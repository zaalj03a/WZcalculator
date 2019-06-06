namespace WZcalculator
{
    partial class ZoneDimensions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Property2Numeric = new System.Windows.Forms.NumericUpDown();
            this.Property3Numeric = new System.Windows.Forms.NumericUpDown();
            this.Property3Label = new System.Windows.Forms.Label();
            this.Property2Label = new System.Windows.Forms.Label();
            this.Property1Label = new System.Windows.Forms.Label();
            this.Property1Numeric = new System.Windows.Forms.NumericUpDown();
            this.WZ_PositionControl = new ABB.Robotics.RobotStudio.Stations.Forms.PositionControl();
            this.PositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).BeginInit();
            this.WZ_PositionControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Property2Numeric
            // 
            this.Property2Numeric.Location = new System.Drawing.Point(81, 60);
            this.Property2Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property2Numeric.Name = "Property2Numeric";
            this.Property2Numeric.Size = new System.Drawing.Size(72, 20);
            this.Property2Numeric.TabIndex = 10;
            this.Property2Numeric.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // Property3Numeric
            // 
            this.Property3Numeric.Location = new System.Drawing.Point(157, 60);
            this.Property3Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property3Numeric.Name = "Property3Numeric";
            this.Property3Numeric.Size = new System.Drawing.Size(72, 20);
            this.Property3Numeric.TabIndex = 13;
            this.Property3Numeric.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // Property3Label
            // 
            this.Property3Label.AutoSize = true;
            this.Property3Label.Location = new System.Drawing.Point(154, 44);
            this.Property3Label.Name = "Property3Label";
            this.Property3Label.Size = new System.Drawing.Size(38, 13);
            this.Property3Label.TabIndex = 12;
            this.Property3Label.Text = "Height";
            // 
            // Property2Label
            // 
            this.Property2Label.AutoSize = true;
            this.Property2Label.Location = new System.Drawing.Point(78, 44);
            this.Property2Label.Name = "Property2Label";
            this.Property2Label.Size = new System.Drawing.Size(35, 13);
            this.Property2Label.TabIndex = 11;
            this.Property2Label.Text = "Width";
            // 
            // Property1Label
            // 
            this.Property1Label.AutoSize = true;
            this.Property1Label.Location = new System.Drawing.Point(5, 44);
            this.Property1Label.Name = "Property1Label";
            this.Property1Label.Size = new System.Drawing.Size(40, 13);
            this.Property1Label.TabIndex = 9;
            this.Property1Label.Text = "Length";
            this.Property1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Property1Numeric
            // 
            this.Property1Numeric.Location = new System.Drawing.Point(3, 60);
            this.Property1Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property1Numeric.Name = "Property1Numeric";
            this.Property1Numeric.Size = new System.Drawing.Size(72, 20);
            this.Property1Numeric.TabIndex = 8;
            this.Property1Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property1Numeric.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // WZ_PositionControl
            // 
            this.WZ_PositionControl.Controls.Add(this.PositionLabel);
            this.WZ_PositionControl.ErrorProviderControl = null;
            this.WZ_PositionControl.ExpressionErrorString = "Bad Expression";
            this.WZ_PositionControl.LabelQuantity = ABB.Robotics.RobotStudio.BuiltinQuantity.None;
            this.WZ_PositionControl.LabelText = null;
            this.WZ_PositionControl.Location = new System.Drawing.Point(3, 3);
            this.WZ_PositionControl.MaxValueErrorString = "Value exceeds maximum";
            this.WZ_PositionControl.MinValueErrorString = "Value is below minimum";
            this.WZ_PositionControl.Name = "WZ_PositionControl";
            this.WZ_PositionControl.NumTextBoxes = 3;
            this.WZ_PositionControl.ReadOnly = false;
            this.WZ_PositionControl.RefCoordSys = null;
            this.WZ_PositionControl.ShowLabel = true;
            this.WZ_PositionControl.Size = new System.Drawing.Size(229, 34);
            this.WZ_PositionControl.TabIndex = 7;
            this.WZ_PositionControl.Text = "positionControl1";
            this.WZ_PositionControl.VerticalLayout = false;
            this.WZ_PositionControl.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(0, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 14;
            this.PositionLabel.Text = "Position";
            // 
            // ZoneDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WZ_PositionControl);
            this.Controls.Add(this.Property2Numeric);
            this.Controls.Add(this.Property3Numeric);
            this.Controls.Add(this.Property3Label);
            this.Controls.Add(this.Property2Label);
            this.Controls.Add(this.Property1Label);
            this.Controls.Add(this.Property1Numeric);
            this.Name = "ZoneDimensions";
            this.Size = new System.Drawing.Size(235, 88);
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).EndInit();
            this.WZ_PositionControl.ResumeLayout(false);
            this.WZ_PositionControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Property2Numeric;
        private System.Windows.Forms.NumericUpDown Property3Numeric;
        private System.Windows.Forms.Label Property3Label;
        private System.Windows.Forms.Label Property2Label;
        private System.Windows.Forms.Label Property1Label;
        private System.Windows.Forms.NumericUpDown Property1Numeric;
        private ABB.Robotics.RobotStudio.Stations.Forms.PositionControl WZ_PositionControl;
        private System.Windows.Forms.Label PositionLabel;
    }
}
