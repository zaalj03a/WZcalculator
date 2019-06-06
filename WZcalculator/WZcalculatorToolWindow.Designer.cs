namespace WZcalculator
{
    partial class WZcalculatorToolWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.CylinderRadioButton = new System.Windows.Forms.RadioButton();
            this.RobotCombobox = new System.Windows.Forms.ComboBox();
            this.RobotLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.InstructionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ZoneGroupBox = new System.Windows.Forms.GroupBox();
            this.zoneDimensions = new WZcalculator.ZoneDimensions();
            this.ZoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxRadioButton
            // 
            this.BoxRadioButton.AutoSize = true;
            this.BoxRadioButton.Checked = true;
            this.BoxRadioButton.Location = new System.Drawing.Point(3, 18);
            this.BoxRadioButton.Name = "BoxRadioButton";
            this.BoxRadioButton.Size = new System.Drawing.Size(43, 17);
            this.BoxRadioButton.TabIndex = 1;
            this.BoxRadioButton.TabStop = true;
            this.BoxRadioButton.Text = "Box";
            this.BoxRadioButton.UseVisualStyleBackColor = true;
            this.BoxRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckChanged);
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(3, 41);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(59, 17);
            this.SphereRadioButton.TabIndex = 1;
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            this.SphereRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckChanged);
            // 
            // CylinderRadioButton
            // 
            this.CylinderRadioButton.AutoSize = true;
            this.CylinderRadioButton.Location = new System.Drawing.Point(3, 64);
            this.CylinderRadioButton.Name = "CylinderRadioButton";
            this.CylinderRadioButton.Size = new System.Drawing.Size(62, 17);
            this.CylinderRadioButton.TabIndex = 1;
            this.CylinderRadioButton.Text = "Cylinder";
            this.CylinderRadioButton.UseVisualStyleBackColor = true;
            this.CylinderRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckChanged);
            // 
            // RobotCombobox
            // 
            this.RobotCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RobotCombobox.FormattingEnabled = true;
            this.RobotCombobox.Location = new System.Drawing.Point(4, 242);
            this.RobotCombobox.Name = "RobotCombobox";
            this.RobotCombobox.Size = new System.Drawing.Size(234, 21);
            this.RobotCombobox.TabIndex = 2;
            this.RobotCombobox.SelectedIndexChanged += new System.EventHandler(this.RobotCombobox_SelectedIndexChanged);
            this.RobotCombobox.Click += new System.EventHandler(this.RobotCombobox_Click);
            // 
            // RobotLabel
            // 
            this.RobotLabel.AutoSize = true;
            this.RobotLabel.Location = new System.Drawing.Point(3, 226);
            this.RobotLabel.Name = "RobotLabel";
            this.RobotLabel.Size = new System.Drawing.Size(36, 13);
            this.RobotLabel.TabIndex = 3;
            this.RobotLabel.Text = "Robot";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(4, 276);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(56, 13);
            this.InstructionLabel.TabIndex = 5;
            this.InstructionLabel.Text = "Instruction";
            // 
            // InstructionRichTextBox
            // 
            this.InstructionRichTextBox.Location = new System.Drawing.Point(4, 292);
            this.InstructionRichTextBox.Name = "InstructionRichTextBox";
            this.InstructionRichTextBox.ReadOnly = true;
            this.InstructionRichTextBox.Size = new System.Drawing.Size(234, 35);
            this.InstructionRichTextBox.TabIndex = 6;
            this.InstructionRichTextBox.Text = "";
            // 
            // ZoneGroupBox
            // 
            this.ZoneGroupBox.Controls.Add(this.zoneDimensions);
            this.ZoneGroupBox.Location = new System.Drawing.Point(3, 96);
            this.ZoneGroupBox.Name = "ZoneGroupBox";
            this.ZoneGroupBox.Size = new System.Drawing.Size(236, 112);
            this.ZoneGroupBox.TabIndex = 7;
            this.ZoneGroupBox.TabStop = false;
            this.ZoneGroupBox.Text = "Zone";
            // 
            // zoneDimensions
            // 
            this.zoneDimensions.Location = new System.Drawing.Point(1, 18);
            this.zoneDimensions.Name = "zoneDimensions";
            this.zoneDimensions.Size = new System.Drawing.Size(235, 88);
            this.zoneDimensions.TabIndex = 0;
            // 
            // WZcalculatorToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstructionRichTextBox);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.RobotLabel);
            this.Controls.Add(this.RobotCombobox);
            this.Controls.Add(this.CylinderRadioButton);
            this.Controls.Add(this.SphereRadioButton);
            this.Controls.Add(this.BoxRadioButton);
            this.Controls.Add(this.ZoneGroupBox);
            this.Name = "WZcalculatorToolWindow";
            this.Size = new System.Drawing.Size(242, 374);
            this.ZoneGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton BoxRadioButton;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.RadioButton CylinderRadioButton;
        private System.Windows.Forms.ComboBox RobotCombobox;
        private System.Windows.Forms.Label RobotLabel;
        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.RichTextBox InstructionRichTextBox;
        private System.Windows.Forms.GroupBox ZoneGroupBox;
        private ZoneDimensions zoneDimensions;
    }
}
