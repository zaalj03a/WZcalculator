using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Robotics.Math;
using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.RobotStudio.Stations.Forms;
using WZcalculator.Helpers;
using WZcalculator.Interfaces;

namespace WZcalculator.Zones
{
    public class Sphere : IZone
    {
        public struct SphereDimensions
        {
            public double x;
            public double y;
            public double z;

            public decimal Radius;
        }

        private SphereDimensions _dimensions;
        private TemporaryGraphic _sphereGraphic;

        public string CreateRapidZone(RsMechanicalUnit mechanicalUnit)
        {
            if (_sphereGraphic == null) return "";

            // Transform the position of the sphere to the robots coordinate system
            Vector3 sphereVector = _sphereGraphic.Matrix.Translation.TransformPoint(Station.ActiveStation.Transform.GlobalMatrix, mechanicalUnit.BaseFrame.GlobalMatrix);

            // Build the rapid string
            string rapidZone = "[";

            rapidZone += (sphereVector.x * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (sphereVector.y * 1000).ToString("0.00", CultureInfo.InvariantCulture) + ",";
            rapidZone += (sphereVector.z * 1000).ToString("0.00", CultureInfo.InvariantCulture) + "],";
            rapidZone += _dimensions.Radius;

            return rapidZone;
        }

        public void DeleteZone()
        {
            GraphicsHelper.DeleteTemporaryGraphic(_sphereGraphic);
        }

        public void DrawZone(RsMechanicalUnit mechanicalUnit)
        {
            // Draw a part that cointaions a body (sphere)
            Part part = new Part();
            Body sphere = Body.CreateSolidSphere(new Vector3(), Decimal.ToDouble(_dimensions.Radius / 1000));
            sphere.Color = System.Drawing.Color.Purple;
            part.Bodies.Add(sphere);

            // Drawing a temporary graphic requires it to be present in the station, therefore the part is added prior to it being drawn as a temorary graphic
            // then immedietely removed from the station
            Matrix4 spherePosition = new Matrix4(new Vector3(_dimensions.x, _dimensions.y, _dimensions.z));
            Station.ActiveStation.GraphicComponents.Add(part);
            TemporaryGraphic tg = Station.ActiveStation.TemporaryGraphics.DrawPart(spherePosition, part, 0.3);
            Station.ActiveStation.GraphicComponents.Remove(part);

            if (_sphereGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(_sphereGraphic);
                _sphereGraphic.Delete();
            }

            _sphereGraphic = tg;
        }

        public object GetDimensions()
        {
            return _dimensions;
        }

        public ZoneType GetZoneType()
        {
            return ZoneType.Sphere;
        }

        public void SetDimensions(object dimensions)
        {
            _dimensions = (SphereDimensions)dimensions;
        }
    }
}
