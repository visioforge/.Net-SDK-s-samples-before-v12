using System;
using System.Diagnostics;
using System.Windows.Forms;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class OggVorbisSettingsDialog : Form
    {
        public OggVorbisSettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cbOGGAverage.SelectedIndex = 6;
            cbOGGMaximum.SelectedIndex = 8;
            cbOGGMinimum.SelectedIndex = 5;
        }

        public void FillSettings(ref VFOGGVorbisOutput oggVorbisOutput)
        {
            oggVorbisOutput.Quality = Convert.ToInt32(edOGGQuality.Text);
            oggVorbisOutput.MinBitRate = Convert.ToInt32(cbOGGMinimum.Text);
            oggVorbisOutput.MaxBitRate = Convert.ToInt32(cbOGGMaximum.Text);
            oggVorbisOutput.AvgBitRate = Convert.ToInt32(cbOGGAverage.Text);

            if (rbOGGQuality.Checked)
            {
                oggVorbisOutput.Mode = VFVorbisMode.Quality;
            }
            else
            {
                oggVorbisOutput.Mode = VFVorbisMode.Bitrate;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/visioforge/.Net-SDK-s-samples/tree/master/Dialogs%20Source%20Code/OutputFormats";
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }
    }
}
