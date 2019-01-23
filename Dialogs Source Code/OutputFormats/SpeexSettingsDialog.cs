using System;
using System.Windows.Forms;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class SpeexSettingsDialog : Form
    {
        public SpeexSettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cbSpeexBitrateControl.SelectedIndex = 2;
            cbSpeexMode.SelectedIndex = 0;
        }

        public void FillSettings(ref VFSpeexOutput speexOutput)
        {
            speexOutput.BitRate = tbSpeexBitrate.Value;
            speexOutput.BitrateControl = (SpeexBitrateControl)cbSpeexBitrateControl.SelectedIndex;
            speexOutput.Mode = (SpeexEncodeMode)cbSpeexMode.SelectedIndex;
            speexOutput.MaxBitRate = tbSpeexMaxBitrate.Value;
            speexOutput.Complexity = tbSpeexComplexity.Value;
            speexOutput.Quality = tbSpeexQuality.Value;
            speexOutput.UseAGC = cbSpeexAGC.Checked;
            speexOutput.UseDTX = cbSpeexDTX.Checked;
            speexOutput.UseDenoise = cbSpeexDenoise.Checked;
            speexOutput.UseVAD = cbSpeexVAD.Checked;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
