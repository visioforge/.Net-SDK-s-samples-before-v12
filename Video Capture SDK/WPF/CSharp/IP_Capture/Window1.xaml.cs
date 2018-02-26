// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
// ReSharper disable StyleCop.SA1601
namespace IP_Capture
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Shared.IPCameraDB;
    using VisioForge.Tools;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;

    public partial class Window1
    {
        private readonly Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();

        private ONVIFControl onvifControl;

        private ONVIFPTZRanges onvifPtzRanges;

        private float onvifPtzX;

        private float onvifPtzY;

        private float onvifPtzZoom;

        public Window1()
        {
            InitializeComponent();
        }

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

        private void lbVLCRedist_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe");
            Process.Start(startInfo);
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

            cbImageType.SelectedIndex = 1;
            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbIPCameraType.SelectedIndex = 2;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutputAVI.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputMP4.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp4";
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
            lbJPEGQuality.Content = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void btSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutputAVI.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl != null)
            {
                onvifControl.Disconnect();
                onvifControl.Dispose();
                onvifControl = null;

                btONVIFConnect.Content = "Connect";
            }
            
            mmLog.Clear();

            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            VideoCapture1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Audio_RecordAudio = false;
            VideoCapture1.Audio_PlayAudio = false;

            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

            // source
            VideoCapture1.IP_Camera_Source = new IPCameraSourceSettings
                                                 {
                                                     URL = this.edIPUrl.Text
                                                 };

            switch (cbIPCameraType.SelectedIndex)
            {
                case 0: VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_VLC;
                    break;
                case 1: VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_FFMPEG;
                    break;
                case 2: VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_LAV;
                    break;
                case 3: VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_Live555;
                    break;
                case 4: VideoCapture1.IP_Camera_Source.Type = VFIPSource.HTTP_FFMPEG;
                    break;
                case 5: VideoCapture1.IP_Camera_Source.Type = VFIPSource.MMS_WMV;
                    break;
                case 6: VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_UDP_FFMPEG;
                    break;
                case 7: VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_TCP_FFMPEG;
                    break;
                case 8: VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_HTTP_FFMPEG;
                    break;
            }

            VideoCapture1.IP_Camera_Source.AudioCapture = cbIPAudioCapture.IsChecked == true;
            VideoCapture1.IP_Camera_Source.Login = edIPLogin.Text;
            VideoCapture1.IP_Camera_Source.Password = edIPPassword.Text;
            VideoCapture1.IP_Camera_Source.VLC_ZeroClockJitterEnabled = cbVLCZeroClockJitter.IsChecked == true;
            VideoCapture1.IP_Camera_Source.VLC_CustomLatency = Convert.ToInt32(edVLCCacheSize.Text);
            VideoCapture1.IP_Camera_Source.ForcedFramerate = Convert.ToDouble(edIPForcedFramerate.Text);
            VideoCapture1.IP_Camera_Source.ForcedFramerate_InstanceID = edIPForcedFramerateID.Text[0];

            if (cbIPCameraONVIF.IsChecked == true)
            {
                VideoCapture1.IP_Camera_Source.ONVIF_Source = true;

                if (cbONVIFProfile.SelectedIndex != -1)
                {
                    VideoCapture1.IP_Camera_Source.ONVIF_SourceProfile = cbONVIFProfile.Text;
                }
            }

            if (cbIPDisconnect.IsChecked == true)
            {
                VideoCapture1.IP_Camera_Source.DisconnectEventInterval = 5000;
            }

            if (rbPreview.IsChecked == true)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.IPPreview;
            }
            else if (rbCaptureAVI.IsChecked == true)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.IPCapture;

                VideoCapture1.Output_Filename = edOutputAVI.Text;

                var aviOutput = new VFAVIOutput
                                    {
                                        ACM =
                                            {
                                                Name = this.cbAudioCodecs.Text,
                                                Channels = Convert.ToInt32(this.cbChannels.Text),
                                                BPS = Convert.ToInt32(this.cbBPS.Text),
                                                SampleRate = Convert.ToInt32(this.cbSampleRate.Text)
                                            },
                                        Video_Codec = this.cbVideoCodecs.Text
                                    };
                
                VideoCapture1.Output_Format = aviOutput;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.IPCapture;

                VideoCapture1.Output_Filename = edOutputMP4.Text;

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

        private void llVideoTutorials_LinkClicked(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void btSelectOutputMP4_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutputMP4.Text = saveFileDialog1.FileName;
            }
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.IsChecked == true)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void btShowIPCamDatabase_Click(object sender, RoutedEventArgs e)
        {
            IPCameraDB.ShowWindow();
        }

        private void btONVIFConnect_Click(object sender, RoutedEventArgs e)
        {
            if (btONVIFConnect.Content.ToString() == "Connect")
            {
                btONVIFConnect.Content = "Disconnect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }

                if (string.IsNullOrEmpty(edIPLogin.Text) || string.IsNullOrEmpty(this.edIPPassword.Text))
                {
                    MessageBox.Show("Please specify IP camera user name and password.");
                    return;
                }

                onvifControl = new ONVIFControl();
                var result = onvifControl.Connect(edIPUrl.Text, edIPLogin.Text, edIPPassword.Text);
                if (!result)
                {
                    onvifControl = null;
                    MessageBox.Show("Unable to connect to ONVIF camera.");
                    return;
                }

                var deviceInfo = onvifControl.GetDeviceInformation();
                lbONVIFCameraInfo.Content = $"Model {deviceInfo.Model}, Firmware {deviceInfo.Firmware}";

                cbONVIFProfile.Items.Clear();
                var profiles = onvifControl.GetProfiles();
                foreach (var profile in profiles)
                {
                    cbONVIFProfile.Items.Add($"{profile.Name}");
                }

                if (cbONVIFProfile.Items.Count > 0)
                {
                    cbONVIFProfile.SelectedIndex = 0;
                }

                onvifPtzRanges = onvifControl.PTZ_GetRanges();
                onvifControl.PTZ_SetAbsolute(0, 0, 0);

                onvifPtzX = 0;
                onvifPtzY = 0;
                onvifPtzZoom = 0;
            }
            else
            {
                btONVIFConnect.Content = "Connect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }
            }
        }

        private void btONVIFRight_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30;
            onvifPtzX = onvifPtzX - step;

            if (onvifPtzX < onvifPtzRanges.MinX)
            {
                onvifPtzX = onvifPtzRanges.MinX;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFPTZSetDefault_Click(object sender, RoutedEventArgs e)
        {
            onvifControl?.PTZ_SetAbsolute(0, 0, 0);
        }

        private void btONVIFLeft_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30;
            onvifPtzX = onvifPtzX + step;

            if (onvifPtzX > onvifPtzRanges.MaxX)
            {
                onvifPtzX = onvifPtzRanges.MaxX;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFUp_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30;
            onvifPtzY = onvifPtzY - step;

            if (onvifPtzY < onvifPtzRanges.MinY)
            {
                onvifPtzY = onvifPtzRanges.MinY;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFDown_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30;
            onvifPtzY = onvifPtzY + step;

            if (onvifPtzY > onvifPtzRanges.MaxY)
            {
                onvifPtzY = onvifPtzRanges.MaxY;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFZoomIn_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100;
            onvifPtzZoom = onvifPtzZoom + step;

            if (onvifPtzZoom > onvifPtzRanges.MaxZoom)
            {
                onvifPtzZoom = onvifPtzRanges.MaxZoom;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFZoomOut_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100;
            onvifPtzZoom = onvifPtzZoom - step;

            if (onvifPtzZoom < onvifPtzRanges.MinZoom)
            {
                onvifPtzZoom = onvifPtzRanges.MinZoom;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }
    }
}

// ReSharper restore InconsistentNaming