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
        public Form1()
        {
            InitializeComponent();
        }

        // private const string url = "http://212.162.177.75/mjpg/video.mjpg";
        // private const string url = "rtsp://media1.law.harvard.edu/Media/policy_a/2012/02/02_unger.mov";

        private void button1_Click(object sender, EventArgs e)
        {
            videoCapture1.Video_CaptureDevice = cbCamera1.Text;
            videoCapture1.Video_CaptureDevice_Format_UseBest = true;

            var deviceItem = videoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera1.Text);
            if (deviceItem == null)
            {
                return;
            }

            var frameRates = deviceItem.VideoFrameRates;
            videoCapture1.Video_CaptureDevice_FrameRate = Convert.ToInt32(frameRates[frameRates.Count - 1]);

            videoCapture1.OnError += VideoCapture1OnOnError;
            videoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
            videoCapture1.Audio_PlayAudio = false;
            videoCapture1.Start();
        }

        private void VideoCapture1OnOnError(object sender, ErrorsEventArgs errorsEventArgs)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoCapture2.Video_CaptureDevice = cbCamera2.Text;
            videoCapture2.Video_CaptureDevice_Format_UseBest = true;

            var deviceItem = videoCapture2.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera2.Text);
            if (deviceItem == null)
            {
                return;
            }

            var frameRates = deviceItem.VideoFrameRates;
            videoCapture2.Video_CaptureDevice_FrameRate = Convert.ToInt32(frameRates[frameRates.Count - 1]);
            
            videoCapture2.OnError += VideoCapture2OnOnError;
            videoCapture2.Mode = VFVideoCaptureMode.VideoPreview;
            videoCapture2.Audio_PlayAudio = false;
            videoCapture2.Start();
        }

        private void VideoCapture2OnOnError(object sender, ErrorsEventArgs errorsEventArgs)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            videoCapture2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + videoCapture1.SDK_Version + ", " + videoCapture1.SDK_State + ")";

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
            
        }
    }
}

// ReSharper restore InconsistentNaming