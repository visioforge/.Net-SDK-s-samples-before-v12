// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable UnusedParameter.Local
namespace VideoEdit_CS_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.GPUVideoEffects;
    using VisioForge.Types.OutputFormat;
    using VisioForge.Types.VideoEffects;

    using VFM4AOutput = VisioForge.Types.OutputFormat.VFM4AOutput;

    /// <summary>
    /// Main demo form.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly List<AudioChannelMapperItem> audioChannelMapperItems = new List<AudioChannelMapperItem>();
        
        // Zoom
        private double zoom = 1.0;

        private int zoomShiftX;

        private int zoomShiftY;

        public Form1()
        {
            InitializeComponent();
        }

        private static string GetFileExt(string filename)
        {
            int k = filename.LastIndexOf('.');
            return filename.Substring(k, filename.Length - k);
        }

        private void btClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
        }

        private void btAddInputFile_Click(object sender, EventArgs e)
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
                    if (cbAddFullFile.Checked)
                    {
                        if (cbInsertAfterPreviousFile.Checked)
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
                        if (cbInsertAfterPreviousFile.Checked)
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
                else
                    if ((string.Compare(GetFileExt(s), ".WAV", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".MP3", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".OGG", StringComparison.OrdinalIgnoreCase) == 0) ||
                   (string.Compare(GetFileExt(s), ".WMA", StringComparison.OrdinalIgnoreCase) == 0))
                {
                    if (cbAddFullFile.Checked)
                    {
                        var audioFile = new VFVEAudioSource(s, -1, -1, string.Empty, 0, tbSpeed.Value / 100.0);
                        if (cbInsertAfterPreviousFile.Checked)
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
                        if (cbInsertAfterPreviousFile.Checked)
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
                    if (cbAddFullFile.Checked)
                    {
                        var videoFile = new VFVEVideoSource(
                                s, -1, -1, VFVideoEditStretchMode.Letterbox, 0, tbSpeed.Value / 100.0);
                        var audioFile = new VFVEAudioSource(s, -1, -1, string.Empty, 0, tbSpeed.Value / 100.0);

                        if (cbInsertAfterPreviousFile.Checked)
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

                        if (cbInsertAfterPreviousFile.Checked)
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

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = SaveDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoEdit1.SDK_Version + ", " + VideoEdit1.SDK_State + ")";

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputFileCut.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            edOutputFileJoin.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            cbMode.SelectedIndex = 1;
            cbFrameRate.SelectedIndex = 0;
            cbChannels.SelectedIndex = 0;
            cbChannels2.SelectedIndex = 0;
            cbSampleRate.SelectedIndex = 0;
            cbSampleRate2.SelectedIndex = 0;
            cbBPS.SelectedIndex = 0;
            cbBPS2.SelectedIndex = 0;
            cbOutputVideoFormat.SelectedIndex = 0;
            cbWMVAudioMode.SelectedIndex = 0;
            cbWMVVideoMode.SelectedIndex = 0;
            cbWMVTVFormat.SelectedIndex = 0;
            cbOGGAverage.SelectedIndex = 6;
            cbOGGMaximum.SelectedIndex = 8;
            cbOGGMinimum.SelectedIndex = 5;
            cbLameCBRBitrate.SelectedIndex = 10;
            cbLameVBRMin.SelectedIndex = 8;
            cbLameVBRMax.SelectedIndex = 10;
            cbLameSampleRate.SelectedIndex = 0;
            cbTextLogoAlign.SelectedIndex = 0;
            cbTextLogoAntialiasing.SelectedIndex = 0;
            cbTextLogoDrawMode.SelectedIndex = 0;
            cbTextLogoEffectrMode.SelectedIndex = 0;
            cbTextLogoGradMode.SelectedIndex = 0;
            cbTextLogoShapeType.SelectedIndex = 0;
            cbMotDetHLColor.SelectedIndex = 1;
            cbDVChannels.SelectedIndex = 1;
            cbDVSampleRate.SelectedIndex = 1;
            cbRotate.SelectedIndex = 0;
            cbBarcodeType.SelectedIndex = 0;
            cbNetworkStreamingMode.SelectedIndex = 0;
            cbDirect2DRotate.SelectedIndex = 0;
            cbSpeexBitrateControl.SelectedIndex = 2;
            cbSpeexMode.SelectedIndex = 0;
            cbMuxStreamsType.SelectedIndex = 0;

            cbFLACBlockSize.SelectedIndex = 4;

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
            cbH264RateControl.SelectedIndex = 0;
            cbH264MBEncoding.SelectedIndex = 0;
            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 12;
            cbH264PictureType.SelectedIndex = 0;
            cbH264TargetUsage.SelectedIndex = 0;

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
            cbDecklinkOutputSingleField.SelectedIndex = 0;

            cbWebMVideoEndUsageMode.SelectedIndex = 0;
            edWebMVideoThreadCount.Text = Environment.ProcessorCount.ToString(CultureInfo.InvariantCulture);
            cbWebMVideoEncoder.SelectedIndex = 0;
            cbWebMVideoKeyframeMode.SelectedIndex = 0;
            cbWebMVideoQualityMode.SelectedIndex = 0;

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

            for (int i = 0; i < VideoEdit1.DirectShow_Filters().Count; i++)
            {
                cbCustomDSFilterV.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomDSFilterA.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomMuxer.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
                cbCustomFilewriter.Items.Add(VideoEdit1.DirectShow_Filters()[i]);
            }

            cbVideoCodec.SelectedIndex = 0;
            cbAudioCodec.SelectedIndex = 0;
            cbAudioCodecs2.SelectedIndex = 0;
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

            for (int i = 0; i < names.Count; i++)
            {
                cbWMVInternalProfile8.Items.Add(names[i]);
            }

            cbWMVInternalProfile8.SelectedIndex = 0;

            cbCustomVideoCodec_SelectedIndexChanged(null, null);
            cbCustomAudioCodec_SelectedIndexChanged(null, null);
            cbCustomMuxer_SelectedIndexChanged(null, null);
            cbCustomDSFilterA_SelectedIndexChanged(null, null);
            cbCustomDSFilterV_SelectedIndexChanged(null, null);
            cbCustomFilewriter_SelectedIndexChanged(null, null);

            cbVideoCodec_SelectedIndexChanged(null, null);
            cbAudioCodec_SelectedIndexChanged(null, null);
            cbAudioCodec2_SelectedIndexChanged(null, null);

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

            if (cbAudioCodecs2.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodecs2.SelectedIndex = cbAudioCodecs2.Items.IndexOf("PCM");
            }

            if (cbVideoCodec.Items.IndexOf("MJPEG Compressor") != -1)
            {
                cbVideoCodec.SelectedIndex = cbVideoCodec.Items.IndexOf("MJPEG Compressor");
            }

            // ReSharper disable once CoVariantArrayConversion
            cbAudEqualizerPreset.Items.AddRange(VideoEdit1.Audio_Effects_Equalizer_Presets().ToArray());
            cbAudEqualizerPreset.SelectedIndex = 0;

            if (!(rbVMR9.Enabled && rbEVR.Enabled))
            {
                rbVR.Checked = true;
            }
            else if (rbEVR.Enabled)
            {
                rbEVR.Checked = true;
            }
        }

        private void FillGIFOutput(ref VFAnimatedGIFOutput gifOutput)
        {
            gifOutput.FrameRate = Convert.ToDouble(edGIFFrameRate.Text);
            gifOutput.ForcedVideoWidth = Convert.ToInt32(edGIFWidth.Text);
            gifOutput.ForcedVideoHeight = Convert.ToInt32(edGIFHeight.Text);
        }

        private void FillLAMESettings(ref VFMP3Output lameOutput)
        {
            lameOutput.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text);
            lameOutput.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text);
            lameOutput.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text);
            lameOutput.SampleRate = Convert.ToInt32(cbLameSampleRate.Text);
            lameOutput.VBR_Quality = tbLameVBRQuality.Value;
            lameOutput.EncodingQuality = tbLameEncodingQuality.Value;

            if (rbLameStandardStereo.Checked)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.StandardStereo;
            }
            else if (rbLameJointStereo.Checked)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.JointStereo;
            }
            else if (rbLameDualChannels.Checked)
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.DualStereo;
            }
            else
            {
                lameOutput.ChannelsMode = VFLameChannelsMode.Mono;
            }

            lameOutput.VBR_Mode = rbLameVBR.Checked;

            // other
            lameOutput.Copyright = cbLameCopyright.Checked;
            lameOutput.Original = cbLameOriginal.Checked;
            lameOutput.CRCProtected = cbLameCRCProtected.Checked;
            lameOutput.ForceMono = cbLameForceMono.Checked;
            lameOutput.StrictlyEnforceVBRMinBitrate = cbLameStrictlyEnforceVBRMinBitrate.Checked;
            lameOutput.VoiceEncodingMode = cbLameVoiceEncodingMode.Checked;
            lameOutput.KeepAllFrequencies = cbLameKeepAllFrequences.Checked;
            lameOutput.StrictISOCompliance = cbLameStrictISOCompilance.Checked;
            lameOutput.DisableShortBlocks = cbLameDisableShortBlocks.Checked;
            lameOutput.EnableXingVBRTag = cbLameEnableXingVBRTag.Checked;
            lameOutput.ModeFixed = cbLameModeFixed.Checked;
        }

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

                wmvOutput.Custom_Video_StreamPresent = cbWMVVideoEnabled.Checked;

                wmvOutput.Custom_Profile_Name = "MyProfile1";
            }
        }

        /// <summary>
        /// Fills FFMPEG EXE settings.
        /// </summary>
        /// <param name="ffmpegOutput">
        /// FFMPEG settings.
        /// </param>
        private void FillFFMPEGEXESettings(ref VFFFMPEGEXEOutput ffmpegOutput)
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
        
        private void btStart_Click(object sender, EventArgs e)
        {
            zoom = 1.0;
            zoomShiftX = 0;
            zoomShiftY = 0;

            mmLog.Clear();

            VideoEdit1.Debug_Mode = cbDebugMode.Checked;

            VideoEdit1.Mode = (VFVideoEditMode)cbMode.SelectedIndex;

            VideoEdit1.Video_Effects_Clear();
            VideoEdit1.Video_Resize = cbResize.Checked;

            if (VideoEdit1.Video_Resize)
            {
                VideoEdit1.Video_Resize_Width = Convert.ToInt32(edWidth.Text);
                VideoEdit1.Video_Resize_Height = Convert.ToInt32(edHeight.Text);
            }

            if (cbCrop.Checked)
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

            if (cbSubtitlesEnabled.Checked)
            {
                VideoEdit1.Video_Subtitles = new SubtitlesSettings(edSubtitlesFilename.Text);
            }
            else
            {
                VideoEdit1.Video_Subtitles = null;
            }

            VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text, CultureInfo.InvariantCulture);

            ConfigureVideoRenderer();

            // network streaming
            VideoEdit1.Network_Streaming_Enabled = cbNetworkStreaming.Checked;

            if (VideoEdit1.Network_Streaming_Enabled)
            {
                switch (cbNetworkStreamingMode.SelectedIndex)
                {
                    case 0:
                        {
                            VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.WMV;

                            if (rbNetworkStreamingUseMainWMVSettings.Checked)
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

                            if (rbNetworkUDPFFMPEG.Checked)
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

                            if (rbNetworkUDPFFMPEG.Checked)
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
                            if (rbNetworkSSSoftware.Checked)
                            {
                                VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_H264_AAC_SW;
                            }
                            else
                            {
                                VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_FFMPEG_EXE;

                                var ffmpegOutput = new VFFFMPEGEXEOutput();

                                if (rbNetworkSSFFMPEGDefault.Checked)
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

                VideoEdit1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.Checked;
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
                    outputFormat = VFVideoEditOutputFormat.WebM;
                    break;
                case 13:
                    outputFormat = VFVideoEditOutputFormat.FFMPEG_DLL;
                    break;
                case 14:
                    outputFormat = VFVideoEditOutputFormat.FFMPEG_EXE;
                    break;
                case 15:
                    outputFormat = VFVideoEditOutputFormat.MP4;
                    break;
                case 16:
                    outputFormat = VFVideoEditOutputFormat.AnimatedGIF;
                    break;
                case 17:
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

                if (cbUseLameInAVI.Checked)
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

                if (cbUseLameInAVI.Checked)
                {
                    mkvOutput.Audio_UseMP3Encoder = true;
                    var mp3Output = new VFMP3Output();
                    FillLAMESettings(ref mp3Output);
                    mkvOutput.MP3 = mp3Output;
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

                if (rbDVPAL.Checked)
                {
                    dvOutput.Video_Format = VFDVVideoFormat.PAL;
                }
                else
                {
                    dvOutput.Video_Format = VFDVVideoFormat.NTSC;
                }

                dvOutput.Type2 = rbDVType2.Checked;

                VideoEdit1.Output_Format = dvOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.Custom)
            {
                var customOutput = new VFCustomOutput();

                if (rbCustomUseVideoCodecsCat.Checked)
                {
                    customOutput.Video_Codec = cbCustomVideoCodec.Text;
                    customOutput.Video_Codec_UseFiltersCategory = false;
                }
                else
                {
                    customOutput.Video_Codec = cbCustomDSFilterV.Text;
                    customOutput.Video_Codec_UseFiltersCategory = true;
                }

                if (rbCustomUseAudioCodecsCat.Checked)
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
                customOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.Checked;
                customOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text;
                customOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.Checked;

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
            else if (outputFormat == VFVideoEditOutputFormat.OggVorbis)
            {
                var oggVorbisOutput = new VFOGGVorbisOutput
                                          {
                                              Quality = Convert.ToInt32(this.edOGGQuality.Text),
                                              MinBitRate = Convert.ToInt32(this.cbOGGMinimum.Text),
                                              MaxBitRate = Convert.ToInt32(this.cbOGGMaximum.Text),
                                              AvgBitRate = Convert.ToInt32(this.cbOGGAverage.Text)
                                          };

                if (rbOGGQuality.Checked)
                {
                    oggVorbisOutput.Mode = VFVorbisMode.Quality;
                }
                else
                {
                    oggVorbisOutput.Mode = VFVorbisMode.Bitrate;
                }

                VideoEdit1.Output_Format = oggVorbisOutput;
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
                                         Audio_Quality = this.tbWebMAudioQuality.Value,
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
                                         Video_AutoAltRef = this.cbWebMVideoAutoAltRef.Checked,
                                         Video_ErrorResilient = this.cbWebMVideoErrorResilent.Checked,
                                         Video_SpatialResampling_Allowed = this.cbWebMVideoSpatialResamplingAllowed.Checked,
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
            else if (outputFormat == VFVideoEditOutputFormat.FLAC)
            {
                var flacOutput = new VFFLACOutput
                                     {
                                         Level = this.tbFLACLevel.Value,
                                         BlockSize = Convert.ToInt32(this.cbFLACBlockSize.Text),
                                         AdaptiveMidSideCoding = this.cbFLACAdaptiveMidSideCoding.Checked,
                                         ExhaustiveModelSearch = this.cbFLACExhaustiveModelSearch.Checked,
                                         LPCOrder = this.tbFLACLPCOrder.Value,
                                         MidSideCoding = this.cbFLACMidSideCoding.Checked,
                                         RiceMin = Convert.ToInt32(this.edFLACRiceMin.Text),
                                         RiceMax = Convert.ToInt32(this.edFLACRiceMax.Text)
                                     };

                VideoEdit1.Output_Format = flacOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.Speex)
            {
                var speexOutput = new VFSpeexOutput
                                      {
                                          BitRate = this.tbSpeexBitrate.Value,
                                          BitrateControl = (SpeexBitrateControl)this.cbSpeexBitrateControl.SelectedIndex,
                                          Mode = (SpeexEncodeMode)this.cbSpeexMode.SelectedIndex,
                                          MaxBitRate = this.tbSpeexMaxBitrate.Value,
                                          Complexity = this.tbSpeexComplexity.Value,
                                          Quality = this.tbSpeexQuality.Value,
                                          UseAGC = this.cbSpeexAGC.Checked,
                                          UseDTX = this.cbSpeexDTX.Checked,
                                          UseDenoise = this.cbSpeexDenoise.Checked,
                                          UseVAD = this.cbSpeexVAD.Checked
                                      };

                VideoEdit1.Output_Format = speexOutput;
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
                ffmpegDLLOutput.Video_Interlace = cbFFVideoInterlace.Checked;

                VideoEdit1.Output_Format = ffmpegDLLOutput;
            }
            else if (outputFormat == VFVideoEditOutputFormat.FFMPEG_EXE)
            {
                var ffmpegOutput = new VFFFMPEGEXEOutput();

                FillFFMPEGEXESettings(ref ffmpegOutput);
                ffmpegOutput.UsePipe = true;

                VideoEdit1.Output_Format = ffmpegOutput;
            }
            else if ((outputFormat == VFVideoEditOutputFormat.MP4) ||
            ((outputFormat == VFVideoEditOutputFormat.Encrypted) && rbEncryptedH264SW.Checked) ||
                    (VideoEdit1.Network_Streaming_Enabled && (VideoEdit1.Network_Streaming_Format == VFNetworkStreamingFormat.RTSP_H264_AAC_SW)))
            {
                int tmp;

                var mp4Output = new VFMP4Output();

                // Main settings
                if (rbMP4Legacy.Checked)
                {
                    mp4Output.MP4Mode = VFMP4Mode.v8;
                }
                else if (rbMP4Modern.Checked)
                {
                    mp4Output.MP4Mode = VFMP4Mode.v10;
                }
                else
                {
                    mp4Output.MP4Mode = VFMP4Mode.NVENC;
                }

                if (mp4Output.MP4Mode != VFMP4Mode.NVENC)
                {
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
                    mp4Output.Video_H264.GOP = cbH264GOP.Checked;
                    mp4Output.Video_H264.BitrateAuto = cbH264AutoBitrate.Checked;

                    int.TryParse(edH264IDR.Text, out tmp);
                    mp4Output.Video_H264.IDR_Period = tmp;

                    int.TryParse(edH264P.Text, out tmp);
                    mp4Output.Video_H264.P_Period = tmp;

                    int.TryParse(edH264Bitrate.Text, out tmp);
                    mp4Output.Video_H264.Bitrate = tmp;

                    mp4Output.Video_H264.MaxBitrate = tmp * 2;
                    mp4Output.Video_H264.MinBitrate = tmp / 2;
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
                if (rbMP4AAC.Checked)
                {
                    mp4Output.AudioFormat = VFMP4AudioEncoder.AAC;

                    int.TryParse(cbAACBitrate.Text, out tmp);
                    mp4Output.Audio_AAC.Bitrate = tmp;

                    mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACVersion.SelectedIndex;
                    mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
                    mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObjectType.SelectedIndex + 1);
                }
                else
                {
                    mp4Output.AudioFormat = VFMP4AudioEncoder.MP3_LAME;

                    var lameOutput = new VFMP3Output();
                    FillLAMESettings(ref lameOutput);

                    mp4Output.Audio_LAME = lameOutput;
                }

                // encryption
                if (outputFormat == VFVideoEditOutputFormat.Encrypted)
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

                VideoEdit1.Output_Format = mp4Output;
            }
            else if (outputFormat == VFVideoEditOutputFormat.AnimatedGIF)
            {
                var gifOutput = new VFAnimatedGIFOutput();
                FillGIFOutput(ref gifOutput);
                VideoEdit1.Output_Format = gifOutput;
            }

            VideoEdit1.Audio_Preview_Enabled = true;

            // Audio enhancement
            VideoEdit1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.Checked;
            if (VideoEdit1.Audio_Enhancer_Enabled)
            {
                VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked);
                VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked);

                ApplyAudioInputGains();
                ApplyAudioOutputGains();

                VideoEdit1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value);
            }

            // Audio channels mapping
            if (cbAudioChannelMapperEnabled.Checked)
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

            // Audio effects
            VideoEdit1.Audio_Effects_Clear(-1);
            VideoEdit1.Audio_Effects_Enabled = cbAudioEffectsEnabled.Checked;
            if (VideoEdit1.Audio_Effects_Enabled)
            {
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.Checked, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1);
                VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1);

                tbAudAmplifyAmp_Scroll(sender, e);
                tbAudDynAmp_Scroll(sender, e);
                tbAudAttack_Scroll(sender, e);
                tbAudRelease_Scroll(sender, e);
                tbAud3DSound_Scroll(sender, e);
                tbAudTrueBass_Scroll(sender, e);

                tbAudEq0_Scroll(sender, e);
                tbAudEq1_Scroll(sender, e);
                tbAudEq2_Scroll(sender, e);
                tbAudEq3_Scroll(sender, e);
                tbAudEq4_Scroll(sender, e);
                tbAudEq5_Scroll(sender, e);
                tbAudEq6_Scroll(sender, e);
                tbAudEq7_Scroll(sender, e);
                tbAudEq8_Scroll(sender, e);
                tbAudEq9_Scroll(sender, e);
            }

            VideoEdit1.Video_Effects_Enabled = cbEffects.Checked;
            VideoEdit1.Video_Effects_Clear();

            // Object detection
            ConfigureObjectDetection();

            // Virtual camera output
            VideoEdit1.Virtual_Camera_Output_Enabled = cbVirtualCamera.Checked;

            // Deinterlace
            if (rbDeintBlendEnabled.Checked)
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
                    // ReSharper disable once TryCastAlwaysSucceeds
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
                var effect = VideoEdit1.Video_Effects_Get("DeinterlaceCAVT");
                if (effect == null)
                {
                    cavt = new VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.Checked, Convert.ToInt32(edDeintCAVTThreshold.Text));
                    VideoEdit1.Video_Effects_Add(cavt);
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

            // Denoise
            if (cbDenoise.Checked)
            {
                VideoEdit1.Video_Effects_Enabled = true;
                if (rbDenoiseCAST.Checked)
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
                        VideoEdit1.Video_Effects_Add(mosquito);
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

            // Decklink output
            ConfigureDecklinkOutput();

            // Chroma key
            ConfigureChromaKey();

            // Barcode detection
            VideoEdit1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.Checked;
            VideoEdit1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;

            // motion detection
            if (cbMotDetEnabled.Checked)
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
            if (cbTagEnabled.Checked)
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
                
                if (imgTagCover.Image != null)
                {
                    tags.Pictures = new[] { new Bitmap(imgTagCover.Image) };
                }

                VideoEdit1.Tags = tags;
            }

            VideoEdit1.Start();

            edNetworkURL.Text = VideoEdit1.Network_Streaming_URL;

            lbTransitions.Items.Clear();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoEdit1.Stop();

            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();
            ProgressBar1.Value = 0;
        }

        private void btAudioSettings2_Click(object sender, EventArgs e)
        {
            string name = cbAudioCodecs2.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomAudioCodecSettings_Click(object sender, EventArgs e)
        {
            string name = cbCustomAudioCodec.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersASettings_Click(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterA.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomDSFiltersVSettings_Click(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterV.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btCustomMuxerSettings_Click(object sender, EventArgs e)
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

        private void btCustomVideoCodecSettings_Click(object sender, EventArgs e)
        {
            string name = cbCustomVideoCodec.Text;

            if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (FontDialog1.ShowDialog() == DialogResult.OK)
            {
                btTextLogoUpdateParams_Click(null, null);
            }
        }

        // ReSharper disable once UnusedParameter.Local
        private void cbAudioCodec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs2.Text;
            btAudioSettings2.Enabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                        || VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodec.Text;
            btAudioSettings.Enabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                       || VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomAudioCodec.Text;
            btCustomAudioCodecSettings.Enabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                                  || VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterA_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterA.Text;
            btCustomDSFiltersASettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default)
                                                  || VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomVideoCodec.Text;
            btCustomVideoCodecSettings.Enabled = VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                                  || VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomMuxer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomMuxer.Text;
            btCustomMuxerSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default)
                                             || VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbCustomDSFilterV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomDSFilterV.Text;
            btCustomDSFiltersVSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default)
                                                  || VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbGreyscale_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectGrayscale grayscale;
            var effect = VideoEdit1.Video_Effects_Get("Grayscale");
            if (effect == null)
            {
                grayscale = new VFVideoEffectGrayscale(cbGreyscale.Checked);
                VideoEdit1.Video_Effects_Add(grayscale);
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

        private void cbInvert_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectInvert invert;
            var effect = VideoEdit1.Video_Effects_Get("Invert");
            if (effect == null)
            {
                invert = new VFVideoEffectInvert(cbInvert.Checked);
                VideoEdit1.Video_Effects_Add(invert);
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

        private void cbTextLogo_CheckedChanged(object sender, EventArgs e)
        {
            btTextLogoUpdateParams_Click(null, null);
        }

        private void cbVideoCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbVideoCodec.Text;

            btVideoSettings.Enabled = VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                       || VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void cbWMVAudioCodec_SelectedIndexChanged(object sender, EventArgs e)
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
                List<string> codecs = VideoEdit1.WMV_Custom_Audio_Formats(cbWMVAudioCodec.Text, mode);
                for (int i = 0; i < codecs.Count; i++)
                {
                    cbWMVAudioFormat.Items.Add(codecs[i]);
                }
            }
        }

        private void cbWMVAudioMode_SelectedIndexChanged(object sender, EventArgs e)
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
            for (int i = 0; i < VideoEdit1.WMV_Custom_Audio_Codecs(mode).Count; i++)
            {
                cbWMVAudioCodec.Items.Add(VideoEdit1.WMV_Custom_Audio_Codecs(mode)[i]);
            }

            cbWMVAudioCodec_SelectedIndexChanged(null, null);
        }

        private void cbWMVVideoMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            VFWMVStreamMode mode = VFWMVStreamMode.CBR;
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
            for (int i = 0; i < VideoEdit1.WMV_Custom_Video_Codecs(mode).Count; i++)
            {
                cbWMVVideoCodec.Items.Add(VideoEdit1.WMV_Custom_Video_Codecs(mode)[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoEdit1.Stop();
        }

        private void tbDarkness_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectDarkness darkness;
            var effect = VideoEdit1.Video_Effects_Get("Darkness");
            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, tbDarkness.Value);
                VideoEdit1.Video_Effects_Add(darkness);
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
            var effect = VideoEdit1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, tbLightness.Value);
                VideoEdit1.Video_Effects_Add(lightness);
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
            var effect = VideoEdit1.Video_Effects_Get("Saturation");
            if (effect == null)
            {
                saturation = new VFVideoEffectSaturation(tbSaturation.Value);
                VideoEdit1.Video_Effects_Add(saturation);
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

        private void tbTextLogoTransp_Scroll(object sender, EventArgs e)
        {
            btTextLogoUpdateParams_Click(null, null);
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
            var effect = VideoEdit1.Video_Effects_Get("TextLogo");
            if (effect == null)
            {
                textLogo = new VFVideoEffectTextLogo(cbTextLogo.Checked);
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

            textLogo.Enabled = this.cbTextLogo.Checked;
            textLogo.Text = edTextLogo.Text;
            textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text);
            textLogo.Top = Convert.ToInt32(edTextLogoTop.Text);
            textLogo.Font = this.FontDialog1.Font;
            textLogo.FontColor = this.FontDialog1.Color;

            textLogo.BackgroundTransparent = cbTextLogoTranspBG.Checked;
            textLogo.BackgroundColor = pnTextLogoBGColor.BackColor;
            textLogo.StringFormat = formatFlags;
            textLogo.Antialiasing = (TextRenderingHint)cbTextLogoAntialiasing.SelectedIndex;
            textLogo.DrawQuality = (InterpolationMode)cbTextLogoDrawMode.SelectedIndex;
            textLogo.Enabled = cbTextLogo.Checked;

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

            if (cbTextLogoDateTime.Checked)
            {
                textLogo.Mode = TextLogoMode.DateTime;
                textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss";
            }
            else
            {
                textLogo.Mode = TextLogoMode.Text;
            }

            textLogo.Update();
        }

        private void cbImageLogo_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectImageLogo imageLogo;
            var effect = VideoEdit1.Video_Effects_Get("ImageLogo");
            if (effect == null)
            {
                imageLogo = new VFVideoEffectImageLogo(cbImageLogo.Checked);
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

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.edImageLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void cbGraphicLogoShowAlways_CheckedChanged(object sender, EventArgs e)
        {
            this.edImageLogoStartTime.Enabled = !this.cbImageLogoShowAlways.Checked;
            this.edImageLogoStopTime.Enabled = !this.cbImageLogoShowAlways.Checked;
            lbGraphicLogoStartTime.Enabled = !this.cbImageLogoShowAlways.Checked;
            lbGraphicLogoStopTime.Enabled = !this.cbImageLogoShowAlways.Checked;

            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void tbGraphicLogoTransp_Scroll(object sender, EventArgs e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
        }

        private void cbGraphicLogoUseColorKey_CheckedChanged(object sender, EventArgs e)
        {
            this.cbImageLogo_CheckedChanged(null, null);
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

        private void pnGraphicLogoColorKey_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.pnImageLogoColorKey.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pnImageLogoColorKey.BackColor = colorDialog1.Color;
            }
        }

        private void cbUseSpecialFilewriter_CheckedChanged(object sender, EventArgs e)
        {
            cbCustomFilewriter.Enabled = cbUseSpecialFilewriter.Checked;
            btCustomFilewriterSettings.Enabled = cbUseSpecialFilewriter.Checked;
        }

        private void cbCustomFilewriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbCustomFilewriter.Text;
            btCustomFilewriterSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btCustomFilewriterSettings_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void btVideoSettings_Click(object sender, EventArgs e)
        {
            string name = cbVideoCodec.Text;

            if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Video_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btAudioSettings_Click(object sender, EventArgs e)
        {
            string name = cbAudioCodec.Text;

            if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btSelectWM_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                edWMVProfile.Text = openFileDialog3.FileName;
            }
        }

        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            IVFVideoEffectContrast contrast;
            var effect = VideoEdit1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, tbContrast.Value);
                VideoEdit1.Video_Effects_Add(contrast);
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

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                string name = cbFilters.Text;
                btFilterSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                    VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterAdd_Click(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                VideoEdit1.Video_Filters_Add(new VFCustomProcessingFilter(cbFilters.Text));
                lbFilters.Items.Add(cbFilters.Text);
            }
        }

        private void btFilterSettings_Click(object sender, EventArgs e)
        {
            string name = cbFilters.Text;

            if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
                if (VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void lbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.Text;
                btFilterSettings2.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                                            VideoEdit.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterSettings2_Click(object sender, EventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.Text;

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

        private void btFilterDeleteAll_Click(object sender, EventArgs e)
        {
            lbFilters.Items.Clear();
            VideoEdit1.Video_Filters_Clear();
        }

        private void cbAudAmplifyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked);
        }

        private void tbAudAmplifyAmp_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, false);
        }

        private void cbAudEqualizerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked);
        }

        private void tbAudEq0_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, tbAudEq9.Value);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(sender, e);
        }

        private void btAudEqRefresh_Click(object sender, EventArgs e)
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

        private void cbAudDynamicAmplifyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.Checked);
        }

        private void tbAudDynAmp_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void tbAudAttack_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void tbAudRelease_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value);
        }

        private void cbAudSound3DEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked);
        }

        private void tbAud3DSound_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Sound3D(-1, 3, tbAud3DSound.Value);
        }

        private void cbAudTrueBassEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.Checked);
        }

        private void tbAudTrueBass_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Effects_TrueBass(-1, 4, 200, false, tbAudTrueBass.Value);
        }

        private void rbVR_CheckedChanged(object sender, EventArgs e)
        {
            cbScreenFlipVertical.Enabled = rbVMR9.Checked || rbDirect2D.Checked;
            cbScreenFlipHorizontal.Enabled = rbVMR9.Checked || rbDirect2D.Checked;

            ConfigureVideoRenderer();
        }

        private void cbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStretch.Checked)
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoEdit1.Video_Renderer_Update();
        }

        private void cbScreenFlipVertical_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked;
            VideoEdit1.Video_Renderer_Update();
        }

        private void cbScreenFlipHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked;
            VideoEdit1.Video_Renderer_Update();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            lbSpeed.Text = Convert.ToInt32(tbSpeed.Value) + "%";
        }

        private void tbSeeking_Scroll(object sender, EventArgs e)
        {
            VideoEdit1.Position_Set(tbSeeking.Value);
        }

        private void cbAudioCodecs2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs2.Text;
            btAudioSettings2.Enabled = VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default)
                                       || VideoEdit.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void VideoEdit1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + "(" + e.CallSite + ")" + Environment.NewLine;
        }

        private void VideoEdit1_OnStart(object sender, EventArgs e)
        {
            tbSeeking.Maximum = VideoEdit1.Duration();
        }

        private void VideoEdit1_OnProgress(object sender, ProgressEventArgs e)
        {
            ProgressBar1.Value = e.Progress;

            // Application.DoEvents();
        }

        private void VideoEdit1_OnStop(object sender, EventArgs e)
        {
            ProgressBar1.Value = 0;
            MessageBox.Show("Complete", string.Empty, MessageBoxButtons.OK);

            lbFiles.Items.Clear();
            VideoEdit1.Input_Clear_List();

            VideoEdit1.Video_Transition_Clear();
            lbTransitions.Items.Clear();
        }

        private void ConfigureObjectDetection()
        {
            if (cbAFMotionDetection.Checked)
            {
                VideoEdit1.Motion_DetectionEx = new MotionDetectionExSettings();
                if (cbAFMotionHighlight.Checked)
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

        private void cbAFMotionDetection_CheckedChanged(object sender, EventArgs e)
        {
            this.ConfigureObjectDetection();
        }

        private void cbAFMotionHighlight_CheckedChanged(object sender, EventArgs e)
        {
            this.ConfigureObjectDetection();
        }

        private void tbChromaKeyContrastLow_Scroll(object sender, EventArgs e)
        {
            ConfigureChromaKey();
        }

        private void tbChromaKeyContrastHigh_Scroll(object sender, EventArgs e)
        {
            ConfigureChromaKey();
        }

        private void btChromaKeySelectBGImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edChromaKeyImage.Text = openFileDialog1.FileName;
            }
        }

        private void btMotDetUpdateSettings_Click(object sender, EventArgs e)
        {
            if (cbMotDetEnabled.Checked)
            {
                VideoEdit1.Motion_Detection = new MotionDetectionSettings
                                                  {
                                                      Enabled = this.cbMotDetEnabled.Checked,
                                                      Compare_Red = this.cbCompareRed.Checked,
                                                      Compare_Green = this.cbCompareGreen.Checked,
                                                      Compare_Blue = this.cbCompareBlue.Checked,
                                                      Compare_Greyscale = this.cbCompareGreyscale.Checked,
                                                      Highlight_Color = (VFMotionCHLColor)this.cbMotDetHLColor.SelectedIndex,
                                                      Highlight_Enabled = this.cbMotDetHLEnabled.Checked,
                                                      Highlight_Threshold = this.tbMotDetHLThreshold.Value,
                                                      FrameInterval = Convert.ToInt32(this.edMotDetFrameInterval.Text),
                                                      Matrix_Height = Convert.ToInt32(this.edMotDetMatrixHeight.Text),
                                                      Matrix_Width = Convert.ToInt32(this.edMotDetMatrixWidth.Text),
                                                      DropFrames_Enabled = this.cbMotDetDropFramesEnabled.Checked,
                                                      DropFrames_Threshold = this.tbMotDetDropFramesThreshold.Value
                                                  };
                VideoEdit1.MotionDetection_Update();
            }
            else
            {
                VideoEdit1.Motion_Detection = null;
            }
        }

        private delegate void MotionDelegate(MotionDetectionEventArgs e);

        private void MotionDelegateMethod(MotionDetectionEventArgs e)
        {
            string s = string.Empty;
            foreach (byte b in e.Matrix)
            {
                s += b + " ";
            }

            mmMotDetMatrix.Text = s.Trim();
            pbMotionLevel.Value = e.Level;
        }

        private void VideoEdit1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        private delegate void AFMotionDelegate(float level);

        private void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void VideoEdit1_OnObjectDetection(object sender, MotionDetectionExEventArgs e)
        {
            BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            //string[] files = { "c:\\samples\\!video.avi", "c:\\samples\\!video2.wmv" };
            string[] files = { "d:\\users\\!\\cut_1.avi", "d:\\users\\!\\cut_1.avi" };
            VFVEFileSegment[] segments1 = new[] { new VFVEFileSegment(0, 5000) };
            var videoFile = new VFVEVideoSource(
                                files[0],
                                segments1,
                                VFVideoEditStretchMode.Letterbox,
                                0,
                                1.0);
            VFVEFileSegment[] segments2 = new[] { new VFVEFileSegment(0, 5000) };

            var videoFile2 = new VFVEVideoSource(
                                            files[1],
                                            segments2,
                                            VFVideoEditStretchMode.Letterbox,
                                            0,
                                            1.0);

            VideoEdit1.Input_AddVideoFile(
                                videoFile,
                                0);

            VideoEdit1.Input_AddVideoFile(
                    videoFile2,
                    4000);

            // get id
            int id = VideoEdit.Video_Transition_GetIDFromName("Upper right");

            // add transition
            VideoEdit1.Video_Transition_Add(4000, 5000, id);

            //var rect1 = new Rectangle(0, 0, 1280, 720);
            //var rect2 = new Rectangle(100, 100, 320, 240);
            //VideoEdit1.Input_AddVideoFile_PIP(videoFile, videoFile2, 0, 10000, VFVEPIPMode.Custom, true, 1280, 720, 0, rect2, rect1);

            //return;
            //string sourceFile = @"c:\samples\!video4K.mp4";
            //string sourceFile = @"c:\samples\!video.mp4";

            //VideoEdit1.OnStop += (o, args) =>
            //{ };

            //VideoEdit1.FastEncrypt_Start(
            //    new List<string>() { sourceFile },
            //    @"c:\samples\!video.enc",
            //    VFEncryptionKeyType.String,
            //    "100",
            //    true,
            //    "",
            //    false,
            //    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\");

            //VideoEdit1.Input_Timeline_Save(@"c:\samples\!timeline.xml");

            //var streams = new List<VFVEFFMPEGStream>();

            //streams.Add(new VFVEFFMPEGStream
            //{
            //    Filename = "c:\\samples\\!video.avi",
            //    ID = "v"
            //});

            //streams.Add(new VFVEFFMPEGStream
            //{
            //    Filename = "c:\\samples\\!sophie.mp3",
            //    ID = "a"
            //});

            //streams.Add(new VFVEFFMPEGStream
            //{
            //    Filename = "c:\\samples\\!video.avi",
            //    ID = "a"
            //});

            //VideoEdit1.FastEdit_MuxStreams(streams, true, edOutput.Text);

            //var filename2 = @"c:\Projects\_Projects\MediaFrameworkDotNet\_SOURCE\_TESTS\Samples\video.mp4";

            //VFVEFileSegment[] segments2 = new[] { new VFVEFileSegment(0, 5000), new VFVEFileSegment(3000, 10000) };

            //VFVEVideoSource videoFile2 = new VFVEVideoSource(
            //                    filename2,
            //                    segments2,
            //                    VFVideoEditStretchMode.Letterbox,
            //                    0,
            //                    1.0);

            //bool ok = VideoEdit1.Input_AddVideoFile(
            //                    videoFile2,
            //                    0);

            //VideoEdit1.Mode = VFVideoEditMode.Convert;

            //VideoEdit1.Video_Codec = "MJPEG Compressor";
            //VideoEdit1.Audio_Codec_Name = "PCM";
            //VideoEdit1.Audio_Codec_Channels = 2;
            //VideoEdit1.Audio_Codec_BPS = 16;
            //VideoEdit1.Audio_Codec_SampleRate = 44100;

            //VideoEdit1.Output_Format = VFVideoEditOutputFormat.AVI;
            //VideoEdit1.Output_Filename = @"c:\Projects\_Projects\MediaFrameworkDotNet\_SOURCE\_TESTS\Temp\output.avi";

            //VideoEdit1.Debug_Mode = true;
            //VideoEdit1.Debug_Dir = @"c:\Projects\_Projects\MediaFrameworkDotNet\_SOURCE\_TESTS\Temp\";

            //VideoEdit1.Start();

            //Thread.Sleep(3000);

            //VideoEdit1.Stop();

            //return;

            //string[] files =
            //    {
            //        "c:\\samples\\!video.avi",
            //    "c:\\samples\\!video2.wmv",
            //    "c:\\samples\\!multiaudio.avi",
            //    "c:\\samples\\!chroma3.mp4",
            //    "c:\\samples\\!chroma.jpg",
            //    "c:\\samples\\!source.avs",
            //    "c:\\samples\\!sophie.mp3"
            //    };

            //VFVEFileSegment[] segments = new[] { new VFVEFileSegment(0, 10000) };

            //var videoFile = new VFVEVideoSource(
            //                    files[0],
            //                    segments,
            //                    VFVideoEditStretchMode.Letterbox,
            //                    0,
            //                    1.0);
            //VideoEdit1.Input_AddVideoFile(
            //                    videoFile,
            //                    0);

            //var audioFile1 = new VFVEAudioSource(files[0], segments, files[0], 0, 1.0);
            //VideoEdit1.Input_AddAudioFile(audioFile1, 0, 0);

            //var audioFile2 = new VFVEAudioSource(files[6], segments);
            //VideoEdit1.Input_AddAudioFile(audioFile2, 0, 1);

            //VFVEFileSegment[] segments2 = new[] { new VFVEFileSegment(0, 10000) };

            //var videoFile2 = new VFVEVideoSource(
            //                    files[1],
            //                    segments2,
            //                    VFVideoEditStretchMode.Letterbox,
            //                    0,
            //                    1.0);

            //var rect1 = new Rectangle(0, 0, 1280, 720);
            //var rect2 = new Rectangle(100, 100, 320, 240);
            //VideoEdit1.Input_AddVideoFile_PIP(videoFile, videoFile2, 0, 10000, VFVEPIPMode.Custom, true, 1280, 720, 0, rect2, rect1);

            //VideoEdit1.Input_AddVideoFile_PIP(videoFile, videoFile2, 0, 10000, VFVEPIPMode.Horizontal, false);

            //var audioFile = new VFVEAudioSource(files[0], segments, files[0]);

            //var envelope = new VFVEAudioVolumeEnvelopeEffect(10);
            //var fade = new VFVEAudioVolumeFadeEffect(0, 100, 7000, 0);
            //var fade2 = new VFVEAudioVolumeFadeEffect(0, 100, 0, 5000);
            //VideoEdit1.Input_AddAudioFile(audioFile, 0, 0);

            //var videoFile = new VFVEVideoSource(
            //                    files[2],
            //                    0,
            //                    10000,
            //                    VFVideoEditStretchMode.Letterbox,
            //                    0,
            //                    1.0);
            //VideoEdit1.Input_AddVideoFile(
            //                    videoFile,
            //                    0);

            //VideoEdit1.Input_AddImageFile(files[3], 10000, 0, VFVideoEditStretchMode.Stretch);

            //var videoFile2 = new VFVEVideoSource(
            //        files[0],
            //        0,
            //        10000,
            //        VFVideoEditStretchMode.Letterbox,
            //        0,
            //        1.0);

            //VideoEdit1.Input_AddVideoFile(
            //        videoFile2,
            //        0);

            //VideoEdit1.Input_AddImageFile(files[3], 10000, 0, VFVideoEditStretchMode.Stretch);

            //VideoEdit1.Video_Transition_Add(0, 10000, 1001);

            //VideoEdit1.Input_Timeline_Load("c:\\samples\\!timeline.xml");
            //VideoEdit1.Input_Timeline_Save("c:\\samples\\!timeline_out.xml");
            
            //VideoEdit1.Input_AddVideoFile(
            //                    videoFile2,
            //                    0,
            //                    0,
            //                    1280 * 2,
            //                    720);

            //VideoEdit1.Video_Transition_Add_PIP(0, 20000, 0, 0, 320, 240, 0, 0, 1280, 720);
            
            //VideoEdit1.Input_AddVideoFile(
            //        "x:\\!video.avi",
            //        0,
            //        7000,
            //        -1,
            //        VFVideoEditStretchMode.Letterbox,
            //        0,
            //        1.0,
            //        0);

            //VideoEdit1.Input_AddVideoFile(
            //        "x:\\!video.avi",
            //        0,
            //        7000,
            //        -1,
            //        VFVideoEditStretchMode.Letterbox,
            //        0,
            //        1.0,
            //        0);

            //VideoEdit1.Video_Transition_Add(4000, 5000, 8);

            //VideoEdit1.Input_AddVideoFile("x:\\!video.avi");
            //VideoEdit1.Input_AddAudioFile("x:\\!video.avi", "x:\\!video.avi");

            //List<VEImageSource> images = new List<VEImageSource>();
            //for (int i = 0; i < 20; i++)
            //{
            //    images.Add(new VEImageSource(@"c:\Samples\pics\1.jpg", 2000));
            //    images.Add(new VEImageSource(@"c:\Samples\pics\2.jpg", 2000));
            //    images.Add(new VEImageSource(@"c:\Samples\pics\3.jpg", 2000));
            //    images.Add(new VEImageSource(@"c:\Samples\pics\4.jpg", 2000));
            //    images.Add(new VEImageSource(@"c:\Samples\pics\5.jpg", 2000));
            //}

            //VideoEdit1.Input_AddImageFile(images, 0);

            //VideoEdit1.Input_AddImageFile(@"c:\Samples\pics\1.jpg", 2000, -1, VFVideoEditStretchMode.Stretch);
            //VideoEdit1.Input_AddImageFile(@"c:\Samples\pics\2.jpg", 2000, -1, VFVideoEditStretchMode.Stretch);
            //VideoEdit1.Input_AddImageFile(@"c:\Samples\pics\3.jpg", 2000, -1, VFVideoEditStretchMode.Stretch);
            //VideoEdit1.Input_AddImageFile(@"c:\Samples\pics\4.jpg", 2000, -1, VFVideoEditStretchMode.Stretch);
            //VideoEdit1.Input_AddImageFile(@"c:\Samples\pics\5.jpg", 2000, -1, VFVideoEditStretchMode.Stretch);

            //VideoEdit1.Video_Transition_Add_FadeIn(0, 5000, Color.Black, 0, 100);
            //VideoEdit1.Video_Transition_Add_FadeIn(5000, 10000, Color.Black, 100, 0);

            //VideoEdit1.PIP_Sources_Add_FileStream(
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0));

            //cbPIPStreams.Items.Add("Video stream " + 0);

            //VideoEdit1.Input_AddVideoFile(
            //        "x:\\!video2.avi",
            //        0,
            //        10000,
            //        0,
            //        VFVideoEditStretchMode.Letterbox,
            //        1.0,
            //        1);

            //VideoEdit1.PIP_Sources_Add_FileStream(
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0),
            //    Convert.ToInt32(0));

            //cbPIPStreams.Items.Add("Video stream " + 1);

            //VideoEdit1.Input_AddVideoFile("x:\\!video.avi", -1, -1, -1, VFVideoEditStretchMode.Letterbox, 1.0, 0);
            //VideoEdit1.Input_AddVideoFile("x:\\!video.wmv", -1, -1, -1, VFVideoEditStretchMode.Letterbox, 1.0, 1);

            //VideoEdit1.PIP_Sources_SetSourcePosition(0, 0, 0, 1280, 720);
            //VideoEdit1.PIP_Sources_SetSourcePosition(1, 0, 0, 320, 240);
            
            //VideoEdit1.Test();

            //VideoEdit1.Video_Crop_Enabled = true;
            //VideoEdit1.Video_Crop_Top = 200;
        }

        private void btFadesAdd_Click(object sender, EventArgs e)
        {
            if (rbFadeIn.Checked)
            {
                VideoEdit1.Audio_Fades_Add(0, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), 0, 100);
                lbFades.Items.Add("Fade-In: " + edStartTime.Text + " - " + edStopTime.Text);
            }
            else
            {
                VideoEdit1.Audio_Fades_Add(0, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), 100, 0);
                lbFades.Items.Add("Fade-Out: " + edStartTime.Text + " - " + edStopTime.Text);
            }
        }

        private void btFadesListClear_Click(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Fades_Clear();
            lbFades.Items.Clear();
        }

        private void cbZoom_CheckedChanged(object sender, EventArgs e)
        {
            IVFVideoEffectZoom zoomEffect;
            var effect = VideoEdit1.Video_Effects_Get("Zoom");
            if (effect == null)
            {
                zoomEffect = new VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoom.Checked);
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

        #region Barcode detector

        private delegate void BarcodeDelegate(BarcodeEventArgs value);

        private void BarcodeDelegateMethod(BarcodeEventArgs value)
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

            BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        private void btBarcodeReset_Click(object sender, EventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            VideoEdit1.Barcode_Reader_Enabled = true;
        }

        private void btRefreshClients_Click(object sender, EventArgs e)
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

        private void btSelectWMVProfileNetwork_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edNetworkStreamingWMVProfile.Text = openFileDialog1.FileName;
            }
        }

        private void ConfigureDecklinkOutput()
        {
            if (cbDecklinkOutput.Checked)
            {
                VideoEdit1.Decklink_Output = new DecklinkOutputSettings
                                                 {
                                                     DVEncoding = this.cbDecklinkDV.Checked,
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
                                                         this.cbDecklinkOutputDownConversionAnalogOutput.Checked,
                                                     AnalogOutput =
                                                         (DecklinkAnalogOutput)this.cbDecklinkOutputAnalog.SelectedIndex
                                                 };
            }
            else
            {
                VideoEdit1.Decklink_Output = null;
            }
        }

        private void ConfigureVideoRenderer()
        {
            if (VideoEdit1.Video_Renderer == null)
            {
                VideoEdit1.Video_Renderer = new VideoRendererSettingsWinForms();
            }

            if (rbVMR9.Checked)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else if (rbEVR.Checked)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (rbVR.Checked)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
            else if (rbDirect2D.Checked)
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D;
            }
            else
            {
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.None;
            }

            if (cbStretch.Checked)
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);

            VideoEdit1.Video_Renderer.BackgroundColor = pnVideoRendererBGColor.BackColor;
            VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked;
            VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked;
        }

        private void ConfigureChromaKey()
        {
            if (cbChromaKeyEnabled.Checked)
            {
                VideoEdit1.ChromaKey = new ChromaKeySettings
                                           {
                                               ContrastHigh = this.tbChromaKeyContrastHigh.Value,
                                               ContrastLow = this.tbChromaKeyContrastLow.Value,
                                               ImageFilename = this.edChromaKeyImage.Text
                                           };

                if (rbChromaKeyGreen.Checked)
                {
                    VideoEdit1.ChromaKey.Color = VFChromaColor.Green;
                }
                else if (rbChromaKeyBlue.Checked)
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

        private void cbFadeInOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFadeIn.Checked)
            {
                IVFVideoEffectFadeIn fadeIn;
                var effect = VideoEdit1.Video_Effects_Get("FadeIn");
                if (effect == null)
                {
                    fadeIn = new VFVideoEffectFadeIn(cbFadeInOut.Checked);
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

                fadeIn.Enabled = cbFadeInOut.Checked;
                fadeIn.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeIn.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
            }
            else
            {
                IVFVideoEffectFadeOut fadeOut;
                var effect = VideoEdit1.Video_Effects_Get("FadeOut");
                if (effect == null)
                {
                    fadeOut = new VFVideoEffectFadeOut(cbFadeInOut.Checked);
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

                fadeOut.Enabled = cbFadeInOut.Checked;
                fadeOut.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text);
                fadeOut.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text);
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

                controlLeft = VideoEdit1.Left;
                controlTop = VideoEdit1.Top;
                controlWidth = VideoEdit1.Width;
                controlHeight = VideoEdit1.Height;

                // resizing window
                Left = 0;
                Top = 0;
                Width = Screen.AllScreens[0].WorkingArea.Width;
                Height = Screen.AllScreens[0].WorkingArea.Height;

                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;

                // resizing control
                VideoEdit1.Left = 0;
                VideoEdit1.Top = 0;
                VideoEdit1.Width = Width;
                VideoEdit1.Height = Height;

                VideoEdit1.Video_Renderer_Update();
            }
            else
            {
                // going normal screen
                fullScreen = false;

                // restoring control
                VideoEdit1.Left = controlLeft;
                VideoEdit1.Top = controlTop;
                VideoEdit1.Width = controlWidth;
                VideoEdit1.Height = controlHeight;

                // restoring window
                Left = windowLeft;
                Top = windowTop;
                Width = windowWidth;
                Height = windowHeight;

                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;

                VideoEdit1.Video_Renderer_Update();
            }
        }

        private void VideoEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (fullScreen)
            {
                this.btFullScreen_Click(null, null);
            }
        }

        #endregion

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/878966-Streaming-to-Adobe-Flash-Media-Server");
            Process.Start(startInfo);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/300487-Streaming-using-Microsoft-Expression-Encoder");
            Process.Start(startInfo);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/240078-How-to-configure-IIS-Smooth-Streaming-in-SDK-demo-application");
            Process.Start(startInfo);
        }

        private void btAddInputFile2_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = OpenDialog1.FileName;

                edSourceFileToCut.Text = s;

                string extNew = Path.GetExtension(s)?.ToLowerInvariant();
                string extOld = Path.GetExtension(edOutputFileCut.Text)?.ToLowerInvariant();
                if (extOld != null)
                {
                    this.edOutputFileCut.Text = this.edOutputFileCut.Text.Replace(extOld, extNew);
                }
            }
        }

        private void btAddInputFile3_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = OpenDialog1.FileName;
                lbFiles2.Items.Add(s);

                edSourceFileToCut.Text = s;

                string extNew = Path.GetExtension(s).ToLowerInvariant();
                string extOld = Path.GetExtension(edOutputFileJoin.Text)?.ToLowerInvariant();
                if (extOld != null)
                {
                    edOutputFileJoin.Text = edOutputFileJoin.Text.Replace(extOld, extNew);
                }
            }
        }

        private void btClearList3_Click(object sender, EventArgs e)
        {
            lbFiles2.Items.Clear();
        }

        private void cbDirect2DRotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);
            VideoEdit1.Video_Renderer_Update();
        }

        private void pnVideoRendererBGColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pnVideoRendererBGColor.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnVideoRendererBGColor.BackColor = colorDialog1.Color;
            }
        }
        
        private void btAddTransition_Click(object sender, EventArgs e)
        {
            // get id
            int id = VideoEdit.Video_Transition_GetIDFromName(cbTransitionName.Text);

            // add transition
            VideoEdit1.Video_Transition_Add(Convert.ToInt32(edTransStartTime.Text), Convert.ToInt32(edTransStopTime.Text), id);

            // add to list
            lbTransitions.Items.Add(cbTransitionName.Text +
            "(Start: " + edTransStartTime.Text + ", stop: " + edTransStopTime.Text + ")");
        }

        private void cbAudioNormalize_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked);
        }

        private void cbAudioAutoGain_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked);
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

            VideoEdit1.Audio_Enhancer_InputGains(-1, gains);
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

            VideoEdit1.Audio_Enhancer_OutputGains(-1, gains);
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

            VideoEdit1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value);
        }

        private void VideoEdit1_OnLicenseRequired(object sender, LicenseEventArgs e)
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

                    cbFFEXEVideoCodec.SelectedIndex = 12;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MPEG-1 VCD
                case 1:
                    cbFFEXEOutputFormat.SelectedIndex = 34;

                    cbFFEXEVideoCodec.SelectedIndex = 12;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2
                case 2:
                    cbFFEXEOutputFormat.SelectedIndex = 23;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MPEG-2 SVCD
                case 3:
                    cbFFEXEOutputFormat.SelectedIndex = 30;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2 DVD
                case 4:
                    cbFFEXEOutputFormat.SelectedIndex = 7;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
                    cbFFEXEAudioCodec.SelectedIndex = 12;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    break;

                // MPEG-2 TS
                case 5:
                    cbFFEXEOutputFormat.SelectedIndex = 24;

                    cbFFEXEVideoCodec.SelectedIndex = 13;
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

                // MP4 HEVC / AAC
                case 8:
                    cbFFEXEOutputFormat.SelectedIndex = 22;

                    cbFFEXEVideoCodec.SelectedIndex = 6;
                    cbFFEXEAudioCodec.SelectedIndex = 1;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // WebM
                case 9:
                    cbFFEXEOutputFormat.SelectedIndex = 36;

                    cbFFEXEVideoCodec.SelectedIndex = 17;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // AVI
                case 10:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // OGG Vorbis
                case 11:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 41;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // Opus
                case 12:
                    cbFFEXEOutputFormat.SelectedIndex = 27;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 14;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // Speex
                case 13:
                    cbFFEXEOutputFormat.SelectedIndex = 26;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 40;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // FLAC
                case 14:
                    cbFFEXEOutputFormat.SelectedIndex = 10;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 10;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // MP3
                case 15:
                    cbFFEXEOutputFormat.SelectedIndex = 21;

                    cbFFEXEVideoCodec.SelectedIndex = 0;
                    cbFFEXEAudioCodec.SelectedIndex = 13;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);
                    break;

                // DV
                case 16:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 1;
                    cbFFEXEAudioCodec.SelectedIndex = 23;

                    cbFFEXEVideoCodec_SelectedIndexChanged(null, null);
                    cbFFEXEAudioCodec_SelectedIndexChanged(null, null);

                    cbFFEXEAudioChannels.SelectedIndex = 1;
                    cbFFEXEAudioSampleRate.SelectedIndex = 1;
                    break;

                // Custom
                case 17:
                    cbFFEXEOutputFormat.SelectedIndex = 4;

                    cbFFEXEVideoCodec.SelectedIndex = 14;
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

                // HEVC
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
                        tbFFEXEVideoQuality_Scroll(null, null);
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
                        tbFFEXEVideoQuality_Scroll(null, null);

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
                        tbFFEXEVideoQuality_Scroll(null, null);

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

        private void VideoEdit1_OnFFMPEGInfo(object sender, FFMPEGInfoEventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/support/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem");
            Process.Start(startInfo);
        }

        private void btStartCut_Click(object sender, EventArgs e)
        {
            VideoEdit1.FastEdit_CutFile(
                edSourceFileToCut.Text,
                Convert.ToInt32(edStartTimeCut.Text),
                Convert.ToInt32(edStopTimeCut.Text),
                edOutputFileCut.Text);
        }

        private void btStopCut_Click(object sender, EventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void btStartJoin_Click(object sender, EventArgs e)
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

        private void btStopJoin_Click(object sender, EventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void btSelectOutputCut_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutputFileCut.Text = SaveDialog1.FileName;
            }
        }

        private void btSelectOutputJoin_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutputFileJoin.Text = SaveDialog1.FileName;
            }
        }

        private void imgTagCover_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                imgTagCover.LoadAsync(openFileDialog2.FileName);
                imgTagCover.Tag = openFileDialog2.FileName;
            }
        }

        private void btStartMux_Click(object sender, EventArgs e)
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

            VideoEdit1.FastEdit_MuxStreams(streams, cbMuxStreamsShortest.Checked, edMuxStreamsOutputFile.Text);
        }

        private void btMuxStreamsSelectFile_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                edMuxStreamsSourceFile.Text = OpenDialog1.FileName;
            }
        }

        private void btMuxStreamsAdd_Click(object sender, EventArgs e)
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

        private void btMuxStreamsClear_Click(object sender, EventArgs e)
        {
            lbMuxStreamsList.Items.Clear();
        }

        private void btMuxStreamsSelectOutput_Click(object sender, EventArgs e)
        {
            if (SaveDialog1.ShowDialog() == DialogResult.OK)
            {
                edMuxStreamsOutputFile.Text = SaveDialog1.FileName;
            }
        }

        private void btStopMux_Click(object sender, EventArgs e)
        {
            VideoEdit1.FastEdit_Stop();
        }

        private void cbDebugMode_CheckedChanged(object sender, EventArgs e)
        {
            VideoEdit1.Debug_Mode = cbDebugMode.Checked;
        }

        private void FFMPEGDownloadLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_ffmpeg_exe_x86_x64.exe");
            Process.Start(startInfo);
        }

        private void btAudioChannelMapperClear_Click(object sender, EventArgs e)
        {
            audioChannelMapperItems.Clear();
            lbAudioChannelMapperRoutes.Items.Clear();
        }

        private void btAudioChannelMapperAddNewRoute_Click(object sender, EventArgs e)
        {
            var item = new AudioChannelMapperItem();
            item.SourceChannel = Convert.ToInt32(edAudioChannelMapperSourceChannel.Text);
            item.TargetChannel = Convert.ToInt32(edAudioChannelMapperTargetChannel.Text);
            item.TargetChannelVolume = tbAudioChannelMapperVolume.Value / 1000.0f;

            audioChannelMapperItems.Add(item);

            lbAudioChannelMapperRoutes.Items.Add(
                "Source: " + edAudioChannelMapperSourceChannel.Text + ", target: "
                + edAudioChannelMapperTargetChannel.Text + ", volume: "
                + (tbAudioChannelMapperVolume.Value / 1000.0f).ToString("F2"));
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"https://visioforge.com/support/577349-Network-streaming-to-YouTube");
            Process.Start(startInfo);
        }

        private void btSubtitlesSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogSubtitles.ShowDialog() == DialogResult.OK)
            {
                edSubtitlesFilename.Text = openFileDialogSubtitles.FileName;
            }
        }

        private void tbGPULightness_Scroll(object sender, EventArgs e)
        {
            IVFGPUVideoEffectBrightness intf;
            var effect = VideoEdit1.Video_Effects_GPU_Get("Brightness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBrightness(true, tbGPULightness.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Saturation");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectSaturation(true, tbGPUSaturation.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Contrast");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectContrast(true, tbGPUContrast.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Darkness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDarkness(true, tbGPUDarkness.Value);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Grayscale");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectGrayscale(cbGPUGreyscale.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Invert");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectInvert(cbGPUInvert.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("NightVision");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectNightVision(cbGPUNightVision.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Pixelate");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectPixelate(cbGPUPixelate.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Denoise");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDenoise(cbGPUDenoise.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("DeinterlaceBlend");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("Blur");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBlur(cbGPUBlur.Checked, 50);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
            var effect = VideoEdit1.Video_Effects_GPU_Get("OldMovie");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectOldMovie(cbGPUOldMovie.Checked);
                VideoEdit1.Video_Effects_GPU_Add(intf);
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
    }
}

// ReSharper restore InconsistentNaming
