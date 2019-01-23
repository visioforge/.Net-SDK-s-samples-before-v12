using System;
using System.Windows.Forms;
using VisioForge.Types.OutputFormat;

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class FLACSettingsDialog : Form
    {
        public FLACSettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void LoadDefaults()
        {
            cbFLACBlockSize.SelectedIndex = 4;
        }

        private void btClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        public void FillSettings(ref VFFLACOutput flacOutput)
        {
            flacOutput.Level = tbFLACLevel.Value;
            flacOutput.BlockSize = Convert.ToInt32(cbFLACBlockSize.Text);
            flacOutput.AdaptiveMidSideCoding = cbFLACAdaptiveMidSideCoding.Checked;
            flacOutput.ExhaustiveModelSearch = cbFLACExhaustiveModelSearch.Checked;
            flacOutput.LPCOrder = tbFLACLPCOrder.Value;
            flacOutput.MidSideCoding = cbFLACMidSideCoding.Checked;
            flacOutput.RiceMin = Convert.ToInt32(edFLACRiceMin.Text);
            flacOutput.RiceMax = Convert.ToInt32(edFLACRiceMax.Text);
        }
    }
}
