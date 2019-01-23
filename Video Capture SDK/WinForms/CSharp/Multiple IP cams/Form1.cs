// ReSharper disable InconsistentNaming

namespace multiple_ap_cams
{
    using System;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.Sources;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly System.Timers.Timer tmRecording1 = new System.Timers.Timer(1000);

        private readonly System.Timers.Timer tmRecording2 = new System.Timers.Timer(1000);


        // private const string url = "http://212.162.177.75/mjpg/video.mjpg";
        // private const string url = "rtsp://media1.law.harvard.edu/Media/policy_a/2012/02/02_unger.mov";

        private void btStart1_Click(object sender, EventArgs e)
        {
            videoCapture1.IP_Camera_Source = new IPCameraSourceSettings
            {
                URL = edURL1.Text,
                Type = VFIPSource.Auto_LAV
            };
            videoCapture1.Mode = VFVideoCaptureMode.IPPreview;
            videoCapture1.Audio_PlayAudio = false;
            videoCapture1.Debug_Mode = cbDebugMode.Checked;
            videoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

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
            videoCapture2.IP_Camera_Source = new IPCameraSourceSettings
            {
                URL = edURL2.Text,
                Type = VFIPSource.Auto_LAV
            };
            videoCapture2.Mode = VFVideoCaptureMode.IPPreview;
            videoCapture2.Audio_PlayAudio = false;
            videoCapture2.Debug_Mode = cbDebugMode.Checked;
            videoCapture2.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

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
            Text += " (SDK v" + videoCapture2.SDK_Version + ", " + videoCapture2.SDK_State + ")";

            tmRecording1.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime1();
            };

            tmRecording2.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime2();
            };

            if (VideoCapture.Filter_Supported_EVR())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (VideoCapture.Filter_Supported_VMR9())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
                videoCapture2.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
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