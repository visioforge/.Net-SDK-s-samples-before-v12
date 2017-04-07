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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btClearList = new System.Windows.Forms.Button();
            this.btAddInputFile = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbConvert = new System.Windows.Forms.RadioButton();
            this.VideoEdit1 = new VisioForge.Controls.UI.WinForms.VideoEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btSelectOutput = new System.Windows.Forms.Button();
            this.edOutput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbWMV = new System.Windows.Forms.RadioButton();
            this.rbAVI = new System.Windows.Forms.RadioButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBPS = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSampleRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.btAudioSettings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAudioCodec = new System.Windows.Forms.ComboBox();
            this.btVideoSettings = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVideoCodec = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbWMVInternalProfile9 = new System.Windows.Forms.ComboBox();
            this.cbFrameRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edHeight = new System.Windows.Forms.TextBox();
            this.edWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResize = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.edTransStopTime = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.edTransStartTime = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btAddTransition = new System.Windows.Forms.Button();
            this.cbTransitionName = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.lbTransitions = new System.Windows.Forms.ListBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.OpenDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageLogoTransp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTextLogoTransp)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(685, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 90;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Watch tutorials";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mmLog
            // 
            this.mmLog.Location = new System.Drawing.Point(12, 440);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(326, 45);
            this.mmLog.TabIndex = 89;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(9, 424);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(100, 13);
            this.label120.TabIndex = 88;
            this.label120.Text = "Errors and warnings";
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(251, 423);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(87, 17);
            this.cbDebugMode.TabIndex = 87;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // rbPreview
            // 
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(454, 427);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(63, 17);
            this.rbPreview.TabIndex = 86;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(705, 424);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(58, 23);
            this.btStop.TabIndex = 85;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(638, 424);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(58, 23);
            this.btStart.TabIndex = 84;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btClearList
            // 
            this.btClearList.Location = new System.Drawing.Point(699, 62);
            this.btClearList.Name = "btClearList";
            this.btClearList.Size = new System.Drawing.Size(64, 23);
            this.btClearList.TabIndex = 83;
            this.btClearList.Text = "Clear";
            this.btClearList.UseVisualStyleBackColor = true;
            this.btClearList.Click += new System.EventHandler(this.btClearList_Click);
            // 
            // btAddInputFile
            // 
            this.btAddInputFile.Location = new System.Drawing.Point(699, 33);
            this.btAddInputFile.Name = "btAddInputFile";
            this.btAddInputFile.Size = new System.Drawing.Size(64, 23);
            this.btAddInputFile.TabIndex = 82;
            this.btAddInputFile.Text = "Add";
            this.btAddInputFile.UseVisualStyleBackColor = true;
            this.btAddInputFile.Click += new System.EventHandler(this.btAddInputFile_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(348, 33);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(345, 56);
            this.lbFiles.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Input files:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(348, 462);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(415, 23);
            this.ProgressBar1.TabIndex = 79;
            // 
            // rbConvert
            // 
            this.rbConvert.AutoSize = true;
            this.rbConvert.Location = new System.Drawing.Point(348, 427);
            this.rbConvert.Name = "rbConvert";
            this.rbConvert.Size = new System.Drawing.Size(91, 17);
            this.rbConvert.TabIndex = 78;
            this.rbConvert.Text = "Convert video";
            this.rbConvert.UseVisualStyleBackColor = true;
            // 
            // VideoEdit1
            // 
            this.VideoEdit1.Audio_Effects_Enabled = false;
            this.VideoEdit1.Audio_Effects_UseLegacyEffects = false;
            this.VideoEdit1.Audio_Enhancer_Enabled = false;
            this.VideoEdit1.Audio_Preview_Enabled = false;
            this.VideoEdit1.BackColor = System.Drawing.Color.Black;
            this.VideoEdit1.Barcode_Reader_Enabled = false;
            this.VideoEdit1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.VideoEdit1.Debug_Dir = "";
            this.VideoEdit1.Debug_Mode = false;
            this.VideoEdit1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.VideoEdit1.Dynamic_Reconnection = false;
            this.VideoEdit1.Location = new System.Drawing.Point(348, 95);
            this.VideoEdit1.Mode = VisioForge.Types.VFVideoEditMode.Convert;
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
            this.VideoEdit1.Size = new System.Drawing.Size(415, 319);
            this.VideoEdit1.Start_DelayEnabled = false;
            this.VideoEdit1.TabIndex = 91;
            this.VideoEdit1.UseLibMediaInfo = false;
            this.VideoEdit1.Video_Custom_Resizer_CLSID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.VideoEdit1.Video_Effects_Enabled = false;
            this.VideoEdit1.Video_FrameRate = 25D;
            this.VideoEdit1.Video_Preview_Enabled = true;
            this.VideoEdit1.Video_Resize = false;
            this.VideoEdit1.Video_Resize_Height = 480;
            this.VideoEdit1.Video_Resize_Width = 640;
            this.VideoEdit1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoEdit1.Virtual_Camera_Output_Enabled = false;
            this.VideoEdit1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoEdit1_OnLicenseRequired);
            this.VideoEdit1.OnProgress += new System.EventHandler<VisioForge.Types.ProgressEventArgs>(this.VideoEdit1_OnProgress);
            this.VideoEdit1.OnStop += new System.EventHandler<System.EventArgs>(this.VideoEdit1_OnStop);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 402);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btSelectOutput);
            this.tabPage1.Controls.Add(this.edOutput);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbWMV);
            this.tabPage1.Controls.Add(this.rbAVI);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.cbFrameRate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.edHeight);
            this.tabPage1.Controls.Add(this.edWidth);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbResize);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btSelectOutput
            // 
            this.btSelectOutput.Location = new System.Drawing.Point(279, 345);
            this.btSelectOutput.Name = "btSelectOutput";
            this.btSelectOutput.Size = new System.Drawing.Size(26, 23);
            this.btSelectOutput.TabIndex = 58;
            this.btSelectOutput.Text = "...";
            this.btSelectOutput.UseVisualStyleBackColor = true;
            this.btSelectOutput.Click += new System.EventHandler(this.btSelectOutput_Click);
            // 
            // edOutput
            // 
            this.edOutput.Location = new System.Drawing.Point(74, 347);
            this.edOutput.Name = "edOutput";
            this.edOutput.Size = new System.Drawing.Size(199, 20);
            this.edOutput.TabIndex = 57;
            this.edOutput.Text = "c:\\vf\\video_edit_output.avi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Output file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Other output formats available in Main Demo";
            // 
            // rbWMV
            // 
            this.rbWMV.AutoSize = true;
            this.rbWMV.Location = new System.Drawing.Point(89, 89);
            this.rbWMV.Name = "rbWMV";
            this.rbWMV.Size = new System.Drawing.Size(52, 17);
            this.rbWMV.TabIndex = 54;
            this.rbWMV.Text = "WMV";
            this.rbWMV.UseVisualStyleBackColor = true;
            // 
            // rbAVI
            // 
            this.rbAVI.AutoSize = true;
            this.rbAVI.Checked = true;
            this.rbAVI.Location = new System.Drawing.Point(16, 89);
            this.rbAVI.Name = "rbAVI";
            this.rbAVI.Size = new System.Drawing.Size(42, 17);
            this.rbAVI.TabIndex = 53;
            this.rbAVI.TabStop = true;
            this.rbAVI.Text = "AVI";
            this.rbAVI.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(16, 115);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(289, 190);
            this.tabControl2.TabIndex = 52;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbBPS);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cbSampleRate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbChannels);
            this.tabPage3.Controls.Add(this.btAudioSettings);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cbAudioCodec);
            this.tabPage3.Controls.Add(this.btVideoSettings);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cbVideoCodec);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(281, 164);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "AVI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "BPS";
            // 
            // cbBPS
            // 
            this.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBPS.FormattingEnabled = true;
            this.cbBPS.Items.AddRange(new object[] {
            "16",
            "8"});
            this.cbBPS.Location = new System.Drawing.Point(197, 109);
            this.cbBPS.Name = "cbBPS";
            this.cbBPS.Size = new System.Drawing.Size(51, 21);
            this.cbBPS.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Sample rate";
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
            this.cbSampleRate.Location = new System.Drawing.Point(71, 136);
            this.cbSampleRate.Name = "cbSampleRate";
            this.cbSampleRate.Size = new System.Drawing.Size(78, 21);
            this.cbSampleRate.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Channels";
            // 
            // cbChannels
            // 
            this.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Items.AddRange(new object[] {
            "2",
            "1"});
            this.cbChannels.Location = new System.Drawing.Point(71, 109);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(78, 21);
            this.cbChannels.TabIndex = 45;
            // 
            // btAudioSettings
            // 
            this.btAudioSettings.Location = new System.Drawing.Point(197, 78);
            this.btAudioSettings.Name = "btAudioSettings";
            this.btAudioSettings.Size = new System.Drawing.Size(66, 23);
            this.btAudioSettings.TabIndex = 44;
            this.btAudioSettings.Text = "Settings";
            this.btAudioSettings.UseVisualStyleBackColor = true;
            this.btAudioSettings.Click += new System.EventHandler(this.btAudioSettings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Audio codec:";
            // 
            // cbAudioCodec
            // 
            this.cbAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioCodec.FormattingEnabled = true;
            this.cbAudioCodec.Location = new System.Drawing.Point(10, 80);
            this.cbAudioCodec.Name = "cbAudioCodec";
            this.cbAudioCodec.Size = new System.Drawing.Size(179, 21);
            this.cbAudioCodec.TabIndex = 42;
            this.cbAudioCodec.SelectedIndexChanged += new System.EventHandler(this.cbAudioCodec_SelectedIndexChanged);
            // 
            // btVideoSettings
            // 
            this.btVideoSettings.Location = new System.Drawing.Point(197, 26);
            this.btVideoSettings.Name = "btVideoSettings";
            this.btVideoSettings.Size = new System.Drawing.Size(66, 23);
            this.btVideoSettings.TabIndex = 41;
            this.btVideoSettings.Text = "Settings";
            this.btVideoSettings.UseVisualStyleBackColor = true;
            this.btVideoSettings.Click += new System.EventHandler(this.btVideoSettings_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Video codec:";
            // 
            // cbVideoCodec
            // 
            this.cbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoCodec.FormattingEnabled = true;
            this.cbVideoCodec.Location = new System.Drawing.Point(10, 28);
            this.cbVideoCodec.Name = "cbVideoCodec";
            this.cbVideoCodec.Size = new System.Drawing.Size(179, 21);
            this.cbVideoCodec.TabIndex = 39;
            this.cbVideoCodec.SelectedIndexChanged += new System.EventHandler(this.cbVideoCodec_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.cbWMVInternalProfile9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(281, 164);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "WMV";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Other WMV features shown in Main Demo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Profile name";
            // 
            // cbWMVInternalProfile9
            // 
            this.cbWMVInternalProfile9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWMVInternalProfile9.FormattingEnabled = true;
            this.cbWMVInternalProfile9.Location = new System.Drawing.Point(12, 29);
            this.cbWMVInternalProfile9.Name = "cbWMVInternalProfile9";
            this.cbWMVInternalProfile9.Size = new System.Drawing.Size(257, 21);
            this.cbWMVInternalProfile9.TabIndex = 23;
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
            this.cbFrameRate.Location = new System.Drawing.Point(89, 44);
            this.cbFrameRate.Name = "cbFrameRate";
            this.cbFrameRate.Size = new System.Drawing.Size(48, 21);
            this.cbFrameRate.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Frame rate:";
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(161, 14);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(48, 20);
            this.edHeight.TabIndex = 49;
            this.edHeight.Text = "576";
            // 
            // edWidth
            // 
            this.edWidth.Location = new System.Drawing.Point(89, 14);
            this.edWidth.Name = "edWidth";
            this.edWidth.Size = new System.Drawing.Size(48, 20);
            this.edWidth.TabIndex = 48;
            this.edWidth.Text = "768";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "x";
            // 
            // cbResize
            // 
            this.cbResize.AutoSize = true;
            this.cbResize.Location = new System.Drawing.Point(16, 17);
            this.cbResize.Name = "cbResize";
            this.cbResize.Size = new System.Drawing.Size(58, 17);
            this.cbResize.TabIndex = 46;
            this.cbResize.Text = "Resize";
            this.cbResize.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.lbTransitions);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transitions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.edTransStopTime);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.edTransStartTime);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.btAddTransition);
            this.groupBox5.Controls.Add(this.cbTransitionName);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Location = new System.Drawing.Point(16, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 144);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add transition";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(133, 110);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(20, 13);
            this.label47.TabIndex = 8;
            this.label47.Text = "ms";
            // 
            // edTransStopTime
            // 
            this.edTransStopTime.Location = new System.Drawing.Point(84, 107);
            this.edTransStopTime.Name = "edTransStopTime";
            this.edTransStopTime.Size = new System.Drawing.Size(43, 20);
            this.edTransStopTime.TabIndex = 7;
            this.edTransStopTime.Text = "5000";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(12, 110);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(51, 13);
            this.label48.TabIndex = 6;
            this.label48.Text = "Stop time";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(133, 84);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(20, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "ms";
            // 
            // edTransStartTime
            // 
            this.edTransStartTime.Location = new System.Drawing.Point(84, 81);
            this.edTransStartTime.Name = "edTransStartTime";
            this.edTransStartTime.Size = new System.Drawing.Size(43, 20);
            this.edTransStartTime.TabIndex = 4;
            this.edTransStartTime.Text = "4000";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(12, 84);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(51, 13);
            this.label45.TabIndex = 3;
            this.label45.Text = "Start time";
            // 
            // btAddTransition
            // 
            this.btAddTransition.Location = new System.Drawing.Point(203, 42);
            this.btAddTransition.Name = "btAddTransition";
            this.btAddTransition.Size = new System.Drawing.Size(42, 23);
            this.btAddTransition.TabIndex = 2;
            this.btAddTransition.Text = "Add";
            this.btAddTransition.UseVisualStyleBackColor = true;
            this.btAddTransition.Click += new System.EventHandler(this.btAddTransition_Click);
            // 
            // cbTransitionName
            // 
            this.cbTransitionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransitionName.FormattingEnabled = true;
            this.cbTransitionName.Location = new System.Drawing.Point(15, 44);
            this.cbTransitionName.Name = "cbTransitionName";
            this.cbTransitionName.Size = new System.Drawing.Size(182, 21);
            this.cbTransitionName.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 28);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 13);
            this.label44.TabIndex = 0;
            this.label44.Text = "Name";
            // 
            // lbTransitions
            // 
            this.lbTransitions.FormattingEnabled = true;
            this.lbTransitions.Location = new System.Drawing.Point(16, 25);
            this.lbTransitions.Name = "lbTransitions";
            this.lbTransitions.Size = new System.Drawing.Size(251, 82);
            this.lbTransitions.TabIndex = 4;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(13, 9);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(49, 13);
            this.label43.TabIndex = 3;
            this.label43.Text = "Selected";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.edImageLogoTop);
            this.tabPage5.Controls.Add(this.cbImageLogo);
            this.tabPage5.Controls.Add(this.label155);
            this.tabPage5.Controls.Add(this.tbImageLogoTransp);
            this.tabPage5.Controls.Add(this.edImageLogoLeft);
            this.tabPage5.Controls.Add(this.label156);
            this.tabPage5.Controls.Add(this.label154);
            this.tabPage5.Controls.Add(this.btSelectImage);
            this.tabPage5.Controls.Add(this.label157);
            this.tabPage5.Controls.Add(this.edImageLogoFilename);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.tbTextLogoTransp);
            this.tabPage5.Controls.Add(this.edTextLogoTop);
            this.tabPage5.Controls.Add(this.label139);
            this.tabPage5.Controls.Add(this.edTextLogoLeft);
            this.tabPage5.Controls.Add(this.label140);
            this.tabPage5.Controls.Add(this.btFont);
            this.tabPage5.Controls.Add(this.edTextLogo);
            this.tabPage5.Controls.Add(this.cbTextLogo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(322, 376);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Video processing";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // edImageLogoTop
            // 
            this.edImageLogoTop.Location = new System.Drawing.Point(56, 267);
            this.edImageLogoTop.Name = "edImageLogoTop";
            this.edImageLogoTop.Size = new System.Drawing.Size(39, 20);
            this.edImageLogoTop.TabIndex = 75;
            this.edImageLogoTop.Text = "50";
            this.edImageLogoTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbImageLogo
            // 
            this.cbImageLogo.AutoSize = true;
            this.cbImageLogo.Location = new System.Drawing.Point(10, 180);
            this.cbImageLogo.Name = "cbImageLogo";
            this.cbImageLogo.Size = new System.Drawing.Size(78, 17);
            this.cbImageLogo.TabIndex = 76;
            this.cbImageLogo.Text = "Image logo";
            this.cbImageLogo.UseVisualStyleBackColor = true;
            this.cbImageLogo.CheckedChanged += new System.EventHandler(this.cbImageLogo_CheckedChanged);
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(23, 270);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(26, 13);
            this.label155.TabIndex = 74;
            this.label155.Text = "Top";
            // 
            // tbImageLogoTransp
            // 
            this.tbImageLogoTransp.BackColor = System.Drawing.SystemColors.Window;
            this.tbImageLogoTransp.Location = new System.Drawing.Point(132, 260);
            this.tbImageLogoTransp.Maximum = 255;
            this.tbImageLogoTransp.Name = "tbImageLogoTransp";
            this.tbImageLogoTransp.Size = new System.Drawing.Size(104, 45);
            this.tbImageLogoTransp.TabIndex = 80;
            this.tbImageLogoTransp.Scroll += new System.EventHandler(this.tbGraphicLogoTransp_Scroll);
            // 
            // edImageLogoLeft
            // 
            this.edImageLogoLeft.Location = new System.Drawing.Point(56, 241);
            this.edImageLogoLeft.Name = "edImageLogoLeft";
            this.edImageLogoLeft.Size = new System.Drawing.Size(39, 20);
            this.edImageLogoLeft.TabIndex = 73;
            this.edImageLogoLeft.Text = "50";
            this.edImageLogoLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(23, 244);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(25, 13);
            this.label156.TabIndex = 72;
            this.label156.Text = "Left";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(133, 244);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(72, 13);
            this.label154.TabIndex = 81;
            this.label154.Text = "Transparency";
            // 
            // btSelectImage
            // 
            this.btSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelectImage.Location = new System.Drawing.Point(291, 201);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(24, 23);
            this.btSelectImage.TabIndex = 79;
            this.btSelectImage.Text = "...";
            this.btSelectImage.UseVisualStyleBackColor = true;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(23, 206);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(52, 13);
            this.label157.TabIndex = 78;
            this.label157.Text = "File name";
            // 
            // edImageLogoFilename
            // 
            this.edImageLogoFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edImageLogoFilename.Location = new System.Drawing.Point(81, 203);
            this.edImageLogoFilename.Name = "edImageLogoFilename";
            this.edImageLogoFilename.Size = new System.Drawing.Size(201, 20);
            this.edImageLogoFilename.TabIndex = 77;
            this.edImageLogoFilename.Text = "c:\\logo.png";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(133, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 13);
            this.label32.TabIndex = 71;
            this.label32.Text = "Transparency (layer)";
            // 
            // tbTextLogoTransp
            // 
            this.tbTextLogoTransp.BackColor = System.Drawing.SystemColors.Window;
            this.tbTextLogoTransp.Location = new System.Drawing.Point(133, 86);
            this.tbTextLogoTransp.Maximum = 255;
            this.tbTextLogoTransp.Name = "tbTextLogoTransp";
            this.tbTextLogoTransp.Size = new System.Drawing.Size(103, 45);
            this.tbTextLogoTransp.TabIndex = 70;
            this.tbTextLogoTransp.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTextLogoTransp.Value = 127;
            this.tbTextLogoTransp.Scroll += new System.EventHandler(this.tbTextLogoTransp_Scroll);
            // 
            // edTextLogoTop
            // 
            this.edTextLogoTop.Location = new System.Drawing.Point(56, 93);
            this.edTextLogoTop.Name = "edTextLogoTop";
            this.edTextLogoTop.Size = new System.Drawing.Size(33, 20);
            this.edTextLogoTop.TabIndex = 69;
            this.edTextLogoTop.Text = "50";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(20, 96);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(26, 13);
            this.label139.TabIndex = 68;
            this.label139.Text = "Top";
            // 
            // edTextLogoLeft
            // 
            this.edTextLogoLeft.Location = new System.Drawing.Point(56, 67);
            this.edTextLogoLeft.Name = "edTextLogoLeft";
            this.edTextLogoLeft.Size = new System.Drawing.Size(33, 20);
            this.edTextLogoLeft.TabIndex = 67;
            this.edTextLogoLeft.Text = "50";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(20, 70);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(25, 13);
            this.label140.TabIndex = 66;
            this.label140.Text = "Left";
            // 
            // btFont
            // 
            this.btFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFont.Location = new System.Drawing.Point(268, 33);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(47, 23);
            this.btFont.TabIndex = 65;
            this.btFont.Text = "Font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // edTextLogo
            // 
            this.edTextLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edTextLogo.Location = new System.Drawing.Point(23, 35);
            this.edTextLogo.Name = "edTextLogo";
            this.edTextLogo.Size = new System.Drawing.Size(242, 20);
            this.edTextLogo.TabIndex = 64;
            this.edTextLogo.Text = "Hello!!!";
            // 
            // cbTextLogo
            // 
            this.cbTextLogo.AutoSize = true;
            this.cbTextLogo.Location = new System.Drawing.Point(10, 12);
            this.cbTextLogo.Name = "cbTextLogo";
            this.cbTextLogo.Size = new System.Drawing.Size(70, 17);
            this.cbTextLogo.TabIndex = 63;
            this.cbTextLogo.Text = "Text logo";
            this.cbTextLogo.UseVisualStyleBackColor = true;
            this.cbTextLogo.CheckedChanged += new System.EventHandler(this.cbTextLogo_CheckedChanged);
            // 
            // OpenDialog1
            // 
            this.OpenDialog1.Filter = resources.GetString("OpenDialog1.Filter");
            // 
            // SaveDialog1
            // 
            this.SaveDialog1.Filter = "AVI  (*.avi) | *.avi|Windows Media Video (*.wmv)| *.wmv|Matroska  (*.mkv)| *.mkv|" +
    "All files  (*.*)| *.*";
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
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(154, 423);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(91, 17);
            this.cbLicensing.TabIndex = 93;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 496);
            this.Controls.Add(this.cbLicensing);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.VideoEdit1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.mmLog);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.cbDebugMode);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btAddInputFile);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.rbConvert);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VisioForge Video Edit SDK .Net - Video From Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageLogoTransp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTextLogoTransp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClearList;
        private System.Windows.Forms.Button btAddInputFile;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.RadioButton rbConvert;
        private VisioForge.Controls.UI.WinForms.VideoEdit VideoEdit1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox edTransStopTime;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox edTransStartTime;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btAddTransition;
        private System.Windows.Forms.ComboBox cbTransitionName;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ListBox lbTransitions;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbFrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edHeight;
        private System.Windows.Forms.TextBox edWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWMV;
        private System.Windows.Forms.RadioButton rbAVI;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSampleRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.Button btAudioSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAudioCodec;
        private System.Windows.Forms.Button btVideoSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVideoCodec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbWMVInternalProfile9;
        private System.Windows.Forms.OpenFileDialog OpenDialog1;
        private System.Windows.Forms.SaveFileDialog SaveDialog1;
        private System.Windows.Forms.Button btSelectOutput;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
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
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TrackBar tbTextLogoTransp;
        private System.Windows.Forms.TextBox edTextLogoTop;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.TextBox edTextLogoLeft;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.TextBox edTextLogo;
        private System.Windows.Forms.CheckBox cbTextLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.CheckBox cbLicensing;
    }
}

