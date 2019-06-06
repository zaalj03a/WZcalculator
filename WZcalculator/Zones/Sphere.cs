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
            _sphereGraphic = GraphicsHelper.DrawSphere(_dimensions, _sphereGraphic);
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
