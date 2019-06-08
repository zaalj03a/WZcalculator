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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).BeginInit();
            this.WZ_PositionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Property2Numeric
            // 
            this.Property2Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Property2Numeric.Location = new System.Drawing.Point(3, 16);
            this.Property2Numeric.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.Property2Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property2Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property2Numeric.Name = "Property2Numeric";
            this.Property2Numeric.Size = new System.Drawing.Size(91, 20);
            this.Property2Numeric.TabIndex = 10;
            this.Property2Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property2Numeric.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // Property3Numeric
            // 
            this.Property3Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Property3Numeric.Location = new System.Drawing.Point(3, 17);
            this.Property3Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property3Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property3Numeric.Name = "Property3Numeric";
            this.Property3Numeric.Size = new System.Drawing.Size(82, 20);
            this.Property3Numeric.TabIndex = 13;
            this.Property3Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property3Numeric.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // Property3Label
            // 
            this.Property3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Property3Label.AutoSize = true;
            this.Property3Label.Location = new System.Drawing.Point(3, 2);
            this.Property3Label.Name = "Property3Label";
            this.Property3Label.Size = new System.Drawing.Size(38, 13);
            this.Property3Label.TabIndex = 12;
            this.Property3Label.Text = "Height";
            // 
            // Property2Label
            // 
            this.Property2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Property2Label.AutoSize = true;
            this.Property2Label.Location = new System.Drawing.Point(3, 2);
            this.Property2Label.Name = "Property2Label";
            this.Property2Label.Size = new System.Drawing.Size(35, 13);
            this.Property2Label.TabIndex = 11;
            this.Property2Label.Text = "Width";
            // 
            // Property1Label
            // 
            this.Property1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Property1Label.AutoSize = true;
            this.Property1Label.Location = new System.Drawing.Point(3, 2);
            this.Property1Label.Name = "Property1Label";
            this.Property1Label.Size = new System.Drawing.Size(40, 13);
            this.Property1Label.TabIndex = 9;
            this.Property1Label.Text = "Length";
            this.Property1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Property1Numeric
            // 
            this.Property1Numeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Property1Numeric.Location = new System.Drawing.Point(3, 16);
            this.Property1Numeric.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.Property1Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property1Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Property1Numeric.Name = "Property1Numeric";
            this.Property1Numeric.Size = new System.Drawing.Size(88, 20);
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
            this.WZ_PositionControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.WZ_PositionControl.Size = new System.Drawing.Size(289, 34);
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
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Property1Numeric);
            this.splitContainer1.Panel1.Controls.Add(this.Property1Label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(289, 40);
            this.splitContainer1.SplitterDistance = 95;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Property2Numeric);
            this.splitContainer2.Panel1.Controls.Add(this.Property2Label);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Property3Numeric);
            this.splitContainer2.Panel2.Controls.Add(this.Property3Label);
            this.splitContainer2.Size = new System.Drawing.Size(190, 40);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 0;
            // 
            // ZoneDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.WZ_PositionControl);
            this.Name = "ZoneDimensions";
            this.Size = new System.Drawing.Size(295, 95);
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).EndInit();
            this.WZ_PositionControl.ResumeLayout(false);
            this.WZ_PositionControl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}
