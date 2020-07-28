﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VisioForge.Controls.MediaPlayer;
using VisioForge.Controls.VideoCapture;
using VisioForge.Controls.VideoEdit;
using VisioForge.Types.VideoEffects;

namespace VisioForge.Controls.UI.Dialogs.VideoEffects
{
    public partial class ImageLogoSettingsDialog : Form, IVFVideoEffectsSettingsDialog
    {
        private const string NAME = "ImageLogo";

        private IVFVideoEffectImageLogo _intf;

        public ImageLogoSettingsDialog()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_intf != null)
            {
                EffectUpdate(_intf);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (_intf != null)
            {
                EffectUpdate(_intf);
            }

            Close();
        }

        public void Attach(IVFVideoEffect effect)
        {
            _intf = effect as IVFVideoEffectImageLogo;
            if (_intf == null)
            {
                return;
            }
            
            edImageLogoFilename.Text = _intf.Filename ;
            edImageLogoLeft.Text = _intf.Left.ToString();
            edImageLogoTop.Text = _intf.Top.ToString();
            tbImageLogoTransp.Value = _intf.TransparencyLevel;
            pnImageLogoColorKey.ForeColor= _intf.ColorKey;
            cbImageLogoUseColorKey.Checked = _intf.UseColorKey;
            cbImageLogoShowAlways.Checked = _intf.StartTime == TimeSpan.Zero && _intf.StopTime == TimeSpan.Zero;
        }

        public void Fill(IVFVideoEffect effect)
        {
            _intf = effect as IVFVideoEffectImageLogo;
            EffectUpdate(_intf);
        }

        public string GenerateNewEffectName(VideoCaptureCore core)
        {
            string name = NAME;

            var eff = core?.Video_Effects_Get(name);
            if (eff != null)
            {
                int k = 2;
                while (eff != null)
                {
                    name = $"{NAME} {k++}";
                    eff = core.Video_Effects_Get(name);
                }
            }

            return name;
        }

        public string GenerateNewEffectName(VideoEditCore core)
        {
            string name = NAME;

            var eff = core?.Video_Effects_Get(name);
            if (eff != null)
            {
                int k = 2;
                while (eff != null)
                {
                    name = $"{NAME} {k++}";
                    eff = core.Video_Effects_Get(name);
                }
            }

            return name;
        }

        public string GenerateNewEffectName(MediaPlayerCore core)
        {
            string name = NAME;

            var eff = core?.Video_Effects_Get(name);
            if (eff != null)
            {
                int k = 2;
                while (eff != null)
                {
                    name = $"{NAME} {k++}";
                    eff = core.Video_Effects_Get(name);
                }
            }

            return name;
        }

        private void EffectUpdate(IVFVideoEffectImageLogo imageLogo)
        {
            if (imageLogo == null)
            {
                MessageBox.Show("Unable to configure image logo effect.");
                return;
            }

            if (!File.Exists(edImageLogoFilename.Text))
            {
                imageLogo.Enabled = false;
                return;
            }

            imageLogo.Enabled = true;
            imageLogo.Filename = edImageLogoFilename.Text;
            imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text);
            imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text);
            imageLogo.TransparencyLevel = tbImageLogoTransp.Value;
            imageLogo.ColorKey = pnImageLogoColorKey.ForeColor;
            imageLogo.UseColorKey = cbImageLogoUseColorKey.Checked;
            imageLogo.AnimationEnabled = true;

            if (cbImageLogoShowAlways.Checked)
            {
                imageLogo.StartTime = TimeSpan.Zero;
                imageLogo.StopTime = TimeSpan.Zero;
            }  
            else
            {
                imageLogo.StartTime = TimeSpan.FromMilliseconds(Convert.ToInt32(edImageLogoStartTime.Text));
                imageLogo.StopTime = TimeSpan.FromMilliseconds(Convert.ToInt32(edImageLogoStopTime.Text));
            }

            imageLogo.Update();
        }

        private void cbImageLogoShowAlways_CheckedChanged(object sender, EventArgs e)
        {
            edImageLogoStartTime.Enabled = !cbImageLogoShowAlways.Checked;
            edImageLogoStopTime.Enabled = !cbImageLogoShowAlways.Checked;
            lbGraphicLogoStartTime.Enabled = !cbImageLogoShowAlways.Checked;
            lbGraphicLogoStopTime.Enabled = !cbImageLogoShowAlways.Checked;
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                edImageLogoFilename.Text = openFileDialog2.FileName;
                imgPreview.Image = new Bitmap(openFileDialog2.FileName);
            }
        }

        private void pnGraphicLogoColorKey_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnImageLogoColorKey.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnImageLogoColorKey.BackColor = colorDialog1.Color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/visioforge/.Net-SDK-s-samples/tree/master/Dialogs%20Source%20Code/OutputFormats";
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }
    }
}
