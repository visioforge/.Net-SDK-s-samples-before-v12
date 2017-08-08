// ReSharper disable InconsistentNaming

namespace VisioForge_SDK_Screen_Capture_Demo
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;
    using VisioForge.Types.VideoEffects;

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public Form1()
        {
            InitializeComponent();
        }

        private void cbVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbVideoCodecs.Text;
            btVideoSettings.Enabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs.Text;
            btAudioSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btVideoSettings_Click(object sender, EventArgs e)
        {
            string name = cbVideoCodecs.Text;

            if (VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
            {
                if (VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btAudioSettings_Click(object sender, EventArgs e)
        {
            string name = cbAudioCodecs.Text;

            if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
            {
                if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btScreenCaptureUpdate_Click(object sender, EventArgs e)
        {
            VideoCapture1.Screen_Capture_UpdateParameters(Convert.ToInt32(edScreenLeft.Text), Convert.ToInt32(edScreenTop.Text), cbScreenCapture_GrabMouseCursor.Checked);
        }

        private void cbImageLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoCapture1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.Checked);
                VideoCapture1.Video_Effects_Add(imageLogo);
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


        private void btSaveScreenshot_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            switch (cbImageType.SelectedIndex)
            {
                case 0:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0);
                    break;
                case 1:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, tbJPEGQuality.Value);
                    break;
                case 2: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0);
                    break;
                case 3: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0); 
                    break;
                case 4: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0);
                    break;
            }
        }

        private void tbJPEGQuality_Scroll(object sender, EventArgs e)
        {
            lbJPEGQuality.Text = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void cbTextLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectTextLogo textLogo;
            var effect = VideoCapture1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.Checked);
                VideoCapture1.Video_Effects_Add(textLogo);
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

        private void tbGraphicLogoTransp_Scroll(object sender, EventArgs e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void tbTextLogoTransp_Scroll(object sender, EventArgs e)
        {
            cbTextLogo_CheckedChanged(null, null);
        }

        private void cbAudioInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAudioInputDevice.SelectedIndex != -1)
            {
                VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
                cbAudioInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                foreach (string format in deviceItem.Formats)
                {
                    cbAudioInputFormat.Items.Add(format);
                }

                if (cbAudioInputFormat.Items.Count > 0)
                {
                    cbAudioInputFormat.SelectedIndex = 0;
                }

                cbAudioInputFormat_SelectedIndexChanged(null, null);

                cbAudioInputLine.Items.Clear();

                foreach (string line in deviceItem.Lines)
                {
                    cbAudioInputLine.Items.Add(line);
                }

                if (cbAudioInputLine.Items.Count > 0)
                {
                    cbAudioInputLine.SelectedIndex = 0;
                }

                cbAudioInputLine_SelectedIndexChanged(null, null);

                btAudioInputDeviceSettings.Enabled = deviceItem.DialogDefault;
            }
        }

        private void btAudioInputDeviceSettings_Click(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void cbAudioInputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
        }

        private void cbAudioInputLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
        }

        private void cbUseBestAudioInputFormat_CheckedChanged(object sender, EventArgs e)
        {
            cbAudioInputFormat.Enabled = !cbUseBestAudioInputFormat.Checked;
        }

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmLog.Clear();

            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            // from screen
            VideoCapture1.Screen_Capture_Source = new ScreenCaptureSourceSettings();
            if (rbScreenCaptureWindow.Checked)
            {
                VideoCapture1.Screen_Capture_Source.Mode = VFScreenCaptureMode.Window;

                VideoCapture1.Screen_Capture_Source.WindowHandle = IntPtr.Zero;

                try
                {
                    VideoCapture1.Screen_Capture_Source.WindowHandle = FindWindow(edScreenCaptureWindowName.Text, null);
                }
                catch
                {
                }

                if (VideoCapture1.Screen_Capture_Source.WindowHandle == IntPtr.Zero)
                {
                    MessageBox.Show("Incorrect window title for screen capture.");
                    return;
                }
            }
            else
            {
                VideoCapture1.Screen_Capture_Source.Mode = VFScreenCaptureMode.Screen;
            }

            VideoCapture1.Screen_Capture_Source.FrameRate = (float)Convert.ToDouble(edScreenFrameRate.Text);
            VideoCapture1.Screen_Capture_Source.FullScreen = rbScreenFullScreen.Checked;
            VideoCapture1.Screen_Capture_Source.Top = Convert.ToInt32(edScreenTop.Text);
            VideoCapture1.Screen_Capture_Source.Bottom = Convert.ToInt32(edScreenBottom.Text);
            VideoCapture1.Screen_Capture_Source.Left = Convert.ToInt32(edScreenLeft.Text);
            VideoCapture1.Screen_Capture_Source.Right = Convert.ToInt32(edScreenRight.Text);
            VideoCapture1.Screen_Capture_Source.GrabMouseCursor = cbScreenCapture_GrabMouseCursor.Checked;
            VideoCapture1.Screen_Capture_Source.DisplayIndex = Convert.ToInt32(cbScreenCaptureDisplayIndex.Text);
            VideoCapture1.Screen_Capture_Source.AllowDesktopDuplicationEngine = cbScreenCapture_DesktopDuplication.Checked;

            if (cbRecordAudio.Checked)
            {
                VideoCapture1.Audio_RecordAudio = true;
                VideoCapture1.Audio_PlayAudio = false;

                VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
                VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
                VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
            }
            else
            {
                VideoCapture1.Audio_RecordAudio = false;
                VideoCapture1.Audio_PlayAudio = false;
            }

            // apply capture params
            VideoCapture1.Video_Effects_Enabled = true;
            VideoCapture1.Video_Effects_Clear();

            if (cbMode.SelectedIndex == 0)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenPreview;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture;
                VideoCapture1.Output_Filename = edOutput.Text;

                if (cbMode.SelectedIndex == 1)
                {
                    var aviOutput = new VFAVIOutput();

                    aviOutput.ACM.Name = cbAudioCodecs.Text;
                    aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
                    aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
                    aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);

                    aviOutput.Video_Codec = cbVideoCodecs.Text;

                    VideoCapture1.Output_Format = aviOutput;
                }
                else if (cbMode.SelectedIndex == 2)
                {
                    var wmvOutput = new VFWMVOutput();

                    wmvOutput.Mode = VFWMVMode.InternalProfile;

                    if (cbWMVInternalProfile9.SelectedIndex != -1)
                    {
                        wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                    }

                    VideoCapture1.Output_Format = wmvOutput;
                }
                else if (cbMode.SelectedIndex == 3)
                {
                    var mp4Output = new VFMP4Output();

                    // Main settings
                    mp4Output.MP4Mode = VFMP4Mode.v10;

                    // Video H264 settings
                    switch (cbH264Profile.SelectedIndex)
                    {
                        case 0:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileAuto;
                            break;
                        case 1:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileBaseline;
                            break;
                        case 2:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileMain;
                            break;
                        case 3:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh;
                            break;
                        case 4:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh10;
                            break;
                        case 5:
                            mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh422;
                            break;
                    }

                    switch (cbH264Level.SelectedIndex)
                    {
                        case 0:
                            mp4Output.Video_H264.Level = VFH264Level.LevelAuto;
                            break;
                        case 1:
                            mp4Output.Video_H264.Level = VFH264Level.Level1;
                            break;
                        case 2:
                            mp4Output.Video_H264.Level = VFH264Level.Level11;
                            break;
                        case 3:
                            mp4Output.Video_H264.Level = VFH264Level.Level12;
                            break;
                        case 4:
                            mp4Output.Video_H264.Level = VFH264Level.Level13;
                            break;
                        case 5:
                            mp4Output.Video_H264.Level = VFH264Level.Level2;
                            break;
                        case 6:
                            mp4Output.Video_H264.Level = VFH264Level.Level21;
                            break;
                        case 7:
                            mp4Output.Video_H264.Level = VFH264Level.Level22;
                            break;
                        case 8:
                            mp4Output.Video_H264.Level = VFH264Level.Level3;
                            break;
                        case 9:
                            mp4Output.Video_H264.Level = VFH264Level.Level31;
                            break;
                        case 10:
                            mp4Output.Video_H264.Level = VFH264Level.Level32;
                            break;
                        case 11:
                            mp4Output.Video_H264.Level = VFH264Level.Level4;
                            break;
                        case 12:
                            mp4Output.Video_H264.Level = VFH264Level.Level41;
                            break;
                        case 13:
                            mp4Output.Video_H264.Level = VFH264Level.Level42;
                            break;
                        case 14:
                            mp4Output.Video_H264.Level = VFH264Level.Level5;
                            break;
                        case 15:
                            mp4Output.Video_H264.Level = VFH264Level.Level51;
                            break;
                    }

                    switch (cbH264TargetUsage.SelectedIndex)
                    {
                        case 0:
                            mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.Auto;
                            break;
                        case 1:
                            mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.BestQuality;
                            break;
                        case 2:
                            mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.Balanced;
                            break;
                        case 3:
                            mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.BestSpeed;
                            break;
                    }

                    mp4Output.Video_H264.PictureType = VFH264PictureType.Auto;


                    mp4Output.Video_H264.RateControl = (VFH264RateControl)cbH264RateControl.SelectedIndex;
                    mp4Output.Video_H264.GOP = cbH264GOP.Checked;
                    mp4Output.Video_H264.BitrateAuto = cbH264AutoBitrate.Checked;

                    int tmp;
                    int.TryParse(edH264Bitrate.Text, out tmp);
                    mp4Output.Video_H264.Bitrate = tmp;

                    // Audio AAC settings
                    int.TryParse(cbAACBitrate.Text, out tmp);
                    mp4Output.Audio_AAC.Bitrate = tmp;

                    mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACVersion.SelectedIndex;
                    mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
                    mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObjectType.SelectedIndex + 1);

                    VideoCapture1.Output_Format = mp4Output;
                }
            }

            VideoCapture1.Start();
        }
        
        private void btStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            foreach (string codec in VideoCapture1.Video_Codecs)
            {
                cbVideoCodecs.Items.Add(codec);
            }

            if (cbVideoCodecs.Items.Count > 0)
            {
                cbVideoCodecs.SelectedIndex = 0;
                cbVideoCodecs_SelectedIndexChanged(null, null);
            }

            foreach (string codec in VideoCapture1.Audio_Codecs)
            {
                cbAudioCodecs.Items.Add(codec);
            }

            if (cbAudioCodecs.Items.Count > 0)
            {
                cbAudioCodecs.SelectedIndex = 0;
                cbAudioCodecs_SelectedIndexChanged(null, null);
            }

            if (cbVideoCodecs.Items.IndexOf("MJPEG Compressor") != -1)
            {
                cbVideoCodecs.SelectedIndex = cbVideoCodecs.Items.IndexOf("MJPEG Compressor");
            }

            if (cbAudioCodecs.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodecs.SelectedIndex = cbAudioCodecs.Items.IndexOf("PCM");
            }

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                cbAudioInputDevice.Items.Add(device.Name);
            }

            if (cbAudioInputDevice.Items.Count > 0)
            {
                cbAudioInputDevice.SelectedIndex = 0;
                cbAudioInputDevice_SelectedIndexChanged(null, null);
            }

            foreach (string profile in VideoCapture1.WMV_Internal_Profiles())
            {
                cbWMVInternalProfile9.Items.Add(profile);
            }

            if (cbWMVInternalProfile9.Items.Count > 0)
            {
                cbWMVInternalProfile9.SelectedIndex = 0;
            }

            foreach (var screen in Screen.AllScreens)
            {
                cbScreenCaptureDisplayIndex.Items.Add(screen.DeviceName.Replace(@"\\.\DISPLAY", string.Empty));
            }

            cbScreenCaptureDisplayIndex.SelectedIndex = 0;

            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbImageType.SelectedIndex = 1;
            cbMode.SelectedIndex = 0;

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264TargetUsage.SelectedIndex = 3;

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            if (VideoCapture.Filter_Supported_EVR())
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (VideoCapture.Filter_Supported_VMR9())
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
        }

        private void llVideoTutorials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }
    }
}

// ReSharper restore InconsistentNaming
