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
            this.WZ_PositionControl = new ABB.Robotics.RobotStudio.Stations.Forms.PositionControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Property3Label = new System.Windows.Forms.Label();
            this.Property2Label = new System.Windows.Forms.Label();
            this.Property3Numeric = new System.Windows.Forms.NumericUpDown();
            this.Property2Numeric = new System.Windows.Forms.NumericUpDown();
            this.Property1Numeric = new System.Windows.Forms.NumericUpDown();
            this.Property1Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // WZ_PositionControl
            // 
            this.WZ_PositionControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.WZ_PositionControl.Size = new System.Drawing.Size(411, 39);
            this.WZ_PositionControl.TabIndex = 7;
            this.WZ_PositionControl.Text = "positionControl1";
            this.WZ_PositionControl.VerticalLayout = false;
            this.WZ_PositionControl.ValueChanged += new System.EventHandler(this.ControlValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel1.Controls.Add(this.Property3Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Property2Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Property3Numeric, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Property2Numeric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Property1Numeric, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Property1Label, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 40);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Property3Label
            // 
            this.Property3Label.AutoSize = true;
            this.Property3Label.Location = new System.Drawing.Point(275, 0);
            this.Property3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Property3Label.MinimumSize = new System.Drawing.Size(80, 0);
            this.Property3Label.Name = "Property3Label";
            this.Property3Label.Size = new System.Drawing.Size(80, 16);
            this.Property3Label.TabIndex = 11;
            this.Property3Label.Text = "Property3";
            // 
            // Property2Label
            // 
            this.Property2Label.AutoSize = true;
            this.Property2Label.Location = new System.Drawing.Point(138, 0);
            this.Property2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Property2Label.MinimumSize = new System.Drawing.Size(80, 0);
            this.Property2Label.Name = "Property2Label";
            this.Property2Label.Size = new System.Drawing.Size(80, 16);
            this.Property2Label.TabIndex = 10;
            this.Property2Label.Text = "Property2";
            // 
            // Property3Numeric
            // 
            this.Property3Numeric.DecimalPlaces = 3;
            this.Property3Numeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Property3Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Property3Numeric.Location = new System.Drawing.Point(273, 18);
            this.Property3Numeric.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Property3Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property3Numeric.MinimumSize = new System.Drawing.Size(4, 0);
            this.Property3Numeric.Name = "Property3Numeric";
            this.Property3Numeric.Size = new System.Drawing.Size(138, 22);
            this.Property3Numeric.TabIndex = 13;
            this.Property3Numeric.ThousandsSeparator = true;
            // 
            // Property2Numeric
            // 
            this.Property2Numeric.DecimalPlaces = 3;
            this.Property2Numeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Property2Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Property2Numeric.Location = new System.Drawing.Point(136, 18);
            this.Property2Numeric.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Property2Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property2Numeric.MinimumSize = new System.Drawing.Size(4, 0);
            this.Property2Numeric.Name = "Property2Numeric";
            this.Property2Numeric.Size = new System.Drawing.Size(137, 22);
            this.Property2Numeric.TabIndex = 12;
            this.Property2Numeric.ThousandsSeparator = true;
            // 
            // Property1Numeric
            // 
            this.Property1Numeric.DecimalPlaces = 3;
            this.Property1Numeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Property1Numeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Property1Numeric.Location = new System.Drawing.Point(0, 18);
            this.Property1Numeric.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Property1Numeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Property1Numeric.MinimumSize = new System.Drawing.Size(4, 0);
            this.Property1Numeric.Name = "Property1Numeric";
            this.Property1Numeric.Size = new System.Drawing.Size(136, 22);
            this.Property1Numeric.TabIndex = 9;
            this.Property1Numeric.ThousandsSeparator = true;
            // 
            // Property1Label
            // 
            this.Property1Label.AutoSize = true;
            this.Property1Label.Location = new System.Drawing.Point(2, 0);
            this.Property1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Property1Label.MinimumSize = new System.Drawing.Size(80, 0);
            this.Property1Label.Name = "Property1Label";
            this.Property1Label.Size = new System.Drawing.Size(80, 16);
            this.Property1Label.TabIndex = 9;
            this.Property1Label.Text = "Property1";
            // 
            // ZoneDimensions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.WZ_PositionControl);
            this.Name = "ZoneDimensions";
            this.Size = new System.Drawing.Size(417, 103);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Property3Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property1Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ABB.Robotics.RobotStudio.Stations.Forms.PositionControl WZ_PositionControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Property1Label;
        private System.Windows.Forms.NumericUpDown Property1Numeric;
        private System.Windows.Forms.Label Property3Label;
        private System.Windows.Forms.Label Property2Label;
        private System.Windows.Forms.NumericUpDown Property3Numeric;
        private System.Windows.Forms.NumericUpDown Property2Numeric;
    }
}
