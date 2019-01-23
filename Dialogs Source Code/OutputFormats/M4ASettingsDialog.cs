using System;
using System.Windows.Forms;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;
// ReSharper disable InconsistentNaming

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class M4ASettingsDialog : Form
    {
        public M4ASettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cbM4AOutput.SelectedIndex = 0;
            cbM4AVersion.SelectedIndex = 0;
            cbM4AObjectType.SelectedIndex = 1;
            cbM4ABitrate.SelectedIndex = 12;
        }

        public void FillSettings(ref VFM4AOutput m4aOutput)
        {
            int.TryParse(cbM4ABitrate.Text, out var tmp);
            m4aOutput.Bitrate = tmp;

            m4aOutput.Version = (VFAACVersion)cbM4AVersion.SelectedIndex;
            m4aOutput.Output = (VFAACOutput)cbM4AOutput.SelectedIndex;
            m4aOutput.Object = (VFAACObject)(cbM4AObjectType.SelectedIndex + 1);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
