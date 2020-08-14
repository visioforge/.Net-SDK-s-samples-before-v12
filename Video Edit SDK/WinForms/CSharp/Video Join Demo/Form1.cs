﻿using System;
using System.Globalization;
using System.Windows.Forms;
using VisioForge.Controls.UI.Dialogs.OutputFormats;
using VisioForge.Tools;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;

namespace Video_Join_Demo
{
    using System.Collections.Generic;

    public partial class Form1 : Form
    {
        private MFSettingsDialog mp4v11SettingsDialog;

        private MP4v10SettingsDialog mp4V10SettingsDialog;

        private AVISettingsDialog aviSettingsDialog;

        private WMVSettingsDialog wmvSettingsDialog;

        private DVSettingsDialog dvSettingsDialog;

        private PCMSettingsDialog pcmSettingsDialog;

        private MP3SettingsDialog mp3SettingsDialog;

        private WebMSettingsDialog webmSettingsDialog;

        private FFMPEGDLLSettingsDialog ffmpegDLLSettingsDialog;

        private FFMPEGEXESettingsDialog ffmpegEXESettingsDialog;

        private FLACSettingsDialog flacSettingsDialog;

        private CustomFormatSettingsDialog customFormatSettingsDialog;

        private OggVorbisSettingsDialog oggVorbisSettingsDialog;

        private SpeexSettingsDialog speexSettingsDialog;

        private M4ASettingsDialog m4aSettingsDialog;

        private GIFSettingsDialog gifSettingsDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private static string GetFileExt(string filename)
        {
            int k = filename.LastIndexOf('.');
            return filename.Substring(k, filename.Length - k);
        }

        private async void BtAddInputFile_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text, CultureInfo.InvariantCulture);

                string s = OpenDialog1.FileName;

                lbFiles.Items.Add(s);

                // resize if required
                int customWidth = 0;
                int customHeight = 0;

                if (cbResize.Checked)
                {
                    customWidth = Convert.ToInt32(edWidth.Text);
                    customHeight = Convert.ToInt32(edHeight.Text);
                }

                if ((string.Compare(GetFileExt(s), ".BMP", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPEG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".GIF", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".PNG", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    await VideoEdit1.Input_AddImageFileAsync(s, TimeSpan.FromMilliseconds(2000), null, VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight);
                }
                else if ((string.Compare(GetFileExt(s), ".WAV", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".MP3", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".OGG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".WMA", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    var audioFile = new VFVEAudioSource(s, TimeSpan.Zero, TimeSpan.Zero, string.Empty);
                    await VideoEdit1.Input_AddAudioFileAsync(audioFile, null, 0);
                }
                else
                {
                    var videoFile = new VFVEVideoSource(s, TimeSpan.Zero, TimeSpan.Zero, VFVideoEditStretchMode.Letterbox);
                    var audioFile = new VFVEAudioSource(s, TimeSpan.Zero, TimeSpan.Zero, string.Empty);

                    await VideoEdit1.Input_AddVideoFileAsync(videoFile, null, 0, customWidth, customHeight);
                    await VideoEdit1.Input_AddAudioFileAsync(audioFile, null, 0);
                }
            }
        }

        private void BtSelectOutput_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = SaveDialog1.FileName;
            }
        }

