using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Push_Source_Demo
{
    using System.Threading;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;

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

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264TargetUsage.SelectedIndex = 3;

            edOutputAVI.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputMP4.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp4";
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
            VideoCapture1.Push_Source = new PushSourceSettings();
            VideoCapture1.Push_Source.VideoPresent = true;
            VideoCapture1.Push_Source.VideoWidth = bmp.Width;
            VideoCapture1.Push_Source.VideoHeight = bmp.Height;
            VideoCapture1.Push_Source.VideoFrameRate = 25.0f;
            bmp.Dispose();

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

            if (rbPreview.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourcePreview;
            }
            else if (rbCaptureAVI.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourceCapture;

                VideoCapture1.Output_Filename = edOutputAVI.Text;

                var aviOutput = new VFAVIOutput();

                aviOutput.ACM.Name = cbAudioCodecs.Text;
                aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
                aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
                aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);

                aviOutput.Video_Codec = cbVideoCodecs.Text;

                VideoCapture1.Output_Format = aviOutput;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.PushSourceCapture;

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
