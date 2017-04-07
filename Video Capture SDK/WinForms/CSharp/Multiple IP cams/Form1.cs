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

        // private const string url = "http://212.162.177.75/mjpg/video.mjpg";
        // private const string url = "rtsp://media1.law.harvard.edu/Media/policy_a/2012/02/02_unger.mov";

        private void button1_Click(object sender, EventArgs e)
        {
            videoCapture1.IP_Camera_Source = new IPCameraSourceSettings();
            videoCapture1.IP_Camera_Source.URL = edURL1.Text;
            videoCapture1.OnError += VideoCapture1OnOnError;
            videoCapture1.Mode = VFVideoCaptureMode.IPPreview;
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
            videoCapture2.IP_Camera_Source = new IPCameraSourceSettings();
            videoCapture2.IP_Camera_Source.URL = edURL2.Text;
            videoCapture2.OnError += VideoCapture2OnOnError;
            videoCapture2.Mode = VFVideoCaptureMode.IPPreview;
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
            Text += " (SDK v" + videoCapture2.SDK_Version + ", " + videoCapture2.SDK_State + ")";
        }

        private void videoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            
        }
    }
}

// ReSharper restore InconsistentNaming