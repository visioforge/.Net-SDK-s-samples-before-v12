using VisioForge.Types;
using System;

namespace VisioForge_SDK_Video_Capture_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbUseAudioInputFromVideoCaptureDevice = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUseBestVideoInputFormat = new System.Windows.Forms.CheckBox();
            this.btVideoCaptureDeviceSettings = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.cbFramerate = new System.Windows.Forms.ComboBox();
            this.cbVideoInputFormat = new System.Windows.Forms.ComboBox();
            this.cbVideoInputDevice = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tbAudioBalance = new System.Windows.Forms.TrackBar();
            this.label54 = new System.Windows.Forms.Label();
            this.tbAudioVolume = new System.Windows.Forms.TrackBar();
            this.cbRecordAudio = new System.Windows.Forms.CheckBox();
            this.cbAudioOutputDevice = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbUseBestAudioInputFormat = new System.Windows.Forms.CheckBox();
            this.btAudioInputDeviceSettings = new System.Windows.Forms.Button();
            this.cbAudioInputLine = new System.Windows.Forms.ComboBox();
            this.cbAudioInputFormat = new System.Windows.Forms.ComboBox();
            this.cbAudioInputDevice = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btSelectOutput = new System.Windows.Forms.Button();
            this.edOutput = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btOutputConfigure = new System.Windows.Forms.Button();
            this.cbOutputFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbMergeTextLogos = new System.Windows.Forms.CheckBox();
            this.cbMergeImageLogos = new System.Windows.Forms.CheckBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.btTextLogoAdd = new System.Windows.Forms.Button();
            this.btLogoRemove = new System.Windows.Forms.Button();
            this.btLogoEdit = new System.Windows.Forms.Button();
            this.lbLogos = new System.Windows.Forms.ListBox();
            this.btImageLogoAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl18 = new System.Windows.Forms.TabControl();
            this.tabPage71 = new System.Windows.Forms.TabPage();
            this.label231 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.tbAudAmplifyAmp = new System.Windows.Forms.TrackBar();
            this.label95 = new System.Windows.Forms.Label();
            this.cbAudAmplifyEnabled = new System.Windows.Forms.CheckBox();
            this.tabPage72 = new System.Windows.Forms.TabPage();
            this.btAudEqRefresh = new System.Windows.Forms.Button();
            this.cbAudEqualizerPreset = new System.Windows.Forms.ComboBox();
            this.label243 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.tbAudEq9 = new System.Windows.Forms.TrackBar();
            this.tbAudEq8 = new System.Windows.Forms.TrackBar();
            this.tbAudEq7 = new System.Windows.Forms.TrackBar();
            this.tbAudEq6 = new System.Windows.Forms.TrackBar();
            this.tbAudEq5 = new System.Windows.Forms.TrackBar();
            this.tbAudEq4 = new System.Windows.Forms.TrackBar();
            this.tbAudEq3 = new System.Windows.Forms.TrackBar();
            this.tbAudEq2 = new System.Windows.Forms.TrackBar();
            this.tbAudEq1 = new System.Windows.Forms.TrackBar();
            this.tbAudEq0 = new System.Windows.Forms.TrackBar();
            this.cbAudEqualizerEnabled = new System.Windows.Forms.CheckBox();
            this.tabPage76 = new System.Windows.Forms.TabPage();
            this.tbAudTrueBass = new System.Windows.Forms.TrackBar();
            this.label254 = new System.Windows.Forms.Label();
            this.cbAudTrueBassEnabled = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.llVideoTutorials = new System.Windows.Forms.LinkLabel();
            this.label34 = new System.Windows.Forms.Label();
            this.lbTimestamp = new System.Windows.Forms.Label();
            this.rbCapture = new System.Windows.Forms.RadioButton();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btSaveScreenshot = new System.Windows.Forms.Button();
            this.btResume = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.VideoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioVolume)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl18.SuspendLayout();
            this.tabPage71.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudAmplifyAmp)).BeginInit();
            this.tabPage72.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq0)).BeginInit();
            this.tabPage76.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudTrueBass)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStop.Location = new System.Drawing.Point(456, 407);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 54;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(388, 407);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 23);
            this.btStart.TabIndex = 53;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Controls.Add(this.tabPage5);
            this.tcMain.Controls.Add(this.tabPage4);
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(378, 427);
            this.tcMain.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbUseAudioInputFromVideoCaptureDevice);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbUseBestVideoInputFormat);
            this.tabPage1.Controls.Add(this.btVideoCaptureDeviceSettings);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.cbFramerate);
            this.tabPage1.Controls.Add(this.cbVideoInputFormat);
            this.tabPage1.Controls.Add(this.cbVideoInputDevice);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.tbAudioBalance);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.tbAudioVolume);
            this.tabPage1.Controls.Add(this.cbRecordAudio);
            this.tabPage1.Controls.Add(this.cbAudioOutputDevice);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cbUseBestAudioInputFormat);
            this.tabPage1.Controls.Add(this.btAudioInputDeviceSettings);
            this.tabPage1.Controls.Add(this.cbAudioInputLine);
            this.tabPage1.Controls.Add(this.cbAudioInputFormat);
            this.tabPage1.Controls.Add(this.cbAudioInputDevice);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Devices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbUseAudioInputFromVideoCaptureDevice
            // 
            this.cbUseAudioInputFromVideoCaptureDevice.AutoSize = true;
            this.cbUseAudioInputFromVideoCaptureDevice.Location = new System.Drawing.Point(173, 172);
            this.cbUseAudioInputFromVideoCaptureDevice.Name = "cbUseAudioInputFromVideoCaptureDevice";
            this.cbUseAudioInputFromVideoCaptureDevice.Size = new System.Drawing.Size(187, 17);
            this.cbUseAudioInputFromVideoCaptureDevice.TabIndex = 129;
            this.cbUseAudioInputFromVideoCaptureDevice.Text = "Use audio input from video source";
            this.cbUseAudioInputFromVideoCaptureDevice.UseVisualStyleBackColor = true;
            this.cbUseAudioInputFromVideoCaptureDevice.CheckedChanged += new System.EventHandler(this.cbUseAudioInputFromVideoCaptureDevice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "fps";
            // 
            // cbUseBestVideoInputFormat
            // 
            this.cbUseBestVideoInputFormat.AutoSize = true;
            this.cbUseBestVideoInputFormat.Location = new System.Drawing.Point(188, 72);
            this.cbUseBestVideoInputFormat.Name = "cbUseBestVideoInputFormat";
            this.cbUseBestVideoInputFormat.Size = new System.Drawing.Size(68, 17);
            this.cbUseBestVideoInputFormat.TabIndex = 127;
            this.cbUseBestVideoInputFormat.Text = "Use best";
            this.cbUseBestVideoInputFormat.UseVisualStyleBackColor = true;
            this.cbUseBestVideoInputFormat.CheckedChanged += new System.EventHandler(this.cbUseBestVideoInputFormat_CheckedChanged);
            // 
            // btVideoCaptureDeviceSettings
            // 
            this.btVideoCaptureDeviceSettings.Location = new System.Drawing.Point(269, 34);
            this.btVideoCaptureDeviceSettings.Name = "btVideoCaptureDeviceSettings";
            this.btVideoCaptureDeviceSettings.Size = new System.Drawing.Size(66, 23);
            this.btVideoCaptureDeviceSettings.TabIndex = 126;
            this.btVideoCaptureDeviceSettings.Text = "Settings";
            this.btVideoCaptureDeviceSettings.UseVisualStyleBackColor = true;
            this.btVideoCaptureDeviceSettings.Click += new System.EventHandler(this.btVideoCaptureDeviceSettings_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 125;
            this.label18.Text = "Frame rate";
            // 
            // cbFramerate
            // 
            this.cbFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFramerate.FormattingEnabled = true;
            this.cbFramerate.Location = new System.Drawing.Point(269, 89);
            this.cbFramerate.Name = "cbFramerate";
            this.cbFramerate.Size = new System.Drawing.Size(65, 21);
            this.cbFramerate.TabIndex = 124;
            // 
            // cbVideoInputFormat
            // 
            this.cbVideoInputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoInputFormat.FormattingEnabled = true;
            this.cbVideoInputFormat.Location = new System.Drawing.Point(9, 89);
            this.cbVideoInputFormat.Name = "cbVideoInputFormat";
            this.cbVideoInputFormat.Size = new System.Drawing.Size(247, 21);
            this.cbVideoInputFormat.TabIndex = 123;
            this.cbVideoInputFormat.SelectedIndexChanged += new System.EventHandler(this.cbVideoInputFormat_SelectedIndexChanged);
            // 
            // cbVideoInputDevice
            // 
            this.cbVideoInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoInputDevice.FormattingEnabled = true;
            this.cbVideoInputDevice.Location = new System.Drawing.Point(9, 36);
            this.cbVideoInputDevice.Name = "cbVideoInputDevice";
            this.cbVideoInputDevice.Size = new System.Drawing.Size(247, 21);
            this.cbVideoInputDevice.TabIndex = 122;
            this.cbVideoInputDevice.SelectedIndexChanged += new System.EventHandler(this.cbVideoInputDevice_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "Video input format";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 120;
            this.label11.Text = "Video input device";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(198, 358);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(46, 13);
            this.label55.TabIndex = 90;
            this.label55.Text = "Balance";
            // 
            // tbAudioBalance
            // 
            this.tbAudioBalance.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudioBalance.Location = new System.Drawing.Point(249, 353);
            this.tbAudioBalance.Maximum = 100;
            this.tbAudioBalance.Minimum = -100;
            this.tbAudioBalance.Name = "tbAudioBalance";
            this.tbAudioBalance.Size = new System.Drawing.Size(114, 45);
            this.tbAudioBalance.TabIndex = 89;
            this.tbAudioBalance.TickFrequency = 5;
            this.tbAudioBalance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudioBalance.Scroll += new System.EventHandler(this.tbAudioBalance_Scroll);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(7, 358);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(42, 13);
            this.label54.TabIndex = 88;
            this.label54.Text = "Volume";
            // 
            // tbAudioVolume
            // 
            this.tbAudioVolume.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudioVolume.Location = new System.Drawing.Point(54, 353);
            this.tbAudioVolume.Maximum = 100;
            this.tbAudioVolume.Minimum = 20;
            this.tbAudioVolume.Name = "tbAudioVolume";
            this.tbAudioVolume.Size = new System.Drawing.Size(116, 45);
            this.tbAudioVolume.TabIndex = 87;
            this.tbAudioVolume.TickFrequency = 10;
            this.tbAudioVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudioVolume.Value = 80;
            this.tbAudioVolume.Scroll += new System.EventHandler(this.tbAudioVolume_Scroll);
            // 
            // cbRecordAudio
            // 
            this.cbRecordAudio.AutoSize = true;
            this.cbRecordAudio.Checked = true;
            this.cbRecordAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRecordAudio.Location = new System.Drawing.Point(253, 309);
            this.cbRecordAudio.Name = "cbRecordAudio";
            this.cbRecordAudio.Size = new System.Drawing.Size(115, 17);
            this.cbRecordAudio.TabIndex = 86;
            this.cbRecordAudio.Text = "Play/Record audio";
            this.cbRecordAudio.UseVisualStyleBackColor = true;
            // 
            // cbAudioOutputDevice
            // 
            this.cbAudioOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudioOutputDevice.FormattingEnabled = true;
            this.cbAudioOutputDevice.Location = new System.Drawing.Point(9, 326);
            this.cbAudioOutputDevice.Name = "cbAudioOutputDevice";
            this.cbAudioOutputDevice.Size = new System.Drawing.Size(354, 21);
            this.cbAudioOutputDevice.TabIndex = 85;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 84;
            this.label15.Text = "Audio output device";
            // 
            // cbUseBestAudioInputFormat
            // 
            this.cbUseBestAudioInputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseBestAudioInputFormat.AutoSize = true;
            this.cbUseBestAudioInputFormat.Location = new System.Drawing.Point(295, 227);
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
            this.btAudioInputDeviceSettings.Location = new System.Drawing.Point(287, 195);
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
            this.cbAudioInputLine.Location = new System.Drawing.Point(9, 251);
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
            this.cbAudioInputFormat.Location = new System.Drawing.Point(183, 250);
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
            this.cbAudioInputDevice.Location = new System.Drawing.Point(9, 197);
            this.cbAudioInputDevice.Name = "cbAudioInputDevice";
            this.cbAudioInputDevice.Size = new System.Drawing.Size(272, 21);
            this.cbAudioInputDevice.TabIndex = 79;
            this.cbAudioInputDevice.SelectedIndexChanged += new System.EventHandler(this.cbAudioInputDevice_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 229);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 78;
            this.label22.Text = "Audio input line";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 13);
            this.label23.TabIndex = 77;
            this.label23.Text = "Audio input device";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(180, 227);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 76;
            this.label25.Text = "Input format";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btSelectOutput);
            this.tabPage2.Controls.Add(this.edOutput);
            this.tabPage2.Controls.Add(this.lbInfo);
            this.tabPage2.Controls.Add(this.btOutputConfigure);
            this.tabPage2.Controls.Add(this.cbOutputFormat);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btSelectOutput
            // 
            this.btSelectOutput.Location = new System.Drawing.Point(340, 159);
            this.btSelectOutput.Name = "btSelectOutput";
            this.btSelectOutput.Size = new System.Drawing.Size(24, 23);
            this.btSelectOutput.TabIndex = 126;
            this.btSelectOutput.Text = "...";
            this.btSelectOutput.UseVisualStyleBackColor = true;
            this.btSelectOutput.Click += new System.EventHandler(this.btSelectOutput_Click);
            // 
            // edOutput
            // 
            this.edOutput.Location = new System.Drawing.Point(16, 161);
            this.edOutput.Name = "edOutput";
            this.edOutput.Size = new System.Drawing.Size(318, 20);
            this.edOutput.TabIndex = 125;
            this.edOutput.Text = "c:\\capture.avi";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(13, 61);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(267, 13);
            this.lbInfo.TabIndex = 124;
            this.lbInfo.Text = "You can use dialog or code to configure format settings";
            // 
            // btOutputConfigure
            // 
            this.btOutputConfigure.Location = new System.Drawing.Point(16, 77);
            this.btOutputConfigure.Name = "btOutputConfigure";
            this.btOutputConfigure.Size = new System.Drawing.Size(75, 23);
            this.btOutputConfigure.TabIndex = 123;
            this.btOutputConfigure.Text = "Configure";
            this.btOutputConfigure.UseVisualStyleBackColor = true;
            this.btOutputConfigure.Click += new System.EventHandler(this.btOutputConfigure_Click);
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
            "FFMPEG (external exe)",
            "MP4 v8/v10",
            "MP4 v11",
            "Animated GIF",
            "Encrypted video",
            "MPEG-TS",
            "MOV"});
            this.cbOutputFormat.Location = new System.Drawing.Point(16, 33);
            this.cbOutputFormat.Name = "cbOutputFormat";
            this.cbOutputFormat.Size = new System.Drawing.Size(348, 21);
            this.cbOutputFormat.TabIndex = 122;
            this.cbOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cbOutputFormat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "File name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Format";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbMergeTextLogos);
            this.tabPage3.Controls.Add(this.cbMergeImageLogos);
            this.tabPage3.Controls.Add(this.cbFlipY);
            this.tabPage3.Controls.Add(this.cbFlipX);
            this.tabPage3.Controls.Add(this.cbInvert);
            this.tabPage3.Controls.Add(this.cbGreyscale);
            this.tabPage3.Controls.Add(this.label201);
            this.tabPage3.Controls.Add(this.tbDarkness);
            this.tabPage3.Controls.Add(this.label200);
            this.tabPage3.Controls.Add(this.label199);
            this.tabPage3.Controls.Add(this.label198);
            this.tabPage3.Controls.Add(this.tbContrast);
            this.tabPage3.Controls.Add(this.tbLightness);
            this.tabPage3.Controls.Add(this.tbSaturation);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btTextLogoAdd);
            this.tabPage3.Controls.Add(this.btLogoRemove);
            this.tabPage3.Controls.Add(this.btLogoEdit);
            this.tabPage3.Controls.Add(this.lbLogos);
            this.tabPage3.Controls.Add(this.btImageLogoAdd);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(370, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Video effects";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbMergeTextLogos
            // 
            this.cbMergeTextLogos.AutoSize = true;
            this.cbMergeTextLogos.Location = new System.Drawing.Point(188, 155);
            this.cbMergeTextLogos.Name = "cbMergeTextLogos";
            this.cbMergeTextLogos.Size = new System.Drawing.Size(145, 17);
            this.cbMergeTextLogos.TabIndex = 87;
            this.cbMergeTextLogos.Text = "Merge text logos into one";
            this.cbMergeTextLogos.UseVisualStyleBackColor = true;
            // 
            // cbMergeImageLogos
            // 
            this.cbMergeImageLogos.AutoSize = true;
            this.cbMergeImageLogos.Location = new System.Drawing.Point(12, 155);
            this.cbMergeImageLogos.Name = "cbMergeImageLogos";
            this.cbMergeImageLogos.Size = new System.Drawing.Size(156, 17);
            this.cbMergeImageLogos.TabIndex = 86;
            this.cbMergeImageLogos.Text = "Merge image logos into one";
            this.cbMergeImageLogos.UseVisualStyleBackColor = true;
            // 
            // cbFlipY
            // 
            this.cbFlipY.AutoSize = true;
            this.cbFlipY.Location = new System.Drawing.Point(252, 328);
            this.cbFlipY.Name = "cbFlipY";
            this.cbFlipY.Size = new System.Drawing.Size(52, 17);
            this.cbFlipY.TabIndex = 85;
            this.cbFlipY.Text = "Flip Y";
            this.cbFlipY.UseVisualStyleBackColor = true;
            this.cbFlipY.CheckedChanged += new System.EventHandler(this.cbFlipY_CheckedChanged);
            // 
            // cbFlipX
            // 
            this.cbFlipX.AutoSize = true;
            this.cbFlipX.Location = new System.Drawing.Point(192, 328);
            this.cbFlipX.Name = "cbFlipX";
            this.cbFlipX.Size = new System.Drawing.Size(52, 17);
            this.cbFlipX.TabIndex = 84;
            this.cbFlipX.Text = "Flip X";
            this.cbFlipX.UseVisualStyleBackColor = true;
            this.cbFlipX.CheckedChanged += new System.EventHandler(this.cbFlipX_CheckedChanged);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbInvert.Location = new System.Drawing.Point(132, 328);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(53, 17);
            this.cbInvert.TabIndex = 83;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            this.cbInvert.CheckedChanged += new System.EventHandler(this.cbInvert_CheckedChanged);
            // 
            // cbGreyscale
            // 
            this.cbGreyscale.AutoSize = true;
            this.cbGreyscale.Location = new System.Drawing.Point(52, 328);
            this.cbGreyscale.Name = "cbGreyscale";
            this.cbGreyscale.Size = new System.Drawing.Size(73, 17);
            this.cbGreyscale.TabIndex = 82;
            this.cbGreyscale.Text = "Greyscale";
            this.cbGreyscale.UseVisualStyleBackColor = true;
            this.cbGreyscale.CheckedChanged += new System.EventHandler(this.cbGreyscale_CheckedChanged);
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(185, 258);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(52, 13);
            this.label201.TabIndex = 81;
            this.label201.Text = "Darkness";
            // 
            // tbDarkness
            // 
            this.tbDarkness.BackColor = System.Drawing.SystemColors.Window;
            this.tbDarkness.Location = new System.Drawing.Point(185, 277);
            this.tbDarkness.Maximum = 255;
            this.tbDarkness.Name = "tbDarkness";
            this.tbDarkness.Size = new System.Drawing.Size(130, 45);
            this.tbDarkness.TabIndex = 80;
            this.tbDarkness.Scroll += new System.EventHandler(this.tbDarkness_Scroll);
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(49, 258);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(46, 13);
            this.label200.TabIndex = 76;
            this.label200.Text = "Contrast";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(185, 206);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(55, 13);
            this.label199.TabIndex = 75;
            this.label199.Text = "Saturation";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(49, 206);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(52, 13);
            this.label198.TabIndex = 74;
            this.label198.Text = "Lightness";
            // 
            // tbContrast
            // 
            this.tbContrast.BackColor = System.Drawing.SystemColors.Window;
            this.tbContrast.Location = new System.Drawing.Point(46, 277);
            this.tbContrast.Maximum = 255;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(130, 45);
            this.tbContrast.TabIndex = 73;
            this.tbContrast.Scroll += new System.EventHandler(this.tbContrast_Scroll);
            // 
            // tbLightness
            // 
            this.tbLightness.BackColor = System.Drawing.SystemColors.Window;
            this.tbLightness.Location = new System.Drawing.Point(46, 221);
            this.tbLightness.Maximum = 255;
            this.tbLightness.Name = "tbLightness";
            this.tbLightness.Size = new System.Drawing.Size(130, 45);
            this.tbLightness.TabIndex = 72;
            this.tbLightness.Scroll += new System.EventHandler(this.tbLightness_Scroll);
            // 
            // tbSaturation
            // 
            this.tbSaturation.BackColor = System.Drawing.SystemColors.Window;
            this.tbSaturation.Location = new System.Drawing.Point(185, 221);
            this.tbSaturation.Maximum = 255;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(130, 45);
            this.tbSaturation.TabIndex = 71;
            this.tbSaturation.Value = 255;
            this.tbSaturation.Scroll += new System.EventHandler(this.tbSaturation_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Text / image logos";
            // 
            // btTextLogoAdd
            // 
            this.btTextLogoAdd.Location = new System.Drawing.Point(117, 126);
            this.btTextLogoAdd.Name = "btTextLogoAdd";
            this.btTextLogoAdd.Size = new System.Drawing.Size(99, 23);
            this.btTextLogoAdd.TabIndex = 68;
            this.btTextLogoAdd.Text = "Add text logo";
            this.btTextLogoAdd.UseVisualStyleBackColor = true;
            this.btTextLogoAdd.Click += new System.EventHandler(this.btTextLogoAdd_Click);
            // 
            // btLogoRemove
            // 
            this.btLogoRemove.Location = new System.Drawing.Point(298, 126);
            this.btLogoRemove.Name = "btLogoRemove";
            this.btLogoRemove.Size = new System.Drawing.Size(59, 23);
            this.btLogoRemove.TabIndex = 67;
            this.btLogoRemove.Text = "Remove";
            this.btLogoRemove.UseVisualStyleBackColor = true;
            this.btLogoRemove.Click += new System.EventHandler(this.btLogoRemove_Click);
            // 
            // btLogoEdit
            // 
            this.btLogoEdit.Location = new System.Drawing.Point(233, 126);
            this.btLogoEdit.Name = "btLogoEdit";
            this.btLogoEdit.Size = new System.Drawing.Size(59, 23);
            this.btLogoEdit.TabIndex = 66;
            this.btLogoEdit.Text = "Edit";
            this.btLogoEdit.UseVisualStyleBackColor = true;
            this.btLogoEdit.Click += new System.EventHandler(this.btLogoEdit_Click);
            // 
            // lbLogos
            // 
            this.lbLogos.FormattingEnabled = true;
            this.lbLogos.Location = new System.Drawing.Point(12, 25);
            this.lbLogos.Name = "lbLogos";
            this.lbLogos.Size = new System.Drawing.Size(345, 95);
            this.lbLogos.TabIndex = 65;
            // 
            // btImageLogoAdd
            // 
            this.btImageLogoAdd.Location = new System.Drawing.Point(12, 126);
            this.btImageLogoAdd.Name = "btImageLogoAdd";
            this.btImageLogoAdd.Size = new System.Drawing.Size(99, 23);
            this.btImageLogoAdd.TabIndex = 64;
            this.btImageLogoAdd.Text = "Add image logo";
            this.btImageLogoAdd.UseVisualStyleBackColor = true;
            this.btImageLogoAdd.Click += new System.EventHandler(this.btImageLogoAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "More effects and settings available in Main Demo";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.tabControl18);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(370, 401);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Audio effects";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "More effects and settings available in Main Demo";
            // 
            // tabControl18
            // 
            this.tabControl18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl18.Controls.Add(this.tabPage71);
            this.tabControl18.Controls.Add(this.tabPage72);
            this.tabControl18.Controls.Add(this.tabPage76);
            this.tabControl18.Location = new System.Drawing.Point(7, 6);
            this.tabControl18.Name = "tabControl18";
            this.tabControl18.SelectedIndex = 0;
            this.tabControl18.Size = new System.Drawing.Size(357, 347);
            this.tabControl18.TabIndex = 2;
            // 
            // tabPage71
            // 
            this.tabPage71.Controls.Add(this.label231);
            this.tabPage71.Controls.Add(this.label230);
            this.tabPage71.Controls.Add(this.tbAudAmplifyAmp);
            this.tabPage71.Controls.Add(this.label95);
            this.tabPage71.Controls.Add(this.cbAudAmplifyEnabled);
            this.tabPage71.Location = new System.Drawing.Point(4, 22);
            this.tabPage71.Name = "tabPage71";
            this.tabPage71.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage71.Size = new System.Drawing.Size(349, 321);
            this.tabPage71.TabIndex = 0;
            this.tabPage71.Text = "Amplify";
            this.tabPage71.UseVisualStyleBackColor = true;
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(244, 53);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(33, 13);
            this.label231.TabIndex = 5;
            this.label231.Text = "400%";
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(75, 53);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(33, 13);
            this.label230.TabIndex = 4;
            this.label230.Text = "100%";
            // 
            // tbAudAmplifyAmp
            // 
            this.tbAudAmplifyAmp.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudAmplifyAmp.Location = new System.Drawing.Point(16, 69);
            this.tbAudAmplifyAmp.Maximum = 4000;
            this.tbAudAmplifyAmp.Name = "tbAudAmplifyAmp";
            this.tbAudAmplifyAmp.Size = new System.Drawing.Size(261, 45);
            this.tbAudAmplifyAmp.TabIndex = 3;
            this.tbAudAmplifyAmp.TickFrequency = 50;
            this.tbAudAmplifyAmp.Value = 1000;
            this.tbAudAmplifyAmp.Scroll += new System.EventHandler(this.tbAudAmplifyAmp_Scroll);
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(13, 53);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(42, 13);
            this.label95.TabIndex = 2;
            this.label95.Text = "Volume";
            // 
            // cbAudAmplifyEnabled
            // 
            this.cbAudAmplifyEnabled.AutoSize = true;
            this.cbAudAmplifyEnabled.Location = new System.Drawing.Point(16, 16);
            this.cbAudAmplifyEnabled.Name = "cbAudAmplifyEnabled";
            this.cbAudAmplifyEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbAudAmplifyEnabled.TabIndex = 1;
            this.cbAudAmplifyEnabled.Text = "Enabled";
            this.cbAudAmplifyEnabled.UseVisualStyleBackColor = true;
            this.cbAudAmplifyEnabled.CheckedChanged += new System.EventHandler(this.cbAudAmplifyEnabled_CheckedChanged);
            // 
            // tabPage72
            // 
            this.tabPage72.Controls.Add(this.btAudEqRefresh);
            this.tabPage72.Controls.Add(this.cbAudEqualizerPreset);
            this.tabPage72.Controls.Add(this.label243);
            this.tabPage72.Controls.Add(this.label242);
            this.tabPage72.Controls.Add(this.label241);
            this.tabPage72.Controls.Add(this.label240);
            this.tabPage72.Controls.Add(this.label239);
            this.tabPage72.Controls.Add(this.label238);
            this.tabPage72.Controls.Add(this.label237);
            this.tabPage72.Controls.Add(this.label236);
            this.tabPage72.Controls.Add(this.label235);
            this.tabPage72.Controls.Add(this.label234);
            this.tabPage72.Controls.Add(this.label233);
            this.tabPage72.Controls.Add(this.label232);
            this.tabPage72.Controls.Add(this.tbAudEq9);
            this.tabPage72.Controls.Add(this.tbAudEq8);
            this.tabPage72.Controls.Add(this.tbAudEq7);
            this.tabPage72.Controls.Add(this.tbAudEq6);
            this.tabPage72.Controls.Add(this.tbAudEq5);
            this.tabPage72.Controls.Add(this.tbAudEq4);
            this.tabPage72.Controls.Add(this.tbAudEq3);
            this.tabPage72.Controls.Add(this.tbAudEq2);
            this.tabPage72.Controls.Add(this.tbAudEq1);
            this.tabPage72.Controls.Add(this.tbAudEq0);
            this.tabPage72.Controls.Add(this.cbAudEqualizerEnabled);
            this.tabPage72.Location = new System.Drawing.Point(4, 22);
            this.tabPage72.Name = "tabPage72";
            this.tabPage72.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage72.Size = new System.Drawing.Size(349, 321);
            this.tabPage72.TabIndex = 1;
            this.tabPage72.Text = "Equalizer";
            this.tabPage72.UseVisualStyleBackColor = true;
            // 
            // btAudEqRefresh
            // 
            this.btAudEqRefresh.Location = new System.Drawing.Point(268, 277);
            this.btAudEqRefresh.Name = "btAudEqRefresh";
            this.btAudEqRefresh.Size = new System.Drawing.Size(75, 23);
            this.btAudEqRefresh.TabIndex = 26;
            this.btAudEqRefresh.Text = "Refresh";
            this.btAudEqRefresh.UseVisualStyleBackColor = true;
            this.btAudEqRefresh.Click += new System.EventHandler(this.btAudEqRefresh_Click);
            // 
            // cbAudEqualizerPreset
            // 
            this.cbAudEqualizerPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAudEqualizerPreset.FormattingEnabled = true;
            this.cbAudEqualizerPreset.Location = new System.Drawing.Point(61, 279);
            this.cbAudEqualizerPreset.Name = "cbAudEqualizerPreset";
            this.cbAudEqualizerPreset.Size = new System.Drawing.Size(201, 21);
            this.cbAudEqualizerPreset.TabIndex = 25;
            this.cbAudEqualizerPreset.SelectedIndexChanged += new System.EventHandler(this.cbAudEqualizerPreset_SelectedIndexChanged);
            // 
            // label243
            // 
            this.label243.AutoSize = true;
            this.label243.Location = new System.Drawing.Point(13, 282);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(37, 13);
            this.label243.TabIndex = 24;
            this.label243.Text = "Preset";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Location = new System.Drawing.Point(273, 237);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(26, 13);
            this.label242.TabIndex = 23;
            this.label242.Text = "16K";
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(243, 237);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(26, 13);
            this.label241.TabIndex = 22;
            this.label241.Text = "14K";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(213, 237);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(26, 13);
            this.label240.TabIndex = 21;
            this.label240.Text = "12K";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(186, 237);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(20, 13);
            this.label239.TabIndex = 20;
            this.label239.Text = "6K";
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(156, 237);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(20, 13);
            this.label238.TabIndex = 19;
            this.label238.Text = "3K";
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(129, 237);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(20, 13);
            this.label237.TabIndex = 18;
            this.label237.Text = "1K";
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(99, 237);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(25, 13);
            this.label236.TabIndex = 17;
            this.label236.Text = "600";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(69, 237);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(25, 13);
            this.label235.TabIndex = 16;
            this.label235.Text = "310";
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(39, 237);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(25, 13);
            this.label234.TabIndex = 15;
            this.label234.Text = "170";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(13, 237);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(19, 13);
            this.label233.TabIndex = 14;
            this.label233.Text = "60";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(156, 37);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(13, 13);
            this.label232.TabIndex = 13;
            this.label232.Text = "0";
            // 
            // tbAudEq9
            // 
            this.tbAudEq9.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq9.Location = new System.Drawing.Point(276, 53);
            this.tbAudEq9.Maximum = 100;
            this.tbAudEq9.Minimum = -100;
            this.tbAudEq9.Name = "tbAudEq9";
            this.tbAudEq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq9.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq9.TabIndex = 12;
            this.tbAudEq9.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq9.Scroll += new System.EventHandler(this.tbAudEq9_Scroll);
            // 
            // tbAudEq8
            // 
            this.tbAudEq8.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq8.Location = new System.Drawing.Point(247, 53);
            this.tbAudEq8.Maximum = 100;
            this.tbAudEq8.Minimum = -100;
            this.tbAudEq8.Name = "tbAudEq8";
            this.tbAudEq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq8.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq8.TabIndex = 11;
            this.tbAudEq8.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq8.Scroll += new System.EventHandler(this.tbAudEq8_Scroll);
            // 
            // tbAudEq7
            // 
            this.tbAudEq7.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq7.Location = new System.Drawing.Point(217, 53);
            this.tbAudEq7.Maximum = 100;
            this.tbAudEq7.Minimum = -100;
            this.tbAudEq7.Name = "tbAudEq7";
            this.tbAudEq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq7.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq7.TabIndex = 10;
            this.tbAudEq7.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq7.Scroll += new System.EventHandler(this.tbAudEq7_Scroll);
            // 
            // tbAudEq6
            // 
            this.tbAudEq6.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq6.Location = new System.Drawing.Point(188, 53);
            this.tbAudEq6.Maximum = 100;
            this.tbAudEq6.Minimum = -100;
            this.tbAudEq6.Name = "tbAudEq6";
            this.tbAudEq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq6.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq6.TabIndex = 9;
            this.tbAudEq6.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq6.Scroll += new System.EventHandler(this.tbAudEq6_Scroll);
            // 
            // tbAudEq5
            // 
            this.tbAudEq5.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq5.Location = new System.Drawing.Point(159, 53);
            this.tbAudEq5.Maximum = 100;
            this.tbAudEq5.Minimum = -100;
            this.tbAudEq5.Name = "tbAudEq5";
            this.tbAudEq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq5.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq5.TabIndex = 8;
            this.tbAudEq5.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq5.Scroll += new System.EventHandler(this.tbAudEq5_Scroll);
            // 
            // tbAudEq4
            // 
            this.tbAudEq4.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq4.Location = new System.Drawing.Point(131, 53);
            this.tbAudEq4.Maximum = 100;
            this.tbAudEq4.Minimum = -100;
            this.tbAudEq4.Name = "tbAudEq4";
            this.tbAudEq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq4.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq4.TabIndex = 7;
            this.tbAudEq4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq4.Scroll += new System.EventHandler(this.tbAudEq4_Scroll);
            // 
            // tbAudEq3
            // 
            this.tbAudEq3.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq3.Location = new System.Drawing.Point(102, 53);
            this.tbAudEq3.Maximum = 100;
            this.tbAudEq3.Minimum = -100;
            this.tbAudEq3.Name = "tbAudEq3";
            this.tbAudEq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq3.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq3.TabIndex = 6;
            this.tbAudEq3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq3.Scroll += new System.EventHandler(this.tbAudEq3_Scroll);
            // 
            // tbAudEq2
            // 
            this.tbAudEq2.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq2.Location = new System.Drawing.Point(73, 53);
            this.tbAudEq2.Maximum = 100;
            this.tbAudEq2.Minimum = -100;
            this.tbAudEq2.Name = "tbAudEq2";
            this.tbAudEq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq2.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq2.TabIndex = 5;
            this.tbAudEq2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq2.Scroll += new System.EventHandler(this.tbAudEq2_Scroll);
            // 
            // tbAudEq1
            // 
            this.tbAudEq1.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq1.Location = new System.Drawing.Point(44, 53);
            this.tbAudEq1.Maximum = 100;
            this.tbAudEq1.Minimum = -100;
            this.tbAudEq1.Name = "tbAudEq1";
            this.tbAudEq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq1.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq1.TabIndex = 4;
            this.tbAudEq1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq1.Scroll += new System.EventHandler(this.tbAudEq1_Scroll);
            // 
            // tbAudEq0
            // 
            this.tbAudEq0.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudEq0.Location = new System.Drawing.Point(16, 53);
            this.tbAudEq0.Maximum = 100;
            this.tbAudEq0.Minimum = -100;
            this.tbAudEq0.Name = "tbAudEq0";
            this.tbAudEq0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAudEq0.Size = new System.Drawing.Size(45, 181);
            this.tbAudEq0.TabIndex = 3;
            this.tbAudEq0.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbAudEq0.Scroll += new System.EventHandler(this.tbAudEq0_Scroll);
            // 
            // cbAudEqualizerEnabled
            // 
            this.cbAudEqualizerEnabled.AutoSize = true;
            this.cbAudEqualizerEnabled.Location = new System.Drawing.Point(16, 16);
            this.cbAudEqualizerEnabled.Name = "cbAudEqualizerEnabled";
            this.cbAudEqualizerEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbAudEqualizerEnabled.TabIndex = 2;
            this.cbAudEqualizerEnabled.Text = "Enabled";
            this.cbAudEqualizerEnabled.UseVisualStyleBackColor = true;
            this.cbAudEqualizerEnabled.CheckedChanged += new System.EventHandler(this.cbAudEqualizerEnabled_CheckedChanged);
            // 
            // tabPage76
            // 
            this.tabPage76.Controls.Add(this.tbAudTrueBass);
            this.tabPage76.Controls.Add(this.label254);
            this.tabPage76.Controls.Add(this.cbAudTrueBassEnabled);
            this.tabPage76.Location = new System.Drawing.Point(4, 22);
            this.tabPage76.Name = "tabPage76";
            this.tabPage76.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage76.Size = new System.Drawing.Size(349, 321);
            this.tabPage76.TabIndex = 5;
            this.tabPage76.Text = "True bass";
            this.tabPage76.UseVisualStyleBackColor = true;
            // 
            // tbAudTrueBass
            // 
            this.tbAudTrueBass.BackColor = System.Drawing.SystemColors.Window;
            this.tbAudTrueBass.Location = new System.Drawing.Point(16, 69);
            this.tbAudTrueBass.Maximum = 10000;
            this.tbAudTrueBass.Name = "tbAudTrueBass";
            this.tbAudTrueBass.Size = new System.Drawing.Size(261, 45);
            this.tbAudTrueBass.TabIndex = 21;
            this.tbAudTrueBass.TickFrequency = 250;
            this.tbAudTrueBass.Scroll += new System.EventHandler(this.tbAudTrueBass_Scroll);
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(13, 53);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(42, 13);
            this.label254.TabIndex = 20;
            this.label254.Text = "Volume";
            // 
            // cbAudTrueBassEnabled
            // 
            this.cbAudTrueBassEnabled.AutoSize = true;
            this.cbAudTrueBassEnabled.Location = new System.Drawing.Point(16, 16);
            this.cbAudTrueBassEnabled.Name = "cbAudTrueBassEnabled";
            this.cbAudTrueBassEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbAudTrueBassEnabled.TabIndex = 2;
            this.cbAudTrueBassEnabled.Text = "Enabled";
            this.cbAudTrueBassEnabled.UseVisualStyleBackColor = true;
            this.cbAudTrueBassEnabled.CheckedChanged += new System.EventHandler(this.cbAudTrueBassEnabled_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbDebugMode);
            this.tabPage4.Controls.Add(this.mmLog);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(370, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(11, 11);
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
            this.mmLog.Location = new System.Drawing.Point(11, 34);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmLog.Size = new System.Drawing.Size(346, 359);
            this.mmLog.TabIndex = 77;
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
            // llVideoTutorials
            // 
            this.llVideoTutorials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llVideoTutorials.AutoSize = true;
            this.llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.llVideoTutorials.Location = new System.Drawing.Point(745, 3);
            this.llVideoTutorials.Name = "llVideoTutorials";
            this.llVideoTutorials.Size = new System.Drawing.Size(98, 13);
            this.llVideoTutorials.TabIndex = 92;
            this.llVideoTutorials.TabStop = true;
            this.llVideoTutorials.Text = "View video tutorials";
            this.llVideoTutorials.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVideoTutorials_LinkClicked);
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(501, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(214, 13);
            this.label34.TabIndex = 97;
            this.label34.Text = "Much more features available in Main Demo";
            // 
            // lbTimestamp
            // 
            this.lbTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimestamp.AutoSize = true;
            this.lbTimestamp.Location = new System.Drawing.Point(569, 380);
            this.lbTimestamp.Name = "lbTimestamp";
            this.lbTimestamp.Size = new System.Drawing.Size(126, 13);
            this.lbTimestamp.TabIndex = 105;
            this.lbTimestamp.Text = "Recording time: 00:00:00";
            // 
            // rbCapture
            // 
            this.rbCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCapture.AutoSize = true;
            this.rbCapture.Location = new System.Drawing.Point(456, 378);
            this.rbCapture.Name = "rbCapture";
            this.rbCapture.Size = new System.Drawing.Size(62, 17);
            this.rbCapture.TabIndex = 104;
            this.rbCapture.Text = "Capture";
            this.rbCapture.UseVisualStyleBackColor = true;
            // 
            // rbPreview
            // 
            this.rbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPreview.AutoSize = true;
            this.rbPreview.Checked = true;
            this.rbPreview.Location = new System.Drawing.Point(387, 378);
            this.rbPreview.Name = "rbPreview";
            this.rbPreview.Size = new System.Drawing.Size(63, 17);
            this.rbPreview.TabIndex = 103;
            this.rbPreview.TabStop = true;
            this.rbPreview.Text = "Preview";
            this.rbPreview.UseVisualStyleBackColor = true;
            // 
            // btSaveScreenshot
            // 
            this.btSaveScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaveScreenshot.Location = new System.Drawing.Point(716, 407);
            this.btSaveScreenshot.Name = "btSaveScreenshot";
            this.btSaveScreenshot.Size = new System.Drawing.Size(127, 23);
            this.btSaveScreenshot.TabIndex = 108;
            this.btSaveScreenshot.Text = "Save screenshot";
            this.btSaveScreenshot.UseVisualStyleBackColor = true;
            this.btSaveScreenshot.Click += new System.EventHandler(this.btSaveScreenshot_Click);
            // 
            // btResume
            // 
            this.btResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResume.Location = new System.Drawing.Point(633, 407);
            this.btResume.Name = "btResume";
            this.btResume.Size = new System.Drawing.Size(55, 23);
            this.btResume.TabIndex = 107;
            this.btResume.Text = "Resume";
            this.btResume.UseVisualStyleBackColor = true;
            this.btResume.Click += new System.EventHandler(this.btResume_Click);
            // 
            // btPause
            // 
            this.btPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPause.Location = new System.Drawing.Point(572, 407);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(55, 23);
            this.btPause.TabIndex = 106;
            this.btPause.Text = "Pause";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // VideoCapture1
            // 
            this.VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.VideoCapture1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.VideoCapture1.Location = new System.Drawing.Point(388, 25);
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
            this.VideoCapture1.OSD_Enabled = false;
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
            this.VideoCapture1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.VideoCapture1.Size = new System.Drawing.Size(454, 332);
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
            this.VideoCapture1.Video_Effects_GPU_Enabled = false;
            this.VideoCapture1.Video_Effects_MergeImageLogos = false;
            this.VideoCapture1.Video_Effects_MergeTextLogos = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_Override = false;
            videoRendererSettingsWinForms1.Aspect_Ratio_X = 0;
            videoRendererSettingsWinForms1.Aspect_Ratio_Y = 0;
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
            this.VideoCapture1.Video_Sample_Grabber_Enabled = false;
            this.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false;
            this.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_Enabled = false;
            this.VideoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.VideoCapture1.VLC_Path = null;
            this.VideoCapture1.OnError += new System.EventHandler<VisioForge.Types.ErrorsEventArgs>(this.VideoCapture1_OnError);
            this.VideoCapture1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoCapture1_OnLicenseRequired);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 439);
            this.Controls.Add(this.btSaveScreenshot);
            this.Controls.Add(this.btResume);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.lbTimestamp);
            this.Controls.Add(this.rbCapture);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.VideoCapture1);
            this.Controls.Add(this.llVideoTutorials);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Video Capture Demo - Video Capture SDK .Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudioVolume)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl18.ResumeLayout(false);
            this.tabPage71.ResumeLayout(false);
            this.tabPage71.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudAmplifyAmp)).EndInit();
            this.tabPage72.ResumeLayout(false);
            this.tabPage72.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudEq0)).EndInit();
            this.tabPage76.ResumeLayout(false);
            this.tabPage76.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAudTrueBass)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbUseBestAudioInputFormat;
        private System.Windows.Forms.Button btAudioInputDeviceSettings;
        private System.Windows.Forms.ComboBox cbAudioInputLine;
        private System.Windows.Forms.ComboBox cbAudioInputFormat;
        private System.Windows.Forms.ComboBox cbAudioInputDevice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TrackBar tbAudioBalance;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TrackBar tbAudioVolume;
        private System.Windows.Forms.CheckBox cbRecordAudio;
        private System.Windows.Forms.ComboBox cbAudioOutputDevice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUseBestVideoInputFormat;
        private System.Windows.Forms.Button btVideoCaptureDeviceSettings;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbFramerate;
        private System.Windows.Forms.ComboBox cbVideoInputFormat;
        private System.Windows.Forms.ComboBox cbVideoInputDevice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbUseAudioInputFromVideoCaptureDevice;
        private System.Windows.Forms.TabControl tabControl18;
        private System.Windows.Forms.TabPage tabPage71;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.TrackBar tbAudAmplifyAmp;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.CheckBox cbAudAmplifyEnabled;
        private System.Windows.Forms.TabPage tabPage72;
        private System.Windows.Forms.Button btAudEqRefresh;
        private System.Windows.Forms.ComboBox cbAudEqualizerPreset;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.TrackBar tbAudEq9;
        private System.Windows.Forms.TrackBar tbAudEq8;
        private System.Windows.Forms.TrackBar tbAudEq7;
        private System.Windows.Forms.TrackBar tbAudEq6;
        private System.Windows.Forms.TrackBar tbAudEq5;
        private System.Windows.Forms.TrackBar tbAudEq4;
        private System.Windows.Forms.TrackBar tbAudEq3;
        private System.Windows.Forms.TrackBar tbAudEq2;
        private System.Windows.Forms.TrackBar tbAudEq1;
        private System.Windows.Forms.TrackBar tbAudEq0;
        private System.Windows.Forms.CheckBox cbAudEqualizerEnabled;
        private System.Windows.Forms.TabPage tabPage76;
        private System.Windows.Forms.TrackBar tbAudTrueBass;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.CheckBox cbAudTrueBassEnabled;
        internal System.Windows.Forms.LinkLabel llVideoTutorials;
        private VisioForge.Controls.UI.WinForms.VideoCapture VideoCapture1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Label lbTimestamp;
        private System.Windows.Forms.RadioButton rbCapture;
        private System.Windows.Forms.RadioButton rbPreview;
        private System.Windows.Forms.Button btSaveScreenshot;
        private System.Windows.Forms.Button btResume;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btOutputConfigure;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSelectOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTextLogoAdd;
        private System.Windows.Forms.Button btLogoRemove;
        private System.Windows.Forms.Button btLogoEdit;
        private System.Windows.Forms.ListBox lbLogos;
        private System.Windows.Forms.Button btImageLogoAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.TrackBar tbLightness;
        private System.Windows.Forms.TrackBar tbSaturation;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.TrackBar tbDarkness;
        private System.Windows.Forms.CheckBox cbFlipY;
        private System.Windows.Forms.CheckBox cbFlipX;
        private System.Windows.Forms.CheckBox cbInvert;
        private System.Windows.Forms.CheckBox cbGreyscale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMergeTextLogos;
        private System.Windows.Forms.CheckBox cbMergeImageLogos;
    }
}

