using VisioForge.Types;

namespace multiple_ap_cams
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
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.videoCapture2 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbCamera1 = new System.Windows.Forms.ComboBox();
            this.cbCamera2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Location = new System.Drawing.Point(12, 12);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.Output_Filename = "";
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = ((long)(0));
            this.videoCapture1.Size = new System.Drawing.Size(295, 228);
            this.videoCapture1.TabIndex = 0;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = false;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.VLC_Path = null;
            this.videoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.videoCapture1_OnLicenseRequired);
            // 
            // videoCapture2
            // 
            this.videoCapture2.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture2.Audio_CaptureDevice = "";
            this.videoCapture2.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture2.Audio_CaptureDevice_Format = "";
            this.videoCapture2.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture2.Audio_CaptureDevice_Line = "";
            this.videoCapture2.Audio_Decoder = null;
            this.videoCapture2.Audio_Effects_Enabled = false;
            this.videoCapture2.Audio_Enhancer_Enabled = false;
            this.videoCapture2.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture2.Audio_PlayAudio = true;
            this.videoCapture2.Audio_RecordAudio = true;
            this.videoCapture2.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture2.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture2.BackColor = System.Drawing.Color.Black;
            this.videoCapture2.Barcode_Reader_Enabled = false;
            this.videoCapture2.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture2.Debug_Dir = "";
            this.videoCapture2.Debug_Mode = false;
            this.videoCapture2.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture2.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture2.Decklink_Input_IREUSA = false;
            this.videoCapture2.Decklink_Input_SMPTE = false;
            this.videoCapture2.DirectCapture_Muxer = null;
            this.videoCapture2.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture2.Location = new System.Drawing.Point(331, 12);
            this.videoCapture2.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
            this.videoCapture2.MPEG_Audio_Decoder = "";
            this.videoCapture2.MPEG_Video_Decoder = "";
            this.videoCapture2.MultiScreen_Enabled = false;
            this.videoCapture2.Name = "videoCapture2";
            this.videoCapture2.Network_Streaming_Audio_Enabled = false;
            this.videoCapture2.Network_Streaming_Enabled = false;
            this.videoCapture2.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture2.Network_Streaming_Network_Port = 100;
            this.videoCapture2.Network_Streaming_URL = "";
            this.videoCapture2.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture2.Output_Filename = "";
            this.videoCapture2.PIP_AddSampleGrabbers = false;
            this.videoCapture2.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture2.SeparateCapture_AutostartCapture = false;
            this.videoCapture2.SeparateCapture_Enabled = false;
            this.videoCapture2.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture2.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture2.SeparateCapture_TimeThreshold = ((long)(0));
            this.videoCapture2.Size = new System.Drawing.Size(295, 228);
            this.videoCapture2.TabIndex = 1;
            this.videoCapture2.TVTuner_Channel = 0;
            this.videoCapture2.TVTuner_Country = "";
            this.videoCapture2.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture2.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture2.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture2.TVTuner_Frequency = 0;
            this.videoCapture2.TVTuner_InputType = "";
            this.videoCapture2.TVTuner_Name = "";
            this.videoCapture2.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture2.Video_CaptureDevice = "";
            this.videoCapture2.Video_CaptureDevice_Format = "";
            this.videoCapture2.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture2.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture2.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture2.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture2.Video_CaptureDevice_Path = null;
            this.videoCapture2.Video_Decoder = null;
            this.videoCapture2.Video_Effects_Enabled = false;
            this.videoCapture2.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture2.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture2.Video_Sample_Grabber_Enabled = false;
            this.videoCapture2.Video_Sample_Grabber_UseForVideoEffects = false;
            this.videoCapture2.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture2.Virtual_Camera_Output_Enabled = false;
            this.videoCapture2.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture2.VLC_Path = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbCamera1
            // 
            this.cbCamera1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera1.FormattingEnabled = true;
            this.cbCamera1.Location = new System.Drawing.Point(12, 245);
            this.cbCamera1.Name = "cbCamera1";
            this.cbCamera1.Size = new System.Drawing.Size(295, 21);
            this.cbCamera1.TabIndex = 6;
            // 
            // cbCamera2
            // 
            this.cbCamera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera2.FormattingEnabled = true;
            this.cbCamera2.Location = new System.Drawing.Point(331, 245);
            this.cbCamera2.Name = "cbCamera2";
            this.cbCamera2.Size = new System.Drawing.Size(295, 21);
            this.cbCamera2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 304);
            this.Controls.Add(this.cbCamera2);
            this.Controls.Add(this.cbCamera1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoCapture2);
            this.Controls.Add(this.videoCapture1);
            this.Name = "Form1";
            this.Text = "Video Capture SDK .Net - Multiple web cameras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbCamera1;
        private System.Windows.Forms.ComboBox cbCamera2;
    }
}

