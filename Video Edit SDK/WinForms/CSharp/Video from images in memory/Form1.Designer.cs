namespace Video_From_Images
{
    using VisioForge.Types;

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
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms14 = new VisioForge.Types.VideoRendererSettingsWinForms();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbConvert = new System.Windows.Forms.RadioButton();
            this.VideoEdit1 = new VisioForge.Controls.UI.WinForms.VideoEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbOutputFormat = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btConfigure = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btSelectOutput = new System.Windows.Forms.Button();
            this.edOutput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrameRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edHeight = new System.Windows.Forms.TextBox();
            this.edWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResize = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.OpenDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbFlipY = new System.Windows.Forms.CheckBox();
            this.cbFlipX = new System.Windows.Forms.CheckBox();
            this.cbInvert = new System.Windows.Forms.CheckBox();
            this.cbGreyscale = new System.Windows.Forms.CheckBox();
            this.label201 = new System.Windows.Forms.Label();
            this.tbDarkness = new System.Windows.Forms.TrackBar();
            this.label200 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.tbLightness = new System.Windows.Forms.TrackBar();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btTextLogoAdd = new System.Windows.Forms.Button();
            this.btLogoRemove = new System.Windows.Forms.Button();
            this.btLogoEdit = new System.Windows.Forms.Button();
            this.lbLogos = new System.Windows.Forms.ListBox();
            this.btImageLogoAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1370, 23);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 25);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Watch tutorials";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rbPreview
            // 
            this.rbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(908, 700);
            this.rbPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(119, 29);
            this.rbPreview.TabIndex = 86;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(1410, 690);
            this.btStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(116, 44);
            this.btStop.TabIndex = 85;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(1276, 690);
            this.btStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(116, 44);
            this.btStart.TabIndex = 84;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(334, 25);
            this.label10.TabIndex = 80;
            this.label10.Text = "Input images located in resources";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar1.Location = new System.Drawing.Point(696, 746);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(830, 44);
            this.ProgressBar1.TabIndex = 79;
            // 
            // rbConvert
            // 
            this.rbConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbConvert.AutoSize = true;
            this.rbConvert.Location = new System.Drawing.Point(696, 700);
            this.rbConvert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbConvert.Name = "rbConvert";
            this.rbConvert.Size = new System.Drawing.Size(176, 29);
            this.rbConvert.TabIndex = 78;
            this.rbConvert.Text = "Convert video";
            this.rbConvert.UseVisualStyleBackColor = true;
            // 
            // VideoEdit1
            // 
            this.VideoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoEdit1.Audio_Channel_Mapper = null;
            this.VideoEdit1.Audio_Effects_Enabled = false;
            this.VideoEdit1.Audio_Effects_UseLegacyEffects = false;
            this.VideoEdit1.Audio_Enhancer_Enabled = false;
            this.VideoEdit1.Audio_Preview_Enabled = false;
            this.VideoEdit1.Audio_VUMeter_Enabled = false;
            this.VideoEdit1.Audio_VUMeter_Pro_Enabled = false;
            this.VideoEdit1.Audio_VUMeter_Pro_Volume = 0;
            this.VideoEdit1.BackColor = System.Drawing.Color.Black;
            this.VideoEdit1.Barcode_Reader_Enabled = false;
            this.VideoEdit1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.VideoEdit1.ChromaKey = null;
            this.VideoEdit1.Debug_Dir = "";
            this.VideoEdit1.Debug_Mode = false;
            this.VideoEdit1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.VideoEdit1.Decklink_Output = null;
            this.VideoEdit1.Dynamic_Reconnection = false;
            this.VideoEdit1.Location = new System.Drawing.Point(696, 65);
            this.VideoEdit1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VideoEdit1.Mode = VisioForge.Types.VFVideoEditMode.Convert;
            this.VideoEdit1.Motion_Detection = null;
            this.VideoEdit1.Motion_DetectionEx = null;
            this.VideoEdit1.Name = "VideoEdit1";
            this.VideoEdit1.Network_Streaming_Audio_Enabled = false;
            this.VideoEdit1.Network_Streaming_Enabled = false;
            this.VideoEdit1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.VideoEdit1.Network_Streaming_Network_Port = 0;
            this.VideoEdit1.Network_Streaming_Output = null;
            this.VideoEdit1.Network_Streaming_URL = null;
            this.VideoEdit1.Network_Streaming_WMV_Maximum_Clients = 0;
            this.VideoEdit1.Output_Filename = "c:\\output.avi";
            this.VideoEdit1.Output_Format = null;
            this.VideoEdit1.Size = new System.Drawing.Size(830, 592);
            this.VideoEdit1.Start_DelayEnabled = false;
            this.VideoEdit1.TabIndex = 91;
            this.VideoEdit1.Tags = null;
            this.VideoEdit1.UseLibMediaInfo = false;
            this.VideoEdit1.Video_Crop = null;
            this.VideoEdit1.Video_Custom_Resizer_CLSID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.VideoEdit1.Video_Effects_AllowMultipleStreams = false;
            this.VideoEdit1.Video_Effects_Enabled = false;
            this.VideoEdit1.Video_FrameRate = 25D;
            this.VideoEdit1.Video_Preview_Enabled = true;
            videoRendererSettingsWinForms14.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms14.Aspect_Ratio_X = 16;
            videoRendererSettingsWinForms14.Aspect_Ratio_Y = 9;
            videoRendererSettingsWinForms14.BackgroundColor = System.Drawing.Color.Black;
            videoRendererSettingsWinForms14.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.Auto;
            videoRendererSettingsWinForms14.Deinterlace_VMR9_Mode = null;
            videoRendererSettingsWinForms14.Deinterlace_VMR9_UseDefault = true;
            videoRendererSettingsWinForms14.Flip_Horizontal = false;
            videoRendererSettingsWinForms14.Flip_Vertical = false;
            videoRendererSettingsWinForms14.RotationAngle = 0;
            videoRendererSettingsWinForms14.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox;
            videoRendererSettingsWinForms14.Video_Renderer = VisioForge.Types.VFVideoRenderer.EVR;
            videoRendererSettingsWinForms14.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.EVR;
            videoRendererSettingsWinForms14.Zoom_Ratio = 0;
            videoRendererSettingsWinForms14.Zoom_ShiftX = 0;
            videoRendererSettingsWinForms14.Zoom_ShiftY = 0;
            this.VideoEdit1.Video_Renderer = videoRendererSettingsWinForms14;
            this.VideoEdit1.Video_Resize = false;
            this.VideoEdit1.Video_Resize_Height = 480;
            this.VideoEdit1.Video_Resize_Width = 640;
            this.VideoEdit1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoEdit1.Video_Subtitles = null;
            this.VideoEdit1.Virtual_Camera_Output_Enabled = false;
            this.VideoEdit1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoEdit1_OnLicenseRequired);
            this.VideoEdit1.OnVideoFrameBitmap += new System.EventHandler<VisioForge.Types.VideoFrameBitmapEventArgs>(this.VideoEdit1_OnVideoFrameBitmap);
            this.VideoEdit1.OnProgress += new System.EventHandler<VisioForge.Types.ProgressEventArgs>(this.VideoEdit1_OnProgress);
            this.VideoEdit1.OnStop += new System.EventHandler<VisioForge.Types.VideoEditStopEventArgs>(this.VideoEdit1_OnStop);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 773);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbOutputFormat);
            this.tabPage1.Controls.Add(this.lbInfo);
            this.tabPage1.Controls.Add(this.btConfigure);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btSelectOutput);
            this.tabPage1.Controls.Add(this.edOutput);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbFrameRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edHeight);
            this.tabPage1.Controls.Add(this.edWidth);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbResize);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(644, 726);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbOutputFormat
            // 
            this.cbOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutputFormat.FormattingEnabled = true;
            this.cbOutputFormat.Items.AddRange(new object[] {
            "AVI",
            "MKV (Matroska)",
            "WMV (Windows Media Video)",
            "DV",
            "WebM",
            "FFMPEG (DLL)",
            "FFMPEG (external exe) (BETA)",
            "MP4 v8/v10",
            "MP4 v11",
            "Animated GIF",
            "Encrypted video"});
            this.cbOutputFormat.Location = new System.Drawing.Point(32, 212);
            this.cbOutputFormat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbOutputFormat.Name = "cbOutputFormat";
            this.cbOutputFormat.Size = new System.Drawing.Size(574, 33);
            this.cbOutputFormat.TabIndex = 123;
            this.cbOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cbOutputFormat_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(26, 273);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(541, 25);
            this.lbInfo.TabIndex = 62;
            this.lbInfo.Text = "You can use dialog or code to configure format settings";
            // 
            // btConfigure
            // 
            this.btConfigure.Location = new System.Drawing.Point(32, 315);
            this.btConfigure.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btConfigure.Name = "btConfigure";
            this.btConfigure.Size = new System.Drawing.Size(122, 44);
            this.btConfigure.TabIndex = 61;
            this.btConfigure.Text = "Configure";
            this.btConfigure.UseVisualStyleBackColor = true;
            this.btConfigure.Click += new System.EventHandler(this.btConfigure_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Format";
            // 
            // btSelectOutput
            // 
            this.btSelectOutput.Location = new System.Drawing.Point(558, 663);
            this.btSelectOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSelectOutput.Name = "btSelectOutput";
            this.btSelectOutput.Size = new System.Drawing.Size(52, 44);
            this.btSelectOutput.TabIndex = 58;
            this.btSelectOutput.Text = "...";
            this.btSelectOutput.UseVisualStyleBackColor = true;
            this.btSelectOutput.Click += new System.EventHandler(this.btSelectOutput_Click);
            // 
            // edOutput
            // 
            this.edOutput.Location = new System.Drawing.Point(148, 667);
            this.edOutput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edOutput.Name = "edOutput";
            this.edOutput.Size = new System.Drawing.Size(394, 31);
            this.edOutput.TabIndex = 57;
            this.edOutput.Text = "c:\\vf\\video_edit_output.avi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 673);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 25);
            this.label15.TabIndex = 56;
            this.label15.Text = "Output file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 610);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "More output formats available in Main Demo";
            // 
            // cbFrameRate
            // 
            this.cbFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrameRate.FormattingEnabled = true;
            this.cbFrameRate.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "12",
            "15",
            "20",
            "25",
            "30"});
            this.cbFrameRate.Location = new System.Drawing.Point(178, 85);
            this.cbFrameRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbFrameRate.Name = "cbFrameRate";
            this.cbFrameRate.Size = new System.Drawing.Size(92, 33);
            this.cbFrameRate.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Frame rate:";
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(322, 27);
            this.edHeight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(92, 31);
            this.edHeight.TabIndex = 49;
            this.edHeight.Text = "576";
            // 
            // edWidth
            // 
            this.edWidth.Location = new System.Drawing.Point(178, 27);
            this.edWidth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edWidth.Name = "edWidth";
            this.edWidth.Size = new System.Drawing.Size(92, 31);
            this.edWidth.TabIndex = 48;
            this.edWidth.Text = "768";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "x";
            // 
            // cbResize
            // 
            this.cbResize.AutoSize = true;
            this.cbResize.Location = new System.Drawing.Point(32, 33);
            this.cbResize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbResize.Name = "cbResize";
            this.cbResize.Size = new System.Drawing.Size(110, 29);
            this.cbResize.TabIndex = 46;
            this.cbResize.Text = "Resize";
            this.cbResize.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbFlipY);
            this.tabPage5.Controls.Add(this.cbFlipX);
            this.tabPage5.Controls.Add(this.cbInvert);
            this.tabPage5.Controls.Add(this.cbGreyscale);
            this.tabPage5.Controls.Add(this.label201);
            this.tabPage5.Controls.Add(this.tbDarkness);
            this.tabPage5.Controls.Add(this.label200);
            this.tabPage5.Controls.Add(this.label199);
            this.tabPage5.Controls.Add(this.label198);
            this.tabPage5.Controls.Add(this.tbContrast);
            this.tabPage5.Controls.Add(this.tbLightness);
            this.tabPage5.Controls.Add(this.tbSaturation);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.btTextLogoAdd);
            this.tabPage5.Controls.Add(this.btLogoRemove);
            this.tabPage5.Controls.Add(this.btLogoEdit);
            this.tabPage5.Controls.Add(this.lbLogos);
            this.tabPage5.Controls.Add(this.btImageLogoAdd);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage5.Size = new System.Drawing.Size(644, 726);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Video processing";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbLicensing);
            this.tabPage2.Controls.Add(this.mmLog);
            this.tabPage2.Controls.Add(this.label120);
            this.tabPage2.Controls.Add(this.cbDebugMode);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(644, 726);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(218, 31);
            this.cbLicensing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(177, 29);
            this.cbLicensing.TabIndex = 97;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            this.mmLog.Location = new System.Drawing.Point(32, 119);
            this.mmLog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(586, 577);
            this.mmLog.TabIndex = 96;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(26, 88);
            this.label120.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(204, 25);
            this.label120.TabIndex = 95;
            this.label120.Text = "Errors and warnings";
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(32, 31);
            this.cbDebugMode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(166, 29);
            this.cbDebugMode.TabIndex = 94;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // OpenDialog1
            // 
            this.OpenDialog1.Filter = resources.GetString("OpenDialog1.Filter");
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Pictures|*.bmp; *.jpg; *.jpeg; *.jpe; *.png; *.gif; *.tiff;|All files|*.*";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.White;
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontDialog1.FontMustExist = true;
            this.fontDialog1.ShowColor = true;
            // 
            // cbFlipY
            // 
            this.cbFlipY.AutoSize = true;
            this.cbFlipY.Location = new System.Drawing.Point(439, 554);
            this.cbFlipY.Margin = new System.Windows.Forms.Padding(6);
            this.cbFlipY.Name = "cbFlipY";
            this.cbFlipY.Size = new System.Drawing.Size(100, 29);
            this.cbFlipY.TabIndex = 123;
            this.cbFlipY.Text = "Flip Y";
            this.cbFlipY.UseVisualStyleBackColor = true;
            this.cbFlipY.CheckedChanged += new System.EventHandler(this.cbFlipY_CheckedChanged);
            // 
            // cbFlipX
            // 
            this.cbFlipX.AutoSize = true;
            this.cbFlipX.Location = new System.Drawing.Point(319, 554);
            this.cbFlipX.Margin = new System.Windows.Forms.Padding(6);
            this.cbFlipX.Name = "cbFlipX";
            this.cbFlipX.Size = new System.Drawing.Size(99, 29);
            this.cbFlipX.TabIndex = 122;
            this.cbFlipX.Text = "Flip X";
            this.cbFlipX.UseVisualStyleBackColor = true;
            this.cbFlipX.CheckedChanged += new System.EventHandler(this.cbFlipX_CheckedChanged);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbInvert.Location = new System.Drawing.Point(199, 554);
            this.cbInvert.Margin = new System.Windows.Forms.Padding(6);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(97, 29);
            this.cbInvert.TabIndex = 121;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            this.cbInvert.CheckedChanged += new System.EventHandler(this.cbInvert_CheckedChanged);
            // 
            // cbGreyscale
            // 
            this.cbGreyscale.AutoSize = true;
            this.cbGreyscale.Location = new System.Drawing.Point(39, 554);
            this.cbGreyscale.Margin = new System.Windows.Forms.Padding(6);
            this.cbGreyscale.Name = "cbGreyscale";
            this.cbGreyscale.Size = new System.Drawing.Size(141, 29);
            this.cbGreyscale.TabIndex = 120;
            this.cbGreyscale.Text = "Greyscale";
            this.cbGreyscale.UseVisualStyleBackColor = true;
            this.cbGreyscale.CheckedChanged += new System.EventHandler(this.cbGreyscale_CheckedChanged);
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(305, 419);
            this.label201.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(103, 25);
            this.label201.TabIndex = 119;
            this.label201.Text = "Darkness";
            // 
            // tbDarkness
            // 
            this.tbDarkness.BackColor = System.Drawing.SystemColors.Window;
            this.tbDarkness.Location = new System.Drawing.Point(305, 456);
            this.tbDarkness.Margin = new System.Windows.Forms.Padding(6);
            this.tbDarkness.Maximum = 255;
            this.tbDarkness.Name = "tbDarkness";
            this.tbDarkness.Size = new System.Drawing.Size(260, 90);
            this.tbDarkness.TabIndex = 118;
            this.tbDarkness.Scroll += new System.EventHandler(this.tbDarkness_Scroll);
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(33, 419);
            this.label200.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(93, 25);
            this.label200.TabIndex = 117;
            this.label200.Text = "Contrast";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(305, 319);
            this.label199.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(110, 25);
            this.label199.TabIndex = 116;
            this.label199.Text = "Saturation";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(33, 319);
            this.label198.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(105, 25);
            this.label198.TabIndex = 115;
            this.label198.Text = "Lightness";
            // 
            // tbContrast
            // 
            this.tbContrast.BackColor = System.Drawing.SystemColors.Window;
            this.tbContrast.Location = new System.Drawing.Point(27, 456);
            this.tbContrast.Margin = new System.Windows.Forms.Padding(6);
            this.tbContrast.Maximum = 255;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(260, 90);
            this.tbContrast.TabIndex = 114;
            this.tbContrast.Scroll += new System.EventHandler(this.tbContrast_Scroll);
            // 
            // tbLightness
            // 
            this.tbLightness.BackColor = System.Drawing.SystemColors.Window;
            this.tbLightness.Location = new System.Drawing.Point(27, 348);
            this.tbLightness.Margin = new System.Windows.Forms.Padding(6);
            this.tbLightness.Maximum = 255;
            this.tbLightness.Name = "tbLightness";
            this.tbLightness.Size = new System.Drawing.Size(260, 90);
            this.tbLightness.TabIndex = 113;
            this.tbLightness.Scroll += new System.EventHandler(this.tbLightness_Scroll);
            // 
            // tbSaturation
            // 
            this.tbSaturation.BackColor = System.Drawing.SystemColors.Window;
            this.tbSaturation.Location = new System.Drawing.Point(305, 348);
            this.tbSaturation.Margin = new System.Windows.Forms.Padding(6);
            this.tbSaturation.Maximum = 255;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(260, 90);
            this.tbSaturation.TabIndex = 112;
            this.tbSaturation.Value = 255;
            this.tbSaturation.Scroll += new System.EventHandler(this.tbSaturation_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "Text / image logos";
            // 
            // btTextLogoAdd
            // 
            this.btTextLogoAdd.Location = new System.Drawing.Point(219, 248);
            this.btTextLogoAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btTextLogoAdd.Name = "btTextLogoAdd";
            this.btTextLogoAdd.Size = new System.Drawing.Size(170, 44);
            this.btTextLogoAdd.TabIndex = 110;
            this.btTextLogoAdd.Text = "Add text logo";
            this.btTextLogoAdd.UseVisualStyleBackColor = true;
            this.btTextLogoAdd.Click += new System.EventHandler(this.btTextLogoAdd_Click);
            // 
            // btLogoRemove
            // 
            this.btLogoRemove.Location = new System.Drawing.Point(519, 248);
            this.btLogoRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btLogoRemove.Name = "btLogoRemove";
            this.btLogoRemove.Size = new System.Drawing.Size(100, 44);
            this.btLogoRemove.TabIndex = 109;
            this.btLogoRemove.Text = "Remove";
            this.btLogoRemove.UseVisualStyleBackColor = true;
            this.btLogoRemove.Click += new System.EventHandler(this.btLogoRemove_Click);
            // 
            // btLogoEdit
            // 
            this.btLogoEdit.Location = new System.Drawing.Point(407, 248);
            this.btLogoEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btLogoEdit.Name = "btLogoEdit";
            this.btLogoEdit.Size = new System.Drawing.Size(100, 44);
            this.btLogoEdit.TabIndex = 108;
            this.btLogoEdit.Text = "Edit";
            this.btLogoEdit.UseVisualStyleBackColor = true;
            this.btLogoEdit.Click += new System.EventHandler(this.btLogoEdit_Click);
            // 
            // lbLogos
            // 
            this.lbLogos.FormattingEnabled = true;
            this.lbLogos.ItemHeight = 25;
            this.lbLogos.Location = new System.Drawing.Point(27, 54);
            this.lbLogos.Margin = new System.Windows.Forms.Padding(6);
            this.lbLogos.Name = "lbLogos";
            this.lbLogos.Size = new System.Drawing.Size(592, 179);
            this.lbLogos.TabIndex = 107;
            // 
            // btImageLogoAdd
            // 
            this.btImageLogoAdd.Location = new System.Drawing.Point(27, 248);
            this.btImageLogoAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btImageLogoAdd.Name = "btImageLogoAdd";
            this.btImageLogoAdd.Size = new System.Drawing.Size(180, 44);
            this.btImageLogoAdd.TabIndex = 106;
            this.btImageLogoAdd.Text = "Add image logo";
            this.btImageLogoAdd.UseVisualStyleBackColor = true;
            this.btImageLogoAdd.Click += new System.EventHandler(this.btImageLogoAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 654);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(484, 25);
            this.label5.TabIndex = 105;
            this.label5.Text = "More effects and settings available in Main Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 808);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.VideoEdit1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.rbConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "VisioForge Video Edit SDK .Net - Video From Images In Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.RadioButton rbConvert;
        private VisioForge.Controls.UI.WinForms.VideoEdit VideoEdit1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbFrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edHeight;
        private System.Windows.Forms.TextBox edWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenDialog1;
        private System.Windows.Forms.Button btSelectOutput;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btConfigure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbLicensing;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.CheckBox cbFlipY;
        private System.Windows.Forms.CheckBox cbFlipX;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.CheckBox cbGreyscale;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.TrackBar tbDarkness;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.TrackBar tbLightness;
        private System.Windows.Forms.TrackBar tbSaturation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTextLogoAdd;
        private System.Windows.Forms.Button btLogoRemove;
        private System.Windows.Forms.Button btLogoEdit;
        private System.Windows.Forms.ListBox lbLogos;
        private System.Windows.Forms.Button btImageLogoAdd;
        private System.Windows.Forms.Label label5;
    }
}

