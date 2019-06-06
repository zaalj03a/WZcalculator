using ABB.Robotics.Math;
using ABB.Robotics.RobotStudio.Environment;
using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.RobotStudio.Stations.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WZcalculator.Zones;

namespace WZcalculator.Helpers
{
    public class GraphicsHelper
    {
        /// <summary>
        /// Draws a box that is aligned to the base frame of the mechanical unit
        /// </summary>
        /// <param name="mechanicalUnit">The mechanical unit which the box is aligned to</param>
        /// <param name="dimensions">The dimensions of the box and its position in the 3D enviroment</param>
        /// <param name="oldGraphic">The old temporary graphic which will be replaced</param>
        /// <returns>The newly created temporary graphic</returns>
        public static TemporaryGraphic DrawAlignedBox(RsMechanicalUnit mechanicalUnit, Box.BoxDimensions dimensions, TemporaryGraphic oldGraphic)
        {
            // Find the orientation of the robot base frame
            Vector3 orientationVector = mechanicalUnit.BaseFrame.GlobalMatrix.EulerZYX;

            // Create a Matrix4 with the same orientation as the robot base frame and the translation of the first corner of the box
            Vector3 boxTranslation = new Vector3(dimensions.x, dimensions.y, dimensions.z);
            Matrix4 boxPosition = new Matrix4(boxTranslation, orientationVector);

            // Create a Vector3 that contains the dimensions
            Vector3 dimensionVector = new Vector3()
            {
                x = Decimal.ToDouble(dimensions.Length) / 1000,
                y = Decimal.ToDouble(dimensions.Width) / 1000 ,
                z = Decimal.ToDouble(dimensions.Height) / 1000
            };

            // Draw a part that contains a box (body)
            Part part = new Part();
            Body box = Body.CreateSolidBox(new Matrix4(new Vector3()), dimensionVector);
            box.Color = System.Drawing.Color.Purple;
            part.Bodies.Add(box);

            // Drawing a temporary graphic requires it to be present in the station, therefore the part is added prior to it being drawn as a temorary graphic
            // then immedietely removed from the station
            Station.ActiveStation.GraphicComponents.Add(part);
            TemporaryGraphic tg = Station.ActiveStation.TemporaryGraphics.DrawPart(boxPosition, part, 0.3d);
            Station.ActiveStation.GraphicComponents.Remove(part);

            if (oldGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(oldGraphic);
                oldGraphic.Delete();
            }

            return tg;
        }

        /// <summary>
        /// Draws a sphere
        /// </summary>
        /// <param name="dimensions">The dimensions of the sphere and its position in the 3D enviroment</param>
        /// <param name="oldGraphic">The old temporary graphic which will replaced</param>
        /// <returns>The newly created temporary graphic</returns>
        public static TemporaryGraphic DrawSphere(Sphere.SphereDimensions dimensions, TemporaryGraphic oldGraphic)
        {
            Part part = new Part();
            Body sphere = Body.CreateSolidSphere(new Vector3(), Decimal.ToDouble(dimensions.Radius / 1000));
            sphere.Color = System.Drawing.Color.Purple;
            part.Bodies.Add(sphere);

            // Drawing a temporary graphic requires it to be present in the station, therefore the part is added prior to it being drawn as a temorary graphic
            // then immedietely removed from the station
            Matrix4 spherePosition = new Matrix4(new Vector3(dimensions.x, dimensions.y, dimensions.z));
            Station.ActiveStation.GraphicComponents.Add(part);
            TemporaryGraphic tg = Station.ActiveStation.TemporaryGraphics.DrawPart(spherePosition, part, 0.3d);
            Station.ActiveStation.GraphicComponents.Remove(part);

            if (oldGraphic != null)
            {
                Station.ActiveStation.TemporaryGraphics.Remove(oldGraphic);
                oldGraphic.Delete();
            }

            return tg;
        }

        public static void DeleteTemporaryGraphic(TemporaryGraphic temporaryGraphic)
        {
            if (temporaryGraphic == null) return;
            Station.ActiveStation.TemporaryGraphics.Remove(temporaryGraphic);
        }
    }
}
