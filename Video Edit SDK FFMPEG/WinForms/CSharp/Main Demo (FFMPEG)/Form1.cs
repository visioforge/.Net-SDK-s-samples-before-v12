// ReSharper disable InconsistentNaming

namespace VideoEdit_CS_Demo
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;

    /// <summary>
    /// Main demo form.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btClearList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            VideoEdit1.Sources_Clear();
        }

        private void btAddInputFile_Click(object sender, EventArgs e)
        {
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = this.OpenDialog1.FileName;

                lbFiles.Items.Add(s);

                long videoDuration;
                long audioDuration;
                VideoEdit.GetFileLength(s, out videoDuration, out audioDuration);

                VideoEdit1.Sources_AddFile(s, videoDuration > 0, audioDuration > 0);
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
            VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            cbFrameRate.SelectedIndex = 7;
            cbOutputVideoFormat.SelectedIndex = 1;
            cbMotDetHLColor.SelectedIndex = 1;
            cbBarcodeType.SelectedIndex = 0;

            cbAspectRatio.SelectedIndex = 0;
            cbAudioBitrate.SelectedIndex = 8;
            cbAudioChannels.SelectedIndex = 1;
            cbAudioEncoder.SelectedIndex = 0;
            cbVideoEncoder.SelectedIndex = 1;
            cbAudioSampleRate.SelectedIndex = 0;
            cbContainer.SelectedIndex = 0;
        }

        private void ConfigureObjectDetection()
        {
            if (cbAFMotionDetection.Checked)
            {
                VideoEdit1.Object_Detection = new ObjectDetectionSettings();
                if (cbAFMotionHighlight.Checked)
                {
                    VideoEdit1.Object_Detection.ProcessorType = MotionProcessorType.MotionAreaHighlighting;
                }
                else
                {
                    VideoEdit1.Object_Detection.ProcessorType = MotionProcessorType.None;
                }
            }
            else
            {
                VideoEdit1.Object_Detection = null;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmLog.Clear();

            VideoEdit1.Debug_Mode = cbDebugMode.Checked;

            VideoEdit1.Video_Effects_Clear();

            VideoEdit1.Output_Filename = edOutput.Text;

            VideoEdit1.Profile = (VFFFMPEGSDKProfile)cbOutputVideoFormat.SelectedIndex;

            VideoEdit1.Output_Audio_Channels = (VFFFMPEGSDKAudioChannels)cbAudioChannels.SelectedIndex;
            VideoEdit1.Output_Audio_SampleRate = Convert.ToInt32(cbAudioSampleRate.Text);
            VideoEdit1.Output_Audio_Bitrate = Convert.ToInt32(cbAudioBitrate.Text) * 1000;
            VideoEdit1.Output_Audio_Encoder = (VFFFMPEGSDKAudioEncoder)cbAudioEncoder.SelectedIndex;

            VideoEdit1.Output_Video_AspectRatio = (VFFFMPEGSDKAspectRatio)cbAspectRatio.SelectedIndex;
            VideoEdit1.Output_Video_Bitrate = Convert.ToInt32(edTargetBitrate.Text) * 1000;
            VideoEdit1.Output_Video_BufferSize = Convert.ToInt32(edBufferSize.Text) * 1000;
            VideoEdit1.Output_Video_Bitrate_Min = Convert.ToInt32(edMinimalBitrate.Text) * 1000;
            VideoEdit1.Output_Video_Bitrate_Max = Convert.ToInt32(edMaximalBitrate.Text) * 1000;
            VideoEdit1.Output_Video_Encoder = (VFFFMPEGSDKVideoEncoder)cbVideoEncoder.SelectedIndex;
            VideoEdit1.Output_Video_FrameRate = (VFFFMPEGSDKFrameRate)cbFrameRate.SelectedIndex;

            VideoEdit1.Output_Muxer = (VFFFMPEGSDKMuxFormat)cbContainer.SelectedIndex;

            if (cbResize.Checked)
            {
                VideoEdit1.Output_Video_Width = Convert.ToInt32(edWidth.Text);
                VideoEdit1.Output_Video_Height = Convert.ToInt32(edHeight.Text);
            }
            else
            {
                VideoEdit1.Output_Video_Width = 0;
                VideoEdit1.Output_Video_Height = 0;
            }

            // Audio processing
            VideoEdit1.Audio_Effects_Clear();

            if (cbAudAmplifyEnabled.Checked)
            {
                VideoEdit1.Audio_Effects_Add_Volume(tbAudAmplifyAmp.Value / 100.0);
            }

            if (cbAudEchoEnabled.Checked)
            {
                VideoEdit1.Audio_Effects_Add_Echo(
                    tbAudDelayGainIn.Value / 100.0,
                    tbAudDelayGainOut.Value / 100.0,
                    tbAudDelay.Value,
                    tbAudDelayGainDecay.Value / 100.0);
            }

            // Video processing
            VideoEdit1.Video_Effects_Clear();

            if (cbVideoEffects.Checked)
            {
                VideoEdit1.Video_Effects_Add_Simple(VFVideoEffectType.Lightness, 0, 0, tbLightness.Value, 0);
                VideoEdit1.Video_Effects_Add_Simple(VFVideoEffectType.Contrast, 0, 0, tbContrast.Value, 0);
                VideoEdit1.Video_Effects_Add_Simple(VFVideoEffectType.Saturation, 0, 0, tbSaturation.Value, 0);

                if (cbInvert.Checked)
                {
                    VideoEdit1.Video_Effects_Add_Simple(VFVideoEffectType.Invert, 0, 0, 0, 0);
                }

                if (cbGreyscale.Checked)
                {
                    VideoEdit1.Video_Effects_Add_Simple(VFVideoEffectType.Greyscale, 0, 0, 0, 0);
                }

                if (cbGraphicLogo.Checked)
                {
                    if (!cbGraphicLogoShowAlways.Checked)
                    {
                        VideoEdit1.Video_Effects_Add_ImageLogo(
                            Convert.ToInt32(edGraphicLogoStartTime.Text),
                            Convert.ToInt32(edGraphicLogoStopTime.Text),
                            edGraphicLogoFilename.Text,
                            Convert.ToInt32(edGraphicLogoLeft.Text),
                            Convert.ToInt32(edGraphicLogoTop.Text));
                    }
                    else
                    {
                        VideoEdit1.Video_Effects_Add_ImageLogo(
                            0,
                            0,
                            edGraphicLogoFilename.Text,
                            Convert.ToInt32(edGraphicLogoLeft.Text),
                            Convert.ToInt32(edGraphicLogoTop.Text));
                    }
                }

                if (cbTextLogo.Checked)
                {
                    if (!cbTextLogoShowAlways.Checked)
                    {
                        VideoEdit1.Video_Effects_Add_TextLogo(
                            Convert.ToInt32(edTextLogoStartTime.Text),
                            Convert.ToInt32(edTextLogoStopTime.Text),
                            edTextLogoValue.Text,
                            Convert.ToInt32(edTextLogoLeft.Text),
                            Convert.ToInt32(edTextLogoTop.Text),
                            FontDialog1.Font,
                            FontDialog1.Color,
                            Color.Transparent);
                    }
                    else
                    {
                        VideoEdit1.Video_Effects_Add_TextLogo(
                            0,
                            0,
                            edTextLogoValue.Text,
                            Convert.ToInt32(edTextLogoLeft.Text),
                            Convert.ToInt32(edTextLogoTop.Text),
                            FontDialog1.Font,
                            FontDialog1.Color,
                            Color.Transparent);
                    }
                }

                if (cbDeinterlace.Checked)
                {
                    VideoEdit1.Video_Effects_Add_Deinterlace();
                }

                if (cbDenoise.Checked)
                {
                    VideoEdit1.Video_Effects_Add_3DDenoise();
                }
            }

            if (cbZoom.Checked)
            {
                double zoom = tbZoom.Value / 10.0;
                VideoEdit1.Video_Effects_Add_Zoom(0, 0, zoom, zoom, 0, 0);
            }

            if (cbPan.Checked)
            {
                VideoEdit1.Video_Effects_Add_Pan(
                    Convert.ToInt32(edPanStartTime.Text),
                    Convert.ToInt32(edPanStopTime.Text),
                    Convert.ToInt32(edPanSourceLeft.Text),
                    Convert.ToInt32(edPanSourceTop.Text),
                    Convert.ToInt32(edPanSourceWidth.Text),
                    Convert.ToInt32(edPanSourceHeight.Text),
                    Convert.ToInt32(edPanDestLeft.Text),
                    Convert.ToInt32(edPanDestTop.Text),
                    Convert.ToInt32(edPanDestWidth.Text),
                    Convert.ToInt32(edPanDestHeight.Text));
            }

            if (cbFadeInOut.Checked)
            {
                if (rbFadeIn.Checked)
                {
                    VideoEdit1.Video_Effects_Add_Simple(
                        VFVideoEffectType.FadeIn,
                        Convert.ToInt32(edFadeInOutStartTime.Text),
                        Convert.ToInt32(edFadeInOutStopTime.Text),
                        0,
                        0);
                }
                else
                {
                    VideoEdit1.Video_Effects_Add_Simple(
                        VFVideoEffectType.FadeOut,
                        Convert.ToInt32(edFadeInOutStartTime.Text),
                        Convert.ToInt32(edFadeInOutStopTime.Text),
                        0,
                        0);
                }
            }

            // motion detection
            if (cbMotDetEnabled.Checked)
            {
                VideoEdit1.Motion_Detection = new MotionDetectionSettings();
                VideoEdit1.Motion_Detection.Enabled = cbMotDetEnabled.Checked;
                VideoEdit1.Motion_Detection.Compare_Red = cbCompareRed.Checked;
                VideoEdit1.Motion_Detection.Compare_Green = cbCompareGreen.Checked;
                VideoEdit1.Motion_Detection.Compare_Blue = cbCompareBlue.Checked;
                VideoEdit1.Motion_Detection.Compare_Greyscale = cbCompareGreyscale.Checked;
                VideoEdit1.Motion_Detection.Highlight_Color = (VFMotionCHLColor)cbMotDetHLColor.SelectedIndex;
                VideoEdit1.Motion_Detection.Highlight_Enabled = cbMotDetHLEnabled.Checked;
                VideoEdit1.Motion_Detection.Highlight_Threshold = tbMotDetHLThreshold.Value;
                VideoEdit1.Motion_Detection.FrameInterval = Convert.ToInt32(edMotDetFrameInterval.Text);
                VideoEdit1.Motion_Detection.Matrix_Height = Convert.ToInt32(edMotDetMatrixHeight.Text);
                VideoEdit1.Motion_Detection.Matrix_Width = Convert.ToInt32(edMotDetMatrixWidth.Text);
                VideoEdit1.Motion_Detection.DropFrames_Enabled = cbMotDetDropFramesEnabled.Checked;
                VideoEdit1.Motion_Detection.DropFrames_Threshold = tbMotDetDropFramesThreshold.Value;
            }
            else
            {
                VideoEdit1.Motion_Detection = null;
            }

            // Object detection
            ConfigureObjectDetection();

            // Chroma key
            ConfigureChromaKey();

            // Barcode detection
            VideoEdit1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.Checked;
            VideoEdit1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;

            VideoEdit1.Start();
        }

        private void ConfigureChromaKey()
        {
            if (cbChromaKeyEnabled.Checked)
            {
                VideoEdit1.ChromaKey = new ChromaKeySettings();
                VideoEdit1.ChromaKey.ContrastHigh = tbChromaKeyContrastHigh.Value;
                VideoEdit1.ChromaKey.ContrastLow = tbChromaKeyContrastLow.Value;
                VideoEdit1.ChromaKey.ImageFilename = edChromaKeyImage.Text;

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

        private void btStop_Click(object sender, EventArgs e)
        {
            VideoEdit1.Stop();
            ProgressBar1.Value = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoEdit1.Stop();
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                edGraphicLogoFilename.Text = openFileDialog2.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        public delegate void AFErrorDelegate(string error);

        private void AFErrorDelegateMethod(string error)
        {
            mmLog.Text = mmLog.Text + error + Environment.NewLine;
        }

        private void VideoEdit1_OnError(object sender, ErrorsEventArgs e)
        {
            BeginInvoke(new AFErrorDelegate(AFErrorDelegateMethod), e.Message);
        }

        public delegate void ProgressDelegate(int progress);

        public void ProgressDelegateMethod(int progress)
        {
            // if (ProgressBar1.Value < progress)
            // {
                ProgressBar1.Value = progress;
            // }
        }

        private void VideoEdit1_OnProgress(object sender, ProgressEventArgs e)
        {
            BeginInvoke(new ProgressDelegate(ProgressDelegateMethod), e.Progress);
        }

        public delegate void AFStopDelegate();

        public void AFStopDelegateMethod()
        {
            ProgressBar1.Value = 0;
            VideoEdit1.Sources_Clear();
            lbFiles.Items.Clear();

            MessageBox.Show("Complete", string.Empty, MessageBoxButtons.OK);
        }

        private void cbAFMotionDetection_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureObjectDetection();
        }

        private void cbAFMotionHighlight_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureObjectDetection();
        }

        private void tbChromaKeyContrastLow_Scroll(object sender, EventArgs e)
        {
            if (VideoEdit1.ChromaKey != null)
            {
                VideoEdit1.ChromaKey.ContrastLow = tbChromaKeyContrastLow.Value;
            }
        }

        private void tbChromaKeyContrastHigh_Scroll(object sender, EventArgs e)
        {
            if (VideoEdit1.ChromaKey != null)
            {
                VideoEdit1.ChromaKey.ContrastHigh = tbChromaKeyContrastHigh.Value;
            }
        }

        private void btChromaKeySelectBGImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edChromaKeyImage.Text = openFileDialog1.FileName;
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

        private void VideoEdit1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        public delegate void AFMotionDelegate(float level);

        public void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void VideoEdit1_OnAForgeMotionDetection(object sender, ObjectDetectionEventArgs e)
        {
            BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
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

            BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        private void btBarcodeReset_Click(object sender, EventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            VideoEdit1.Barcode_Reader_Enabled = true;
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog1.ShowDialog();
        }

        private void cbFadeInOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFadeIn.Checked)
            {
                VideoEdit1.Video_Effects_Add_Simple(
                    VFVideoEffectType.FadeIn,
                    Convert.ToInt32(edFadeInOutStartTime.Text),
                    Convert.ToInt32(edFadeInOutStopTime.Text),
                    0,
                    0);
            }
            else
            {
                VideoEdit1.Video_Effects_Add_Simple(
                    VFVideoEffectType.FadeOut,
                    Convert.ToInt32(edFadeInOutStartTime.Text),
                    Convert.ToInt32(edFadeInOutStopTime.Text),
                    0,
                    0);
            }
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            // string filename = "x:\\axe_matamor.avi";
            // VideoEdit1.Sources_AddFile(filename);

            // VideoEdit1.Debug_Mode = false;
            // VideoEdit1.Video_Effects_Clear();
            // VideoEdit1.Output_Filename = "x:\\axe_matamor.webm";
            // VideoEdit1.Profile = VFFFMPEGSDKProfile.Custom;
            // VideoEdit1.Output_Audio_Channels = VFFFMPEGSDKAudioChannels.Stereo;
            // VideoEdit1.Output_Audio_SampleRate = 44100;
            // VideoEdit1.Output_Audio_SampleRate = 44100;
            // VideoEdit1.Output_Audio_Bitrate = 128000;
            // VideoEdit1.Output_Audio_Encoder = VFFFMPEGSDKAudioEncoder.Vorbis;
            // VideoEdit1.Output_Video_AspectRatio = VFFFMPEGSDKAspectRatio.AR_None;
            // VideoEdit1.Output_Video_Bitrate = 2000000;
            // VideoEdit1.Output_Video_BufferSize = 3000000;
            // VideoEdit1.Output_Video_Bitrate_Min = 1000000;
            // VideoEdit1.Output_Video_Bitrate_Max = 3000000;
            // VideoEdit1.Output_Video_Encoder = VFFFMPEGSDKVideoEncoder.VP8;
            // VideoEdit1.Output_Video_FrameRate = VFFFMPEGSDKFrameRate.fr25;

            // VideoEdit1.Output_Muxer = VFFFMPEGSDKMuxFormat.WebM;

            // VideoEdit1.Output_Video_Width = 640;
            // VideoEdit1.Output_Video_Height = 480;

            //// Audio processing 
            // VideoEdit1.Audio_Effects_Clear();

            //// Video processing 
            // VideoEdit1.Video_Effects_Clear();

            //// motion detection 
            // VideoEdit1.MotionDetection_Enabled = false;

            //// AForge.Net 
            // VideoEdit1.AForge_Motion_Detection_Enabled = false;
            // VideoEdit1.AForge_Motion_Detection_ProcessorType = AFMotionProcessorType.None;

            //// Chroma key 
            // VideoEdit1.ChromaKey_Enabled = false;
            // VideoEdit1.ChromaKey_ContrastHigh = 150;
            // VideoEdit1.ChromaKey_ContrastLow = 10;
            // VideoEdit1.ChromaKey_ImageFilename = @"c:\chroma_bg.bmp";
            // VideoEdit1.ChromaKey_Color = VFChromaColor.Green;

            //// Barcode detection 
            // VideoEdit1.Barcode_Reader_Enabled = false;
            // VideoEdit1.Barcode_Reader_Type = VFBarcodeType.Auto;

            // VideoEdit1.Start();
        }

        //VisioForge.Controls.WinForms.VideoEdit videoEdit = new VisioForge.Controls.WinForms.VideoEdit();

        //public delegate void FastCryptDelegate();

        //private void FastCryptDelegateMethod()
        //{
        //    videoEdit.OnError += VideoEditOnOnError;
        //    videoEdit.OnStop += VideoEditOnOnStop;
        //    videoEdit.OnProgress += VideoEdit2OnOnProgress;

        //    videoEdit.FastEncrypt_Start(new List<string>() { edOutput.Text }, "C:\\vf\\test.enc", "100", false, "c:\\vf\\"); 
        //}

        private void VideoEdit1_OnStop(object sender, EventArgs e)
        {
            //BeginInvoke(new FastCryptDelegate(FastCryptDelegateMethod));

            BeginInvoke(new AFStopDelegate(this.AFStopDelegateMethod));
        }

        private void VideoEdit1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        //private void VideoEdit2OnOnProgress(object sender, ProgressEventArgs progressEventArgs)
        //{
            
        //}

        //private void VideoEditOnOnStop(object sender, EventArgs eventArgs)
        //{
        //    MessageBox.Show("FastCrypt done");
        //}

        //private void VideoEditOnOnError(object sender, ErrorsEventArgs errorsEventArgs)
        //{
        //    MessageBox.Show(errorsEventArgs.Message);
        //}
    }
}

// ReSharper restore InconsistentNaming