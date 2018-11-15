// ReSharper disable InconsistentNaming
// ReSharper disable StyleCop.SA1600
// ReSharper disable UnusedParameter.Local

using System.Drawing.Imaging;
using VisioForge.MediaFramework.MFP;

namespace VideoCapture_CSharp_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.GPUVideoEffects;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.Sources;
    using VisioForge.Types.VideoEffects;

    using VFM4AOutput = VisioForge.Types.OutputFormat.VFM4AOutput;

    using VisioForge.Shared.IPCameraDB;
    using VisioForge.Tools;

    /// <summary>
    /// Main form.
    /// </summary>
    public partial class Form1 : Form
    {
        private FiltersAvailableInfo filtersAvailableInfo;

        private ONVIFControl onvifControl;

        private ONVIFPTZRanges onvifPtzRanges;

        private float onvifPtzX;

        private float onvifPtzY;

        private float onvifPtzZoom;

        private List<AudioChannelMapperItem> audioChannelMapperItems;

        // Zoom
        private double zoom = 1.0;

        private int zoomShiftX;

        private int zoomShiftY;

        private List<Form> multiscreenWindows = new List<Form>();

        // ReSharper disable InconsistentNaming

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsWindows8OrNewer()
        {
            var os = Environment.OSVersion;
            return os.Platform == PlatformID.Win32NT &&
                   (os.Version.Major > 6 || (os.Version.Major == 6 && os.Version.Minor >= 2));
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

        /// <summary>
        /// Adds audio effects.
        /// </summary>
        private void AddAudioEffects()
        {
            VideoCapture1.Audio_Effects_Clear(-1);

            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1);
        }

        /// <summary>
        /// Fills FFMPEG EXE settings.
        /// </summary>
        /// <param name="ffmpegOutput">
        /// FFMPEG settings.
        /// </param>
        private void SetFFMPEGEXESettings(ref VFFFMPEGEXEOutput ffmpegOutput)
        {
            ffmpegOutput.Custom_AdditionalAudioArgs = edFFEXECustomParametersAudio.Text;
            ffmpegOutput.Custom_AdditionalVideoArgs = edFFEXECustomParametersVideo.Text;

            if (cbFFEXEUseOnlyAdditionalParameters.Checked)
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
                    // H264 QSV
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.H264_QSV;
                    break;
                case 7:
                    // HEVC
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HEVC;
                    break;
                case 8:
                    // HEVC QSV
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HEVC_QSV;
                    break;
                case 9:
                    // HuffYUV
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HuffYUV;
                    break;
                case 10:
                    // JPEG 2000
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEG2000;
                    break;
                case 11:
                    // JPEG-LS
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEGLS;
                    break;
                case 12:
                    // LJPEG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.LJPEG;
                    break;
                case 13:
                    // MJPEG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MJPEG;
                    break;
                case 14:
                    // MPEG-1
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG1Video;
                    break;
                case 15:
                    // MPEG-2
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG2Video;
                    break;
                case 16:
                    // MPEG-4
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG4;
                    break;
                case 17:
                    // PNG
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.PNG;
                    break;
                case 18:
                    // Theora
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.Theora;
                    break;
                case 19:
                    // VP8
                    ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.VP8;
                    break;
                case 20:
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

            if (cbFFEXEVideoResolutionOriginal.Checked)
            {
                ffmpegOutput.Video_Width = 0;
                ffmpegOutput.Video_Height = 0;
            }
            else
            {
                ffmpegOutput.Video_Width = Convert.ToInt32(edFFEXEVideoWidth.Text);
                ffmpegOutput.Video_Height = Convert.ToInt32(edFFEXEVideoHeight.Text);
            }

            if (rbFFEXEVideoModeCBR.Checked)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.CBR;
            }
            else if (rbFFEXEVideoModeQuality.Checked)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.Quality;
            }
            else if (rbFFEXEVideoModeABR.Checked)
            {
                ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.ABR;
            }

            ffmpegOutput.Video_Bitrate = Convert.ToInt32(edFFEXEVideoTargetBitrate.Text) * 1000;
            ffmpegOutput.Video_MaxBitrate = Convert.ToInt32(edFFEXEVideoBitrateMax.Text) * 1000;
            ffmpegOutput.Video_MinBitrate = Convert.ToInt32(edFFEXEVideoBitrateMin.Text) * 1000;
            ffmpegOutput.Video_BufferSize = Convert.ToInt32(edFFEXEVBVBufferSize.Text);
            ffmpegOutput.Video_GOPSize = Convert.ToInt32(edFFEXEVideoGOPSize.Text);
            ffmpegOutput.Video_BFrames = Convert.ToInt32(edFFEXEVideoBFramesCount.Text);
            ffmpegOutput.Video_Interlace = cbFFEXEVideoInterlace.Checked;
            ffmpegOutput.Video_Letterbox = cbFFEXEVideoResolutionLetterbox.Checked;
            ffmpegOutput.Video_Quality = tbFFEXEVideoQuality.Value;

            ffmpegOutput.Video_H264_Quantizer = tbFFEXEH264Quantizer.Value;
            ffmpegOutput.Video_H264_Mode = (VFFFMPEGEXEH264Mode)cbFFEXEH264Mode.SelectedIndex;
            ffmpegOutput.Video_H264_Preset = (VFFFMPEGEXEH264Preset)cbFFEXEH264Preset.SelectedIndex;
            ffmpegOutput.Video_H264_Profile = (VFFFMPEGEXEH264Profile)cbFFEXEH264Profile.SelectedIndex;
            ffmpegOutput.Video_H264_QuickTime_Compatibility = cbFFEXEH264QuickTimeCompatibility.Checked;
            ffmpegOutput.Video_H264_ZeroTolerance = cbFFEXEH264ZeroTolerance.Checked;
            ffmpegOutput.Video_H264_WebFastStart = cbFFEXEH264WebFastStart.Checked;
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

            ffmpegOutput.Audio_Quality = tbFFEXEAudioQuality.Value;

            if (rbFFEXEAudioModeCBR.Checked)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.CBR;
            }
            else if (rbFFEXEAudioModeQuality.Checked)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Quality;
            }
            else if (rbFFEXEAudioModeABR.Checked)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.ABR;
            }
            else if (rbFFEXEAudioModeLossless.Checked)
            {
                ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Lossless;
            }
        }

        /// <summary>
        /// Fills WMV settings.
        /// </summary>
        /// <param name="wmvOutput">
        /// WMV settings.
        /// </param>
        private void FillWMVSettings(ref VFWMVOutput wmvOutput)
        {
            if (rbWMVInternal9.Checked)
            {
                wmvOutput.Mode = VFWMVMode.InternalProfile;

                if (cbWMVInternalProfile9.SelectedIndex != -1)
                {
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text;
                }
            }
            else if (rbWMVInternal8.Checked)
            {
                wmvOutput.Mode = VFWMVMode.V8SystemProfile;

                if (cbWMVInternalProfile8.SelectedIndex != -1)
                {
                    wmvOutput.V8ProfileName = cbWMVInternalProfile8.Text;
                }
            }
            else if (rbWMVExternal.Checked)
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

                wmvOutput.Custom_Audio_StreamPresent = cbWMVAudioEnabled.Checked;

                wmvOutput.Custom_Video_Codec = cbWMVVideoCodec.Text;
                wmvOutput.Custom_Video_Width = Convert.ToInt32(edWMVWidth.Text);
                wmvOutput.Custom_Video_Height = Convert.ToInt32(edWMVHeight.Text);
                wmvOutput.Custom_Video_SizeSameAsInput = cbWMVSizeSameAsInput.Checked;
                wmvOutput.Custom_Video_FrameRate = Convert.ToDouble(edWMVFrameRate.Text);
                wmvOutput.Custom_Video_KeyFrameInterval = Convert.ToByte(edWMVKeyFrameInterval.Text);
                wmvOutput.Custom_Video_Bitrate = Convert.ToInt32(edWMVVideoBitrate.Text);
                wmvOutput.Custom_Video_Quality = Convert.ToByte(edWMVVideoQuality.Text);

                s = cbWMVVideoMode.Text;
                if (s == "CBR")
                {
                    wmvOutput.Custom_Video_Mode = VFWMVStreamMode.CBR;
                }
                else if (s == "VBR")
                {
                    wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRBitrate;
                }
                else if (s == "VBR (Peak)")
                {
                    wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRPeakBitrate;
                }
                else
                {
                    wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRQuality;
                }

                if (cbWMVTVFormat.Text == "PAL")
                {
                    wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.PAL;
                }
                else if (cbWMVTVFormat.Text == "NTSC")
                {
                    wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.NTSC;
                }
                else
                {
                    wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.Other;
                }

                wmvOutput.Custom_Video_StreamPresent = cbWMVVideoEnabled.Checked;

                wmvOutput.Custom_Profile_Name = "My_Profile_1";
            }
        }

        /// <summary>
        /// Form load event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            audioChannelMapperItems = new List<AudioChannelMapperItem>();

            // set combobox indexes
            cbMode.SelectedIndex = 0;
            cbOutputFormat.SelectedIndex = 22;
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
            cbSpeexBitrateControl.SelectedIndex = 2;
            cbSpeexMode.SelectedIndex = 0;
            cbCustomAudioSourceCategory.SelectedIndex = 0;
            cbCustomVideoSourceCategory.SelectedIndex = 0;
            cbPIPResizeMode.SelectedIndex = 0;

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
            
            cbMFProfile.SelectedIndex = 1;
            cbMFLevel.SelectedIndex = 12;
            cbMFRateControl.SelectedIndex = 3;
            
            filtersAvailableInfo = VideoCapture.GetFiltersAvailable();
            if (filtersAvailableInfo.V11_NVENC_H264)
            {
                lbMFHWAvailableEncoders.Text += "NVENC ";
            }

            if (filtersAvailableInfo.V11_AMD_H264)
            {
                lbMFHWAvailableEncoders.Text += "AMD ";
            }

            if (filtersAvailableInfo.V11_QSV_H264)
            {
                lbMFHWAvailableEncoders.Text += "INTEL QSV";
            }

            if (IsWindows8OrNewer())
            {
                cbMP4Mode.SelectedIndex = 3;
            }
            else if (IsWindows7OrNewer())
            {
                cbMP4Mode.SelectedIndex = 1;
            }
            else
            {
                cbMP4Mode.SelectedIndex = 0;
            }

            cbFLACBlockSize.SelectedIndex = 4;

            foreach (var screen in Screen.AllScreens)
            {
                cbScreenCaptureDisplayIndex.Items.Add(screen.DeviceName.Replace(@"\\.\DISPLAY", string.Empty));
            }

            cbScreenCaptureDisplayIndex.SelectedIndex = 0;

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

            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbH264MBEncoding.SelectedIndex = 0;
            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 16;
            cbH264PictureType.SelectedIndex = 0;
            cbH264TargetUsage.SelectedIndex = 3;

            cbNVENCProfile.SelectedIndex = 2;
            cbNVENCLevel.SelectedIndex = 0;
            cbNVENCRateControl.SelectedIndex = 1;

            cbM4AOutput.SelectedIndex = 0;
            cbM4AVersion.SelectedIndex = 0;
            cbM4AObjectType.SelectedIndex = 1;
            cbM4ABitrate.SelectedIndex = 12;

            cbDecklinkOutputAnalog.SelectedIndex = 0;
            cbDecklinkOutputBlackToDeck.SelectedIndex = 0;
            cbDecklinkOutputComponentLevels.SelectedIndex = 0;
            cbDecklinkOutputDownConversion.SelectedIndex = 0;
            cbDecklinkOutputDualLink.SelectedIndex = 0;
            cbDecklinkOutputHDTVPulldown.SelectedIndex = 0;
            cbDecklinkOutputNTSC.SelectedIndex = 0;
            cbDecklinkOutputSingleField.SelectedIndex = 0;

            cbDecklinkSourceInput.SelectedIndex = 0;
            cbDecklinkSourceNTSC.SelectedIndex = 0;
            cbDecklinkSourceComponentLevels.SelectedIndex = 0;
            cbDecklinkSourceTimecode.SelectedIndex = 0;

            cbFaceTrackingColorMode.SelectedIndex = 0;
            cbFaceTrackingScalingMode.SelectedIndex = 0;
            cbFaceTrackingSearchMode.SelectedIndex = 1;

            cbNetworkStreamingMode.SelectedIndex = 0;

            cbDirect2DRotate.SelectedIndex = 0;

            cbWebMVideoEndUsageMode.SelectedIndex = 0;
            edWebMVideoThreadCount.Text = Environment.ProcessorCount.ToString(CultureInfo.InvariantCulture);
            cbWebMVideoEncoder.SelectedIndex = 0;
            cbWebMVideoKeyframeMode.SelectedIndex = 0;
            cbWebMVideoQualityMode.SelectedIndex = 0;

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

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edNewFilename.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output_new.avi";

            foreach (string codec in VideoCapture1.Video_Codecs)
            {
                cbVideoCodecs.Items.Add(codec);
                cbCustomVideoCodecs.Items.Add(codec);

                // cbRTSPVideoCodec.Items.Add(codec);
            }

            if (cbVideoCodecs.Items.Count > 0)
            {
                cbVideoCodecs.SelectedIndex = 0;
                cbVideoCodecs_SelectedIndexChanged(null, null);
                cbCustomVideoCodecs.SelectedIndex = 0;
                cbCustomVideoCodecs_SelectedIndexChanged(null, null);

                // cbRTSPVideoCodec.SelectedIndex = 0;
                // cbRTSPVideoCodec_SelectedIndexChanged(null, null);
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

                // cbRTSPAudioCodec.Items.Add(codec);
            }

            if (cbAudioCodecs.Items.Count > 0)
            {
                cbAudioCodecs.SelectedIndex = 0;
                cbAudioCodecs_SelectedIndexChanged(null, null);
                cbAudioCodecs2.SelectedIndex = 0;
                cbAudioCodecs2_SelectedIndexChanged(null, null);
                cbCustomAudioCodecs.SelectedIndex = 0;
                cbCustomAudioCodecs_SelectedIndexChanged(null, null);

                // cbRTSPAudioCodec.SelectedIndex = 0;
                // cbRTSPAudioCodec_SelectedIndexChanged(null, null);
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

            string defaultAudioRenderer = string.Empty;
            foreach (string audioOutputDevice in VideoCapture1.Audio_OutputDevices)
            {
                cbAudioOutputDevice.Items.Add(audioOutputDevice);

                if (audioOutputDevice.Contains("Default DirectSound Device"))
                {
                    defaultAudioRenderer = audioOutputDevice;
                }
            }

            if (cbAudioOutputDevice.Items.Count > 0)
            {
                if (string.IsNullOrEmpty(defaultAudioRenderer))
                {
                    cbAudioOutputDevice.SelectedIndex = 0;
                }
                else
                {
                    cbAudioOutputDevice.Text = defaultAudioRenderer;
                }
               
                cbAudioOutputDevice_SelectedIndexChanged(null, null);
            }

            if (!string.IsNullOrEmpty(cbAudioInputDevice.Text))
            {
                var audioInputDevice =
                    VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (audioInputDevice != null)
                {
                    foreach (string line in audioInputDevice.Lines)
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

            rbEVR.Enabled = VideoCapture.Filter_Supported_EVR();
            rbVMR9.Enabled = VideoCapture.Filter_Supported_VMR9();

            if (!(rbVMR9.Enabled && rbEVR.Enabled))
            {
                rbVR.Checked = true;
            }
            else if (rbEVR.Enabled)
            {
                rbEVR.Checked = true;
            }

            rbVR_CheckedChanged(null, null);

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
                cbMPEGDemuxer.Items.Add(directShowFilter);
            }

            // Video capture device MPEG decoders
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

            cbWMVAudioMode_SelectedIndexChanged(sender, e);
            cbWMVVideoMode_SelectedIndexChanged(sender, e);

            if (cbWMVVideoCodec.Items.Count > 0)
            {
                cbWMVVideoCodec.SelectedIndex = 0;
            }

            if (cbWMVAudioCodec.Items.Count > 0)
            {
                cbWMVAudioCodec.SelectedIndex = 0;
            }

            cbWMVAudioCodec_SelectedIndexChanged(sender, e);

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

            foreach (string preset in VideoCapture1.Audio_Effects_Equalizer_Presets())
            {
                cbAudEqualizerPreset.Items.Add(preset);
            }

            cbPIPMode.SelectedIndex = 0;

            // BDA
            foreach (string source in VideoCapture.BDA_Sources())
            {
                cbBDASourceDevice.Items.Add(source);
            }

            foreach (string receiver in VideoCapture.BDA_Receivers())
            {
                cbBDAReceiver.Items.Add(receiver);
            }

            if (cbBDASourceDevice.Items.Count > 0)
            {
                cbBDASourceDevice.SelectedIndex = 0;
            }

            if (cbBDAReceiver.Items.Count > 1)
            {
                cbBDAReceiver.SelectedIndex = 1;
            }

            cbBDADeviceStandard.SelectedIndex = 0;
            cbDVBSPolarisation.SelectedIndex = 0;
            cbDVBCModulation.SelectedIndex = 4;

            // ReSharper disable once CoVariantArrayConversion
            cbAudEqualizerPreset.Items.AddRange(VideoCapture1.Audio_Effects_Equalizer_Presets().ToArray());
            cbAudEqualizerPreset.SelectedIndex = 0;

            // Decklink
            foreach (var device in VideoCapture1.Decklink_CaptureDevices)
            {
                cbDecklinkCaptureDevice.Items.Add(device.Name);
            }

            if (cbDecklinkCaptureDevice.Items.Count > 0)
            {
                cbDecklinkCaptureDevice.SelectedIndex = 0;
                cbDecklinkCaptureDevice_SelectedIndexChanged(null, null);
            }
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

                // currently device active, we can read TV Tuner name
                string tvTuner = deviceItem.TVTuner;
                if (!string.IsNullOrEmpty(tvTuner))
                {
                    int k = cbTVTuner.Items.IndexOf(tvTuner);
                    if (k >= 0)
                    {
                        cbTVTuner.SelectedIndex = k;
                    }
                }

                cbCrossBarAvailable.Enabled = VideoCapture1.Video_CaptureDevice_CrossBar_Init(cbVideoInputDevice.Text);
                cbCrossBarAvailable.Checked = cbCrossBarAvailable.Enabled;

                if (cbCrossBarAvailable.Enabled)
                {
                    cbCrossbarInput.Enabled = true;
                    cbCrossbarOutput.Enabled = true;
                    rbCrossbarSimple.Enabled = true;
                    rbCrossbarAdvanced.Enabled = true;
                    cbCrossbarVideoInput.Enabled = true;
                    btConnect.Enabled = true;
                    cbConnectRelated.Enabled = true;
                    lbRotes.Enabled = true;

                    VideoCapture1.Video_CaptureDevice_CrossBar_ClearConnections();

                    cbCrossbarVideoInput.Items.Clear();
                    foreach (string s in VideoCapture1.Video_CaptureDevice_CrossBar_GetInputsForOutput("Video Decoder"))
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
                        string input = VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(cbCrossbarOutput.Text);

                        if (input != string.Empty)
                        {
                            lbRotes.Items.Add("Input: " + input + ", Output: " + cbCrossbarOutput.Items[i]);
                        }
                    }
                }
                else
                {
                    cbCrossbarInput.Enabled = false;
                    cbCrossbarOutput.Enabled = false;
                    rbCrossbarSimple.Enabled = false;
                    rbCrossbarAdvanced.Enabled = false;
                    cbCrossbarVideoInput.Enabled = false;
                    btConnect.Enabled = false;
                    cbConnectRelated.Enabled = false;
                    lbRotes.Enabled = false;
                }

                // updating adjust settings
                int max;
                int defaultValue;
                int min;
                bool auto;
                int step;
                if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(VFVideoHardwareAdjustment.Brightness, out min, out max, out step, out defaultValue, out auto))
                {
                    tbAdjBrightness.Minimum = min;
                    tbAdjBrightness.Maximum = max;
                    tbAdjBrightness.SmallChange = step;
                    tbAdjBrightness.Value = defaultValue;
                    cbAdjBrightnessAuto.Checked = auto;
                    lbAdjBrightnessMin.Text = "Min: " + Convert.ToString(min);
                    lbAdjBrightnessMax.Text = "Max: " + Convert.ToString(max);
                    lbAdjBrightnessCurrent.Text = "Current: " + Convert.ToString(defaultValue);
                }

                if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(VFVideoHardwareAdjustment.Hue, out min, out max, out step, out defaultValue, out auto))
                {
                    tbAdjHue.Minimum = min;
                    tbAdjHue.Maximum = max;
                    tbAdjHue.SmallChange = step;
                    tbAdjHue.Value = defaultValue;
                    cbAdjHueAuto.Checked = auto;
                    lbAdjHueMin.Text = "Min: " + Convert.ToString(min);
                    lbAdjHueMax.Text = "Max: " + Convert.ToString(max);
                    lbAdjHueCurrent.Text = "Current: " + Convert.ToString(defaultValue);
                }

                if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(VFVideoHardwareAdjustment.Saturation, out min, out max, out step, out defaultValue, out auto))
                {
                    tbAdjSaturation.Minimum = min;
                    tbAdjSaturation.Maximum = max;
                    tbAdjSaturation.SmallChange = step;
                    tbAdjSaturation.Value = defaultValue;
                    cbAdjSaturationAuto.Checked = auto;
                    lbAdjSaturationMin.Text = "Min: " + Convert.ToString(min);
                    lbAdjSaturationMax.Text = "Max: " + Convert.ToString(max);
                    lbAdjSaturationCurrent.Text = "Current: " + Convert.ToString(defaultValue);
                }

                if (VideoCapture1.Video_CaptureDevice_VideoAdjust_GetRanges(VFVideoHardwareAdjustment.Contrast, out min, out max, out step, out defaultValue, out auto))
                {
                    tbAdjContrast.Minimum = min;
                    tbAdjContrast.Maximum = max;
                    tbAdjContrast.SmallChange = step;
                    tbAdjContrast.Value = defaultValue;
                    cbAdjContrastAuto.Checked = auto;
                    lbAdjContrastMin.Text = "Min: " + Convert.ToString(min);
                    lbAdjContrastMax.Text = "Max: " + Convert.ToString(max);
                    lbAdjContrastCurrent.Text = "Current: " + Convert.ToString(defaultValue);
                }

                cbUseAudioInputFromVideoCaptureDevice.Enabled = deviceItem.AudioOutput;
                btVideoCaptureDeviceSettings.Enabled = deviceItem.DialogDefault;
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

                    cbAudioInputFormat_SelectedIndexChanged(null, null);
                }
            }
            else if (cbAudioInputDevice.SelectedIndex != -1)
            {
                VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem != null)
                {
                    var defaultValue = "PCM, 44100 Hz, 16 Bits, 2 Channels";
                    var defaultValueExists = false;
                    foreach (string format in deviceItem.Formats)
                    {
                        cbAudioInputFormat.Items.Add(format);

                        if (defaultValue == format)
                        {
                            defaultValueExists = true;
                        }
                    }

                    if (cbAudioInputFormat.Items.Count > 0)
                    {
                        cbAudioInputFormat.SelectedIndex = 0;

                        if (defaultValueExists)
                        {
                            cbAudioInputFormat.Text = defaultValue;
                        }
                    }

                    cbAudioInputFormat_SelectedIndexChanged(null, null);

                    foreach (string line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }

                    if (cbAudioInputLine.Items.Count > 0)
                    {
                        cbAudioInputLine.SelectedIndex = 0;
                    }

                    cbAudioInputLine_SelectedIndexChanged(null, null);

                    btAudioInputDeviceSettings.Enabled = deviceItem.DialogDefault;
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
            else if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        /// <summary>
        /// Selects output file.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Selectes WM profile.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void btSelectWM_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Starts video preview or capture.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void btStart_Click(object sender, EventArgs e)
        {
            zoom = 1.0;
            zoomShiftX = 0;
            zoomShiftY = 0;

            if (onvifControl != null)
            {
                onvifControl.Disconnect();
                onvifControl.Dispose();
                onvifControl = null;

                btONVIFConnect.Text = "Connect";
            }

            mmLog.Clear();

            if (cbPIPDevices.Items.Count > 0)
            {
                if (cbPIPDevices.Items.IndexOf("Main source") == -1)
                {
                    cbPIPDevices.Items.Insert(0, "Main source");
                }
            }

            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            VideoCapture1.VLC_Path = Environment.GetEnvironmentVariable("VFVLCPATH");

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
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = cbUseBestAudioInputFormat.Checked;

            VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = rbAddAudioStreamsMix.Checked;

            if ((VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.ScreenPreview))
            {
                ScreenCaptureSourceSettings screenSource;
                SelectScreenSource(out screenSource);
                VideoCapture1.Screen_Capture_Source = screenSource;
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.IPCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.IPPreview))
            {
                // from IP camera
                IPCameraSourceSettings settings;
                SelectIPCameraSource(out settings);
                VideoCapture1.IP_Camera_Source = settings;
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.VideoPreview) ||
                (VideoCapture1.Mode == VFVideoCaptureMode.AudioCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.AudioPreview))
            {
                // from video capture device
                SelectVideoCaptureSource();
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.BDACapture) || (VideoCapture1.Mode == VFVideoCaptureMode.BDAPreview))
            {
                SelectBDASource();
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.CustomCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.CustomPreview))
            {
                SelectCustomSource();
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.PushSourceCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.PushSourcePreview))
            {
                VideoCapture1.Push_Source = new PushSourceSettings
                {
                    VideoPresent = true,
                    VideoWidth = 640,
                    VideoHeight = 480,
                    VideoFrameRate = 25.0f
                };
            }
            else if ((VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture) || (VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourcePreview))
            {
                VideoCapture1.Decklink_Source = new DecklinkSourceSettings
                {
                    Name = cbDecklinkCaptureDevice.Text,
                    VideoFormat = cbDecklinkCaptureVideoFormat.Text
                };
            }

            // Auto file name
            SetFilename();

            // network streaming
            VideoCapture1.Network_Streaming_Enabled = false;

            if (cbNetworkStreaming.Checked)
            {
                ConfigureNetworkStreaming();
            }

            VideoCapture1.Audio_RecordAudio = cbRecordAudio.Checked;
            VideoCapture1.Audio_PlayAudio = cbPlayAudio.Checked;

            // VU meters
            ConfigureVUMeters();

            // multiscreen
            ConfigureMultiscreen();

            VFVideoCaptureOutputFormat outputFormat = VFVideoCaptureOutputFormat.AVI;
            if (VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture || VideoCapture1.Mode == VFVideoCaptureMode.AudioCapture ||
                VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture || VideoCapture1.Mode == VFVideoCaptureMode.IPCapture ||
                VideoCapture1.Mode == VFVideoCaptureMode.PushSourceCapture || VideoCapture1.Mode == VFVideoCaptureMode.CustomCapture ||
                VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture || VideoCapture1.Mode == VFVideoCaptureMode.BDACapture)
            {
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
                            FillWMVSettings(ref wmvOutput);
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

                            var wmaOutput = new VFWMAOutput
                            {
                                ProfileFilename = edWMVProfile.Text
                            };
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
                        VideoCapture1.Output_Format = new VFDirectCaptureDVOutput();
                        break;
                    case 13:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureAVI;
                        VideoCapture1.Output_Format = new VFDirectCaptureAVIOutput();
                        break;
                    case 14:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMPEG;
                        VideoCapture1.Output_Format = new VFDirectCaptureMPEGOutput();
                        break;
                    case 15:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMKV;
                        VideoCapture1.Output_Format = new VFDirectCaptureMKVOutput();

                        break;
                    case 16:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMP4_GDCL;

                        var directCaptureOutputGDCL = new VFDirectCaptureMP4Output();

                        // Custom audio code can be use if device to not have audio pin with compressed stream
                        if (rbCustomUseAudioCodecsCat.Checked)
                        {
                            directCaptureOutputGDCL.Audio_Codec = cbCustomAudioCodecs.Text;
                            directCaptureOutputGDCL.Audio_Codec_UseFiltersCategory = false;
                        }
                        else
                        {
                            directCaptureOutputGDCL.Audio_Codec = cbCustomDSFilterA.Text;
                            directCaptureOutputGDCL.Audio_Codec_UseFiltersCategory = true;
                        }

                        directCaptureOutputGDCL.Muxer = VFDirectCaptureMP4Muxer.GDCL;

                        VideoCapture1.Output_Format = directCaptureOutputGDCL;

                        break;
                    case 17:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureMP4_Monogram;

                        var directCaptureOutputMG = new VFDirectCaptureMP4Output();

                        // Custom audio code can be use if device to not have audio pin with compressed stream
                        if (rbCustomUseAudioCodecsCat.Checked)
                        {
                            directCaptureOutputMG.Audio_Codec = cbCustomAudioCodecs.Text;
                            directCaptureOutputMG.Audio_Codec_UseFiltersCategory = false;
                        }
                        else
                        {
                            directCaptureOutputMG.Audio_Codec = cbCustomDSFilterA.Text;
                            directCaptureOutputMG.Audio_Codec_UseFiltersCategory = true;
                        }

                        directCaptureOutputMG.Muxer = VFDirectCaptureMP4Muxer.Monogram;

                        VideoCapture1.Output_Format = directCaptureOutputMG;

                        break;
                    case 18:
                        outputFormat = VFVideoCaptureOutputFormat.DirectCaptureCustom;
                        break;
                    case 19:
                        outputFormat = VFVideoCaptureOutputFormat.WebM;
                        break;
                    case 20:
                        outputFormat = VFVideoCaptureOutputFormat.FFMPEG_DLL;
                        break;
                    case 21:
                        outputFormat = VFVideoCaptureOutputFormat.FFMPEG_EXE;
                        break;
                    case 22:
                        outputFormat = VFVideoCaptureOutputFormat.MP4;
                        break;
                    case 23:
                        outputFormat = VFVideoCaptureOutputFormat.AnimatedGIF;
                        break;
                    case 24:
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
                    // nothing, already applied in FillWMVSettings
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.OggVorbis)
                {
                    SetOGGOutput();
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.M4A)
                {
                    var m4aOutput = new VFM4AOutput();
                    SetM4AOutput(ref m4aOutput);
                    VideoCapture1.Output_Format = m4aOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.Speex)
                {
                    SetSpeexOutput();
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

                    VideoCapture1.Output_Format = new VFDirectCaptureMPEGOutput();
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
                else if (outputFormat == VFVideoCaptureOutputFormat.MP3)
                {
                    var mp3Output = new VFMP3Output();
                    SetMP3Output(ref mp3Output);
                    VideoCapture1.Output_Format = mp3Output;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.WebM)
                {
                    var webmOutput = new VFWebMOutput();
                    SetWebMOutput(ref webmOutput);
                    VideoCapture1.Output_Format = webmOutput;
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

                    SetFFMPEGEXESettings(ref ffmpegOutput);

                    ffmpegOutput.UsePipe = cbFFMPEGEXEUsePipes.Checked;

                    VideoCapture1.Output_Format = ffmpegOutput;
                }
                else if (outputFormat == VFVideoCaptureOutputFormat.DirectCaptureCustom)
                {
                    var directCaptureOutput = new VFDirectCaptureCustomOutput();
                    SetDirectCaptureCustomOutput(ref directCaptureOutput);
                    VideoCapture1.Output_Format = directCaptureOutput;
                }
                else if ((outputFormat == VFVideoCaptureOutputFormat.MP4) ||
                    ((outputFormat == VFVideoCaptureOutputFormat.Encrypted) && rbEncryptedH264SW.Checked) ||
                    (VideoCapture1.Network_Streaming_Enabled && (VideoCapture1.Network_Streaming_Format == VFNetworkStreamingFormat.RTSP_H264_AAC_SW)))
                {
                    var mp4Output = new VFMP4Output();
                    SetMP4Output(ref mp4Output);

                    if (outputFormat == VFVideoCaptureOutputFormat.Encrypted)
                    {
                        mp4Output.Encryption = true;
                        mp4Output.Encryption_Format = VFEncryptionFormat.MP4_H264_SW_AAC;

                        if (rbEncryptionKeyString.Checked)
                        {
                            mp4Output.Encryption_KeyType = VFEncryptionKeyType.String;
                            mp4Output.Encryption_Key = edEncryptionKeyString.Text;
                        }
                        else if (rbEncryptionKeyFile.Checked)
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

                        if (rbEncryptionModeAES128.Checked)
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

            // crossbar
            SelectCrossbar();

            // Video effects
            VideoCapture1.Video_Effects_Enabled = cbEffects.Checked;
            VideoCapture1.Video_Effects_Clear();
            ConfigureVideoEffects();

            // Virtual camera output
            VideoCapture1.Virtual_Camera_Output_Enabled = cbVirtualCamera.Checked;

            // Decklink output
            ConfigureDecklink();

            // Object detection 
            ConfigureMotionDetectionEx();

            // Face tracking
            ConfigureFaceTracking();

            // Barcode detection
            ConfigureBarcodeDetection();

            // Chroma key
            ConfigureChromaKey();

            // video renderer
            ConfigureVideoRenderer();

            // video resize and crop
            ConfigureResizeCropRotate();

            // MPEG / DV decoders
            ConfigureDecoders();

            // motion detection
            if (cbMotDetEnabled.Checked)
            {
                btMotDetUpdateSettings_Click(null, null); // apply settings
            }

            // Audio enhancement
            VideoCapture1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.Checked;
            if (VideoCapture1.Audio_Enhancer_Enabled)
            {
                VideoCapture1.Audio_Enhancer_Normalize(cbAudioNormalize.Checked);
                VideoCapture1.Audio_Enhancer_AutoGain(cbAudioAutoGain.Checked);

                ApplyAudioInputGains();
                ApplyAudioOutputGains();

                VideoCapture1.Audio_Enhancer_Timeshift(tbAudioTimeshift.Value);
            }

            // Audio channels mapping
            if (cbAudioChannelMapperEnabled.Checked)
            {
                VideoCapture1.Audio_Channel_Mapper = new AudioChannelMapperSettings
                {
                    Routes = audioChannelMapperItems.ToArray(),
                    OutputChannelsCount =
                                                                 Convert.ToInt32(
                                                                     edAudioChannelMapperOutputChannels.Text)
                };
            }
            else
            {
                VideoCapture1.Audio_Channel_Mapper = null;
            }

            // Audio processing
            VideoCapture1.Audio_Effects_Enabled = cbAudioEffectsEnabled.Checked;
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
                chromaKey.Color = pnPIPChromaKeyColor.BackColor;
                chromaKey.Tolerance1 = tbPIPChromaKeyTolerance1.Value;
                chromaKey.Tolerance2 = tbPIPChromaKeyTolerance2.Value;

                VideoCapture1.PIP_ChromaKeySettings = chromaKey;
            }

            // Separate capture
            ConfigureSeparateCapture();

            // Output tags
            ConfigureOutputTags();

            // Disable video processing?
            if (cbDisableAllVideoProcessing.Checked)
            {
                VideoCapture1.Video_Effects_Enabled = false;
                VideoCapture1.Video_Effects_Clear();

                VideoCapture1.Video_Sample_Grabber_Enabled = false;
            }

            // bug
            VideoCapture1.Video_Sample_Grabber_Enabled = true;
            //VideoCapture1.Video_Effects_Enabled = true;

            //IVFGPUVideoEffectEmboss intf;
            //intf = new VFGPUVideoEffectEmboss(true);
            //VideoCapture1.Video_Effects_GPU_Add(intf);

            //IVFGPUVideoEffectBrightness intf;
            //intf = new VFGPUVideoEffectBrightness(true, 100);
            //VideoCapture1.Video_Effects_GPU_Add(intf);

            // start
            VideoCapture1.Start(cbIndependentThread.Checked);

            edNetworkURL.Text = VideoCapture1.Network_Streaming_URL;
        }

        private void ConfigureDecoders()
        {
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

            if (cbMPEGDemuxer.SelectedIndex < 1)
            {
                // default
                VideoCapture1.MPEG_Demuxer = string.Empty;
            }
            else
            {
                VideoCapture1.MPEG_Demuxer = cbMPEGDemuxer.Text;
            }

            // DV resolution
            if (rbDVResFull.Checked)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Full;
            }
            else if (rbDVResHalf.Checked)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Half;
            }
            else if (rbDVResQuarter.Checked)
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.Quarter;
            }
            else
            {
                VideoCapture1.DV_Decoder_Video_Resolution = VFDVVideoResolution.DC;
            }
        }

        private void ConfigureOutputTags()
        {
            if (cbTagEnabled.Checked)
            {
                var tags = new VFFileTags
                {
                    Title = edTagTitle.Text,
                    Performers = new[] { edTagArtists.Text },
                    Album = edTagAlbum.Text,
                    Comment = edTagComment.Text,
                    Track = Convert.ToUInt32(edTagTrackID.Text),
                    Copyright = edTagCopyright.Text,
                    Year = Convert.ToUInt32(edTagYear.Text),
                    Composers = new[] { edTagComposers.Text },
                    Genres = new[] { cbTagGenre.Text },
                    Lyrics = edTagLyrics.Text
                };

                if (imgTagCover.Image != null)
                {
                    tags.Pictures = new[] { new Bitmap(imgTagCover.Image) };
                }

                VideoCapture1.Tags = tags;
            }
        }

        private void ConfigureSeparateCapture()
        {
            VideoCapture1.SeparateCapture_Enabled = cbSeparateCaptureEnabled.Checked;
            if (VideoCapture1.SeparateCapture_Enabled)
            {
                VideoCapture1.SeparateCapture_GMFMode = !cbSeparateCaptureBridgeEngine.Checked;

                if (rbSeparateCaptureStartManually.Checked)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.Normal;
                    VideoCapture1.SeparateCapture_AutostartCapture = false;
                }
                else if (rbSeparateCaptureSplitByDuration.Checked)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.SplitByDuration;
                    VideoCapture1.SeparateCapture_AutostartCapture = true;
                    VideoCapture1.SeparateCapture_TimeThreshold = Convert.ToInt32(edSeparateCaptureDuration.Text);
                }
                else if (rbSeparateCaptureSplitBySize.Checked)
                {
                    VideoCapture1.SeparateCapture_Mode = VFSeparateCaptureMode.SplitByFileSize;
                    VideoCapture1.SeparateCapture_AutostartCapture = true;
                    VideoCapture1.SeparateCapture_FileSizeThreshold = Convert.ToInt32(edSeparateCaptureFileSize.Text) * 1024
                                                                      * 1024;
                }
            }
        }

        private void ConfigureResizeCropRotate()
        {
            VideoCapture1.Video_ResizeOrCrop_Enabled = false;

            if (cbResize.Checked)
            {
                VideoCapture1.Video_ResizeOrCrop_Enabled = true;

                VideoCapture1.Video_Resize = new VideoResizeSettings
                {
                    Width = Convert.ToInt32(edResizeWidth.Text),
                    Height = Convert.ToInt32(edResizeHeight.Text),
                    LetterBox = cbResizeLetterbox.Checked
                };

                switch (cbResizeMode.SelectedIndex)
                {
                    case 0:
                        VideoCapture1.Video_Resize.Mode = VFResizeMode.NearestNeighbor;
                        break;
                    case 1:
                        VideoCapture1.Video_Resize.Mode = VFResizeMode.Bilinear;
                        break;
                    case 2:
                        VideoCapture1.Video_Resize.Mode = VFResizeMode.Bicubic;
                        break;
                    case 3:
                        VideoCapture1.Video_Resize.Mode = VFResizeMode.Lancroz;
                        break;
                }
            }
            else
            {
                VideoCapture1.Video_Resize = null;
            }

            if (cbCrop.Checked)
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
        }

        private void ConfigureVideoRenderer()
        {
            if (VideoCapture1.Video_Renderer == null)
            {
                VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            if (rbVMR9.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else if (rbEVR.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (rbVR.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
            else if (rbDirect2D.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D;
            }
            else
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.None;
            }

            if (cbStretch.Checked)
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);

            VideoCapture1.Video_Renderer.BackgroundColor = pnVideoRendererBGColor.BackColor;
            VideoCapture1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked;
            VideoCapture1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked;
        }

        private void ConfigureChromaKey()
        {
            if (cbChromaKeyEnabled.Checked)
            {
                VideoCapture1.ChromaKey = new ChromaKeySettings
                {
                    ContrastHigh = tbChromaKeyContrastHigh.Value,
                    ContrastLow = tbChromaKeyContrastLow.Value,
                    ImageFilename = edChromaKeyImage.Text
                };

                if (rbChromaKeyGreen.Checked)
                {
                    VideoCapture1.ChromaKey.Color = VFChromaColor.Green;
                }
                else if (rbChromaKeyBlue.Checked)
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
        }

        static void ShowOnScreen(Form window, int screenNumber)
        {
            if (screenNumber >= 0 && screenNumber < Screen.AllScreens.Length)
            {
                window.Location = Screen.AllScreens[screenNumber].WorkingArea.Location;

                window.Show();

                window.Width = Screen.AllScreens[screenNumber].Bounds.Width;
                window.Height = Screen.AllScreens[screenNumber].Bounds.Height;
                window.Left = Screen.AllScreens[screenNumber].Bounds.Left;
                window.Top = Screen.AllScreens[screenNumber].Bounds.Top;
                window.TopMost = true;
                window.FormBorderStyle = FormBorderStyle.None;
                window.WindowState = FormWindowState.Maximized;
            }
        }

        private void ConfigureMultiscreen()
        {
            VideoCapture1.MultiScreen_Clear();
            VideoCapture1.MultiScreen_Enabled = cbMultiscreenDrawOnPanels.Checked || cbMultiscreenDrawOnExternalDisplays.Checked;

            if (!VideoCapture1.MultiScreen_Enabled)
            {
                return;
            }

            if (cbMultiscreenDrawOnPanels.Checked)
            {
                VideoCapture1.MultiScreen_AddScreen(pnScreen1.Handle, pnScreen1.Width, pnScreen1.Height);
                VideoCapture1.MultiScreen_AddScreen(pnScreen2.Handle, pnScreen2.Width, pnScreen2.Height);
                VideoCapture1.MultiScreen_AddScreen(pnScreen3.Handle, pnScreen3.Width, pnScreen3.Height);
            }

            if (cbMultiscreenDrawOnExternalDisplays.Checked)
            {
                if (Screen.AllScreens.Length > 1)
                {
                    for (int i = 1; i < Screen.AllScreens.Length; i++)
                    {
                        var additinalWindow1 = new Form();
                        ShowOnScreen(additinalWindow1, i);
                        VideoCapture1.MultiScreen_AddScreen(additinalWindow1.Handle, additinalWindow1.Width, additinalWindow1.Height);
                        multiscreenWindows.Add(additinalWindow1);
                    }
                }
            }
        }

        private void SetFilename()
        {
            if ((VideoCapture1.Mode == VFVideoCaptureMode.ScreenCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.AudioCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.IPCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.CustomCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.PushSourceCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.DecklinkSourceCapture)
                || (VideoCapture1.Mode == VFVideoCaptureMode.BDACapture))
            {
                if (!cbAutoFilename.Checked)
                {
                    VideoCapture1.Output_Filename = edOutput.Text;
                }
                else
                {
                    DateTime dt = DateTime.Now;
                    string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

                    string path = Path.GetDirectoryName(edOutput.Text);
                    string ext = Path.GetExtension(edOutput.Text);
                    VideoCapture1.Output_Filename = path + "\\" + s + ext;
                }
            }
        }

        private void ConfigureVideoEffects()
        {
            // Deinterlace, except screen preview / capture
            if (cbDeinterlace.Checked && VideoCapture1.Mode != VFVideoCaptureMode.ScreenCapture
                && VideoCapture1.Mode != VFVideoCaptureMode.ScreenPreview)
            {
                if (rbDeintBlendEnabled.Checked)
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
                else if (rbDeintCAVTEnabled.Checked)
                {
                    IVFVideoEffectDeinterlaceCAVT cavt;
                    var effect = VideoCapture1.Video_Effects_Get("DeinterlaceCAVT");
                    if (effect == null)
                    {
                        cavt = new VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.Checked, Convert.ToInt32(edDeintCAVTThreshold.Text));
                        VideoCapture1.Video_Effects_Add(cavt);
                    }
                    else
                    {
                        cavt = effect as IVFVideoEffectDeinterlaceCAVT;
                    }

                    if (cavt == null)
                    {
                        MessageBox.Show("Unable to configure deinterlace CAVT effect.");
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

            // Denoise, except screen preview / capture
            if (cbDenoise.Checked && VideoCapture1.Mode != VFVideoCaptureMode.ScreenCapture
                && VideoCapture1.Mode != VFVideoCaptureMode.ScreenPreview)
            {
                if (rbDenoiseCAST.Checked)
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

            if (cbGreyscale.Checked)
            {
                cbGreyscale_CheckedChanged(null, null);
            }

            if (cbInvert.Checked)
            {
                cbInvert_CheckedChanged(null, null);
            }

            if (cbZoom.Checked)
            {
                cbZoom_CheckedChanged(null, null);
            }

            if (cbLiveRotation.Checked)
            {
                cbLiveRotation_CheckedChanged(null, null);
            }

            if (cbPan.Checked)
            {
                cbPan_CheckedChanged(null, null);
            }

            if (cbImageLogo.Checked)
            {
                cbImageLogo_CheckedChanged(null, null);
            }

            if (cbTextLogo.Checked)
            {
                btTextLogoUpdateParams_Click(null, null);
            }

            if (cbFadeInOut.Checked)
            {
                cbFadeInOut_CheckedChanged(null, null);
            }
        }

        private void ConfigureBarcodeDetection()
        {
            VideoCapture1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.Checked;
            VideoCapture1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;
        }

        private void ConfigureFaceTracking()
        {
            if (cbFaceTrackingEnabled.Checked)
            {
                VideoCapture1.Face_Tracking = new FaceTrackingSettings
                {
                    ColorMode = (CamshiftMode)cbFaceTrackingColorMode.SelectedIndex,
                    Highlight = cbFaceTrackingCHL.Checked,
                    MinimumWindowSize =
                                                          int.Parse(edFaceTrackingMinimumWindowSize.Text),
                    ScalingMode =
                                                          (ObjectDetectorScalingMode)
                                                          cbFaceTrackingScalingMode.SelectedIndex,
                    SearchMode =
                                                          (ObjectDetectorSearchMode)
                                                          cbFaceTrackingSearchMode.SelectedIndex
                };

                // VideoCapture1.FaceTracking_ScaleFactor = int.Parse(edFaceTrackingScaleFactor.Text);
            }
            else
            {
                VideoCapture1.Face_Tracking = null;
            }
        }

        private void ConfigureMotionDetectionEx()
        {
            if (cbMotionDetectionEx.Checked)
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

        private void ConfigureDecklink()
        {
            if (cbDecklinkOutput.Checked)
            {
                VideoCapture1.Decklink_Output = new DecklinkOutputSettings
                {
                    DVEncoding = cbDecklinkDV.Checked,
                    AnalogOutputIREUSA = cbDecklinkOutputNTSC.SelectedIndex == 0,
                    AnalogOutputSMPTE =
                                                            cbDecklinkOutputComponentLevels.SelectedIndex == 0,
                    BlackToDeckInCapture =
                                                            (DecklinkBlackToDeckInCapture)
                                                            cbDecklinkOutputBlackToDeck.SelectedIndex,
                    DualLinkOutputMode =
                                                            (DecklinkDualLinkMode)
                                                            cbDecklinkOutputDualLink.SelectedIndex,
                    HDTVPulldownOnOutput =
                                                            (DecklinkHDTVPulldownOnOutput)
                                                            cbDecklinkOutputHDTVPulldown.SelectedIndex,
                    SingleFieldOutputForSynchronousFrames =
                                                            (DecklinkSingleFieldOutputForSynchronousFrames)
                                                            cbDecklinkOutputSingleField.SelectedIndex,
                    VideoOutputDownConversionMode =
                                                            (DecklinkVideoOutputDownConversionMode)
                                                            cbDecklinkOutputDownConversion.SelectedIndex,
                    VideoOutputDownConversionModeAnalogUsed =
                                                            cbDecklinkOutputDownConversionAnalogOutput.Checked,
                    AnalogOutput =
                                                            (DecklinkAnalogOutput)cbDecklinkOutputAnalog.SelectedIndex
                };

                VideoCapture1.Decklink_Input = (DecklinkInput)cbDecklinkSourceInput.SelectedIndex;
                VideoCapture1.Decklink_Input_SMPTE = cbDecklinkSourceComponentLevels.SelectedIndex == 0;
                VideoCapture1.Decklink_Input_IREUSA = cbDecklinkSourceNTSC.SelectedIndex == 0;
                VideoCapture1.Decklink_Input_Capture_Timecode_Source =
                    (DecklinkCaptureTimecodeSource)cbDecklinkSourceTimecode.SelectedIndex;
            }
            else
            {
                VideoCapture1.Decklink_Output = null;
            }
        }

        private void SelectCrossbar()
        {
            if (VideoCapture1.Mode == VFVideoCaptureMode.VideoPreview || VideoCapture1.Mode == VFVideoCaptureMode.VideoCapture)
            {
                if (cbCrossBarAvailable.Enabled)
                {
                    // ReSharper disable RedundantIfElseBlock
                    if (rbCrossbarSimple.Checked)
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
            }
        }

        private void SetMP4Output(ref VFMP4Output mp4Output)
        {
            int tmp;

            // Main settings
            switch (cbMP4Mode.SelectedIndex)
            {
                case 0:
                    // v8 Legacy(XP compatible, CPU or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v8;
                    break;
                case 1:
                    // v10(CPU or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v10;
                    break;
                case 2:
                    // v10 nVidia NVENC
                    mp4Output.MP4Mode = VFMP4Mode.v10_NVENC;
                    break;
                default:
                    mp4Output.MP4Mode = VFMP4Mode.v11;
                    break;
            }
            
            if (mp4Output.MP4Mode == VFMP4Mode.v8 || mp4Output.MP4Mode == VFMP4Mode.v10)
            {
                // Legacy / Modern settings

                // Video H264 settings
                switch (cbH264Profile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileAuto;
                        break;
                    case 1:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileBaseline;
                        break;
                    case 2:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileMain;
                        break;
                    case 3:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh;
                        break;
                    case 4:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh10;
                        break;
                    case 5:
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh422;
                        break;
                }

                switch (cbH264Level.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10.Level = VFH264Level.LevelAuto;
                        break;
                    case 1:
                        mp4Output.Video_v10.Level = VFH264Level.Level1;
                        break;
                    case 2:
                        mp4Output.Video_v10.Level = VFH264Level.Level11;
                        break;
                    case 3:
                        mp4Output.Video_v10.Level = VFH264Level.Level12;
                        break;
                    case 4:
                        mp4Output.Video_v10.Level = VFH264Level.Level13;
                        break;
                    case 5:
                        mp4Output.Video_v10.Level = VFH264Level.Level2;
                        break;
                    case 6:
                        mp4Output.Video_v10.Level = VFH264Level.Level21;
                        break;
                    case 7:
                        mp4Output.Video_v10.Level = VFH264Level.Level22;
                        break;
                    case 8:
                        mp4Output.Video_v10.Level = VFH264Level.Level3;
                        break;
                    case 9:
                        mp4Output.Video_v10.Level = VFH264Level.Level31;
                        break;
                    case 10:
                        mp4Output.Video_v10.Level = VFH264Level.Level32;
                        break;
                    case 11:
                        mp4Output.Video_v10.Level = VFH264Level.Level4;
                        break;
                    case 12:
                        mp4Output.Video_v10.Level = VFH264Level.Level41;
                        break;
                    case 13:
                        mp4Output.Video_v10.Level = VFH264Level.Level42;
                        break;
                    case 14:
                        mp4Output.Video_v10.Level = VFH264Level.Level5;
                        break;
                    case 15:
                        mp4Output.Video_v10.Level = VFH264Level.Level51;
                        break;
                }

                switch (cbH264TargetUsage.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.Auto;
                        break;
                    case 1:
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.BestQuality;
                        break;
                    case 2:
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.Balanced;
                        break;
                    case 3:
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.BestSpeed;
                        break;
                }

                switch (cbH264PictureType.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10.PictureType = VFH264PictureType.Auto;
                        break;
                    case 1:
                        mp4Output.Video_v10.PictureType = VFH264PictureType.Frame;
                        break;
                    case 2:
                        mp4Output.Video_v10.PictureType = VFH264PictureType.TFF;
                        break;
                    case 3:
                        mp4Output.Video_v10.PictureType = VFH264PictureType.BFF;
                        break;
                }

                mp4Output.Video_v10.RateControl = (VFH264RateControl)cbH264RateControl.SelectedIndex;
                mp4Output.Video_v10.MBEncoding = (VFH264MBEncoding)cbH264MBEncoding.SelectedIndex;
                mp4Output.Video_v10.GOP = cbH264GOP.Checked;
                mp4Output.Video_v10.BitrateAuto = cbH264AutoBitrate.Checked;

                int.TryParse(edH264IDR.Text, out tmp);
                mp4Output.Video_v10.IDR_Period = tmp;

                int.TryParse(edH264P.Text, out tmp);
                mp4Output.Video_v10.P_Period = tmp;

                int.TryParse(edH264Bitrate.Text, out tmp);
                mp4Output.Video_v10.Bitrate = tmp;
            }
            else if (mp4Output.MP4Mode == VFMP4Mode.v10_NVENC)
            {
                // NVENC settings
                switch (cbNVENCProfile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.Auto;
                        break;
                    case 1:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Baseline;
                        break;
                    case 2:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Main;
                        break;
                    case 3:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High;
                        break;
                    case 4:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High444;
                        break;
                    case 5:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ProgressiveHigh;
                        break;
                    case 6:
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ConstrainedHigh;
                        break;
                }

                switch (cbNVENCLevel.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.Auto;
                        break;
                    case 1:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_1;
                        break;
                    case 2:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_11;
                        break;
                    case 3:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_12;
                        break;
                    case 4:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_13;
                        break;
                    case 5:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_2;
                        break;
                    case 6:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_21;
                        break;
                    case 7:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_22;
                        break;
                    case 8:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_3;
                        break;
                    case 9:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_31;
                        break;
                    case 10:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_32;
                        break;
                    case 11:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_4;
                        break;
                    case 12:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_41;
                        break;
                    case 13:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_42;
                        break;
                    case 14:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_5;
                        break;
                    case 15:
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_51;
                        break;
                }

                mp4Output.Video_v10_NVENC.Bitrate = Convert.ToInt32(edNVENCBitrate.Text);
                mp4Output.Video_v10_NVENC.QP = Convert.ToInt32(edNVENCQP.Text);
                mp4Output.Video_v10_NVENC.RateControl = (VFNVENCRateControlMode)cbNVENCRateControl.SelectedIndex;
                mp4Output.Video_v10_NVENC.GOP = Convert.ToInt32(edNVENCGOP.Text);
                mp4Output.Video_v10_NVENC.BFrames = Convert.ToInt32(edNVENCBFrames.Text);
            }
            else
            {
                switch (cbMP4Mode.SelectedIndex)
                {
                    case 3:
                        //  v11 (CPU) H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.MS_H264;
                        break;
                    case 4:
                        //  v11 nVidia NVENC H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.NVENC_H264;
                        break;
                    case 5:
                        //  v11 Intel QuickSync H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.QSV_H264;
                        break;
                    case 6:
                        //  v11 AMD Radeon H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.AMD_H264;
                        break;
                    case 7:
                        //  v11 nVidia NVENC H265
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.NVENC_H265;
                        break;
                    case 8:
                        //  v11 AMD Radeon H265
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.AMD_H265;
                        break;
                }

                // Video H264 settings
                switch (cbMFProfile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v11.Profile = VFMFH264Profile.Base;
                        break;
                    case 1:
                        mp4Output.Video_v11.Profile = VFMFH264Profile.Main;
                        break;
                    case 2:
                        mp4Output.Video_v11.Profile = VFMFH264Profile.High;
                        break;
                }

                switch (cbMFLevel.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level1;
                        break;
                    case 1:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level11;
                        break;
                    case 2:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level12;
                        break;
                    case 3:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level13;
                        break;
                    case 4:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level2;
                        break;
                    case 5:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level21;
                        break;
                    case 6:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level22;
                        break;
                    case 7:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level3;
                        break;
                    case 8:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level31;
                        break;
                    case 9:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level32;
                        break;
                    case 10:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level4;
                        break;
                    case 11:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level41;
                        break;
                    case 12:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level42;
                        break;
                    case 13:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level5;
                        break;
                    case 14:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level51;
                        break;
                    case 15:
                        mp4Output.Video_v11.Level = VFMFH264Level.Level51;
                        break;
                }

                mp4Output.Video_v11.RateControl = (VFMFCommonRateControlMode)cbMFRateControl.SelectedIndex;

                mp4Output.Video_v11.CABAC = cbMFCABAC.Checked;
                mp4Output.Video_v11.LowLatencyMode = cbMFLowLatency.Checked;

                int.TryParse(edMFBFramesCount.Text, out tmp);
                mp4Output.Video_v11.DefaultBPictureCount = tmp;

                int.TryParse(edMFKeyFrameSpacing.Text, out tmp);
                mp4Output.Video_v11.MaxKeyFrameSpacing = tmp;

                int.TryParse(edMFBitrate.Text, out tmp);
                mp4Output.Video_v11.AvgBitrate = tmp;

                int.TryParse(edMFMaxBitrate.Text, out tmp);
                mp4Output.Video_v11.MaxBitrate = tmp;

                int.TryParse(edMFQuality.Text, out tmp);
                mp4Output.Video_v11.Quality = tmp;
            }

            // video resize
            if (cbMP4Resize.Checked)
            {
                mp4Output.Video_Resize = new VideoResizeSettings
                {
                    Width = Convert.ToInt32(edMP4ResizeWidth.Text),
                    Height = Convert.ToInt32(edMP4ResizeHeight.Text),
                    LetterBox = cbMP4ResizeLetterbox.Checked
                };

                switch (cbResizeMode.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_Resize.Mode = VFResizeMode.NearestNeighbor;
                        break;
                    case 1:
                        mp4Output.Video_Resize.Mode = VFResizeMode.Bilinear;
                        break;
                    case 2:
                        mp4Output.Video_Resize.Mode = VFResizeMode.Bicubic;
                        break;
                    case 3:
                        mp4Output.Video_Resize.Mode = VFResizeMode.Lancroz;
                        break;
                }
            }

            // Audio AAC settings
            int.TryParse(cbAACBitrate.Text, out tmp);
            mp4Output.Audio_AAC.Bitrate = tmp;

            mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACVersion.SelectedIndex;
            mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
            mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObjectType.SelectedIndex + 1);

            mp4Output.UseSpecialSyncMode = cbMP4UseSpecialSyncMode.Checked;

            if (cbMP4CustomAVSettings.Checked)
            {
                mp4Output.MP4V10Flags = 0;
                if (cbMP4TimeAdjust.Checked)
                {
                    mp4Output.MP4V10Flags |= (int)MP4V10Flags.TimeAdjust;
                }

                if (cbMP4TimeOverride.Checked)
                {
                    mp4Output.MP4V10Flags |= (int)MP4V10Flags.TimeOverride;
                }
            }
        }

        private void SetDirectCaptureCustomOutput(ref VFDirectCaptureCustomOutput directCaptureOutput)
        {
            if (rbCustomUseVideoCodecsCat.Checked)
            {
                directCaptureOutput.Video_Codec = cbCustomVideoCodecs.Text;
                directCaptureOutput.Video_Codec_UseFiltersCategory = false;
            }
            else
            {
                directCaptureOutput.Video_Codec = cbCustomDSFilterV.Text;
                directCaptureOutput.Video_Codec_UseFiltersCategory = true;
            }

            if (rbCustomUseAudioCodecsCat.Checked)
            {
                directCaptureOutput.Audio_Codec = cbCustomAudioCodecs.Text;
                directCaptureOutput.Audio_Codec_UseFiltersCategory = false;
            }
            else
            {
                directCaptureOutput.Audio_Codec = cbCustomDSFilterA.Text;
                directCaptureOutput.Audio_Codec_UseFiltersCategory = true;
            }

            directCaptureOutput.MuxFilter_Name = cbCustomMuxer.Text;
            directCaptureOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.Checked;
            directCaptureOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.Checked;
            directCaptureOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text;
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
            ffmpegDLLOutput.Video_Interlace = cbFFVideoInterlace.Checked;
        }

        private void SetWebMOutput(ref VFWebMOutput webmOutput)
        {
            webmOutput.Audio_Quality = tbWebMAudioQuality.Value;

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
            webmOutput.Video_AutoAltRef = cbWebMVideoAutoAltRef.Checked;
            webmOutput.Video_ErrorResilient = cbWebMVideoErrorResilent.Checked;
            webmOutput.Video_SpatialResampling_Allowed = cbWebMVideoSpatialResamplingAllowed.Checked;
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

        private void SetGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            gifOutput.FrameRate = Convert.ToDouble(edGIFFrameRate.Text);
            gifOutput.ForcedVideoWidth = Convert.ToInt32(edGIFWidth.Text);
            gifOutput.ForcedVideoHeight = Convert.ToInt32(edGIFHeight.Text);
        }

        private void SetMP3Output(ref VFMP3Output mp3Output)
        {
            // main
            mp3Output.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text);
            mp3Output.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text);
            mp3Output.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text);
            mp3Output.SampleRate = Convert.ToInt32(cbLameSampleRate.Text);
            mp3Output.VBR_Quality = tbLameVBRQuality.Value;
            mp3Output.EncodingQuality = tbLameEncodingQuality.Value;

            if (rbLameStandardStereo.Checked)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.StandardStereo;
            }
            else if (rbLameJointStereo.Checked)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.JointStereo;
            }
            else if (rbLameDualChannels.Checked)
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.DualStereo;
            }
            else
            {
                mp3Output.ChannelsMode = VFLameChannelsMode.Mono;
            }

            mp3Output.VBR_Mode = rbLameVBR.Checked;

            // other
            mp3Output.Copyright = cbLameCopyright.Checked;
            mp3Output.Original = cbLameOriginal.Checked;
            mp3Output.CRCProtected = cbLameCRCProtected.Checked;
            mp3Output.ForceMono = cbLameForceMono.Checked;
            mp3Output.StrictlyEnforceVBRMinBitrate = cbLameStrictlyEnforceVBRMinBitrate.Checked;
            mp3Output.VoiceEncodingMode = cbLameVoiceEncodingMode.Checked;
            mp3Output.KeepAllFrequencies = cbLameKeepAllFrequences.Checked;
            mp3Output.StrictISOCompliance = cbLameStrictISOCompilance.Checked;
            mp3Output.DisableShortBlocks = cbLameDisableShortBlocks.Checked;
            mp3Output.EnableXingVBRTag = cbLameEnableXingVBRTag.Checked;
            mp3Output.ModeFixed = cbLameModeFixed.Checked;
        }

        private void SetACMOutput(ref VFACMOutput acmOutput)
        {
            acmOutput.Channels = Convert.ToInt32(cbChannels2.Text);
            acmOutput.BPS = Convert.ToInt32(cbBPS2.Text);
            acmOutput.SampleRate = Convert.ToInt32(cbSampleRate2.Text);

            acmOutput.Name = cbAudioCodecs2.Text;
        }

        private void SetFLACOutput(ref VFFLACOutput flacOutput)
        {
            flacOutput.Level = tbFLACLevel.Value;
            flacOutput.BlockSize = Convert.ToInt32(cbFLACBlockSize.Text);
            flacOutput.AdaptiveMidSideCoding = cbFLACAdaptiveMidSideCoding.Checked;
            flacOutput.ExhaustiveModelSearch = cbFLACExhaustiveModelSearch.Checked;
            flacOutput.LPCOrder = tbFLACLPCOrder.Value;
            flacOutput.MidSideCoding = cbFLACMidSideCoding.Checked;
            flacOutput.RiceMin = Convert.ToInt32(edFLACRiceMin.Text);
            flacOutput.RiceMax = Convert.ToInt32(edFLACRiceMax.Text);
        }

        private void SetCustomOutput(ref VFCustomOutput customOutput)
        {
            if (rbCustomUseVideoCodecsCat.Checked)
            {
                customOutput.Video_Codec = cbCustomVideoCodecs.Text;
                customOutput.Video_Codec_UseFiltersCategory = false;
            }
            else
            {
                customOutput.Video_Codec = cbCustomDSFilterV.Text;
                customOutput.Video_Codec_UseFiltersCategory = true;
            }

            if (rbCustomUseAudioCodecsCat.Checked)
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
            customOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.Checked;
            customOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.Checked;
            customOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text;
        }

        private void SetDVOutput(ref VFDVOutput dvOutput)
        {
            dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text);
            dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text);

            if (rbDVPAL.Checked)
            {
                dvOutput.Video_Format = VFDVVideoFormat.PAL;
            }
            else
            {
                dvOutput.Video_Format = VFDVVideoFormat.NTSC;
            }

            dvOutput.Type2 = rbDVType2.Checked;
        }

        private void SetSpeexOutput()
        {
            VideoCapture1.Output_Format = new VFSpeexOutput
            {
                BitRate = tbSpeexBitrate.Value,
                BitrateControl = (SpeexBitrateControl)cbSpeexBitrateControl.SelectedIndex,
                Mode = (SpeexEncodeMode)cbSpeexMode.SelectedIndex,
                MaxBitRate = tbSpeexMaxBitrate.Value,
                Complexity = tbSpeexComplexity.Value,
                Quality = tbSpeexQuality.Value,
                UseAGC = cbSpeexAGC.Checked,
                UseDTX = cbSpeexDTX.Checked,
                UseDenoise = cbSpeexDenoise.Checked,
                UseVAD = cbSpeexVAD.Checked
            };
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

        private void SetOGGOutput()
        {
            var oggVorbisOutput = new VFOGGVorbisOutput
            {
                Quality = Convert.ToInt32(edOGGQuality.Text),
                MinBitRate = Convert.ToInt32(cbOGGMinimum.Text),
                MaxBitRate = Convert.ToInt32(cbOGGMaximum.Text),
                AvgBitRate = Convert.ToInt32(cbOGGAverage.Text)
            };

            if (rbOGGQuality.Checked)
            {
                oggVorbisOutput.Mode = VFVorbisMode.Quality;
            }
            else
            {
                oggVorbisOutput.Mode = VFVorbisMode.Bitrate;
            }

            VideoCapture1.Output_Format = oggVorbisOutput;
        }

        private void SetAVIOutput(ref VFAVIOutput aviOutput)
        {
            aviOutput.ACM.Name = cbAudioCodecs.Text;
            aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
            aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
            aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);
            aviOutput.Video_Codec = cbVideoCodecs.Text;
            aviOutput.Video_UseCompression = !cbUncVideo.Checked;
            aviOutput.Video_UseCompression_DecodeUncompressedToRGB = cbDecodeToRGB.Checked;
            aviOutput.ACM.UseCompression = !cbUncAudio.Checked;

            if (cbUseMP3InAVI.Checked)
            {
                aviOutput.Audio_UseMP3Encoder = true;
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                aviOutput.MP3 = mp3Output;
            }
        }

        private void SetMKVOutput(ref VFMKVOutput mkvOutput)
        {
            mkvOutput.ACM.Name = cbAudioCodecs.Text;
            mkvOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text);
            mkvOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text);
            mkvOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text);
            mkvOutput.Video_Codec = cbVideoCodecs.Text;
            mkvOutput.Video_UseCompression = !cbUncVideo.Checked;
            mkvOutput.Video_UseCompression_DecodeUncompressedToRGB = cbDecodeToRGB.Checked;
            mkvOutput.ACM.UseCompression = !cbUncAudio.Checked;

            if (cbUseMP3InAVI.Checked)
            {
                mkvOutput.Audio_UseMP3Encoder = true;
                var mp3Output = new VFMP3Output();
                SetMP3Output(ref mp3Output);
                mkvOutput.MP3 = mp3Output;
            }
        }

        private void ConfigureVUMeters()
        {
            VideoCapture1.Audio_VUMeter_Enabled = cbVUMeter.Checked;
            VideoCapture1.Audio_VUMeter_Pro_Enabled = cbVUMeterPro.Checked;

            if (VideoCapture1.Audio_VUMeter_Pro_Enabled)
            {
                VideoCapture1.Audio_VUMeter_Pro_Volume = tbVUMeterAmplification.Value;

                volumeMeter1.Boost = tbVUMeterBoost.Value / 10.0F;
                volumeMeter2.Boost = tbVUMeterBoost.Value / 10.0F;

                waveformPainter1.Boost = tbVUMeterBoost.Value / 10.0F;
                waveformPainter2.Boost = tbVUMeterBoost.Value / 10.0F;
            }
        }

        private void ConfigureNetworkStreaming()
        {
            VideoCapture1.Network_Streaming_Enabled = true;

            switch (cbNetworkStreamingMode.SelectedIndex)
            {
                case 0:
                    {
                        VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.WMV;

                        if (rbNetworkStreamingUseMainWMVSettings.Checked)
                        {
                            var wmvOutput = new VFWMVOutput();
                            FillWMVSettings(ref wmvOutput);
                            VideoCapture1.Network_Streaming_Output = wmvOutput;
                        }
                        else
                        {
                            var wmvOutput = new VFWMVOutput
                            {
                                Mode = VFWMVMode.ExternalProfile,
                                External_Profile_FileName = edNetworkStreamingWMVProfile.Text
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

                        // else
                        // {
                        //    VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.RTSP_FFMPEG_EXE;
                        //    VideoCapture1.Network_Streaming_FFMPEG_EXE_UseMainFFMPEGEXEOutputSettings = true;
                        //    VideoCapture1.FFMPEG_EXE_FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                        //    VideoCapture1.Network_Streaming_FFMPEG_EXE_OutputMuxer = VFFFMPEGEXEOutputMuxer.RTSP;
                        // }

                        VideoCapture1.Network_Streaming_URL = edNetworkRTSPURL.Text;

                        break;
                    }

                case 2:
                    {
                        VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.RTMP_FFMPEG_EXE;

                        var ffmpegOutput = new VFFFMPEGEXEOutput();

                        if (rbNetworkUDPFFMPEG.Checked)
                        {
                            ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                        }
                        else
                        {
                            SetFFMPEGEXESettings(ref ffmpegOutput);
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

                        if (rbNetworkUDPFFMPEG.Checked)
                        {
                            ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                        }
                        else
                        {
                            SetFFMPEGEXESettings(ref ffmpegOutput);
                        }

                        ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS;
                        VideoCapture1.Network_Streaming_Output = ffmpegOutput;

                        VideoCapture1.Network_Streaming_URL = edNetworkUDPURL.Text;

                        break;
                    }

                case 4:
                    {
                        if (rbNetworkSSSoftware.Checked)
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

                            if (rbNetworkSSFFMPEGDefault.Checked)
                            {
                                ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                            }
                            else
                            {
                                SetFFMPEGEXESettings(ref ffmpegOutput);
                            }

                            ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ISMV;
                            VideoCapture1.Network_Streaming_Output = ffmpegOutput;
                        }

                        VideoCapture1.Network_Streaming_URL = edNetworkSSURL.Text;

                        break;
                    }

                case 5:
                    {
                        VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.HLS_VLC_EXE;

                        var vlcOutput = new VFVLCEXEOutput();

                        //if (rbNetworkSSFFMPEGDefault.Checked)
                        //{
                        //    vlcOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                        //}
                        //else
                        //{
                        //    SetFFMPEGEXESettings(ref vlcOutput);
                        //}

                        // vlcOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ISMV;
                        VideoCapture1.Network_Streaming_Output = vlcOutput;

                        break;
                    }

                case 6:
                    {
                        VideoCapture1.Network_Streaming_Format = VFNetworkStreamingFormat.External;

                        break;
                    }
            }

            VideoCapture1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.Checked;
        }

        private void SelectCustomSource()
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
            VideoCapture1.Custom_Source.VideoFilenameOrURL = edCustomVideoSourceURL.Text;

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
            VideoCapture1.Custom_Source.AudioFilenameOrURL = edCustomAudioSourceURL.Text;
        }

        private void SelectBDASource()
        {
            VideoCapture1.BDA_Source = new BDASourceSettings
            {
                ReceiverName = cbBDAReceiver.Text,
                SourceType = (VFBDAType)cbBDADeviceStandard.SelectedIndex,
                SourceName = cbBDASourceDevice.Text
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

        private void SelectVideoCaptureSource()
        {
            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text;
            VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.Checked;
            VideoCapture1.Video_CaptureDevice_Format_UseBest = cbUseBestVideoInputFormat.Checked;
            VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text;

            if (cbFramerate.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureDevice_FrameRate = Convert.ToDouble(cbFramerate.Text, CultureInfo.CurrentCulture);
            }

            VideoCapture1.Video_CaptureDevice_UseClosedCaptions = cbUseClosedCaptions.Checked;
        }

        private void SelectIPCameraSource(out IPCameraSourceSettings settings)
        {
            settings = new IPCameraSourceSettings
            {
                URL = edIPUrl.Text
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

            settings.AudioCapture = cbIPAudioCapture.Checked;
            settings.Login = edIPLogin.Text;
            settings.Password = edIPPassword.Text;
            settings.ForcedFramerate = Convert.ToDouble(edIPForcedFramerate.Text);
            settings.ForcedFramerate_InstanceID = edIPForcedFramerateID.Text[0];
            settings.Debug_Enabled = cbDebugMode.Checked;
            settings.Debug_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                                      + "\\VisioForge\\ip_cam_log.txt";
            settings.VLC_ZeroClockJitterEnabled = cbVLCZeroClockJitter.Checked;
            settings.VLC_CustomLatency = Convert.ToInt32(edVLCCacheSize.Text);
           
            if (cbIPCameraONVIF.Checked)
            {
                settings.ONVIF_Source = true;

                if (cbONVIFProfile.SelectedIndex != -1)
                {
                    settings.ONVIF_SourceProfile = cbONVIFProfile.Text;
                }
            }

            if (cbIPDisconnect.Checked)
            {
                settings.DisconnectEventInterval = 5000;
            }
        }

        private bool SelectScreenSource(out ScreenCaptureSourceSettings settings)
        {
            settings = new ScreenCaptureSourceSettings();

            if (rbScreenCaptureWindow.Checked)
            {
                settings.Mode = VFScreenCaptureMode.Window;

                settings.WindowHandle = IntPtr.Zero;

                try
                {
                    settings.WindowHandle = FindWindow(edScreenCaptureWindowName.Text, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (settings.WindowHandle == IntPtr.Zero)
                {
                    MessageBox.Show("Incorrect window title for screen capture.");
                    return false;
                }
            }
            else if (rbScreenCaptureColorSource.Checked)
            {
                settings.Mode = VFScreenCaptureMode.Color;

                settings.FullScreen = rbScreenFullScreen.Checked;
                settings.Top = Convert.ToInt32(edScreenTop.Text);
                settings.Bottom = Convert.ToInt32(edScreenBottom.Text);
                settings.Left = Convert.ToInt32(edScreenLeft.Text);
                settings.Right = Convert.ToInt32(edScreenRight.Text);
            }
            else
            {
                settings.Mode = VFScreenCaptureMode.Screen;

                settings.FullScreen = rbScreenFullScreen.Checked;
                settings.Top = Convert.ToInt32(edScreenTop.Text);
                settings.Bottom = Convert.ToInt32(edScreenBottom.Text);
                settings.Left = Convert.ToInt32(edScreenLeft.Text);
                settings.Right = Convert.ToInt32(edScreenRight.Text);

                settings.DisplayIndex = Convert.ToInt32(cbScreenCaptureDisplayIndex.Text);
            }

            settings.FrameRate = Convert.ToInt32(edScreenFrameRate.Text);

            settings.GrabMouseCursor = cbScreenCapture_GrabMouseCursor.Checked;
            settings.AllowDesktopDuplicationEngine = cbScreenCapture_DesktopDuplication.Checked;

            return true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            // clear VU Meters
            peakMeterCtrl1.SetData(new int[19], 0, 19);
            peakMeterCtrl1.Stop();

            VideoCapture1.Stop();

            if (cbMultiscreenDrawOnPanels.Checked)
            {
                pnScreen1.Refresh();
                pnScreen2.Refresh();
                pnScreen3.Refresh();
            }

            foreach (var form in multiscreenWindows)
            {
                form.Close();
                form.Dispose();
            }

            multiscreenWindows.Clear();

            waveformPainter1.Clear();
            waveformPainter2.Clear();

            volumeMeter1.Clear();
            volumeMeter2.Clear();

            cbPIPDevices.Items.Clear();

            lbFilters.Items.Clear();
            VideoCapture1.Video_Filters_Clear();
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

        /// <summary>
        /// Audio codec combobox.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs.Text;
            btAudioSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        /// <summary>
        /// Audio input format combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        // ReSharper disable once UnusedParameter.Local
        // ReSharper disable once UnusedParameter.Local
        private void cbAudioInputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
        }

        /// <summary>
        /// Audio input line combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbAudioInputLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
        }

        /// <summary>
        /// Audio output device combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbAudioOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
        }

        /// <summary>
        /// Crossbar input combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbCrossbarInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCrossbarInput.SelectedIndex != -1)
            {
                string relatedInput;
                string relatedOutput;
                VideoCapture1.Video_CaptureDevice_CrossBar_GetRelated(cbCrossbarInput.Text, cbCrossbarOutput.Text, out relatedInput, out relatedOutput);
            }
        }

        /// <summary>
        /// Crossbar output combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbCrossbarOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCrossbarInput.Items.Clear();

            if (cbCrossbarOutput.SelectedIndex != -1)
            {
                foreach (string s in VideoCapture1.Video_CaptureDevice_CrossBar_GetInputsForOutput(cbCrossbarOutput.Text))
                {
                    cbCrossbarInput.Items.Add(s);
                }
            }

            string input = VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(cbCrossbarOutput.Text);

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

        /// <summary>
        /// TV Tuner combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbTVTuner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbTVTuner.Items.Count > 0) && (cbTVTuner.SelectedIndex != -1))
            {
                VideoCapture1.TVTuner_Name = cbTVTuner.Text;
                VideoCapture1.TVTuner_Read();

                cbTVMode.Items.Clear();
                foreach (string tunerMode in VideoCapture1.TVTuner_Modes())
                {
                    cbTVMode.Items.Add(tunerMode);
                }

                edVideoFreq.Text = Convert.ToString(VideoCapture1.TVTuner_VideoFrequency);
                edAudioFreq.Text = Convert.ToString(VideoCapture1.TVTuner_AudioFrequency);
                cbTVInput.SelectedIndex = cbTVInput.Items.IndexOf(VideoCapture1.TVTuner_InputType);
                cbTVMode.SelectedIndex = cbTVMode.Items.IndexOf(VideoCapture1.TVTuner_Mode);
                cbTVSystem.SelectedIndex = cbTVSystem.Items.IndexOf(VideoCapture1.TVTuner_TVFormat);
                cbTVCountry.SelectedIndex = cbTVCountry.Items.IndexOf(VideoCapture1.TVTuner_Country);
            }
        }

        /// <summary>
        /// Video codec combobox event.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void cbVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbVideoCodecs.Text;
            btVideoSettings.Enabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (VideoCapture1.Status == VFVideoCaptureStatus.Work)
            {
                VideoCapture1.Stop();
            }
        }

        private void cbGreyscale_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectGrayscale grayscale;
            var effect = VideoCapture1.Video_Effects_Get("Grayscale");
            if (effect == null)
            {
                grayscale = new VFVideoEffectGrayscale(cbGreyscale.Checked);
                VideoCapture1.Video_Effects_Add(grayscale);
            }
            else
            {
                grayscale = effect as IVFVideoEffectGrayscale;
                if (grayscale != null)
                {
                    grayscale.Enabled = cbGreyscale.Checked;
                }
            }
        }

        private void btSaveScreenshot_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            int customWidth = 0;
            int customHeight = 0;

            if (cbScreenshotResize.Checked)
            {
                customWidth = Convert.ToInt32(edScreenshotWidth.Text);
                customHeight = Convert.ToInt32(edScreenshotHeight.Text);
            }

            switch (cbImageType.SelectedIndex)
            {
                case 0:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0, customWidth, customHeight);
                    break;
                case 1:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, tbJPEGQuality.Value, customWidth, customHeight);
                    break;
                case 2:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0, customWidth, customHeight);
                    break;
                case 3:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0, customWidth, customHeight);
                    break;
                case 4:
                    VideoCapture1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0, customWidth, customHeight);
                    break;
            }
        }

        private void tbJPEGQuality_Scroll(object sender, EventArgs e)
        {
            lbJPEGQuality.Text = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                edTextLogo.Font = fontDialog1.Font;
                btTextLogoUpdateParams_Click(null, null);
            }
        }

        private void cbTextLogo_CheckedChanged(object sender, EventArgs e)
        {
            btTextLogoUpdateParams_Click(null, null);
        }

        private void cbInvert_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectInvert invert;
            var effect = VideoCapture1.Video_Effects_Get("Invert");
            if (effect == null)
            {
                invert = new VFVideoEffectInvert(cbInvert.Checked);
                VideoCapture1.Video_Effects_Add(invert);
            }
            else
            {
                invert = effect as IVFVideoEffectInvert;
                if (invert != null)
                {
                    invert.Enabled = cbInvert.Checked;
                }
            }
        }

        private void tbAdjContrast_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Contrast, tbAdjContrast.Value, cbAdjContrastAuto.Checked);
            lbAdjContrastCurrent.Text = "Current: " + Convert.ToString(tbAdjContrast.Value);
        }

        private void tbAdjHue_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Hue, tbAdjHue.Value, cbAdjHueAuto.Checked);
            lbAdjHueCurrent.Text = "Current: " + Convert.ToString(tbAdjHue.Value);
        }

        private void tbAdjSaturation_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Saturation, tbAdjSaturation.Value, cbAdjSaturationAuto.Checked);
            lbAdjSaturationCurrent.Text = "Current: " + Convert.ToString(tbAdjSaturation.Value);
        }

        private void cbUseAudioInputFromVideoCaptureDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbVideoInputDevice.Text))
            {
                VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.Checked;
                cbAudioInputDevice_SelectedIndexChanged(null, null);

                cbAudioInputDevice.Enabled = !cbUseAudioInputFromVideoCaptureDevice.Checked;
                btAudioInputDeviceSettings.Enabled = !cbUseAudioInputFromVideoCaptureDevice.Checked;
            }
        }

        private void cbCustomVideoCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomVideoCodecs.Text;
            btCustomVideoCodecSettings.Enabled = VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomAudioCodecs.Text;
            btCustomAudioCodecSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodecs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs2.Text;
            btAudioSettings2.Enabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterV.Text;
            btCustomDSFiltersVSettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterA.Text;
            btCustomDSFiltersASettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomMuxer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomMuxer.Text;
            btCustomMuxerSettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomFilewriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomFilewriter.Text;
            btCustomFilewriterSettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void rbVR_CheckedChanged(object sender, EventArgs e)
        {
            cbScreenFlipVertical.Enabled = rbVMR9.Checked || rbDirect2D.Checked;
            cbScreenFlipHorizontal.Enabled = rbVMR9.Checked || rbDirect2D.Checked;
            cbDirect2DRotate.Enabled = rbDirect2D.Checked;

            if (VideoCapture1.Video_Renderer == null)
            {
                VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            if (rbVMR9.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else if (rbEVR.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (rbVR.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
            else if (rbDirect2D.Checked)
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D;
            }
            else
            {
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.None;
            }
        }

        private void btVideoCaptureDeviceSettings_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbVideoInputDevice.Text);
        }

        private void btAudioInputDeviceSettings_Click(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if ((cbCrossbarInput.SelectedIndex != -1) && (cbCrossbarOutput.SelectedIndex != -1))
            {
                VideoCapture1.Video_CaptureDevice_CrossBar_Connect(cbCrossbarInput.Text, cbCrossbarOutput.Text, cbConnectRelated.Checked);

                lbRotes.Items.Clear();
                for (int i = 0; i < cbCrossbarOutput.Items.Count; i++)
                {
                    string input = VideoCapture1.Video_CaptureDevice_CrossBar_GetConnectedInputForOutput(cbCrossbarOutput.Items[i].ToString());
                    lbRotes.Items.Add("Input: " + input + ", Output: " + cbCrossbarOutput.Items[i]);
                }
            }
        }

        private void btCustomAudioCodecSettings_Click(object sender, EventArgs e)
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

        private void btCustomDSFiltersASettings_Click(object sender, EventArgs e)
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

        private void btCustomDSFiltersVSettings_Click(object sender, EventArgs e)
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

        private void btCustomFilewriterSettings_Click(object sender, EventArgs e)
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

        private void btCustomMuxerSettings_Click(object sender, EventArgs e)
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

        private void btCustomVideoCodecSettings_Click(object sender, EventArgs e)
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

        /// <summary>
        /// DV Fast Forward.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void btDVFF_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.FastForward);
        }

        /// <summary>
        /// DV pause.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event args.
        /// </param>
        private void btDVPause_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Pause);
        }

        private void btDVRewind_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Rew);
        }

        private void btDVPlay_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Play);
        }

        private void btDVStepFWD_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepFw);
        }

        private void btDVStepRev_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.StepRev);
        }

        private void btDVStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.DV_SendCommand(VFDVCommand.Stop);
        }

        private void btRefreshClients_Click(object sender, EventArgs e)
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

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void btStartTune_Click(object sender, EventArgs e)
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

        private void btStopTune_Click(object sender, EventArgs e)
        {
            VideoCapture1.TVTuner_TuneChannels_Stop();
        }

        private void btUseThisChannel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(edChannel.Text) <= 10000)
            {
                // channel
                VideoCapture1.TVTuner_Channel = Convert.ToInt32(edChannel.Text);
            }
            else
            {
                // must be -1 to use frequency
                VideoCapture1.TVTuner_Channel = -1;
                VideoCapture1.TVTuner_Frequency = Convert.ToInt32(edChannel.Text);
            }

            VideoCapture1.TVTuner_Apply();
            VideoCapture1.TVTuner_Read();
            edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
            edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
        }

        private void cbTVCountry_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbImageLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoCapture1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.Checked);
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

            imageLogo.Enabled = cbImageLogo.Checked;
            imageLogo.Filename = edImageLogoFilename.Text;
            imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text);
            imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text);
            imageLogo.TransparencyLevel = tbImageLogoTransp.Value;
            imageLogo.ColorKey = pnImageLogoColorKey.ForeColor;
            imageLogo.UseColorKey = cbImageLogoUseColorKey.Checked;
            imageLogo.AnimationEnabled = true;

            if (cbImageLogoShowAlways.Checked)
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

        private void cbImageLogoShowAlways_CheckedChanged(object sender, EventArgs e)
        {
            edImageLogoStartTime.Enabled = !cbImageLogoShowAlways.Checked;
            edImageLogoStopTime.Enabled = !cbImageLogoShowAlways.Checked;
            lbGraphicLogoStartTime.Enabled = !cbImageLogoShowAlways.Checked;
            lbGraphicLogoStopTime.Enabled = !cbImageLogoShowAlways.Checked;

            cbImageLogo_CheckedChanged(null, null);
        }

        private void cbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoCapture1.Video_Renderer == null)
            {
                VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            if (cbStretch.Checked)
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoCapture1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.Video_Renderer_Update();
        }

        private void cbTVMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTVMode.SelectedIndex != -1)
            {
                VFTVTunerMode mode;
                Enum.TryParse(cbTVMode.Text, true, out mode);
                VideoCapture1.TVTuner_Mode = mode;

                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                cbTVChannel.Items.Clear();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTVChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTVChannel.SelectedIndex != -1)
            {
                int k = Convert.ToInt32(cbTVChannel.Text);

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

        private void cbTVInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTVInput.SelectedIndex != -1)
            {
                VideoCapture1.TVTuner_InputType = cbTVInput.Text;
                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbTVSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTVSystem.SelectedIndex != -1)
            {
                if (string.IsNullOrEmpty(VideoCapture1.TVTuner_Name))
                {
                    return;
                }

                VideoCapture1.TVTuner_TVFormat = VideoCapture1.TVTuner_TVFormat_FromString(cbTVSystem.Text);
                VideoCapture1.TVTuner_Apply();
                VideoCapture1.TVTuner_Read();
                edVideoFreq.Text = VideoCapture1.TVTuner_VideoFrequency.ToString(CultureInfo.InvariantCulture);
                edAudioFreq.Text = VideoCapture1.TVTuner_AudioFrequency.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbUseBestAudioInputFormat_CheckedChanged(object sender, EventArgs e)
        {
            cbAudioInputFormat.Enabled = !cbUseBestAudioInputFormat.Checked;
        }

        private void cbUseBestVideoInputFormat_CheckedChanged(object sender, EventArgs e)
        {
            cbVideoInputFormat.Enabled = !cbUseBestVideoInputFormat.Checked;
        }

        private void cbUseSpecialFilewriter_CheckedChanged(object sender, EventArgs e)
        {
            cbCustomFilewriter.Enabled = cbUseSpecialFilewriter.Checked;
            btCustomFilewriterSettings.Enabled = cbUseSpecialFilewriter.Checked;
        }

        private void tbAudioVolume_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice_Volume_Set(tbAudioVolume.Value);
        }

        private void tbAudioBalance_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice_Balance_Set(tbAudioBalance.Value);
            VideoCapture1.Audio_OutputDevice_Balance_Get();
        }

        private void btAudioSettings2_Click(object sender, EventArgs e)
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

        private void btSelectScreenshotsFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                edScreenshotsFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btSelectWMVProfileNetwork_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edNetworkStreamingWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            VideoCapture1.Pause();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            VideoCapture1.Resume();
        }

        private void btMPEGEncoderShowDialog_Click(object sender, EventArgs e)
        {
            if (cbMPEGEncoder.SelectedIndex != -1)
            {
                VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = cbMPEGEncoder.Text;
                VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_ShowDialog(IntPtr.Zero);
            }
        }

        private void cbUncVideo_CheckedChanged(object sender, EventArgs e)
        {
            cbVideoCodecs.Enabled = !cbUncVideo.Checked;
            btVideoSettings.Enabled = !cbUncVideo.Checked;
            cbDecodeToRGB.Enabled = cbUncVideo.Checked;

            if (cbVideoCodecs.Enabled)
            {
                cbVideoCodecs_SelectedIndexChanged(null, null);
            }
            else
            {
                btVideoSettings.Enabled = false;
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                string name = cbFilters.Text;
                btFilterSettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                    VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterAdd_Click(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                VideoCapture1.Video_Filters_Add(new VFCustomProcessingFilter(cbFilters.Text));
                lbFilters.Items.Add(cbFilters.Text);
            }
        }

        private void btFilterSettings_Click(object sender, EventArgs e)
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

        private void lbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.Text;
                btFilterSettings2.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                                            VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterSettings2_Click(object sender, EventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.Text;

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

        private void btFilterDeleteAll_Click(object sender, EventArgs e)
        {
            lbFilters.Items.Clear();
            VideoCapture1.Video_Filters_Clear();
        }

        private void cbPIPDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPIPDevice.SelectedIndex != -1)
            {
                cbPIPFormat.Items.Clear();
                var deviceItem = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbPIPDevice.Text);
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

                    VideoCapture1.PIP_Sources_Device_GetCrossbar(cbPIPDevice.Text);
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

        private void cbMPEGVideoDecoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMPEGVideoDecoder.SelectedIndex < 1)
            {
                btMPEGVidDecSetting.Enabled = false;
            }
            else
            {
                string name = cbMPEGVideoDecoder.Text;
                btMPEGVidDecSetting.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                  VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbMPEGAudioDecoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMPEGAudioDecoder.SelectedIndex < 1)
            {
                btMPEGAudDecSettings.Enabled = false;
            }
            else
            {
                string name = cbMPEGVideoDecoder.Text;
                btMPEGAudDecSettings.Enabled = VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                  VideoCapture.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btMPEGVidDecSetting_Click(object sender, EventArgs e)
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

        private void btMPEGAudDecSettings_Click(object sender, EventArgs e)
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

        private void btScreenCaptureUpdate_Click(object sender, EventArgs e)
        {
            VideoCapture1.Screen_Capture_UpdateParameters(
                Convert.ToInt32(edScreenLeft.Text),
                Convert.ToInt32(edScreenTop.Text),
                cbScreenCapture_GrabMouseCursor.Checked);
        }

        private void cbPIPFormatUseBest_CheckedChanged(object sender, EventArgs e)
        {
            cbPIPFormat.Enabled = !cbPIPFormatUseBest.Checked;
        }

        private void btPIPAddDevice_Click(object sender, EventArgs e)
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
                    cbPIPFormatUseBest.Checked,
                    Convert.ToDouble(frameRate),
                    input,
                    Convert.ToInt32(edPIPVidCapLeft.Text),
                    Convert.ToInt32(edPIPVidCapTop.Text),
                    Convert.ToInt32(edPIPVidCapWidth.Text),
                    Convert.ToInt32(edPIPVidCapHeight.Text));

                cbPIPDevices.Items.Add(cbPIPDevice.Text);
            }
        }

        private void tbGraphicLogoTransp_Scroll(object sender, EventArgs e)
        {
            cbImageLogo_CheckedChanged(null, null);
        }

        private void cbGraphicLogoUseColorKey_CheckedChanged(object sender, EventArgs e)
        {
            cbImageLogo_CheckedChanged(null, null);
        }

        private void pnGraphicLogoColorKey_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnImageLogoColorKey.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnImageLogoColorKey.BackColor = colorDialog1.Color;
            }
        }

        private void btOSDInit_Click(object sender, EventArgs e)
        {
            VideoCapture1.OSD_Init();
        }

        private void btOSDDeinit_Click(object sender, EventArgs e)
        {
            VideoCapture1.OSD_Destroy();
        }

        private void btOSDClearLayers_Click(object sender, EventArgs e)
        {
            VideoCapture1.OSD_Layers_Clear();
            lbOSDLayers.Items.Clear();
        }

        private void btOSDLayerAdd_Click(object sender, EventArgs e)
        {
            VideoCapture1.OSD_Layers_Create(
                Convert.ToInt32(edOSDLayerLeft.Text),
                Convert.ToInt32(edOSDLayerTop.Text),
                Convert.ToInt32(edOSDLayerWidth.Text),
                Convert.ToInt32(edOSDLayerHeight.Text));
            lbOSDLayers.Items.Add("layer " + Convert.ToString(lbOSDLayers.Items.Count + 1));
        }

        private void btOSDApplyLayer_Click(object sender, EventArgs e)
        {
            if (lbOSDLayers.SelectedIndex != -1)
            {
                VideoCapture1.OSD_Layers_Apply(lbOSDLayers.SelectedIndex);
            }
        }

        private void btOSDSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                edOSDImageFilename.Text = openFileDialog2.FileName;
            }
        }

        private void btOSDImageDraw_Click(object sender, EventArgs e)
        {
            if (lbOSDLayers.SelectedIndex != -1)
            {
                if (cbOSDImageTranspColor.Checked)
                {
                    VideoCapture1.OSD_Layers_Draw_ImageFromFile(
                        lbOSDLayers.SelectedIndex,
                        edOSDImageFilename.Text,
                        Convert.ToInt32(edOSDImageLeft.Text),
                        Convert.ToInt32(edOSDImageTop.Text),
                        true,
                        pnOSDColorKey.BackColor);
                }
                else
                {
                    VideoCapture1.OSD_Layers_Draw_ImageFromFile(
                        lbOSDLayers.SelectedIndex,
                        edOSDImageFilename.Text,
                        Convert.ToInt32(edOSDImageLeft.Text),
                        Convert.ToInt32(edOSDImageTop.Text),
                        false,
                        Color.Black);
                }
            }
        }

        private void btOSDSelectFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                edOSDText.Font = fontDialog1.Font;
                edOSDText.ForeColor = fontDialog1.Color;
            }
        }

        private void btOSDTextDraw_Click(object sender, EventArgs e)
        {
            if (lbOSDLayers.SelectedIndex != -1)
            {
                Font fnt = edOSDText.Font;
                Color color = edOSDText.ForeColor;

                VideoCapture1.OSD_Layers_Draw_Text(
                    lbOSDLayers.SelectedIndex,
                    Convert.ToInt32(edOSDTextLeft.Text),
                    Convert.ToInt32(edOSDTextTop.Text),
                    edOSDText.Text,
                    fnt,
                    color);
            }
        }

        private void btOSDSetTransp_Click(object sender, EventArgs e)
        {
            if (lbOSDLayers.SelectedIndex != -1)
            {
                VideoCapture1.OSD_Layers_SetTransparency(lbOSDLayers.SelectedIndex, (byte)tbOSDTranspLevel.Value);
                VideoCapture1.OSD_Layers_Apply(lbOSDLayers.SelectedIndex);
            }
        }

        private void btTextLogoUpdateParams_Click(object sender, EventArgs e)
        {
            VFTextRotationMode rotate;
            VFTextFlipMode flip;

            StringFormat formatFlags = new StringFormat();

            if (cbTextLogoVertical.Checked)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionVertical;
            }

            if (cbTextLogoRightToLeft.Checked)
            {
                formatFlags.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }

            formatFlags.Alignment = (StringAlignment)cbTextLogoAlign.SelectedIndex;

            IVFVideoEffectTextLogo textLogo;
            var effect = VideoCapture1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.Checked);
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

            textLogo.Enabled = cbTextLogo.Checked;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = fontDialog1.Font;
            textLogo.FontColor = fontDialog1.Color;

            textLogo.BackgroundTransparent = cbTextLogoTranspBG.Checked;
            textLogo.BackgroundColor = pnTextLogoBGColor.BackColor;
            textLogo.StringFormat = formatFlags;
            textLogo.Antialiasing = (TextRenderingHint)cbTextLogoAntialiasing.SelectedIndex;
            textLogo.DrawQuality = (InterpolationMode)cbTextLogoDrawMode.SelectedIndex;

            if (cbTextLogoUseRect.Checked)
            {
                textLogo.RectWidth = Convert.ToInt32(edTextLogoWidth.Text);
                textLogo.RectHeight = Convert.ToInt32(edTextLogoHeight.Text);
            }
            else
            {
                textLogo.RectWidth = 0;
                textLogo.RectHeight = 0;
            }

            if (rbTextLogoDegree0.Checked)
            {
                rotate = VFTextRotationMode.RmNone;
            }
            else if (rbTextLogoDegree90.Checked)
            {
                rotate = VFTextRotationMode.Rm90;
            }
            else if (rbTextLogoDegree180.Checked)
            {
                rotate = VFTextRotationMode.Rm180;
            }
            else
            {
                rotate = VFTextRotationMode.Rm270;
            }

            if (rbTextLogoFlipNone.Checked)
            {
                flip = VFTextFlipMode.None;
            }
            else if (rbTextLogoFlipX.Checked)
            {
                flip = VFTextFlipMode.X;
            }
            else if (rbTextLogoFlipY.Checked)
            {
                flip = VFTextFlipMode.Y;
            }
            else
            {
                flip = VFTextFlipMode.XAndY;
            }

            textLogo.RotationMode = rotate;
            textLogo.FlipMode = flip;

            textLogo.GradientEnabled = cbTextLogoGradientEnabled.Checked;
            textLogo.GradientMode = (VFTextGradientMode)cbTextLogoGradMode.SelectedIndex;
            textLogo.GradientColor1 = pnTextLogoGradColor1.BackColor;
            textLogo.GradientColor2 = pnTextLogoGradColor2.BackColor;

            textLogo.BorderMode = (VFTextEffectMode)cbTextLogoEffectrMode.SelectedIndex;
            textLogo.BorderInnerColor = pnTextLogoInnerColor.BackColor;
            textLogo.BorderOuterColor = pnTextLogoOuterColor.BackColor;
            textLogo.BorderInnerSize = Convert.ToInt32(edTextLogoInnerSize.Text);
            textLogo.BorderOuterSize = Convert.ToInt32(edTextLogoOuterSize.Text);

            textLogo.Shape = cbTextLogoShapeEnabled.Checked;
            textLogo.ShapeLeft = Convert.ToInt32(edTextLogoShapeLeft.Text);
            textLogo.ShapeTop = Convert.ToInt32(edTextLogoShapeTop.Text);
            textLogo.ShapeType = (VFTextShapeType)cbTextLogoShapeType.SelectedIndex;
            textLogo.ShapeWidth = Convert.ToInt32(edTextLogoShapeWidth.Text);
            textLogo.ShapeHeight = Convert.ToInt32(edTextLogoShapeHeight.Text);
            textLogo.ShapeColor = pnTextLogoShapeColor.BackColor;

            textLogo.TransparencyLevel = tbTextLogoTransp.Value;

            if (rbTextLogoDrawText.Checked)
            {
                textLogo.Mode = TextLogoMode.Text;
            }
            else if (rbTextLogoDrawDate.Checked)
            {
                textLogo.Mode = TextLogoMode.DateTime;
                textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss";
            }
            else if (rbTextLogoDrawFrameNumber.Checked)
            {
                textLogo.Mode = TextLogoMode.FrameNumber;
            }
            else
            {
                textLogo.Mode = TextLogoMode.Timestamp;
            }

            textLogo.Update();
        }

        private void pnTextLogoBGColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoBGColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoBGColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoGradColor1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoGradColor1.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoGradColor1.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoGradColor2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoGradColor2.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoGradColor2.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoInnerColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoInnerColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoInnerColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoOuterColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoOuterColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoOuterColor.BackColor = colorDialog1.Color;
            }
        }

        private void pnTextLogoShapeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnTextLogoShapeColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnTextLogoShapeColor.BackColor = colorDialog1.Color;
            }
        }

        private void cbScreenFlipVertical_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoCapture1.Video_Renderer == null)
            {
                VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            VideoCapture1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked;
            VideoCapture1.Video_Renderer_Update();
        }

        private void cbScreenFlipHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btMotDetUpdateSettings_Click(object sender, EventArgs e)
        {
            if (cbMotDetEnabled.Checked)
            {
                VideoCapture1.Motion_Detection = new MotionDetectionSettings
                {
                    Enabled = cbMotDetEnabled.Checked,
                    Compare_Red = cbCompareRed.Checked,
                    Compare_Green = cbCompareGreen.Checked,
                    Compare_Blue = cbCompareBlue.Checked,
                    Compare_Greyscale = cbCompareGreyscale.Checked,
                    Highlight_Color =
                                                             (VFMotionCHLColor)cbMotDetHLColor.SelectedIndex,
                    Highlight_Enabled = cbMotDetHLEnabled.Checked,
                    Highlight_Threshold = tbMotDetHLThreshold.Value,
                    FrameInterval = Convert.ToInt32(edMotDetFrameInterval.Text),
                    Matrix_Height = Convert.ToInt32(edMotDetMatrixHeight.Text),
                    Matrix_Width = Convert.ToInt32(edMotDetMatrixWidth.Text),
                    DropFrames_Enabled = cbMotDetDropFramesEnabled.Checked,
                    DropFrames_Threshold = tbMotDetDropFramesThreshold.Value
                };
                VideoCapture1.MotionDetection_Update();
            }
            else
            {
                VideoCapture1.Motion_Detection = null;
            }
        }

        #region Barcode detector

        public delegate void BarcodeDelegate(BarcodeEventArgs value);

        public void BarcodeDelegateMethod(BarcodeEventArgs value)
        {
            edBarcode.Text = value.Value;
            edBarcodeMetadata.Text = string.Empty;

            if (value.Metadata == null)
            {
                return;
            }

            foreach (var o in value.Metadata)
            {
                edBarcodeMetadata.Text += o.Key + ": " + o.Value + Environment.NewLine;
            }
        }

        private void VideoCapture1_OnBarcodeDetected(object sender, BarcodeEventArgs e)
        {
            // e.DetectorEnabled = false;

            BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        public delegate void MotionDelegate(MotionDetectionEventArgs e);

        public void MotionDelegateMethod(MotionDetectionEventArgs e)
        {
            string s = string.Empty;
            int k = 0;
            foreach (byte b in e.Matrix)
            {
                s += b.ToString("D3") + " ";

                if (k == VideoCapture1.Motion_Detection.Matrix_Width - 1)
                {
                    k = 0;
                    s += Environment.NewLine;
                }
                else
                {
                    k++;
                }
            }

            mmMotDetMatrix.Text = s.Trim();
            pbMotionLevel.Value = e.Level;
        }

        private void VideoCapture1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        private void btAudEqRefresh_Click(object sender, EventArgs e)
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

        private void btSignal_Click(object sender, EventArgs e)
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

        private void btZoomIn_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = VideoCapture1.Video_Renderer.Zoom_Ratio + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomOut_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_Ratio = VideoCapture1.Video_Renderer.Zoom_Ratio - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftDown_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftY = VideoCapture1.Video_Renderer.Zoom_ShiftY - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftLeft_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftX = VideoCapture1.Video_Renderer.Zoom_ShiftX - 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftRight_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftX = VideoCapture1.Video_Renderer.Zoom_ShiftX + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void btZoomShiftUp_Click(object sender, EventArgs e)
        {
            VideoCapture1.Video_Renderer.Zoom_ShiftY = VideoCapture1.Video_Renderer.Zoom_ShiftY + 10;
            VideoCapture1.Video_Renderer_Update();
        }

        private void cbAudAmplifyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked);
        }

        private void cbAudDynamicAmplifyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.Checked);
        }

        private void cbAudEqualizerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(sender, e);
        }

        private void cbAudSound3DEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked);
        }

        private void cbAudTrueBassEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.Checked);
        }

        private void cbStretch1_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch1.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(0, stretch, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked);
        }

        private void cbStretch2_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch2.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(1, stretch, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked);
        }

        private void cbStretch3_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch2.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(2, stretch, cbFlipHorizontal3.Checked, cbFlipVertical3.Checked);
        }

        private void cbWMVAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
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
            if (cbWMVAudioCodec.SelectedIndex != -1)
            {
                foreach (string format in VideoCapture1.WMV_CustomProfile_AudioFormats(cbWMVAudioCodec.Text, mode))
                {
                    cbWMVAudioFormat.Items.Add(format);
                }
            }
        }

        private void cbWMVAudioMode_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cbWMVVideoMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = VFWMVStreamMode.CBR;
            switch (cbWMVVideoMode.SelectedIndex)
            {
                case 0:
                    {
                        mode = VFWMVStreamMode.CBR;
                        edWMVVideoBitrate.Enabled = true;
                        edWMVVideoPeakBitrate.Enabled = false;
                        edWMVVideoQuality.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        mode = VFWMVStreamMode.VBRBitrate;
                        edWMVVideoBitrate.Enabled = true;
                        edWMVVideoPeakBitrate.Enabled = false;
                        edWMVVideoQuality.Enabled = false;
                        break;
                    }

                case 2:
                    {
                        mode = VFWMVStreamMode.VBRPeakBitrate;
                        edWMVVideoBitrate.Enabled = true;
                        edWMVVideoPeakBitrate.Enabled = true;
                        edWMVVideoQuality.Enabled = false;
                        break;
                    }

                case 3:
                    {
                        mode = VFWMVStreamMode.VBRQuality;
                        edWMVVideoBitrate.Enabled = false;
                        edWMVVideoPeakBitrate.Enabled = false;
                        edWMVVideoQuality.Enabled = true;
                        break;
                    }
            }

            cbWMVVideoCodec.Items.Clear();
            foreach (string codec in VideoCapture1.WMV_CustomProfile_VideoCodecs(mode))
            {
                cbWMVVideoCodec.Items.Add(codec);
            }
        }

        private void tbAdjBrightness_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Video_CaptureDevice_VideoAdjust_SetValue(VFVideoHardwareAdjustment.Brightness, tbAdjBrightness.Value, cbAdjBrightnessAuto.Checked);
            lbAdjBrightnessCurrent.Text = "Current: " + Convert.ToString(tbAdjBrightness.Value);
        }

        private void tbAud3DSound_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Sound3D(-1, 3, (ushort)tbAud3DSound.Value);
        }

        private void tbAudDynAmp_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void tbAudAttack_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void tbAudEq0_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, (sbyte)tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, (sbyte)tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, (sbyte)tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, (sbyte)tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, (sbyte)tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, (sbyte)tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, (sbyte)tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, (sbyte)tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, (sbyte)tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, (sbyte)tbAudEq9.Value);
        }

        private void tbAudTrueBass_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_TrueBass(-1, 4, 200, false, (ushort)tbAudTrueBass.Value);
        }

        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectContrast contrast;
            var effect = VideoCapture1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, tbContrast.Value);
                VideoCapture1.Video_Effects_Add(contrast);
            }
            else
            {
                contrast = effect as IVFVideoEffectContrast;
                if (contrast != null)
                {
                    contrast.Value = tbContrast.Value;
                }
            }
        }

        private void tbDarkness_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectDarkness darkness;
            var effect = VideoCapture1.Video_Effects_Get("Darkness");
            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, tbDarkness.Value);
                VideoCapture1.Video_Effects_Add(darkness);
            }
            else
            {
                darkness = effect as IVFVideoEffectDarkness;
                if (darkness != null)
                {
                    darkness.Value = tbDarkness.Value;
                }
            }
        }

        private void tbLightness_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectLightness lightness;
            var effect = VideoCapture1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, tbLightness.Value);
                VideoCapture1.Video_Effects_Add(lightness);
            }
            else
            {
                lightness = effect as IVFVideoEffectLightness;
                if (lightness != null)
                {
                    lightness.Value = tbLightness.Value;
                }
            }
        }

        private void tbSaturation_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectSaturation saturation;
            var effect = VideoCapture1.Video_Effects_Get("Saturation");
            if (effect == null)
            {
                saturation = new VFVideoEffectSaturation(tbSaturation.Value);
                VideoCapture1.Video_Effects_Add(saturation);
            }
            else
            {
                saturation = effect as IVFVideoEffectSaturation;
                if (saturation != null)
                {
                    saturation.Value = tbSaturation.Value;
                }
            }
        }

        private void tbAudAmplifyAmp_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, false);
        }

        private void tbAudRelease_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_DynamicAmplify(-1, 2, (ushort)tbAudAttack.Value, (ushort)tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void pnOSDColorKey_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnOSDColorKey.BackColor = colorDialog1.Color;
            }
        }

        private void cbFlipVertical1_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch1.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(0, stretch, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked);
        }

        private void cbFlipHorizontal1_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch1.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(0, stretch, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked);
        }

        private void cbFlipVertical2_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch2.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(1, stretch, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked);
        }

        private void cbFlipHorizontal2_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch2.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(1, stretch, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked);
        }

        private void cbFlipVertical3_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch3.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(2, stretch, cbFlipHorizontal3.Checked, cbFlipVertical3.Checked);
        }

        private void cbFlipHorizontal3_CheckedChanged(object sender, EventArgs e)
        {
            VFVideoRendererStretchMode stretch;
            if (cbStretch3.Checked)
            {
                stretch = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                stretch = VFVideoRendererStretchMode.Letterbox;
            }

            VideoCapture1.MultiScreen_SetParameters(2, stretch, cbFlipHorizontal3.Checked, cbFlipVertical3.Checked);
        }

        private void tbChromaKeyContrastLow_Scroll(object sender, EventArgs e)
        {
            if (VideoCapture1.ChromaKey != null)
            {
                VideoCapture1.ChromaKey.ContrastLow = tbChromaKeyContrastLow.Value;
            }
        }

        private void tbChromaKeyContrastHigh_Scroll(object sender, EventArgs e)
        {
            if (VideoCapture1.ChromaKey != null)
            {
                VideoCapture1.ChromaKey.ContrastHigh = tbChromaKeyContrastHigh.Value;
            }
        }

        private void btChromaKeySelectBGImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edChromaKeyImage.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void VideoCapture1_OnTVTunerTuneChannels(object sender, TVTunerTuneChannelsEventArgs e)
        {
            Application.DoEvents();

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

            Application.DoEvents();
        }

        #region VU Meter

        public delegate void VUDelegate(VUMeterEventArgs e);

        public void VUDelegateMethod(VUMeterEventArgs e)
        {
            peakMeterCtrl1.SetData(e.MeterData, 0, 19);
        }

        private void VideoCapture1_OnAudioVUMeter(object sender, VUMeterEventArgs e)
        {
            BeginInvoke(new VUDelegate(VUDelegateMethod), e);
        }

        #endregion

        private void btTest_Click(object sender, EventArgs e)
        {
            VideoCapture1.OutputFilename_ChangeOnTheFly(edOutput.Text + "(1)");

            ////ApplyEffect(VisioForge.MediaFramework.DXVideoEffects.Effects.GrayScaleEffect.GetData());

            ////return;

            //Task.Run(
            //    () =>
            //        {
            //            Bitmap CurrentBitmap;

            //            var data = VisioForge.MediaFramework.DXVideoEffects.Effects.GreyscaleEffect.GetData();

            //            var processor = new VisioForge.MediaFramework.DXVideoEffects.EffectProcessor();
            //            processor.Init();

            //            CurrentBitmap = new Bitmap(@"c:\Samples\pics\2.jpg");

            //            int sourceSize = CurrentBitmap.Width * CurrentBitmap.Height * 4;
            //            IntPtr source = Marshal.AllocCoTaskMem(sourceSize);
            //            ImageHelper.BitmapToIntPtr(CurrentBitmap, source, CurrentBitmap.Width, CurrentBitmap.Height, PixelFormat.Format32bppArgb);

            //            var frm = new DXFrame(source, sourceSize, CurrentBitmap.Width, CurrentBitmap.Height);
            //            frm = processor.ApplyEffect(frm, data);

            //            Bitmap bmp1 = new Bitmap(frm.Width, frm.Height);
            //            VisioForge.MediaFramework.MFP.ImageHelper.IntPtrToBitmap(
            //                frm.Data,
            //                frm.Width,
            //                frm.Height,
            //                PixelFormat.Format32bppArgb,
            //                ref bmp1);
            //            bmp1.Save(@"c:\Samples\pics\2z.jpg");
            //        });
        }

        private delegate void AFMotionDelegate(float level);

        public void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void VideoCapture1_OnMotionDetectionEx(object sender, MotionDetectionExEventArgs e)
        {
            BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
        }

        private void cbAFMotionDetection_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureMotionDetectionEx();
        }

        private void btSeparateCaptureStart_Click(object sender, EventArgs e)
        {
            VideoCapture1.SeparateCapture_Start(edOutput.Text);
        }

        private void btSeparateCaptureStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.SeparateCapture_Stop();
        }

        private void btSeparateCaptureChangeFilename_Click(object sender, EventArgs e)
        {
            VideoCapture1.SeparateCapture_ChangeFilenameOnTheFly(edNewFilename.Text);
        }

        private void ReadCameraControlInfo()
        {
            int max;
            int defaultValue;
            int min;
            int step;
            VFCameraControlFlags flags;

            if (VideoCapture1.Video_CaptureDevice_CameraControl_GetRange(VFCameraControlProperty.Pan, out min, out max, out step, out defaultValue, out flags))
            {
                tbCCPan.Minimum = min;
                tbCCPan.Maximum = max;
                tbCCPan.SmallChange = step;
                tbCCPan.Value = defaultValue;
                lbCCPanMin.Text = "Min: " + Convert.ToString(min);
                lbCCPanMax.Text = "Max: " + Convert.ToString(max);
                lbCCPanCurrent.Text = "Current: " + Convert.ToString(defaultValue);

                cbCCPanManual.Checked = (flags & VFCameraControlFlags.Manual) == VFCameraControlFlags.Manual;
                cbCCPanAuto.Checked = (flags & VFCameraControlFlags.Auto) == VFCameraControlFlags.Auto;
                cbCCPanRelative.Checked = (flags & VFCameraControlFlags.Relative) == VFCameraControlFlags.Relative;
            }

            if (VideoCapture1.Video_CaptureDevice_CameraControl_GetRange(VFCameraControlProperty.Tilt, out min, out max, out step, out defaultValue, out flags))
            {
                tbCCTilt.Minimum = min;
                tbCCTilt.Maximum = max;
                tbCCTilt.SmallChange = step;
                tbCCTilt.Value = defaultValue;
                lbCCTiltMin.Text = "Min: " + Convert.ToString(min);
                lbCCTiltMax.Text = "Max: " + Convert.ToString(max);
                lbCCTiltCurrent.Text = "Current: " + Convert.ToString(defaultValue);

                cbCCTiltManual.Checked = (flags & VFCameraControlFlags.Manual) == VFCameraControlFlags.Manual;
                cbCCTiltAuto.Checked = (flags & VFCameraControlFlags.Auto) == VFCameraControlFlags.Auto;
                cbCCTiltRelative.Checked = (flags & VFCameraControlFlags.Relative) == VFCameraControlFlags.Relative;
            }
        }

        private void btCCReadValues_Click(object sender, EventArgs e)
        {
            ReadCameraControlInfo();
        }

        private void btCCPanApply_Click(object sender, EventArgs e)
        {
            VFCameraControlFlags flags = VFCameraControlFlags.None;

            if (cbCCPanManual.Checked)
            {
                flags = flags | VFCameraControlFlags.Manual;
            }

            if (cbCCPanAuto.Checked)
            {
                flags = flags | VFCameraControlFlags.Auto;
            }

            if (cbCCPanRelative.Checked)
            {
                flags = flags | VFCameraControlFlags.Relative;
            }

            VideoCapture1.Video_CaptureDevice_CameraControl_Set(VFCameraControlProperty.Pan, tbCCPan.Value, flags);
        }

        private void btCCTiltApply_Click(object sender, EventArgs e)
        {
            VFCameraControlFlags flags = VFCameraControlFlags.None;

            if (cbCCTiltManual.Checked)
            {
                flags = flags | VFCameraControlFlags.Manual;
            }

            if (cbCCTiltAuto.Checked)
            {
                flags = flags | VFCameraControlFlags.Auto;
            }

            if (cbCCTiltRelative.Checked)
            {
                flags = flags | VFCameraControlFlags.Relative;
            }

            VideoCapture1.Video_CaptureDevice_CameraControl_Set(VFCameraControlProperty.Tilt, tbCCTilt.Value, flags);
        }

        private void btPIPAddIPCamera_Click(object sender, EventArgs e)
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

        private void btPIPAddScreenCapture_Click(object sender, EventArgs e)
        {
            ScreenCaptureSourceSettings screenSource;
            SelectScreenSource(out screenSource);

            VideoCapture1.PIP_Sources_Add_ScreenSource(
                screenSource,
                Convert.ToInt32(edPIPScreenCapLeft.Text),
                Convert.ToInt32(edPIPScreenCapTop.Text),
                Convert.ToInt32(edPIPScreenCapWidth.Text),
                Convert.ToInt32(edPIPScreenCapHeight.Text));

            cbPIPDevices.Items.Add("Screen Capture");
        }

        private void btPIPDevicesClear_Click(object sender, EventArgs e)
        {
            VideoCapture1.PIP_Sources_Clear();
            cbPIPDevices.Items.Clear();
        }

        private void btPIPUpdate_Click(object sender, EventArgs e)
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

        private void btPIPSet_Click(object sender, EventArgs e)
        {
            if (cbPIPDevices.SelectedIndex != -1)
            {
                VideoCapture1.PIP_Sources_SetSourceSettings(cbPIPDevices.SelectedIndex, tbPIPTransparency.Value, false, false);
            }
            else
            {
                MessageBox.Show("Select device!");
            }
        }

        private void btPIPSetOutputSize_Click(object sender, EventArgs e)
        {
            VideoCapture1.PIP_CustomOutputSize_Set(Convert.ToInt32(edPIPOutputWidth.Text), Convert.ToInt32(edPIPOutputHeight.Text));
        }

        private void btDVBTTune_Click(object sender, EventArgs e)
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

        private void btSeparateCapturePause_Click(object sender, EventArgs e)
        {
            VideoCapture1.SeparateCapture_Pause();
        }

        private void btSeparateCaptureResume_Click(object sender, EventArgs e)
        {
            VideoCapture1.SeparateCapture_Resume();
        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectZoom zoomEffect;
            var effect = VideoCapture1.Video_Effects_Get("Zoom");
            if (effect == null)
            {
                zoomEffect = new VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoom.Checked);
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
            zoomEffect.Enabled = cbZoom.Checked;
        }

        private void btEffZoomIn_Click(object sender, EventArgs e)
        {
            zoom += 0.1;
            zoom = Math.Min(zoom, 5);

            cbZoom_CheckedChanged(null, null);
        }

        private void btEffZoomOut_Click(object sender, EventArgs e)
        {
            zoom -= 0.1;
            zoom = Math.Max(zoom, 1);

            cbZoom_CheckedChanged(null, null);
        }

        private void btEffZoomUp_Click(object sender, EventArgs e)
        {
            zoomShiftY += 20;

            cbZoom_CheckedChanged(null, null);
        }

        private void btEffZoomDown_Click(object sender, EventArgs e)
        {
            zoomShiftY -= 20;

            cbZoom_CheckedChanged(null, null);
        }

        private void btEffZoomRight_Click(object sender, EventArgs e)
        {
            zoomShiftX += 20;

            cbZoom_CheckedChanged(null, null);
        }

        private void btEffZoomLeft_Click(object sender, EventArgs e)
        {
            zoomShiftX -= 20;

            cbZoom_CheckedChanged(null, null);
        }

        private void cbPan_CheckedChanged(object sender, EventArgs e)
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

            pan.Enabled = cbPan.Checked;
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

        private void btBarcodeReset_Click(object sender, EventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            VideoCapture1.Barcode_Reader_Enabled = true;
        }

        private void btAddAdditionalAudioSource_Click(object sender, EventArgs e)
        {
            VideoCapture1.Additional_Audio_CaptureDevice_Add(cbAdditionalAudioSource.Text);
            MessageBox.Show(cbAdditionalAudioSource.Text + " added");
        }

        private void btPIPFileSourceAdd_Click(object sender, EventArgs e)
        {
            VideoCapture1.PIP_Sources_Add_VideoFile(
                edPIPFileSoureFilename.Text,
                Convert.ToInt32(edPIPFileLeft.Text),
                Convert.ToInt32(edPIPFileTop.Text),
                Convert.ToInt32(edPIPFileWidth.Text),
                Convert.ToInt32(edPIPFileHeight.Text));
            cbPIPDevices.Items.Add("File source");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edPIPFileSoureFilename.Text = openFileDialog1.FileName;
            }
        }

        private void cbFadeInOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFadeIn.Checked)
            {
                IVFVideoEffectFadeIn fadeIn;
                var effect = VideoCapture1.Video_Effects_Get("FadeIn");
                if (effect == null)
                {
                    fadeIn = new VFVideoEffectFadeIn(cbFadeInOut.Checked);
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

                fadeIn.Enabled = cbFadeInOut.Checked;
                fadeIn.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeIn.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
            }
            else
            {
                IVFVideoEffectFadeOut fadeOut;
                var effect = VideoCapture1.Video_Effects_Get("FadeOut");
                if (effect == null)
                {
                    fadeOut = new VFVideoEffectFadeOut(cbFadeInOut.Checked);
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

                fadeOut.Enabled = cbFadeInOut.Checked;
                fadeOut.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeOut.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/878966-Streaming-to-Adobe-Flash-Media-Server");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnBDAChannelFound(object sender, BDAChannelEventArgs e)
        {
            Application.DoEvents();

            ListViewItem lvi = new ListViewItem(
                new[]
                    {
                        e.Channel.Name,
                        e.Channel.Frequency.ToString(CultureInfo.InvariantCulture),
                        e.Channel.AudioPid.ToString(CultureInfo.InvariantCulture),
                        e.Channel.VideoPid.ToString(CultureInfo.InvariantCulture),
                        e.Channel.ServId.ToString(CultureInfo.InvariantCulture),
                        e.Channel.SymbolRate.ToString(CultureInfo.InvariantCulture)
                    });

            lvBDAChannels.Items.Add(lvi);

            Application.DoEvents();
        }

        private void btBDAChannelScanningStart_Click(object sender, EventArgs e)
        {
            lvBDAChannels.Items.Clear();
            VideoCapture1.BDA_ScanChannels();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/300487-Streaming-using-Microsoft-Expression-Encoder");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnFaceDetected(object sender, AFFaceDetectionEventArgs e)
        {
            BeginInvoke(new FaceDelegate(FaceDelegateMethod), e);
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

        #region Full screen

        private bool fullScreen;

        private int windowLeft;

        private int windowTop;

        private int windowWidth;

        private int windowHeight;

        private int controlLeft;

        private int controlTop;

        private int controlWidth;

        private int controlHeight;

        private void btFullScreen_Click(object sender, EventArgs e)
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

                controlLeft = VideoCapture1.Left;
                controlTop = VideoCapture1.Top;
                controlWidth = VideoCapture1.Width;
                controlHeight = VideoCapture1.Height;

                // resizing window
                Left = 0;
                Top = 0;
                Width = Screen.AllScreens[0].WorkingArea.Width;
                Height = Screen.AllScreens[0].WorkingArea.Height;

                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;

                // resizing control
                VideoCapture1.Left = 0;
                VideoCapture1.Top = 0;
                VideoCapture1.Width = Width;
                VideoCapture1.Height = Height;

                VideoCapture1.Video_Renderer_Update();
            }
            else
            {
                // going normal screen
                fullScreen = false;

                // restoring control
                VideoCapture1.Left = controlLeft;
                VideoCapture1.Top = controlTop;
                VideoCapture1.Width = controlWidth;
                VideoCapture1.Height = controlHeight;

                // restoring window
                Left = windowLeft;
                Top = windowTop;
                Width = windowWidth;
                Height = windowHeight;

                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;

                VideoCapture1.Video_Renderer_Update();
            }
        }

        private void VideoCapture1_MouseDown(object sender, MouseEventArgs e)
        {
            if (fullScreen)
            {
                btFullScreen_Click(null, null);
            }
        }

        #endregion

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/240078-How-to-configure-IIS-Smooth-Streaming-in-SDK-demo-application");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnNetworkSourceStop(object sender, EventArgs e)
        {
            BeginInvoke(new NetworkStopDelegate(NetworkStopDelegateMethod));
        }

        public delegate void NetworkStopDelegate();

        public void NetworkStopDelegateMethod()
        {
            VideoCapture1.Stop();

            MessageBox.Show("Network source stopped or disconnected!");
        }

        private void VideoCapture1_OnAudioVUMeterProVolume(object sender, AudioLevelEventArgs e)
        {
            volumeMeter1.Amplitude = e.ChannelLevelsDb[0];
            waveformPainter1.AddMax(e.ChannelLevelsDb[0]);

            if (e.ChannelLevelsDb.Length > 1)
            {
                volumeMeter2.Amplitude = e.ChannelLevelsDb[1];
                waveformPainter2.AddMax(e.ChannelLevelsDb[1]);
            }
        }

        private void tbVUMeterAmplification_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_VUMeter_Pro_Volume = tbVUMeterAmplification.Value;
        }

        private void tbVUMeterBoost_Scroll(object sender, EventArgs e)
        {
            volumeMeter1.Boost = tbVUMeterBoost.Value / 10.0F;
            volumeMeter2.Boost = tbVUMeterBoost.Value / 10.0F;

            waveformPainter1.Boost = tbVUMeterBoost.Value / 10.0F;
            waveformPainter2.Boost = tbVUMeterBoost.Value / 10.0F;
        }

        private void cbLiveRotation_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectRotate rotate;
            var effect = VideoCapture1.Video_Effects_Get("Rotate");
            if (effect == null)
            {
                rotate = new VFVideoEffectRotate(
                    cbLiveRotation.Checked,
                    tbLiveRotationAngle.Value,
                    cbLiveRotationStretch.Checked);
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

            rotate.Enabled = cbLiveRotation.Checked;
            rotate.Angle = tbLiveRotationAngle.Value;
            rotate.Stretch = cbLiveRotationStretch.Checked;
        }

        private void tbLiveRotationDegree_Scroll(object sender, EventArgs e)
        {
            cbLiveRotation_CheckedChanged(sender, e);
        }

        private void cbLiveRotationStretch_CheckedChanged(object sender, EventArgs e)
        {
            cbLiveRotation_CheckedChanged(sender, e);
        }

        private void cbDirect2DRotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VideoCapture1.Video_Renderer == null)
            {
                VideoCapture1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            VideoCapture1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);
            VideoCapture1.Video_Renderer_Update();
        }

        private void pnVideoRendererBGColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnVideoRendererBGColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnVideoRendererBGColor.BackColor = colorDialog1.Color;

                VideoCapture1.Video_Renderer.BackgroundColor = pnVideoRendererBGColor.BackColor;
                VideoCapture1.Video_Renderer_Update();
            }
        }

        private void cbCustomVideoSourceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCustomVideoSourceFilter.Items.Clear();

            if (cbCustomVideoSourceCategory.SelectedIndex == 0)
            {
                var filters = VideoCapture1.Video_CaptureDevicesInfo;
                foreach (var item in filters)
                {
                    cbCustomVideoSourceFilter.Items.Add(item.Name);
                }

                if (filters.Count > 0)
                {
                    cbCustomVideoSourceFilter.SelectedIndex = 0;
                }
            }
            else if (cbCustomVideoSourceCategory.SelectedIndex == 1)
            {
                var filters = VideoCapture1.DirectShow_Filters;
                foreach (var item in filters)
                {
                    cbCustomVideoSourceFilter.Items.Add(item);
                }

                if (filters.Count > 0)
                {
                    cbCustomVideoSourceFilter.SelectedIndex = 0;
                }
            }
        }

        private void cbCustomAudioSourceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void cbCustomVideoSourceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbCustomVideoSourceFilter.Text))
            {
                cbCustomVideoSourceFormat.Items.Clear();
                cbCustomVideoSourceFrameRate.Items.Clear();

                List<string> formats;
                List<string> frameRates;

                if (cbCustomVideoSourceCategory.SelectedIndex == 0)
                {
                    VideoCapture1.DirectShow_Filter_GetFormats(
                        VFFilterCategory.VideoCaptureSource,
                        cbCustomVideoSourceFilter.Text,
                        VFMediaCategory.Video,
                        out formats,
                        out frameRates);
                }
                else
                {
                    VideoCapture1.DirectShow_Filter_GetFormats(
                        VFFilterCategory.DirectShowFilters,
                        cbCustomVideoSourceFilter.Text,
                        VFMediaCategory.Video,
                        out formats,
                        out frameRates);
                }

                foreach (var format in formats)
                {
                    cbCustomVideoSourceFormat.Items.Add(format);
                }

                foreach (var format in frameRates)
                {
                    cbCustomVideoSourceFrameRate.Items.Add(format);
                }
            }
        }

        private void cbCustomAudioSourceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbCustomAudioSourceFilter.Text))
            {
                cbCustomAudioSourceFormat.Items.Clear();

                List<string> formats;
                List<string> frameRates;

                if (cbCustomAudioSourceCategory.SelectedIndex == 0)
                {
                    VideoCapture1.DirectShow_Filter_GetFormats(
                        VFFilterCategory.AudioCaptureSource,
                        cbCustomAudioSourceFilter.Text,
                        VFMediaCategory.Audio,
                        out formats,
                        out frameRates);
                }
                else
                {
                    VideoCapture1.DirectShow_Filter_GetFormats(
                        VFFilterCategory.DirectShowFilters,
                        cbCustomAudioSourceFilter.Text,
                        VFMediaCategory.Audio,
                        out formats,
                        out frameRates);
                }

                foreach (var format in formats)
                {
                    cbCustomAudioSourceFormat.Items.Add(format);
                }
            }
        }

        private void cbAudioNormalize_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Enhancer_Normalize(cbAudioNormalize.Checked);
        }

        private void cbAudioAutoGain_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Enhancer_AutoGain(cbAudioAutoGain.Checked);
        }

        private void ApplyAudioInputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = tbAudioInputGainL.Value / 10.0f,
                C = tbAudioInputGainC.Value / 10.0f,
                R = tbAudioInputGainR.Value / 10.0f,
                SL = tbAudioInputGainSL.Value / 10.0f,
                SR = tbAudioInputGainSR.Value / 10.0f,
                LFE = tbAudioInputGainLFE.Value / 10.0f
            };

            VideoCapture1.Audio_Enhancer_InputGains(gains);
        }

        private void tbAudioInputGainL_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainL.Text = (tbAudioInputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainC_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainC.Text = (tbAudioInputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainR_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainR.Text = (tbAudioInputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSL_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainSL.Text = (tbAudioInputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSR_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainSR.Text = (tbAudioInputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainLFE_Scroll(object sender, EventArgs e)
        {
            lbAudioInputGainLFE.Text = (tbAudioInputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void ApplyAudioOutputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = tbAudioOutputGainL.Value / 10.0f,
                C = tbAudioOutputGainC.Value / 10.0f,
                R = tbAudioOutputGainR.Value / 10.0f,
                SL = tbAudioOutputGainSL.Value / 10.0f,
                SR = tbAudioOutputGainSR.Value / 10.0f,
                LFE = tbAudioOutputGainLFE.Value / 10.0f
            };

            VideoCapture1.Audio_Enhancer_OutputGains(gains);
        }

        private void tbAudioOutputGainL_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainL.Text = (tbAudioOutputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainC_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainC.Text = (tbAudioOutputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainR_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainR.Text = (tbAudioOutputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSL_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainSL.Text = (tbAudioOutputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSR_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainSR.Text = (tbAudioOutputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainLFE_Scroll(object sender, EventArgs e)
        {
            lbAudioOutputGainLFE.Text = (tbAudioOutputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioTimeshift_Scroll(object sender, EventArgs e)
        {
            lbAudioTimeshift.Text = tbAudioTimeshift.Value.ToString(CultureInfo.InvariantCulture) + " ms";

            VideoCapture1.Audio_Enhancer_Timeshift(tbAudioTimeshift.Value);
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void FFEXEDisableVideoMode()
        {
            rbFFEXEVideoModeABR.Enabled = false;
            rbFFEXEVideoModeABR.Checked = false;
            rbFFEXEVideoModeCBR.Enabled = false;
            rbFFEXEVideoModeCBR.Checked = false;
            rbFFEXEVideoModeQuality.Enabled = false;
            rbFFEXEVideoModeQuality.Checked = false;

            tbFFEXEVideoQuality.Enabled = false;
            edFFEXEVideoTargetBitrate.Enabled = false;
            edFFEXEVideoBitrateMax.Enabled = false;
            edFFEXEVideoBitrateMin.Enabled = false;
        }

        private void FFEXEEnableVideoCBR()
        {
            rbFFEXEVideoModeCBR.Enabled = true;
            rbFFEXEVideoModeCBR.Checked = true;

            edFFEXEVideoTargetBitrate.Enabled = true;
        }

        private void FFEXEEnableVideoABR()
        {
            rbFFEXEVideoModeABR.Enabled = true;
            rbFFEXEVideoModeABR.Checked = true;

            edFFEXEVideoTargetBitrate.Enabled = true;
            edFFEXEVideoBitrateMax.Enabled = true;
            edFFEXEVideoBitrateMin.Enabled = true;
        }

        private void FFEXEEnableVideoQuality()
        {
            rbFFEXEVideoModeQuality.Enabled = true;
            rbFFEXEVideoModeQuality.Checked = true;

            tbFFEXEVideoQuality.Enabled = true;
        }

        private void cbFFEXEProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFFEXEProfile.SelectedIndex)
            {
                // MPEG-1
                case 0:
                    cbFFEXEOutputFormat.SelectedIndex = 23;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MPEG-1 VCD
                case 1:
                    cbFFEXEOutputFormat.SelectedIndex = 34;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2
                case 2:
                    cbFFEXEOutputFormat.SelectedIndex = 23;

                    cbFFEXEVideoCodec.SelectedIndex = 15;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MPEG-2 SVCD
                case 3:
                    cbFFEXEOutputFormat.SelectedIndex = 30;

                    cbFFEXEVideoCodec.SelectedIndex = 15;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2 DVD
                case 4:
                    cbFFEXEOutputFormat.SelectedIndex = 7;

                    cbFFEXEVideoCodec.SelectedIndex = 15;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2 TS
                case 5:
                    cbFFEXEOutputFormat.SelectedIndex = 24;

                    cbFFEXEVideoCodec.SelectedIndex = 15;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // Flash Video (FLV)
                case 6:
                    cbFFEXEOutputFormat.SelectedIndex = 11;

                    cbFFEXEVideoCodec.SelectedIndex = 5;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP4 H264 / AAC
                case 7:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 5;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP4 H264 / AAC QSV
                case 8:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 6;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP4 HEVC / AAC
                case 9:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 7;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP4 HEVC / AAC QSV
                case 10:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 8;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // WebM
                case 11:
                    cbFFEXEOutputFormat.SelectedIndex = 36;

                    cbFFEXEVideoCodec.SelectedIndex = 19;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // AVI
                case 12:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 16;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // OGG Vorbis
                case 13:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // Opus
                case 14:
                    cbFFEXEOutputFormat.SelectedIndex = 27;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 14;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // Speex
                case 15:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 40;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // FLAC
                case 16:
                    cbFFEXEOutputFormat.SelectedIndex = 10;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 10;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP3
                case 17:
                    cbFFEXEOutputFormat.SelectedIndex = 21;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // DV
                case 18:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 1;
                    cbFFEXEAudioCodec.SelectedIndex = 23;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    cbFFEXEAudioChannels.SelectedIndex = 1;
                    cbFFEXEAudioSampleRate.SelectedIndex = 1;
                    break;

                // Custom
                case 19:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 16;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;
            }
        }

        private void tbFFEXEH264Quantizer_Scroll(object sender, EventArgs e)
        {
            lbFFEXEH264Quantizer.Text = tbFFEXEH264Quantizer.Value.ToString();
        }

        private void FFEXEDisableAudioMode()
        {
            rbFFEXEAudioModeABR.Enabled = false;
            rbFFEXEAudioModeABR.Checked = false;
            rbFFEXEAudioModeCBR.Enabled = false;
            rbFFEXEAudioModeCBR.Checked = false;
            rbFFEXEAudioModeQuality.Enabled = false;
            rbFFEXEAudioModeQuality.Checked = false;
            rbFFEXEAudioModeLossless.Enabled = false;
            rbFFEXEAudioModeLossless.Checked = false;

            tbFFEXEAudioQuality.Enabled = false;
            cbFFEXEAudioBitrate.Enabled = false;
        }

        private void FFEXEEnableAudioCBR()
        {
            rbFFEXEAudioModeCBR.Enabled = true;
            rbFFEXEAudioModeCBR.Checked = true;

            cbFFEXEAudioBitrate.Enabled = true;
        }

        // ReSharper disable once UnusedMember.Local
        private void FFEXEEnableAudioABR()
        {
            rbFFEXEAudioModeABR.Enabled = true;
            rbFFEXEAudioModeABR.Checked = true;

            // edFFEXEAudioTargetBitrate.Enabled = true;
            // edFFEXEAudioBitrateMax.Enabled = true;
            // edFFEXEAudioBitrateMin.Enabled = true;
        }

        private void FFEXEEnableAudioQuality()
        {
            rbFFEXEAudioModeQuality.Enabled = true;
            rbFFEXEAudioModeQuality.Checked = true;

            tbFFEXEAudioQuality.Enabled = true;
        }

        private void FFEXEEnableAudioLossless()
        {
            rbFFEXEAudioModeLossless.Enabled = true;
            rbFFEXEAudioModeLossless.Checked = true;

            // tbFFEXEAudioQuality.Enabled = true;
        }

        private void cbFFEXEAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            FFEXEDisableAudioMode();
            lbFFEXEAudioNotes.Text = "Notes: None.";

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
                        lbFFEXEAudioNotes.Text = "Notes: Use Quality mode, trackbar set compression level (0-12, .";

                        FFEXEEnableAudioQuality();

                        tbFFEXEAudioQuality.Minimum = 0;
                        tbFFEXEAudioQuality.Maximum = 12;
                        tbFFEXEAudioQuality.Value = 5;
                        lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString();
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
                        lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString();
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
                        lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString();
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
                        tbFFEXEAudioQuality_Scroll(null, null);
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
                        tbFFEXEAudioQuality_Scroll(null, null);
                    }

                    break;

                // WavPack
                case 42:
                    {
                    }

                    break;
            }
        }

        private void tbFFEXEAudioQuality_Scroll(object sender, EventArgs e)
        {
            lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString();
        }

        private void cbFFEXEVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            edFFEXEVBVBufferSize.Text = "0";
            edFFEXEVideoGOPSize.Text = "0";
            edFFEXEVideoBFramesCount.Text = "0";
            tbFFEXEVideoQuality.Minimum = 1;
            tbFFEXEVideoQuality.Maximum = 31;

            lbFFEXEVideoNotes.Text = "Notes: None.";

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
                        lbFFEXEVideoNotes.Text = "Notes: Specify constraint settings for PAL or NTSC DV output.";
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
                        cbFFEXEH264QuickTimeCompatibility.Checked = true;
                        cbFFEXEH264ZeroTolerance.Checked = false;
                        cbFFEXEH264WebFastStart.Checked = false;
                    }

                    break;

                // H264 QSV
                case 6:
                    {
                        cbFFEXEH264Mode.SelectedIndex = 0;
                        cbFFEXEH264Level.SelectedIndex = 0;
                        cbFFEXEH264Preset.SelectedIndex = 0;
                        cbFFEXEH264Profile.SelectedIndex = 0;
                        tbFFEXEH264Quantizer.Value = 23;
                        cbFFEXEH264QuickTimeCompatibility.Checked = true;
                        cbFFEXEH264ZeroTolerance.Checked = false;
                        cbFFEXEH264WebFastStart.Checked = false;
                    }

                    break;

                // HEVC
                case 7:
                    {
                        cbFFEXEH264Mode.SelectedIndex = 0;
                        cbFFEXEH264Level.SelectedIndex = 0;
                        cbFFEXEH264Preset.SelectedIndex = 0;
                        cbFFEXEH264Profile.SelectedIndex = 0;
                        tbFFEXEH264Quantizer.Value = 23;
                        cbFFEXEH264QuickTimeCompatibility.Checked = true;
                        cbFFEXEH264ZeroTolerance.Checked = false;
                        cbFFEXEH264WebFastStart.Checked = false;
                    }

                    break;

                // HEVC QSV
                case 8:
                    {
                        cbFFEXEH264Mode.SelectedIndex = 0;
                        cbFFEXEH264Level.SelectedIndex = 0;
                        cbFFEXEH264Preset.SelectedIndex = 0;
                        cbFFEXEH264Profile.SelectedIndex = 0;
                        tbFFEXEH264Quantizer.Value = 23;
                        cbFFEXEH264QuickTimeCompatibility.Checked = true;
                        cbFFEXEH264ZeroTolerance.Checked = false;
                        cbFFEXEH264WebFastStart.Checked = false;
                    }

                    break;

                // HuffYUV
                case 9:
                    {
                    }

                    break;

                // JPEG 2000
                case 10:
                    {
                    }

                    break;

                // JPEG-LS
                case 11:
                    {
                    }

                    break;

                // LJPEG
                case 12:
                    {
                    }

                    break;

                // MJPEG
                case 13:
                    {
                        FFEXEEnableVideoQuality();

                        tbFFEXEVideoQuality.Value = 4;
                        tbFFEXEVideoQuality_Scroll(null, null);
                    }

                    break;

                // MPEG-1
                case 14:
                    {
                        FFEXEEnableVideoCBR();

                        edFFEXEVideoBitrateMin.Text = "1000";
                        edFFEXEVideoBitrateMax.Text = "2000";
                        edFFEXEVideoTargetBitrate.Text = "1800";
                    }

                    break;

                // MPEG-2
                case 15:
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
                case 16:
                    {
                        FFEXEEnableVideoCBR();

                        edFFEXEVideoBitrateMin.Text = "2000";
                        edFFEXEVideoBitrateMax.Text = "5000";
                        edFFEXEVideoTargetBitrate.Text = "4000";
                    }

                    break;

                // PNG
                case 17:
                    {
                    }

                    break;

                // Theora
                case 18:
                    {
                        FFEXEEnableVideoQuality();

                        tbFFEXEVideoQuality.Minimum = 0;
                        tbFFEXEVideoQuality.Maximum = 10;
                        tbFFEXEVideoQuality.Value = 7;
                        tbFFEXEVideoQuality_Scroll(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;

                // VP8
                case 19:
                    {
                        FFEXEEnableVideoQuality();
                        FFEXEEnableVideoCBR();

                        tbFFEXEVideoQuality.Minimum = 4;
                        tbFFEXEVideoQuality.Maximum = 63;
                        tbFFEXEVideoQuality.Value = 10;
                        tbFFEXEVideoQuality_Scroll(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;

                // VP9   
                case 20:
                    {
                        FFEXEEnableVideoQuality();
                        FFEXEEnableVideoCBR();

                        tbFFEXEVideoQuality.Minimum = 4;
                        tbFFEXEVideoQuality.Maximum = 63;
                        tbFFEXEVideoQuality.Value = 10;
                        tbFFEXEVideoQuality_Scroll(null, null);

                        edFFEXEVideoTargetBitrate.Text = "2000";
                    }

                    break;
            }
        }

        private void tbFFEXEVideoQuality_Scroll(object sender, EventArgs e)
        {
            lbFFEXEVideoQuality.Text = tbFFEXEVideoQuality.Value.ToString();
        }

        private delegate void FFMPEGInfoDelegate(string message);

        private void FFMPEGInfoDelegateMethod(string message)
        {
            // if (VideoCapture1.Debug_Mode)
            // {

            mmLog.Text += "(NOT ERROR) FFMPEG " + message + Environment.NewLine;

            // }
        }

        private void VideoCapture1_OnFFMPEGInfo(object sender, FFMPEGInfoEventArgs e)
        {
            BeginInvoke(new FFMPEGInfoDelegate(FFMPEGInfoDelegateMethod), e.Message);
        }

        private void btEncryptionOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edEncryptionKeyFile.Text = openFileDialog1.FileName;
            }
        }

        private void cbFFEXEH264Mode_SelectedIndexChanged(object sender, EventArgs e)
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

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem");
            Process.Start(startInfo);
        }

        private void imgTagCover_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                imgTagCover.LoadAsync(openFileDialog2.FileName);
                imgTagCover.Tag = openFileDialog2.FileName;
            }
        }

        private void cbDecklinkCaptureDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDecklinkCaptureVideoFormat.Items.Clear();

            var deviceItem = VideoCapture1.Decklink_CaptureDevices.First(device => device.Name == cbDecklinkCaptureDevice.Text);
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

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe");
            Process.Start(startInfo);
        }

        private void FFMPEGDownloadLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_ffmpeg_exe_x86_x64.exe");
            Process.Start(startInfo);
        }

        private void btAudioChannelMapperAddNewRoute_Click(object sender, EventArgs e)
        {
            var item = new AudioChannelMapperItem
            {
                SourceChannel = Convert.ToInt32(edAudioChannelMapperSourceChannel.Text),
                TargetChannel = Convert.ToInt32(edAudioChannelMapperTargetChannel.Text),
                TargetChannelVolume = tbAudioChannelMapperVolume.Value / 1000.0f
            };

            audioChannelMapperItems.Add(item);

            lbAudioChannelMapperRoutes.Items.Add(
                "Source: " + edAudioChannelMapperSourceChannel.Text + ", target: "
                + edAudioChannelMapperTargetChannel.Text + ", volume: "
                + (tbAudioChannelMapperVolume.Value / 1000.0f).ToString("F2"));
        }

        private void btAudioChannelMapperClear_Click(object sender, EventArgs e)
        {
            audioChannelMapperItems.Clear();
            lbAudioChannelMapperRoutes.Items.Clear();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge.com/support/577349-Network-streaming-to-YouTube");
            Process.Start(startInfo);
        }

        private void tpNVENC_Enter(object sender, EventArgs e)
        {
            if (lbNVENCStatus.Tag.ToString() == "0")
            {
                lbNVENCStatus.Tag = 1;

                NVENCErrorCode errorCode;
                bool res = VideoCapture.Filter_Supported_NVENC(out errorCode);

                if (res)
                {
                    lbNVENCStatus.Text = "Available";
                }
                else
                {
                    lbNVENCStatus.Text = "Not available. Error code: " + errorCode;
                }
            }
        }

        //// motion detector
        //MotionDetector detector = new MotionDetector(
        //    //new SimpleBackgroundModelingDetector(true, true),
        //    new TwoFramesDifferenceDetector(true),
        //    new BlobCountingObjectsProcessing());

        //// counter used for flashing
        //private int flash = 0;
        //private float motionAlarmLevel = 0.015f;

        //private List<float> motionHistory = new List<float>();
        //private int detectedObjectsCount = -1;

        //private void VideoCapture1_OnVideoFrameBufferOriginal(object sender, VideoFrameBufferEventArgs2 e)
        //{
        //    return;

        //    lock (this)
        //    {
        //        if (detector != null)
        //        {
        //            var imageu = new UnmanagedImage(e.Buffer, e.Width, e.Height, e.Stride, e.PixelFormat);

        //            float motionLevel = detector.ProcessFrame(imageu);

        //            //if (motionLevel > motionAlarmLevel)
        //            //{
        //            //    // flash for 2 seconds
        //            //    flash = (int)(2 * (1000 / alarmTimer.Interval));
        //            //}

        //            // check objects' count
        //            if (detector.MotionProcessingAlgorithm is BlobCountingObjectsProcessing)
        //            {
        //                BlobCountingObjectsProcessing countingDetector = (BlobCountingObjectsProcessing)detector.MotionProcessingAlgorithm;
        //                detectedObjectsCount = countingDetector.ObjectsCount;
        //            }
        //            else
        //            {
        //                detectedObjectsCount = -1;
        //            }

        //            // accumulate history
        //            //motionHistory.Add(motionLevel);
        //            //if (motionHistory.Count > 300)
        //            //{
        //            //    motionHistory.RemoveAt(0);
        //            //}

        //            //if (showMotionHistoryToolStripMenuItem.Checked)
        //            DrawMotionHistory(imageu);
        //        }
        //    }
        //}

        //// Draw motion history
        //private void DrawMotionHistory(UnmanagedImage image)
        //{
        //    Color greenColor = Color.FromArgb(128, 0, 255, 0);
        //    Color yellowColor = Color.FromArgb(128, 255, 255, 0);
        //    Color redColor = Color.FromArgb(128, 255, 0, 0);

        //    //BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
        //    //    ImageLockMode.ReadWrite, image.PixelFormat);

        //    int t1 = (int)(motionAlarmLevel * 500);
        //    int t2 = (int)(0.075 * 500);

        //    for (int i = 1, n = motionHistory.Count; i <= n; i++)
        //    {
        //        int motionBarLength = (int)(motionHistory[n - i] * 500);

        //        if (motionBarLength == 0)
        //            continue;

        //        if (motionBarLength > 50)
        //            motionBarLength = 50;

        //        Drawing.Line(image,
        //            new IntPoint(image.Width - i, image.Height - 1),
        //            new IntPoint(image.Width - i, image.Height - 1 - motionBarLength),
        //            greenColor);

        //        if (motionBarLength > t1)
        //        {
        //            Drawing.Line(image,
        //                new IntPoint(image.Width - i, image.Height - 1 - t1),
        //                new IntPoint(image.Width - i, image.Height - 1 - motionBarLength),
        //                yellowColor);
        //        }

        //        if (motionBarLength > t2)
        //        {
        //            Drawing.Line(image,
        //                new IntPoint(image.Width - i, image.Height - 1 - t2),
        //                new IntPoint(image.Width - i, image.Height - 1 - motionBarLength),
        //                redColor);
        //        }
        //    }

        //    //image.UnlockBits(bitmapData);
        //}

        private void tbGPULightness_Scroll(object sender, EventArgs e)
        {
            IVFGPUVideoEffectBrightness intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Brightness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBrightness(true, tbGPULightness.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBrightness;
                if (intf != null)
                {
                    intf.Value = tbGPULightness.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUSaturation_Scroll(object sender, EventArgs e)
        {
            IVFGPUVideoEffectSaturation intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Saturation");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectSaturation(true, tbGPUSaturation.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectSaturation;
                if (intf != null)
                {
                    intf.Value = tbGPUSaturation.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUContrast_Scroll(object sender, EventArgs e)
        {
            IVFGPUVideoEffectContrast intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Contrast");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectContrast(true, tbGPUContrast.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as VFGPUVideoEffectContrast;
                if (intf != null)
                {
                    intf.Value = tbGPUContrast.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUDarkness_Scroll(object sender, EventArgs e)
        {
            IVFGPUVideoEffectDarkness intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Darkness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDarkness(true, tbGPUDarkness.Value);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDarkness;
                if (intf != null)
                {
                    intf.Value = tbGPUDarkness.Value;
                    intf.Update();
                }
            }
        }

        private void cbGPUGreyscale_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectGrayscale intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Grayscale");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectGrayscale(cbGPUGreyscale.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectGrayscale;
                if (intf != null)
                {
                    intf.Enabled = cbGPUGreyscale.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUInvert_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectInvert intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Invert");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectInvert(cbGPUInvert.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectInvert;
                if (intf != null)
                {
                    intf.Enabled = cbGPUInvert.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUNightVision_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectNightVision intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("NightVision");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectNightVision(cbGPUNightVision.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectNightVision;
                if (intf != null)
                {
                    intf.Enabled = cbGPUNightVision.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUPixelate_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectPixelate intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Pixelate");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectPixelate(cbGPUPixelate.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectPixelate;
                if (intf != null)
                {
                    intf.Enabled = cbGPUPixelate.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUDenoise_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectDenoise intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Denoise");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDenoise(cbGPUDenoise.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDenoise;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDenoise.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUDeinterlace_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectDeinterlaceBlend intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("DeinterlaceBlend");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDeinterlaceBlend;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDeinterlace.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUBlur_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectBlur intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("Blur");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBlur(cbGPUBlur.Checked, 50);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBlur;
                if (intf != null)
                {
                    intf.Enabled = cbGPUBlur.Checked;
                    intf.Update();
                }
            }
        }

        private void cbGPUOldMovie_CheckedChanged(object sender, EventArgs e)
        {
            IVFGPUVideoEffectOldMovie intf;
            var effect = VideoCapture1.Video_Effects_GPU_Get("OldMovie");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectOldMovie(cbGPUOldMovie.Checked);
                VideoCapture1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectOldMovie;
                if (intf != null)
                {
                    intf.Enabled = cbGPUOldMovie.Checked;
                    intf.Update();
                }
            }
        }

        private void btShowIPCamDatabase_Click(object sender, EventArgs e)
        {
            IPCameraDB.ShowWindow();
        }

        private void btONVIFConnect_Click(object sender, EventArgs e)
        {
            if (btONVIFConnect.Text == "Connect")
            {
                btONVIFConnect.Text = "Disconnect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }

                if (string.IsNullOrEmpty(edONVIFLogin.Text) || string.IsNullOrEmpty(edONVIFPassword.Text))
                {
                    MessageBox.Show("Please specify IP camera user name and password.");
                    return;
                }

                onvifControl = new ONVIFControl();
                var result = onvifControl.Connect(edONVIFURL.Text, edONVIFLogin.Text, edONVIFPassword.Text);
                if (!result)
                {
                    onvifControl = null;
                    MessageBox.Show("Unable to connect to ONVIF camera.");
                    return;
                }

                var deviceInfo = onvifControl.GetDeviceInformation();
                lbONVIFCameraInfo.Text = $"Model {deviceInfo.Model}, Firmware {deviceInfo.Firmware}";

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

                edONVIFLiveVideoURL.Text = edIPUrl.Text = onvifControl.GetVideoURL();

                edIPLogin.Text = edONVIFLogin.Text;
                edIPPassword.Text = edONVIFPassword.Text;

                onvifPtzRanges = onvifControl.PTZ_GetRanges();
                onvifControl.PTZ_SetAbsolute(0, 0, 0);

                onvifPtzX = 0;
                onvifPtzY = 0;
                onvifPtzZoom = 0;
            }
            else
            {
                btONVIFConnect.Text = "Connect";

                if (onvifControl != null)
                {
                    onvifControl.Disconnect();
                    onvifControl.Dispose();
                    onvifControl = null;
                }
            }
        }

        private void btONVIFRight_Click(object sender, EventArgs e)
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

        private void btONVIFPTZSetDefault_Click(object sender, EventArgs e)
        {
            onvifControl?.PTZ_SetAbsolute(0, 0, 0);
        }

        private void btONVIFLeft_Click(object sender, EventArgs e)
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

        private void btONVIFUp_Click(object sender, EventArgs e)
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

        private void btONVIFDown_Click(object sender, EventArgs e)
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

        private void btONVIFZoomIn_Click(object sender, EventArgs e)
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

        private void btONVIFZoomOut_Click(object sender, EventArgs e)
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

        private void tbPIPChromaKeyTolerance1_Scroll(object sender, EventArgs e)
        {
            lbPIPChromaKeyTolerance1.Text = tbPIPChromaKeyTolerance1.Value.ToString();
        }

        private void tbPIPChromaKeyTolerance2_Scroll(object sender, EventArgs e)
        {
            lbPIPChromaKeyTolerance2.Text = tbPIPChromaKeyTolerance2.Value.ToString();
        }

        private void pnPIPChromaKeyColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnPIPChromaKeyColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnPIPChromaKeyColor.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

// ReSharper restore InconsistentNaming