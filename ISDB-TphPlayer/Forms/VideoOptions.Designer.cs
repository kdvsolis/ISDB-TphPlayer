namespace ISDB_TphPlayer
{
    partial class VideoOptions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aspectRatioBox = new System.Windows.Forms.GroupBox();
            this.arRadButton3 = new System.Windows.Forms.RadioButton();
            this.arRadButton2 = new System.Windows.Forms.RadioButton();
            this.arRadButton1 = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.autoFullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.enableEPGCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bandwidthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aspectRatioBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aspectRatioBox
            // 
            this.aspectRatioBox.Controls.Add(this.arRadButton3);
            this.aspectRatioBox.Controls.Add(this.arRadButton2);
            this.aspectRatioBox.Controls.Add(this.arRadButton1);
            this.aspectRatioBox.Location = new System.Drawing.Point(12, 12);
            this.aspectRatioBox.Name = "aspectRatioBox";
            this.aspectRatioBox.Size = new System.Drawing.Size(260, 144);
            this.aspectRatioBox.TabIndex = 0;
            this.aspectRatioBox.TabStop = false;
            this.aspectRatioBox.Text = "Aspect Ratio:";
            // 
            // arRadButton3
            // 
            this.arRadButton3.AutoSize = true;
            this.arRadButton3.Location = new System.Drawing.Point(25, 98);
            this.arRadButton3.Name = "arRadButton3";
            this.arRadButton3.Size = new System.Drawing.Size(52, 17);
            this.arRadButton3.TabIndex = 2;
            this.arRadButton3.Text = "16:10";
            this.arRadButton3.UseVisualStyleBackColor = true;
            this.arRadButton3.CheckedChanged += new System.EventHandler(this.arButtonCheckedChanged);
            // 
            // arRadButton2
            // 
            this.arRadButton2.AutoSize = true;
            this.arRadButton2.Checked = true;
            this.arRadButton2.Location = new System.Drawing.Point(25, 65);
            this.arRadButton2.Name = "arRadButton2";
            this.arRadButton2.Size = new System.Drawing.Size(46, 17);
            this.arRadButton2.TabIndex = 2;
            this.arRadButton2.TabStop = true;
            this.arRadButton2.Text = "16:9";
            this.arRadButton2.UseVisualStyleBackColor = true;
            this.arRadButton2.CheckedChanged += new System.EventHandler(this.arButtonCheckedChanged);
            // 
            // arRadButton1
            // 
            this.arRadButton1.AutoSize = true;
            this.arRadButton1.Location = new System.Drawing.Point(25, 32);
            this.arRadButton1.Name = "arRadButton1";
            this.arRadButton1.Size = new System.Drawing.Size(40, 17);
            this.arRadButton1.TabIndex = 1;
            this.arRadButton1.Text = "4:3";
            this.arRadButton1.UseVisualStyleBackColor = true;
            this.arRadButton1.CheckedChanged += new System.EventHandler(this.arButtonCheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(116, 281);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 281);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // autoFullScreenCheckBox
            // 
            this.autoFullScreenCheckBox.AutoSize = true;
            this.autoFullScreenCheckBox.Location = new System.Drawing.Point(6, 28);
            this.autoFullScreenCheckBox.Name = "autoFullScreenCheckBox";
            this.autoFullScreenCheckBox.Size = new System.Drawing.Size(99, 17);
            this.autoFullScreenCheckBox.TabIndex = 4;
            this.autoFullScreenCheckBox.Text = "Auto Fullscreen";
            this.autoFullScreenCheckBox.UseVisualStyleBackColor = true;
            this.autoFullScreenCheckBox.CheckedChanged += new System.EventHandler(this.miscSettingsCheckBoxChanged);
            // 
            // enableEPGCheckBox
            // 
            this.enableEPGCheckBox.AutoSize = true;
            this.enableEPGCheckBox.Location = new System.Drawing.Point(6, 51);
            this.enableEPGCheckBox.Name = "enableEPGCheckBox";
            this.enableEPGCheckBox.Size = new System.Drawing.Size(84, 17);
            this.enableEPGCheckBox.TabIndex = 5;
            this.enableEPGCheckBox.Text = "Enable EPG";
            this.enableEPGCheckBox.UseVisualStyleBackColor = true;
            this.enableEPGCheckBox.CheckedChanged += new System.EventHandler(this.miscSettingsCheckBoxChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bandwidthComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.enableEPGCheckBox);
            this.groupBox2.Controls.Add(this.autoFullScreenCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc Settings";
            // 
            // bandwidthComboBox
            // 
            this.bandwidthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandwidthComboBox.FormattingEnabled = true;
            this.bandwidthComboBox.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.bandwidthComboBox.Location = new System.Drawing.Point(104, 72);
            this.bandwidthComboBox.Name = "bandwidthComboBox";
            this.bandwidthComboBox.Size = new System.Drawing.Size(75, 21);
            this.bandwidthComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Default Bandwidth:";
            // 
            // VideoOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.aspectRatioBox);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VideoOptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Options";
            this.Load += new System.EventHandler(this.VideoOptions_Load);
            this.aspectRatioBox.ResumeLayout(false);
            this.aspectRatioBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aspectRatioBox;
        private System.Windows.Forms.RadioButton arRadButton3;
        private System.Windows.Forms.RadioButton arRadButton2;
        private System.Windows.Forms.RadioButton arRadButton1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox autoFullScreenCheckBox;
        private System.Windows.Forms.CheckBox enableEPGCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox bandwidthComboBox;
        private System.Windows.Forms.Label label1;
    }
}