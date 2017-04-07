namespace VisioForge_SDK_4_IP_Camera_CSharp_Demo
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
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms3 = new VisioForge.Types.VideoRendererSettingsWinForms();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl15 = new System.Windows.Forms.TabControl();
            this.tabPage144 = new System.Windows.Forms.TabPage();
            this.cbIPCameraONVIF = new System.Windows.Forms.CheckBox();
            this.btShowIPCamDatabase = new System.Windows.Forms.Button();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.cbIPDisconnect = new System.Windows.Forms.CheckBox();
            this.edIPForcedFramerateID = new System.Windows.Forms.TextBox();
            this.label344 = new System.Windows.Forms.Label();
            this.edIPForcedFramerate = new System.Windows.Forms.TextBox();
            this.label295 = new System.Windows.Forms.Label();
            this.cbIPCameraType = new System.Windows.Forms.ComboBox();
            this.edIPPassword = new System.Windows.Forms.TextBox();
            this.label167 = new System.Windows.Forms.Label();
            this.edIPLogin = new System.Windows.Forms.TextBox();
            this.label166 = new System.Windows.Forms.Label();
            this.cbIPAudioCapture = new System.Windows.Forms.CheckBox();
            this.label168 = new System.Windows.Forms.Label();
            this.tabPage146 = new System.Windows.Forms.TabPage();
            this.cbVLCZeroClockJitter = new System.Windows.Forms.CheckBox();
            this.edVLCCacheSize = new System.Windows.Forms.TextBox();
            this.label312 = new System.Windows.Forms.Label();
            this.tabPage145 = new System.Windows.Forms.TabPage();
            this.edONVIFLiveVideoURL = new System.Windows.Forms.TextBox();
            this.label513 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.btONVIFPTZSetDefault = new System.Windows.Forms.Button();
            this.btONVIFRight = new System.Windows.Forms.Button();
            this.btONVIFLeft = new System.Windows.Forms.Button();
            this.btONVIFZoomOut = new System.Windows.Forms.Button();
            this.btONVIFZoomIn = new System.Windows.Forms.Button();
            this.btONVIFDown = new System.Windows.Forms.Button();
            this.btONVIFUp = new System.Windows.Forms.Button();
            this.cbONVIFProfile = new System.Windows.Forms.ComboBox();
            this.label510 = new System.Windows.Forms.Label();
            this.lbONVIFCameraInfo = new System.Windows.Forms.Label();
            this.btONVIFConnect = new System.Windows.Forms.Button();
            this.edIPUrl = new System.Windows.Forms.TextBox();
            this.label165 = new System.Windows.Forms.Label();
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
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.cbImageType = new System.Windows.Forms.ComboBox();
            this.lbJPEGQuality = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btSaveScreenshot = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.edScreenshotsFolder = new System.Windows.Forms.TextBox();
            this.tbJPEGQuality = new System.Windows.Forms.TrackBar();
            this.rbCaptureAVI = new System.Windows.Forms.RadioButton();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.llVideoTutorials = new System.Windows.Forms.LinkLabel();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.rbCaptureMP4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl15.SuspendLayout();
            this.tabPage144.SuspendLayout();
            this.tabPage146.SuspendLayout();
            this.tabPage145.SuspendLayout();
            this.groupBox42.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox46.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJPEGQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 352);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl15);
            this.tabPage1.Controls.Add(this.edIPUrl);
            this.tabPage1.Controls.Add(this.label165);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl15
            // 
            this.tabControl15.Controls.Add(this.tabPage144);
            this.tabControl15.Controls.Add(this.tabPage146);
            this.tabControl15.Controls.Add(this.tabPage145);
            this.tabControl15.Location = new System.Drawing.Point(8, 38);
            this.tabControl15.Name = "tabControl15";
            this.tabControl15.SelectedIndex = 0;
            this.tabControl15.Size = new System.Drawing.Size(447, 282);
            this.tabControl15.TabIndex = 65;
            // 
            // tabPage144
            // 
            this.tabPage144.Controls.Add(this.cbIPCameraONVIF);
            this.tabPage144.Controls.Add(this.btShowIPCamDatabase);
            this.tabPage144.Controls.Add(this.linkLabel7);
            this.tabPage144.Controls.Add(this.cbIPDisconnect);
            this.tabPage144.Controls.Add(this.edIPForcedFramerateID);
            this.tabPage144.Controls.Add(this.label344);
            this.tabPage144.Controls.Add(this.edIPForcedFramerate);
            this.tabPage144.Controls.Add(this.label295);
            this.tabPage144.Controls.Add(this.cbIPCameraType);
            this.tabPage144.Controls.Add(this.edIPPassword);
            this.tabPage144.Controls.Add(this.label167);
            this.tabPage144.Controls.Add(this.edIPLogin);
            this.tabPage144.Controls.Add(this.label166);
            this.tabPage144.Controls.Add(this.cbIPAudioCapture);
            this.tabPage144.Controls.Add(this.label168);
            this.tabPage144.Location = new System.Drawing.Point(4, 22);
            this.tabPage144.Name = "tabPage144";
            this.tabPage144.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage144.Size = new System.Drawing.Size(439, 256);
            this.tabPage144.TabIndex = 0;
            this.tabPage144.Text = "Main";
            this.tabPage144.UseVisualStyleBackColor = true;
            // 
            // cbIPCameraONVIF
            // 
            this.cbIPCameraONVIF.AutoSize = true;
            this.cbIPCameraONVIF.Location = new System.Drawing.Point(294, 12);
            this.cbIPCameraONVIF.Name = "cbIPCameraONVIF";
            this.cbIPCameraONVIF.Size = new System.Drawing.Size(96, 17);
            this.cbIPCameraONVIF.TabIndex = 78;
            this.cbIPCameraONVIF.Text = "ONVIF camera";
            this.cbIPCameraONVIF.UseVisualStyleBackColor = true;
            // 
            // btShowIPCamDatabase
            // 
            this.btShowIPCamDatabase.Location = new System.Drawing.Point(282, 179);
            this.btShowIPCamDatabase.Name = "btShowIPCamDatabase";
            this.btShowIPCamDatabase.Size = new System.Drawing.Size(135, 23);
            this.btShowIPCamDatabase.TabIndex = 77;
            this.btShowIPCamDatabase.Text = "Show IP cam database";
            this.btShowIPCamDatabase.UseVisualStyleBackColor = true;
            this.btShowIPCamDatabase.Click += new System.EventHandler(this.btShowIPCamDatabase_Click);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(12, 184);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(264, 13);
            this.linkLabel7.TabIndex = 76;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Please install VisioForge VLC redist to use VLC engine ";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // cbIPDisconnect
            // 
            this.cbIPDisconnect.AutoSize = true;
            this.cbIPDisconnect.Location = new System.Drawing.Point(15, 127);
            this.cbIPDisconnect.Name = "cbIPDisconnect";
            this.cbIPDisconnect.Size = new System.Drawing.Size(136, 17);
            this.cbIPDisconnect.TabIndex = 75;
            this.cbIPDisconnect.Text = "Notify if connection lost";
            this.cbIPDisconnect.UseVisualStyleBackColor = true;
            // 
            // edIPForcedFramerateID
            // 
            this.edIPForcedFramerateID.Location = new System.Drawing.Point(267, 100);
            this.edIPForcedFramerateID.Margin = new System.Windows.Forms.Padding(2);
            this.edIPForcedFramerateID.Name = "edIPForcedFramerateID";
            this.edIPForcedFramerateID.Size = new System.Drawing.Size(32, 20);
            this.edIPForcedFramerateID.TabIndex = 71;
            this.edIPForcedFramerateID.Text = "0";
            // 
            // label344
            // 
            this.label344.AutoSize = true;
            this.label344.Location = new System.Drawing.Point(165, 102);
            this.label344.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label344.Name = "label344";
            this.label344.Size = new System.Drawing.Size(98, 13);
            this.label344.TabIndex = 70;
            this.label344.Text = "Force frame rate ID";
            // 
            // edIPForcedFramerate
            // 
            this.edIPForcedFramerate.Location = new System.Drawing.Point(114, 100);
            this.edIPForcedFramerate.Margin = new System.Windows.Forms.Padding(2);
            this.edIPForcedFramerate.Name = "edIPForcedFramerate";
            this.edIPForcedFramerate.Size = new System.Drawing.Size(32, 20);
            this.edIPForcedFramerate.TabIndex = 69;
            this.edIPForcedFramerate.Text = "0";
            // 
            // label295
            // 
            this.label295.AutoSize = true;
            this.label295.Location = new System.Drawing.Point(12, 102);
            this.label295.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label295.Name = "label295";
            this.label295.Size = new System.Drawing.Size(84, 13);
            this.label295.TabIndex = 68;
            this.label295.Text = "Force frame rate";
            // 
            // cbIPCameraType
            // 
            this.cbIPCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIPCameraType.FormattingEnabled = true;
            this.cbIPCameraType.Items.AddRange(new object[] {
            "Auto (VLC engine)",
            "Auto (FFMPEG engine)",
            "Auto (LAV engine)",
            "RTSP (Live555 engine)",
            "HTTP (FFMPEG engine)",
            "MMS - WMV",
            "RTSP - UDP (FFMPEG engine)",
            "RTSP - TCP (FFMPEG engine)",
            "RTSP over HTTP (FFMPEG engine)"});
            this.cbIPCameraType.Location = new System.Drawing.Point(57, 10);
            this.cbIPCameraType.Name = "cbIPCameraType";
            this.cbIPCameraType.Size = new System.Drawing.Size(227, 21);
            this.cbIPCameraType.TabIndex = 67;
            // 
            // edIPPassword
            // 
            this.edIPPassword.Location = new System.Drawing.Point(168, 58);
            this.edIPPassword.Name = "edIPPassword";
            this.edIPPassword.Size = new System.Drawing.Size(100, 20);
            this.edIPPassword.TabIndex = 66;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(165, 41);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(53, 13);
            this.label167.TabIndex = 65;
            this.label167.Text = "Password";
            // 
            // edIPLogin
            // 
            this.edIPLogin.Location = new System.Drawing.Point(15, 58);
            this.edIPLogin.Name = "edIPLogin";
            this.edIPLogin.Size = new System.Drawing.Size(100, 20);
            this.edIPLogin.TabIndex = 64;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(11, 41);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(33, 13);
            this.label166.TabIndex = 63;
            this.label166.Text = "Login";
            // 
            // cbIPAudioCapture
            // 
            this.cbIPAudioCapture.AutoSize = true;
            this.cbIPAudioCapture.Checked = true;
            this.cbIPAudioCapture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIPAudioCapture.Location = new System.Drawing.Point(168, 127);
            this.cbIPAudioCapture.Name = "cbIPAudioCapture";
            this.cbIPAudioCapture.Size = new System.Drawing.Size(92, 17);
            this.cbIPAudioCapture.TabIndex = 62;
            this.cbIPAudioCapture.Text = "Capture audio";
            this.cbIPAudioCapture.UseVisualStyleBackColor = true;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(11, 14);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(40, 13);
            this.label168.TabIndex = 61;
            this.label168.Text = "Engine";
            // 
            // tabPage146
            // 
            this.tabPage146.Controls.Add(this.cbVLCZeroClockJitter);
            this.tabPage146.Controls.Add(this.edVLCCacheSize);
            this.tabPage146.Controls.Add(this.label312);
            this.tabPage146.Location = new System.Drawing.Point(4, 22);
            this.tabPage146.Name = "tabPage146";
            this.tabPage146.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage146.Size = new System.Drawing.Size(439, 256);
            this.tabPage146.TabIndex = 2;
            this.tabPage146.Text = "VLC";
            this.tabPage146.UseVisualStyleBackColor = true;
            // 
            // cbVLCZeroClockJitter
            // 
            this.cbVLCZeroClockJitter.AutoSize = true;
            this.cbVLCZeroClockJitter.Location = new System.Drawing.Point(173, 16);
            this.cbVLCZeroClockJitter.Name = "cbVLCZeroClockJitter";
            this.cbVLCZeroClockJitter.Size = new System.Drawing.Size(120, 17);
            this.cbVLCZeroClockJitter.TabIndex = 78;
            this.cbVLCZeroClockJitter.Text = "VLC zero clock jitter";
            this.cbVLCZeroClockJitter.UseVisualStyleBackColor = true;
            // 
            // edVLCCacheSize
            // 
            this.edVLCCacheSize.Location = new System.Drawing.Point(119, 14);
            this.edVLCCacheSize.Name = "edVLCCacheSize";
            this.edVLCCacheSize.Size = new System.Drawing.Size(32, 20);
            this.edVLCCacheSize.TabIndex = 77;
            this.edVLCCacheSize.Text = "1000";
            // 
            // label312
            // 
            this.label312.AutoSize = true;
            this.label312.Location = new System.Drawing.Point(17, 17);
            this.label312.Name = "label312";
            this.label312.Size = new System.Drawing.Size(103, 13);
            this.label312.TabIndex = 76;
            this.label312.Text = "VLC cache size (ms)";
            // 
            // tabPage145
            // 
            this.tabPage145.Controls.Add(this.edONVIFLiveVideoURL);
            this.tabPage145.Controls.Add(this.label513);
            this.tabPage145.Controls.Add(this.groupBox42);
            this.tabPage145.Controls.Add(this.cbONVIFProfile);
            this.tabPage145.Controls.Add(this.label510);
            this.tabPage145.Controls.Add(this.lbONVIFCameraInfo);
            this.tabPage145.Controls.Add(this.btONVIFConnect);
            this.tabPage145.Location = new System.Drawing.Point(4, 22);
            this.tabPage145.Name = "tabPage145";
            this.tabPage145.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage145.Size = new System.Drawing.Size(439, 256);
            this.tabPage145.TabIndex = 1;
            this.tabPage145.Text = "ONVIF";
            this.tabPage145.UseVisualStyleBackColor = true;
            // 
            // edONVIFLiveVideoURL
            // 
            this.edONVIFLiveVideoURL.Location = new System.Drawing.Point(75, 75);
            this.edONVIFLiveVideoURL.Name = "edONVIFLiveVideoURL";
            this.edONVIFLiveVideoURL.ReadOnly = true;
            this.edONVIFLiveVideoURL.Size = new System.Drawing.Size(346, 20);
            this.edONVIFLiveVideoURL.TabIndex = 28;
            // 
            // label513
            // 
            this.label513.AutoSize = true;
            this.label513.Location = new System.Drawing.Point(11, 78);
            this.label513.Name = "label513";
            this.label513.Size = new System.Drawing.Size(59, 13);
            this.label513.TabIndex = 27;
            this.label513.Text = "Video URL";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.btONVIFPTZSetDefault);
            this.groupBox42.Controls.Add(this.btONVIFRight);
            this.groupBox42.Controls.Add(this.btONVIFLeft);
            this.groupBox42.Controls.Add(this.btONVIFZoomOut);
            this.groupBox42.Controls.Add(this.btONVIFZoomIn);
            this.groupBox42.Controls.Add(this.btONVIFDown);
            this.groupBox42.Controls.Add(this.btONVIFUp);
            this.groupBox42.Location = new System.Drawing.Point(14, 103);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Size = new System.Drawing.Size(271, 104);
            this.groupBox42.TabIndex = 26;
            this.groupBox42.TabStop = false;
            this.groupBox42.Text = "PTZ";
            // 
            // btONVIFPTZSetDefault
            // 
            this.btONVIFPTZSetDefault.Location = new System.Drawing.Point(130, 44);
            this.btONVIFPTZSetDefault.Name = "btONVIFPTZSetDefault";
            this.btONVIFPTZSetDefault.Size = new System.Drawing.Size(116, 23);
            this.btONVIFPTZSetDefault.TabIndex = 6;
            this.btONVIFPTZSetDefault.Text = "Set default position";
            this.btONVIFPTZSetDefault.UseVisualStyleBackColor = true;
            this.btONVIFPTZSetDefault.Click += new System.EventHandler(this.btONVIFPTZSetDefault_Click);
            // 
            // btONVIFRight
            // 
            this.btONVIFRight.Location = new System.Drawing.Point(85, 33);
            this.btONVIFRight.Name = "btONVIFRight";
            this.btONVIFRight.Size = new System.Drawing.Size(21, 48);
            this.btONVIFRight.TabIndex = 5;
            this.btONVIFRight.Text = "R";
            this.btONVIFRight.UseVisualStyleBackColor = true;
            this.btONVIFRight.Click += new System.EventHandler(this.btONVIFRight_Click);
            // 
            // btONVIFLeft
            // 
            this.btONVIFLeft.Location = new System.Drawing.Point(13, 32);
            this.btONVIFLeft.Name = "btONVIFLeft";
            this.btONVIFLeft.Size = new System.Drawing.Size(21, 48);
            this.btONVIFLeft.TabIndex = 4;
            this.btONVIFLeft.Text = "L";
            this.btONVIFLeft.UseVisualStyleBackColor = true;
            this.btONVIFLeft.Click += new System.EventHandler(this.btONVIFLeft_Click);
            // 
            // btONVIFZoomOut
            // 
            this.btONVIFZoomOut.Location = new System.Drawing.Point(61, 45);
            this.btONVIFZoomOut.Name = "btONVIFZoomOut";
            this.btONVIFZoomOut.Size = new System.Drawing.Size(23, 23);
            this.btONVIFZoomOut.TabIndex = 3;
            this.btONVIFZoomOut.Text = "-";
            this.btONVIFZoomOut.UseVisualStyleBackColor = true;
            this.btONVIFZoomOut.Click += new System.EventHandler(this.btONVIFZoomOut_Click);
            // 
            // btONVIFZoomIn
            // 
            this.btONVIFZoomIn.Location = new System.Drawing.Point(35, 45);
            this.btONVIFZoomIn.Name = "btONVIFZoomIn";
            this.btONVIFZoomIn.Size = new System.Drawing.Size(22, 23);
            this.btONVIFZoomIn.TabIndex = 2;
            this.btONVIFZoomIn.Text = "+";
            this.btONVIFZoomIn.UseVisualStyleBackColor = true;
            this.btONVIFZoomIn.Click += new System.EventHandler(this.btONVIFZoomIn_Click);
            // 
            // btONVIFDown
            // 
            this.btONVIFDown.Location = new System.Drawing.Point(34, 69);
            this.btONVIFDown.Name = "btONVIFDown";
            this.btONVIFDown.Size = new System.Drawing.Size(51, 23);
            this.btONVIFDown.TabIndex = 1;
            this.btONVIFDown.Text = "Down";
            this.btONVIFDown.UseVisualStyleBackColor = true;
            this.btONVIFDown.Click += new System.EventHandler(this.btONVIFDown_Click);
            // 
            // btONVIFUp
            // 
            this.btONVIFUp.Location = new System.Drawing.Point(34, 20);
            this.btONVIFUp.Name = "btONVIFUp";
            this.btONVIFUp.Size = new System.Drawing.Size(51, 23);
            this.btONVIFUp.TabIndex = 0;
            this.btONVIFUp.Text = "Up";
            this.btONVIFUp.UseVisualStyleBackColor = true;
            this.btONVIFUp.Click += new System.EventHandler(this.btONVIFUp_Click);
            // 
            // cbONVIFProfile
            // 
            this.cbONVIFProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbONVIFProfile.FormattingEnabled = true;
            this.cbONVIFProfile.Location = new System.Drawing.Point(75, 49);
            this.cbONVIFProfile.Name = "cbONVIFProfile";
            this.cbONVIFProfile.Size = new System.Drawing.Size(346, 21);
            this.cbONVIFProfile.TabIndex = 4;
            // 
            // label510
            // 
            this.label510.AutoSize = true;
            this.label510.Location = new System.Drawing.Point(12, 52);
            this.label510.Name = "label510";
            this.label510.Size = new System.Drawing.Size(36, 13);
            this.label510.TabIndex = 3;
            this.label510.Text = "Profile";
            // 
            // lbONVIFCameraInfo
            // 
            this.lbONVIFCameraInfo.AutoSize = true;
            this.lbONVIFCameraInfo.Location = new System.Drawing.Point(95, 22);
            this.lbONVIFCameraInfo.Name = "lbONVIFCameraInfo";
            this.lbONVIFCameraInfo.Size = new System.Drawing.Size(126, 13);
            this.lbONVIFCameraInfo.TabIndex = 1;
            this.lbONVIFCameraInfo.Text = "Camera info not available";
            // 
            // btONVIFConnect
            // 
            this.btONVIFConnect.Location = new System.Drawing.Point(14, 17);
            this.btONVIFConnect.Name = "btONVIFConnect";
            this.btONVIFConnect.Size = new System.Drawing.Size(75, 23);
            this.btONVIFConnect.TabIndex = 0;
            this.btONVIFConnect.Text = "Connect";
            this.btONVIFConnect.UseVisualStyleBackColor = true;
            this.btONVIFConnect.Click += new System.EventHandler(this.btONVIFConnect_Click);
            // 
            // edIPUrl
            // 
            this.edIPUrl.Location = new System.Drawing.Point(58, 12);
            this.edIPUrl.Name = "edIPUrl";
            this.edIPUrl.Size = new System.Drawing.Size(393, 20);
            this.edIPUrl.TabIndex = 64;
            this.edIPUrl.Text = "http://212.162.177.75/mjpg/video.mjpg";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(13, 14);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(29, 13);
            this.label165.TabIndex = 63;
            this.label165.Text = "URL";
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
            this.tabPage2.Size = new System.Drawing.Size(463, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AVI output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSelectOutputAVI
            // 
            this.btSelectOutputAVI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectOutputAVI.Location = new System.Drawing.Point(433, 7);
            this.btSelectOutputAVI.Name = "btSelectOutputAVI";
            this.btSelectOutputAVI.Size = new System.Drawing.Size(24, 23);
            this.btSelectOutputAVI.TabIndex = 47;
            this.btSelectOutputAVI.Text = "...";
            this.btSelectOutputAVI.UseVisualStyleBackColor = true;
            this.btSelectOutputAVI.Click += new System.EventHandler(this.btSelectOutput_Click);
            // 
            // edOutputAVI
            // 
            this.edOutputAVI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edOutputAVI.Location = new System.Drawing.Point(63, 9);
            this.edOutputAVI.Name = "edOutputAVI";
            this.edOutputAVI.Size = new System.Drawing.Size(364, 20);
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
            this.label27.Location = new System.Drawing.Point(5, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 39;
            this.label27.Text = "Audio codec";
            // 
            // btAudioSettings
            // 
            this.btAudioSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAudioSettings.Location = new System.Drawing.Point(393, 66);
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
            this.btVideoSettings.Location = new System.Drawing.Point(393, 39);
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
            this.cbAudioCodecs.Size = new System.Drawing.Size(289, 21);
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
            this.cbVideoCodecs.Size = new System.Drawing.Size(289, 21);
            this.cbVideoCodecs.TabIndex = 28;
            this.cbVideoCodecs.SelectedIndexChanged += new System.EventHandler(this.cbVideoCodecs_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(463, 326);
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
            this.tabControl2.Size = new System.Drawing.Size(451, 314);
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
            this.tabPage4.Size = new System.Drawing.Size(443, 288);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Main";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btSelectOutputMP4
            // 
            this.btSelectOutputMP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectOutputMP4.Location = new System.Drawing.Point(413, 13);
            this.btSelectOutputMP4.Name = "btSelectOutputMP4";
            this.btSelectOutputMP4.Size = new System.Drawing.Size(24, 23);
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
            this.edOutputMP4.Size = new System.Drawing.Size(341, 20);
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
            this.tabPage5.Size = new System.Drawing.Size(443, 288);
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
            this.label351.Text = "Rate ñontrol";
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
            this.tabPage6.Size = new System.Drawing.Size(443, 288);
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
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.cbLicensing);
            this.tabPage7.Controls.Add(this.cbDebugMode);
            this.tabPage7.Controls.Add(this.mmLog);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(463, 326);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Debug";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(12, 10);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(91, 17);
            this.cbLicensing.TabIndex = 79;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(168, 10);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(87, 17);
            this.cbDebugMode.TabIndex = 78;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            this.mmLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmLog.Location = new System.Drawing.Point(12, 33);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(445, 287);
            this.mmLog.TabIndex = 77;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.cbImageType);
            this.tabPage8.Controls.Add(this.lbJPEGQuality);
            this.tabPage8.Controls.Add(this.label38);
            this.tabPage8.Controls.Add(this.btSaveScreenshot);
            this.tabPage8.Controls.Add(this.label63);
            this.tabPage8.Controls.Add(this.edScreenshotsFolder);
            this.tabPage8.Controls.Add(this.tbJPEGQuality);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(463, 326);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Screenshot";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // cbImageType
            // 
            this.cbImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageType.FormattingEnabled = true;
            this.cbImageType.Items.AddRange(new object[] {
            "BMP",
            "JPEG",
            "GIF",
            "PNG",
            "TIFF"});
            this.cbImageType.Location = new System.Drawing.Point(18, 45);
            this.cbImageType.Name = "cbImageType";
            this.cbImageType.Size = new System.Drawing.Size(73, 21);
            this.cbImageType.TabIndex = 48;
            // 
            // lbJPEGQuality
            // 
            this.lbJPEGQuality.AutoSize = true;
            this.lbJPEGQuality.Location = new System.Drawing.Point(269, 48);
            this.lbJPEGQuality.Name = "lbJPEGQuality";
            this.lbJPEGQuality.Size = new System.Drawing.Size(19, 13);
            this.lbJPEGQuality.TabIndex = 47;
            this.lbJPEGQuality.Text = "85";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(126, 48);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 13);
            this.label38.TabIndex = 46;
            this.label38.Text = "JPEG quality";
            // 
            // btSaveScreenshot
            // 
            this.btSaveScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveScreenshot.Location = new System.Drawing.Point(353, 43);
            this.btSaveScreenshot.Name = "btSaveScreenshot";
            this.btSaveScreenshot.Size = new System.Drawing.Size(56, 23);
            this.btSaveScreenshot.TabIndex = 44;
            this.btSaveScreenshot.Text = "Save";
            this.btSaveScreenshot.UseVisualStyleBackColor = true;
            this.btSaveScreenshot.Click += new System.EventHandler(this.btSaveScreenshot_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(15, 22);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(36, 13);
            this.label63.TabIndex = 43;
            this.label63.Text = "Folder";
            // 
            // edScreenshotsFolder
            // 
            this.edScreenshotsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edScreenshotsFolder.Location = new System.Drawing.Point(60, 19);
            this.edScreenshotsFolder.Name = "edScreenshotsFolder";
            this.edScreenshotsFolder.Size = new System.Drawing.Size(349, 20);
            this.edScreenshotsFolder.TabIndex = 42;
            this.edScreenshotsFolder.Text = "c:\\";
            // 
            // tbJPEGQuality
            // 
            this.tbJPEGQuality.BackColor = System.Drawing.SystemColors.Window;
            this.tbJPEGQuality.Location = new System.Drawing.Point(199, 43);
            this.tbJPEGQuality.Maximum = 100;
            this.tbJPEGQuality.Name = "tbJPEGQuality";
            this.tbJPEGQuality.Size = new System.Drawing.Size(64, 45);
            this.tbJPEGQuality.TabIndex = 45;
            this.tbJPEGQuality.TickFrequency = 5;
            this.tbJPEGQuality.Value = 85;
            this.tbJPEGQuality.Scroll += new System.EventHandler(this.tbJPEGQuality_Scroll);
            // 
            // rbCaptureAVI
            // 
            this.rbCaptureAVI.AutoSize = true;
            this.rbCaptureAVI.Location = new System.Drawing.Point(84, 364);
            this.rbCaptureAVI.Name = "rbCaptureAVI";
            this.rbCaptureAVI.Size = new System.Drawing.Size(94, 17);
            this.rbCaptureAVI.TabIndex = 52;
            this.rbCaptureAVI.Text = "Capture to AVI";
            this.rbCaptureAVI.UseVisualStyleBackColor = true;
            // 
            // rbPreview
            // 
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(15, 364);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(63, 17);
            this.rbPreview.TabIndex = 51;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(412, 361);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 50;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(347, 361);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 23);
            this.btStart.TabIndex = 49;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // llVideoTutorials
            // 
            this.llVideoTutorials.AutoSize = true;
            this.llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.llVideoTutorials.Location = new System.Drawing.Point(841, 3);
            this.llVideoTutorials.Name = "llVideoTutorials";
            this.llVideoTutorials.Size = new System.Drawing.Size(68, 13);
            this.llVideoTutorials.TabIndex = 92;
            this.llVideoTutorials.TabStop = true;
            this.llVideoTutorials.Text = "Video tutorial";
            this.llVideoTutorials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVideoTutorials_LinkClicked_1);
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
            this.VideoCapture1.Location = new System.Drawing.Point(480, 25);
            this.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;
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
            this.VideoCapture1.Network_Streaming_Network_Port = 10;
            this.VideoCapture1.Network_Streaming_Output = null;
            this.VideoCapture1.Network_Streaming_URL = "";
            this.VideoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.VideoCapture1.Output_Filename = "";
            this.VideoCapture1.Output_Format = null;
            this.VideoCapture1.PIP_AddSampleGrabbers = false;
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
            this.VideoCapture1.SeparateCapture_TimeThreshold = ((long)(0));
            this.VideoCapture1.Size = new System.Drawing.Size(428, 330);
            this.VideoCapture1.Start_DelayEnabled = false;
            this.VideoCapture1.TabIndex = 93;
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
            this.VideoCapture1.Video_CaptureDevice_FrameRate = 0D;
            this.VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.VideoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.VideoCapture1.Video_CaptureDevice_Path = null;
            this.VideoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.VideoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.VideoCapture1.Video_Crop = null;
            this.VideoCapture1.Video_Decoder = null;
            this.VideoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.VideoCapture1.Video_Effects_Enabled = false;
            videoRendererSettingsWinForms3.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms3.Aspect_Ratio_X = 0;
            videoRendererSettingsWinForms3.Aspect_Ratio_Y = 0;
            videoRendererSettingsWinForms3.BackgroundColor = System.Drawing.Color.Black;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            videoRendererSettingsWinForms3.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.Auto;
            videoRendererSettingsWinForms3.Deinterlace_VMR9_Mode = null;
            videoRendererSettingsWinForms3.Deinterlace_VMR9_UseDefault = true;
            videoRendererSettingsWinForms3.Flip_Horizontal = false;
            videoRendererSettingsWinForms3.Flip_Vertical = false;
            videoRendererSettingsWinForms3.RotationAngle = 0;
            videoRendererSettingsWinForms3.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox;
            videoRendererSettingsWinForms3.Video_Renderer = VisioForge.Types.VFVideoRenderer.VideoRenderer;
            videoRendererSettingsWinForms3.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.VideoRenderer;
            videoRendererSettingsWinForms3.Zoom_Ratio = 0;
            videoRendererSettingsWinForms3.Zoom_ShiftX = 0;
            videoRendererSettingsWinForms3.Zoom_ShiftY = 0;
            this.VideoCapture1.Video_Renderer = videoRendererSettingsWinForms3;
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
            // rbCaptureMP4
            // 
            this.rbCaptureMP4.AutoSize = true;
            this.rbCaptureMP4.Location = new System.Drawing.Point(184, 364);
            this.rbCaptureMP4.Name = "rbCaptureMP4";
            this.rbCaptureMP4.Size = new System.Drawing.Size(99, 17);
            this.rbCaptureMP4.TabIndex = 94;
            this.rbCaptureMP4.Text = "Capture to MP4";
            this.rbCaptureMP4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Much more features available in Main Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbCaptureMP4);
            this.Controls.Add(this.VideoCapture1);
            this.Controls.Add(this.llVideoTutorials);
            this.Controls.Add(this.rbCaptureAVI);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "IP Preview/Capture Demo - VisioForge Video Capture SDK .Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl15.ResumeLayout(false);
            this.tabPage144.ResumeLayout(false);
            this.tabPage144.PerformLayout();
            this.tabPage146.ResumeLayout(false);
            this.tabPage146.PerformLayout();
            this.tabPage145.ResumeLayout(false);
            this.tabPage145.PerformLayout();
            this.groupBox42.ResumeLayout(false);
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
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJPEGQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Button btSelectOutputAVI;
        private System.Windows.Forms.TextBox edOutputAVI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbCaptureAVI;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.LinkLabel llVideoTutorials;
        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btSelectOutputMP4;
        private System.Windows.Forms.TextBox edOutputMP4;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label354;
        private System.Windows.Forms.ComboBox cbAACOutput;
        private System.Windows.Forms.Label label355;
        private System.Windows.Forms.ComboBox cbAACBitrate;
        private System.Windows.Forms.Label label356;
        private System.Windows.Forms.ComboBox cbAACObjectType;
        private System.Windows.Forms.Label label357;
        private System.Windows.Forms.ComboBox cbAACVersion;
        private System.Windows.Forms.Label label358;
        private System.Windows.Forms.RadioButton rbCaptureMP4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox cbLicensing;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ComboBox cbImageType;
        private System.Windows.Forms.Label lbJPEGQuality;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btSaveScreenshot;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox edScreenshotsFolder;
        private System.Windows.Forms.TrackBar tbJPEGQuality;
        private System.Windows.Forms.TabControl tabControl15;
        private System.Windows.Forms.TabPage tabPage144;
        private System.Windows.Forms.CheckBox cbIPCameraONVIF;
        private System.Windows.Forms.Button btShowIPCamDatabase;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.CheckBox cbIPDisconnect;
        private System.Windows.Forms.TextBox edIPForcedFramerateID;
        private System.Windows.Forms.Label label344;
        private System.Windows.Forms.TextBox edIPForcedFramerate;
        private System.Windows.Forms.Label label295;
        private System.Windows.Forms.ComboBox cbIPCameraType;
        private System.Windows.Forms.TextBox edIPPassword;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.TextBox edIPLogin;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.CheckBox cbIPAudioCapture;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.TabPage tabPage146;
        private System.Windows.Forms.CheckBox cbVLCZeroClockJitter;
        private System.Windows.Forms.TextBox edVLCCacheSize;
        private System.Windows.Forms.Label label312;
        private System.Windows.Forms.TabPage tabPage145;
        private System.Windows.Forms.TextBox edONVIFLiveVideoURL;
        private System.Windows.Forms.Label label513;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.Button btONVIFPTZSetDefault;
        private System.Windows.Forms.Button btONVIFRight;
        private System.Windows.Forms.Button btONVIFLeft;
        private System.Windows.Forms.Button btONVIFZoomOut;
        private System.Windows.Forms.Button btONVIFZoomIn;
        private System.Windows.Forms.Button btONVIFDown;
        private System.Windows.Forms.Button btONVIFUp;
        private System.Windows.Forms.ComboBox cbONVIFProfile;
        private System.Windows.Forms.Label label510;
        private System.Windows.Forms.Label lbONVIFCameraInfo;
        private System.Windows.Forms.Button btONVIFConnect;
        private System.Windows.Forms.TextBox edIPUrl;
        private System.Windows.Forms.Label label165;
    }
}

