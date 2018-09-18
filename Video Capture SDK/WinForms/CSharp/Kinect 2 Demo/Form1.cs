using System;
using System.Linq;
using System.Windows.Forms;
using VisioForge.Kinect2;

namespace Kinect_2_Demo
{
    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;

    public partial class Form1 : Form
    {
        private KinectSource kinect;

        public Form1()
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

        private void ApplyMP4Settings(ref VFMP4Output mp4Output)
        {
            if (IsWindows7OrNewer())
            {
                mp4Output.MP4Mode = VFMP4Mode.v10;
            }
            else
            {
                mp4Output.MP4Mode = VFMP4Mode.v8;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            kinect.SensorID = cbKinectDevice.SelectedIndex;
            
            if (rbUseVideoSource.Checked)
            {
                kinect.Video_Source = VFKinectVideoSource.Video;
            }
            else
            {
                kinect.Video_Source = VFKinectVideoSource.DepthGrayscale;
            }

            VideoCapture1.Audio_CaptureDevice = cbAudioCaptureDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioCaptureFormat.Text;
            VideoCapture1.Audio_RecordAudio = true;
            VideoCapture1.Audio_PlayAudio = true;

            if (rbPreview.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.KinectPreview;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.KinectCapture;  

                VideoCapture1.Output_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp4";

                var mp4Output = new VFMP4Output();
                ApplyMP4Settings(ref mp4Output);
                VideoCapture1.Output_Format = mp4Output;
            }

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

            VideoCapture1.Audio_PlayAudio = false;

            kinect.Init(VideoCapture1.Core);
            kinect.Start();
        }

        public void kinect_OnKinectReadyToStart(object sender, EventArgs e)
        {
            VideoCapture1.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.Stop();
            kinect.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kinect = new KinectSource();
            kinect.OnKinectReadyToStart += kinect_OnKinectReadyToStart;
            
            cbKinectDevice.Items.Add("0");

            if (cbKinectDevice.Items.Count > 0)
            {
                cbKinectDevice.SelectedIndex = 0;
            }

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                if (device.Name.ToUpper().Contains("XBOX"))
                {
                    cbAudioCaptureDevice.Items.Add(device.Name);
                }
            }

            if (cbAudioCaptureDevice.Items.Count > 0)
            {
                cbAudioCaptureDevice.SelectedIndex = 0;
                cbAudioCaptureDevice_SelectedIndexChanged(null, null);
            }
        }

        private void cbAudioCaptureDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAudioCaptureDevice.SelectedIndex != -1)
            {
                VideoCapture1.Audio_CaptureDevice = cbAudioCaptureDevice.Text;
                cbAudioCaptureFormat.Items.Clear();

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioCaptureDevice.Text);
                foreach (string format in deviceItem.Formats)
                {
                    cbAudioCaptureFormat.Items.Add(format);
                }

                if (cbAudioCaptureFormat.Items.Count > 0)
                {
                    cbAudioCaptureFormat.SelectedIndex = 0;
                }
            }
        }

    }
}
