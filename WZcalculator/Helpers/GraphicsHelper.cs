using ABB.Robotics.RobotStudio.Stations;
using ABB.Robotics.RobotStudio.Stations.Forms;
using System.Drawing;

namespace WZcalculator.Helpers
{
    public class GraphicsHelper
    {
        public static void DeleteTemporaryGraphic(TemporaryGraphic temporaryGraphic)
        {
            if (temporaryGraphic == null) return;
            Station.ActiveStation.TemporaryGraphics.Remove(temporaryGraphic);
        }
    }
}
