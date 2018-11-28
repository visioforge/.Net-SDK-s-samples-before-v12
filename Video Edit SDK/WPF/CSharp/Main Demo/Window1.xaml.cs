// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
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
    using System.IO;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    using VisioForge.Controls.UI.WPF;
    using VisioForge.Types;
    using VisioForge.Types.GPUVideoEffects;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.VideoEffects;

    using Color = System.Windows.Media.Color;
    using MessageBox = System.Windows.MessageBox;
    using VFM4AOutput = VisioForge.Types.OutputFormat.VFM4AOutput;

    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class Window1
    {
        private readonly List<AudioChannelMapperItem> audioChannelMapperItems = new List<AudioChannelMapperItem>();
        
        // Zoom
        private double zoom = 1.0;
        private int zoomShiftX;
        private int zoomShiftY;

        // Dialogs
        private readonly FontDialog fontDialog;
        private readonly Microsoft.Win32.SaveFileDialog saveFileDialog1;
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog1;
        private readonly Microsoft.Win32.OpenFileDialog openFileDialog2;
        private readonly ColorDialog colorDialog1;

        private static System.Drawing.Color ColorConv(Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private static Color ColorConv(System.Drawing.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private static string GetFileExt(string filename)
        {
            int k = filename.LastIndexOf('.');
            return filename.Substring(k, filename.Length - k);
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

        public Window1()
        {
            InitializeComponent();

            fontDialog = new FontDialog();
            saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
            openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog2 = new Microsoft.Win32.OpenFileDialog();
            colorDialog1 = new ColorDialog();
        }

        private void Form1_Load(object sender, RoutedEventArgs e)
        {
            Title += " (SDK v" + VideoEdit1.SDK_Version + ", " + VideoEdit1.SDK_State + ")";

            // font for text logo
            fontDialog.Color = System.Drawing.Color.White;
            fontDialog.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 32);

            cbFrameRate.SelectedIndex = 0;
            cbOutputVideoFormat.SelectedIndex = 14;
            cbWMVAudioMode.SelectedIndex = 0;
            cbWMVVideoMode.SelectedIndex = 0;
            cbWMVTVFormat.SelectedIndex = 0;
            cbOGGAverage.SelectedIndex = 6;
            cbOGGMaximum.SelectedIndex = 8;
            cbOGGMinimum.SelectedIndex = 5;
            cbTextLogoAlign.SelectedIndex = 0;
            cbTextLogoAntialiasing.SelectedIndex = 0;
            cbTextLogoDrawMode.SelectedIndex = 0;
            cbTextLogoEffectrMode.SelectedIndex = 0;
            cbTextLogoGradMode.SelectedIndex = 0;
            cbTextLogoShapeType.SelectedIndex = 0;
            cbMotDetHLColor.SelectedIndex = 1;
            cbRotate.SelectedIndex = 0;
            cbBarcodeType.SelectedIndex = 0;
            cbNetworkStreamingMode.SelectedIndex = 0;
            cbDirect2DRotate.SelectedIndex = 0;

            cbDVChannels.SelectedIndex = 1;
            cbDVSampleRate.SelectedIndex = 0;
            cbBPS.SelectedIndex = 0;
            cbChannels.SelectedIndex = 1;
            cbSampleRate.SelectedIndex = 0;
            cbBPS2.SelectedIndex = 0;
            cbChannels2.SelectedIndex = 1;
            cbSampleRate2.SelectedIndex = 0;
            cbLameCBRBitrate.SelectedIndex = 8;
            cbLameVBRMin.SelectedIndex = 8;
            cbLameVBRMax.SelectedIndex = 10;
            cbLameSampleRate.SelectedIndex = 0;

            cbMFProfile.SelectedIndex = 1;
            cbMFLevel.SelectedIndex = 12;
            cbMFRateControl.SelectedIndex = 3;

            var filtersAvailableInfo = VideoCapture.GetFiltersAvailable();
            if (filtersAvailableInfo.V11_NVENC_H264)
            {
                lbMFHWAvailableEncoders.Content += "NVENC ";
            }

            if (filtersAvailableInfo.V11_AMD_H264)
            {
                lbMFHWAvailableEncoders.Content += "AMD ";
            }

            if (filtersAvailableInfo.V11_QSV_H264)
            {
                lbMFHWAvailableEncoders.Content += "INTEL QSV";
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
            cbFFEXEProfile.SelectedIndex = 0;
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
            cbH264RateControl.SelectedIndex = 0;
            cbH264MBEncoding.SelectedIndex = 0;
            cbAACOutput.SelectedIndex = 0;
            cbAACMPEGVersion.SelectedIndex = 0;
            cbAACObject.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264PictureType.SelectedIndex = 0;
            cbH264TargetUsage.SelectedIndex = 0;

            cbM4AOutput.SelectedIndex = 0;
            cbM4AVersion.SelectedIndex = 0;
            cbM4AObjectType.SelectedIndex = 1;
            cbM4ABitrate.SelectedIndex = 12;

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputFileCut.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputFileJoin.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            for (int i = 0; i < VideoEdit1.Video_Codecs().Count; i++)
            {
                cbVideoCodec.Items.Add(VideoEdit1.Video_Codecs()[i]);
                cbCustomVideoCodec.Items.Add(VideoEdit1.Video_Codecs()[i]);
            }

            for (int i = 0; i < VideoEdit1.Audio_Codecs().Count; i++)
            {
                cbAudioCodec.Items.Add(VideoEdit1.Audio_Codecs()[i]);
                cbAudioCodecs2.Items.Add(VideoEdit1.Audio_Codecs()[i]);
                cbCustomAudioCodec.Items.Add(VideoEdit1.Audio_Codecs()[i]);
            }

            cbAudioCodec.Text = "PCM";
            cbAudioCodecs2.Text = "PCM";

            for (int i = 0; i < VideoEdit1.DirectShow_Filters().Count; i++)
            {
                cbCustomDSFilterV.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomDSFilterA.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomMuxer.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomFilewriter.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
            }

            cbVideoCodec.SelectedIndex = 0;
            cbCustomVideoCodec.SelectedIndex = 0;
            cbCustomAudioCodec.SelectedIndex = 0;
            cbCustomDSFilterV.SelectedIndex = 0;
            cbCustomDSFilterA.SelectedIndex = 0;
            cbCustomMuxer.SelectedIndex = 0;
            cbCustomFilewriter.SelectedIndex = 0;

            if (cbWMVAudioFormat.Items.Count > 0)
            {
                cbWMVAudioFormat.SelectedIndex = 0;
            }

            for (int i = 0; i < VideoEdit1.WMV_Internal_Profiles().Count; i++)
            {
                cbWMVInternalProfile9.Items.Add(VideoEdit1.WMV_Internal_Profiles()[i]);
            }

            cbWMVInternalProfile9.SelectedIndex = 0;

            List<string> names;
            List<string> descs;
            VideoEdit1.WMV_V8_Profiles(out names, out descs);

            foreach (string t in names)
            {
                cbWMVInternalProfile8.Items.Add(t);
            }

            cbWMVInternalProfile8.SelectedIndex = 0;

            cbCustomVideoCodecs_SelectedIndexChanged(null, null);
            cbCustomAudioCodecs_SelectedIndexChanged(null, null);
            cbCustomMuxer_SelectedIndexChanged(null, null);
            cbCustomDSFilterA_SelectedIndexChanged(null, null);
            cbCustomDSFilterV_SelectedIndexChanged(null, null);
            cbCustomFilewriter_SelectedIndexChanged(null, null);

            cbVideoCodecs_SelectedIndexChanged(null, null);
            cbAudioCodecs_SelectedIndexChanged(null, null);
            cbAudioCodecs2_SelectedIndexChanged(null, null);

            cbWMVAudioMode_SelectedIndexChanged(null, null);
            cbWMVVideoMode_SelectedIndexChanged(null, null);
            cbWMVAudioCodec.SelectedIndex = 0;
            cbWMVVideoCodec.SelectedIndex = 0;
            cbWMVAudioCodec_SelectedIndexChanged(null, null);

            for (int i = 0; i < VideoEdit1.Video_Transition_Names().Count; i++)
            {
                cbTransitionName.Items.Add(VideoEdit1.Video_Transition_Names()[i]);
            }

            cbTransitionName.SelectedIndex = 0;

            for (int i = 0; i < VideoEdit1.Audio_Effects_Equalizer_Presets().Count; i++)
            {
                cbAudEqualizerPreset.Items.Add(VideoEdit1.Audio_Effects_Equalizer_Presets()[i]);
            }

            if (cbAudioCodec.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodec.SelectedIndex = cbAudioCodec.Items.IndexOf("PCM");
            }

            if (cbVideoCodec.Items.IndexOf("MJPEG Compressor") != -1)
            {
                cbVideoCodec.SelectedIndex = cbVideoCodec.Items.IndexOf("MJPEG Compressor");
            }

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

            // ReSharper disable once CoVariantArrayConversion
            foreach (var item in VideoEdit1.Audio_Effects_Equalizer_Presets())
            {
                cbAudEqualizerPreset.Items.Add(item);
            }

            cbAudEqualizerPreset.SelectedIndex = 0;
        }

        /// <summary>
        /// Fills FFMPEG EXE settings.
        /// </summary>
        /// <param name="ffmpegOutput">
        /// FFMPEG parameters.
        /// </param>
        private void FillFFMPEGEXESettings(ref VFFFMPEGEXEOutput ffmpegOutput)
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

            ffmpegOutput.Video_Bitrate = Convert.ToInt32(this.edFFEXEVideoTargetBitrate.Text) * 1000;
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

        private void FillWMVSettings(ref VFWMVOutput wmvOutput)
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
                switch (s)
                {
                    case "CBR":
                        wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.CBR;
                        break;
                    case "VBR":
                        wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRBitrate;
                        break;
                    case "VBR (Peak)":
                        wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRPeakBitrate;
                        break;
                    default:
                        wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRQuality;
                        break;
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

                wmvOutput.Custom_Profile_Name = "MyProfile1";
            }
        }

        private void btAudioSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbAudioCodec.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
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

        private void FillLAMESettings(ref VFMP3Output lameOutput)
        {
            lameOutput.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text);
            lameOutput.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text);
            lameOutput.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text);
            lameOutput.SampleRate = Convert.ToInt32(cbLameSampleRate.Text);
            lameOutput.VBR_Quality = (int)tbLameVBRQuality.Value;
            lameOutput.EncodingQuality = (int)tbLameEncodingQuality.Value;

            if (rbLameStandardStereo.IsChecked == true)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.StandardStereo;
            }
            else if (rbLameJointStereo.IsChecked == true)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.JointStereo;
            }
            else if (rbLameDualChannels.IsChecked == true)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.DualStereo;
            }
            else
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.Mono;
            }

            lameOutput.VBR_Mode = rbLameVBR.IsChecked == true;
            lameOutput.Copyright = cbLameCopyright.IsChecked == true;
            lameOutput.Original = cbLameOriginal.IsChecked == true;
            lameOutput.CRCProtected = cbLameCRCProtected.IsChecked == true;
            lameOutput.ForceMono = cbLameForceMono.IsChecked == true;
            lameOutput.StrictlyEnforceVBRMinBitrate =
                cbLameStrictlyEnforceVBRMinBitrate.IsChecked == true;
            lameOutput.VoiceEncodingMode = cbLameVoiceEncodingMode.IsChecked == true;
            lameOutput.KeepAllFrequencies = cbLameKeepAllFrequencies.IsChecked == true;
            lameOutput.StrictISOCompliance = cbLameStrictISOCompilance.IsChecked == true;
            lameOutput.DisableShortBlocks = cbLameDisableShortBlocks.IsChecked == true;
            lameOutput.EnableXingVBRTag = cbLameEnableXingVBRTag.IsChecked == true;
            lameOutput.ModeFixed = cbLameModeFixed.IsChecked == true;
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            zoom = 1.0;
            zoomShiftX = 0;
            zoomShiftY = 0;

            mmLog.Clear();

            VideoEdit1.Debug_Mode = cbDebugMode.IsChecked == true;
            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            VideoEdit1.Video_Renderer.Zoom_Ratio = 0;
            VideoEdit1.Video_Renderer.Zoom_ShiftX = 0;
            VideoEdit1.Video_Renderer.Zoom_ShiftY = 0;

            VideoEdit1.Video_Effects_Clear();

            if (rbConvert.IsChecked == true)
            {
                VideoEdit1.Mode = VFVideoEditMode.Convert;
            }
            else
            {
                VideoEdit1.Mode = VFVideoEditMode.Preview;
            }

            VideoEdit1.Video_Resize = cbResize.IsChecked == true;

            if (VideoEdit1.Video_Resize)
            {
                VideoEdit1.Video_Resize_Width = Convert.ToInt32(edWidth.Text);
                VideoEdit1.Video_Resize_Height = Convert.ToInt32(edHeight.Text);
            }

            if (cbCrop.IsChecked == true)
            {
                VideoEdit1.Video_Crop = new VideoCropSettings(
                    Convert.ToInt32(edCropLeft.Text),
                    Convert.ToInt32(edCropTop.Text),
                    Convert.ToInt32(edCropRight.Text),
                    Convert.ToInt32(edCropBottom.Text));
            }
            else
            {
                VideoEdit1.Video_Crop = null;
            }

            if (cbSubtitlesEnabled.IsChecked == true)
            {
                VideoEdit1.Video_Subtitles = new SubtitlesSettings(edSubtitlesFilename.Text);
            }
            else
            {
                VideoEdit1.Video_Subtitles = null;
            }

            VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text);

            if (rbWPF.IsChecked == true)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;
            }
            else if (rbDirect2D.IsChecked == true)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.Direct2D;
            }
            else
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.None;
            }

            if (cbStretch.IsChecked == true)
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);

            VideoEdit1.Video_Renderer.BackgroundColor = VideoEdit.ColorConv(((SolidColorBrush)pnVideoRendererBGColor.Fill).Color);
            VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;

            // Network streaming
            VideoEdit1.Network_Streaming_Enabled = cbNetworkStreaming.IsChecked == true;

            if (VideoEdit1.Network_Streaming_Enabled)
            {
                switch (cbNetworkStreamingMode.SelectedIndex)
                {
                    case 0:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.WMV;

                            if (rbNetworkStreamingUseMainWMVSettings.IsChecked == true)
                            {
                                var wmvOutput = new VFWMVOutput();
                                FillWMVSettings(ref wmvOutput);
                                VideoEdit1.Network_Streaming_Output = wmvOutput;
                            }
                            else
                            {
                                var wmvOutput = new VFWMVOutput
                                                    {
                                                        Mode = VFWMVMode.ExternalProfile,
                                                        External_Profile_FileName = this.edNetworkStreamingWMVProfile.Text
                                                    };
                                VideoEdit1.Network_Streaming_Output = wmvOutput;
                            }

                            VideoEdit1.Network_Streaming_WMV_Maximum_Clients = Convert.ToInt32(edMaximumClients.Text);
                            VideoEdit1.Network_Streaming_Network_Port = Convert.ToInt32(edWMVNetworkPort.Text);

                            break;
                        }

                    case 1:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.RTSP_H264_AAC_SW;
                            VideoEdit1.Network_Streaming_URL = edNetworkRTSPURL.Text;

                            break;
                        }

                    case 2:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.RTMP_FFMPEG_EXE;

                            var ffmpegOutput = new VFFFMPEGEXEOutput();

                            if (rbNetworkUDPFFMPEG.IsChecked == true)
                            {
                                ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                            }
                            else
                            {
                                FillFFMPEGEXESettings(ref ffmpegOutput);
                            }

                            ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLV;

                            VideoEdit1.Network_Streaming_Output = ffmpegOutput;
                            VideoEdit1.Network_Streaming_URL = edNetworkRTMPURL.Text;

                            break;
                        }

                    case 3:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.UDP_FFMPEG_EXE;

                            var ffmpegOutput = new VFFFMPEGEXEOutput();

                            if (rbNetworkUDPFFMPEG.IsChecked == true)
                            {
                                ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                            }
                            else
                            {
                                FillFFMPEGEXESettings(ref ffmpegOutput);
                            }

                            ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS;
                            VideoEdit1.Network_Streaming_Output = ffmpegOutput;

                            VideoEdit1.Network_Streaming_URL = edNetworkUDPURL.Text;

                            break;
                        }

                    case 4:
                        {
                            if (rbNetworkSSSoftware.IsChecked == true)
                            {
                                VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_H264_AAC_SW;
                            }
                            else
                            {
                                VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_FFMPEG_EXE;

                                var ffmpegOutput = new VFFFMPEGEXEOutput();

                                if (rbNetworkSSFFMPEGDefault.IsChecked == true)
                                {
                                    ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, true);
                                }
                                else
                                {
                                    FillFFMPEGEXESettings(ref ffmpegOutput);
                                }

                                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ISMV;
                                VideoEdit1.Network_Streaming_Output = ffmpegOutput;
                            }

                            VideoEdit1.Network_Streaming_URL = edNetworkSSURL.Text;

                            break;
                        }

                    case 5:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.External;

                            break;
                        }
                }

                VideoEdit1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.IsChecked == true;
            }

            VideoEdit1.Output_Filename = edOutput.Text;

            VFVideoEditOutputFormat outputFormat = VFVideoEditOutputFormat.AVI;
            switch (cbOutputVideoFormat.SelectedIndex)
            {
                case 0:
                    outputFormat = VFVideoEditOutputFormat.AVI;
                    break;
                case 1:
                    outputFormat = VFVideoEditOutputFormat.MKV;
                    break;
                case 2:
                    {
                        outputFormat = VFVideoEditOutputFormat.WMV;
                        var wmvOutput = new VFWMVOutput();
                        FillWMVSettings(ref wmvOutput);
                        VideoEdit1.Output_Format = wmvOutput;
                    }

                    break;
                case 3:
                    outputFormat = VFVideoEditOutputFormat.DV;
                    break;
                case 4:
                    outputFormat = VFVideoEditOutputFormat.PCM_ACM;
                    break;
                case 5:
                    outputFormat = VFVideoEditOutputFormat.LAME;
                    break;
                case 6:
                    outputFormat = VFVideoEditOutputFormat.M4A;
                    break;
                case 7:
                    {
                        outputFormat = VFVideoEditOutputFormat.WMA;
                        var wmvOutput = new VFWMVOutput();
                        FillWMVSettings(ref wmvOutput);
                        VideoEdit1.Output_Format = wmvOutput;
                    }

                    break;
                case 8:
                    outputFormat = VFVideoEditOutputFormat.OggVorbis;
                    break;
                case 9:
                    outputFormat = VFVideoEditOutputFormat.FLAC;
                    break;
                case 10:
                    outputFormat = VFVideoEditOutputFormat.Speex;
                    break;
                case 11:
                    outputFormat = VFVideoEditOutputFormat.Custom;
                    break;
                case 12:
                    outputFormat = VFVideoEditOutputFormat.FFMPEG_DLL;
                    break;
                case 13:
                    outputFormat = VFVideoEditOutputFormat.WebM;
                    break;
                case 14:
                    outputFormat = VFVideoEditOutputFormat.MP4;
                    break;
                case 15:
                    outputFormat = VFVideoEditOutputFormat.AnimatedGIF;
                    break;
                case 16:
                    outputFormat = VFVideoEditOutputFormat.Encrypted;
                    break;
            }

            if (outputFormat == VFVideoEditOutputFormat.AVI)
            {
                var aviOutput = new VFAVIOutput
                                    {
                                        ACM =
                                            {
                                                Name = this.cbAudioCodec.Text,
                                                Channels = Convert.ToInt32(this.cbChannels.Text),
                                                BPS = Convert.ToInt32(this.cbBPS.Text),
                                                SampleRate = Convert.ToInt32(this.cbSampleRate.Text)
                                            },
                                        Video_Codec = this.cbVideoCodec.Text
                                    };

                if (cbUseLameInAVI.IsChecked == true)
                {
                    aviOutput.Audio_UseMP3Encoder = true;

                    var lameOutput = new VFMP3Output();
                    FillLAMESettings(ref lameOutput);
                    aviOutput.MP3 = lameOutput;
                }

                VideoEdit1.Output_Format = aviOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.MKV)                
            {
                var mkvOutput = new VFMKVOutput
                                    {
                                        ACM =
                                            {
                                                Name = this.cbAudioCodec.Text,
                                                Channels = Convert.ToInt32(this.cbChannels.Text),
                                                BPS = Convert.ToInt32(this.cbBPS.Text),
                                                SampleRate = Convert.ToInt32(this.cbSampleRate.Text)
                                            },
                                        Video_Codec = this.cbVideoCodec.Text
                                    };

                if (cbUseLameInAVI.IsChecked == true)
                {
                    mkvOutput.Audio_UseMP3Encoder = true;

                    var lameOutput = new VFMP3Output();
                    FillLAMESettings(ref lameOutput);
                    mkvOutput.MP3 = lameOutput;
                }

                VideoEdit1.Output_Format = mkvOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.WMA)
            {
                VFWMVOutput wmvOutput = (VFWMVOutput)VideoEdit1.Output_Format;
                wmvOutput.External_Profile_FileName = edWMVProfile.Text;
                VideoEdit1.Output_Format = wmvOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.DV)
            {
                var dvOutput = new VFDVOutput
                                   {
                                       Audio_Channels = Convert.ToInt32(this.cbDVChannels.Text),
                                       Audio_SampleRate = Convert.ToInt32(this.cbDVSampleRate.Text)
                                   };
                
                if (rbDVPAL.IsChecked == true)
                {
                    dvOutput.Video_Format = VFDVVideoFormat.PAL;
                }
                else
                {
                    dvOutput.Video_Format = VFDVVideoFormat.NTSC;
                }

                dvOutput.Type2 = rbDVType2.IsChecked == true;

                VideoEdit1.Output_Format = dvOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.Custom)
            {
                var customOutput = new VFCustomOutput();

                if (rbCustomUseVideoCodecsCat.IsChecked == true)
                {
                    customOutput.Video_Codec = cbCustomVideoCodec.Text;
                    customOutput.Video_Codec_UseFiltersCategory = false;
                }
                else
                {
                    customOutput.Video_Codec = cbCustomDSFilterV.Text;
                    customOutput.Video_Codec_UseFiltersCategory = true;
                }

                if (rbCustomUseAudioCodecsCat.IsChecked == true)
                {
                    customOutput.Audio_Codec = cbCustomAudioCodec.Text;
                    customOutput.Audio_Codec_UseFiltersCategory = false;
                }
                else
                {
                    customOutput.Audio_Codec = cbCustomDSFilterA.Text;
                    customOutput.Audio_Codec_UseFiltersCategory = true;
                }

                customOutput.MuxFilter_Name = cbCustomMuxer.Text;
                customOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.IsChecked == true;
                customOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text;
                customOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.IsChecked == true;

                VideoEdit1.Output_Format = customOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.PCM_ACM)
            {
                var acmOutput = new VFACMOutput
                                    {
                                        Channels = Convert.ToInt32(this.cbChannels2.Text),
                                        BPS = Convert.ToInt32(this.cbBPS2.Text),
                                        SampleRate = Convert.ToInt32(this.cbSampleRate2.Text),
                                        Name = this.cbAudioCodecs2.Text
                                    };

                VideoEdit1.Output_Format = acmOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.M4A)
            {
                var m4aOutput = new VFM4AOutput();

                int tmp;
                int.TryParse(cbM4ABitrate.Text, out tmp);
                m4aOutput.Bitrate = tmp;
                m4aOutput.Version = (VFAACVersion)cbM4AVersion.SelectedIndex;
                m4aOutput.Output = (VFAACOutput)cbM4AOutput.SelectedIndex;
                m4aOutput.Object = (VFAACObject)(cbM4AObjectType.SelectedIndex + 1);

                VideoEdit1.Output_Format = m4aOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.FLAC)
            {
                var flacOutput = new VFFLACOutput
                                     {
                                         Level = (int)this.tbFLACLevel.Value,
                                         BlockSize = Convert.ToInt32(this.cbFLACBlockSize.Text),
                                         AdaptiveMidSideCoding = this.cbFLACAdaptiveMidSideCoding.IsChecked == true,
                                         ExhaustiveModelSearch = this.cbFLACExhaustiveModelSearch.IsChecked == true,
                                         LPCOrder = (int)this.tbFLACLPCOrder.Value,
                                         MidSideCoding = this.cbFLACMidSideCoding.IsChecked == true,
                                         RiceMin = Convert.ToInt32(this.edFLACRiceMin.Text),
                                         RiceMax = Convert.ToInt32(this.edFLACRiceMax.Text)
                                     };

                VideoEdit1.Output_Format = flacOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.OggVorbis)
            {
                var oggVorbisOutput = new VFOGGVorbisOutput
                                          {
                                              Quality = Convert.ToInt32(this.edOGGQuality.Text),
                                              MinBitRate = Convert.ToInt32(this.cbOGGMinimum.Text),
                                              MaxBitRate = Convert.ToInt32(this.cbOGGMaximum.Text),
                                              AvgBitRate = Convert.ToInt32(this.cbOGGAverage.Text)
                                          };

                if (rbOGGQuality.IsChecked == true)
                {
                    oggVorbisOutput.Mode = VFVorbisMode.Quality;
                }
                else
                {
                    oggVorbisOutput.Mode = VFVorbisMode.Bitrate;
                }

                VideoEdit1.Output_Format = oggVorbisOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.Speex)
            {
                var speexOutput = new VFSpeexOutput
                                      {
                                          BitRate = (int)this.tbSpeexBitrate.Value,
                                          BitrateControl = (SpeexBitrateControl)this.cbSpeexBitrateControl.SelectedIndex,
                                          Mode = (SpeexEncodeMode)this.cbSpeexMode.SelectedIndex,
                                          MaxBitRate = (int)this.tbSpeexMaxBitrate.Value,
                                          Complexity = (int)this.tbSpeexComplexity.Value,
                                          Quality = (int)this.tbSpeexQuality.Value,
                                          UseAGC = this.cbSpeexAGC.IsChecked == true,
                                          UseDTX = this.cbSpeexDTX.IsChecked == true,
                                          UseDenoise = this.cbSpeexDenoise.IsChecked == true,
                                          UseVAD = this.cbSpeexVAD.IsChecked == true
                                      };

                VideoEdit1.Output_Format = speexOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.LAME)
            {
                var lameOutput = new VFMP3Output();
                FillLAMESettings(ref lameOutput);
                VideoEdit1.Output_Format = lameOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.WebM)
            {
                var webmOutput = new VFWebMOutput
                                     {
                                         Audio_Quality = (int)this.tbWebMAudioQuality.Value,
                                         Video_Bitrate = Convert.ToInt32(this.edWebMVideoBitrate.Text),
                                         Video_ARNR_MaxFrames = Convert.ToInt32(this.edWebMVideoARNRMaxFrames.Text),
                                         Video_ARNR_Strength = Convert.ToInt32(this.edWebMVideoARNRStrenght.Text),
                                         Video_ARNR_Type = Convert.ToInt32(this.edWebMVideoARNRType.Text),
                                         Video_CPUUsed = Convert.ToInt32(this.edWebMVideoCPUUsed.Text),
                                         Video_Decimate = Convert.ToInt32(this.edWebMVideoDecimate.Text),
                                         Video_Decoder_Buffer_Size = Convert.ToInt32(this.edWebMVideoDecoderBufferSize.Text),
                                         Video_Decoder_Buffer_InitialSize =
                                             Convert.ToInt32(this.edWebMVideoDecoderInitialBuffer.Text),
                                         Video_Decoder_Buffer_OptimalSize =
                                             Convert.ToInt32(this.edWebMVideoDecoderOptimalBuffer.Text),
                                         Video_FixedKeyframeInterval =
                                             Convert.ToInt32(this.edWebMVideoFixedKeyframeInterval.Text),
                                         Video_Keyframe_MaxInterval =
                                             Convert.ToInt32(this.edWebMVideoKeyframeMaxInterval.Text),
                                         Video_Keyframe_MinInterval =
                                             Convert.ToInt32(this.edWebMVideoKeyframeMinInterval.Text),
                                         Video_LagInFrames = Convert.ToInt32(this.edWebMVideoLagInFrames.Text),
                                         Video_MaxQuantizer = Convert.ToInt32(this.edWebMVideoMaxQuantizer.Text),
                                         Video_MinQuantizer = Convert.ToInt32(this.edWebMVideoMinQuantizer.Text),
                                         Video_OvershootPct = Convert.ToInt32(this.edWebMVideoOvershootPct.Text),
                                         Video_SpatialResampling_DownThreshold =
                                             Convert.ToInt32(this.edWebMVideoSpatialDownThreshold.Text),
                                         Video_SpatialResampling_UpThreshold =
                                             Convert.ToInt32(this.edWebMVideoSpatialUpThreshold.Text),
                                         Video_StaticThreshold = Convert.ToInt32(this.edWebMVideoStaticThreshold.Text),
                                         Video_ThreadCount = Convert.ToInt32(this.edWebMVideoThreadCount.Text),
                                         Video_TokenPartition = Convert.ToInt32(this.edWebMVideoTokenPartition.Text),
                                         Video_UndershootPct = Convert.ToInt32(this.edWebMVideoUndershootPct.Text),
                                         Video_AutoAltRef = this.cbWebMVideoAutoAltRef.IsChecked == true,
                                         Video_ErrorResilient = this.cbWebMVideoErrorResilent.IsChecked == true,
                                         Video_SpatialResampling_Allowed =
                                             this.cbWebMVideoSpatialResamplingAllowed.IsChecked == true,
                                         Video_Encoder = (WebMVideoEncoder)this.cbWebMVideoEncoder.SelectedIndex
                                     };

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

                VideoEdit1.Output_Format = webmOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.AnimatedGIF)
            {
                var gifOutput = new VFAnimatedGIFOutput
                                    {
                                        FrameRate = Convert.ToDouble(this.edGIFFrameRate.Text),
                                        ForcedVideoWidth = Convert.ToInt32(this.edGIFWidth.Text),
                                        ForcedVideoHeight = Convert.ToInt32(this.edGIFHeight.Text)
                                    };
                VideoEdit1.Output_Format = gifOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.FFMPEG_DLL)
            {
                var ffmpegDLLOutput = new VFFFMPEGDLLOutput();

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

                VideoEdit1.Output_Format = ffmpegDLLOutput;
            }

            if ((outputFormat == VFVideoEditOutputFormat.MP4) ||
((outputFormat == VFVideoEditOutputFormat.Encrypted) && (rbEncryptedH264SW.IsChecked == true)) ||
                    (VideoEdit1.Network_Streaming_Enabled && (VideoEdit1.Network_Streaming_Format == VFNetworkStreamingFormat.RTSP_H264_AAC_SW)))
            {
                int tmp;

                var mp4Output = new VFMP4Output();

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
                    mp4Output.Video_v10.GOP = cbH264GOP.IsChecked == true;
                    mp4Output.Video_v10.BitrateAuto = cbH264AutoBitrate.IsChecked == true;

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

                    mp4Output.Video_v11.CABAC = cbMFCABAC.IsChecked == true;
                    mp4Output.Video_v11.LowLatencyMode = cbMFLowLatency.IsChecked == true;

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

                // Audio AAC settings
                int.TryParse(cbAACBitrate.Text, out tmp);
                mp4Output.Audio_AAC.Bitrate = tmp;

                mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACMPEGVersion.SelectedIndex;
                mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
                mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObject.SelectedIndex + 1);

                // encryption
                if (outputFormat == VFVideoEditOutputFormat.Encrypted)
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

                VideoEdit1.Output_Format = mp4Output;
            }

            VideoEdit1.Audio_Preview_Enabled = true;

            // Audio enhancement
            VideoEdit1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.IsChecked == true;
            if (VideoEdit1.Audio_Enhancer_Enabled)
            {
                VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.IsChecked == true);
                VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.IsChecked == true);

                ApplyAudioInputGains();
                ApplyAudioOutputGains();

                VideoEdit1.Audio_Enhancer_Timeshift(-1, (int)tbAudioTimeshift.Value);
            }

            // Audio channels mapping
            if (cbAudioChannelMapperEnabled.IsChecked == true)
            {
                VideoEdit1.Audio_Channel_Mapper = new AudioChannelMapperSettings
                                                      {
                                                          Routes = this.audioChannelMapperItems.ToArray(),
                                                          OutputChannelsCount =
                                                              Convert.ToInt32(this.edAudioChannelMapperOutputChannels.Text)
                                                      };
            }
            else
            {
                VideoEdit1.Audio_Channel_Mapper = null;
            }

            // Audio processing
            VideoEdit1.Audio_Effects_Clear(-1);
            VideoEdit1.Audio_Effects_Enabled = cbAudioEffectsEnabled.IsChecked == true;
            if (VideoEdit1.Audio_Effects_Enabled)
            {
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.IsChecked == true, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.IsChecked == true, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.IsChecked == true, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.IsChecked == true, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.IsChecked == true, -1, -1);

                tbAudAmplifyAmp_Scroll(sender, null);
                tbAudDynAmp_Scroll(sender, null);
                tbAudAttack_Scroll(sender, null);
                tbAudRelease_Scroll(sender, null);
                tbAud3DSound_Scroll(sender, null);
                tbAudTrueBass_Scroll(sender, null);

                tbAudEq0_Scroll(sender, null);
                tbAudEq1_Scroll(sender, null);
                tbAudEq2_Scroll(sender, null);
                tbAudEq3_Scroll(sender, null);
                tbAudEq4_Scroll(sender, null);
                tbAudEq5_Scroll(sender, null);
                tbAudEq6_Scroll(sender, null);
                tbAudEq7_Scroll(sender, null);
                tbAudEq8_Scroll(sender, null);
                tbAudEq9_Scroll(sender, null);
            }

            // Virtual camera output
            VideoEdit1.Virtual_Camera_Output_Enabled = cbVirtualCamera.IsChecked == true;

            VideoEdit1.Video_Effects_Enabled = cbEffects.IsChecked == true;
            VideoEdit1.Video_Effects_Clear();

            // Deinterlace
            if (cbDeinterlace.IsChecked == true)
            {
                if (rbDeintBlendEnabled.IsChecked == true)
                {
                    IVFVideoEffectDeinterlaceBlend blend;
                    var effect = VideoEdit1.Video_Effects_Get("DeinterlaceBlend");
                    if (effect == null)
                    {
                        blend = new VFVideoEffectDeinterlaceBlend(true);
                        VideoEdit1.Video_Effects_Add(blend);
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
                    var effect = VideoEdit1.Video_Effects_Get("DeinterlaceCAVT");
                    if (effect == null)
                    {
                        cavt = new VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.IsChecked == true, Convert.ToInt32(edDeintCAVTThreshold.Text));
                        VideoEdit1.Video_Effects_Add(cavt);
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
                    var effect = VideoEdit1.Video_Effects_Get("DeinterlaceTriangle");
                    if (effect == null)
                    {
                        triangle = new VFVideoEffectDeinterlaceTriangle(true, Convert.ToByte(edDeintTriangleWeight.Text));
                        VideoEdit1.Video_Effects_Add(triangle);
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
            if (cbDenoise.IsChecked == true)
            {
                if (rbDenoiseCAST.IsChecked == true)
                {
                    IVFVideoEffectDenoiseCAST cast;
                    var effect = VideoEdit1.Video_Effects_Get("DenoiseCAST");
                    if (effect == null)
                    {
                        cast = new VFVideoEffectDenoiseCAST(true);
                        VideoEdit1.Video_Effects_Add(cast);
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
                    var effect = VideoEdit1.Video_Effects_Get("DenoiseMosquito");
                    if (effect == null)
                    {
                        mosquito = new VFVideoEffectDenoiseMosquito(true);
                        this.VideoEdit1.Video_Effects_Add(mosquito);
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

            // Chromakey
            ConfigureChromaKey();

            // Object detection
            ConfigureObjectDetection();

            VideoEdit1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.IsChecked == true;

            // Barcode detection
            VideoEdit1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.IsChecked == true;
            VideoEdit1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;

            // Decklink output
            ConfigureDecklinkOutput();

            // motion detection
            if (cbMotDetEnabled.IsChecked == true)
            {
                btMotDetUpdateSettings_Click(null, null); // apply settings
            }

            // video rotation
            switch (cbRotate.SelectedIndex)
            {
                case 0:
                    VideoEdit1.Video_Rotation = VFRotateMode.RotateNone;
                    break;
                case 1:
                    VideoEdit1.Video_Rotation = VFRotateMode.Rotate90;
                    break;
                case 2:
                    VideoEdit1.Video_Rotation = VFRotateMode.Rotate180;
                    break;
                case 3:
                    VideoEdit1.Video_Rotation = VFRotateMode.Rotate270;
                    break;
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

                VideoEdit1.Tags = tags;
            }

            VideoEdit1.Start();

            lbTransitions.Items.Clear();

            edNetworkURL.Text = VideoEdit1.Network_Streaming_URL;
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Stop();

            pbProgress.Value = 0;

            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
        }

        private void btVideoSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbVideoCodec.Text;

            if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
            {
                if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void cbAudioCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbAudioCodec.Text;
            btAudioSettings.IsEnabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbVideoCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbVideoCodec.Text;
            btVideoSettings.IsEnabled = VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbGreyscale_CheckedChanged(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectGrayscale grayscale;
            var effect = VideoEdit1.Video_Effects_Get("Grayscale");
            if (effect == null)
            {
                grayscale = new VFVideoEffectGrayscale(cbGreyscale.IsChecked == true);
                VideoEdit1.Video_Effects_Add(grayscale);
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
            var effect = VideoEdit1.Video_Effects_Get("Invert");
            if (effect == null)
            {
                invert = new VFVideoEffectInvert(cbInvert.IsChecked == true);
                VideoEdit1.Video_Effects_Add(invert);
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

        private void cbCustomVideoCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomVideoCodec.Text;
            btCustomVideoCodecSettings.IsEnabled = VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomAudioCodecs_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomAudioCodec.Text;
            btCustomAudioCodecSettings.IsEnabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodecs2_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbAudioCodecs2.Text;
            btAudioSettings2.IsEnabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterV_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomDSFilterV.Text;
            btCustomDSFiltersVSettings.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterA_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomDSFilterA.Text;
            btCustomDSFiltersASettings.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomMuxer_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomMuxer.Text;
            btCustomMuxerSettings.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomFilewriter_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = cbCustomFilewriter.Text;
            btCustomFilewriterSettings.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btCustomAudioCodecSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomAudioCodec.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersASettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomDSFilterA.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersVSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomDSFilterV.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomFilewriterSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomFilewriter.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomMuxerSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomMuxer.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomVideoCodecSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbCustomVideoCodec.Text;

            if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbImageLogo_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (VideoEdit1 == null)
            {
                return;
            }

            if (!File.Exists(edImageLogoFilename.Text))
            {
                if (cbImageLogo.IsChecked == true)
                {
                    MessageBox.Show("Unable to find " + edImageLogoFilename.Text);
                    cbImageLogo.IsChecked = false;
                }

                return;
            }

            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoEdit1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.IsChecked == true);
                VideoEdit1.Video_Effects_Add(imageLogo);
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

        private void cbGraphicLogoShowAlways_CheckedChanged(object sender, RoutedEventArgs e)
        {
            this.edImageLogoStartTime.IsEnabled = this.cbImageLogoShowAlways.IsChecked != true;
            this.edImageLogoStopTime.IsEnabled = this.cbImageLogoShowAlways.IsChecked != true;
            lbGraphicLogoStartTime.IsEnabled = this.cbImageLogoShowAlways.IsChecked != true;
            lbGraphicLogoStopTime.IsEnabled = this.cbImageLogoShowAlways.IsChecked != true;

            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void btAudioSettings2_Click(object sender, RoutedEventArgs e)
        {
            string name = cbAudioCodecs2.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                string name = cbFilters.Text;
                btFilterSettings.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                    VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                VideoEdit1.Video_Filters_Add(new VFCustomProcessingFilter(cbFilters.Text));
                lbFilters.Items.Add(cbFilters.Text);
            }
        }

        private void btFilterSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbFilters.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterSettings2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.SelectedValue.ToString();

                if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
                {
                    VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
                }
                else if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btFilterDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            lbFilters.Items.Clear();
            VideoEdit1.Video_Filters_Clear();
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
            var effect = VideoEdit1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.IsChecked == true);
                VideoEdit1.Video_Effects_Add(textLogo);
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

            if (cbTextLogoDateTime.IsChecked == true)
            {
                textLogo.Mode = TextLogoMode.DateTime;
                textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss";
            }
            else
            {
                textLogo.Mode = TextLogoMode.Text;
            }

            if (cbTextLogoFadeIn.IsChecked == true)
            {
                textLogo.FadeIn = true;
                textLogo.FadeInDuration = 5000;
            }
            else
            {
                textLogo.FadeIn = false;
            }

            if (cbTextLogoFadeOut.IsChecked == true)
            {
                textLogo.FadeOut = true;
                textLogo.FadeOutDuration = 5000;
            }
            else
            {
                textLogo.FadeOut = false;
            }

            textLogo.Update();
        }

        private void btAudEqRefresh_Click(object sender, RoutedEventArgs e)
        {
            tbAudEq0.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0);
            tbAudEq1.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1);
            tbAudEq2.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2);
            tbAudEq3.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3);
            tbAudEq4.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4);
            tbAudEq5.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5);
            tbAudEq6.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6);
            tbAudEq7.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7);
            tbAudEq8.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8);
            tbAudEq9.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9);
        }

        private void btSelectImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog2.ShowDialog() == true)
            {
                this.edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void cbAudAmplifyEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.IsChecked == true);
        }

        private void cbAudDynamicAmplifyEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.IsChecked == true);
        }

        private void cbAudEqualizerEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.IsChecked == true);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(sender, e);
        }

        private void cbAudSound3DEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.IsChecked == true);
        }

        private void cbAudTrueBassEnabled_CheckedChanged(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.IsChecked == true);
        }

        private void cbWMVAudioCodec_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VFWMVStreamMode mode = VFWMVStreamMode.CBR;
            switch (cbWMVAudioMode.SelectedIndex)
            {
                case 0:
                    mode = VFWMVStreamMode.CBR;
                    break;
                case 1:
                    mode = VFWMVStreamMode.VBRBitrate;
                    break;
                case 2:
                    mode = VFWMVStreamMode.VBRPeakBitrate;
                    break;
                case 3:
                    mode = VFWMVStreamMode.VBRQuality;
                    break;
            }

            cbWMVAudioFormat.Items.Clear();
            if (cbWMVAudioCodec.SelectedIndex != -1)
            {
                foreach (string format in VideoEdit1.WMV_Custom_Audio_Formats(cbWMVAudioCodec.Text, mode))
                {
                    cbWMVAudioFormat.Items.Add(format);
                }
            }
        }

        private void cbWMVAudioMode_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            VFWMVStreamMode mode = VFWMVStreamMode.CBR;
            switch (cbWMVAudioMode.SelectedIndex)
            {
                case 0:
                    mode = VFWMVStreamMode.CBR;
                    break;
                case 1:
                    mode = VFWMVStreamMode.VBRBitrate;
                    break;
                case 2:
                    mode = VFWMVStreamMode.VBRPeakBitrate;
                    break;
                case 3:
                    mode = VFWMVStreamMode.VBRQuality;
                    break;
            }

            cbWMVAudioCodec.Items.Clear();
            foreach (string codec in VideoEdit1.WMV_Custom_Audio_Codecs(mode))
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
            foreach (string codec in VideoEdit1.WMV_Custom_Video_Codecs(mode))
            {
                cbWMVVideoCodec.Items.Add(codec);
            }
        }

        private void tbAud3DSound_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1?.Audio_Effects_Sound3D(-1, 3, (ushort)this.tbAud3DSound.Value);
        }

        private void tbAudDynAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1?.Audio_Effects_DynamicAmplify(
                -1, 2, (int)this.tbAudAttack.Value, (int)this.tbAudDynAmp.Value, (int)this.tbAudRelease.Value);
        }

        private void tbAudAttack_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1?.Audio_Effects_DynamicAmplify(
                -1, 2, (int)this.tbAudAttack.Value, (int)this.tbAudDynAmp.Value, (int)this.tbAudRelease.Value);
        }

        private void tbAudEq0_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, (sbyte)tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, (sbyte)tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, (sbyte)tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, (sbyte)tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, (sbyte)tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, (sbyte)tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, (sbyte)tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, (sbyte)tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, (sbyte)tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, (sbyte)tbAudEq9.Value);
        }

        private void tbAudTrueBass_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1.Audio_Effects_TrueBass(-1, 4, 200, false, (ushort)tbAudTrueBass.Value);
        }

        private void tbContrast_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectContrast contrast;
            var effect = VideoEdit1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, (int)tbContrast.Value);
                VideoEdit1.Video_Effects_Add(contrast);
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
            var effect = VideoEdit1.Video_Effects_Get("Darkness");
            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, (int)tbDarkness.Value);
                VideoEdit1.Video_Effects_Add(darkness);
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
            var effect = VideoEdit1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, (int)tbLightness.Value);
                VideoEdit1.Video_Effects_Add(lightness);
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
            if (VideoEdit1 != null)
            {
                IVFVideoEffectSaturation saturation;
                var effect = VideoEdit1.Video_Effects_Get("Saturation");
                if (effect == null)
                {
                    saturation = new VFVideoEffectSaturation((int)tbSaturation.Value);
                    VideoEdit1.Video_Effects_Add(saturation);
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

        private void ConfigureChromaKey()
        {
            if (cbChromaKeyEnabled.IsChecked == true)
            {
                VideoEdit1.ChromaKey = new ChromaKeySettings
                                           {
                                               ContrastHigh = (int)this.tbChromaKeyContrastHigh.Value,
                                               ContrastLow = (int)this.tbChromaKeyContrastLow.Value,
                                               ImageFilename = this.edChromaKeyImage.Text
                                           };

                if (rbChromaKeyGreen.IsChecked == true)
                {
                    VideoEdit1.ChromaKey.Color = VFChromaColor.Green;
                }
                else if (rbChromaKeyBlue.IsChecked == true)
                {
                    VideoEdit1.ChromaKey.Color = VFChromaColor.Blue;
                }
                else
                {
                    VideoEdit1.ChromaKey.Color = VFChromaColor.Red;
                }
            }
            else
            {
                VideoEdit1.ChromaKey = null;
            }
        }

        private void ConfigureDecklinkOutput()
        {
            if (cbDecklinkOutput.IsChecked == true)
            {
                VideoEdit1.Decklink_Output = new DecklinkOutputSettings
                                                 {
                                                     DVEncoding = this.cbDecklinkDV.IsChecked == true,
                                                     AnalogOutputIREUSA = this.cbDecklinkOutputNTSC.SelectedIndex == 0,
                                                     AnalogOutputSMPTE =
                                                         this.cbDecklinkOutputComponentLevels.SelectedIndex == 0,
                                                     BlackToDeckInCapture =
                                                         (DecklinkBlackToDeckInCapture)
                                                         this.cbDecklinkOutputBlackToDeck.SelectedIndex,
                                                     DualLinkOutputMode =
                                                         (DecklinkDualLinkMode)this.cbDecklinkOutputDualLink.SelectedIndex,
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
                                                         this.cbDecklinkOutputDownConversionAnalogOutput.IsChecked == true,
                                                     AnalogOutput =
                                                         (DecklinkAnalogOutput)this.cbDecklinkOutputAnalog.SelectedIndex
                                                 };
            }
            else
            {
                VideoEdit1.Decklink_Output = null;
            }
        }

        private void ConfigureObjectDetection()
        {
            if (cbAFMotionDetection.IsChecked == true)
            {
                VideoEdit1.Motion_DetectionEx = new MotionDetectionExSettings();
                if (cbAFMotionHighlight.IsChecked == true)
                {
                    VideoEdit1.Motion_DetectionEx.ProcessorType = MotionProcessorType.MotionAreaHighlighting;
                }
                else
                {
                    VideoEdit1.Motion_DetectionEx.ProcessorType = MotionProcessorType.None;
                }
            }
            else
            {
                VideoEdit1.Motion_DetectionEx = null;
            }
        }

        private void tbAudAmplifyAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1?.Audio_Effects_Amplify(-1, 0, (int)this.tbAudAmplifyAmp.Value * 10, false);
        }

        private void tbAudRelease_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VideoEdit1?.Audio_Effects_DynamicAmplify(
                -1, 2, (ushort)this.tbAudAttack.Value, (ushort)this.tbAudDynAmp.Value, (int)this.tbAudRelease.Value);
        }

        private void linkLabel1_LinkClicked(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (VideoEdit1.Status == VFVideoEditStatus.Work)
            {
                VideoEdit1.Stop();
            }
        }

        private void VideoEdit1_OnError(object sender, ErrorsEventArgs e)
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
                btFilterSettings2.IsEnabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                                            VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
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
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoEdit1.Video_Renderer_Update();
        }

        private void VideoEdit1_OnProgress(object sender, ProgressEventArgs e)
        {
            pbProgress.Value = e.Progress;

            // Application.DoEvents();
        }

        public delegate void StopDelegate(VideoEditStopEventArgs e);

        public void StopDelegateMethod(VideoEditStopEventArgs e)
        {
            pbProgress.Value = 0;
            if (e.Successful)
            {
                MessageBox.Show("Completed successfully");
            }
            else
            {
                MessageBox.Show("Stopped with error");
            }

            VideoEdit1.Input_Clear_List();
            lbFiles.Items.Clear();

            VideoEdit1.Video_Transition_Clear();
            lbTransitions.Items.Clear();
        }

        private void VideoEdit1_OnStop(object sender, VideoEditStopEventArgs e)
        {
            Dispatcher.BeginInvoke(new StopDelegate(StopDelegateMethod), e);
        }

        private void VideoEdit1_OnStart(object sender, EventArgs e)
        {
            tbSeeking.Maximum = VideoEdit1.Duration();
        }

        private void btAddInputFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text, CultureInfo.InvariantCulture);

                // resize if required
                int customWidth = 0;
                int customHeight = 0;

                if (cbResize.IsChecked == true)
                {
                    customWidth = Convert.ToInt32(edWidth.Text);
                    customHeight = Convert.ToInt32(edHeight.Text);
                }

                string s = openFileDialog1.FileName;

                lbFiles.Items.Add(s);

                if ((string.Compare(GetFileExt(s), ".BMP", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".JPEG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".GIF", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".PNG", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    if (cbAddFullFile.IsChecked == true)
                    {
                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddImageFile(s, 2000, -1, VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight);
                        }
                        else
                        {
                            VideoEdit1.Input_AddImageFile(s, 2000, Convert.ToInt32(edInsertTime.Text), VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight);
                        }
                    }
                    else
                    {
                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddImageFile(s, Convert.ToInt32(edStopTime.Text) - Convert.ToInt32(edStartTime.Text), -1, VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight);
                        }
                        else
                        {
                            VideoEdit1.Input_AddImageFile(
                                s,
                                Convert.ToInt32(edStopTime.Text) - Convert.ToInt32(edStartTime.Text),
                                Convert.ToInt32(edInsertTime.Text),
                                VFVideoEditStretchMode.Letterbox,
                                0, 
                                customWidth,
                                customHeight);
                        }
                    }
                }
                else if ((string.Compare(GetFileExt(s), ".WAV", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".MP3", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".OGG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".WMA", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    if (cbAddFullFile.IsChecked == true)
                    {
                        var audioFile = new VFVEAudioSource(s, -1, -1, string.Empty, 0, tbSpeed.Value / 100.0);
                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                        }
                        else
                        {
                            VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0);
                        }
                    }
                    else
                    {
                        var audioFile = new VFVEAudioSource(s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), string.Empty, 0, tbSpeed.Value / 100.0);
                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                        }
                        else
                        {
                            VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0);
                        }
                    }
                }
                else
                {
                    if (cbAddFullFile.IsChecked == true)
                    {
                        var videoFile = new VFVEVideoSource(
                                s, -1, -1, VFVideoEditStretchMode.Letterbox, 0, tbSpeed.Value / 100.0);
                        var audioFile = new VFVEAudioSource(s, -1, -1, string.Empty, 0, tbSpeed.Value / 100.0);

                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddVideoFile(videoFile, -1, 0, customWidth, customHeight);
                            VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                        }
                        else
                        {
                            VideoEdit1.Input_AddVideoFile(videoFile, Convert.ToInt32(edInsertTime.Text), 0, customWidth, customHeight);
                            VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0);
                        }
                    }
                    else
                    {
                        var videoFile = new VFVEVideoSource(
                                s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), VFVideoEditStretchMode.Letterbox, 0, tbSpeed.Value / 100.0);
                        var audioFile = new VFVEAudioSource(s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), string.Empty, 0, tbSpeed.Value / 100.0);

                        if (cbInsertAfterPreviousFile.IsChecked == true)
                        {
                            VideoEdit1.Input_AddVideoFile(videoFile, -1, 0, customWidth, customHeight);
                            VideoEdit1.Input_AddAudioFile(audioFile, -1, 0);
                        }
                        else
                        {
                            VideoEdit1.Input_AddVideoFile(videoFile, Convert.ToInt32(edInsertTime.Text), 0, customWidth, customHeight);
                            VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0);
                        }
                    }
                }
            }
        }

        private void btClearList_Click(object sender, RoutedEventArgs e)
        {
            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
        }

        private void tbSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbSpeed != null)
            {
                lbSpeed.Content = Convert.ToInt32(tbSpeed.Value) + "%";
            }
        }

        private void tbSeeking_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoEdit1 != null)
            {
                VideoEdit1.Position_Set((int)tbSeeking.Value);
            }
        }

        private void tbChromaKeyContrastLow_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoEdit1 != null)
            {
                ConfigureChromaKey();
            }
        }

        private void tbChromaKeyContrastHigh_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoEdit1 != null)
            {
                ConfigureChromaKey();
            }
        }

        private void btChromaKeySelectBGImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edChromaKeyImage.Text = openFileDialog1.FileName;
            }
        }

        private void cbAFMotionHighlight_Checked(object sender, RoutedEventArgs e)
        {
            ConfigureObjectDetection();
        }

        private void cbAFMotionDetection_Checked(object sender, RoutedEventArgs e)
        {
            ConfigureObjectDetection();
        }

        private void VideoEdit1_OnObjectDetection(object sender, MotionDetectionExEventArgs e)
        {
            Dispatcher.BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
        }

        public delegate void AFMotionDelegate(float level);

        public void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void btMotDetUpdateSettings_Click(object sender, RoutedEventArgs e)
        {
            if (cbMotDetEnabled.IsChecked == true)
            {
                VideoEdit1.Motion_Detection = new MotionDetectionSettings
                                                  {
                                                      Enabled = this.cbMotDetEnabled.IsChecked == true,
                                                      Compare_Red = this.cbCompareRed.IsChecked == true,
                                                      Compare_Green = this.cbCompareGreen.IsChecked == true,
                                                      Compare_Blue = this.cbCompareBlue.IsChecked == true,
                                                      Compare_Greyscale = this.cbCompareGreyscale.IsChecked == true,
                                                      Highlight_Color = (VFMotionCHLColor)this.cbMotDetHLColor.SelectedIndex,
                                                      Highlight_Enabled = this.cbMotDetHLEnabled.IsChecked == true,
                                                      Highlight_Threshold = (int)this.tbMotDetHLThreshold.Value,
                                                      FrameInterval = Convert.ToInt32(this.edMotDetFrameInterval.Text),
                                                      Matrix_Height = Convert.ToInt32(this.edMotDetMatrixHeight.Text),
                                                      Matrix_Width = Convert.ToInt32(this.edMotDetMatrixWidth.Text),
                                                      DropFrames_Enabled = this.cbMotDetDropFramesEnabled.IsChecked == true,
                                                      DropFrames_Threshold = (int)this.tbMotDetDropFramesThreshold.Value
                                                  };
                VideoEdit1.MotionDetection_Update();
            }
            else
            {
                VideoEdit1.Motion_Detection = null;
            }
        }

        public delegate void MotionDelegate(MotionDetectionEventArgs e);

        public void MotionDelegateMethod(MotionDetectionEventArgs e)
        {
            string s = string.Empty;
            int k = 0;
            foreach (byte b in e.Matrix)
            {
                s += b.ToString("D3") + " ";

                if (k == VideoEdit1.Motion_Detection.Matrix_Width - 1)
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

        private void VideoEdit1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            Dispatcher.BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        private void cbZoomEnabled_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectZoom zoomEffect;
            var effect = VideoEdit1.Video_Effects_Get("Zoom");
            if (effect == null)
            {
                zoomEffect = new VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoomEnabled.IsChecked == true);
                VideoEdit1.Video_Effects_Add(zoomEffect);
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
            var effect = VideoEdit1.Video_Effects_Get("Pan");
            if (effect == null)
            {
                pan = new VFVideoEffectPan(true);
                VideoEdit1.Video_Effects_Add(pan);
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

        private void VideoEdit1_OnBarcodeDetected(object sender, BarcodeEventArgs e)
        {
            e.DetectorEnabled = false;

            Dispatcher.BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        private void btBarcodeReset_Click(object sender, RoutedEventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            VideoEdit1.Barcode_Reader_Enabled = true;
        }

        private void btSelectWMVProfileNetwork_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edNetworkStreamingWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        private void btRefreshClients_Click(object sender, RoutedEventArgs e)
        {
            lbNetworkClients.Items.Clear();

            for (int i = 0; i < VideoEdit1.Network_Streaming_WMV_Clients_GetCount(); i++)
            {
                string dns;
                string address;
                int port;
                VideoEdit1.Network_Streaming_WMV_Clients_GetInfo(i, out port, out address, out dns);

                string client = "ID: " + i + ", Port: " + port + ", Address: " + address + ", DNS: " + dns;
                lbNetworkClients.Items.Add(client);
            }
        }

        private void cbFadeInOut_Checked(object sender, RoutedEventArgs e)
        {
            if (rbFadeIn.IsChecked == true)
            {
                IVFVideoEffectFadeIn fadeIn;
                var effect = VideoEdit1.Video_Effects_Get("FadeIn");
                if (effect == null)
                {
                    fadeIn = new VFVideoEffectFadeIn(cbFadeInOut.IsChecked == true);
                    VideoEdit1.Video_Effects_Add(fadeIn);
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
                var effect = VideoEdit1.Video_Effects_Get("FadeOut");
                if (effect == null)
                {
                    fadeOut = new VFVideoEffectFadeOut(cbFadeInOut.IsChecked == true);
                    VideoEdit1.Video_Effects_Add(fadeOut);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Mode = VFVideoEditMode.Preview;
           
            VideoEdit1.Input_AddImageFile(@"c:\samples\autumn-06.jpg",25000, -1, VFVideoEditStretchMode.Stretch);

            VideoEdit1.Debug_Mode = true;
            VideoEdit1.Debug_Dir = @"VisioForge";

            VideoEdit1.Video_Renderer.Zoom_Ratio = 0;
            VideoEdit1.Video_Renderer.Zoom_ShiftX = 0;
            VideoEdit1.Video_Renderer.Zoom_ShiftY = 0;

            VideoEdit1.Video_Effects_Clear();
            VideoEdit1.Video_FrameRate = 0;
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

            VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;

            VideoEdit1.Video_Renderer.RotationAngle = 0;

            VideoEdit1.Video_Renderer.BackgroundColor = VideoEdit.ColorConv(((SolidColorBrush)pnVideoRendererBGColor.Fill).Color);
            VideoEdit1.Video_Renderer.Flip_Horizontal = false;
            VideoEdit1.Video_Renderer.Flip_Vertical = false; ;           

            VideoEdit1.Network_Streaming_Audio_Enabled = false;

            
            

            VideoEdit1.Video_Rotation = VFRotateMode.RotateNone;

            VideoEdit1.Start();

            //gdVideoEdit.Width /= 2;
            //VideoEdit1.Width = gdVideoEdit.Width;
            //VideoEdit1.Height = gdVideoEdit.Height;

            //VideoEdit1.RenderSize = new System.Windows.Size(gdVideoEdit.Width, gdVideoEdit.Height);

            //VideoEdit1.Video_Renderer_Update();
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

                controlLeft = gdVideoEdit.Margin.Left;
                controlTop = gdVideoEdit.Margin.Top;
                controlWidth = gdVideoEdit.Width;
                controlHeight = gdVideoEdit.Height;

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
                gdVideoEdit.Margin = new Thickness(0);
                gdVideoEdit.Width = Width + 10;
                gdVideoEdit.Height = Height + 10;

                VideoEdit1.Width = Width + 10;
                VideoEdit1.Height = Height + 10;

                VideoEdit1.RenderSize = new System.Windows.Size(Width + 10, Height + 10);

                VideoEdit1.Video_Renderer_Update();
            }
            else
            {
                // going normal screen
                fullScreen = false;

                // restoring control
                gdVideoEdit.Margin = new Thickness(controlLeft, controlTop, 0, 0);
                gdVideoEdit.Width = controlWidth;
                gdVideoEdit.Height = controlHeight;

                VideoEdit1.Width = controlWidth;
                VideoEdit1.Height = controlHeight;
                VideoEdit1.RenderSize = new System.Windows.Size(controlWidth, controlHeight);

                // restoring window
                Left = windowLeft;
                Top = windowTop;
                Width = windowWidth;
                Height = windowHeight;

                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
                Topmost = false;
                ResizeMode = ResizeMode.CanResize;

                VideoEdit1.Video_Renderer_Update();
            }
        }

        private void VideoEdit1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fullScreen)
            {
                btFullScreen_Click(null, null);
            }
        }

        #endregion

        private void label1291_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/240078-How-to-configure-IIS-Smooth-Streaming-in-SDK-demo-application");
            Process.Start(startInfo);
        }

        private void btAddInputFile2_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                string s = openFileDialog1.FileName;

                edSourceFileToCut.Text = s;

                string extNew = Path.GetExtension(s)?.ToLowerInvariant();
                string extOld = Path.GetExtension(edOutputFileCut.Text)?.ToLowerInvariant();
                if (extOld != null)
                {
                    edOutputFileCut.Text = edOutputFileCut.Text.Replace(extOld, extNew);
                }
            }
        }

        private void btAddInputFile3_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                string s = openFileDialog1.FileName;
                lbFiles2.Items.Add(s);

                edSourceFileToCut.Text = s;

                string extNew = Path.GetExtension(s)?.ToLowerInvariant();
                string extOld = Path.GetExtension(edOutputFileJoin.Text)?.ToLowerInvariant();
                if (extOld != null)
                {
                    edOutputFileJoin.Text = edOutputFileJoin.Text.Replace(extOld, extNew);
                }
            }
        }

        private void btClearList3_Click(object sender, RoutedEventArgs e)
        {
            lbFiles2.Items.Clear();
        }

        private void cbScreenFlipVertical_Checked(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;
            VideoEdit1.Video_Renderer_Update();
        }

        private void cbScreenFlipHorizontal_Checked(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            VideoEdit1.Video_Renderer_Update();
        }

        private void cbDirect2DRotate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = ((ComboBoxItem)e.AddedItems[0]).Content.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(name);
                VideoEdit1.Video_Renderer_Update();
            }
        }

        private void btZoomShiftUp_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_ShiftY = VideoEdit1.Video_Renderer.Zoom_ShiftY + 10;
        }

        private void btZoomShiftRight_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_ShiftX = VideoEdit1.Video_Renderer.Zoom_ShiftX + 10;
        }

        private void btZoomShiftLeft_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_ShiftX = VideoEdit1.Video_Renderer.Zoom_ShiftX - 10;
        }

        private void btZoomShiftDown_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_ShiftY = VideoEdit1.Video_Renderer.Zoom_ShiftY - 10;
        }

        private void btZoomOut_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_Ratio = VideoEdit1.Video_Renderer.Zoom_Ratio - 10;
        }

        private void btZoomIn_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Video_Renderer.Zoom_Ratio = VideoEdit1.Video_Renderer.Zoom_Ratio + 10;
        }

        private void pnVideoRendererBGColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnTextLogoGradColor1.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnVideoRendererBGColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
            }
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

        private void btAddTransition_Click(object sender, RoutedEventArgs e)
        {
            // get id
            int id = VideoEdit.Video_Transition_GetIDFromName(cbTransitionName.Text);

            // add transition
            VideoEdit1.Video_Transition_Add(Convert.ToInt32(edTransStartTime.Text), Convert.ToInt32(edTransStopTime.Text), id);

            // add to list
            lbTransitions.Items.Add(cbTransitionName.Text +
            "(Start: " + edTransStartTime.Text + ", stop: " + edTransStopTime.Text + ")");
        }

        private void cbAudioNormalize_Checked(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.IsChecked == true);
        }

        private void cbAudioAutoGain_Checked(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.IsChecked == true);
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

            VideoEdit1.Audio_Enhancer_InputGains(-1, gains);
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

            VideoEdit1.Audio_Enhancer_OutputGains(-1, gains);
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

            VideoEdit1.Audio_Enhancer_Timeshift(-1, (int)tbAudioTimeshift.Value);
        }

        private void VideoEdit1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.IsChecked == true)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
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
            // if (VideoEdit1.Debug_Mode)
            // {

            mmLog.Text += "(NOT ERROR) FFMPEG " + message + Environment.NewLine;

            // }
        }

        private void VideoEdit1_OnFFMPEGInfo(object sender, FFMPEGInfoEventArgs e)
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
                    //CRF
                    break;
                case 1:
                    //CRF (limited bitrate)
                    FFEXEEnableVideoCBR();
                    break;
                case 2:
                    //CBR
                    FFEXEEnableVideoCBR();
                    break;
                case 3:
                    //ABR
                    FFEXEEnableVideoABR();
                    break;
                case 4:
                    //Lossless
                    break;
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem");
            Process.Start(startInfo);
        }

        private void btSelectOutputCut_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutputFileCut.Text = saveFileDialog1.FileName;
            }
        }

        private void btStartCut_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.FastEdit_CutFile(
                edSourceFileToCut.Text,
                Convert.ToInt32(edStartTimeCut.Text),
                Convert.ToInt32(edStopTimeCut.Text),
                edOutputFileCut.Text);
        }

        private void btStopCut_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void btStopJoin_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void btStartJoin_Click(object sender, RoutedEventArgs e)
        {
            List<string> files = new List<string>();
            foreach (var item in lbFiles2.Items)
            {
                files.Add(item.ToString());
            }

            VideoEdit1.FastEdit_JoinFiles(
                files.ToArray(),
                edOutputFileCut.Text);
        }

        private void btSelectOutputJoin_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edOutputFileJoin.Text = saveFileDialog1.FileName;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (openFileDialog2.ShowDialog() == true)
            {
                imgTagCover.Source = new BitmapImage(new Uri(openFileDialog2.FileName));
                imgTagCover.Tag = openFileDialog2.FileName;
            }
        }

        private void btMuxStreamsSelectFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edMuxStreamsSourceFile.Text = openFileDialog1.FileName;
            }
        }

        private void btMuxStreamsAdd_Click(object sender, RoutedEventArgs e)
        {
            string prefix;
            if (cbMuxStreamsType.SelectedIndex == 0)
            {
                prefix = "v";
            }
            else if (cbMuxStreamsType.SelectedIndex == 1)
            {
                prefix = "a";
            }
            else
            {
                prefix = cbMuxStreamsType.Text;
            }

            lbMuxStreamsList.Items.Add(prefix + ": " + edMuxStreamsSourceFile.Text);
        }

        private void btMuxStreamsClear_Click(object sender, RoutedEventArgs e)
        {
            lbMuxStreamsList.Items.Clear();
        }

        private void btMuxStreamsSelectOutput_Click(object sender, RoutedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == true)
            {
                edMuxStreamsOutputFile.Text = saveFileDialog1.FileName;
            }
        }

        private void btStopMux_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void btStartMux_Click(object sender, RoutedEventArgs e)
        {
            var streams = new List<VFVEFFMPEGStream>();

            foreach (string item in lbMuxStreamsList.Items)
            {
                string prefix = item.Substring(0, 1);
                string filename = item.Substring(3);

                streams.Add(new VFVEFFMPEGStream
                {
                    Filename = filename,
                    ID = prefix
                });
            }

            VideoEdit1.FastEdit_MuxStreams(streams, cbMuxStreamsShortest.IsChecked == true, edMuxStreamsOutputFile.Text);
        }

        private void cbDebugMode_Click(object sender, RoutedEventArgs e)
        {
            VideoEdit1.Debug_Mode = cbDebugMode.IsChecked == true;
        }

        private void lbDownloadFFMPEG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_ffmpeg_exe_x86_x64.exe");
            Process.Start(startInfo);
        }

        private void lbDownloadFFMPEG_Copy3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge.com/support/577349-Network-streaming-to-YouTube");
            Process.Start(startInfo);
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

        private void btSubtitlesSelectFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edSubtitlesFilename.Text = openFileDialog1.FileName;
            }
        }

        private void tbGPULightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VideoEdit1 == null)
            {
                return;
            }

            IVFGPUVideoEffectBrightness intf;
            var effect = VideoEdit1.Video_Effects_GPU_Get("Brightness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBrightness(true, (int)tbGPULightness.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            if (VideoEdit1 == null)
            {
                return;
            }

            IVFGPUVideoEffectSaturation intf;
            var effect = VideoEdit1.Video_Effects_GPU_Get("Saturation");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectSaturation(true, (int)tbGPUSaturation.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            if (VideoEdit1 == null)
            {
                return;
            }

            IVFGPUVideoEffectContrast intf;
            var effect = VideoEdit1.Video_Effects_GPU_Get("Contrast");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectContrast(true, (int)tbGPUContrast.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            if (VideoEdit1 == null)
            {
                return;
            }

            IVFGPUVideoEffectDarkness intf;
            var effect = VideoEdit1.Video_Effects_GPU_Get("Darkness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDarkness(true, (int)tbGPUDarkness.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Grayscale");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectGrayscale(cbGPUGreyscale.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Invert");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectInvert(cbGPUInvert.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("NightVision");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectNightVision(cbGPUNightVision.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Pixelate");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectPixelate(cbGPUPixelate.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Denoise");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDenoise(cbGPUDenoise.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("DeinterlaceBlend");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Blur");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBlur(cbGPUBlur.IsChecked == true, 50);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("OldMovie");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectOldMovie(cbGPUOldMovie.IsChecked == true);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
    }
}

// ReSharper restore InconsistentNaming