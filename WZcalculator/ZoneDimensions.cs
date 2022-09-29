﻿using System;
using System.Windows.Forms;
using ABB.Robotics.Math;
using WZcalculator.Zones;
using WZcalculator.Interfaces;

namespace WZcalculator
{
    /// <summary>
    /// Manages the UI for zone dimensions and converts the input into POCOs.
    /// </summary>
    public partial class ZoneDimensions : UserControl
    {
        private Box _box = new Box();
        private Sphere _sphere = new Sphere();
        private Cylinder _cylinder = new Cylinder();
        private ZoneType _currentZoneType;
        private IZone _oldZone;

        public ZoneDimensions()
        {
            InitializeComponent();
        }

        #region Public methods
        /// <summary>
        /// The UI is configured to match the zone type
        /// </summary>
        /// <param name="zoneType"></param>
        public void SetZoneType(ZoneType zoneType)
        {
            // Events are disabled when modifying controls to prevent unwanted callbacks.
            WZ_PositionControl.ValueChanged -= ControlValueChanged;
            Property1Numeric.ValueChanged -= ControlValueChanged;
            Property2Numeric.ValueChanged -= ControlValueChanged;
            Property3Numeric.ValueChanged -= ControlValueChanged;

            // Store the old zone if the current zone is changed
            if (_currentZoneType != zoneType)
            {
                _oldZone = GetCurrentZone();
            }
            _currentZoneType = zoneType ; 
             
            switch (zoneType)
            {
                case ZoneType.Box:
                    // All controls are used for box type
                    Property1Label.Text = "Length (mm)";
                    Property2Label.Text = "Width (mm)";
                    Property3Label.Text = "Height (mm)";

                    Property1Numeric.Visible = true;
                    Property2Numeric.Visible = true;
                    Property3Numeric.Visible = true;

                    Box.BoxDimensions boxDimensions = (Box.BoxDimensions)_box.GetDimensions();

                    // Apply default values if necessarry.
                    if (boxDimensions.Length == 0) boxDimensions.Length  = 1000;
                    if (boxDimensions.Width == 0) boxDimensions.Width  = 1000;
                    if (boxDimensions.Height == 0) boxDimensions.Height  = 1000;

                    Property1Numeric.Value = boxDimensions.Length;
                    Property2Numeric.Value = boxDimensions.Width;
                    Property3Numeric.Value = boxDimensions.Height;

                    // Apply the stored values for position
                    WZ_PositionControl.Value = new Vector3(boxDimensions.x, boxDimensions.y, boxDimensions.z);

                    // Save the updated dimensions
                    _box.SetDimensions(boxDimensions);
                    break;
                case ZoneType.Sphere:
                    // Only Property1Numeric are used for sphere type
                    Property1Label.Text = "Radius (mm)";
                    Property2Label.Text = "";
                    Property3Label.Text = "";

                    Property1Numeric.Visible = true;
                    Property2Numeric.Visible = false;
                    Property3Numeric.Visible = false;


                    Sphere.SphereDimensions sphereDimensions = (Sphere.SphereDimensions)_sphere.GetDimensions();

                    // Apply default values if necessarry.
                    if (sphereDimensions.Radius == 0) sphereDimensions.Radius = 500;

                    Property1Numeric.Value = sphereDimensions.Radius;

                    // Apply the stored values for position
                    WZ_PositionControl.Value = new Vector3(sphereDimensions.x, sphereDimensions.y, sphereDimensions.z);

                    // Save the updated dimensions
                    _sphere.SetDimensions(sphereDimensions);

                    break;
                case ZoneType.Cylinder:
                    // Only Property1Numeric and Property2Numeric are used for cylinder type
                    Property1Label.Text = "Radius (mm)";
                    Property2Label.Text = "Height (mm)";
                    Property3Label.Text = "";

                    Property1Numeric.Visible = true;
                    Property2Numeric.Visible = true;
                    Property3Numeric.Visible = false;

                    Cylinder.CylinderDimensions cylinderDimensions = (Cylinder.CylinderDimensions)_cylinder.GetDimensions();

                    // Apply default values if necessarry.
                    if (cylinderDimensions.Radius == 0) cylinderDimensions.Radius = 500;
                    if (cylinderDimensions.Height == 0) cylinderDimensions.Height = 1000;

                    Property1Numeric.Value = cylinderDimensions.Radius;
                    Property2Numeric.Value = cylinderDimensions.Height;

                    // Apply the stored values for position
                    WZ_PositionControl.Value = new Vector3(cylinderDimensions.x, cylinderDimensions.y, cylinderDimensions.z);

                    // Save the updated dimensions
                    _cylinder.SetDimensions(cylinderDimensions);
                    break;
                default:
                    break;
            }

            // Re-enable events.
            WZ_PositionControl.ValueChanged += ControlValueChanged;
            Property1Numeric.ValueChanged += ControlValueChanged;
            Property2Numeric.ValueChanged += ControlValueChanged;
            Property3Numeric.ValueChanged += ControlValueChanged;

            // Raise the dimensions changed event
            RaiseDimensionsChangedEvent();
        }

