using VisioForge.Types;

namespace Kinect_Demo
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

            if (kinect != null)
            {
                kinect.Dispose();
                kinect = null;
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
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElevationAngle = new System.Windows.Forms.TrackBar();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKinectDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepthSourceFormat = new System.Windows.Forms.ComboBox();
            this.cbVideoSourceFormat = new System.Windows.Forms.ComboBox();
            this.rbUseDepthSource = new System.Windows.Forms.RadioButton();
            this.rbUseVideoSource = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edGestures = new System.Windows.Forms.TextBox();
            this.cbDetectGestures = new System.Windows.Forms.CheckBox();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.rbCaptureMP4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAudioCaptureFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAudioCaptureDevice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbElevationAngle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(15, 314);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(96, 314);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elevation angle";
            // 
            // tbElevationAngle
            // 
            this.tbElevationAngle.Location = new System.Drawing.Point(644, 225);
            this.tbElevationAngle.Name = "tbElevationAngle";
            this.tbElevationAngle.Size = new System.Drawing.Size(208, 45);
            this.tbElevationAngle.TabIndex = 4;
            this.tbElevationAngle.Scroll += new System.EventHandler(this.tbElevationAngle_Scroll);
            // 
            // VideoCapture1
            // 
            this.VideoCapture1.Audio_CaptureDevice = "";
            this.VideoCapture1.Audio_Decoder = null;
            this.VideoCapture1.Audio_Effects_Enabled = false;
            this.VideoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.VideoCapture1.Audio_PlayAudio = true;
            this.VideoCapture1.Audio_RecordAudio = true;
            this.VideoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Audio_VUMeter_Enabled = false;
            this.VideoCapture1.BackColor = System.Drawing.Color.Black;
            this.VideoCapture1.Barcode_Reader_Enabled = false;
            this.VideoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.VideoCapture1.Debug_Dir = "";
            this.VideoCapture1.Debug_Mode = false;
            this.VideoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.VideoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.VideoCapture1.Decklink_Input_IREUSA = false;
            this.VideoCapture1.Decklink_Input_SMPTE = false;
            this.VideoCapture1.DirectCapture_Muxer = null;
            this.VideoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.VideoCapture1.Location = new System.Drawing.Point(12, 12);
            this.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
            this.VideoCapture1.MPEG_Audio_Decoder = "";
            this.VideoCapture1.MPEG_Video_Decoder = "";
            this.VideoCapture1.MultiScreen_Enabled = false;
            this.VideoCapture1.Name = "VideoCapture1";
            this.VideoCapture1.Network_Streaming_Audio_Enabled = false;
            this.VideoCapture1.Network_Streaming_Enabled = false;
            this.VideoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.VideoCapture1.Network_Streaming_Network_Port = 100;
            this.VideoCapture1.Network_Streaming_URL = "";
            this.VideoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.VideoCapture1.Output_Filename = "";
            this.VideoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.VideoCapture1.SeparateCapture_AutostartCapture = false;
            this.VideoCapture1.SeparateCapture_Enabled = false;
            this.VideoCapture1.Size = new System.Drawing.Size(405, 288);
            this.VideoCapture1.TabIndex = 0;
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
            this.VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.VideoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.VideoCapture1.Video_CaptureDevice_Path = null;
            this.VideoCapture1.Video_Decoder = null;
            this.VideoCapture1.Video_Effects_Enabled = false;
            this.VideoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.VideoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoCapture1.Video_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_Enabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKinectDevice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDepthSourceFormat);
            this.groupBox1.Controls.Add(this.cbVideoSourceFormat);
            this.groupBox1.Controls.Add(this.rbUseDepthSource);
            this.groupBox1.Controls.Add(this.rbUseVideoSource);
            this.groupBox1.Location = new System.Drawing.Point(434, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 189);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video source";
            // 
            // cbKinectDevice
            // 
            this.cbKinectDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKinectDevice.FormattingEnabled = true;
            this.cbKinectDevice.Location = new System.Drawing.Point(13, 41);
            this.cbKinectDevice.Name = "cbKinectDevice";
            this.cbKinectDevice.Size = new System.Drawing.Size(174, 21);
            this.cbKinectDevice.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kinect device ID";
            // 
            // cbDepthSourceFormat
            // 
            this.cbDepthSourceFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepthSourceFormat.FormattingEnabled = true;
            this.cbDepthSourceFormat.Items.AddRange(new object[] {
            "640 x 480 x 30 FPS",
            "320 x 240 x 30 FPS",
            "80 x 60 x 30 FPS"});
            this.cbDepthSourceFormat.Location = new System.Drawing.Point(13, 159);
            this.cbDepthSourceFormat.Name = "cbDepthSourceFormat";
            this.cbDepthSourceFormat.Size = new System.Drawing.Size(174, 21);
            this.cbDepthSourceFormat.TabIndex = 14;
            // 
            // cbVideoSourceFormat
            // 
            this.cbVideoSourceFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoSourceFormat.FormattingEnabled = true;
            this.cbVideoSourceFormat.Items.AddRange(new object[] {
            "RGB32 640 x 480 x 30 FPS",
            "RGB32 1280 x 960 x 12 FPS"});
            this.cbVideoSourceFormat.Location = new System.Drawing.Point(13, 109);
            this.cbVideoSourceFormat.Name = "cbVideoSourceFormat";
            this.cbVideoSourceFormat.Size = new System.Drawing.Size(174, 21);
            this.cbVideoSourceFormat.TabIndex = 13;
            // 
            // rbUseDepthSource
            // 
            this.rbUseDepthSource.AutoSize = true;
            this.rbUseDepthSource.Location = new System.Drawing.Point(13, 136);
            this.rbUseDepthSource.Name = "rbUseDepthSource";
            this.rbUseDepthSource.Size = new System.Drawing.Size(109, 17);
            this.rbUseDepthSource.TabIndex = 12;
            this.rbUseDepthSource.Text = "Use depth source";
            this.rbUseDepthSource.UseVisualStyleBackColor = true;
            // 
            // rbUseVideoSource
            // 
            this.rbUseVideoSource.AutoSize = true;
            this.rbUseVideoSource.Checked = true;
            this.rbUseVideoSource.Location = new System.Drawing.Point(13, 86);
            this.rbUseVideoSource.Name = "rbUseVideoSource";
            this.rbUseVideoSource.Size = new System.Drawing.Size(108, 17);
            this.rbUseVideoSource.TabIndex = 11;
            this.rbUseVideoSource.TabStop = true;
            this.rbUseVideoSource.Text = "Use video source";
            this.rbUseVideoSource.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edGestures);
            this.groupBox2.Controls.Add(this.cbDetectGestures);
            this.groupBox2.Location = new System.Drawing.Point(644, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 189);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestures";
            // 
            // edGestures
            // 
            this.edGestures.Location = new System.Drawing.Point(16, 43);
            this.edGestures.Multiline = true;
            this.edGestures.Name = "edGestures";
            this.edGestures.Size = new System.Drawing.Size(178, 136);
            this.edGestures.TabIndex = 1;
            // 
            // cbDetectGestures
            // 
            this.cbDetectGestures.AutoSize = true;
            this.cbDetectGestures.Location = new System.Drawing.Point(16, 20);
            this.cbDetectGestures.Name = "cbDetectGestures";
            this.cbDetectGestures.Size = new System.Drawing.Size(101, 17);
            this.cbDetectGestures.TabIndex = 0;
            this.cbDetectGestures.Text = "Detect gestures";
            this.cbDetectGestures.UseVisualStyleBackColor = true;
            this.cbDetectGestures.CheckedChanged += new System.EventHandler(this.cbDetectGestures_CheckedChanged);
            // 
            // rbPreview
            // 
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(193, 317);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(63, 17);
            this.rbPreview.TabIndex = 13;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // rbCaptureMP4
            // 
            this.rbCaptureMP4.AutoSize = true;
            this.rbCaptureMP4.Location = new System.Drawing.Point(262, 317);
            this.rbCaptureMP4.Name = "rbCaptureMP4";
            this.rbCaptureMP4.Size = new System.Drawing.Size(99, 17);
            this.rbCaptureMP4.TabIndex = 14;
            this.rbCaptureMP4.Text = "Capture to MP4";
            this.rbCaptureMP4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAudioCaptureFormat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbAudioCaptureDevice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(434, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 127);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio source";
            // 
            // cbAudioCaptureFormat
            // 
            this.cbAudioCaptureFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCaptureFormat.FormattingEnabled = true;
            this.cbAudioCaptureFormat.Location = new System.Drawing.Point(13, 91);
            this.cbAudioCaptureFormat.Name = "cbAudioCaptureFormat";
            this.cbAudioCaptureFormat.Size = new System.Drawing.Size(174, 21);
            this.cbAudioCaptureFormat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Format";
            // 
            // cbAudioCaptureDevice
            // 
            this.cbAudioCaptureDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCaptureDevice.FormattingEnabled = true;
            this.cbAudioCaptureDevice.Location = new System.Drawing.Point(13, 48);
            this.cbAudioCaptureDevice.Name = "cbAudioCaptureDevice";
            this.cbAudioCaptureDevice.Size = new System.Drawing.Size(174, 21);
            this.cbAudioCaptureDevice.TabIndex = 1;
            this.cbAudioCaptureDevice.SelectedIndexChanged += new System.EventHandler(this.cbAudioCaptureDevice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rbCaptureMP4);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbElevationAngle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.VideoCapture1);
            this.Name = "Form1";
            this.Text = "Video Capture SDK .Net - Kinect Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbElevationAngle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbElevationAngle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDepthSourceFormat;
        private System.Windows.Forms.ComboBox cbVideoSourceFormat;
        private System.Windows.Forms.RadioButton rbUseDepthSource;
        private System.Windows.Forms.RadioButton rbUseVideoSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edGestures;
        private System.Windows.Forms.CheckBox cbDetectGestures;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.RadioButton rbCaptureMP4;
        private System.Windows.Forms.ComboBox cbKinectDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbAudioCaptureFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAudioCaptureDevice;
        private System.Windows.Forms.Label label3;


    }
}

