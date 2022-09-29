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
            this.CopyButton = new System.Windows.Forms.Button();
            this.zoneDimensions = new WZcalculator.ZoneDimensions();
            this.SuspendLayout();
            // 
            // BoxRadioButton
            // 
            this.BoxRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxRadioButton.AutoSize = true;
            this.BoxRadioButton.Checked = true;
            this.BoxRadioButton.Location = new System.Drawing.Point(2, 18);
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
            this.RobotCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RobotCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RobotCombobox.FormattingEnabled = true;
            this.RobotCombobox.Location = new System.Drawing.Point(3, 261);
            this.RobotCombobox.Name = "RobotCombobox";
            this.RobotCombobox.Size = new System.Drawing.Size(369, 21);
            this.RobotCombobox.TabIndex = 2;
            this.RobotCombobox.SelectedIndexChanged += new System.EventHandler(this.RobotCombobox_SelectedIndexChanged);
            this.RobotCombobox.Click += new System.EventHandler(this.RobotCombobox_Click);
            // 
            // RobotLabel
            // 
            this.RobotLabel.AutoSize = true;
            this.RobotLabel.Location = new System.Drawing.Point(2, 245);
            this.RobotLabel.Name = "RobotLabel";
            this.RobotLabel.Size = new System.Drawing.Size(36, 13);
            this.RobotLabel.TabIndex = 3;
            this.RobotLabel.Text = "Robot";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(3, 296);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(56, 13);
            this.InstructionLabel.TabIndex = 5;
            this.InstructionLabel.Text = "Instruction";
            // 
            // InstructionRichTextBox
            // 
            this.InstructionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstructionRichTextBox.Location = new System.Drawing.Point(4, 312);
            this.InstructionRichTextBox.Name = "InstructionRichTextBox";
            this.InstructionRichTextBox.ReadOnly = true;
            this.InstructionRichTextBox.Size = new System.Drawing.Size(369, 35);
            this.InstructionRichTextBox.TabIndex = 6;
            this.InstructionRichTextBox.Text = "";
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyButton.Location = new System.Drawing.Point(295, 353);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 8;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // zoneDimensions
            // 
            this.zoneDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoneDimensions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zoneDimensions.Location = new System.Drawing.Point(4, 115);
            this.zoneDimensions.Name = "zoneDimensions";
            this.zoneDimensions.Size = new System.Drawing.Size(368, 91);
            this.zoneDimensions.TabIndex = 9;
            // 
            // WZcalculatorToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.zoneDimensions);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.InstructionRichTextBox);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.RobotLabel);
            this.Controls.Add(this.RobotCombobox);
            this.Controls.Add(this.CylinderRadioButton);
            this.Controls.Add(this.SphereRadioButton);
            this.Controls.Add(this.BoxRadioButton);
            this.Name = "WZcalculatorToolWindow";
            this.Size = new System.Drawing.Size(381, 412);
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
        private System.Windows.Forms.Button CopyButton;
        private ZoneDimensions zoneDimensions;
    }
}
