using System;
using System.Windows;
using System.Windows.Forms;
using VisioForge.Controls.VideoCapture;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;
using MessageBox = System.Windows.Forms.MessageBox;

// ReSharper disable InconsistentNaming

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public class OutputFormatManager
    {
        private MFSettingsDialog mfSettingsDialog;

        private MP4v10SettingsDialog mp4V10SettingsDialog;

        private AVISettingsDialog aviSettingsDialog;

        private AVISettingsDialog mkvSettingsDialog;

        private WMVSettingsDialog wmvSettingsDialog;

        private WMVSettingsDialog wmaSettingsDialog;

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

        public void ShowDialog(VFVideoCaptureOutputFormat format, Window parent, VideoCaptureCore core)
        {
            ShowDialog(format, new WPFWindowWrapper(parent), core);
        }
        
        public void ShowDialog(VFVideoCaptureOutputFormat format, IWin32Window parent, VideoCaptureCore core)
        {
            switch (format)
            {
                case VFVideoCaptureOutputFormat.AVI:
                    {
                        if (aviSettingsDialog == null)
                        {
                            aviSettingsDialog = new AVISettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray());
                        }

                        aviSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.WMV:
                    {
                        if (wmvSettingsDialog == null)
                        {
                            wmvSettingsDialog = new WMVSettingsDialog(core);
                        }

                        wmvSettingsDialog.WMA = false;
                        wmvSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.DV:
                    {
                        if (dvSettingsDialog == null)
                        {
                            dvSettingsDialog = new DVSettingsDialog();
                        }

                        dvSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.MKVv1:
                    {
                        if (mkvSettingsDialog == null)
                        {
                            mkvSettingsDialog = new AVISettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray());
                        }

                        mkvSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.PCM_ACM:
                    {
                        if (pcmSettingsDialog == null)
                        {
                            pcmSettingsDialog = new PCMSettingsDialog(core.Audio_Codecs().ToArray());
                        }

                        pcmSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.WMA:
                    {
                        if (wmaSettingsDialog == null)
                        {
                            wmaSettingsDialog = new WMVSettingsDialog(core);
                        }

                        wmaSettingsDialog.WMA = true;
                        wmaSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP3:
                    {
                        if (mp3SettingsDialog == null)
                        {
                            mp3SettingsDialog = new MP3SettingsDialog();
                        }

                        mp3SettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.Custom:
                    {
                        if (customFormatSettingsDialog == null)
                        {
                            customFormatSettingsDialog = new CustomFormatSettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray(), core.DirectShow_Filters().ToArray());
                        }

                        customFormatSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureDV:
                case VFVideoCaptureOutputFormat.DirectCaptureMPEG:
                case VFVideoCaptureOutputFormat.DirectCaptureAVI:
                case VFVideoCaptureOutputFormat.DirectCaptureMKV:
                    {
                        MessageBox.Show("No settings available for selected output format.");

                        break;
                    }
                case VFVideoCaptureOutputFormat.FFMPEG_DLL:
                    {
                        if (ffmpegDLLSettingsDialog == null)
                        {
                            ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
                        }

                        ffmpegDLLSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.WebM:
                    {
                        if (webmSettingsDialog == null)
                        {
                            webmSettingsDialog = new WebMSettingsDialog();
                        }

                        webmSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureMP4_GDCL:
                case VFVideoCaptureOutputFormat.DirectCaptureMP4_Monogram:
                    {
                        MessageBox.Show("No settings available for selected output format.");

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureCustom:
                    {
                        if (customFormatSettingsDialog == null)
                        {
                            customFormatSettingsDialog = new CustomFormatSettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray(), core.DirectShow_Filters().ToArray());
                        }

                        customFormatSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4_CUDA:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        mp4V10SettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4v8v10:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        mp4V10SettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4v11:
                    {
                        if (mfSettingsDialog == null)
                        {
                            mfSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
                        }

                        mfSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.Encrypted:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        mp4V10SettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.FLAC:
                    {
                        if (flacSettingsDialog == null)
                        {
                            flacSettingsDialog = new FLACSettingsDialog();
                        }

                        flacSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.OggVorbis:
                    {
                        if (oggVorbisSettingsDialog == null)
                        {
                            oggVorbisSettingsDialog = new OggVorbisSettingsDialog();
                        }

                        oggVorbisSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.Speex:
                    {
                        if (speexSettingsDialog == null)
                        {
                            speexSettingsDialog = new SpeexSettingsDialog();
                        }

                        speexSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.FFMPEG_EXE:
                    {
                        if (ffmpegEXESettingsDialog == null)
                        {
                            ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
                        }

                        ffmpegEXESettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.M4A:
                    {
                        if (m4aSettingsDialog == null)
                        {
                            m4aSettingsDialog = new M4ASettingsDialog();
                        }

                        m4aSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.AnimatedGIF:
                    {
                        if (gifSettingsDialog == null)
                        {
                            gifSettingsDialog = new GIFSettingsDialog();
                        }

                        gifSettingsDialog.ShowDialog(parent);

                        break;
                    }
                case VFVideoCaptureOutputFormat.VLC_EXE:
                    {
                        MessageBox.Show("No settings available for selected output format.");

                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        public void SetMP3Output(ref VFMP3Output mp3Output)
        {
            if (mp3SettingsDialog == null)
            {
                mp3SettingsDialog = new MP3SettingsDialog();
            }

            mp3SettingsDialog.FillSettings(ref mp3Output);
        }

        public void SetMP4Output(ref VFMP4v8v10Output mp4Output)
        {
            if (mp4V10SettingsDialog == null)
            {
                mp4V10SettingsDialog = new MP4v10SettingsDialog();
            }

            mp4V10SettingsDialog.FillSettings(ref mp4Output);
        }

        public void SetFFMPEGEXEOutput(ref VFFFMPEGEXEOutput ffmpegOutput)
        {
            if (ffmpegEXESettingsDialog == null)
            {
                ffmpegEXESettingsDialog = new FFMPEGEXESettingsDialog();
            }

            ffmpegEXESettingsDialog.FillSettings(ref ffmpegOutput);
        }

        public void SetWMVOutput(ref VFWMVOutput wmvOutput, VideoCaptureCore core)
        {
            if (wmvSettingsDialog == null)
            {
                wmvSettingsDialog = new WMVSettingsDialog(core);
            }

            wmvSettingsDialog.WMA = false;
            wmvSettingsDialog.FillSettings(ref wmvOutput);
        }

        public void SetWMAOutput(ref VFWMAOutput wmaOutput, VideoCaptureCore core)
        {
            if (wmvSettingsDialog == null)
            {
                wmvSettingsDialog = new WMVSettingsDialog(core);
            }

            wmvSettingsDialog.WMA = true;
            wmvSettingsDialog.FillSettings(ref wmaOutput);
        }

        public void SetACMOutput(ref VFACMOutput acmOutput, VideoCaptureCore core)
        {
            if (pcmSettingsDialog == null)
            {
                pcmSettingsDialog = new PCMSettingsDialog(core.Audio_Codecs().ToArray());
            }

            pcmSettingsDialog.FillSettings(ref acmOutput);
        }

        public void SetWebMOutput(ref VFWebMOutput webmOutput)
        {
            if (webmSettingsDialog == null)
            {
                webmSettingsDialog = new WebMSettingsDialog();
            }

            webmSettingsDialog.FillSettings(ref webmOutput);
        }

        public void SetFFMPEGDLLOutput(ref VFFFMPEGDLLOutput ffmpegDLLOutput)
        {
            if (ffmpegDLLSettingsDialog == null)
            {
                ffmpegDLLSettingsDialog = new FFMPEGDLLSettingsDialog();
            }

            ffmpegDLLSettingsDialog.FillSettings(ref ffmpegDLLOutput);
        }

        public void SetFLACOutput(ref VFFLACOutput flacOutput)
        {
            if (flacSettingsDialog == null)
            {
                flacSettingsDialog = new FLACSettingsDialog();
            }

            flacSettingsDialog.FillSettings(ref flacOutput);
        }

        public void SetMP4Output(ref VFMP4v11Output mp4Output)
        {
            if (mfSettingsDialog == null)
            {
                mfSettingsDialog = new MFSettingsDialog(MFSettingsDialogMode.MP4v11);
            }

            mfSettingsDialog.FillSettings(ref mp4Output);
        }

        public void SetSpeexOutput(ref VFSpeexOutput speexOutput)
        {
            if (speexSettingsDialog == null)
            {
                speexSettingsDialog = new SpeexSettingsDialog();
            }

            speexSettingsDialog.FillSettings(ref speexOutput);
        }

        public void SetM4AOutput(ref VFM4AOutput m4aOutput)
        {
            if (m4aSettingsDialog == null)
            {
                m4aSettingsDialog = new M4ASettingsDialog();
            }

            m4aSettingsDialog.FillSettings(ref m4aOutput);
        }

        public void SetGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            if (gifSettingsDialog == null)
            {
                gifSettingsDialog = new GIFSettingsDialog();
            }

            gifSettingsDialog.FillSettings(ref gifOutput);
        }

        public void SetDirectCaptureCustomOutput(ref VFDirectCaptureCustomOutput directCaptureOutput, VideoCaptureCore core)
        {
            if (customFormatSettingsDialog == null)
            {
                customFormatSettingsDialog = new CustomFormatSettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray(), core.DirectShow_Filters().ToArray());
            }

            customFormatSettingsDialog.FillSettings(ref directCaptureOutput);
        }

        public void SetDirectCaptureCustomOutput(ref VFDirectCaptureMP4Output directCaptureOutput, VideoCaptureCore core)
        {
            if (customFormatSettingsDialog == null)
            {
                customFormatSettingsDialog = new CustomFormatSettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray(), core.DirectShow_Filters().ToArray());
            }

            customFormatSettingsDialog.FillSettings(ref directCaptureOutput);
        }

        public void SetCustomOutput(ref VFCustomOutput customOutput, VideoCaptureCore core)
        {
            if (customFormatSettingsDialog == null)
            {
                customFormatSettingsDialog = new CustomFormatSettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray(), core.DirectShow_Filters().ToArray());
            }

            customFormatSettingsDialog.FillSettings(ref customOutput);
        }

        public void SetDVOutput(ref VFDVOutput dvOutput)
        {
            if (dvSettingsDialog == null)
            {
                dvSettingsDialog = new DVSettingsDialog();
            }

            dvSettingsDialog.FillSettings(ref dvOutput);
        }

        public void SetAVIOutput(ref VFAVIOutput aviOutput, VideoCaptureCore core)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray());
            }

            aviSettingsDialog.FillSettings(ref aviOutput);

            if (aviOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                aviOutput.MP3 = mp3Output;
            }
        }

        public void SetMKVOutput(ref VFMKVv1Output mkvOutput, VideoCaptureCore core)
        {
            if (aviSettingsDialog == null)
            {
                aviSettingsDialog = new AVISettingsDialog(core.Video_Codecs().ToArray(), core.Audio_Codecs().ToArray());
            }

            aviSettingsDialog.FillSettings(ref mkvOutput);

            if (mkvOutput.Audio_UseMP3Encoder)
            {
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                mkvOutput.MP3 = mp3Output;
            }
        }

        public void SetOGGOutput(ref VFOGGVorbisOutput oggVorbisOutput)
        {
            if (oggVorbisSettingsDialog == null)
            {
                oggVorbisSettingsDialog = new OggVorbisSettingsDialog();
            }

            oggVorbisSettingsDialog.FillSettings(ref oggVorbisOutput);
        }

        public void FillSettings(VFVideoCaptureOutputFormat format, VideoCaptureCore core)
        {
            switch (format)
            {
                case VFVideoCaptureOutputFormat.AVI:
                    {
                        var aviOutput = new VFAVIOutput();
                        SetAVIOutput(ref aviOutput, core);
                        core.Output_Format = aviOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.WMV:
                    {
                        var wmvOutput = new VFWMVOutput();
                        SetWMVOutput(ref wmvOutput, core);
                        core.Output_Format = wmvOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.DV:
                    {
                        var dvOutput = new VFDVOutput();
                        SetDVOutput(ref dvOutput);
                        core.Output_Format = dvOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.MKVv1:
                    {
                        var mkvOutput = new VFMKVv1Output();
                        SetMKVOutput(ref mkvOutput, core);
                        core.Output_Format = mkvOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.PCM_ACM:
                    {
                        var acmOutput = new VFACMOutput();
                        SetACMOutput(ref acmOutput, core);
                        core.Output_Format = acmOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.WMA:
                    {

                        var wmaOutput = new VFWMAOutput();
                        SetWMAOutput(ref wmaOutput, core);
                        core.Output_Format = wmaOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP3:
                    {
                        var mp3Output = new VFMP3Output();
                        SetMP3Output(ref mp3Output);
                        core.Output_Format = mp3Output;

                        break;
                    }
                case VFVideoCaptureOutputFormat.Custom:
                    {

                        var customOutput = new VFCustomOutput();
                        SetCustomOutput(ref customOutput, core);
                        core.Output_Format = customOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureDV:
                    {
                        core.Output_Format = new VFDirectCaptureDVOutput();
                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureMPEG:
                    {
                        core.Output_Format = new VFDirectCaptureMPEGOutput();
                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureAVI:
                    {
                        core.Output_Format = new VFDirectCaptureAVIOutput();
                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureMKV:
                    {
                        core.Output_Format = new VFDirectCaptureMKVOutput();
                        break;
                    }
                case VFVideoCaptureOutputFormat.FFMPEG_DLL:
                    {
                        var ffmpegDLLOutput = new VFFFMPEGDLLOutput();
                        SetFFMPEGDLLOutput(ref ffmpegDLLOutput);
                        core.Output_Format = ffmpegDLLOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.WebM:
                    {
                        var webmOutput = new VFWebMOutput();
                        SetWebMOutput(ref webmOutput);
                        core.Output_Format = webmOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureMP4_GDCL:
                    {
                        var directCaptureOutputGDCL = new VFDirectCaptureMP4Output();
                        SetDirectCaptureCustomOutput(ref directCaptureOutputGDCL, core);
                        directCaptureOutputGDCL.Muxer = VFDirectCaptureMP4Muxer.GDCL;
                        core.Output_Format = directCaptureOutputGDCL;

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureMP4_Monogram:
                    {
                        var directCaptureOutputMG = new VFDirectCaptureMP4Output();
                        SetDirectCaptureCustomOutput(ref directCaptureOutputMG, core);
                        directCaptureOutputMG.Muxer = VFDirectCaptureMP4Muxer.Monogram;
                        core.Output_Format = directCaptureOutputMG;

                        break;
                    }
                case VFVideoCaptureOutputFormat.DirectCaptureCustom:
                    {
                        var directCaptureOutput = new VFDirectCaptureCustomOutput();
                        SetDirectCaptureCustomOutput(ref directCaptureOutput, core);
                        core.Output_Format = directCaptureOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4_CUDA:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        var mp4Output = new VFMP4v8v10Output();
                        SetMP4Output(ref mp4Output);
                        core.Output_Format = mp4Output;

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4v8v10:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        var mp4Output = new VFMP4v8v10Output();
                        SetMP4Output(ref mp4Output);
                        core.Output_Format = mp4Output;

                        break;
                    }
                case VFVideoCaptureOutputFormat.MP4v11:
                    {
                        var mp4Output = new VFMP4v11Output();
                        SetMP4Output(ref mp4Output);
                        core.Output_Format = mp4Output;

                        break;
                    }
                case VFVideoCaptureOutputFormat.Encrypted:
                    {
                        if (mp4V10SettingsDialog == null)
                        {
                            mp4V10SettingsDialog = new MP4v10SettingsDialog();
                        }

                        var mp4Output = new VFMP4v8v10Output();
                        SetMP4Output(ref mp4Output);
                        mp4Output.Encryption = true;
                        core.Output_Format = mp4Output;

                        break;
                    }
                case VFVideoCaptureOutputFormat.FLAC:
                    {
                        var flacOutput = new VFFLACOutput();
                        SetFLACOutput(ref flacOutput);
                        core.Output_Format = flacOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.OggVorbis:
                    {
                        var oggVorbisOutput = new VFOGGVorbisOutput();
                        SetOGGOutput(ref oggVorbisOutput);
                        core.Output_Format = oggVorbisOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.Speex:
                    {
                        var speexOutput = new VFSpeexOutput();
                        SetSpeexOutput(ref speexOutput);
                        core.Output_Format = speexOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.FFMPEG_EXE:
                    {
                        var ffmpegOutput = new VFFFMPEGEXEOutput();
                        SetFFMPEGEXEOutput(ref ffmpegOutput);
                        core.Output_Format = ffmpegOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.M4A:
                    {
                        var m4aOutput = new VFM4AOutput();
                        SetM4AOutput(ref m4aOutput);
                        core.Output_Format = m4aOutput;

                        break;
                    }
                case VFVideoCaptureOutputFormat.AnimatedGIF:
                    {
                        var gifOutput = new VFAnimatedGIFOutput();
                        SetGIFOutput(ref gifOutput);
                        core.Output_Format = gifOutput;
                        break;
                    }
                case VFVideoCaptureOutputFormat.VLC_EXE:
                    {
                        var vlcOutput = new VFVLCEXEOutput();
                        //SetGIFOutput(ref gifOutput);
                        core.Output_Format = vlcOutput;
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }
    }
}