        /// <summary>
        /// Returns the active zone.
        /// </summary>
        /// <returns>The active zone</returns>
        public IZone GetCurrentZone()
        {
            switch (_currentZoneType)
            {
                case ZoneType.Box:
                    return _box;
                case ZoneType.Sphere:
                    return _sphere;
                case ZoneType.Cylinder:
                    return _cylinder;
                default:
                    return null;
            }
        }
        #endregion

        #region Events

        public delegate void OnDimensionsChanged(object sender, DimensionsChangedEventArgs e);

        /// <summary>
        /// Raised when the dimensions or zone type is changed.
        /// </summary>
        public event OnDimensionsChanged DimensionsChanged;

        public class DimensionsChangedEventArgs : EventArgs
        {
            public IZone zone;
            public IZone oldZone;
        }

        private void RaiseDimensionsChangedEvent()
        {
            if (DimensionsChanged == null) return;
            DimensionsChangedEventArgs args = new DimensionsChangedEventArgs()
            {
                zone = GetCurrentZone(),
                oldZone = _oldZone
            };

            DimensionsChanged(this, args);
        }

        private void ControlValueChanged(object sender, EventArgs e)
        {
            // Store the values
            switch (_currentZoneType)
            {
                case ZoneType.Box:
                    Box.BoxDimensions boxDimensions = (Box.BoxDimensions)_box.GetDimensions();
                    boxDimensions.x = WZ_PositionControl.Value.x;
                    boxDimensions.y = WZ_PositionControl.Value.y;
                    boxDimensions.z = WZ_PositionControl.Value.z;

                    boxDimensions.Length = Property1Numeric.Value;
                    boxDimensions.Width = Property2Numeric.Value;
                    boxDimensions.Height = Property3Numeric.Value;
                    _box.SetDimensions(boxDimensions);
                    break;
                case ZoneType.Sphere:
                    Sphere.SphereDimensions sphereDimensions = (Sphere.SphereDimensions)_sphere.GetDimensions();
                    sphereDimensions.x = WZ_PositionControl.Value.x;
                    sphereDimensions.y = WZ_PositionControl.Value.y;
                    sphereDimensions.z = WZ_PositionControl.Value.z;
                    sphereDimensions.Radius = Property1Numeric.Value;

                    _sphere.SetDimensions(sphereDimensions);
                    break;
                case ZoneType.Cylinder:
                    Cylinder.CylinderDimensions cylinderDimensions = (Cylinder.CylinderDimensions)_cylinder.GetDimensions();
                    cylinderDimensions.x = WZ_PositionControl.Value.x;
                    cylinderDimensions.y = WZ_PositionControl.Value.y;
                    cylinderDimensions.z = WZ_PositionControl.Value.z;

                    cylinderDimensions.Radius = Property1Numeric.Value;
                    cylinderDimensions.Height = Property2Numeric.Value;

                    _cylinder.SetDimensions(cylinderDimensions);
                    break;
                default:
                    break;
            }

            // Raise the event
            RaiseDimensionsChangedEvent();
        }
        #endregion

    }
}
