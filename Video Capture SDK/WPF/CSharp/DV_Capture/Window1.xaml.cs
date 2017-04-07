// ReSharper disable InconsistentNaming

namespace DVCapture
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Media;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.VideoEffects;

    using MessageBox = System.Windows.Forms.MessageBox;

    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class Window1
    {
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog2 = new Microsoft.Win32.OpenFileDialog();
        private readonly Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
        private readonly FontDialog fontDialog = new FontDialog();

        public Window1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, RoutedEventArgs e)
        {
            Title += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            foreach (var codec in VideoCapture1.Video_Codecs)
            {
                cbVideoCodecs.Items.Add(codec);
            }

            if (cbVideoCodecs.Items.Count > 0)
            {
                cbVideoCodecs.SelectedIndex = 0;
                cbVideoCodecs_SelectedIndexChanged(null, null);
            }

            foreach (var codec in VideoCapture1.Audio_Codecs)
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

            foreach (var profile in VideoCapture1.WMV_Internal_Profiles())
            {
                cbWMVInternalProfile9.Items.Add(profile);
            }

            if (cbWMVInternalProfile9.Items.Count > 0)
            {
                cbWMVInternalProfile9.SelectedIndex = 0;
            }

            foreach (var device in VideoCapture1.Video_CaptureDevicesInfo)
            {
                cbVideoInputDevice.Items.Add(device.Name);
            }

            if (cbVideoInputDevice.Items.Count > 0)
            {
                cbVideoInputDevice.SelectedIndex = 0;
            }

            cbVideoInputDevice_SelectedIndexChanged(null, null);

            foreach (var audioOutputDevice in VideoCapture1.Audio_OutputDevices)
            {
                cbAudioOutputDevice.Items.Add(audioOutputDevice);
            }

            if (cbAudioOutputDevice.Items.Count > 0)
            {
                cbAudioOutputDevice.SelectedIndex = 0;
            }

            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbDVChannels.SelectedIndex = 1;
            cbDVSampleRate.SelectedIndex = 0;
            cbImageType.SelectedIndex = 1;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
        }

        private void cbVideoCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btVideoSettings.IsEnabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btAudioSettings.IsEnabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btVideoSettings_Click(object sender, RoutedEventArgs e)
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

        private void btAudioSettings_Click(object sender, RoutedEventArgs e)
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

        private void cbImageLogo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoCapture1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.IsChecked == true);
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

            imageLogo.Enabled = cbImageLogo.IsChecked == true;
            imageLogo.Filename = edImageLogoFilename.Text;
            imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text);
            imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text);
            imageLogo.TransparencyLevel = (int)tbImageLogoTransp.Value;
            imageLogo.AnimationEnabled = true;
        }

        private void btSelectImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog2.ShowDialog() == true)
            {
                this.edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void btFont_Click(object sender, RoutedEventArgs e)
        {
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cbTextLogo_CheckedChanged(null, null);
            }
        }

        private void btSaveScreenshot_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            switch (cbImageType.SelectedIndex)
            {
                case 0: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0);
                    break;
                case 1: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, (int)tbJPEGQuality.Value);
                    break;
                case 2: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0);
                    break;
                case 3: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0);
                    break;
                case 4: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0);
                    break;
            }
        }

        private void tbJPEGQuality_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbJPEGQuality != null)
            {
                lbJPEGQuality.Content = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTextLogo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFVideoEffectTextLogo textLogo;
            var effect = VideoCapture1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.IsChecked == true);
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

            textLogo.Enabled = cbTextLogo.IsChecked == true;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = fontDialog.Font;
            textLogo.FontColor = fontDialog.Color;

            textLogo.TransparencyLevel = (int)tbTextLogoTransp.Value;

            textLogo.Update();
        }

        private void tbImageLogoTransp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void tbTextLogoTransp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cbTextLogo_CheckedChanged(null, null);
        }

        private void cbVideoInputDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVideoInputDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureDevice = e.AddedItems[0].ToString();

                cbVideoInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == e.AddedItems[0].ToString());
                if (deviceItem == null)
                {
                    return;
                }

                foreach (var format in deviceItem.VideoFormats)
                {
                    cbVideoInputFormat.Items.Add(format);
                }

                if (cbVideoInputFormat.Items.Count > 0)
                {
                    cbVideoInputFormat.SelectedIndex = 0;
                    cbVideoInputFormat_SelectedIndexChanged(null, null);
                }

                cbFramerate.Items.Clear();

                foreach (var frameRate in deviceItem.VideoFrameRates)
                {
                    cbFramerate.Items.Add(frameRate);
                }

                if (cbFramerate.Items.Count > 0)
                {
                    cbFramerate.SelectedIndex = 0;
                }

                btVideoCaptureDeviceSettings.IsEnabled = deviceItem.DialogDefault;
            }
        }

        private void cbVideoInputFormat_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVideoInputFormat.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureFormat = cbVideoInputFormat.Text;
            }
            else
            {
                VideoCapture1.Video_CaptureFormat = string.Empty;
            }
        }

        private void cbUseBestVideoInputFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbVideoInputFormat.IsEnabled = (bool)(!cbUseBestVideoInputFormat.IsChecked);
        }

        private void btVideoCaptureDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbVideoInputDevice.Text);
        }

        private void tbAudioVolume_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_OutputDevice_Volume_Set((int)tbAudioVolume.Value);
            }
        }

        private void tbAudioBalance_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_OutputDevice_Balance_Set((int)tbAudioBalance.Value);
            VideoCapture1.Audio_OutputDevice_Balance_Get();
        }

        private void btSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btDVFF_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.FastForward);
        }

        private void btDVPause_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Pause);
        }

        private void btDVRewind_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Rew);
        }

        private void btDVPlay_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Play);
        }

        private void btDVStepFWD_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepFw);
        }

        private void btDVStepRev_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepRev);
        }

        private void btDVStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Stop);
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            mmLog.Clear();

            VideoCapture1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            if (cbRecordAudio.IsChecked == true)
            {
                VideoCapture1.Audio_RecordAudio = true;
                VideoCapture1.Audio_PlayAudio = false;
            }
            else
            {
                VideoCapture1.Audio_RecordAudio = false;
                VideoCapture1.Audio_PlayAudio = false;
            }

            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text;
            VideoCapture1.Video_CaptureDevice_IsAudioSource = true;
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            VideoCapture1.Video_CaptureFormat = cbVideoInputFormat.Text;
            VideoCapture1.Video_CaptureFormat_UseBest = cbUseBestVideoInputFormat.IsChecked == true;            

            if (cbFramerate.SelectedIndex != -1)
            {
                VideoCapture1.Video_FrameRate = (float)Convert.ToDouble(cbFramerate.Text);
            }

            if (rbPreview.IsChecked == true)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
                VideoCapture1.Output_Filename = edOutput.Text;

                if (rbAVI.IsChecked == true)
                {
                    var aviOutput = new VFAVIOutput();

                    aviOutput.ACM.Name = cbAudioCodecs.Text;
                    aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
                    aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
                    aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);

                    aviOutput.Video_Codec = cbVideoCodecs.Text;

                    VideoCapture1.Output_Format = aviOutput;
                }
                else if (rbWMV.IsChecked == true)
                {
                    var wmvOutput = new VFWMVOutput();

                    wmvOutput.Mode = VFWMVMode.InternalProfile;

                    if (cbWMVInternalProfile9.SelectedIndex != -1)
                    {
                        wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                    }

                    VideoCapture1.Output_Format = wmvOutput;
                }
                else if (rbDVDirectstream.IsChecked == true)
                {
                    var dvDirectcaptureOutput = new VFDirectCaptureDVOutput();
                    VideoCapture1.Output_Format = dvDirectcaptureOutput;
                }
                else
                {
                    var dvOutput = new VFDVOutput();

                    dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text);
                    dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text);

                    if (rbDVPAL.IsChecked == true)
                    {
                        dvOutput.Video_Format = VFDVVideoFormat.PAL;
                    }
                    else
                    {
                        dvOutput.Video_Format = VFDVVideoFormat.NTSC;
                    }

                    dvOutput.Type2 = rbDVType2.IsChecked == true;

                    VideoCapture1.Output_Format = dvOutput;
                }
            }

            VideoCapture1.Video_Effects_Enabled = true;
            VideoCapture1.Video_Effects_Clear();

            IVFVideoEffectDeinterlaceCAVT cavt = new VFVideoEffectDeinterlaceCAVT(true, 20);
            VideoCapture1.Video_Effects_Add(cavt);

            VideoCapture1.Start();
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Stop();
        }

        private void llVideoTutorials_LinkClicked(object sender, MouseButtonEventArgs e)
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
            if (cbLicensing.IsChecked == true)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }
    }
}

// ReSharper restore InconsistentNaming