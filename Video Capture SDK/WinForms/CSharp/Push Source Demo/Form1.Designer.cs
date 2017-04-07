namespace Push_Source_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms1 = new VisioForge.Types.VideoRendererSettingsWinForms();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCaptureMP4 = new System.Windows.Forms.RadioButton();
            this.rbCaptureAVI = new System.Windows.Forms.RadioButton();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSelectOutputAVI = new System.Windows.Forms.Button();
            this.edOutputAVI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btAudioSettings = new System.Windows.Forms.Button();
            this.btVideoSettings = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.cbBPS = new System.Windows.Forms.ComboBox();
            this.cbAudioCodecs = new System.Windows.Forms.ComboBox();
            this.cbSampleRate = new System.Windows.Forms.ComboBox();
            this.cbVideoCodecs = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btSelectOutputMP4 = new System.Windows.Forms.Button();
            this.edOutputMP4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.cbH264GOP = new System.Windows.Forms.CheckBox();
            this.cbH264AutoBitrate = new System.Windows.Forms.CheckBox();
            this.label350 = new System.Windows.Forms.Label();
            this.edH264Bitrate = new System.Windows.Forms.TextBox();
            this.label351 = new System.Windows.Forms.Label();
            this.cbH264RateControl = new System.Windows.Forms.ComboBox();
            this.groupBox46 = new System.Windows.Forms.GroupBox();
            this.cbH264TargetUsage = new System.Windows.Forms.ComboBox();
            this.label359 = new System.Windows.Forms.Label();
            this.label352 = new System.Windows.Forms.Label();
            this.label353 = new System.Windows.Forms.Label();
            this.cbH264Level = new System.Windows.Forms.ComboBox();
            this.cbH264Profile = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label354 = new System.Windows.Forms.Label();
            this.cbAACOutput = new System.Windows.Forms.ComboBox();
            this.label355 = new System.Windows.Forms.Label();
            this.cbAACBitrate = new System.Windows.Forms.ComboBox();
            this.label356 = new System.Windows.Forms.Label();
            this.cbAACObjectType = new System.Windows.Forms.ComboBox();
            this.label357 = new System.Windows.Forms.Label();
            this.cbAACVersion = new System.Windows.Forms.ComboBox();
            this.label358 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox46.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoCapture1
            // 
            this.VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.VideoCapture1.Audio_CaptureDevice = "";
            this.VideoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.VideoCapture1.Audio_CaptureDevice_Format = "";
            this.VideoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.VideoCapture1.Audio_CaptureDevice_Line = "";
            this.VideoCapture1.Audio_CaptureDevice_Path = null;
            this.VideoCapture1.Audio_Decoder = null;
            this.VideoCapture1.Audio_Effects_Enabled = false;
            this.VideoCapture1.Audio_Effects_UseLegacyEffects = false;
            this.VideoCapture1.Audio_Enhancer_Enabled = false;
            this.VideoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.VideoCapture1.Audio_PlayAudio = true;
            this.VideoCapture1.Audio_RecordAudio = true;
            this.VideoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Audio_VUMeter_Enabled = false;
            this.VideoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.VideoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.VideoCapture1.BackColor = System.Drawing.Color.Black;
            this.VideoCapture1.Barcode_Reader_Enabled = false;
            this.VideoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.VideoCapture1.BDA_Source = null;
            this.VideoCapture1.ChromaKey = null;
            this.VideoCapture1.Custom_Source = null;
            this.VideoCapture1.Debug_Dir = "";
            this.VideoCapture1.Debug_Mode = false;
            this.VideoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.VideoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.VideoCapture1.Decklink_Input_IREUSA = false;
            this.VideoCapture1.Decklink_Input_SMPTE = false;
            this.VideoCapture1.Decklink_Output = null;
            this.VideoCapture1.Decklink_Source = null;
            this.VideoCapture1.DirectCapture_Muxer = null;
            this.VideoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.VideoCapture1.Face_Tracking = null;
            this.VideoCapture1.IP_Camera_Source = null;
            this.VideoCapture1.Location = new System.Drawing.Point(372, 12);
            this.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
            this.VideoCapture1.Motion_Detection = null;
            this.VideoCapture1.MPEG_Audio_Decoder = "";
            this.VideoCapture1.MPEG_Video_Decoder = "";
            this.VideoCapture1.MultiScreen_Enabled = false;
            this.VideoCapture1.Name = "VideoCapture1";
            this.VideoCapture1.Network_Streaming_Audio_Enabled = false;
            this.VideoCapture1.Network_Streaming_Enabled = false;
            this.VideoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.VideoCapture1.Network_Streaming_Network_Port = 100;
            this.VideoCapture1.Network_Streaming_Output = null;
            this.VideoCapture1.Network_Streaming_URL = "";
            this.VideoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.VideoCapture1.Output_Filename = "C:\\Users\\roman\\Documents\\VisioForge\\output.avi";
            this.VideoCapture1.Output_Format = null;
            this.VideoCapture1.PIP_AddSampleGrabbers = false;
            this.VideoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.VideoCapture1.Push_Source = null;
            this.VideoCapture1.Screen_Capture_Source = null;
            this.VideoCapture1.SeparateCapture_AutostartCapture = false;
            this.VideoCapture1.SeparateCapture_Enabled = false;
            this.VideoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.VideoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.VideoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.VideoCapture1.SeparateCapture_TimeThreshold = ((long)(0));
            this.VideoCapture1.Size = new System.Drawing.Size(429, 302);
            this.VideoCapture1.Start_DelayEnabled = false;
            this.VideoCapture1.TabIndex = 0;
            this.VideoCapture1.Tags = null;
            this.VideoCapture1.TVTuner_Channel = 0;
            this.VideoCapture1.TVTuner_Country = "";
            this.VideoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.VideoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.VideoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.VideoCapture1.TVTuner_Frequency = 0;
            this.VideoCapture1.TVTuner_InputType = "";
            this.VideoCapture1.TVTuner_Name = "";
            this.VideoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.VideoCapture1.Video_CaptureDevice = "";
            this.VideoCapture1.Video_CaptureDevice_Format = "";
            this.VideoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.VideoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.VideoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.VideoCapture1.Video_CaptureDevice_Path = null;
            this.VideoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.VideoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.VideoCapture1.Video_Crop = null;
            this.VideoCapture1.Video_Decoder = null;
            this.VideoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.VideoCapture1.Video_Effects_Enabled = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_X = 0;
            videoRendererSettingsWinForms1.Aspect_Ratio_Y = 0;
            videoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            videoRendererSettingsWinForms1.Flip_Horizontal = false;
            videoRendererSettingsWinForms1.Flip_Vertical = false;
            videoRendererSettingsWinForms1.RotationAngle = 0;
            videoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox;
            videoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.VideoRenderer;
            videoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.VideoRenderer;
            videoRendererSettingsWinForms1.Zoom_Ratio = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftX = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftY = 0;
            this.VideoCapture1.Video_Renderer = videoRendererSettingsWinForms1;
            this.VideoCapture1.Video_Resize = null;
            this.VideoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.VideoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoCapture1.Video_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.VideoCapture1.VLC_Path = null;
            this.VideoCapture1.OnError += new System.EventHandler<VisioForge.Types.ErrorsEventArgs>(this.VideoCapture1_OnError);
            this.VideoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoCapture1_OnLicenseRequired);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Much more features available in Main Demo";
            // 
            // rbCaptureMP4
            // 
            this.rbCaptureMP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCaptureMP4.AutoSize = true;
            this.rbCaptureMP4.Location = new System.Drawing.Point(541, 346);
            this.rbCaptureMP4.Name = "rbCaptureMP4";
            this.rbCaptureMP4.Size = new System.Drawing.Size(99, 17);
            this.rbCaptureMP4.TabIndex = 102;
            this.rbCaptureMP4.Text = "Capture to MP4";
            this.rbCaptureMP4.UseVisualStyleBackColor = true;
            // 
            // rbCaptureAVI
            // 
            this.rbCaptureAVI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbCaptureAVI.AutoSize = true;
            this.rbCaptureAVI.Location = new System.Drawing.Point(441, 346);
            this.rbCaptureAVI.Name = "rbCaptureAVI";
            this.rbCaptureAVI.Size = new System.Drawing.Size(94, 17);
            this.rbCaptureAVI.TabIndex = 101;
            this.rbCaptureAVI.Text = "Capture to AVI";
            this.rbCaptureAVI.UseVisualStyleBackColor = true;
            // 
            // rbPreview
            // 
            this.rbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(372, 346);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(63, 17);
            this.rbPreview.TabIndex = 100;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(739, 343);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 99;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(674, 343);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 23);
            this.btStart.TabIndex = 98;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cbLicensing);
            this.groupBox1.Controls.Add(this.cbDebugMode);
            this.groupBox1.Controls.Add(this.mmLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 72);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errors/Warnings";
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(160, 12);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(91, 17);
            this.cbLicensing.TabIndex = 76;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(257, 12);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(87, 17);
            this.cbDebugMode.TabIndex = 75;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            this.mmLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmLog.Location = new System.Drawing.Point(6, 35);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(338, 31);
            this.mmLog.TabIndex = 74;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 276);
            this.tabControl1.TabIndex = 96;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btSelectOutputAVI);
            this.tabPage2.Controls.Add(this.edOutputAVI);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.btAudioSettings);
            this.tabPage2.Controls.Add(this.btVideoSettings);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.cbChannels);
            this.tabPage2.Controls.Add(this.cbBPS);
            this.tabPage2.Controls.Add(this.cbAudioCodecs);
            this.tabPage2.Controls.Add(this.cbSampleRate);
            this.tabPage2.Controls.Add(this.cbVideoCodecs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AVI output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSelectOutputAVI
            // 
            this.btSelectOutputAVI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectOutputAVI.Location = new System.Drawing.Point(320, 7);
            this.btSelectOutputAVI.Name = "btSelectOutputAVI";
            this.btSelectOutputAVI.Size = new System.Drawing.Size(20, 23);
            this.btSelectOutputAVI.TabIndex = 47;
            this.btSelectOutputAVI.Text = "...";
            this.btSelectOutputAVI.UseVisualStyleBackColor = true;
            this.btSelectOutputAVI.Click += new System.EventHandler(this.btSelectOutputAVI_Click);
            // 
            // edOutputAVI
            // 
            this.edOutputAVI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edOutputAVI.Location = new System.Drawing.Point(63, 9);
            this.edOutputAVI.Name = "edOutputAVI";
            this.edOutputAVI.Size = new System.Drawing.Size(247, 20);
            this.edOutputAVI.TabIndex = 46;
            this.edOutputAVI.Text = "c:\\capture.avi";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "File name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 39;
            this.label27.Text = "Audio codec";
            // 
            // btAudioSettings
            // 
            this.btAudioSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAudioSettings.Location = new System.Drawing.Point(276, 66);
            this.btAudioSettings.Name = "btAudioSettings";
            this.btAudioSettings.Size = new System.Drawing.Size(64, 23);
            this.btAudioSettings.TabIndex = 38;
            this.btAudioSettings.Text = "Settings";
            this.btAudioSettings.UseVisualStyleBackColor = true;
            this.btAudioSettings.Click += new System.EventHandler(this.btAudioSettings_Click);
            // 
            // btVideoSettings
            // 
            this.btVideoSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVideoSettings.Location = new System.Drawing.Point(276, 39);
            this.btVideoSettings.Name = "btVideoSettings";
            this.btVideoSettings.Size = new System.Drawing.Size(64, 23);
            this.btVideoSettings.TabIndex = 37;
            this.btVideoSettings.Text = "Settings";
            this.btVideoSettings.UseVisualStyleBackColor = true;
            this.btVideoSettings.Click += new System.EventHandler(this.btVideoSettings_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 125);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 36;
            this.label28.Text = "Sample rate";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(173, 98);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(28, 13);
            this.label29.TabIndex = 35;
            this.label29.Text = "BPS";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(21, 98);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 34;
            this.label30.Text = "Channels";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 33;
            this.label31.Text = "Video codec";
            // 
            // cbChannels
            // 
            this.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbChannels.Location = new System.Drawing.Point(98, 95);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(65, 21);
            this.cbChannels.TabIndex = 32;
            // 
            // cbBPS
            // 
            this.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBPS.FormattingEnabled = true;
            this.cbBPS.Items.AddRange(new object[] {
            "8",
            "16"});
            this.cbBPS.Location = new System.Drawing.Point(207, 95);
            this.cbBPS.Name = "cbBPS";
            this.cbBPS.Size = new System.Drawing.Size(67, 21);
            this.cbBPS.TabIndex = 31;
            // 
            // cbAudioCodecs
            // 
            this.cbAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCodecs.FormattingEnabled = true;
            this.cbAudioCodecs.Location = new System.Drawing.Point(98, 68);
            this.cbAudioCodecs.Name = "cbAudioCodecs";
            this.cbAudioCodecs.Size = new System.Drawing.Size(172, 21);
            this.cbAudioCodecs.TabIndex = 30;
            this.cbAudioCodecs.SelectedIndexChanged += new System.EventHandler(this.cbAudioCodecs_SelectedIndexChanged);
            // 
            // cbSampleRate
            // 
            this.cbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSampleRate.FormattingEnabled = true;
            this.cbSampleRate.Items.AddRange(new object[] {
            "48000",
            "44100",
            "32000",
            "24000",
            "22050",
            "16000",
            "12000",
            "11025",
            "8000"});
            this.cbSampleRate.Location = new System.Drawing.Point(98, 122);
            this.cbSampleRate.Name = "cbSampleRate";
            this.cbSampleRate.Size = new System.Drawing.Size(65, 21);
            this.cbSampleRate.TabIndex = 29;
            // 
            // cbVideoCodecs
            // 
            this.cbVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoCodecs.FormattingEnabled = true;
            this.cbVideoCodecs.Location = new System.Drawing.Point(98, 41);
            this.cbVideoCodecs.Name = "cbVideoCodecs";
            this.cbVideoCodecs.Size = new System.Drawing.Size(172, 21);
            this.cbVideoCodecs.TabIndex = 28;
            this.cbVideoCodecs.SelectedIndexChanged += new System.EventHandler(this.cbVideoCodecs_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MP4 output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(337, 237);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btSelectOutputMP4);
            this.tabPage4.Controls.Add(this.edOutputMP4);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(329, 211);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Main";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btSelectOutputMP4
            // 
            this.btSelectOutputMP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectOutputMP4.Location = new System.Drawing.Point(303, 13);
            this.btSelectOutputMP4.Name = "btSelectOutputMP4";
            this.btSelectOutputMP4.Size = new System.Drawing.Size(20, 23);
            this.btSelectOutputMP4.TabIndex = 50;
            this.btSelectOutputMP4.Text = "...";
            this.btSelectOutputMP4.UseVisualStyleBackColor = true;
            this.btSelectOutputMP4.Click += new System.EventHandler(this.btSelectOutputMP4_Click);
            // 
            // edOutputMP4
            // 
            this.edOutputMP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edOutputMP4.Location = new System.Drawing.Point(66, 15);
            this.edOutputMP4.Name = "edOutputMP4";
            this.edOutputMP4.Size = new System.Drawing.Size(227, 20);
            this.edOutputMP4.TabIndex = 49;
            this.edOutputMP4.Text = "c:\\capture.mp4";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "File name";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox29);
            this.tabPage5.Controls.Add(this.groupBox46);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(329, 211);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Video";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.cbH264GOP);
            this.groupBox29.Controls.Add(this.cbH264AutoBitrate);
            this.groupBox29.Controls.Add(this.label350);
            this.groupBox29.Controls.Add(this.edH264Bitrate);
            this.groupBox29.Controls.Add(this.label351);
            this.groupBox29.Controls.Add(this.cbH264RateControl);
            this.groupBox29.Location = new System.Drawing.Point(6, 109);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(223, 98);
            this.groupBox29.TabIndex = 7;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Bitrate";
            // 
            // cbH264GOP
            // 
            this.cbH264GOP.AutoSize = true;
            this.cbH264GOP.Location = new System.Drawing.Point(166, 78);
            this.cbH264GOP.Name = "cbH264GOP";
            this.cbH264GOP.Size = new System.Drawing.Size(49, 17);
            this.cbH264GOP.TabIndex = 12;
            this.cbH264GOP.Text = "GOP";
            this.cbH264GOP.UseVisualStyleBackColor = true;
            // 
            // cbH264AutoBitrate
            // 
            this.cbH264AutoBitrate.AutoSize = true;
            this.cbH264AutoBitrate.Location = new System.Drawing.Point(10, 78);
            this.cbH264AutoBitrate.Name = "cbH264AutoBitrate";
            this.cbH264AutoBitrate.Size = new System.Drawing.Size(127, 17);
            this.cbH264AutoBitrate.TabIndex = 7;
            this.cbH264AutoBitrate.Text = "Auto configure bitrate";
            this.cbH264AutoBitrate.UseVisualStyleBackColor = true;
            // 
            // label350
            // 
            this.label350.AutoSize = true;
            this.label350.Location = new System.Drawing.Point(6, 53);
            this.label350.Name = "label350";
            this.label350.Size = new System.Drawing.Size(69, 13);
            this.label350.TabIndex = 6;
            this.label350.Text = "Bitrate (kbps)";
            // 
            // edH264Bitrate
            // 
            this.edH264Bitrate.Location = new System.Drawing.Point(94, 52);
            this.edH264Bitrate.Name = "edH264Bitrate";
            this.edH264Bitrate.Size = new System.Drawing.Size(121, 20);
            this.edH264Bitrate.TabIndex = 5;
            this.edH264Bitrate.Text = "2000";
            this.edH264Bitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label351
            // 
            this.label351.AutoSize = true;
            this.label351.Location = new System.Drawing.Point(6, 21);
            this.label351.Name = "label351";
            this.label351.Size = new System.Drawing.Size(65, 13);
            this.label351.TabIndex = 4;
            this.label351.Text = "Rate сontrol";
            // 
            // cbH264RateControl
            // 
            this.cbH264RateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbH264RateControl.FormattingEnabled = true;
            this.cbH264RateControl.Items.AddRange(new object[] {
            "CBR",
            "VBR"});
            this.cbH264RateControl.Location = new System.Drawing.Point(94, 19);
            this.cbH264RateControl.Name = "cbH264RateControl";
            this.cbH264RateControl.Size = new System.Drawing.Size(121, 21);
            this.cbH264RateControl.TabIndex = 3;
            // 
            // groupBox46
            // 
            this.groupBox46.Controls.Add(this.cbH264TargetUsage);
            this.groupBox46.Controls.Add(this.label359);
            this.groupBox46.Controls.Add(this.label352);
            this.groupBox46.Controls.Add(this.label353);
            this.groupBox46.Controls.Add(this.cbH264Level);
            this.groupBox46.Controls.Add(this.cbH264Profile);
            this.groupBox46.Location = new System.Drawing.Point(6, 6);
            this.groupBox46.Name = "groupBox46";
            this.groupBox46.Size = new System.Drawing.Size(223, 97);
            this.groupBox46.TabIndex = 6;
            this.groupBox46.TabStop = false;
            this.groupBox46.Text = "Profile settings";
            // 
            // cbH264TargetUsage
            // 
            this.cbH264TargetUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbH264TargetUsage.FormattingEnabled = true;
            this.cbH264TargetUsage.Items.AddRange(new object[] {
            "Auto",
            "Best quality",
            "Balanced",
            "Best speed"});
            this.cbH264TargetUsage.Location = new System.Drawing.Point(94, 73);
            this.cbH264TargetUsage.Name = "cbH264TargetUsage";
            this.cbH264TargetUsage.Size = new System.Drawing.Size(121, 21);
            this.cbH264TargetUsage.TabIndex = 5;
            // 
            // label359
            // 
            this.label359.AutoSize = true;
            this.label359.Location = new System.Drawing.Point(7, 76);
            this.label359.Name = "label359";
            this.label359.Size = new System.Drawing.Size(70, 13);
            this.label359.TabIndex = 4;
            this.label359.Text = "Target usage";
            // 
            // label352
            // 
            this.label352.AutoSize = true;
            this.label352.Location = new System.Drawing.Point(7, 49);
            this.label352.Name = "label352";
            this.label352.Size = new System.Drawing.Size(33, 13);
            this.label352.TabIndex = 3;
            this.label352.Text = "Level";
            // 
            // label353
            // 
            this.label353.AutoSize = true;
            this.label353.Location = new System.Drawing.Point(7, 22);
            this.label353.Name = "label353";
            this.label353.Size = new System.Drawing.Size(36, 13);
            this.label353.TabIndex = 2;
            this.label353.Text = "Profile";
            // 
            // cbH264Level
            // 
            this.cbH264Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbH264Level.FormattingEnabled = true;
            this.cbH264Level.Items.AddRange(new object[] {
            "Auto",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "2.0",
            "2.1",
            "2.2",
            "3.0",
            "3.1",
            "3.2",
            "4.0",
            "4.1",
            "4.2",
            "5.0",
            "5.1"});
            this.cbH264Level.Location = new System.Drawing.Point(94, 46);
            this.cbH264Level.Name = "cbH264Level";
            this.cbH264Level.Size = new System.Drawing.Size(121, 21);
            this.cbH264Level.TabIndex = 1;
            // 
            // cbH264Profile
            // 
            this.cbH264Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbH264Profile.FormattingEnabled = true;
            this.cbH264Profile.Items.AddRange(new object[] {
            "Auto",
            "Baseline",
            "Main",
            "High",
            "High 10",
            "High 422"});
            this.cbH264Profile.Location = new System.Drawing.Point(94, 19);
            this.cbH264Profile.Name = "cbH264Profile";
            this.cbH264Profile.Size = new System.Drawing.Size(121, 21);
            this.cbH264Profile.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label354);
            this.tabPage6.Controls.Add(this.cbAACOutput);
            this.tabPage6.Controls.Add(this.label355);
            this.tabPage6.Controls.Add(this.cbAACBitrate);
            this.tabPage6.Controls.Add(this.label356);
            this.tabPage6.Controls.Add(this.cbAACObjectType);
            this.tabPage6.Controls.Add(this.label357);
            this.tabPage6.Controls.Add(this.cbAACVersion);
            this.tabPage6.Controls.Add(this.label358);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(329, 211);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Audio";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label354
            // 
            this.label354.AutoSize = true;
            this.label354.Location = new System.Drawing.Point(230, 88);
            this.label354.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label354.Name = "label354";
            this.label354.Size = new System.Drawing.Size(31, 13);
            this.label354.TabIndex = 17;
            this.label354.Text = "Kbps";
            // 
            // cbAACOutput
            // 
            this.cbAACOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAACOutput.FormattingEnabled = true;
            this.cbAACOutput.Items.AddRange(new object[] {
            "RAW",
            "ADTS"});
            this.cbAACOutput.Location = new System.Drawing.Point(105, 124);
            this.cbAACOutput.Margin = new System.Windows.Forms.Padding(2);
            this.cbAACOutput.Name = "cbAACOutput";
            this.cbAACOutput.Size = new System.Drawing.Size(156, 21);
            this.cbAACOutput.TabIndex = 16;
            // 
            // label355
            // 
            this.label355.AutoSize = true;
            this.label355.Location = new System.Drawing.Point(12, 126);
            this.label355.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label355.Name = "label355";
            this.label355.Size = new System.Drawing.Size(39, 13);
            this.label355.TabIndex = 15;
            this.label355.Text = "Output";
            // 
            // cbAACBitrate
            // 
            this.cbAACBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAACBitrate.FormattingEnabled = true;
            this.cbAACBitrate.Items.AddRange(new object[] {
            "32",
            "40",
            "48",
            "56",
            "64",
            "72",
            "80",
            "88",
            "96",
            "104",
            "112",
            "120",
            "128",
            "140",
            "160",
            "192",
            "224",
            "256"});
            this.cbAACBitrate.Location = new System.Drawing.Point(105, 86);
            this.cbAACBitrate.Margin = new System.Windows.Forms.Padding(2);
            this.cbAACBitrate.Name = "cbAACBitrate";
            this.cbAACBitrate.Size = new System.Drawing.Size(121, 21);
            this.cbAACBitrate.TabIndex = 14;
            // 
            // label356
            // 
            this.label356.AutoSize = true;
            this.label356.Location = new System.Drawing.Point(12, 88);
            this.label356.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label356.Name = "label356";
            this.label356.Size = new System.Drawing.Size(37, 13);
            this.label356.TabIndex = 13;
            this.label356.Text = "Bitrate";
            // 
            // cbAACObjectType
            // 
            this.cbAACObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAACObjectType.FormattingEnabled = true;
            this.cbAACObjectType.Items.AddRange(new object[] {
            "Main",
            "Low complexity",
            "Scalable Sampling Rate",
            "Long Term Predictor"});
            this.cbAACObjectType.Location = new System.Drawing.Point(105, 50);
            this.cbAACObjectType.Margin = new System.Windows.Forms.Padding(2);
            this.cbAACObjectType.Name = "cbAACObjectType";
            this.cbAACObjectType.Size = new System.Drawing.Size(156, 21);
            this.cbAACObjectType.TabIndex = 12;
            // 
            // label357
            // 
            this.label357.AutoSize = true;
            this.label357.Location = new System.Drawing.Point(12, 52);
            this.label357.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label357.Name = "label357";
            this.label357.Size = new System.Drawing.Size(61, 13);
            this.label357.TabIndex = 11;
            this.label357.Text = "Object type";
            // 
            // cbAACVersion
            // 
            this.cbAACVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAACVersion.FormattingEnabled = true;
            this.cbAACVersion.Items.AddRange(new object[] {
            "MPEG-4",
            "MPEG-2"});
            this.cbAACVersion.Location = new System.Drawing.Point(105, 15);
            this.cbAACVersion.Margin = new System.Windows.Forms.Padding(2);
            this.cbAACVersion.Name = "cbAACVersion";
            this.cbAACVersion.Size = new System.Drawing.Size(156, 21);
            this.cbAACVersion.TabIndex = 10;
            // 
            // label358
            // 
            this.label358.AutoSize = true;
            this.label358.Location = new System.Drawing.Point(12, 18);
            this.label358.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label358.Name = "label358";
            this.label358.Size = new System.Drawing.Size(75, 13);
            this.label358.TabIndex = 9;
            this.label358.Text = "MPEG version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sample images used in this demo. In real application you can push";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = ".Net Bitmap class frames";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCaptureMP4);
            this.Controls.Add(this.rbCaptureAVI);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.VideoCapture1);
            this.Name = "Form1";
            this.Text = "VisioForge Video Capture SDK .Net Push Source Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox46.ResumeLayout(false);
            this.groupBox46.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCaptureMP4;
        private System.Windows.Forms.RadioButton rbCaptureAVI;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLicensing;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btSelectOutputAVI;
        private System.Windows.Forms.TextBox edOutputAVI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btAudioSettings;
        private System.Windows.Forms.Button btVideoSettings;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.ComboBox cbBPS;
        private System.Windows.Forms.ComboBox cbAudioCodecs;
        private System.Windows.Forms.ComboBox cbSampleRate;
        private System.Windows.Forms.ComboBox cbVideoCodecs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btSelectOutputMP4;
        private System.Windows.Forms.TextBox edOutputMP4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.CheckBox cbH264GOP;
        private System.Windows.Forms.CheckBox cbH264AutoBitrate;
        private System.Windows.Forms.Label label350;
        private System.Windows.Forms.TextBox edH264Bitrate;
        private System.Windows.Forms.Label label351;
        private System.Windows.Forms.ComboBox cbH264RateControl;
        private System.Windows.Forms.GroupBox groupBox46;
        private System.Windows.Forms.ComboBox cbH264TargetUsage;
        private System.Windows.Forms.Label label359;
        private System.Windows.Forms.Label label352;
        private System.Windows.Forms.Label label353;
        private System.Windows.Forms.ComboBox cbH264Level;
        private System.Windows.Forms.ComboBox cbH264Profile;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label354;
        private System.Windows.Forms.ComboBox cbAACOutput;
        private System.Windows.Forms.Label label355;
        private System.Windows.Forms.ComboBox cbAACBitrate;
        private System.Windows.Forms.Label label356;
        private System.Windows.Forms.ComboBox cbAACObjectType;
        private System.Windows.Forms.Label label357;
        private System.Windows.Forms.ComboBox cbAACVersion;
        private System.Windows.Forms.Label label358;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

