using ISDB_TphPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDB_TphPlayer
{
    public partial class VideoOptions : Form
    {
        private string aspectRatioSelected = "16:9";
        private string autofullScreenStatus = "false";
        private string enableEPGScan = "false";
        public List<string[]> settings { get; set; }

        public VideoOptions()
        {
            InitializeComponent();
        }

        private void VideoOptions_Load(object sender, EventArgs e)
        {
            settings = SettingsHandler.LoadSettings();
            if (settings == null) return;
            foreach(string[] setting in settings)
            {
                switch (setting[0])
                {
                    case "aspect_ratio":
                        switch (setting[1])
                        {
                            case "4:3": arRadButton1.Checked = true; break;
                            case "16:9": arRadButton2.Checked = true; break;
                            case "16:10": arRadButton3.Checked = true; break;
                        }
                    break;
                    case "auto_fullscreen":autoFullScreenCheckBox.Checked = Boolean.Parse(setting[1]); break;
                    case "enable_epg": enableEPGCheckBox.Checked = Boolean.Parse(setting[1]); break;
                    case "default_bandwidth": bandwidthComboBox.Text = setting[1]; break;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            settings.Clear();
            settings.Add(new string[] { "aspect_ratio", aspectRatioSelected });
            settings.Add(new string[] { "auto_fullscreen", autofullScreenStatus });
            settings.Add(new string[] { "enable_epg", enableEPGScan });
            settings.Add(new string[] { "default_bandwidth", bandwidthComboBox.Text });
            SettingsHandler.SaveSettings(settings);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void arButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if(radioButton.Checked)
                aspectRatioSelected = radioButton.Text;
        }

        private void miscSettingsCheckBoxChanged(object sender, EventArgs e)
        {
            CheckBox miscSettingsCheckBox = sender as CheckBox;
            if (miscSettingsCheckBox.Name == "autoFullScreenCheckBox")
                autofullScreenStatus = miscSettingsCheckBox.Checked.ToString().ToLower();
            if (miscSettingsCheckBox.Name == "enableEPGCheckBox")
                enableEPGScan = miscSettingsCheckBox.Checked.ToString().ToLower();
        }
    }
}
