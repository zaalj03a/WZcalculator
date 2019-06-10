using ABB.Robotics.RobotStudio.Stations.Forms;
using System;
using WZcalculator.Interfaces;
using WZcalculator.Helpers;
using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.Math;
using System.Globalization;
using System.Drawing;

namespace WZcalculator.Zones
{
    public class Box : IZone
    {
        public struct BoxDimensions
        {
            public double x;
            public double y;
            public double z;

            public decimal Length;
            public decimal Width;
            public decimal Height;
        }

        private BoxDimensions _dimensions;
        private TemporaryGraphic _boxGraphic;

        public void DeleteZone()
        {
            GraphicsHelper.DeleteTemporaryGraphic(_boxGraphic);
        }

        public void DrawZone(RsMechanicalUnit mechanicalUnit)
        {
            // Find the orientation of the robot base frame
            Vector3 orientationVector = mechanicalUnit.BaseFrame.GlobalMatrix.EulerZYX;

            // Create a Matrix4 with the same orientation as the robot base frame and the translation of the first corner of the box
            Vector3 boxTranslation = new Vector3(_dimensions.x, _dimensions.y, _dimensions.z);
            Matrix4 boxPosition = new Matrix4(boxTranslation, orientationVector);

            // Create a Vector3 that contains the dimensions
            Vector3 dimensionVector = new Vector3()
            {
                x = Decimal.ToDouble(_dimensions.Length) / 1000,
                y = Decimal.ToDouble(_dimensions.Width) / 1000,
                z = Decimal.ToDouble(_dimensions.Height) / 1000
            };

            // Draw a part that contains a box (body)
            Part part = new Part();
            Body box = Body.CreateSolidBox(new Matrix4(new Vector3()), dimensionVector);
            box.Color = Color.Purple;
            part.Bodies.Add(box);

            // Drawing a temporary graphic requires it to be present in the station, therefore the part is added prior to it being drawn as a temorary graphic
            // then immedietely removed from the station
            Station.ActiveStation.GraphicComponents.Add(part);
            TemporaryGraphic tg = Station.ActiveStation.TemporaryGraphics.DrawPart(boxPosition, part, 0.3);
            Station.ActiveStation.GraphicComponents.Remove(part);

            if (_boxGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(_boxGraphic);
                _boxGraphic.Delete();
            }

            _boxGraphic = tg;
        }

        public object GetDimensions()
        {
            return _dimensions;
        }

        public void SetDimensions(object dimensions)
        {
            _dimensions = (BoxDimensions)dimensions;
        }

        public ZoneType GetZoneType()
        {
            return ZoneType.Box;
        }

        public string CreateRapidZone(RsMechanicalUnit mechanicalUnit)
        {
            if (_boxGraphic == null) return "";

            // Get the translation of p1 in world coordinate system
            Matrix4 p1Matrix = _boxGraphic.Matrix;

            // Calculate the translation of p2 in world coordinate system
            Matrix4 p2Matrix = p1Matrix;
            p2Matrix.TranslateLocal(Decimal.ToDouble(_dimensions.Length / 1000), Decimal.ToDouble(_dimensions.Width / 1000), Decimal.ToDouble(_dimensions.Height / 1000));

            // Transform to robot coordinate system
            p1Matrix.Translation = p1Matrix.Translation.TransformPoint(Station.ActiveStation.Transform.GlobalMatrix, mechanicalUnit.BaseFrame.GlobalMatrix);
            p2Matrix.Translation = p2Matrix.Translation.TransformPoint(Station.ActiveStation.Transform.GlobalMatrix, mechanicalUnit.BaseFrame.GlobalMatrix);

            string rapidZone = "[";

            rapidZone += (p1Matrix.Translation.x * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (p1Matrix.Translation.y * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (p1Matrix.Translation.z * 1000).ToString("0.00", CultureInfo.InvariantCulture) + "],[";

            rapidZone += (p2Matrix.Translation.x * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (p2Matrix.Translation.y * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (p2Matrix.Translation.z * 1000).ToString("0.00", CultureInfo.InvariantCulture) + "]";

            return rapidZone;
        }
    }
}
