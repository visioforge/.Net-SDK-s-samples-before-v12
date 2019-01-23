using System;
using System.Windows.Forms;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class DVSettingsDialog : Form
    {
        public DVSettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cbDVChannels.SelectedIndex = 1;
            cbDVSampleRate.SelectedIndex = 0;
        }

        public void FillSettings(ref VFDVOutput dvOutput)
        {
            dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text);
            dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text);

            if (rbDVPAL.Checked)
            {
                dvOutput.Video_Format = VFDVVideoFormat.PAL;
            }
            else
            {
                dvOutput.Video_Format = VFDVVideoFormat.NTSC;
            }

            dvOutput.Type2 = rbDVType2.Checked;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
