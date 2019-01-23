using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            oggVorbisOutput = new VFOGGVorbisOutput
            {
                Quality = Convert.ToInt32(edOGGQuality.Text),
                MinBitRate = Convert.ToInt32(cbOGGMinimum.Text),
                MaxBitRate = Convert.ToInt32(cbOGGMaximum.Text),
                AvgBitRate = Convert.ToInt32(cbOGGAverage.Text)
            };

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
    }
}
