// ReSharper disable InconsistentNaming
// ReSharper disable StyleCop.SA1600
// ReSharper disable StyleCop.SA1601
// ReSharper disable UseObjectOrCollectionInitializer

namespace VisioForge_SDK_4_IP_Camera_CSharp_Demo
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Shared.IPCameraDB;
    using VisioForge.Tools;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;

    public partial class Form1 : Form
    {
        private ONVIFControl onvifControl;

        private ONVIFPTZRanges onvifPtzRanges;

        private float onvifPtzX;

        private float onvifPtzY;

        private float onvifPtzZoom;

        public Form1()
        {
            InitializeComponent();
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

            cbImageType.SelectedIndex = 1;
            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbIPCameraType.SelectedIndex = 2;

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264TargetUsage.SelectedIndex = 3;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VisioForge\";
            edOutputAVI.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VisioForge\" + "output.avi";
            edOutputMP4.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\VisioForge\" + "output.mp4";
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

        private void btSaveScreenshot_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            switch (cbImageType.SelectedIndex)
            {
                case 0: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0); 
                    break;
                case 1: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, tbJPEGQuality.Value);
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
        
        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutputAVI.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (onvifControl != null)
            {
                onvifControl.Disconnect();
                onvifControl.Dispose();
                onvifControl = null;

                btONVIFConnect.Text = "Connect";
            }

            mmLog.Clear();

            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
       
            VideoCapture1.Audio_RecordAudio = true;
            VideoCapture1.Audio_PlayAudio = true;

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

            VideoCapture1.Video_Sample_Grabber_Enabled = true;

            // source
            VideoCapture1.IP_Camera_Source = new IPCameraSourceSettings
                                                 {
                                                     URL = edIPUrl.Text
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

            VideoCapture1.IP_Camera_Source.AudioCapture = cbIPAudioCapture.Checked;
            VideoCapture1.IP_Camera_Source.Login = edIPLogin.Text;
            VideoCapture1.IP_Camera_Source.Password = edIPPassword.Text;
            VideoCapture1.IP_Camera_Source.VLC_ZeroClockJitterEnabled = cbVLCZeroClockJitter.Checked;
            VideoCapture1.IP_Camera_Source.VLC_CacheSize = Convert.ToInt32(edVLCCacheSize.Text);

            if (cbIPCameraONVIF.Checked)
            {
                VideoCapture1.IP_Camera_Source.ONVIF_Source = true;

                if (cbONVIFProfile.SelectedIndex != -1)
                {
                    VideoCapture1.IP_Camera_Source.ONVIF_SourceProfile = cbONVIFProfile.Text;
                }
            }

            if (rbPreview.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.IPPreview;
            }
            else if (rbCaptureAVI.Checked)
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

            VideoCapture1.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.Stop();
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void llVideoTutorials_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void btSelectOutputMP4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutputMP4.Text = saveFileDialog1.FileName;
            }
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe");
            Process.Start(startInfo);
        }

        private void btShowIPCamDatabase_Click(object sender, EventArgs e)
        {
            IPCameraDB.ShowWindow();
        }

        private void btONVIFConnect_Click(object sender, EventArgs e)
        {
            if (btONVIFConnect.Text == "Connect")
            {
                btONVIFConnect.Text = "Disconnect";

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
                lbONVIFCameraInfo.Text = $"Model {deviceInfo.Model}, Firmware {deviceInfo.Firmware}";

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

                edONVIFLiveVideoURL.Text = onvifControl.GetVideoURL();

                onvifPtzRanges = onvifControl.PTZ_GetRanges();
                onvifControl.PTZ_SetAbsolute(0, 0, 0);

                onvifPtzX = 0;
                onvifPtzY = 0;
                onvifPtzZoom = 0;
            }
            else
            {
                btONVIFConnect.Text = "Connect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }
            }
        }

        private void btONVIFRight_Click(object sender, EventArgs e)
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

        private void btONVIFPTZSetDefault_Click(object sender, EventArgs e)
        {
            onvifControl?.PTZ_SetAbsolute(0, 0, 0);
        }

        private void btONVIFLeft_Click(object sender, EventArgs e)
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

        private void btONVIFUp_Click(object sender, EventArgs e)
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

        private void btONVIFDown_Click(object sender, EventArgs e)
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

        private void btONVIFZoomIn_Click(object sender, EventArgs e)
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

        private void btONVIFZoomOut_Click(object sender, EventArgs e)
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