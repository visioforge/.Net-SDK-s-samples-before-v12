// ReSharper disable StyleCop.SA1600

using VisioForge.Controls.UI.Dialogs.OutputFormats;
using VisioForge.Tools;
// ReSharper disable InconsistentNaming

namespace Push_Source_Demo
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;

    // ReSharper disable once StyleCop.SA1601
    public partial class Form1 : Form
    {
        private MFSettingsDialog mp4v11SettingsDialog;

        private MFSettingsDialog mpegTSSettingsDialog;

        private MFSettingsDialog movSettingsDialog;

        private MP4v10SettingsDialog mp4V10SettingsDialog;

        private AVISettingsDialog aviSettingsDialog;

        private MP3SettingsDialog mp3SettingsDialog;

        private WMVSettingsDialog wmvSettingsDialog;

        private DVSettingsDialog dvSettingsDialog;

        private WebMSettingsDialog webmSettingsDialog;

        private FFMPEGDLLSettingsDialog ffmpegDLLSettingsDialog;

        private FFMPEGEXESettingsDialog ffmpegEXESettingsDialog;

        private GIFSettingsDialog gifSettingsDialog;

        private readonly System.Timers.Timer tmRecording = new System.Timers.Timer(1000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            tmRecording.Elapsed += (senderx, args) =>
            {
                UpdateRecordingTime();
            };

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" +
                            "output.mp4";

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

            cbOutputFormat.SelectedIndex = 7;
        }

        private void UpdateRecordingTime()
        {
            long timestamp = VideoCapture1.Duration_Time();

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

        private void PushImages()
        {
            Bitmap bmp = null;
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 25; i++)
                {
                    switch (k)
                    {
                        case 0:
                            bmp = new Bitmap(Properties.Resources._1);
                            break;
                        case 1:
                            bmp = new Bitmap(Properties.Resources._2);
                            break;
                        case 2:
                            bmp = new Bitmap(Properties.Resources._3);
                            break;
                        case 3:
                            bmp = new Bitmap(Properties.Resources._4);
                            break;
                        case 4:
                            bmp = new Bitmap(Properties.Resources._5);
                            break;
                    }

                    if (bmp != null)
                    {
                        VideoCapture1.Push_Source_AddVideoFrame(bmp);
                        bmp.Dispose();
                    }

                    Application.DoEvents();
                }
            }

            VideoCapture1.Stop();

            tmRecording.Stop();

            MessageBox.Show("Done!");
        }


        private void SetMP4Output(ref VFMP4v8v10Output mp4Output)
        {
            if (mp4V10SettingsDialog == null)
            {
                mp4V10SettingsDialog = new MP4v10SettingsDialog();
            }

            mp4V10SettingsDialog.FillSettings(ref mp4Output);
        }

        private void SetFFMPEGEXEOutput(ref VFFFMPEGEXEOutput ffmpegOutput)
        {
            if (ffmpegEXESettingsDialog == null)
            {
                ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
            }

            ffmpegEXESettingsDialog.FillSettings(ref ffmpegOutput);
        }

        private void SetWMVOutput(ref VFWMVOutput wmvOutput)
        {
            if (wmvSettingsDialog == null)
            {
                wmvSettingsDialog = new WMVSettingsDialog(VideoCapture1.Core);
            }

            wmvSettingsDialog.WMA = false;
            wmvSettingsDialog.FillSettings(ref wmvOutput);
        }

        private void SetWebMOutput(ref VFWebMOutput webmOutput)
        {
            if (webmSettingsDialog == null)
            {
                webmSettingsDialog = new WebMSettingsDialog();
            }

            webmSettingsDialog.FillSettings(ref webmOutput);
        }

        private void SetFFMPEGDLLOutput(ref VFFFMPEGDLLOutput ffmpegDLLOutput)
        {
            if (ffmpegDLLSettingsDialog == null)
            {
                ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
            }

            ffmpegDLLSettingsDialog.FillSettings(ref ffmpegDLLOutput);
        }
               
        private void SetMP4v11Output(ref VFMP4v11Output mp4Output)
        {
            if (mp4v11SettingsDialog == null)
            {
                mp4v11SettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
            }

            mp4v11SettingsDialog.FillSettings(ref mp4Output);
        }

        private void SetMPEGTSOutput(ref VFMPEGTSOutput mpegTSOutput)
        {
            if (mpegTSSettingsDialog == null)
            {
                mpegTSSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MPEGTS);
            }

            mpegTSSettingsDialog.FillSettings(ref mpegTSOutput);
        }

        private void SetMOVOutput(ref VFMOVOutput mkvOutput)
        {
            if (movSettingsDialog == null)
            {
                movSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MOV);
            }

            movSettingsDialog.FillSettings(ref mkvOutput);
        }

        private void SetGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            if (gifSettingsDialog == null)
            {
                gifSettingsDialog = new GIFSettingsDialog();
            }

            gifSettingsDialog.FillSettings(ref gifOutput);
        }

        private void SetDVOutput(ref VFDVOutput dvOutput)
        {
            if (dvSettingsDialog == null)
            {
                dvSettingsDialog = new DVSettingsDialog();
            }

            dvSettingsDialog.FillSettings(ref dvOutput);
        }

        private void SetAVIOutput(ref VFAVIOutput aviOutput)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(VideoCapture1.Video_Codecs.ToArray(),
                    VideoCapture1.Audio_Codecs.ToArray());
            }

            aviSettingsDialog.FillSettings(ref aviOutput);

            if (aviOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                aviOutput.MP3 = mp3Output;
            }
        }

        private void SetMP3Output(ref VFMP3Output mp3Output)
        {
            if (mp3SettingsDialog == null)
            {
                mp3SettingsDialog = new MP3SettingsDialog();
            }

            mp3SettingsDialog.FillSettings(ref mp3Output);
        }

        private void SetMKVOutput(ref VFMKVv1Output mkvOutput)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(VideoCapture1.Video_Codecs.ToArray(),
                    VideoCapture1.Audio_Codecs.ToArray());
            }

            aviSettingsDialog.FillSettings(ref mkvOutput);

            if (mkvOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                mkvOutput.MP3 = mp3Output;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Audio_RecordAudio = false;
            VideoCapture1.Audio_PlayAudio = false;

            var bmp = new Bitmap(Properties.Resources._1);
            VideoCapture1.Push_Source = new PushSourceSettings
            {
                VideoPresent = true,
                VideoWidth = bmp.Width,
                VideoHeight = bmp.Height,
                VideoFrameRate = 25.0f
            };
            bmp.Dispose();

            if (rbPreview.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourcePreview;
            }
            else if (rbCapture.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourceCapture;

                VideoCapture1.Output_Filename = edOutput.Text;

                switch (cbOutputFormat.SelectedIndex)
                {
                    case 0:
                    {
                        var aviOutput = new VFAVIOutput();
                        SetAVIOutput(ref aviOutput);
                        VideoCapture1.Output_Format = aviOutput;

                        break;
                    }
                    case 1:
                    {
                        var mkvOutput = new VFMKVv1Output();
                        SetMKVOutput(ref mkvOutput);
                        VideoCapture1.Output_Format = mkvOutput;

                        break;
                    }
                    case 2:
                    {
                        var wmvOutput = new VFWMVOutput();
                        SetWMVOutput(ref wmvOutput);
                        VideoCapture1.Output_Format = wmvOutput;

                        break;
                    }
                    case 3:
                    {
                        var dvOutput = new VFDVOutput();
                        SetDVOutput(ref dvOutput);
                        VideoCapture1.Output_Format = dvOutput;

                        break;
                    }
                    case 4:
                    {
                        var webmOutput = new VFWebMOutput();
                        SetWebMOutput(ref webmOutput);
                        VideoCapture1.Output_Format = webmOutput;

                        break;
                    }
                    case 5:
                    {
                        var ffmpegDLLOutput = new VFFFMPEGDLLOutput();
                        SetFFMPEGDLLOutput(ref ffmpegDLLOutput);
                        VideoCapture1.Output_Format = ffmpegDLLOutput;

                        break;
                    }
                    case 6:
                    {
                        var ffmpegOutput = new VFFFMPEGEXEOutput();
                        SetFFMPEGEXEOutput(ref ffmpegOutput);
                        VideoCapture1.Output_Format = ffmpegOutput;

                        break;
                    }
                    case 7:
                    {
                        var mp4Output = new VFMP4v8v10Output();
                        SetMP4Output(ref mp4Output);
                        VideoCapture1.Output_Format = mp4Output;

                        break;
                    }
                    case 8:
                    {
                        var mp4Output = new VFMP4v11Output();
                        SetMP4v11Output(ref mp4Output);
                        VideoCapture1.Output_Format = mp4Output;

                        break;
                    }
                    case 9:
                    {
                        var gifOutput = new VFAnimatedGIFOutput();
                        SetGIFOutput(ref gifOutput);

                        VideoCapture1.Output_Format = gifOutput;

                        break;
                    }
                    case 10:
                    {
                        var encOutput = new VFMP4v8v10Output();
                        SetMP4Output(ref encOutput);
                        encOutput.Encryption = true;
                        encOutput.Encryption_Format = VFEncryptionFormat.MP4_H264_SW_AAC;

                        VideoCapture1.Output_Format = encOutput;

                        break;
                    }
                    case 11:
                        {
                            var tsOutput = new VFMPEGTSOutput();
                            SetMPEGTSOutput(ref tsOutput);
                            VideoCapture1.Output_Format = tsOutput;

                            break;
                        }
                    case 12:
                        {
                            var movOutput = new VFMOVOutput();
                            SetMOVOutput(ref movOutput);
                            VideoCapture1.Output_Format = movOutput;

                            break;
                        }
                }
            }

            VideoCapture1.Start();

            tcMain.SelectedIndex = 2;
            tmRecording.Start();

            PushImages();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            tmRecording.Stop();

            VideoCapture1.Stop();
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void cbOutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOutputFormat.SelectedIndex)
            {
                case 0:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                    break;
                }
                case 1:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mkv");
                    break;
                }
                case 2:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".wmv");
                    break;
                }
                case 3:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                    break;
                }
                case 4:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".webm");
                    break;
                }
                case 5:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                    break;
                }
                case 6:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                    break;
                }
                case 7:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mp4");
                    break;
                }
                case 8:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mp4");
                    break;
                }
                case 9:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".gif");
                    break;
                }
                case 10:
                {
                    edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".enc");
                    break;
                }
                case 11:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".ts");
                        break;
                    }
                case 12:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mov");
                        break;
                    }
            }
        }

        private void btOutputConfigure_Click(object sender, EventArgs e)
        {
            switch (cbOutputFormat.SelectedIndex)
            {
                case 0:
                {
                    if (aviSettingsDialog == null)
                    {
                        aviSettingsDialog = new AVISettingsDialog(VideoCapture1.Video_Codecs.ToArray(),
                            VideoCapture1.Audio_Codecs.ToArray());
                    }

                    aviSettingsDialog.ShowDialog(this);

                    break;
                }
                case 1:
                {
                    if (aviSettingsDialog == null)
                    {
                        aviSettingsDialog = new AVISettingsDialog(VideoCapture1.Video_Codecs.ToArray(),
                            VideoCapture1.Audio_Codecs.ToArray());
                    }

                    aviSettingsDialog.ShowDialog(this);

                    break;
                }
                case 2:
                {
                    if (wmvSettingsDialog == null)
                    {
                        wmvSettingsDialog = new WMVSettingsDialog(VideoCapture1.Core);
                    }

                    wmvSettingsDialog.WMA = false;
                    wmvSettingsDialog.ShowDialog(this);

                    break;
                }
                case 3:
                {
                    if (dvSettingsDialog == null)
                    {
                        dvSettingsDialog = new DVSettingsDialog();
                    }

                    dvSettingsDialog.ShowDialog(this);

                    break;
                }
                case 4:
                {
                    if (webmSettingsDialog == null)
                    {
                        webmSettingsDialog = new WebMSettingsDialog();
                    }

                    webmSettingsDialog.ShowDialog(this);

                    break;
                }
                case 5:
                {
                    if (ffmpegDLLSettingsDialog == null)
                    {
                        ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
                    }

                    ffmpegDLLSettingsDialog.ShowDialog(this);

                    break;
                }
                case 6:
                {
                    if (ffmpegEXESettingsDialog == null)
                    {
                        ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
                    }

                    ffmpegEXESettingsDialog.ShowDialog(this);

                    break;
                }
                case 7:
                {
                    if (mp4V10SettingsDialog == null)
                    {
                        mp4V10SettingsDialog = new MP4v10SettingsDialog();
                    }

                    mp4V10SettingsDialog.ShowDialog(this);

                    break;
                }
                case 8:
                {
                    if (mp4v11SettingsDialog == null)
                    {
                            mp4v11SettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
                    }

                        mp4v11SettingsDialog.ShowDialog(this);

                    break;
                }
                case 9:
                {
                    if (gifSettingsDialog == null)
                    {
                        gifSettingsDialog = new GIFSettingsDialog();
                    }

                    gifSettingsDialog.ShowDialog(this);

                    break;
                }
                case 10:
                {
                    if (mp4V10SettingsDialog == null)
                    {
                        mp4V10SettingsDialog = new MP4v10SettingsDialog();
                    }

                    mp4V10SettingsDialog.ShowDialog(this);

                    break;
                }
                case 11:
                    {
                        if (mpegTSSettingsDialog == null)
                        {
                            mpegTSSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MPEGTS);
                        }

                        mpegTSSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 12:
                    {
                        if (movSettingsDialog == null)
                        {
                            movSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MOV);
                        }

                        movSettingsDialog.ShowDialog(this);

                        break;
                    }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(null, null);
        }
    }
}