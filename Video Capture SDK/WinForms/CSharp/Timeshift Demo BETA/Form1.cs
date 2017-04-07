using System;
using System.Linq;
using System.Windows.Forms;

namespace VC_Timeshift_Demo
{
    using System.Globalization;

    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";

            foreach (var device in VideoCapture1.Video_CaptureDevicesInfo)
            {
                cbVideoInputDevice.Items.Add(device.Name);
         }

            if (cbVideoInputDevice.Items.Count > 0)
            {
                cbVideoInputDevice.SelectedIndex = 0;
                cbVideoInputDevice_SelectedIndexChanged(null, null);
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

            cbOutputFormat.SelectedIndex = 0;
        }

        private void cbVideoInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVideoInputDevice.SelectedIndex != -1)
            {
                cbVideoInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbVideoInputDevice.Text);
                if (deviceItem == null)
                {
                    return;
                }

                foreach (string format in deviceItem.VideoFormats)
                {
                    cbVideoInputFormat.Items.Add(format);
                }

                if (cbVideoInputFormat.Items.Count > 0)
                {
                    cbVideoInputFormat.SelectedIndex = 0;
                    cbVideoInputFormat_SelectedIndexChanged(null, null);
                }

                cbFramerate.Items.Clear();

                foreach (string frameRate in deviceItem.VideoFrameRates)
                {
                    cbFramerate.Items.Add(frameRate);
                }

                if (cbFramerate.Items.Count > 0)
                {
                    cbFramerate.SelectedIndex = 0;
                }
                
                cbUseAudioInputFromVideoCaptureDevice.Enabled = deviceItem.AudioOutput;
            }
        }

        private void cbVideoInputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVideoInputFormat.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text;
            }
            else
            {
                VideoCapture1.Video_CaptureDevice_Format = string.Empty;
            }
        }

        private void cbAudioInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAudioInputFormat.Items.Clear();
            cbAudioInputLine.Items.Clear();

            if (cbUseAudioInputFromVideoCaptureDevice.Checked)
            {
                var deviceItem =
                    VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbVideoInputDevice.Text);
                if (deviceItem != null)
                {
                    foreach (string format in deviceItem.AudioFormats)
                    {
                        cbAudioInputFormat.Items.Add(format);
                    }

                    if (cbAudioInputFormat.Items.Count > 0)
                    {
                        cbAudioInputFormat.SelectedIndex = 0;
                    }
                }
            }
            else if (cbAudioInputDevice.SelectedIndex != -1)
            {
                VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem != null)
                {
                    foreach (string format in deviceItem.Formats)
                    {
                        cbAudioInputFormat.Items.Add(format);
                    }

                    if (cbAudioInputFormat.Items.Count > 0)
                    {
                        cbAudioInputFormat.SelectedIndex = 0;
                    }

                    foreach (string line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }

                    if (cbAudioInputLine.Items.Count > 0)
                    {
                        cbAudioInputLine.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmLog.Clear();

            VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;

            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = cbUseBestAudioInputFormat.Checked;

            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text;
            VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.Checked;
            VideoCapture1.Video_CaptureDevice_Format_UseBest = cbUseBestVideoInputFormat.Checked;
            VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text;

            if (cbFramerate.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureDevice_FrameRate = Convert.ToDouble(cbFramerate.Text, CultureInfo.CurrentCulture);
            }
            
            VideoCapture1.Audio_RecordAudio = true;
            VideoCapture1.Audio_PlayAudio = false;

            VideoCapture1.Timeshift_Settings = new TimeshiftSettings
                                                   {
                                                       Player_Screen = MediaPlayer1,
                                                       TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\SBE\\",
                                                       Player_AudioOutput_Enabled = cbPlayerPlayAudio.Checked
                                                   };
            var mp4Settings = new VFMP4Output();
            mp4Settings.Video_H264.IDR_Period = 5;

            VideoCapture1.Timeshift_Settings.EncodingSettings = mp4Settings;

            switch (cbOutputFormat.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    {
                        VideoCapture1.Output_Filename = edOutput.Text;
                        VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
                        var output = new VFAVIOutput();
                        VideoCapture1.Output_Format = output;
                    }

                    break;
                case 2:
                    {
                        VideoCapture1.Output_Filename = edOutput.Text;
                        VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
                        var output = new VFMP4Output();
                        VideoCapture1.Output_Format = output;
                    }

                    break;
                case 3:
                    {
                        VideoCapture1.Output_Filename = edOutput.Text;
                        VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
                        var output = new VFWebMOutput();
                        VideoCapture1.Output_Format = output;
                    }

                    break;
            }
            
            VideoCapture1.Start();

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Stop();
            VideoCapture1.Stop();
        }

        private void btPlayerPause_Click(object sender, EventArgs e)
        {
            VideoCapture1.Test();
            //MediaPlayer1.Pause();
        }

        private void btPlayerResume_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Resume();
        }

        private string FormatTime(TimeSpan span)
        {
            return span.ToString(@"hh\:mm\:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dur = (int)MediaPlayer1.Duration_Time();
            TimeSpan spanDur = new TimeSpan(0, 0, 0, 0, dur);
            lbDuration.Text = FormatTime(spanDur);

            tbTimeline.Maximum = dur / 1000;

            TimeSpan spanPos;
            int pos = (int)MediaPlayer1.Position_Get_Time() ;
            if (pos < dur)
            {
                spanPos = new TimeSpan(0, 0, 0, 0, pos);
                tbTimeline.Value = pos / 1000;
            }
            else
            {
                spanPos = new TimeSpan(0, 0, 0, 0, dur);
                tbTimeline.Value = dur / 1000;
            }

            lbPostion.Text = FormatTime(spanPos);
        }

        private void tbTimeline_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void tbTimeline_MouseUp(object sender, MouseEventArgs e)
        {
            MediaPlayer1.Position_Set_Time(tbTimeline.Value * 1000);

            timer1.Enabled = true;
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void MediaPlayer1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void VideoCapture1_OnTimeshiftFileCreated(object sender, TimeshiftFileEventArgs e)
        {
            MediaPlayer1.Debug_Mode = true;
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            
            string filename = e.Filename;

            MediaPlayer1.FilenamesOrURL.Clear();
            MediaPlayer1.FilenamesOrURL.Add(filename);

            MediaPlayer1.Source_Mode = VFMediaPlayerSource.Timeshift;

            MediaPlayer1.Play();
        }
    }
}
