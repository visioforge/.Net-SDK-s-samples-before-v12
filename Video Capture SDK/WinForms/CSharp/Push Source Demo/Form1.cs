// ReSharper disable StyleCop.SA1600

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

            cbChannels.SelectedIndex = 1;
            cbBPS.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;

            edOutputAVI.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputMP4.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp4";

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

            MessageBox.Show("Done!");
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

        private void btStart_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoCapture1.Audio_RecordAudio = true;
            VideoCapture1.Audio_PlayAudio = true;

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
            else if (rbCaptureAVI.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourceCapture;

                VideoCapture1.Output_Filename = edOutputAVI.Text;

                var aviOutput = new VFAVIOutput
                                    {
                                        ACM =
                                            {
                                                Name = cbAudioCodecs.Text,
                                                Channels = Convert.ToInt32(cbChannels.Text),
                                                BPS = Convert.ToInt32(cbBPS.Text),
                                                SampleRate = Convert.ToInt32(cbSampleRate.Text)
                                            },
                                        Video_Codec = cbVideoCodecs.Text
                                    };

                VideoCapture1.Output_Format = aviOutput;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourceCapture;

                VideoCapture1.Output_Filename = edOutputMP4.Text;

                var mp4Output = new VFMP4Output();

                if (IsWindows7OrNewer())
                {
                    mp4Output.MP4Mode = VFMP4Mode.v10;
                }
                else
                {
                    mp4Output.MP4Mode = VFMP4Mode.v8;
                }

                VideoCapture1.Output_Format = mp4Output;
            }

            VideoCapture1.Start();

            PushImages();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.Stop();
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
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

        private void btSelectOutputAVI_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutputAVI.Text = saveFileDialog1.FileName;
            }
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
    }
}
