﻿namespace Video_From_Images
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
            VisioForge.Types.VideoRendererSettingsWinForms videoRendererSettingsWinForms1 = new VisioForge.Types.VideoRendererSettingsWinForms();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rbPreview = new System.Windows.Forms.RadioButton();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btClearList = new System.Windows.Forms.Button();
            this.btAddInputFile = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbConvert = new System.Windows.Forms.RadioButton();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbLicensing = new System.Windows.Forms.CheckBox();
            this.mmLog = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.OpenDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.VideoEdit1 = new VisioForge.Controls.UI.WinForms.VideoEdit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            this.tabPage3.SuspendLayout();
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
            // rbPreview
            // 
            this.rbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBar1.Location = new System.Drawing.Point(348, 462);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(415, 23);
            this.ProgressBar1.TabIndex = 79;
            // 
            // rbConvert
            // 
            this.rbConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbConvert.AutoSize = true;
            this.rbConvert.Location = new System.Drawing.Point(348, 427);
            this.rbConvert.Name = "rbConvert";
            this.rbConvert.Size = new System.Drawing.Size(91, 17);
            this.rbConvert.TabIndex = 78;
            this.rbConvert.Text = "Convert video";
            this.rbConvert.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 402);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(322, 376);
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
            this.cbOutputFormat.Location = new System.Drawing.Point(16, 109);
            this.cbOutputFormat.Name = "cbOutputFormat";
            this.cbOutputFormat.Size = new System.Drawing.Size(289, 21);
            this.cbOutputFormat.TabIndex = 127;
            this.cbOutputFormat.SelectedIndexChanged += new System.EventHandler(this.cbOutputFormat_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(13, 141);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(267, 13);
            this.lbInfo.TabIndex = 126;
            this.lbInfo.Text = "You can use dialog or code to configure format settings";
            // 
            // btConfigure
            // 
            this.btConfigure.Location = new System.Drawing.Point(16, 163);
            this.btConfigure.Name = "btConfigure";
            this.btConfigure.Size = new System.Drawing.Size(61, 23);
            this.btConfigure.TabIndex = 125;
            this.btConfigure.Text = "Configure";
            this.btConfigure.UseVisualStyleBackColor = true;
            this.btConfigure.Click += new System.EventHandler(this.btConfigure_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Format";
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
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(322, 376);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Video processing";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbFlipY
            // 
            this.cbFlipY.AutoSize = true;
            this.cbFlipY.Location = new System.Drawing.Point(218, 290);
            this.cbFlipY.Name = "cbFlipY";
            this.cbFlipY.Size = new System.Drawing.Size(52, 17);
            this.cbFlipY.TabIndex = 104;
            this.cbFlipY.Text = "Flip Y";
            this.cbFlipY.UseVisualStyleBackColor = true;
            this.cbFlipY.CheckedChanged += new System.EventHandler(this.cbFlipY_CheckedChanged);
            // 
            // cbFlipX
            // 
            this.cbFlipX.AutoSize = true;
            this.cbFlipX.Location = new System.Drawing.Point(158, 290);
            this.cbFlipX.Name = "cbFlipX";
            this.cbFlipX.Size = new System.Drawing.Size(52, 17);
            this.cbFlipX.TabIndex = 103;
            this.cbFlipX.Text = "Flip X";
            this.cbFlipX.UseVisualStyleBackColor = true;
            this.cbFlipX.CheckedChanged += new System.EventHandler(this.cbFlipX_CheckedChanged);
            // 
            // cbInvert
            // 
            this.cbInvert.AutoSize = true;
            this.cbInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbInvert.Location = new System.Drawing.Point(98, 290);
            this.cbInvert.Name = "cbInvert";
            this.cbInvert.Size = new System.Drawing.Size(53, 17);
            this.cbInvert.TabIndex = 102;
            this.cbInvert.Text = "Invert";
            this.cbInvert.UseVisualStyleBackColor = true;
            this.cbInvert.CheckedChanged += new System.EventHandler(this.cbInvert_CheckedChanged);
            // 
            // cbGreyscale
            // 
            this.cbGreyscale.AutoSize = true;
            this.cbGreyscale.Location = new System.Drawing.Point(18, 290);
            this.cbGreyscale.Name = "cbGreyscale";
            this.cbGreyscale.Size = new System.Drawing.Size(73, 17);
            this.cbGreyscale.TabIndex = 101;
            this.cbGreyscale.Text = "Greyscale";
            this.cbGreyscale.UseVisualStyleBackColor = true;
            this.cbGreyscale.CheckedChanged += new System.EventHandler(this.cbGreyscale_CheckedChanged);
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(151, 219);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(52, 13);
            this.label201.TabIndex = 100;
            this.label201.Text = "Darkness";
            // 
            // tbDarkness
            // 
            this.tbDarkness.BackColor = System.Drawing.SystemColors.Window;
            this.tbDarkness.Location = new System.Drawing.Point(151, 239);
            this.tbDarkness.Maximum = 255;
            this.tbDarkness.Name = "tbDarkness";
            this.tbDarkness.Size = new System.Drawing.Size(130, 45);
            this.tbDarkness.TabIndex = 99;
            this.tbDarkness.Scroll += new System.EventHandler(this.tbDarkness_Scroll);
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(15, 219);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(46, 13);
            this.label200.TabIndex = 98;
            this.label200.Text = "Contrast";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(151, 167);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(55, 13);
            this.label199.TabIndex = 97;
            this.label199.Text = "Saturation";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(15, 167);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(52, 13);
            this.label198.TabIndex = 96;
            this.label198.Text = "Lightness";
            // 
            // tbContrast
            // 
            this.tbContrast.BackColor = System.Drawing.SystemColors.Window;
            this.tbContrast.Location = new System.Drawing.Point(12, 239);
            this.tbContrast.Maximum = 255;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(130, 45);
            this.tbContrast.TabIndex = 95;
            this.tbContrast.Scroll += new System.EventHandler(this.tbContrast_Scroll);
            // 
            // tbLightness
            // 
            this.tbLightness.BackColor = System.Drawing.SystemColors.Window;
            this.tbLightness.Location = new System.Drawing.Point(12, 183);
            this.tbLightness.Maximum = 255;
            this.tbLightness.Name = "tbLightness";
            this.tbLightness.Size = new System.Drawing.Size(130, 45);
            this.tbLightness.TabIndex = 94;
            this.tbLightness.Scroll += new System.EventHandler(this.tbLightness_Scroll);
            // 
            // tbSaturation
            // 
            this.tbSaturation.BackColor = System.Drawing.SystemColors.Window;
            this.tbSaturation.Location = new System.Drawing.Point(151, 183);
            this.tbSaturation.Maximum = 255;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(130, 45);
            this.tbSaturation.TabIndex = 93;
            this.tbSaturation.Value = 255;
            this.tbSaturation.Scroll += new System.EventHandler(this.tbSaturation_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Text / image logos";
            // 
            // btTextLogoAdd
            // 
            this.btTextLogoAdd.Location = new System.Drawing.Point(108, 131);
            this.btTextLogoAdd.Name = "btTextLogoAdd";
            this.btTextLogoAdd.Size = new System.Drawing.Size(85, 23);
            this.btTextLogoAdd.TabIndex = 91;
            this.btTextLogoAdd.Text = "Add text logo";
            this.btTextLogoAdd.UseVisualStyleBackColor = true;
            this.btTextLogoAdd.Click += new System.EventHandler(this.btTextLogoAdd_Click);
            // 
            // btLogoRemove
            // 
            this.btLogoRemove.Location = new System.Drawing.Point(258, 131);
            this.btLogoRemove.Name = "btLogoRemove";
            this.btLogoRemove.Size = new System.Drawing.Size(50, 23);
            this.btLogoRemove.TabIndex = 90;
            this.btLogoRemove.Text = "Remove";
            this.btLogoRemove.UseVisualStyleBackColor = true;
            this.btLogoRemove.Click += new System.EventHandler(this.btLogoRemove_Click);
            // 
            // btLogoEdit
            // 
            this.btLogoEdit.Location = new System.Drawing.Point(202, 131);
            this.btLogoEdit.Name = "btLogoEdit";
            this.btLogoEdit.Size = new System.Drawing.Size(50, 23);
            this.btLogoEdit.TabIndex = 89;
            this.btLogoEdit.Text = "Edit";
            this.btLogoEdit.UseVisualStyleBackColor = true;
            this.btLogoEdit.Click += new System.EventHandler(this.btLogoEdit_Click);
            // 
            // lbLogos
            // 
            this.lbLogos.FormattingEnabled = true;
            this.lbLogos.Location = new System.Drawing.Point(12, 30);
            this.lbLogos.Name = "lbLogos";
            this.lbLogos.Size = new System.Drawing.Size(298, 95);
            this.lbLogos.TabIndex = 88;
            // 
            // btImageLogoAdd
            // 
            this.btImageLogoAdd.Location = new System.Drawing.Point(12, 131);
            this.btImageLogoAdd.Name = "btImageLogoAdd";
            this.btImageLogoAdd.Size = new System.Drawing.Size(90, 23);
            this.btImageLogoAdd.TabIndex = 87;
            this.btImageLogoAdd.Text = "Add image logo";
            this.btImageLogoAdd.UseVisualStyleBackColor = true;
            this.btImageLogoAdd.Click += new System.EventHandler(this.btImageLogoAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "More effects and settings available in Main Demo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbLicensing);
            this.tabPage3.Controls.Add(this.mmLog);
            this.tabPage3.Controls.Add(this.label120);
            this.tabPage3.Controls.Add(this.cbDebugMode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(322, 376);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbLicensing
            // 
            this.cbLicensing.AutoSize = true;
            this.cbLicensing.Location = new System.Drawing.Point(130, 16);
            this.cbLicensing.Name = "cbLicensing";
            this.cbLicensing.Size = new System.Drawing.Size(91, 17);
            this.cbLicensing.TabIndex = 97;
            this.cbLicensing.Text = "Licensing info";
            this.cbLicensing.UseVisualStyleBackColor = true;
            // 
            // mmLog
            // 
            this.mmLog.Location = new System.Drawing.Point(17, 61);
            this.mmLog.Multiline = true;
            this.mmLog.Name = "mmLog";
            this.mmLog.Size = new System.Drawing.Size(289, 298);
            this.mmLog.TabIndex = 96;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(14, 42);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(100, 13);
            this.label120.TabIndex = 95;
            this.label120.Text = "Errors and warnings";
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(16, 16);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(87, 17);
            this.cbDebugMode.TabIndex = 94;
            this.cbDebugMode.Text = "Debug mode";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            // 
            // OpenDialog1
            // 
            this.OpenDialog1.Filter = resources.GetString("OpenDialog1.Filter");
            this.OpenDialog1.Multiselect = true;
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
            this.VideoEdit1.CustomRedist_Enabled = false;
            this.VideoEdit1.CustomRedist_Path = null;
            this.VideoEdit1.Debug_Dir = "";
            this.VideoEdit1.Debug_Mode = false;
            this.VideoEdit1.Debug_Telemetry = false;
            this.VideoEdit1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.VideoEdit1.Decklink_Output = null;
            this.VideoEdit1.Dynamic_Reconnection = false;
            this.VideoEdit1.Location = new System.Drawing.Point(348, 95);
            this.VideoEdit1.Loop = false;
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
            this.VideoEdit1.Size = new System.Drawing.Size(415, 319);
            this.VideoEdit1.Start_DelayEnabled = false;
            this.VideoEdit1.TabIndex = 91;
            this.VideoEdit1.Tags = null;
            this.VideoEdit1.UseLibMediaInfo = false;
            this.VideoEdit1.Video_Crop = null;
            this.VideoEdit1.Video_Custom_Resizer_CLSID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.VideoEdit1.Video_Effects_AllowMultipleStreams = false;
            this.VideoEdit1.Video_Effects_Enabled = false;
            this.VideoEdit1.Video_Effects_GPU_Enabled = false;
            this.VideoEdit1.Video_FrameRate = 25D;
            this.VideoEdit1.Video_Preview_Enabled = true;
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
            this.VideoEdit1.Video_Renderer = videoRendererSettingsWinForms1;
            this.VideoEdit1.Video_Resize = false;
            this.VideoEdit1.Video_Resize_Height = 480;
            this.VideoEdit1.Video_Resize_Width = 640;
            this.VideoEdit1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.VideoEdit1.Video_Subtitles = null;
            this.VideoEdit1.Virtual_Camera_Output_Enabled = false;
            this.VideoEdit1.OnError += new System.EventHandler<VisioForge.Types.ErrorsEventArgs>(this.VideoEdit1_OnError);
            this.VideoEdit1.OnLicenseRequired += new System.EventHandler<VisioForge.Types.LicenseEventArgs>(this.VideoEdit1_OnLicenseRequired);
            this.VideoEdit1.OnProgress += new System.EventHandler<VisioForge.Types.ProgressEventArgs>(this.VideoEdit1_OnProgress);
            this.VideoEdit1.OnStop += new System.EventHandler<VisioForge.Types.VideoEditStopEventArgs>(this.VideoEdit1_OnStop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 496);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.VideoEdit1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rbPreview);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btClearList);
            this.Controls.Add(this.btAddInputFile);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.rbConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VisioForge Video Edit SDK .Net - Video From Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
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
        private System.Windows.Forms.OpenFileDialog OpenDialog1;
        private System.Windows.Forms.SaveFileDialog SaveDialog1;
        private System.Windows.Forms.Button btSelectOutput;
        private System.Windows.Forms.TextBox edOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbLicensing;
        private System.Windows.Forms.TextBox mmLog;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.ComboBox cbOutputFormat;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btConfigure;
        private System.Windows.Forms.Label label9;
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

