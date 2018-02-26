namespace VisioForge_SDK_Screen_Capture_Demo
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
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms1 = new VisioForge.Types.VideoRendererSettingsWinForms();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbScreenCapture_DesktopDuplication = new System.Windows.Forms.CheckBox();
            this.label294 = new System.Windows.Forms.Label();
            this.edScreenCaptureWindowName = new System.Windows.Forms.TextBox();
            this.rbScreenCaptureWindow = new System.Windows.Forms.RadioButton();
            this.cbScreenCaptureDisplayIndex = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.cbUseBestAudioInputFormat = new System.Windows.Forms.CheckBox();
            this.btAudioInputDeviceSettings = new System.Windows.Forms.Button();
            this.cbAudioInputLine = new System.Windows.Forms.ComboBox();
            this.cbAudioInputFormat = new System.Windows.Forms.ComboBox();
            this.cbAudioInputDevice = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbRecordAudio = new System.Windows.Forms.CheckBox();
            this.btScreenCaptureUpdate = new System.Windows.Forms.Button();
            this.label124 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.cbScreenCapture_GrabMouseCursor = new System.Windows.Forms.CheckBox();
            this.label79 = new System.Windows.Forms.Label();
            this.edScreenFrameRate = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.edScreenBottom = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.edScreenRight = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.edScreenTop = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.edScreenLeft = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.rbScreenCustomArea = new System.Windows.Forms.RadioButton();
            this.rbScreenFullScreen = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.cbWMVInternalProfile9 = new System.Windows.Forms.ComboBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edImageLogoTop = new System.Windows.Forms.TextBox();
            this.cbImageLogo = new System.Windows.Forms.CheckBox();
            this.label155 = new System.Windows.Forms.Label();
            this.tbImageLogoTransp = new System.Windows.Forms.TrackBar();
            this.edImageLogoLeft = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.btSelectImage = new System.Windows.Forms.Button();
            this.label157 = new System.Windows.Forms.Label();
            this.edImageLogoFilename = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbTextLogoTransp = new System.Windows.Forms.TrackBar();
            this.edTextLogoTop = new System.Windows.Forms.TextBox();
            this.label139 = new System.Windows.Forms.Label();
            this.edTextLogoLeft = new System.Windows.Forms.TextBox();
            this.label140 = new System.Windows.Forms.Label();
            this.btFont = new System.Windows.Forms.Button();
            this.edTextLogo = new System.Windows.Forms.TextBox();
            this.cbTextLogo = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbImageType = new System.Windows.Forms.ComboBox();
            this.lbJPEGQuality = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btSaveScreenshot = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.edScreenshotsFolder = new System.Windows.Forms.TextBox();
            this.tbJPEGQuality = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.btSelectOutput = new System.Windows.Forms.Button();
            this.edOutput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.cbUncAudio = new System.Windows.Forms.CheckBox();
            this.cbDecodeToRGB = new System.Windows.Forms.CheckBox();
            this.cbUncVideo = new System.Windows.Forms.CheckBox();
            this.cbUseLameInAVI = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbVUMeter2 = new System.Windows.Forms.PictureBox();
            this.pbVUMeter1 = new System.Windows.Forms.PictureBox();
            this.edVUMeterValues = new System.Windows.Forms.TextBox();
            this.cbVUMeters = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tbAudioBalance = new System.Windows.Forms.TrackBar();
            this.label54 = new System.Windows.Forms.Label();
            this.tbAudioVolume = new System.Windows.Forms.TrackBar();
            this.cbPlayAudio = new System.Windows.Forms.CheckBox();
            this.cbUseAudioInputFromVideoCaptureDevice = new System.Windows.Forms.CheckBox();
            this.cbAudioOutputDevice = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.llVideoTutorials = new System.Windows.Forms.LinkLabel();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageLogoTransp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTextLogoTransp)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJPEGQuality)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVUMeter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVUMeter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 400);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbScreenCapture_DesktopDuplication);
            this.tabPage1.Controls.Add(this.label294);
            this.tabPage1.Controls.Add(this.edScreenCaptureWindowName);
            this.tabPage1.Controls.Add(this.rbScreenCaptureWindow);
            this.tabPage1.Controls.Add(this.cbScreenCaptureDisplayIndex);
            this.tabPage1.Controls.Add(this.label93);
            this.tabPage1.Controls.Add(this.cbUseBestAudioInputFormat);
            this.tabPage1.Controls.Add(this.btAudioInputDeviceSettings);
            this.tabPage1.Controls.Add(this.cbAudioInputLine);
            this.tabPage1.Controls.Add(this.cbAudioInputFormat);
            this.tabPage1.Controls.Add(this.cbAudioInputDevice);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.cbRecordAudio);
            this.tabPage1.Controls.Add(this.btScreenCaptureUpdate);
            this.tabPage1.Controls.Add(this.label124);
            this.tabPage1.Controls.Add(this.label123);
            this.tabPage1.Controls.Add(this.label122);
            this.tabPage1.Controls.Add(this.cbScreenCapture_GrabMouseCursor);
            this.tabPage1.Controls.Add(this.label79);
            this.tabPage1.Controls.Add(this.edScreenFrameRate);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.edScreenBottom);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.edScreenRight);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.edScreenTop);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.edScreenLeft);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.rbScreenCustomArea);
            this.tabPage1.Controls.Add(this.rbScreenFullScreen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbScreenCapture_DesktopDuplication
            // 
            this.cbScreenCapture_DesktopDuplication.AutoSize = true;
            this.cbScreenCapture_DesktopDuplication.Location = new System.Drawing.Point(10, 204);
            this.cbScreenCapture_DesktopDuplication.Name = "cbScreenCapture_DesktopDuplication";
            this.cbScreenCapture_DesktopDuplication.Size = new System.Drawing.Size(210, 17);
            this.cbScreenCapture_DesktopDuplication.TabIndex = 89;
            this.cbScreenCapture_DesktopDuplication.Text = "Allow Win8 Desktop Duplication usage";
            this.cbScreenCapture_DesktopDuplication.UseVisualStyleBackColor = true;
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Location = new System.Drawing.Point(193, 151);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(135, 13);
            this.label294.TabIndex = 88;
            this.label294.Text = "class, Notepad an example";
            // 
            // edScreenCaptureWindowName
            // 
            this.edScreenCaptureWindowName.Location = new System.Drawing.Point(174, 178);
            this.edScreenCaptureWindowName.Name = "edScreenCaptureWindowName";
            this.edScreenCaptureWindowName.Size = new System.Drawing.Size(162, 20);
            this.edScreenCaptureWindowName.TabIndex = 87;
            this.edScreenCaptureWindowName.Text = "Notepad";
            // 
            // rbScreenCaptureWindow
            // 
            this.rbScreenCaptureWindow.AutoSize = true;
            this.rbScreenCaptureWindow.Location = new System.Drawing.Point(174, 131);
            this.rbScreenCaptureWindow.Name = "rbScreenCaptureWindow";
            this.rbScreenCaptureWindow.Size = new System.Drawing.Size(179, 17);
            this.rbScreenCaptureWindow.TabIndex = 86;
            this.rbScreenCaptureWindow.TabStop = true;
            this.rbScreenCaptureWindow.Text = "Capture window (specify window";
            this.rbScreenCaptureWindow.UseVisualStyleBackColor = true;
            // 
            // cbScreenCaptureDisplayIndex
            // 
            this.cbScreenCaptureDisplayIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreenCaptureDisplayIndex.FormattingEnabled = true;
            this.cbScreenCaptureDisplayIndex.Location = new System.Drawing.Point(80, 154);
            this.cbScreenCaptureDisplayIndex.Name = "cbScreenCaptureDisplayIndex";
            this.cbScreenCaptureDisplayIndex.Size = new System.Drawing.Size(45, 21);
            this.cbScreenCaptureDisplayIndex.TabIndex = 85;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label93.Location = new System.Drawing.Point(7, 157);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(65, 13);
            this.label93.TabIndex = 84;
            this.label93.Text = "Display ID";
            // 
            // cbUseBestAudioInputFormat
            // 
            this.cbUseBestAudioInputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseBestAudioInputFormat.AutoSize = true;
            this.cbUseBestAudioInputFormat.Location = new System.Drawing.Point(296, 309);
            this.cbUseBestAudioInputFormat.Name = "cbUseBestAudioInputFormat";
            this.cbUseBestAudioInputFormat.Size = new System.Drawing.Size(68, 17);
            this.cbUseBestAudioInputFormat.TabIndex = 83;
            this.cbUseBestAudioInputFormat.Text = "Use best";
            this.cbUseBestAudioInputFormat.UseVisualStyleBackColor = true;
            this.cbUseBestAudioInputFormat.CheckedChanged += new System.EventHandler(this.cbUseBestAudioInputFormat_CheckedChanged);
            // 
            // btAudioInputDeviceSettings
            // 
            this.btAudioInputDeviceSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAudioInputDeviceSettings.Location = new System.Drawing.Point(288, 277);
            this.btAudioInputDeviceSettings.Name = "btAudioInputDeviceSettings";
            this.btAudioInputDeviceSettings.Size = new System.Drawing.Size(76, 23);
            this.btAudioInputDeviceSettings.TabIndex = 82;
            this.btAudioInputDeviceSettings.Text = "Settings";
            this.btAudioInputDeviceSettings.UseVisualStyleBackColor = true;
            this.btAudioInputDeviceSettings.Click += new System.EventHandler(this.btAudioInputDeviceSettings_Click);
            // 
            // cbAudioInputLine
            // 
            this.cbAudioInputLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioInputLine.FormattingEnabled = true;
            this.cbAudioInputLine.Location = new System.Drawing.Point(10, 327);
            this.cbAudioInputLine.Name = "cbAudioInputLine";
            this.cbAudioInputLine.Size = new System.Drawing.Size(161, 21);
            this.cbAudioInputLine.TabIndex = 81;
            this.cbAudioInputLine.SelectedIndexChanged += new System.EventHandler(this.cbAudioInputLine_SelectedIndexChanged);
            // 
            // cbAudioInputFormat
            // 
            this.cbAudioInputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAudioInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioInputFormat.FormattingEnabled = true;
            this.cbAudioInputFormat.Location = new System.Drawing.Point(184, 326);
            this.cbAudioInputFormat.Name = "cbAudioInputFormat";
            this.cbAudioInputFormat.Size = new System.Drawing.Size(180, 21);
            this.cbAudioInputFormat.TabIndex = 80;
            this.cbAudioInputFormat.SelectedIndexChanged += new System.EventHandler(this.cbAudioInputFormat_SelectedIndexChanged);
            // 
            // cbAudioInputDevice
            // 
            this.cbAudioInputDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAudioInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioInputDevice.FormattingEnabled = true;
            this.cbAudioInputDevice.Location = new System.Drawing.Point(10, 279);
            this.cbAudioInputDevice.Name = "cbAudioInputDevice";
            this.cbAudioInputDevice.Size = new System.Drawing.Size(272, 21);
            this.cbAudioInputDevice.TabIndex = 79;
            this.cbAudioInputDevice.SelectedIndexChanged += new System.EventHandler(this.cbAudioInputDevice_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 311);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 78;
            this.label22.Text = "Input line";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 77;
            this.label23.Text = "Input device";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(181, 309);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 76;
            this.label25.Text = "Input format";
            // 
            // cbRecordAudio
            // 
            this.cbRecordAudio.AutoSize = true;
            this.cbRecordAudio.Location = new System.Drawing.Point(10, 234);
            this.cbRecordAudio.Name = "cbRecordAudio";
            this.cbRecordAudio.Size = new System.Drawing.Size(90, 17);
            this.cbRecordAudio.TabIndex = 66;
            this.cbRecordAudio.Text = "Record audio";
            this.cbRecordAudio.UseVisualStyleBackColor = true;
            // 
            // btScreenCaptureUpdate
            // 
            this.btScreenCaptureUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btScreenCaptureUpdate.Location = new System.Drawing.Point(252, 61);
            this.btScreenCaptureUpdate.Name = "btScreenCaptureUpdate";
            this.btScreenCaptureUpdate.Size = new System.Drawing.Size(75, 23);
            this.btScreenCaptureUpdate.TabIndex = 65;
            this.btScreenCaptureUpdate.Text = "Update";
            this.btScreenCaptureUpdate.UseVisualStyleBackColor = true;
            this.btScreenCaptureUpdate.Click += new System.EventHandler(this.btScreenCaptureUpdate_Click);
            // 
            // label124
            // 
            this.label124.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(205, 34);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(50, 13);
            this.label124.TabIndex = 64;
            this.label124.Text = "on-the-fly";
            // 
            // label123
            // 
            this.label123.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(205, 21);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(141, 13);
            this.label123.TabIndex = 63;
            this.label123.Text = "and mouse cursor  capturing";
            // 
            // label122
            // 
            this.label122.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(205, 8);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(159, 13);
            this.label122.TabIndex = 62;
            this.label122.Text = "You can update left/top position";
            // 
            // cbScreenCapture_GrabMouseCursor
            // 
            this.cbScreenCapture_GrabMouseCursor.AutoSize = true;
            this.cbScreenCapture_GrabMouseCursor.Location = new System.Drawing.Point(10, 181);
            this.cbScreenCapture_GrabMouseCursor.Name = "cbScreenCapture_GrabMouseCursor";
            this.cbScreenCapture_GrabMouseCursor.Size = new System.Drawing.Size(129, 17);
            this.cbScreenCapture_GrabMouseCursor.TabIndex = 61;
            this.cbScreenCapture_GrabMouseCursor.Text = "Capture mouse cursor";
            this.cbScreenCapture_GrabMouseCursor.UseVisualStyleBackColor = true;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(131, 131);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(21, 13);
            this.label79.TabIndex = 60;
            this.label79.Text = "fps";
            // 
            // edScreenFrameRate
            // 
            this.edScreenFrameRate.Location = new System.Drawing.Point(80, 128);
            this.edScreenFrameRate.Name = "edScreenFrameRate";
            this.edScreenFrameRate.Size = new System.Drawing.Size(45, 20);
            this.edScreenFrameRate.TabIndex = 59;
            this.edScreenFrameRate.Text = "5";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(7, 131);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(67, 13);
            this.label43.TabIndex = 58;
            this.label43.Text = "Frame rate";
            // 
            // edScreenBottom
            // 
            this.edScreenBottom.Location = new System.Drawing.Point(174, 89);
            this.edScreenBottom.Name = "edScreenBottom";
            this.edScreenBottom.Size = new System.Drawing.Size(44, 20);
            this.edScreenBottom.TabIndex = 57;
            this.edScreenBottom.Text = "480";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(131, 92);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 13);
            this.label42.TabIndex = 56;
            this.label42.Text = "Bottom";
            // 
            // edScreenRight
            // 
            this.edScreenRight.Location = new System.Drawing.Point(70, 89);
            this.edScreenRight.Name = "edScreenRight";
            this.edScreenRight.Size = new System.Drawing.Size(44, 20);
            this.edScreenRight.TabIndex = 55;
            this.edScreenRight.Text = "640";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(29, 92);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(32, 13);
            this.label40.TabIndex = 54;
            this.label40.Text = "Right";
            // 
            // edScreenTop
            // 
            this.edScreenTop.Location = new System.Drawing.Point(174, 63);
            this.edScreenTop.Name = "edScreenTop";
            this.edScreenTop.Size = new System.Drawing.Size(44, 20);
            this.edScreenTop.TabIndex = 53;
            this.edScreenTop.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(131, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "Top";
            // 
            // edScreenLeft
            // 
            this.edScreenLeft.Location = new System.Drawing.Point(70, 63);
            this.edScreenLeft.Name = "edScreenLeft";
            this.edScreenLeft.Size = new System.Drawing.Size(44, 20);
            this.edScreenLeft.TabIndex = 51;
            this.edScreenLeft.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(29, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 50;
            this.label24.Text = "Left";
            // 
            // rbScreenCustomArea
            // 
            this.rbScreenCustomArea.AutoSize = true;
            this.rbScreenCustomArea.Location = new System.Drawing.Point(10, 36);
            this.rbScreenCustomArea.Name = "rbScreenCustomArea";
            this.rbScreenCustomArea.Size = new System.Drawing.Size(84, 17);
            this.rbScreenCustomArea.TabIndex = 49;
            this.rbScreenCustomArea.Text = "Custom area";
            this.rbScreenCustomArea.UseVisualStyleBackColor = true;
            // 
            // rbScreenFullScreen
            // 
            this.rbScreenFullScreen.AutoSize = true;
            this.rbScreenFullScreen.Checked = true;
            this.rbScreenFullScreen.Location = new System.Drawing.Point(10, 12);
            this.rbScreenFullScreen.Name = "rbScreenFullScreen";
            this.rbScreenFullScreen.Size = new System.Drawing.Size(76, 17);
            this.rbScreenFullScreen.TabIndex = 48;
            this.rbScreenFullScreen.TabStop = true;
            this.rbScreenFullScreen.Text = "Full screen";
            this.rbScreenFullScreen.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(358, 362);
            this.tabControl2.TabIndex = 44;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label27);
            this.tabPage5.Controls.Add(this.btAudioSettings);
            this.tabPage5.Controls.Add(this.btVideoSettings);
            this.tabPage5.Controls.Add(this.label28);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.cbChannels);
            this.tabPage5.Controls.Add(this.cbBPS);
            this.tabPage5.Controls.Add(this.cbAudioCodecs);
            this.tabPage5.Controls.Add(this.cbSampleRate);
            this.tabPage5.Controls.Add(this.cbVideoCodecs);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(350, 336);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "AVI";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 51;
            this.label27.Text = "Audio codec";
            // 
            // btAudioSettings
            // 
            this.btAudioSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAudioSettings.Location = new System.Drawing.Point(278, 42);
            this.btAudioSettings.Name = "btAudioSettings";
            this.btAudioSettings.Size = new System.Drawing.Size(64, 23);
            this.btAudioSettings.TabIndex = 50;
            this.btAudioSettings.Text = "Settings";
            this.btAudioSettings.UseVisualStyleBackColor = true;
            this.btAudioSettings.Click += new System.EventHandler(this.btAudioSettings_Click);
            // 
            // btVideoSettings
            // 
            this.btVideoSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVideoSettings.Location = new System.Drawing.Point(278, 15);
            this.btVideoSettings.Name = "btVideoSettings";
            this.btVideoSettings.Size = new System.Drawing.Size(64, 23);
            this.btVideoSettings.TabIndex = 49;
            this.btVideoSettings.Text = "Settings";
            this.btVideoSettings.UseVisualStyleBackColor = true;
            this.btVideoSettings.Click += new System.EventHandler(this.btVideoSettings_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 99);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "Sample rate";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(179, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(28, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "BPS";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(27, 72);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 46;
            this.label30.Text = "Channels";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 45;
            this.label31.Text = "Video codec";
            // 
            // cbChannels
            // 
            this.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbChannels.Location = new System.Drawing.Point(104, 69);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(65, 21);
            this.cbChannels.TabIndex = 44;
            // 
            // cbBPS
            // 
            this.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBPS.FormattingEnabled = true;
            this.cbBPS.Items.AddRange(new object[] {
            "8",
            "16"});
            this.cbBPS.Location = new System.Drawing.Point(213, 69);
            this.cbBPS.Name = "cbBPS";
            this.cbBPS.Size = new System.Drawing.Size(59, 21);
            this.cbBPS.TabIndex = 43;
            // 
            // cbAudioCodecs
            // 
            this.cbAudioCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCodecs.FormattingEnabled = true;
            this.cbAudioCodecs.Location = new System.Drawing.Point(104, 42);
            this.cbAudioCodecs.Name = "cbAudioCodecs";
            this.cbAudioCodecs.Size = new System.Drawing.Size(168, 21);
            this.cbAudioCodecs.TabIndex = 42;
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
            this.cbSampleRate.Location = new System.Drawing.Point(104, 96);
            this.cbSampleRate.Name = "cbSampleRate";
            this.cbSampleRate.Size = new System.Drawing.Size(65, 21);
            this.cbSampleRate.TabIndex = 41;
            // 
            // cbVideoCodecs
            // 
            this.cbVideoCodecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoCodecs.FormattingEnabled = true;
            this.cbVideoCodecs.Location = new System.Drawing.Point(104, 15);
            this.cbVideoCodecs.Name = "cbVideoCodecs";
            this.cbVideoCodecs.Size = new System.Drawing.Size(168, 21);
            this.cbVideoCodecs.TabIndex = 40;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.cbWMVInternalProfile9);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(350, 336);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "WMV";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(36, 13);
            this.label33.TabIndex = 45;
            this.label33.Text = "Profile";
            // 
            // cbWMVInternalProfile9
            // 
            this.cbWMVInternalProfile9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWMVInternalProfile9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWMVInternalProfile9.FormattingEnabled = true;
            this.cbWMVInternalProfile9.Location = new System.Drawing.Point(15, 31);
            this.cbWMVInternalProfile9.Name = "cbWMVInternalProfile9";
            this.cbWMVInternalProfile9.Size = new System.Drawing.Size(321, 21);
            this.cbWMVInternalProfile9.TabIndex = 44;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label36);
            this.tabPage7.Controls.Add(this.label37);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(350, 336);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "MP4";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edImageLogoTop);
            this.tabPage3.Controls.Add(this.cbImageLogo);
            this.tabPage3.Controls.Add(this.label155);
            this.tabPage3.Controls.Add(this.tbImageLogoTransp);
            this.tabPage3.Controls.Add(this.edImageLogoLeft);
            this.tabPage3.Controls.Add(this.label156);
            this.tabPage3.Controls.Add(this.label154);
            this.tabPage3.Controls.Add(this.btSelectImage);
            this.tabPage3.Controls.Add(this.label157);
            this.tabPage3.Controls.Add(this.edImageLogoFilename);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.tbTextLogoTransp);
            this.tabPage3.Controls.Add(this.edTextLogoTop);
            this.tabPage3.Controls.Add(this.label139);
            this.tabPage3.Controls.Add(this.edTextLogoLeft);
            this.tabPage3.Controls.Add(this.label140);
            this.tabPage3.Controls.Add(this.btFont);
            this.tabPage3.Controls.Add(this.edTextLogo);
            this.tabPage3.Controls.Add(this.cbTextLogo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(370, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video effects";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edImageLogoTop
            // 
            this.edImageLogoTop.Location = new System.Drawing.Point(65, 278);
            this.edImageLogoTop.Name = "edImageLogoTop";
            this.edImageLogoTop.Size = new System.Drawing.Size(39, 20);
            this.edImageLogoTop.TabIndex = 56;
            this.edImageLogoTop.Text = "50";
            this.edImageLogoTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbImageLogo
            // 
            this.cbImageLogo.AutoSize = true;
            this.cbImageLogo.Location = new System.Drawing.Point(19, 191);
            this.cbImageLogo.Name = "cbImageLogo";
            this.cbImageLogo.Size = new System.Drawing.Size(78, 17);
            this.cbImageLogo.TabIndex = 57;
            this.cbImageLogo.Text = "Image logo";
            this.cbImageLogo.UseVisualStyleBackColor = true;
            this.cbImageLogo.CheckedChanged += new System.EventHandler(this.cbImageLogo_CheckedChanged);
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(32, 281);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(26, 13);
            this.label155.TabIndex = 55;
            this.label155.Text = "Top";
            // 
            // tbImageLogoTransp
            // 
            this.tbImageLogoTransp.BackColor = System.Drawing.SystemColors.Window;
            this.tbImageLogoTransp.Location = new System.Drawing.Point(141, 271);
            this.tbImageLogoTransp.Maximum = 255;
            this.tbImageLogoTransp.Name = "tbImageLogoTransp";
            this.tbImageLogoTransp.Size = new System.Drawing.Size(104, 45);
            this.tbImageLogoTransp.TabIndex = 61;
            this.tbImageLogoTransp.Scroll += new System.EventHandler(this.tbGraphicLogoTransp_Scroll);
            // 
            // edImageLogoLeft
            // 
            this.edImageLogoLeft.Location = new System.Drawing.Point(65, 252);
            this.edImageLogoLeft.Name = "edImageLogoLeft";
            this.edImageLogoLeft.Size = new System.Drawing.Size(39, 20);
            this.edImageLogoLeft.TabIndex = 54;
            this.edImageLogoLeft.Text = "50";
            this.edImageLogoLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(32, 255);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(25, 13);
            this.label156.TabIndex = 53;
            this.label156.Text = "Left";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(142, 255);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(72, 13);
            this.label154.TabIndex = 62;
            this.label154.Text = "Transparency";
            // 
            // btSelectImage
            // 
            this.btSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectImage.Location = new System.Drawing.Point(330, 212);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(24, 23);
            this.btSelectImage.TabIndex = 60;
            this.btSelectImage.Text = "...";
            this.btSelectImage.UseVisualStyleBackColor = true;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(32, 217);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(52, 13);
            this.label157.TabIndex = 59;
            this.label157.Text = "File name";
            // 
            // edImageLogoFilename
            // 
            this.edImageLogoFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edImageLogoFilename.Location = new System.Drawing.Point(90, 214);
            this.edImageLogoFilename.Name = "edImageLogoFilename";
            this.edImageLogoFilename.Size = new System.Drawing.Size(234, 20);
            this.edImageLogoFilename.TabIndex = 58;
            this.edImageLogoFilename.Text = "c:\\1.png";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(142, 81);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 13);
            this.label32.TabIndex = 28;
            this.label32.Text = "Transparency (layer)";
            // 
            // tbTextLogoTransp
            // 
            this.tbTextLogoTransp.BackColor = System.Drawing.SystemColors.Window;
            this.tbTextLogoTransp.Location = new System.Drawing.Point(142, 97);
            this.tbTextLogoTransp.Maximum = 255;
            this.tbTextLogoTransp.Name = "tbTextLogoTransp";
            this.tbTextLogoTransp.Size = new System.Drawing.Size(103, 45);
            this.tbTextLogoTransp.TabIndex = 27;
            this.tbTextLogoTransp.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTextLogoTransp.Value = 127;
            this.tbTextLogoTransp.Scroll += new System.EventHandler(this.tbTextLogoTransp_Scroll);
            // 
            // edTextLogoTop
            // 
            this.edTextLogoTop.Location = new System.Drawing.Point(65, 104);
            this.edTextLogoTop.Name = "edTextLogoTop";
            this.edTextLogoTop.Size = new System.Drawing.Size(33, 20);
            this.edTextLogoTop.TabIndex = 23;
            this.edTextLogoTop.Text = "50";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(29, 107);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(26, 13);
            this.label139.TabIndex = 22;
            this.label139.Text = "Top";
            // 
            // edTextLogoLeft
            // 
            this.edTextLogoLeft.Location = new System.Drawing.Point(65, 78);
            this.edTextLogoLeft.Name = "edTextLogoLeft";
            this.edTextLogoLeft.Size = new System.Drawing.Size(33, 20);
            this.edTextLogoLeft.TabIndex = 21;
            this.edTextLogoLeft.Text = "50";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(29, 81);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(25, 13);
            this.label140.TabIndex = 20;
            this.label140.Text = "Left";
            // 
            // btFont
            // 
            this.btFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFont.Location = new System.Drawing.Point(307, 44);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(47, 23);
            this.btFont.TabIndex = 19;
            this.btFont.Text = "Font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // edTextLogo
            // 
            this.edTextLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTextLogo.Location = new System.Drawing.Point(32, 46);
            this.edTextLogo.Name = "edTextLogo";
            this.edTextLogo.Size = new System.Drawing.Size(266, 20);
            this.edTextLogo.TabIndex = 18;
            this.edTextLogo.Text = "Hello!!!";
            // 
            // cbTextLogo
            // 
            this.cbTextLogo.AutoSize = true;
            this.cbTextLogo.Location = new System.Drawing.Point(19, 23);
            this.cbTextLogo.Name = "cbTextLogo";
            this.cbTextLogo.Size = new System.Drawing.Size(70, 17);
            this.cbTextLogo.TabIndex = 17;
            this.cbTextLogo.Text = "Text logo";
            this.cbTextLogo.UseVisualStyleBackColor = true;
            this.cbTextLogo.CheckedChanged += new System.EventHandler(this.cbTextLogo_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(370, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "More";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbImageType);
            this.groupBox2.Controls.Add(this.lbJPEGQuality);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.btSaveScreenshot);
            this.groupBox2.Controls.Add(this.label63);
            this.groupBox2.Controls.Add(this.edScreenshotsFolder);
            this.groupBox2.Controls.Add(this.tbJPEGQuality);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screenshot";
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
            this.cbImageType.Location = new System.Drawing.Point(12, 45);
            this.cbImageType.Name = "cbImageType";
            this.cbImageType.Size = new System.Drawing.Size(73, 21);
            this.cbImageType.TabIndex = 41;
            // 
            // lbJPEGQuality
            // 
            this.lbJPEGQuality.AutoSize = true;
            this.lbJPEGQuality.Location = new System.Drawing.Point(263, 48);
            this.lbJPEGQuality.Name = "lbJPEGQuality";
            this.lbJPEGQuality.Size = new System.Drawing.Size(19, 13);
            this.lbJPEGQuality.TabIndex = 40;
            this.lbJPEGQuality.Text = "85";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(120, 48);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(67, 13);
            this.label38.TabIndex = 39;
            this.label38.Text = "JPEG quality";
            // 
            // btSaveScreenshot
            // 
            this.btSaveScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveScreenshot.Location = new System.Drawing.Point(296, 43);
            this.btSaveScreenshot.Name = "btSaveScreenshot";
            this.btSaveScreenshot.Size = new System.Drawing.Size(56, 23);
            this.btSaveScreenshot.TabIndex = 37;
            this.btSaveScreenshot.Text = "Save";
            this.btSaveScreenshot.UseVisualStyleBackColor = true;
            this.btSaveScreenshot.Click += new System.EventHandler(this.btSaveScreenshot_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(9, 22);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(36, 13);
            this.label63.TabIndex = 35;
            this.label63.Text = "Folder";
            // 
            // edScreenshotsFolder
            // 
            this.edScreenshotsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edScreenshotsFolder.Location = new System.Drawing.Point(54, 19);
            this.edScreenshotsFolder.Name = "edScreenshotsFolder";
            this.edScreenshotsFolder.Size = new System.Drawing.Size(298, 20);
            this.edScreenshotsFolder.TabIndex = 34;
            this.edScreenshotsFolder.Text = "c:\\";
            // 
            // tbJPEGQuality
            // 
            this.tbJPEGQuality.BackColor = System.Drawing.SystemColors.Window;
            this.tbJPEGQuality.Location = new System.Drawing.Point(193, 43);
            this.tbJPEGQuality.Maximum = 100;
            this.tbJPEGQuality.Name = "tbJPEGQuality";
            this.tbJPEGQuality.Size = new System.Drawing.Size(64, 45);
            this.tbJPEGQuality.TabIndex = 38;
            this.tbJPEGQuality.TickFrequency = 5;
            this.tbJPEGQuality.Value = 85;
            this.tbJPEGQuality.Scroll += new System.EventHandler(this.tbJPEGQuality_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLicensing);
            this.groupBox1.Controls.Add(this.cbDebugMode);
            this.groupBox1.Controls.Add(this.mmLog);
            this.groupBox1.Location = new System.Drawing.Point(6, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Errors/Warnings";
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(168, 19);
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
            this.cbDebugMode.Location = new System.Drawing.Point(265, 19);
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
            this.mmLog.Location = new System.Drawing.Point(6, 42);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(346, 230);
            this.mmLog.TabIndex = 74;
            // 
            // btSelectOutput
            // 
            this.btSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelectOutput.Location = new System.Drawing.Point(353, 412);
            this.btSelectOutput.Name = "btSelectOutput";
            this.btSelectOutput.Size = new System.Drawing.Size(24, 23);
            this.btSelectOutput.TabIndex = 44;
            this.btSelectOutput.Text = "...";
            this.btSelectOutput.UseVisualStyleBackColor = true;
            this.btSelectOutput.Click += new System.EventHandler(this.btSelectOutput_Click);
            // 
            // edOutput
            // 
            this.edOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edOutput.Location = new System.Drawing.Point(66, 412);
            this.edOutput.Name = "edOutput";
            this.edOutput.Size = new System.Drawing.Size(281, 20);
            this.edOutput.TabIndex = 43;
            this.edOutput.Text = "c:\\capture.avi";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "File name";
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(756, 410);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 46;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(691, 410);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 23);
            this.btStart.TabIndex = 45;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // cbUncAudio
            // 
            this.cbUncAudio.AutoSize = true;
            this.cbUncAudio.Location = new System.Drawing.Point(13, 157);
            this.cbUncAudio.Name = "cbUncAudio";
            this.cbUncAudio.Size = new System.Drawing.Size(126, 17);
            this.cbUncAudio.TabIndex = 27;
            this.cbUncAudio.Text = "Uncompressed audio";
            this.cbUncAudio.UseVisualStyleBackColor = true;
            // 
            // cbDecodeToRGB
            // 
            this.cbDecodeToRGB.AutoSize = true;
            this.cbDecodeToRGB.Location = new System.Drawing.Point(36, 83);
            this.cbDecodeToRGB.Name = "cbDecodeToRGB";
            this.cbDecodeToRGB.Size = new System.Drawing.Size(102, 17);
            this.cbDecodeToRGB.TabIndex = 26;
            this.cbDecodeToRGB.Text = "Decode to RGB";
            this.cbDecodeToRGB.UseVisualStyleBackColor = true;
            // 
            // cbUncVideo
            // 
            this.cbUncVideo.AutoSize = true;
            this.cbUncVideo.Location = new System.Drawing.Point(13, 62);
            this.cbUncVideo.Name = "cbUncVideo";
            this.cbUncVideo.Size = new System.Drawing.Size(126, 17);
            this.cbUncVideo.TabIndex = 25;
            this.cbUncVideo.Text = "Uncompressed video";
            this.cbUncVideo.UseVisualStyleBackColor = true;
            // 
            // cbUseLameInAVI
            // 
            this.cbUseLameInAVI.AutoSize = true;
            this.cbUseLameInAVI.Location = new System.Drawing.Point(13, 263);
            this.cbUseLameInAVI.Name = "cbUseLameInAVI";
            this.cbUseLameInAVI.Size = new System.Drawing.Size(168, 17);
            this.cbUseLameInAVI.TabIndex = 24;
            this.cbUseLameInAVI.Text = "Use LAME for audio encoding";
            this.cbUseLameInAVI.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Audio codec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sample rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "BPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Channels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Video codec";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Input line";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Input device";
            // 
            // pbVUMeter2
            // 
            this.pbVUMeter2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbVUMeter2.Location = new System.Drawing.Point(313, 187);
            this.pbVUMeter2.Name = "pbVUMeter2";
            this.pbVUMeter2.Size = new System.Drawing.Size(119, 53);
            this.pbVUMeter2.TabIndex = 84;
            this.pbVUMeter2.TabStop = false;
            // 
            // pbVUMeter1
            // 
            this.pbVUMeter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbVUMeter1.Location = new System.Drawing.Point(183, 187);
            this.pbVUMeter1.Name = "pbVUMeter1";
            this.pbVUMeter1.Size = new System.Drawing.Size(119, 53);
            this.pbVUMeter1.TabIndex = 83;
            this.pbVUMeter1.TabStop = false;
            // 
            // edVUMeterValues
            // 
            this.edVUMeterValues.Location = new System.Drawing.Point(34, 210);
            this.edVUMeterValues.Name = "edVUMeterValues";
            this.edVUMeterValues.Size = new System.Drawing.Size(110, 20);
            this.edVUMeterValues.TabIndex = 82;
            // 
            // cbVUMeters
            // 
            this.cbVUMeters.AutoSize = true;
            this.cbVUMeters.Location = new System.Drawing.Point(26, 187);
            this.cbVUMeters.Name = "cbVUMeters";
            this.cbVUMeters.Size = new System.Drawing.Size(107, 17);
            this.cbVUMeters.TabIndex = 81;
            this.cbVUMeters.Text = "Enable VU Meter";
            this.cbVUMeters.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(347, 114);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(46, 13);
            this.label55.TabIndex = 80;
            this.label55.Text = "Balance";
            // 
            // tbAudioBalance
            // 
            this.tbAudioBalance.Location = new System.Drawing.Point(350, 128);
            this.tbAudioBalance.Maximum = 100;
            this.tbAudioBalance.Minimum = -100;
            this.tbAudioBalance.Name = "tbAudioBalance";
            this.tbAudioBalance.Size = new System.Drawing.Size(82, 45);
            this.tbAudioBalance.TabIndex = 79;
            this.tbAudioBalance.TickFrequency = 5;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(239, 114);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(42, 13);
            this.label54.TabIndex = 78;
            this.label54.Text = "Volume";
            // 
            // tbAudioVolume
            // 
            this.tbAudioVolume.Location = new System.Drawing.Point(241, 128);
            this.tbAudioVolume.Maximum = 1000;
            this.tbAudioVolume.Minimum = 600;
            this.tbAudioVolume.Name = "tbAudioVolume";
            this.tbAudioVolume.Size = new System.Drawing.Size(82, 45);
            this.tbAudioVolume.TabIndex = 77;
            this.tbAudioVolume.TickFrequency = 10;
            this.tbAudioVolume.Value = 700;
            // 
            // cbPlayAudio
            // 
            this.cbPlayAudio.AutoSize = true;
            this.cbPlayAudio.Checked = true;
            this.cbPlayAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlayAudio.Location = new System.Drawing.Point(141, 113);
            this.cbPlayAudio.Name = "cbPlayAudio";
            this.cbPlayAudio.Size = new System.Drawing.Size(75, 17);
            this.cbPlayAudio.TabIndex = 76;
            this.cbPlayAudio.Text = "Play audio";
            this.cbPlayAudio.UseVisualStyleBackColor = true;
            // 
            // cbUseAudioInputFromVideoCaptureDevice
            // 
            this.cbUseAudioInputFromVideoCaptureDevice.AutoSize = true;
            this.cbUseAudioInputFromVideoCaptureDevice.Location = new System.Drawing.Point(251, 16);
            this.cbUseAudioInputFromVideoCaptureDevice.Name = "cbUseAudioInputFromVideoCaptureDevice";
            this.cbUseAudioInputFromVideoCaptureDevice.Size = new System.Drawing.Size(187, 17);
            this.cbUseAudioInputFromVideoCaptureDevice.TabIndex = 74;
            this.cbUseAudioInputFromVideoCaptureDevice.Text = "Use audio input from video source";
            this.cbUseAudioInputFromVideoCaptureDevice.UseVisualStyleBackColor = true;
            // 
            // cbAudioOutputDevice
            // 
            this.cbAudioOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioOutputDevice.FormattingEnabled = true;
            this.cbAudioOutputDevice.Location = new System.Drawing.Point(26, 130);
            this.cbAudioOutputDevice.Name = "cbAudioOutputDevice";
            this.cbAudioOutputDevice.Size = new System.Drawing.Size(190, 21);
            this.cbAudioOutputDevice.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Output device";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Input format";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Audio codec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sample rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "BPS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Channels";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Video codec";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "Input line";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "Input device";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(313, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 53);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(183, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 53);
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 82;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(347, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "Balance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(239, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 78;
            this.label19.Text = "Volume";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 71;
            this.label20.Text = "Output device";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(239, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "Input format";
            // 
            // llVideoTutorials
            // 
            this.llVideoTutorials.AutoSize = true;
            this.llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.llVideoTutorials.Location = new System.Drawing.Point(750, 4);
            this.llVideoTutorials.Name = "llVideoTutorials";
            this.llVideoTutorials.Size = new System.Drawing.Size(68, 13);
            this.llVideoTutorials.TabIndex = 92;
            this.llVideoTutorials.TabStop = true;
            this.llVideoTutorials.Text = "Video tutorial";
            this.llVideoTutorials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVideoTutorials_LinkClicked);
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
            this.VideoCapture1.Location = new System.Drawing.Point(387, 26);
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
            this.VideoCapture1.SeparateCapture_TimeThreshold = ((long)(0));
            this.VideoCapture1.Size = new System.Drawing.Size(430, 308);
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
            videoRendererSettingsWinForms1.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_X = 0;
            videoRendererSettingsWinForms1.Aspect_Ratio_Y = 0;
            videoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
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
            this.VideoCapture1.Video_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.VideoCapture1.VLC_Path = null;
            this.VideoCapture1.OnError += new System.EventHandler<VisioForge.Types.ErrorsEventArgs>(this.VideoCapture1_OnError);
            this.VideoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoCapture1_OnLicenseRequired);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(496, 337);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(214, 13);
            this.label34.TabIndex = 96;
            this.label34.Text = "Much more features available in Main Demo";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(384, 417);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 13);
            this.label35.TabIndex = 97;
            this.label35.Text = "Mode";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Preview",
            "Capture to AVI",
            "Capture to WMV",
            "Capture to MP4"});
            this.cbMode.Location = new System.Drawing.Point(424, 414);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 21);
            this.cbMode.TabIndex = 98;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(322, 13);
            this.label36.TabIndex = 3;
            this.label36.Text = "Supported GPUs - Intel, nVidia and AMD. H264 and H265 codecs.";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(303, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Please use Main Demo to configure CPU encoder or use GPU.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 442);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.VideoCapture1);
            this.Controls.Add(this.llVideoTutorials);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSelectOutput);
            this.Controls.Add(this.edOutput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Screen Capture Demo - VisioForge Video Capture SDK .Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageLogoTransp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTextLogoTransp)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJPEGQuality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVUMeter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVUMeter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btSelectOutput;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btScreenCaptureUpdate;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.CheckBox cbScreenCapture_GrabMouseCursor;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox edScreenFrameRate;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox edScreenBottom;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox edScreenRight;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox edScreenTop;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox edScreenLeft;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton rbScreenCustomArea;
        private System.Windows.Forms.RadioButton rbScreenFullScreen;
        private System.Windows.Forms.CheckBox cbRecordAudio;
        private System.Windows.Forms.CheckBox cbUncAudio;
        private System.Windows.Forms.CheckBox cbDecodeToRGB;
        private System.Windows.Forms.CheckBox cbUncVideo;
        private System.Windows.Forms.CheckBox cbUseLameInAVI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbVUMeter2;
        private System.Windows.Forms.PictureBox pbVUMeter1;
        private System.Windows.Forms.TextBox edVUMeterValues;
        private System.Windows.Forms.CheckBox cbVUMeters;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TrackBar tbAudioBalance;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TrackBar tbAudioVolume;
        private System.Windows.Forms.CheckBox cbPlayAudio;
        private System.Windows.Forms.CheckBox cbUseAudioInputFromVideoCaptureDevice;
        private System.Windows.Forms.ComboBox cbAudioOutputDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbUseBestAudioInputFormat;
        private System.Windows.Forms.Button btAudioInputDeviceSettings;
        private System.Windows.Forms.ComboBox cbAudioInputLine;
        private System.Windows.Forms.ComboBox cbAudioInputFormat;
        private System.Windows.Forms.ComboBox cbAudioInputDevice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TrackBar tbTextLogoTransp;
        private System.Windows.Forms.TextBox edTextLogoTop;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.TextBox edTextLogoLeft;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.TextBox edTextLogo;
        private System.Windows.Forms.CheckBox cbTextLogo;
        private System.Windows.Forms.TextBox edImageLogoTop;
        private System.Windows.Forms.CheckBox cbImageLogo;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TrackBar tbImageLogoTransp;
        private System.Windows.Forms.TextBox edImageLogoLeft;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Button btSelectImage;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.TextBox edImageLogoFilename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbImageType;
        private System.Windows.Forms.Label lbJPEGQuality;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btSaveScreenshot;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox edScreenshotsFolder;
        private System.Windows.Forms.TrackBar tbJPEGQuality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        internal System.Windows.Forms.LinkLabel llVideoTutorials;
        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.ComboBox cbScreenCaptureDisplayIndex;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.TextBox edScreenCaptureWindowName;
        private System.Windows.Forms.RadioButton rbScreenCaptureWindow;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
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
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cbWMVInternalProfile9;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.CheckBox cbScreenCapture_DesktopDuplication;
        private System.Windows.Forms.CheckBox cbLicensing;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
    }
}

