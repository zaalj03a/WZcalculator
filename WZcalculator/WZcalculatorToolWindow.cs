using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ABB.Robotics.RobotStudio;
using ABB.Robotics.RobotStudio.Stations;
using WZcalculator;

namespace WZcalculator
{
    public enum ZoneType { Box, Sphere, Cylinder }

    public partial class WZcalculatorToolWindow : UserControl
    {
        private object _lastSelectedMechUnit;
        private System.Timers.Timer _indicateTextCopiedTimer = new System.Timers.Timer(200);

        public WZcalculatorToolWindow()
        {
            InitializeComponent();
            zoneDimensions.SetZoneType(ZoneType.Box);
            zoneDimensions.DimensionsChanged += ZoneDimensionsChanged;
            ProjectObject.ProjectObjectChanged += ProjectObjectChanged;

            RefreshRobotsComboBox();

            if (RobotCombobox.Items.Count > 0)
            {
                // Set the index of the combobox to the first item and select the robot in the 3D view
                RobotCombobox.SelectedIndex = 0;
                Mechanism mech = ((RsMechanicalUnit)RobotCombobox.Items[0]).Mechanism;

                // Only highlight the robot if the stations cointains more than 1 robots
                if (RobotCombobox.Items.Count > 1)
                {
                    Selection.SelectedObjects.Add(mech);
                    _lastSelectedMechUnit = mech;
                }
            }
        }

        private void ProjectObjectChanged(object sender, ProjectObjectChangedEventArgs e)
        {
            if (e.ChangedObject.GetType() == typeof(Mechanism))
            {
                if (e.ChangeType == ProjectObjectChangeType.Transform)
                {
                    if (RobotCombobox.SelectedItem != null)
                    {
                        // Recreate the zone with the updated transform
                        RsMechanicalUnit selectedMechUnit = RobotCombobox.SelectedItem as RsMechanicalUnit;
                        zoneDimensions.GetCurrentZone().DrawZone(selectedMechUnit);
                        InstructionRichTextBox.Text = zoneDimensions.GetCurrentZone().CreateRapidZone(selectedMechUnit);
                    }
                }
            }
        }

        private void ZoneDimensionsChanged(object sender, ZoneDimensions.DimensionsChangedEventArgs args)
        {
            if (RobotCombobox.SelectedItem != null)
            {

                if (!(RobotCombobox.SelectedItem is RsMechanicalUnit mechUnit))
                {
                    Logger.AddMessage("Selected mechanical unit is invalid", LogMessageSeverity.Error);
                    return;
                }
                args.zone.DrawZone(mechUnit);
                InstructionRichTextBox.Text = args.zone.CreateRapidZone(mechUnit);
            }
            else
            {
                Logger.AddMessage("WZcalculator: Invalid selection", true);
            }

            if (args?.oldZone != null)
            {
                args.oldZone.DeleteZone();
            }
           
        }

        private void RadioButtonCheckChanged(object sender, EventArgs e)
        {
            if (BoxRadioButton.Checked)
            {
                zoneDimensions.SetZoneType(ZoneType.Box);
            }
            else if (SphereRadioButton.Checked)
            {
                zoneDimensions.SetZoneType(ZoneType.Sphere);
            }
            else if (CylinderRadioButton.Checked)
            {
                zoneDimensions.SetZoneType(ZoneType.Cylinder);
            }
        }

        private void RobotCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RobotCombobox.SelectedItem != null)
            {
                if (_lastSelectedMechUnit != null) Selection.SelectedObjects.Remove(_lastSelectedMechUnit);

                RsMechanicalUnit mech = RobotCombobox.SelectedItem as RsMechanicalUnit;

                // Recreate the zone with the new robot
                zoneDimensions.GetCurrentZone().DrawZone(mech);
                InstructionRichTextBox.Text = zoneDimensions.GetCurrentZone().CreateRapidZone(mech);
                
                // Only highlight the robot if the stations cointains more than 1 robots
                if (RobotCombobox.Items.Count > 1)
                {
                    Selection.SelectedObjects.Add(mech.Mechanism);
                    _lastSelectedMechUnit = mech.Mechanism;
                }
            }
        }


        protected override void Dispose(bool disposing)
        {
            zoneDimensions.GetCurrentZone().DeleteZone();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void RobotCombobox_Click(object sender, EventArgs e)
        {
            RefreshRobotsComboBox();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            InstructionRichTextBox.SelectAll();
            InstructionRichTextBox.Copy();
            InstructionRichTextBox.DeselectAll();

            InstructionRichTextBox.BackColor = Color.Green;
            _indicateTextCopiedTimer.SynchronizingObject = this;
            _indicateTextCopiedTimer.Elapsed += delegate
            {
                InstructionRichTextBox.BackColor = DefaultBackColor;
            };
            _indicateTextCopiedTimer.AutoReset = false;
            _indicateTextCopiedTimer.Start();
        }

        private void RefreshRobotsComboBox()
        {
            List<RsMechanicalUnit> mechUnitsInStation = new List<RsMechanicalUnit>();

            // Find applicable MechanicalUnits in the station and add them to the collection
            foreach (RsIrc5Controller controller in Station.ActiveStation.Irc5Controllers.Cast<RsIrc5Controller>())
            {
                for (int i = 0; i < (controller?.MechanicalUnits?.Count ?? 0); i++)
                {
                    if (controller.MechanicalUnits[i].MechanicalUnitType == MechanicalUnitType.TCPRobot)
                    {
                        mechUnitsInStation.Add(controller.MechanicalUnits[i]);
                    }
                }
            }

            // Newly added robots are added to the combo box
            if (mechUnitsInStation.Count > 0)
            {
                foreach (RsMechanicalUnit mechUnit in mechUnitsInStation)
                {
                    if (!RobotCombobox.Items.Contains(mechUnit))
                    {
                        RobotCombobox.Items.Add(mechUnit);
                    }
                }
            }

            // Robots that no longer exist in the station are removed also removed from the combobox
            for (int i = 0; i < RobotCombobox.Items.Count; i++)
            {
                if (!mechUnitsInStation.Contains(RobotCombobox.Items[i]))
                {
                    RobotCombobox.Items.RemoveAt(i);
                }
            }
        }
    }
}
