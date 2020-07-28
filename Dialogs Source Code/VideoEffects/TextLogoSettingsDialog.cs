﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using VisioForge.Controls.MediaPlayer;
using VisioForge.Controls.VideoCapture;
using VisioForge.Controls.VideoEdit;
using VisioForge.Types;
using VisioForge.Types.VideoEffects;

namespace VisioForge.Controls.UI.Dialogs.VideoEffects
{
    public partial class TextLogoSettingsDialog : Form, IVFVideoEffectsSettingsDialog
    {
        private const string NAME = "TextLogo";

        private IVFVideoEffectTextLogo _intf;

        public TextLogoSettingsDialog()
        {
            InitializeComponent();

            cbTextLogoAlign.SelectedIndex = 0;
            cbTextLogoAntialiasing.SelectedIndex = 0;
            cbTextLogoDrawMode.SelectedIndex = 0;
            cbTextLogoEffectrMode.SelectedIndex = 0;
            cbTextLogoGradMode.SelectedIndex = 0;
            cbTextLogoShapeType.SelectedIndex = 0;
        }
        
        public void Attach(IVFVideoEffect effect)
        {
            _intf = effect as IVFVideoEffectTextLogo;
            if (_intf == null)
            {
                return;
            }

            StringFormat formatFlags = _intf.StringFormat;

            cbTextLogoVertical.Checked = (formatFlags.FormatFlags & StringFormatFlags.DirectionVertical) != 0;
            cbTextLogoRightToLeft.Checked = (formatFlags.FormatFlags & StringFormatFlags.DirectionRightToLeft) != 0;
            cbTextLogoAlign.SelectedIndex = (int)formatFlags.Alignment;
            edTextLogo.Text = _intf.Text;
            edTextLogoLeft.Text = _intf.Left.ToString();
            edTextLogoTop.Text = _intf.Top.ToString();
            fontDialog1.Font = _intf.Font;
            fontDialog1.Color = _intf.FontColor;
            cbTextLogoTranspBG.Checked = _intf.BackgroundTransparent;

            pnTextLogoBGColor.BackColor = _intf.BackgroundColor;
            cbTextLogoAntialiasing.SelectedIndex = (int)_intf.Antialiasing;
            cbTextLogoDrawMode.SelectedIndex = (int)_intf.DrawQuality;

            if (_intf.RectWidth > 0 && _intf.RectHeight > 0)
            {
                edTextLogoWidth.Text = _intf.RectWidth.ToString();
                edTextLogoHeight.Text = _intf.RectHeight.ToString();
            }
            else
            {
                edTextLogoWidth.Text = "0";
                edTextLogoHeight.Text = "0";
            }

            switch (_intf.RotationMode)
            {
                case VFTextRotationMode.RmNone:
                    rbTextLogoDegree0.Checked = true;
                    break;
                case VFTextRotationMode.Rm90:
                    rbTextLogoDegree90.Checked = true;
                    break;
                case VFTextRotationMode.Rm180:
                    rbTextLogoDegree180.Checked = true;
                    break;
                case VFTextRotationMode.Rm270:
                    rbTextLogoDegree270.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (_intf.FlipMode)
            {
                case VFTextFlipMode.None:
                    rbTextLogoFlipNone.Checked = true;
                    break;
                case VFTextFlipMode.X:
                    rbTextLogoFlipX.Checked = true;
                    break;
                case VFTextFlipMode.Y:
                    rbTextLogoFlipY.Checked = true;
                    break;
                case VFTextFlipMode.XAndY:
                    rbTextLogoFlipXY.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            cbTextLogoGradientEnabled.Checked = _intf.GradientEnabled;
            cbTextLogoGradMode.SelectedIndex = (int)_intf.GradientMode;
            pnTextLogoGradColor1.BackColor = _intf.GradientColor1;
            pnTextLogoGradColor2.BackColor = _intf.GradientColor2;

            cbTextLogoEffectrMode.SelectedIndex = (int)_intf.BorderMode;
            pnTextLogoInnerColor.BackColor = _intf.BorderInnerColor;
            pnTextLogoOuterColor.BackColor = _intf.BorderOuterColor ;
            edTextLogoInnerSize.Text = _intf.BorderInnerSize.ToString();
            edTextLogoOuterSize.Text = _intf.BorderOuterSize.ToString();

            cbTextLogoShapeEnabled.Checked = _intf.Shape;
            edTextLogoShapeLeft.Text = _intf.ShapeLeft.ToString();
            edTextLogoShapeTop.Text = _intf.ShapeTop.ToString();
            cbTextLogoShapeType.SelectedIndex = (int)_intf.ShapeType ;
            edTextLogoShapeWidth.Text = _intf.ShapeWidth.ToString();
            edTextLogoShapeHeight.Text = _intf.ShapeHeight.ToString();
            pnTextLogoShapeColor.BackColor = _intf.ShapeColor ;

            tbTextLogoTransp.Value = _intf.TransparencyLevel ;

            switch (_intf.Mode)
            {
                case TextLogoMode.Text:
                    rbTextLogoDrawText.Checked = true;
                    break;
                case TextLogoMode.DateTime:
                    rbTextLogoDrawDate.Checked = true;
                    break;
                case TextLogoMode.Timestamp:
                    rbTextLogoDrawTimestamp.Checked = true;
                    break;
                case TextLogoMode.FrameNumber:
                    rbTextLogoDrawFrameNumber.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            cbTextLogoFadeIn.Checked = _intf.FadeIn;
            cbTextLogoFadeOut.Checked = _intf.FadeOut;
        }

        public void Fill(IVFVideoEffect effect)
        {
            _intf = effect as IVFVideoEffectTextLogo;
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

        private void EffectUpdate(IVFVideoEffectTextLogo textLogo)
        {
            if (textLogo == null)
            {
                MessageBox.Show("Unable to configure text logo effect.");
                return;
            }

            VFTextRotationMode rotate;
            VFTextFlipMode flip;

            StringFormat formatFlags = new StringFormat();

            if (cbTextLogoVertical.Checked)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionVertical;
            }

            if (cbTextLogoRightToLeft.Checked)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }

            formatFlags.Alignment = (StringAlignment)cbTextLogoAlign.SelectedIndex;

            textLogo.Enabled = true;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = fontDialog1.Font;
            textLogo.FontColor = fontDialog1.Color;

            textLogo.BackgroundTransparent = cbTextLogoTranspBG.Checked;
            textLogo.BackgroundColor = pnTextLogoBGColor.BackColor;
            textLogo.StringFormat = formatFlags;
            textLogo.Antialiasing = (TextRenderingHint)cbTextLogoAntialiasing.SelectedIndex;
            textLogo.DrawQuality = (InterpolationMode)cbTextLogoDrawMode.SelectedIndex;

            if (cbTextLogoUseRect.Checked)
            {
                textLogo.RectWidth = Convert.ToInt32(edTextLogoWidth.Text);
                textLogo.RectHeight = Convert.ToInt32(edTextLogoHeight.Text);
            }
            else
            {
                textLogo.RectWidth = 0;
                textLogo.RectHeight = 0;
            }

            if (rbTextLogoDegree0.Checked)
            {
                rotate = VFTextRotationMode.RmNone;
            }
            else if (rbTextLogoDegree90.Checked)
            {
                rotate = VFTextRotationMode.Rm90;
            }
            else if (rbTextLogoDegree180.Checked)
            {
                rotate = VFTextRotationMode.Rm180;
            }
            else
            {
                rotate = VFTextRotationMode.Rm270;
            }

            if (rbTextLogoFlipNone.Checked)
            {
                flip = VFTextFlipMode.None;
            }
            else if (rbTextLogoFlipX.Checked)
            {
                flip = VFTextFlipMode.X;
            }
            else if (rbTextLogoFlipY.Checked)
            {
                flip = VFTextFlipMode.Y;
            }
            else
            {
                flip = VFTextFlipMode.XAndY;
            }

            textLogo.RotationMode = rotate;
            textLogo.FlipMode = flip;

            textLogo.GradientEnabled = cbTextLogoGradientEnabled.Checked;
            textLogo.GradientMode = (VFTextGradientMode)cbTextLogoGradMode.SelectedIndex;
            textLogo.GradientColor1 = pnTextLogoGradColor1.BackColor;
            textLogo.GradientColor2 = pnTextLogoGradColor2.BackColor;

            textLogo.BorderMode = (VFTextEffectMode)cbTextLogoEffectrMode.SelectedIndex;
            textLogo.BorderInnerColor = pnTextLogoInnerColor.BackColor;
            textLogo.BorderOuterColor = pnTextLogoOuterColor.BackColor;
            textLogo.BorderInnerSize = Convert.ToInt32(edTextLogoInnerSize.Text);
            textLogo.BorderOuterSize = Convert.ToInt32(edTextLogoOuterSize.Text);

            textLogo.Shape = cbTextLogoShapeEnabled.Checked;
            textLogo.ShapeLeft = Convert.ToInt32(edTextLogoShapeLeft.Text);
            textLogo.ShapeTop = Convert.ToInt32(edTextLogoShapeTop.Text);
            textLogo.ShapeType = (VFTextShapeType)cbTextLogoShapeType.SelectedIndex;
            textLogo.ShapeWidth = Convert.ToInt32(edTextLogoShapeWidth.Text);
            textLogo.ShapeHeight = Convert.ToInt32(edTextLogoShapeHeight.Text);
            textLogo.ShapeColor = pnTextLogoShapeColor.BackColor;

            textLogo.TransparencyLevel = tbTextLogoTransp.Value;

            if (rbTextLogoDrawText.Checked)
            {
                textLogo.Mode = TextLogoMode.Text;
            }
            else if (rbTextLogoDrawDate.Checked)
            {
                textLogo.Mode = TextLogoMode.DateTime;
                textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss";
            }
            else if (rbTextLogoDrawFrameNumber.Checked)
            {
                textLogo.Mode = TextLogoMode.FrameNumber;
            }
            else
            {
                textLogo.Mode = TextLogoMode.Timestamp;
            }

            if (cbTextLogoFadeIn.Checked)
            {
                textLogo.FadeIn = true;
                textLogo.FadeInDuration = TimeSpan.FromSeconds(5);
            }
            else
            {
                textLogo.FadeIn = false;
            }

            if (cbTextLogoFadeOut.Checked)
            {
                textLogo.FadeOut = true;
                textLogo.FadeOutDuration = TimeSpan.FromSeconds(5);
            }
            else
            {
                textLogo.FadeOut = false;
            }

            textLogo.Update();
        }

        private void pnTextLogoBGColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoBGColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoBGColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoGradColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoGradColor1.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoGradColor1.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoGradColor2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoGradColor2.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoGradColor2.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoInnerColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoInnerColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoInnerColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoOuterColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoOuterColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoOuterColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoShapeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoShapeColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoShapeColor.BackColor = colorDialog1.Color;
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                edTextLogo.Font = fontDialog1.Font;
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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (_intf != null)
            {
                EffectUpdate(_intf);
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
