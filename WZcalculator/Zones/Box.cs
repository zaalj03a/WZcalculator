using ABB.Robotics.RobotStudio.Stations.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZcalculator.Interfaces;
using WZcalculator.Helpers;
using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.Math;
using System.Globalization;
using ABB.Robotics.RobotStudio.Environment;
using WZcalculator.Helpers;

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
            _boxGraphic = GraphicsHelper.DrawAlignedBox(mechanicalUnit, _dimensions, _boxGraphic);
        }

        public object GetDimensions()
        {
            return _dimensions;
        }

        public void SetDimensions(object dimensions)
        {
            if (dimensions.GetType() != typeof(BoxDimensions))
            {
                throw new Exception("Cannot set dimensions of box, expected type is " + nameof(BoxDimensions));
            }

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
