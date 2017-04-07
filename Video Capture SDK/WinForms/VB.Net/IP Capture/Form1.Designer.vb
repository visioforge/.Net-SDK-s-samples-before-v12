Imports VisioForge.Types

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim VideoRendererSettingsWinForms13 As VisioForge.Types.VideoRendererSettingsWinForms = New VisioForge.Types.VideoRendererSettingsWinForms()
        Me.btSelectOutput = New System.Windows.Forms.Button()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.edOutputAVI = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.btAudioSettings = New System.Windows.Forms.Button()
        Me.btVideoSettings = New System.Windows.Forms.Button()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label29 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label31 = New System.Windows.Forms.Label()
        Me.cbChannels = New System.Windows.Forms.ComboBox()
        Me.cbBPS = New System.Windows.Forms.ComboBox()
        Me.cbAudioCodecs = New System.Windows.Forms.ComboBox()
        Me.cbSampleRate = New System.Windows.Forms.ComboBox()
        Me.cbVideoCodecs = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.btSelectOutputMP4 = New System.Windows.Forms.Button()
        Me.edOutputMP4 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.groupBox29 = New System.Windows.Forms.GroupBox()
        Me.cbH264GOP = New System.Windows.Forms.CheckBox()
        Me.cbH264AutoBitrate = New System.Windows.Forms.CheckBox()
        Me.label350 = New System.Windows.Forms.Label()
        Me.edH264Bitrate = New System.Windows.Forms.TextBox()
        Me.label351 = New System.Windows.Forms.Label()
        Me.cbH264RateControl = New System.Windows.Forms.ComboBox()
        Me.groupBox46 = New System.Windows.Forms.GroupBox()
        Me.cbH264TargetUsage = New System.Windows.Forms.ComboBox()
        Me.label359 = New System.Windows.Forms.Label()
        Me.label352 = New System.Windows.Forms.Label()
        Me.label353 = New System.Windows.Forms.Label()
        Me.cbH264Level = New System.Windows.Forms.ComboBox()
        Me.cbH264Profile = New System.Windows.Forms.ComboBox()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.label354 = New System.Windows.Forms.Label()
        Me.cbAACOutput = New System.Windows.Forms.ComboBox()
        Me.label355 = New System.Windows.Forms.Label()
        Me.cbAACBitrate = New System.Windows.Forms.ComboBox()
        Me.label356 = New System.Windows.Forms.Label()
        Me.cbAACObjectType = New System.Windows.Forms.ComboBox()
        Me.label357 = New System.Windows.Forms.Label()
        Me.cbAACVersion = New System.Windows.Forms.ComboBox()
        Me.label358 = New System.Windows.Forms.Label()
        Me.rbPreview = New System.Windows.Forms.RadioButton()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btStart = New System.Windows.Forms.Button()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.llVideoTutorials = New System.Windows.Forms.LinkLabel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.rbCaptureMP4 = New System.Windows.Forms.RadioButton()
        Me.rbCaptureAVI = New System.Windows.Forms.RadioButton()
        Me.VideoCapture1 = New VisioForge.Controls.UI.WinForms.VideoCapture()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.tabControl15 = New System.Windows.Forms.TabControl()
        Me.tabPage144 = New System.Windows.Forms.TabPage()
        Me.cbIPCameraONVIF = New System.Windows.Forms.CheckBox()
        Me.btShowIPCamDatabase = New System.Windows.Forms.Button()
        Me.linkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.cbIPDisconnect = New System.Windows.Forms.CheckBox()
        Me.edIPForcedFramerateID = New System.Windows.Forms.TextBox()
        Me.label344 = New System.Windows.Forms.Label()
        Me.edIPForcedFramerate = New System.Windows.Forms.TextBox()
        Me.label295 = New System.Windows.Forms.Label()
        Me.cbIPCameraType = New System.Windows.Forms.ComboBox()
        Me.edIPPassword = New System.Windows.Forms.TextBox()
        Me.label167 = New System.Windows.Forms.Label()
        Me.edIPLogin = New System.Windows.Forms.TextBox()
        Me.label166 = New System.Windows.Forms.Label()
        Me.cbIPAudioCapture = New System.Windows.Forms.CheckBox()
        Me.label168 = New System.Windows.Forms.Label()
        Me.tabPage146 = New System.Windows.Forms.TabPage()
        Me.cbVLCZeroClockJitter = New System.Windows.Forms.CheckBox()
        Me.edVLCCacheSize = New System.Windows.Forms.TextBox()
        Me.label312 = New System.Windows.Forms.Label()
        Me.tabPage145 = New System.Windows.Forms.TabPage()
        Me.edONVIFLiveVideoURL = New System.Windows.Forms.TextBox()
        Me.label513 = New System.Windows.Forms.Label()
        Me.groupBox42 = New System.Windows.Forms.GroupBox()
        Me.btONVIFPTZSetDefault = New System.Windows.Forms.Button()
        Me.btONVIFRight = New System.Windows.Forms.Button()
        Me.btONVIFLeft = New System.Windows.Forms.Button()
        Me.btONVIFZoomOut = New System.Windows.Forms.Button()
        Me.btONVIFZoomIn = New System.Windows.Forms.Button()
        Me.btONVIFDown = New System.Windows.Forms.Button()
        Me.btONVIFUp = New System.Windows.Forms.Button()
        Me.cbONVIFProfile = New System.Windows.Forms.ComboBox()
        Me.label510 = New System.Windows.Forms.Label()
        Me.lbONVIFCameraInfo = New System.Windows.Forms.Label()
        Me.btONVIFConnect = New System.Windows.Forms.Button()
        Me.edIPUrl = New System.Windows.Forms.TextBox()
        Me.label165 = New System.Windows.Forms.Label()
        Me.cbImageType = New System.Windows.Forms.ComboBox()
        Me.lbJPEGQuality = New System.Windows.Forms.Label()
        Me.label38 = New System.Windows.Forms.Label()
        Me.btSaveScreenshot = New System.Windows.Forms.Button()
        Me.label63 = New System.Windows.Forms.Label()
        Me.edScreenshotsFolder = New System.Windows.Forms.TextBox()
        Me.tbJPEGQuality = New System.Windows.Forms.TrackBar()
        Me.cbLicensing = New System.Windows.Forms.CheckBox()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.mmLog = New System.Windows.Forms.TextBox()
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabPage2.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPage4.SuspendLayout
        Me.tabPage5.SuspendLayout
        Me.groupBox29.SuspendLayout
        Me.groupBox46.SuspendLayout
        Me.tabPage6.SuspendLayout
        Me.TabPage7.SuspendLayout
        Me.TabPage8.SuspendLayout
        Me.tabControl15.SuspendLayout
        Me.tabPage144.SuspendLayout
        Me.tabPage146.SuspendLayout
        Me.tabPage145.SuspendLayout
        Me.groupBox42.SuspendLayout
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btSelectOutput
        '
        Me.btSelectOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSelectOutput.Location = New System.Drawing.Point(320, 7)
        Me.btSelectOutput.Name = "btSelectOutput"
        Me.btSelectOutput.Size = New System.Drawing.Size(24, 23)
        Me.btSelectOutput.TabIndex = 47
        Me.btSelectOutput.Text = "..."
        Me.btSelectOutput.UseVisualStyleBackColor = true
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage7)
        Me.tabControl1.Controls.Add(Me.TabPage8)
        Me.tabControl1.Location = New System.Drawing.Point(3, 3)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(472, 348)
        Me.tabControl1.TabIndex = 53
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.tabControl15)
        Me.tabPage1.Controls.Add(Me.edIPUrl)
        Me.tabPage1.Controls.Add(Me.label165)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(464, 322)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Input"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.btSelectOutput)
        Me.tabPage2.Controls.Add(Me.edOutputAVI)
        Me.tabPage2.Controls.Add(Me.label9)
        Me.tabPage2.Controls.Add(Me.label27)
        Me.tabPage2.Controls.Add(Me.btAudioSettings)
        Me.tabPage2.Controls.Add(Me.btVideoSettings)
        Me.tabPage2.Controls.Add(Me.label28)
        Me.tabPage2.Controls.Add(Me.label29)
        Me.tabPage2.Controls.Add(Me.label30)
        Me.tabPage2.Controls.Add(Me.label31)
        Me.tabPage2.Controls.Add(Me.cbChannels)
        Me.tabPage2.Controls.Add(Me.cbBPS)
        Me.tabPage2.Controls.Add(Me.cbAudioCodecs)
        Me.tabPage2.Controls.Add(Me.cbSampleRate)
        Me.tabPage2.Controls.Add(Me.cbVideoCodecs)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(350, 246)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "AVI output"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'edOutputAVI
        '
        Me.edOutputAVI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edOutputAVI.Location = New System.Drawing.Point(63, 9)
        Me.edOutputAVI.Name = "edOutputAVI"
        Me.edOutputAVI.Size = New System.Drawing.Size(251, 20)
        Me.edOutputAVI.TabIndex = 46
        Me.edOutputAVI.Text = "c:\capture.avi"
        '
        'label9
        '
        Me.label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label9.AutoSize = true
        Me.label9.Location = New System.Drawing.Point(6, 12)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(52, 13)
        Me.label9.TabIndex = 45
        Me.label9.Text = "File name"
        '
        'label27
        '
        Me.label27.AutoSize = true
        Me.label27.Location = New System.Drawing.Point(5, 71)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(67, 13)
        Me.label27.TabIndex = 39
        Me.label27.Text = "Audio codec"
        '
        'btAudioSettings
        '
        Me.btAudioSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btAudioSettings.Location = New System.Drawing.Point(280, 66)
        Me.btAudioSettings.Name = "btAudioSettings"
        Me.btAudioSettings.Size = New System.Drawing.Size(64, 23)
        Me.btAudioSettings.TabIndex = 38
        Me.btAudioSettings.Text = "Settings"
        Me.btAudioSettings.UseVisualStyleBackColor = true
        '
        'btVideoSettings
        '
        Me.btVideoSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btVideoSettings.Location = New System.Drawing.Point(280, 39)
        Me.btVideoSettings.Name = "btVideoSettings"
        Me.btVideoSettings.Size = New System.Drawing.Size(64, 23)
        Me.btVideoSettings.TabIndex = 37
        Me.btVideoSettings.Text = "Settings"
        Me.btVideoSettings.UseVisualStyleBackColor = true
        '
        'label28
        '
        Me.label28.AutoSize = true
        Me.label28.Location = New System.Drawing.Point(21, 125)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(63, 13)
        Me.label28.TabIndex = 36
        Me.label28.Text = "Sample rate"
        '
        'label29
        '
        Me.label29.AutoSize = true
        Me.label29.Location = New System.Drawing.Point(173, 98)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(28, 13)
        Me.label29.TabIndex = 35
        Me.label29.Text = "BPS"
        '
        'label30
        '
        Me.label30.AutoSize = true
        Me.label30.Location = New System.Drawing.Point(21, 98)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(51, 13)
        Me.label30.TabIndex = 34
        Me.label30.Text = "Channels"
        '
        'label31
        '
        Me.label31.AutoSize = true
        Me.label31.Location = New System.Drawing.Point(6, 44)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(67, 13)
        Me.label31.TabIndex = 33
        Me.label31.Text = "Video codec"
        '
        'cbChannels
        '
        Me.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChannels.FormattingEnabled = true
        Me.cbChannels.Items.AddRange(New Object() {"1", "2"})
        Me.cbChannels.Location = New System.Drawing.Point(98, 95)
        Me.cbChannels.Name = "cbChannels"
        Me.cbChannels.Size = New System.Drawing.Size(65, 21)
        Me.cbChannels.TabIndex = 32
        '
        'cbBPS
        '
        Me.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBPS.FormattingEnabled = true
        Me.cbBPS.Items.AddRange(New Object() {"8", "16"})
        Me.cbBPS.Location = New System.Drawing.Point(207, 95)
        Me.cbBPS.Name = "cbBPS"
        Me.cbBPS.Size = New System.Drawing.Size(67, 21)
        Me.cbBPS.TabIndex = 31
        '
        'cbAudioCodecs
        '
        Me.cbAudioCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbAudioCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioCodecs.FormattingEnabled = true
        Me.cbAudioCodecs.Location = New System.Drawing.Point(98, 68)
        Me.cbAudioCodecs.Name = "cbAudioCodecs"
        Me.cbAudioCodecs.Size = New System.Drawing.Size(176, 21)
        Me.cbAudioCodecs.TabIndex = 30
        '
        'cbSampleRate
        '
        Me.cbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSampleRate.FormattingEnabled = true
        Me.cbSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbSampleRate.Location = New System.Drawing.Point(98, 122)
        Me.cbSampleRate.Name = "cbSampleRate"
        Me.cbSampleRate.Size = New System.Drawing.Size(65, 21)
        Me.cbSampleRate.TabIndex = 29
        '
        'cbVideoCodecs
        '
        Me.cbVideoCodecs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbVideoCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideoCodecs.FormattingEnabled = true
        Me.cbVideoCodecs.Location = New System.Drawing.Point(98, 41)
        Me.cbVideoCodecs.Name = "cbVideoCodecs"
        Me.cbVideoCodecs.Size = New System.Drawing.Size(176, 21)
        Me.cbVideoCodecs.TabIndex = 28
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(350, 246)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MP4 output"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'tabControl2
        '
        Me.tabControl2.Controls.Add(Me.tabPage4)
        Me.tabControl2.Controls.Add(Me.tabPage5)
        Me.tabControl2.Controls.Add(Me.tabPage6)
        Me.tabControl2.Location = New System.Drawing.Point(6, 6)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New System.Drawing.Size(337, 237)
        Me.tabControl2.TabIndex = 1
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.btSelectOutputMP4)
        Me.tabPage4.Controls.Add(Me.edOutputMP4)
        Me.tabPage4.Controls.Add(Me.label1)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(329, 211)
        Me.tabPage4.TabIndex = 0
        Me.tabPage4.Text = "Main"
        Me.tabPage4.UseVisualStyleBackColor = true
        '
        'btSelectOutputMP4
        '
        Me.btSelectOutputMP4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSelectOutputMP4.Location = New System.Drawing.Point(303, 13)
        Me.btSelectOutputMP4.Name = "btSelectOutputMP4"
        Me.btSelectOutputMP4.Size = New System.Drawing.Size(20, 23)
        Me.btSelectOutputMP4.TabIndex = 50
        Me.btSelectOutputMP4.Text = "..."
        Me.btSelectOutputMP4.UseVisualStyleBackColor = true
        '
        'edOutputMP4
        '
        Me.edOutputMP4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edOutputMP4.Location = New System.Drawing.Point(66, 15)
        Me.edOutputMP4.Name = "edOutputMP4"
        Me.edOutputMP4.Size = New System.Drawing.Size(227, 20)
        Me.edOutputMP4.TabIndex = 49
        Me.edOutputMP4.Text = "c:\capture.avi"
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(9, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 13)
        Me.label1.TabIndex = 48
        Me.label1.Text = "File name"
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.groupBox29)
        Me.tabPage5.Controls.Add(Me.groupBox46)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage5.Size = New System.Drawing.Size(329, 211)
        Me.tabPage5.TabIndex = 1
        Me.tabPage5.Text = "Video"
        Me.tabPage5.UseVisualStyleBackColor = true
        '
        'groupBox29
        '
        Me.groupBox29.Controls.Add(Me.cbH264GOP)
        Me.groupBox29.Controls.Add(Me.cbH264AutoBitrate)
        Me.groupBox29.Controls.Add(Me.label350)
        Me.groupBox29.Controls.Add(Me.edH264Bitrate)
        Me.groupBox29.Controls.Add(Me.label351)
        Me.groupBox29.Controls.Add(Me.cbH264RateControl)
        Me.groupBox29.Location = New System.Drawing.Point(6, 109)
        Me.groupBox29.Name = "groupBox29"
        Me.groupBox29.Size = New System.Drawing.Size(223, 98)
        Me.groupBox29.TabIndex = 7
        Me.groupBox29.TabStop = false
        Me.groupBox29.Text = "Bitrate"
        '
        'cbH264GOP
        '
        Me.cbH264GOP.AutoSize = true
        Me.cbH264GOP.Location = New System.Drawing.Point(166, 78)
        Me.cbH264GOP.Name = "cbH264GOP"
        Me.cbH264GOP.Size = New System.Drawing.Size(49, 17)
        Me.cbH264GOP.TabIndex = 12
        Me.cbH264GOP.Text = "GOP"
        Me.cbH264GOP.UseVisualStyleBackColor = true
        '
        'cbH264AutoBitrate
        '
        Me.cbH264AutoBitrate.AutoSize = true
        Me.cbH264AutoBitrate.Location = New System.Drawing.Point(10, 78)
        Me.cbH264AutoBitrate.Name = "cbH264AutoBitrate"
        Me.cbH264AutoBitrate.Size = New System.Drawing.Size(127, 17)
        Me.cbH264AutoBitrate.TabIndex = 7
        Me.cbH264AutoBitrate.Text = "Auto configure bitrate"
        Me.cbH264AutoBitrate.UseVisualStyleBackColor = true
        '
        'label350
        '
        Me.label350.AutoSize = true
        Me.label350.Location = New System.Drawing.Point(6, 53)
        Me.label350.Name = "label350"
        Me.label350.Size = New System.Drawing.Size(69, 13)
        Me.label350.TabIndex = 6
        Me.label350.Text = "Bitrate (kbps)"
        '
        'edH264Bitrate
        '
        Me.edH264Bitrate.Location = New System.Drawing.Point(94, 52)
        Me.edH264Bitrate.Name = "edH264Bitrate"
        Me.edH264Bitrate.Size = New System.Drawing.Size(121, 20)
        Me.edH264Bitrate.TabIndex = 5
        Me.edH264Bitrate.Text = "2000"
        Me.edH264Bitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label351
        '
        Me.label351.AutoSize = true
        Me.label351.Location = New System.Drawing.Point(6, 21)
        Me.label351.Name = "label351"
        Me.label351.Size = New System.Drawing.Size(65, 13)
        Me.label351.TabIndex = 4
        Me.label351.Text = "Rate ñontrol"
        '
        'cbH264RateControl
        '
        Me.cbH264RateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264RateControl.FormattingEnabled = true
        Me.cbH264RateControl.Items.AddRange(New Object() {"CBR", "VBR"})
        Me.cbH264RateControl.Location = New System.Drawing.Point(94, 19)
        Me.cbH264RateControl.Name = "cbH264RateControl"
        Me.cbH264RateControl.Size = New System.Drawing.Size(121, 21)
        Me.cbH264RateControl.TabIndex = 3
        '
        'groupBox46
        '
        Me.groupBox46.Controls.Add(Me.cbH264TargetUsage)
        Me.groupBox46.Controls.Add(Me.label359)
        Me.groupBox46.Controls.Add(Me.label352)
        Me.groupBox46.Controls.Add(Me.label353)
        Me.groupBox46.Controls.Add(Me.cbH264Level)
        Me.groupBox46.Controls.Add(Me.cbH264Profile)
        Me.groupBox46.Location = New System.Drawing.Point(6, 6)
        Me.groupBox46.Name = "groupBox46"
        Me.groupBox46.Size = New System.Drawing.Size(223, 97)
        Me.groupBox46.TabIndex = 6
        Me.groupBox46.TabStop = false
        Me.groupBox46.Text = "Profile settings"
        '
        'cbH264TargetUsage
        '
        Me.cbH264TargetUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264TargetUsage.FormattingEnabled = true
        Me.cbH264TargetUsage.Items.AddRange(New Object() {"Auto", "Best quality", "Balanced", "Best speed"})
        Me.cbH264TargetUsage.Location = New System.Drawing.Point(94, 73)
        Me.cbH264TargetUsage.Name = "cbH264TargetUsage"
        Me.cbH264TargetUsage.Size = New System.Drawing.Size(121, 21)
        Me.cbH264TargetUsage.TabIndex = 5
        '
        'label359
        '
        Me.label359.AutoSize = true
        Me.label359.Location = New System.Drawing.Point(7, 76)
        Me.label359.Name = "label359"
        Me.label359.Size = New System.Drawing.Size(70, 13)
        Me.label359.TabIndex = 4
        Me.label359.Text = "Target usage"
        '
        'label352
        '
        Me.label352.AutoSize = true
        Me.label352.Location = New System.Drawing.Point(7, 49)
        Me.label352.Name = "label352"
        Me.label352.Size = New System.Drawing.Size(33, 13)
        Me.label352.TabIndex = 3
        Me.label352.Text = "Level"
        '
        'label353
        '
        Me.label353.AutoSize = true
        Me.label353.Location = New System.Drawing.Point(7, 22)
        Me.label353.Name = "label353"
        Me.label353.Size = New System.Drawing.Size(36, 13)
        Me.label353.TabIndex = 2
        Me.label353.Text = "Profile"
        '
        'cbH264Level
        '
        Me.cbH264Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264Level.FormattingEnabled = true
        Me.cbH264Level.Items.AddRange(New Object() {"Auto", "1.0", "1.1", "1.2", "1.3", "2.0", "2.1", "2.2", "3.0", "3.1", "3.2", "4.0", "4.1", "4.2", "5.0", "5.1"})
        Me.cbH264Level.Location = New System.Drawing.Point(94, 46)
        Me.cbH264Level.Name = "cbH264Level"
        Me.cbH264Level.Size = New System.Drawing.Size(121, 21)
        Me.cbH264Level.TabIndex = 1
        '
        'cbH264Profile
        '
        Me.cbH264Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264Profile.FormattingEnabled = true
        Me.cbH264Profile.Items.AddRange(New Object() {"Auto", "Baseline", "Main", "High", "High 10", "High 422"})
        Me.cbH264Profile.Location = New System.Drawing.Point(94, 19)
        Me.cbH264Profile.Name = "cbH264Profile"
        Me.cbH264Profile.Size = New System.Drawing.Size(121, 21)
        Me.cbH264Profile.TabIndex = 0
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.label354)
        Me.tabPage6.Controls.Add(Me.cbAACOutput)
        Me.tabPage6.Controls.Add(Me.label355)
        Me.tabPage6.Controls.Add(Me.cbAACBitrate)
        Me.tabPage6.Controls.Add(Me.label356)
        Me.tabPage6.Controls.Add(Me.cbAACObjectType)
        Me.tabPage6.Controls.Add(Me.label357)
        Me.tabPage6.Controls.Add(Me.cbAACVersion)
        Me.tabPage6.Controls.Add(Me.label358)
        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage6.Size = New System.Drawing.Size(329, 211)
        Me.tabPage6.TabIndex = 2
        Me.tabPage6.Text = "Audio"
        Me.tabPage6.UseVisualStyleBackColor = true
        '
        'label354
        '
        Me.label354.AutoSize = true
        Me.label354.Location = New System.Drawing.Point(230, 88)
        Me.label354.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label354.Name = "label354"
        Me.label354.Size = New System.Drawing.Size(31, 13)
        Me.label354.TabIndex = 17
        Me.label354.Text = "Kbps"
        '
        'cbAACOutput
        '
        Me.cbAACOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACOutput.FormattingEnabled = true
        Me.cbAACOutput.Items.AddRange(New Object() {"RAW", "ADTS"})
        Me.cbAACOutput.Location = New System.Drawing.Point(105, 124)
        Me.cbAACOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACOutput.Name = "cbAACOutput"
        Me.cbAACOutput.Size = New System.Drawing.Size(156, 21)
        Me.cbAACOutput.TabIndex = 16
        '
        'label355
        '
        Me.label355.AutoSize = true
        Me.label355.Location = New System.Drawing.Point(12, 126)
        Me.label355.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label355.Name = "label355"
        Me.label355.Size = New System.Drawing.Size(39, 13)
        Me.label355.TabIndex = 15
        Me.label355.Text = "Output"
        '
        'cbAACBitrate
        '
        Me.cbAACBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACBitrate.FormattingEnabled = true
        Me.cbAACBitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128", "140", "160", "192", "224", "256"})
        Me.cbAACBitrate.Location = New System.Drawing.Point(105, 86)
        Me.cbAACBitrate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACBitrate.Name = "cbAACBitrate"
        Me.cbAACBitrate.Size = New System.Drawing.Size(121, 21)
        Me.cbAACBitrate.TabIndex = 14
        '
        'label356
        '
        Me.label356.AutoSize = true
        Me.label356.Location = New System.Drawing.Point(12, 88)
        Me.label356.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label356.Name = "label356"
        Me.label356.Size = New System.Drawing.Size(37, 13)
        Me.label356.TabIndex = 13
        Me.label356.Text = "Bitrate"
        '
        'cbAACObjectType
        '
        Me.cbAACObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACObjectType.FormattingEnabled = true
        Me.cbAACObjectType.Items.AddRange(New Object() {"Main", "Low complexity", "Scalable Sampling Rate", "Long Term Predictor"})
        Me.cbAACObjectType.Location = New System.Drawing.Point(105, 50)
        Me.cbAACObjectType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACObjectType.Name = "cbAACObjectType"
        Me.cbAACObjectType.Size = New System.Drawing.Size(156, 21)
        Me.cbAACObjectType.TabIndex = 12
        '
        'label357
        '
        Me.label357.AutoSize = true
        Me.label357.Location = New System.Drawing.Point(12, 52)
        Me.label357.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label357.Name = "label357"
        Me.label357.Size = New System.Drawing.Size(61, 13)
        Me.label357.TabIndex = 11
        Me.label357.Text = "Object type"
        '
        'cbAACVersion
        '
        Me.cbAACVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACVersion.FormattingEnabled = true
        Me.cbAACVersion.Items.AddRange(New Object() {"MPEG-4", "MPEG-2"})
        Me.cbAACVersion.Location = New System.Drawing.Point(105, 15)
        Me.cbAACVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACVersion.Name = "cbAACVersion"
        Me.cbAACVersion.Size = New System.Drawing.Size(156, 21)
        Me.cbAACVersion.TabIndex = 10
        '
        'label358
        '
        Me.label358.AutoSize = true
        Me.label358.Location = New System.Drawing.Point(12, 18)
        Me.label358.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label358.Name = "label358"
        Me.label358.Size = New System.Drawing.Size(75, 13)
        Me.label358.TabIndex = 9
        Me.label358.Text = "MPEG version"
        '
        'rbPreview
        '
        Me.rbPreview.AutoSize = true
        Me.rbPreview.Checked = true
        Me.rbPreview.Location = New System.Drawing.Point(7, 357)
        Me.rbPreview.Name = "rbPreview"
        Me.rbPreview.Size = New System.Drawing.Size(63, 17)
        Me.rbPreview.TabIndex = 58
        Me.rbPreview.TabStop = true
        Me.rbPreview.Text = "Preview"
        Me.rbPreview.UseVisualStyleBackColor = true
        '
        'btStop
        '
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStop.Location = New System.Drawing.Point(409, 354)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(62, 23)
        Me.btStop.TabIndex = 57
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = true
        '
        'btStart
        '
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStart.Location = New System.Drawing.Point(344, 354)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(62, 23)
        Me.btStart.TabIndex = 56
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = true
        '
        'llVideoTutorials
        '
        Me.llVideoTutorials.AutoSize = true
        Me.llVideoTutorials.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.llVideoTutorials.Location = New System.Drawing.Point(841, 8)
        Me.llVideoTutorials.Name = "llVideoTutorials"
        Me.llVideoTutorials.Size = New System.Drawing.Size(68, 13)
        Me.llVideoTutorials.TabIndex = 92
        Me.llVideoTutorials.TabStop = true
        Me.llVideoTutorials.Text = "Video tutorial"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(596, 361)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(214, 13)
        Me.label2.TabIndex = 96
        Me.label2.Text = "Much more features available in Main Demo"
        '
        'rbCaptureMP4
        '
        Me.rbCaptureMP4.AutoSize = true
        Me.rbCaptureMP4.Location = New System.Drawing.Point(176, 357)
        Me.rbCaptureMP4.Name = "rbCaptureMP4"
        Me.rbCaptureMP4.Size = New System.Drawing.Size(99, 17)
        Me.rbCaptureMP4.TabIndex = 98
        Me.rbCaptureMP4.Text = "Capture to MP4"
        Me.rbCaptureMP4.UseVisualStyleBackColor = true
        '
        'rbCaptureAVI
        '
        Me.rbCaptureAVI.AutoSize = true
        Me.rbCaptureAVI.Location = New System.Drawing.Point(76, 357)
        Me.rbCaptureAVI.Name = "rbCaptureAVI"
        Me.rbCaptureAVI.Size = New System.Drawing.Size(94, 17)
        Me.rbCaptureAVI.TabIndex = 97
        Me.rbCaptureAVI.Text = "Capture to AVI"
        Me.rbCaptureAVI.UseVisualStyleBackColor = true
        '
        'VideoCapture1
        '
        Me.VideoCapture1.Additional_Audio_CaptureDevice_MixChannels = false
        Me.VideoCapture1.Audio_CaptureDevice = ""
        Me.VideoCapture1.Audio_CaptureDevice_CustomLatency = 0
        Me.VideoCapture1.Audio_CaptureDevice_Format = ""
        Me.VideoCapture1.Audio_CaptureDevice_Format_UseBest = true
        Me.VideoCapture1.Audio_CaptureDevice_Line = ""
        Me.VideoCapture1.Audio_CaptureDevice_MasterDevice = Nothing
        Me.VideoCapture1.Audio_CaptureDevice_MasterDevice_Format = Nothing
        Me.VideoCapture1.Audio_CaptureDevice_Path = Nothing
        Me.VideoCapture1.Audio_CaptureSourceFilter = Nothing
        Me.VideoCapture1.Audio_Channel_Mapper = Nothing
        Me.VideoCapture1.Audio_Decoder = Nothing
        Me.VideoCapture1.Audio_Effects_Enabled = false
        Me.VideoCapture1.Audio_Effects_UseLegacyEffects = false
        Me.VideoCapture1.Audio_Enhancer_Enabled = false
        Me.VideoCapture1.Audio_OutputDevice = "Default DirectSound Device"
        Me.VideoCapture1.Audio_PCM_Converter = Nothing
        Me.VideoCapture1.Audio_PlayAudio = true
        Me.VideoCapture1.Audio_RecordAudio = true
        Me.VideoCapture1.Audio_Sample_Grabber_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Pro_Enabled = false
        Me.VideoCapture1.Audio_VUMeter_Pro_Volume = 100
        Me.VideoCapture1.BackColor = System.Drawing.Color.Black
        Me.VideoCapture1.Barcode_Reader_Enabled = false
        Me.VideoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.VideoCapture1.BDA_Source = Nothing
        Me.VideoCapture1.ChromaKey = Nothing
        Me.VideoCapture1.Custom_Source = Nothing
        Me.VideoCapture1.Debug_Dir = ""
        Me.VideoCapture1.Debug_Mode = false
        Me.VideoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.[Auto]
        Me.VideoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.[Auto]
        Me.VideoCapture1.Decklink_Input_IREUSA = false
        Me.VideoCapture1.Decklink_Input_SMPTE = false
        Me.VideoCapture1.Decklink_Output = Nothing
        Me.VideoCapture1.Decklink_Source = Nothing
        Me.VideoCapture1.DirectCapture_Muxer = Nothing
        Me.VideoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full
        Me.VideoCapture1.Face_Tracking = Nothing
        Me.VideoCapture1.IP_Camera_Source = Nothing
        Me.VideoCapture1.Location = New System.Drawing.Point(481, 25)
        Me.VideoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture
        Me.VideoCapture1.Motion_Detection = Nothing
        Me.VideoCapture1.Motion_DetectionEx = Nothing
        Me.VideoCapture1.MPEG_Audio_Decoder = ""
        Me.VideoCapture1.MPEG_Demuxer = Nothing
        Me.VideoCapture1.MPEG_Video_Decoder = ""
        Me.VideoCapture1.MultiScreen_Enabled = false
        Me.VideoCapture1.Name = "VideoCapture1"
        Me.VideoCapture1.Network_Streaming_Audio_Enabled = false
        Me.VideoCapture1.Network_Streaming_Enabled = false
        Me.VideoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV
        Me.VideoCapture1.Network_Streaming_Network_Port = 100
        Me.VideoCapture1.Network_Streaming_Output = Nothing
        Me.VideoCapture1.Network_Streaming_URL = ""
        Me.VideoCapture1.Network_Streaming_WMV_Maximum_Clients = 10
        Me.VideoCapture1.Output_Filename = ""
        Me.VideoCapture1.Output_Format = Nothing
        Me.VideoCapture1.PIP_AddSampleGrabbers = false
        Me.VideoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom
        Me.VideoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN
        Me.VideoCapture1.Push_Source = Nothing
        Me.VideoCapture1.Screen_Capture_Source = Nothing
        Me.VideoCapture1.SeparateCapture_AutostartCapture = false
        Me.VideoCapture1.SeparateCapture_Enabled = false
        Me.VideoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext"
        Me.VideoCapture1.SeparateCapture_FileSizeThreshold = CType(0,Long)
        Me.VideoCapture1.SeparateCapture_GMFMode = true
        Me.VideoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal
        Me.VideoCapture1.SeparateCapture_TimeThreshold = CType(0,Long)
        Me.VideoCapture1.Size = New System.Drawing.Size(428, 326)
        Me.VideoCapture1.Start_DelayEnabled = false
        Me.VideoCapture1.TabIndex = 93
        Me.VideoCapture1.Tags = Nothing
        Me.VideoCapture1.Timeshift_Settings = Nothing
        Me.VideoCapture1.TVTuner_Channel = 0
        Me.VideoCapture1.TVTuner_Country = ""
        Me.VideoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000
        Me.VideoCapture1.TVTuner_FM_Tuning_Step = 160000000
        Me.VideoCapture1.TVTuner_FM_Tuning_StopFrequency = 0
        Me.VideoCapture1.TVTuner_Frequency = 0
        Me.VideoCapture1.TVTuner_InputType = ""
        Me.VideoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.[Default]
        Me.VideoCapture1.TVTuner_Name = ""
        Me.VideoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D
        Me.VideoCapture1.Video_CaptureDevice = ""
        Me.VideoCapture1.Video_CaptureDevice_Format = ""
        Me.VideoCapture1.Video_CaptureDevice_Format_UseBest = true
        Me.VideoCapture1.Video_CaptureDevice_FrameRate = 0R
        Me.VideoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = ""
        Me.VideoCapture1.Video_CaptureDevice_IsAudioSource = false
        Me.VideoCapture1.Video_CaptureDevice_Path = Nothing
        Me.VideoCapture1.Video_CaptureDevice_UseClosedCaptions = false
        Me.VideoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false
        Me.VideoCapture1.Video_Crop = Nothing
        Me.VideoCapture1.Video_Decoder = Nothing
        Me.VideoCapture1.Video_Effects_AllowMultipleStreams = false
        Me.VideoCapture1.Video_Effects_Enabled = false
        VideoRendererSettingsWinForms13.Aspect_Ratio_Override = false
        VideoRendererSettingsWinForms13.Aspect_Ratio_X = 0
        VideoRendererSettingsWinForms13.Aspect_Ratio_Y = 0
        VideoRendererSettingsWinForms13.BackgroundColor = System.Drawing.Color.Black
