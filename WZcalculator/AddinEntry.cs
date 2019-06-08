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
        private const string MAIN_WINDOW_ID = "WZcalculator.MainWindow";
        private const string OPEN_BUTTON_ID = "WZcalculator.OpenButton";

        public static void AddinMain()
        {
            CommandBarButton.FromID("WZcalculator.OpenButton").ExecuteCommand += OpenButtonClicked;
            Project.ActiveProjectChanged += Project_ActiveProjectChanged;
        }

        private static void Project_ActiveProjectChanged(object sender, EventArgs e)
        {
            CloseMainWindow();
        }

        private static void OpenButtonClicked(object sender, ExecuteCommandEventArgs e)
        {
            if (Station.ActiveStation == null) return;

            // Create a toolwindow that contains the WZcalculator UserControl and add it to the enviroment.
            ToolWindow toolWindow = new ToolWindow(MAIN_WINDOW_ID, new WZcalculatorToolWindow(), "WZcalculator");
            toolWindow.Closed += MainWindowClosed;
            toolWindow.ActiveTab = true;
            toolWindow.CloseButtonBehavior = CloseButtonBehavior.Close;

            UIEnvironment.Windows.AddDocked(toolWindow, System.Windows.Forms.DockStyle.Left);

            // Disable the Open button
            CommandBarButton.FromID(OPEN_BUTTON_ID).DefaultEnabled = false;

        }

        private static void MainWindowClosed(object sender, EventArgs e)
        {
            // Re-enable the button
            CommandBarButton.FromID("WZcalculator.OpenButton").DefaultEnabled = true;
        }

        private static void CloseMainWindow()
        {
            // Find and close the tabbed toolwindow 
            if (UIEnvironment.Windows.FindWindows(w => (w.Id ?? "").Equals(MAIN_WINDOW_ID)).Length > 0)
            {
                UIEnvironment.Windows[OPEN_BUTTON_ID].Close();
            }
        }
    }
}