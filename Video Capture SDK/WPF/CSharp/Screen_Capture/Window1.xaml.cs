// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
// ReSharper disable StyleCop.SA1601
namespace Screen_Capture
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;
    using VisioForge.Types.VideoEffects;

    using MessageBox = System.Windows.Forms.MessageBox;

    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class Window1
    {
        private bool IsWindows7OrNewer()
        {
            var version = Environment.OSVersion.Version;
            if (version.Major > 6)
            {
                return true;
            }

            if (version.Major == 6 && version.Minor >= 1)
            {
                return true;
            }

            return false;
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        
        // Dialogs
        private readonly FontDialog fontDialog = new FontDialog();
        private readonly Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog2 = new Microsoft.Win32.OpenFileDialog();

        public Window1()
        {
            InitializeComponent();
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

        private void btScreenCaptureUpdate_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Screen_Capture_UpdateParameters(Convert.ToInt32(edScreenLeft.Text), Convert.ToInt32(edScreenTop.Text), cbScreenCapture_GrabMouseCursor.IsChecked == true);
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
                System.Windows.MessageBox.Show("Unable to configure image logo effect.");
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
                case 0:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0);
                    break;
                case 1:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, (int)tbJPEGQuality.Value);
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

        private void cbAudioInputDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
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

                cbAudioInputFormat_SelectedIndexChanged(null, null);

                cbAudioInputLine.Items.Clear();

                foreach (var line in deviceItem.Lines)
                {
                    cbAudioInputLine.Items.Add(line);
                }

                if (cbAudioInputLine.Items.Count > 0)
                {
                    cbAudioInputLine.SelectedIndex = 0;
                }

                cbAudioInputLine_SelectedIndexChanged(null, null);

                btAudioInputDeviceSettings.IsEnabled = deviceItem.DialogDefault;
            }
        }

        private void btAudioInputDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void cbAudioInputFormat_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Format = e.AddedItems[0].ToString();
        }

        private void cbAudioInputLine_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Line = e.AddedItems[0].ToString();
        }

        private void cbUseBestAudioInputFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAudioInputFormat.IsEnabled = cbUseBestAudioInputFormat.IsChecked == false;
        }

        private void btSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            mmLog.Clear();

            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            VideoCapture1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            // from screen
            VideoCapture1.Screen_Capture_Source = new ScreenCaptureSourceSettings();

            if (rbScreenCaptureWindow.IsChecked == true)
            {
                VideoCapture1.Screen_Capture_Source.Mode = VFScreenCaptureMode.Window;

                VideoCapture1.Screen_Capture_Source.WindowHandle = IntPtr.Zero;

                try
                {
                    VideoCapture1.Screen_Capture_Source.WindowHandle = FindWindow(edScreenCaptureWindowName.Text, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get window handle for screen capture. " + ex.Message);
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
            VideoCapture1.Screen_Capture_Source.FullScreen = rbScreenFullScreen.IsChecked == true;
            VideoCapture1.Screen_Capture_Source.Top = Convert.ToInt32(edScreenTop.Text);
            VideoCapture1.Screen_Capture_Source.Bottom = Convert.ToInt32(edScreenBottom.Text);
            VideoCapture1.Screen_Capture_Source.Left = Convert.ToInt32(edScreenLeft.Text);
            VideoCapture1.Screen_Capture_Source.Right = Convert.ToInt32(edScreenRight.Text);
            VideoCapture1.Screen_Capture_Source.GrabMouseCursor = cbScreenCapture_GrabMouseCursor.IsChecked == true;
            VideoCapture1.Screen_Capture_Source.DisplayIndex = Convert.ToInt32(cbScreenCaptureDisplayIndex.Text);
            VideoCapture1.Screen_Capture_Source.AllowDesktopDuplicationEngine = cbScreenCapture_DesktopDuplication.IsChecked == true;

            if (cbRecordAudio.IsChecked == true)
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

            // apply capture parameters
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

            VideoCapture1.Video_Effects_Enabled = true;
            VideoCapture1.Video_Effects_Clear();

            if (cbMode.SelectedIndex == 0)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenPreview;
            }
            else if (cbMode.SelectedIndex == 1)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture;

                VideoCapture1.Output_Filename = edOutput.Text;
                var aviOutput = new VFAVIOutput
                                    {
                                        ACM =
                                            {
                                                Name = cbAudioCodecs.Text,
                                                Channels = Convert.ToInt32(cbChannels.Text),
                                                BPS = Convert.ToInt32(cbBPS.Text),
                                                SampleRate = Convert.ToInt32(cbSampleRate.Text)
                                            },
                                        Video_Codec = cbVideoCodecs.Text
                                    };

                VideoCapture1.Output_Format = aviOutput;
            }
            else if (cbMode.SelectedIndex == 2)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture;

                VideoCapture1.Output_Filename = edOutput.Text;
                var wmvOutput = new VFWMVOutput
                                    {
                                        Mode = VFWMVMode.InternalProfile
                                    };

                if (cbWMVInternalProfile9.SelectedIndex != -1)
                {
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                }

                VideoCapture1.Output_Format = wmvOutput;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture;

                VideoCapture1.Output_Filename = edOutput.Text;

                var mp4Output = new VFMP4Output();

                if (IsWindows7OrNewer())
                {
                    mp4Output.MP4Mode = VFMP4Mode.v11;
                }
                else
                {
                    mp4Output.MP4Mode = VFMP4Mode.v8;
                }

                VideoCapture1.Output_Format = mp4Output;
            }

            VideoCapture1.Start();
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Stop();
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

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                cbAudioInputDevice.Items.Add(device.Name);
            }

            if (cbAudioInputDevice.Items.Count > 0)
            {
                cbAudioInputDevice.SelectedIndex = 0;
                cbAudioInputDevice_SelectedIndexChanged(null, null);
            }

            foreach (var profile in VideoCapture1.WMV_Internal_Profiles())
            {
                cbWMVInternalProfile9.Items.Add(profile);
            }

            if (cbWMVInternalProfile9.Items.Count > 0)
            {
                cbWMVInternalProfile9.SelectedIndex = 0;
            }

            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbImageType.SelectedIndex = 1;

            cbMode.SelectedIndex = 0;

            foreach (var screen in Screen.AllScreens)
            {
                cbScreenCaptureDisplayIndex.Items.Add(screen.DeviceName.Replace(@"\\.\DISPLAY", string.Empty));
            }

            cbScreenCaptureDisplayIndex.SelectedIndex = 0;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
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