'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        VideoRendererSettingsWinForms13.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.[Auto]
        VideoRendererSettingsWinForms13.Deinterlace_VMR9_Mode = Nothing
        VideoRendererSettingsWinForms13.Deinterlace_VMR9_UseDefault = true
        VideoRendererSettingsWinForms13.Flip_Horizontal = false
        VideoRendererSettingsWinForms13.Flip_Vertical = false
        VideoRendererSettingsWinForms13.RotationAngle = 0
        VideoRendererSettingsWinForms13.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox
        VideoRendererSettingsWinForms13.Video_Renderer = VisioForge.Types.VFVideoRenderer.VideoRenderer
        VideoRendererSettingsWinForms13.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.VideoRenderer
        VideoRendererSettingsWinForms13.Zoom_Ratio = 0
        VideoRendererSettingsWinForms13.Zoom_ShiftX = 0
        VideoRendererSettingsWinForms13.Zoom_ShiftY = 0
        Me.VideoCapture1.Video_Renderer = VideoRendererSettingsWinForms13
        Me.VideoCapture1.Video_Resize = Nothing
        Me.VideoCapture1.Video_ResizeOrCrop_Enabled = false
        Me.VideoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone
        Me.VideoCapture1.Video_Sample_Grabber_Enabled = false
        Me.VideoCapture1.Video_Sample_Grabber_UseForVideoEffects = false
        Me.VideoCapture1.Video_Still_Frames_Grabber_Enabled = false
        Me.VideoCapture1.Virtual_Camera_Output_Enabled = false
        Me.VideoCapture1.Virtual_Camera_Output_LicenseKey = Nothing
        Me.VideoCapture1.VLC_Path = Nothing
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.cbLicensing)
        Me.TabPage7.Controls.Add(Me.cbDebugMode)
        Me.TabPage7.Controls.Add(Me.mmLog)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(464, 322)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Debug"
        Me.TabPage7.UseVisualStyleBackColor = true
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.cbImageType)
        Me.TabPage8.Controls.Add(Me.lbJPEGQuality)
        Me.TabPage8.Controls.Add(Me.label38)
        Me.TabPage8.Controls.Add(Me.btSaveScreenshot)
        Me.TabPage8.Controls.Add(Me.label63)
        Me.TabPage8.Controls.Add(Me.edScreenshotsFolder)
        Me.TabPage8.Controls.Add(Me.tbJPEGQuality)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(464, 322)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Screenshot"
        Me.TabPage8.UseVisualStyleBackColor = true
        '
        'tabControl15
        '
        Me.tabControl15.Controls.Add(Me.tabPage144)
        Me.tabControl15.Controls.Add(Me.tabPage146)
        Me.tabControl15.Controls.Add(Me.tabPage145)
        Me.tabControl15.Location = New System.Drawing.Point(12, 35)
        Me.tabControl15.Name = "tabControl15"
        Me.tabControl15.SelectedIndex = 0
        Me.tabControl15.Size = New System.Drawing.Size(447, 282)
        Me.tabControl15.TabIndex = 68
        '
        'tabPage144
        '
        Me.tabPage144.Controls.Add(Me.cbIPCameraONVIF)
        Me.tabPage144.Controls.Add(Me.btShowIPCamDatabase)
        Me.tabPage144.Controls.Add(Me.linkLabel7)
        Me.tabPage144.Controls.Add(Me.cbIPDisconnect)
        Me.tabPage144.Controls.Add(Me.edIPForcedFramerateID)
        Me.tabPage144.Controls.Add(Me.label344)
        Me.tabPage144.Controls.Add(Me.edIPForcedFramerate)
        Me.tabPage144.Controls.Add(Me.label295)
        Me.tabPage144.Controls.Add(Me.cbIPCameraType)
        Me.tabPage144.Controls.Add(Me.edIPPassword)
        Me.tabPage144.Controls.Add(Me.label167)
        Me.tabPage144.Controls.Add(Me.edIPLogin)
        Me.tabPage144.Controls.Add(Me.label166)
        Me.tabPage144.Controls.Add(Me.cbIPAudioCapture)
        Me.tabPage144.Controls.Add(Me.label168)
        Me.tabPage144.Location = New System.Drawing.Point(4, 22)
        Me.tabPage144.Name = "tabPage144"
        Me.tabPage144.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage144.Size = New System.Drawing.Size(439, 256)
        Me.tabPage144.TabIndex = 0
        Me.tabPage144.Text = "Main"
        Me.tabPage144.UseVisualStyleBackColor = true
        '
        'cbIPCameraONVIF
        '
        Me.cbIPCameraONVIF.AutoSize = true
        Me.cbIPCameraONVIF.Location = New System.Drawing.Point(294, 12)
        Me.cbIPCameraONVIF.Name = "cbIPCameraONVIF"
        Me.cbIPCameraONVIF.Size = New System.Drawing.Size(96, 17)
        Me.cbIPCameraONVIF.TabIndex = 78
        Me.cbIPCameraONVIF.Text = "ONVIF camera"
        Me.cbIPCameraONVIF.UseVisualStyleBackColor = true
        '
        'btShowIPCamDatabase
        '
        Me.btShowIPCamDatabase.Location = New System.Drawing.Point(282, 179)
        Me.btShowIPCamDatabase.Name = "btShowIPCamDatabase"
        Me.btShowIPCamDatabase.Size = New System.Drawing.Size(135, 23)
        Me.btShowIPCamDatabase.TabIndex = 77
        Me.btShowIPCamDatabase.Text = "Show IP cam database"
        Me.btShowIPCamDatabase.UseVisualStyleBackColor = true
        '
        'linkLabel7
        '
        Me.linkLabel7.AutoSize = true
        Me.linkLabel7.Location = New System.Drawing.Point(12, 184)
        Me.linkLabel7.Name = "linkLabel7"
        Me.linkLabel7.Size = New System.Drawing.Size(264, 13)
        Me.linkLabel7.TabIndex = 76
        Me.linkLabel7.TabStop = true
        Me.linkLabel7.Text = "Please install VisioForge VLC redist to use VLC engine "
        '
        'cbIPDisconnect
        '
        Me.cbIPDisconnect.AutoSize = true
        Me.cbIPDisconnect.Location = New System.Drawing.Point(15, 127)
        Me.cbIPDisconnect.Name = "cbIPDisconnect"
        Me.cbIPDisconnect.Size = New System.Drawing.Size(136, 17)
        Me.cbIPDisconnect.TabIndex = 75
        Me.cbIPDisconnect.Text = "Notify if connection lost"
        Me.cbIPDisconnect.UseVisualStyleBackColor = true
        '
        'edIPForcedFramerateID
        '
        Me.edIPForcedFramerateID.Location = New System.Drawing.Point(267, 100)
        Me.edIPForcedFramerateID.Margin = New System.Windows.Forms.Padding(2)
        Me.edIPForcedFramerateID.Name = "edIPForcedFramerateID"
        Me.edIPForcedFramerateID.Size = New System.Drawing.Size(32, 20)
        Me.edIPForcedFramerateID.TabIndex = 71
        Me.edIPForcedFramerateID.Text = "0"
        '
        'label344
        '
        Me.label344.AutoSize = true
        Me.label344.Location = New System.Drawing.Point(165, 102)
        Me.label344.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label344.Name = "label344"
        Me.label344.Size = New System.Drawing.Size(98, 13)
        Me.label344.TabIndex = 70
        Me.label344.Text = "Force frame rate ID"
        '
        'edIPForcedFramerate
        '
        Me.edIPForcedFramerate.Location = New System.Drawing.Point(114, 100)
        Me.edIPForcedFramerate.Margin = New System.Windows.Forms.Padding(2)
        Me.edIPForcedFramerate.Name = "edIPForcedFramerate"
        Me.edIPForcedFramerate.Size = New System.Drawing.Size(32, 20)
        Me.edIPForcedFramerate.TabIndex = 69
        Me.edIPForcedFramerate.Text = "0"
        '
        'label295
        '
        Me.label295.AutoSize = true
        Me.label295.Location = New System.Drawing.Point(12, 102)
        Me.label295.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label295.Name = "label295"
        Me.label295.Size = New System.Drawing.Size(84, 13)
        Me.label295.TabIndex = 68
        Me.label295.Text = "Force frame rate"
        '
        'cbIPCameraType
        '
        Me.cbIPCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIPCameraType.FormattingEnabled = true
        Me.cbIPCameraType.Items.AddRange(New Object() {"Auto (VLC engine)", "Auto (FFMPEG engine)", "Auto (LAV engine)", "RTSP (Live555 engine)", "HTTP (FFMPEG engine)", "MMS - WMV", "RTSP - UDP (FFMPEG engine)", "RTSP - TCP (FFMPEG engine)", "RTSP over HTTP (FFMPEG engine)"})
        Me.cbIPCameraType.Location = New System.Drawing.Point(57, 10)
        Me.cbIPCameraType.Name = "cbIPCameraType"
        Me.cbIPCameraType.Size = New System.Drawing.Size(227, 21)
        Me.cbIPCameraType.TabIndex = 67
        '
        'edIPPassword
        '
        Me.edIPPassword.Location = New System.Drawing.Point(168, 58)
        Me.edIPPassword.Name = "edIPPassword"
        Me.edIPPassword.Size = New System.Drawing.Size(100, 20)
        Me.edIPPassword.TabIndex = 66
        '
        'label167
        '
        Me.label167.AutoSize = true
        Me.label167.Location = New System.Drawing.Point(165, 41)
        Me.label167.Name = "label167"
        Me.label167.Size = New System.Drawing.Size(53, 13)
        Me.label167.TabIndex = 65
        Me.label167.Text = "Password"
        '
        'edIPLogin
        '
        Me.edIPLogin.Location = New System.Drawing.Point(15, 58)
        Me.edIPLogin.Name = "edIPLogin"
        Me.edIPLogin.Size = New System.Drawing.Size(100, 20)
        Me.edIPLogin.TabIndex = 64
        '
        'label166
        '
        Me.label166.AutoSize = true
        Me.label166.Location = New System.Drawing.Point(11, 41)
        Me.label166.Name = "label166"
        Me.label166.Size = New System.Drawing.Size(33, 13)
        Me.label166.TabIndex = 63
        Me.label166.Text = "Login"
        '
        'cbIPAudioCapture
        '
        Me.cbIPAudioCapture.AutoSize = true
        Me.cbIPAudioCapture.Checked = true
        Me.cbIPAudioCapture.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIPAudioCapture.Location = New System.Drawing.Point(168, 127)
        Me.cbIPAudioCapture.Name = "cbIPAudioCapture"
        Me.cbIPAudioCapture.Size = New System.Drawing.Size(92, 17)
        Me.cbIPAudioCapture.TabIndex = 62
        Me.cbIPAudioCapture.Text = "Capture audio"
        Me.cbIPAudioCapture.UseVisualStyleBackColor = true
        '
        'label168
        '
        Me.label168.AutoSize = true
        Me.label168.Location = New System.Drawing.Point(11, 14)
        Me.label168.Name = "label168"
        Me.label168.Size = New System.Drawing.Size(40, 13)
        Me.label168.TabIndex = 61
        Me.label168.Text = "Engine"
        '
        'tabPage146
        '
        Me.tabPage146.Controls.Add(Me.cbVLCZeroClockJitter)
        Me.tabPage146.Controls.Add(Me.edVLCCacheSize)
        Me.tabPage146.Controls.Add(Me.label312)
        Me.tabPage146.Location = New System.Drawing.Point(4, 22)
        Me.tabPage146.Name = "tabPage146"
        Me.tabPage146.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage146.Size = New System.Drawing.Size(439, 256)
        Me.tabPage146.TabIndex = 2
        Me.tabPage146.Text = "VLC"
        Me.tabPage146.UseVisualStyleBackColor = true
        '
        'cbVLCZeroClockJitter
        '
        Me.cbVLCZeroClockJitter.AutoSize = true
        Me.cbVLCZeroClockJitter.Location = New System.Drawing.Point(173, 16)
        Me.cbVLCZeroClockJitter.Name = "cbVLCZeroClockJitter"
        Me.cbVLCZeroClockJitter.Size = New System.Drawing.Size(120, 17)
        Me.cbVLCZeroClockJitter.TabIndex = 78
        Me.cbVLCZeroClockJitter.Text = "VLC zero clock jitter"
        Me.cbVLCZeroClockJitter.UseVisualStyleBackColor = true
        '
        'edVLCCacheSize
        '
        Me.edVLCCacheSize.Location = New System.Drawing.Point(119, 14)
        Me.edVLCCacheSize.Name = "edVLCCacheSize"
        Me.edVLCCacheSize.Size = New System.Drawing.Size(32, 20)
        Me.edVLCCacheSize.TabIndex = 77
        Me.edVLCCacheSize.Text = "1000"
        '
        'label312
        '
        Me.label312.AutoSize = true
        Me.label312.Location = New System.Drawing.Point(17, 17)
        Me.label312.Name = "label312"
        Me.label312.Size = New System.Drawing.Size(103, 13)
        Me.label312.TabIndex = 76
        Me.label312.Text = "VLC cache size (ms)"
        '
        'tabPage145
        '
        Me.tabPage145.Controls.Add(Me.edONVIFLiveVideoURL)
        Me.tabPage145.Controls.Add(Me.label513)
        Me.tabPage145.Controls.Add(Me.groupBox42)
        Me.tabPage145.Controls.Add(Me.cbONVIFProfile)
        Me.tabPage145.Controls.Add(Me.label510)
        Me.tabPage145.Controls.Add(Me.lbONVIFCameraInfo)
        Me.tabPage145.Controls.Add(Me.btONVIFConnect)
        Me.tabPage145.Location = New System.Drawing.Point(4, 22)
        Me.tabPage145.Name = "tabPage145"
        Me.tabPage145.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage145.Size = New System.Drawing.Size(439, 256)
        Me.tabPage145.TabIndex = 1
        Me.tabPage145.Text = "ONVIF"
        Me.tabPage145.UseVisualStyleBackColor = true
        '
        'edONVIFLiveVideoURL
        '
        Me.edONVIFLiveVideoURL.Location = New System.Drawing.Point(75, 75)
        Me.edONVIFLiveVideoURL.Name = "edONVIFLiveVideoURL"
        Me.edONVIFLiveVideoURL.ReadOnly = true
        Me.edONVIFLiveVideoURL.Size = New System.Drawing.Size(346, 20)
        Me.edONVIFLiveVideoURL.TabIndex = 28
        '
        'label513
        '
        Me.label513.AutoSize = true
        Me.label513.Location = New System.Drawing.Point(11, 78)
        Me.label513.Name = "label513"
        Me.label513.Size = New System.Drawing.Size(59, 13)
        Me.label513.TabIndex = 27
        Me.label513.Text = "Video URL"
        '
        'groupBox42
        '
        Me.groupBox42.Controls.Add(Me.btONVIFPTZSetDefault)
        Me.groupBox42.Controls.Add(Me.btONVIFRight)
        Me.groupBox42.Controls.Add(Me.btONVIFLeft)
        Me.groupBox42.Controls.Add(Me.btONVIFZoomOut)
        Me.groupBox42.Controls.Add(Me.btONVIFZoomIn)
        Me.groupBox42.Controls.Add(Me.btONVIFDown)
        Me.groupBox42.Controls.Add(Me.btONVIFUp)
        Me.groupBox42.Location = New System.Drawing.Point(14, 103)
        Me.groupBox42.Name = "groupBox42"
        Me.groupBox42.Size = New System.Drawing.Size(271, 104)
        Me.groupBox42.TabIndex = 26
        Me.groupBox42.TabStop = false
        Me.groupBox42.Text = "PTZ"
        '
        'btONVIFPTZSetDefault
        '
        Me.btONVIFPTZSetDefault.Location = New System.Drawing.Point(130, 44)
        Me.btONVIFPTZSetDefault.Name = "btONVIFPTZSetDefault"
        Me.btONVIFPTZSetDefault.Size = New System.Drawing.Size(116, 23)
        Me.btONVIFPTZSetDefault.TabIndex = 6
        Me.btONVIFPTZSetDefault.Text = "Set default position"
        Me.btONVIFPTZSetDefault.UseVisualStyleBackColor = true
        '
        'btONVIFRight
        '
        Me.btONVIFRight.Location = New System.Drawing.Point(85, 33)
        Me.btONVIFRight.Name = "btONVIFRight"
        Me.btONVIFRight.Size = New System.Drawing.Size(21, 48)
        Me.btONVIFRight.TabIndex = 5
        Me.btONVIFRight.Text = "R"
        Me.btONVIFRight.UseVisualStyleBackColor = true
        '
        'btONVIFLeft
        '
        Me.btONVIFLeft.Location = New System.Drawing.Point(13, 32)
        Me.btONVIFLeft.Name = "btONVIFLeft"
        Me.btONVIFLeft.Size = New System.Drawing.Size(21, 48)
        Me.btONVIFLeft.TabIndex = 4
        Me.btONVIFLeft.Text = "L"
        Me.btONVIFLeft.UseVisualStyleBackColor = true
        '
        'btONVIFZoomOut
        '
        Me.btONVIFZoomOut.Location = New System.Drawing.Point(61, 45)
        Me.btONVIFZoomOut.Name = "btONVIFZoomOut"
        Me.btONVIFZoomOut.Size = New System.Drawing.Size(23, 23)
        Me.btONVIFZoomOut.TabIndex = 3
        Me.btONVIFZoomOut.Text = "-"
        Me.btONVIFZoomOut.UseVisualStyleBackColor = true
        '
        'btONVIFZoomIn
        '
        Me.btONVIFZoomIn.Location = New System.Drawing.Point(35, 45)
        Me.btONVIFZoomIn.Name = "btONVIFZoomIn"
        Me.btONVIFZoomIn.Size = New System.Drawing.Size(22, 23)
        Me.btONVIFZoomIn.TabIndex = 2
        Me.btONVIFZoomIn.Text = "+"
        Me.btONVIFZoomIn.UseVisualStyleBackColor = true
        '
        'btONVIFDown
        '
        Me.btONVIFDown.Location = New System.Drawing.Point(34, 69)
        Me.btONVIFDown.Name = "btONVIFDown"
        Me.btONVIFDown.Size = New System.Drawing.Size(51, 23)
        Me.btONVIFDown.TabIndex = 1
        Me.btONVIFDown.Text = "Down"
        Me.btONVIFDown.UseVisualStyleBackColor = true
        '
        'btONVIFUp
        '
        Me.btONVIFUp.Location = New System.Drawing.Point(34, 20)
        Me.btONVIFUp.Name = "btONVIFUp"
        Me.btONVIFUp.Size = New System.Drawing.Size(51, 23)
        Me.btONVIFUp.TabIndex = 0
        Me.btONVIFUp.Text = "Up"
        Me.btONVIFUp.UseVisualStyleBackColor = true
        '
        'cbONVIFProfile
        '
        Me.cbONVIFProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbONVIFProfile.FormattingEnabled = true
        Me.cbONVIFProfile.Location = New System.Drawing.Point(75, 49)
        Me.cbONVIFProfile.Name = "cbONVIFProfile"
        Me.cbONVIFProfile.Size = New System.Drawing.Size(346, 21)
        Me.cbONVIFProfile.TabIndex = 4
        '
        'label510
        '
        Me.label510.AutoSize = true
        Me.label510.Location = New System.Drawing.Point(12, 52)
        Me.label510.Name = "label510"
        Me.label510.Size = New System.Drawing.Size(36, 13)
        Me.label510.TabIndex = 3
        Me.label510.Text = "Profile"
        '
        'lbONVIFCameraInfo
        '
        Me.lbONVIFCameraInfo.AutoSize = true
        Me.lbONVIFCameraInfo.Location = New System.Drawing.Point(95, 22)
        Me.lbONVIFCameraInfo.Name = "lbONVIFCameraInfo"
        Me.lbONVIFCameraInfo.Size = New System.Drawing.Size(126, 13)
        Me.lbONVIFCameraInfo.TabIndex = 1
        Me.lbONVIFCameraInfo.Text = "Camera info not available"
        '
        'btONVIFConnect
        '
        Me.btONVIFConnect.Location = New System.Drawing.Point(14, 17)
        Me.btONVIFConnect.Name = "btONVIFConnect"
        Me.btONVIFConnect.Size = New System.Drawing.Size(75, 23)
        Me.btONVIFConnect.TabIndex = 0
        Me.btONVIFConnect.Text = "Connect"
        Me.btONVIFConnect.UseVisualStyleBackColor = true
        '
        'edIPUrl
        '
        Me.edIPUrl.Location = New System.Drawing.Point(62, 9)
        Me.edIPUrl.Name = "edIPUrl"
        Me.edIPUrl.Size = New System.Drawing.Size(393, 20)
        Me.edIPUrl.TabIndex = 67
        Me.edIPUrl.Text = "http://212.162.177.75/mjpg/video.mjpg"
        '
        'label165
        '
        Me.label165.AutoSize = true
        Me.label165.Location = New System.Drawing.Point(17, 11)
        Me.label165.Name = "label165"
        Me.label165.Size = New System.Drawing.Size(29, 13)
        Me.label165.TabIndex = 66
        Me.label165.Text = "URL"
        '
        'cbImageType
        '
        Me.cbImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImageType.FormattingEnabled = true
        Me.cbImageType.Items.AddRange(New Object() {"BMP", "JPEG", "GIF", "PNG", "TIFF"})
        Me.cbImageType.Location = New System.Drawing.Point(19, 40)
        Me.cbImageType.Name = "cbImageType"
        Me.cbImageType.Size = New System.Drawing.Size(86, 21)
        Me.cbImageType.TabIndex = 48
        '
        'lbJPEGQuality
        '
        Me.lbJPEGQuality.AutoSize = true
        Me.lbJPEGQuality.Location = New System.Drawing.Point(270, 43)
        Me.lbJPEGQuality.Name = "lbJPEGQuality"
        Me.lbJPEGQuality.Size = New System.Drawing.Size(19, 13)
        Me.lbJPEGQuality.TabIndex = 47
        Me.lbJPEGQuality.Text = "85"
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Location = New System.Drawing.Point(127, 43)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(67, 13)
        Me.label38.TabIndex = 46
        Me.label38.Text = "JPEG quality"
        '
        'btSaveScreenshot
        '
        Me.btSaveScreenshot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSaveScreenshot.Location = New System.Drawing.Point(295, 38)
        Me.btSaveScreenshot.Name = "btSaveScreenshot"
        Me.btSaveScreenshot.Size = New System.Drawing.Size(56, 23)
        Me.btSaveScreenshot.TabIndex = 44
        Me.btSaveScreenshot.Text = "Save"
        Me.btSaveScreenshot.UseVisualStyleBackColor = true
        '
        'label63
        '
        Me.label63.AutoSize = true
        Me.label63.Location = New System.Drawing.Point(16, 17)
        Me.label63.Name = "label63"
        Me.label63.Size = New System.Drawing.Size(36, 13)
        Me.label63.TabIndex = 43
        Me.label63.Text = "Folder"
        '
        'edScreenshotsFolder
        '
        Me.edScreenshotsFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edScreenshotsFolder.Location = New System.Drawing.Point(61, 14)
        Me.edScreenshotsFolder.Name = "edScreenshotsFolder"
        Me.edScreenshotsFolder.Size = New System.Drawing.Size(290, 20)
        Me.edScreenshotsFolder.TabIndex = 42
        Me.edScreenshotsFolder.Text = "c:\"
        '
        'tbJPEGQuality
        '
        Me.tbJPEGQuality.BackColor = System.Drawing.SystemColors.Window
        Me.tbJPEGQuality.Location = New System.Drawing.Point(200, 38)
        Me.tbJPEGQuality.Maximum = 100
        Me.tbJPEGQuality.Name = "tbJPEGQuality"
        Me.tbJPEGQuality.Size = New System.Drawing.Size(64, 45)
        Me.tbJPEGQuality.TabIndex = 45
        Me.tbJPEGQuality.TickFrequency = 5
        Me.tbJPEGQuality.Value = 85
        '
        'cbLicensing
        '
        Me.cbLicensing.AutoSize = true
        Me.cbLicensing.Location = New System.Drawing.Point(12, 14)
        Me.cbLicensing.Name = "cbLicensing"
        Me.cbLicensing.Size = New System.Drawing.Size(91, 17)
        Me.cbLicensing.TabIndex = 79
        Me.cbLicensing.Text = "Licensing info"
        Me.cbLicensing.UseVisualStyleBackColor = true
        '
        'cbDebugMode
        '
        Me.cbDebugMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbDebugMode.AutoSize = true
        Me.cbDebugMode.Location = New System.Drawing.Point(109, 14)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(87, 17)
        Me.cbDebugMode.TabIndex = 78
        Me.cbDebugMode.Text = "Debug mode"
        Me.cbDebugMode.UseVisualStyleBackColor = true
        '
        'mmLog
        '
        Me.mmLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.mmLog.Location = New System.Drawing.Point(12, 37)
        Me.mmLog.Multiline = true
        Me.mmLog.Name = "mmLog"
        Me.mmLog.Size = New System.Drawing.Size(338, 30)
        Me.mmLog.TabIndex = 77
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 388)
        Me.Controls.Add(Me.rbCaptureMP4)
        Me.Controls.Add(Me.rbCaptureAVI)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.VideoCapture1)
        Me.Controls.Add(Me.llVideoTutorials)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.rbPreview)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btStart)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "IP Preview/Capture Demo - VisioForge Video Capture SDK .Net"
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabPage2.ResumeLayout(false)
        Me.tabPage2.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.tabControl2.ResumeLayout(false)
        Me.tabPage4.ResumeLayout(false)
        Me.tabPage4.PerformLayout
        Me.tabPage5.ResumeLayout(false)
        Me.groupBox29.ResumeLayout(false)
        Me.groupBox29.PerformLayout
        Me.groupBox46.ResumeLayout(false)
        Me.groupBox46.PerformLayout
        Me.tabPage6.ResumeLayout(false)
        Me.tabPage6.PerformLayout
        Me.TabPage7.ResumeLayout(false)
        Me.TabPage7.PerformLayout
        Me.TabPage8.ResumeLayout(false)
        Me.TabPage8.PerformLayout
        Me.tabControl15.ResumeLayout(false)
        Me.tabPage144.ResumeLayout(false)
        Me.tabPage144.PerformLayout
        Me.tabPage146.ResumeLayout(false)
        Me.tabPage146.PerformLayout
        Me.tabPage145.ResumeLayout(false)
        Me.tabPage145.PerformLayout
        Me.groupBox42.ResumeLayout(false)
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents btSelectOutput As System.Windows.Forms.Button
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents edOutputAVI As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label27 As System.Windows.Forms.Label
    Private WithEvents btAudioSettings As System.Windows.Forms.Button
    Private WithEvents btVideoSettings As System.Windows.Forms.Button
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents label30 As System.Windows.Forms.Label
    Private WithEvents label31 As System.Windows.Forms.Label
    Private WithEvents cbChannels As System.Windows.Forms.ComboBox
    Private WithEvents cbBPS As System.Windows.Forms.ComboBox
    Private WithEvents cbAudioCodecs As System.Windows.Forms.ComboBox
    Private WithEvents cbSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents cbVideoCodecs As System.Windows.Forms.ComboBox
    Private WithEvents rbPreview As System.Windows.Forms.RadioButton
    Private WithEvents btStop As System.Windows.Forms.Button
    Private WithEvents btStart As System.Windows.Forms.Button
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents llVideoTutorials As System.Windows.Forms.LinkLabel
    Friend WithEvents VideoCapture1 As VisioForge.Controls.UI.WinForms.VideoCapture
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents rbCaptureMP4 As System.Windows.Forms.RadioButton
    Private WithEvents rbCaptureAVI As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents tabControl2 As System.Windows.Forms.TabControl
    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
    Private WithEvents btSelectOutputMP4 As System.Windows.Forms.Button
    Private WithEvents edOutputMP4 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
    Private WithEvents groupBox29 As System.Windows.Forms.GroupBox
    Private WithEvents cbH264GOP As System.Windows.Forms.CheckBox
    Private WithEvents cbH264AutoBitrate As System.Windows.Forms.CheckBox
    Private WithEvents label350 As System.Windows.Forms.Label
    Private WithEvents edH264Bitrate As System.Windows.Forms.TextBox
    Private WithEvents label351 As System.Windows.Forms.Label
    Private WithEvents cbH264RateControl As System.Windows.Forms.ComboBox
    Private WithEvents groupBox46 As System.Windows.Forms.GroupBox
    Private WithEvents cbH264TargetUsage As System.Windows.Forms.ComboBox
    Private WithEvents label359 As System.Windows.Forms.Label
    Private WithEvents label352 As System.Windows.Forms.Label
    Private WithEvents label353 As System.Windows.Forms.Label
    Private WithEvents cbH264Level As System.Windows.Forms.ComboBox
    Private WithEvents cbH264Profile As System.Windows.Forms.ComboBox
    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
    Private WithEvents label354 As System.Windows.Forms.Label
    Private WithEvents cbAACOutput As System.Windows.Forms.ComboBox
    Private WithEvents label355 As System.Windows.Forms.Label
    Private WithEvents cbAACBitrate As System.Windows.Forms.ComboBox
    Private WithEvents label356 As System.Windows.Forms.Label
    Private WithEvents cbAACObjectType As System.Windows.Forms.ComboBox
    Private WithEvents label357 As System.Windows.Forms.Label
    Private WithEvents cbAACVersion As System.Windows.Forms.ComboBox
    Private WithEvents label358 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Private WithEvents tabControl15 As TabControl
    Private WithEvents tabPage144 As TabPage
    Private WithEvents cbIPCameraONVIF As CheckBox
    Private WithEvents btShowIPCamDatabase As Button
    Private WithEvents linkLabel7 As LinkLabel
    Private WithEvents cbIPDisconnect As CheckBox
    Private WithEvents edIPForcedFramerateID As TextBox
    Private WithEvents label344 As Label
    Private WithEvents edIPForcedFramerate As TextBox
    Private WithEvents label295 As Label
    Private WithEvents cbIPCameraType As ComboBox
    Private WithEvents edIPPassword As TextBox
    Private WithEvents label167 As Label
    Private WithEvents edIPLogin As TextBox
    Private WithEvents label166 As Label
    Private WithEvents cbIPAudioCapture As CheckBox
    Private WithEvents label168 As Label
    Private WithEvents tabPage146 As TabPage
    Private WithEvents cbVLCZeroClockJitter As CheckBox
    Private WithEvents edVLCCacheSize As TextBox
    Private WithEvents label312 As Label
    Private WithEvents tabPage145 As TabPage
    Private WithEvents edONVIFLiveVideoURL As TextBox
    Private WithEvents label513 As Label
    Private WithEvents groupBox42 As GroupBox
    Private WithEvents btONVIFPTZSetDefault As Button
    Private WithEvents btONVIFRight As Button
    Private WithEvents btONVIFLeft As Button
    Private WithEvents btONVIFZoomOut As Button
    Private WithEvents btONVIFZoomIn As Button
    Private WithEvents btONVIFDown As Button
    Private WithEvents btONVIFUp As Button
    Private WithEvents cbONVIFProfile As ComboBox
    Private WithEvents label510 As Label
    Private WithEvents lbONVIFCameraInfo As Label
    Private WithEvents btONVIFConnect As Button
    Private WithEvents edIPUrl As TextBox
    Private WithEvents label165 As Label
    Private WithEvents cbLicensing As CheckBox
    Private WithEvents cbDebugMode As CheckBox
    Private WithEvents mmLog As TextBox
    Friend WithEvents cbImageType As ComboBox
    Private WithEvents lbJPEGQuality As Label
    Private WithEvents label38 As Label
    Private WithEvents btSaveScreenshot As Button
    Private WithEvents label63 As Label
    Private WithEvents edScreenshotsFolder As TextBox
    Private WithEvents tbJPEGQuality As TrackBar
End Class
