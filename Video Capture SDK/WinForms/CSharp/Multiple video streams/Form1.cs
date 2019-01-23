// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
// ReSharper disable StyleCop.SA1601
namespace multiple_video_streams
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Properties;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;

    public partial class Form1 : Form
    {
        private VideoCapture videoCaptureHelper;
        
        public Form1()
        {
            InitializeComponent();
        }

        private readonly System.Timers.Timer tmRecording = new System.Timers.Timer(1000);

        private void btStart_Click(object sender, EventArgs e)
        {
            // 1st device
            videoCapture1.Video_CaptureDevice = cbCamera1.Text;
            videoCapture1.Video_CaptureDevice_Format_UseBest = false;
            videoCapture1.Video_CaptureDevice_Format = cbVideoFormat1.Text;
            videoCapture1.Video_CaptureDevice_FrameRate = Convert.ToDouble(cbVideoFrameRate1.Text);

            // 2nd device
            videoCapture1.PIP_Sources_Add_VideoCaptureDevice(
                cbCamera2.Text,
                cbVideoFormat2.Text,
                false,
                Convert.ToDouble(cbVideoFrameRate1.Text),
                cbCamera2.Text,
                0,
                0,
                320,
                240);

            var wmvOutput = new VFWMVOutput
                                {
                                    Mode = VFWMVMode.ExternalProfileFromText,
                                    External_Profile_Text = Resources.WMVProfile
                                };
            videoCapture1.Output_Format = wmvOutput;

            // main options
            videoCapture1.OnError += VideoCapture1OnOnError;

            videoCapture1.Output_Filename = edFilename.Text;
            videoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
            videoCapture1.PIP_Mode = VFPIPMode.MultipleVideoStreams;
            videoCapture1.PIP_AddSampleGrabbers = true;
            videoCapture1.Audio_PlayAudio = false;
            videoCapture1.Audio_RecordAudio = false;

            videoCapture1.Debug_Mode = cbDebugMode.Checked;
            videoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            
            videoCapture1.Start();
            tmRecording.Start();
        }

        private void VideoCapture1OnOnError(object sender, ErrorsEventArgs errorsEventArgs)
        {
            edLog.Text += errorsEventArgs.Message + Environment.NewLine;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmRecording.Stop();
            videoCapture1.Stop();

            videoScreen2.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoCaptureHelper = new VideoCapture();
            Text += " (SDK v" + videoCaptureHelper.SDK_Version + ", " + videoCaptureHelper.SDK_State + ")";

            foreach (var device in videoCaptureHelper.Video_CaptureDevicesInfo)
            {
                cbCamera1.Items.Add(device.Name);
                cbCamera2.Items.Add(device.Name);
            }

            if (cbCamera1.Items.Count > 0)
            {
                cbCamera1.SelectedIndex = 0;
                cbCamera2.SelectedIndex = 0;
            }

            edFilename.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\"
                              + "multiple_video_streams.wmv";

            if (VideoCapture.Filter_Supported_EVR())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (VideoCapture.Filter_Supported_VMR9())
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                videoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }

            tmRecording.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime();
            };
        }

        private void cbCamera1_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCaptureHelper.Video_CaptureDevice = cbCamera1.Text;

            var deviceItem = videoCaptureHelper.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera1.Text);
            if (deviceItem == null)
            {
                return;
            }

            var frameRates = deviceItem.VideoFrameRates;

            cbVideoFrameRate1.Items.Clear();
            foreach (var frameRate in frameRates)
            {
                cbVideoFrameRate1.Items.Add(frameRate);
            }

            if (cbVideoFrameRate1.Items.Count > 4)
            {
                cbVideoFrameRate1.SelectedIndex = 4;
            }

            var formats = deviceItem.VideoFormats;

            cbVideoFormat1.Items.Clear();
            foreach (var format in formats)
            {
                cbVideoFormat1.Items.Add(format);
            }

            if (cbVideoFormat1.Items.Count > 4)
            {
                cbVideoFormat1.SelectedIndex = 4;
            }
        }

        private void cbCamera2_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCaptureHelper.Video_CaptureDevice = cbCamera2.Text;

            var deviceItem = videoCaptureHelper.Video_CaptureDevicesInfo.First(device => device.Name == cbCamera2.Text);
            if (deviceItem == null)
            {
                return;
            }

            var frameRates = deviceItem.VideoFrameRates;

            cbVideoFrameRate2.Items.Clear();
            foreach (var frameRate in frameRates)
            {
                cbVideoFrameRate2.Items.Add(frameRate);
            }

            if (cbVideoFrameRate2.Items.Count > 4)
            {
                cbVideoFrameRate2.SelectedIndex = 4;
            }

            var formats = deviceItem.VideoFormats;

            cbVideoFormat2.Items.Clear();
            foreach (var format in formats)
            {
                cbVideoFormat2.Items.Add(format);
            }

            if (cbVideoFormat2.Items.Count > 4)
            {
                cbVideoFormat2.SelectedIndex = 4;
            }
        }

        private void videoCapture1_OnVideoFrameBitmap(object sender, VideoFrameBitmapEventArgs e)
        {
            if (e.SourceStream == VFVideoStreamType.PIP1)
            {
                videoScreen2.Image = e.Frame;
            }
        }

        private void videoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                edLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void UpdateRecordingTime()
        {
            long timestamp = videoCapture1.Duration_Time();

            if (timestamp < 0)
            {
                return;
            }

            BeginInvoke((Action)(() =>
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(timestamp);
                lbTimestamp.Text = $"Recording time: " + ts.ToString(@"hh\:mm\:ss");
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(null, null);
        }
    }
}

// ReSharper restore InconsistentNaming