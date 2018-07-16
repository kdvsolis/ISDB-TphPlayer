namespace ISDB_TphPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.epgListView = new System.Windows.Forms.ListView();
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.channel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.program = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanButton = new System.Windows.Forms.Button();
            this.optionButton = new System.Windows.Forms.Button();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel List";
            // 
            // channelListBox
            // 
            this.channelListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.ItemHeight = 20;
            this.channelListBox.Location = new System.Drawing.Point(583, 58);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(262, 224);
            this.channelListBox.TabIndex = 4;
            this.channelListBox.DoubleClick += new System.EventHandler(this.channelListBox_DoubleClick);
            this.channelListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.channelListBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "EPG";
            // 
            // epgListView
            // 
            this.epgListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.channel,
            this.program,
            this.details,
            this.duration,
            this.status});
            this.epgListView.Location = new System.Drawing.Point(583, 335);
            this.epgListView.Name = "epgListView";
            this.epgListView.Size = new System.Drawing.Size(262, 97);
            this.epgListView.TabIndex = 6;
            this.epgListView.UseCompatibleStateImageBehavior = false;
            this.epgListView.View = System.Windows.Forms.View.Details;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 88;
            // 
            // channel
            // 
            this.channel.Text = "Channel";
            this.channel.Width = 65;
            // 
            // program
            // 
            this.program.Text = "Program";
            this.program.Width = 134;
            // 
            // details
            // 
            this.details.Text = "Details";
            // 
            // duration
            // 
            this.duration.Text = "Duration";
            // 
            // status
            // 
            this.status.Text = "Status";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(583, 447);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(127, 23);
            this.scanButton.TabIndex = 7;
            this.scanButton.Text = "Scan new channels";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(718, 447);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(127, 23);
            this.optionButton.TabIndex = 8;
            this.optionButton.Text = "Options";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(553, 500);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 500);
            this.Controls.Add(this.optionButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.epgListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.channelListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axVLCPlugin21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISDB-Tph Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView epgListView;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader channel;
        private System.Windows.Forms.ColumnHeader program;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.ColumnHeader details;
        private System.Windows.Forms.ColumnHeader duration;
        private System.Windows.Forms.ColumnHeader status;
    }
}

