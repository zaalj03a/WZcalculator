using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.RobotStudio.Stations.Forms;
using WZcalculator.Interfaces;
using ABB.Robotics.Math;
using System.Globalization;
using System;

namespace WZcalculator.Zones
{
    public class Cylinder : IZone
    {
        public struct CylinderDimensions
        {
            public double x;
            public double y;
            public double z;

            public decimal Radius;
            public decimal Height;
        }

        private CylinderDimensions _dimensions;
        private TemporaryGraphic _CylinderGraphic;

        public string CreateRapidZone(RsMechanicalUnit mechanicalUnit)
        {
            if (_CylinderGraphic == null) return "";

            // Transform cylinder position to the robots coordinate system
            Vector3 transformedVector = new Vector3(_dimensions.x, _dimensions.y, _dimensions.z);
            transformedVector = transformedVector.TransformPoint(Station.ActiveStation.Transform.GlobalMatrix, mechanicalUnit.BaseFrame.GlobalMatrix);

            // Zone is declared as [x,y,z,R,H] where R is radius in mm and H is height in mm
            string rapidZone = "[";

            rapidZone += (transformedVector.x * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (transformedVector.y * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (transformedVector.z * 1000).ToString("0.00", CultureInfo.InvariantCulture) + "],";

            rapidZone += _dimensions.Radius + ",";
            rapidZone += _dimensions.Height;

            return rapidZone;
        }

        public void DeleteZone()
        {
            if (Station.ActiveStation != null && _CylinderGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(_CylinderGraphic);
            }    
        }

        public void DrawZone(RsMechanicalUnit mechanicalUnit)
        {
            // Draw a part that cointaions a body (cylinder)
            Part part = new Part();
            Body cylinder = Body.CreateSolidCylinder(new Matrix4(new Vector3()), Decimal.ToDouble(_dimensions.Radius / 1000), Decimal.ToDouble(_dimensions.Height / 1000));
            cylinder.Color = System.Drawing.Color.Purple;
            part.Bodies.Add(cylinder);

            // Get the base frame and modify only the translation part, this way the cylinder orientation is the same as the robots orientation
            Matrix4 cylinderMatrix = mechanicalUnit.BaseFrame.GlobalMatrix;
            cylinderMatrix.Translation = new Vector3(_dimensions.x, _dimensions.y, _dimensions.z);

            // Drawing a temporary graphic requires it to be present in the station, therefore the part is added prior to it being drawn as a temorary graphic
            // then immedietely removed from the station
            Station.ActiveStation.GraphicComponents.Add(part);
            TemporaryGraphic tg = Station.ActiveStation.TemporaryGraphics.DrawPart(cylinderMatrix, part, 0.3d);
            Station.ActiveStation.GraphicComponents.Remove(part);

            if (_CylinderGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(_CylinderGraphic);
                _CylinderGraphic.Delete();
            }

            _CylinderGraphic = tg;
        }

        public object GetDimensions()
        {
            return _dimensions;
        }

        public ZoneType GetZoneType()
        {
            return ZoneType.Cylinder;
        }

        public void SetDimensions(object dimensions)
        {
            _dimensions = (CylinderDimensions)dimensions;
        }
    }
}
