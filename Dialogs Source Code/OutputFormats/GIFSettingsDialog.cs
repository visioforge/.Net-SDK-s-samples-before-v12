using System;
using System.Diagnostics;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class GIFSettingsDialog : Form
    {
        public GIFSettingsDialog()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillSettings(ref VFAnimatedGIFOutput gifOutput)
        {
            gifOutput.FrameRate = Convert.ToDouble(edGIFFrameRate.Text);
            gifOutput.ForcedVideoWidth = Convert.ToInt32(edGIFWidth.Text);
            gifOutput.ForcedVideoHeight = Convert.ToInt32(edGIFHeight.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/visioforge/.Net-SDK-s-samples/tree/master/Dialogs%20Source%20Code/OutputFormats";
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }
    }
}
