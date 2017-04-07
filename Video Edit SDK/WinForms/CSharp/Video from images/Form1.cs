// ReSharper disable InconsistentNaming

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Video_From_Images
{
    using System.Diagnostics;

    using VisioForge.Types;
    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.VideoEffects;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string GetFileExt(string filename)
        {
            int k = filename.LastIndexOf('.');
            return filename.Substring(k, filename.Length - k);
        }

        private void btAddInputFile_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text);

                // resize if required
                int customWidth = 0;
                int customHeight = 0;

                if (cbResize.Checked)
                {
                    customWidth = Convert.ToInt32(edWidth.Text);
                    customHeight = Convert.ToInt32(edHeight.Text);
                }

                string s = OpenDialog1.FileName;

                lbFiles.Items.Add(s);

                if ((string.Compare(GetFileExt(s), ".BMP", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPEG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".GIF", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".PNG", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    VideoEdit1.Input_AddImageFile(s, 2000, -1, VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight);
                }
                else if ((string.Compare(GetFileExt(s), ".WAV", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".MP3", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".OGG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".WMA", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    var audioFile = new VFVEAudioSource(s, -1, -1, string.Empty, 0, 1.0);
                    VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                }
                else
                {
                    var audioFile = new VFVEAudioSource(s, -1, -1, s, 0, 1.0);
                    var videoFile = new VFVEVideoSource(
                                s, -1, -1, VFVideoEditStretchMode.Letterbox, 0, 1.0);

                    VideoEdit1.Input_AddVideoFile(videoFile, -1, 0, customWidth, customHeight);
                    VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                }
            }
        }

        private void btClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
        }

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = SaveDialog1.FileName;
            }
        }

        private void btVideoSettings_Click(object sender, EventArgs e)
        {
            string name = this.cbVideoCodec.Text;

            if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
        }

        private void btAudioSettings_Click(object sender, EventArgs e)
        {
            string name = this.cbAudioCodec.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void btAddTransition_Click(object sender, EventArgs e)
        {
            // get id
            int id = VideoEdit.Video_Transition_GetIDFromName(this.cbTransitionName.Text);

            // add transition
            VideoEdit1.Video_Transition_Add(Convert.ToInt32(edTransStartTime.Text), Convert.ToInt32(edTransStopTime.Text), id);

            // add to list
            lbTransitions.Items.Add(cbTransitionName.Text +
            "(Start: " + edTransStartTime.Text + ", stop: " + edTransStopTime.Text + ")");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoEdit1.SDK_Version + ", " + VideoEdit1.SDK_State + ")";

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            cbFrameRate.SelectedIndex = 7;
            cbChannels.SelectedIndex = 0;
            cbSampleRate.SelectedIndex = 0;
            cbBPS.SelectedIndex = 0;

            for (int i = 0; i < VideoEdit1.Video_Codecs().Count; i++)
            {
                cbVideoCodec.Items.Add(VideoEdit1.Video_Codecs()[i]);
            }

            for (int i = 0; i < VideoEdit1.Audio_Codecs().Count; i++)
            {
                cbAudioCodec.Items.Add(VideoEdit1.Audio_Codecs()[i]);
            }

            cbVideoCodec.SelectedIndex = 0;
            cbAudioCodec.SelectedIndex = 0;

            for (int i = 0; i < VideoEdit1.WMV_Internal_Profiles().Count; i++)
            {
                cbWMVInternalProfile9.Items.Add(VideoEdit1.WMV_Internal_Profiles()[i]);
            }

            cbWMVInternalProfile9.SelectedIndex = 0;

            cbVideoCodec_SelectedIndexChanged(null, null);
            cbAudioCodec_SelectedIndexChanged(null, null);

            for (int i = 0; i < VideoEdit1.Video_Transition_Names().Count; i++)
            {
                cbTransitionName.Items.Add(VideoEdit1.Video_Transition_Names()[i]);
            }

            cbTransitionName.SelectedIndex = 0;

            if (cbAudioCodec.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodec.SelectedIndex = cbAudioCodec.Items.IndexOf("PCM");
            }

            if (cbVideoCodec.Items.IndexOf("MJPEG Compressor") != -1)
            {
                cbVideoCodec.SelectedIndex = cbVideoCodec.Items.IndexOf("MJPEG Compressor");
            }
        }

        private void cbVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.cbVideoCodec.Text;

            btVideoSettings.Enabled = VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                       || VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.cbAudioCodec.Text;
            btAudioSettings.Enabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                       || VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmLog.Clear();

            VideoEdit1.Debug_Mode = cbDebugMode.Checked;

            VideoEdit1.Video_Effects_Clear();

            if (rbConvert.Checked)
            {
                VideoEdit1.Mode = VFVideoEditMode.Convert;
            }
            else
            {
                VideoEdit1.Mode = VFVideoEditMode.Preview;
            }

            VideoEdit1.Video_Resize = cbResize.Checked;

            if (VideoEdit1.Video_Resize)
            {
                VideoEdit1.Video_Resize_Width = Convert.ToInt32(edWidth.Text);
                VideoEdit1.Video_Resize_Height = Convert.ToInt32(edHeight.Text);
            }

            VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text);

            // apply capture parameters
            if (VideoEdit.Filter_Supported_VMR9())
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }

            VideoEdit1.Output_Filename = edOutput.Text;

            if (rbAVI.Checked)
            {
                var aviOutput = new VFAVIOutput();
                aviOutput.ACM.Name = cbAudioCodec.Text;
                aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
                aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
                aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);
                aviOutput.Video_Codec = cbVideoCodec.Text;
                aviOutput.Audio_UseMP3Encoder = false;
                VideoEdit1.Output_Format = aviOutput;
            }
            else
            {
                var wmvOutput = new VFWMVOutput();
                wmvOutput.Mode = VFWMVMode.InternalProfile;

                if (cbWMVInternalProfile9.SelectedIndex != -1)
                {
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                }

                VideoEdit1.Output_Format = wmvOutput;
            }

            VideoEdit1.Video_Effects_Enabled = true;
            VideoEdit1.Video_Effects_Clear();

            if (this.cbImageLogo.Checked)
            {
                cbImageLogo_CheckedChanged(null, null);
            }

            if (cbTextLogo.Checked)
            {
                cbTextLogo_CheckedChanged(null, null);
            }

            VideoEdit1.Start();

            lbTransitions.Items.Clear();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoEdit1.Stop();
            ProgressBar1.Value = 0;
        }

        private void cbTextLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectTextLogo textLogo;
            var effect = VideoEdit1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.Checked);
                VideoEdit1.Video_Effects_Add(textLogo);
            }
            else
            {
                textLogo = effect as IVFVideoEffectTextLogo;
            }

            if (textLogo == null)
            {
                MessageBox.Show("Unable to configure text logo effect.");
                return;
            }

            textLogo.Enabled = cbTextLogo.Checked;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = fontDialog1.Font;
            textLogo.FontColor = fontDialog1.Color;

            textLogo.TransparencyLevel = tbTextLogoTransp.Value;

            textLogo.Update();
        }

        private void cbImageLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoEdit1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.Checked);
                VideoEdit1.Video_Effects_Add(imageLogo);
            }
            else
            {
                imageLogo = effect as IVFVideoEffectImageLogo;
            }

            if (imageLogo == null)
            {
                MessageBox.Show("Unable to configure image logo effect.");
                return;
            }

            imageLogo.Enabled = cbImageLogo.Checked;
            imageLogo.Filename = edImageLogoFilename.Text;
            imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text);
            imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text);
            imageLogo.TransparencyLevel = tbImageLogoTransp.Value;
            imageLogo.AnimationEnabled = true;
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                cbTextLogo_CheckedChanged(null, null);
            }
        }

        private void tbTextLogoTransp_Scroll(object sender, EventArgs e)
        {
            cbTextLogo_CheckedChanged(null, null);
        }

        private void tbGraphicLogoTransp_Scroll(object sender, EventArgs e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void VideoEdit1_OnProgress(object sender, ProgressEventArgs e)
        {
            ProgressBar1.Value = e.Progress;
        }

        private void VideoEdit1_OnStop(object sender, EventArgs e)
        {
            ProgressBar1.Value = 0;
        }

        private void VideoEdit1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }
    }
}

// ReSharper restore InconsistentNaming