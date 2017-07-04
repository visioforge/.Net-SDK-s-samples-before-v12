// ReSharper disable InconsistentNaming

 // ReSharper disable StyleCop.SA1601
namespace Main_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Threading;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Shared.IPCameraDB;
    using VisioForge.Tools;
    using VisioForge.Types;
    using VisioForge.Types.GPUVideoEffects;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;
    using VisioForge.Types.VideoEffects;

    using Application = System.Windows.Application;
    using Color = System.Windows.Media.Color;
    using MessageBox = System.Windows.MessageBox;
    using VFM4AOutput = VisioForge.Types.OutputFormat.VFM4AOutput;

    // ReSharper disable InconsistentNaming

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented")]
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class Window1
    {
        private ONVIFControl onvifControl;

        private ONVIFPTZRanges onvifPtzRanges;

        private float onvifPtzX;

        private float onvifPtzY;

        private float onvifPtzZoom;

        private readonly List<AudioChannelMapperItem> audioChannelMapperItems = new List<AudioChannelMapperItem>();

        // Zoom
        private double zoom = 1.0;
        private int zoomShiftX;
        private int zoomShiftY;

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // Dialogs
        private readonly FontDialog fontDialog = new FontDialog();
        private readonly Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog2 = new Microsoft.Win32.OpenFileDialog();
        private readonly ColorDialog colorDialog1 = new ColorDialog();
        private readonly FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        private static System.Drawing.Color ColorConv(Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private static Color ColorConv(System.Drawing.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void AddAudioEffects()
        {
            VideoCapture1.Audio_Effects_Clear(-1);

            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.IsChecked == true, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.IsChecked == true, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.IsChecked == true, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.IsChecked == true, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.IsChecked == true, -1, -1);
        }

        private void FillMP3Settings(ref VFMP3Output mp3Output)
        {
            mp3Output.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text);
            mp3Output.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text);
            mp3Output.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text);
            mp3Output.SampleRate = Convert.ToInt32(cbLameSampleRate.Text);
            mp3Output.VBR_Quality = (int)tbLameVBRQuality.Value;
            mp3Output.EncodingQuality = (int)tbLameEncodingQuality.Value;

            if (rbLameStandardStereo.IsChecked == true)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.StandardStereo;
            }
            else if (rbLameJointStereo.IsChecked == true)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.JointStereo;
            }
            else if (rbLameDualChannels.IsChecked == true)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.DualStereo;
            }
            else
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.Mono;
            }

            mp3Output.VBR_Mode = rbLameVBR.IsChecked == true;
            mp3Output.Copyright = cbLameCopyright.IsChecked == true;
            mp3Output.Original = cbLameOriginal.IsChecked == true;
            mp3Output.CRCProtected = cbLameCRCProtected.IsChecked == true;
            mp3Output.ForceMono = cbLameForceMono.IsChecked == true;
            mp3Output.StrictlyEnforceVBRMinBitrate =
                cbLameStrictlyEnforceVBRMinBitrate.IsChecked == true;
            mp3Output.VoiceEncodingMode = cbLameVoiceEncodingMode.IsChecked == true;
            mp3Output.KeepAllFrequencies = cbLameKeepAllFrequencies.IsChecked == true;
            mp3Output.StrictISOCompliance = cbLameStrictISOCompilance.IsChecked == true;
            mp3Output.DisableShortBlocks = cbLameDisableShortBlocks.IsChecked == true;
            mp3Output.EnableXingVBRTag = cbLameEnableXingVBRTag.IsChecked == true;
            mp3Output.ModeFixed = cbLameModeFixed.IsChecked == true;
        }

        private void SetGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            gifOutput.FrameRate = Convert.ToDouble(edGIFFrameRate.Text);
            gifOutput.ForcedVideoWidth = Convert.ToInt32(edGIFWidth.Text);
            gifOutput.ForcedVideoHeight = Convert.ToInt32(edGIFHeight.Text);
        }

        /// <summary>
        /// Fills FFMPEG EXE settings.
        /// </summary>
        /// <param name="ffmpegOutput">
        /// Settings.
        /// </param>
        private void SetFFMPEGEXEOutput(ref VFFFMPEGEXEOutput ffmpegOutput)
        {
            ffmpegOutput.Custom_AdditionalAudioArgs = edFFEXECustomParametersAudio.Text;
            ffmpegOutput.Custom_AdditionalVideoArgs = edFFEXECustomParametersVideo.Text;

            if (cbFFEXEUseOnlyAdditionalParameters.IsChecked == true)
            {
                ffmpegOutput.Custom_AllFFMPEGArgs = edFFEXECustomParametersCommon.Text;
            }
            else
            {
                ffmpegOutput.Custom_AdditionalCommonArgs = edFFEXECustomParametersCommon.Text;
            }

            switch (cbFFEXEOutputFormat.SelectedIndex)
            {
                case 0:
                    // 3G2
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Mobile3G2;
                    break;
                case 1:
                    // 3GP
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Mobile3GP;
                    break;
                case 2:
                    // AC3
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.AC3;
                    break;
                case 3:
                    // ADTS
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ADTS;
                    break;
                case 4:
                    // AVI
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.AVI;
                    break;
                case 5:
                    // DTS
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.DTS;
                    break;
                case 6:
                    // DTS-HD
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.DTSHD;
                    break;
                case 7:
                    // DVD (VOB)
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VOB;
                    break;
                case 8:
                    // E-AC3
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.EAC3;
                    break;
                case 9:
                    // F4V
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.F4V;
                    break;
                case 10:
                    // FLAC
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLAC;
                    break;
                case 11:
                    // FLV
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLV;
                    break;
                case 12:
                    // GIF
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.GIF;
                    break;
                case 13:
                    // H263
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.H263;
                    break;
                case 14:
                    // H264
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.H264;
                    break;
                case 15:
                    // HEVC
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.HEVC;
                    break;
                case 16:
                    // Matroska
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Matroska;
                    break;
                case 17:
                    // M4V
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.M4V;
                    break;
                case 18:
                    // MJPEG
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MJPEG;
                    break;
                case 19:
                    // MOV
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MOV;
                    break;
                case 20:
                    // MP2
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP2;
                    break;
                case 21:
                    // MP3
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP3;
                    break;
                case 22:
                    // MP4
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP4;
                    break;
                case 23:
                    // MPEG
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEG;
                    break;
                case 24:
                    // MPEGTS
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS;
                    break;
                case 25:
                    // MXF
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MXF;
                    break;
                case 26:
                    // OGG
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.OGG;
                    break;
                case 27:
                    // OPUS
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.OPUS;
                    break;
                case 28:
                    // PSP MP4
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.PSP;
                    break;
                case 29:
                    // RAWVideo
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.RAWVideo;
                    break;
                case 30:
                    // SVCD
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.SVCD;
                    break;
                case 31:
                    // SWF
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.SWF;
                    break;
                case 32:
                    // TrueHD
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.TrueHD;
                    break;
                case 33:
                    // VC1
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VC1;
                    break;
                case 34:
                    // VCD
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VCD;
                    break;
                case 35:
                    // WAV
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WAV;
                    break;
                case 36:
                    // WebM
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WebM;
                    break;
                case 37:
                    // WTV
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WTV;
                    break;
                case 38:
                    // WV (WavPack)
                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WV;
                    break;
            }

            switch (cbFFEXEVideoCodec.SelectedIndex)
            {
                case 0:
                    // Auto
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.Auto;
                    break;
                case 1:
                    // DV
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.DVVideo;
                    break;
                case 2:
                    // FLV1
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.FLV1;
                    break;
                case 3:
                    // GIF
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.GIF;
                    break;
                case 4:
                    // H263
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.H263;
                    break;
                case 5:
                    // H264
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.H264;
                    break;
                case 6:
                    // HEVC
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HEVC;
                    break;
                case 7:
                    // HuffYUV
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HuffYUV;
                    break;
                case 8:
                    // JPEG 2000
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEG2000;
                    break;
                case 9:
                    // JPEG-LS
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEGLS;
                    break;
                case 10:
                    // LJPEG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.LJPEG;
                    break;
                case 11:
                    // MJPEG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MJPEG;
                    break;
                case 12:
                    // MPEG-1
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG1Video;
                    break;
                case 13:
                    // MPEG-2
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG2Video;
                    break;
                case 14:
                    // MPEG-4
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG4;
                    break;
                case 15:
                    // PNG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.PNG;
                    break;
                case 16:
                    // Theora
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.Theora;
                    break;
                case 17:
                    // VP8
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.VP8;
                    break;
                case 18:
                    // VP9
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.VP9;
                    break;
            }

            switch (cbFFEXEAspectRatio.SelectedIndex)
            {
                case 0:
                    ffmpegOutput.Video_AspectRatioW = 0;
                    ffmpegOutput.Video_AspectRatioH = 1;
                    break;
                case 1:
                    ffmpegOutput.Video_AspectRatioW = 1;
                    ffmpegOutput.Video_AspectRatioH = 1;
                    break;
                case 2:
                    ffmpegOutput.Video_AspectRatioW = 4;
                    ffmpegOutput.Video_AspectRatioH = 3;
                    break;
                case 3:
                    ffmpegOutput.Video_AspectRatioW = 16;
                    ffmpegOutput.Video_AspectRatioH = 9;
                    break;
            }

            if (cbFFEXEVideoResolutionOriginal.IsChecked == true)
            {
                ffmpegOutput.Video_Width = 0;
                ffmpegOutput.Video_Height = 0;
            }
            else
            {
                ffmpegOutput.Video_Width = Convert.ToInt32(edFFEXEVideoWidth.Text);
                ffmpegOutput.Video_Height = Convert.ToInt32(edFFEXEVideoHeight.Text);
            }

            if (rbFFEXEVideoModeCBR.IsChecked == true)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.CBR;
            }
            else if (rbFFEXEVideoModeQuality.IsChecked == true)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.Quality;
            }
            else if (rbFFEXEVideoModeABR.IsChecked == true)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.ABR;
            }

            ffmpegOutput.Video_Bitrate = Convert.ToInt32(edFFEXEVideoTargetBitrate.Text) * 1000;
            ffmpegOutput.Video_MaxBitrate = Convert.ToInt32(edFFEXEVideoBitrateMax.Text) * 1000;
            ffmpegOutput.Video_MinBitrate = Convert.ToInt32(edFFEXEVideoBitrateMin.Text) * 1000;
            ffmpegOutput.Video_BufferSize = Convert.ToInt32(edFFEXEVBVBufferSize.Text);
            ffmpegOutput.Video_GOPSize = Convert.ToInt32(edFFEXEVideoGOPSize.Text);
            ffmpegOutput.Video_BFrames = Convert.ToInt32(edFFEXEVideoBFramesCount.Text);
            ffmpegOutput.Video_Interlace = cbFFEXEVideoInterlace.IsChecked == true;
            ffmpegOutput.Video_Letterbox = cbFFEXEVideoResolutionLetterbox.IsChecked == true;
            ffmpegOutput.Video_Quality = (int)tbFFEXEVideoQuality.Value;

            ffmpegOutput.Video_H264_Quantizer = (int)tbFFEXEH264Quantizer.Value;
            ffmpegOutput.Video_H264_Mode = (VFFFMPEGEXEH264Mode)cbFFEXEH264Mode.SelectedIndex;
            ffmpegOutput.Video_H264_Preset = (VFFFMPEGEXEH264Preset)cbFFEXEH264Preset.SelectedIndex;
            ffmpegOutput.Video_H264_Profile = (VFFFMPEGEXEH264Profile)cbFFEXEH264Profile.SelectedIndex;
            ffmpegOutput.Video_H264_QuickTime_Compatibility = cbFFEXEH264QuickTimeCompatibility.IsChecked == true;
            ffmpegOutput.Video_H264_ZeroTolerance = cbFFEXEH264ZeroTolerance.IsChecked == true;
            ffmpegOutput.Video_H264_WebFastStart = cbFFEXEH264WebFastStart.IsChecked == true;
            ffmpegOutput.Video_TVSystem = (VFFFMPEGEXETVSystem)cbFFEXEVideoConstraint.SelectedIndex;

            switch (cbFFEXEH264Level.SelectedIndex)
            {
                case 0:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.None;
                    break;
                case 1:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level1;
                    break;
                case 2:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level11;
                    break;
                case 3:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level12;
                    break;
                case 4:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level13;
                    break;
                case 5:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level2;
                    break;
                case 6:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level21;
                    break;
                case 7:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level22;
                    break;
                case 8:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level3;
                    break;
                case 9:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level31;
                    break;
                case 10:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level32;
                    break;
                case 11:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level4;
                    break;
                case 12:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level41;
                    break;
                case 13:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level42;
                    break;
                case 14:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level5;
                    break;
                case 15:
                    ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level51;
                    break;
            }

            switch (cbFFEXEAudioCodec.SelectedIndex)
            {
                case 0:
                    // Auto
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Auto;
                    break;
                case 1:
                    // AAC
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AAC;
                    break;
                case 2:
                    // AC3
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AC3;
                    break;
                case 3:
                    // G722
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_g722;
                    break;
                case 4:
                    // G726
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_g726;
                    break;
                case 5:
                    // ADPCM
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_ms;
                    break;
                case 6:
                    // ALAC
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.ALAC;
                    break;
                case 7:
                    // AMR-NB
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AMR_NB;
                    break;
                case 8:
                    // AMR-WB
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AMR_WB;
                    break;
                case 9:
                    // E-AC3
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.EAC3;
                    break;
                case 10:
                    // FLAC
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.FLAC;
                    break;
                case 11:
                    // G723
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.G723_1;
                    break;
                case 12:
                    // MP2
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.MP2;
                    break;
                case 13:
                    // MP3
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.MP3;
                    break;
                case 14:
                    // OPUS
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.OPUS;
                    break;
                case 15:
                    // PCM ALAW
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_ALAW;
                    break;
                case 16:
                    // PCM F32BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F32BE;
                    break;
                case 17:
                    // PCM F32LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F32LE;
                    break;
                case 18:
                    // PCM F64BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F64BE;
                    break;
                case 19:
                    // PCM F64LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F64LE;
                    break;
                case 20:
                    // PCM MULAW
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_MULAW;
                    break;
                case 21:
                    // PCM S16BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16BE;
                    break;
                case 22:
                    // PCM S16BE Planar
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16BE_Planar;
                    break;
                case 23:
                    // PCM S16LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16LE;
                    break;
                case 24:
                    // PCM S16LE Planar
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16LE_Planar;
                    break;
                case 25:
                    // PCM S24BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24BE;
                    break;
                case 26:
                    // PCM S24LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24LE;
                    break;
                case 27:
                    // PCM S24LE Planar
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24LE_Planar;
                    break;
                case 28:
                    // PCM S32BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32BE;
                    break;
                case 29:
                    // PCM S32LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32LE;
                    break;
                case 30:
                    // PCM S32LE Planar
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32LE_Planar;
                    break;
                case 31:
                    // PCM S8
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S8;
                    break;
                case 32:
                    // PCM S8 Planar
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S8_Planar;
                    break;
                case 33:
                    // PCM U16BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U16BE;
                    break;
                case 34:
                    // PCM U16LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U16LE;
                    break;
                case 35:
                    // PCM U24BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U24BE;
                    break;
                case 36:
                    // PCM U24LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U24LE;
                    break;
                case 37:
                    // PCM U32BE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U32BE;
                    break;
                case 38:
                    // PCM U32LE
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U32LE;
                    break;
                case 39:
                    // PCM U8
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U8;
                    break;
                case 40:
                    // Speex
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Speex;
                    break;
                case 41:
                    // Vorbis
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Vorbis;
                    break;
                case 42:
                    // WavPack
                    ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.WavPack;
                    break;
            }

            if (cbFFEXEAudioChannels.SelectedIndex == 0)
            {
                ffmpegOutput.Audio_Channels = 0;
            }
            else
            {
                ffmpegOutput.Audio_Channels = Convert.ToInt32(cbFFEXEAudioChannels.Text);
            }

            if (cbFFEXEAudioSampleRate.SelectedIndex == 0)
            {
                ffmpegOutput.Audio_SampleRate = 0;
            }
            else
            {
                ffmpegOutput.Audio_SampleRate = Convert.ToInt32(cbFFEXEAudioSampleRate.Text);
            }

            if (cbFFEXEAudioBitrate.SelectedIndex == 0)
            {
                ffmpegOutput.Audio_Bitrate = 0;
            }
            else
            {
                ffmpegOutput.Audio_Bitrate = Convert.ToInt32(cbFFEXEAudioBitrate.Text) * 1000;
            }

            ffmpegOutput.Audio_Quality = (int)tbFFEXEAudioQuality.Value;

            if (rbFFEXEAudioModeCBR.IsChecked == true)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.CBR;
            }
            else if (rbFFEXEAudioModeQuality.IsChecked == true)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Quality;
            }
            else if (rbFFEXEAudioModeABR.IsChecked == true)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.ABR;
            }
            else if (rbFFEXEAudioModeLossless.IsChecked == true)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Lossless;
            }
        }

        private void SetWMVSettings(ref VFWMVOutput wmvOutput)
        {
            if (rbWMVInternal9.IsChecked == true)
            {
                wmvOutput.Mode = VFWMVMode.InternalProfile;

                if (cbWMVInternalProfile9.SelectedIndex != -1)
                {
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                }
            }
            else if (rbWMVInternal8.IsChecked == true)
            {
                wmvOutput.Mode = VFWMVMode.V8SystemProfile;

                if (cbWMVInternalProfile8.SelectedIndex != -1)
                {
                    wmvOutput.V8ProfileName = cbWMVInternalProfile8.Text;
                }
            }
            else if (rbWMVExternal.IsChecked == true)
            {
                wmvOutput.Mode = VFWMVMode.ExternalProfile;
                wmvOutput.External_Profile_FileName = edWMVProfile.Text;
            }
            else
            {
                wmvOutput.Mode = VFWMVMode.CustomSettings;

                wmvOutput.Custom_Audio_Codec = cbWMVAudioCodec.Text;
                wmvOutput.Custom_Audio_Format = cbWMVAudioFormat.Text;
                wmvOutput.Custom_Audio_PeakBitrate = Convert.ToInt32(edWMVAudioPeakBitrate.Text);

                string s = cbWMVAudioMode.Text;
                if (s == "CBR")
                {
                    wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.CBR;
                }
                else if (s == "VBR")
                {
                    wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRBitrate;
                }
                else if (s == "VBR (Peak)")
                {
                    wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRPeakBitrate;
                }
                else
                {
                    wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRQuality;
                }

                wmvOutput.Custom_Audio_StreamPresent = cbWMVAudioEnabled.IsChecked == true;

                wmvOutput.Custom_Video_Codec = cbWMVVideoCodec.Text;
                wmvOutput.Custom_Video_Width = Convert.ToInt32(edWMVWidth.Text);
                wmvOutput.Custom_Video_Height = Convert.ToInt32(edWMVHeight.Text);
                wmvOutput.Custom_Video_SizeSameAsInput = cbWMVSizeSameAsInput.IsChecked == true;
                wmvOutput.Custom_Video_FrameRate = Convert.ToDouble(edWMVFrameRate.Text);
                wmvOutput.Custom_Video_KeyFrameInterval = Convert.ToByte(edWMVKeyFrameInterval.Text);
                wmvOutput.Custom_Video_Bitrate = Convert.ToInt32(edWMVVideoBitrate.Text);
                wmvOutput.Custom_Video_Quality = Convert.ToByte(edWMVVideoQuality.Text);

                s = cbWMVVideoMode.Text;
                switch (s)
                {
                    case "CBR":
                        wmvOutput.Custom_Video_Mode = VFWMVStreamMode.CBR;
                        break;
                    case "VBR":
                        wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRBitrate;
                        break;
                    case "VBR (Peak)":
                        wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRPeakBitrate;
                        break;
                    default:
                        wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRQuality;
                        break;
                }

                switch (cbWMVTVFormat.Text)
                {
                    case "PAL":
                        wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.PAL;
                        break;
                    case "NTSC":
                        wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.NTSC;
                        break;
                    default:
                        wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.Other;
                        break;
                }

                wmvOutput.Custom_Video_StreamPresent = cbWMVVideoEnabled.IsChecked == true;

                wmvOutput.Custom_Profile_Name = "My_Profile_1";
            }
        }

        private void lbVLCRedist_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe");
            Process.Start(startInfo);
        }

        private void Form1_Load(object sender, RoutedEventArgs e)
        {
            Title += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            // font for text logo
            fontDialog.Color = System.Drawing.Color.White;
            fontDialog.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 32);

            // set combobox indexes
            cbMode.SelectedIndex = 0;
            cbOutputFormat.SelectedIndex = 0;
            cbDVChannels.SelectedIndex = 0;
            cbDVSampleRate.SelectedIndex = 0;
            cbOGGAverage.SelectedIndex = 6;
            cbOGGMaximum.SelectedIndex = 8;
            cbOGGMinimum.SelectedIndex = 5;
            cbResizeMode.SelectedIndex = 0;
            cbImageType.SelectedIndex = 1;
            cbTextLogoAlign.SelectedIndex = 0;
            cbTextLogoAntialiasing.SelectedIndex = 0;
            cbTextLogoDrawMode.SelectedIndex = 0;
            cbTextLogoEffectrMode.SelectedIndex = 0;
            cbTextLogoGradMode.SelectedIndex = 0;
            cbTextLogoShapeType.SelectedIndex = 0;
            cbMotDetHLColor.SelectedIndex = 1;
            cbIPCameraType.SelectedIndex = 2;
            cbRotate.SelectedIndex = 0;
            cbBarcodeType.SelectedIndex = 0;
            cbNetworkStreamingMode.SelectedIndex = 0;
            cbDirect2DRotate.SelectedIndex = 0;

            cbDVChannels.SelectedIndex = 1;
            cbDVSampleRate.SelectedIndex = 0;
            cbBPS.SelectedIndex = 1;
            cbChannels.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbBPS2.SelectedIndex = 0;
            cbChannels2.SelectedIndex = 0;
            cbSampleRate2.SelectedIndex = 0;
            cbLameCBRBitrate.SelectedIndex = 8;
            cbLameVBRMin.SelectedIndex = 8;
            cbLameVBRMax.SelectedIndex = 10;
            cbLameSampleRate.SelectedIndex = 0;

            cbCustomAudioSourceCategory.SelectedIndex = 0;
            cbCustomVideoSourceCategory.SelectedIndex = 0;

            cbCustomAudioSourceCategory_SelectionChanged(null, null);
            cbCustomVideoSourceCategory_SelectionChanged(null, null);

            cbWebMVideoEndUsageMode.SelectedIndex = 0;
            edWebMVideoThreadCount.Text = Environment.ProcessorCount.ToString(CultureInfo.InvariantCulture);
            cbWebMVideoEncoder.SelectedIndex = 0;
            cbWebMVideoKeyframeMode.SelectedIndex = 0;
            cbWebMVideoQualityMode.SelectedIndex = 0;

            cbFFAspectRatio.SelectedIndex = 0;
            cbFFAudioBitrate.SelectedIndex = 8;
            cbFFAudioChannels.SelectedIndex = 0;
            cbFFAudioSampleRate.SelectedIndex = 1;
            cbFFConstaint.SelectedIndex = 0;
            cbFFOutputFormat.SelectedIndex = 0;

            cbFFEXEAspectRatio.SelectedIndex = 0;
            cbFFEXEAudioBitrate.SelectedIndex = 8;
            cbFFEXEAudioChannels.SelectedIndex = 0;
            cbFFEXEAudioSampleRate.SelectedIndex = 0;
            cbFFEXEProfile.SelectedIndex = 7;
            cbFFEXEH264Mode.SelectedIndex = 0;
            cbFFEXEH264Level.SelectedIndex = 0;
            cbFFEXEH264Preset.SelectedIndex = 0;
            cbFFEXEH264Profile.SelectedIndex = 0;
            cbFFEXEVideoConstraint.SelectedIndex = 0;
            
            cbNVENCProfile.SelectedIndex = 2;
            cbNVENCLevel.SelectedIndex = 0;
            cbNVENCRateControl.SelectedIndex = 1;

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbH264MBEncoding.SelectedIndex = 0;
            cbAACOutput.SelectedIndex = 0;
            cbAACMPEGVersion.SelectedIndex = 0;
            cbAACObject.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 16;
            cbH264PictureType.SelectedIndex = 0;
            cbH264TargetUsage.SelectedIndex = 3;

            cbFaceTrackingColorMode.SelectedIndex = 0;
            cbFaceTrackingScalingMode.SelectedIndex = 0;
            cbFaceTrackingSearchMode.SelectedIndex = 1;

            cbM4AOutput.SelectedIndex = 0;
            cbM4AVersion.SelectedIndex = 0;
            cbM4AObjectType.SelectedIndex = 1;
            cbM4ABitrate.SelectedIndex = 12;

            rbMotionDetectionExProcessor.SelectedIndex = 1;
            rbMotionDetectionExDetector.SelectedIndex = 1;

            var genres = new List<string>();
            foreach (var genre in VideoCapture.Tags_GetDefaultVideoGenres())
            {
                genres.Add(genre);
            }

            foreach (var genre in VideoCapture.Tags_GetDefaultAudioGenres())
            {
                genres.Add(genre);
            }

            genres.Sort();
            foreach (var genre in genres)
            {
                cbTagGenre.Items.Add(genre);
            }

            cbTagGenre.SelectedIndex = 0;

            cbPIPMode.SelectedIndex = 0;
            
            foreach (var screen in Screen.AllScreens)
            {
                cbScreenCaptureDisplayIndex.Items.Add(screen.DeviceName.Replace(@"\\.\DISPLAY", string.Empty));
            }

            cbScreenCaptureDisplayIndex.SelectedIndex = 0;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";

            foreach (string codec in VideoCapture1.Video_Codecs)
            {
                cbVideoCodecs.Items.Add(codec);
                cbCustomVideoCodecs.Items.Add(codec);
            }

            if (cbVideoCodecs.Items.Count > 0)
            {
                cbVideoCodecs.SelectedIndex = 0;
                cbVideoCodecs_SelectedIndexChanged(null, null);
                cbCustomVideoCodecs.SelectedIndex = 0;
                cbCustomVideoCodecs_SelectedIndexChanged(null, null);
            }

            VideoCapture1.TVTuner_Read();

            foreach (string tunerDevice in VideoCapture1.TVTuner_Devices)
            {
                cbTVTuner.Items.Add(tunerDevice);
            }

            if (cbTVTuner.Items.Count > 0)
            {
                cbTVTuner.SelectedIndex = 0;
            }

            foreach (string tunerTVFormat in VideoCapture1.TVTuner_TVFormats())
            {
                cbTVSystem.Items.Add(tunerTVFormat);
            }

            cbTVSystem.SelectedIndex = 0;

            foreach (string tunerCountry in VideoCapture1.TVTuner_Countries)
            {
                cbTVCountry.Items.Add(tunerCountry);
            }

            cbTVCountry.SelectedIndex = 0;

            cbTVTuner_SelectedIndexChanged(null, null);

            foreach (var device in VideoCapture1.Video_CaptureDevicesInfo)
            {
                cbVideoInputDevice.Items.Add(device.Name);
                cbPIPDevice.Items.Add(device.Name);
            }

            if (cbVideoInputDevice.Items.Count > 0)
            {
                cbVideoInputDevice.SelectedIndex = 0;
                cbVideoInputDevice_SelectedIndexChanged(null, null);
                cbPIPDevice.SelectedIndex = 0;
                cbPIPDevice_SelectedIndexChanged(null, null);
            }

            foreach (string codec in VideoCapture1.Audio_Codecs)
            {
                cbAudioCodecs.Items.Add(codec);
                cbAudioCodecs2.Items.Add(codec);
                cbCustomAudioCodecs.Items.Add(codec);
            }

            if (cbAudioCodecs.Items.Count > 0)
            {
                cbAudioCodecs.SelectedIndex = 0;
                cbAudioCodecs_SelectedIndexChanged(null, null);
                cbAudioCodecs2.SelectedIndex = 0;
                cbAudioCodecs2_SelectedIndexChanged(null, null);
                cbCustomAudioCodecs.SelectedIndex = 0;
                cbCustomAudioCodecs_SelectedIndexChanged(null, null);
            }
            
            cbAudioCodecs.Text = "PCM";
            cbAudioCodecs2.Text = "PCM";

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                cbAudioInputDevice.Items.Add(device.Name);
                cbAdditionalAudioSource.Items.Add(device.Name);
            }

            if (cbAudioInputDevice.Items.Count > 0)
            {
                cbAudioInputDevice.SelectedIndex = 0;
                cbAudioInputDevice_SelectedIndexChanged(null, null);
                cbAdditionalAudioSource.SelectedIndex = 0;
            }

            foreach (string audioOutputDevice in VideoCapture1.Audio_OutputDevices)
            {
                cbAudioOutputDevice.Items.Add(audioOutputDevice);
            }

            if (cbAudioOutputDevice.Items.Count > 0)
            {
                cbAudioOutputDevice.SelectedIndex = 0;
                cbAudioOutputDevice_SelectedIndexChanged(null, null);
            }

            if (!string.IsNullOrEmpty(cbAudioInputDevice.Text))
            {
                var deviceItem =
                    VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem != null)
                {
                    foreach (string line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }

                    if (cbAudioInputLine.Items.Count > 0)
                    {
                        cbAudioInputLine.SelectedIndex = 0;
                        cbAudioInputLine_SelectedIndexChanged(null, null);
                    }
                }
            }

            cbAudioInputFormat_SelectedIndexChanged(null, null);
            cbVideoInputFormat_SelectedIndexChanged(null, null);

            foreach (string directShowFilter in VideoCapture1.DirectShow_Filters)
            {
                cbCustomDSFilterA.Items.Add(directShowFilter);
                cbCustomDSFilterV.Items.Add(directShowFilter);
                cbCustomMuxer.Items.Add(directShowFilter);
                cbCustomFilewriter.Items.Add(directShowFilter);
            }

            if (cbCustomDSFilterA.Items.Count > 0)
            {
                cbCustomDSFilterA.SelectedIndex = 0;
                cbCustomDSFilterA_SelectedIndexChanged(null, null);
                cbCustomDSFilterV.SelectedIndex = 0;
                cbCustomDSFilterV_SelectedIndexChanged(null, null);
                cbCustomMuxer.SelectedIndex = 0;
                cbCustomMuxer_SelectedIndexChanged(null, null);
                cbCustomFilewriter.SelectedIndex = 0;
                cbCustomFilewriter_SelectedIndexChanged(null, null);
            }

            foreach (string specialFilter in VideoCapture1.Special_Filters(VFSpecialFilterType.HardwareVideoEncoder))
            {
                cbMPEGEncoder.Items.Add(specialFilter);
            }

            if (cbMPEGEncoder.Items.Count > 0)
            {
                cbMPEGEncoder.SelectedIndex = 0;
            }

            foreach (string directShowFilter in VideoCapture1.DirectShow_Filters)
            {
                cbFilters.Items.Add(directShowFilter);
            }

            cbMPEGVideoDecoder.Items.Add("(default)");
            cbMPEGAudioDecoder.Items.Add("(default)");

            foreach (string specialFilter in VideoCapture1.Special_Filters(VFSpecialFilterType.MPEG12VideoDecoder))
            {
                cbMPEGVideoDecoder.Items.Add(specialFilter);
            }

            if (cbMPEGVideoDecoder.Items.Count > 0)
            {
                cbMPEGVideoDecoder.SelectedIndex = 0;
            }

            foreach (string specialFilter in VideoCapture1.Special_Filters(VFSpecialFilterType.MPEG1AudioDecoder))
            {
                cbMPEGAudioDecoder.Items.Add(specialFilter);
            }

            if (cbMPEGAudioDecoder.Items.Count > 0)
            {
                cbMPEGAudioDecoder.SelectedIndex = 0;
            }

            cbMPEGVideoDecoder_SelectedIndexChanged(null, null);
            cbMPEGAudioDecoder_SelectedIndexChanged(null, null);

            if (cbVideoCodecs.Items.IndexOf("MJPEG Compressor") != -1)
            {
                cbVideoCodecs.SelectedIndex = cbVideoCodecs.Items.IndexOf("MJPEG Compressor");
            }

            if (cbAudioCodecs.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodecs.SelectedIndex = cbAudioCodecs.Items.IndexOf("PCM");
            }

            cbWMVAudioMode_SelectedIndexChanged(sender, null);
            cbWMVVideoMode_SelectedIndexChanged(sender, null);

            if (cbWMVVideoCodec.Items.Count > 0)
            {
                cbWMVVideoCodec.SelectedIndex = 0;
            }

            if (cbWMVAudioCodec.Items.Count > 0)
            {
                cbWMVAudioCodec.SelectedIndex = 0;
            }

            cbWMVAudioCodec_SelectedIndexChanged(sender, null);

            if (cbWMVAudioFormat.Items.Count > 0)
            {
                cbWMVAudioFormat.SelectedIndex = 0;
            }

            foreach (string profile in VideoCapture1.WMV_Internal_Profiles())
            {
                cbWMVInternalProfile9.Items.Add(profile);
            }

            if (cbWMVInternalProfile9.Items.Count > 7)
            {
                cbWMVInternalProfile9.SelectedIndex = 7;
            }

            List<string> names;
            List<string> descs;
            VideoCapture1.WMV_V8_Profiles(out names, out descs);

            foreach (string name in names)
            {
                cbWMVInternalProfile8.Items.Add(name);
            }

            if (cbWMVInternalProfile8.Items.Count > 0)
            {
                cbWMVInternalProfile8.SelectedIndex = 0;
            }

            // ReSharper disable once CoVariantArrayConversion
            foreach (var item in VideoCapture1.Audio_Effects_Equalizer_Presets())
            {
                cbAudEqualizerPreset.Items.Add(item);
            }

            cbAudEqualizerPreset.SelectedIndex = 0;

            // Decklink
            foreach (var device in VideoCapture1.Decklink_CaptureDevices)
            {
                cbDecklinkCaptureDevice.Items.Add(device.Name);
            }

            if (cbDecklinkCaptureDevice.Items.Count > 0)
            {
                cbDecklinkCaptureDevice.SelectedIndex = 0;
                cbDecklinkCaptureDevice_SelectionChanged(null, null);
            }
        }

        private void cbVideoInputDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVideoInputDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureDevice = e.AddedItems[0].ToString();

                cbVideoInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == e.AddedItems[0].ToString());
                if (deviceItem != null)
                {
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

                    // currently device active, we can read TV Tuner name
                    var tvTuner = deviceItem.TVTuner;
                    if (tvTuner != null)
                    {
                        int k = cbTVTuner.Items.IndexOf(tvTuner);
                        if (k >= 0)
                        {
                            cbTVTuner.SelectedIndex = k;
                        }
                    }

                    cbCrossBarAvailable.IsEnabled =
                        VideoCapture1.Video_CaptureDevice_CrossBar_Init(e.AddedItems[0].ToString());
                    cbCrossBarAvailable.IsChecked = cbCrossBarAvailable.IsEnabled;

                    if (cbCrossBarAvailable.IsEnabled)
                    {
                        cbCrossbarInput.IsEnabled = true;
                        cbCrossbarOutput.IsEnabled = true;
                        rbCrossbarSimple.IsEnabled = true;
                        rbCrossbarAdvanced.IsEnabled = true;
                        cbCrossbarVideoInput.IsEnabled = true;
                        btConnect.IsEnabled = true;
                        cbConnectRelated.IsEnabled = true;
                        lbRotes.IsEnabled = true;

                        VideoCapture1.Video_CaptureDevice_CrossBar_ClearConnections();

                        cbCrossbarVideoInput.Items.Clear();
                        foreach (
                            string s in VideoCapture1.Video_CaptureDevice_CrossBar_GetInputsForOutput("Video Decoder"))
                        {
                            cbCrossbarVideoInput.Items.Add(s);
                        }

                        cbCrossbarVideoInput.SelectedIndex = 0;

                        cbCrossbarOutput.Items.Clear();

                        foreach (string output in VideoCapture1.Video_CaptureDevice_CrossBar_Outputs())
                        {
                            cbCrossbarOutput.Items.Add(output);
                        }

                        if (cbCrossbarOutput.Items.Count > 0)
                        {
                            cbCrossbarOutput.SelectedIndex = 0;
                            cbCrossbarOutput_SelectedIndexChanged(null, null);
                        }

                        lbRotes.Items.Clear();
                        for (int i = 0; i < cbCrossbarOutput.Items.Count; i++)
                        {
                            string input =
                                VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(
                                    cbCrossbarOutput.Text);

                            if (input != string.Empty)
                            {
                                lbRotes.Items.Add("Input: " + input + ", Output: " + cbCrossbarOutput.Items[i]);
                            }
                        }
                    }
                    else
                    {
                        cbCrossbarInput.IsEnabled = false;
                        cbCrossbarOutput.IsEnabled = false;
                        rbCrossbarSimple.IsEnabled = false;
                        rbCrossbarAdvanced.IsEnabled = false;
                        cbCrossbarVideoInput.IsEnabled = false;
                        btConnect.IsEnabled = false;
                        cbConnectRelated.IsEnabled = false;
                        lbRotes.IsEnabled = false;
                    }

                    // updating adjust settings
                    int max;
                    int defaultValue;
                    int min;
                    bool auto;
                    int step;
                    if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(
                        VFVideoHardwareAdjustment.Brightness,
                        out min,
                        out max,
                        out step,
                        out defaultValue,
                        out auto))
                    {
                        tbAdjBrightness.Minimum = min;
                        tbAdjBrightness.Maximum = max;
                        tbAdjBrightness.SmallChange = step;
                        tbAdjBrightness.Value = defaultValue;
                        cbAdjBrightnessAuto.IsChecked = auto;
                        lbAdjBrightnessMin.Content = "Min: " + Convert.ToString(min);
                        lbAdjBrightnessMax.Content = "Max: " + Convert.ToString(max);
                        lbAdjBrightnessCurrent.Content = "Current: " + Convert.ToString(defaultValue);
                    }

                    if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(
                        VFVideoHardwareAdjustment.Hue,
                        out min,
                        out max,
                        out step,
                        out defaultValue,
                        out auto))
                    {
                        tbAdjHue.Minimum = min;
                        tbAdjHue.Maximum = max;
                        tbAdjHue.SmallChange = step;
                        tbAdjHue.Value = defaultValue;
                        cbAdjHueAuto.IsChecked = auto;
                        lbAdjHueMin.Content = "Min: " + Convert.ToString(min);
                        lbAdjHueMax.Content = "Max: " + Convert.ToString(max);
                        lbAdjHueCurrent.Content = "Current: " + Convert.ToString(defaultValue);
                    }

                    if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(
                        VFVideoHardwareAdjustment.Saturation,
                        out min,
                        out max,
                        out step,
                        out defaultValue,
                        out auto))
                    {
                        tbAdjSaturation.Minimum = min;
                        tbAdjSaturation.Maximum = max;
                        tbAdjSaturation.SmallChange = step;
                        tbAdjSaturation.Value = defaultValue;
                        cbAdjSaturationAuto.IsChecked = auto;
                        lbAdjSaturationMin.Content = "Min: " + Convert.ToString(min);
                        lbAdjSaturationMax.Content = "Max: " + Convert.ToString(max);
                        lbAdjSaturationCurrent.Content = "Current: " + Convert.ToString(defaultValue);
                    }

                    if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(
                        VFVideoHardwareAdjustment.Contrast,
                        out min,
                        out max,
                        out step,
                        out defaultValue,
                        out auto))
                    {
                        tbAdjContrast.Minimum = min;
                        tbAdjContrast.Maximum = max;
                        tbAdjContrast.SmallChange = step;
                        tbAdjContrast.Value = defaultValue;
                        cbAdjContrastAuto.IsChecked = auto;
                        lbAdjContrastMin.Content = "Min: " + Convert.ToString(min);
                        lbAdjContrastMax.Content = "Max: " + Convert.ToString(max);
                        lbAdjContrastCurrent.Content = "Current: " + Convert.ToString(defaultValue);
                    }

                    cbUseAudioInputFromVideoCaptureDevice.IsEnabled = deviceItem.AudioOutput;
                    btVideoCaptureDeviceSettings.IsEnabled = deviceItem.DialogDefault;
                }
            }
        }

        private void cbAudioInputDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbAudioInputDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Audio_CaptureDevice = e.AddedItems[0].ToString();
                cbAudioInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == e.AddedItems[0].ToString());
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

                    cbAudioInputFormat_SelectedIndexChanged(null, null);

                    cbAudioInputLine.Items.Clear();

                    foreach (string line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }

                    if (cbAudioInputLine.Items.Count > 0)
                    {
                        cbAudioInputLine.SelectedIndex = 0;
                    }

                    cbAudioInputLine_SelectedIndexChanged(null, null);

                    btAudioInputDeviceSettings.IsEnabled = deviceItem.DialogDefault;
                }
            }
        }

        private void btAudioSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbAudioCodecs.Text;

            if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btSelectWM_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        private void SelectScreenCaptureSource(out ScreenCaptureSourceSettings settings)
        {
            settings = new ScreenCaptureSourceSettings();
            if (rbScreenCaptureWindow.IsChecked == true)
            {
                settings.Mode = VFScreenCaptureMode.Window;
                settings.WindowHandle = IntPtr.Zero;

                try
                {
                    settings.WindowHandle = FindWindow(
                        edScreenCaptureWindowName.Text,
                        null);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect window title for screen capture.");
                    return;
                }

                if (settings.WindowHandle == IntPtr.Zero)
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect window title for screen capture.");
                    return;
                }
            }
            else
            {
                settings.Mode = VFScreenCaptureMode.Screen;
            }

            settings.FrameRate = (float)Convert.ToDouble(edScreenFrameRate.Text);
            settings.FullScreen = rbScreenFullScreen.IsChecked == true;
            settings.Top = Convert.ToInt32(edScreenTop.Text);
            settings.Bottom = Convert.ToInt32(edScreenBottom.Text);
            settings.Left = Convert.ToInt32(edScreenLeft.Text);
            settings.Right = Convert.ToInt32(edScreenRight.Text);
            settings.GrabMouseCursor = cbScreenCapture_GrabMouseCursor.IsChecked
                                                                  == true;
            settings.DisplayIndex = Convert.ToInt32(cbScreenCaptureDisplayIndex.Text);
            settings.AllowDesktopDuplicationEngine = cbScreenCapture_DesktopDuplication.IsChecked == true;
        }

        private void SelectIPCameraSource(out IPCameraSourceSettings settings)
        {
            settings = new IPCameraSourceSettings
                           {
                               URL = this.edIPUrl.Text
                           };

            switch (cbIPCameraType.SelectedIndex)
            {
                case 0:
                    settings.Type = VFIPSource.Auto_VLC;
                    break;
                case 1:
                    settings.Type = VFIPSource.Auto_FFMPEG;
                    break;
                case 2:
                    settings.Type = VFIPSource.Auto_LAV;
                    break;
                case 3:
                    settings.Type = VFIPSource.RTSP_Live555;
                    break;
                case 4:
                    settings.Type = VFIPSource.HTTP_FFMPEG;
                    break;
                case 5:
                    settings.Type = VFIPSource.MMS_WMV;
                    break;
                case 6:
                    settings.Type = VFIPSource.RTSP_UDP_FFMPEG;
                    break;
                case 7:
                    settings.Type = VFIPSource.RTSP_TCP_FFMPEG;
                    break;
                case 8:
                    settings.Type = VFIPSource.RTSP_HTTP_FFMPEG;
                    break;
            }

            settings.AudioCapture = cbIPAudioCapture.IsChecked == true;
            settings.Login = edIPLogin.Text;
            settings.Password = edIPPassword.Text;
            settings.ForcedFramerate = Convert.ToDouble(edIPForcedFramerate.Text);
            settings.ForcedFramerate_InstanceID = edIPForcedFramerateID.Text[0];
            settings.Debug_Enabled = cbDebugMode.IsChecked == true;
            settings.Debug_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\ip_cam_log.txt";
            settings.VLC_ZeroClockJitterEnabled = cbVLCZeroClockJitter.IsChecked == true;
            settings.VLC_CustomLatency = Convert.ToInt32(edVLCCacheSize.Text);

            if (cbIPCameraONVIF.IsChecked == true)
            {
                settings.ONVIF_Source = true;

                if (cbONVIFProfile.SelectedIndex != -1)
                {
                    settings.ONVIF_SourceProfile = cbONVIFProfile.Text;
                }
            }

            if (cbIPDisconnect.IsChecked == true)
            {
                settings.DisconnectEventInterval = 5000;
            }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl != null)
            {
                onvifControl.Disconnect();
                onvifControl.Dispose();
                onvifControl = null;

                btONVIFConnect.Content = "Connect";
            }

            zoom = 1.0;
            zoomShiftX = 0;
            zoomShiftY = 0;

            mmLog.Clear();

            if (cbPIPDevices.Items.Count > 0)
            {
                if (cbPIPDevices.Items.IndexOf("Main source") == -1)
                {
                    cbPIPDevices.Items.Insert(0, "Main source");
                }
            }

            VideoCapture1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            VideoCapture1.VLC_Path = Environment.GetEnvironmentVariable("VFVLCPATH");

            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Video_Effects_Clear();

            switch (cbMode.SelectedIndex)
            {
                case 0:
                    VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
                    break;
                case 1:
                    VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture;
                    break;
                case 2:
                    VideoCapture1.Mode = VFVideoCaptureMode.AudioPreview;
                    break;
                case 3:
                    VideoCapture1.Mode = VFVideoCaptureMode.AudioCapture;
                    break;
                case 4:
                    VideoCapture1.Mode = VFVideoCaptureMode.ScreenPreview;
                    break;
                case 5:
                    VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture;
                    break;
                case 6:
                    VideoCapture1.Mode = VFVideoCaptureMode.IPPreview;
                    break;
                case 7:
                    VideoCapture1.Mode = VFVideoCaptureMode.IPCapture;
                    break;
                case 8:
                    VideoCapture1.Mode = VFVideoCaptureMode.BDAPreview;
                    break;
                case 9:
                    VideoCapture1.Mode = VFVideoCaptureMode.BDACapture;
                    break;
                case 10:
                    VideoCapture1.Mode = VFVideoCaptureMode.CustomPreview;
                    break;
                case 11:
                    VideoCapture1.Mode = VFVideoCaptureMode.CustomCapture;
                    break;
                case 12:
                    VideoCapture1.Mode = VFVideoCaptureMode.DecklinkSourcePreview;
                    break;
                case 13:
                    VideoCapture1.Mode = VFVideoCaptureMode.DecklinkSourceCapture;
                    break;
            }

            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;

            VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = rbAddAudioStreamsMix.IsChecked == true;

            // Network streaming
            VideoCapture1.Network_Streaming_Enabled = cbNetworkStreaming.IsChecked == true;

            if (VideoCapture1.Network_Streaming_Enabled)
            {
                switch (cbNetworkStreamingMode.SelectedIndex)
                {
                    case 0:
                        {
                            VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.WMV;

                            if (rbNetworkStreamingUseMainWMVSettings.IsChecked == true)
                            {
                                var wmvOutput = new VFWMVOutput();
                                SetWMVSettings(ref wmvOutput);
                                VideoCapture1.Network_Streaming_Output = wmvOutput;
                            }
                            else
                            {
                                var wmvOutput = new VFWMVOutput
                                                    {
                                                        Mode = VFWMVMode.ExternalProfile,
                                                        External_Profile_FileName = this.edNetworkStreamingWMVProfile.Text
                                                    };
                                VideoCapture1.Network_Streaming_Output = wmvOutput;
                            }

                            VideoCapture1.Network_Streaming_WMV_Maximum_Clients = Convert.ToInt32(edMaximumClients.Text);
                            VideoCapture1.Network_Streaming_Network_Port = Convert.ToInt32(edWMVNetworkPort.Text);

                            break;
                        }

                    case 1:
                        {
                            VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.RTSP_H264_AAC_SW;

                            var mp4Output = new VFMP4Output();
                            SetMP4Output(ref mp4Output);
                            VideoCapture1.Network_Streaming_Output = mp4Output;

                            VideoCapture1.Network_Streaming_URL = edNetworkRTSPURL.Text;

                            break;
                        }

                    case 2:
                        {
                            VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.RTMP_FFMPEG_EXE;

                            var ffmpegOutput = new VFFFMPEGEXEOutput();
                            
                            if (rbNetworkUDPFFMPEG.IsChecked == true)
                            {
                                ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                            }
                            else
                            {
                                SetFFMPEGEXEOutput(ref ffmpegOutput);
                            }
                            
                            ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLV;

                            VideoCapture1.Network_Streaming_Output = ffmpegOutput;
                            VideoCapture1.Network_Streaming_URL = edNetworkRTMPURL.Text;

                            break;
                        }

                    case 3:
                        {
                            VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.UDP_FFMPEG_EXE;

                            var ffmpegOutput = new VFFFMPEGEXEOutput();

                            if (rbNetworkUDPFFMPEG.IsChecked == true)
                            {
                                ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                            }
                            else
                            {
                                SetFFMPEGEXEOutput(ref ffmpegOutput);
                            }

                            ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS;
                            VideoCapture1.Network_Streaming_Output = ffmpegOutput;

                            VideoCapture1.Network_Streaming_URL = edNetworkUDPURL.Text;

                            break;
                        }

                    case 4:
                        {
                            if (rbNetworkSSSoftware.IsChecked == true)
                            {
                                VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_H264_AAC_SW;

                                var mp4Output = new VFMP4Output();
                                SetMP4Output(ref mp4Output);
                                VideoCapture1.Network_Streaming_Output = mp4Output;
                            }
                            else
                            {
                                VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_FFMPEG_EXE;

                                var ffmpegOutput = new VFFFMPEGEXEOutput();

                                if (rbNetworkSSFFMPEGDefault.IsChecked == true)
                                {
                                    ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                                }
                                else
                                {
                                    SetFFMPEGEXEOutput(ref ffmpegOutput);
                                }

                                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ISMV;
                                VideoCapture1.Network_Streaming_Output = ffmpegOutput;
                            }

                            VideoCapture1.Network_Streaming_URL = edNetworkSSURL.Text;

                            break;
                        }

                    case 5:
                        {
                            VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.External;

                            break;
                        }
                }

                VideoCapture1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.IsChecked == true;
            }

            if (VideoCapture1.Mode == VFVideoCaptureMode.ScreenPreview
                || VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture)
            {
                // from screen
                ScreenCaptureSourceSettings settings;
                SelectScreenCaptureSource(out settings);
                VideoCapture1.Screen_Capture_Source = settings;
            }
            else if (VideoCapture1.Mode == VFVideoCaptureMode.IPPreview
                     || VideoCapture1.Mode == VFVideoCaptureMode.IPCapture)
            {
                IPCameraSourceSettings settings;
                SelectIPCameraSource(out settings);
                VideoCapture1.IP_Camera_Source = settings;
            }
            else if (VideoCapture1.Mode == VFVideoCaptureMode.BDAPreview
                     || VideoCapture1.Mode == VFVideoCaptureMode.BDACapture)
            {
                VideoCapture1.BDA_Source = new BDASourceSettings
                                               {
                                                   ReceiverName = this.cbBDAReceiver.Text,
                                                   SourceType = (VFBDAType)this.cbBDADeviceStandard.SelectedIndex,
                                                   SourceName = this.cbBDASourceDevice.Text
                                               };

                if (VideoCapture1.BDA_Source.SourceType == VFBDAType.DVBT)
                {
                    VFBDATuningParameters bdaTuningParameters = new VFBDATuningParameters
                    {
                        Frequency = Convert.ToInt32(edDVBTFrequency.Text),
                        ONID = Convert.ToInt32(edDVBTONID.Text),
                        SID = Convert.ToInt32(edDVBTSID.Text),
                        TSID = Convert.ToInt32(edDVBTTSID.Text)
                    };

                    VideoCapture1.BDA_SetParameters(bdaTuningParameters);
                }
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.CustomCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.CustomPreview))
            {
                VideoCapture1.Custom_Source = new CustomSourceSettings();

                if (cbCustomVideoSourceCategory.SelectedIndex == 0)
                {
                    VideoCapture1.Custom_Source.VideoFilterCategory = VFFilterCategory.VideoCaptureSource;
                }
                else
                {
                    VideoCapture1.Custom_Source.VideoFilterCategory = VFFilterCategory.DirectShowFilters;
                }

                VideoCapture1.Custom_Source.VideoFilterName = cbCustomVideoSourceFilter.Text;
                VideoCapture1.Custom_Source.VideoFilterFormat = cbCustomVideoSourceFormat.Text;

                if (string.IsNullOrEmpty(cbCustomVideoSourceFrameRate.Text))
                {
                    VideoCapture1.Custom_Source.VideoFilterFrameRate = 0f;
                }
                else
                {
                    VideoCapture1.Custom_Source.VideoFilterFrameRate = Convert.ToDouble(cbCustomVideoSourceFrameRate.Text);
                }

                if (cbCustomAudioSourceCategory.SelectedIndex == 0)
                {
                    VideoCapture1.Custom_Source.AudioFilterCategory = VFFilterCategory.AudioCaptureSource;
                }
                else
                {
                    VideoCapture1.Custom_Source.AudioFilterCategory = VFFilterCategory.DirectShowFilters;
                }

                VideoCapture1.Custom_Source.AudioFilterName = cbCustomAudioSourceFilter.Text;
                VideoCapture1.Custom_Source.AudioFilterFormat = cbCustomAudioSourceFormat.Text;
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourcePreview))
            {
                VideoCapture1.Decklink_Source = new DecklinkSourceSettings
                                                    {
                                                        Name = this.cbDecklinkCaptureDevice.Text,
                                                        VideoFormat = this.cbDecklinkCaptureVideoFormat.Text
                                                    };
            }
            else
            {
                VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text;
                VideoCapture1.Video_CaptureFormat = cbVideoInputFormat.Text;
                VideoCapture1.Video_CaptureFormat_UseBest = cbUseBestVideoInputFormat.IsChecked == true;

                try
                {
                    if (!string.IsNullOrEmpty(cbFramerate.Text))
                    {
                        VideoCapture1.Video_FrameRate = Convert.ToDouble(cbFramerate.Text);
                    }
                }
                catch
                {
                    VideoCapture1.Video_FrameRate = 25;
                }

                VideoCapture1.Video_CaptureDevice_IsAudioSource =
                    cbUseAudioInputFromVideoCaptureDevice.IsChecked == true;
                VideoCapture1.Video_CaptureDevice_UseClosedCaptions = cbUseClosedCaptions.IsChecked == true;
            }

            if ((VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture) ||
                (VideoCapture1.Mode == VFVideoCaptureMode.AudioCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.IPCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.BDACapture) || (VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture))
            {
                VideoCapture1.Output_Filename = edOutput.Text;
            }

            VideoCapture1.Audio_RecordAudio = cbRecordAudio.IsChecked == true;
            VideoCapture1.Audio_PlayAudio = cbPlayAudio.IsChecked == true;

            if (VideoCapture1.Mode == VFVideoCaptureMode.AudioCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.BDACapture
                || VideoCapture1.Mode == VFVideoCaptureMode.CustomCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.IPCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.KinectCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture
                || VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture)
            {
                VFVideoCaptureOutputFormat outputFormat = VFVideoCaptureOutputFormat.AVI;
                switch (cbOutputFormat.SelectedIndex)
                {
                    case 0:
                        outputFormat = VFVideoCaptureOutputFormat.AVI;
                        break;
                    case 1:
                        outputFormat = VFVideoCaptureOutputFormat.MKV;
                        break;
                    case 2:
                        {
                            outputFormat = VFVideoCaptureOutputFormat.WMV;
                            var wmvOutput = new VFWMVOutput();
                            SetWMVSettings(ref wmvOutput);
                            VideoCapture1.Output_Format = wmvOutput;
                            break;
                        }

                    case 3:
                        outputFormat = VFVideoCaptureOutputFormat.DV;
                        break;
                    case 4:
                        outputFormat = VFVideoCaptureOutputFormat.PCM_ACM;
                        break;
                    case 5:
                        outputFormat = VFVideoCaptureOutputFormat.MP3;
                        break;
                    case 6:
                        outputFormat = VFVideoCaptureOutputFormat.M4A;
                        break;
                    case 7:
                        {
                            outputFormat = VFVideoCaptureOutputFormat.WMA;

                            var wmaOutput = new VFWMAOutput { ProfileFilename = this.edWMVProfile.Text };
                            VideoCapture1.Output_Format = wmaOutput;

                            break;
                        }

                    case 8:
                        outputFormat = VFVideoCaptureOutputFormat.FLAC;
                        break;
                    case 9:
                        outputFormat = VFVideoCaptureOutputFormat.OggVorbis;
                        break;
                    case 10:
                        outputFormat = VFVideoCaptureOutputFormat.Speex;
                        break;
                    case 11:
                        outputFormat = VFVideoCaptureOutputFormat.Custom;
                        break;
                    case 12:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureDV;
                        break;
                    case 13:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureAVI;
                        break;
                    case 14:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMPEG;
                        break;
                    case 15:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMKV;
                        break;
                    case 16:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMP4_GDCL;
                        break;
                    case 17:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMP4_Monogram;
                        break;
                    case 18:
                        outputFormat = VFVideoCaptureOutputFormat.WebM;
                        break;
                    case 19:
                        outputFormat = VFVideoCaptureOutputFormat.FFMPEG_DLL;
                        break;
                    case 20:
                        outputFormat = VFVideoCaptureOutputFormat.FFMPEG_EXE;
                        break;
                    case 21:
                        outputFormat = VFVideoCaptureOutputFormat.MP4;
                        break;
                    case 22:
                        outputFormat = VFVideoCaptureOutputFormat.AnimatedGIF;
                        break;
                    case 23:
                        outputFormat = VFVideoCaptureOutputFormat.Encrypted;
                        break;
                }

                if (outputFormat == VFVideoCaptureOutputFormat.AVI)
                {
                    var aviOutput = new VFAVIOutput();
                    SetAVIOutput(ref aviOutput);
                    VideoCapture1.Output_Format = aviOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.MKV)
                {
                    var mkvOutput = new VFMKVOutput();
                    SetMKVOutput(ref mkvOutput);
                    VideoCapture1.Output_Format = mkvOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.WMV)
                {
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.DV)
                {
                    var dvOutput = new VFDVOutput();
                    SetDVOutput(ref dvOutput);
                    VideoCapture1.Output_Format = dvOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.Custom)
                {
                    var customOutput = new VFCustomOutput();
                    SetCustomOutput(ref customOutput);
                    VideoCapture1.Output_Format = customOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.DirectCaptureMPEG)
                {
                    if (cbMPEGEncoder.SelectedIndex != -1)
                    {
                        VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = cbMPEGEncoder.Text;
                    }
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.PCM_ACM)
                {
                    var acmOutput = new VFACMOutput();
                    SetACMOutput(ref acmOutput);
                    VideoCapture1.Output_Format = acmOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.FLAC)
                {
                    var flacOutput = new VFFLACOutput();
                    SetFLACOutput(ref flacOutput);
                    VideoCapture1.Output_Format = flacOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.Speex)
                {
                    var speexOutput = new VFSpeexOutput();
                    SetSpeexOutput(ref speexOutput);
                    VideoCapture1.Output_Format = speexOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.M4A)
                {
                    var m4aOutput = new VFM4AOutput();
                    SetM4AOutput(ref m4aOutput);
                    VideoCapture1.Output_Format = m4aOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.MP3)
                {
                    var mp3Output = new VFMP3Output();
                    FillMP3Settings(ref mp3Output);
                    VideoCapture1.Output_Format = mp3Output;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.WebM)
                {
                    var webmOutput = new VFWebMOutput();
                    SetWebMOutput(ref webmOutput);
                    VideoCapture1.Output_Format = webmOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.OggVorbis)
                {
                    var oggVorbisOutput = new VFOGGVorbisOutput();
                    SetOGGVorbisOutput(ref oggVorbisOutput);
                    VideoCapture1.Output_Format = oggVorbisOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.FFMPEG_DLL)
                {
                    var ffmpegDLLOutput = new VFFFMPEGDLLOutput();
                    SetFFMPEGDLLOutput(ref ffmpegDLLOutput);
                    VideoCapture1.Output_Format = ffmpegDLLOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.FFMPEG_EXE)
                {
                    var ffmpegOutput = new VFFFMPEGEXEOutput();
                    SetFFMPEGEXEOutput(ref ffmpegOutput);
                    VideoCapture1.Output_Format = ffmpegOutput;
                }
                else if ((outputFormat == VFVideoCaptureOutputFormat.MP4)
                         || ((outputFormat == VFVideoCaptureOutputFormat.Encrypted)
                             && (rbEncryptedH264SW.IsChecked == true))
                         || (VideoCapture1.Network_Streaming_Enabled
                             && (VideoCapture1.Network_Streaming_Format == VFNetworkStreamingFormat.RTSP_H264_AAC_SW)))
                {
                    var mp4Output = new VFMP4Output();
                    SetMP4Output(ref mp4Output);

                    if (outputFormat == VFVideoCaptureOutputFormat.Encrypted)
                    {
                        mp4Output.Encryption = true;
                        mp4Output.Encryption_Format = VFEncryptionFormat.MP4_H264_SW_AAC;

                        if (rbEncryptionKeyString.IsChecked == true)
                        {
                            mp4Output.Encryption_KeyType = VFEncryptionKeyType.String;
                            mp4Output.Encryption_Key = edEncryptionKeyString.Text;
                        }
                        else if (rbEncryptionKeyFile.IsChecked == true)
                        {
                            mp4Output.Encryption_KeyType = VFEncryptionKeyType.File;
                            mp4Output.Encryption_Key = edEncryptionKeyFile.Text;
                        }
                        else
                        {
                            mp4Output.Encryption_KeyType = VFEncryptionKeyType.Binary;
                            mp4Output.Encryption_Key =
                                VideoCapture.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text);
                        }

                        if (rbEncryptionModeAES128.IsChecked == true)
                        {
                            mp4Output.Encryption_Mode = VFEncryptionMode.v8_AES128;
                        }
                        else
                        {
                            mp4Output.Encryption_Mode = VFEncryptionMode.v9_AES256;
                        }
                    }

                    VideoCapture1.Output_Format = mp4Output;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.AnimatedGIF)
                {
                    var gifOutput = new VFAnimatedGIFOutput();
                    SetGIFOutput(ref gifOutput);
                    VideoCapture1.Output_Format = gifOutput;
                }
            }

            // VU meter Pro
            if (cbVUMeterProEnabled.IsChecked == true)
            {
                VideoCapture1.Audio_VUMeter_Pro_Enabled = true;

                VideoCapture1.Audio_VUMeter_Pro_Volume = (int)tbVUMeterAmplification.Value;

                volumeMeter1.Boost = (float)tbVUMeterBoost.Value / 10.0F;
                volumeMeter2.Boost = (float)tbVUMeterBoost.Value / 10.0F;

                waveformPainter.Start();
                spectrumAnalyzer.Start();
                volumeMeter1.Start();
                volumeMeter2.Start();
            }
            else
            {
                VideoCapture1.Audio_VUMeter_Pro_Enabled = false;
            }

            // crossbar
            if (cbCrossBarAvailable.IsChecked == true)
            {
                // ReSharper disable RedundantIfElseBlock
                if (rbCrossbarSimple.IsChecked == true)
                {
                    if (cbCrossbarVideoInput.SelectedIndex != -1)
                    {
                        VideoCapture1.Video_CaptureDevice_CrossBar_ClearConnections();
                        VideoCapture1.Video_CaptureDevice_CrossBar_Connect(cbCrossbarVideoInput.Text, "Video Decoder", true);
                    }
                }
                else
                {
                    // all routes must be already applied
                    // you don't need to do anything
                }
                // ReSharper restore RedundantIfElseBlock
            }

            // Virtual camera output
            VideoCapture1.Virtual_Camera_Output_Enabled = cbVirtualCamera.IsChecked == true;

            // Decklink output
            if (cbDecklinkOutput.IsChecked == true)
            {
                VideoCapture1.Decklink_Output = new DecklinkOutputSettings
                                                    {
                                                        DVEncoding = this.cbDecklinkDV.IsChecked == true,
                                                        AnalogOutputIREUSA = this.cbDecklinkOutputNTSC.SelectedIndex == 0,
                                                        AnalogOutputSMPTE =
                                                            this.cbDecklinkOutputComponentLevels.SelectedIndex == 0,
                                                        BlackToDeckInCapture =
                                                            (DecklinkBlackToDeckInCapture)
                                                            this.cbDecklinkOutputBlackToDeck.SelectedIndex,
                                                        DualLinkOutputMode =
                                                            (DecklinkDualLinkMode)
                                                            this.cbDecklinkOutputDualLink.SelectedIndex,
                                                        HDTVPulldownOnOutput =
                                                            (DecklinkHDTVPulldownOnOutput)
                                                            this.cbDecklinkOutputHDTVPulldown.SelectedIndex,
                                                        SingleFieldOutputForSynchronousFrames =
                                                            (DecklinkSingleFieldOutputForSynchronousFrames)
                                                            this.cbDecklinkOutputSingleField.SelectedIndex,
                                                        VideoOutputDownConversionMode =
                                                            (DecklinkVideoOutputDownConversionMode)
                                                            this.cbDecklinkOutputDownConversion.SelectedIndex,
                                                        VideoOutputDownConversionModeAnalogUsed =
                                                            this.cbDecklinkOutputDownConversionAnalogOutput.IsChecked
                                                            == true,
                                                        AnalogOutput =
                                                            (DecklinkAnalogOutput)this.cbDecklinkOutputAnalog.SelectedIndex
                                                    };
            }
            else
            {
                VideoCapture1.Decklink_Output = null;
            }

            VideoCapture1.Decklink_Input = (DecklinkInput)cbDecklinkSourceInput.SelectedIndex;
            VideoCapture1.Decklink_Input_SMPTE = cbDecklinkSourceComponentLevels.SelectedIndex == 0;
            VideoCapture1.Decklink_Input_IREUSA = cbDecklinkSourceNTSC.SelectedIndex == 0;
            VideoCapture1.Decklink_Input_Capture_Timecode_Source = (DecklinkCaptureTimecodeSource)cbDecklinkSourceTimecode.SelectedIndex;

            // Barcode detection
            VideoCapture1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.IsChecked == true;
            VideoCapture1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;

            // Video effects
            ConfigureVideoEffects();

            // Chromakey
            if (cbChromaKeyEnabled.IsChecked == true)
            {
                VideoCapture1.ChromaKey = new ChromaKeySettings
                                              {
                                                  ContrastHigh = (int)this.tbChromaKeyContrastHigh.Value,
                                                  ContrastLow = (int)this.tbChromaKeyContrastLow.Value,
                                                  ImageFilename = this.edChromaKeyImage.Text
                                              };

                if (rbChromaKeyGreen.IsChecked == true)
                {
                    VideoCapture1.ChromaKey.Color = VFChromaColor.Green;
                }
                else if (rbChromaKeyBlue.IsChecked == true)
                {
                    VideoCapture1.ChromaKey.Color = VFChromaColor.Blue;
                }
                else
                {
                    VideoCapture1.ChromaKey.Color = VFChromaColor.Red;
                }
            }
            else
            {
                VideoCapture1.ChromaKey = null;
            }

            // Object detection 
            ConfigureMotionDetectionEx();

            // Face tracking
            if (cbFaceTrackingEnabled.IsChecked == true)
            {
                VideoCapture1.Face_Tracking = new FaceTrackingSettings
                                                  {
                                                      ColorMode = (CamshiftMode)this.cbFaceTrackingColorMode.SelectedIndex,
                                                      Highlight = this.cbFaceTrackingCHL.IsChecked == true,
                                                      MinimumWindowSize =
                                                          int.Parse(this.edFaceTrackingMinimumWindowSize.Text),
                                                      ScalingMode =
                                                          (ObjectDetectorScalingMode)
                                                          this.cbFaceTrackingScalingMode.SelectedIndex,
                                                      SearchMode =
                                                          (ObjectDetectorSearchMode)
                                                          this.cbFaceTrackingSearchMode.SelectedIndex
                                                  };

                // VideoCapture1.FaceTracking_ScaleFactor = int.Parse(edFaceTrackingScaleFactor.Text);
            }
            else
            {
                VideoCapture1.Face_Tracking = null;
            }
            
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = cbUseBestAudioInputFormat.IsChecked == true;
            VideoCapture1.Video_CaptureFormat_UseBest = cbUseBestVideoInputFormat.IsChecked == true;

            VideoCapture1.Video_CaptureFormat = cbVideoInputFormat.Text;

            if (rbWPF.IsChecked == true)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;
            }
            else if (rbDirect2D.IsChecked == true)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.Direct2D;
            }
            else
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.None;
            }

            if (cbStretch.IsChecked == true)
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }
            
            VideoCapture1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);

            VideoCapture1.Video_Renderer.BackgroundColor = VideoCapture.ColorConv(((SolidColorBrush)pnVideoRendererBGColor.Fill).Color);
            VideoCapture1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            VideoCapture1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;

            VideoCapture1.Video_ResizeOrCrop_Enabled = false;

            if (cbResize.IsChecked == true)
            {
                VideoCapture1.Video_ResizeOrCrop_Enabled = true;

                VideoCapture1.Video_Resize = new VideoResizeSettings
                                                 {
                                                     Width = Convert.ToInt32(this.edResizeWidth.Text),
                                                     Height = Convert.ToInt32(this.edResizeHeight.Text),
                                                     LetterBox = this.cbResizeLetterbox.IsChecked == true
                                                 };

                switch (cbResizeMode.SelectedIndex)
                {
                    case 0: VideoCapture1.Video_Resize.Mode = VFResizeMode.NearestNeighbor;
                        break;
                    case 1: VideoCapture1.Video_Resize.Mode = VFResizeMode.Bilinear;
                        break;
                    case 2: VideoCapture1.Video_Resize.Mode = VFResizeMode.Bicubic;
                        break;
                    case 3: VideoCapture1.Video_Resize.Mode = VFResizeMode.Lancroz;
                        break;
                }
            }
            else
            {
                VideoCapture1.Video_Resize = null;
            }

            if (cbCrop.IsChecked == true)
            {
                VideoCapture1.Video_ResizeOrCrop_Enabled = true;

                VideoCapture1.Video_Crop = new VideoCropSettings(
                    Convert.ToInt32(edCropLeft.Text),
                    Convert.ToInt32(edCropTop.Text),
                    Convert.ToInt32(edCropRight.Text),
                    Convert.ToInt32(edCropBottom.Text));
            }
            else
            {
                VideoCapture1.Video_Crop = null;
            }

            switch (cbRotate.SelectedIndex)
            {
                case 0:
                    VideoCapture1.Video_Rotation = VFRotateMode.RotateNone;
                    break;
                case 1:
                    VideoCapture1.Video_Rotation = VFRotateMode.Rotate90;
                    break;
                case 2:
                    VideoCapture1.Video_Rotation = VFRotateMode.Rotate180;
                    break;
                case 3:
                    VideoCapture1.Video_Rotation = VFRotateMode.Rotate270;
                    break;
            }

            // MPEG decoding (only for tuners with internal HW encoder)
            if (cbMPEGVideoDecoder.SelectedIndex < 1)
            {
                // default
                VideoCapture1.MPEG_Video_Decoder = string.Empty;
            }
            else
            {
                VideoCapture1.MPEG_Video_Decoder = cbMPEGVideoDecoder.Text;
            }

            if (cbMPEGAudioDecoder.SelectedIndex < 1)
            {
                // default
                VideoCapture1.MPEG_Audio_Decoder = string.Empty;
            }
            else
            {
                VideoCapture1.MPEG_Audio_Decoder = cbMPEGAudioDecoder.Text;
            }

            // DV resolution
            if (rbDVResFull.IsChecked == true)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Full;
            }
            else if (rbDVResHalf.IsChecked == true)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Half;
            }
            else if (rbDVResQuarter.IsChecked == true)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Quarter;
            }
            else
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.DC;
            }

            // motion detection
            if (cbMotDetEnabled.IsChecked == true)
            {
                btMotDetUpdateSettings_Click(null, null); // apply settings
            }

            // Audio enhancement
            VideoCapture1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.IsChecked == true;
            if (VideoCapture1.Audio_Enhancer_Enabled)
            {
                VideoCapture1.Audio_Enhancer_Normalize(cbAudioNormalize.IsChecked == true);
                VideoCapture1.Audio_Enhancer_AutoGain(cbAudioAutoGain.IsChecked == true);

                ApplyAudioInputGains();
                ApplyAudioOutputGains();

                VideoCapture1.Audio_Enhancer_Timeshift((int)tbAudioTimeshift.Value);
            }

            // Audio channels mapping
            if (cbAudioChannelMapperEnabled.IsChecked == true)
            {
                VideoCapture1.Audio_Channel_Mapper = new AudioChannelMapperSettings
                                                         {
                                                             Routes = this.audioChannelMapperItems.ToArray(),
                                                             OutputChannelsCount =
                                                                 Convert.ToInt32(
                                                                     this.edAudioChannelMapperOutputChannels.Text)
                                                         };
            }
            else
            {
                VideoCapture1.Audio_Channel_Mapper = null;
            }

            // Audio processing
            VideoCapture1.Audio_Effects_Enabled = cbAudioEffectsEnabled.IsChecked == true;
            if (VideoCapture1.Audio_Effects_Enabled)
            {
                AddAudioEffects();
            }

            // PIP
            VideoCapture1.PIP_Mode = (VFPIPMode)cbPIPMode.SelectedIndex;
            VideoCapture1.PIP_ResizeQuality = (VFPIPResizeQuality)cbPIPResizeMode.SelectedIndex;

            if (VideoCapture1.PIP_Mode == VFPIPMode.ChromaKey)
            {
                var chromaKey = new VFPIPChromaKeySettings();
                chromaKey.Color = VideoCapture.ColorConv(((SolidColorBrush)pnPIPChromaKeyColor.Fill).Color);  
                chromaKey.Tolerance1 = (int)tbPIPChromaKeyTolerance1.Value;
                chromaKey.Tolerance2 = (int)tbPIPChromaKeyTolerance2.Value;

                VideoCapture1.PIP_ChromaKeySettings = chromaKey;
            }

            // separate capture
            VideoCapture1.SeparateCapture_Enabled = cbSeparateCaptureEnabled.IsChecked == true;
            if (VideoCapture1.SeparateCapture_Enabled)
            {
                if (rbSeparateCaptureStartManually.IsChecked == true)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.Normal;
                    VideoCapture1.SeparateCapture_AutostartCapture = false;
                }
                else if (rbSeparateCaptureSplitByDuration.IsChecked == true)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.SplitByDuration;
                    VideoCapture1.SeparateCapture_AutostartCapture = true;
                    VideoCapture1.SeparateCapture_TimeThreshold = Convert.ToInt32(edSeparateCaptureDuration.Text);
                }
                else if (rbSeparateCaptureSplitBySize.IsChecked == true)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.SplitByFileSize;
                    VideoCapture1.SeparateCapture_AutostartCapture = true;
                    VideoCapture1.SeparateCapture_FileSizeThreshold = Convert.ToInt32(edSeparateCaptureFileSize.Text) * 1024 * 1024;
                }
            }

            // Output tags
            if (cbTagEnabled.IsChecked == true)
            {
                var tags = new VFFileTags
                               {
                                   Title = this.edTagTitle.Text,
                                   Performers = new[] { this.edTagArtists.Text },
                                   Album = this.edTagAlbum.Text,
                                   Comment = this.edTagComment.Text,
                                   Track = Convert.ToUInt32(this.edTagTrackID.Text),
                                   Copyright = this.edTagCopyright.Text,
                                   Year = Convert.ToUInt32(this.edTagYear.Text),
                                   Composers = new[] { this.edTagComposers.Text },
                                   Genres = new[] { this.cbTagGenre.Text },
                                   Lyrics = this.edTagLyrics.Text
                               };

                if (imgTagCover.Tag != null)
                {
                    tags.Pictures = new[] { new Bitmap(imgTagCover.Tag.ToString()) };
                }

                VideoCapture1.Tags = tags;
            }

            // Start
            VideoCapture1.Start();

            edNetworkURL.Text = VideoCapture1.Network_Streaming_URL;
        }

        private void ConfigureMotionDetectionEx()
        {
            if (cbMotionDetectionEx.IsChecked == true)
            {
                VideoCapture1.Motion_DetectionEx = new MotionDetectionExSettings();
                VideoCapture1.Motion_DetectionEx.ProcessorType = (MotionProcessorType)rbMotionDetectionExProcessor.SelectedIndex;
                VideoCapture1.Motion_DetectionEx.DetectorType = (MotionDetectorType)rbMotionDetectionExDetector.SelectedIndex;
            }
            else
            {
                VideoCapture1.Motion_DetectionEx = null;
            }
        }

        private void ConfigureVideoEffects()
        {
            VideoCapture1.Video_Effects_Enabled = cbEffects.IsChecked == true;
            VideoCapture1.Video_Effects_Clear();

            // Deinterlace
            if (cbDeinterlace.IsChecked == true && VideoCapture1.Mode != VFVideoCaptureMode.ScreenCapture
                && VideoCapture1.Mode != VFVideoCaptureMode.ScreenPreview)
            {
                if (rbDeintBlendEnabled.IsChecked == true)
                {
                    IVFVideoEffectDeinterlaceBlend blend;
                    var effect = VideoCapture1.Video_Effects_Get("DeinterlaceBlend");
                    if (effect == null)
                    {
                        blend = new VFVideoEffectDeinterlaceBlend(true);
                        VideoCapture1.Video_Effects_Add(blend);
                    }
                    else
                    {
                        blend = effect as IVFVideoEffectDeinterlaceBlend;
                    }

                    if (blend == null)
                    {
                        MessageBox.Show("Unable to configure deinterlace blend effect.");
                        return;
                    }

                    blend.Threshold1 = Convert.ToInt32(edDeintBlendThreshold1.Text);
                    blend.Threshold2 = Convert.ToInt32(edDeintBlendThreshold2.Text);
                    blend.Constants1 = Convert.ToInt32(edDeintBlendConstants1.Text) / 10.0;
                    blend.Constants2 = Convert.ToInt32(edDeintBlendConstants2.Text) / 10.0;
                }
                else if (rbDeintCAVTEnabled.IsChecked == true)
                {
                    IVFVideoEffectDeinterlaceCAVT cavt;
                    var effect = VideoCapture1.Video_Effects_Get("DeinterlaceCAVT");
                    if (effect == null)
                    {
                        cavt = new VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.IsChecked == true, Convert.ToInt32(edDeintCAVTThreshold.Text));
                        VideoCapture1.Video_Effects_Add(cavt);
                    }
                    else
                    {
                        cavt = effect as IVFVideoEffectDeinterlaceCAVT;
                    }

                    if (cavt == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Unable to configure deinterlace CAVT effect.");
                        return;
                    }

                    cavt.Threshold = Convert.ToInt32(edDeintCAVTThreshold.Text);
                }
                else
                {
                    IVFVideoEffectDeinterlaceTriangle triangle;
                    var effect = VideoCapture1.Video_Effects_Get("DeinterlaceTriangle");
                    if (effect == null)
                    {
                        triangle = new VFVideoEffectDeinterlaceTriangle(true, Convert.ToByte(edDeintTriangleWeight.Text));
                        VideoCapture1.Video_Effects_Add(triangle);
                    }
                    else
                    {
                        triangle = effect as IVFVideoEffectDeinterlaceTriangle;
                    }

                    if (triangle == null)
                    {
                        MessageBox.Show("Unable to configure deinterlace triangle effect.");
                        return;
                    }

                    triangle.Weight = Convert.ToByte(edDeintTriangleWeight.Text);
                }
            }

            // Denoise
            if (cbDenoise.IsChecked == true && VideoCapture1.Mode != VFVideoCaptureMode.ScreenCapture
                && VideoCapture1.Mode != VFVideoCaptureMode.ScreenPreview)
            {
                if (rbDenoiseCAST.IsChecked == true)
                {
                    IVFVideoEffectDenoiseCAST cast;
                    var effect = VideoCapture1.Video_Effects_Get("DenoiseCAST");
                    if (effect == null)
                    {
                        cast = new VFVideoEffectDenoiseCAST(true);
                        VideoCapture1.Video_Effects_Add(cast);
                    }
                    else
                    {
                        cast = effect as IVFVideoEffectDenoiseCAST;
                    }

                    if (cast == null)
                    {
                        MessageBox.Show("Unable to configure denoise CAST effect.");
                        return;
                    }
                }
                else
                {
                    IVFVideoEffectDenoiseMosquito mosquito;
                    var effect = VideoCapture1.Video_Effects_Get("DenoiseMosquito");
                    if (effect == null)
                    {
                        mosquito = new VFVideoEffectDenoiseMosquito(true);
                        VideoCapture1.Video_Effects_Add(mosquito);
                    }
                    else
                    {
                        mosquito = effect as IVFVideoEffectDenoiseMosquito;
                    }

                    if (mosquito == null)
                    {
                        MessageBox.Show("Unable to configure denoise mosquito effect.");
                        return;
                    }
                }
            }

            // Other effects
            if (tbLightness.Value > 0)
            {
                tbLightness_Scroll(null, null);
            }

            if (tbSaturation.Value < 255)
            {
                tbSaturation_Scroll(null, null);
            }

            if (tbContrast.Value > 0)
            {
                tbContrast_Scroll(null, null);
            }

            if (tbDarkness.Value > 0)
            {
                tbDarkness_Scroll(null, null);
            }

            if (cbGreyscale.IsChecked == true)
            {
                cbGreyscale_CheckedChanged(null, null);
            }

            if (cbInvert.IsChecked == true)
            {
                cbInvert_CheckedChanged(null, null);
            }

            if (cbZoomEnabled.IsChecked == true)
            {
                cbZoomEnabled_Checked(null, null);
            }

            if (cbPan.IsChecked == true)
            {
                cbPan_Checked(null, null);
            }

            if (cbFadeInOut.IsChecked == true)
            {
                cbFadeInOut_Checked(null, null);
            }

            if (cbImageLogo.IsChecked == true)
            {
                cbImageLogo_CheckedChanged(null, null);
            }

            if (cbTextLogo.IsChecked == true)
            {
                btTextLogoUpdateParams_Click(null, null);
            }

            if (cbLiveRotation.IsChecked == true)
            {
                cbLiveRotation_Checked(null, null);
            }
        }

        private void SetMP4Output(ref VFMP4Output mp4Output)
        {
            int tmp;

            // Main settings
            if (rbMP4Legacy.IsChecked == true)
            {
                mp4Output.MP4Mode = VFMP4Mode.v8;
            }
            else if (rbMP4Modern.IsChecked == true)
            {
                mp4Output.MP4Mode = VFMP4Mode.v10;
            }
            else
            {
                mp4Output.MP4Mode = VFMP4Mode.NVENC;
            }

            if (mp4Output.MP4Mode != VFMP4Mode.NVENC)
            {
                // Legacy / Modern settings
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

                switch (cbH264PictureType.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_H264.PictureType = VFH264PictureType.Auto;
                        break;
                    case 1:
                        mp4Output.Video_H264.PictureType = VFH264PictureType.Frame;
                        break;
                    case 2:
                        mp4Output.Video_H264.PictureType = VFH264PictureType.TFF;
                        break;
                    case 3:
                        mp4Output.Video_H264.PictureType = VFH264PictureType.BFF;
                        break;
                }

                mp4Output.Video_H264.RateControl = (VFH264RateControl)cbH264RateControl.SelectedIndex;
                mp4Output.Video_H264.MBEncoding = (VFH264MBEncoding)cbH264MBEncoding.SelectedIndex;
                mp4Output.Video_H264.GOP = cbH264GOP.IsChecked == true;
                mp4Output.Video_H264.BitrateAuto = cbH264AutoBitrate.IsChecked == true;

                int.TryParse(edH264IDR.Text, out tmp);
                mp4Output.Video_H264.IDR_Period = tmp;

                int.TryParse(edH264P.Text, out tmp);
                mp4Output.Video_H264.P_Period = tmp;

                int.TryParse(edH264Bitrate.Text, out tmp);
                mp4Output.Video_H264.Bitrate = tmp;
            }
            else
            {
                // NVENC settings
                switch (cbNVENCProfile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.Auto;
                        break;
                    case 1:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_Baseline;
                        break;
                    case 2:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_Main;
                        break;
                    case 3:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_High;
                        break;
                    case 4:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_High444;
                        break;
                    case 5:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_ProgressiveHigh;
                        break;
                    case 6:
                        mp4Output.Video_NVENC.Profile = NVENCProfile.H264_ConstrainedHigh;
                        break;
                }

                switch (cbNVENCLevel.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.Auto;
                        break;
                    case 1:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_1;
                        break;
                    case 2:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_11;
                        break;
                    case 3:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_12;
                        break;
                    case 4:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_13;
                        break;
                    case 5:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_2;
                        break;
                    case 6:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_21;
                        break;
                    case 7:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_22;
                        break;
                    case 8:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_3;
                        break;
                    case 9:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_31;
                        break;
                    case 10:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_32;
                        break;
                    case 11:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_4;
                        break;
                    case 12:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_41;
                        break;
                    case 13:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_42;
                        break;
                    case 14:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_5;
                        break;
                    case 15:
                        mp4Output.Video_NVENC.Level = VFNVENCLevel.H264_51;
                        break;
                }

                mp4Output.Video_NVENC.Bitrate = Convert.ToInt32(edNVENCBitrate.Text);
                mp4Output.Video_NVENC.QP = Convert.ToInt32(edNVENCQP.Text);
                mp4Output.Video_NVENC.RateControl = (VFNVENCRateControlMode)cbNVENCRateControl.SelectedIndex;
                mp4Output.Video_NVENC.GOP = Convert.ToInt32(edNVENCGOP.Text);
                mp4Output.Video_NVENC.BFrames = Convert.ToInt32(edNVENCBFrames.Text);
            }

            // Audio AAC settings
            int.TryParse(cbAACBitrate.Text, out tmp);
            mp4Output.Audio_AAC.Bitrate = tmp;

            mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACMPEGVersion.SelectedIndex;
            mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
            mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObject.SelectedIndex + 1);
        }

        private void SetFFMPEGDLLOutput(ref VFFFMPEGDLLOutput ffmpegDLLOutput)
        {
            switch (cbFFOutputFormat.SelectedIndex)
            {
                case 0:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG1;
                    break;
                case 1:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG1VCD;
                    break;
                case 2:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2;
                    break;
                case 3:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2SVCD;
                    break;
                case 4:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2DVD;
                    break;
                case 5:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2TS;
                    break;
                case 6:
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.FLV;
                    break;
            }

            switch (cbFFAspectRatio.SelectedIndex)
            {
                case 0:
                    ffmpegDLLOutput.Video_AspectRatio_W = 0;
                    ffmpegDLLOutput.Video_AspectRatio_H = 1;
                    break;
                case 1:
                    ffmpegDLLOutput.Video_AspectRatio_W = 1;
                    ffmpegDLLOutput.Video_AspectRatio_H = 1;
                    break;
                case 2:
                    ffmpegDLLOutput.Video_AspectRatio_W = 4;
                    ffmpegDLLOutput.Video_AspectRatio_H = 3;
                    break;
                case 3:
                    ffmpegDLLOutput.Video_AspectRatio_W = 16;
                    ffmpegDLLOutput.Video_AspectRatio_H = 9;
                    break;
            }

            switch (cbFFConstaint.SelectedIndex)
            {
                case 0:
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.None;
                    break;
                case 1:
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.PAL;
                    break;
                case 2:
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.NTSC;
                    break;
                case 3:
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.Film;
                    break;
            }

            ffmpegDLLOutput.Video_Width = Convert.ToInt32(edFFVideoWidth.Text);
            ffmpegDLLOutput.Video_Height = Convert.ToInt32(edFFVideoHeight.Text);
            ffmpegDLLOutput.Video_Bitrate = Convert.ToInt32(edFFTargetBitrate.Text) * 1000;
            ffmpegDLLOutput.Video_MaxBitrate = Convert.ToInt32(edFFVideoBitrateMax.Text) * 1000;
            ffmpegDLLOutput.Video_MinBitrate = Convert.ToInt32(edFFVideoBitrateMin.Text) * 1000;
            ffmpegDLLOutput.Video_BufferSize = Convert.ToInt32(edFFVBVBufferSize.Text);
            ffmpegDLLOutput.Audio_Channels = Convert.ToInt32(cbFFAudioChannels.Text);
            ffmpegDLLOutput.Audio_SampleRate = Convert.ToInt32(cbFFAudioSampleRate.Text);
            ffmpegDLLOutput.Audio_Bitrate = Convert.ToInt32(cbFFAudioBitrate.Text) * 1000;
            ffmpegDLLOutput.Video_Interlace = cbFFVideoInterlace.IsChecked == true;
        }

        private void SetOGGVorbisOutput(ref VFOGGVorbisOutput oggVorbisOutput)
        {
            oggVorbisOutput.Quality = Convert.ToInt32(edOGGQuality.Text);
            oggVorbisOutput.MinBitRate = Convert.ToInt32(cbOGGMinimum.Text);
            oggVorbisOutput.MaxBitRate = Convert.ToInt32(cbOGGMaximum.Text);
            oggVorbisOutput.AvgBitRate = Convert.ToInt32(cbOGGAverage.Text);

            if (rbOGGQuality.IsChecked == true)
            {
                oggVorbisOutput.Mode = VFVorbisMode.Quality;
            }
            else
            {
                oggVorbisOutput.Mode = VFVorbisMode.Bitrate;
            }
        }

        private void SetWebMOutput(ref VFWebMOutput webmOutput)
        {
            webmOutput.Audio_Quality = (int)tbWebMAudioQuality.Value;

            webmOutput.Video_Bitrate = Convert.ToInt32(edWebMVideoBitrate.Text);
            webmOutput.Video_ARNR_MaxFrames = Convert.ToInt32(edWebMVideoARNRMaxFrames.Text);
            webmOutput.Video_ARNR_Strength = Convert.ToInt32(edWebMVideoARNRStrenght.Text);
            webmOutput.Video_ARNR_Type = Convert.ToInt32(edWebMVideoARNRType.Text);
            webmOutput.Video_CPUUsed = Convert.ToInt32(edWebMVideoCPUUsed.Text);
            webmOutput.Video_Decimate = Convert.ToInt32(edWebMVideoDecimate.Text);
            webmOutput.Video_Decoder_Buffer_Size = Convert.ToInt32(edWebMVideoDecoderBufferSize.Text);
            webmOutput.Video_Decoder_Buffer_InitialSize = Convert.ToInt32(edWebMVideoDecoderInitialBuffer.Text);
            webmOutput.Video_Decoder_Buffer_OptimalSize = Convert.ToInt32(edWebMVideoDecoderOptimalBuffer.Text);
            webmOutput.Video_FixedKeyframeInterval = Convert.ToInt32(edWebMVideoFixedKeyframeInterval.Text);
            webmOutput.Video_Keyframe_MaxInterval = Convert.ToInt32(edWebMVideoKeyframeMaxInterval.Text);
            webmOutput.Video_Keyframe_MinInterval = Convert.ToInt32(edWebMVideoKeyframeMinInterval.Text);
            webmOutput.Video_LagInFrames = Convert.ToInt32(edWebMVideoLagInFrames.Text);
            webmOutput.Video_MaxQuantizer = Convert.ToInt32(edWebMVideoMaxQuantizer.Text);
            webmOutput.Video_MinQuantizer = Convert.ToInt32(edWebMVideoMinQuantizer.Text);
            webmOutput.Video_OvershootPct = Convert.ToInt32(edWebMVideoOvershootPct.Text);
            webmOutput.Video_SpatialResampling_DownThreshold = Convert.ToInt32(edWebMVideoSpatialDownThreshold.Text);
            webmOutput.Video_SpatialResampling_UpThreshold = Convert.ToInt32(edWebMVideoSpatialUpThreshold.Text);
            webmOutput.Video_StaticThreshold = Convert.ToInt32(edWebMVideoStaticThreshold.Text);
            webmOutput.Video_ThreadCount = Convert.ToInt32(edWebMVideoThreadCount.Text);
            webmOutput.Video_TokenPartition = Convert.ToInt32(edWebMVideoTokenPartition.Text);
            webmOutput.Video_UndershootPct = Convert.ToInt32(edWebMVideoUndershootPct.Text);
            webmOutput.Video_AutoAltRef = cbWebMVideoAutoAltRef.IsChecked == true;
            webmOutput.Video_ErrorResilient = cbWebMVideoErrorResilent.IsChecked == true;
            webmOutput.Video_SpatialResampling_Allowed = cbWebMVideoSpatialResamplingAllowed.IsChecked == true;
            webmOutput.Video_Encoder = (WebMVideoEncoder)cbWebMVideoEncoder.SelectedIndex;

            switch (cbWebMVideoEndUsageMode.SelectedIndex)
            {
                case 0:
                    webmOutput.Video_EndUsage = VP8EndUsageMode.Default;
                    break;
                case 1:
                    webmOutput.Video_EndUsage = VP8EndUsageMode.CBR;
                    break;
                case 2:
                    webmOutput.Video_EndUsage = VP8EndUsageMode.VBR;
                    break;
            }

            switch (cbWebMVideoQualityMode.SelectedIndex)
            {
                case 0:
                    webmOutput.Video_Mode = VP8QualityMode.Realtime;
                    break;
                case 1:
                    webmOutput.Video_Mode = VP8QualityMode.GoodQuality;
                    break;
                case 2:
                    webmOutput.Video_Mode = VP8QualityMode.BestQualityBetaDoNotUse;
                    break;
            }

            switch (cbWebMVideoKeyframeMode.SelectedIndex)
            {
                case 0:
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Auto;
                    break;
                case 1:
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Default;
                    break;
                case 2:
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Disabled;
                    break;
            }
        }

        private void SetM4AOutput(ref VFM4AOutput m4aOutput)
        {
            int tmp;
            int.TryParse(cbM4ABitrate.Text, out tmp);
            m4aOutput.Bitrate = tmp;
            m4aOutput.Version = (VFAACVersion)cbM4AVersion.SelectedIndex;
            m4aOutput.Output = (VFAACOutput)cbM4AOutput.SelectedIndex;
            m4aOutput.Object = (VFAACObject)(cbM4AObjectType.SelectedIndex + 1);
        }

        private void SetSpeexOutput(ref VFSpeexOutput speexOutput)
        {
            speexOutput.BitRate = (int)tbSpeexBitrate.Value;
            speexOutput.BitrateControl = (SpeexBitrateControl)cbSpeexBitrateControl.SelectedIndex;
            speexOutput.Mode = (SpeexEncodeMode)cbSpeexMode.SelectedIndex;
            speexOutput.MaxBitRate = (int)tbSpeexMaxBitrate.Value;
            speexOutput.Complexity = (int)tbSpeexComplexity.Value;
            speexOutput.Quality = (int)tbSpeexQuality.Value;
            speexOutput.UseAGC = cbSpeexAGC.IsChecked == true;
            speexOutput.UseDTX = cbSpeexDTX.IsChecked == true;
            speexOutput.UseDenoise = cbSpeexDenoise.IsChecked == true;
            speexOutput.UseVAD = cbSpeexVAD.IsChecked == true;
        }

        private void SetFLACOutput(ref VFFLACOutput flacOutput)
        {
            flacOutput.Level = (int)tbFLACLevel.Value;
            flacOutput.BlockSize = Convert.ToInt32(cbFLACBlockSize.Text);
            flacOutput.AdaptiveMidSideCoding = cbFLACAdaptiveMidSideCoding.IsChecked == true;
            flacOutput.ExhaustiveModelSearch = cbFLACExhaustiveModelSearch.IsChecked == true;
            flacOutput.LPCOrder = (int)tbFLACLPCOrder.Value;
            flacOutput.MidSideCoding = cbFLACMidSideCoding.IsChecked == true;
            flacOutput.RiceMin = Convert.ToInt32(edFLACRiceMin.Text);
            flacOutput.RiceMax = Convert.ToInt32(edFLACRiceMax.Text);
        }

        private void SetACMOutput(ref VFACMOutput acmOutput)
        {
            acmOutput.Channels = Convert.ToInt32(cbChannels2.Text);
            acmOutput.BPS = Convert.ToInt32(cbBPS2.Text);
            acmOutput.SampleRate = Convert.ToInt32(cbSampleRate2.Text);
            acmOutput.Name = cbAudioCodecs2.Text;
        }

        private void SetCustomOutput(ref VFCustomOutput customOutput)
        {
            if (rbCustomUseVideoCodecsCat.IsChecked == true)
            {
                customOutput.Video_Codec = cbCustomVideoCodecs.Text;
                customOutput.Video_Codec_UseFiltersCategory = false;
            }
            else
            {
                customOutput.Video_Codec = cbCustomDSFilterV.Text;
                customOutput.Video_Codec_UseFiltersCategory = true;
            }

            if (rbCustomUseAudioCodecsCat.IsChecked == true)
            {
                customOutput.Audio_Codec = cbCustomAudioCodecs.Text;
                customOutput.Audio_Codec_UseFiltersCategory = false;
            }
            else
            {
                customOutput.Audio_Codec = cbCustomDSFilterA.Text;
                customOutput.Audio_Codec_UseFiltersCategory = true;
            }

            customOutput.MuxFilter_Name = cbCustomMuxer.Text;
            customOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.IsChecked == true;
            customOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.IsChecked == true;
            customOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text;
        }

        private void SetDVOutput(ref VFDVOutput dvOutput)
        {
            dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text);
            dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text);
            if (rbDVPAL.IsChecked == true)
            {
                dvOutput.Video_Format = VFDVVideoFormat.PAL;
            }
            else
            {
                dvOutput.Video_Format = VFDVVideoFormat.NTSC;
            }

            dvOutput.Type2 = rbDVType2.IsChecked == true;
        }

        private void SetMKVOutput(ref VFMKVOutput mkvOutput)
        {
            mkvOutput.ACM.Name = cbAudioCodecs.Text;
            mkvOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
            mkvOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
            mkvOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);
            mkvOutput.Video_Codec = cbVideoCodecs.Text;
            mkvOutput.Video_UseCompression = cbUncVideo.IsChecked != true;
            mkvOutput.Video_UseCompression_DecodeUncompressedToRGB = cbDecodeToRGB.IsChecked == true;
            mkvOutput.ACM.UseCompression = cbUncAudio.IsChecked != true;

            if (cbUseLameInAVI.IsChecked == true)
            {
                mkvOutput.Audio_UseMP3Encoder = true;
                var mp3Output = new VFMP3Output();
                FillMP3Settings(ref mp3Output);
                mkvOutput.MP3 = mp3Output;
            }
        }

        private void SetAVIOutput(ref VFAVIOutput aviOutput)
        {
            aviOutput.ACM.Name = cbAudioCodecs.Text;
            aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
            aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
            aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);
            aviOutput.Video_Codec = cbVideoCodecs.Text;
            aviOutput.Video_UseCompression = cbUncVideo.IsChecked != true;
            aviOutput.Video_UseCompression_DecodeUncompressedToRGB = cbDecodeToRGB.IsChecked == true;
            aviOutput.ACM.UseCompression = cbUncAudio.IsChecked != true;

            if (cbUseLameInAVI.IsChecked == true)
            {
                aviOutput.Audio_UseMP3Encoder = true;
                var mp3Output = new VFMP3Output();
                FillMP3Settings(ref mp3Output);
                aviOutput.MP3 = mp3Output;
            }
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Stop();

            // if ((bool)cbUseAdditionalScreens.IsChecked)
            // {
            // pnScreen1.Refresh();
            // pnScreen2.Refresh();
            // pnScreen3.Refresh();
            // }

            waveformPainter.Stop();
            waveformPainter.Clear();

            spectrumAnalyzer.Stop();
            spectrumAnalyzer.Clear();

            volumeMeter1.Stop();
            volumeMeter1.Clear();

            volumeMeter2.Stop();
            volumeMeter2.Clear();

            cbPIPDevices.Items.Clear();

            lbFilters.Items.Clear();
            VideoCapture1.Video_Filters_Clear();
        }

        private void btVideoSettings_Click(object sender, RoutedEventArgs e)
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

        private void cbAudioCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btAudioSettings.IsEnabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioInputFormat_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Format = e.AddedItems[0].ToString();
        }

        private void cbAudioInputLine_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_CaptureDevice_Line = e.AddedItems[0].ToString();
        }

        private void cbAudioOutputDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_OutputDevice = e.AddedItems[0].ToString();
        }

        private void cbCrossbarInput_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCrossbarInput.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                string relatedInput;
                string relatedOutput;
                VideoCapture1.Video_CaptureDevice_CrossBar_GetRelated(e.AddedItems[0].ToString(), cbCrossbarOutput.Text, out relatedInput, out relatedOutput);
            }
        }

        private void cbCrossbarOutput_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            cbCrossbarInput.Items.Clear();

            if (cbCrossbarOutput.SelectedIndex != -1)
            {
                foreach (string s in VideoCapture1.Video_CaptureDevice_CrossBar_GetInputsForOutput(e.AddedItems[0].ToString()))
                {
                    cbCrossbarInput.Items.Add(s);
                }
            }

            string input = VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(e.AddedItems[0].ToString());

            if (input != null)
            {
                cbCrossbarInput.SelectedIndex = cbCrossbarInput.Items.IndexOf(input);
            }
            else
            {
                cbCrossbarInput.SelectedIndex = -1;
            }

            cbCrossbarInput_SelectedIndexChanged(null, null);
        }

        private void cbTVTuner_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((cbTVTuner.Items.Count > 0) && (cbTVTuner.SelectedIndex != -1) && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.TVTuner_Name = e.AddedItems[0].ToString();
                VideoCapture1.TVTuner_Read();

                cbTVMode.Items.Clear();
                foreach (string tunerMode in VideoCapture1.TVTuner_Modes())
                {
                    cbTVMode.Items.Add(tunerMode);
                }

                edVideoFreq.Text = Convert.ToString(VideoCapture1.TVTuner_VideoFrequency);
                edAudioFreq.Text = Convert.ToString(VideoCapture1.TVTuner_AudioFrequency);
                cbTVInput.SelectedIndex = cbTVInput.Items.IndexOf(VideoCapture1.TVTuner_InputType);
                cbTVMode.SelectedIndex = cbTVMode.Items.IndexOf(VideoCapture1.TVTuner_Mode.ToString());
                cbTVSystem.SelectedIndex = cbTVSystem.Items.IndexOf(VideoCapture1.TVTuner_TVFormat);
                cbTVCountry.SelectedIndex = cbTVCountry.Items.IndexOf(VideoCapture1.TVTuner_Country);
            }
        }

        private void cbVideoCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btVideoSettings.IsEnabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbVideoInputFormat_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbVideoInputFormat.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureFormat = e.AddedItems[0].ToString();
            }
            else
            {
                VideoCapture1.Video_CaptureFormat = string.Empty;
            }
        }

        private void cbGreyscale_CheckedChanged(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectGrayscale grayscale;
            var effect = VideoCapture1.Video_Effects_Get("Grayscale");
            if (effect == null)
            {
                grayscale = new VFVideoEffectGrayscale(cbGreyscale.IsChecked == true);
                VideoCapture1.Video_Effects_Add(grayscale);
            }
            else
            {
                grayscale = effect as IVFVideoEffectGrayscale;
                if (grayscale != null)
                {
                    grayscale.Enabled = cbGreyscale.IsChecked == true;
                }
            }
        }

        private void btSaveScreenshot_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            int customWidth = 0;
            int customHeight = 0;

            if (cbScreenshotResize.IsChecked == true)
            {
                customWidth = Convert.ToInt32(edScreenshotWidth.Text);
                customHeight = Convert.ToInt32(edScreenshotHeight.Text);
            }

            switch (cbImageType.SelectedIndex)
            {
                case 0: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0, customWidth, customHeight);
                    break;
                case 1: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, (int)tbJPEGQuality.Value, customWidth, customHeight);
                    break;
                case 2: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0, customWidth, customHeight);
                    break;
                case 3: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0, customWidth, customHeight);
                    break;
                case 4: VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0, customWidth, customHeight);
                    break;
            }
        }

        private void tbJPEGQuality_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbJPEGQuality != null)
            {
                lbJPEGQuality.Content = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void btFont_Click(object sender, RoutedEventArgs e)
        {
            if (fontDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btTextLogoUpdateParams_Click(null, null);
            }
        }

        private void cbTextLogo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            btTextLogoUpdateParams_Click(null, null);
        }

        private void cbInvert_CheckedChanged(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectInvert invert;
            var effect = VideoCapture1.Video_Effects_Get("Invert");
            if (effect == null)
            {
                invert = new VFVideoEffectInvert(cbInvert.IsChecked == true);
                VideoCapture1.Video_Effects_Add(invert);
            }
            else
            {
                invert = effect as IVFVideoEffectInvert;
                if (invert != null)
                {
                    invert.Enabled = cbInvert.IsChecked == true;
                }
            }
        }

        private void tbAdjContrast_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Contrast, (int)tbAdjContrast.Value, cbAdjContrastAuto.IsChecked == true);
            }

            if (lbAdjContrastCurrent != null)
            {
                lbAdjContrastCurrent.Content = "Current: " + Convert.ToString((int)tbAdjContrast.Value);
            }
        }

        private void tbAdjHue_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Hue, (int)tbAdjHue.Value, cbAdjHueAuto.IsChecked == true);
            }

            if (lbAdjHueCurrent != null)
            {
                lbAdjHueCurrent.Content = "Current: " + Convert.ToString((int)tbAdjHue.Value);
            }
        }

        private void tbAdjSaturation_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Saturation, (int)tbAdjSaturation.Value, cbAdjSaturationAuto.IsChecked == true);
            }

            if (lbAdjSaturationCurrent != null)
            {
                lbAdjSaturationCurrent.Content = "Current: " + Convert.ToString((int)tbAdjSaturation.Value);
            }
        }

        private void cbUseAudioInputFromVideoCaptureDevice_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbVideoInputDevice.Text))
            {
                VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.IsChecked == true;
                cbAudioInputDevice_SelectedIndexChanged(null, null);

                cbAudioInputDevice.IsEnabled = cbUseAudioInputFromVideoCaptureDevice.IsChecked != true;
                btAudioInputDeviceSettings.IsEnabled = cbUseAudioInputFromVideoCaptureDevice.IsChecked != true;
            }
        }

        private void cbCustomVideoCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomVideoCodecSettings.IsEnabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomAudioCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomAudioCodecSettings.IsEnabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodecs2_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btAudioSettings2.IsEnabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterV_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomDSFiltersVSettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterA_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomDSFiltersASettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomMuxer_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomMuxerSettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomFilewriter_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            string name = e.AddedItems[0].ToString();
            btCustomFilewriterSettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btVideoCaptureDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbVideoInputDevice.Text);
        }

        private void btAudioInputDeviceSettings_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void btConnect_Click(object sender, RoutedEventArgs e)
        {
            if ((cbCrossbarInput.SelectedIndex != -1) && (cbCrossbarOutput.SelectedIndex != -1))
            {
                VideoCapture1.Video_CaptureDevice_CrossBar_Connect(cbCrossbarInput.Text, cbCrossbarOutput.Text, cbConnectRelated.IsChecked == true);

                lbRotes.Items.Clear();
                for (int i = 0; i < cbCrossbarOutput.Items.Count; i++)
                {
                    string input = VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(cbCrossbarOutput.Items[i].ToString());
                    lbRotes.Items.Add("Input: " + input + ", Output: " + cbCrossbarOutput.Items[i]);
                }
            }
        }

        private void btCustomAudioCodecSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomAudioCodecs.Text;

            if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersASettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomDSFilterA.Text;

            if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersVSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomDSFilterV.Text;

            if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomFilewriterSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomFilewriter.Text;

            if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomMuxerSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomMuxer.Text;

            if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomVideoCodecSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomVideoCodecs.Text;

            if (VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btDVFF_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.FastForward);
        }

        private void btDVPause_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Pause);
        }

        private void btDVRewind_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Rew);
        }

        private void btDVPlay_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Play);
        }

        private void btDVStepFWD_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepFw);
        }

        private void btDVStepRev_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepRev);
        }

        private void btDVStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Stop);
        }

        private void btRefreshClients_Click(object sender, RoutedEventArgs e)
        {
            lbNetworkClients.Items.Clear();

            for (int i = 0; i < VideoCapture1.Network_Streaming_WMV_Clients_GetCount(); i++)
            {
                string dns;
                string address;
                int port;
                VideoCapture1.Network_Streaming_WMV_Clients_GetInfo(i, out port, out address, out dns);

                string client = "ID: " + i + ", Port: " + port + ", Address: " + address + ", DNS: " + dns;
                lbNetworkClients.Items.Add(client);
            }
        }

        private void btSelectImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog2.ShowDialog() == true)
            {
                edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void btStartTune_Click(object sender, RoutedEventArgs e)
        {
            const int KHz = 1000;
            const int MHz = 1000000;

            VideoCapture1.TVTuner_Read();
            cbTVChannel.Items.Clear();

            if ((cbTVMode.SelectedIndex != -1) && (cbTVMode.Text == "FM Radio"))
            {
                VideoCapture1.TVTuner_FM_Tuning_StartFrequency = 100 * MHz;
                VideoCapture1.TVTuner_FM_Tuning_StopFrequency = 110 * MHz;
                VideoCapture1.TVTuner_FM_Tuning_Step = 100 * KHz;
            }

            VideoCapture1.TVTuner_TuneChannels_Start();
        }

        private void btStopTune_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.TVTuner_TuneChannels_Stop();
        }

        private void btUseThisChannel_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(edChannel.Text) <= 10000)
            {
                // channel
                VideoCapture1.TVTuner_Channel = Convert.ToInt32(edChannel.Text);
            }
            else
            {
                VideoCapture1.TVTuner_Channel = -1;

                // must be -1 to use frequency

                VideoCapture1.TVTuner_Frequency = Convert.ToInt32(edChannel.Text);
            }

            VideoCapture1.TVTuner_Apply();
            VideoCapture1.TVTuner_Read();
            edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
            edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
        }

        private void cbTVCountry_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTVCountry.SelectedIndex != -1)
            {
                VideoCapture1.TVTuner_Country = cbTVCountry.Text;
                edTVDefaultFormat.Text = VideoCapture1.TVTuner_Countries_GetPreferredFormatForCountry(VideoCapture1.TVTuner_Country);

                if (VideoCapture1.Status == VFVideoCaptureStatus.Work)
                {
                    VideoCapture1.TVTuner_Apply();
                    VideoCapture1.TVTuner_Read();
                }
            }
        }

        private void cbImageLogo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoCapture1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.IsChecked == true);
                VideoCapture1.Video_Effects_Add(imageLogo);
            }
            else
            {
                imageLogo = effect as IVFVideoEffectImageLogo;
            }

            if (imageLogo == null)
            {
                MessageBox.Show("Unable to configure image logo effect.");
                return;
            }

            imageLogo.Enabled = cbImageLogo.IsChecked == true;
            imageLogo.Filename = edImageLogoFilename.Text;
            imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text);
            imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text);
            imageLogo.TransparencyLevel = (int)tbImageLogoTransp.Value;
            imageLogo.ColorKey = VideoCapture.ColorConv(((SolidColorBrush)pnImageLogoColorKey.Fill).Color);
            imageLogo.UseColorKey = cbImageLogoUseColorKey.IsChecked == true;
            imageLogo.AnimationEnabled = true;

            if (cbImageLogoShowAlways.IsChecked == true)
            {
                imageLogo.StartTime = 0;
                imageLogo.StopTime = 0;
            }
            else
            {
                imageLogo.StartTime = Convert.ToInt32(edImageLogoStartTime.Text);
                imageLogo.StopTime = Convert.ToInt32(edImageLogoStopTime.Text);
            }
        }

        private void cbImageLogoShowAlways_CheckedChanged(object sender, RoutedEventArgs e)
        {
            edImageLogoStartTime.IsEnabled = cbImageLogoShowAlways.IsChecked != true;
            edImageLogoStopTime.IsEnabled = cbImageLogoShowAlways.IsChecked != true;
            lbGraphicLogoStartTime.IsEnabled = cbImageLogoShowAlways.IsChecked != true;
            lbGraphicLogoStopTime.IsEnabled = cbImageLogoShowAlways.IsChecked != true;

            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void cbTVMode_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTVMode.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VFTVTunerMode mode;
                Enum.TryParse(e.AddedItems[0].ToString(), true, out mode);
                VideoCapture1.TVTuner_Mode = mode;
                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                cbTVChannel.Items.Clear();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTVChannel_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTVChannel.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                int k = Convert.ToInt32(e.AddedItems[0].ToString());

                if (k <= 10000)
                {
                    // channel
                    VideoCapture1.TVTuner_Channel = k;
                }
                else
                {
                    // must be -1 to use frequency
                    VideoCapture1.TVTuner_Channel = -1;
                    VideoCapture1.TVTuner_Frequency = k;
                }

                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTVInput_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTVInput.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.TVTuner_InputType = e.AddedItems[0].ToString();
                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTVSystem_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTVSystem.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.TVTuner_TVFormat = VideoCapture1.TVTuner_TVFormat_FromString(e.AddedItems[0].ToString());
                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbUseBestAudioInputFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAudioInputFormat.IsEnabled = cbUseBestAudioInputFormat.IsChecked != true;
        }

        private void cbUseBestVideoInputFormat_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbVideoInputFormat.IsEnabled = cbUseBestVideoInputFormat.IsChecked != true;
        }

        private void tbAudioVolume_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_OutputDevice_Volume_Set((int)tbAudioVolume.Value);
            }
        }

        private void tbAudioBalance_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_OutputDevice_Balance_Set((int)tbAudioBalance.Value);
            VideoCapture1.Audio_OutputDevice_Balance_Get();
        }

        private void btAudioSettings2_Click(object sender, RoutedEventArgs e)
        {
            string name = cbAudioCodecs2.Text;

            if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btSelectScreenshotsFolder_Click(object sender, RoutedEventArgs e)
        {
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                edScreenshotsFolder.Text = folderDialog.SelectedPath;
            }
        }

        private void btSelectWMVProfileNetwork_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edNetworkStreamingWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        private void btPause_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Pause();
        }

        private void btResume_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Resume();
        }

        private void btMPEGEncoderShowDialog_Click(object sender, RoutedEventArgs e)
        {
            if (cbMPEGEncoder.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = cbMPEGEncoder.Text;
            }

            VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_ShowDialog(IntPtr.Zero);
        }

        private void cbFilters_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                string name = e.AddedItems[0].ToString();
                btFilterSettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                    VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                VideoCapture1.Video_Filters_Add(new VFCustomProcessingFilter(cbFilters.Text));
                lbFilters.Items.Add(cbFilters.Text);
            }
        }

        private void btFilterSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbFilters.Text;

            if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterSettings2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.SelectedValue.ToString();

                if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
                }
                else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btFilterDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            lbFilters.Items.Clear();
            VideoCapture1.Video_Filters_Clear();
        }

        private void cbPIPDevice_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPIPDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureDevice = e.AddedItems[0].ToString();

                cbPIPFormat.Items.Clear();

                var deviceItem = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == e.AddedItems[0].ToString());
                if (deviceItem != null)
                {
                    foreach (string format in deviceItem.VideoFormats)
                    {
                        cbPIPFormat.Items.Add(format);
                    }

                    if (cbPIPFormat.Items.Count > 0)
                    {
                        cbPIPFormat.SelectedIndex = 0;
                    }

                    cbPIPFrameRate.Items.Clear();
                    foreach (string frameRate in deviceItem.VideoFrameRates)
                    {
                        cbPIPFrameRate.Items.Add(frameRate);
                    }

                    if (cbPIPFrameRate.Items.Count > 0)
                    {
                        cbPIPFrameRate.SelectedIndex = 0;
                    }

                    cbPIPInput.Items.Clear();

                    VideoCapture1.PIP_Sources_Device_GetCrossbar(e.AddedItems[0].ToString());
                    foreach (string input in VideoCapture1.PIP_Sources_Device_GetCrossbarInputs())
                    {
                        cbPIPInput.Items.Add(input);
                    }

                    if (cbPIPInput.Items.Count > 0)
                    {
                        cbPIPInput.SelectedIndex = 0;
                    }
                }
            }
        }

        private void cbMPEGVideoDecoder_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMPEGVideoDecoder.SelectedIndex < 1 || e == null || e.AddedItems.Count > 0)
            {
                btMPEGVidDecSetting.IsEnabled = false;
            }
            else
            {
                string name = e.AddedItems[0].ToString();
                btMPEGVidDecSetting.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                  VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbMPEGAudioDecoder_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMPEGAudioDecoder.SelectedIndex < 1 || e == null || e.AddedItems.Count > 0)
            {
                btMPEGAudDecSettings.IsEnabled = false;
            }
            else
            {
                string name = e.AddedItems[0].ToString();
                btMPEGAudDecSettings.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                  VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btMPEGVidDecSetting_Click(object sender, RoutedEventArgs e)
        {
            if (cbMPEGVideoDecoder.SelectedIndex > 0)
            {
                string name = cbMPEGVideoDecoder.Text;

                if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
                }
                else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btMPEGAudDecSettings_Click(object sender, RoutedEventArgs e)
        {
            if (cbMPEGAudioDecoder.SelectedIndex > 0)
            {
                string name = cbMPEGAudioDecoder.Text;

                if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
                }
                else if (VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btScreenCaptureUpdate_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Screen_Capture_UpdateParameters(
                Convert.ToInt32(edScreenLeft.Text),
                Convert.ToInt32(edScreenTop.Text),
                cbScreenCapture_GrabMouseCursor.IsChecked == true);
        }

        private void cbPIPFormatUseBest_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbPIPFormat.IsEnabled = cbPIPFormatUseBest.IsChecked != true;
        }

        private void btPIPUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (cbPIPDevices.SelectedIndex != -1)
            {
                VideoCapture1.PIP_Sources_SetSourcePosition(
                    cbPIPDevices.SelectedIndex,
                    Convert.ToInt32(edPIPLeft.Text),
                    Convert.ToInt32(edPIPTop.Text),
                    Convert.ToInt32(edPIPWidth.Text),
                    Convert.ToInt32(edPIPHeight.Text));
            }
            else
            {
                MessageBox.Show("Select device!");
            }
        }

        private void btPIPAddDevice_Click(object sender, RoutedEventArgs e)
        {
            if (cbPIPDevice.SelectedIndex != -1)
            {
                string frameRate;
                if (cbPIPFrameRate.SelectedIndex != -1)
                {
                    frameRate = cbPIPFrameRate.Text;
                }
                else
                {
                    frameRate = "0";
                }

                string format;
                if (cbPIPFormat.SelectedIndex != -1)
                {
                    format = cbPIPFormat.Text;
                }
                else
                {
                    format = string.Empty;
                }

                string input;
                if (cbPIPInput.SelectedIndex != -1)
                {
                    input = cbPIPInput.Text;
                }
                else
                {
                    input = string.Empty;
                }

                VideoCapture1.PIP_Sources_Add_VideoCaptureDevice(
                    cbPIPDevice.Text,
                    format,
                    cbPIPFormatUseBest.IsChecked == true,
                    Convert.ToDouble(frameRate),
                    input,
                    Convert.ToInt32(edPIPVidCapLeft.Text),
                    Convert.ToInt32(edPIPVidCapTop.Text),
                    Convert.ToInt32(edPIPVidCapWidth.Text),
                    Convert.ToInt32(edPIPVidCapHeight.Text));

                cbPIPDevices.Items.Add(cbPIPDevice.Text);
            }
        }

        private void btTextLogoUpdateParams_Click(object sender, RoutedEventArgs e)
        {
            VFTextRotationMode rotate;
            VFTextFlipMode flip;

            StringFormat formatFlags = new StringFormat();

            if (cbTextLogoVertical.IsChecked == true)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionVertical;
            }

            if (cbTextLogoRightToLeft.IsChecked == true)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }

            formatFlags.Alignment = (StringAlignment)cbTextLogoAlign.SelectedIndex;

            IVFVideoEffectTextLogo textLogo;
            var effect = VideoCapture1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.IsChecked == true);
                VideoCapture1.Video_Effects_Add(textLogo);
            }
            else
            {
                textLogo = effect as IVFVideoEffectTextLogo;
            }

            if (textLogo == null)
            {
                MessageBox.Show("Unable to configure text logo effect.");
                return;
            }

            textLogo.Enabled = cbTextLogo.IsChecked == true;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = fontDialog.Font;
            textLogo.FontColor = fontDialog.Color;

            textLogo.BackgroundTransparent = cbTextLogoTranspBG.IsChecked == true;
            textLogo.BackgroundColor = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoBGColor.Fill).Color);
            textLogo.StringFormat = formatFlags;
            textLogo.Antialiasing = (TextRenderingHint)cbTextLogoAntialiasing.SelectedIndex;
            textLogo.DrawQuality = (InterpolationMode)cbTextLogoDrawMode.SelectedIndex;

            if (cbTextLogoUseRect.IsChecked == true)
            {
                textLogo.RectWidth = Convert.ToInt32(edTextLogoWidth.Text);
                textLogo.RectHeight = Convert.ToInt32(edTextLogoHeight.Text);
            }
            else
            {
                textLogo.RectWidth = 0;
                textLogo.RectHeight = 0;
            }

            if (rbTextLogoDegree0.IsChecked == true)
            {
                rotate = VFTextRotationMode.RmNone;
            }
            else if (rbTextLogoDegree90.IsChecked == true)
            {
                rotate = VFTextRotationMode.Rm90;
            }
            else if (rbTextLogoDegree180.IsChecked == true)
            {
                rotate = VFTextRotationMode.Rm180;
            }
            else
            {
                rotate = VFTextRotationMode.Rm270;
            }

            if (rbTextLogoFlipNone.IsChecked == true)
            {
                flip = VFTextFlipMode.None;
            }
            else if (rbTextLogoFlipX.IsChecked == true)
            {
                flip = VFTextFlipMode.X;
            }
            else if (rbTextLogoFlipY.IsChecked == true)
            {
                flip = VFTextFlipMode.Y;
            }
            else
            {
                flip = VFTextFlipMode.XAndY;
            }

            textLogo.RotationMode = rotate;
            textLogo.FlipMode = flip;

            textLogo.GradientEnabled = cbTextLogoGradientEnabled.IsChecked == true;
            textLogo.GradientMode = (VFTextGradientMode)cbTextLogoGradMode.SelectedIndex;
            textLogo.GradientColor1 = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoGradColor1.Fill).Color);
            textLogo.GradientColor2 = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoGradColor2.Fill).Color);

            textLogo.BorderMode = (VFTextEffectMode)cbTextLogoEffectrMode.SelectedIndex;
            textLogo.BorderInnerColor = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoInnerColor.Fill).Color);
            textLogo.BorderOuterColor = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoOuterColor.Fill).Color);
            textLogo.BorderInnerSize = Convert.ToInt32(edTextLogoInnerSize.Text);
            textLogo.BorderOuterSize = Convert.ToInt32(edTextLogoOuterSize.Text);

            textLogo.Shape = cbTextLogoShapeEnabled.IsChecked == true;
            textLogo.ShapeLeft = Convert.ToInt32(edTextLogoShapeLeft.Text);
            textLogo.ShapeTop = Convert.ToInt32(edTextLogoShapeTop.Text);
            textLogo.ShapeType = (VFTextShapeType)cbTextLogoShapeType.SelectedIndex;
            textLogo.ShapeWidth = Convert.ToInt32(edTextLogoShapeWidth.Text);
            textLogo.ShapeHeight = Convert.ToInt32(edTextLogoShapeHeight.Text);
            textLogo.ShapeColor = VideoCapture.ColorConv(((SolidColorBrush)pnTextLogoShapeColor.Fill).Color);

            textLogo.TransparencyLevel = (int)tbTextLogoTransp.Value;

            if (rbTextLogoDrawText.IsChecked == true)
            {
                textLogo.Mode = TextLogoMode.Text;
            }
            else if (rbTextLogoDrawDate.IsChecked == true)
            {
                textLogo.Mode = TextLogoMode.DateTime;
                textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss";
            }
            else if (rbTextLogoDrawFrameNumber.IsChecked == true)
            {
                textLogo.Mode = TextLogoMode.FrameNumber;
            }
            else
            {
                textLogo.Mode = TextLogoMode.Timestamp;
            }

            textLogo.Update();
        }

        private void btMotDetUpdateSettings_Click(object sender, RoutedEventArgs e)
        {
            if (cbMotDetEnabled.IsChecked == true)
            {
                VideoCapture1.Motion_Detection = new MotionDetectionSettings
                                                     {
                                                         Enabled = this.cbMotDetEnabled.IsChecked == true,
                                                         Compare_Red = this.cbCompareRed.IsChecked == true,
                                                         Compare_Green = this.cbCompareGreen.IsChecked == true,
                                                         Compare_Blue = this.cbCompareBlue.IsChecked == true,
                                                         Compare_Greyscale = this.cbCompareGreyscale.IsChecked == true,
                                                         Highlight_Color =
                                                             (VFMotionCHLColor)this.cbMotDetHLColor.SelectedIndex,
                                                         Highlight_Enabled = this.cbMotDetHLEnabled.IsChecked == true,
                                                         Highlight_Threshold = (int)this.tbMotDetHLThreshold.Value,
                                                         FrameInterval = Convert.ToInt32(this.edMotDetFrameInterval.Text),
                                                         Matrix_Height = Convert.ToInt32(this.edMotDetMatrixHeight.Text),
                                                         Matrix_Width = Convert.ToInt32(this.edMotDetMatrixWidth.Text),
                                                         DropFrames_Enabled =
                                                             this.cbMotDetDropFramesEnabled.IsChecked == true,
                                                         DropFrames_Threshold = (int)this.tbMotDetDropFramesThreshold.Value
                                                     };
                VideoCapture1.MotionDetection_Update();
            }
            else
            {
                VideoCapture1.Motion_Detection = null;
            }
        }

        public delegate void MotionDelegate(MotionDetectionEventArgs e);

        public void MotionDelegateMethod(MotionDetectionEventArgs e)
        {
            string s = string.Empty;
            foreach (byte b in e.Matrix)
            {
                s += b + " ";
            }

            mmMotDetMatrix.Text = s.Trim();
            pbMotionLevel.Value = e.Level;
        }

        private void VideoCapture1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            Dispatcher.BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        private void btAudEqRefresh_Click(object sender, RoutedEventArgs e)
        {
            tbAudEq0.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0);
            tbAudEq1.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1);
            tbAudEq2.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2);
            tbAudEq3.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3);
            tbAudEq4.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4);
            tbAudEq5.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5);
            tbAudEq6.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6);
            tbAudEq7.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7);
            tbAudEq8.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8);
            tbAudEq9.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9);
        }

        private void btSignal_Click(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1.Video_CaptureDevice_SignalPresent())
            {
                MessageBox.Show("Signal present");
            }
            else
            {
                MessageBox.Show("Signal not present");
            }
        }

        // private void pnColorBG_Click(object sender, RoutedEventArgs e)
        // {
        //    if (colorDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pnColorBG.BackColor = colorDialog1.Color;
        //        //VideoCapture1.BackgroundColor = colorDialog1.Color;
        //    }
        // }

        private void cbAudAmplifyEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.IsChecked == true);
        }

        private void cbAudDynamicAmplifyEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.IsChecked == true);
        }

        private void cbAudEqualizerEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.IsChecked == true);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e == null || e.AddedItems.Count == 0)
            {
                return;
            }

            VideoCapture1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(sender, e);
        }

        private void cbAudSound3DEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.IsChecked == true);
        }

        private void cbAudTrueBassEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.IsChecked == true);
        }

        private void cbWMVAudioCodec_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            var mode = VFWMVStreamMode.CBR;
            switch (cbWMVAudioMode.SelectedIndex)
            {
                case 0:
                    {
                        mode = VFWMVStreamMode.CBR;
                        break;
                    }

                case 1:
                    {
                        mode = VFWMVStreamMode.VBRBitrate;
                        break;
                    }

                case 2:
                    {
                        mode = VFWMVStreamMode.VBRPeakBitrate;
                        break;
                    }

                case 3:
                    {
                        mode = VFWMVStreamMode.VBRQuality;
                        break;
                    }
            }

            cbWMVAudioFormat.Items.Clear();
            if (cbWMVAudioCodec.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                foreach (string format in VideoCapture1.WMV_CustomProfile_AudioFormats(e.AddedItems[0].ToString(), mode))
                {
                    cbWMVAudioFormat.Items.Add(format);
                }
            }
        }

        private void cbWMVAudioMode_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            var mode = VFWMVStreamMode.CBR;
            switch (cbWMVAudioMode.SelectedIndex)
            {
                case 0:
                    {
                        mode = VFWMVStreamMode.CBR;
                        break;
                    }

                case 1:
                    {
                        mode = VFWMVStreamMode.VBRBitrate;
                        break;
                    }

                case 2:
                    {
                        mode = VFWMVStreamMode.VBRPeakBitrate;
                        break;
                    }

                case 3:
                    {
                        mode = VFWMVStreamMode.VBRQuality;
                        break;
                    }
            }

            cbWMVAudioCodec.Items.Clear();
            foreach (string codec in VideoCapture1.WMV_CustomProfile_AudioCodecs(mode))
            {
                cbWMVAudioCodec.Items.Add(codec);
            }

            cbWMVAudioCodec_SelectedIndexChanged(sender, e);
        }

        private void cbWMVVideoMode_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            var mode = VFWMVStreamMode.CBR;
            switch (cbWMVVideoMode.SelectedIndex)
            {
                case 0:
                    {
                        mode = VFWMVStreamMode.CBR;
                        edWMVVideoBitrate.IsEnabled = true;
                        edWMVVideoPeakBitrate.IsEnabled = false;
                        edWMVVideoQuality.IsEnabled = false;
                        break;
                    }

                case 1:
                    {
                        mode = VFWMVStreamMode.VBRBitrate;
                        edWMVVideoBitrate.IsEnabled = true;
                        edWMVVideoPeakBitrate.IsEnabled = false;
                        edWMVVideoQuality.IsEnabled = false;
                        break;
                    }

                case 2:
                    {
                        mode = VFWMVStreamMode.VBRPeakBitrate;
                        edWMVVideoBitrate.IsEnabled = true;
                        edWMVVideoPeakBitrate.IsEnabled = true;
                        edWMVVideoQuality.IsEnabled = false;
                        break;
                    }

                case 3:
                    {
                        mode = VFWMVStreamMode.VBRQuality;
                        edWMVVideoBitrate.IsEnabled = false;
                        edWMVVideoPeakBitrate.IsEnabled = false;
                        edWMVVideoQuality.IsEnabled = true;
                        break;
                    }
            }

            cbWMVVideoCodec.Items.Clear();
            foreach (string codec in VideoCapture1.WMV_CustomProfile_VideoCodecs(mode))
            {
                cbWMVVideoCodec.Items.Add(codec);
            }
        }
        
        private void tbAdjBrightness_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(
                    VFVideoHardwareAdjustment.Brightness,
                    (int)tbAdjBrightness.Value,
                    cbAdjBrightnessAuto.IsChecked == true);
            }

            if (lbAdjBrightnessCurrent != null)
            {
                lbAdjBrightnessCurrent.Content = "Current: " + Convert.ToString((int)tbAdjBrightness.Value);
            }
        }

        private void tbAud3DSound_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_Effects_Sound3D(-1, 3, (ushort)tbAud3DSound.Value);
            }
        }

        private void tbAudDynAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_Effects_DynamicAmplify(
                    -1, 2, (int)tbAudAttack.Value, (int)tbAudDynAmp.Value, (int)tbAudRelease.Value);
            }
        }

        private void tbAudAttack_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_Effects_DynamicAmplify(
                    -1, 2, (int)tbAudAttack.Value, (int)tbAudDynAmp.Value, (int)tbAudRelease.Value);
            }
        }
        
        private void tbAudEq0_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, (sbyte)tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, (sbyte)tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, (sbyte)tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, (sbyte)tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, (sbyte)tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, (sbyte)tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, (sbyte)tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, (sbyte)tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, (sbyte)tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, (sbyte)tbAudEq9.Value);
        }

        private void tbAudTrueBass_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoCapture1.Audio_Effects_TrueBass(-1, 4, 200, false, (ushort)tbAudTrueBass.Value);
        }

        private void tbContrast_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectContrast contrast;
            var effect = VideoCapture1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, (int)tbContrast.Value);
                VideoCapture1.Video_Effects_Add(contrast);
            }
            else
            {
                contrast = effect as IVFVideoEffectContrast;
                if (contrast != null)
                {
                    contrast.Value = (int)tbContrast.Value;
                }
            }
        }

        private void tbDarkness_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectDarkness darkness;
            var effect = VideoCapture1.Video_Effects_Get("Darkness");
            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, (int)tbDarkness.Value);
                VideoCapture1.Video_Effects_Add(darkness);
            }
            else
            {
                darkness = effect as IVFVideoEffectDarkness;
                if (darkness != null)
                {
                    darkness.Value = (int)tbDarkness.Value;
                }
            }
        }

        private void tbLightness_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectLightness lightness;
            var effect = VideoCapture1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, (int)tbLightness.Value);
                VideoCapture1.Video_Effects_Add(lightness);
            }
            else
            {
                lightness = effect as IVFVideoEffectLightness;
                if (lightness != null)
                {
                    lightness.Value = (int)tbLightness.Value;
                }
            }
        }

        private void tbSaturation_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                IVFVideoEffectSaturation saturation;
                var effect = VideoCapture1.Video_Effects_Get("Saturation");
                if (effect == null)
                {
                    saturation = new VFVideoEffectSaturation((int)tbSaturation.Value);
                    VideoCapture1.Video_Effects_Add(saturation);
                }
                else
                {
                    saturation = effect as IVFVideoEffectSaturation;
                    if (saturation != null)
                    {
                        saturation.Value = (int)tbSaturation.Value;
                    }
                }
            }
        }

        // private void VideoCapture1_OnDVDeviceEvent(object sender, IVFVideoCapture4XEvents_OnDVDeviceEventEvent e)
        // {
        //    switch (e.eventCode)
        //    {
        //        case (int)VFDVCommand.DV_PLAY: VideoCapture1.Resume(); break;
        //        case (int)VFDVCommand.DV_PAUSE: VideoCapture1.Pause(); break;
        //        case (int)VFDVCommand.DV_STOP: VideoCapture1.Stop(); break;
        //        // other events codes - DV_x
        //    }
        // }

        // private void VideoCapture1_OnVUMeterImageS1I(object sender, IVFVideoCapture4XEvents_OnVUMeterImageS1IEvent e)
        // {
        //    Bitmap bmp = Bitmap.FromHbitmap((IntPtr)e.frame);
        //    pbVUMeter1.Image = bmp;
        // }

        // private void VideoCapture1_OnVUMeterImageS2I(object sender, IVFVideoCapture4XEvents_OnVUMeterImageS2IEvent e)
        // {
        //    Bitmap bmp = Bitmap.FromHbitmap((IntPtr)e.frame);
        //    pbVUMeter2.Image = bmp;
        // }

        // private void VideoCapture1_OnVUMeterValues(object sender, IVFVideoCapture4XEvents_OnVUMeterValuesEvent e)
        // {
        //    edVUMeterValues.Text = e.values;
        // }

        private void tbAudAmplifyAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_Effects_Amplify(-1, 0, (int)tbAudAmplifyAmp.Value * 10, false);
            }
        }

        private void tbAudRelease_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_Effects_DynamicAmplify(
                    -1, 2, (ushort)tbAudAttack.Value, (ushort)tbAudDynAmp.Value, (int)tbAudRelease.Value);
            }
        }
        
        private void tbChromaKeyContrastLow_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1?.ChromaKey != null)
            {
                VideoCapture1.ChromaKey.ContrastLow = (int)tbChromaKeyContrastLow.Value;
            }
        }

        private void tbChromaKeyContrastHigh_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1?.ChromaKey != null)
            {
                VideoCapture1.ChromaKey.ContrastHigh = (int)tbChromaKeyContrastHigh.Value;
            }
        }

        private void btChromaKeySelectBGImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                if (VideoCapture1.ChromaKey != null)
                {
                    VideoCapture1.ChromaKey.ImageFilename = edChromaKeyImage.Text = openFileDialog1.FileName;
                }

                edChromaKeyImage.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (VideoCapture1.Status == VFVideoCaptureStatus.Work)
            {
                VideoCapture1.Stop();
            }
        }

        private static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate { }));
        }

        private void VideoCapture1_OnTVTunerTuneChannels(object sender, TVTunerTuneChannelsEventArgs e)
        {
            DoEvents();

            pbChannels.Value = e.Progress;

            if (e.SignalPresent)
            {
                cbTVChannel.Items.Add(e.Channel.ToString(CultureInfo.InvariantCulture));
            }

            if (e.Channel == -1)
            {
                pbChannels.Value = 0;
                MessageBox.Show("AutoTune complete");
            }

            DoEvents();
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void cbUseSpecialFilewriter_Checked(object sender, RoutedEventArgs e)
        {
            cbCustomFilewriter.IsEnabled = cbUseSpecialFilewriter.IsChecked == true;
            btCustomFilewriterSettings.IsEnabled = cbUseSpecialFilewriter.IsChecked == true;
        }

        private void pnGraphicLogoColorKey_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnImageLogoColorKey.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnImageLogoColorKey.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoBGColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoBGColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoBGColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoGradColor1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoGradColor1.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoGradColor1.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoGradColor2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoGradColor2.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoGradColor2.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoInnerColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoInnerColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoInnerColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoOuterColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoOuterColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoOuterColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void pnTextLogoShapeColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoShapeColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnTextLogoShapeColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void lbFilters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.SelectedValue.ToString();
                btFilterSettings2.IsEnabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                                            VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbUncVideo_Checked(object sender, RoutedEventArgs e)
        {
            cbVideoCodecs.IsEnabled = cbUncVideo.IsChecked != true;
            btVideoSettings.IsEnabled = cbUncVideo.IsChecked != true;
            cbDecodeToRGB.IsEnabled = cbUncVideo.IsChecked == true;

            if (cbVideoCodecs.IsEnabled)
            {
                cbVideoCodecs_SelectedIndexChanged(null, null);
            }
            else
            {
                btVideoSettings.IsEnabled = false;
            }
        }

        private void tbGraphicLogoTransp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void cbGraphicLogoUseColorKey_Checked(object sender, RoutedEventArgs e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void cbStretch_Checked(object sender, RoutedEventArgs e)
        {
            if (cbStretch.IsChecked == true)
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.Video_Renderer_Update();
        }

        private void cbMPEGEncoder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMPEGEncoder.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = e.AddedItems[0].ToString();
            }
        }

        public delegate void AFMotionDelegate(float level);

        public void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void VideoCapture1_OnObjectDetection(object sender, MotionDetectionExEventArgs e)
        {
            Dispatcher.BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
        }

        private void cbAFMotionDetection_Checked(object sender, RoutedEventArgs e)
        {
            ConfigureMotionDetectionEx();
        }

        private void btSeparateCaptureStart_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.SeparateCapture_Start(edOutput.Text);
        }

        private void btSeparateCaptureStop_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.SeparateCapture_Stop();
        }

        private void btSeparateCaptureChangeFilename_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.SeparateCapture_ChangeFilenameOnTheFly(edNewFilename.Text);
        }

        private void btPIPAddIPCamera_Click(object sender, RoutedEventArgs e)
        {
            IPCameraSourceSettings ipCameraSource;
            SelectIPCameraSource(out ipCameraSource);

            VideoCapture1.PIP_Sources_Add_IPCamera(
                ipCameraSource,
                Convert.ToInt32(edPIPScreenCapLeft.Text),
                Convert.ToInt32(edPIPScreenCapTop.Text),
                Convert.ToInt32(edPIPScreenCapWidth.Text),
                Convert.ToInt32(edPIPScreenCapHeight.Text));

            cbPIPDevices.Items.Add("IP Capture");
        }

        private void btPIPAddScreenCapture_Click(object sender, RoutedEventArgs e)
        {
            ScreenCaptureSourceSettings screenSource;
            SelectScreenCaptureSource(out screenSource);

            VideoCapture1.PIP_Sources_Add_ScreenSource(
                screenSource,
                Convert.ToInt32(edPIPScreenCapLeft.Text),
                Convert.ToInt32(edPIPScreenCapTop.Text),
                Convert.ToInt32(edPIPScreenCapWidth.Text),
                Convert.ToInt32(edPIPScreenCapHeight.Text));

            cbPIPDevices.Items.Add("Screen Capture");
        }

        private void btPIPDevicesClear_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.PIP_Sources_Clear();
            cbPIPDevices.Items.Clear();
        }

        private void btPIPSetOutputSize_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.PIP_CustomOutputSize_Set(Convert.ToInt32(edPIPOutputWidth.Text), Convert.ToInt32(edPIPOutputHeight.Text));
        }

        private void btPIPSet_Click(object sender, RoutedEventArgs e)
        {
            if (cbPIPDevices.SelectedIndex != -1)
            {
                VideoCapture1.PIP_Sources_SetSourceSettings(cbPIPDevices.SelectedIndex, (int)tbPIPTransparency.Value, false, false);
            }
            else
            {
                MessageBox.Show("Select device!");
            }
        }

        private void btSeparateCapturePause_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.SeparateCapture_Pause();
        }

        private void btSeparateCaptureResume_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.SeparateCapture_Resume();
        }

        private void btDVBTTune_Click(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1.BDA_Source != null && VideoCapture1.BDA_Source.SourceType == VFBDAType.DVBT)
            {
                VFBDATuningParameters bdaTuningParameters = new VFBDATuningParameters
                {
                    Frequency = Convert.ToInt32(edDVBTFrequency.Text),
                    ONID = Convert.ToInt32(edDVBTONID.Text),
                    SID = Convert.ToInt32(edDVBTSID.Text),
                    TSID = Convert.ToInt32(edDVBTTSID.Text)
                };

                VideoCapture1.BDA_SetParameters(bdaTuningParameters);
            }
        }

        private void cbZoomEnabled_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectZoom zoomEffect;
            var effect = VideoCapture1.Video_Effects_Get("Zoom");
            if (effect == null)
            {
                zoomEffect = new VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoomEnabled.IsChecked == true);
                VideoCapture1.Video_Effects_Add(zoomEffect);
            }
            else
            {
                zoomEffect = effect as IVFVideoEffectZoom;
            }

            if (zoomEffect == null)
            {
                MessageBox.Show("Unable to configure zoom effect.");
                return;
            }

            zoomEffect.ZoomX = zoom;
            zoomEffect.ZoomY = zoom;
            zoomEffect.ShiftX = zoomShiftX;
            zoomEffect.ShiftY = zoomShiftY;
            zoomEffect.Enabled = cbZoomEnabled.IsChecked == true;
        }

        private void btEffZoomIn_Click(object sender, RoutedEventArgs e)
        {
            zoom += 0.1;
            zoom = Math.Min(zoom, 5);

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomOut_Click(object sender, RoutedEventArgs e)
        {
            zoom -= 0.1;
            zoom = Math.Max(zoom, 1);

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftUp_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftY += 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftDown_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftY -= 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftRight_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftX += 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftLeft_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftX -= 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void cbPan_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectPan pan;
            var effect = VideoCapture1.Video_Effects_Get("Pan");
            if (effect == null)
            {
                pan = new VFVideoEffectPan(true);
                VideoCapture1.Video_Effects_Add(pan);
            }
            else
            {
                pan = effect as IVFVideoEffectPan;
            }

            if (pan == null)
            {
                MessageBox.Show("Unable to configure pan effect.");
                return;
            }

            pan.Enabled = cbPan.IsChecked == true;
            pan.StartTime = Convert.ToInt32(edPanStartTime.Text);
            pan.StopTime = Convert.ToInt32(edPanStopTime.Text);
            pan.StartX = Convert.ToInt32(edPanSourceLeft.Text);
            pan.StartY = Convert.ToInt32(edPanSourceTop.Text);
            pan.StartWidth = Convert.ToInt32(edPanSourceWidth.Text);
            pan.StartHeight = Convert.ToInt32(edPanSourceHeight.Text);
            pan.StopX = Convert.ToInt32(edPanDestLeft.Text);
            pan.StopY = Convert.ToInt32(edPanDestTop.Text);
            pan.StopWidth = Convert.ToInt32(edPanDestWidth.Text);
            pan.StopHeight = Convert.ToInt32(edPanDestHeight.Text);
        }

        private void btBarcodeReset_Click(object sender, RoutedEventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            VideoCapture1.Barcode_Reader_Enabled = true;
        }

        #region Barcode detector

        public delegate void BarcodeDelegate(BarcodeEventArgs value);

        public void BarcodeDelegateMethod(BarcodeEventArgs value)
        {
            edBarcode.Text = value.Value;
            edBarcodeMetadata.Text = string.Empty;
            foreach (var o in value.Metadata)
            {
                edBarcodeMetadata.Text += o.Key + ": " + o.Value + Environment.NewLine;
            }
        }

        private void VideoCapture1_OnBarcodeDetected(object sender, BarcodeEventArgs e)
        {
            e.DetectorEnabled = false;

            Dispatcher.BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        private void btAddAdditionalAudioSource_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Additional_Audio_CaptureDevice_Add(cbAdditionalAudioSource.Text);
            MessageBox.Show(cbAdditionalAudioSource.Text + " added");
        }

        private void btPIPAddFileSource_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.PIP_Sources_Add_VideoFile(
                edPIPFileSoureFilename.Text,
                Convert.ToInt32(edPIPFileLeft.Text),
                Convert.ToInt32(edPIPFileTop.Text),
                Convert.ToInt32(edPIPFileWidth.Text),
                Convert.ToInt32(edPIPFileHeight.Text));
            cbPIPDevices.Items.Add("File source");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edPIPFileSoureFilename.Text = openFileDialog1.FileName;
            }
        }

        private void cbFadeInOut_Checked(object sender, RoutedEventArgs e)
        {
            if (rbFadeIn.IsChecked == true)
            {
                IVFVideoEffectFadeIn fadeIn;
                var effect = VideoCapture1.Video_Effects_Get("FadeIn");
                if (effect == null)
                {
                    fadeIn = new VFVideoEffectFadeIn(cbFadeInOut.IsChecked == true);
                    VideoCapture1.Video_Effects_Add(fadeIn);
                }
                else
                {
                    fadeIn = effect as IVFVideoEffectFadeIn;
                }

                if (fadeIn == null)
                {
                    MessageBox.Show("Unable to configure fade-in effect.");
                    return;
                }

                fadeIn.Enabled = cbFadeInOut.IsChecked == true;
                fadeIn.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeIn.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
            }
            else
            {
                IVFVideoEffectFadeOut fadeOut;
                var effect = VideoCapture1.Video_Effects_Get("FadeOut");
                if (effect == null)
                {
                    fadeOut = new VFVideoEffectFadeOut(cbFadeInOut.IsChecked == true);
                    VideoCapture1.Video_Effects_Add(fadeOut);
                }
                else
                {
                    fadeOut = effect as IVFVideoEffectFadeOut;
                }

                if (fadeOut == null)
                {
                    MessageBox.Show("Unable to configure fade-out effect.");
                    return;
                }

                fadeOut.Enabled = cbFadeInOut.IsChecked == true;
                fadeOut.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeOut.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
            }
        }

        private void label1291_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/878966-Streaming-to-Adobe-Flash-Media-Server");
            Process.Start(startInfo);
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/300487-Streaming-using-Microsoft-Expression-Encoder");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnFaceDetected(object sender, AFFaceDetectionEventArgs e)
        {
            Dispatcher.BeginInvoke(new FaceDelegate(FaceDelegateMethod), e);
        }

        public delegate void FaceDelegate(AFFaceDetectionEventArgs e);

        public void FaceDelegateMethod(AFFaceDetectionEventArgs e)
        {
            edFaceTrackingFaces.Text = string.Empty;

            foreach (var faceRectangle in e.FaceRectangles)
            {
                edFaceTrackingFaces.Text += "(" + faceRectangle.Left + ", " + faceRectangle.Top + "), ("
                                            + faceRectangle.Width + ", " + faceRectangle.Height + ")" + Environment.NewLine;
            }
        }

        private void label1291_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/240078-How-to-configure-IIS-Smooth-Streaming-in-SDK-demo-application");
            Process.Start(startInfo);
        }

        #region Full screen

        private bool fullScreen;

        private double windowLeft;

        private double windowTop;

        private double windowWidth;

        private double windowHeight;

        private double controlLeft;

        private double controlTop;

        private double controlWidth;

        private double controlHeight;

        private void btFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (!fullScreen)
            {
                // going fullscreen
                fullScreen = true;

                // saving coordinates
                windowLeft = Left;
                windowTop = Top;
                windowWidth = Width;
                windowHeight = Height;

                controlLeft = gdVideoCapture.Margin.Left;
                controlTop = gdVideoCapture.Margin.Top;
                controlWidth = gdVideoCapture.Width;
                controlHeight = gdVideoCapture.Height;

                // resizing window
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
                Topmost = true;

                Left = 0;
                Top = 0;
                Width = Screen.AllScreens[0].Bounds.Width;
                Height = Screen.AllScreens[0].Bounds.Height;
                Margin = new Thickness(0);

                // resizing control
                gdVideoCapture.Margin = new Thickness(0);
                gdVideoCapture.Width = Width + 10;
                gdVideoCapture.Height = Height + 10;

                VideoCapture1.Width = Width + 10;
                VideoCapture1.Height = Height + 10;

                VideoCapture1.RenderSize = new System.Windows.Size(Width + 10, Height + 10);

                VideoCapture1.Video_Renderer_Update();
            }
            else
            {
                // going normal screen
                fullScreen = false;

                // restoring control
                gdVideoCapture.Margin = new Thickness(controlLeft, controlTop, 0, 0);
                gdVideoCapture.Width = controlWidth;
                gdVideoCapture.Height = controlHeight;

                VideoCapture1.Width = controlWidth;
                VideoCapture1.Height = controlHeight;
                VideoCapture1.RenderSize = new System.Windows.Size(controlWidth, controlHeight);

                // restoring window
                Left = windowLeft;
                Top = windowTop;
                Width = windowWidth;
                Height = windowHeight;

                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
                Topmost = false;
                ResizeMode = ResizeMode.CanResize;

                VideoCapture1.Video_Renderer_Update();
            }
        }

        private void VideoCapture1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fullScreen)
            {
                btFullScreen_Click(null, null);
            }
        }

        #endregion

        #region VU meter Pro

        public delegate void AudioVUMeterProMaximumCalculatedDelegate(VUMeterMaxSampleEventArgs e);

        public void AudioVUMeterProMaximumCalculatedelegateMethod(VUMeterMaxSampleEventArgs e)
        {
            waveformPainter.AddValue(e.MaxSample, e.MinSample);
        }

        private void VideoCapture1_OnAudioVUMeterProMaximumCalculated(object sender, VUMeterMaxSampleEventArgs e)
        {
            Dispatcher.BeginInvoke(new AudioVUMeterProMaximumCalculatedDelegate(AudioVUMeterProMaximumCalculatedelegateMethod), e);
        }

        public delegate void AudioVUMeterProFFTCalculatedDelegate(VUMeterFFTEventArgs e);

        public void AudioVUMeterProFFTCalculatedDelegateMethod(VUMeterFFTEventArgs e)
        {
            spectrumAnalyzer.Update(e.Result);
        }

        private void VideoCapture1_OnAudioVUMeterProFFTCalculated(object sender, VUMeterFFTEventArgs e)
        {
            Dispatcher.BeginInvoke(new AudioVUMeterProFFTCalculatedDelegate(AudioVUMeterProFFTCalculatedDelegateMethod), e);
        }

        public delegate void AudioVUMeterProVolumeDelegate(AudioLevelEventArgs e);

        public void AudioVUMeterProVolumeDelegateMethod(AudioLevelEventArgs e)
        {
            volumeMeter1.Amplitude = e.ChannelLevelsDb[0];
            volumeMeter1.Update();

            if (e.ChannelLevelsDb.Length > 1)
            {
                volumeMeter2.Amplitude = e.ChannelLevelsDb[1];
                volumeMeter2.Update();
            }
        }

        private void VideoCapture1_OnAudioVUMeterProVolume(object sender, AudioLevelEventArgs e)
        {
            Dispatcher.BeginInvoke(new AudioVUMeterProVolumeDelegate(AudioVUMeterProVolumeDelegateMethod), e);
        }

        private void tbVUMeterAmplification_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 != null)
            {
                VideoCapture1.Audio_VUMeter_Pro_Volume = (int)tbVUMeterAmplification.Value;
            }
        }

        private void tbVUMeterBoost_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            volumeMeter1.Boost = (float)tbVUMeterBoost.Value / 10.0F;
            volumeMeter2.Boost = (float)tbVUMeterBoost.Value / 10.0F;
        }

        #endregion

        private void cbLiveRotation_Checked(object sender, RoutedEventArgs e)
        {
            if (VideoCapture1 != null)
            {
                IVFVideoEffectRotate rotate;
                var effect = VideoCapture1.Video_Effects_Get("Rotate");
                if (effect == null)
                {
                    rotate = new VFVideoEffectRotate(
                        cbLiveRotation.IsChecked == true,
                        tbLiveRotationAngle.Value,
                        cbLiveRotationStretch.IsChecked == true);
                    VideoCapture1.Video_Effects_Add(rotate);
                }
                else
                {
                    rotate = effect as IVFVideoEffectRotate;
                }

                if (rotate == null)
                {
                    MessageBox.Show("Unable to configure rotate effect.");
                    return;
                }

                rotate.Enabled = cbLiveRotation.IsChecked == true;
                rotate.Angle = tbLiveRotationAngle.Value;
                rotate.Stretch = cbLiveRotationStretch.IsChecked == true;
            }
        }

        private void tbLiveRotationAngle_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cbLiveRotation_Checked(sender, e);
        }

        private void cbLiveRotationStretch_Checked(object sender, RoutedEventArgs e)
        {
            cbLiveRotation_Checked(sender, e);
        }

        /// <summary>
        /// Load a resource WPF-BitmapImage (png, bmp, ...) from embedded resource defined as 'Resource' not as 'Embedded resource'.
        /// </summary>
        /// <param name="pathInApplication">Path without starting slash</param>
        /// <param name="assembly">Usually 'Assembly.GetExecutingAssembly()'. If not mentionned, I will use the calling assembly</param>
        /// <returns>Returns BitmapImage.</returns>
        public static BitmapImage LoadBitmapFromResource(string pathInApplication, Assembly assembly = null)
        {
            if (assembly == null)
            {
                assembly = Assembly.GetCallingAssembly();
            }

            if (pathInApplication[0] == '/')
            {
                pathInApplication = pathInApplication.Substring(1);
            }

            return new BitmapImage(new Uri(@"pack://application:,,,/" + assembly.GetName().Name + ";component/" + pathInApplication, UriKind.Absolute));
        }

        private void btTest_Click(object sender, RoutedEventArgs e)
        {
            gdVideoCapture.Width /= 2;
            VideoCapture1.Width = gdVideoCapture.Width;
            VideoCapture1.Height = gdVideoCapture.Height;

            VideoCapture1.RenderSize = new System.Windows.Size(gdVideoCapture.Width, gdVideoCapture.Height);

            VideoCapture1.Video_Renderer_Update();
        }

        private void cbScreenFlipVertical_Checked(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;
            VideoCapture1.Video_Renderer_Update();
        }

        private void cbScreenFlipHorizontal_Checked(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            VideoCapture1.Video_Renderer_Update();
        }

        private void cbDirect2DRotate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = ((ComboBoxItem)e.AddedItems[0]).Content.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                VideoCapture1.Video_Renderer.RotationAngle = Convert.ToInt32(name);
                VideoCapture1.Video_Renderer_Update();
            }
        }

        private void btZoomShiftUp_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftY = VideoCapture1.Video_Renderer.Zoom_ShiftY + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftRight_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftX = VideoCapture1.Video_Renderer.Zoom_ShiftX + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftLeft_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftX = VideoCapture1.Video_Renderer.Zoom_ShiftX - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftDown_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftY = VideoCapture1.Video_Renderer.Zoom_ShiftY - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomOut_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = VideoCapture1.Video_Renderer.Zoom_Ratio - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomIn_Click(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = VideoCapture1.Video_Renderer.Zoom_Ratio + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void pnVideoRendererBGColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoGradColor1.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnVideoRendererBGColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }

            VideoCapture1.Video_Renderer.BackgroundColor = colorDialog1.Color;
            VideoCapture1.Video_Renderer_Update();
        }

        private void rbVR_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDirect2D != null)
            {
                bool direct2d = rbDirect2D.IsChecked == true;
                cbScreenFlipVertical.IsEnabled = direct2d;
                cbScreenFlipHorizontal.IsEnabled = direct2d;
                cbDirect2DRotate.IsEnabled = direct2d;
                pnZoom.IsEnabled = direct2d;
            }
        }

        private void cbCustomVideoSourceCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCustomVideoSourceFilter == null)
            {
                return;
            }

            if (cbCustomVideoSourceCategory.SelectedIndex == 0)
            {
                var filters = VideoCapture1.Video_CaptureDevicesInfo;
                var list = new List<string>();
                foreach (var info in filters)
                {
                    list.Add(info.Name);    
                }

                cbCustomVideoSourceFilter.ItemsSource = list;

                if (filters.Count > 0)
                {
                    cbCustomVideoSourceFilter.SelectedIndex = 0;
                    cbCustomVideoSourceFilter_SelectionChanged(null, null);
                }
            }
            else if (cbCustomVideoSourceCategory.SelectedIndex == 1)
            {
                var filters = VideoCapture1.DirectShow_Filters;
                cbCustomVideoSourceFilter.ItemsSource = filters;

                if (filters.Count > 0)
                {
                    cbCustomVideoSourceFilter.SelectedIndex = 0;
                    cbCustomVideoSourceFilter_SelectionChanged(null, null);
                }
            }
        }

        private void cbCustomAudioSourceCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCustomAudioSourceFilter == null)
            {
                return;
            }

            cbCustomAudioSourceFilter.Items.Clear();
            cbCustomAudioSourceFilter.Items.Add(string.Empty);

            if (cbCustomAudioSourceCategory.SelectedIndex == 0)
            {
                var filters = VideoCapture1.Audio_CaptureDevicesInfo;
                foreach (var item in filters)
                {
                    cbCustomAudioSourceFilter.Items.Add(item.Name);
                }

                if (filters.Count > 0)
                {
                    cbCustomAudioSourceFilter.SelectedIndex = 0;
                }
            }
            else if (cbCustomAudioSourceCategory.SelectedIndex == 1)
            {
                var filters = VideoCapture1.DirectShow_Filters;
                foreach (var item in filters)
                {
                    cbCustomAudioSourceFilter.Items.Add(item);
                }

                if (filters.Count > 0)
                {
                    cbCustomAudioSourceFilter.SelectedIndex = 0;
                }
            }
        }

        private void cbCustomVideoSourceFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = string.Empty;
            if (cbCustomVideoSourceFilter.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                value = e.AddedItems[0].ToString();
            }

            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            List<string> formats;
            List<string> frameRates;

            if (cbCustomVideoSourceCategory.SelectedIndex == 0)
            {
                VideoCapture1.DirectShow_Filter_GetFormats(
                    VFFilterCategory.VideoCaptureSource,
                    value,
                    VFMediaCategory.Video,
                    out formats,
                    out frameRates);
            }
            else
            {
                VideoCapture1.DirectShow_Filter_GetFormats(
                    VFFilterCategory.DirectShowFilters,
                    value,
                    VFMediaCategory.Video,
                    out formats,
                    out frameRates);
            }

            cbCustomVideoSourceFormat.ItemsSource = formats;
            cbCustomVideoSourceFrameRate.ItemsSource = frameRates;
        }

        private void cbCustomAudioSourceFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = string.Empty;
            if (cbCustomAudioSourceFilter.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                value = e.AddedItems[0].ToString();
            }

            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            cbCustomAudioSourceFormat.Items.Clear();

            List<string> formats;
            List<string> frameRates;

            if (cbCustomAudioSourceCategory.SelectedIndex == 0)
            {
                VideoCapture1.DirectShow_Filter_GetFormats(
                    VFFilterCategory.AudioCaptureSource,
                    value,
                    VFMediaCategory.Audio,
                    out formats,
                    out frameRates);
            }
            else
            {
                VideoCapture1.DirectShow_Filter_GetFormats(
                    VFFilterCategory.DirectShowFilters,
                    value,
                    VFMediaCategory.Audio,
                    out formats,
                    out frameRates);
            }

            foreach (var format in formats)
            {
                cbCustomAudioSourceFormat.Items.Add(format);
            }
        }

        private void cbAudioNormalize_Checked(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Enhancer_Normalize(cbAudioNormalize.IsChecked == true);
        }

        private void cbAudioAutoGain_Checked(object sender, RoutedEventArgs e)
        {
            VideoCapture1.Audio_Enhancer_AutoGain(cbAudioAutoGain.IsChecked == true);
        }

        private void ApplyAudioInputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = (float)tbAudioInputGainL.Value / 10.0f,
                C = (float)tbAudioInputGainC.Value / 10.0f,
                R = (float)tbAudioInputGainR.Value / 10.0f,
                SL = (float)tbAudioInputGainSL.Value / 10.0f,
                SR = (float)tbAudioInputGainSR.Value / 10.0f,
                LFE = (float)tbAudioInputGainLFE.Value / 10.0f
            };

            VideoCapture1.Audio_Enhancer_InputGains(gains);
        }

        private void tbAudioInputGainL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainL.Content = (tbAudioInputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainC_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainC.Content = (tbAudioInputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainR.Content = (tbAudioInputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainSL.Content = (tbAudioInputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainSR.Content = (tbAudioInputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainLFE_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainLFE.Content = (tbAudioInputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void ApplyAudioOutputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = (float)tbAudioOutputGainL.Value / 10.0f,
                C = (float)tbAudioOutputGainC.Value / 10.0f,
                R = (float)tbAudioOutputGainR.Value / 10.0f,
                SL = (float)tbAudioOutputGainSL.Value / 10.0f,
                SR = (float)tbAudioOutputGainSR.Value / 10.0f,
                LFE = (float)tbAudioOutputGainLFE.Value / 10.0f
            };

            VideoCapture1.Audio_Enhancer_OutputGains(gains);
        }

        private void tbAudioOutputGainL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainL.Content = (tbAudioOutputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainC_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainC.Content = (tbAudioOutputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainR.Content = (tbAudioOutputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainSL.Content = (tbAudioOutputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainSR.Content = (tbAudioOutputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainLFE_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainLFE.Content = (tbAudioOutputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioTimeshift_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioTimeshift.Content = tbAudioTimeshift.Value.ToString(CultureInfo.InvariantCulture) + " ms";

            VideoCapture1.Audio_Enhancer_Timeshift((int)tbAudioTimeshift.Value);
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)(() =>
               {
                   if (cbLicensing.IsChecked == true)
                   {
                       mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
                   }
               }));
        }

        private void FFEXEDisableVideoMode()
        {
            rbFFEXEVideoModeABR.IsEnabled = false;
            rbFFEXEVideoModeABR.IsChecked = false;
            rbFFEXEVideoModeCBR.IsEnabled = false;
            rbFFEXEVideoModeCBR.IsChecked = false;
            rbFFEXEVideoModeQuality.IsEnabled = false;
            rbFFEXEVideoModeQuality.IsChecked = false;

            tbFFEXEVideoQuality.IsEnabled = false;
            edFFEXEVideoTargetBitrate.IsEnabled = false;
            edFFEXEVideoBitrateMax.IsEnabled = false;
            edFFEXEVideoBitrateMin.IsEnabled = false;
        }

        private void FFEXEEnableVideoCBR()
        {
            rbFFEXEVideoModeCBR.IsEnabled = true;
            rbFFEXEVideoModeCBR.IsChecked = true;

            edFFEXEVideoTargetBitrate.IsEnabled = true;
        }

        private void FFEXEEnableVideoABR()
        {
            rbFFEXEVideoModeABR.IsEnabled = true;
            rbFFEXEVideoModeABR.IsChecked = true;

            edFFEXEVideoTargetBitrate.IsEnabled = true;
            edFFEXEVideoBitrateMax.IsEnabled = true;
            edFFEXEVideoBitrateMin.IsEnabled = true;
        }

        private void FFEXEEnableVideoQuality()
        {
            rbFFEXEVideoModeQuality.IsEnabled = true;
            rbFFEXEVideoModeQuality.IsChecked = true;

            tbFFEXEVideoQuality.IsEnabled = true;
        }

        private void cbFFEXEProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbFFEXEProfile.SelectedIndex)
            {
                // MPEG-1
                case 0:
                    cbFFEXEOutputFormat.SelectedIndex = 23;

                    cbFFEXEVideoCodec.SelectedIndex = 12;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // MPEG-1 VCD
                case 1:
                    cbFFEXEOutputFormat.SelectedIndex = 34;

                    cbFFEXEVideoCodec.SelectedIndex = 12;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);

                    break;

                // MPEG-2
                case 2:
                    cbFFEXEOutputFormat.SelectedIndex = 23;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // MPEG-2 SVCD
                case 3:
                    cbFFEXEOutputFormat.SelectedIndex = 30;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);

                    break;

                // MPEG-2 DVD
                case 4:
                    cbFFEXEOutputFormat.SelectedIndex = 7;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);

                    break;

                // MPEG-2 TS
                case 5:
                    cbFFEXEOutputFormat.SelectedIndex = 24;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);

                    break;

                // Flash Video (FLV)
                case 6:
                    cbFFEXEOutputFormat.SelectedIndex = 11;

                    cbFFEXEVideoCodec.SelectedIndex = 5;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // MP4 H264 / AAC
                case 7:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 5;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // MP4 HEVC / AAC
                case 8:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 6;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // WebM
                case 9:
                    cbFFEXEOutputFormat.SelectedIndex = 36;

                    cbFFEXEVideoCodec.SelectedIndex = 17;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // AVI
                case 10:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // OGG Vorbis
                case 11:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // Opus
                case 12:
                    cbFFEXEOutputFormat.SelectedIndex = 27;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 14;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // Speex
                case 13:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 40;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // FLAC
                case 14:
                    cbFFEXEOutputFormat.SelectedIndex = 10;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 10;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // MP3
                case 15:
                    cbFFEXEOutputFormat.SelectedIndex = 21;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;

                // DV
                case 16:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 1;
                    cbFFEXEAudioCodec.SelectedIndex = 23;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);

                    cbFFEXEAudioChannels.SelectedIndex = 1;
                    cbFFEXEAudioSampleRate.SelectedIndex = 1;
                    break;

                // Custom
                case 17:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectionChanged(null, null);
                    cbFFEXEAudioCodec_SelectionChanged(null, null);
                    break;
            }
        }

        private void tbFFEXEVideoQuality_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbFFEXEVideoQuality != null)
            {
                lbFFEXEVideoQuality.Content = ((int)tbFFEXEVideoQuality.Value).ToString();
            }
        }

        private void FFEXEDisableAudioMode()
        {
            rbFFEXEAudioModeABR.IsEnabled = false;
            rbFFEXEAudioModeABR.IsChecked = false;
            rbFFEXEAudioModeCBR.IsEnabled = false;
            rbFFEXEAudioModeCBR.IsChecked = false;
            rbFFEXEAudioModeQuality.IsEnabled = false;
            rbFFEXEAudioModeQuality.IsChecked = false;
            rbFFEXEAudioModeLossless.IsEnabled = false;
            rbFFEXEAudioModeLossless.IsChecked = false;

            tbFFEXEAudioQuality.IsEnabled = false;
            cbFFEXEAudioBitrate.IsEnabled = false;
        }

        private void FFEXEEnableAudioCBR()
        {
            rbFFEXEAudioModeCBR.IsEnabled = true;
            rbFFEXEAudioModeCBR.IsChecked = true;

            cbFFEXEAudioBitrate.IsEnabled = true;
        }

        // private void FFEXEEnableAudioABR()
        // {
        //    rbFFEXEAudioModeABR.IsEnabled = true;
        //    rbFFEXEAudioModeABR.IsChecked = true;
        //    // edFFEXEAudioTargetBitrate.Enabled = true;
        //    // edFFEXEAudioBitrateMax.Enabled = true;
        //    // edFFEXEAudioBitrateMin.Enabled = true;
        // }

        private void FFEXEEnableAudioQuality()
        {
            rbFFEXEAudioModeQuality.IsEnabled = true;
            rbFFEXEAudioModeQuality.IsChecked = true;

            tbFFEXEAudioQuality.IsEnabled = true;
        }

        private void FFEXEEnableAudioLossless()
        {
            rbFFEXEAudioModeLossless.IsEnabled = true;
            rbFFEXEAudioModeLossless.IsChecked = true;

            // tbFFEXEAudioQuality.Enabled = true;
        }

        private void cbFFEXEAudioCodec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FFEXEDisableAudioMode();
            lbFFEXEAudioNotes.Content = "Notes: None.";

            switch (cbFFEXEAudioCodec.SelectedIndex)
            {
                // Auto / None
                case 0:
                    {
                    }

                    break;

                // AAC
                case 1:
                    {
                        FFEXEEnableAudioCBR();
                    }

                    break;

                // AC3
                case 2:
                    {
                        FFEXEEnableAudioCBR();
                    }

                    break;

                // G722
                case 3:
                    {
                    }

                    break;

                // G726
                case 4:
                    {
                    }

                    break;

                // ADPCM
                case 5:
                    {
                    }

                    break;

                // ALAC
                case 6:
                    {
                        FFEXEEnableAudioCBR();
                        FFEXEEnableAudioLossless();
                    }

                    break;

                // AMR-NB
                case 7:
                    {
                    }

                    break;

                // AMR-WB
                case 8:
                    {
                    }

                    break;

                // E-AC3
                case 9:
                    {
                        FFEXEEnableAudioCBR();
                    }

                    break;

                // FLAC
                case 10:
                    {
                        lbFFEXEAudioNotes.Content = "Notes: Use Quality mode, trackbar set compression level (0-12, .";

                        FFEXEEnableAudioQuality();

                        tbFFEXEAudioQuality.Minimum = 0;
                        tbFFEXEAudioQuality.Maximum = 12;
                        tbFFEXEAudioQuality.Value = 5;
                        lbFFEXEAudioQuality.Content = ((int)tbFFEXEAudioQuality.Value).ToString();
                    }

                    break;

                // G723
                case 11:
                    {
                    }

                    break;

                // MP2
                case 12:
                    {
                        FFEXEEnableAudioQuality();
                        FFEXEEnableAudioCBR();

                        tbFFEXEAudioQuality.Minimum = 0;
                        tbFFEXEAudioQuality.Maximum = 9;
                        tbFFEXEAudioQuality.Value = 0;
                        lbFFEXEAudioQuality.Content = ((int)tbFFEXEAudioQuality.Value).ToString();
                    }

                    break;

                // MP3
                case 13:
                    {
                        FFEXEEnableAudioQuality();
                        FFEXEEnableAudioCBR();

                        tbFFEXEAudioQuality.Minimum = 0;
                        tbFFEXEAudioQuality.Maximum = 9;
                        tbFFEXEAudioQuality.Value = 4;
                        lbFFEXEAudioQuality.Content = ((int)tbFFEXEAudioQuality.Value).ToString();
                    }

                    break;

                // OPUS
                case 14:
                    {
                        FFEXEEnableAudioCBR();
                    }

                    break;

                // PCM ALAW
                case 15:
                    {
                    }

                    break;

                // PCM F32BE
                case 16:
                    {
                    }

                    break;

                // PCM F32LE
                case 17:
                    {
                    }

                    break;

                // PCM F64BE
                case 18:
                    {
                    }

                    break;

                // PCM F64LE
                case 19:
                    {
                    }

                    break;

                // PCM MULAW
                case 20:
                    {
                    }

                    break;

                // PCM S16BE
                case 21:
                    {
                    }

                    break;

                // PCM S16BE Planar
                case 22:
                    {
                    }

                    break;

                // PCM S16LE
                case 23:
                    {
                    }

                    break;

                // PCM S16LE Planar
                case 24:
                    {
                    }

                    break;

                // PCM S24BE
                case 25:
                    {
                    }

                    break;

                // PCM S24LE
                case 26:
                    {
                    }

                    break;

                // PCM S24LE Planar
                case 27:
                    {
                    }

                    break;

                // PCM S32BE
                case 28:
                    {
                    }

                    break;

                // PCM S32LE
                case 29:
                    {
                    }

                    break;

                // PCM S32LE Planar
                case 30:
                    {
                    }

                    break;

                // PCM S8
                case 31:
                    {
                    }

                    break;

                // PCM S8 Planar
                case 32:
                    {
                    }

                    break;

                // PCM U16BE
                case 33:
                    {
                    }

                    break;

                // PCM U16LE
                case 34:
                    {
                    }

                    break;

                // PCM U24BE
                case 35:
                    {
                    }

                    break;

                // PCM U24LE
                case 36:
                    {
                    }

                    break;

                // PCM U32BE     
                case 37:
                    {
                    }

                    break;

                // PCM U32LE
                case 38:
                    {
                    }

                    break;

                // PCM U8
                case 39:
                    {
                    }

                    break;

                // Speex
                case 40:
                    {
                        FFEXEEnableAudioQuality();
                        FFEXEEnableAudioCBR();

                        tbFFEXEAudioQuality.Minimum = 0;
                        tbFFEXEAudioQuality.Maximum = 10;
                        tbFFEXEAudioQuality.Value = 5;
                        tbFFEXEAudioQuality_ValueChanged(null, null);
                    }

                    break;

                // Vorbis
                case 41:
                    {
                        FFEXEEnableAudioQuality();
                        FFEXEEnableAudioCBR();

                        tbFFEXEAudioQuality.Minimum = -1;
                        tbFFEXEAudioQuality.Maximum = 10;
                        tbFFEXEAudioQuality.Value = 5;
                        tbFFEXEAudioQuality_ValueChanged(null, null);
                    }

                    break;

                // WavPack
                case 42:
                    {
                    }

                    break;
            }
        }

        private void tbFFEXEAudioQuality_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbFFEXEAudioQuality != null)
            {
                lbFFEXEAudioQuality.Content = ((int)tbFFEXEAudioQuality.Value).ToString();
            }
        }

        private void cbFFEXEVideoCodec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            edFFEXEVBVBufferSize.Text = "0";
            edFFEXEVideoGOPSize.Text = "0";
            edFFEXEVideoBFramesCount.Text = "0";
            tbFFEXEVideoQuality.Minimum = 1;
            tbFFEXEVideoQuality.Maximum = 31;

            lbFFEXEVideoNotes.Content = "Notes: None.";

            FFEXEDisableVideoMode();

            switch (cbFFEXEVideoCodec.SelectedIndex)
            {
                // Auto / None
                case 0:
                    {
                        FFEXEEnableVideoABR();
                        FFEXEEnableVideoQuality();
                    }

                    break;

                // DV
                case 1:
                    {
                        lbFFEXEVideoNotes.Content = "Notes: Specify constraint settings for PAL or NTSC DV output.";
                        cbFFEXEVideoConstraint.SelectedIndex = 1;
                    }

                    break;

                // FLV1
                case 2:
                    {
                        FFEXEEnableVideoCBR();
                        FFEXEEnableVideoQuality();
                    }

                    break;

                // GIF
                case 3:
                    {
                    }

                    break;

                // H263
                case 4:
                    {
                    }

                    break;

                // H264
                case 5:
                    {
                        cbFFEXEH264Mode.SelectedIndex = 0;
                        cbFFEXEH264Level.SelectedIndex = 0;
                        cbFFEXEH264Preset.SelectedIndex = 0;
                        cbFFEXEH264Profile.SelectedIndex = 0;
                        tbFFEXEH264Quantizer.Value = 23;
                        cbFFEXEH264QuickTimeCompatibility.IsChecked = true;
                        cbFFEXEH264ZeroTolerance.IsChecked = false;
                        cbFFEXEH264WebFastStart.IsChecked = false;
                    }

                    break;

                // HEVC
                case 6:
                    {
                        cbFFEXEH264Mode.SelectedIndex = 0;
                        cbFFEXEH264Level.SelectedIndex = 0;
                        cbFFEXEH264Preset.SelectedIndex = 0;
                        cbFFEXEH264Profile.SelectedIndex = 0;
                        tbFFEXEH264Quantizer.Value = 23;
                        cbFFEXEH264QuickTimeCompatibility.IsChecked = true;
                        cbFFEXEH264ZeroTolerance.IsChecked = false;
                        cbFFEXEH264WebFastStart.IsChecked = false;
                    }

                    break;

                // HuffYUV
                case 7:
                    {
                    }

                    break;

                // JPEG 2000
                case 8:
                    {
                    }

                    break;

                // JPEG-LS
                case 9:
                    {
                    }

                    break;

                // LJPEG
                case 10:
                    {
                    }

                    break;

                // MJPEG
                case 11:
                    {
                        FFEXEEnableVideoQuality();

                        tbFFEXEVideoQuality.Value = 4;
                        tbFFEXEVideoQuality_ValueChanged(null, null);
                    }

                    break;

                // MPEG-1
                case 12:
                    {
                        FFEXEEnableVideoCBR();

                        edFFEXEVideoBitrateMin.Text = "1000";
                        edFFEXEVideoBitrateMax.Text = "2000";
                        edFFEXEVideoTargetBitrate.Text = "1800";
                    }

                    break;

                // MPEG-2
                case 13:
                    {
                        FFEXEEnableVideoCBR();

                        edFFEXEVideoBitrateMin.Text = "2000";
                        edFFEXEVideoBitrateMax.Text = "5000";
                        edFFEXEVideoTargetBitrate.Text = "4000";

                        edFFEXEVideoGOPSize.Text = "45";
                        edFFEXEVideoBFramesCount.Text = "2";
                    }

                    break;

                // MPEG-4
                case 14:
                    {
                        FFEXEEnableVideoCBR();

                        edFFEXEVideoBitrateMin.Text = "2000";
                        edFFEXEVideoBitrateMax.Text = "5000";
                        edFFEXEVideoTargetBitrate.Text = "4000";
                    }

                    break;

                // PNG
                case 15:
                    {
                    }

                    break;

                // Theora
                case 16:
                    {
                        FFEXEEnableVideoQuality();

                        tbFFEXEVideoQuality.Minimum = 0;
                        tbFFEXEVideoQuality.Maximum = 10;
                        tbFFEXEVideoQuality.Value = 7;
                        tbFFEXEVideoQuality_ValueChanged(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;

                // VP8
                case 17:
                    {
                        FFEXEEnableVideoQuality();
                        FFEXEEnableVideoCBR();

                        tbFFEXEVideoQuality.Minimum = 4;
                        tbFFEXEVideoQuality.Maximum = 63;
                        tbFFEXEVideoQuality.Value = 10;
                        tbFFEXEVideoQuality_ValueChanged(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;

                // VP9   
                case 18:
                    {
                        FFEXEEnableVideoQuality();
                        FFEXEEnableVideoCBR();

                        tbFFEXEVideoQuality.Minimum = 4;
                        tbFFEXEVideoQuality.Maximum = 63;
                        tbFFEXEVideoQuality.Value = 10;
                        tbFFEXEVideoQuality_ValueChanged(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;
            }
        }

        private void tbFFEXEH264Quantizer_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbFFEXEH264Quantizer != null)
            {
                lbFFEXEH264Quantizer.Content = ((int)tbFFEXEH264Quantizer.Value).ToString();
            }
        }

        public delegate void FFMPEGInfoDelegate(string message);

        public void FFMPEGInfoDelegateMethod(string message)
        {
            // if (VideoCapture1.Debug_Mode)
            // {

            mmLog.Text += "(NOT ERROR) FFMPEG " + message + Environment.NewLine;

            // }
        }

        private void VideoCapture1_OnFFMPEGInfo(object sender, FFMPEGInfoEventArgs e)
        {
            Dispatcher.BeginInvoke(new FFMPEGInfoDelegate(FFMPEGInfoDelegateMethod), e.Message);
        }

        private void btEncryptionOpenFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edEncryptionKeyFile.Text = openFileDialog1.FileName;
            }
        }

        private void cbFFEXEH264Mode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FFEXEDisableVideoMode();

            switch (cbFFEXEH264Mode.SelectedIndex)
            {
                case 0:
                    // CRF
                    break;
                case 1:
                    // CRF (limited bitrate)
                    FFEXEEnableVideoCBR();
                    break;
                case 2:
                    // CBR
                    FFEXEEnableVideoCBR();
                    break;
                case 3:
                    // ABR
                    FFEXEEnableVideoABR();
                    break;
                case 4:
                    // Lossless
                    break;
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem");
            Process.Start(startInfo);
        }

        private void imgTagCover_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (openFileDialog2.ShowDialog() == true)
            {
                imgTagCover.Source = new BitmapImage(new Uri(openFileDialog2.FileName));
                imgTagCover.Tag = openFileDialog2.FileName;
            }
        }

        private void lbDownloadFFMPEG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_ffmpeg_exe_x86_x64.exe");
            Process.Start(startInfo);
        }

        private void cbDecklinkCaptureDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value;
            if (cbDecklinkCaptureDevice.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                value = e.AddedItems[0].ToString();
            }
            else
            {
                return;
            }

            cbDecklinkCaptureVideoFormat.Items.Clear();

            var deviceItem = VideoCapture1.Decklink_CaptureDevices.First(device => device.Name == value);
            if (deviceItem != null)
            {
                foreach (var format in deviceItem.VideoFormats)
                {
                    cbDecklinkCaptureVideoFormat.Items.Add(format.Name);
                }

                if (cbDecklinkCaptureVideoFormat.Items.Count == 0)
                {
                    cbDecklinkCaptureVideoFormat.Items.Add("No input connected");
                }

                cbDecklinkCaptureVideoFormat.SelectedIndex = 0;

                // cbVideoInputFormat_SelectedIndexChanged(null, null);
            }
        }

        private void btAudioChannelMapperClear_Click(object sender, RoutedEventArgs e)
        {
            audioChannelMapperItems.Clear();
            lbAudioChannelMapperRoutes.Items.Clear();
        }

        private void btAudioChannelMapperAddNewRoute_Click(object sender, RoutedEventArgs e)
        {
            var item = new AudioChannelMapperItem
                           {
                               SourceChannel = Convert.ToInt32(this.edAudioChannelMapperSourceChannel.Text),
                               TargetChannel = Convert.ToInt32(this.edAudioChannelMapperTargetChannel.Text),
                               TargetChannelVolume = (float)this.tbAudioChannelMapperVolume.Value / 1000.0f
                           };

            audioChannelMapperItems.Add(item);

            lbAudioChannelMapperRoutes.Items.Add(
                "Source: " + edAudioChannelMapperSourceChannel.Text + ", target: "
                + edAudioChannelMapperTargetChannel.Text + ", volume: "
                + (tbAudioChannelMapperVolume.Value / 1000.0f).ToString("F2"));
        }

        private void lbDownloadFFMPEG_Copy3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge.com/support/577349-Network-streaming-to-YouTube");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnNetworkSourceDisconnect(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(new NetworkStopDelegate(NetworkStopDelegateMethod));
        }

        public delegate void NetworkStopDelegate();

        public void NetworkStopDelegateMethod()
        {
            VideoCapture1.Stop();

            MessageBox.Show("Network source stopped or disconnected!");
        }

        private void tpNVENC_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (lbNVENCStatus.Tag.ToString() == "0")
            {
                lbNVENCStatus.Tag = 1;

                NVENCErrorCode errorCode;
                bool res = VideoCapture.Filter_Supported_NVENC(out errorCode);

                if (res)
                {
                    lbNVENCStatus.Content = "Available";
                }
                else
                {
                    lbNVENCStatus.Content = "Not available. Error code: " + errorCode;
                }
            }
        }

        private void tbGPULightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFGPUVideoEffectBrightness intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Brightness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBrightness(true, (int)tbGPULightness.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBrightness;
                if (intf != null)
                {
                    intf.Value = (int)tbGPULightness.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUSaturation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFGPUVideoEffectSaturation intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Saturation");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectSaturation(true, (int)tbGPUSaturation.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectSaturation;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUSaturation.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUContrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFGPUVideoEffectContrast intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Contrast");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectContrast(true, (int)tbGPUContrast.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as VFGPUVideoEffectContrast;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUContrast.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUDarkness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoCapture1 == null)
            {
                return;
            }

            IVFGPUVideoEffectDarkness intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Darkness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDarkness(true, (int)tbGPUDarkness.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDarkness;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUDarkness.Value;
                    intf.Update();
                }
            }
        }

        private void cbGPUGreyscale_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectGrayscale intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Grayscale");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectGrayscale(cbGPUGreyscale.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectGrayscale;
                if (intf != null)
                {
                    intf.Enabled = cbGPUGreyscale.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUInvert_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectInvert intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Invert");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectInvert(cbGPUInvert.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectInvert;
                if (intf != null)
                {
                    intf.Enabled = cbGPUInvert.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUNightVision_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectNightVision intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("NightVision");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectNightVision(cbGPUNightVision.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectNightVision;
                if (intf != null)
                {
                    intf.Enabled = cbGPUNightVision.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUPixelate_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectPixelate intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Pixelate");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectPixelate(cbGPUPixelate.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectPixelate;
                if (intf != null)
                {
                    intf.Enabled = cbGPUPixelate.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUDenoise_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectDenoise intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Denoise");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDenoise(cbGPUDenoise.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDenoise;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDenoise.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUDeinterlace_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectDeinterlaceBlend intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("DeinterlaceBlend");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDeinterlaceBlend;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDeinterlace.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUBlur_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectBlur intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Blur");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBlur(cbGPUBlur.IsChecked == true, 50);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBlur;
                if (intf != null)
                {
                    intf.Enabled = cbGPUBlur.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUOldMovie_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectOldMovie intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("OldMovie");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectOldMovie(cbGPUOldMovie.IsChecked == true);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectOldMovie;
                if (intf != null)
                {
                    intf.Enabled = cbGPUOldMovie.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void btShowIPCamDatabase_Click(object sender, RoutedEventArgs e)
        {
            IPCameraDB.ShowWindow();
        }


        private void btONVIFConnect_Click(object sender, RoutedEventArgs e)
        {
            if (btONVIFConnect.Content.ToString() == "Connect")
            {
                btONVIFConnect.Content = "Disconnect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }

                if (string.IsNullOrEmpty(edIPLogin.Text) || string.IsNullOrEmpty(this.edIPPassword.Text))
                {
                    MessageBox.Show("Please specify IP camera user name and password.");
                    return;
                }

                onvifControl = new ONVIFControl();
                var result = onvifControl.Connect(edIPUrl.Text, edIPLogin.Text, edIPPassword.Text);
                if (!result)
                {
                    onvifControl = null;
                    MessageBox.Show("Unable to connect to ONVIF camera.");
                    return;
                }

                var deviceInfo = onvifControl.GetDeviceInformation();
                lbONVIFCameraInfo.Content = $"Model {deviceInfo.Model}, Firmware {deviceInfo.Firmware}";

                cbONVIFProfile.Items.Clear();
                var profiles = onvifControl.GetProfiles();
                foreach (var profile in profiles)
                {
                    cbONVIFProfile.Items.Add($"{profile.Name}");
                }

                if (cbONVIFProfile.Items.Count > 0)
                {
                    cbONVIFProfile.SelectedIndex = 0;
                }

                onvifPtzRanges = onvifControl.PTZ_GetRanges();
                onvifControl.PTZ_SetAbsolute(0, 0, 0);

                onvifPtzX = 0;
                onvifPtzY = 0;
                onvifPtzZoom = 0;
            }
            else
            {
                btONVIFConnect.Content = "Connect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }
            }
        }

        private void btONVIFRight_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30;
            onvifPtzX = onvifPtzX - step;

            if (onvifPtzX < onvifPtzRanges.MinX)
            {
                onvifPtzX = onvifPtzRanges.MinX;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFPTZSetDefault_Click(object sender, RoutedEventArgs e)
        {
            onvifControl?.PTZ_SetAbsolute(0, 0, 0);
        }

        private void btONVIFLeft_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30;
            onvifPtzX = onvifPtzX + step;

            if (onvifPtzX > onvifPtzRanges.MaxX)
            {
                onvifPtzX = onvifPtzRanges.MaxX;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFUp_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30;
            onvifPtzY = onvifPtzY - step;

            if (onvifPtzY < onvifPtzRanges.MinY)
            {
                onvifPtzY = onvifPtzRanges.MinY;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFDown_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30;
            onvifPtzY = onvifPtzY + step;

            if (onvifPtzY > onvifPtzRanges.MaxY)
            {
                onvifPtzY = onvifPtzRanges.MaxY;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFZoomIn_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100;
            onvifPtzZoom = onvifPtzZoom + step;

            if (onvifPtzZoom > onvifPtzRanges.MaxZoom)
            {
                onvifPtzZoom = onvifPtzRanges.MaxZoom;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void btONVIFZoomOut_Click(object sender, RoutedEventArgs e)
        {
            if (onvifControl == null || onvifPtzRanges == null)
            {
                return;
            }

            float step = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100;
            onvifPtzZoom = onvifPtzZoom - step;

            if (onvifPtzZoom < onvifPtzRanges.MinZoom)
            {
                onvifPtzZoom = onvifPtzRanges.MinZoom;
            }

            onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom);
        }

        private void pnPIPChromaKeyColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnPIPChromaKeyColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnPIPChromaKeyColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
        }

        private void tbPIPChromaKeyTolerance1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbPIPChromaKeyTolerance1.Content = tbPIPChromaKeyTolerance1.Value.ToString();
        }

        private void tbPIPChromaKeyTolerance2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbPIPChromaKeyTolerance2.Content = tbPIPChromaKeyTolerance2.Value.ToString();
        }
    }
}

 // ReSharper restore InconsistentNaming