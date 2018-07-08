using ISDB_TphPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDB_TphPlayer
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
        }

        private void ScanForm_Load(object sender, EventArgs e)
        {
            bandwidthComboBox.Text = SettingsHandler.LoadSettings().FirstOrDefault(x => x[0] == "default_bandwidth")[1];
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            int[] counterParams = { Int32.Parse(startFrequencyBox.Text), Int32.Parse(endFrequencyBox.Text), Int32.Parse(bandwidthComboBox.Text) * 1000 };
            progressBar1.Maximum = counterParams[1] - counterParams[0];
            if (progressBar1.Maximum % counterParams[2] != 0)
            {
                MessageBox.Show("You have placed invalid parameters! Difference between start and end frequency should be divisible by bandwidth * 1000");
            }
            else
            {
                scanButton.Text = scanButton.Text == "Scan" ? "Stop" : "Scan";
                if (scanButton.Text == "Stop")
                    backgroundWorker1.RunWorkerAsync(counterParams);
                else
                    backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int[] args = e.Argument as int[];
            int startFreq = args[0];
            int endFreq = args[1];
            int bandwidth = args[2];
            int channelCount = 0;
            
            closeButton.Invoke(new Action(() => { closeButton.Enabled = false; }));
            label5.Invoke(new Action(() => { label5.Text = "Channels Found: "; }));
            for (int i = 0; i <= endFreq - startFreq; i += bandwidth)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0, startFreq + i - bandwidth);
                    closeButton.Invoke(new Action(() => { closeButton.Enabled = true; }));
                    break;
                }
                try
                {
                    channelCount += ChannelInfoHandler.ScanServiceIDsPerFrequency((startFreq + i).ToString(), (bandwidth/1000).ToString(), channelCount == 0);
                    label5.Invoke(new Action(() => { label5.Text = "Channels Found: " + channelCount.ToString(); }));
                }
                catch (Exception)
                {
                    Console.WriteLine("No channels found");
                }
                backgroundWorker1.ReportProgress(i, startFreq + i);
            }
            closeButton.Invoke(new Action(() => { closeButton.Enabled = true; }));
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label4.Text = "Frequency: " + ((int)e.UserState).ToString();
        }
    }
}
