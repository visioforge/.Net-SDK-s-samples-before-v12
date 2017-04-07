// ReSharper disable InconsistentNaming

namespace Simple_Video_Capture
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.VideoEffects;

    using MessageBox = System.Windows.Forms.MessageBox;

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class Window1
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Dialogs
        private readonly FontDialog fontDialog = new FontDialog();

        private static bool OpenFileDialog(string defaultExt, string filter, out string filename)
        {
            filename = string.Empty;

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
                                                     {
                                                         DefaultExt = defaultExt,
                                                         Filter = filter
                                                     };

            if (dlg.ShowDialog() == true)
            {
                filename = dlg.FileName;
                return true;
            }

            return false;
        }

        private static bool SaveFileDialog(string defaultExt, string filter, out string filename)
        {
            filename = string.Empty;

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
                                                     {
                DefaultExt = defaultExt,
                Filter = filter
            };

            if (dlg.ShowDialog() == true)
            {
                filename = dlg.FileName;
                return true;
            }

            return false;
        }

        private void btSelectImage_Click(object sender, RoutedEventArgs e)
        {
            string filename;
            if (OpenFileDialog(".jpg; *.bmp; *.gif;", "Images|*.jpg; *.bmp; *.gif;", out filename))
            {
                this.edImageLogoFilename.Text = filename;
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
                case 0:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0);
                    break;
                case 1:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, (int)tbJPEGQuality.Value);
                    break;
                case 2:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0);
                    break;
                case 3:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0);
                    break;
                case 4:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0);
                    break;
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

        private void tbGraphicLogoTransp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void tbTextLogoTransp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cbTextLogo_CheckedChanged(null, null);
        }

        private void btAudioInputDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

            cbVideoInputDevice_SelectionChanged(null, null);

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                cbAudioInputDevice.Items.Add(device.Name);
            }

            if (cbAudioInputDevice.Items.Count > 0)
            {
                cbAudioInputDevice.SelectedIndex = 0;
                cbAudioInputDevice_SelectionChanged(null, null);
            }

            cbAudioInputLine.Items.Clear();

            if (!string.IsNullOrEmpty(cbAudioInputDevice.Text))
            {
                var deviceItem =
                    VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem != null)
                {
                    foreach (var line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }

                    if (cbAudioInputLine.Items.Count > 0)
                    {
                        cbAudioInputLine.SelectedIndex = 0;
                        cbAudioInputLine_SelectionChanged(null, null);
                        cbAudioInputFormat_SelectionChanged(null, null);
                    }
                }
            }

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
            cbImageType.SelectedIndex = 1;

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbAACOutput.SelectedIndex = 0;
            cbAACMPEGVersion.SelectedIndex = 0;
            cbAACObject.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264TargetUsage.SelectedIndex = 3;

            cbMode.SelectedIndex = 0;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
        }

        private void btSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            string filename;
            if (SaveFileDialog(".jpg; *.bmp; *.gif;", "Images|*.jpg; *.bmp; *.gif;", out filename))
            {
                edOutput.Text = filename;
            }
        }

        private void cbUseBestAudioInputFormat_Checked(object sender, RoutedEventArgs e)
        {
            cbAudioInputFormat.IsEnabled = cbUseBestAudioInputFormat.IsChecked == false;
        }

        private void cbUseAudioInputFromVideoCaptureDevice_Checked(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbVideoInputDevice.Text))
            {
                VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.IsChecked == true;
                cbAudioInputDevice_SelectionChanged(null, null);

                cbAudioInputDevice.IsEnabled = cbUseAudioInputFromVideoCaptureDevice.IsChecked == false;
                btAudioInputDeviceSettings.IsEnabled = cbUseAudioInputFromVideoCaptureDevice.IsChecked == false;
            }
        }

        private void cbUseBestVideoInputFormat_Checked(object sender, RoutedEventArgs e)
        {
            cbVideoInputFormat.IsEnabled = cbUseBestVideoInputFormat.IsChecked == false;
        }

        private void btVideoCaptureDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbVideoInputDevice.Text);
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void tbAudioVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_OutputDevice_Volume_Set((int)tbAudioVolume.Value);
            }
        }

        private void tbAudioBalance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_OutputDevice_Balance_Set((int)tbAudioBalance.Value);
            VideoCapture1.Audio_OutputDevice_Balance_Get();
        }

        private void tbJPEGQuality_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbJPEGQuality.Content = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void lbViewVideoTutorials_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void cbVideoInputDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
                    cbVideoInputFormat_SelectionChanged(null, null);
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

                cbUseAudioInputFromVideoCaptureDevice.IsEnabled = deviceItem.AudioOutput;
                btVideoCaptureDeviceSettings.IsEnabled = deviceItem.DialogDefault;
            }
        }

        private void cbAudioInputDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbAudioInputDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Audio_CaptureDevice = e.AddedItems[0].ToString();
                cbAudioInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == e.AddedItems[0].ToString());
                if (deviceItem == null)
                {
                    return;
                }

                foreach (var format in deviceItem.Formats)
                {
                    cbAudioInputFormat.Items.Add(format);
                }

                if (cbAudioInputFormat.Items.Count > 0)
                {
                    cbAudioInputFormat.SelectedIndex = 0;
                }

                cbAudioInputFormat_SelectionChanged(null, null);

                cbAudioInputLine.Items.Clear();

                foreach (var line in deviceItem.Lines)
                {
                    cbAudioInputLine.Items.Add(line);
                }

                if (cbAudioInputLine.Items.Count > 0)
                {
                    cbAudioInputLine.SelectedIndex = 0;
                }

                cbAudioInputLine_SelectionChanged(null, null);

                btAudioInputDeviceSettings.IsEnabled = deviceItem.DialogDefault;
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            mmLog.Clear();

            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            VideoCapture1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Audio_OutputDevice = "Default DirectSound Device";

            if (cbRecordAudio.IsChecked == true)
            {
                VideoCapture1.Audio_RecordAudio = true;
                VideoCapture1.Audio_PlayAudio = true;
            }
            else
            {
                VideoCapture1.Audio_RecordAudio = false;
                VideoCapture1.Audio_PlayAudio = false;
            }

            // apply capture params
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text;
            VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.IsChecked == true;
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = cbUseBestAudioInputFormat.IsChecked == true;
            VideoCapture1.Video_CaptureFormat = cbVideoInputFormat.Text;
            VideoCapture1.Video_CaptureFormat_UseBest = cbUseBestVideoInputFormat.IsChecked == true;
            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;

            if (cbFramerate.SelectedIndex != -1)
            {
                VideoCapture1.Video_FrameRate = (float)Convert.ToDouble(cbFramerate.Text);
            }

            if (cbMode.SelectedIndex == 0)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
            }
            else if (cbMode.SelectedIndex == 1)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;

                VideoCapture1.Output_Filename = edOutput.Text;
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
                VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;

                VideoCapture1.Output_Filename = edOutput.Text;

                var wmvOutput = new VFWMVOutput();

                wmvOutput.Mode = VFWMVMode.InternalProfile;

                if (cbWMVInternalProfile9.SelectedIndex != -1)
                {
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                }

                VideoCapture1.Output_Format = wmvOutput;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;

                VideoCapture1.Output_Filename = edOutput.Text;

                var mp4Output = new VFMP4Output();
                
                int tmp;

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
                mp4Output.Video_H264.GOP = cbH264GOP.IsChecked == true;
                mp4Output.Video_H264.BitrateAuto = cbH264AutoBitrate.IsChecked == true;

                int.TryParse(edH264Bitrate.Text, out tmp);
                mp4Output.Video_H264.Bitrate = tmp;

                // Audio AAC settings
                int.TryParse(cbAACBitrate.Text, out tmp);
                mp4Output.Audio_AAC.Bitrate = tmp;

                mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACMPEGVersion.SelectedIndex;
                mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
                mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObject.SelectedIndex + 1);

                VideoCapture1.Output_Format = mp4Output;
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

        private void cbAudioInputFormat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Format = e.AddedItems[0].ToString();
        }

        private void cbAudioInputLine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Line = e.AddedItems[0].ToString();
        }

        private void cbVideoInputFormat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVideoInputFormat.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureFormat = e.AddedItems[0].ToString();
            }
            else
            {
                VideoCapture1.Video_CaptureFormat = string.Empty;
            }
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