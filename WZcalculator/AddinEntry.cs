using System;
using System.Collections.Generic;
using System.Text;
using ABB.Robotics.Math;
using ABB.Robotics.RobotStudio;
using ABB.Robotics.RobotStudio.Environment;
using ABB.Robotics.RobotStudio.Stations;
using WZcalculator;
namespace WZcalculator
{
    public class AddinEntry
    {
        private static WZcalculatorToolWindow _window;
        public static void AddinMain()
        {
            CommandBarButton.FromID("WZcalculator.OpenButton").ExecuteCommand += OpenButtonClicked;
        }

        private static void OpenButtonClicked(object sender, ExecuteCommandEventArgs e)
        {
            // Create a toolwindow that contains the WZcalculator UserControl and add it to the enviroment.
            _window = new WZcalculatorToolWindow();
            ToolWindow toolWindow = new ToolWindow("WZcalculator.MainWindow", _window, "WZcalculator");
            toolWindow.Closed += MainWindowClosed;
            toolWindow.ActiveTab = true;
            toolWindow.CloseButtonBehavior = CloseButtonBehavior.Close;

            UIEnvironment.Windows.AddDocked(toolWindow, System.Windows.Forms.DockStyle.Left);

            // Disable the Open button
            CommandBarButton.FromID("WZcalculator.OpenButton").DefaultEnabled = false;

        }

        private static void MainWindowClosed(object sender, EventArgs e)
        {
            // Dispose of the user control
            _window.Dispose();
            _window = null;
            // Re-enable the button.
            CommandBarButton.FromID("WZcalculator.OpenButton").DefaultEnabled = true;

        }
    }
}