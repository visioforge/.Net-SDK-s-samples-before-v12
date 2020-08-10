﻿using System;

namespace face_detection
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.cbUseBestVideoInputFormat = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbVideoFrameRate = new System.Windows.Forms.ComboBox();
            this.cbVideoInputFormat = new System.Windows.Forms.ComboBox();
            this.cbVideoInputDevice = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label363 = new System.Windows.Forms.Label();
            this.cbFaceTrackingScalingMode = new System.Windows.Forms.ComboBox();
            this.label362 = new System.Windows.Forms.Label();
            this.edFaceTrackingScaleFactor = new System.Windows.Forms.TextBox();
            this.label361 = new System.Windows.Forms.Label();
            this.cbFaceTrackingSearchMode = new System.Windows.Forms.ComboBox();
            this.cbFaceTrackingColorMode = new System.Windows.Forms.ComboBox();
            this.label346 = new System.Windows.Forms.Label();
            this.edFaceTrackingMinimumWindowSize = new System.Windows.Forms.TextBox();
            this.label345 = new System.Windows.Forms.Label();
            this.cbFaceTrackingCHL = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.edFaceTrackingFaces = new System.Windows.Forms.TextBox();
            this.label364 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbTelemetry = new System.Windows.Forms.CheckBox();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.btResume = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 272);
            this.tabControl1.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.cbUseBestVideoInputFormat);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.cbVideoFrameRate);
            this.tabPage1.Controls.Add(this.cbVideoInputFormat);
            this.tabPage1.Controls.Add(this.cbVideoInputDevice);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(301, 88);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(21, 13);
            this.label28.TabIndex = 127;
            this.label28.Text = "fps";
            // 
            // cbUseBestVideoInputFormat
            // 
            this.cbUseBestVideoInputFormat.AutoSize = true;
            this.cbUseBestVideoInputFormat.Location = new System.Drawing.Point(156, 68);
            this.cbUseBestVideoInputFormat.Name = "cbUseBestVideoInputFormat";
            this.cbUseBestVideoInputFormat.Size = new System.Drawing.Size(68, 17);
            this.cbUseBestVideoInputFormat.TabIndex = 126;
            this.cbUseBestVideoInputFormat.Text = "Use best";
            this.cbUseBestVideoInputFormat.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(227, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 125;
            this.label18.Text = "Frame rate";
            // 
            // cbVideoFrameRate
            // 
            this.cbVideoFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoFrameRate.FormattingEnabled = true;
            this.cbVideoFrameRate.Location = new System.Drawing.Point(230, 85);
            this.cbVideoFrameRate.Name = "cbVideoFrameRate";
            this.cbVideoFrameRate.Size = new System.Drawing.Size(65, 21);
            this.cbVideoFrameRate.TabIndex = 124;
            // 
            // cbVideoInputFormat
            // 
            this.cbVideoInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoInputFormat.FormattingEnabled = true;
            this.cbVideoInputFormat.Location = new System.Drawing.Point(19, 85);
            this.cbVideoInputFormat.Name = "cbVideoInputFormat";
            this.cbVideoInputFormat.Size = new System.Drawing.Size(205, 21);
            this.cbVideoInputFormat.TabIndex = 123;
            // 
            // cbVideoInputDevice
            // 
            this.cbVideoInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoInputDevice.FormattingEnabled = true;
            this.cbVideoInputDevice.Location = new System.Drawing.Point(19, 32);
            this.cbVideoInputDevice.Name = "cbVideoInputDevice";
            this.cbVideoInputDevice.Size = new System.Drawing.Size(205, 21);
            this.cbVideoInputDevice.TabIndex = 122;
            this.cbVideoInputDevice.SelectedIndexChanged += new System.EventHandler(this.cbVideoInputDevice_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Input format";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Input device";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label363);
            this.tabPage2.Controls.Add(this.cbFaceTrackingScalingMode);
            this.tabPage2.Controls.Add(this.label362);
            this.tabPage2.Controls.Add(this.edFaceTrackingScaleFactor);
            this.tabPage2.Controls.Add(this.label361);
            this.tabPage2.Controls.Add(this.cbFaceTrackingSearchMode);
            this.tabPage2.Controls.Add(this.cbFaceTrackingColorMode);
            this.tabPage2.Controls.Add(this.label346);
            this.tabPage2.Controls.Add(this.edFaceTrackingMinimumWindowSize);
            this.tabPage2.Controls.Add(this.label345);
            this.tabPage2.Controls.Add(this.cbFaceTrackingCHL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 246);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label363
            // 
            this.label363.AutoSize = true;
            this.label363.Location = new System.Drawing.Point(14, 194);
            this.label363.Name = "label363";
            this.label363.Size = new System.Drawing.Size(71, 13);
            this.label363.TabIndex = 22;
            this.label363.Text = "Scaling mode";
            // 
            // cbFaceTrackingScalingMode
            // 
            this.cbFaceTrackingScalingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaceTrackingScalingMode.FormattingEnabled = true;
            this.cbFaceTrackingScalingMode.Items.AddRange(new object[] {
            "Greater to smaller",
            "Smaller to greater"});
            this.cbFaceTrackingScalingMode.Location = new System.Drawing.Point(150, 191);
            this.cbFaceTrackingScalingMode.Name = "cbFaceTrackingScalingMode";
            this.cbFaceTrackingScalingMode.Size = new System.Drawing.Size(121, 21);
            this.cbFaceTrackingScalingMode.TabIndex = 21;
            // 
            // label362
            // 
            this.label362.AutoSize = true;
            this.label362.Location = new System.Drawing.Point(14, 157);
            this.label362.Name = "label362";
            this.label362.Size = new System.Drawing.Size(64, 13);
            this.label362.TabIndex = 20;
            this.label362.Text = "Scale factor";
            // 
            // edFaceTrackingScaleFactor
            // 
            this.edFaceTrackingScaleFactor.Location = new System.Drawing.Point(150, 154);
            this.edFaceTrackingScaleFactor.Name = "edFaceTrackingScaleFactor";
            this.edFaceTrackingScaleFactor.Size = new System.Drawing.Size(45, 20);
            this.edFaceTrackingScaleFactor.TabIndex = 19;
            this.edFaceTrackingScaleFactor.Text = "1.2";
            // 
            // label361
            // 
            this.label361.AutoSize = true;
            this.label361.Location = new System.Drawing.Point(14, 119);
            this.label361.Name = "label361";
            this.label361.Size = new System.Drawing.Size(70, 13);
            this.label361.TabIndex = 18;
            this.label361.Text = "Search mode";
            // 
            // cbFaceTrackingSearchMode
            // 
            this.cbFaceTrackingSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaceTrackingSearchMode.FormattingEnabled = true;
            this.cbFaceTrackingSearchMode.Items.AddRange(new object[] {
            "Default",
            "Single",
            "No overlap",
            "Average"});
            this.cbFaceTrackingSearchMode.Location = new System.Drawing.Point(150, 116);
            this.cbFaceTrackingSearchMode.Name = "cbFaceTrackingSearchMode";
            this.cbFaceTrackingSearchMode.Size = new System.Drawing.Size(121, 21);
            this.cbFaceTrackingSearchMode.TabIndex = 17;
            // 
            // cbFaceTrackingColorMode
            // 
            this.cbFaceTrackingColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaceTrackingColorMode.FormattingEnabled = true;
            this.cbFaceTrackingColorMode.Items.AddRange(new object[] {
            "RGB",
            "HSL",
            "Mixed"});
            this.cbFaceTrackingColorMode.Location = new System.Drawing.Point(150, 79);
            this.cbFaceTrackingColorMode.Name = "cbFaceTrackingColorMode";
            this.cbFaceTrackingColorMode.Size = new System.Drawing.Size(121, 21);
            this.cbFaceTrackingColorMode.TabIndex = 16;
            // 
            // label346
            // 
            this.label346.AutoSize = true;
            this.label346.Location = new System.Drawing.Point(14, 82);
            this.label346.Name = "label346";
            this.label346.Size = new System.Drawing.Size(60, 13);
            this.label346.TabIndex = 15;
            this.label346.Text = "Color mode";
            // 
            // edFaceTrackingMinimumWindowSize
            // 
            this.edFaceTrackingMinimumWindowSize.Location = new System.Drawing.Point(150, 45);
            this.edFaceTrackingMinimumWindowSize.Name = "edFaceTrackingMinimumWindowSize";
            this.edFaceTrackingMinimumWindowSize.Size = new System.Drawing.Size(45, 20);
            this.edFaceTrackingMinimumWindowSize.TabIndex = 14;
            this.edFaceTrackingMinimumWindowSize.Text = "25";
            // 
            // label345
            // 
            this.label345.AutoSize = true;
            this.label345.Location = new System.Drawing.Point(14, 48);
            this.label345.Name = "label345";
            this.label345.Size = new System.Drawing.Size(108, 13);
            this.label345.TabIndex = 13;
            this.label345.Text = "Minimum window size";
            // 
            // cbFaceTrackingCHL
            // 
            this.cbFaceTrackingCHL.AutoSize = true;
            this.cbFaceTrackingCHL.Checked = true;
            this.cbFaceTrackingCHL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFaceTrackingCHL.Location = new System.Drawing.Point(17, 18);
            this.cbFaceTrackingCHL.Name = "cbFaceTrackingCHL";
            this.cbFaceTrackingCHL.Size = new System.Drawing.Size(92, 17);
            this.cbFaceTrackingCHL.TabIndex = 12;
            this.cbFaceTrackingCHL.Text = "Color highlight";
            this.cbFaceTrackingCHL.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.edFaceTrackingFaces);
            this.tabPage4.Controls.Add(this.label364);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(375, 246);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Results";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // edFaceTrackingFaces
            // 
            this.edFaceTrackingFaces.Location = new System.Drawing.Point(15, 33);
            this.edFaceTrackingFaces.Multiline = true;
            this.edFaceTrackingFaces.Name = "edFaceTrackingFaces";
            this.edFaceTrackingFaces.Size = new System.Drawing.Size(348, 201);
            this.edFaceTrackingFaces.TabIndex = 15;
            // 
            // label364
            // 
            this.label364.AutoSize = true;
            this.label364.Location = new System.Drawing.Point(12, 14);
            this.label364.Name = "label364";
            this.label364.Size = new System.Drawing.Size(80, 13);
            this.label364.TabIndex = 14;
            this.label364.Text = "Detected faces";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbTelemetry);
            this.tabPage3.Controls.Add(this.cbDebugMode);
            this.tabPage3.Controls.Add(this.mmLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(375, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Debug/Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbTelemetry
            // 
            this.cbTelemetry.AutoSize = true;
            this.cbTelemetry.Checked = true;
            this.cbTelemetry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTelemetry.Location = new System.Drawing.Point(76, 14);
            this.cbTelemetry.Name = "cbTelemetry";
            this.cbTelemetry.Size = new System.Drawing.Size(72, 17);
            this.cbTelemetry.TabIndex = 81;
            this.cbTelemetry.Text = "Telemetry";
            this.cbTelemetry.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(12, 14);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(58, 17);
            this.cbDebugMode.TabIndex = 79;
            this.cbDebugMode.Text = "Debug";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            this.mmLog.Location = new System.Drawing.Point(12, 37);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(352, 200);
            this.mmLog.TabIndex = 78;
            // 
            // btResume
            // 
            this.btResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResume.Location = new System.Drawing.Point(334, 290);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(55, 23);
            this.btResume.TabIndex = 82;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btPause
            // 
            this.btPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPause.Location = new System.Drawing.Point(273, 290);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(55, 23);
            this.btPause.TabIndex = 81;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(76, 290);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 80;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(11, 290);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 23);
            this.btStart.TabIndex = 79;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // VideoCapture1
            // 
            this.VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.VideoCapture1.Audio_CaptureDevice = "";
            this.VideoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.VideoCapture1.Audio_CaptureDevice_Format = "";
            this.VideoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.VideoCapture1.Audio_CaptureDevice_Line = "";
            this.VideoCapture1.Audio_CaptureDevice_MasterDevice = null;
            this.VideoCapture1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.VideoCapture1.Audio_CaptureDevice_Path = null;
            this.VideoCapture1.Audio_CaptureSourceFilter = null;
            this.VideoCapture1.Audio_Channel_Mapper = null;
            this.VideoCapture1.Audio_Decoder = null;
            this.VideoCapture1.Audio_Effects_Enabled = false;
            this.VideoCapture1.Audio_Effects_UseLegacyEffects = false;
            this.VideoCapture1.Audio_Enhancer_Enabled = false;
            this.VideoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.VideoCapture1.Audio_PCM_Converter = null;
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
            this.VideoCapture1.CustomRedist_Enabled = false;
            this.VideoCapture1.CustomRedist_Path = null;
            this.VideoCapture1.Debug_Dir = "";
            this.VideoCapture1.Debug_Mode = false;
            this.VideoCapture1.Debug_Telemetry = false;
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
            this.VideoCapture1.Location = new System.Drawing.Point(400, 12);
            this.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.VideoCapture1.Motion_Detection = null;
            this.VideoCapture1.Motion_DetectionEx = null;
            this.VideoCapture1.MPEG_Audio_Decoder = "";
            this.VideoCapture1.MPEG_Demuxer = null;
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
            this.VideoCapture1.OSD_Enabled = false;
            this.VideoCapture1.Output_Filename = "C:\\Users\\roman\\Documents\\VisioForge\\output.avi";
            this.VideoCapture1.Output_Format = null;
            this.VideoCapture1.PIP_AddSampleGrabbers = false;
            this.VideoCapture1.PIP_ChromaKeySettings = null;
            this.VideoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.VideoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.VideoCapture1.Push_Source = null;
            this.VideoCapture1.Screen_Capture_Source = null;
            this.VideoCapture1.SeparateCapture_AutostartCapture = false;
            this.VideoCapture1.SeparateCapture_Enabled = false;
            this.VideoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.VideoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.VideoCapture1.SeparateCapture_GMFMode = true;
            this.VideoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.VideoCapture1.SeparateCapture_TimeThreshold = TimeSpan.Zero;
            this.VideoCapture1.Size = new System.Drawing.Size(402, 301);
            this.VideoCapture1.Start_DelayEnabled = false;
            this.VideoCapture1.TabIndex = 78;
            this.VideoCapture1.Tags = null;
            this.VideoCapture1.Timeshift_Settings = null;
            this.VideoCapture1.TVTuner_Channel = 0;
            this.VideoCapture1.TVTuner_Country = "";
            this.VideoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.VideoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.VideoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.VideoCapture1.TVTuner_Frequency = 0;
            this.VideoCapture1.TVTuner_InputType = "";
            this.VideoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
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
            this.VideoCapture1.Video_Effects_GPU_Enabled = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_X = 16;
            videoRendererSettingsWinForms1.Aspect_Ratio_Y = 9;
            videoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black;
            videoRendererSettingsWinForms1.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.Auto;
            videoRendererSettingsWinForms1.Deinterlace_VMR9_Mode = null;
            videoRendererSettingsWinForms1.Deinterlace_VMR9_UseDefault = true;
            videoRendererSettingsWinForms1.Flip_Horizontal = false;
            videoRendererSettingsWinForms1.Flip_Vertical = false;
            videoRendererSettingsWinForms1.RotationAngle = 0;
            videoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox;
            videoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.EVR;
            videoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.EVR;
            videoRendererSettingsWinForms1.Zoom_Ratio = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftX = 0;
            videoRendererSettingsWinForms1.Zoom_ShiftY = 0;
            this.VideoCapture1.Video_Renderer = videoRendererSettingsWinForms1;
            this.VideoCapture1.Video_Resize = null;
            this.VideoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.VideoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoCapture1.Video_Sample_Grabber_Enabled = true;
            this.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.VideoCapture1.VLC_Path = null;
            this.VideoCapture1.OnError += new System.EventHandler<VisioForge.Types.ErrorsEventArgs>(this.VideoCapture1_OnError);
            this.VideoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoCapture1_OnLicenseRequired);
            this.VideoCapture1.OnFaceDetected += new System.EventHandler<VisioForge.Types.AFFaceDetectionEventArgs>(this.VideoCapture1_OnFaceDetected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 325);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.VideoCapture1);
            this.Name = "Form1";
            this.Text = "Face Detection Code Snippet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cbUseBestVideoInputFormat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbVideoFrameRate;
        private System.Windows.Forms.ComboBox cbVideoInputFormat;
        private System.Windows.Forms.ComboBox cbVideoInputDevice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbTelemetry;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label363;
        private System.Windows.Forms.ComboBox cbFaceTrackingScalingMode;
        private System.Windows.Forms.Label label362;
        private System.Windows.Forms.TextBox edFaceTrackingScaleFactor;
        private System.Windows.Forms.Label label361;
        private System.Windows.Forms.ComboBox cbFaceTrackingSearchMode;
        private System.Windows.Forms.ComboBox cbFaceTrackingColorMode;
        private System.Windows.Forms.Label label346;
        private System.Windows.Forms.TextBox edFaceTrackingMinimumWindowSize;
        private System.Windows.Forms.Label label345;
        private System.Windows.Forms.CheckBox cbFaceTrackingCHL;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox edFaceTrackingFaces;
        private System.Windows.Forms.Label label364;
    }
}