        private void BtClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
        }

        private void BtConfigure_Click(object sender, EventArgs e)
        {
            switch (cbOutputVideoFormat.SelectedIndex)
            {
                case 0:
                    {
                        if (aviSettingsDialog == null)
                        {
                            aviSettingsDialog = new AVISettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray());
                        }

                        aviSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 1:
                    {
                        if (aviSettingsDialog == null)
                        {
                            aviSettingsDialog = new AVISettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray());
                        }

                        aviSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 2:
                    {
                        if (wmvSettingsDialog == null)
                        {
                            wmvSettingsDialog = new WMVSettingsDialog(VideoEdit1);
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
                        if (pcmSettingsDialog == null)
                        {
                            pcmSettingsDialog = new PCMSettingsDialog(VideoEdit1.Audio_Codecs.ToArray());
                        }

                        pcmSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 5:
                    {
                        if (mp3SettingsDialog == null)
                        {
                            mp3SettingsDialog = new MP3SettingsDialog();
                        }

                        mp3SettingsDialog.ShowDialog(this);

                        break;
                    }
                case 6:
                    {
                        if (m4aSettingsDialog == null)
                        {
                            m4aSettingsDialog = new M4ASettingsDialog();
                        }

                        m4aSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 7:
                    {
                        if (wmvSettingsDialog == null)
                        {
                            wmvSettingsDialog = new WMVSettingsDialog(VideoEdit1);
                        }

                        wmvSettingsDialog.WMA = true;
                        wmvSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 8:
                    {
                        if (oggVorbisSettingsDialog == null)
                        {
                            oggVorbisSettingsDialog = new OggVorbisSettingsDialog();
                        }

                        oggVorbisSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 9:
                    {
                        if (flacSettingsDialog == null)
                        {
                            flacSettingsDialog = new FLACSettingsDialog();
                        }

                        flacSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 10:
                    {
                        if (speexSettingsDialog == null)
                        {
                            speexSettingsDialog = new SpeexSettingsDialog();
                        }

                        speexSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 11:
                    {
                        if (customFormatSettingsDialog == null)
                        {
                            customFormatSettingsDialog = new CustomFormatSettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray(), VideoEdit1.DirectShow_Filters.ToArray());
                        }

                        customFormatSettingsDialog.ShowDialog(this);

                        break;
                    }

                case 12:
                    {
                        if (webmSettingsDialog == null)
                        {
                            webmSettingsDialog = new WebMSettingsDialog();
                        }

                        webmSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 13:
                    {
                        if (ffmpegDLLSettingsDialog == null)
                        {
                            ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
                        }

                        ffmpegDLLSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 14:
                    {
                        if (ffmpegEXESettingsDialog == null)
                        {
                            ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
                        }

                        ffmpegEXESettingsDialog.ShowDialog(this);

                        break;
                    }
                case 15:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        mp4V10SettingsDialog.ShowDialog(this);

                        break;
                    }
                case 16:
                    {
                        if (mp4v11SettingsDialog == null)
                        {
                            mp4v11SettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
                        }

                        mp4v11SettingsDialog.ShowDialog(this);

                        break;
                    }
                case 17:
                    {
                        if (gifSettingsDialog == null)
                        {
                            gifSettingsDialog = new GIFSettingsDialog();
                        }

                        gifSettingsDialog.ShowDialog(this);

                        break;
                    }
                case 18:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        mp4V10SettingsDialog.ShowDialog(this);

                        break;
                    }
            }
        }

        private void CbOutputVideoFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOutputVideoFormat.SelectedIndex)
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
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".wav");
                        break;
                    }
                case 5:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mp3");
                        break;
                    }
                case 6:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".m4a");
                        break;
                    }
                case 7:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".wma");
                        break;
                    }
                case 8:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".ogg");
                        break;
                    }
                case 9:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".flac");
                        break;
                    }
                case 10:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".ogg");
                        break;
                    }
                case 11:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                        break;
                    }
                case 12:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".webm");
                        break;
                    }
                case 13:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                        break;
                    }
                case 14:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".avi");
                        break;
                    }
                case 15:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mp4");
                        break;
                    }
                case 16:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".mp4");
                        break;
                    }
                case 17:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".gif");
                        break;
                    }
                case 18:
                    {
                        edOutput.Text = FilenameHelper.ChangeFileExt(edOutput.Text, ".enc");
                        break;
                    }
            }
        }

        private async void BtStart_Click(object sender, EventArgs e)
        {
            VideoEdit1.Debug_Mode = cbDebugMode.Checked;
            VideoEdit1.Debug_Telemetry = cbTelemetry.Checked;

            mmLog.Clear();

            VideoEdit1.Mode = VFVideoEditMode.Convert;

            VideoEdit1.Video_Effects_Clear();
            VideoEdit1.Video_Resize = cbResize.Checked;

            if (VideoEdit1.Video_Resize)
            {
                VideoEdit1.Video_Resize_Width = Convert.ToInt32(edWidth.Text);
                VideoEdit1.Video_Resize_Height = Convert.ToInt32(edHeight.Text);
            }

            VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text, CultureInfo.InvariantCulture);

            VideoEdit1.Output_Filename = edOutput.Text;

            switch (cbOutputVideoFormat.SelectedIndex)
            {
                case 0:
                    {
                        var aviOutput = new VFAVIOutput();
                        SetAVIOutput(ref aviOutput);
                        VideoEdit1.Output_Format = aviOutput;
                        break;
                    }
                case 1:
                    {
                        var mkvOutput = new VFMKVv1Output();
                        SetMKVOutput(ref mkvOutput);
                        VideoEdit1.Output_Format = mkvOutput;
                        break;
                    }
                case 2:
                    {
                        var wmvOutput = new VFWMVOutput();
                        SetWMVOutput(ref wmvOutput);
                        VideoEdit1.Output_Format = wmvOutput;
                        break;
                    }
                case 3:
                    {
                        var dvOutput = new VFDVOutput();
                        SetDVOutput(ref dvOutput);
                        VideoEdit1.Output_Format = dvOutput;
                        break;
                    }
                case 4:
                    {
                        var acmOutput = new VFACMOutput();
                        SetACMOutput(ref acmOutput);
                        VideoEdit1.Output_Format = acmOutput;
                        break;
                    }
                case 5:
                    {
                        var mp3Output = new VFMP3Output();
                        SetMP3Output(ref mp3Output);
                        VideoEdit1.Output_Format = mp3Output;
                        break;
                    }
                case 6:
                    {
                        var m4aOutput = new VFM4AOutput();
                        SetM4AOutput(ref m4aOutput);
                        VideoEdit1.Output_Format = m4aOutput;
                        break;
                    }
                case 7:
                    {
                        var wmaOutput = new VFWMAOutput();
                        SetWMAOutput(ref wmaOutput);
                        VideoEdit1.Output_Format = wmaOutput;
                        break;
                    }
                case 8:
                    {
                        var oggVorbisOutput = new VFOGGVorbisOutput();
                        SetOGGOutput(ref oggVorbisOutput);
                        VideoEdit1.Output_Format = oggVorbisOutput;
                        break;
                    }
                case 9:
                    {
                        var flacOutput = new VFFLACOutput();
                        SetFLACOutput(ref flacOutput);
                        VideoEdit1.Output_Format = flacOutput;
                        break;
                    }
                case 10:
                    {
                        var speexOutput = new VFSpeexOutput();
                        SetSpeexOutput(ref speexOutput);
                        VideoEdit1.Output_Format = speexOutput;
                        break;
                    }
                case 11:
                    {
                        var customOutput = new VFCustomOutput();
                        SetCustomOutput(ref customOutput);
                        VideoEdit1.Output_Format = customOutput;
                        break;
                    }
                case 12:
                    {
                        var webmOutput = new VFWebMOutput();
                        SetWebMOutput(ref webmOutput);
                        VideoEdit1.Output_Format = webmOutput;
                        break;
                    }
                case 13:
                    {
                        var ffmpegDLLOutput = new VFFFMPEGDLLOutput();
                        SetFFMPEGDLLOutput(ref ffmpegDLLOutput);
                        VideoEdit1.Output_Format = ffmpegDLLOutput;
                        break;
                    }
                case 14:
                    {
                        var ffmpegOutput = new VFFFMPEGEXEOutput();
                        SetFFMPEGEXEOutput(ref ffmpegOutput);
                        VideoEdit1.Output_Format = ffmpegOutput;
                        break;
                    }
                case 15:
                    {
                        var mp4Output = new VFMP4v8v10Output();
                        SetMP4v10Output(ref mp4Output);
                        VideoEdit1.Output_Format = mp4Output;
                        break;
                    }
                case 16:
                    {
                        var mp4Output = new VFMP4v11Output();
                        SetMP4v11Output(ref mp4Output);
                        VideoEdit1.Output_Format = mp4Output;
                        break;
                    }
                case 17:
                    {
                        var gifOutput = new VFAnimatedGIFOutput();
                        SetGIFOutput(ref gifOutput);
                        VideoEdit1.Output_Format = gifOutput;
                        break;
                    }
                case 18:
                    MessageBox.Show("Please use Main Demo to create encrypted files.");
                    return;
            }

            VideoEdit1.Audio_Preview_Enabled = true;

            await VideoEdit1.StartAsync();
        }

        private async void BtStop_Click(object sender, EventArgs e)
        {
            await VideoEdit1.StopAsync();

            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
            ProgressBar1.Value = 0;
        }

        private void VideoEdit1_OnError(object sender, ErrorsEventArgs e)
        {
            Invoke((Action)(() =>
                                   {
                                       mmLog.Text = mmLog.Text + e.Message + "(" + e.CallSite + ")" + Environment.NewLine;
                                   }));
        }

        private void VideoEdit1_OnProgress(object sender, ProgressEventArgs e)
        {
            Invoke((Action)(() => { ProgressBar1.Value = e.Progress; }));
        }

        private void VideoEdit1_OnStop(object sender, VideoEditStopEventArgs e)
        {
            Invoke((Action)(() =>
                                   {
                                       ProgressBar1.Value = 0;
                                       lbFiles.Items.Clear();
                                   }));

            if (e.Successful)
            {
                MessageBox.Show("Completed successfully", string.Empty, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Stopped with error", string.Empty, MessageBoxButtons.OK);
            }

            VideoEdit1.Input_Clear_List();

            VideoEdit1.Video_Transition_Clear();
        }

        private void SetMP3Output(ref VFMP3Output mp3Output)
        {
            if (mp3SettingsDialog == null)
            {
                mp3SettingsDialog = new MP3SettingsDialog();
            }

            mp3SettingsDialog.SaveSettings(ref mp3Output);
        }

        private void SetMP4v10Output(ref VFMP4v8v10Output mp4Output)
        {
            if (mp4V10SettingsDialog == null)
            {
                mp4V10SettingsDialog = new MP4v10SettingsDialog();
            }

            mp4V10SettingsDialog.SaveSettings(ref mp4Output);
        }

        private void SetFFMPEGEXEOutput(ref VFFFMPEGEXEOutput ffmpegOutput)
        {
            if (ffmpegEXESettingsDialog == null)
            {
                ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
            }

            ffmpegEXESettingsDialog.SaveSettings(ref ffmpegOutput);
        }

        private void SetWMVOutput(ref VFWMVOutput wmvOutput)
        {
            if (wmvSettingsDialog == null)
            {
                wmvSettingsDialog = new WMVSettingsDialog(VideoEdit1);
            }

            wmvSettingsDialog.WMA = false;
            wmvSettingsDialog.SaveSettings(ref wmvOutput);
        }

        private void SetWMAOutput(ref VFWMAOutput wmaOutput)
        {
            if (wmvSettingsDialog == null)
            {
                wmvSettingsDialog = new WMVSettingsDialog(VideoEdit1);
            }

            wmvSettingsDialog.WMA = true;
            wmvSettingsDialog.SaveSettings(ref wmaOutput);
        }

        private void SetACMOutput(ref VFACMOutput acmOutput)
        {
            if (pcmSettingsDialog == null)
            {
                pcmSettingsDialog = new PCMSettingsDialog(VideoEdit1.Audio_Codecs.ToArray());
            }

            pcmSettingsDialog.SaveSettings(ref acmOutput);
        }

        private void SetWebMOutput(ref VFWebMOutput webmOutput)
        {
            if (webmSettingsDialog == null)
            {
                webmSettingsDialog = new WebMSettingsDialog();
            }

            webmSettingsDialog.SaveSettings(ref webmOutput);
        }

        private void SetFFMPEGDLLOutput(ref VFFFMPEGDLLOutput ffmpegDLLOutput)
        {
            if (ffmpegDLLSettingsDialog == null)
            {
                ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
            }

            ffmpegDLLSettingsDialog.SaveSettings(ref ffmpegDLLOutput);
        }

        private void SetFLACOutput(ref VFFLACOutput flacOutput)
        {
            if (flacSettingsDialog == null)
            {
                flacSettingsDialog = new FLACSettingsDialog();
            }

            flacSettingsDialog.SaveSettings(ref flacOutput);
        }

        private void SetMP4v11Output(ref VFMP4v11Output mp4Output)
        {
            if (mp4v11SettingsDialog == null)
            {
                mp4v11SettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
            }

            mp4v11SettingsDialog.SaveSettings(ref mp4Output);
        }

        private void SetSpeexOutput(ref VFSpeexOutput speexOutput)
        {
            if (speexSettingsDialog == null)
            {
                speexSettingsDialog = new SpeexSettingsDialog();
            }

            speexSettingsDialog.SaveSettings(ref speexOutput);
        }

        private void SetM4AOutput(ref VFM4AOutput m4aOutput)
        {
            if (m4aSettingsDialog == null)
            {
                m4aSettingsDialog = new M4ASettingsDialog();
            }

            m4aSettingsDialog.SaveSettings(ref m4aOutput);
        }

        private void SetGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            if (gifSettingsDialog == null)
            {
                gifSettingsDialog = new GIFSettingsDialog();
            }

            gifSettingsDialog.SaveSettings(ref gifOutput);
        }

        private void SetCustomOutput(ref VFCustomOutput customOutput)
        {
            if (customFormatSettingsDialog == null)
            {
                customFormatSettingsDialog = new CustomFormatSettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray(), VideoEdit1.DirectShow_Filters.ToArray());
            }

            customFormatSettingsDialog.SaveSettings(ref customOutput);
        }

        private void SetDVOutput(ref VFDVOutput dvOutput)
        {
            if (dvSettingsDialog == null)
            {
                dvSettingsDialog = new DVSettingsDialog();
            }

            dvSettingsDialog.SaveSettings(ref dvOutput);
        }

        private void SetAVIOutput(ref VFAVIOutput aviOutput)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray());
            }

            aviSettingsDialog.SaveSettings(ref aviOutput);

            if (aviOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                aviOutput.MP3 = mp3Output;
            }
        }

        private void SetMKVOutput(ref VFMKVv1Output mkvOutput)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(VideoEdit1.Video_Codecs.ToArray(), VideoEdit1.Audio_Codecs.ToArray());
            }

            aviSettingsDialog.SaveSettings(ref mkvOutput);

            if (mkvOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                mkvOutput.MP3 = mp3Output;
            }
        }

        private void SetOGGOutput(ref VFOGGVorbisOutput oggVorbisOutput)
        {
            if (oggVorbisSettingsDialog == null)
            {
                oggVorbisSettingsDialog = new OggVorbisSettingsDialog();
            }

            oggVorbisSettingsDialog.SaveSettings(ref oggVorbisOutput);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoEdit1.SDK_Version + ", " + VideoEdit1.SDK_State + ")";

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";

            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            cbFrameRate.SelectedIndex = 0;
            cbOutputVideoFormat.SelectedIndex = 15;
        }
    }
}
