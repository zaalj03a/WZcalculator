using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.RobotStudio.Stations.Forms;
using WZcalculator.Interfaces;
using WZcalculator.Helpers;
using ABB.Robotics.Math;
using System.Globalization;

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
            GraphicsHelper.DeleteTemporaryGraphic(_CylinderGraphic);
        }

        public void DrawZone(RsMechanicalUnit mechanicalUnit)
        {
            _CylinderGraphic = GraphicsHelper.DrawAlignedCylinder(mechanicalUnit, _dimensions, _CylinderGraphic);
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
