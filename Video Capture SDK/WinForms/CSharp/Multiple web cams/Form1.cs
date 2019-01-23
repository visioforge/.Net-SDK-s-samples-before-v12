// ReSharper disable InconsistentNaming

namespace multiple_ap_cams
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;

    public partial class Form1 : Form
    {
        private readonly System.Timers.Timer tmRecording1 = new System.Timers.Timer(1000);

        private readonly System.Timers.Timer tmRecording2 = new System.Timers.Timer(1000);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart1_Click(object sender, EventArgs e)
        {
            videoCapture1.Video_CaptureDevice = cbCamera1.Text;

            var deviceItem = videoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera1.Text);
            if (deviceItem == null)
            {
                return;
            }

            var formats = deviceItem.VideoFormats;
            videoCapture1.Video_CaptureDevice_Format_UseBest = false;
            foreach (var format in formats)
            {
                if (format.Contains("1280x720"))
                {
                    videoCapture1.Video_CaptureDevice_Format = format;
                    break;
                }
                else if (format.Contains("1920x1080"))
                {
                    videoCapture1.Video_CaptureDevice_Format = format;
                    break;
                }
            }

            var frameRates = deviceItem.VideoFrameRates;
            if (frameRates.Contains("25"))
            {
                videoCapture1.Video_CaptureDevice_FrameRate = 25;
            }
            else if (frameRates.Contains("30"))
            {
                videoCapture1.Video_CaptureDevice_FrameRate = 30;
            }
            else
            {
                videoCapture1.Video_CaptureDevice_FrameRate = Convert.ToInt32(frameRates[frameRates.Count - 1]);
            }

            videoCapture1.OnError += VideoCapture1OnOnError;
            videoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
            videoCapture1.Audio_PlayAudio = false;
            videoCapture1.Start();

            tmRecording1.Start();
        }

        private void VideoCapture1OnOnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + "CAM1: " + e.Message + Environment.NewLine;
        }

        private void btStop1_Click(object sender, EventArgs e)
        {
            tmRecording1.Stop();

            videoCapture1.Stop();
        }

        private void btStart2_Click(object sender, EventArgs e)
        {
            videoCapture2.Video_CaptureDevice = cbCamera2.Text;
            
            var deviceItem = videoCapture2.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera2.Text);
            if (deviceItem == null)
            {
                return;
            }

            var formats = deviceItem.VideoFormats;
            videoCapture2.Video_CaptureDevice_Format_UseBest = false;
            foreach (var format in formats)
            {
                if (format.Contains("1280x720"))
                {
                    videoCapture2.Video_CaptureDevice_Format = format;
                    break;
                }
                else if (format.Contains("1920x1080"))
                {
                    videoCapture2.Video_CaptureDevice_Format = format;
                    break;
                }
            }

            var frameRates = deviceItem.VideoFrameRates;
            if (frameRates.Contains("25"))
            {
                videoCapture2.Video_CaptureDevice_FrameRate = 25;
            }
            else if (frameRates.Contains("30"))
            {
                videoCapture2.Video_CaptureDevice_FrameRate = 30;
            }
            else
            {
                videoCapture2.Video_CaptureDevice_FrameRate = Convert.ToInt32(frameRates[frameRates.Count - 1]);
            }

            videoCapture2.OnError += VideoCapture2OnOnError;
            videoCapture2.Mode = VFVideoCaptureMode.VideoPreview;
            videoCapture2.Audio_PlayAudio = false;
            videoCapture2.Start();

            tmRecording2.Start();
        }

        private void VideoCapture2OnOnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + "CAM2: " + e.Message + Environment.NewLine;
        }

        private void btStop2_Click(object sender, EventArgs e)
        {
            tmRecording2.Stop();

            videoCapture2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + videoCapture1.SDK_Version + ", " + videoCapture1.SDK_State + ")";
            
            tmRecording1.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime1();
            };

            tmRecording2.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime2();
            };

            foreach (var device in videoCapture1.Video_CaptureDevicesInfo)
            {
                cbCamera1.Items.Add(device.Name);
                cbCamera2.Items.Add(device.Name);
            }

            if (cbCamera1.Items.Count > 0)
            {
                cbCamera1.SelectedIndex = 0;
                cbCamera2.SelectedIndex = 0;
            }

            if (VideoCapture.Filter_Supported_EVR())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (VideoCapture.Filter_Supported_VMR9())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
        }

        private void videoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void videoCapture2_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void UpdateRecordingTime1()
        {
            long timestamp = videoCapture1.Duration_Time();

            if (timestamp < 0)
            {
                return;
            }

            BeginInvoke((Action)(() =>
            {
                var ts = TimeSpan.FromMilliseconds(timestamp);
                lbTimestamp1.Text = "Recording time: " + ts.ToString(@"hh\:mm\:ss");
            }));
        }

        private void UpdateRecordingTime2()
        {
            long timestamp = videoCapture2.Duration_Time();

            if (timestamp < 0)
            {
                return;
            }

            BeginInvoke((Action)(() =>
            {
                var ts = TimeSpan.FromMilliseconds(timestamp);
                lbTimestamp2.Text = "Recording time: " + ts.ToString(@"hh\:mm\:ss");
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop1_Click(null, null);
            btStop2_Click(null, null);
        }
    }
}

// ReSharper restore InconsistentNaming