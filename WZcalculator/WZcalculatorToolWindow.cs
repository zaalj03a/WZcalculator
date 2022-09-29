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

            // Find all robots in the station and add them to the combobox
            foreach (RsIrc5Controller controller in Station.ActiveStation.Irc5Controllers)
            {
                foreach (RsMechanicalUnit mech in controller.MechanicalUnits)
                {
                    RobotCombobox.Items.Add(mech);
                }
            }

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
                RsMechanicalUnit mechUnit = RobotCombobox.SelectedItem as RsMechanicalUnit;

                args.zone.DrawZone(mechUnit);
                args.oldZone?.DeleteZone();
                InstructionRichTextBox.Text = args.zone.CreateRapidZone(mechUnit);
            }
            else
            {
                Logger.AddMessage("WZcalculator: Invalid selection", true);
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
            List<RsMechanicalUnit> mechUnitsInStation = new List<RsMechanicalUnit>();

            // Find all MechanicalUnits in the station and add them to the combo box
            foreach (RsIrc5Controller controller in Station.ActiveStation.Irc5Controllers)
            {
                for (int i = 0; i < controller.MechanicalUnits.Count; i++)
                {
                    mechUnitsInStation.Add(controller.MechanicalUnits[i]);
                }
            }

            // Find new robots that do not exist in the combobox item collection and add them
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

            // Find robots that have been removed from the station and remove them from the combobox item collection
            for (int i = 0; i < RobotCombobox.Items.Count; i++)
            {
                if (!mechUnitsInStation.Contains(RobotCombobox.Items[i]))
                {
                    RobotCombobox.Items.RemoveAt(i);
                }
            }
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

    }
}
