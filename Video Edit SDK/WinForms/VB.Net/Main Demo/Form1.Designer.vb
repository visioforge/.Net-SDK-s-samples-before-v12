Imports VisioForge.Types

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim VideoRendererSettingsWinForms7 As VisioForge.Types.VideoRendererSettingsWinForms = New VisioForge.Types.VideoRendererSettingsWinForms()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.mmLog = New System.Windows.Forms.TextBox()
        Me.label120 = New System.Windows.Forms.Label()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.rbPreview = New System.Windows.Forms.RadioButton()
        Me.rbConvert = New System.Windows.Forms.RadioButton()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.btSelectOutput = New System.Windows.Forms.Button()
        Me.edOutput = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.cbOutputVideoFormat = New System.Windows.Forms.ComboBox()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPage30 = New System.Windows.Forms.TabPage()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.edCropRight = New System.Windows.Forms.TextBox()
        Me.label176 = New System.Windows.Forms.Label()
        Me.edCropBottom = New System.Windows.Forms.TextBox()
        Me.label252 = New System.Windows.Forms.Label()
        Me.edCropLeft = New System.Windows.Forms.TextBox()
        Me.label270 = New System.Windows.Forms.Label()
        Me.edCropTop = New System.Windows.Forms.TextBox()
        Me.label272 = New System.Windows.Forms.Label()
        Me.cbCrop = New System.Windows.Forms.CheckBox()
        Me.label92 = New System.Windows.Forms.Label()
        Me.cbRotate = New System.Windows.Forms.ComboBox()
        Me.cbFrameRate = New System.Windows.Forms.ComboBox()
        Me.edHeight = New System.Windows.Forms.TextBox()
        Me.edWidth = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbResize = New System.Windows.Forms.CheckBox()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.cbUseLameInAVI = New System.Windows.Forms.CheckBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cbBPS = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cbSampleRate = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cbChannels = New System.Windows.Forms.ComboBox()
        Me.btAudioSettings = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbAudioCodec = New System.Windows.Forms.ComboBox()
        Me.btVideoSettings = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbVideoCodec = New System.Windows.Forms.ComboBox()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.tabControl11 = New System.Windows.Forms.TabControl()
        Me.tabPage13 = New System.Windows.Forms.TabPage()
        Me.label189 = New System.Windows.Forms.Label()
        Me.edWMVKeyFrameInterval = New System.Windows.Forms.TextBox()
        Me.label190 = New System.Windows.Forms.Label()
        Me.label191 = New System.Windows.Forms.Label()
        Me.edWMVFrameRate = New System.Windows.Forms.TextBox()
        Me.label192 = New System.Windows.Forms.Label()
        Me.edWMVVideoQuality = New System.Windows.Forms.TextBox()
        Me.label188 = New System.Windows.Forms.Label()
        Me.cbWMVTVFormat = New System.Windows.Forms.ComboBox()
        Me.label187 = New System.Windows.Forms.Label()
        Me.label183 = New System.Windows.Forms.Label()
        Me.edWMVVideoPeakBitrate = New System.Windows.Forms.TextBox()
        Me.label184 = New System.Windows.Forms.Label()
        Me.label185 = New System.Windows.Forms.Label()
        Me.edWMVVideoBitrate = New System.Windows.Forms.TextBox()
        Me.label186 = New System.Windows.Forms.Label()
        Me.label62 = New System.Windows.Forms.Label()
        Me.cbWMVSizeSameAsInput = New System.Windows.Forms.CheckBox()
        Me.edWMVHeight = New System.Windows.Forms.TextBox()
        Me.edWMVWidth = New System.Windows.Forms.TextBox()
        Me.label182 = New System.Windows.Forms.Label()
        Me.cbWMVVideoEnabled = New System.Windows.Forms.CheckBox()
        Me.cbWMVVideoCodec = New System.Windows.Forms.ComboBox()
        Me.label174 = New System.Windows.Forms.Label()
        Me.cbWMVVideoMode = New System.Windows.Forms.ComboBox()
        Me.label175 = New System.Windows.Forms.Label()
        Me.tabPage19 = New System.Windows.Forms.TabPage()
        Me.cbWMVAudioEnabled = New System.Windows.Forms.CheckBox()
        Me.label193 = New System.Windows.Forms.Label()
        Me.edWMVAudioPeakBitrate = New System.Windows.Forms.TextBox()
        Me.label194 = New System.Windows.Forms.Label()
        Me.cbWMVAudioFormat = New System.Windows.Forms.ComboBox()
        Me.label195 = New System.Windows.Forms.Label()
        Me.cbWMVAudioCodec = New System.Windows.Forms.ComboBox()
        Me.label196 = New System.Windows.Forms.Label()
        Me.cbWMVAudioMode = New System.Windows.Forms.ComboBox()
        Me.label197 = New System.Windows.Forms.Label()
        Me.rbWMVCustom = New System.Windows.Forms.RadioButton()
        Me.cbWMVInternalProfile8 = New System.Windows.Forms.ComboBox()
        Me.rbWMVInternal8 = New System.Windows.Forms.RadioButton()
        Me.cbWMVInternalProfile9 = New System.Windows.Forms.ComboBox()
        Me.rbWMVInternal9 = New System.Windows.Forms.RadioButton()
        Me.rbWMVExternal = New System.Windows.Forms.RadioButton()
        Me.btSelectWM = New System.Windows.Forms.Button()
        Me.edWMVProfile = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbDVType2 = New System.Windows.Forms.RadioButton()
        Me.rbDVType1 = New System.Windows.Forms.RadioButton()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.rbDVNTSC = New System.Windows.Forms.RadioButton()
        Me.rbDVPAL = New System.Windows.Forms.RadioButton()
        Me.groupBox10 = New System.Windows.Forms.GroupBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.cbDVChannels = New System.Windows.Forms.ComboBox()
        Me.cbDVSampleRate = New System.Windows.Forms.ComboBox()
        Me.tabPage10 = New System.Windows.Forms.TabPage()
        Me.btAudioSettings2 = New System.Windows.Forms.Button()
        Me.label67 = New System.Windows.Forms.Label()
        Me.cbAudioCodecs2 = New System.Windows.Forms.ComboBox()
        Me.cbSampleRate2 = New System.Windows.Forms.ComboBox()
        Me.label68 = New System.Windows.Forms.Label()
        Me.cbBPS2 = New System.Windows.Forms.ComboBox()
        Me.label69 = New System.Windows.Forms.Label()
        Me.cbChannels2 = New System.Windows.Forms.ComboBox()
        Me.label70 = New System.Windows.Forms.Label()
        Me.tabPage11 = New System.Windows.Forms.TabPage()
        Me.tabControl4 = New System.Windows.Forms.TabControl()
        Me.tabPage17 = New System.Windows.Forms.TabPage()
        Me.label71 = New System.Windows.Forms.Label()
        Me.tbLameEncodingQuality = New System.Windows.Forms.TrackBar()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.cbLameSampleRate = New System.Windows.Forms.ComboBox()
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.rbLameMono = New System.Windows.Forms.RadioButton()
        Me.rbLameDualChannels = New System.Windows.Forms.RadioButton()
        Me.rbLameJointStereo = New System.Windows.Forms.RadioButton()
        Me.rbLameStandardStereo = New System.Windows.Forms.RadioButton()
        Me.groupBox12 = New System.Windows.Forms.GroupBox()
        Me.label74 = New System.Windows.Forms.Label()
        Me.tbLameVBRQuality = New System.Windows.Forms.TrackBar()
        Me.cbLameVBRMax = New System.Windows.Forms.ComboBox()
        Me.label75 = New System.Windows.Forms.Label()
        Me.label76 = New System.Windows.Forms.Label()
        Me.cbLameVBRMin = New System.Windows.Forms.ComboBox()
        Me.label77 = New System.Windows.Forms.Label()
        Me.label78 = New System.Windows.Forms.Label()
        Me.cbLameCBRBitrate = New System.Windows.Forms.ComboBox()
        Me.rbLameVBR = New System.Windows.Forms.RadioButton()
        Me.rbLameCBR = New System.Windows.Forms.RadioButton()
        Me.tabPage18 = New System.Windows.Forms.TabPage()
        Me.cbLameVoiceEncodingMode = New System.Windows.Forms.CheckBox()
        Me.cbLameModeFixed = New System.Windows.Forms.CheckBox()
        Me.cbLameEnableXingVBRTag = New System.Windows.Forms.CheckBox()
        Me.cbLameDisableShortBlocks = New System.Windows.Forms.CheckBox()
        Me.cbLameStrictISOCompilance = New System.Windows.Forms.CheckBox()
        Me.cbLameKeepAllFrequences = New System.Windows.Forms.CheckBox()
        Me.cbLameStrictlyEnforceVBRMinBitrate = New System.Windows.Forms.CheckBox()
        Me.cbLameForceMono = New System.Windows.Forms.CheckBox()
        Me.cbLameCRCProtected = New System.Windows.Forms.CheckBox()
        Me.cbLameOriginal = New System.Windows.Forms.CheckBox()
        Me.cbLameCopyright = New System.Windows.Forms.CheckBox()
        Me.tabPage12 = New System.Windows.Forms.TabPage()
        Me.label60 = New System.Windows.Forms.Label()
        Me.label61 = New System.Windows.Forms.Label()
        Me.cbOGGAverage = New System.Windows.Forms.ComboBox()
        Me.label58 = New System.Windows.Forms.Label()
        Me.label59 = New System.Windows.Forms.Label()
        Me.cbOGGMaximum = New System.Windows.Forms.ComboBox()
        Me.label57 = New System.Windows.Forms.Label()
        Me.label56 = New System.Windows.Forms.Label()
        Me.cbOGGMinimum = New System.Windows.Forms.ComboBox()
        Me.rbOGGBitrate = New System.Windows.Forms.RadioButton()
        Me.edOGGQuality = New System.Windows.Forms.TextBox()
        Me.label55 = New System.Windows.Forms.Label()
        Me.rbOGGQuality = New System.Windows.Forms.RadioButton()
        Me.tabPage8 = New System.Windows.Forms.TabPage()
        Me.btCustomFilewriterSettings = New System.Windows.Forms.Button()
        Me.cbCustomFilewriter = New System.Windows.Forms.ComboBox()
        Me.cbUseSpecialFilewriter = New System.Windows.Forms.CheckBox()
        Me.cbCustomMuxFilterIsEncoder = New System.Windows.Forms.CheckBox()
        Me.btCustomMuxerSettings = New System.Windows.Forms.Button()
        Me.cbCustomMuxer = New System.Windows.Forms.ComboBox()
        Me.label34 = New System.Windows.Forms.Label()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.btCustomDSFiltersASettings = New System.Windows.Forms.Button()
        Me.cbCustomDSFilterA = New System.Windows.Forms.ComboBox()
        Me.rbCustomUseDSFiltersCat = New System.Windows.Forms.RadioButton()
        Me.btCustomAudioCodecSettings = New System.Windows.Forms.Button()
        Me.cbCustomAudioCodec = New System.Windows.Forms.ComboBox()
        Me.rbCustomUseAudioCodecsCat = New System.Windows.Forms.RadioButton()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btCustomDSFiltersVSettings = New System.Windows.Forms.Button()
        Me.cbCustomDSFilterV = New System.Windows.Forms.ComboBox()
        Me.rbCustomUseDSFiltersCap = New System.Windows.Forms.RadioButton()
        Me.btCustomVideoCodecSettings = New System.Windows.Forms.Button()
        Me.cbCustomVideoCodec = New System.Windows.Forms.ComboBox()
        Me.rbCustomUseVideoCodecsCat = New System.Windows.Forms.RadioButton()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.tabControl6 = New System.Windows.Forms.TabControl()
        Me.tabPage58 = New System.Windows.Forms.TabPage()
        Me.cbWebMVideoKeyframeMode = New System.Windows.Forms.ComboBox()
        Me.label113 = New System.Windows.Forms.Label()
        Me.edWebMVideoKeyframeMaxInterval = New System.Windows.Forms.TextBox()
        Me.label100 = New System.Windows.Forms.Label()
        Me.edWebMVideoKeyframeMinInterval = New System.Windows.Forms.TextBox()
        Me.label99 = New System.Windows.Forms.Label()
        Me.edWebMVideoMaxQuantizer = New System.Windows.Forms.TextBox()
        Me.label88 = New System.Windows.Forms.Label()
        Me.edWebMVideoMinQuantizer = New System.Windows.Forms.TextBox()
        Me.label86 = New System.Windows.Forms.Label()
        Me.label79 = New System.Windows.Forms.Label()
        Me.cbWebMVideoEncoder = New System.Windows.Forms.ComboBox()
        Me.cbWebMVideoQualityMode = New System.Windows.Forms.ComboBox()
        Me.label63 = New System.Windows.Forms.Label()
        Me.label179 = New System.Windows.Forms.Label()
        Me.cbWebMVideoEndUsageMode = New System.Windows.Forms.ComboBox()
        Me.label178 = New System.Windows.Forms.Label()
        Me.edWebMVideoThreadCount = New System.Windows.Forms.TextBox()
        Me.label173 = New System.Windows.Forms.Label()
        Me.edWebMVideoBitrate = New System.Windows.Forms.TextBox()
        Me.label172 = New System.Windows.Forms.Label()
        Me.tabPage60 = New System.Windows.Forms.TabPage()
        Me.tbWebMAudioQuality = New System.Windows.Forms.TrackBar()
        Me.label223 = New System.Windows.Forms.Label()
        Me.tabPage61 = New System.Windows.Forms.TabPage()
        Me.cbWebMVideoAutoAltRef = New System.Windows.Forms.CheckBox()
        Me.label98 = New System.Windows.Forms.Label()
        Me.edWebMVideoDecoderOptimalBuffer = New System.Windows.Forms.TextBox()
        Me.label97 = New System.Windows.Forms.Label()
        Me.edWebMVideoDecoderInitialBuffer = New System.Windows.Forms.TextBox()
        Me.label96 = New System.Windows.Forms.Label()
        Me.edWebMVideoDecoderBufferSize = New System.Windows.Forms.TextBox()
        Me.edWebMVideoOvershootPct = New System.Windows.Forms.TextBox()
        Me.label94 = New System.Windows.Forms.Label()
        Me.edWebMVideoUndershootPct = New System.Windows.Forms.TextBox()
        Me.label93 = New System.Windows.Forms.Label()
        Me.edWebMVideoLagInFrames = New System.Windows.Forms.TextBox()
        Me.label85 = New System.Windows.Forms.Label()
        Me.edWebMVideoSpatialDownThreshold = New System.Windows.Forms.TextBox()
        Me.label84 = New System.Windows.Forms.Label()
        Me.edWebMVideoSpatialUpThreshold = New System.Windows.Forms.TextBox()
        Me.label83 = New System.Windows.Forms.Label()
        Me.cbWebMVideoSpatialResamplingAllowed = New System.Windows.Forms.CheckBox()
        Me.edWebMVideoDropFrameThreshold = New System.Windows.Forms.TextBox()
        Me.label82 = New System.Windows.Forms.Label()
        Me.cbWebMVideoErrorResilent = New System.Windows.Forms.CheckBox()
        Me.tabPage63 = New System.Windows.Forms.TabPage()
        Me.label112 = New System.Windows.Forms.Label()
        Me.edWebMVideoTokenPartition = New System.Windows.Forms.TextBox()
        Me.label111 = New System.Windows.Forms.Label()
        Me.edWebMVideoDecimate = New System.Windows.Forms.TextBox()
        Me.label110 = New System.Windows.Forms.Label()
        Me.edWebMVideoStaticThreshold = New System.Windows.Forms.TextBox()
        Me.edWebMVideoCPUUsed = New System.Windows.Forms.TextBox()
        Me.label109 = New System.Windows.Forms.Label()
        Me.edWebMVideoFixedKeyframeInterval = New System.Windows.Forms.TextBox()
        Me.label108 = New System.Windows.Forms.Label()
        Me.edWebMVideoARNRType = New System.Windows.Forms.TextBox()
        Me.label103 = New System.Windows.Forms.Label()
        Me.edWebMVideoARNRStrenght = New System.Windows.Forms.TextBox()
        Me.label102 = New System.Windows.Forms.Label()
        Me.edWebMVideoARNRMaxFrames = New System.Windows.Forms.TextBox()
        Me.label101 = New System.Windows.Forms.Label()
        Me.TabPage15 = New System.Windows.Forms.TabPage()
        Me.tabControl16 = New System.Windows.Forms.TabControl()
        Me.tabPage62 = New System.Windows.Forms.TabPage()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.tabPage64 = New System.Windows.Forms.TabPage()
        Me.cbFFVideoInterlace = New System.Windows.Forms.CheckBox()
        Me.edFFVideoBitrateMax = New System.Windows.Forms.TextBox()
        Me.label218 = New System.Windows.Forms.Label()
        Me.edFFVBVBufferSize = New System.Windows.Forms.TextBox()
        Me.label224 = New System.Windows.Forms.Label()
        Me.label225 = New System.Windows.Forms.Label()
        Me.edFFVideoBitrateMin = New System.Windows.Forms.TextBox()
        Me.label226 = New System.Windows.Forms.Label()
        Me.label227 = New System.Windows.Forms.Label()
        Me.edFFTargetBitrate = New System.Windows.Forms.TextBox()
        Me.label228 = New System.Windows.Forms.Label()
        Me.cbFFConstaint = New System.Windows.Forms.ComboBox()
        Me.label255 = New System.Windows.Forms.Label()
        Me.cbFFAspectRatio = New System.Windows.Forms.ComboBox()
        Me.label257 = New System.Windows.Forms.Label()
        Me.edFFVideoHeight = New System.Windows.Forms.TextBox()
        Me.label258 = New System.Windows.Forms.Label()
        Me.edFFVideoWidth = New System.Windows.Forms.TextBox()
        Me.label259 = New System.Windows.Forms.Label()
        Me.tabPage65 = New System.Windows.Forms.TabPage()
        Me.label261 = New System.Windows.Forms.Label()
        Me.label262 = New System.Windows.Forms.Label()
        Me.cbFFAudioBitrate = New System.Windows.Forms.ComboBox()
        Me.label263 = New System.Windows.Forms.Label()
        Me.cbFFAudioChannels = New System.Windows.Forms.ComboBox()
        Me.label264 = New System.Windows.Forms.Label()
        Me.cbFFAudioSampleRate = New System.Windows.Forms.ComboBox()
        Me.label265 = New System.Windows.Forms.Label()
        Me.cbFFOutputFormat = New System.Windows.Forms.ComboBox()
        Me.label267 = New System.Windows.Forms.Label()
        Me.TabPage66 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tabControl29 = New System.Windows.Forms.TabControl()
        Me.tabPage129 = New System.Windows.Forms.TabPage()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.tabPage132 = New System.Windows.Forms.TabPage()
        Me.label468 = New System.Windows.Forms.Label()
        Me.cbFFEXEOutputFormat = New System.Windows.Forms.ComboBox()
        Me.tabPage130 = New System.Windows.Forms.TabPage()
        Me.tabControl30 = New System.Windows.Forms.TabControl()
        Me.tabPage134 = New System.Windows.Forms.TabPage()
        Me.cbFFEXEVideoConstraint = New System.Windows.Forms.ComboBox()
        Me.label482 = New System.Windows.Forms.Label()
        Me.lbFFEXEVideoNotes = New System.Windows.Forms.Label()
        Me.cbFFEXEVideoResolutionLetterbox = New System.Windows.Forms.CheckBox()
        Me.label469 = New System.Windows.Forms.Label()
        Me.cbFFEXEVideoCodec = New System.Windows.Forms.ComboBox()
        Me.cbFFEXEVideoResolutionOriginal = New System.Windows.Forms.CheckBox()
        Me.cbFFEXEAspectRatio = New System.Windows.Forms.ComboBox()
        Me.label459 = New System.Windows.Forms.Label()
        Me.edFFEXEVideoHeight = New System.Windows.Forms.TextBox()
        Me.label460 = New System.Windows.Forms.Label()
        Me.edFFEXEVideoWidth = New System.Windows.Forms.TextBox()
        Me.label461 = New System.Windows.Forms.Label()
        Me.tabPage137 = New System.Windows.Forms.TabPage()
        Me.lbFFEXEVideoQuality = New System.Windows.Forms.Label()
        Me.tbFFEXEVideoQuality = New System.Windows.Forms.TrackBar()
        Me.label481 = New System.Windows.Forms.Label()
        Me.rbFFEXEVideoModeQuality = New System.Windows.Forms.RadioButton()
        Me.rbFFEXEVideoModeABR = New System.Windows.Forms.RadioButton()
        Me.rbFFEXEVideoModeCBR = New System.Windows.Forms.RadioButton()
        Me.edFFEXEVideoBitrateMax = New System.Windows.Forms.TextBox()
        Me.label452 = New System.Windows.Forms.Label()
        Me.label454 = New System.Windows.Forms.Label()
        Me.edFFEXEVideoBitrateMin = New System.Windows.Forms.TextBox()
        Me.label455 = New System.Windows.Forms.Label()
        Me.label456 = New System.Windows.Forms.Label()
        Me.edFFEXEVideoTargetBitrate = New System.Windows.Forms.TextBox()
        Me.label457 = New System.Windows.Forms.Label()
        Me.tabPage136 = New System.Windows.Forms.TabPage()
        Me.edFFEXEVideoBFramesCount = New System.Windows.Forms.TextBox()
        Me.label479 = New System.Windows.Forms.Label()
        Me.edFFEXEVideoGOPSize = New System.Windows.Forms.TextBox()
        Me.label478 = New System.Windows.Forms.Label()
        Me.cbFFEXEVideoInterlace = New System.Windows.Forms.CheckBox()
        Me.edFFEXEVBVBufferSize = New System.Windows.Forms.TextBox()
        Me.label453 = New System.Windows.Forms.Label()
        Me.tabPage135 = New System.Windows.Forms.TabPage()
        Me.label483 = New System.Windows.Forms.Label()
        Me.cbFFEXEH264WebFastStart = New System.Windows.Forms.CheckBox()
        Me.cbFFEXEH264ZeroTolerance = New System.Windows.Forms.CheckBox()
        Me.cbFFEXEH264QuickTimeCompatibility = New System.Windows.Forms.CheckBox()
        Me.cbFFEXEH264Level = New System.Windows.Forms.ComboBox()
        Me.label475 = New System.Windows.Forms.Label()
        Me.cbFFEXEH264Profile = New System.Windows.Forms.ComboBox()
        Me.label474 = New System.Windows.Forms.Label()
        Me.cbFFEXEH264Preset = New System.Windows.Forms.ComboBox()
        Me.label473 = New System.Windows.Forms.Label()
        Me.cbFFEXEH264Mode = New System.Windows.Forms.ComboBox()
        Me.label472 = New System.Windows.Forms.Label()
        Me.lbFFEXEH264Quantizer = New System.Windows.Forms.Label()
        Me.tbFFEXEH264Quantizer = New System.Windows.Forms.TrackBar()
        Me.label458 = New System.Windows.Forms.Label()
        Me.tabPage131 = New System.Windows.Forms.TabPage()
        Me.lbFFEXEAudioNotes = New System.Windows.Forms.Label()
        Me.rbFFEXEAudioModeLossless = New System.Windows.Forms.RadioButton()
        Me.rbFFEXEAudioModeQuality = New System.Windows.Forms.RadioButton()
        Me.rbFFEXEAudioModeABR = New System.Windows.Forms.RadioButton()
        Me.rbFFEXEAudioModeCBR = New System.Windows.Forms.RadioButton()
        Me.lbFFEXEAudioQuality = New System.Windows.Forms.Label()
        Me.tbFFEXEAudioQuality = New System.Windows.Forms.TrackBar()
        Me.label477 = New System.Windows.Forms.Label()
        Me.label470 = New System.Windows.Forms.Label()
        Me.cbFFEXEAudioCodec = New System.Windows.Forms.ComboBox()
        Me.label462 = New System.Windows.Forms.Label()
        Me.label463 = New System.Windows.Forms.Label()
        Me.cbFFEXEAudioBitrate = New System.Windows.Forms.ComboBox()
        Me.label464 = New System.Windows.Forms.Label()
        Me.cbFFEXEAudioChannels = New System.Windows.Forms.ComboBox()
        Me.label465 = New System.Windows.Forms.Label()
        Me.cbFFEXEAudioSampleRate = New System.Windows.Forms.ComboBox()
        Me.label466 = New System.Windows.Forms.Label()
        Me.tabPage133 = New System.Windows.Forms.TabPage()
        Me.edFFEXECustomParametersCommon = New System.Windows.Forms.TextBox()
        Me.label480 = New System.Windows.Forms.Label()
        Me.edFFEXECustomParametersAudio = New System.Windows.Forms.TextBox()
        Me.label476 = New System.Windows.Forms.Label()
        Me.cbFFEXEUseAviSynthProxy = New System.Windows.Forms.CheckBox()
        Me.cbFFEXEUseOnlyAdditionalParameters = New System.Windows.Forms.CheckBox()
        Me.edFFEXECustomParametersVideo = New System.Windows.Forms.TextBox()
        Me.label471 = New System.Windows.Forms.Label()
        Me.cbFFEXEProfile = New System.Windows.Forms.ComboBox()
        Me.label467 = New System.Windows.Forms.Label()
        Me.TabPage46 = New System.Windows.Forms.TabPage()
        Me.tabControl24 = New System.Windows.Forms.TabControl()
        Me.TabPage50 = New System.Windows.Forms.TabPage()
        Me.rbMP4NVENC = New System.Windows.Forms.RadioButton()
        Me.linkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.Label500 = New System.Windows.Forms.Label()
        Me.Label501 = New System.Windows.Forms.Label()
        Me.rbMP4Modern = New System.Windows.Forms.RadioButton()
        Me.rbMP4Legacy = New System.Windows.Forms.RadioButton()
        Me.label380 = New System.Windows.Forms.Label()
        Me.label379 = New System.Windows.Forms.Label()
        Me.label378 = New System.Windows.Forms.Label()
        Me.label377 = New System.Windows.Forms.Label()
        Me.tabPage89 = New System.Windows.Forms.TabPage()
        Me.groupBox18 = New System.Windows.Forms.GroupBox()
        Me.cbH264PictureType = New System.Windows.Forms.ComboBox()
        Me.label360 = New System.Windows.Forms.Label()
        Me.label347 = New System.Windows.Forms.Label()
        Me.edH264P = New System.Windows.Forms.TextBox()
        Me.label348 = New System.Windows.Forms.Label()
        Me.edH264IDR = New System.Windows.Forms.TextBox()
        Me.label349 = New System.Windows.Forms.Label()
        Me.cbH264MBEncoding = New System.Windows.Forms.ComboBox()
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
        Me.TabPage22 = New System.Windows.Forms.TabPage()
        Me.groupBox14 = New System.Windows.Forms.GroupBox()
        Me.label506 = New System.Windows.Forms.Label()
        Me.edNVENCBFrames = New System.Windows.Forms.TextBox()
        Me.label507 = New System.Windows.Forms.Label()
        Me.edNVENCGOP = New System.Windows.Forms.TextBox()
        Me.groupBox49 = New System.Windows.Forms.GroupBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.edNVENCQP = New System.Windows.Forms.TextBox()
        Me.label508 = New System.Windows.Forms.Label()
        Me.edNVENCBitrate = New System.Windows.Forms.TextBox()
        Me.label509 = New System.Windows.Forms.Label()
        Me.cbNVENCRateControl = New System.Windows.Forms.ComboBox()
        Me.groupBox50 = New System.Windows.Forms.GroupBox()
        Me.label511 = New System.Windows.Forms.Label()
        Me.label512 = New System.Windows.Forms.Label()
        Me.cbNVENCLevel = New System.Windows.Forms.ComboBox()
        Me.cbNVENCProfile = New System.Windows.Forms.ComboBox()
        Me.tabPage90 = New System.Windows.Forms.TabPage()
        Me.label354 = New System.Windows.Forms.Label()
        Me.cbAACOutput = New System.Windows.Forms.ComboBox()
        Me.label355 = New System.Windows.Forms.Label()
        Me.cbAACBitrate = New System.Windows.Forms.ComboBox()
        Me.label356 = New System.Windows.Forms.Label()
        Me.cbAACObjectType = New System.Windows.Forms.ComboBox()
        Me.label357 = New System.Windows.Forms.Label()
        Me.cbAACVersion = New System.Windows.Forms.ComboBox()
        Me.label358 = New System.Windows.Forms.Label()
        Me.TabPage51 = New System.Windows.Forms.TabPage()
        Me.cbFLACExhaustiveModelSearch = New System.Windows.Forms.CheckBox()
        Me.cbFLACAdaptiveMidSideCoding = New System.Windows.Forms.CheckBox()
        Me.cbFLACMidSideCoding = New System.Windows.Forms.CheckBox()
        Me.edFLACRiceMax = New System.Windows.Forms.TextBox()
        Me.label401 = New System.Windows.Forms.Label()
        Me.edFLACRiceMin = New System.Windows.Forms.TextBox()
        Me.label400 = New System.Windows.Forms.Label()
        Me.label399 = New System.Windows.Forms.Label()
        Me.tbFLACLPCOrder = New System.Windows.Forms.TrackBar()
        Me.cbFLACBlockSize = New System.Windows.Forms.ComboBox()
        Me.label398 = New System.Windows.Forms.Label()
        Me.label397 = New System.Windows.Forms.Label()
        Me.label396 = New System.Windows.Forms.Label()
        Me.label395 = New System.Windows.Forms.Label()
        Me.tbFLACLevel = New System.Windows.Forms.TrackBar()
        Me.TabPage55 = New System.Windows.Forms.TabPage()
        Me.cbSpeexDenoise = New System.Windows.Forms.CheckBox()
        Me.cbSpeexAGC = New System.Windows.Forms.CheckBox()
        Me.cbSpeexVAD = New System.Windows.Forms.CheckBox()
        Me.cbSpeexDTX = New System.Windows.Forms.CheckBox()
        Me.tbSpeexComplexity = New System.Windows.Forms.TrackBar()
        Me.label54 = New System.Windows.Forms.Label()
        Me.tbSpeexMaxBitrate = New System.Windows.Forms.TrackBar()
        Me.label53 = New System.Windows.Forms.Label()
        Me.tbSpeexBitrate = New System.Windows.Forms.TrackBar()
        Me.label52 = New System.Windows.Forms.Label()
        Me.tbSpeexQuality = New System.Windows.Forms.TrackBar()
        Me.label51 = New System.Windows.Forms.Label()
        Me.cbSpeexBitrateControl = New System.Windows.Forms.ComboBox()
        Me.label49 = New System.Windows.Forms.Label()
        Me.cbSpeexMode = New System.Windows.Forms.ComboBox()
        Me.label33 = New System.Windows.Forms.Label()
        Me.TabPage77 = New System.Windows.Forms.TabPage()
        Me.TabControl31 = New System.Windows.Forms.TabControl()
        Me.tabPage140 = New System.Windows.Forms.TabPage()
        Me.label485 = New System.Windows.Forms.Label()
        Me.cbM4AOutput = New System.Windows.Forms.ComboBox()
        Me.label486 = New System.Windows.Forms.Label()
        Me.cbM4ABitrate = New System.Windows.Forms.ComboBox()
        Me.label487 = New System.Windows.Forms.Label()
        Me.cbM4AObjectType = New System.Windows.Forms.ComboBox()
        Me.label488 = New System.Windows.Forms.Label()
        Me.cbM4AVersion = New System.Windows.Forms.ComboBox()
        Me.label489 = New System.Windows.Forms.Label()
        Me.tabPage141 = New System.Windows.Forms.TabPage()
        Me.TabPage79 = New System.Windows.Forms.TabPage()
        Me.label504 = New System.Windows.Forms.Label()
        Me.edGIFHeight = New System.Windows.Forms.TextBox()
        Me.edGIFWidth = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.edGIFFrameRate = New System.Windows.Forms.TextBox()
        Me.label251 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tabPage31 = New System.Windows.Forms.TabPage()
        Me.tabControl17 = New System.Windows.Forms.TabControl()
        Me.tabPage68 = New System.Windows.Forms.TabPage()
        Me.label201 = New System.Windows.Forms.Label()
        Me.label200 = New System.Windows.Forms.Label()
        Me.label199 = New System.Windows.Forms.Label()
        Me.label198 = New System.Windows.Forms.Label()
        Me.tabControl7 = New System.Windows.Forms.TabControl()
        Me.tabPage29 = New System.Windows.Forms.TabPage()
        Me.cbTextLogoDateTime = New System.Windows.Forms.CheckBox()
        Me.btTextLogoUpdateParams = New System.Windows.Forms.Button()
        Me.tabControl8 = New System.Windows.Forms.TabControl()
        Me.tabPage35 = New System.Windows.Forms.TabPage()
        Me.label39 = New System.Windows.Forms.Label()
        Me.pnTextLogoBGColor = New System.Windows.Forms.Panel()
        Me.label40 = New System.Windows.Forms.Label()
        Me.cbTextLogoTranspBG = New System.Windows.Forms.CheckBox()
        Me.cbTextLogoRightToLeft = New System.Windows.Forms.CheckBox()
        Me.cbTextLogoVertical = New System.Windows.Forms.CheckBox()
        Me.cbTextLogoAlign = New System.Windows.Forms.ComboBox()
        Me.label41 = New System.Windows.Forms.Label()
        Me.tbTextLogoTransp = New System.Windows.Forms.TrackBar()
        Me.tabPage36 = New System.Windows.Forms.TabPage()
        Me.cbTextLogoGradMode = New System.Windows.Forms.ComboBox()
        Me.label107 = New System.Windows.Forms.Label()
        Me.pnTextLogoGradColor2 = New System.Windows.Forms.Panel()
        Me.label135 = New System.Windows.Forms.Label()
        Me.pnTextLogoGradColor1 = New System.Windows.Forms.Panel()
        Me.label136 = New System.Windows.Forms.Label()
        Me.cbTextLogoGradientEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage37 = New System.Windows.Forms.TabPage()
        Me.edTextLogoHeight = New System.Windows.Forms.TextBox()
        Me.label137 = New System.Windows.Forms.Label()
        Me.edTextLogoWidth = New System.Windows.Forms.TextBox()
        Me.label138 = New System.Windows.Forms.Label()
        Me.cbTextLogoUseRect = New System.Windows.Forms.CheckBox()
        Me.edTextLogoTop = New System.Windows.Forms.TextBox()
        Me.label139 = New System.Windows.Forms.Label()
        Me.edTextLogoLeft = New System.Windows.Forms.TextBox()
        Me.label140 = New System.Windows.Forms.Label()
        Me.tabPage38 = New System.Windows.Forms.TabPage()
        Me.cbTextLogoDrawMode = New System.Windows.Forms.ComboBox()
        Me.cbTextLogoAntialiasing = New System.Windows.Forms.ComboBox()
        Me.label141 = New System.Windows.Forms.Label()
        Me.label142 = New System.Windows.Forms.Label()
        Me.tabPage39 = New System.Windows.Forms.TabPage()
        Me.edTextLogoOuterSize = New System.Windows.Forms.TextBox()
        Me.label143 = New System.Windows.Forms.Label()
        Me.edTextLogoInnerSize = New System.Windows.Forms.TextBox()
        Me.label144 = New System.Windows.Forms.Label()
        Me.pnTextLogoOuterColor = New System.Windows.Forms.Panel()
        Me.label145 = New System.Windows.Forms.Label()
        Me.pnTextLogoInnerColor = New System.Windows.Forms.Panel()
        Me.label146 = New System.Windows.Forms.Label()
        Me.cbTextLogoEffectrMode = New System.Windows.Forms.ComboBox()
        Me.label147 = New System.Windows.Forms.Label()
        Me.tabPage40 = New System.Windows.Forms.TabPage()
        Me.groupBox16 = New System.Windows.Forms.GroupBox()
        Me.rbTextLogoFlipXY = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoFlipY = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoFlipX = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoFlipNone = New System.Windows.Forms.RadioButton()
        Me.groupBox17 = New System.Windows.Forms.GroupBox()
        Me.rbTextLogoDegree270 = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoDegree180 = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoDegree90 = New System.Windows.Forms.RadioButton()
        Me.rbTextLogoDegree0 = New System.Windows.Forms.RadioButton()
        Me.tabPage41 = New System.Windows.Forms.TabPage()
        Me.edTextLogoShapeHeight = New System.Windows.Forms.TextBox()
        Me.label148 = New System.Windows.Forms.Label()
        Me.edTextLogoShapeWidth = New System.Windows.Forms.TextBox()
        Me.label149 = New System.Windows.Forms.Label()
        Me.edTextLogoShapeTop = New System.Windows.Forms.TextBox()
        Me.label150 = New System.Windows.Forms.Label()
        Me.edTextLogoShapeLeft = New System.Windows.Forms.TextBox()
        Me.label151 = New System.Windows.Forms.Label()
        Me.cbTextLogoShapeType = New System.Windows.Forms.ComboBox()
        Me.label152 = New System.Windows.Forms.Label()
        Me.pnTextLogoShapeColor = New System.Windows.Forms.Panel()
        Me.label153 = New System.Windows.Forms.Label()
        Me.cbTextLogoShapeEnabled = New System.Windows.Forms.CheckBox()
        Me.btFont = New System.Windows.Forms.Button()
        Me.edTextLogo = New System.Windows.Forms.TextBox()
        Me.cbTextLogo = New System.Windows.Forms.CheckBox()
        Me.tabPage42 = New System.Windows.Forms.TabPage()
        Me.pnImageLogoColorKey = New System.Windows.Forms.Panel()
        Me.cbImageLogoUseColorKey = New System.Windows.Forms.CheckBox()
        Me.label154 = New System.Windows.Forms.Label()
        Me.tbImageLogoTransp = New System.Windows.Forms.TrackBar()
        Me.groupBox22 = New System.Windows.Forms.GroupBox()
        Me.cbImageLogoShowAlways = New System.Windows.Forms.CheckBox()
        Me.edImageLogoStopTime = New System.Windows.Forms.TextBox()
        Me.lbGraphicLogoStopTime = New System.Windows.Forms.Label()
        Me.edImageLogoStartTime = New System.Windows.Forms.TextBox()
        Me.lbGraphicLogoStartTime = New System.Windows.Forms.Label()
        Me.groupBox23 = New System.Windows.Forms.GroupBox()
        Me.edImageLogoTop = New System.Windows.Forms.TextBox()
        Me.label155 = New System.Windows.Forms.Label()
        Me.edImageLogoLeft = New System.Windows.Forms.TextBox()
        Me.label156 = New System.Windows.Forms.Label()
        Me.btSelectImage = New System.Windows.Forms.Button()
        Me.label157 = New System.Windows.Forms.Label()
        Me.edImageLogoFilename = New System.Windows.Forms.TextBox()
        Me.cbImageLogo = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.groupBox37 = New System.Windows.Forms.GroupBox()
        Me.btEffZoomRight = New System.Windows.Forms.Button()
        Me.btEffZoomLeft = New System.Windows.Forms.Button()
        Me.btEffZoomOut = New System.Windows.Forms.Button()
        Me.btEffZoomIn = New System.Windows.Forms.Button()
        Me.btEffZoomDown = New System.Windows.Forms.Button()
        Me.btEffZoomUp = New System.Windows.Forms.Button()
        Me.cbZoom = New System.Windows.Forms.CheckBox()
        Me.TabPage16 = New System.Windows.Forms.TabPage()
        Me.groupBox40 = New System.Windows.Forms.GroupBox()
        Me.edPanDestHeight = New System.Windows.Forms.TextBox()
        Me.label302 = New System.Windows.Forms.Label()
        Me.edPanDestWidth = New System.Windows.Forms.TextBox()
        Me.label303 = New System.Windows.Forms.Label()
        Me.edPanDestTop = New System.Windows.Forms.TextBox()
        Me.label304 = New System.Windows.Forms.Label()
        Me.edPanDestLeft = New System.Windows.Forms.TextBox()
        Me.label305 = New System.Windows.Forms.Label()
        Me.groupBox39 = New System.Windows.Forms.GroupBox()
        Me.edPanSourceHeight = New System.Windows.Forms.TextBox()
        Me.label298 = New System.Windows.Forms.Label()
        Me.edPanSourceWidth = New System.Windows.Forms.TextBox()
        Me.label299 = New System.Windows.Forms.Label()
        Me.edPanSourceTop = New System.Windows.Forms.TextBox()
        Me.label300 = New System.Windows.Forms.Label()
        Me.edPanSourceLeft = New System.Windows.Forms.TextBox()
        Me.label301 = New System.Windows.Forms.Label()
        Me.groupBox38 = New System.Windows.Forms.GroupBox()
        Me.edPanStopTime = New System.Windows.Forms.TextBox()
        Me.label296 = New System.Windows.Forms.Label()
        Me.edPanStartTime = New System.Windows.Forms.TextBox()
        Me.label297 = New System.Windows.Forms.Label()
        Me.cbPan = New System.Windows.Forms.CheckBox()
        Me.TabPage33 = New System.Windows.Forms.TabPage()
        Me.rbFadeOut = New System.Windows.Forms.RadioButton()
        Me.rbFadeIn = New System.Windows.Forms.RadioButton()
        Me.groupBox45 = New System.Windows.Forms.GroupBox()
        Me.edFadeInOutStopTime = New System.Windows.Forms.TextBox()
        Me.label329 = New System.Windows.Forms.Label()
        Me.edFadeInOutStartTime = New System.Windows.Forms.TextBox()
        Me.label330 = New System.Windows.Forms.Label()
        Me.cbFadeInOut = New System.Windows.Forms.CheckBox()
        Me.tbContrast = New System.Windows.Forms.TrackBar()
        Me.tbDarkness = New System.Windows.Forms.TrackBar()
        Me.tbLightness = New System.Windows.Forms.TrackBar()
        Me.tbSaturation = New System.Windows.Forms.TrackBar()
        Me.cbInvert = New System.Windows.Forms.CheckBox()
        Me.cbGreyscale = New System.Windows.Forms.CheckBox()
        Me.cbEffects = New System.Windows.Forms.CheckBox()
        Me.tabPage69 = New System.Windows.Forms.TabPage()
        Me.label211 = New System.Windows.Forms.Label()
        Me.edDeintTriangleWeight = New System.Windows.Forms.TextBox()
        Me.label212 = New System.Windows.Forms.Label()
        Me.label210 = New System.Windows.Forms.Label()
        Me.label209 = New System.Windows.Forms.Label()
        Me.label206 = New System.Windows.Forms.Label()
        Me.edDeintBlendConstants2 = New System.Windows.Forms.TextBox()
        Me.label207 = New System.Windows.Forms.Label()
        Me.edDeintBlendConstants1 = New System.Windows.Forms.TextBox()
        Me.label208 = New System.Windows.Forms.Label()
        Me.label204 = New System.Windows.Forms.Label()
        Me.edDeintBlendThreshold2 = New System.Windows.Forms.TextBox()
        Me.label205 = New System.Windows.Forms.Label()
        Me.edDeintBlendThreshold1 = New System.Windows.Forms.TextBox()
        Me.label203 = New System.Windows.Forms.Label()
        Me.label202 = New System.Windows.Forms.Label()
        Me.edDeintCAVTThreshold = New System.Windows.Forms.TextBox()
        Me.label104 = New System.Windows.Forms.Label()
        Me.rbDeintTriangleEnabled = New System.Windows.Forms.RadioButton()
        Me.rbDeintBlendEnabled = New System.Windows.Forms.RadioButton()
        Me.rbDeintCAVTEnabled = New System.Windows.Forms.RadioButton()
        Me.cbDeinterlace = New System.Windows.Forms.CheckBox()
        Me.tabPage59 = New System.Windows.Forms.TabPage()
        Me.rbDenoiseCAST = New System.Windows.Forms.RadioButton()
        Me.rbDenoiseMosquito = New System.Windows.Forms.RadioButton()
        Me.cbDenoise = New System.Windows.Forms.CheckBox()
        Me.TabPage82 = New System.Windows.Forms.TabPage()
        Me.cbGPUOldMovie = New System.Windows.Forms.CheckBox()
        Me.cbGPUBlur = New System.Windows.Forms.CheckBox()
        Me.cbGPUDeinterlace = New System.Windows.Forms.CheckBox()
        Me.cbGPUDenoise = New System.Windows.Forms.CheckBox()
        Me.cbGPUPixelate = New System.Windows.Forms.CheckBox()
        Me.cbGPUNightVision = New System.Windows.Forms.CheckBox()
        Me.label383 = New System.Windows.Forms.Label()
        Me.label384 = New System.Windows.Forms.Label()
        Me.label385 = New System.Windows.Forms.Label()
        Me.label386 = New System.Windows.Forms.Label()
        Me.tbGPUContrast = New System.Windows.Forms.TrackBar()
        Me.tbGPUDarkness = New System.Windows.Forms.TrackBar()
        Me.tbGPULightness = New System.Windows.Forms.TrackBar()
        Me.tbGPUSaturation = New System.Windows.Forms.TrackBar()
        Me.cbGPUInvert = New System.Windows.Forms.CheckBox()
        Me.cbGPUGreyscale = New System.Windows.Forms.CheckBox()
        Me.TabPage20 = New System.Windows.Forms.TabPage()
        Me.tabControl15 = New System.Windows.Forms.TabControl()
        Me.TabPage26 = New System.Windows.Forms.TabPage()
        Me.label64 = New System.Windows.Forms.Label()
        Me.label65 = New System.Windows.Forms.Label()
        Me.pbAFMotionLevel = New System.Windows.Forms.ProgressBar()
        Me.cbAFMotionHighlight = New System.Windows.Forms.CheckBox()
        Me.cbAFMotionDetection = New System.Windows.Forms.CheckBox()
        Me.TabPage27 = New System.Windows.Forms.TabPage()
        Me.label171 = New System.Windows.Forms.Label()
        Me.label66 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.TabPage21 = New System.Windows.Forms.TabPage()
        Me.btChromaKeySelectBGImage = New System.Windows.Forms.Button()
        Me.edChromaKeyImage = New System.Windows.Forms.TextBox()
        Me.label216 = New System.Windows.Forms.Label()
        Me.rbChromaKeyRed = New System.Windows.Forms.RadioButton()
        Me.rbChromaKeyBlue = New System.Windows.Forms.RadioButton()
        Me.rbChromaKeyGreen = New System.Windows.Forms.RadioButton()
        Me.label215 = New System.Windows.Forms.Label()
        Me.tbChromaKeyContrastHigh = New System.Windows.Forms.TrackBar()
        Me.label214 = New System.Windows.Forms.Label()
        Me.tbChromaKeyContrastLow = New System.Windows.Forms.TrackBar()
        Me.label213 = New System.Windows.Forms.Label()
        Me.cbChromaKeyEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage70 = New System.Windows.Forms.TabPage()
        Me.btFilterDeleteAll = New System.Windows.Forms.Button()
        Me.btFilterSettings2 = New System.Windows.Forms.Button()
        Me.lbFilters = New System.Windows.Forms.ListBox()
        Me.label106 = New System.Windows.Forms.Label()
        Me.btFilterSettings = New System.Windows.Forms.Button()
        Me.btFilterAdd = New System.Windows.Forms.Button()
        Me.cbFilters = New System.Windows.Forms.ComboBox()
        Me.label105 = New System.Windows.Forms.Label()
        Me.TabPage81 = New System.Windows.Forms.TabPage()
        Me.label177 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btSubtitlesSelectFile = New System.Windows.Forms.Button()
        Me.edSubtitlesFilename = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.cbSubtitlesEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage9 = New System.Windows.Forms.TabPage()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.label47 = New System.Windows.Forms.Label()
        Me.edTransStopTime = New System.Windows.Forms.TextBox()
        Me.label48 = New System.Windows.Forms.Label()
        Me.label46 = New System.Windows.Forms.Label()
        Me.edTransStartTime = New System.Windows.Forms.TextBox()
        Me.label45 = New System.Windows.Forms.Label()
        Me.btAddTransition = New System.Windows.Forms.Button()
        Me.cbTransitionName = New System.Windows.Forms.ComboBox()
        Me.label44 = New System.Windows.Forms.Label()
        Me.lbTransitions = New System.Windows.Forms.ListBox()
        Me.label43 = New System.Windows.Forms.Label()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tabControl18 = New System.Windows.Forms.TabControl()
        Me.tabPage71 = New System.Windows.Forms.TabPage()
        Me.label231 = New System.Windows.Forms.Label()
        Me.label230 = New System.Windows.Forms.Label()
        Me.tbAudAmplifyAmp = New System.Windows.Forms.TrackBar()
        Me.label95 = New System.Windows.Forms.Label()
        Me.cbAudAmplifyEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage72 = New System.Windows.Forms.TabPage()
        Me.btAudEqRefresh = New System.Windows.Forms.Button()
        Me.cbAudEqualizerPreset = New System.Windows.Forms.ComboBox()
        Me.label243 = New System.Windows.Forms.Label()
        Me.label242 = New System.Windows.Forms.Label()
        Me.label241 = New System.Windows.Forms.Label()
        Me.label240 = New System.Windows.Forms.Label()
        Me.label239 = New System.Windows.Forms.Label()
        Me.label238 = New System.Windows.Forms.Label()
        Me.label237 = New System.Windows.Forms.Label()
        Me.label236 = New System.Windows.Forms.Label()
        Me.label235 = New System.Windows.Forms.Label()
        Me.label234 = New System.Windows.Forms.Label()
        Me.label233 = New System.Windows.Forms.Label()
        Me.label232 = New System.Windows.Forms.Label()
        Me.tbAudEq9 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq8 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq7 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq6 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq5 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq4 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq3 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq2 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq1 = New System.Windows.Forms.TrackBar()
        Me.tbAudEq0 = New System.Windows.Forms.TrackBar()
        Me.cbAudEqualizerEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage73 = New System.Windows.Forms.TabPage()
        Me.tbAudRelease = New System.Windows.Forms.TrackBar()
        Me.label248 = New System.Windows.Forms.Label()
        Me.label249 = New System.Windows.Forms.Label()
        Me.label246 = New System.Windows.Forms.Label()
        Me.tbAudAttack = New System.Windows.Forms.TrackBar()
        Me.label247 = New System.Windows.Forms.Label()
        Me.label244 = New System.Windows.Forms.Label()
        Me.tbAudDynAmp = New System.Windows.Forms.TrackBar()
        Me.label245 = New System.Windows.Forms.Label()
        Me.cbAudDynamicAmplifyEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage75 = New System.Windows.Forms.TabPage()
        Me.tbAud3DSound = New System.Windows.Forms.TrackBar()
        Me.label253 = New System.Windows.Forms.Label()
        Me.cbAudSound3DEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage76 = New System.Windows.Forms.TabPage()
        Me.tbAudTrueBass = New System.Windows.Forms.TrackBar()
        Me.label254 = New System.Windows.Forms.Label()
        Me.cbAudTrueBassEnabled = New System.Windows.Forms.CheckBox()
        Me.cbAudioEffectsEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage57 = New System.Windows.Forms.TabPage()
        Me.lbAudioTimeshift = New System.Windows.Forms.Label()
        Me.tbAudioTimeshift = New System.Windows.Forms.TrackBar()
        Me.label115 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAudioOutputGainLFE = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainLFE = New System.Windows.Forms.TrackBar()
        Me.label116 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainSR = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainSR = New System.Windows.Forms.TrackBar()
        Me.label117 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainSL = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainSL = New System.Windows.Forms.TrackBar()
        Me.label118 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainR = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainR = New System.Windows.Forms.TrackBar()
        Me.label119 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainC = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainC = New System.Windows.Forms.TrackBar()
        Me.label121 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainL = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainL = New System.Windows.Forms.TrackBar()
        Me.label122 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbAudioInputGainLFE = New System.Windows.Forms.Label()
        Me.tbAudioInputGainLFE = New System.Windows.Forms.TrackBar()
        Me.label123 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainSR = New System.Windows.Forms.Label()
        Me.tbAudioInputGainSR = New System.Windows.Forms.TrackBar()
        Me.label124 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainSL = New System.Windows.Forms.Label()
        Me.tbAudioInputGainSL = New System.Windows.Forms.TrackBar()
        Me.label125 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainR = New System.Windows.Forms.Label()
        Me.tbAudioInputGainR = New System.Windows.Forms.TrackBar()
        Me.label126 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainC = New System.Windows.Forms.Label()
        Me.tbAudioInputGainC = New System.Windows.Forms.TrackBar()
        Me.label127 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainL = New System.Windows.Forms.Label()
        Me.tbAudioInputGainL = New System.Windows.Forms.TrackBar()
        Me.label128 = New System.Windows.Forms.Label()
        Me.cbAudioAutoGain = New System.Windows.Forms.CheckBox()
        Me.cbAudioNormalize = New System.Windows.Forms.CheckBox()
        Me.cbAudioEnhancementEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage80 = New System.Windows.Forms.TabPage()
        Me.btAudioChannelMapperClear = New System.Windows.Forms.Button()
        Me.groupBox41 = New System.Windows.Forms.GroupBox()
        Me.btAudioChannelMapperAddNewRoute = New System.Windows.Forms.Button()
        Me.label311 = New System.Windows.Forms.Label()
        Me.tbAudioChannelMapperVolume = New System.Windows.Forms.TrackBar()
        Me.label310 = New System.Windows.Forms.Label()
        Me.edAudioChannelMapperTargetChannel = New System.Windows.Forms.TextBox()
        Me.label309 = New System.Windows.Forms.Label()
        Me.edAudioChannelMapperSourceChannel = New System.Windows.Forms.TextBox()
        Me.label308 = New System.Windows.Forms.Label()
        Me.label307 = New System.Windows.Forms.Label()
        Me.edAudioChannelMapperOutputChannels = New System.Windows.Forms.TextBox()
        Me.label306 = New System.Windows.Forms.Label()
        Me.lbAudioChannelMapperRoutes = New System.Windows.Forms.ListBox()
        Me.cbAudioChannelMapperEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage28 = New System.Windows.Forms.TabPage()
        Me.tabControl9 = New System.Windows.Forms.TabControl()
        Me.tabPage44 = New System.Windows.Forms.TabPage()
        Me.pbMotionLevel = New System.Windows.Forms.ProgressBar()
        Me.label158 = New System.Windows.Forms.Label()
        Me.mmMotDetMatrix = New System.Windows.Forms.TextBox()
        Me.tabPage45 = New System.Windows.Forms.TabPage()
        Me.groupBox25 = New System.Windows.Forms.GroupBox()
        Me.cbMotDetHLColor = New System.Windows.Forms.ComboBox()
        Me.label161 = New System.Windows.Forms.Label()
        Me.label160 = New System.Windows.Forms.Label()
        Me.cbMotDetHLEnabled = New System.Windows.Forms.CheckBox()
        Me.tbMotDetHLThreshold = New System.Windows.Forms.TrackBar()
        Me.btMotDetUpdateSettings = New System.Windows.Forms.Button()
        Me.groupBox27 = New System.Windows.Forms.GroupBox()
        Me.edMotDetMatrixHeight = New System.Windows.Forms.TextBox()
        Me.label163 = New System.Windows.Forms.Label()
        Me.edMotDetMatrixWidth = New System.Windows.Forms.TextBox()
        Me.label164 = New System.Windows.Forms.Label()
        Me.groupBox26 = New System.Windows.Forms.GroupBox()
        Me.label162 = New System.Windows.Forms.Label()
        Me.tbMotDetDropFramesThreshold = New System.Windows.Forms.TrackBar()
        Me.cbMotDetDropFramesEnabled = New System.Windows.Forms.CheckBox()
        Me.groupBox24 = New System.Windows.Forms.GroupBox()
        Me.edMotDetFrameInterval = New System.Windows.Forms.TextBox()
        Me.label159 = New System.Windows.Forms.Label()
        Me.cbCompareGreyscale = New System.Windows.Forms.CheckBox()
        Me.cbCompareBlue = New System.Windows.Forms.CheckBox()
        Me.cbCompareGreen = New System.Windows.Forms.CheckBox()
        Me.cbCompareRed = New System.Windows.Forms.CheckBox()
        Me.cbMotDetEnabled = New System.Windows.Forms.CheckBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.label393 = New System.Windows.Forms.Label()
        Me.cbDirect2DRotate = New System.Windows.Forms.ComboBox()
        Me.pnVideoRendererBGColor = New System.Windows.Forms.Panel()
        Me.label394 = New System.Windows.Forms.Label()
        Me.btFullScreen = New System.Windows.Forms.Button()
        Me.cbScreenFlipVertical = New System.Windows.Forms.CheckBox()
        Me.cbScreenFlipHorizontal = New System.Windows.Forms.CheckBox()
        Me.cbStretch = New System.Windows.Forms.CheckBox()
        Me.groupBox13 = New System.Windows.Forms.GroupBox()
        Me.rbDirect2D = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.rbEVR = New System.Windows.Forms.RadioButton()
        Me.rbVMR9 = New System.Windows.Forms.RadioButton()
        Me.rbVR = New System.Windows.Forms.RadioButton()
        Me.TabPage23 = New System.Windows.Forms.TabPage()
        Me.edBarcodeMetadata = New System.Windows.Forms.TextBox()
        Me.label91 = New System.Windows.Forms.Label()
        Me.cbBarcodeType = New System.Windows.Forms.ComboBox()
        Me.label90 = New System.Windows.Forms.Label()
        Me.btBarcodeReset = New System.Windows.Forms.Button()
        Me.edBarcode = New System.Windows.Forms.TextBox()
        Me.label89 = New System.Windows.Forms.Label()
        Me.cbBarcodeDetectionEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage24 = New System.Windows.Forms.TabPage()
        Me.cbNetworkStreamingMode = New System.Windows.Forms.ComboBox()
        Me.tabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage25 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.edNetworkURL = New System.Windows.Forms.TextBox()
        Me.edWMVNetworkPort = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btRefreshClients = New System.Windows.Forms.Button()
        Me.lbNetworkClients = New System.Windows.Forms.ListBox()
        Me.rbNetworkStreamingUseExternalProfile = New System.Windows.Forms.RadioButton()
        Me.rbNetworkStreamingUseMainWMVSettings = New System.Windows.Forms.RadioButton()
        Me.label81 = New System.Windows.Forms.Label()
        Me.label80 = New System.Windows.Forms.Label()
        Me.edMaximumClients = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btSelectWMVProfileNetwork = New System.Windows.Forms.Button()
        Me.edNetworkStreamingWMVProfile = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage47 = New System.Windows.Forms.TabPage()
        Me.edNetworkRTSPURL = New System.Windows.Forms.TextBox()
        Me.label367 = New System.Windows.Forms.Label()
        Me.label366 = New System.Windows.Forms.Label()
        Me.TabPage48 = New System.Windows.Forms.TabPage()
        Me.linkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.rbNetworkRTMPFFMPEGCustom = New System.Windows.Forms.RadioButton()
        Me.rbNetworkRTMPFFMPEG = New System.Windows.Forms.RadioButton()
        Me.edNetworkRTMPURL = New System.Windows.Forms.TextBox()
        Me.label368 = New System.Windows.Forms.Label()
        Me.label369 = New System.Windows.Forms.Label()
        Me.TabPage67 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.label484 = New System.Windows.Forms.Label()
        Me.edNetworkUDPURL = New System.Windows.Forms.TextBox()
        Me.label372 = New System.Windows.Forms.Label()
        Me.rbNetworkUDPFFMPEGCustom = New System.Windows.Forms.RadioButton()
        Me.rbNetworkUDPFFMPEG = New System.Windows.Forms.RadioButton()
        Me.TabPage49 = New System.Windows.Forms.TabPage()
        Me.linkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.rbNetworkSSFFMPEGCustom = New System.Windows.Forms.RadioButton()
        Me.rbNetworkSSFFMPEGDefault = New System.Windows.Forms.RadioButton()
        Me.linkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.edNetworkSSURL = New System.Windows.Forms.TextBox()
        Me.label370 = New System.Windows.Forms.Label()
        Me.label371 = New System.Windows.Forms.Label()
        Me.rbNetworkSSSoftware = New System.Windows.Forms.RadioButton()
        Me.TabPage56 = New System.Windows.Forms.TabPage()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.cbNetworkStreamingAudioEnabled = New System.Windows.Forms.CheckBox()
        Me.cbNetworkStreaming = New System.Windows.Forms.CheckBox()
        Me.TabPage32 = New System.Windows.Forms.TabPage()
        Me.label328 = New System.Windows.Forms.Label()
        Me.label327 = New System.Windows.Forms.Label()
        Me.label326 = New System.Windows.Forms.Label()
        Me.label325 = New System.Windows.Forms.Label()
        Me.cbVirtualCamera = New System.Windows.Forms.CheckBox()
        Me.TabPage34 = New System.Windows.Forms.TabPage()
        Me.cbDecklinkOutputDownConversionAnalogOutput = New System.Windows.Forms.CheckBox()
        Me.cbDecklinkOutputDownConversion = New System.Windows.Forms.ComboBox()
        Me.label337 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputHDTVPulldown = New System.Windows.Forms.ComboBox()
        Me.label336 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputBlackToDeck = New System.Windows.Forms.ComboBox()
        Me.label335 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputSingleField = New System.Windows.Forms.ComboBox()
        Me.label334 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputComponentLevels = New System.Windows.Forms.ComboBox()
        Me.label333 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputNTSC = New System.Windows.Forms.ComboBox()
        Me.label332 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputDualLink = New System.Windows.Forms.ComboBox()
        Me.label331 = New System.Windows.Forms.Label()
        Me.cbDecklinkOutputAnalog = New System.Windows.Forms.ComboBox()
        Me.label87 = New System.Windows.Forms.Label()
        Me.cbDecklinkDV = New System.Windows.Forms.CheckBox()
        Me.cbDecklinkOutput = New System.Windows.Forms.CheckBox()
        Me.TabPage43 = New System.Windows.Forms.TabPage()
        Me.groupBox48 = New System.Windows.Forms.GroupBox()
        Me.label343 = New System.Windows.Forms.Label()
        Me.edEncryptionKeyHEX = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyBinary = New System.Windows.Forms.RadioButton()
        Me.btEncryptionOpenFile = New System.Windows.Forms.Button()
        Me.edEncryptionKeyFile = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyFile = New System.Windows.Forms.RadioButton()
        Me.edEncryptionKeyString = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyString = New System.Windows.Forms.RadioButton()
        Me.groupBox47 = New System.Windows.Forms.GroupBox()
        Me.rbEncryptionModeAES256 = New System.Windows.Forms.RadioButton()
        Me.rbEncryptionModeAES128 = New System.Windows.Forms.RadioButton()
        Me.groupBox43 = New System.Windows.Forms.GroupBox()
        Me.rbEncryptedH264CUDA = New System.Windows.Forms.RadioButton()
        Me.rbEncryptedH264SW = New System.Windows.Forms.RadioButton()
        Me.TabPage78 = New System.Windows.Forms.TabPage()
        Me.TabControl32 = New System.Windows.Forms.TabControl()
        Me.TabPage142 = New System.Windows.Forms.TabPage()
        Me.edTagTrackID = New System.Windows.Forms.TextBox()
        Me.Label496 = New System.Windows.Forms.Label()
        Me.edTagYear = New System.Windows.Forms.TextBox()
        Me.Label495 = New System.Windows.Forms.Label()
        Me.edTagComment = New System.Windows.Forms.TextBox()
        Me.Label493 = New System.Windows.Forms.Label()
        Me.edTagAlbum = New System.Windows.Forms.TextBox()
        Me.Label491 = New System.Windows.Forms.Label()
        Me.edTagArtists = New System.Windows.Forms.TextBox()
        Me.Label490 = New System.Windows.Forms.Label()
        Me.edTagCopyright = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.edTagTitle = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage143 = New System.Windows.Forms.TabPage()
        Me.imgTagCover = New System.Windows.Forms.PictureBox()
        Me.Label499 = New System.Windows.Forms.Label()
        Me.Label498 = New System.Windows.Forms.Label()
        Me.edTagLyrics = New System.Windows.Forms.TextBox()
        Me.Label497 = New System.Windows.Forms.Label()
        Me.cbTagGenre = New System.Windows.Forms.ComboBox()
        Me.Label494 = New System.Windows.Forms.Label()
        Me.edTagComposers = New System.Windows.Forms.TextBox()
        Me.Label492 = New System.Windows.Forms.Label()
        Me.cbTagEnabled = New System.Windows.Forms.CheckBox()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btStart = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tbSeeking = New System.Windows.Forms.TrackBar()
        Me.openFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.VideoEdit1 = New VisioForge.Controls.UI.WinForms.VideoEdit()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl3 = New System.Windows.Forms.TabControl()
        Me.tabPage52 = New System.Windows.Forms.TabPage()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.label72 = New System.Windows.Forms.Label()
        Me.edInsertTime = New System.Windows.Forms.TextBox()
        Me.label73 = New System.Windows.Forms.Label()
        Me.cbInsertAfterPreviousFile = New System.Windows.Forms.CheckBox()
        Me.label50 = New System.Windows.Forms.Label()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.label42 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.edStopTime = New System.Windows.Forms.TextBox()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label36 = New System.Windows.Forms.Label()
        Me.edStartTime = New System.Windows.Forms.TextBox()
        Me.label35 = New System.Windows.Forms.Label()
        Me.cbAddFullFile = New System.Windows.Forms.CheckBox()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.btClearList = New System.Windows.Forms.Button()
        Me.btAddInputFile = New System.Windows.Forms.Button()
        Me.lbFiles = New System.Windows.Forms.ListBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tabPage53 = New System.Windows.Forms.TabPage()
        Me.label134 = New System.Windows.Forms.Label()
        Me.btSelectOutputCut = New System.Windows.Forms.Button()
        Me.edOutputFileCut = New System.Windows.Forms.TextBox()
        Me.label131 = New System.Windows.Forms.Label()
        Me.btStopCut = New System.Windows.Forms.Button()
        Me.btStartCut = New System.Windows.Forms.Button()
        Me.label31 = New System.Windows.Forms.Label()
        Me.btAddInputFile2 = New System.Windows.Forms.Button()
        Me.edSourceFileToCut = New System.Windows.Forms.TextBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.edStopTimeCut = New System.Windows.Forms.TextBox()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.edStartTimeCut = New System.Windows.Forms.TextBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.tabPage54 = New System.Windows.Forms.TabPage()
        Me.btSelectOutputJoin = New System.Windows.Forms.Button()
        Me.edOutputFileJoin = New System.Windows.Forms.TextBox()
        Me.label132 = New System.Windows.Forms.Label()
        Me.btStopJoin = New System.Windows.Forms.Button()
        Me.btStartJoin = New System.Windows.Forms.Button()
        Me.btClearList3 = New System.Windows.Forms.Button()
        Me.btAddInputFile3 = New System.Windows.Forms.Button()
        Me.lbFiles2 = New System.Windows.Forms.ListBox()
        Me.label32 = New System.Windows.Forms.Label()
        Me.TabPage74 = New System.Windows.Forms.TabPage()
        Me.label168 = New System.Windows.Forms.Label()
        Me.cbMuxStreamsShortest = New System.Windows.Forms.CheckBox()
        Me.cbMuxStreamsType = New System.Windows.Forms.ComboBox()
        Me.btMuxStreamsSelectFile = New System.Windows.Forms.Button()
        Me.edMuxStreamsSourceFile = New System.Windows.Forms.TextBox()
        Me.label167 = New System.Windows.Forms.Label()
        Me.btMuxStreamsSelectOutput = New System.Windows.Forms.Button()
        Me.edMuxStreamsOutputFile = New System.Windows.Forms.TextBox()
        Me.label165 = New System.Windows.Forms.Label()
        Me.btStopMux = New System.Windows.Forms.Button()
        Me.btStartMux = New System.Windows.Forms.Button()
        Me.btMuxStreamsClear = New System.Windows.Forms.Button()
        Me.btMuxStreamsAdd = New System.Windows.Forms.Button()
        Me.lbMuxStreamsList = New System.Windows.Forms.ListBox()
        Me.label166 = New System.Windows.Forms.Label()
        Me.btTest = New System.Windows.Forms.Button()
        Me.cbLicensing = New System.Windows.Forms.CheckBox()
        Me.openFileDialogSubtitles = New System.Windows.Forms.OpenFileDialog()
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPage30.SuspendLayout
        Me.tabPage4.SuspendLayout
        Me.tabPage5.SuspendLayout
        Me.tabControl11.SuspendLayout
        Me.tabPage13.SuspendLayout
        Me.tabPage19.SuspendLayout
        Me.tabPage6.SuspendLayout
        Me.groupBox8.SuspendLayout
        Me.groupBox9.SuspendLayout
        Me.groupBox10.SuspendLayout
        Me.tabPage10.SuspendLayout
        Me.tabPage11.SuspendLayout
        Me.tabControl4.SuspendLayout
        Me.tabPage17.SuspendLayout
        CType(Me.tbLameEncodingQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox11.SuspendLayout
        Me.groupBox12.SuspendLayout
        CType(Me.tbLameVBRQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage18.SuspendLayout
        Me.tabPage12.SuspendLayout
        Me.tabPage8.SuspendLayout
        Me.groupBox4.SuspendLayout
        Me.groupBox3.SuspendLayout
        Me.TabPage14.SuspendLayout
        Me.tabControl6.SuspendLayout
        Me.tabPage58.SuspendLayout
        Me.tabPage60.SuspendLayout
        CType(Me.tbWebMAudioQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage61.SuspendLayout
        Me.tabPage63.SuspendLayout
        Me.TabPage15.SuspendLayout
        Me.tabControl16.SuspendLayout
        Me.tabPage62.SuspendLayout
        Me.tabPage64.SuspendLayout
        Me.tabPage65.SuspendLayout
        Me.TabPage66.SuspendLayout
        Me.tabControl29.SuspendLayout
        Me.tabPage129.SuspendLayout
        Me.tabPage132.SuspendLayout
        Me.tabPage130.SuspendLayout
        Me.tabControl30.SuspendLayout
        Me.tabPage134.SuspendLayout
        Me.tabPage137.SuspendLayout
        CType(Me.tbFFEXEVideoQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage136.SuspendLayout
        Me.tabPage135.SuspendLayout
        CType(Me.tbFFEXEH264Quantizer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage131.SuspendLayout
        CType(Me.tbFFEXEAudioQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage133.SuspendLayout
        Me.TabPage46.SuspendLayout
        Me.tabControl24.SuspendLayout
        Me.TabPage50.SuspendLayout
        Me.tabPage89.SuspendLayout
        Me.groupBox18.SuspendLayout
        Me.groupBox29.SuspendLayout
        Me.groupBox46.SuspendLayout
        Me.TabPage22.SuspendLayout
        Me.groupBox14.SuspendLayout
        Me.groupBox49.SuspendLayout
        Me.groupBox50.SuspendLayout
        Me.tabPage90.SuspendLayout
        Me.TabPage51.SuspendLayout
        CType(Me.tbFLACLPCOrder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbFLACLevel,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage55.SuspendLayout
        CType(Me.tbSpeexComplexity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSpeexMaxBitrate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSpeexBitrate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSpeexQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage77.SuspendLayout
        Me.TabControl31.SuspendLayout
        Me.tabPage140.SuspendLayout
        Me.TabPage79.SuspendLayout
        Me.tabPage31.SuspendLayout
        Me.tabControl17.SuspendLayout
        Me.tabPage68.SuspendLayout
        Me.tabControl7.SuspendLayout
        Me.tabPage29.SuspendLayout
        Me.tabControl8.SuspendLayout
        Me.tabPage35.SuspendLayout
        CType(Me.tbTextLogoTransp,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage36.SuspendLayout
        Me.tabPage37.SuspendLayout
        Me.tabPage38.SuspendLayout
        Me.tabPage39.SuspendLayout
        Me.tabPage40.SuspendLayout
        Me.groupBox16.SuspendLayout
        Me.groupBox17.SuspendLayout
        Me.tabPage41.SuspendLayout
        Me.tabPage42.SuspendLayout
        CType(Me.tbImageLogoTransp,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox22.SuspendLayout
        Me.groupBox23.SuspendLayout
        Me.TabPage7.SuspendLayout
        Me.groupBox37.SuspendLayout
        Me.TabPage16.SuspendLayout
        Me.groupBox40.SuspendLayout
        Me.groupBox39.SuspendLayout
        Me.groupBox38.SuspendLayout
        Me.TabPage33.SuspendLayout
        Me.groupBox45.SuspendLayout
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbDarkness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbLightness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage69.SuspendLayout
        Me.tabPage59.SuspendLayout
        Me.TabPage82.SuspendLayout
        CType(Me.tbGPUContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPUDarkness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPULightness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPUSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage20.SuspendLayout
        Me.tabControl15.SuspendLayout
        Me.TabPage26.SuspendLayout
        Me.TabPage27.SuspendLayout
        Me.TabPage21.SuspendLayout
        CType(Me.tbChromaKeyContrastHigh,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbChromaKeyContrastLow,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage70.SuspendLayout
        Me.TabPage81.SuspendLayout
        Me.tabPage9.SuspendLayout
        Me.groupBox5.SuspendLayout
        Me.tabPage3.SuspendLayout
        Me.tabControl18.SuspendLayout
        Me.tabPage71.SuspendLayout
        CType(Me.tbAudAmplifyAmp,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage72.SuspendLayout
        CType(Me.tbAudEq9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq7,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq6,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudEq0,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage73.SuspendLayout
        CType(Me.tbAudRelease,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudAttack,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudDynAmp,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage75.SuspendLayout
        CType(Me.tbAud3DSound,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage76.SuspendLayout
        CType(Me.tbAudTrueBass,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage57.SuspendLayout
        CType(Me.tbAudioTimeshift,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox1.SuspendLayout
        CType(Me.tbAudioOutputGainLFE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainSR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainSL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainL,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox2.SuspendLayout
        CType(Me.tbAudioInputGainLFE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainSR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainSL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainL,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage80.SuspendLayout
        Me.groupBox41.SuspendLayout
        CType(Me.tbAudioChannelMapperVolume,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage28.SuspendLayout
        Me.tabControl9.SuspendLayout
        Me.tabPage44.SuspendLayout
        Me.tabPage45.SuspendLayout
        Me.groupBox25.SuspendLayout
        CType(Me.tbMotDetHLThreshold,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox27.SuspendLayout
        Me.groupBox26.SuspendLayout
        CType(Me.tbMotDetDropFramesThreshold,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox24.SuspendLayout
        Me.tabPage2.SuspendLayout
        Me.groupBox13.SuspendLayout
        Me.TabPage23.SuspendLayout
        Me.TabPage24.SuspendLayout
        Me.tabControl5.SuspendLayout
        Me.TabPage25.SuspendLayout
        Me.TabPage47.SuspendLayout
        Me.TabPage48.SuspendLayout
        Me.TabPage67.SuspendLayout
        Me.TabPage49.SuspendLayout
        Me.TabPage56.SuspendLayout
        Me.TabPage32.SuspendLayout
        Me.TabPage34.SuspendLayout
        Me.TabPage43.SuspendLayout
        Me.groupBox48.SuspendLayout
        Me.groupBox47.SuspendLayout
        Me.groupBox43.SuspendLayout
        Me.TabPage78.SuspendLayout
        Me.TabControl32.SuspendLayout
        Me.TabPage142.SuspendLayout
        Me.TabPage143.SuspendLayout
        CType(Me.imgTagCover,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSeeking,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabControl3.SuspendLayout
        Me.tabPage52.SuspendLayout
        Me.groupBox7.SuspendLayout
        Me.groupBox6.SuspendLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage53.SuspendLayout
        Me.tabPage54.SuspendLayout
        Me.TabPage74.SuspendLayout
        Me.SuspendLayout
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.Color.White
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.FontDialog1.ShowColor = true
        '
        'OpenDialog1
        '
        Me.OpenDialog1.Filter = resources.GetString("OpenDialog1.Filter")
        '
        'SaveDialog1
        '
        Me.SaveDialog1.Filter = "AVI  (*.avi) | *.avi|Windows Media Video (*.wmv)| *.wmv|Matroska  (*.mkv)| *.mkv|"& _ 
    "All files  (*.*)| *.*"
        '
        'openFileDialog2
        '
        Me.openFileDialog2.Filter = "Pictures|*.bmp; *.jpg; *.jpeg; *.jpe; *.png; *.gif; *.tiff;|All files|*.*"
        '
        'mmLog
        '
        Me.mmLog.Location = New System.Drawing.Point(11, 590)
        Me.mmLog.Multiline = true
        Me.mmLog.Name = "mmLog"
        Me.mmLog.Size = New System.Drawing.Size(310, 59)
        Me.mmLog.TabIndex = 76
        '
        'label120
        '
        Me.label120.AutoSize = true
        Me.label120.Location = New System.Drawing.Point(8, 574)
        Me.label120.Name = "label120"
        Me.label120.Size = New System.Drawing.Size(100, 13)
        Me.label120.TabIndex = 75
        Me.label120.Text = "Errors and warnings"
        '
        'cbDebugMode
        '
        Me.cbDebugMode.AutoSize = true
        Me.cbDebugMode.Location = New System.Drawing.Point(149, 545)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(87, 17)
        Me.cbDebugMode.TabIndex = 74
        Me.cbDebugMode.Text = "Debug mode"
        Me.cbDebugMode.UseVisualStyleBackColor = true
        '
        'rbPreview
        '
        Me.rbPreview.AutoSize = true
        Me.rbPreview.Checked = true
        Me.rbPreview.Location = New System.Drawing.Point(80, 544)
        Me.rbPreview.Name = "rbPreview"
        Me.rbPreview.Size = New System.Drawing.Size(63, 17)
        Me.rbPreview.TabIndex = 73
        Me.rbPreview.TabStop = true
        Me.rbPreview.Text = "Preview"
        Me.rbPreview.UseVisualStyleBackColor = true
        '
        'rbConvert
        '
        Me.rbConvert.AutoSize = true
        Me.rbConvert.Location = New System.Drawing.Point(11, 544)
        Me.rbConvert.Name = "rbConvert"
        Me.rbConvert.Size = New System.Drawing.Size(62, 17)
        Me.rbConvert.TabIndex = 72
        Me.rbConvert.Text = "Convert"
        Me.rbConvert.UseVisualStyleBackColor = true
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage31)
        Me.tabControl1.Controls.Add(Me.tabPage9)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.TabPage57)
        Me.tabControl1.Controls.Add(Me.TabPage80)
        Me.tabControl1.Controls.Add(Me.TabPage28)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage23)
        Me.tabControl1.Controls.Add(Me.TabPage24)
        Me.tabControl1.Controls.Add(Me.TabPage32)
        Me.tabControl1.Controls.Add(Me.TabPage34)
        Me.tabControl1.Controls.Add(Me.TabPage43)
        Me.tabControl1.Controls.Add(Me.TabPage78)
        Me.tabControl1.Location = New System.Drawing.Point(11, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(310, 520)
        Me.tabControl1.TabIndex = 71
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.btSelectOutput)
        Me.tabPage1.Controls.Add(Me.edOutput)
        Me.tabPage1.Controls.Add(Me.label15)
        Me.tabPage1.Controls.Add(Me.cbOutputVideoFormat)
        Me.tabPage1.Controls.Add(Me.tabControl2)
        Me.tabPage1.Controls.Add(Me.label9)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(302, 494)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Output"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'btSelectOutput
        '
        Me.btSelectOutput.Location = New System.Drawing.Point(270, 464)
        Me.btSelectOutput.Name = "btSelectOutput"
        Me.btSelectOutput.Size = New System.Drawing.Size(26, 23)
        Me.btSelectOutput.TabIndex = 25
        Me.btSelectOutput.Text = "..."
        Me.btSelectOutput.UseVisualStyleBackColor = true
        '
        'edOutput
        '
        Me.edOutput.Location = New System.Drawing.Point(92, 466)
        Me.edOutput.Name = "edOutput"
        Me.edOutput.Size = New System.Drawing.Size(168, 20)
        Me.edOutput.TabIndex = 24
        Me.edOutput.Text = "c:\video_edit_output.avi"
        '
        'label15
        '
        Me.label15.AutoSize = true
        Me.label15.Location = New System.Drawing.Point(16, 469)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(55, 13)
        Me.label15.TabIndex = 23
        Me.label15.Text = "Output file"
        '
        'cbOutputVideoFormat
        '
        Me.cbOutputVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutputVideoFormat.FormattingEnabled = true
        Me.cbOutputVideoFormat.Items.AddRange(New Object() {"AVI", "MKV (Matroska)", "WMV", "DV", "PCM/ACM", "MP3 (Lame)", "M4A (AAC)", "WMA (Windows Media Audio)", "Ogg Vorbis", "FLAC", "Speex", "Custom format", "WebM", "FFMPEG", "MP4", "Animated GIF", "Encrypted video"})
        Me.cbOutputVideoFormat.Location = New System.Drawing.Point(92, 437)
        Me.cbOutputVideoFormat.Name = "cbOutputVideoFormat"
        Me.cbOutputVideoFormat.Size = New System.Drawing.Size(204, 21)
        Me.cbOutputVideoFormat.TabIndex = 14
        '
        'tabControl2
        '
        Me.tabControl2.Controls.Add(Me.tabPage30)
        Me.tabControl2.Controls.Add(Me.tabPage4)
        Me.tabControl2.Controls.Add(Me.tabPage5)
        Me.tabControl2.Controls.Add(Me.tabPage6)
        Me.tabControl2.Controls.Add(Me.tabPage10)
        Me.tabControl2.Controls.Add(Me.tabPage11)
        Me.tabControl2.Controls.Add(Me.tabPage12)
        Me.tabControl2.Controls.Add(Me.tabPage8)
        Me.tabControl2.Controls.Add(Me.TabPage14)
        Me.tabControl2.Controls.Add(Me.TabPage15)
        Me.tabControl2.Controls.Add(Me.TabPage66)
        Me.tabControl2.Controls.Add(Me.TabPage46)
        Me.tabControl2.Controls.Add(Me.TabPage51)
        Me.tabControl2.Controls.Add(Me.TabPage55)
        Me.tabControl2.Controls.Add(Me.TabPage77)
        Me.tabControl2.Controls.Add(Me.TabPage79)
        Me.tabControl2.Location = New System.Drawing.Point(4, 6)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New System.Drawing.Size(292, 425)
        Me.tabControl2.TabIndex = 10
        '
        'tabPage30
        '
        Me.tabPage30.Controls.Add(Me.Label114)
        Me.tabPage30.Controls.Add(Me.edCropRight)
        Me.tabPage30.Controls.Add(Me.label176)
        Me.tabPage30.Controls.Add(Me.edCropBottom)
        Me.tabPage30.Controls.Add(Me.label252)
        Me.tabPage30.Controls.Add(Me.edCropLeft)
        Me.tabPage30.Controls.Add(Me.label270)
        Me.tabPage30.Controls.Add(Me.edCropTop)
        Me.tabPage30.Controls.Add(Me.label272)
        Me.tabPage30.Controls.Add(Me.cbCrop)
        Me.tabPage30.Controls.Add(Me.label92)
        Me.tabPage30.Controls.Add(Me.cbRotate)
        Me.tabPage30.Controls.Add(Me.cbFrameRate)
        Me.tabPage30.Controls.Add(Me.edHeight)
        Me.tabPage30.Controls.Add(Me.edWidth)
        Me.tabPage30.Controls.Add(Me.label2)
        Me.tabPage30.Controls.Add(Me.cbResize)
        Me.tabPage30.Location = New System.Drawing.Point(4, 22)
        Me.tabPage30.Name = "tabPage30"
        Me.tabPage30.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage30.Size = New System.Drawing.Size(284, 399)
        Me.tabPage30.TabIndex = 6
        Me.tabPage30.Text = "Main settings"
        Me.tabPage30.UseVisualStyleBackColor = true
        '
        'Label114
        '
        Me.Label114.AutoSize = true
        Me.Label114.Location = New System.Drawing.Point(8, 52)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(278, 13)
        Me.Label114.TabIndex = 167
        Me.Label114.Text = "Frame rate (Use 0 to have original, set before adding files)"
        '
        'edCropRight
        '
        Me.edCropRight.Location = New System.Drawing.Point(179, 228)
        Me.edCropRight.Name = "edCropRight"
        Me.edCropRight.Size = New System.Drawing.Size(36, 20)
        Me.edCropRight.TabIndex = 166
        Me.edCropRight.Text = "0"
        '
        'label176
        '
        Me.label176.AutoSize = true
        Me.label176.Location = New System.Drawing.Point(138, 232)
        Me.label176.Name = "label176"
        Me.label176.Size = New System.Drawing.Size(32, 13)
        Me.label176.TabIndex = 165
        Me.label176.Text = "Right"
        '
        'edCropBottom
        '
        Me.edCropBottom.Location = New System.Drawing.Point(84, 228)
        Me.edCropBottom.Name = "edCropBottom"
        Me.edCropBottom.Size = New System.Drawing.Size(36, 20)
        Me.edCropBottom.TabIndex = 164
        Me.edCropBottom.Text = "0"
        '
        'label252
        '
        Me.label252.AutoSize = true
        Me.label252.Location = New System.Drawing.Point(38, 232)
        Me.label252.Name = "label252"
        Me.label252.Size = New System.Drawing.Size(40, 13)
        Me.label252.TabIndex = 163
        Me.label252.Text = "Bottom"
        '
        'edCropLeft
        '
        Me.edCropLeft.Location = New System.Drawing.Point(179, 202)
        Me.edCropLeft.Name = "edCropLeft"
        Me.edCropLeft.Size = New System.Drawing.Size(36, 20)
        Me.edCropLeft.TabIndex = 162
        Me.edCropLeft.Text = "0"
        '
        'label270
        '
        Me.label270.AutoSize = true
        Me.label270.Location = New System.Drawing.Point(138, 206)
        Me.label270.Name = "label270"
        Me.label270.Size = New System.Drawing.Size(25, 13)
        Me.label270.TabIndex = 161
        Me.label270.Text = "Left"
        '
        'edCropTop
        '
        Me.edCropTop.Location = New System.Drawing.Point(84, 202)
        Me.edCropTop.Name = "edCropTop"
        Me.edCropTop.Size = New System.Drawing.Size(36, 20)
        Me.edCropTop.TabIndex = 160
        Me.edCropTop.Text = "0"
        '
        'label272
        '
        Me.label272.AutoSize = true
        Me.label272.Location = New System.Drawing.Point(38, 206)
        Me.label272.Name = "label272"
        Me.label272.Size = New System.Drawing.Size(26, 13)
        Me.label272.TabIndex = 159
        Me.label272.Text = "Top"
        '
        'cbCrop
        '
        Me.cbCrop.AutoSize = true
        Me.cbCrop.Location = New System.Drawing.Point(11, 180)
        Me.cbCrop.Name = "cbCrop"
        Me.cbCrop.Size = New System.Drawing.Size(48, 17)
        Me.cbCrop.TabIndex = 158
        Me.cbCrop.Text = "Crop"
        Me.cbCrop.UseVisualStyleBackColor = true
        '
        'label92
        '
        Me.label92.AutoSize = true
        Me.label92.Location = New System.Drawing.Point(8, 155)
        Me.label92.Name = "label92"
        Me.label92.Size = New System.Drawing.Size(39, 13)
        Me.label92.TabIndex = 143
        Me.label92.Text = "Rotate"
        '
        'cbRotate
        '
        Me.cbRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRotate.FormattingEnabled = true
        Me.cbRotate.Items.AddRange(New Object() {"0", "90", "180", "270"})
        Me.cbRotate.Location = New System.Drawing.Point(84, 152)
        Me.cbRotate.Name = "cbRotate"
        Me.cbRotate.Size = New System.Drawing.Size(120, 21)
        Me.cbRotate.TabIndex = 142
        '
        'cbFrameRate
        '
        Me.cbFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrameRate.FormattingEnabled = true
        Me.cbFrameRate.Items.AddRange(New Object() {"0", "1", "2", "5", "10", "12", "15", "20", "25", "30"})
        Me.cbFrameRate.Location = New System.Drawing.Point(11, 68)
        Me.cbFrameRate.Name = "cbFrameRate"
        Me.cbFrameRate.Size = New System.Drawing.Size(48, 21)
        Me.cbFrameRate.TabIndex = 45
        '
        'edHeight
        '
        Me.edHeight.Location = New System.Drawing.Point(156, 18)
        Me.edHeight.Name = "edHeight"
        Me.edHeight.Size = New System.Drawing.Size(48, 20)
        Me.edHeight.TabIndex = 43
        Me.edHeight.Text = "576"
        '
        'edWidth
        '
        Me.edWidth.Location = New System.Drawing.Point(84, 18)
        Me.edWidth.Name = "edWidth"
        Me.edWidth.Size = New System.Drawing.Size(48, 20)
        Me.edWidth.TabIndex = 42
        Me.edWidth.Text = "768"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(138, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(12, 13)
        Me.label2.TabIndex = 41
        Me.label2.Text = "x"
        '
        'cbResize
        '
        Me.cbResize.AutoSize = true
        Me.cbResize.Location = New System.Drawing.Point(11, 21)
        Me.cbResize.Name = "cbResize"
        Me.cbResize.Size = New System.Drawing.Size(58, 17)
        Me.cbResize.TabIndex = 40
        Me.cbResize.Text = "Resize"
        Me.cbResize.UseVisualStyleBackColor = true
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.cbUseLameInAVI)
        Me.tabPage4.Controls.Add(Me.label7)
        Me.tabPage4.Controls.Add(Me.cbBPS)
        Me.tabPage4.Controls.Add(Me.label6)
        Me.tabPage4.Controls.Add(Me.cbSampleRate)
        Me.tabPage4.Controls.Add(Me.label5)
        Me.tabPage4.Controls.Add(Me.cbChannels)
        Me.tabPage4.Controls.Add(Me.btAudioSettings)
        Me.tabPage4.Controls.Add(Me.label4)
        Me.tabPage4.Controls.Add(Me.cbAudioCodec)
        Me.tabPage4.Controls.Add(Me.btVideoSettings)
        Me.tabPage4.Controls.Add(Me.label1)
        Me.tabPage4.Controls.Add(Me.cbVideoCodec)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(284, 399)
        Me.tabPage4.TabIndex = 0
        Me.tabPage4.Text = "AVI/MKV"
        Me.tabPage4.UseVisualStyleBackColor = true
        '
        'cbUseLameInAVI
        '
        Me.cbUseLameInAVI.AutoSize = true
        Me.cbUseLameInAVI.Location = New System.Drawing.Point(9, 176)
        Me.cbUseLameInAVI.Name = "cbUseLameInAVI"
        Me.cbUseLameInAVI.Size = New System.Drawing.Size(168, 17)
        Me.cbUseLameInAVI.TabIndex = 38
        Me.cbUseLameInAVI.Text = "Use LAME for audio encoding"
        Me.cbUseLameInAVI.UseVisualStyleBackColor = true
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Location = New System.Drawing.Point(162, 116)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(28, 13)
        Me.label7.TabIndex = 37
        Me.label7.Text = "BPS"
        '
        'cbBPS
        '
        Me.cbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBPS.FormattingEnabled = true
        Me.cbBPS.Items.AddRange(New Object() {"16", "8"})
        Me.cbBPS.Location = New System.Drawing.Point(196, 113)
        Me.cbBPS.Name = "cbBPS"
        Me.cbBPS.Size = New System.Drawing.Size(51, 21)
        Me.cbBPS.TabIndex = 36
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(6, 143)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(63, 13)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Sample rate"
        '
        'cbSampleRate
        '
        Me.cbSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSampleRate.FormattingEnabled = true
        Me.cbSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbSampleRate.Location = New System.Drawing.Point(70, 140)
        Me.cbSampleRate.Name = "cbSampleRate"
        Me.cbSampleRate.Size = New System.Drawing.Size(78, 21)
        Me.cbSampleRate.TabIndex = 34
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(6, 116)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(51, 13)
        Me.label5.TabIndex = 33
        Me.label5.Text = "Channels"
        '
        'cbChannels
        '
        Me.cbChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChannels.FormattingEnabled = true
        Me.cbChannels.Items.AddRange(New Object() {"2", "1"})
        Me.cbChannels.Location = New System.Drawing.Point(70, 113)
        Me.cbChannels.Name = "cbChannels"
        Me.cbChannels.Size = New System.Drawing.Size(78, 21)
        Me.cbChannels.TabIndex = 32
        '
        'btAudioSettings
        '
        Me.btAudioSettings.Location = New System.Drawing.Point(196, 82)
        Me.btAudioSettings.Name = "btAudioSettings"
        Me.btAudioSettings.Size = New System.Drawing.Size(66, 23)
        Me.btAudioSettings.TabIndex = 31
        Me.btAudioSettings.Text = "Settings"
        Me.btAudioSettings.UseVisualStyleBackColor = true
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(6, 68)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(70, 13)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Audio codec:"
        '
        'cbAudioCodec
        '
        Me.cbAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioCodec.FormattingEnabled = true
        Me.cbAudioCodec.Location = New System.Drawing.Point(9, 84)
        Me.cbAudioCodec.Name = "cbAudioCodec"
        Me.cbAudioCodec.Size = New System.Drawing.Size(179, 21)
        Me.cbAudioCodec.TabIndex = 29
        '
        'btVideoSettings
        '
        Me.btVideoSettings.Location = New System.Drawing.Point(196, 30)
        Me.btVideoSettings.Name = "btVideoSettings"
        Me.btVideoSettings.Size = New System.Drawing.Size(66, 23)
        Me.btVideoSettings.TabIndex = 24
        Me.btVideoSettings.Text = "Settings"
        Me.btVideoSettings.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(6, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(70, 13)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Video codec:"
        '
        'cbVideoCodec
        '
        Me.cbVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVideoCodec.FormattingEnabled = true
        Me.cbVideoCodec.Location = New System.Drawing.Point(9, 32)
        Me.cbVideoCodec.Name = "cbVideoCodec"
        Me.cbVideoCodec.Size = New System.Drawing.Size(179, 21)
        Me.cbVideoCodec.TabIndex = 22
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.tabControl11)
        Me.tabPage5.Controls.Add(Me.rbWMVCustom)
        Me.tabPage5.Controls.Add(Me.cbWMVInternalProfile8)
        Me.tabPage5.Controls.Add(Me.rbWMVInternal8)
        Me.tabPage5.Controls.Add(Me.cbWMVInternalProfile9)
        Me.tabPage5.Controls.Add(Me.rbWMVInternal9)
        Me.tabPage5.Controls.Add(Me.rbWMVExternal)
        Me.tabPage5.Controls.Add(Me.btSelectWM)
        Me.tabPage5.Controls.Add(Me.edWMVProfile)
        Me.tabPage5.Controls.Add(Me.label8)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage5.Size = New System.Drawing.Size(284, 399)
        Me.tabPage5.TabIndex = 1
        Me.tabPage5.Text = "WMV/WMA"
        Me.tabPage5.UseVisualStyleBackColor = true
        '
        'tabControl11
        '
        Me.tabControl11.Controls.Add(Me.tabPage13)
        Me.tabControl11.Controls.Add(Me.tabPage19)
        Me.tabControl11.Location = New System.Drawing.Point(2, 183)
        Me.tabControl11.Name = "tabControl11"
        Me.tabControl11.SelectedIndex = 0
        Me.tabControl11.Size = New System.Drawing.Size(288, 206)
        Me.tabControl11.TabIndex = 26
        '
        'tabPage13
        '
        Me.tabPage13.Controls.Add(Me.label189)
        Me.tabPage13.Controls.Add(Me.edWMVKeyFrameInterval)
        Me.tabPage13.Controls.Add(Me.label190)
        Me.tabPage13.Controls.Add(Me.label191)
        Me.tabPage13.Controls.Add(Me.edWMVFrameRate)
        Me.tabPage13.Controls.Add(Me.label192)
        Me.tabPage13.Controls.Add(Me.edWMVVideoQuality)
        Me.tabPage13.Controls.Add(Me.label188)
        Me.tabPage13.Controls.Add(Me.cbWMVTVFormat)
        Me.tabPage13.Controls.Add(Me.label187)
        Me.tabPage13.Controls.Add(Me.label183)
        Me.tabPage13.Controls.Add(Me.edWMVVideoPeakBitrate)
        Me.tabPage13.Controls.Add(Me.label184)
        Me.tabPage13.Controls.Add(Me.label185)
        Me.tabPage13.Controls.Add(Me.edWMVVideoBitrate)
        Me.tabPage13.Controls.Add(Me.label186)
        Me.tabPage13.Controls.Add(Me.label62)
        Me.tabPage13.Controls.Add(Me.cbWMVSizeSameAsInput)
        Me.tabPage13.Controls.Add(Me.edWMVHeight)
        Me.tabPage13.Controls.Add(Me.edWMVWidth)
        Me.tabPage13.Controls.Add(Me.label182)
        Me.tabPage13.Controls.Add(Me.cbWMVVideoEnabled)
        Me.tabPage13.Controls.Add(Me.cbWMVVideoCodec)
        Me.tabPage13.Controls.Add(Me.label174)
        Me.tabPage13.Controls.Add(Me.cbWMVVideoMode)
        Me.tabPage13.Controls.Add(Me.label175)
        Me.tabPage13.Location = New System.Drawing.Point(4, 22)
        Me.tabPage13.Name = "tabPage13"
        Me.tabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage13.Size = New System.Drawing.Size(280, 180)
        Me.tabPage13.TabIndex = 0
        Me.tabPage13.Text = "Video"
        Me.tabPage13.UseVisualStyleBackColor = true
        '
        'label189
        '
        Me.label189.AutoSize = true
        Me.label189.Location = New System.Drawing.Point(267, 154)
        Me.label189.Name = "label189"
        Me.label189.Size = New System.Drawing.Size(12, 13)
        Me.label189.TabIndex = 71
        Me.label189.Text = "s"
        '
        'edWMVKeyFrameInterval
        '
        Me.edWMVKeyFrameInterval.Location = New System.Drawing.Point(241, 151)
        Me.edWMVKeyFrameInterval.Name = "edWMVKeyFrameInterval"
        Me.edWMVKeyFrameInterval.Size = New System.Drawing.Size(20, 20)
        Me.edWMVKeyFrameInterval.TabIndex = 70
        Me.edWMVKeyFrameInterval.Text = "1"
        '
        'label190
        '
        Me.label190.AutoSize = true
        Me.label190.Location = New System.Drawing.Point(147, 154)
        Me.label190.Name = "label190"
        Me.label190.Size = New System.Drawing.Size(91, 13)
        Me.label190.TabIndex = 69
        Me.label190.Text = "Key frame interval"
        '
        'label191
        '
        Me.label191.AutoSize = true
        Me.label191.Location = New System.Drawing.Point(114, 154)
        Me.label191.Name = "label191"
        Me.label191.Size = New System.Drawing.Size(21, 13)
        Me.label191.TabIndex = 68
        Me.label191.Text = "fps"
        '
        'edWMVFrameRate
        '
        Me.edWMVFrameRate.Location = New System.Drawing.Point(79, 151)
        Me.edWMVFrameRate.Name = "edWMVFrameRate"
        Me.edWMVFrameRate.Size = New System.Drawing.Size(30, 20)
        Me.edWMVFrameRate.TabIndex = 67
        Me.edWMVFrameRate.Text = "25"
        '
        'label192
        '
        Me.label192.AutoSize = true
        Me.label192.Location = New System.Drawing.Point(11, 154)
        Me.label192.Name = "label192"
        Me.label192.Size = New System.Drawing.Size(57, 13)
        Me.label192.TabIndex = 66
        Me.label192.Text = "Frame rate"
        '
        'edWMVVideoQuality
        '
        Me.edWMVVideoQuality.Location = New System.Drawing.Point(217, 122)
        Me.edWMVVideoQuality.Name = "edWMVVideoQuality"
        Me.edWMVVideoQuality.Size = New System.Drawing.Size(30, 20)
        Me.edWMVVideoQuality.TabIndex = 65
        Me.edWMVVideoQuality.Text = "95"
        '
        'label188
        '
        Me.label188.AutoSize = true
        Me.label188.Location = New System.Drawing.Point(147, 125)
        Me.label188.Name = "label188"
        Me.label188.Size = New System.Drawing.Size(39, 13)
        Me.label188.TabIndex = 64
        Me.label188.Text = "Quality"
        '
        'cbWMVTVFormat
        '
        Me.cbWMVTVFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVTVFormat.FormattingEnabled = true
        Me.cbWMVTVFormat.Items.AddRange(New Object() {"PAL", "NTSC", "Other"})
        Me.cbWMVTVFormat.Location = New System.Drawing.Point(79, 122)
        Me.cbWMVTVFormat.Name = "cbWMVTVFormat"
        Me.cbWMVTVFormat.Size = New System.Drawing.Size(62, 21)
        Me.cbWMVTVFormat.TabIndex = 63
        '
        'label187
        '
        Me.label187.AutoSize = true
        Me.label187.Location = New System.Drawing.Point(11, 125)
        Me.label187.Name = "label187"
        Me.label187.Size = New System.Drawing.Size(53, 13)
        Me.label187.TabIndex = 62
        Me.label187.Text = "TV format"
        '
        'label183
        '
        Me.label183.AutoSize = true
        Me.label183.Location = New System.Drawing.Point(248, 99)
        Me.label183.Name = "label183"
        Me.label183.Size = New System.Drawing.Size(31, 13)
        Me.label183.TabIndex = 61
        Me.label183.Text = "Kbps"
        '
        'edWMVVideoPeakBitrate
        '
        Me.edWMVVideoPeakBitrate.Location = New System.Drawing.Point(217, 96)
        Me.edWMVVideoPeakBitrate.Name = "edWMVVideoPeakBitrate"
        Me.edWMVVideoPeakBitrate.Size = New System.Drawing.Size(30, 20)
        Me.edWMVVideoPeakBitrate.TabIndex = 60
        Me.edWMVVideoPeakBitrate.Text = "3000"
        '
        'label184
        '
        Me.label184.AutoSize = true
        Me.label184.Location = New System.Drawing.Point(147, 99)
        Me.label184.Name = "label184"
        Me.label184.Size = New System.Drawing.Size(67, 13)
        Me.label184.TabIndex = 59
        Me.label184.Text = "Peak bit rate"
        '
        'label185
        '
        Me.label185.AutoSize = true
        Me.label185.Location = New System.Drawing.Point(110, 99)
        Me.label185.Name = "label185"
        Me.label185.Size = New System.Drawing.Size(31, 13)
        Me.label185.TabIndex = 58
        Me.label185.Text = "Kbps"
        '
        'edWMVVideoBitrate
        '
        Me.edWMVVideoBitrate.Location = New System.Drawing.Point(78, 96)
        Me.edWMVVideoBitrate.Name = "edWMVVideoBitrate"
        Me.edWMVVideoBitrate.Size = New System.Drawing.Size(30, 20)
        Me.edWMVVideoBitrate.TabIndex = 57
        Me.edWMVVideoBitrate.Text = "3000"
        '
        'label186
        '
        Me.label186.AutoSize = true
        Me.label186.Location = New System.Drawing.Point(11, 99)
        Me.label186.Name = "label186"
        Me.label186.Size = New System.Drawing.Size(40, 13)
        Me.label186.TabIndex = 56
        Me.label186.Text = "Bit rate"
        '
        'label62
        '
        Me.label62.AutoSize = true
        Me.label62.Location = New System.Drawing.Point(11, 70)
        Me.label62.Name = "label62"
        Me.label62.Size = New System.Drawing.Size(55, 13)
        Me.label62.TabIndex = 55
        Me.label62.Text = "Video size"
        '
        'cbWMVSizeSameAsInput
        '
        Me.cbWMVSizeSameAsInput.AutoSize = true
        Me.cbWMVSizeSameAsInput.Location = New System.Drawing.Point(178, 69)
        Me.cbWMVSizeSameAsInput.Name = "cbWMVSizeSameAsInput"
        Me.cbWMVSizeSameAsInput.Size = New System.Drawing.Size(93, 17)
        Me.cbWMVSizeSameAsInput.TabIndex = 54
        Me.cbWMVSizeSameAsInput.Text = "Same as input"
        Me.cbWMVSizeSameAsInput.UseVisualStyleBackColor = true
        '
        'edWMVHeight
        '
        Me.edWMVHeight.Location = New System.Drawing.Point(129, 67)
        Me.edWMVHeight.Name = "edWMVHeight"
        Me.edWMVHeight.Size = New System.Drawing.Size(30, 20)
        Me.edWMVHeight.TabIndex = 53
        Me.edWMVHeight.Text = "576"
        '
        'edWMVWidth
        '
        Me.edWMVWidth.Location = New System.Drawing.Point(79, 67)
        Me.edWMVWidth.Name = "edWMVWidth"
        Me.edWMVWidth.Size = New System.Drawing.Size(30, 20)
        Me.edWMVWidth.TabIndex = 52
        Me.edWMVWidth.Text = "768"
        '
        'label182
        '
        Me.label182.AutoSize = true
        Me.label182.Location = New System.Drawing.Point(115, 70)
        Me.label182.Name = "label182"
        Me.label182.Size = New System.Drawing.Size(12, 13)
        Me.label182.TabIndex = 51
        Me.label182.Text = "x"
        '
        'cbWMVVideoEnabled
        '
        Me.cbWMVVideoEnabled.AutoSize = true
        Me.cbWMVVideoEnabled.Location = New System.Drawing.Point(206, 12)
        Me.cbWMVVideoEnabled.Name = "cbWMVVideoEnabled"
        Me.cbWMVVideoEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbWMVVideoEnabled.TabIndex = 17
        Me.cbWMVVideoEnabled.Text = "Enabled"
        Me.cbWMVVideoEnabled.UseVisualStyleBackColor = true
        '
        'cbWMVVideoCodec
        '
        Me.cbWMVVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVVideoCodec.FormattingEnabled = true
        Me.cbWMVVideoCodec.Location = New System.Drawing.Point(53, 37)
        Me.cbWMVVideoCodec.Name = "cbWMVVideoCodec"
        Me.cbWMVVideoCodec.Size = New System.Drawing.Size(216, 21)
        Me.cbWMVVideoCodec.TabIndex = 16
        '
        'label174
        '
        Me.label174.AutoSize = true
        Me.label174.Location = New System.Drawing.Point(11, 40)
        Me.label174.Name = "label174"
        Me.label174.Size = New System.Drawing.Size(38, 13)
        Me.label174.TabIndex = 15
        Me.label174.Text = "Codec"
        '
        'cbWMVVideoMode
        '
        Me.cbWMVVideoMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVVideoMode.FormattingEnabled = true
        Me.cbWMVVideoMode.Items.AddRange(New Object() {"CBR", "VBR", "VBR (Peak)", "Quality"})
        Me.cbWMVVideoMode.Location = New System.Drawing.Point(53, 10)
        Me.cbWMVVideoMode.Name = "cbWMVVideoMode"
        Me.cbWMVVideoMode.Size = New System.Drawing.Size(58, 21)
        Me.cbWMVVideoMode.TabIndex = 14
        '
        'label175
        '
        Me.label175.AutoSize = true
        Me.label175.Location = New System.Drawing.Point(11, 13)
        Me.label175.Name = "label175"
        Me.label175.Size = New System.Drawing.Size(34, 13)
        Me.label175.TabIndex = 13
        Me.label175.Text = "Mode"
        '
        'tabPage19
        '
        Me.tabPage19.Controls.Add(Me.cbWMVAudioEnabled)
        Me.tabPage19.Controls.Add(Me.label193)
        Me.tabPage19.Controls.Add(Me.edWMVAudioPeakBitrate)
        Me.tabPage19.Controls.Add(Me.label194)
        Me.tabPage19.Controls.Add(Me.cbWMVAudioFormat)
        Me.tabPage19.Controls.Add(Me.label195)
        Me.tabPage19.Controls.Add(Me.cbWMVAudioCodec)
        Me.tabPage19.Controls.Add(Me.label196)
        Me.tabPage19.Controls.Add(Me.cbWMVAudioMode)
        Me.tabPage19.Controls.Add(Me.label197)
        Me.tabPage19.Location = New System.Drawing.Point(4, 22)
        Me.tabPage19.Name = "tabPage19"
        Me.tabPage19.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage19.Size = New System.Drawing.Size(280, 180)
        Me.tabPage19.TabIndex = 1
        Me.tabPage19.Text = "Audio"
        Me.tabPage19.UseVisualStyleBackColor = true
        '
        'cbWMVAudioEnabled
        '
        Me.cbWMVAudioEnabled.AutoSize = true
        Me.cbWMVAudioEnabled.Location = New System.Drawing.Point(204, 12)
        Me.cbWMVAudioEnabled.Name = "cbWMVAudioEnabled"
        Me.cbWMVAudioEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbWMVAudioEnabled.TabIndex = 20
        Me.cbWMVAudioEnabled.Text = "Enabled"
        Me.cbWMVAudioEnabled.UseVisualStyleBackColor = true
        '
        'label193
        '
        Me.label193.AutoSize = true
        Me.label193.Location = New System.Drawing.Point(238, 116)
        Me.label193.Name = "label193"
        Me.label193.Size = New System.Drawing.Size(31, 13)
        Me.label193.TabIndex = 19
        Me.label193.Text = "Kbps"
        '
        'edWMVAudioPeakBitrate
        '
        Me.edWMVAudioPeakBitrate.Location = New System.Drawing.Point(205, 113)
        Me.edWMVAudioPeakBitrate.Name = "edWMVAudioPeakBitrate"
        Me.edWMVAudioPeakBitrate.Size = New System.Drawing.Size(33, 20)
        Me.edWMVAudioPeakBitrate.TabIndex = 18
        Me.edWMVAudioPeakBitrate.Text = "384"
        '
        'label194
        '
        Me.label194.AutoSize = true
        Me.label194.Location = New System.Drawing.Point(202, 96)
        Me.label194.Name = "label194"
        Me.label194.Size = New System.Drawing.Size(67, 13)
        Me.label194.TabIndex = 17
        Me.label194.Text = "Peak bit rate"
        '
        'cbWMVAudioFormat
        '
        Me.cbWMVAudioFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVAudioFormat.FormattingEnabled = true
        Me.cbWMVAudioFormat.Location = New System.Drawing.Point(14, 112)
        Me.cbWMVAudioFormat.Name = "cbWMVAudioFormat"
        Me.cbWMVAudioFormat.Size = New System.Drawing.Size(180, 21)
        Me.cbWMVAudioFormat.TabIndex = 16
        '
        'label195
        '
        Me.label195.AutoSize = true
        Me.label195.Location = New System.Drawing.Point(11, 96)
        Me.label195.Name = "label195"
        Me.label195.Size = New System.Drawing.Size(39, 13)
        Me.label195.TabIndex = 15
        Me.label195.Text = "Format"
        '
        'cbWMVAudioCodec
        '
        Me.cbWMVAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVAudioCodec.FormattingEnabled = true
        Me.cbWMVAudioCodec.Location = New System.Drawing.Point(14, 61)
        Me.cbWMVAudioCodec.Name = "cbWMVAudioCodec"
        Me.cbWMVAudioCodec.Size = New System.Drawing.Size(255, 21)
        Me.cbWMVAudioCodec.TabIndex = 14
        '
        'label196
        '
        Me.label196.AutoSize = true
        Me.label196.Location = New System.Drawing.Point(11, 45)
        Me.label196.Name = "label196"
        Me.label196.Size = New System.Drawing.Size(38, 13)
        Me.label196.TabIndex = 13
        Me.label196.Text = "Codec"
        '
        'cbWMVAudioMode
        '
        Me.cbWMVAudioMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVAudioMode.FormattingEnabled = true
        Me.cbWMVAudioMode.Items.AddRange(New Object() {"CBR", "VBR", "VBR (Peak)", "Quality"})
        Me.cbWMVAudioMode.Location = New System.Drawing.Point(53, 10)
        Me.cbWMVAudioMode.Name = "cbWMVAudioMode"
        Me.cbWMVAudioMode.Size = New System.Drawing.Size(58, 21)
        Me.cbWMVAudioMode.TabIndex = 12
        '
        'label197
        '
        Me.label197.AutoSize = true
        Me.label197.Location = New System.Drawing.Point(11, 13)
        Me.label197.Name = "label197"
        Me.label197.Size = New System.Drawing.Size(34, 13)
        Me.label197.TabIndex = 11
        Me.label197.Text = "Mode"
        '
        'rbWMVCustom
        '
        Me.rbWMVCustom.AutoSize = true
        Me.rbWMVCustom.Location = New System.Drawing.Point(9, 161)
        Me.rbWMVCustom.Name = "rbWMVCustom"
        Me.rbWMVCustom.Size = New System.Drawing.Size(60, 17)
        Me.rbWMVCustom.TabIndex = 25
        Me.rbWMVCustom.Text = "Custom"
        Me.rbWMVCustom.UseVisualStyleBackColor = true
        '
        'cbWMVInternalProfile8
        '
        Me.cbWMVInternalProfile8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVInternalProfile8.FormattingEnabled = true
        Me.cbWMVInternalProfile8.Location = New System.Drawing.Point(9, 134)
        Me.cbWMVInternalProfile8.Name = "cbWMVInternalProfile8"
        Me.cbWMVInternalProfile8.Size = New System.Drawing.Size(257, 21)
        Me.cbWMVInternalProfile8.TabIndex = 24
        '
        'rbWMVInternal8
        '
        Me.rbWMVInternal8.AutoSize = true
        Me.rbWMVInternal8.Location = New System.Drawing.Point(9, 111)
        Me.rbWMVInternal8.Name = "rbWMVInternal8"
        Me.rbWMVInternal8.Size = New System.Drawing.Size(167, 17)
        Me.rbWMVInternal8.TabIndex = 23
        Me.rbWMVInternal8.Text = "Internal (OS) profile (version 8)"
        Me.rbWMVInternal8.UseVisualStyleBackColor = true
        '
        'cbWMVInternalProfile9
        '
        Me.cbWMVInternalProfile9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWMVInternalProfile9.FormattingEnabled = true
        Me.cbWMVInternalProfile9.Location = New System.Drawing.Point(9, 84)
        Me.cbWMVInternalProfile9.Name = "cbWMVInternalProfile9"
        Me.cbWMVInternalProfile9.Size = New System.Drawing.Size(257, 21)
        Me.cbWMVInternalProfile9.TabIndex = 22
        '
        'rbWMVInternal9
        '
        Me.rbWMVInternal9.AutoSize = true
        Me.rbWMVInternal9.Checked = true
        Me.rbWMVInternal9.Location = New System.Drawing.Point(9, 61)
        Me.rbWMVInternal9.Name = "rbWMVInternal9"
        Me.rbWMVInternal9.Size = New System.Drawing.Size(149, 17)
        Me.rbWMVInternal9.TabIndex = 21
        Me.rbWMVInternal9.TabStop = true
        Me.rbWMVInternal9.Text = "Internal profile (version 9+)"
        Me.rbWMVInternal9.UseVisualStyleBackColor = true
        '
        'rbWMVExternal
        '
        Me.rbWMVExternal.AutoSize = true
        Me.rbWMVExternal.Location = New System.Drawing.Point(9, 13)
        Me.rbWMVExternal.Name = "rbWMVExternal"
        Me.rbWMVExternal.Size = New System.Drawing.Size(94, 17)
        Me.rbWMVExternal.TabIndex = 20
        Me.rbWMVExternal.Text = "External profile"
        Me.rbWMVExternal.UseVisualStyleBackColor = true
        '
        'btSelectWM
        '
        Me.btSelectWM.Location = New System.Drawing.Point(242, 33)
        Me.btSelectWM.Name = "btSelectWM"
        Me.btSelectWM.Size = New System.Drawing.Size(24, 23)
        Me.btSelectWM.TabIndex = 19
        Me.btSelectWM.Text = "..."
        Me.btSelectWM.UseVisualStyleBackColor = true
        '
        'edWMVProfile
        '
        Me.edWMVProfile.Location = New System.Drawing.Point(64, 35)
        Me.edWMVProfile.Name = "edWMVProfile"
        Me.edWMVProfile.Size = New System.Drawing.Size(172, 20)
        Me.edWMVProfile.TabIndex = 18
        Me.edWMVProfile.Text = "c:\wm.prx"
        '
        'label8
        '
        Me.label8.AutoSize = true
        Me.label8.Location = New System.Drawing.Point(6, 38)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(52, 13)
        Me.label8.TabIndex = 17
        Me.label8.Text = "File name"
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.groupBox8)
        Me.tabPage6.Controls.Add(Me.groupBox9)
        Me.tabPage6.Controls.Add(Me.groupBox10)
        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage6.Size = New System.Drawing.Size(284, 399)
        Me.tabPage6.TabIndex = 7
        Me.tabPage6.Text = "DV"
        Me.tabPage6.UseVisualStyleBackColor = true
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.rbDVType2)
        Me.groupBox8.Controls.Add(Me.rbDVType1)
        Me.groupBox8.Location = New System.Drawing.Point(24, 176)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(238, 58)
        Me.groupBox8.TabIndex = 30
        Me.groupBox8.TabStop = false
        Me.groupBox8.Text = "File format"
        '
        'rbDVType2
        '
        Me.rbDVType2.AutoSize = true
        Me.rbDVType2.Location = New System.Drawing.Point(117, 25)
        Me.rbDVType2.Name = "rbDVType2"
        Me.rbDVType2.Size = New System.Drawing.Size(76, 17)
        Me.rbDVType2.TabIndex = 1
        Me.rbDVType2.Text = "Type-2 DV"
        Me.rbDVType2.UseVisualStyleBackColor = true
        '
        'rbDVType1
        '
        Me.rbDVType1.AutoSize = true
        Me.rbDVType1.Checked = true
        Me.rbDVType1.Location = New System.Drawing.Point(19, 25)
        Me.rbDVType1.Name = "rbDVType1"
        Me.rbDVType1.Size = New System.Drawing.Size(76, 17)
        Me.rbDVType1.TabIndex = 0
        Me.rbDVType1.TabStop = true
        Me.rbDVType1.Text = "Type-1 DV"
        Me.rbDVType1.UseVisualStyleBackColor = true
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.rbDVNTSC)
        Me.groupBox9.Controls.Add(Me.rbDVPAL)
        Me.groupBox9.Location = New System.Drawing.Point(24, 112)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(238, 58)
        Me.groupBox9.TabIndex = 29
        Me.groupBox9.TabStop = false
        Me.groupBox9.Text = "Video format"
        '
        'rbDVNTSC
        '
        Me.rbDVNTSC.AutoSize = true
        Me.rbDVNTSC.Location = New System.Drawing.Point(117, 25)
        Me.rbDVNTSC.Name = "rbDVNTSC"
        Me.rbDVNTSC.Size = New System.Drawing.Size(54, 17)
        Me.rbDVNTSC.TabIndex = 1
        Me.rbDVNTSC.Text = "NTSC"
        Me.rbDVNTSC.UseVisualStyleBackColor = true
        '
        'rbDVPAL
        '
        Me.rbDVPAL.AutoSize = true
        Me.rbDVPAL.Checked = true
        Me.rbDVPAL.Location = New System.Drawing.Point(19, 25)
        Me.rbDVPAL.Name = "rbDVPAL"
        Me.rbDVPAL.Size = New System.Drawing.Size(45, 17)
        Me.rbDVPAL.TabIndex = 0
        Me.rbDVPAL.TabStop = true
        Me.rbDVPAL.Text = "PAL"
        Me.rbDVPAL.UseVisualStyleBackColor = true
        '
        'groupBox10
        '
        Me.groupBox10.Controls.Add(Me.label11)
        Me.groupBox10.Controls.Add(Me.label12)
        Me.groupBox10.Controls.Add(Me.cbDVChannels)
        Me.groupBox10.Controls.Add(Me.cbDVSampleRate)
        Me.groupBox10.Location = New System.Drawing.Point(24, 18)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Size = New System.Drawing.Size(238, 88)
        Me.groupBox10.TabIndex = 28
        Me.groupBox10.TabStop = false
        Me.groupBox10.Text = "Audio settings"
        '
        'label11
        '
        Me.label11.AutoSize = true
        Me.label11.Location = New System.Drawing.Point(11, 59)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(63, 13)
        Me.label11.TabIndex = 28
        Me.label11.Text = "Sample rate"
        '
        'label12
        '
        Me.label12.AutoSize = true
        Me.label12.Location = New System.Drawing.Point(11, 27)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(51, 13)
        Me.label12.TabIndex = 27
        Me.label12.Text = "Channels"
        '
        'cbDVChannels
        '
        Me.cbDVChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVChannels.FormattingEnabled = true
        Me.cbDVChannels.Items.AddRange(New Object() {"1", "2"})
        Me.cbDVChannels.Location = New System.Drawing.Point(85, 24)
        Me.cbDVChannels.Name = "cbDVChannels"
        Me.cbDVChannels.Size = New System.Drawing.Size(53, 21)
        Me.cbDVChannels.TabIndex = 26
        '
        'cbDVSampleRate
        '
        Me.cbDVSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVSampleRate.FormattingEnabled = true
        Me.cbDVSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbDVSampleRate.Location = New System.Drawing.Point(85, 56)
        Me.cbDVSampleRate.Name = "cbDVSampleRate"
        Me.cbDVSampleRate.Size = New System.Drawing.Size(53, 21)
        Me.cbDVSampleRate.TabIndex = 25
        '
        'tabPage10
        '
        Me.tabPage10.Controls.Add(Me.btAudioSettings2)
        Me.tabPage10.Controls.Add(Me.label67)
        Me.tabPage10.Controls.Add(Me.cbAudioCodecs2)
        Me.tabPage10.Controls.Add(Me.cbSampleRate2)
        Me.tabPage10.Controls.Add(Me.label68)
        Me.tabPage10.Controls.Add(Me.cbBPS2)
        Me.tabPage10.Controls.Add(Me.label69)
        Me.tabPage10.Controls.Add(Me.cbChannels2)
        Me.tabPage10.Controls.Add(Me.label70)
        Me.tabPage10.Location = New System.Drawing.Point(4, 22)
        Me.tabPage10.Name = "tabPage10"
        Me.tabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage10.Size = New System.Drawing.Size(284, 399)
        Me.tabPage10.TabIndex = 8
        Me.tabPage10.Text = "PCM/ACM"
        Me.tabPage10.UseVisualStyleBackColor = true
        '
        'btAudioSettings2
        '
        Me.btAudioSettings2.Location = New System.Drawing.Point(192, 113)
        Me.btAudioSettings2.Name = "btAudioSettings2"
        Me.btAudioSettings2.Size = New System.Drawing.Size(66, 23)
        Me.btAudioSettings2.TabIndex = 52
        Me.btAudioSettings2.Text = "Settings"
        Me.btAudioSettings2.UseVisualStyleBackColor = true
        '
        'label67
        '
        Me.label67.AutoSize = true
        Me.label67.Location = New System.Drawing.Point(15, 99)
        Me.label67.Name = "label67"
        Me.label67.Size = New System.Drawing.Size(38, 13)
        Me.label67.TabIndex = 51
        Me.label67.Text = "Codec"
        '
        'cbAudioCodecs2
        '
        Me.cbAudioCodecs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioCodecs2.FormattingEnabled = true
        Me.cbAudioCodecs2.Location = New System.Drawing.Point(18, 115)
        Me.cbAudioCodecs2.Name = "cbAudioCodecs2"
        Me.cbAudioCodecs2.Size = New System.Drawing.Size(166, 21)
        Me.cbAudioCodecs2.TabIndex = 50
        '
        'cbSampleRate2
        '
        Me.cbSampleRate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSampleRate2.FormattingEnabled = true
        Me.cbSampleRate2.Items.AddRange(New Object() {"48000", "44100", "32000", "22050", "16000", "11025", "8000"})
        Me.cbSampleRate2.Location = New System.Drawing.Point(84, 56)
        Me.cbSampleRate2.Name = "cbSampleRate2"
        Me.cbSampleRate2.Size = New System.Drawing.Size(65, 21)
        Me.cbSampleRate2.TabIndex = 49
        '
        'label68
        '
        Me.label68.AutoSize = true
        Me.label68.Location = New System.Drawing.Point(15, 59)
        Me.label68.Name = "label68"
        Me.label68.Size = New System.Drawing.Size(63, 13)
        Me.label68.TabIndex = 48
        Me.label68.Text = "Sample rate"
        '
        'cbBPS2
        '
        Me.cbBPS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBPS2.FormattingEnabled = true
        Me.cbBPS2.Items.AddRange(New Object() {"16", "8"})
        Me.cbBPS2.Location = New System.Drawing.Point(201, 19)
        Me.cbBPS2.Name = "cbBPS2"
        Me.cbBPS2.Size = New System.Drawing.Size(55, 21)
        Me.cbBPS2.TabIndex = 47
        '
        'label69
        '
        Me.label69.AutoSize = true
        Me.label69.Location = New System.Drawing.Point(167, 22)
        Me.label69.Name = "label69"
        Me.label69.Size = New System.Drawing.Size(28, 13)
        Me.label69.TabIndex = 46
        Me.label69.Text = "BPS"
        '
        'cbChannels2
        '
        Me.cbChannels2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChannels2.FormattingEnabled = true
        Me.cbChannels2.Items.AddRange(New Object() {"2", "1"})
        Me.cbChannels2.Location = New System.Drawing.Point(84, 19)
        Me.cbChannels2.Name = "cbChannels2"
        Me.cbChannels2.Size = New System.Drawing.Size(65, 21)
        Me.cbChannels2.TabIndex = 45
        '
        'label70
        '
        Me.label70.AutoSize = true
        Me.label70.Location = New System.Drawing.Point(15, 22)
        Me.label70.Name = "label70"
        Me.label70.Size = New System.Drawing.Size(51, 13)
        Me.label70.TabIndex = 44
        Me.label70.Text = "Channels"
        '
        'tabPage11
        '
        Me.tabPage11.Controls.Add(Me.tabControl4)
        Me.tabPage11.Location = New System.Drawing.Point(4, 22)
        Me.tabPage11.Name = "tabPage11"
        Me.tabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage11.Size = New System.Drawing.Size(284, 399)
        Me.tabPage11.TabIndex = 9
        Me.tabPage11.Text = "MP3 (Lame)"
        Me.tabPage11.UseVisualStyleBackColor = true
        '
        'tabControl4
        '
        Me.tabControl4.Controls.Add(Me.tabPage17)
        Me.tabControl4.Controls.Add(Me.tabPage18)
        Me.tabControl4.Location = New System.Drawing.Point(2, 8)
        Me.tabControl4.Name = "tabControl4"
        Me.tabControl4.SelectedIndex = 0
        Me.tabControl4.Size = New System.Drawing.Size(281, 383)
        Me.tabControl4.TabIndex = 2
        '
        'tabPage17
        '
        Me.tabPage17.Controls.Add(Me.label71)
        Me.tabPage17.Controls.Add(Me.tbLameEncodingQuality)
        Me.tabPage17.Controls.Add(Me.label13)
        Me.tabPage17.Controls.Add(Me.label14)
        Me.tabPage17.Controls.Add(Me.cbLameSampleRate)
        Me.tabPage17.Controls.Add(Me.groupBox11)
        Me.tabPage17.Controls.Add(Me.groupBox12)
        Me.tabPage17.Location = New System.Drawing.Point(4, 22)
        Me.tabPage17.Name = "tabPage17"
        Me.tabPage17.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage17.Size = New System.Drawing.Size(273, 357)
        Me.tabPage17.TabIndex = 0
        Me.tabPage17.Text = "Main"
        Me.tabPage17.UseVisualStyleBackColor = true
        '
        'label71
        '
        Me.label71.AutoSize = true
        Me.label71.Location = New System.Drawing.Point(19, 285)
        Me.label71.Name = "label71"
        Me.label71.Size = New System.Drawing.Size(85, 13)
        Me.label71.TabIndex = 27
        Me.label71.Text = "Encoding quality"
        '
        'tbLameEncodingQuality
        '
        Me.tbLameEncodingQuality.BackColor = System.Drawing.SystemColors.Window
        Me.tbLameEncodingQuality.Location = New System.Drawing.Point(129, 272)
        Me.tbLameEncodingQuality.Maximum = 8
        Me.tbLameEncodingQuality.Minimum = 1
        Me.tbLameEncodingQuality.Name = "tbLameEncodingQuality"
        Me.tbLameEncodingQuality.Size = New System.Drawing.Size(107, 45)
        Me.tbLameEncodingQuality.TabIndex = 26
        Me.tbLameEncodingQuality.Value = 7
        '
        'label13
        '
        Me.label13.AutoSize = true
        Me.label13.Location = New System.Drawing.Point(201, 252)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(20, 13)
        Me.label13.TabIndex = 22
        Me.label13.Text = "Hz"
        '
        'label14
        '
        Me.label14.AutoSize = true
        Me.label14.Location = New System.Drawing.Point(19, 252)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(63, 13)
        Me.label14.TabIndex = 21
        Me.label14.Text = "Sample rate"
        '
        'cbLameSampleRate
        '
        Me.cbLameSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLameSampleRate.FormattingEnabled = true
        Me.cbLameSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "22050", "16000", "11025", "8000"})
        Me.cbLameSampleRate.Location = New System.Drawing.Point(129, 249)
        Me.cbLameSampleRate.Name = "cbLameSampleRate"
        Me.cbLameSampleRate.Size = New System.Drawing.Size(66, 21)
        Me.cbLameSampleRate.TabIndex = 20
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.rbLameMono)
        Me.groupBox11.Controls.Add(Me.rbLameDualChannels)
        Me.groupBox11.Controls.Add(Me.rbLameJointStereo)
        Me.groupBox11.Controls.Add(Me.rbLameStandardStereo)
        Me.groupBox11.Location = New System.Drawing.Point(16, 177)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(220, 65)
        Me.groupBox11.TabIndex = 1
        Me.groupBox11.TabStop = false
        Me.groupBox11.Text = "Channels"
        '
        'rbLameMono
        '
        Me.rbLameMono.AutoSize = true
        Me.rbLameMono.Location = New System.Drawing.Point(117, 42)
        Me.rbLameMono.Name = "rbLameMono"
        Me.rbLameMono.Size = New System.Drawing.Size(52, 17)
        Me.rbLameMono.TabIndex = 3
        Me.rbLameMono.Text = "Mono"
        Me.rbLameMono.UseVisualStyleBackColor = true
        '
        'rbLameDualChannels
        '
        Me.rbLameDualChannels.AutoSize = true
        Me.rbLameDualChannels.Location = New System.Drawing.Point(117, 19)
        Me.rbLameDualChannels.Name = "rbLameDualChannels"
        Me.rbLameDualChannels.Size = New System.Drawing.Size(93, 17)
        Me.rbLameDualChannels.TabIndex = 2
        Me.rbLameDualChannels.Text = "Dual channels"
        Me.rbLameDualChannels.UseVisualStyleBackColor = true
        '
        'rbLameJointStereo
        '
        Me.rbLameJointStereo.AutoSize = true
        Me.rbLameJointStereo.Location = New System.Drawing.Point(11, 42)
        Me.rbLameJointStereo.Name = "rbLameJointStereo"
        Me.rbLameJointStereo.Size = New System.Drawing.Size(79, 17)
        Me.rbLameJointStereo.TabIndex = 1
        Me.rbLameJointStereo.Text = "Joint stereo"
        Me.rbLameJointStereo.UseVisualStyleBackColor = true
        '
        'rbLameStandardStereo
        '
        Me.rbLameStandardStereo.AutoSize = true
        Me.rbLameStandardStereo.Checked = true
        Me.rbLameStandardStereo.Location = New System.Drawing.Point(11, 19)
        Me.rbLameStandardStereo.Name = "rbLameStandardStereo"
        Me.rbLameStandardStereo.Size = New System.Drawing.Size(100, 17)
        Me.rbLameStandardStereo.TabIndex = 0
        Me.rbLameStandardStereo.TabStop = true
        Me.rbLameStandardStereo.Text = "Standard stereo"
        Me.rbLameStandardStereo.UseVisualStyleBackColor = true
        '
        'groupBox12
        '
        Me.groupBox12.Controls.Add(Me.label74)
        Me.groupBox12.Controls.Add(Me.tbLameVBRQuality)
        Me.groupBox12.Controls.Add(Me.cbLameVBRMax)
        Me.groupBox12.Controls.Add(Me.label75)
        Me.groupBox12.Controls.Add(Me.label76)
        Me.groupBox12.Controls.Add(Me.cbLameVBRMin)
        Me.groupBox12.Controls.Add(Me.label77)
        Me.groupBox12.Controls.Add(Me.label78)
        Me.groupBox12.Controls.Add(Me.cbLameCBRBitrate)
        Me.groupBox12.Controls.Add(Me.rbLameVBR)
        Me.groupBox12.Controls.Add(Me.rbLameCBR)
        Me.groupBox12.Location = New System.Drawing.Point(16, 6)
        Me.groupBox12.Name = "groupBox12"
        Me.groupBox12.Size = New System.Drawing.Size(220, 165)
        Me.groupBox12.TabIndex = 0
        Me.groupBox12.TabStop = false
        Me.groupBox12.Text = "Mode"
        '
        'label74
        '
        Me.label74.AutoSize = true
        Me.label74.Location = New System.Drawing.Point(34, 134)
        Me.label74.Name = "label74"
        Me.label74.Size = New System.Drawing.Size(39, 13)
        Me.label74.TabIndex = 26
        Me.label74.Text = "Quality"
        '
        'tbLameVBRQuality
        '
        Me.tbLameVBRQuality.BackColor = System.Drawing.SystemColors.Window
        Me.tbLameVBRQuality.Location = New System.Drawing.Point(92, 116)
        Me.tbLameVBRQuality.Maximum = 9
        Me.tbLameVBRQuality.Name = "tbLameVBRQuality"
        Me.tbLameVBRQuality.Size = New System.Drawing.Size(118, 45)
        Me.tbLameVBRQuality.TabIndex = 25
        Me.tbLameVBRQuality.Value = 7
        '
        'cbLameVBRMax
        '
        Me.cbLameVBRMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLameVBRMax.FormattingEnabled = true
        Me.cbLameVBRMax.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.cbLameVBRMax.Location = New System.Drawing.Point(156, 89)
        Me.cbLameVBRMax.Name = "cbLameVBRMax"
        Me.cbLameVBRMax.Size = New System.Drawing.Size(54, 21)
        Me.cbLameVBRMax.TabIndex = 24
        '
        'label75
        '
        Me.label75.AutoSize = true
        Me.label75.Location = New System.Drawing.Point(127, 92)
        Me.label75.Name = "label75"
        Me.label75.Size = New System.Drawing.Size(27, 13)
        Me.label75.TabIndex = 23
        Me.label75.Text = "Max"
        '
        'label76
        '
        Me.label76.AutoSize = true
        Me.label76.Location = New System.Drawing.Point(34, 92)
        Me.label76.Name = "label76"
        Me.label76.Size = New System.Drawing.Size(24, 13)
        Me.label76.TabIndex = 21
        Me.label76.Text = "Min"
        '
        'cbLameVBRMin
        '
        Me.cbLameVBRMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLameVBRMin.FormattingEnabled = true
        Me.cbLameVBRMin.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.cbLameVBRMin.Location = New System.Drawing.Point(64, 89)
        Me.cbLameVBRMin.Name = "cbLameVBRMin"
        Me.cbLameVBRMin.Size = New System.Drawing.Size(54, 21)
        Me.cbLameVBRMin.TabIndex = 20
        '
        'label77
        '
        Me.label77.AutoSize = true
        Me.label77.Location = New System.Drawing.Point(177, 45)
        Me.label77.Name = "label77"
        Me.label77.Size = New System.Drawing.Size(31, 13)
        Me.label77.TabIndex = 19
        Me.label77.Text = "Kbps"
        '
        'label78
        '
        Me.label78.AutoSize = true
        Me.label78.Location = New System.Drawing.Point(34, 45)
        Me.label78.Name = "label78"
        Me.label78.Size = New System.Drawing.Size(40, 13)
        Me.label78.TabIndex = 18
        Me.label78.Text = "Bit rate"
        '
        'cbLameCBRBitrate
        '
        Me.cbLameCBRBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLameCBRBitrate.FormattingEnabled = true
        Me.cbLameCBRBitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.cbLameCBRBitrate.Location = New System.Drawing.Point(113, 42)
        Me.cbLameCBRBitrate.Name = "cbLameCBRBitrate"
        Me.cbLameCBRBitrate.Size = New System.Drawing.Size(58, 21)
        Me.cbLameCBRBitrate.TabIndex = 17
        '
        'rbLameVBR
        '
        Me.rbLameVBR.AutoSize = true
        Me.rbLameVBR.Location = New System.Drawing.Point(17, 66)
        Me.rbLameVBR.Name = "rbLameVBR"
        Me.rbLameVBR.Size = New System.Drawing.Size(104, 17)
        Me.rbLameVBR.TabIndex = 1
        Me.rbLameVBR.Text = "Variable Bit Rate"
        Me.rbLameVBR.UseVisualStyleBackColor = true
        '
        'rbLameCBR
        '
        Me.rbLameCBR.AutoSize = true
        Me.rbLameCBR.Checked = true
        Me.rbLameCBR.Location = New System.Drawing.Point(17, 19)
        Me.rbLameCBR.Name = "rbLameCBR"
        Me.rbLameCBR.Size = New System.Drawing.Size(108, 17)
        Me.rbLameCBR.TabIndex = 0
        Me.rbLameCBR.TabStop = true
        Me.rbLameCBR.Text = "Constant Bit Rate"
        Me.rbLameCBR.UseVisualStyleBackColor = true
        '
        'tabPage18
        '
        Me.tabPage18.Controls.Add(Me.cbLameVoiceEncodingMode)
        Me.tabPage18.Controls.Add(Me.cbLameModeFixed)
        Me.tabPage18.Controls.Add(Me.cbLameEnableXingVBRTag)
        Me.tabPage18.Controls.Add(Me.cbLameDisableShortBlocks)
        Me.tabPage18.Controls.Add(Me.cbLameStrictISOCompilance)
        Me.tabPage18.Controls.Add(Me.cbLameKeepAllFrequences)
        Me.tabPage18.Controls.Add(Me.cbLameStrictlyEnforceVBRMinBitrate)
        Me.tabPage18.Controls.Add(Me.cbLameForceMono)
        Me.tabPage18.Controls.Add(Me.cbLameCRCProtected)
        Me.tabPage18.Controls.Add(Me.cbLameOriginal)
        Me.tabPage18.Controls.Add(Me.cbLameCopyright)
        Me.tabPage18.Location = New System.Drawing.Point(4, 22)
        Me.tabPage18.Name = "tabPage18"
        Me.tabPage18.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage18.Size = New System.Drawing.Size(273, 357)
        Me.tabPage18.TabIndex = 1
        Me.tabPage18.Text = "Other"
        Me.tabPage18.UseVisualStyleBackColor = true
        '
        'cbLameVoiceEncodingMode
        '
        Me.cbLameVoiceEncodingMode.AutoSize = true
        Me.cbLameVoiceEncodingMode.Location = New System.Drawing.Point(26, 177)
        Me.cbLameVoiceEncodingMode.Name = "cbLameVoiceEncodingMode"
        Me.cbLameVoiceEncodingMode.Size = New System.Drawing.Size(129, 17)
        Me.cbLameVoiceEncodingMode.TabIndex = 10
        Me.cbLameVoiceEncodingMode.Text = "Voice encoding mode"
        Me.cbLameVoiceEncodingMode.UseVisualStyleBackColor = true
        '
        'cbLameModeFixed
        '
        Me.cbLameModeFixed.AutoSize = true
        Me.cbLameModeFixed.Location = New System.Drawing.Point(26, 285)
        Me.cbLameModeFixed.Name = "cbLameModeFixed"
        Me.cbLameModeFixed.Size = New System.Drawing.Size(88, 17)
        Me.cbLameModeFixed.TabIndex = 9
        Me.cbLameModeFixed.Text = """Mode fixed"""
        Me.cbLameModeFixed.UseVisualStyleBackColor = true
        '
        'cbLameEnableXingVBRTag
        '
        Me.cbLameEnableXingVBRTag.AutoSize = true
        Me.cbLameEnableXingVBRTag.Location = New System.Drawing.Point(26, 258)
        Me.cbLameEnableXingVBRTag.Name = "cbLameEnableXingVBRTag"
        Me.cbLameEnableXingVBRTag.Size = New System.Drawing.Size(126, 17)
        Me.cbLameEnableXingVBRTag.TabIndex = 8
        Me.cbLameEnableXingVBRTag.Text = "Enable Xing VBR tag"
        Me.cbLameEnableXingVBRTag.UseVisualStyleBackColor = true
        '
        'cbLameDisableShortBlocks
        '
        Me.cbLameDisableShortBlocks.AutoSize = true
        Me.cbLameDisableShortBlocks.Location = New System.Drawing.Point(26, 231)
        Me.cbLameDisableShortBlocks.Name = "cbLameDisableShortBlocks"
        Me.cbLameDisableShortBlocks.Size = New System.Drawing.Size(121, 17)
        Me.cbLameDisableShortBlocks.TabIndex = 7
        Me.cbLameDisableShortBlocks.Text = "Disable short blocks"
        Me.cbLameDisableShortBlocks.UseVisualStyleBackColor = true
        '
        'cbLameStrictISOCompilance
        '
        Me.cbLameStrictISOCompilance.AutoSize = true
        Me.cbLameStrictISOCompilance.Location = New System.Drawing.Point(26, 204)
        Me.cbLameStrictISOCompilance.Name = "cbLameStrictISOCompilance"
        Me.cbLameStrictISOCompilance.Size = New System.Drawing.Size(128, 17)
        Me.cbLameStrictISOCompilance.TabIndex = 6
        Me.cbLameStrictISOCompilance.Text = "Strict ISO compilance"
        Me.cbLameStrictISOCompilance.UseVisualStyleBackColor = true
        '
        'cbLameKeepAllFrequences
        '
        Me.cbLameKeepAllFrequences.AutoSize = true
        Me.cbLameKeepAllFrequences.Location = New System.Drawing.Point(26, 150)
        Me.cbLameKeepAllFrequences.Name = "cbLameKeepAllFrequences"
        Me.cbLameKeepAllFrequences.Size = New System.Drawing.Size(120, 17)
        Me.cbLameKeepAllFrequences.TabIndex = 5
        Me.cbLameKeepAllFrequences.Text = "Keep all frequences"
        Me.cbLameKeepAllFrequences.UseVisualStyleBackColor = true
        '
        'cbLameStrictlyEnforceVBRMinBitrate
        '
        Me.cbLameStrictlyEnforceVBRMinBitrate.AutoSize = true
        Me.cbLameStrictlyEnforceVBRMinBitrate.Location = New System.Drawing.Point(26, 123)
        Me.cbLameStrictlyEnforceVBRMinBitrate.Name = "cbLameStrictlyEnforceVBRMinBitrate"
        Me.cbLameStrictlyEnforceVBRMinBitrate.Size = New System.Drawing.Size(175, 17)
        Me.cbLameStrictlyEnforceVBRMinBitrate.TabIndex = 4
        Me.cbLameStrictlyEnforceVBRMinBitrate.Text = "Strictly enforce VBR min bit rate"
        Me.cbLameStrictlyEnforceVBRMinBitrate.UseVisualStyleBackColor = true
        '
        'cbLameForceMono
        '
        Me.cbLameForceMono.AutoSize = true
        Me.cbLameForceMono.Location = New System.Drawing.Point(26, 96)
        Me.cbLameForceMono.Name = "cbLameForceMono"
        Me.cbLameForceMono.Size = New System.Drawing.Size(82, 17)
        Me.cbLameForceMono.TabIndex = 3
        Me.cbLameForceMono.Text = "Force mono"
        Me.cbLameForceMono.UseVisualStyleBackColor = true
        '
        'cbLameCRCProtected
        '
        Me.cbLameCRCProtected.AutoSize = true
        Me.cbLameCRCProtected.Location = New System.Drawing.Point(26, 69)
        Me.cbLameCRCProtected.Name = "cbLameCRCProtected"
        Me.cbLameCRCProtected.Size = New System.Drawing.Size(96, 17)
        Me.cbLameCRCProtected.TabIndex = 2
        Me.cbLameCRCProtected.Text = "CRC protected"
        Me.cbLameCRCProtected.UseVisualStyleBackColor = true
        '
        'cbLameOriginal
        '
        Me.cbLameOriginal.AutoSize = true
        Me.cbLameOriginal.Location = New System.Drawing.Point(26, 42)
        Me.cbLameOriginal.Name = "cbLameOriginal"
        Me.cbLameOriginal.Size = New System.Drawing.Size(96, 17)
        Me.cbLameOriginal.TabIndex = 1
        Me.cbLameOriginal.Text = "Original / Copy"
        Me.cbLameOriginal.UseVisualStyleBackColor = true
        '
        'cbLameCopyright
        '
        Me.cbLameCopyright.AutoSize = true
        Me.cbLameCopyright.Location = New System.Drawing.Point(26, 15)
        Me.cbLameCopyright.Name = "cbLameCopyright"
        Me.cbLameCopyright.Size = New System.Drawing.Size(70, 17)
        Me.cbLameCopyright.TabIndex = 0
        Me.cbLameCopyright.Text = "Copyright"
        Me.cbLameCopyright.UseVisualStyleBackColor = true
        '
        'tabPage12
        '
        Me.tabPage12.Controls.Add(Me.label60)
        Me.tabPage12.Controls.Add(Me.label61)
        Me.tabPage12.Controls.Add(Me.cbOGGAverage)
        Me.tabPage12.Controls.Add(Me.label58)
        Me.tabPage12.Controls.Add(Me.label59)
        Me.tabPage12.Controls.Add(Me.cbOGGMaximum)
        Me.tabPage12.Controls.Add(Me.label57)
        Me.tabPage12.Controls.Add(Me.label56)
        Me.tabPage12.Controls.Add(Me.cbOGGMinimum)
        Me.tabPage12.Controls.Add(Me.rbOGGBitrate)
        Me.tabPage12.Controls.Add(Me.edOGGQuality)
        Me.tabPage12.Controls.Add(Me.label55)
        Me.tabPage12.Controls.Add(Me.rbOGGQuality)
        Me.tabPage12.Location = New System.Drawing.Point(4, 22)
        Me.tabPage12.Name = "tabPage12"
        Me.tabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage12.Size = New System.Drawing.Size(284, 399)
        Me.tabPage12.TabIndex = 10
        Me.tabPage12.Text = "Ogg Vorbis"
        Me.tabPage12.UseVisualStyleBackColor = true
        '
        'label60
        '
        Me.label60.AutoSize = true
        Me.label60.Location = New System.Drawing.Point(191, 193)
        Me.label60.Name = "label60"
        Me.label60.Size = New System.Drawing.Size(31, 13)
        Me.label60.TabIndex = 35
        Me.label60.Text = "Kbps"
        '
        'label61
        '
        Me.label61.AutoSize = true
        Me.label61.Location = New System.Drawing.Point(48, 193)
        Me.label61.Name = "label61"
        Me.label61.Size = New System.Drawing.Size(47, 13)
        Me.label61.TabIndex = 34
        Me.label61.Text = "Average"
        '
        'cbOGGAverage
        '
        Me.cbOGGAverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOGGAverage.FormattingEnabled = true
        Me.cbOGGAverage.Items.AddRange(New Object() {"32", "48", "96", "128", "160", "192", "224", "256", "320"})
        Me.cbOGGAverage.Location = New System.Drawing.Point(127, 190)
        Me.cbOGGAverage.Name = "cbOGGAverage"
        Me.cbOGGAverage.Size = New System.Drawing.Size(58, 21)
        Me.cbOGGAverage.TabIndex = 33
        '
        'label58
        '
        Me.label58.AutoSize = true
        Me.label58.Location = New System.Drawing.Point(191, 156)
        Me.label58.Name = "label58"
        Me.label58.Size = New System.Drawing.Size(31, 13)
        Me.label58.TabIndex = 32
        Me.label58.Text = "Kbps"
        '
        'label59
        '
        Me.label59.AutoSize = true
        Me.label59.Location = New System.Drawing.Point(48, 156)
        Me.label59.Name = "label59"
        Me.label59.Size = New System.Drawing.Size(51, 13)
        Me.label59.TabIndex = 31
        Me.label59.Text = "Maximum"
        '
        'cbOGGMaximum
        '
        Me.cbOGGMaximum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOGGMaximum.FormattingEnabled = true
        Me.cbOGGMaximum.Items.AddRange(New Object() {"32", "48", "96", "128", "160", "192", "224", "256", "320"})
        Me.cbOGGMaximum.Location = New System.Drawing.Point(127, 153)
        Me.cbOGGMaximum.Name = "cbOGGMaximum"
        Me.cbOGGMaximum.Size = New System.Drawing.Size(58, 21)
        Me.cbOGGMaximum.TabIndex = 30
        '
        'label57
        '
        Me.label57.AutoSize = true
        Me.label57.Location = New System.Drawing.Point(191, 119)
        Me.label57.Name = "label57"
        Me.label57.Size = New System.Drawing.Size(31, 13)
        Me.label57.TabIndex = 29
        Me.label57.Text = "Kbps"
        '
        'label56
        '
        Me.label56.AutoSize = true
        Me.label56.Location = New System.Drawing.Point(48, 119)
        Me.label56.Name = "label56"
        Me.label56.Size = New System.Drawing.Size(48, 13)
        Me.label56.TabIndex = 28
        Me.label56.Text = "Minimum"
        '
        'cbOGGMinimum
        '
        Me.cbOGGMinimum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOGGMinimum.FormattingEnabled = true
        Me.cbOGGMinimum.Items.AddRange(New Object() {"32", "48", "96", "128", "160", "192", "224", "256", "320"})
        Me.cbOGGMinimum.Location = New System.Drawing.Point(127, 116)
        Me.cbOGGMinimum.Name = "cbOGGMinimum"
        Me.cbOGGMinimum.Size = New System.Drawing.Size(58, 21)
        Me.cbOGGMinimum.TabIndex = 27
        '
        'rbOGGBitrate
        '
        Me.rbOGGBitrate.AutoSize = true
        Me.rbOGGBitrate.Location = New System.Drawing.Point(22, 87)
        Me.rbOGGBitrate.Name = "rbOGGBitrate"
        Me.rbOGGBitrate.Size = New System.Drawing.Size(58, 17)
        Me.rbOGGBitrate.TabIndex = 26
        Me.rbOGGBitrate.Text = "Bit rate"
        Me.rbOGGBitrate.UseVisualStyleBackColor = true
        '
        'edOGGQuality
        '
        Me.edOGGQuality.Location = New System.Drawing.Point(127, 46)
        Me.edOGGQuality.Name = "edOGGQuality"
        Me.edOGGQuality.Size = New System.Drawing.Size(32, 20)
        Me.edOGGQuality.TabIndex = 25
        Me.edOGGQuality.Text = "80"
        '
        'label55
        '
        Me.label55.AutoSize = true
        Me.label55.Location = New System.Drawing.Point(48, 49)
        Me.label55.Name = "label55"
        Me.label55.Size = New System.Drawing.Size(34, 13)
        Me.label55.TabIndex = 24
        Me.label55.Text = "Value"
        '
        'rbOGGQuality
        '
        Me.rbOGGQuality.AutoSize = true
        Me.rbOGGQuality.Checked = true
        Me.rbOGGQuality.Location = New System.Drawing.Point(22, 20)
        Me.rbOGGQuality.Name = "rbOGGQuality"
        Me.rbOGGQuality.Size = New System.Drawing.Size(57, 17)
        Me.rbOGGQuality.TabIndex = 23
        Me.rbOGGQuality.TabStop = true
        Me.rbOGGQuality.Text = "Quality"
        Me.rbOGGQuality.UseVisualStyleBackColor = true
        '
        'tabPage8
        '
        Me.tabPage8.Controls.Add(Me.btCustomFilewriterSettings)
        Me.tabPage8.Controls.Add(Me.cbCustomFilewriter)
        Me.tabPage8.Controls.Add(Me.cbUseSpecialFilewriter)
        Me.tabPage8.Controls.Add(Me.cbCustomMuxFilterIsEncoder)
        Me.tabPage8.Controls.Add(Me.btCustomMuxerSettings)
        Me.tabPage8.Controls.Add(Me.cbCustomMuxer)
        Me.tabPage8.Controls.Add(Me.label34)
        Me.tabPage8.Controls.Add(Me.groupBox4)
        Me.tabPage8.Controls.Add(Me.groupBox3)
        Me.tabPage8.Location = New System.Drawing.Point(4, 22)
        Me.tabPage8.Name = "tabPage8"
        Me.tabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage8.Size = New System.Drawing.Size(284, 399)
        Me.tabPage8.TabIndex = 4
        Me.tabPage8.Text = "Custom"
        Me.tabPage8.UseVisualStyleBackColor = true
        '
        'btCustomFilewriterSettings
        '
        Me.btCustomFilewriterSettings.Location = New System.Drawing.Point(215, 350)
        Me.btCustomFilewriterSettings.Name = "btCustomFilewriterSettings"
        Me.btCustomFilewriterSettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomFilewriterSettings.TabIndex = 10
        Me.btCustomFilewriterSettings.Text = "Settings"
        Me.btCustomFilewriterSettings.UseVisualStyleBackColor = true
        '
        'cbCustomFilewriter
        '
        Me.cbCustomFilewriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomFilewriter.FormattingEnabled = true
        Me.cbCustomFilewriter.Location = New System.Drawing.Point(14, 352)
        Me.cbCustomFilewriter.Name = "cbCustomFilewriter"
        Me.cbCustomFilewriter.Size = New System.Drawing.Size(195, 21)
        Me.cbCustomFilewriter.Sorted = true
        Me.cbCustomFilewriter.TabIndex = 9
        '
        'cbUseSpecialFilewriter
        '
        Me.cbUseSpecialFilewriter.AutoSize = true
        Me.cbUseSpecialFilewriter.Location = New System.Drawing.Point(14, 329)
        Me.cbUseSpecialFilewriter.Name = "cbUseSpecialFilewriter"
        Me.cbUseSpecialFilewriter.Size = New System.Drawing.Size(153, 17)
        Me.cbUseSpecialFilewriter.TabIndex = 8
        Me.cbUseSpecialFilewriter.Text = "Use special File Writer filter"
        Me.cbUseSpecialFilewriter.UseVisualStyleBackColor = true
        '
        'cbCustomMuxFilterIsEncoder
        '
        Me.cbCustomMuxFilterIsEncoder.AutoSize = true
        Me.cbCustomMuxFilterIsEncoder.Location = New System.Drawing.Point(149, 273)
        Me.cbCustomMuxFilterIsEncoder.Name = "cbCustomMuxFilterIsEncoder"
        Me.cbCustomMuxFilterIsEncoder.Size = New System.Drawing.Size(120, 17)
        Me.cbCustomMuxFilterIsEncoder.TabIndex = 7
        Me.cbCustomMuxFilterIsEncoder.Text = "Mux filter is encoder"
        Me.cbCustomMuxFilterIsEncoder.UseVisualStyleBackColor = true
        '
        'btCustomMuxerSettings
        '
        Me.btCustomMuxerSettings.Location = New System.Drawing.Point(215, 294)
        Me.btCustomMuxerSettings.Name = "btCustomMuxerSettings"
        Me.btCustomMuxerSettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomMuxerSettings.TabIndex = 6
        Me.btCustomMuxerSettings.Text = "Settings"
        Me.btCustomMuxerSettings.UseVisualStyleBackColor = true
        '
        'cbCustomMuxer
        '
        Me.cbCustomMuxer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomMuxer.FormattingEnabled = true
        Me.cbCustomMuxer.Location = New System.Drawing.Point(14, 296)
        Me.cbCustomMuxer.Name = "cbCustomMuxer"
        Me.cbCustomMuxer.Size = New System.Drawing.Size(195, 21)
        Me.cbCustomMuxer.Sorted = true
        Me.cbCustomMuxer.TabIndex = 3
        '
        'label34
        '
        Me.label34.AutoSize = true
        Me.label34.Location = New System.Drawing.Point(11, 274)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(49, 13)
        Me.label34.TabIndex = 2
        Me.label34.Text = "Mux filter"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.btCustomDSFiltersASettings)
        Me.groupBox4.Controls.Add(Me.cbCustomDSFilterA)
        Me.groupBox4.Controls.Add(Me.rbCustomUseDSFiltersCat)
        Me.groupBox4.Controls.Add(Me.btCustomAudioCodecSettings)
        Me.groupBox4.Controls.Add(Me.cbCustomAudioCodec)
        Me.groupBox4.Controls.Add(Me.rbCustomUseAudioCodecsCat)
        Me.groupBox4.Location = New System.Drawing.Point(6, 140)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(263, 128)
        Me.groupBox4.TabIndex = 1
        Me.groupBox4.TabStop = false
        Me.groupBox4.Text = "Audio encoder"
        '
        'btCustomDSFiltersASettings
        '
        Me.btCustomDSFiltersASettings.Location = New System.Drawing.Point(203, 91)
        Me.btCustomDSFiltersASettings.Name = "btCustomDSFiltersASettings"
        Me.btCustomDSFiltersASettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomDSFiltersASettings.TabIndex = 5
        Me.btCustomDSFiltersASettings.Text = "Settings"
        Me.btCustomDSFiltersASettings.UseVisualStyleBackColor = true
        '
        'cbCustomDSFilterA
        '
        Me.cbCustomDSFilterA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomDSFilterA.FormattingEnabled = true
        Me.cbCustomDSFilterA.Location = New System.Drawing.Point(31, 93)
        Me.cbCustomDSFilterA.Name = "cbCustomDSFilterA"
        Me.cbCustomDSFilterA.Size = New System.Drawing.Size(166, 21)
        Me.cbCustomDSFilterA.Sorted = true
        Me.cbCustomDSFilterA.TabIndex = 4
        '
        'rbCustomUseDSFiltersCat
        '
        Me.rbCustomUseDSFiltersCat.AutoSize = true
        Me.rbCustomUseDSFiltersCat.Location = New System.Drawing.Point(15, 70)
        Me.rbCustomUseDSFiltersCat.Name = "rbCustomUseDSFiltersCat"
        Me.rbCustomUseDSFiltersCat.Size = New System.Drawing.Size(179, 17)
        Me.rbCustomUseDSFiltersCat.TabIndex = 3
        Me.rbCustomUseDSFiltersCat.Text = "Use ""directshow filters"" category"
        Me.rbCustomUseDSFiltersCat.UseVisualStyleBackColor = true
        '
        'btCustomAudioCodecSettings
        '
        Me.btCustomAudioCodecSettings.Location = New System.Drawing.Point(203, 40)
        Me.btCustomAudioCodecSettings.Name = "btCustomAudioCodecSettings"
        Me.btCustomAudioCodecSettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomAudioCodecSettings.TabIndex = 2
        Me.btCustomAudioCodecSettings.Text = "Settings"
        Me.btCustomAudioCodecSettings.UseVisualStyleBackColor = true
        '
        'cbCustomAudioCodec
        '
        Me.cbCustomAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomAudioCodec.FormattingEnabled = true
        Me.cbCustomAudioCodec.Location = New System.Drawing.Point(31, 42)
        Me.cbCustomAudioCodec.Name = "cbCustomAudioCodec"
        Me.cbCustomAudioCodec.Size = New System.Drawing.Size(166, 21)
        Me.cbCustomAudioCodec.Sorted = true
        Me.cbCustomAudioCodec.TabIndex = 1
        '
        'rbCustomUseAudioCodecsCat
        '
        Me.rbCustomUseAudioCodecsCat.AutoSize = true
        Me.rbCustomUseAudioCodecsCat.Checked = true
        Me.rbCustomUseAudioCodecsCat.Location = New System.Drawing.Point(15, 19)
        Me.rbCustomUseAudioCodecsCat.Name = "rbCustomUseAudioCodecsCat"
        Me.rbCustomUseAudioCodecsCat.Size = New System.Drawing.Size(165, 17)
        Me.rbCustomUseAudioCodecsCat.TabIndex = 0
        Me.rbCustomUseAudioCodecsCat.TabStop = true
        Me.rbCustomUseAudioCodecsCat.Text = "Use ""audio codecs"" category"
        Me.rbCustomUseAudioCodecsCat.UseVisualStyleBackColor = true
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btCustomDSFiltersVSettings)
        Me.groupBox3.Controls.Add(Me.cbCustomDSFilterV)
        Me.groupBox3.Controls.Add(Me.rbCustomUseDSFiltersCap)
        Me.groupBox3.Controls.Add(Me.btCustomVideoCodecSettings)
        Me.groupBox3.Controls.Add(Me.cbCustomVideoCodec)
        Me.groupBox3.Controls.Add(Me.rbCustomUseVideoCodecsCat)
        Me.groupBox3.Location = New System.Drawing.Point(6, 6)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(263, 128)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = false
        Me.groupBox3.Text = "Video encoder"
        '
        'btCustomDSFiltersVSettings
        '
        Me.btCustomDSFiltersVSettings.Location = New System.Drawing.Point(202, 91)
        Me.btCustomDSFiltersVSettings.Name = "btCustomDSFiltersVSettings"
        Me.btCustomDSFiltersVSettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomDSFiltersVSettings.TabIndex = 5
        Me.btCustomDSFiltersVSettings.Text = "Settings"
        Me.btCustomDSFiltersVSettings.UseVisualStyleBackColor = true
        '
        'cbCustomDSFilterV
        '
        Me.cbCustomDSFilterV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomDSFilterV.FormattingEnabled = true
        Me.cbCustomDSFilterV.Location = New System.Drawing.Point(31, 93)
        Me.cbCustomDSFilterV.Name = "cbCustomDSFilterV"
        Me.cbCustomDSFilterV.Size = New System.Drawing.Size(166, 21)
        Me.cbCustomDSFilterV.Sorted = true
        Me.cbCustomDSFilterV.TabIndex = 4
        '
        'rbCustomUseDSFiltersCap
        '
        Me.rbCustomUseDSFiltersCap.AutoSize = true
        Me.rbCustomUseDSFiltersCap.Location = New System.Drawing.Point(15, 70)
        Me.rbCustomUseDSFiltersCap.Name = "rbCustomUseDSFiltersCap"
        Me.rbCustomUseDSFiltersCap.Size = New System.Drawing.Size(179, 17)
        Me.rbCustomUseDSFiltersCap.TabIndex = 3
        Me.rbCustomUseDSFiltersCap.Text = "Use ""directshow filters"" category"
        Me.rbCustomUseDSFiltersCap.UseVisualStyleBackColor = true
        '
        'btCustomVideoCodecSettings
        '
        Me.btCustomVideoCodecSettings.Location = New System.Drawing.Point(202, 40)
        Me.btCustomVideoCodecSettings.Name = "btCustomVideoCodecSettings"
        Me.btCustomVideoCodecSettings.Size = New System.Drawing.Size(54, 23)
        Me.btCustomVideoCodecSettings.TabIndex = 2
        Me.btCustomVideoCodecSettings.Text = "Settings"
        Me.btCustomVideoCodecSettings.UseVisualStyleBackColor = true
        '
        'cbCustomVideoCodec
        '
        Me.cbCustomVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomVideoCodec.FormattingEnabled = true
        Me.cbCustomVideoCodec.Location = New System.Drawing.Point(31, 42)
        Me.cbCustomVideoCodec.Name = "cbCustomVideoCodec"
        Me.cbCustomVideoCodec.Size = New System.Drawing.Size(166, 21)
        Me.cbCustomVideoCodec.Sorted = true
        Me.cbCustomVideoCodec.TabIndex = 1
        '
        'rbCustomUseVideoCodecsCat
        '
        Me.rbCustomUseVideoCodecsCat.AutoSize = true
        Me.rbCustomUseVideoCodecsCat.Checked = true
        Me.rbCustomUseVideoCodecsCat.Location = New System.Drawing.Point(15, 19)
        Me.rbCustomUseVideoCodecsCat.Name = "rbCustomUseVideoCodecsCat"
        Me.rbCustomUseVideoCodecsCat.Size = New System.Drawing.Size(165, 17)
        Me.rbCustomUseVideoCodecsCat.TabIndex = 0
        Me.rbCustomUseVideoCodecsCat.TabStop = true
        Me.rbCustomUseVideoCodecsCat.Text = "Use ""video codecs"" category"
        Me.rbCustomUseVideoCodecsCat.UseVisualStyleBackColor = true
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.tabControl6)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(284, 399)
        Me.TabPage14.TabIndex = 11
        Me.TabPage14.Text = "WebM"
        Me.TabPage14.UseVisualStyleBackColor = true
        '
        'tabControl6
        '
        Me.tabControl6.Controls.Add(Me.tabPage58)
        Me.tabControl6.Controls.Add(Me.tabPage60)
        Me.tabControl6.Controls.Add(Me.tabPage61)
        Me.tabControl6.Controls.Add(Me.tabPage63)
        Me.tabControl6.Location = New System.Drawing.Point(6, 6)
        Me.tabControl6.Name = "tabControl6"
        Me.tabControl6.SelectedIndex = 0
        Me.tabControl6.Size = New System.Drawing.Size(272, 387)
        Me.tabControl6.TabIndex = 5
        '
        'tabPage58
        '
        Me.tabPage58.Controls.Add(Me.cbWebMVideoKeyframeMode)
        Me.tabPage58.Controls.Add(Me.label113)
        Me.tabPage58.Controls.Add(Me.edWebMVideoKeyframeMaxInterval)
        Me.tabPage58.Controls.Add(Me.label100)
        Me.tabPage58.Controls.Add(Me.edWebMVideoKeyframeMinInterval)
        Me.tabPage58.Controls.Add(Me.label99)
        Me.tabPage58.Controls.Add(Me.edWebMVideoMaxQuantizer)
        Me.tabPage58.Controls.Add(Me.label88)
        Me.tabPage58.Controls.Add(Me.edWebMVideoMinQuantizer)
        Me.tabPage58.Controls.Add(Me.label86)
        Me.tabPage58.Controls.Add(Me.label79)
        Me.tabPage58.Controls.Add(Me.cbWebMVideoEncoder)
        Me.tabPage58.Controls.Add(Me.cbWebMVideoQualityMode)
        Me.tabPage58.Controls.Add(Me.label63)
        Me.tabPage58.Controls.Add(Me.label179)
        Me.tabPage58.Controls.Add(Me.cbWebMVideoEndUsageMode)
        Me.tabPage58.Controls.Add(Me.label178)
        Me.tabPage58.Controls.Add(Me.edWebMVideoThreadCount)
        Me.tabPage58.Controls.Add(Me.label173)
        Me.tabPage58.Controls.Add(Me.edWebMVideoBitrate)
        Me.tabPage58.Controls.Add(Me.label172)
        Me.tabPage58.Location = New System.Drawing.Point(4, 22)
        Me.tabPage58.Name = "tabPage58"
        Me.tabPage58.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage58.Size = New System.Drawing.Size(264, 361)
        Me.tabPage58.TabIndex = 0
        Me.tabPage58.Text = "Video (VP8/VP9) - Main"
        Me.tabPage58.UseVisualStyleBackColor = true
        '
        'cbWebMVideoKeyframeMode
        '
        Me.cbWebMVideoKeyframeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWebMVideoKeyframeMode.FormattingEnabled = true
        Me.cbWebMVideoKeyframeMode.Items.AddRange(New Object() {"Auto", "Default", "Disabled"})
        Me.cbWebMVideoKeyframeMode.Location = New System.Drawing.Point(131, 238)
        Me.cbWebMVideoKeyframeMode.Name = "cbWebMVideoKeyframeMode"
        Me.cbWebMVideoKeyframeMode.Size = New System.Drawing.Size(84, 21)
        Me.cbWebMVideoKeyframeMode.TabIndex = 34
        '
        'label113
        '
        Me.label113.AutoSize = true
        Me.label113.Location = New System.Drawing.Point(15, 241)
        Me.label113.Name = "label113"
        Me.label113.Size = New System.Drawing.Size(80, 13)
        Me.label113.TabIndex = 33
        Me.label113.Text = "Keyframe mode"
        '
        'edWebMVideoKeyframeMaxInterval
        '
        Me.edWebMVideoKeyframeMaxInterval.Location = New System.Drawing.Point(131, 291)
        Me.edWebMVideoKeyframeMaxInterval.Name = "edWebMVideoKeyframeMaxInterval"
        Me.edWebMVideoKeyframeMaxInterval.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoKeyframeMaxInterval.TabIndex = 32
        Me.edWebMVideoKeyframeMaxInterval.Text = "-1"
        '
        'label100
        '
        Me.label100.AutoSize = true
        Me.label100.Location = New System.Drawing.Point(15, 294)
        Me.label100.Name = "label100"
        Me.label100.Size = New System.Drawing.Size(110, 13)
        Me.label100.TabIndex = 31
        Me.label100.Text = "Keyframe max interval"
        '
        'edWebMVideoKeyframeMinInterval
        '
        Me.edWebMVideoKeyframeMinInterval.Location = New System.Drawing.Point(131, 265)
        Me.edWebMVideoKeyframeMinInterval.Name = "edWebMVideoKeyframeMinInterval"
        Me.edWebMVideoKeyframeMinInterval.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoKeyframeMinInterval.TabIndex = 30
        Me.edWebMVideoKeyframeMinInterval.Text = "-1"
        '
        'label99
        '
        Me.label99.AutoSize = true
        Me.label99.Location = New System.Drawing.Point(15, 268)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(107, 13)
        Me.label99.TabIndex = 29
        Me.label99.Text = "Keyframe min interval"
        '
        'edWebMVideoMaxQuantizer
        '
        Me.edWebMVideoMaxQuantizer.Location = New System.Drawing.Point(131, 190)
        Me.edWebMVideoMaxQuantizer.Name = "edWebMVideoMaxQuantizer"
        Me.edWebMVideoMaxQuantizer.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoMaxQuantizer.TabIndex = 28
        Me.edWebMVideoMaxQuantizer.Text = "-1"
        '
        'label88
        '
        Me.label88.AutoSize = true
        Me.label88.Location = New System.Drawing.Point(15, 193)
        Me.label88.Name = "label88"
        Me.label88.Size = New System.Drawing.Size(91, 13)
        Me.label88.TabIndex = 27
        Me.label88.Text = "Maximal quantizer"
        '
        'edWebMVideoMinQuantizer
        '
        Me.edWebMVideoMinQuantizer.Location = New System.Drawing.Point(131, 164)
        Me.edWebMVideoMinQuantizer.Name = "edWebMVideoMinQuantizer"
        Me.edWebMVideoMinQuantizer.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoMinQuantizer.TabIndex = 26
        Me.edWebMVideoMinQuantizer.Text = "-1"
        '
        'label86
        '
        Me.label86.AutoSize = true
        Me.label86.Location = New System.Drawing.Point(15, 167)
        Me.label86.Name = "label86"
        Me.label86.Size = New System.Drawing.Size(88, 13)
        Me.label86.TabIndex = 25
        Me.label86.Text = "Minimal quantizer"
        '
        'label79
        '
        Me.label79.AutoSize = true
        Me.label79.Location = New System.Drawing.Point(15, 25)
        Me.label79.Name = "label79"
        Me.label79.Size = New System.Drawing.Size(47, 13)
        Me.label79.TabIndex = 24
        Me.label79.Text = "Encoder"
        '
        'cbWebMVideoEncoder
        '
        Me.cbWebMVideoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWebMVideoEncoder.FormattingEnabled = true
        Me.cbWebMVideoEncoder.Items.AddRange(New Object() {"VP8", "VP9"})
        Me.cbWebMVideoEncoder.Location = New System.Drawing.Point(131, 22)
        Me.cbWebMVideoEncoder.Name = "cbWebMVideoEncoder"
        Me.cbWebMVideoEncoder.Size = New System.Drawing.Size(84, 21)
        Me.cbWebMVideoEncoder.TabIndex = 23
        '
        'cbWebMVideoQualityMode
        '
        Me.cbWebMVideoQualityMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWebMVideoQualityMode.FormattingEnabled = true
        Me.cbWebMVideoQualityMode.Items.AddRange(New Object() {"Realtime", "Good", "Best (BETA)"})
        Me.cbWebMVideoQualityMode.Location = New System.Drawing.Point(131, 131)
        Me.cbWebMVideoQualityMode.Name = "cbWebMVideoQualityMode"
        Me.cbWebMVideoQualityMode.Size = New System.Drawing.Size(84, 21)
        Me.cbWebMVideoQualityMode.TabIndex = 22
        '
        'label63
        '
        Me.label63.AutoSize = true
        Me.label63.Location = New System.Drawing.Point(15, 134)
        Me.label63.Name = "label63"
        Me.label63.Size = New System.Drawing.Size(68, 13)
        Me.label63.TabIndex = 21
        Me.label63.Text = "Quality mode"
        '
        'label179
        '
        Me.label179.AutoSize = true
        Me.label179.Location = New System.Drawing.Point(221, 52)
        Me.label179.Name = "label179"
        Me.label179.Size = New System.Drawing.Size(31, 13)
        Me.label179.TabIndex = 20
        Me.label179.Text = "Kbps"
        '
        'cbWebMVideoEndUsageMode
        '
        Me.cbWebMVideoEndUsageMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWebMVideoEndUsageMode.FormattingEnabled = true
        Me.cbWebMVideoEndUsageMode.Items.AddRange(New Object() {"Default", "CBR", "VBR"})
        Me.cbWebMVideoEndUsageMode.Location = New System.Drawing.Point(131, 102)
        Me.cbWebMVideoEndUsageMode.Name = "cbWebMVideoEndUsageMode"
        Me.cbWebMVideoEndUsageMode.Size = New System.Drawing.Size(84, 21)
        Me.cbWebMVideoEndUsageMode.TabIndex = 19
        '
        'label178
        '
        Me.label178.AutoSize = true
        Me.label178.Location = New System.Drawing.Point(15, 105)
        Me.label178.Name = "label178"
        Me.label178.Size = New System.Drawing.Size(87, 13)
        Me.label178.TabIndex = 18
        Me.label178.Text = "End usage mode"
        '
        'edWebMVideoThreadCount
        '
        Me.edWebMVideoThreadCount.Location = New System.Drawing.Point(131, 76)
        Me.edWebMVideoThreadCount.Name = "edWebMVideoThreadCount"
        Me.edWebMVideoThreadCount.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoThreadCount.TabIndex = 17
        Me.edWebMVideoThreadCount.Text = "2"
        '
        'label173
        '
        Me.label173.AutoSize = true
        Me.label173.Location = New System.Drawing.Point(15, 79)
        Me.label173.Name = "label173"
        Me.label173.Size = New System.Drawing.Size(71, 13)
        Me.label173.TabIndex = 16
        Me.label173.Text = "Thread count"
        '
        'edWebMVideoBitrate
        '
        Me.edWebMVideoBitrate.Location = New System.Drawing.Point(131, 49)
        Me.edWebMVideoBitrate.Name = "edWebMVideoBitrate"
        Me.edWebMVideoBitrate.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoBitrate.TabIndex = 15
        Me.edWebMVideoBitrate.Text = "2000"
        '
        'label172
        '
        Me.label172.AutoSize = true
        Me.label172.Location = New System.Drawing.Point(15, 52)
        Me.label172.Name = "label172"
        Me.label172.Size = New System.Drawing.Size(37, 13)
        Me.label172.TabIndex = 14
        Me.label172.Text = "Bitrate"
        '
        'tabPage60
        '
        Me.tabPage60.Controls.Add(Me.tbWebMAudioQuality)
        Me.tabPage60.Controls.Add(Me.label223)
        Me.tabPage60.Location = New System.Drawing.Point(4, 22)
        Me.tabPage60.Name = "tabPage60"
        Me.tabPage60.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage60.Size = New System.Drawing.Size(264, 361)
        Me.tabPage60.TabIndex = 1
        Me.tabPage60.Text = "Audio (Vorbis)"
        Me.tabPage60.UseVisualStyleBackColor = true
        '
        'tbWebMAudioQuality
        '
        Me.tbWebMAudioQuality.Location = New System.Drawing.Point(86, 20)
        Me.tbWebMAudioQuality.Maximum = 100
        Me.tbWebMAudioQuality.Minimum = -10
        Me.tbWebMAudioQuality.Name = "tbWebMAudioQuality"
        Me.tbWebMAudioQuality.Size = New System.Drawing.Size(125, 45)
        Me.tbWebMAudioQuality.TabIndex = 41
        Me.tbWebMAudioQuality.TickFrequency = 5
        Me.tbWebMAudioQuality.Value = 80
        '
        'label223
        '
        Me.label223.AutoSize = true
        Me.label223.Location = New System.Drawing.Point(15, 20)
        Me.label223.Name = "label223"
        Me.label223.Size = New System.Drawing.Size(39, 13)
        Me.label223.TabIndex = 39
        Me.label223.Text = "Quality"
        '
        'tabPage61
        '
        Me.tabPage61.Controls.Add(Me.cbWebMVideoAutoAltRef)
        Me.tabPage61.Controls.Add(Me.label98)
        Me.tabPage61.Controls.Add(Me.edWebMVideoDecoderOptimalBuffer)
        Me.tabPage61.Controls.Add(Me.label97)
        Me.tabPage61.Controls.Add(Me.edWebMVideoDecoderInitialBuffer)
        Me.tabPage61.Controls.Add(Me.label96)
        Me.tabPage61.Controls.Add(Me.edWebMVideoDecoderBufferSize)
        Me.tabPage61.Controls.Add(Me.edWebMVideoOvershootPct)
        Me.tabPage61.Controls.Add(Me.label94)
        Me.tabPage61.Controls.Add(Me.edWebMVideoUndershootPct)
        Me.tabPage61.Controls.Add(Me.label93)
        Me.tabPage61.Controls.Add(Me.edWebMVideoLagInFrames)
        Me.tabPage61.Controls.Add(Me.label85)
        Me.tabPage61.Controls.Add(Me.edWebMVideoSpatialDownThreshold)
        Me.tabPage61.Controls.Add(Me.label84)
        Me.tabPage61.Controls.Add(Me.edWebMVideoSpatialUpThreshold)
        Me.tabPage61.Controls.Add(Me.label83)
        Me.tabPage61.Controls.Add(Me.cbWebMVideoSpatialResamplingAllowed)
        Me.tabPage61.Controls.Add(Me.edWebMVideoDropFrameThreshold)
        Me.tabPage61.Controls.Add(Me.label82)
        Me.tabPage61.Controls.Add(Me.cbWebMVideoErrorResilent)
        Me.tabPage61.Location = New System.Drawing.Point(4, 22)
        Me.tabPage61.Name = "tabPage61"
        Me.tabPage61.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage61.Size = New System.Drawing.Size(264, 361)
        Me.tabPage61.TabIndex = 2
        Me.tabPage61.Text = "Video (VP8/VP9) - Advanced"
        Me.tabPage61.UseVisualStyleBackColor = true
        '
        'cbWebMVideoAutoAltRef
        '
        Me.cbWebMVideoAutoAltRef.AutoSize = true
        Me.cbWebMVideoAutoAltRef.Location = New System.Drawing.Point(20, 328)
        Me.cbWebMVideoAutoAltRef.Name = "cbWebMVideoAutoAltRef"
        Me.cbWebMVideoAutoAltRef.Size = New System.Drawing.Size(77, 17)
        Me.cbWebMVideoAutoAltRef.TabIndex = 48
        Me.cbWebMVideoAutoAltRef.Text = "Auto alt ref"
        Me.cbWebMVideoAutoAltRef.UseVisualStyleBackColor = true
        '
        'label98
        '
        Me.label98.AutoSize = true
        Me.label98.Location = New System.Drawing.Point(17, 281)
        Me.label98.Name = "label98"
        Me.label98.Size = New System.Drawing.Size(114, 13)
        Me.label98.TabIndex = 47
        Me.label98.Text = "Decoder optimal buffer"
        '
        'edWebMVideoDecoderOptimalBuffer
        '
        Me.edWebMVideoDecoderOptimalBuffer.Location = New System.Drawing.Point(133, 278)
        Me.edWebMVideoDecoderOptimalBuffer.Name = "edWebMVideoDecoderOptimalBuffer"
        Me.edWebMVideoDecoderOptimalBuffer.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoDecoderOptimalBuffer.TabIndex = 46
        Me.edWebMVideoDecoderOptimalBuffer.Text = "-1"
        '
        'label97
        '
        Me.label97.AutoSize = true
        Me.label97.Location = New System.Drawing.Point(17, 255)
        Me.label97.Name = "label97"
        Me.label97.Size = New System.Drawing.Size(104, 13)
        Me.label97.TabIndex = 45
        Me.label97.Text = "Decoder initial buffer"
        '
        'edWebMVideoDecoderInitialBuffer
        '
        Me.edWebMVideoDecoderInitialBuffer.Location = New System.Drawing.Point(133, 252)
        Me.edWebMVideoDecoderInitialBuffer.Name = "edWebMVideoDecoderInitialBuffer"
        Me.edWebMVideoDecoderInitialBuffer.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoDecoderInitialBuffer.TabIndex = 44
        Me.edWebMVideoDecoderInitialBuffer.Text = "-1"
        '
        'label96
        '
        Me.label96.AutoSize = true
        Me.label96.Location = New System.Drawing.Point(17, 229)
        Me.label96.Name = "label96"
        Me.label96.Size = New System.Drawing.Size(99, 13)
        Me.label96.TabIndex = 43
        Me.label96.Text = "Decoder buffer size"
        '
        'edWebMVideoDecoderBufferSize
        '
        Me.edWebMVideoDecoderBufferSize.Location = New System.Drawing.Point(133, 226)
        Me.edWebMVideoDecoderBufferSize.Name = "edWebMVideoDecoderBufferSize"
        Me.edWebMVideoDecoderBufferSize.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoDecoderBufferSize.TabIndex = 42
        Me.edWebMVideoDecoderBufferSize.Text = "-1"
        '
        'edWebMVideoOvershootPct
        '
        Me.edWebMVideoOvershootPct.Location = New System.Drawing.Point(133, 193)
        Me.edWebMVideoOvershootPct.Name = "edWebMVideoOvershootPct"
        Me.edWebMVideoOvershootPct.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoOvershootPct.TabIndex = 41
        Me.edWebMVideoOvershootPct.Text = "-1"
        '
        'label94
        '
        Me.label94.AutoSize = true
        Me.label94.Location = New System.Drawing.Point(17, 196)
        Me.label94.Name = "label94"
        Me.label94.Size = New System.Drawing.Size(74, 13)
        Me.label94.TabIndex = 40
        Me.label94.Text = "Overshoot pct"
        '
        'edWebMVideoUndershootPct
        '
        Me.edWebMVideoUndershootPct.Location = New System.Drawing.Point(133, 167)
        Me.edWebMVideoUndershootPct.Name = "edWebMVideoUndershootPct"
        Me.edWebMVideoUndershootPct.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoUndershootPct.TabIndex = 39
        Me.edWebMVideoUndershootPct.Text = "-1"
        '
        'label93
        '
        Me.label93.AutoSize = true
        Me.label93.Location = New System.Drawing.Point(17, 170)
        Me.label93.Name = "label93"
        Me.label93.Size = New System.Drawing.Size(80, 13)
        Me.label93.TabIndex = 38
        Me.label93.Text = "Undershoot pct"
        '
        'edWebMVideoLagInFrames
        '
        Me.edWebMVideoLagInFrames.Location = New System.Drawing.Point(133, 141)
        Me.edWebMVideoLagInFrames.Name = "edWebMVideoLagInFrames"
        Me.edWebMVideoLagInFrames.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoLagInFrames.TabIndex = 37
        Me.edWebMVideoLagInFrames.Text = "-1"
        '
        'label85
        '
        Me.label85.AutoSize = true
        Me.label85.Location = New System.Drawing.Point(17, 144)
        Me.label85.Name = "label85"
        Me.label85.Size = New System.Drawing.Size(70, 13)
        Me.label85.TabIndex = 36
        Me.label85.Text = "Lag in frames"
        '
        'edWebMVideoSpatialDownThreshold
        '
        Me.edWebMVideoSpatialDownThreshold.Location = New System.Drawing.Point(133, 103)
        Me.edWebMVideoSpatialDownThreshold.Name = "edWebMVideoSpatialDownThreshold"
        Me.edWebMVideoSpatialDownThreshold.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoSpatialDownThreshold.TabIndex = 35
        Me.edWebMVideoSpatialDownThreshold.Text = "-1"
        '
        'label84
        '
        Me.label84.AutoSize = true
        Me.label84.Location = New System.Drawing.Point(41, 106)
        Me.label84.Name = "label84"
        Me.label84.Size = New System.Drawing.Size(81, 13)
        Me.label84.TabIndex = 34
        Me.label84.Text = "Down threshold"
        '
        'edWebMVideoSpatialUpThreshold
        '
        Me.edWebMVideoSpatialUpThreshold.Location = New System.Drawing.Point(133, 74)
        Me.edWebMVideoSpatialUpThreshold.Name = "edWebMVideoSpatialUpThreshold"
        Me.edWebMVideoSpatialUpThreshold.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoSpatialUpThreshold.TabIndex = 33
        Me.edWebMVideoSpatialUpThreshold.Text = "-1"
        '
        'label83
        '
        Me.label83.AutoSize = true
        Me.label83.Location = New System.Drawing.Point(41, 77)
        Me.label83.Name = "label83"
        Me.label83.Size = New System.Drawing.Size(67, 13)
        Me.label83.TabIndex = 32
        Me.label83.Text = "Up threshold"
        '
        'cbWebMVideoSpatialResamplingAllowed
        '
        Me.cbWebMVideoSpatialResamplingAllowed.AutoSize = true
        Me.cbWebMVideoSpatialResamplingAllowed.Location = New System.Drawing.Point(20, 49)
        Me.cbWebMVideoSpatialResamplingAllowed.Name = "cbWebMVideoSpatialResamplingAllowed"
        Me.cbWebMVideoSpatialResamplingAllowed.Size = New System.Drawing.Size(111, 17)
        Me.cbWebMVideoSpatialResamplingAllowed.TabIndex = 31
        Me.cbWebMVideoSpatialResamplingAllowed.Text = "Spatial resampling"
        Me.cbWebMVideoSpatialResamplingAllowed.UseVisualStyleBackColor = true
        '
        'edWebMVideoDropFrameThreshold
        '
        Me.edWebMVideoDropFrameThreshold.Location = New System.Drawing.Point(133, 16)
        Me.edWebMVideoDropFrameThreshold.Name = "edWebMVideoDropFrameThreshold"
        Me.edWebMVideoDropFrameThreshold.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoDropFrameThreshold.TabIndex = 30
        Me.edWebMVideoDropFrameThreshold.Text = "-1"
        '
        'label82
        '
        Me.label82.AutoSize = true
        Me.label82.Location = New System.Drawing.Point(17, 19)
        Me.label82.Name = "label82"
        Me.label82.Size = New System.Drawing.Size(105, 13)
        Me.label82.TabIndex = 29
        Me.label82.Text = "Drop frame threshold"
        '
        'cbWebMVideoErrorResilent
        '
        Me.cbWebMVideoErrorResilent.AutoSize = true
        Me.cbWebMVideoErrorResilent.Location = New System.Drawing.Point(158, 328)
        Me.cbWebMVideoErrorResilent.Name = "cbWebMVideoErrorResilent"
        Me.cbWebMVideoErrorResilent.Size = New System.Drawing.Size(84, 17)
        Me.cbWebMVideoErrorResilent.TabIndex = 28
        Me.cbWebMVideoErrorResilent.Text = "Error resilent"
        Me.cbWebMVideoErrorResilent.UseVisualStyleBackColor = true
        '
        'tabPage63
        '
        Me.tabPage63.Controls.Add(Me.label112)
        Me.tabPage63.Controls.Add(Me.edWebMVideoTokenPartition)
        Me.tabPage63.Controls.Add(Me.label111)
        Me.tabPage63.Controls.Add(Me.edWebMVideoDecimate)
        Me.tabPage63.Controls.Add(Me.label110)
        Me.tabPage63.Controls.Add(Me.edWebMVideoStaticThreshold)
        Me.tabPage63.Controls.Add(Me.edWebMVideoCPUUsed)
        Me.tabPage63.Controls.Add(Me.label109)
        Me.tabPage63.Controls.Add(Me.edWebMVideoFixedKeyframeInterval)
        Me.tabPage63.Controls.Add(Me.label108)
        Me.tabPage63.Controls.Add(Me.edWebMVideoARNRType)
        Me.tabPage63.Controls.Add(Me.label103)
        Me.tabPage63.Controls.Add(Me.edWebMVideoARNRStrenght)
        Me.tabPage63.Controls.Add(Me.label102)
        Me.tabPage63.Controls.Add(Me.edWebMVideoARNRMaxFrames)
        Me.tabPage63.Controls.Add(Me.label101)
        Me.tabPage63.Location = New System.Drawing.Point(4, 22)
        Me.tabPage63.Name = "tabPage63"
        Me.tabPage63.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage63.Size = New System.Drawing.Size(264, 361)
        Me.tabPage63.TabIndex = 3
        Me.tabPage63.Text = "Video (VP8/VP9) - Advanced 2"
        Me.tabPage63.UseVisualStyleBackColor = true
        '
        'label112
        '
        Me.label112.AutoSize = true
        Me.label112.Location = New System.Drawing.Point(17, 219)
        Me.label112.Name = "label112"
        Me.label112.Size = New System.Drawing.Size(78, 13)
        Me.label112.TabIndex = 15
        Me.label112.Text = "Token partition"
        '
        'edWebMVideoTokenPartition
        '
        Me.edWebMVideoTokenPartition.Location = New System.Drawing.Point(133, 216)
        Me.edWebMVideoTokenPartition.Name = "edWebMVideoTokenPartition"
        Me.edWebMVideoTokenPartition.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoTokenPartition.TabIndex = 14
        Me.edWebMVideoTokenPartition.Text = "-1"
        '
        'label111
        '
        Me.label111.AutoSize = true
        Me.label111.Location = New System.Drawing.Point(17, 191)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(52, 13)
        Me.label111.TabIndex = 13
        Me.label111.Text = "Decimate"
        '
        'edWebMVideoDecimate
        '
        Me.edWebMVideoDecimate.Location = New System.Drawing.Point(133, 188)
        Me.edWebMVideoDecimate.Name = "edWebMVideoDecimate"
        Me.edWebMVideoDecimate.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoDecimate.TabIndex = 12
        Me.edWebMVideoDecimate.Text = "-1"
        '
        'label110
        '
        Me.label110.AutoSize = true
        Me.label110.Location = New System.Drawing.Point(17, 163)
        Me.label110.Name = "label110"
        Me.label110.Size = New System.Drawing.Size(80, 13)
        Me.label110.TabIndex = 11
        Me.label110.Text = "Static threshold"
        '
        'edWebMVideoStaticThreshold
        '
        Me.edWebMVideoStaticThreshold.Location = New System.Drawing.Point(133, 160)
        Me.edWebMVideoStaticThreshold.Name = "edWebMVideoStaticThreshold"
        Me.edWebMVideoStaticThreshold.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoStaticThreshold.TabIndex = 10
        Me.edWebMVideoStaticThreshold.Text = "-1"
        '
        'edWebMVideoCPUUsed
        '
        Me.edWebMVideoCPUUsed.Location = New System.Drawing.Point(133, 132)
        Me.edWebMVideoCPUUsed.Name = "edWebMVideoCPUUsed"
        Me.edWebMVideoCPUUsed.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoCPUUsed.TabIndex = 9
        Me.edWebMVideoCPUUsed.Text = "-17"
        '
        'label109
        '
        Me.label109.AutoSize = true
        Me.label109.Location = New System.Drawing.Point(17, 135)
        Me.label109.Name = "label109"
        Me.label109.Size = New System.Drawing.Size(55, 13)
        Me.label109.TabIndex = 8
        Me.label109.Text = "CPU used"
        '
        'edWebMVideoFixedKeyframeInterval
        '
        Me.edWebMVideoFixedKeyframeInterval.Location = New System.Drawing.Point(133, 104)
        Me.edWebMVideoFixedKeyframeInterval.Name = "edWebMVideoFixedKeyframeInterval"
        Me.edWebMVideoFixedKeyframeInterval.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoFixedKeyframeInterval.TabIndex = 7
        Me.edWebMVideoFixedKeyframeInterval.Text = "-1"
        '
        'label108
        '
        Me.label108.AutoSize = true
        Me.label108.Location = New System.Drawing.Point(17, 107)
        Me.label108.Name = "label108"
        Me.label108.Size = New System.Drawing.Size(115, 13)
        Me.label108.TabIndex = 6
        Me.label108.Text = "Fixed keyframe interval"
        '
        'edWebMVideoARNRType
        '
        Me.edWebMVideoARNRType.Location = New System.Drawing.Point(133, 68)
        Me.edWebMVideoARNRType.Name = "edWebMVideoARNRType"
        Me.edWebMVideoARNRType.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoARNRType.TabIndex = 5
        Me.edWebMVideoARNRType.Text = "-1"
        '
        'label103
        '
        Me.label103.AutoSize = true
        Me.label103.Location = New System.Drawing.Point(17, 71)
        Me.label103.Name = "label103"
        Me.label103.Size = New System.Drawing.Size(61, 13)
        Me.label103.TabIndex = 4
        Me.label103.Text = "ARNR type"
        '
        'edWebMVideoARNRStrenght
        '
        Me.edWebMVideoARNRStrenght.Location = New System.Drawing.Point(133, 42)
        Me.edWebMVideoARNRStrenght.Name = "edWebMVideoARNRStrenght"
        Me.edWebMVideoARNRStrenght.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoARNRStrenght.TabIndex = 3
        Me.edWebMVideoARNRStrenght.Text = "-1"
        '
        'label102
        '
        Me.label102.AutoSize = true
        Me.label102.Location = New System.Drawing.Point(17, 45)
        Me.label102.Name = "label102"
        Me.label102.Size = New System.Drawing.Size(79, 13)
        Me.label102.TabIndex = 2
        Me.label102.Text = "ARNR strength"
        '
        'edWebMVideoARNRMaxFrames
        '
        Me.edWebMVideoARNRMaxFrames.Location = New System.Drawing.Point(133, 16)
        Me.edWebMVideoARNRMaxFrames.Name = "edWebMVideoARNRMaxFrames"
        Me.edWebMVideoARNRMaxFrames.Size = New System.Drawing.Size(84, 20)
        Me.edWebMVideoARNRMaxFrames.TabIndex = 1
        Me.edWebMVideoARNRMaxFrames.Text = "-1"
        '
        'label101
        '
        Me.label101.AutoSize = true
        Me.label101.Location = New System.Drawing.Point(17, 19)
        Me.label101.Name = "label101"
        Me.label101.Size = New System.Drawing.Size(94, 13)
        Me.label101.TabIndex = 0
        Me.label101.Text = "ARNR max frames"
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.tabControl16)
        Me.TabPage15.Controls.Add(Me.cbFFOutputFormat)
        Me.TabPage15.Controls.Add(Me.label267)
        Me.TabPage15.Location = New System.Drawing.Point(4, 22)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(284, 399)
        Me.TabPage15.TabIndex = 12
        Me.TabPage15.Text = "FFMPEG (DLL)"
        Me.TabPage15.UseVisualStyleBackColor = true
        '
        'tabControl16
        '
        Me.tabControl16.Controls.Add(Me.tabPage62)
        Me.tabControl16.Controls.Add(Me.tabPage64)
        Me.tabControl16.Controls.Add(Me.tabPage65)
        Me.tabControl16.Location = New System.Drawing.Point(2, 41)
        Me.tabControl16.Name = "tabControl16"
        Me.tabControl16.SelectedIndex = 0
        Me.tabControl16.Size = New System.Drawing.Size(281, 344)
        Me.tabControl16.TabIndex = 11
        '
        'tabPage62
        '
        Me.tabPage62.Controls.Add(Me.textBox3)
        Me.tabPage62.Controls.Add(Me.textBox4)
        Me.tabPage62.Location = New System.Drawing.Point(4, 22)
        Me.tabPage62.Name = "tabPage62"
        Me.tabPage62.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage62.Size = New System.Drawing.Size(273, 318)
        Me.tabPage62.TabIndex = 0
        Me.tabPage62.Text = "About"
        Me.tabPage62.UseVisualStyleBackColor = true
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(6, 292)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(261, 20)
        Me.textBox3.TabIndex = 1
        Me.textBox3.Text = "http://www.ffmpeg.org"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(6, 6)
        Me.textBox4.Multiline = true
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(261, 280)
        Me.textBox4.TabIndex = 0
        Me.textBox4.Text = "FFMPEG wrapper for VisioForge SDK's. MPEG-1/2 and FLV codecs supported. "
        '
        'tabPage64
        '
        Me.tabPage64.Controls.Add(Me.cbFFVideoInterlace)
        Me.tabPage64.Controls.Add(Me.edFFVideoBitrateMax)
        Me.tabPage64.Controls.Add(Me.label218)
        Me.tabPage64.Controls.Add(Me.edFFVBVBufferSize)
        Me.tabPage64.Controls.Add(Me.label224)
        Me.tabPage64.Controls.Add(Me.label225)
        Me.tabPage64.Controls.Add(Me.edFFVideoBitrateMin)
        Me.tabPage64.Controls.Add(Me.label226)
        Me.tabPage64.Controls.Add(Me.label227)
        Me.tabPage64.Controls.Add(Me.edFFTargetBitrate)
        Me.tabPage64.Controls.Add(Me.label228)
        Me.tabPage64.Controls.Add(Me.cbFFConstaint)
        Me.tabPage64.Controls.Add(Me.label255)
        Me.tabPage64.Controls.Add(Me.cbFFAspectRatio)
        Me.tabPage64.Controls.Add(Me.label257)
        Me.tabPage64.Controls.Add(Me.edFFVideoHeight)
        Me.tabPage64.Controls.Add(Me.label258)
        Me.tabPage64.Controls.Add(Me.edFFVideoWidth)
        Me.tabPage64.Controls.Add(Me.label259)
        Me.tabPage64.Location = New System.Drawing.Point(4, 22)
        Me.tabPage64.Name = "tabPage64"
        Me.tabPage64.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage64.Size = New System.Drawing.Size(273, 318)
        Me.tabPage64.TabIndex = 2
        Me.tabPage64.Text = "Video"
        Me.tabPage64.UseVisualStyleBackColor = true
        '
        'cbFFVideoInterlace
        '
        Me.cbFFVideoInterlace.AutoSize = true
        Me.cbFFVideoInterlace.Location = New System.Drawing.Point(15, 184)
        Me.cbFFVideoInterlace.Name = "cbFFVideoInterlace"
        Me.cbFFVideoInterlace.Size = New System.Drawing.Size(96, 17)
        Me.cbFFVideoInterlace.TabIndex = 95
        Me.cbFFVideoInterlace.Text = "Interlace video"
        Me.cbFFVideoInterlace.UseVisualStyleBackColor = true
        '
        'edFFVideoBitrateMax
        '
        Me.edFFVideoBitrateMax.Location = New System.Drawing.Point(178, 127)
        Me.edFFVideoBitrateMax.Name = "edFFVideoBitrateMax"
        Me.edFFVideoBitrateMax.Size = New System.Drawing.Size(49, 20)
        Me.edFFVideoBitrateMax.TabIndex = 94
        Me.edFFVideoBitrateMax.Text = "9000"
        '
        'label218
        '
        Me.label218.AutoSize = true
        Me.label218.Location = New System.Drawing.Point(159, 130)
        Me.label218.Name = "label218"
        Me.label218.Size = New System.Drawing.Size(16, 13)
        Me.label218.TabIndex = 93
        Me.label218.Text = "to"
        '
        'edFFVBVBufferSize
        '
        Me.edFFVBVBufferSize.Location = New System.Drawing.Point(101, 153)
        Me.edFFVBVBufferSize.Name = "edFFVBVBufferSize"
        Me.edFFVBVBufferSize.Size = New System.Drawing.Size(52, 20)
        Me.edFFVBVBufferSize.TabIndex = 91
        Me.edFFVBVBufferSize.Text = "0"
        '
        'label224
        '
        Me.label224.AutoSize = true
        Me.label224.Location = New System.Drawing.Point(12, 156)
        Me.label224.Name = "label224"
        Me.label224.Size = New System.Drawing.Size(82, 13)
        Me.label224.TabIndex = 90
        Me.label224.Text = "VBV Buffer Size"
        '
        'label225
        '
        Me.label225.AutoSize = true
        Me.label225.Location = New System.Drawing.Point(227, 130)
        Me.label225.Name = "label225"
        Me.label225.Size = New System.Drawing.Size(31, 13)
        Me.label225.TabIndex = 89
        Me.label225.Text = "Kbps"
        '
        'edFFVideoBitrateMin
        '
        Me.edFFVideoBitrateMin.Location = New System.Drawing.Point(101, 127)
        Me.edFFVideoBitrateMin.Name = "edFFVideoBitrateMin"
        Me.edFFVideoBitrateMin.Size = New System.Drawing.Size(52, 20)
        Me.edFFVideoBitrateMin.TabIndex = 88
        Me.edFFVideoBitrateMin.Text = "0"
        '
        'label226
        '
        Me.label226.AutoSize = true
        Me.label226.Location = New System.Drawing.Point(12, 130)
        Me.label226.Name = "label226"
        Me.label226.Size = New System.Drawing.Size(72, 13)
        Me.label226.TabIndex = 87
        Me.label226.Text = "Bitrate Range"
        '
        'label227
        '
        Me.label227.AutoSize = true
        Me.label227.Location = New System.Drawing.Point(159, 103)
        Me.label227.Name = "label227"
        Me.label227.Size = New System.Drawing.Size(31, 13)
        Me.label227.TabIndex = 86
        Me.label227.Text = "Kbps"
        '
        'edFFTargetBitrate
        '
        Me.edFFTargetBitrate.Location = New System.Drawing.Point(101, 101)
        Me.edFFTargetBitrate.Name = "edFFTargetBitrate"
        Me.edFFTargetBitrate.Size = New System.Drawing.Size(52, 20)
        Me.edFFTargetBitrate.TabIndex = 85
        Me.edFFTargetBitrate.Text = "6000"
        '
        'label228
        '
        Me.label228.AutoSize = true
        Me.label228.Location = New System.Drawing.Point(12, 103)
        Me.label228.Name = "label228"
        Me.label228.Size = New System.Drawing.Size(70, 13)
        Me.label228.TabIndex = 84
        Me.label228.Text = "Target bitrate"
        '
        'cbFFConstaint
        '
        Me.cbFFConstaint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFConstaint.FormattingEnabled = true
        Me.cbFFConstaint.Items.AddRange(New Object() {"None", "PAL", "NTSC", "Film"})
        Me.cbFFConstaint.Location = New System.Drawing.Point(101, 72)
        Me.cbFFConstaint.Name = "cbFFConstaint"
        Me.cbFFConstaint.Size = New System.Drawing.Size(125, 21)
        Me.cbFFConstaint.TabIndex = 81
        '
        'label255
        '
        Me.label255.AutoSize = true
        Me.label255.Location = New System.Drawing.Point(12, 75)
        Me.label255.Name = "label255"
        Me.label255.Size = New System.Drawing.Size(54, 13)
        Me.label255.TabIndex = 80
        Me.label255.Text = "Constraint"
        '
        'cbFFAspectRatio
        '
        Me.cbFFAspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFAspectRatio.FormattingEnabled = true
        Me.cbFFAspectRatio.Items.AddRange(New Object() {"Default", "1:1", "4:3", "16:9"})
        Me.cbFFAspectRatio.Location = New System.Drawing.Point(101, 42)
        Me.cbFFAspectRatio.Name = "cbFFAspectRatio"
        Me.cbFFAspectRatio.Size = New System.Drawing.Size(125, 21)
        Me.cbFFAspectRatio.TabIndex = 77
        '
        'label257
        '
        Me.label257.AutoSize = true
        Me.label257.Location = New System.Drawing.Point(12, 45)
        Me.label257.Name = "label257"
        Me.label257.Size = New System.Drawing.Size(63, 13)
        Me.label257.TabIndex = 76
        Me.label257.Text = "Aspect ratio"
        '
        'edFFVideoHeight
        '
        Me.edFFVideoHeight.Location = New System.Drawing.Point(161, 14)
        Me.edFFVideoHeight.Name = "edFFVideoHeight"
        Me.edFFVideoHeight.Size = New System.Drawing.Size(36, 20)
        Me.edFFVideoHeight.TabIndex = 75
        Me.edFFVideoHeight.Text = "576"
        '
        'label258
        '
        Me.label258.AutoSize = true
        Me.label258.Location = New System.Drawing.Point(143, 16)
        Me.label258.Name = "label258"
        Me.label258.Size = New System.Drawing.Size(12, 13)
        Me.label258.TabIndex = 74
        Me.label258.Text = "x"
        '
        'edFFVideoWidth
        '
        Me.edFFVideoWidth.Location = New System.Drawing.Point(101, 14)
        Me.edFFVideoWidth.Name = "edFFVideoWidth"
        Me.edFFVideoWidth.Size = New System.Drawing.Size(36, 20)
        Me.edFFVideoWidth.TabIndex = 73
        Me.edFFVideoWidth.Text = "768"
        '
        'label259
        '
        Me.label259.AutoSize = true
        Me.label259.Location = New System.Drawing.Point(12, 16)
        Me.label259.Name = "label259"
        Me.label259.Size = New System.Drawing.Size(57, 13)
        Me.label259.TabIndex = 72
        Me.label259.Text = "Resolution"
        '
        'tabPage65
        '
        Me.tabPage65.Controls.Add(Me.label261)
        Me.tabPage65.Controls.Add(Me.label262)
        Me.tabPage65.Controls.Add(Me.cbFFAudioBitrate)
        Me.tabPage65.Controls.Add(Me.label263)
        Me.tabPage65.Controls.Add(Me.cbFFAudioChannels)
        Me.tabPage65.Controls.Add(Me.label264)
        Me.tabPage65.Controls.Add(Me.cbFFAudioSampleRate)
        Me.tabPage65.Controls.Add(Me.label265)
        Me.tabPage65.Location = New System.Drawing.Point(4, 22)
        Me.tabPage65.Name = "tabPage65"
        Me.tabPage65.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage65.Size = New System.Drawing.Size(273, 318)
        Me.tabPage65.TabIndex = 3
        Me.tabPage65.Text = "Audio"
        Me.tabPage65.UseVisualStyleBackColor = true
        '
        'label261
        '
        Me.label261.AutoSize = true
        Me.label261.Location = New System.Drawing.Point(233, 16)
        Me.label261.Name = "label261"
        Me.label261.Size = New System.Drawing.Size(20, 13)
        Me.label261.TabIndex = 91
        Me.label261.Text = "Hz"
        '
        'label262
        '
        Me.label262.AutoSize = true
        Me.label262.Location = New System.Drawing.Point(233, 74)
        Me.label262.Name = "label262"
        Me.label262.Size = New System.Drawing.Size(31, 13)
        Me.label262.TabIndex = 90
        Me.label262.Text = "Kbps"
        '
        'cbFFAudioBitrate
        '
        Me.cbFFAudioBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFAudioBitrate.FormattingEnabled = true
        Me.cbFFAudioBitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.cbFFAudioBitrate.Location = New System.Drawing.Point(101, 71)
        Me.cbFFAudioBitrate.Name = "cbFFAudioBitrate"
        Me.cbFFAudioBitrate.Size = New System.Drawing.Size(125, 21)
        Me.cbFFAudioBitrate.TabIndex = 11
        '
        'label263
        '
        Me.label263.AutoSize = true
        Me.label263.Location = New System.Drawing.Point(12, 74)
        Me.label263.Name = "label263"
        Me.label263.Size = New System.Drawing.Size(37, 13)
        Me.label263.TabIndex = 10
        Me.label263.Text = "Bitrate"
        '
        'cbFFAudioChannels
        '
        Me.cbFFAudioChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFAudioChannels.FormattingEnabled = true
        Me.cbFFAudioChannels.Items.AddRange(New Object() {"2", "1"})
        Me.cbFFAudioChannels.Location = New System.Drawing.Point(101, 42)
        Me.cbFFAudioChannels.Name = "cbFFAudioChannels"
        Me.cbFFAudioChannels.Size = New System.Drawing.Size(125, 21)
        Me.cbFFAudioChannels.TabIndex = 9
        '
        'label264
        '
        Me.label264.AutoSize = true
        Me.label264.Location = New System.Drawing.Point(12, 45)
        Me.label264.Name = "label264"
        Me.label264.Size = New System.Drawing.Size(51, 13)
        Me.label264.TabIndex = 8
        Me.label264.Text = "Channels"
        '
        'cbFFAudioSampleRate
        '
        Me.cbFFAudioSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFAudioSampleRate.FormattingEnabled = true
        Me.cbFFAudioSampleRate.Items.AddRange(New Object() {"48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbFFAudioSampleRate.Location = New System.Drawing.Point(101, 13)
        Me.cbFFAudioSampleRate.Name = "cbFFAudioSampleRate"
        Me.cbFFAudioSampleRate.Size = New System.Drawing.Size(125, 21)
        Me.cbFFAudioSampleRate.TabIndex = 7
        '
        'label265
        '
        Me.label265.AutoSize = true
        Me.label265.Location = New System.Drawing.Point(12, 16)
        Me.label265.Name = "label265"
        Me.label265.Size = New System.Drawing.Size(63, 13)
        Me.label265.TabIndex = 6
        Me.label265.Text = "Sample rate"
        '
        'cbFFOutputFormat
        '
        Me.cbFFOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFOutputFormat.FormattingEnabled = true
        Me.cbFFOutputFormat.Items.AddRange(New Object() {"MPEG-1", "MPEG-1 VCD", "MPEG-2", "MPEG-2 SVCD", "MPEG-2 DVD", "MPEG-2 TS", "Flash Video (FLV)"})
        Me.cbFFOutputFormat.Location = New System.Drawing.Point(84, 14)
        Me.cbFFOutputFormat.Name = "cbFFOutputFormat"
        Me.cbFFOutputFormat.Size = New System.Drawing.Size(195, 21)
        Me.cbFFOutputFormat.TabIndex = 10
        '
        'label267
        '
        Me.label267.AutoSize = true
        Me.label267.Location = New System.Drawing.Point(7, 17)
        Me.label267.Name = "label267"
        Me.label267.Size = New System.Drawing.Size(71, 13)
        Me.label267.TabIndex = 9
        Me.label267.Text = "Output format"
        '
        'TabPage66
        '
        Me.TabPage66.Controls.Add(Me.Label21)
        Me.TabPage66.Controls.Add(Me.tabControl29)
        Me.TabPage66.Controls.Add(Me.cbFFEXEProfile)
        Me.TabPage66.Controls.Add(Me.label467)
        Me.TabPage66.Location = New System.Drawing.Point(4, 22)
        Me.TabPage66.Name = "TabPage66"
        Me.TabPage66.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage66.Size = New System.Drawing.Size(284, 399)
        Me.TabPage66.TabIndex = 17
        Me.TabPage66.Text = "FFMPEG (EXE)"
        Me.TabPage66.UseVisualStyleBackColor = true
        '
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(67, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(155, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "(Settings for network streaming)"
        '
        'tabControl29
        '
        Me.tabControl29.Controls.Add(Me.tabPage129)
        Me.tabControl29.Controls.Add(Me.tabPage132)
        Me.tabControl29.Controls.Add(Me.tabPage130)
        Me.tabControl29.Controls.Add(Me.tabPage131)
        Me.tabControl29.Controls.Add(Me.tabPage133)
        Me.tabControl29.Location = New System.Drawing.Point(3, 48)
        Me.tabControl29.Name = "tabControl29"
        Me.tabControl29.SelectedIndex = 0
        Me.tabControl29.Size = New System.Drawing.Size(281, 351)
        Me.tabControl29.TabIndex = 14
        '
        'tabPage129
        '
        Me.tabPage129.Controls.Add(Me.textBox1)
        Me.tabPage129.Controls.Add(Me.textBox2)
        Me.tabPage129.Location = New System.Drawing.Point(4, 22)
        Me.tabPage129.Name = "tabPage129"
        Me.tabPage129.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage129.Size = New System.Drawing.Size(273, 325)
        Me.tabPage129.TabIndex = 0
        Me.tabPage129.Text = "About"
        Me.tabPage129.UseVisualStyleBackColor = true
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(6, 292)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(261, 20)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "http://www.ffmpeg.org"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(6, 6)
        Me.textBox2.Multiline = true
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(261, 280)
        Me.textBox2.TabIndex = 0
        Me.textBox2.Text = "FFMPEG exe output. All FFMPEG formats available in exe are supported. Custom proc"& _ 
    "essing and effects can be configured using SDK API or FFMPEG commands."
        '
        'tabPage132
        '
        Me.tabPage132.Controls.Add(Me.label468)
        Me.tabPage132.Controls.Add(Me.cbFFEXEOutputFormat)
        Me.tabPage132.Location = New System.Drawing.Point(4, 22)
        Me.tabPage132.Name = "tabPage132"
        Me.tabPage132.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage132.Size = New System.Drawing.Size(273, 325)
        Me.tabPage132.TabIndex = 4
        Me.tabPage132.Text = "Format"
        Me.tabPage132.UseVisualStyleBackColor = true
        '
        'label468
        '
        Me.label468.AutoSize = true
        Me.label468.Location = New System.Drawing.Point(12, 20)
        Me.label468.Name = "label468"
        Me.label468.Size = New System.Drawing.Size(35, 13)
        Me.label468.TabIndex = 1
        Me.label468.Text = "Name"
        '
        'cbFFEXEOutputFormat
        '
        Me.cbFFEXEOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEOutputFormat.FormattingEnabled = true
        Me.cbFFEXEOutputFormat.Items.AddRange(New Object() {"3G2", "3GP", "AC3", "ADTS", "AVI", "DTS", "DTS-HD", "DVD (VOB)", "E-AC3", "F4V", "FLAC", "FLV", "GIF", "H263", "H264", "HEVC", "Matroska", "M4V", "MJPEG", "MOV", "MP2", "MP3", "MP4", "MPEG", "MPEGTS", "MXF", "OGG", "OPUS", "PSP MP4", "RAWVideo", "SVCD", "SWF", "TrueHD", "VC1", "VCD", "WAV", "WebM", "WTV", "WV (WavPack)"})
        Me.cbFFEXEOutputFormat.Location = New System.Drawing.Point(99, 16)
        Me.cbFFEXEOutputFormat.Name = "cbFFEXEOutputFormat"
        Me.cbFFEXEOutputFormat.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEOutputFormat.TabIndex = 0
        '
        'tabPage130
        '
        Me.tabPage130.Controls.Add(Me.tabControl30)
        Me.tabPage130.Location = New System.Drawing.Point(4, 22)
        Me.tabPage130.Name = "tabPage130"
        Me.tabPage130.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage130.Size = New System.Drawing.Size(273, 325)
        Me.tabPage130.TabIndex = 2
        Me.tabPage130.Text = "Video"
        Me.tabPage130.UseVisualStyleBackColor = true
        '
        'tabControl30
        '
        Me.tabControl30.Controls.Add(Me.tabPage134)
        Me.tabControl30.Controls.Add(Me.tabPage137)
        Me.tabControl30.Controls.Add(Me.tabPage136)
        Me.tabControl30.Controls.Add(Me.tabPage135)
        Me.tabControl30.Location = New System.Drawing.Point(6, 6)
        Me.tabControl30.Name = "tabControl30"
        Me.tabControl30.SelectedIndex = 0
        Me.tabControl30.Size = New System.Drawing.Size(261, 316)
        Me.tabControl30.TabIndex = 102
        '
        'tabPage134
        '
        Me.tabPage134.Controls.Add(Me.cbFFEXEVideoConstraint)
        Me.tabPage134.Controls.Add(Me.label482)
        Me.tabPage134.Controls.Add(Me.lbFFEXEVideoNotes)
        Me.tabPage134.Controls.Add(Me.cbFFEXEVideoResolutionLetterbox)
        Me.tabPage134.Controls.Add(Me.label469)
        Me.tabPage134.Controls.Add(Me.cbFFEXEVideoCodec)
        Me.tabPage134.Controls.Add(Me.cbFFEXEVideoResolutionOriginal)
        Me.tabPage134.Controls.Add(Me.cbFFEXEAspectRatio)
        Me.tabPage134.Controls.Add(Me.label459)
        Me.tabPage134.Controls.Add(Me.edFFEXEVideoHeight)
        Me.tabPage134.Controls.Add(Me.label460)
        Me.tabPage134.Controls.Add(Me.edFFEXEVideoWidth)
        Me.tabPage134.Controls.Add(Me.label461)
        Me.tabPage134.Location = New System.Drawing.Point(4, 22)
        Me.tabPage134.Name = "tabPage134"
        Me.tabPage134.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage134.Size = New System.Drawing.Size(253, 290)
        Me.tabPage134.TabIndex = 0
        Me.tabPage134.Text = "Common"
        Me.tabPage134.UseVisualStyleBackColor = true
        '
        'cbFFEXEVideoConstraint
        '
        Me.cbFFEXEVideoConstraint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEVideoConstraint.FormattingEnabled = true
        Me.cbFFEXEVideoConstraint.Items.AddRange(New Object() {"None", "PAL", "NTSC", "Film"})
        Me.cbFFEXEVideoConstraint.Location = New System.Drawing.Point(98, 125)
        Me.cbFFEXEVideoConstraint.Name = "cbFFEXEVideoConstraint"
        Me.cbFFEXEVideoConstraint.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEVideoConstraint.TabIndex = 133
        '
        'label482
        '
        Me.label482.AutoSize = true
        Me.label482.Location = New System.Drawing.Point(9, 128)
        Me.label482.Name = "label482"
        Me.label482.Size = New System.Drawing.Size(54, 13)
        Me.label482.TabIndex = 132
        Me.label482.Text = "Constraint"
        '
        'lbFFEXEVideoNotes
        '
        Me.lbFFEXEVideoNotes.AutoSize = true
        Me.lbFFEXEVideoNotes.Location = New System.Drawing.Point(9, 251)
        Me.lbFFEXEVideoNotes.Name = "lbFFEXEVideoNotes"
        Me.lbFFEXEVideoNotes.Size = New System.Drawing.Size(70, 13)
        Me.lbFFEXEVideoNotes.TabIndex = 131
        Me.lbFFEXEVideoNotes.Text = "Notes: None."
        '
        'cbFFEXEVideoResolutionLetterbox
        '
        Me.cbFFEXEVideoResolutionLetterbox.AutoSize = true
        Me.cbFFEXEVideoResolutionLetterbox.Location = New System.Drawing.Point(98, 70)
        Me.cbFFEXEVideoResolutionLetterbox.Name = "cbFFEXEVideoResolutionLetterbox"
        Me.cbFFEXEVideoResolutionLetterbox.Size = New System.Drawing.Size(88, 17)
        Me.cbFFEXEVideoResolutionLetterbox.TabIndex = 122
        Me.cbFFEXEVideoResolutionLetterbox.Text = "Use letterbox"
        Me.cbFFEXEVideoResolutionLetterbox.UseVisualStyleBackColor = true
        '
        'label469
        '
        Me.label469.AutoSize = true
        Me.label469.Location = New System.Drawing.Point(9, 17)
        Me.label469.Name = "label469"
        Me.label469.Size = New System.Drawing.Size(67, 13)
        Me.label469.TabIndex = 121
        Me.label469.Text = "Codec name"
        '
        'cbFFEXEVideoCodec
        '
        Me.cbFFEXEVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEVideoCodec.FormattingEnabled = true
        Me.cbFFEXEVideoCodec.Items.AddRange(New Object() {"Auto / None", "DV", "FLV1", "GIF", "H263", "H264", "HEVC", "HuffYUV", "JPEG 2000", "JPEG-LS", "LJPEG", "MJPEG", "MPEG-1", "MPEG-2", "MPEG-4", "PNG", "Theora", "VP8", "VP9"})
        Me.cbFFEXEVideoCodec.Location = New System.Drawing.Point(98, 14)
        Me.cbFFEXEVideoCodec.Name = "cbFFEXEVideoCodec"
        Me.cbFFEXEVideoCodec.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEVideoCodec.TabIndex = 120
        '
        'cbFFEXEVideoResolutionOriginal
        '
        Me.cbFFEXEVideoResolutionOriginal.AutoSize = true
        Me.cbFFEXEVideoResolutionOriginal.Checked = true
        Me.cbFFEXEVideoResolutionOriginal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFFEXEVideoResolutionOriginal.Location = New System.Drawing.Point(186, 46)
        Me.cbFFEXEVideoResolutionOriginal.Name = "cbFFEXEVideoResolutionOriginal"
        Me.cbFFEXEVideoResolutionOriginal.Size = New System.Drawing.Size(61, 17)
        Me.cbFFEXEVideoResolutionOriginal.TabIndex = 119
        Me.cbFFEXEVideoResolutionOriginal.Text = "Original"
        Me.cbFFEXEVideoResolutionOriginal.UseVisualStyleBackColor = true
        '
        'cbFFEXEAspectRatio
        '
        Me.cbFFEXEAspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEAspectRatio.FormattingEnabled = true
        Me.cbFFEXEAspectRatio.Items.AddRange(New Object() {"Default", "1:1", "4:3", "16:9"})
        Me.cbFFEXEAspectRatio.Location = New System.Drawing.Point(98, 93)
        Me.cbFFEXEAspectRatio.Name = "cbFFEXEAspectRatio"
        Me.cbFFEXEAspectRatio.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEAspectRatio.TabIndex = 107
        '
        'label459
        '
        Me.label459.AutoSize = true
        Me.label459.Location = New System.Drawing.Point(9, 96)
        Me.label459.Name = "label459"
        Me.label459.Size = New System.Drawing.Size(63, 13)
        Me.label459.TabIndex = 106
        Me.label459.Text = "Aspect ratio"
        '
        'edFFEXEVideoHeight
        '
        Me.edFFEXEVideoHeight.Location = New System.Drawing.Point(146, 45)
        Me.edFFEXEVideoHeight.Name = "edFFEXEVideoHeight"
        Me.edFFEXEVideoHeight.Size = New System.Drawing.Size(36, 20)
        Me.edFFEXEVideoHeight.TabIndex = 105
        Me.edFFEXEVideoHeight.Text = "576"
        '
        'label460
        '
        Me.label460.AutoSize = true
        Me.label460.Location = New System.Drawing.Point(135, 47)
        Me.label460.Name = "label460"
        Me.label460.Size = New System.Drawing.Size(12, 13)
        Me.label460.TabIndex = 104
        Me.label460.Text = "x"
        '
        'edFFEXEVideoWidth
        '
        Me.edFFEXEVideoWidth.Location = New System.Drawing.Point(98, 45)
        Me.edFFEXEVideoWidth.Name = "edFFEXEVideoWidth"
        Me.edFFEXEVideoWidth.Size = New System.Drawing.Size(36, 20)
        Me.edFFEXEVideoWidth.TabIndex = 103
        Me.edFFEXEVideoWidth.Text = "768"
        '
        'label461
        '
        Me.label461.AutoSize = true
        Me.label461.Location = New System.Drawing.Point(9, 47)
        Me.label461.Name = "label461"
        Me.label461.Size = New System.Drawing.Size(57, 13)
        Me.label461.TabIndex = 102
        Me.label461.Text = "Resolution"
        '
        'tabPage137
        '
        Me.tabPage137.Controls.Add(Me.lbFFEXEVideoQuality)
        Me.tabPage137.Controls.Add(Me.tbFFEXEVideoQuality)
        Me.tabPage137.Controls.Add(Me.label481)
        Me.tabPage137.Controls.Add(Me.rbFFEXEVideoModeQuality)
        Me.tabPage137.Controls.Add(Me.rbFFEXEVideoModeABR)
        Me.tabPage137.Controls.Add(Me.rbFFEXEVideoModeCBR)
        Me.tabPage137.Controls.Add(Me.edFFEXEVideoBitrateMax)
        Me.tabPage137.Controls.Add(Me.label452)
        Me.tabPage137.Controls.Add(Me.label454)
        Me.tabPage137.Controls.Add(Me.edFFEXEVideoBitrateMin)
        Me.tabPage137.Controls.Add(Me.label455)
        Me.tabPage137.Controls.Add(Me.label456)
        Me.tabPage137.Controls.Add(Me.edFFEXEVideoTargetBitrate)
        Me.tabPage137.Controls.Add(Me.label457)
        Me.tabPage137.Location = New System.Drawing.Point(4, 22)
        Me.tabPage137.Name = "tabPage137"
        Me.tabPage137.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage137.Size = New System.Drawing.Size(253, 290)
        Me.tabPage137.TabIndex = 3
        Me.tabPage137.Text = "Bitrate / quality"
        Me.tabPage137.UseVisualStyleBackColor = true
        '
        'lbFFEXEVideoQuality
        '
        Me.lbFFEXEVideoQuality.AutoSize = true
        Me.lbFFEXEVideoQuality.Location = New System.Drawing.Point(228, 143)
        Me.lbFFEXEVideoQuality.Name = "lbFFEXEVideoQuality"
        Me.lbFFEXEVideoQuality.Size = New System.Drawing.Size(19, 13)
        Me.lbFFEXEVideoQuality.TabIndex = 144
        Me.lbFFEXEVideoQuality.Text = "23"
        '
        'tbFFEXEVideoQuality
        '
        Me.tbFFEXEVideoQuality.Location = New System.Drawing.Point(97, 129)
        Me.tbFFEXEVideoQuality.Maximum = 31
        Me.tbFFEXEVideoQuality.Minimum = 1
        Me.tbFFEXEVideoQuality.Name = "tbFFEXEVideoQuality"
        Me.tbFFEXEVideoQuality.Size = New System.Drawing.Size(125, 45)
        Me.tbFFEXEVideoQuality.TabIndex = 143
        Me.tbFFEXEVideoQuality.Value = 23
        '
        'label481
        '
        Me.label481.AutoSize = true
        Me.label481.Location = New System.Drawing.Point(12, 143)
        Me.label481.Name = "label481"
        Me.label481.Size = New System.Drawing.Size(52, 13)
        Me.label481.TabIndex = 142
        Me.label481.Text = "Quantizer"
        '
        'rbFFEXEVideoModeQuality
        '
        Me.rbFFEXEVideoModeQuality.AutoSize = true
        Me.rbFFEXEVideoModeQuality.Location = New System.Drawing.Point(11, 114)
        Me.rbFFEXEVideoModeQuality.Name = "rbFFEXEVideoModeQuality"
        Me.rbFFEXEVideoModeQuality.Size = New System.Drawing.Size(57, 17)
        Me.rbFFEXEVideoModeQuality.TabIndex = 141
        Me.rbFFEXEVideoModeQuality.Text = "Quality"
        Me.rbFFEXEVideoModeQuality.UseVisualStyleBackColor = true
        '
        'rbFFEXEVideoModeABR
        '
        Me.rbFFEXEVideoModeABR.AutoSize = true
        Me.rbFFEXEVideoModeABR.Location = New System.Drawing.Point(11, 64)
        Me.rbFFEXEVideoModeABR.Name = "rbFFEXEVideoModeABR"
        Me.rbFFEXEVideoModeABR.Size = New System.Drawing.Size(47, 17)
        Me.rbFFEXEVideoModeABR.TabIndex = 140
        Me.rbFFEXEVideoModeABR.Text = "ABR"
        Me.rbFFEXEVideoModeABR.UseVisualStyleBackColor = true
        '
        'rbFFEXEVideoModeCBR
        '
        Me.rbFFEXEVideoModeCBR.AutoSize = true
        Me.rbFFEXEVideoModeCBR.Checked = true
        Me.rbFFEXEVideoModeCBR.Location = New System.Drawing.Point(11, 13)
        Me.rbFFEXEVideoModeCBR.Name = "rbFFEXEVideoModeCBR"
        Me.rbFFEXEVideoModeCBR.Size = New System.Drawing.Size(47, 17)
        Me.rbFFEXEVideoModeCBR.TabIndex = 139
        Me.rbFFEXEVideoModeCBR.TabStop = true
        Me.rbFFEXEVideoModeCBR.Text = "CBR"
        Me.rbFFEXEVideoModeCBR.UseVisualStyleBackColor = true
        '
        'edFFEXEVideoBitrateMax
        '
        Me.edFFEXEVideoBitrateMax.Location = New System.Drawing.Point(169, 87)
        Me.edFFEXEVideoBitrateMax.Name = "edFFEXEVideoBitrateMax"
        Me.edFFEXEVideoBitrateMax.Size = New System.Drawing.Size(49, 20)
        Me.edFFEXEVideoBitrateMax.TabIndex = 138
        Me.edFFEXEVideoBitrateMax.Text = "9000"
        '
        'label452
        '
        Me.label452.AutoSize = true
        Me.label452.Location = New System.Drawing.Point(150, 90)
        Me.label452.Name = "label452"
        Me.label452.Size = New System.Drawing.Size(16, 13)
        Me.label452.TabIndex = 137
        Me.label452.Text = "to"
        '
        'label454
        '
        Me.label454.AutoSize = true
        Me.label454.Location = New System.Drawing.Point(218, 90)
        Me.label454.Name = "label454"
        Me.label454.Size = New System.Drawing.Size(31, 13)
        Me.label454.TabIndex = 136
        Me.label454.Text = "Kbps"
        '
        'edFFEXEVideoBitrateMin
        '
        Me.edFFEXEVideoBitrateMin.Location = New System.Drawing.Point(97, 87)
        Me.edFFEXEVideoBitrateMin.Name = "edFFEXEVideoBitrateMin"
        Me.edFFEXEVideoBitrateMin.Size = New System.Drawing.Size(52, 20)
        Me.edFFEXEVideoBitrateMin.TabIndex = 135
        Me.edFFEXEVideoBitrateMin.Text = "0"
        '
        'label455
        '
        Me.label455.AutoSize = true
        Me.label455.Location = New System.Drawing.Point(12, 90)
        Me.label455.Name = "label455"
        Me.label455.Size = New System.Drawing.Size(67, 13)
        Me.label455.TabIndex = 134
        Me.label455.Text = "Bitrate range"
        '
        'label456
        '
        Me.label456.AutoSize = true
        Me.label456.Location = New System.Drawing.Point(150, 41)
        Me.label456.Name = "label456"
        Me.label456.Size = New System.Drawing.Size(31, 13)
        Me.label456.TabIndex = 133
        Me.label456.Text = "Kbps"
        '
        'edFFEXEVideoTargetBitrate
        '
        Me.edFFEXEVideoTargetBitrate.Location = New System.Drawing.Point(97, 39)
        Me.edFFEXEVideoTargetBitrate.Name = "edFFEXEVideoTargetBitrate"
        Me.edFFEXEVideoTargetBitrate.Size = New System.Drawing.Size(52, 20)
        Me.edFFEXEVideoTargetBitrate.TabIndex = 132
        Me.edFFEXEVideoTargetBitrate.Text = "6000"
        '
        'label457
        '
        Me.label457.AutoSize = true
        Me.label457.Location = New System.Drawing.Point(12, 41)
        Me.label457.Name = "label457"
        Me.label457.Size = New System.Drawing.Size(70, 13)
        Me.label457.TabIndex = 131
        Me.label457.Text = "Target bitrate"
        '
        'tabPage136
        '
        Me.tabPage136.Controls.Add(Me.edFFEXEVideoBFramesCount)
        Me.tabPage136.Controls.Add(Me.label479)
        Me.tabPage136.Controls.Add(Me.edFFEXEVideoGOPSize)
        Me.tabPage136.Controls.Add(Me.label478)
        Me.tabPage136.Controls.Add(Me.cbFFEXEVideoInterlace)
        Me.tabPage136.Controls.Add(Me.edFFEXEVBVBufferSize)
        Me.tabPage136.Controls.Add(Me.label453)
        Me.tabPage136.Location = New System.Drawing.Point(4, 22)
        Me.tabPage136.Name = "tabPage136"
        Me.tabPage136.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage136.Size = New System.Drawing.Size(253, 290)
        Me.tabPage136.TabIndex = 2
        Me.tabPage136.Text = "Advanced"
        Me.tabPage136.UseVisualStyleBackColor = true
        '
        'edFFEXEVideoBFramesCount
        '
        Me.edFFEXEVideoBFramesCount.Location = New System.Drawing.Point(96, 98)
        Me.edFFEXEVideoBFramesCount.Name = "edFFEXEVideoBFramesCount"
        Me.edFFEXEVideoBFramesCount.Size = New System.Drawing.Size(52, 20)
        Me.edFFEXEVideoBFramesCount.TabIndex = 125
        Me.edFFEXEVideoBFramesCount.Text = "0"
        '
        'label479
        '
        Me.label479.AutoSize = true
        Me.label479.Location = New System.Drawing.Point(9, 101)
        Me.label479.Name = "label479"
        Me.label479.Size = New System.Drawing.Size(78, 13)
        Me.label479.TabIndex = 124
        Me.label479.Text = "B-frames count"
        '
        'edFFEXEVideoGOPSize
        '
        Me.edFFEXEVideoGOPSize.Location = New System.Drawing.Point(96, 72)
        Me.edFFEXEVideoGOPSize.Name = "edFFEXEVideoGOPSize"
        Me.edFFEXEVideoGOPSize.Size = New System.Drawing.Size(52, 20)
        Me.edFFEXEVideoGOPSize.TabIndex = 123
        Me.edFFEXEVideoGOPSize.Text = "0"
        '
        'label478
        '
        Me.label478.AutoSize = true
        Me.label478.Location = New System.Drawing.Point(9, 75)
        Me.label478.Name = "label478"
        Me.label478.Size = New System.Drawing.Size(51, 13)
        Me.label478.TabIndex = 122
        Me.label478.Text = "GOP size"
        '
        'cbFFEXEVideoInterlace
        '
        Me.cbFFEXEVideoInterlace.AutoSize = true
        Me.cbFFEXEVideoInterlace.Location = New System.Drawing.Point(12, 45)
        Me.cbFFEXEVideoInterlace.Name = "cbFFEXEVideoInterlace"
        Me.cbFFEXEVideoInterlace.Size = New System.Drawing.Size(96, 17)
        Me.cbFFEXEVideoInterlace.TabIndex = 121
        Me.cbFFEXEVideoInterlace.Text = "Interlace video"
        Me.cbFFEXEVideoInterlace.UseVisualStyleBackColor = true
        '
        'edFFEXEVBVBufferSize
        '
        Me.edFFEXEVBVBufferSize.Location = New System.Drawing.Point(96, 14)
        Me.edFFEXEVBVBufferSize.Name = "edFFEXEVBVBufferSize"
        Me.edFFEXEVBVBufferSize.Size = New System.Drawing.Size(52, 20)
        Me.edFFEXEVBVBufferSize.TabIndex = 120
        Me.edFFEXEVBVBufferSize.Text = "0"
        '
        'label453
        '
        Me.label453.AutoSize = true
        Me.label453.Location = New System.Drawing.Point(9, 17)
        Me.label453.Name = "label453"
        Me.label453.Size = New System.Drawing.Size(79, 13)
        Me.label453.TabIndex = 119
        Me.label453.Text = "VBV buffer size"
        '
        'tabPage135
        '
        Me.tabPage135.Controls.Add(Me.label483)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264WebFastStart)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264ZeroTolerance)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264QuickTimeCompatibility)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264Level)
        Me.tabPage135.Controls.Add(Me.label475)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264Profile)
        Me.tabPage135.Controls.Add(Me.label474)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264Preset)
        Me.tabPage135.Controls.Add(Me.label473)
        Me.tabPage135.Controls.Add(Me.cbFFEXEH264Mode)
        Me.tabPage135.Controls.Add(Me.label472)
        Me.tabPage135.Controls.Add(Me.lbFFEXEH264Quantizer)
        Me.tabPage135.Controls.Add(Me.tbFFEXEH264Quantizer)
        Me.tabPage135.Controls.Add(Me.label458)
        Me.tabPage135.Location = New System.Drawing.Point(4, 22)
        Me.tabPage135.Name = "tabPage135"
        Me.tabPage135.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage135.Size = New System.Drawing.Size(253, 290)
        Me.tabPage135.TabIndex = 1
        Me.tabPage135.Text = "H264 / HEVC"
        Me.tabPage135.UseVisualStyleBackColor = true
        '
        'label483
        '
        Me.label483.AutoSize = true
        Me.label483.Location = New System.Drawing.Point(65, 191)
        Me.label483.Name = "label483"
        Me.label483.Size = New System.Drawing.Size(111, 13)
        Me.label483.TabIndex = 139
        Me.label483.Text = "H264 specific settings"
        '
        'cbFFEXEH264WebFastStart
        '
        Me.cbFFEXEH264WebFastStart.AutoSize = true
        Me.cbFFEXEH264WebFastStart.Location = New System.Drawing.Point(12, 262)
        Me.cbFFEXEH264WebFastStart.Name = "cbFFEXEH264WebFastStart"
        Me.cbFFEXEH264WebFastStart.Size = New System.Drawing.Size(132, 17)
        Me.cbFFEXEH264WebFastStart.TabIndex = 138
        Me.cbFFEXEH264WebFastStart.Text = "Web browser fast start"
        Me.cbFFEXEH264WebFastStart.UseVisualStyleBackColor = true
        '
        'cbFFEXEH264ZeroTolerance
        '
        Me.cbFFEXEH264ZeroTolerance.AutoSize = true
        Me.cbFFEXEH264ZeroTolerance.Location = New System.Drawing.Point(12, 239)
        Me.cbFFEXEH264ZeroTolerance.Name = "cbFFEXEH264ZeroTolerance"
        Me.cbFFEXEH264ZeroTolerance.Size = New System.Drawing.Size(205, 17)
        Me.cbFFEXEH264ZeroTolerance.TabIndex = 137
        Me.cbFFEXEH264ZeroTolerance.Text = "Zero tolerance (for network streaming)"
        Me.cbFFEXEH264ZeroTolerance.UseVisualStyleBackColor = true
        '
        'cbFFEXEH264QuickTimeCompatibility
        '
        Me.cbFFEXEH264QuickTimeCompatibility.AutoSize = true
        Me.cbFFEXEH264QuickTimeCompatibility.Checked = true
        Me.cbFFEXEH264QuickTimeCompatibility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFFEXEH264QuickTimeCompatibility.Location = New System.Drawing.Point(12, 216)
        Me.cbFFEXEH264QuickTimeCompatibility.Name = "cbFFEXEH264QuickTimeCompatibility"
        Me.cbFFEXEH264QuickTimeCompatibility.Size = New System.Drawing.Size(241, 17)
        Me.cbFFEXEH264QuickTimeCompatibility.TabIndex = 136
        Me.cbFFEXEH264QuickTimeCompatibility.Text = "Apple QuickTime and old players compatibility"
        Me.cbFFEXEH264QuickTimeCompatibility.UseVisualStyleBackColor = true
        '
        'cbFFEXEH264Level
        '
        Me.cbFFEXEH264Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEH264Level.FormattingEnabled = true
        Me.cbFFEXEH264Level.Items.AddRange(New Object() {"None / auto", "1.0", "1.1", "1.2", "1.3", "2.0", "2.1", "2.2", "3.0", "3.1", "3.2", "4.0", "4.1", "4.2", "5.0", "5.1"})
        Me.cbFFEXEH264Level.Location = New System.Drawing.Point(96, 152)
        Me.cbFFEXEH264Level.Name = "cbFFEXEH264Level"
        Me.cbFFEXEH264Level.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEH264Level.TabIndex = 135
        '
        'label475
        '
        Me.label475.AutoSize = true
        Me.label475.Location = New System.Drawing.Point(9, 155)
        Me.label475.Name = "label475"
        Me.label475.Size = New System.Drawing.Size(33, 13)
        Me.label475.TabIndex = 134
        Me.label475.Text = "Level"
        '
        'cbFFEXEH264Profile
        '
        Me.cbFFEXEH264Profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEH264Profile.FormattingEnabled = true
        Me.cbFFEXEH264Profile.Items.AddRange(New Object() {"None / auto", "Baseline", "Main", "High", "High 10", "High 422", "High 444"})
        Me.cbFFEXEH264Profile.Location = New System.Drawing.Point(96, 122)
        Me.cbFFEXEH264Profile.Name = "cbFFEXEH264Profile"
        Me.cbFFEXEH264Profile.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEH264Profile.TabIndex = 133
        '
        'label474
        '
        Me.label474.AutoSize = true
        Me.label474.Location = New System.Drawing.Point(9, 125)
        Me.label474.Name = "label474"
        Me.label474.Size = New System.Drawing.Size(36, 13)
        Me.label474.TabIndex = 132
        Me.label474.Text = "Profile"
        '
        'cbFFEXEH264Preset
        '
        Me.cbFFEXEH264Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEH264Preset.FormattingEnabled = true
        Me.cbFFEXEH264Preset.Items.AddRange(New Object() {"None / auto", "Ultra fast", "Super fast", "Very fast", "Faster", "Fast", "Medium", "Slow", "Slower", "Very slow"})
        Me.cbFFEXEH264Preset.Location = New System.Drawing.Point(96, 92)
        Me.cbFFEXEH264Preset.Name = "cbFFEXEH264Preset"
        Me.cbFFEXEH264Preset.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEH264Preset.TabIndex = 131
        '
        'label473
        '
        Me.label473.AutoSize = true
        Me.label473.Location = New System.Drawing.Point(9, 95)
        Me.label473.Name = "label473"
        Me.label473.Size = New System.Drawing.Size(37, 13)
        Me.label473.TabIndex = 130
        Me.label473.Text = "Preset"
        '
        'cbFFEXEH264Mode
        '
        Me.cbFFEXEH264Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEH264Mode.FormattingEnabled = true
        Me.cbFFEXEH264Mode.Items.AddRange(New Object() {"CRF", "CRF (limited bitrate)", "CBR", "ABR", "Lossless"})
        Me.cbFFEXEH264Mode.Location = New System.Drawing.Point(96, 14)
        Me.cbFFEXEH264Mode.Name = "cbFFEXEH264Mode"
        Me.cbFFEXEH264Mode.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEH264Mode.TabIndex = 129
        '
        'label472
        '
        Me.label472.AutoSize = true
        Me.label472.Location = New System.Drawing.Point(9, 17)
        Me.label472.Name = "label472"
        Me.label472.Size = New System.Drawing.Size(34, 13)
        Me.label472.TabIndex = 128
        Me.label472.Text = "Mode"
        '
        'lbFFEXEH264Quantizer
        '
        Me.lbFFEXEH264Quantizer.AutoSize = true
        Me.lbFFEXEH264Quantizer.Location = New System.Drawing.Point(227, 55)
        Me.lbFFEXEH264Quantizer.Name = "lbFFEXEH264Quantizer"
        Me.lbFFEXEH264Quantizer.Size = New System.Drawing.Size(19, 13)
        Me.lbFFEXEH264Quantizer.TabIndex = 127
        Me.lbFFEXEH264Quantizer.Text = "23"
        '
        'tbFFEXEH264Quantizer
        '
        Me.tbFFEXEH264Quantizer.Location = New System.Drawing.Point(96, 41)
        Me.tbFFEXEH264Quantizer.Maximum = 63
        Me.tbFFEXEH264Quantizer.Name = "tbFFEXEH264Quantizer"
        Me.tbFFEXEH264Quantizer.Size = New System.Drawing.Size(125, 45)
        Me.tbFFEXEH264Quantizer.TabIndex = 126
        Me.tbFFEXEH264Quantizer.Value = 23
        '
        'label458
        '
        Me.label458.AutoSize = true
        Me.label458.Location = New System.Drawing.Point(9, 55)
        Me.label458.Name = "label458"
        Me.label458.Size = New System.Drawing.Size(82, 13)
        Me.label458.TabIndex = 125
        Me.label458.Text = "Quantizer (CRF)"
        '
        'tabPage131
        '
        Me.tabPage131.Controls.Add(Me.lbFFEXEAudioNotes)
        Me.tabPage131.Controls.Add(Me.rbFFEXEAudioModeLossless)
        Me.tabPage131.Controls.Add(Me.rbFFEXEAudioModeQuality)
        Me.tabPage131.Controls.Add(Me.rbFFEXEAudioModeABR)
        Me.tabPage131.Controls.Add(Me.rbFFEXEAudioModeCBR)
        Me.tabPage131.Controls.Add(Me.lbFFEXEAudioQuality)
        Me.tabPage131.Controls.Add(Me.tbFFEXEAudioQuality)
        Me.tabPage131.Controls.Add(Me.label477)
        Me.tabPage131.Controls.Add(Me.label470)
        Me.tabPage131.Controls.Add(Me.cbFFEXEAudioCodec)
        Me.tabPage131.Controls.Add(Me.label462)
        Me.tabPage131.Controls.Add(Me.label463)
        Me.tabPage131.Controls.Add(Me.cbFFEXEAudioBitrate)
        Me.tabPage131.Controls.Add(Me.label464)
        Me.tabPage131.Controls.Add(Me.cbFFEXEAudioChannels)
        Me.tabPage131.Controls.Add(Me.label465)
        Me.tabPage131.Controls.Add(Me.cbFFEXEAudioSampleRate)
        Me.tabPage131.Controls.Add(Me.label466)
        Me.tabPage131.Location = New System.Drawing.Point(4, 22)
        Me.tabPage131.Name = "tabPage131"
        Me.tabPage131.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage131.Size = New System.Drawing.Size(273, 325)
        Me.tabPage131.TabIndex = 3
        Me.tabPage131.Text = "Audio"
        Me.tabPage131.UseVisualStyleBackColor = true
        '
        'lbFFEXEAudioNotes
        '
        Me.lbFFEXEAudioNotes.AutoSize = true
        Me.lbFFEXEAudioNotes.Location = New System.Drawing.Point(11, 282)
        Me.lbFFEXEAudioNotes.Name = "lbFFEXEAudioNotes"
        Me.lbFFEXEAudioNotes.Size = New System.Drawing.Size(70, 13)
        Me.lbFFEXEAudioNotes.TabIndex = 130
        Me.lbFFEXEAudioNotes.Text = "Notes: None."
        '
        'rbFFEXEAudioModeLossless
        '
        Me.rbFFEXEAudioModeLossless.AutoSize = true
        Me.rbFFEXEAudioModeLossless.Location = New System.Drawing.Point(13, 253)
        Me.rbFFEXEAudioModeLossless.Name = "rbFFEXEAudioModeLossless"
        Me.rbFFEXEAudioModeLossless.Size = New System.Drawing.Size(65, 17)
        Me.rbFFEXEAudioModeLossless.TabIndex = 129
        Me.rbFFEXEAudioModeLossless.Text = "Lossless"
        Me.rbFFEXEAudioModeLossless.UseVisualStyleBackColor = true
        '
        'rbFFEXEAudioModeQuality
        '
        Me.rbFFEXEAudioModeQuality.AutoSize = true
        Me.rbFFEXEAudioModeQuality.Location = New System.Drawing.Point(13, 197)
        Me.rbFFEXEAudioModeQuality.Name = "rbFFEXEAudioModeQuality"
        Me.rbFFEXEAudioModeQuality.Size = New System.Drawing.Size(57, 17)
        Me.rbFFEXEAudioModeQuality.TabIndex = 128
        Me.rbFFEXEAudioModeQuality.Text = "Quality"
        Me.rbFFEXEAudioModeQuality.UseVisualStyleBackColor = true
        '
        'rbFFEXEAudioModeABR
        '
        Me.rbFFEXEAudioModeABR.AutoSize = true
        Me.rbFFEXEAudioModeABR.Location = New System.Drawing.Point(13, 174)
        Me.rbFFEXEAudioModeABR.Name = "rbFFEXEAudioModeABR"
        Me.rbFFEXEAudioModeABR.Size = New System.Drawing.Size(47, 17)
        Me.rbFFEXEAudioModeABR.TabIndex = 127
        Me.rbFFEXEAudioModeABR.Text = "ABR"
        Me.rbFFEXEAudioModeABR.UseVisualStyleBackColor = true
        '
        'rbFFEXEAudioModeCBR
        '
        Me.rbFFEXEAudioModeCBR.AutoSize = true
        Me.rbFFEXEAudioModeCBR.Checked = true
        Me.rbFFEXEAudioModeCBR.Location = New System.Drawing.Point(13, 123)
        Me.rbFFEXEAudioModeCBR.Name = "rbFFEXEAudioModeCBR"
        Me.rbFFEXEAudioModeCBR.Size = New System.Drawing.Size(47, 17)
        Me.rbFFEXEAudioModeCBR.TabIndex = 126
        Me.rbFFEXEAudioModeCBR.TabStop = true
        Me.rbFFEXEAudioModeCBR.Text = "CBR"
        Me.rbFFEXEAudioModeCBR.UseVisualStyleBackColor = true
        '
        'lbFFEXEAudioQuality
        '
        Me.lbFFEXEAudioQuality.AutoSize = true
        Me.lbFFEXEAudioQuality.Location = New System.Drawing.Point(231, 223)
        Me.lbFFEXEAudioQuality.Name = "lbFFEXEAudioQuality"
        Me.lbFFEXEAudioQuality.Size = New System.Drawing.Size(13, 13)
        Me.lbFFEXEAudioQuality.TabIndex = 105
        Me.lbFFEXEAudioQuality.Text = "4"
        '
        'tbFFEXEAudioQuality
        '
        Me.tbFFEXEAudioQuality.Location = New System.Drawing.Point(99, 207)
        Me.tbFFEXEAudioQuality.Maximum = 9
        Me.tbFFEXEAudioQuality.Name = "tbFFEXEAudioQuality"
        Me.tbFFEXEAudioQuality.Size = New System.Drawing.Size(125, 45)
        Me.tbFFEXEAudioQuality.TabIndex = 104
        Me.tbFFEXEAudioQuality.Value = 4
        '
        'label477
        '
        Me.label477.AutoSize = true
        Me.label477.Location = New System.Drawing.Point(10, 177)
        Me.label477.Name = "label477"
        Me.label477.Size = New System.Drawing.Size(39, 13)
        Me.label477.TabIndex = 103
        Me.label477.Text = "Quality"
        '
        'label470
        '
        Me.label470.AutoSize = true
        Me.label470.Location = New System.Drawing.Point(10, 19)
        Me.label470.Name = "label470"
        Me.label470.Size = New System.Drawing.Size(67, 13)
        Me.label470.TabIndex = 100
        Me.label470.Text = "Codec name"
        '
        'cbFFEXEAudioCodec
        '
        Me.cbFFEXEAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEAudioCodec.FormattingEnabled = true
        Me.cbFFEXEAudioCodec.Items.AddRange(New Object() {"Auto / None", "AAC", "AC3", "G722", "G726", "ADPCM", "ALAC", "AMR-NB", "AMR-WB", "E-AC3", "FLAC", "G723", "MP2", "MP3", "OPUS", "PCM ALAW", "PCM F32BE", "PCM F32LE", "PCM F64BE", "PCM F64LE", "PCM MULAW", "PCM S16BE", "PCM S16BE Planar", "PCM S16LE", "PCM S16LE Planar", "PCM S24BE", "PCM S24LE", "PCM S24LE Planar", "PCM S32BE", "PCM S32LE", "PCM S32LE Planar", "PCM S8", "PCM S8 Planar", "PCM U16BE", "PCM U16LE", "PCM U24BE", "PCM U24LE", "PCM U32BE", "PCM U32LE", "PCM U8", "Speex", "Vorbis", "WavPack"})
        Me.cbFFEXEAudioCodec.Location = New System.Drawing.Point(99, 16)
        Me.cbFFEXEAudioCodec.Name = "cbFFEXEAudioCodec"
        Me.cbFFEXEAudioCodec.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEAudioCodec.TabIndex = 99
        '
        'label462
        '
        Me.label462.AutoSize = true
        Me.label462.Location = New System.Drawing.Point(231, 49)
        Me.label462.Name = "label462"
        Me.label462.Size = New System.Drawing.Size(20, 13)
        Me.label462.TabIndex = 91
        Me.label462.Text = "Hz"
        '
        'label463
        '
        Me.label463.AutoSize = true
        Me.label463.Location = New System.Drawing.Point(231, 148)
        Me.label463.Name = "label463"
        Me.label463.Size = New System.Drawing.Size(31, 13)
        Me.label463.TabIndex = 90
        Me.label463.Text = "Kbps"
        '
        'cbFFEXEAudioBitrate
        '
        Me.cbFFEXEAudioBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEAudioBitrate.FormattingEnabled = true
        Me.cbFFEXEAudioBitrate.Items.AddRange(New Object() {"Auto", "32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320"})
        Me.cbFFEXEAudioBitrate.Location = New System.Drawing.Point(99, 145)
        Me.cbFFEXEAudioBitrate.Name = "cbFFEXEAudioBitrate"
        Me.cbFFEXEAudioBitrate.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEAudioBitrate.TabIndex = 11
        '
        'label464
        '
        Me.label464.AutoSize = true
        Me.label464.Location = New System.Drawing.Point(33, 148)
        Me.label464.Name = "label464"
        Me.label464.Size = New System.Drawing.Size(37, 13)
        Me.label464.TabIndex = 10
        Me.label464.Text = "Bitrate"
        '
        'cbFFEXEAudioChannels
        '
        Me.cbFFEXEAudioChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEAudioChannels.FormattingEnabled = true
        Me.cbFFEXEAudioChannels.Items.AddRange(New Object() {"Auto", "2", "1"})
        Me.cbFFEXEAudioChannels.Location = New System.Drawing.Point(99, 77)
        Me.cbFFEXEAudioChannels.Name = "cbFFEXEAudioChannels"
        Me.cbFFEXEAudioChannels.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEAudioChannels.TabIndex = 9
        '
        'label465
        '
        Me.label465.AutoSize = true
        Me.label465.Location = New System.Drawing.Point(10, 80)
        Me.label465.Name = "label465"
        Me.label465.Size = New System.Drawing.Size(51, 13)
        Me.label465.TabIndex = 8
        Me.label465.Text = "Channels"
        '
        'cbFFEXEAudioSampleRate
        '
        Me.cbFFEXEAudioSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEAudioSampleRate.FormattingEnabled = true
        Me.cbFFEXEAudioSampleRate.Items.AddRange(New Object() {"Auto", "48000", "44100", "32000", "24000", "22050", "16000", "12000", "11025", "8000"})
        Me.cbFFEXEAudioSampleRate.Location = New System.Drawing.Point(99, 46)
        Me.cbFFEXEAudioSampleRate.Name = "cbFFEXEAudioSampleRate"
        Me.cbFFEXEAudioSampleRate.Size = New System.Drawing.Size(125, 21)
        Me.cbFFEXEAudioSampleRate.TabIndex = 7
        '
        'label466
        '
        Me.label466.AutoSize = true
        Me.label466.Location = New System.Drawing.Point(10, 49)
        Me.label466.Name = "label466"
        Me.label466.Size = New System.Drawing.Size(63, 13)
        Me.label466.TabIndex = 6
        Me.label466.Text = "Sample rate"
        '
        'tabPage133
        '
        Me.tabPage133.Controls.Add(Me.edFFEXECustomParametersCommon)
        Me.tabPage133.Controls.Add(Me.label480)
        Me.tabPage133.Controls.Add(Me.edFFEXECustomParametersAudio)
        Me.tabPage133.Controls.Add(Me.label476)
        Me.tabPage133.Controls.Add(Me.cbFFEXEUseAviSynthProxy)
        Me.tabPage133.Controls.Add(Me.cbFFEXEUseOnlyAdditionalParameters)
        Me.tabPage133.Controls.Add(Me.edFFEXECustomParametersVideo)
        Me.tabPage133.Controls.Add(Me.label471)
        Me.tabPage133.Location = New System.Drawing.Point(4, 22)
        Me.tabPage133.Name = "tabPage133"
        Me.tabPage133.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage133.Size = New System.Drawing.Size(273, 325)
        Me.tabPage133.TabIndex = 5
        Me.tabPage133.Text = "Advanced"
        Me.tabPage133.UseVisualStyleBackColor = true
        '
        'edFFEXECustomParametersCommon
        '
        Me.edFFEXECustomParametersCommon.Location = New System.Drawing.Point(13, 124)
        Me.edFFEXECustomParametersCommon.Name = "edFFEXECustomParametersCommon"
        Me.edFFEXECustomParametersCommon.Size = New System.Drawing.Size(241, 20)
        Me.edFFEXECustomParametersCommon.TabIndex = 7
        '
        'label480
        '
        Me.label480.AutoSize = true
        Me.label480.Location = New System.Drawing.Point(10, 108)
        Me.label480.Name = "label480"
        Me.label480.Size = New System.Drawing.Size(240, 13)
        Me.label480.TabIndex = 6
        Me.label480.Text = "Custom additional FFMPEG parameters (common)"
        '
        'edFFEXECustomParametersAudio
        '
        Me.edFFEXECustomParametersAudio.Location = New System.Drawing.Point(13, 74)
        Me.edFFEXECustomParametersAudio.Name = "edFFEXECustomParametersAudio"
        Me.edFFEXECustomParametersAudio.Size = New System.Drawing.Size(241, 20)
        Me.edFFEXECustomParametersAudio.TabIndex = 5
        '
        'label476
        '
        Me.label476.AutoSize = true
        Me.label476.Location = New System.Drawing.Point(10, 58)
        Me.label476.Name = "label476"
        Me.label476.Size = New System.Drawing.Size(226, 13)
        Me.label476.TabIndex = 4
        Me.label476.Text = "Custom additional FFMPEG parameters (audio)"
        '
        'cbFFEXEUseAviSynthProxy
        '
        Me.cbFFEXEUseAviSynthProxy.AutoSize = true
        Me.cbFFEXEUseAviSynthProxy.Location = New System.Drawing.Point(13, 173)
        Me.cbFFEXEUseAviSynthProxy.Name = "cbFFEXEUseAviSynthProxy"
        Me.cbFFEXEUseAviSynthProxy.Size = New System.Drawing.Size(196, 17)
        Me.cbFFEXEUseAviSynthProxy.TabIndex = 3
        Me.cbFFEXEUseAviSynthProxy.Text = "Use AviSynth proxy script on source"
        Me.cbFFEXEUseAviSynthProxy.UseVisualStyleBackColor = true
        '
        'cbFFEXEUseOnlyAdditionalParameters
        '
        Me.cbFFEXEUseOnlyAdditionalParameters.AutoSize = true
        Me.cbFFEXEUseOnlyAdditionalParameters.Location = New System.Drawing.Point(13, 150)
        Me.cbFFEXEUseOnlyAdditionalParameters.Name = "cbFFEXEUseOnlyAdditionalParameters"
        Me.cbFFEXEUseOnlyAdditionalParameters.Size = New System.Drawing.Size(244, 17)
        Me.cbFFEXEUseOnlyAdditionalParameters.TabIndex = 2
        Me.cbFFEXEUseOnlyAdditionalParameters.Text = "Use only additional parameters, ignore settings"
        Me.cbFFEXEUseOnlyAdditionalParameters.UseVisualStyleBackColor = true
        '
        'edFFEXECustomParametersVideo
        '
        Me.edFFEXECustomParametersVideo.Location = New System.Drawing.Point(13, 35)
        Me.edFFEXECustomParametersVideo.Name = "edFFEXECustomParametersVideo"
        Me.edFFEXECustomParametersVideo.Size = New System.Drawing.Size(241, 20)
        Me.edFFEXECustomParametersVideo.TabIndex = 1
        '
        'label471
        '
        Me.label471.AutoSize = true
        Me.label471.Location = New System.Drawing.Point(10, 19)
        Me.label471.Name = "label471"
        Me.label471.Size = New System.Drawing.Size(226, 13)
        Me.label471.TabIndex = 0
        Me.label471.Text = "Custom additional FFMPEG parameters (video)"
        '
        'cbFFEXEProfile
        '
        Me.cbFFEXEProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFFEXEProfile.FormattingEnabled = true
        Me.cbFFEXEProfile.Items.AddRange(New Object() {"MPEG-1", "MPEG-1 VCD", "MPEG-2", "MPEG-2 SVCD", "MPEG-2 DVD", "MPEG-2 TS", "Flash Video (FLV)", "MP4 H264 / AAC", "MP4 HEVC / AAC", "WebM", "AVI", "OGG Vorbis", "Opus", "Speex", "FLAC", "MP3", "DV", "Custom"})
        Me.cbFFEXEProfile.Location = New System.Drawing.Point(85, 21)
        Me.cbFFEXEProfile.Name = "cbFFEXEProfile"
        Me.cbFFEXEProfile.Size = New System.Drawing.Size(195, 21)
        Me.cbFFEXEProfile.TabIndex = 13
        '
        'label467
        '
        Me.label467.AutoSize = true
        Me.label467.Location = New System.Drawing.Point(8, 24)
        Me.label467.Name = "label467"
        Me.label467.Size = New System.Drawing.Size(36, 13)
        Me.label467.TabIndex = 12
        Me.label467.Text = "Profile"
        '
        'TabPage46
        '
        Me.TabPage46.Controls.Add(Me.tabControl24)
        Me.TabPage46.Location = New System.Drawing.Point(4, 22)
        Me.TabPage46.Name = "TabPage46"
        Me.TabPage46.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage46.Size = New System.Drawing.Size(284, 399)
        Me.TabPage46.TabIndex = 14
        Me.TabPage46.Text = "MP4 H264 / AAC"
        Me.TabPage46.UseVisualStyleBackColor = true
        '
        'tabControl24
        '
        Me.tabControl24.Controls.Add(Me.TabPage50)
        Me.tabControl24.Controls.Add(Me.tabPage89)
        Me.tabControl24.Controls.Add(Me.TabPage22)
        Me.tabControl24.Controls.Add(Me.tabPage90)
        Me.tabControl24.Location = New System.Drawing.Point(-1, 8)
        Me.tabControl24.Margin = New System.Windows.Forms.Padding(2)
        Me.tabControl24.Name = "tabControl24"
        Me.tabControl24.SelectedIndex = 0
        Me.tabControl24.Size = New System.Drawing.Size(286, 382)
        Me.tabControl24.TabIndex = 7
        '
        'TabPage50
        '
        Me.TabPage50.Controls.Add(Me.rbMP4NVENC)
        Me.TabPage50.Controls.Add(Me.linkLabel6)
        Me.TabPage50.Controls.Add(Me.Label500)
        Me.TabPage50.Controls.Add(Me.Label501)
        Me.TabPage50.Controls.Add(Me.rbMP4Modern)
        Me.TabPage50.Controls.Add(Me.rbMP4Legacy)
        Me.TabPage50.Controls.Add(Me.label380)
        Me.TabPage50.Controls.Add(Me.label379)
        Me.TabPage50.Controls.Add(Me.label378)
        Me.TabPage50.Controls.Add(Me.label377)
        Me.TabPage50.Location = New System.Drawing.Point(4, 22)
        Me.TabPage50.Name = "TabPage50"
        Me.TabPage50.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage50.Size = New System.Drawing.Size(278, 356)
        Me.TabPage50.TabIndex = 2
        Me.TabPage50.Text = "Main"
        Me.TabPage50.UseVisualStyleBackColor = true
        '
        'rbMP4NVENC
        '
        Me.rbMP4NVENC.AutoSize = true
        Me.rbMP4NVENC.Location = New System.Drawing.Point(9, 122)
        Me.rbMP4NVENC.Name = "rbMP4NVENC"
        Me.rbMP4NVENC.Size = New System.Drawing.Size(126, 17)
        Me.rbMP4NVENC.TabIndex = 21
        Me.rbMP4NVENC.Text = "nVidia NVENC (GPU)"
        Me.rbMP4NVENC.UseVisualStyleBackColor = true
        '
        'linkLabel6
        '
        Me.linkLabel6.AutoSize = true
        Me.linkLabel6.Location = New System.Drawing.Point(6, 238)
        Me.linkLabel6.Name = "linkLabel6"
        Me.linkLabel6.Size = New System.Drawing.Size(59, 13)
        Me.linkLabel6.TabIndex = 20
        Me.linkLabel6.TabStop = true
        Me.linkLabel6.Text = "Read more"
        '
        'Label500
        '
        Me.Label500.AutoSize = true
        Me.Label500.Location = New System.Drawing.Point(6, 211)
        Me.Label500.Name = "Label500"
        Me.Label500.Size = New System.Drawing.Size(184, 13)
        Me.Label500.TabIndex = 19
        Me.Label500.Text = "/largeaddressaware option for exe file"
        '
        'Label501
        '
        Me.Label501.AutoSize = true
        Me.Label501.Location = New System.Drawing.Point(6, 189)
        Me.Label501.Name = "Label501"
        Me.Label501.Size = New System.Drawing.Size(189, 13)
        Me.Label501.TabIndex = 18
        Me.Label501.Text = "For 2K/4K resolutions you must enable"
        '
        'rbMP4Modern
        '
        Me.rbMP4Modern.AutoSize = true
        Me.rbMP4Modern.Checked = true
        Me.rbMP4Modern.Location = New System.Drawing.Point(9, 99)
        Me.rbMP4Modern.Name = "rbMP4Modern"
        Me.rbMP4Modern.Size = New System.Drawing.Size(167, 17)
        Me.rbMP4Modern.TabIndex = 17
        Me.rbMP4Modern.TabStop = true
        Me.rbMP4Modern.Text = "Modern (Windows 7 and later)"
        Me.rbMP4Modern.UseVisualStyleBackColor = true
        '
        'rbMP4Legacy
        '
        Me.rbMP4Legacy.AutoSize = true
        Me.rbMP4Legacy.Location = New System.Drawing.Point(9, 76)
        Me.rbMP4Legacy.Name = "rbMP4Legacy"
        Me.rbMP4Legacy.Size = New System.Drawing.Size(174, 17)
        Me.rbMP4Legacy.TabIndex = 16
        Me.rbMP4Legacy.Text = "Legacy (Windows XP and later)"
        Me.rbMP4Legacy.UseVisualStyleBackColor = true
        '
        'label380
        '
        Me.label380.AutoSize = true
        Me.label380.Location = New System.Drawing.Point(6, 51)
        Me.label380.Name = "label380"
        Me.label380.Size = New System.Drawing.Size(256, 13)
        Me.label380.TabIndex = 15
        Me.label380.Text = "on modern CPUs (available for Windows 7 and later)."
        '
        'label379
        '
        Me.label379.AutoSize = true
        Me.label379.Location = New System.Drawing.Point(6, 38)
        Me.label379.Name = "label379"
        Me.label379.Size = New System.Drawing.Size(270, 13)
        Me.label379.TabIndex = 14
        Me.label379.Text = "second to provide maximal quality with HW acceleration"
        '
        'label378
        '
        Me.label378.AutoSize = true
        Me.label378.Location = New System.Drawing.Point(6, 25)
        Me.label378.Name = "label378"
        Me.label378.Size = New System.Drawing.Size(211, 13)
        Me.label378.TabIndex = 13
        Me.label378.Text = "first to have compatibility with XP and Vista,"
        '
        'label377
        '
        Me.label377.AutoSize = true
        Me.label377.Location = New System.Drawing.Point(6, 12)
        Me.label377.Name = "label377"
        Me.label377.Size = New System.Drawing.Size(225, 13)
        Me.label377.TabIndex = 12
        Me.label377.Text = "SDK contains 2 codec packs for MP4 output, "
        '
        'tabPage89
        '
        Me.tabPage89.Controls.Add(Me.groupBox18)
        Me.tabPage89.Controls.Add(Me.groupBox29)
        Me.tabPage89.Controls.Add(Me.groupBox46)
        Me.tabPage89.Location = New System.Drawing.Point(4, 22)
        Me.tabPage89.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPage89.Name = "tabPage89"
        Me.tabPage89.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPage89.Size = New System.Drawing.Size(278, 356)
        Me.tabPage89.TabIndex = 0
        Me.tabPage89.Text = "Video (Modern\Legacy)"
        Me.tabPage89.UseVisualStyleBackColor = true
        '
        'groupBox18
        '
        Me.groupBox18.Controls.Add(Me.cbH264PictureType)
        Me.groupBox18.Controls.Add(Me.label360)
        Me.groupBox18.Controls.Add(Me.label347)
        Me.groupBox18.Controls.Add(Me.edH264P)
        Me.groupBox18.Controls.Add(Me.label348)
        Me.groupBox18.Controls.Add(Me.edH264IDR)
        Me.groupBox18.Controls.Add(Me.label349)
        Me.groupBox18.Controls.Add(Me.cbH264MBEncoding)
        Me.groupBox18.Location = New System.Drawing.Point(5, 213)
        Me.groupBox18.Name = "groupBox18"
        Me.groupBox18.Size = New System.Drawing.Size(223, 142)
        Me.groupBox18.TabIndex = 6
        Me.groupBox18.TabStop = false
        Me.groupBox18.Text = "Advanced"
        '
        'cbH264PictureType
        '
        Me.cbH264PictureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264PictureType.FormattingEnabled = true
        Me.cbH264PictureType.Items.AddRange(New Object() {"Auto", "Frame", "TFF", "BFF"})
        Me.cbH264PictureType.Location = New System.Drawing.Point(94, 48)
        Me.cbH264PictureType.Name = "cbH264PictureType"
        Me.cbH264PictureType.Size = New System.Drawing.Size(121, 21)
        Me.cbH264PictureType.TabIndex = 12
        '
        'label360
        '
        Me.label360.AutoSize = true
        Me.label360.Location = New System.Drawing.Point(6, 51)
        Me.label360.Name = "label360"
        Me.label360.Size = New System.Drawing.Size(63, 13)
        Me.label360.TabIndex = 11
        Me.label360.Text = "Picture type"
        '
        'label347
        '
        Me.label347.AutoSize = true
        Me.label347.Location = New System.Drawing.Point(7, 117)
        Me.label347.Name = "label347"
        Me.label347.Size = New System.Drawing.Size(46, 13)
        Me.label347.TabIndex = 10
        Me.label347.Text = "P period"
        '
        'edH264P
        '
        Me.edH264P.Location = New System.Drawing.Point(94, 114)
        Me.edH264P.Name = "edH264P"
        Me.edH264P.Size = New System.Drawing.Size(121, 20)
        Me.edH264P.TabIndex = 9
        Me.edH264P.Text = "3"
        Me.edH264P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label348
        '
        Me.label348.AutoSize = true
        Me.label348.Location = New System.Drawing.Point(7, 83)
        Me.label348.Name = "label348"
        Me.label348.Size = New System.Drawing.Size(58, 13)
        Me.label348.TabIndex = 8
        Me.label348.Text = "IDR period"
        '
        'edH264IDR
        '
        Me.edH264IDR.Location = New System.Drawing.Point(94, 80)
        Me.edH264IDR.Name = "edH264IDR"
        Me.edH264IDR.Size = New System.Drawing.Size(121, 20)
        Me.edH264IDR.TabIndex = 7
        Me.edH264IDR.Text = "15"
        Me.edH264IDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label349
        '
        Me.label349.AutoSize = true
        Me.label349.Location = New System.Drawing.Point(6, 19)
        Me.label349.Name = "label349"
        Me.label349.Size = New System.Drawing.Size(70, 13)
        Me.label349.TabIndex = 4
        Me.label349.Text = "MB encoding"
        '
        'cbH264MBEncoding
        '
        Me.cbH264MBEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbH264MBEncoding.FormattingEnabled = true
        Me.cbH264MBEncoding.Items.AddRange(New Object() {"CAVLC", "CABAC"})
        Me.cbH264MBEncoding.Location = New System.Drawing.Point(94, 16)
        Me.cbH264MBEncoding.Name = "cbH264MBEncoding"
        Me.cbH264MBEncoding.Size = New System.Drawing.Size(121, 21)
        Me.cbH264MBEncoding.TabIndex = 3
        '
        'groupBox29
        '
        Me.groupBox29.Controls.Add(Me.cbH264GOP)
        Me.groupBox29.Controls.Add(Me.cbH264AutoBitrate)
        Me.groupBox29.Controls.Add(Me.label350)
        Me.groupBox29.Controls.Add(Me.edH264Bitrate)
        Me.groupBox29.Controls.Add(Me.label351)
        Me.groupBox29.Controls.Add(Me.cbH264RateControl)
        Me.groupBox29.Location = New System.Drawing.Point(5, 109)
        Me.groupBox29.Name = "groupBox29"
        Me.groupBox29.Size = New System.Drawing.Size(223, 98)
        Me.groupBox29.TabIndex = 5
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
        Me.groupBox46.Location = New System.Drawing.Point(5, 6)
        Me.groupBox46.Name = "groupBox46"
        Me.groupBox46.Size = New System.Drawing.Size(223, 97)
        Me.groupBox46.TabIndex = 4
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
        'TabPage22
        '
        Me.TabPage22.Controls.Add(Me.groupBox14)
        Me.TabPage22.Controls.Add(Me.groupBox49)
        Me.TabPage22.Controls.Add(Me.groupBox50)
        Me.TabPage22.Location = New System.Drawing.Point(4, 22)
        Me.TabPage22.Name = "TabPage22"
        Me.TabPage22.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage22.Size = New System.Drawing.Size(278, 356)
        Me.TabPage22.TabIndex = 3
        Me.TabPage22.Text = "Video (NVENC)"
        Me.TabPage22.UseVisualStyleBackColor = true
        '
        'groupBox14
        '
        Me.groupBox14.Controls.Add(Me.label506)
        Me.groupBox14.Controls.Add(Me.edNVENCBFrames)
        Me.groupBox14.Controls.Add(Me.label507)
        Me.groupBox14.Controls.Add(Me.edNVENCGOP)
        Me.groupBox14.Location = New System.Drawing.Point(8, 210)
        Me.groupBox14.Name = "groupBox14"
        Me.groupBox14.Size = New System.Drawing.Size(264, 79)
        Me.groupBox14.TabIndex = 15
        Me.groupBox14.TabStop = false
        Me.groupBox14.Text = "Advanced"
        '
        'label506
        '
        Me.label506.AutoSize = true
        Me.label506.Location = New System.Drawing.Point(9, 48)
        Me.label506.Name = "label506"
        Me.label506.Size = New System.Drawing.Size(48, 13)
        Me.label506.TabIndex = 10
        Me.label506.Text = "B-frames"
        '
        'edNVENCBFrames
        '
        Me.edNVENCBFrames.Location = New System.Drawing.Point(96, 45)
        Me.edNVENCBFrames.Name = "edNVENCBFrames"
        Me.edNVENCBFrames.Size = New System.Drawing.Size(121, 20)
        Me.edNVENCBFrames.TabIndex = 9
        Me.edNVENCBFrames.Text = "0"
        Me.edNVENCBFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label507
        '
        Me.label507.AutoSize = true
        Me.label507.Location = New System.Drawing.Point(9, 22)
        Me.label507.Name = "label507"
        Me.label507.Size = New System.Drawing.Size(30, 13)
        Me.label507.TabIndex = 8
        Me.label507.Text = "GOP"
        '
        'edNVENCGOP
        '
        Me.edNVENCGOP.Location = New System.Drawing.Point(96, 19)
        Me.edNVENCGOP.Name = "edNVENCGOP"
        Me.edNVENCGOP.Size = New System.Drawing.Size(121, 20)
        Me.edNVENCGOP.TabIndex = 7
        Me.edNVENCGOP.Text = "32"
        Me.edNVENCGOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'groupBox49
        '
        Me.groupBox49.Controls.Add(Me.Label129)
        Me.groupBox49.Controls.Add(Me.edNVENCQP)
        Me.groupBox49.Controls.Add(Me.label508)
        Me.groupBox49.Controls.Add(Me.edNVENCBitrate)
        Me.groupBox49.Controls.Add(Me.label509)
        Me.groupBox49.Controls.Add(Me.cbNVENCRateControl)
        Me.groupBox49.Location = New System.Drawing.Point(8, 98)
        Me.groupBox49.Name = "groupBox49"
        Me.groupBox49.Size = New System.Drawing.Size(264, 106)
        Me.groupBox49.TabIndex = 14
        Me.groupBox49.TabStop = false
        Me.groupBox49.Text = "Bitrate"
        '
        'Label129
        '
        Me.Label129.AutoSize = true
        Me.Label129.Location = New System.Drawing.Point(6, 73)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(22, 13)
        Me.Label129.TabIndex = 8
        Me.Label129.Text = "QP"
        '
        'edNVENCQP
        '
        Me.edNVENCQP.Location = New System.Drawing.Point(94, 72)
        Me.edNVENCQP.Name = "edNVENCQP"
        Me.edNVENCQP.Size = New System.Drawing.Size(121, 20)
        Me.edNVENCQP.TabIndex = 7
        Me.edNVENCQP.Text = "28"
        Me.edNVENCQP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label508
        '
        Me.label508.AutoSize = true
        Me.label508.Location = New System.Drawing.Point(6, 47)
        Me.label508.Name = "label508"
        Me.label508.Size = New System.Drawing.Size(69, 13)
        Me.label508.TabIndex = 6
        Me.label508.Text = "Bitrate (kbps)"
        '
        'edNVENCBitrate
        '
        Me.edNVENCBitrate.Location = New System.Drawing.Point(94, 46)
        Me.edNVENCBitrate.Name = "edNVENCBitrate"
        Me.edNVENCBitrate.Size = New System.Drawing.Size(121, 20)
        Me.edNVENCBitrate.TabIndex = 5
        Me.edNVENCBitrate.Text = "2000"
        Me.edNVENCBitrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label509
        '
        Me.label509.AutoSize = true
        Me.label509.Location = New System.Drawing.Point(6, 21)
        Me.label509.Name = "label509"
        Me.label509.Size = New System.Drawing.Size(65, 13)
        Me.label509.TabIndex = 4
        Me.label509.Text = "Rate ñontrol"
        '
        'cbNVENCRateControl
        '
        Me.cbNVENCRateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNVENCRateControl.FormattingEnabled = true
        Me.cbNVENCRateControl.Items.AddRange(New Object() {"CONST QP", "VBR", "CBR"})
        Me.cbNVENCRateControl.Location = New System.Drawing.Point(94, 19)
        Me.cbNVENCRateControl.Name = "cbNVENCRateControl"
        Me.cbNVENCRateControl.Size = New System.Drawing.Size(121, 21)
        Me.cbNVENCRateControl.TabIndex = 3
        '
        'groupBox50
        '
        Me.groupBox50.Controls.Add(Me.label511)
        Me.groupBox50.Controls.Add(Me.label512)
        Me.groupBox50.Controls.Add(Me.cbNVENCLevel)
        Me.groupBox50.Controls.Add(Me.cbNVENCProfile)
        Me.groupBox50.Location = New System.Drawing.Point(8, 10)
        Me.groupBox50.Name = "groupBox50"
        Me.groupBox50.Size = New System.Drawing.Size(264, 82)
        Me.groupBox50.TabIndex = 13
        Me.groupBox50.TabStop = false
        Me.groupBox50.Text = "Profile settings"
        '
        'label511
        '
        Me.label511.AutoSize = true
        Me.label511.Location = New System.Drawing.Point(7, 49)
        Me.label511.Name = "label511"
        Me.label511.Size = New System.Drawing.Size(33, 13)
        Me.label511.TabIndex = 3
        Me.label511.Text = "Level"
        '
        'label512
        '
        Me.label512.AutoSize = true
        Me.label512.Location = New System.Drawing.Point(7, 22)
        Me.label512.Name = "label512"
        Me.label512.Size = New System.Drawing.Size(36, 13)
        Me.label512.TabIndex = 2
        Me.label512.Text = "Profile"
        '
        'cbNVENCLevel
        '
        Me.cbNVENCLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNVENCLevel.FormattingEnabled = true
        Me.cbNVENCLevel.Items.AddRange(New Object() {"Auto", "1.0", "1.1", "1.2", "1.3", "2.0", "2.1", "2.2", "3.0", "3.1", "3.2", "4.0", "4.1", "4.2", "5.0", "5.1"})
        Me.cbNVENCLevel.Location = New System.Drawing.Point(94, 46)
        Me.cbNVENCLevel.Name = "cbNVENCLevel"
        Me.cbNVENCLevel.Size = New System.Drawing.Size(121, 21)
        Me.cbNVENCLevel.TabIndex = 1
        '
        'cbNVENCProfile
        '
        Me.cbNVENCProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNVENCProfile.FormattingEnabled = true
        Me.cbNVENCProfile.Items.AddRange(New Object() {"Auto", "Baseline", "Main", "High", "High 444", "Progressive High", "Constrained High"})
        Me.cbNVENCProfile.Location = New System.Drawing.Point(94, 19)
        Me.cbNVENCProfile.Name = "cbNVENCProfile"
        Me.cbNVENCProfile.Size = New System.Drawing.Size(121, 21)
        Me.cbNVENCProfile.TabIndex = 0
        '
        'tabPage90
        '
        Me.tabPage90.Controls.Add(Me.label354)
        Me.tabPage90.Controls.Add(Me.cbAACOutput)
        Me.tabPage90.Controls.Add(Me.label355)
        Me.tabPage90.Controls.Add(Me.cbAACBitrate)
        Me.tabPage90.Controls.Add(Me.label356)
        Me.tabPage90.Controls.Add(Me.cbAACObjectType)
        Me.tabPage90.Controls.Add(Me.label357)
        Me.tabPage90.Controls.Add(Me.cbAACVersion)
        Me.tabPage90.Controls.Add(Me.label358)
        Me.tabPage90.Location = New System.Drawing.Point(4, 22)
        Me.tabPage90.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPage90.Name = "tabPage90"
        Me.tabPage90.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPage90.Size = New System.Drawing.Size(278, 356)
        Me.tabPage90.TabIndex = 1
        Me.tabPage90.Text = "Audio"
        Me.tabPage90.UseVisualStyleBackColor = true
        '
        'label354
        '
        Me.label354.AutoSize = true
        Me.label354.Location = New System.Drawing.Point(230, 94)
        Me.label354.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label354.Name = "label354"
        Me.label354.Size = New System.Drawing.Size(31, 13)
        Me.label354.TabIndex = 8
        Me.label354.Text = "Kbps"
        '
        'cbAACOutput
        '
        Me.cbAACOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACOutput.FormattingEnabled = true
        Me.cbAACOutput.Items.AddRange(New Object() {"RAW", "ADTS"})
        Me.cbAACOutput.Location = New System.Drawing.Point(105, 130)
        Me.cbAACOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACOutput.Name = "cbAACOutput"
        Me.cbAACOutput.Size = New System.Drawing.Size(156, 21)
        Me.cbAACOutput.TabIndex = 7
        '
        'label355
        '
        Me.label355.AutoSize = true
        Me.label355.Location = New System.Drawing.Point(12, 132)
        Me.label355.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label355.Name = "label355"
        Me.label355.Size = New System.Drawing.Size(39, 13)
        Me.label355.TabIndex = 6
        Me.label355.Text = "Output"
        '
        'cbAACBitrate
        '
        Me.cbAACBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACBitrate.FormattingEnabled = true
        Me.cbAACBitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128", "140", "160", "192", "224", "256"})
        Me.cbAACBitrate.Location = New System.Drawing.Point(105, 92)
        Me.cbAACBitrate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACBitrate.Name = "cbAACBitrate"
        Me.cbAACBitrate.Size = New System.Drawing.Size(121, 21)
        Me.cbAACBitrate.TabIndex = 5
        '
        'label356
        '
        Me.label356.AutoSize = true
        Me.label356.Location = New System.Drawing.Point(12, 94)
        Me.label356.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label356.Name = "label356"
        Me.label356.Size = New System.Drawing.Size(37, 13)
        Me.label356.TabIndex = 4
        Me.label356.Text = "Bitrate"
        '
        'cbAACObjectType
        '
        Me.cbAACObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACObjectType.FormattingEnabled = true
        Me.cbAACObjectType.Items.AddRange(New Object() {"Main", "Low complexity", "Scalable Sampling Rate", "Long Term Predictor"})
        Me.cbAACObjectType.Location = New System.Drawing.Point(105, 56)
        Me.cbAACObjectType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACObjectType.Name = "cbAACObjectType"
        Me.cbAACObjectType.Size = New System.Drawing.Size(156, 21)
        Me.cbAACObjectType.TabIndex = 3
        '
        'label357
        '
        Me.label357.AutoSize = true
        Me.label357.Location = New System.Drawing.Point(12, 58)
        Me.label357.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label357.Name = "label357"
        Me.label357.Size = New System.Drawing.Size(61, 13)
        Me.label357.TabIndex = 2
        Me.label357.Text = "Object type"
        '
        'cbAACVersion
        '
        Me.cbAACVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAACVersion.FormattingEnabled = true
        Me.cbAACVersion.Items.AddRange(New Object() {"MPEG-4", "MPEG-2"})
        Me.cbAACVersion.Location = New System.Drawing.Point(105, 21)
        Me.cbAACVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAACVersion.Name = "cbAACVersion"
        Me.cbAACVersion.Size = New System.Drawing.Size(156, 21)
        Me.cbAACVersion.TabIndex = 1
        '
        'label358
        '
        Me.label358.AutoSize = true
        Me.label358.Location = New System.Drawing.Point(12, 24)
        Me.label358.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label358.Name = "label358"
        Me.label358.Size = New System.Drawing.Size(75, 13)
        Me.label358.TabIndex = 0
        Me.label358.Text = "MPEG version"
        '
        'TabPage51
        '
        Me.TabPage51.Controls.Add(Me.cbFLACExhaustiveModelSearch)
        Me.TabPage51.Controls.Add(Me.cbFLACAdaptiveMidSideCoding)
        Me.TabPage51.Controls.Add(Me.cbFLACMidSideCoding)
        Me.TabPage51.Controls.Add(Me.edFLACRiceMax)
        Me.TabPage51.Controls.Add(Me.label401)
        Me.TabPage51.Controls.Add(Me.edFLACRiceMin)
        Me.TabPage51.Controls.Add(Me.label400)
        Me.TabPage51.Controls.Add(Me.label399)
        Me.TabPage51.Controls.Add(Me.tbFLACLPCOrder)
        Me.TabPage51.Controls.Add(Me.cbFLACBlockSize)
        Me.TabPage51.Controls.Add(Me.label398)
        Me.TabPage51.Controls.Add(Me.label397)
        Me.TabPage51.Controls.Add(Me.label396)
        Me.TabPage51.Controls.Add(Me.label395)
        Me.TabPage51.Controls.Add(Me.tbFLACLevel)
        Me.TabPage51.Location = New System.Drawing.Point(4, 22)
        Me.TabPage51.Name = "TabPage51"
        Me.TabPage51.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage51.Size = New System.Drawing.Size(284, 399)
        Me.TabPage51.TabIndex = 15
        Me.TabPage51.Text = "FLAC"
        Me.TabPage51.UseVisualStyleBackColor = true
        '
        'cbFLACExhaustiveModelSearch
        '
        Me.cbFLACExhaustiveModelSearch.AutoSize = true
        Me.cbFLACExhaustiveModelSearch.Location = New System.Drawing.Point(11, 243)
        Me.cbFLACExhaustiveModelSearch.Name = "cbFLACExhaustiveModelSearch"
        Me.cbFLACExhaustiveModelSearch.Size = New System.Drawing.Size(144, 17)
        Me.cbFLACExhaustiveModelSearch.TabIndex = 44
        Me.cbFLACExhaustiveModelSearch.Text = "Exhaustive model search"
        Me.cbFLACExhaustiveModelSearch.UseVisualStyleBackColor = true
        '
        'cbFLACAdaptiveMidSideCoding
        '
        Me.cbFLACAdaptiveMidSideCoding.AutoSize = true
        Me.cbFLACAdaptiveMidSideCoding.Location = New System.Drawing.Point(11, 289)
        Me.cbFLACAdaptiveMidSideCoding.Name = "cbFLACAdaptiveMidSideCoding"
        Me.cbFLACAdaptiveMidSideCoding.Size = New System.Drawing.Size(144, 17)
        Me.cbFLACAdaptiveMidSideCoding.TabIndex = 43
        Me.cbFLACAdaptiveMidSideCoding.Text = "Adaptive mid-side coding"
        Me.cbFLACAdaptiveMidSideCoding.UseVisualStyleBackColor = true
        '
        'cbFLACMidSideCoding
        '
        Me.cbFLACMidSideCoding.AutoSize = true
        Me.cbFLACMidSideCoding.Location = New System.Drawing.Point(11, 266)
        Me.cbFLACMidSideCoding.Name = "cbFLACMidSideCoding"
        Me.cbFLACMidSideCoding.Size = New System.Drawing.Size(100, 17)
        Me.cbFLACMidSideCoding.TabIndex = 42
        Me.cbFLACMidSideCoding.Text = "Mid-side coding"
        Me.cbFLACMidSideCoding.UseVisualStyleBackColor = true
        '
        'edFLACRiceMax
        '
        Me.edFLACRiceMax.Location = New System.Drawing.Point(159, 181)
        Me.edFLACRiceMax.Name = "edFLACRiceMax"
        Me.edFLACRiceMax.Size = New System.Drawing.Size(113, 20)
        Me.edFLACRiceMax.TabIndex = 41
        Me.edFLACRiceMax.Text = "3"
        '
        'label401
        '
        Me.label401.AutoSize = true
        Me.label401.Location = New System.Drawing.Point(156, 165)
        Me.label401.Name = "label401"
        Me.label401.Size = New System.Drawing.Size(51, 13)
        Me.label401.TabIndex = 40
        Me.label401.Text = "Rice max"
        '
        'edFLACRiceMin
        '
        Me.edFLACRiceMin.Location = New System.Drawing.Point(159, 127)
        Me.edFLACRiceMin.Name = "edFLACRiceMin"
        Me.edFLACRiceMin.Size = New System.Drawing.Size(113, 20)
        Me.edFLACRiceMin.TabIndex = 39
        Me.edFLACRiceMin.Text = "3"
        '
        'label400
        '
        Me.label400.AutoSize = true
        Me.label400.Location = New System.Drawing.Point(156, 111)
        Me.label400.Name = "label400"
        Me.label400.Size = New System.Drawing.Size(48, 13)
        Me.label400.TabIndex = 38
        Me.label400.Text = "Rice min"
        '
        'label399
        '
        Me.label399.AutoSize = true
        Me.label399.Location = New System.Drawing.Point(8, 165)
        Me.label399.Name = "label399"
        Me.label399.Size = New System.Drawing.Size(54, 13)
        Me.label399.TabIndex = 37
        Me.label399.Text = "LPC order"
        '
        'tbFLACLPCOrder
        '
        Me.tbFLACLPCOrder.Location = New System.Drawing.Point(11, 181)
        Me.tbFLACLPCOrder.Maximum = 32
        Me.tbFLACLPCOrder.Name = "tbFLACLPCOrder"
        Me.tbFLACLPCOrder.Size = New System.Drawing.Size(113, 45)
        Me.tbFLACLPCOrder.TabIndex = 36
        Me.tbFLACLPCOrder.Value = 8
        '
        'cbFLACBlockSize
        '
        Me.cbFLACBlockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFLACBlockSize.FormattingEnabled = true
        Me.cbFLACBlockSize.Items.AddRange(New Object() {"192", "576", "1152", "2304", "4608", "256", "512", "1024", "2048", "4096", "8192", "16384"})
        Me.cbFLACBlockSize.Location = New System.Drawing.Point(11, 127)
        Me.cbFLACBlockSize.Name = "cbFLACBlockSize"
        Me.cbFLACBlockSize.Size = New System.Drawing.Size(113, 21)
        Me.cbFLACBlockSize.TabIndex = 35
        '
        'label398
        '
        Me.label398.AutoSize = true
        Me.label398.Location = New System.Drawing.Point(8, 111)
        Me.label398.Name = "label398"
        Me.label398.Size = New System.Drawing.Size(55, 13)
        Me.label398.TabIndex = 34
        Me.label398.Text = "Block size"
        '
        'label397
        '
        Me.label397.AutoSize = true
        Me.label397.Location = New System.Drawing.Point(175, 76)
        Me.label397.Name = "label397"
        Me.label397.Size = New System.Drawing.Size(97, 13)
        Me.label397.TabIndex = 33
        Me.label397.Text = "Better compression"
        '
        'label396
        '
        Me.label396.AutoSize = true
        Me.label396.Location = New System.Drawing.Point(8, 76)
        Me.label396.Name = "label396"
        Me.label396.Size = New System.Drawing.Size(70, 13)
        Me.label396.TabIndex = 32
        Me.label396.Text = "Higher speed"
        '
        'label395
        '
        Me.label395.AutoSize = true
        Me.label395.Location = New System.Drawing.Point(8, 12)
        Me.label395.Name = "label395"
        Me.label395.Size = New System.Drawing.Size(92, 13)
        Me.label395.TabIndex = 31
        Me.label395.Text = "Compression level"
        '
        'tbFLACLevel
        '
        Me.tbFLACLevel.Location = New System.Drawing.Point(11, 28)
        Me.tbFLACLevel.Maximum = 8
        Me.tbFLACLevel.Name = "tbFLACLevel"
        Me.tbFLACLevel.Size = New System.Drawing.Size(261, 45)
        Me.tbFLACLevel.TabIndex = 30
        Me.tbFLACLevel.Value = 5
        '
        'TabPage55
        '
        Me.TabPage55.Controls.Add(Me.cbSpeexDenoise)
        Me.TabPage55.Controls.Add(Me.cbSpeexAGC)
        Me.TabPage55.Controls.Add(Me.cbSpeexVAD)
        Me.TabPage55.Controls.Add(Me.cbSpeexDTX)
        Me.TabPage55.Controls.Add(Me.tbSpeexComplexity)
        Me.TabPage55.Controls.Add(Me.label54)
        Me.TabPage55.Controls.Add(Me.tbSpeexMaxBitrate)
        Me.TabPage55.Controls.Add(Me.label53)
        Me.TabPage55.Controls.Add(Me.tbSpeexBitrate)
        Me.TabPage55.Controls.Add(Me.label52)
        Me.TabPage55.Controls.Add(Me.tbSpeexQuality)
        Me.TabPage55.Controls.Add(Me.label51)
        Me.TabPage55.Controls.Add(Me.cbSpeexBitrateControl)
        Me.TabPage55.Controls.Add(Me.label49)
        Me.TabPage55.Controls.Add(Me.cbSpeexMode)
        Me.TabPage55.Controls.Add(Me.label33)
        Me.TabPage55.Location = New System.Drawing.Point(4, 22)
        Me.TabPage55.Name = "TabPage55"
        Me.TabPage55.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage55.Size = New System.Drawing.Size(284, 399)
        Me.TabPage55.TabIndex = 16
        Me.TabPage55.Text = "Speex"
        Me.TabPage55.UseVisualStyleBackColor = true
        '
        'cbSpeexDenoise
        '
        Me.cbSpeexDenoise.AutoSize = true
        Me.cbSpeexDenoise.Location = New System.Drawing.Point(194, 218)
        Me.cbSpeexDenoise.Name = "cbSpeexDenoise"
        Me.cbSpeexDenoise.Size = New System.Drawing.Size(65, 17)
        Me.cbSpeexDenoise.TabIndex = 31
        Me.cbSpeexDenoise.Text = "Denoise"
        Me.cbSpeexDenoise.UseVisualStyleBackColor = true
        '
        'cbSpeexAGC
        '
        Me.cbSpeexAGC.AutoSize = true
        Me.cbSpeexAGC.Location = New System.Drawing.Point(143, 218)
        Me.cbSpeexAGC.Name = "cbSpeexAGC"
        Me.cbSpeexAGC.Size = New System.Drawing.Size(48, 17)
        Me.cbSpeexAGC.TabIndex = 30
        Me.cbSpeexAGC.Text = "AGC"
        Me.cbSpeexAGC.UseVisualStyleBackColor = true
        '
        'cbSpeexVAD
        '
        Me.cbSpeexVAD.AutoSize = true
        Me.cbSpeexVAD.Location = New System.Drawing.Point(71, 218)
        Me.cbSpeexVAD.Name = "cbSpeexVAD"
        Me.cbSpeexVAD.Size = New System.Drawing.Size(48, 17)
        Me.cbSpeexVAD.TabIndex = 29
        Me.cbSpeexVAD.Text = "VAD"
        Me.cbSpeexVAD.UseVisualStyleBackColor = true
        '
        'cbSpeexDTX
        '
        Me.cbSpeexDTX.AutoSize = true
        Me.cbSpeexDTX.Location = New System.Drawing.Point(11, 218)
        Me.cbSpeexDTX.Name = "cbSpeexDTX"
        Me.cbSpeexDTX.Size = New System.Drawing.Size(48, 17)
        Me.cbSpeexDTX.TabIndex = 28
        Me.cbSpeexDTX.Text = "DTX"
        Me.cbSpeexDTX.UseVisualStyleBackColor = true
        '
        'tbSpeexComplexity
        '
        Me.tbSpeexComplexity.Location = New System.Drawing.Point(143, 154)
        Me.tbSpeexComplexity.Minimum = 1
        Me.tbSpeexComplexity.Name = "tbSpeexComplexity"
        Me.tbSpeexComplexity.Size = New System.Drawing.Size(121, 45)
        Me.tbSpeexComplexity.TabIndex = 27
        Me.tbSpeexComplexity.Value = 3
        '
        'label54
        '
        Me.label54.AutoSize = true
        Me.label54.Location = New System.Drawing.Point(140, 138)
        Me.label54.Name = "label54"
        Me.label54.Size = New System.Drawing.Size(57, 13)
        Me.label54.TabIndex = 26
        Me.label54.Text = "Complexity"
        '
        'tbSpeexMaxBitrate
        '
        Me.tbSpeexMaxBitrate.Location = New System.Drawing.Point(143, 83)
        Me.tbSpeexMaxBitrate.Maximum = 96
        Me.tbSpeexMaxBitrate.Minimum = 2
        Me.tbSpeexMaxBitrate.Name = "tbSpeexMaxBitrate"
        Me.tbSpeexMaxBitrate.Size = New System.Drawing.Size(121, 45)
        Me.tbSpeexMaxBitrate.SmallChange = 2
        Me.tbSpeexMaxBitrate.TabIndex = 25
        Me.tbSpeexMaxBitrate.TickFrequency = 2
        Me.tbSpeexMaxBitrate.Value = 48
        '
        'label53
        '
        Me.label53.AutoSize = true
        Me.label53.Location = New System.Drawing.Point(140, 67)
        Me.label53.Name = "label53"
        Me.label53.Size = New System.Drawing.Size(59, 13)
        Me.label53.TabIndex = 24
        Me.label53.Text = "Max bitrate"
        '
        'tbSpeexBitrate
        '
        Me.tbSpeexBitrate.Location = New System.Drawing.Point(11, 83)
        Me.tbSpeexBitrate.Maximum = 96
        Me.tbSpeexBitrate.Minimum = 2
        Me.tbSpeexBitrate.Name = "tbSpeexBitrate"
        Me.tbSpeexBitrate.Size = New System.Drawing.Size(121, 45)
        Me.tbSpeexBitrate.SmallChange = 2
        Me.tbSpeexBitrate.TabIndex = 23
        Me.tbSpeexBitrate.TickFrequency = 2
        Me.tbSpeexBitrate.Value = 48
        '
        'label52
        '
        Me.label52.AutoSize = true
        Me.label52.Location = New System.Drawing.Point(8, 67)
        Me.label52.Name = "label52"
        Me.label52.Size = New System.Drawing.Size(37, 13)
        Me.label52.TabIndex = 22
        Me.label52.Text = "Bitrate"
        '
        'tbSpeexQuality
        '
        Me.tbSpeexQuality.Location = New System.Drawing.Point(11, 154)
        Me.tbSpeexQuality.Minimum = 1
        Me.tbSpeexQuality.Name = "tbSpeexQuality"
        Me.tbSpeexQuality.Size = New System.Drawing.Size(121, 45)
        Me.tbSpeexQuality.TabIndex = 21
        Me.tbSpeexQuality.Value = 8
        '
        'label51
        '
        Me.label51.AutoSize = true
        Me.label51.Location = New System.Drawing.Point(8, 138)
        Me.label51.Name = "label51"
        Me.label51.Size = New System.Drawing.Size(39, 13)
        Me.label51.TabIndex = 20
        Me.label51.Text = "Quality"
        '
        'cbSpeexBitrateControl
        '
        Me.cbSpeexBitrateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSpeexBitrateControl.FormattingEnabled = true
        Me.cbSpeexBitrateControl.Items.AddRange(New Object() {"VBR quality", "VBR bitrate", "CBR quality", "CBR bitrate", "ABR"})
        Me.cbSpeexBitrateControl.Location = New System.Drawing.Point(143, 28)
        Me.cbSpeexBitrateControl.Name = "cbSpeexBitrateControl"
        Me.cbSpeexBitrateControl.Size = New System.Drawing.Size(121, 21)
        Me.cbSpeexBitrateControl.TabIndex = 19
        '
        'label49
        '
        Me.label49.AutoSize = true
        Me.label49.Location = New System.Drawing.Point(140, 12)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(72, 13)
        Me.label49.TabIndex = 18
        Me.label49.Text = "Bitrate control"
        '
        'cbSpeexMode
        '
        Me.cbSpeexMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSpeexMode.FormattingEnabled = true
        Me.cbSpeexMode.Items.AddRange(New Object() {"Auto", "Narrowband", "Wideband", "Ultra wideband"})
        Me.cbSpeexMode.Location = New System.Drawing.Point(11, 28)
        Me.cbSpeexMode.Name = "cbSpeexMode"
        Me.cbSpeexMode.Size = New System.Drawing.Size(121, 21)
        Me.cbSpeexMode.TabIndex = 17
        '
        'label33
        '
        Me.label33.AutoSize = true
        Me.label33.Location = New System.Drawing.Point(8, 12)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(34, 13)
        Me.label33.TabIndex = 16
        Me.label33.Text = "Mode"
        '
        'TabPage77
        '
        Me.TabPage77.Controls.Add(Me.TabControl31)
        Me.TabPage77.Location = New System.Drawing.Point(4, 22)
        Me.TabPage77.Name = "TabPage77"
        Me.TabPage77.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage77.Size = New System.Drawing.Size(284, 399)
        Me.TabPage77.TabIndex = 18
        Me.TabPage77.Text = "M4A"
        Me.TabPage77.UseVisualStyleBackColor = true
        '
        'TabControl31
        '
        Me.TabControl31.Controls.Add(Me.tabPage140)
        Me.TabControl31.Controls.Add(Me.tabPage141)
        Me.TabControl31.Location = New System.Drawing.Point(3, 4)
        Me.TabControl31.Name = "TabControl31"
        Me.TabControl31.SelectedIndex = 0
        Me.TabControl31.Size = New System.Drawing.Size(278, 390)
        Me.TabControl31.TabIndex = 3
        '
        'tabPage140
        '
        Me.tabPage140.Controls.Add(Me.label485)
        Me.tabPage140.Controls.Add(Me.cbM4AOutput)
        Me.tabPage140.Controls.Add(Me.label486)
        Me.tabPage140.Controls.Add(Me.cbM4ABitrate)
        Me.tabPage140.Controls.Add(Me.label487)
        Me.tabPage140.Controls.Add(Me.cbM4AObjectType)
        Me.tabPage140.Controls.Add(Me.label488)
        Me.tabPage140.Controls.Add(Me.cbM4AVersion)
        Me.tabPage140.Controls.Add(Me.label489)
        Me.tabPage140.Location = New System.Drawing.Point(4, 22)
        Me.tabPage140.Name = "tabPage140"
        Me.tabPage140.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage140.Size = New System.Drawing.Size(270, 364)
        Me.tabPage140.TabIndex = 0
        Me.tabPage140.Text = "Main"
        Me.tabPage140.UseVisualStyleBackColor = true
        '
        'label485
        '
        Me.label485.AutoSize = true
        Me.label485.Location = New System.Drawing.Point(230, 88)
        Me.label485.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label485.Name = "label485"
        Me.label485.Size = New System.Drawing.Size(31, 13)
        Me.label485.TabIndex = 17
        Me.label485.Text = "Kbps"
        '
        'cbM4AOutput
        '
        Me.cbM4AOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbM4AOutput.FormattingEnabled = true
        Me.cbM4AOutput.Items.AddRange(New Object() {"RAW", "ADTS"})
        Me.cbM4AOutput.Location = New System.Drawing.Point(105, 124)
        Me.cbM4AOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.cbM4AOutput.Name = "cbM4AOutput"
        Me.cbM4AOutput.Size = New System.Drawing.Size(156, 21)
        Me.cbM4AOutput.TabIndex = 16
        '
        'label486
        '
        Me.label486.AutoSize = true
        Me.label486.Location = New System.Drawing.Point(12, 126)
        Me.label486.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label486.Name = "label486"
        Me.label486.Size = New System.Drawing.Size(39, 13)
        Me.label486.TabIndex = 15
        Me.label486.Text = "Output"
        '
        'cbM4ABitrate
        '
        Me.cbM4ABitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbM4ABitrate.FormattingEnabled = true
        Me.cbM4ABitrate.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "72", "80", "88", "96", "104", "112", "120", "128", "140", "160", "192", "224", "256"})
        Me.cbM4ABitrate.Location = New System.Drawing.Point(105, 86)
        Me.cbM4ABitrate.Margin = New System.Windows.Forms.Padding(2)
        Me.cbM4ABitrate.Name = "cbM4ABitrate"
        Me.cbM4ABitrate.Size = New System.Drawing.Size(121, 21)
        Me.cbM4ABitrate.TabIndex = 14
        '
        'label487
        '
        Me.label487.AutoSize = true
        Me.label487.Location = New System.Drawing.Point(12, 88)
        Me.label487.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label487.Name = "label487"
        Me.label487.Size = New System.Drawing.Size(37, 13)
        Me.label487.TabIndex = 13
        Me.label487.Text = "Bitrate"
        '
        'cbM4AObjectType
        '
        Me.cbM4AObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbM4AObjectType.FormattingEnabled = true
        Me.cbM4AObjectType.Items.AddRange(New Object() {"Main", "Low complexity", "Scalable Sampling Rate", "Long Term Predictor"})
        Me.cbM4AObjectType.Location = New System.Drawing.Point(105, 50)
        Me.cbM4AObjectType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbM4AObjectType.Name = "cbM4AObjectType"
        Me.cbM4AObjectType.Size = New System.Drawing.Size(156, 21)
        Me.cbM4AObjectType.TabIndex = 12
        '
        'label488
        '
        Me.label488.AutoSize = true
        Me.label488.Location = New System.Drawing.Point(12, 52)
        Me.label488.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label488.Name = "label488"
        Me.label488.Size = New System.Drawing.Size(61, 13)
        Me.label488.TabIndex = 11
        Me.label488.Text = "Object type"
        '
        'cbM4AVersion
        '
        Me.cbM4AVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbM4AVersion.FormattingEnabled = true
        Me.cbM4AVersion.Items.AddRange(New Object() {"MPEG-4", "MPEG-2"})
        Me.cbM4AVersion.Location = New System.Drawing.Point(105, 15)
        Me.cbM4AVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.cbM4AVersion.Name = "cbM4AVersion"
        Me.cbM4AVersion.Size = New System.Drawing.Size(156, 21)
        Me.cbM4AVersion.TabIndex = 10
        '
        'label489
        '
        Me.label489.AutoSize = true
        Me.label489.Location = New System.Drawing.Point(12, 18)
        Me.label489.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label489.Name = "label489"
        Me.label489.Size = New System.Drawing.Size(75, 13)
        Me.label489.TabIndex = 9
        Me.label489.Text = "MPEG version"
        '
        'tabPage141
        '
        Me.tabPage141.Location = New System.Drawing.Point(4, 22)
        Me.tabPage141.Name = "tabPage141"
        Me.tabPage141.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage141.Size = New System.Drawing.Size(270, 364)
        Me.tabPage141.TabIndex = 1
        Me.tabPage141.Text = "Tags"
        Me.tabPage141.UseVisualStyleBackColor = true
        '
        'TabPage79
        '
        Me.TabPage79.Controls.Add(Me.label504)
        Me.TabPage79.Controls.Add(Me.edGIFHeight)
        Me.TabPage79.Controls.Add(Me.edGIFWidth)
        Me.TabPage79.Controls.Add(Me.Label25)
        Me.TabPage79.Controls.Add(Me.edGIFFrameRate)
        Me.TabPage79.Controls.Add(Me.label251)
        Me.TabPage79.Location = New System.Drawing.Point(4, 22)
        Me.TabPage79.Name = "TabPage79"
        Me.TabPage79.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage79.Size = New System.Drawing.Size(284, 399)
        Me.TabPage79.TabIndex = 19
        Me.TabPage79.Text = "GIF"
        Me.TabPage79.UseVisualStyleBackColor = true
        '
        'label504
        '
        Me.label504.AutoSize = true
        Me.label504.Location = New System.Drawing.Point(52, 82)
        Me.label504.Name = "label504"
        Me.label504.Size = New System.Drawing.Size(12, 13)
        Me.label504.TabIndex = 11
        Me.label504.Text = "x"
        '
        'edGIFHeight
        '
        Me.edGIFHeight.Location = New System.Drawing.Point(66, 79)
        Me.edGIFHeight.Name = "edGIFHeight"
        Me.edGIFHeight.Size = New System.Drawing.Size(36, 20)
        Me.edGIFHeight.TabIndex = 10
        Me.edGIFHeight.Text = "0"
        '
        'edGIFWidth
        '
        Me.edGIFWidth.Location = New System.Drawing.Point(15, 79)
        Me.edGIFWidth.Name = "edGIFWidth"
        Me.edGIFWidth.Size = New System.Drawing.Size(35, 20)
        Me.edGIFWidth.TabIndex = 9
        Me.edGIFWidth.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Location = New System.Drawing.Point(12, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 13)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Custom resolution"
        '
        'edGIFFrameRate
        '
        Me.edGIFFrameRate.Location = New System.Drawing.Point(15, 30)
        Me.edGIFFrameRate.Name = "edGIFFrameRate"
        Me.edGIFFrameRate.Size = New System.Drawing.Size(87, 20)
        Me.edGIFFrameRate.TabIndex = 7
        Me.edGIFFrameRate.Text = "3"
        '
        'label251
        '
        Me.label251.AutoSize = true
        Me.label251.Location = New System.Drawing.Point(12, 14)
        Me.label251.Name = "label251"
        Me.label251.Size = New System.Drawing.Size(57, 13)
        Me.label251.TabIndex = 6
        Me.label251.Text = "Frame rate"
        '
        'label9
        '
        Me.label9.AutoSize = true
        Me.label9.Location = New System.Drawing.Point(16, 440)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(71, 13)
        Me.label9.TabIndex = 5
        Me.label9.Text = "Output format"
        '
        'tabPage31
        '
        Me.tabPage31.Controls.Add(Me.tabControl17)
        Me.tabPage31.Location = New System.Drawing.Point(4, 22)
        Me.tabPage31.Name = "tabPage31"
        Me.tabPage31.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage31.Size = New System.Drawing.Size(302, 494)
        Me.tabPage31.TabIndex = 4
        Me.tabPage31.Text = "Video processing"
        Me.tabPage31.UseVisualStyleBackColor = true
        '
        'tabControl17
        '
        Me.tabControl17.Controls.Add(Me.tabPage68)
        Me.tabControl17.Controls.Add(Me.tabPage69)
        Me.tabControl17.Controls.Add(Me.tabPage59)
        Me.tabControl17.Controls.Add(Me.TabPage82)
        Me.tabControl17.Controls.Add(Me.TabPage20)
        Me.tabControl17.Controls.Add(Me.TabPage21)
        Me.tabControl17.Controls.Add(Me.tabPage70)
        Me.tabControl17.Controls.Add(Me.TabPage81)
        Me.tabControl17.Location = New System.Drawing.Point(1, 6)
        Me.tabControl17.Name = "tabControl17"
        Me.tabControl17.SelectedIndex = 0
        Me.tabControl17.Size = New System.Drawing.Size(298, 485)
        Me.tabControl17.TabIndex = 37
        '
        'tabPage68
        '
        Me.tabPage68.Controls.Add(Me.label201)
        Me.tabPage68.Controls.Add(Me.label200)
        Me.tabPage68.Controls.Add(Me.label199)
        Me.tabPage68.Controls.Add(Me.label198)
        Me.tabPage68.Controls.Add(Me.tabControl7)
        Me.tabPage68.Controls.Add(Me.tbContrast)
        Me.tabPage68.Controls.Add(Me.tbDarkness)
        Me.tabPage68.Controls.Add(Me.tbLightness)
        Me.tabPage68.Controls.Add(Me.tbSaturation)
        Me.tabPage68.Controls.Add(Me.cbInvert)
        Me.tabPage68.Controls.Add(Me.cbGreyscale)
        Me.tabPage68.Controls.Add(Me.cbEffects)
        Me.tabPage68.Location = New System.Drawing.Point(4, 22)
        Me.tabPage68.Name = "tabPage68"
        Me.tabPage68.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage68.Size = New System.Drawing.Size(290, 459)
        Me.tabPage68.TabIndex = 0
        Me.tabPage68.Text = "Effects"
        Me.tabPage68.UseVisualStyleBackColor = true
        '
        'label201
        '
        Me.label201.AutoSize = true
        Me.label201.Location = New System.Drawing.Point(142, 88)
        Me.label201.Name = "label201"
        Me.label201.Size = New System.Drawing.Size(52, 13)
        Me.label201.TabIndex = 63
        Me.label201.Text = "Darkness"
        '
        'label200
        '
        Me.label200.AutoSize = true
        Me.label200.Location = New System.Drawing.Point(6, 88)
        Me.label200.Name = "label200"
        Me.label200.Size = New System.Drawing.Size(46, 13)
        Me.label200.TabIndex = 62
        Me.label200.Text = "Contrast"
        '
        'label199
        '
        Me.label199.AutoSize = true
        Me.label199.Location = New System.Drawing.Point(142, 36)
        Me.label199.Name = "label199"
        Me.label199.Size = New System.Drawing.Size(55, 13)
        Me.label199.TabIndex = 61
        Me.label199.Text = "Saturation"
        '
        'label198
        '
        Me.label198.AutoSize = true
        Me.label198.Location = New System.Drawing.Point(6, 36)
        Me.label198.Name = "label198"
        Me.label198.Size = New System.Drawing.Size(52, 13)
        Me.label198.TabIndex = 60
        Me.label198.Text = "Lightness"
        '
        'tabControl7
        '
        Me.tabControl7.Controls.Add(Me.tabPage29)
        Me.tabControl7.Controls.Add(Me.tabPage42)
        Me.tabControl7.Controls.Add(Me.TabPage7)
        Me.tabControl7.Controls.Add(Me.TabPage16)
        Me.tabControl7.Controls.Add(Me.TabPage33)
        Me.tabControl7.Location = New System.Drawing.Point(3, 185)
        Me.tabControl7.Name = "tabControl7"
        Me.tabControl7.SelectedIndex = 0
        Me.tabControl7.Size = New System.Drawing.Size(283, 274)
        Me.tabControl7.TabIndex = 59
        '
        'tabPage29
        '
        Me.tabPage29.Controls.Add(Me.cbTextLogoDateTime)
        Me.tabPage29.Controls.Add(Me.btTextLogoUpdateParams)
        Me.tabPage29.Controls.Add(Me.tabControl8)
        Me.tabPage29.Controls.Add(Me.btFont)
        Me.tabPage29.Controls.Add(Me.edTextLogo)
        Me.tabPage29.Controls.Add(Me.cbTextLogo)
        Me.tabPage29.Location = New System.Drawing.Point(4, 22)
        Me.tabPage29.Name = "tabPage29"
        Me.tabPage29.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage29.Size = New System.Drawing.Size(275, 248)
        Me.tabPage29.TabIndex = 0
        Me.tabPage29.Text = "Text logo"
        Me.tabPage29.UseVisualStyleBackColor = true
        '
        'cbTextLogoDateTime
        '
        Me.cbTextLogoDateTime.AutoSize = true
        Me.cbTextLogoDateTime.Location = New System.Drawing.Point(186, 16)
        Me.cbTextLogoDateTime.Name = "cbTextLogoDateTime"
        Me.cbTextLogoDateTime.Size = New System.Drawing.Size(83, 17)
        Me.cbTextLogoDateTime.TabIndex = 22
        Me.cbTextLogoDateTime.Text = "Date / Time"
        Me.cbTextLogoDateTime.UseVisualStyleBackColor = true
        '
        'btTextLogoUpdateParams
        '
        Me.btTextLogoUpdateParams.Location = New System.Drawing.Point(194, 219)
        Me.btTextLogoUpdateParams.Name = "btTextLogoUpdateParams"
        Me.btTextLogoUpdateParams.Size = New System.Drawing.Size(75, 23)
        Me.btTextLogoUpdateParams.TabIndex = 19
        Me.btTextLogoUpdateParams.Text = "Update"
        Me.btTextLogoUpdateParams.UseVisualStyleBackColor = true
        '
        'tabControl8
        '
        Me.tabControl8.Controls.Add(Me.tabPage35)
        Me.tabControl8.Controls.Add(Me.tabPage36)
        Me.tabControl8.Controls.Add(Me.tabPage37)
        Me.tabControl8.Controls.Add(Me.tabPage38)
        Me.tabControl8.Controls.Add(Me.tabPage39)
        Me.tabControl8.Controls.Add(Me.tabPage40)
        Me.tabControl8.Controls.Add(Me.tabPage41)
        Me.tabControl8.Location = New System.Drawing.Point(8, 73)
        Me.tabControl8.Name = "tabControl8"
        Me.tabControl8.SelectedIndex = 0
        Me.tabControl8.Size = New System.Drawing.Size(261, 140)
        Me.tabControl8.TabIndex = 18
        '
        'tabPage35
        '
        Me.tabPage35.Controls.Add(Me.label39)
        Me.tabPage35.Controls.Add(Me.pnTextLogoBGColor)
        Me.tabPage35.Controls.Add(Me.label40)
        Me.tabPage35.Controls.Add(Me.cbTextLogoTranspBG)
        Me.tabPage35.Controls.Add(Me.cbTextLogoRightToLeft)
        Me.tabPage35.Controls.Add(Me.cbTextLogoVertical)
        Me.tabPage35.Controls.Add(Me.cbTextLogoAlign)
        Me.tabPage35.Controls.Add(Me.label41)
        Me.tabPage35.Controls.Add(Me.tbTextLogoTransp)
        Me.tabPage35.Location = New System.Drawing.Point(4, 22)
        Me.tabPage35.Name = "tabPage35"
        Me.tabPage35.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage35.Size = New System.Drawing.Size(253, 114)
        Me.tabPage35.TabIndex = 0
        Me.tabPage35.Text = "Main"
        Me.tabPage35.UseVisualStyleBackColor = true
        '
        'label39
        '
        Me.label39.AutoSize = true
        Me.label39.Location = New System.Drawing.Point(146, 65)
        Me.label39.Name = "label39"
        Me.label39.Size = New System.Drawing.Size(103, 13)
        Me.label39.TabIndex = 26
        Me.label39.Text = "Transparency (layer)"
        '
        'pnTextLogoBGColor
        '
        Me.pnTextLogoBGColor.BackColor = System.Drawing.Color.Silver
        Me.pnTextLogoBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoBGColor.Location = New System.Drawing.Point(87, 83)
        Me.pnTextLogoBGColor.Name = "pnTextLogoBGColor"
        Me.pnTextLogoBGColor.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoBGColor.TabIndex = 25
        '
        'label40
        '
        Me.label40.AutoSize = true
        Me.label40.Location = New System.Drawing.Point(45, 88)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(31, 13)
        Me.label40.TabIndex = 24
        Me.label40.Text = "Color"
        '
        'cbTextLogoTranspBG
        '
        Me.cbTextLogoTranspBG.AutoSize = true
        Me.cbTextLogoTranspBG.Checked = true
        Me.cbTextLogoTranspBG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTextLogoTranspBG.Location = New System.Drawing.Point(15, 64)
        Me.cbTextLogoTranspBG.Name = "cbTextLogoTranspBG"
        Me.cbTextLogoTranspBG.Size = New System.Drawing.Size(122, 17)
        Me.cbTextLogoTranspBG.TabIndex = 23
        Me.cbTextLogoTranspBG.Text = "Transp. background"
        Me.cbTextLogoTranspBG.UseVisualStyleBackColor = true
        '
        'cbTextLogoRightToLeft
        '
        Me.cbTextLogoRightToLeft.AutoSize = true
        Me.cbTextLogoRightToLeft.Location = New System.Drawing.Point(149, 35)
        Me.cbTextLogoRightToLeft.Name = "cbTextLogoRightToLeft"
        Me.cbTextLogoRightToLeft.Size = New System.Drawing.Size(88, 17)
        Me.cbTextLogoRightToLeft.TabIndex = 22
        Me.cbTextLogoRightToLeft.Text = "Right-To-Left"
        Me.cbTextLogoRightToLeft.UseVisualStyleBackColor = true
        '
        'cbTextLogoVertical
        '
        Me.cbTextLogoVertical.AutoSize = true
        Me.cbTextLogoVertical.Location = New System.Drawing.Point(149, 16)
        Me.cbTextLogoVertical.Name = "cbTextLogoVertical"
        Me.cbTextLogoVertical.Size = New System.Drawing.Size(61, 17)
        Me.cbTextLogoVertical.TabIndex = 21
        Me.cbTextLogoVertical.Text = "Vertical"
        Me.cbTextLogoVertical.UseVisualStyleBackColor = true
        '
        'cbTextLogoAlign
        '
        Me.cbTextLogoAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoAlign.FormattingEnabled = true
        Me.cbTextLogoAlign.Items.AddRange(New Object() {"left", "center", "right"})
        Me.cbTextLogoAlign.Location = New System.Drawing.Point(48, 14)
        Me.cbTextLogoAlign.Name = "cbTextLogoAlign"
        Me.cbTextLogoAlign.Size = New System.Drawing.Size(71, 21)
        Me.cbTextLogoAlign.TabIndex = 20
        '
        'label41
        '
        Me.label41.AutoSize = true
        Me.label41.Location = New System.Drawing.Point(12, 17)
        Me.label41.Name = "label41"
        Me.label41.Size = New System.Drawing.Size(30, 13)
        Me.label41.TabIndex = 19
        Me.label41.Text = "Align"
        '
        'tbTextLogoTransp
        '
        Me.tbTextLogoTransp.BackColor = System.Drawing.SystemColors.Window
        Me.tbTextLogoTransp.Location = New System.Drawing.Point(146, 84)
        Me.tbTextLogoTransp.Maximum = 255
        Me.tbTextLogoTransp.Name = "tbTextLogoTransp"
        Me.tbTextLogoTransp.Size = New System.Drawing.Size(104, 45)
        Me.tbTextLogoTransp.TabIndex = 18
        Me.tbTextLogoTransp.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbTextLogoTransp.Value = 127
        '
        'tabPage36
        '
        Me.tabPage36.Controls.Add(Me.cbTextLogoGradMode)
        Me.tabPage36.Controls.Add(Me.label107)
        Me.tabPage36.Controls.Add(Me.pnTextLogoGradColor2)
        Me.tabPage36.Controls.Add(Me.label135)
        Me.tabPage36.Controls.Add(Me.pnTextLogoGradColor1)
        Me.tabPage36.Controls.Add(Me.label136)
        Me.tabPage36.Controls.Add(Me.cbTextLogoGradientEnabled)
        Me.tabPage36.Location = New System.Drawing.Point(4, 22)
        Me.tabPage36.Name = "tabPage36"
        Me.tabPage36.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage36.Size = New System.Drawing.Size(253, 114)
        Me.tabPage36.TabIndex = 1
        Me.tabPage36.Text = "Gradient"
        Me.tabPage36.UseVisualStyleBackColor = true
        '
        'cbTextLogoGradMode
        '
        Me.cbTextLogoGradMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoGradMode.FormattingEnabled = true
        Me.cbTextLogoGradMode.Items.AddRange(New Object() {"Horizontal", "Vertical", "Forward diagonal", "Backward diagonal"})
        Me.cbTextLogoGradMode.Location = New System.Drawing.Point(143, 69)
        Me.cbTextLogoGradMode.Name = "cbTextLogoGradMode"
        Me.cbTextLogoGradMode.Size = New System.Drawing.Size(104, 21)
        Me.cbTextLogoGradMode.TabIndex = 31
        '
        'label107
        '
        Me.label107.AutoSize = true
        Me.label107.Location = New System.Drawing.Point(140, 53)
        Me.label107.Name = "label107"
        Me.label107.Size = New System.Drawing.Size(34, 13)
        Me.label107.TabIndex = 30
        Me.label107.Text = "Mode"
        '
        'pnTextLogoGradColor2
        '
        Me.pnTextLogoGradColor2.BackColor = System.Drawing.Color.Black
        Me.pnTextLogoGradColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoGradColor2.Location = New System.Drawing.Point(87, 74)
        Me.pnTextLogoGradColor2.Name = "pnTextLogoGradColor2"
        Me.pnTextLogoGradColor2.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoGradColor2.TabIndex = 29
        '
        'label135
        '
        Me.label135.AutoSize = true
        Me.label135.Location = New System.Drawing.Point(37, 80)
        Me.label135.Name = "label135"
        Me.label135.Size = New System.Drawing.Size(40, 13)
        Me.label135.TabIndex = 28
        Me.label135.Text = "Color 2"
        '
        'pnTextLogoGradColor1
        '
        Me.pnTextLogoGradColor1.BackColor = System.Drawing.Color.White
        Me.pnTextLogoGradColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoGradColor1.Location = New System.Drawing.Point(87, 42)
        Me.pnTextLogoGradColor1.Name = "pnTextLogoGradColor1"
        Me.pnTextLogoGradColor1.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoGradColor1.TabIndex = 27
        '
        'label136
        '
        Me.label136.AutoSize = true
        Me.label136.Location = New System.Drawing.Point(37, 48)
        Me.label136.Name = "label136"
        Me.label136.Size = New System.Drawing.Size(40, 13)
        Me.label136.TabIndex = 26
        Me.label136.Text = "Color 1"
        '
        'cbTextLogoGradientEnabled
        '
        Me.cbTextLogoGradientEnabled.AutoSize = true
        Me.cbTextLogoGradientEnabled.Location = New System.Drawing.Point(12, 12)
        Me.cbTextLogoGradientEnabled.Name = "cbTextLogoGradientEnabled"
        Me.cbTextLogoGradientEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbTextLogoGradientEnabled.TabIndex = 0
        Me.cbTextLogoGradientEnabled.Text = "Enabled"
        Me.cbTextLogoGradientEnabled.UseVisualStyleBackColor = true
        '
        'tabPage37
        '
        Me.tabPage37.Controls.Add(Me.edTextLogoHeight)
        Me.tabPage37.Controls.Add(Me.label137)
        Me.tabPage37.Controls.Add(Me.edTextLogoWidth)
        Me.tabPage37.Controls.Add(Me.label138)
        Me.tabPage37.Controls.Add(Me.cbTextLogoUseRect)
        Me.tabPage37.Controls.Add(Me.edTextLogoTop)
        Me.tabPage37.Controls.Add(Me.label139)
        Me.tabPage37.Controls.Add(Me.edTextLogoLeft)
        Me.tabPage37.Controls.Add(Me.label140)
        Me.tabPage37.Location = New System.Drawing.Point(4, 22)
        Me.tabPage37.Name = "tabPage37"
        Me.tabPage37.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage37.Size = New System.Drawing.Size(253, 114)
        Me.tabPage37.TabIndex = 2
        Me.tabPage37.Text = "Position"
        Me.tabPage37.UseVisualStyleBackColor = true
        '
        'edTextLogoHeight
        '
        Me.edTextLogoHeight.Location = New System.Drawing.Point(193, 71)
        Me.edTextLogoHeight.Name = "edTextLogoHeight"
        Me.edTextLogoHeight.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoHeight.TabIndex = 8
        Me.edTextLogoHeight.Text = "100"
        '
        'label137
        '
        Me.label137.AutoSize = true
        Me.label137.Location = New System.Drawing.Point(151, 74)
        Me.label137.Name = "label137"
        Me.label137.Size = New System.Drawing.Size(38, 13)
        Me.label137.TabIndex = 7
        Me.label137.Text = "Height"
        '
        'edTextLogoWidth
        '
        Me.edTextLogoWidth.Location = New System.Drawing.Point(193, 45)
        Me.edTextLogoWidth.Name = "edTextLogoWidth"
        Me.edTextLogoWidth.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoWidth.TabIndex = 6
        Me.edTextLogoWidth.Text = "200"
        '
        'label138
        '
        Me.label138.AutoSize = true
        Me.label138.Location = New System.Drawing.Point(151, 48)
        Me.label138.Name = "label138"
        Me.label138.Size = New System.Drawing.Size(35, 13)
        Me.label138.TabIndex = 5
        Me.label138.Text = "Width"
        '
        'cbTextLogoUseRect
        '
        Me.cbTextLogoUseRect.AutoSize = true
        Me.cbTextLogoUseRect.Location = New System.Drawing.Point(132, 18)
        Me.cbTextLogoUseRect.Name = "cbTextLogoUseRect"
        Me.cbTextLogoUseRect.Size = New System.Drawing.Size(66, 17)
        Me.cbTextLogoUseRect.TabIndex = 4
        Me.cbTextLogoUseRect.Text = "Use rect"
        Me.cbTextLogoUseRect.UseVisualStyleBackColor = true
        '
        'edTextLogoTop
        '
        Me.edTextLogoTop.Location = New System.Drawing.Point(62, 42)
        Me.edTextLogoTop.Name = "edTextLogoTop"
        Me.edTextLogoTop.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoTop.TabIndex = 3
        Me.edTextLogoTop.Text = "50"
        '
        'label139
        '
        Me.label139.AutoSize = true
        Me.label139.Location = New System.Drawing.Point(20, 45)
        Me.label139.Name = "label139"
        Me.label139.Size = New System.Drawing.Size(26, 13)
        Me.label139.TabIndex = 2
        Me.label139.Text = "Top"
        '
        'edTextLogoLeft
        '
        Me.edTextLogoLeft.Location = New System.Drawing.Point(62, 16)
        Me.edTextLogoLeft.Name = "edTextLogoLeft"
        Me.edTextLogoLeft.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoLeft.TabIndex = 1
        Me.edTextLogoLeft.Text = "50"
        '
        'label140
        '
        Me.label140.AutoSize = true
        Me.label140.Location = New System.Drawing.Point(20, 19)
        Me.label140.Name = "label140"
        Me.label140.Size = New System.Drawing.Size(25, 13)
        Me.label140.TabIndex = 0
        Me.label140.Text = "Left"
        '
        'tabPage38
        '
        Me.tabPage38.Controls.Add(Me.cbTextLogoDrawMode)
        Me.tabPage38.Controls.Add(Me.cbTextLogoAntialiasing)
        Me.tabPage38.Controls.Add(Me.label141)
        Me.tabPage38.Controls.Add(Me.label142)
        Me.tabPage38.Location = New System.Drawing.Point(4, 22)
        Me.tabPage38.Name = "tabPage38"
        Me.tabPage38.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage38.Size = New System.Drawing.Size(253, 114)
        Me.tabPage38.TabIndex = 3
        Me.tabPage38.Text = "Quality"
        Me.tabPage38.UseVisualStyleBackColor = true
        '
        'cbTextLogoDrawMode
        '
        Me.cbTextLogoDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoDrawMode.FormattingEnabled = true
        Me.cbTextLogoDrawMode.Items.AddRange(New Object() {"Bicubic HQ", "Bilinear HQ", "Nearest Neighbor", "Bicubic", "Bilinear", "Standard HQ", "Standard LQ,", "System default"})
        Me.cbTextLogoDrawMode.Location = New System.Drawing.Point(97, 41)
        Me.cbTextLogoDrawMode.Name = "cbTextLogoDrawMode"
        Me.cbTextLogoDrawMode.Size = New System.Drawing.Size(121, 21)
        Me.cbTextLogoDrawMode.TabIndex = 3
        '
        'cbTextLogoAntialiasing
        '
        Me.cbTextLogoAntialiasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoAntialiasing.FormattingEnabled = true
        Me.cbTextLogoAntialiasing.Items.AddRange(New Object() {"System default", "Single Bit Per Pixel (Grid Fit)", "Single Bit Per Pixel", "AntiAlias (GridFit)", "AntiAlias", "ClearType"})
        Me.cbTextLogoAntialiasing.Location = New System.Drawing.Point(97, 14)
        Me.cbTextLogoAntialiasing.Name = "cbTextLogoAntialiasing"
        Me.cbTextLogoAntialiasing.Size = New System.Drawing.Size(121, 21)
        Me.cbTextLogoAntialiasing.TabIndex = 2
        '
        'label141
        '
        Me.label141.AutoSize = true
        Me.label141.Location = New System.Drawing.Point(12, 44)
        Me.label141.Name = "label141"
        Me.label141.Size = New System.Drawing.Size(61, 13)
        Me.label141.TabIndex = 1
        Me.label141.Text = "Draw mode"
        '
        'label142
        '
        Me.label142.AutoSize = true
        Me.label142.Location = New System.Drawing.Point(12, 17)
        Me.label142.Name = "label142"
        Me.label142.Size = New System.Drawing.Size(60, 13)
        Me.label142.TabIndex = 0
        Me.label142.Text = "Antialiasing"
        '
        'tabPage39
        '
        Me.tabPage39.Controls.Add(Me.edTextLogoOuterSize)
        Me.tabPage39.Controls.Add(Me.label143)
        Me.tabPage39.Controls.Add(Me.edTextLogoInnerSize)
        Me.tabPage39.Controls.Add(Me.label144)
        Me.tabPage39.Controls.Add(Me.pnTextLogoOuterColor)
        Me.tabPage39.Controls.Add(Me.label145)
        Me.tabPage39.Controls.Add(Me.pnTextLogoInnerColor)
        Me.tabPage39.Controls.Add(Me.label146)
        Me.tabPage39.Controls.Add(Me.cbTextLogoEffectrMode)
        Me.tabPage39.Controls.Add(Me.label147)
        Me.tabPage39.Location = New System.Drawing.Point(4, 22)
        Me.tabPage39.Name = "tabPage39"
        Me.tabPage39.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage39.Size = New System.Drawing.Size(253, 114)
        Me.tabPage39.TabIndex = 4
        Me.tabPage39.Text = "Effects"
        Me.tabPage39.UseVisualStyleBackColor = true
        '
        'edTextLogoOuterSize
        '
        Me.edTextLogoOuterSize.Location = New System.Drawing.Point(214, 88)
        Me.edTextLogoOuterSize.Name = "edTextLogoOuterSize"
        Me.edTextLogoOuterSize.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoOuterSize.TabIndex = 37
        Me.edTextLogoOuterSize.Text = "1"
        '
        'label143
        '
        Me.label143.AutoSize = true
        Me.label143.Location = New System.Drawing.Point(138, 91)
        Me.label143.Name = "label143"
        Me.label143.Size = New System.Drawing.Size(65, 13)
        Me.label143.TabIndex = 36
        Me.label143.Text = "Second size"
        '
        'edTextLogoInnerSize
        '
        Me.edTextLogoInnerSize.Location = New System.Drawing.Point(72, 88)
        Me.edTextLogoInnerSize.Name = "edTextLogoInnerSize"
        Me.edTextLogoInnerSize.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoInnerSize.TabIndex = 35
        Me.edTextLogoInnerSize.Text = "1"
        '
        'label144
        '
        Me.label144.AutoSize = true
        Me.label144.Location = New System.Drawing.Point(14, 91)
        Me.label144.Name = "label144"
        Me.label144.Size = New System.Drawing.Size(47, 13)
        Me.label144.TabIndex = 34
        Me.label144.Text = "First size"
        '
        'pnTextLogoOuterColor
        '
        Me.pnTextLogoOuterColor.BackColor = System.Drawing.Color.Black
        Me.pnTextLogoOuterColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoOuterColor.Location = New System.Drawing.Point(214, 48)
        Me.pnTextLogoOuterColor.Name = "pnTextLogoOuterColor"
        Me.pnTextLogoOuterColor.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoOuterColor.TabIndex = 33
        '
        'label145
        '
        Me.label145.AutoSize = true
        Me.label145.Location = New System.Drawing.Point(138, 54)
        Me.label145.Name = "label145"
        Me.label145.Size = New System.Drawing.Size(70, 13)
        Me.label145.TabIndex = 32
        Me.label145.Text = "Second color"
        '
        'pnTextLogoInnerColor
        '
        Me.pnTextLogoInnerColor.BackColor = System.Drawing.Color.White
        Me.pnTextLogoInnerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoInnerColor.Location = New System.Drawing.Point(72, 48)
        Me.pnTextLogoInnerColor.Name = "pnTextLogoInnerColor"
        Me.pnTextLogoInnerColor.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoInnerColor.TabIndex = 31
        '
        'label146
        '
        Me.label146.AutoSize = true
        Me.label146.Location = New System.Drawing.Point(14, 54)
        Me.label146.Name = "label146"
        Me.label146.Size = New System.Drawing.Size(52, 13)
        Me.label146.TabIndex = 30
        Me.label146.Text = "First color"
        '
        'cbTextLogoEffectrMode
        '
        Me.cbTextLogoEffectrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoEffectrMode.FormattingEnabled = true
        Me.cbTextLogoEffectrMode.Items.AddRange(New Object() {"None", "Inner border", "Outer border", "Inner and outer borders", "Embossed", "Outline", "Filled outline", "Halo"})
        Me.cbTextLogoEffectrMode.Location = New System.Drawing.Point(72, 14)
        Me.cbTextLogoEffectrMode.Name = "cbTextLogoEffectrMode"
        Me.cbTextLogoEffectrMode.Size = New System.Drawing.Size(166, 21)
        Me.cbTextLogoEffectrMode.TabIndex = 1
        '
        'label147
        '
        Me.label147.AutoSize = true
        Me.label147.Location = New System.Drawing.Point(14, 17)
        Me.label147.Name = "label147"
        Me.label147.Size = New System.Drawing.Size(34, 13)
        Me.label147.TabIndex = 0
        Me.label147.Text = "Mode"
        '
        'tabPage40
        '
        Me.tabPage40.Controls.Add(Me.groupBox16)
        Me.tabPage40.Controls.Add(Me.groupBox17)
        Me.tabPage40.Location = New System.Drawing.Point(4, 22)
        Me.tabPage40.Name = "tabPage40"
        Me.tabPage40.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage40.Size = New System.Drawing.Size(253, 114)
        Me.tabPage40.TabIndex = 5
        Me.tabPage40.Text = "Rotation"
        Me.tabPage40.UseVisualStyleBackColor = true
        '
        'groupBox16
        '
        Me.groupBox16.Controls.Add(Me.rbTextLogoFlipXY)
        Me.groupBox16.Controls.Add(Me.rbTextLogoFlipY)
        Me.groupBox16.Controls.Add(Me.rbTextLogoFlipX)
        Me.groupBox16.Controls.Add(Me.rbTextLogoFlipNone)
        Me.groupBox16.Location = New System.Drawing.Point(6, 58)
        Me.groupBox16.Name = "groupBox16"
        Me.groupBox16.Size = New System.Drawing.Size(241, 46)
        Me.groupBox16.TabIndex = 1
        Me.groupBox16.TabStop = false
        Me.groupBox16.Text = "Flip"
        '
        'rbTextLogoFlipXY
        '
        Me.rbTextLogoFlipXY.AutoSize = true
        Me.rbTextLogoFlipXY.Location = New System.Drawing.Point(190, 19)
        Me.rbTextLogoFlipXY.Name = "rbTextLogoFlipXY"
        Me.rbTextLogoFlipXY.Size = New System.Drawing.Size(51, 17)
        Me.rbTextLogoFlipXY.TabIndex = 3
        Me.rbTextLogoFlipXY.TabStop = true
        Me.rbTextLogoFlipXY.Text = "X && Y"
        Me.rbTextLogoFlipXY.UseVisualStyleBackColor = true
        '
        'rbTextLogoFlipY
        '
        Me.rbTextLogoFlipY.AutoSize = true
        Me.rbTextLogoFlipY.Location = New System.Drawing.Point(125, 19)
        Me.rbTextLogoFlipY.Name = "rbTextLogoFlipY"
        Me.rbTextLogoFlipY.Size = New System.Drawing.Size(32, 17)
        Me.rbTextLogoFlipY.TabIndex = 2
        Me.rbTextLogoFlipY.TabStop = true
        Me.rbTextLogoFlipY.Text = "Y"
        Me.rbTextLogoFlipY.UseVisualStyleBackColor = true
        '
        'rbTextLogoFlipX
        '
        Me.rbTextLogoFlipX.AutoSize = true
        Me.rbTextLogoFlipX.Location = New System.Drawing.Point(66, 19)
        Me.rbTextLogoFlipX.Name = "rbTextLogoFlipX"
        Me.rbTextLogoFlipX.Size = New System.Drawing.Size(32, 17)
        Me.rbTextLogoFlipX.TabIndex = 1
        Me.rbTextLogoFlipX.TabStop = true
        Me.rbTextLogoFlipX.Text = "X"
        Me.rbTextLogoFlipX.UseVisualStyleBackColor = true
        '
        'rbTextLogoFlipNone
        '
        Me.rbTextLogoFlipNone.AutoSize = true
        Me.rbTextLogoFlipNone.Checked = true
        Me.rbTextLogoFlipNone.Location = New System.Drawing.Point(13, 19)
        Me.rbTextLogoFlipNone.Name = "rbTextLogoFlipNone"
        Me.rbTextLogoFlipNone.Size = New System.Drawing.Size(51, 17)
        Me.rbTextLogoFlipNone.TabIndex = 0
        Me.rbTextLogoFlipNone.TabStop = true
        Me.rbTextLogoFlipNone.Text = "None"
        Me.rbTextLogoFlipNone.UseVisualStyleBackColor = true
        '
        'groupBox17
        '
        Me.groupBox17.Controls.Add(Me.rbTextLogoDegree270)
        Me.groupBox17.Controls.Add(Me.rbTextLogoDegree180)
        Me.groupBox17.Controls.Add(Me.rbTextLogoDegree90)
        Me.groupBox17.Controls.Add(Me.rbTextLogoDegree0)
        Me.groupBox17.Location = New System.Drawing.Point(6, 6)
        Me.groupBox17.Name = "groupBox17"
        Me.groupBox17.Size = New System.Drawing.Size(241, 46)
        Me.groupBox17.TabIndex = 0
        Me.groupBox17.TabStop = false
        Me.groupBox17.Text = "Degree"
        '
        'rbTextLogoDegree270
        '
        Me.rbTextLogoDegree270.AutoSize = true
        Me.rbTextLogoDegree270.Location = New System.Drawing.Point(190, 19)
        Me.rbTextLogoDegree270.Name = "rbTextLogoDegree270"
        Me.rbTextLogoDegree270.Size = New System.Drawing.Size(43, 17)
        Me.rbTextLogoDegree270.TabIndex = 3
        Me.rbTextLogoDegree270.TabStop = true
        Me.rbTextLogoDegree270.Text = "270"
        Me.rbTextLogoDegree270.UseVisualStyleBackColor = true
        '
        'rbTextLogoDegree180
        '
        Me.rbTextLogoDegree180.AutoSize = true
        Me.rbTextLogoDegree180.Location = New System.Drawing.Point(125, 19)
        Me.rbTextLogoDegree180.Name = "rbTextLogoDegree180"
        Me.rbTextLogoDegree180.Size = New System.Drawing.Size(43, 17)
        Me.rbTextLogoDegree180.TabIndex = 2
        Me.rbTextLogoDegree180.TabStop = true
        Me.rbTextLogoDegree180.Text = "180"
        Me.rbTextLogoDegree180.UseVisualStyleBackColor = true
        '
        'rbTextLogoDegree90
        '
        Me.rbTextLogoDegree90.AutoSize = true
        Me.rbTextLogoDegree90.Location = New System.Drawing.Point(66, 19)
        Me.rbTextLogoDegree90.Name = "rbTextLogoDegree90"
        Me.rbTextLogoDegree90.Size = New System.Drawing.Size(37, 17)
        Me.rbTextLogoDegree90.TabIndex = 1
        Me.rbTextLogoDegree90.TabStop = true
        Me.rbTextLogoDegree90.Text = "90"
        Me.rbTextLogoDegree90.UseVisualStyleBackColor = true
        '
        'rbTextLogoDegree0
        '
        Me.rbTextLogoDegree0.AutoSize = true
        Me.rbTextLogoDegree0.Checked = true
        Me.rbTextLogoDegree0.Location = New System.Drawing.Point(13, 19)
        Me.rbTextLogoDegree0.Name = "rbTextLogoDegree0"
        Me.rbTextLogoDegree0.Size = New System.Drawing.Size(31, 17)
        Me.rbTextLogoDegree0.TabIndex = 0
        Me.rbTextLogoDegree0.TabStop = true
        Me.rbTextLogoDegree0.Text = "0"
        Me.rbTextLogoDegree0.UseVisualStyleBackColor = true
        '
        'tabPage41
        '
        Me.tabPage41.Controls.Add(Me.edTextLogoShapeHeight)
        Me.tabPage41.Controls.Add(Me.label148)
        Me.tabPage41.Controls.Add(Me.edTextLogoShapeWidth)
        Me.tabPage41.Controls.Add(Me.label149)
        Me.tabPage41.Controls.Add(Me.edTextLogoShapeTop)
        Me.tabPage41.Controls.Add(Me.label150)
        Me.tabPage41.Controls.Add(Me.edTextLogoShapeLeft)
        Me.tabPage41.Controls.Add(Me.label151)
        Me.tabPage41.Controls.Add(Me.cbTextLogoShapeType)
        Me.tabPage41.Controls.Add(Me.label152)
        Me.tabPage41.Controls.Add(Me.pnTextLogoShapeColor)
        Me.tabPage41.Controls.Add(Me.label153)
        Me.tabPage41.Controls.Add(Me.cbTextLogoShapeEnabled)
        Me.tabPage41.Location = New System.Drawing.Point(4, 22)
        Me.tabPage41.Name = "tabPage41"
        Me.tabPage41.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage41.Size = New System.Drawing.Size(253, 114)
        Me.tabPage41.TabIndex = 6
        Me.tabPage41.Text = "Shape"
        Me.tabPage41.UseVisualStyleBackColor = true
        '
        'edTextLogoShapeHeight
        '
        Me.edTextLogoShapeHeight.Location = New System.Drawing.Point(201, 88)
        Me.edTextLogoShapeHeight.Name = "edTextLogoShapeHeight"
        Me.edTextLogoShapeHeight.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoShapeHeight.TabIndex = 46
        Me.edTextLogoShapeHeight.Text = "100"
        '
        'label148
        '
        Me.label148.AutoSize = true
        Me.label148.Location = New System.Drawing.Point(154, 91)
        Me.label148.Name = "label148"
        Me.label148.Size = New System.Drawing.Size(38, 13)
        Me.label148.TabIndex = 45
        Me.label148.Text = "Height"
        '
        'edTextLogoShapeWidth
        '
        Me.edTextLogoShapeWidth.Location = New System.Drawing.Point(201, 62)
        Me.edTextLogoShapeWidth.Name = "edTextLogoShapeWidth"
        Me.edTextLogoShapeWidth.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoShapeWidth.TabIndex = 44
        Me.edTextLogoShapeWidth.Text = "200"
        '
        'label149
        '
        Me.label149.AutoSize = true
        Me.label149.Location = New System.Drawing.Point(154, 65)
        Me.label149.Name = "label149"
        Me.label149.Size = New System.Drawing.Size(35, 13)
        Me.label149.TabIndex = 43
        Me.label149.Text = "Width"
        '
        'edTextLogoShapeTop
        '
        Me.edTextLogoShapeTop.Location = New System.Drawing.Point(56, 88)
        Me.edTextLogoShapeTop.Name = "edTextLogoShapeTop"
        Me.edTextLogoShapeTop.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoShapeTop.TabIndex = 42
        Me.edTextLogoShapeTop.Text = "50"
        '
        'label150
        '
        Me.label150.AutoSize = true
        Me.label150.Location = New System.Drawing.Point(19, 91)
        Me.label150.Name = "label150"
        Me.label150.Size = New System.Drawing.Size(26, 13)
        Me.label150.TabIndex = 41
        Me.label150.Text = "Top"
        '
        'edTextLogoShapeLeft
        '
        Me.edTextLogoShapeLeft.Location = New System.Drawing.Point(56, 62)
        Me.edTextLogoShapeLeft.Name = "edTextLogoShapeLeft"
        Me.edTextLogoShapeLeft.Size = New System.Drawing.Size(33, 20)
        Me.edTextLogoShapeLeft.TabIndex = 40
        Me.edTextLogoShapeLeft.Text = "50"
        '
        'label151
        '
        Me.label151.AutoSize = true
        Me.label151.Location = New System.Drawing.Point(19, 65)
        Me.label151.Name = "label151"
        Me.label151.Size = New System.Drawing.Size(25, 13)
        Me.label151.TabIndex = 39
        Me.label151.Text = "Left"
        '
        'cbTextLogoShapeType
        '
        Me.cbTextLogoShapeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTextLogoShapeType.FormattingEnabled = true
        Me.cbTextLogoShapeType.Items.AddRange(New Object() {"Rectangle", "Ellipse"})
        Me.cbTextLogoShapeType.Location = New System.Drawing.Point(56, 35)
        Me.cbTextLogoShapeType.Name = "cbTextLogoShapeType"
        Me.cbTextLogoShapeType.Size = New System.Drawing.Size(83, 21)
        Me.cbTextLogoShapeType.TabIndex = 38
        '
        'label152
        '
        Me.label152.AutoSize = true
        Me.label152.Location = New System.Drawing.Point(19, 38)
        Me.label152.Name = "label152"
        Me.label152.Size = New System.Drawing.Size(31, 13)
        Me.label152.TabIndex = 37
        Me.label152.Text = "Type"
        '
        'pnTextLogoShapeColor
        '
        Me.pnTextLogoShapeColor.BackColor = System.Drawing.Color.Silver
        Me.pnTextLogoShapeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnTextLogoShapeColor.Location = New System.Drawing.Point(201, 32)
        Me.pnTextLogoShapeColor.Name = "pnTextLogoShapeColor"
        Me.pnTextLogoShapeColor.Size = New System.Drawing.Size(24, 24)
        Me.pnTextLogoShapeColor.TabIndex = 34
        '
        'label153
        '
        Me.label153.AutoSize = true
        Me.label153.Location = New System.Drawing.Point(154, 38)
        Me.label153.Name = "label153"
        Me.label153.Size = New System.Drawing.Size(31, 13)
        Me.label153.TabIndex = 33
        Me.label153.Text = "Color"
        '
        'cbTextLogoShapeEnabled
        '
        Me.cbTextLogoShapeEnabled.AutoSize = true
        Me.cbTextLogoShapeEnabled.Location = New System.Drawing.Point(12, 12)
        Me.cbTextLogoShapeEnabled.Name = "cbTextLogoShapeEnabled"
        Me.cbTextLogoShapeEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbTextLogoShapeEnabled.TabIndex = 32
        Me.cbTextLogoShapeEnabled.Text = "Enabled"
        Me.cbTextLogoShapeEnabled.UseVisualStyleBackColor = true
        '
        'btFont
        '
        Me.btFont.Location = New System.Drawing.Point(222, 38)
        Me.btFont.Name = "btFont"
        Me.btFont.Size = New System.Drawing.Size(47, 23)
        Me.btFont.TabIndex = 16
        Me.btFont.Text = "Font"
        Me.btFont.UseVisualStyleBackColor = true
        '
        'edTextLogo
        '
        Me.edTextLogo.Location = New System.Drawing.Point(8, 38)
        Me.edTextLogo.Name = "edTextLogo"
        Me.edTextLogo.Size = New System.Drawing.Size(208, 20)
        Me.edTextLogo.TabIndex = 15
        Me.edTextLogo.Text = "Hello!!!"
        '
        'cbTextLogo
        '
        Me.cbTextLogo.AutoSize = true
        Me.cbTextLogo.Location = New System.Drawing.Point(8, 16)
        Me.cbTextLogo.Name = "cbTextLogo"
        Me.cbTextLogo.Size = New System.Drawing.Size(65, 17)
        Me.cbTextLogo.TabIndex = 14
        Me.cbTextLogo.Text = "Enabled"
        Me.cbTextLogo.UseVisualStyleBackColor = true
        '
        'tabPage42
        '
        Me.tabPage42.Controls.Add(Me.pnImageLogoColorKey)
        Me.tabPage42.Controls.Add(Me.cbImageLogoUseColorKey)
        Me.tabPage42.Controls.Add(Me.label154)
        Me.tabPage42.Controls.Add(Me.tbImageLogoTransp)
        Me.tabPage42.Controls.Add(Me.groupBox22)
        Me.tabPage42.Controls.Add(Me.groupBox23)
        Me.tabPage42.Controls.Add(Me.btSelectImage)
        Me.tabPage42.Controls.Add(Me.label157)
        Me.tabPage42.Controls.Add(Me.edImageLogoFilename)
        Me.tabPage42.Controls.Add(Me.cbImageLogo)
        Me.tabPage42.Location = New System.Drawing.Point(4, 22)
        Me.tabPage42.Name = "tabPage42"
        Me.tabPage42.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage42.Size = New System.Drawing.Size(275, 248)
        Me.tabPage42.TabIndex = 1
        Me.tabPage42.Text = "Image logo"
        Me.tabPage42.UseVisualStyleBackColor = true
        '
        'pnImageLogoColorKey
        '
        Me.pnImageLogoColorKey.BackColor = System.Drawing.Color.Fuchsia
        Me.pnImageLogoColorKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnImageLogoColorKey.Location = New System.Drawing.Point(241, 186)
        Me.pnImageLogoColorKey.Name = "pnImageLogoColorKey"
        Me.pnImageLogoColorKey.Size = New System.Drawing.Size(24, 24)
        Me.pnImageLogoColorKey.TabIndex = 54
        '
        'cbImageLogoUseColorKey
        '
        Me.cbImageLogoUseColorKey.AutoSize = true
        Me.cbImageLogoUseColorKey.Location = New System.Drawing.Point(127, 191)
        Me.cbImageLogoUseColorKey.Name = "cbImageLogoUseColorKey"
        Me.cbImageLogoUseColorKey.Size = New System.Drawing.Size(91, 17)
        Me.cbImageLogoUseColorKey.TabIndex = 53
        Me.cbImageLogoUseColorKey.Text = "Use color key"
        Me.cbImageLogoUseColorKey.UseVisualStyleBackColor = true
        '
        'label154
        '
        Me.label154.AutoSize = true
        Me.label154.Location = New System.Drawing.Point(11, 167)
        Me.label154.Name = "label154"
        Me.label154.Size = New System.Drawing.Size(72, 13)
        Me.label154.TabIndex = 52
        Me.label154.Text = "Transparency"
        '
        'tbImageLogoTransp
        '
        Me.tbImageLogoTransp.BackColor = System.Drawing.SystemColors.Window
        Me.tbImageLogoTransp.Location = New System.Drawing.Point(6, 182)
        Me.tbImageLogoTransp.Maximum = 255
        Me.tbImageLogoTransp.Name = "tbImageLogoTransp"
        Me.tbImageLogoTransp.Size = New System.Drawing.Size(104, 45)
        Me.tbImageLogoTransp.TabIndex = 51
        '
        'groupBox22
        '
        Me.groupBox22.Controls.Add(Me.cbImageLogoShowAlways)
        Me.groupBox22.Controls.Add(Me.edImageLogoStopTime)
        Me.groupBox22.Controls.Add(Me.lbGraphicLogoStopTime)
        Me.groupBox22.Controls.Add(Me.edImageLogoStartTime)
        Me.groupBox22.Controls.Add(Me.lbGraphicLogoStartTime)
        Me.groupBox22.Location = New System.Drawing.Point(111, 78)
        Me.groupBox22.Name = "groupBox22"
        Me.groupBox22.Size = New System.Drawing.Size(159, 76)
        Me.groupBox22.TabIndex = 50
        Me.groupBox22.TabStop = false
        Me.groupBox22.Text = "Duration"
        '
        'cbImageLogoShowAlways
        '
        Me.cbImageLogoShowAlways.AutoSize = true
        Me.cbImageLogoShowAlways.Checked = true
        Me.cbImageLogoShowAlways.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbImageLogoShowAlways.Location = New System.Drawing.Point(13, 48)
        Me.cbImageLogoShowAlways.Name = "cbImageLogoShowAlways"
        Me.cbImageLogoShowAlways.Size = New System.Drawing.Size(88, 17)
        Me.cbImageLogoShowAlways.TabIndex = 35
        Me.cbImageLogoShowAlways.Text = "Show always"
        Me.cbImageLogoShowAlways.UseVisualStyleBackColor = true
        '
        'edImageLogoStopTime
        '
        Me.edImageLogoStopTime.Enabled = false
        Me.edImageLogoStopTime.Location = New System.Drawing.Point(117, 19)
        Me.edImageLogoStopTime.Name = "edImageLogoStopTime"
        Me.edImageLogoStopTime.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoStopTime.TabIndex = 34
        Me.edImageLogoStopTime.Text = "10000"
        Me.edImageLogoStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbGraphicLogoStopTime
        '
        Me.lbGraphicLogoStopTime.AutoSize = true
        Me.lbGraphicLogoStopTime.Enabled = false
        Me.lbGraphicLogoStopTime.Location = New System.Drawing.Point(88, 22)
        Me.lbGraphicLogoStopTime.Name = "lbGraphicLogoStopTime"
        Me.lbGraphicLogoStopTime.Size = New System.Drawing.Size(29, 13)
        Me.lbGraphicLogoStopTime.TabIndex = 33
        Me.lbGraphicLogoStopTime.Text = "Stop"
        '
        'edImageLogoStartTime
        '
        Me.edImageLogoStartTime.Enabled = false
        Me.edImageLogoStartTime.Location = New System.Drawing.Point(43, 19)
        Me.edImageLogoStartTime.Name = "edImageLogoStartTime"
        Me.edImageLogoStartTime.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoStartTime.TabIndex = 32
        Me.edImageLogoStartTime.Text = "0"
        Me.edImageLogoStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbGraphicLogoStartTime
        '
        Me.lbGraphicLogoStartTime.AutoSize = true
        Me.lbGraphicLogoStartTime.Enabled = false
        Me.lbGraphicLogoStartTime.Location = New System.Drawing.Point(10, 22)
        Me.lbGraphicLogoStartTime.Name = "lbGraphicLogoStartTime"
        Me.lbGraphicLogoStartTime.Size = New System.Drawing.Size(29, 13)
        Me.lbGraphicLogoStartTime.TabIndex = 31
        Me.lbGraphicLogoStartTime.Text = "Start"
        '
        'groupBox23
        '
        Me.groupBox23.Controls.Add(Me.edImageLogoTop)
        Me.groupBox23.Controls.Add(Me.label155)
        Me.groupBox23.Controls.Add(Me.edImageLogoLeft)
        Me.groupBox23.Controls.Add(Me.label156)
        Me.groupBox23.Location = New System.Drawing.Point(8, 78)
        Me.groupBox23.Name = "groupBox23"
        Me.groupBox23.Size = New System.Drawing.Size(97, 76)
        Me.groupBox23.TabIndex = 49
        Me.groupBox23.TabStop = false
        Me.groupBox23.Text = "Position"
        '
        'edImageLogoTop
        '
        Me.edImageLogoTop.Location = New System.Drawing.Point(47, 45)
        Me.edImageLogoTop.Name = "edImageLogoTop"
        Me.edImageLogoTop.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoTop.TabIndex = 32
        Me.edImageLogoTop.Text = "50"
        Me.edImageLogoTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label155
        '
        Me.label155.AutoSize = true
        Me.label155.Location = New System.Drawing.Point(14, 48)
        Me.label155.Name = "label155"
        Me.label155.Size = New System.Drawing.Size(26, 13)
        Me.label155.TabIndex = 31
        Me.label155.Text = "Top"
        '
        'edImageLogoLeft
        '
        Me.edImageLogoLeft.Location = New System.Drawing.Point(47, 19)
        Me.edImageLogoLeft.Name = "edImageLogoLeft"
        Me.edImageLogoLeft.Size = New System.Drawing.Size(39, 20)
        Me.edImageLogoLeft.TabIndex = 30
        Me.edImageLogoLeft.Text = "50"
        Me.edImageLogoLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label156
        '
        Me.label156.AutoSize = true
        Me.label156.Location = New System.Drawing.Point(14, 22)
        Me.label156.Name = "label156"
        Me.label156.Size = New System.Drawing.Size(25, 13)
        Me.label156.TabIndex = 29
        Me.label156.Text = "Left"
        '
        'btSelectImage
        '
        Me.btSelectImage.Location = New System.Drawing.Point(246, 43)
        Me.btSelectImage.Name = "btSelectImage"
        Me.btSelectImage.Size = New System.Drawing.Size(24, 23)
        Me.btSelectImage.TabIndex = 48
        Me.btSelectImage.Text = "..."
        Me.btSelectImage.UseVisualStyleBackColor = true
        '
        'label157
        '
        Me.label157.AutoSize = true
        Me.label157.Location = New System.Drawing.Point(7, 48)
        Me.label157.Name = "label157"
        Me.label157.Size = New System.Drawing.Size(52, 13)
        Me.label157.TabIndex = 47
        Me.label157.Text = "File name"
        '
        'edImageLogoFilename
        '
        Me.edImageLogoFilename.Location = New System.Drawing.Point(65, 45)
        Me.edImageLogoFilename.Name = "edImageLogoFilename"
        Me.edImageLogoFilename.Size = New System.Drawing.Size(175, 20)
        Me.edImageLogoFilename.TabIndex = 46
        Me.edImageLogoFilename.Text = "c:\1.png"
        '
        'cbImageLogo
        '
        Me.cbImageLogo.AutoSize = true
        Me.cbImageLogo.Location = New System.Drawing.Point(8, 16)
        Me.cbImageLogo.Name = "cbImageLogo"
        Me.cbImageLogo.Size = New System.Drawing.Size(65, 17)
        Me.cbImageLogo.TabIndex = 45
        Me.cbImageLogo.Text = "Enabled"
        Me.cbImageLogo.UseVisualStyleBackColor = true
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.groupBox37)
        Me.TabPage7.Controls.Add(Me.cbZoom)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Size = New System.Drawing.Size(275, 248)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "Zoom"
        Me.TabPage7.UseVisualStyleBackColor = true
        '
        'groupBox37
        '
        Me.groupBox37.Controls.Add(Me.btEffZoomRight)
        Me.groupBox37.Controls.Add(Me.btEffZoomLeft)
        Me.groupBox37.Controls.Add(Me.btEffZoomOut)
        Me.groupBox37.Controls.Add(Me.btEffZoomIn)
        Me.groupBox37.Controls.Add(Me.btEffZoomDown)
        Me.groupBox37.Controls.Add(Me.btEffZoomUp)
        Me.groupBox37.Location = New System.Drawing.Point(86, 50)
        Me.groupBox37.Name = "groupBox37"
        Me.groupBox37.Size = New System.Drawing.Size(119, 104)
        Me.groupBox37.TabIndex = 20
        Me.groupBox37.TabStop = false
        Me.groupBox37.Text = "Zoom"
        '
        'btEffZoomRight
        '
        Me.btEffZoomRight.Location = New System.Drawing.Point(85, 33)
        Me.btEffZoomRight.Name = "btEffZoomRight"
        Me.btEffZoomRight.Size = New System.Drawing.Size(21, 48)
        Me.btEffZoomRight.TabIndex = 5
        Me.btEffZoomRight.Text = "R"
        Me.btEffZoomRight.UseVisualStyleBackColor = true
        '
        'btEffZoomLeft
        '
        Me.btEffZoomLeft.Location = New System.Drawing.Point(13, 32)
        Me.btEffZoomLeft.Name = "btEffZoomLeft"
        Me.btEffZoomLeft.Size = New System.Drawing.Size(21, 48)
        Me.btEffZoomLeft.TabIndex = 4
        Me.btEffZoomLeft.Text = "L"
        Me.btEffZoomLeft.UseVisualStyleBackColor = true
        '
        'btEffZoomOut
        '
        Me.btEffZoomOut.Location = New System.Drawing.Point(61, 45)
        Me.btEffZoomOut.Name = "btEffZoomOut"
        Me.btEffZoomOut.Size = New System.Drawing.Size(23, 23)
        Me.btEffZoomOut.TabIndex = 3
        Me.btEffZoomOut.Text = "-"
        Me.btEffZoomOut.UseVisualStyleBackColor = true
        '
        'btEffZoomIn
        '
        Me.btEffZoomIn.Location = New System.Drawing.Point(35, 45)
        Me.btEffZoomIn.Name = "btEffZoomIn"
        Me.btEffZoomIn.Size = New System.Drawing.Size(22, 23)
        Me.btEffZoomIn.TabIndex = 2
        Me.btEffZoomIn.Text = "+"
        Me.btEffZoomIn.UseVisualStyleBackColor = true
        '
        'btEffZoomDown
        '
        Me.btEffZoomDown.Location = New System.Drawing.Point(34, 69)
        Me.btEffZoomDown.Name = "btEffZoomDown"
        Me.btEffZoomDown.Size = New System.Drawing.Size(51, 23)
        Me.btEffZoomDown.TabIndex = 1
        Me.btEffZoomDown.Text = "Down"
        Me.btEffZoomDown.UseVisualStyleBackColor = true
        '
        'btEffZoomUp
        '
        Me.btEffZoomUp.Location = New System.Drawing.Point(34, 20)
        Me.btEffZoomUp.Name = "btEffZoomUp"
        Me.btEffZoomUp.Size = New System.Drawing.Size(51, 23)
        Me.btEffZoomUp.TabIndex = 0
        Me.btEffZoomUp.Text = "Up"
        Me.btEffZoomUp.UseVisualStyleBackColor = true
        '
        'cbZoom
        '
        Me.cbZoom.AutoSize = true
        Me.cbZoom.Location = New System.Drawing.Point(12, 14)
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(65, 17)
        Me.cbZoom.TabIndex = 19
        Me.cbZoom.Text = "Enabled"
        Me.cbZoom.UseVisualStyleBackColor = true
        '
        'TabPage16
        '
        Me.TabPage16.Controls.Add(Me.groupBox40)
        Me.TabPage16.Controls.Add(Me.groupBox39)
        Me.TabPage16.Controls.Add(Me.groupBox38)
        Me.TabPage16.Controls.Add(Me.cbPan)
        Me.TabPage16.Location = New System.Drawing.Point(4, 22)
        Me.TabPage16.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage16.Size = New System.Drawing.Size(275, 248)
        Me.TabPage16.TabIndex = 3
        Me.TabPage16.Text = "Pan"
        Me.TabPage16.UseVisualStyleBackColor = true
        '
        'groupBox40
        '
        Me.groupBox40.Controls.Add(Me.edPanDestHeight)
        Me.groupBox40.Controls.Add(Me.label302)
        Me.groupBox40.Controls.Add(Me.edPanDestWidth)
        Me.groupBox40.Controls.Add(Me.label303)
        Me.groupBox40.Controls.Add(Me.edPanDestTop)
        Me.groupBox40.Controls.Add(Me.label304)
        Me.groupBox40.Controls.Add(Me.edPanDestLeft)
        Me.groupBox40.Controls.Add(Me.label305)
        Me.groupBox40.Location = New System.Drawing.Point(12, 162)
        Me.groupBox40.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox40.Name = "groupBox40"
        Me.groupBox40.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox40.Size = New System.Drawing.Size(168, 77)
        Me.groupBox40.TabIndex = 58
        Me.groupBox40.TabStop = false
        Me.groupBox40.Text = "Destination rect"
        '
        'edPanDestHeight
        '
        Me.edPanDestHeight.Location = New System.Drawing.Point(123, 51)
        Me.edPanDestHeight.Name = "edPanDestHeight"
        Me.edPanDestHeight.Size = New System.Drawing.Size(33, 20)
        Me.edPanDestHeight.TabIndex = 17
        Me.edPanDestHeight.Text = "240"
        '
        'label302
        '
        Me.label302.AutoSize = true
        Me.label302.Location = New System.Drawing.Point(81, 54)
        Me.label302.Name = "label302"
        Me.label302.Size = New System.Drawing.Size(38, 13)
        Me.label302.TabIndex = 16
        Me.label302.Text = "Height"
        '
        'edPanDestWidth
        '
        Me.edPanDestWidth.Location = New System.Drawing.Point(123, 25)
        Me.edPanDestWidth.Name = "edPanDestWidth"
        Me.edPanDestWidth.Size = New System.Drawing.Size(33, 20)
        Me.edPanDestWidth.TabIndex = 15
        Me.edPanDestWidth.Text = "320"
        '
        'label303
        '
        Me.label303.AutoSize = true
        Me.label303.Location = New System.Drawing.Point(81, 28)
        Me.label303.Name = "label303"
        Me.label303.Size = New System.Drawing.Size(35, 13)
        Me.label303.TabIndex = 14
        Me.label303.Text = "Width"
        '
        'edPanDestTop
        '
        Me.edPanDestTop.Location = New System.Drawing.Point(43, 52)
        Me.edPanDestTop.Name = "edPanDestTop"
        Me.edPanDestTop.Size = New System.Drawing.Size(33, 20)
        Me.edPanDestTop.TabIndex = 12
        Me.edPanDestTop.Text = "0"
        '
        'label304
        '
        Me.label304.AutoSize = true
        Me.label304.Location = New System.Drawing.Point(13, 54)
        Me.label304.Name = "label304"
        Me.label304.Size = New System.Drawing.Size(26, 13)
        Me.label304.TabIndex = 11
        Me.label304.Text = "Top"
        '
        'edPanDestLeft
        '
        Me.edPanDestLeft.Location = New System.Drawing.Point(43, 26)
        Me.edPanDestLeft.Name = "edPanDestLeft"
        Me.edPanDestLeft.Size = New System.Drawing.Size(33, 20)
        Me.edPanDestLeft.TabIndex = 10
        Me.edPanDestLeft.Text = "0"
        '
        'label305
        '
        Me.label305.AutoSize = true
        Me.label305.Location = New System.Drawing.Point(13, 28)
        Me.label305.Name = "label305"
        Me.label305.Size = New System.Drawing.Size(25, 13)
        Me.label305.TabIndex = 9
        Me.label305.Text = "Left"
        '
        'groupBox39
        '
        Me.groupBox39.Controls.Add(Me.edPanSourceHeight)
        Me.groupBox39.Controls.Add(Me.label298)
        Me.groupBox39.Controls.Add(Me.edPanSourceWidth)
        Me.groupBox39.Controls.Add(Me.label299)
        Me.groupBox39.Controls.Add(Me.edPanSourceTop)
        Me.groupBox39.Controls.Add(Me.label300)
        Me.groupBox39.Controls.Add(Me.edPanSourceLeft)
        Me.groupBox39.Controls.Add(Me.label301)
        Me.groupBox39.Location = New System.Drawing.Point(12, 80)
        Me.groupBox39.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox39.Name = "groupBox39"
        Me.groupBox39.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox39.Size = New System.Drawing.Size(168, 77)
        Me.groupBox39.TabIndex = 57
        Me.groupBox39.TabStop = false
        Me.groupBox39.Text = "Source rect"
        '
        'edPanSourceHeight
        '
        Me.edPanSourceHeight.Location = New System.Drawing.Point(123, 51)
        Me.edPanSourceHeight.Name = "edPanSourceHeight"
        Me.edPanSourceHeight.Size = New System.Drawing.Size(33, 20)
        Me.edPanSourceHeight.TabIndex = 17
        Me.edPanSourceHeight.Text = "480"
        '
        'label298
        '
        Me.label298.AutoSize = true
        Me.label298.Location = New System.Drawing.Point(81, 54)
        Me.label298.Name = "label298"
        Me.label298.Size = New System.Drawing.Size(38, 13)
        Me.label298.TabIndex = 16
        Me.label298.Text = "Height"
        '
        'edPanSourceWidth
        '
        Me.edPanSourceWidth.Location = New System.Drawing.Point(123, 25)
        Me.edPanSourceWidth.Name = "edPanSourceWidth"
        Me.edPanSourceWidth.Size = New System.Drawing.Size(33, 20)
        Me.edPanSourceWidth.TabIndex = 15
        Me.edPanSourceWidth.Text = "640"
        '
        'label299
        '
        Me.label299.AutoSize = true
        Me.label299.Location = New System.Drawing.Point(81, 28)
        Me.label299.Name = "label299"
        Me.label299.Size = New System.Drawing.Size(35, 13)
        Me.label299.TabIndex = 14
        Me.label299.Text = "Width"
        '
        'edPanSourceTop
        '
        Me.edPanSourceTop.Location = New System.Drawing.Point(43, 52)
        Me.edPanSourceTop.Name = "edPanSourceTop"
        Me.edPanSourceTop.Size = New System.Drawing.Size(33, 20)
        Me.edPanSourceTop.TabIndex = 12
        Me.edPanSourceTop.Text = "0"
        '
        'label300
        '
        Me.label300.AutoSize = true
        Me.label300.Location = New System.Drawing.Point(13, 54)
        Me.label300.Name = "label300"
        Me.label300.Size = New System.Drawing.Size(26, 13)
        Me.label300.TabIndex = 11
        Me.label300.Text = "Top"
        '
        'edPanSourceLeft
        '
        Me.edPanSourceLeft.Location = New System.Drawing.Point(43, 26)
        Me.edPanSourceLeft.Name = "edPanSourceLeft"
        Me.edPanSourceLeft.Size = New System.Drawing.Size(33, 20)
        Me.edPanSourceLeft.TabIndex = 10
        Me.edPanSourceLeft.Text = "0"
        '
        'label301
        '
        Me.label301.AutoSize = true
        Me.label301.Location = New System.Drawing.Point(13, 28)
        Me.label301.Name = "label301"
        Me.label301.Size = New System.Drawing.Size(25, 13)
        Me.label301.TabIndex = 9
        Me.label301.Text = "Left"
        '
        'groupBox38
        '
        Me.groupBox38.Controls.Add(Me.edPanStopTime)
        Me.groupBox38.Controls.Add(Me.label296)
        Me.groupBox38.Controls.Add(Me.edPanStartTime)
        Me.groupBox38.Controls.Add(Me.label297)
        Me.groupBox38.Location = New System.Drawing.Point(12, 29)
        Me.groupBox38.Name = "groupBox38"
        Me.groupBox38.Size = New System.Drawing.Size(168, 46)
        Me.groupBox38.TabIndex = 56
        Me.groupBox38.TabStop = false
        Me.groupBox38.Text = "Duration"
        '
        'edPanStopTime
        '
        Me.edPanStopTime.Location = New System.Drawing.Point(117, 19)
        Me.edPanStopTime.Name = "edPanStopTime"
        Me.edPanStopTime.Size = New System.Drawing.Size(39, 20)
        Me.edPanStopTime.TabIndex = 34
        Me.edPanStopTime.Text = "15000"
        Me.edPanStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label296
        '
        Me.label296.AutoSize = true
        Me.label296.Location = New System.Drawing.Point(88, 22)
        Me.label296.Name = "label296"
        Me.label296.Size = New System.Drawing.Size(29, 13)
        Me.label296.TabIndex = 33
        Me.label296.Text = "Stop"
        '
        'edPanStartTime
        '
        Me.edPanStartTime.Location = New System.Drawing.Point(43, 19)
        Me.edPanStartTime.Name = "edPanStartTime"
        Me.edPanStartTime.Size = New System.Drawing.Size(39, 20)
        Me.edPanStartTime.TabIndex = 32
        Me.edPanStartTime.Text = "5000"
        Me.edPanStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label297
        '
        Me.label297.AutoSize = true
        Me.label297.Location = New System.Drawing.Point(10, 22)
        Me.label297.Name = "label297"
        Me.label297.Size = New System.Drawing.Size(29, 13)
        Me.label297.TabIndex = 31
        Me.label297.Text = "Start"
        '
        'cbPan
        '
        Me.cbPan.AutoSize = true
        Me.cbPan.Location = New System.Drawing.Point(12, 6)
        Me.cbPan.Name = "cbPan"
        Me.cbPan.Size = New System.Drawing.Size(65, 17)
        Me.cbPan.TabIndex = 55
        Me.cbPan.Text = "Enabled"
        Me.cbPan.UseVisualStyleBackColor = true
        '
        'TabPage33
        '
        Me.TabPage33.Controls.Add(Me.rbFadeOut)
        Me.TabPage33.Controls.Add(Me.rbFadeIn)
        Me.TabPage33.Controls.Add(Me.groupBox45)
        Me.TabPage33.Controls.Add(Me.cbFadeInOut)
        Me.TabPage33.Location = New System.Drawing.Point(4, 22)
        Me.TabPage33.Name = "TabPage33"
        Me.TabPage33.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage33.Size = New System.Drawing.Size(275, 248)
        Me.TabPage33.TabIndex = 4
        Me.TabPage33.Text = "Fade-in/out"
        Me.TabPage33.UseVisualStyleBackColor = true
        '
        'rbFadeOut
        '
        Me.rbFadeOut.AutoSize = true
        Me.rbFadeOut.Location = New System.Drawing.Point(107, 90)
        Me.rbFadeOut.Name = "rbFadeOut"
        Me.rbFadeOut.Size = New System.Drawing.Size(67, 17)
        Me.rbFadeOut.TabIndex = 64
        Me.rbFadeOut.TabStop = true
        Me.rbFadeOut.Text = "Fade-out"
        Me.rbFadeOut.UseVisualStyleBackColor = true
        '
        'rbFadeIn
        '
        Me.rbFadeIn.AutoSize = true
        Me.rbFadeIn.Checked = true
        Me.rbFadeIn.Location = New System.Drawing.Point(16, 90)
        Me.rbFadeIn.Name = "rbFadeIn"
        Me.rbFadeIn.Size = New System.Drawing.Size(60, 17)
        Me.rbFadeIn.TabIndex = 63
        Me.rbFadeIn.TabStop = true
        Me.rbFadeIn.Text = "Fade-in"
        Me.rbFadeIn.UseVisualStyleBackColor = true
        '
        'groupBox45
        '
        Me.groupBox45.Controls.Add(Me.edFadeInOutStopTime)
        Me.groupBox45.Controls.Add(Me.label329)
        Me.groupBox45.Controls.Add(Me.edFadeInOutStartTime)
        Me.groupBox45.Controls.Add(Me.label330)
        Me.groupBox45.Location = New System.Drawing.Point(16, 38)
        Me.groupBox45.Name = "groupBox45"
        Me.groupBox45.Size = New System.Drawing.Size(168, 46)
        Me.groupBox45.TabIndex = 62
        Me.groupBox45.TabStop = false
        Me.groupBox45.Text = "Duration"
        '
        'edFadeInOutStopTime
        '
        Me.edFadeInOutStopTime.Location = New System.Drawing.Point(117, 19)
        Me.edFadeInOutStopTime.Name = "edFadeInOutStopTime"
        Me.edFadeInOutStopTime.Size = New System.Drawing.Size(39, 20)
        Me.edFadeInOutStopTime.TabIndex = 34
        Me.edFadeInOutStopTime.Text = "15000"
        Me.edFadeInOutStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label329
        '
        Me.label329.AutoSize = true
        Me.label329.Location = New System.Drawing.Point(88, 22)
        Me.label329.Name = "label329"
        Me.label329.Size = New System.Drawing.Size(29, 13)
        Me.label329.TabIndex = 33
        Me.label329.Text = "Stop"
        '
        'edFadeInOutStartTime
        '
        Me.edFadeInOutStartTime.Location = New System.Drawing.Point(43, 19)
        Me.edFadeInOutStartTime.Name = "edFadeInOutStartTime"
        Me.edFadeInOutStartTime.Size = New System.Drawing.Size(39, 20)
        Me.edFadeInOutStartTime.TabIndex = 32
        Me.edFadeInOutStartTime.Text = "5000"
        Me.edFadeInOutStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label330
        '
        Me.label330.AutoSize = true
        Me.label330.Location = New System.Drawing.Point(10, 22)
        Me.label330.Name = "label330"
        Me.label330.Size = New System.Drawing.Size(29, 13)
        Me.label330.TabIndex = 31
        Me.label330.Text = "Start"
        '
        'cbFadeInOut
        '
        Me.cbFadeInOut.AutoSize = true
        Me.cbFadeInOut.Location = New System.Drawing.Point(16, 15)
        Me.cbFadeInOut.Name = "cbFadeInOut"
        Me.cbFadeInOut.Size = New System.Drawing.Size(65, 17)
        Me.cbFadeInOut.TabIndex = 61
        Me.cbFadeInOut.Text = "Enabled"
        Me.cbFadeInOut.UseVisualStyleBackColor = true
        '
        'tbContrast
        '
        Me.tbContrast.BackColor = System.Drawing.SystemColors.Window
        Me.tbContrast.Location = New System.Drawing.Point(3, 107)
        Me.tbContrast.Maximum = 255
        Me.tbContrast.Name = "tbContrast"
        Me.tbContrast.Size = New System.Drawing.Size(130, 45)
        Me.tbContrast.TabIndex = 49
        '
        'tbDarkness
        '
        Me.tbDarkness.BackColor = System.Drawing.SystemColors.Window
        Me.tbDarkness.Location = New System.Drawing.Point(142, 107)
        Me.tbDarkness.Maximum = 255
        Me.tbDarkness.Name = "tbDarkness"
        Me.tbDarkness.Size = New System.Drawing.Size(130, 45)
        Me.tbDarkness.TabIndex = 46
        '
        'tbLightness
        '
        Me.tbLightness.BackColor = System.Drawing.SystemColors.Window
        Me.tbLightness.Location = New System.Drawing.Point(3, 51)
        Me.tbLightness.Maximum = 255
        Me.tbLightness.Name = "tbLightness"
        Me.tbLightness.Size = New System.Drawing.Size(130, 45)
        Me.tbLightness.TabIndex = 45
        '
        'tbSaturation
        '
        Me.tbSaturation.BackColor = System.Drawing.SystemColors.Window
        Me.tbSaturation.Location = New System.Drawing.Point(142, 51)
        Me.tbSaturation.Maximum = 255
        Me.tbSaturation.Name = "tbSaturation"
        Me.tbSaturation.Size = New System.Drawing.Size(130, 45)
        Me.tbSaturation.TabIndex = 43
        Me.tbSaturation.Value = 255
        '
        'cbInvert
        '
        Me.cbInvert.AutoSize = true
        Me.cbInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbInvert.Location = New System.Drawing.Point(137, 158)
        Me.cbInvert.Name = "cbInvert"
        Me.cbInvert.Size = New System.Drawing.Size(53, 17)
        Me.cbInvert.TabIndex = 41
        Me.cbInvert.Text = "Invert"
        Me.cbInvert.UseVisualStyleBackColor = true
        '
        'cbGreyscale
        '
        Me.cbGreyscale.AutoSize = true
        Me.cbGreyscale.Location = New System.Drawing.Point(9, 158)
        Me.cbGreyscale.Name = "cbGreyscale"
        Me.cbGreyscale.Size = New System.Drawing.Size(73, 17)
        Me.cbGreyscale.TabIndex = 39
        Me.cbGreyscale.Text = "Greyscale"
        Me.cbGreyscale.UseVisualStyleBackColor = true
        '
        'cbEffects
        '
        Me.cbEffects.AutoSize = true
        Me.cbEffects.Checked = true
        Me.cbEffects.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEffects.Location = New System.Drawing.Point(8, 8)
        Me.cbEffects.Name = "cbEffects"
        Me.cbEffects.Size = New System.Drawing.Size(65, 17)
        Me.cbEffects.TabIndex = 37
        Me.cbEffects.Text = "Enabled"
        Me.cbEffects.UseVisualStyleBackColor = true
        '
        'tabPage69
        '
        Me.tabPage69.Controls.Add(Me.label211)
        Me.tabPage69.Controls.Add(Me.edDeintTriangleWeight)
        Me.tabPage69.Controls.Add(Me.label212)
        Me.tabPage69.Controls.Add(Me.label210)
        Me.tabPage69.Controls.Add(Me.label209)
        Me.tabPage69.Controls.Add(Me.label206)
        Me.tabPage69.Controls.Add(Me.edDeintBlendConstants2)
        Me.tabPage69.Controls.Add(Me.label207)
        Me.tabPage69.Controls.Add(Me.edDeintBlendConstants1)
        Me.tabPage69.Controls.Add(Me.label208)
        Me.tabPage69.Controls.Add(Me.label204)
        Me.tabPage69.Controls.Add(Me.edDeintBlendThreshold2)
        Me.tabPage69.Controls.Add(Me.label205)
        Me.tabPage69.Controls.Add(Me.edDeintBlendThreshold1)
        Me.tabPage69.Controls.Add(Me.label203)
        Me.tabPage69.Controls.Add(Me.label202)
        Me.tabPage69.Controls.Add(Me.edDeintCAVTThreshold)
        Me.tabPage69.Controls.Add(Me.label104)
        Me.tabPage69.Controls.Add(Me.rbDeintTriangleEnabled)
        Me.tabPage69.Controls.Add(Me.rbDeintBlendEnabled)
        Me.tabPage69.Controls.Add(Me.rbDeintCAVTEnabled)
        Me.tabPage69.Controls.Add(Me.cbDeinterlace)
        Me.tabPage69.Location = New System.Drawing.Point(4, 22)
        Me.tabPage69.Name = "tabPage69"
        Me.tabPage69.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage69.Size = New System.Drawing.Size(290, 459)
        Me.tabPage69.TabIndex = 1
        Me.tabPage69.Text = "Deinterlace"
        Me.tabPage69.UseVisualStyleBackColor = true
        '
        'label211
        '
        Me.label211.AutoSize = true
        Me.label211.Location = New System.Drawing.Point(100, 294)
        Me.label211.Name = "label211"
        Me.label211.Size = New System.Drawing.Size(40, 13)
        Me.label211.TabIndex = 28
        Me.label211.Text = "[0-255]"
        '
        'edDeintTriangleWeight
        '
        Me.edDeintTriangleWeight.Location = New System.Drawing.Point(103, 270)
        Me.edDeintTriangleWeight.Name = "edDeintTriangleWeight"
        Me.edDeintTriangleWeight.Size = New System.Drawing.Size(32, 20)
        Me.edDeintTriangleWeight.TabIndex = 27
        Me.edDeintTriangleWeight.Text = "180"
        '
        'label212
        '
        Me.label212.AutoSize = true
        Me.label212.Location = New System.Drawing.Point(34, 273)
        Me.label212.Name = "label212"
        Me.label212.Size = New System.Drawing.Size(41, 13)
        Me.label212.TabIndex = 26
        Me.label212.Text = "Weight"
        '
        'label210
        '
        Me.label210.AutoSize = true
        Me.label210.Location = New System.Drawing.Point(257, 192)
        Me.label210.Name = "label210"
        Me.label210.Size = New System.Drawing.Size(27, 13)
        Me.label210.TabIndex = 25
        Me.label210.Text = "/ 10"
        '
        'label209
        '
        Me.label209.AutoSize = true
        Me.label209.Location = New System.Drawing.Point(257, 159)
        Me.label209.Name = "label209"
        Me.label209.Size = New System.Drawing.Size(27, 13)
        Me.label209.TabIndex = 24
        Me.label209.Text = "/ 10"
        '
        'label206
        '
        Me.label206.AutoSize = true
        Me.label206.Location = New System.Drawing.Point(218, 213)
        Me.label206.Name = "label206"
        Me.label206.Size = New System.Drawing.Size(46, 13)
        Me.label206.TabIndex = 23
        Me.label206.Text = "[0.0-1.0]"
        '
        'edDeintBlendConstants2
        '
        Me.edDeintBlendConstants2.Location = New System.Drawing.Point(221, 189)
        Me.edDeintBlendConstants2.Name = "edDeintBlendConstants2"
        Me.edDeintBlendConstants2.Size = New System.Drawing.Size(32, 20)
        Me.edDeintBlendConstants2.TabIndex = 22
        Me.edDeintBlendConstants2.Text = "9"
        '
        'label207
        '
        Me.label207.AutoSize = true
        Me.label207.Location = New System.Drawing.Point(152, 192)
        Me.label207.Name = "label207"
        Me.label207.Size = New System.Drawing.Size(63, 13)
        Me.label207.TabIndex = 21
        Me.label207.Text = "Constants 2"
        '
        'edDeintBlendConstants1
        '
        Me.edDeintBlendConstants1.Location = New System.Drawing.Point(221, 156)
        Me.edDeintBlendConstants1.Name = "edDeintBlendConstants1"
        Me.edDeintBlendConstants1.Size = New System.Drawing.Size(32, 20)
        Me.edDeintBlendConstants1.TabIndex = 20
        Me.edDeintBlendConstants1.Text = "3"
        '
        'label208
        '
        Me.label208.AutoSize = true
        Me.label208.Location = New System.Drawing.Point(152, 159)
        Me.label208.Name = "label208"
        Me.label208.Size = New System.Drawing.Size(63, 13)
        Me.label208.TabIndex = 19
        Me.label208.Text = "Constants 1"
        '
        'label204
        '
        Me.label204.AutoSize = true
        Me.label204.Location = New System.Drawing.Point(100, 213)
        Me.label204.Name = "label204"
        Me.label204.Size = New System.Drawing.Size(40, 13)
        Me.label204.TabIndex = 18
        Me.label204.Text = "[0-255]"
        '
        'edDeintBlendThreshold2
        '
        Me.edDeintBlendThreshold2.Location = New System.Drawing.Point(103, 189)
        Me.edDeintBlendThreshold2.Name = "edDeintBlendThreshold2"
        Me.edDeintBlendThreshold2.Size = New System.Drawing.Size(32, 20)
        Me.edDeintBlendThreshold2.TabIndex = 17
        Me.edDeintBlendThreshold2.Text = "9"
        '
        'label205
        '
        Me.label205.AutoSize = true
        Me.label205.Location = New System.Drawing.Point(34, 192)
        Me.label205.Name = "label205"
        Me.label205.Size = New System.Drawing.Size(63, 13)
        Me.label205.TabIndex = 16
        Me.label205.Text = "Threshold 2"
        '
        'edDeintBlendThreshold1
        '
        Me.edDeintBlendThreshold1.Location = New System.Drawing.Point(103, 156)
        Me.edDeintBlendThreshold1.Name = "edDeintBlendThreshold1"
        Me.edDeintBlendThreshold1.Size = New System.Drawing.Size(32, 20)
        Me.edDeintBlendThreshold1.TabIndex = 15
        Me.edDeintBlendThreshold1.Text = "5"
        '
        'label203
        '
        Me.label203.AutoSize = true
        Me.label203.Location = New System.Drawing.Point(34, 159)
        Me.label203.Name = "label203"
        Me.label203.Size = New System.Drawing.Size(63, 13)
        Me.label203.TabIndex = 14
        Me.label203.Text = "Threshold 1"
        '
        'label202
        '
        Me.label202.AutoSize = true
        Me.label202.Location = New System.Drawing.Point(100, 103)
        Me.label202.Name = "label202"
        Me.label202.Size = New System.Drawing.Size(40, 13)
        Me.label202.TabIndex = 13
        Me.label202.Text = "[0-255]"
        '
        'edDeintCAVTThreshold
        '
        Me.edDeintCAVTThreshold.Location = New System.Drawing.Point(103, 79)
        Me.edDeintCAVTThreshold.Name = "edDeintCAVTThreshold"
        Me.edDeintCAVTThreshold.Size = New System.Drawing.Size(32, 20)
        Me.edDeintCAVTThreshold.TabIndex = 12
        Me.edDeintCAVTThreshold.Text = "20"
        '
        'label104
        '
        Me.label104.AutoSize = true
        Me.label104.Location = New System.Drawing.Point(34, 82)
        Me.label104.Name = "label104"
        Me.label104.Size = New System.Drawing.Size(54, 13)
        Me.label104.TabIndex = 11
        Me.label104.Text = "Threshold"
        '
        'rbDeintTriangleEnabled
        '
        Me.rbDeintTriangleEnabled.AutoSize = true
        Me.rbDeintTriangleEnabled.Location = New System.Drawing.Point(18, 243)
        Me.rbDeintTriangleEnabled.Name = "rbDeintTriangleEnabled"
        Me.rbDeintTriangleEnabled.Size = New System.Drawing.Size(63, 17)
        Me.rbDeintTriangleEnabled.TabIndex = 10
        Me.rbDeintTriangleEnabled.Text = "Triangle"
        Me.rbDeintTriangleEnabled.UseVisualStyleBackColor = true
        '
        'rbDeintBlendEnabled
        '
        Me.rbDeintBlendEnabled.AutoSize = true
        Me.rbDeintBlendEnabled.Location = New System.Drawing.Point(18, 127)
        Me.rbDeintBlendEnabled.Name = "rbDeintBlendEnabled"
        Me.rbDeintBlendEnabled.Size = New System.Drawing.Size(52, 17)
        Me.rbDeintBlendEnabled.TabIndex = 9
        Me.rbDeintBlendEnabled.Text = "Blend"
        Me.rbDeintBlendEnabled.UseVisualStyleBackColor = true
        '
        'rbDeintCAVTEnabled
        '
        Me.rbDeintCAVTEnabled.AutoSize = true
        Me.rbDeintCAVTEnabled.Checked = true
        Me.rbDeintCAVTEnabled.Location = New System.Drawing.Point(18, 52)
        Me.rbDeintCAVTEnabled.Name = "rbDeintCAVTEnabled"
        Me.rbDeintCAVTEnabled.Size = New System.Drawing.Size(229, 17)
        Me.rbDeintCAVTEnabled.TabIndex = 8
        Me.rbDeintCAVTEnabled.TabStop = true
        Me.rbDeintCAVTEnabled.Text = "Content Adaptive Vertical Temporal (CAVT)"
        Me.rbDeintCAVTEnabled.UseVisualStyleBackColor = true
        '
        'cbDeinterlace
        '
        Me.cbDeinterlace.AutoSize = true
        Me.cbDeinterlace.Checked = true
        Me.cbDeinterlace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDeinterlace.Location = New System.Drawing.Point(18, 16)
        Me.cbDeinterlace.Name = "cbDeinterlace"
        Me.cbDeinterlace.Size = New System.Drawing.Size(65, 17)
        Me.cbDeinterlace.TabIndex = 7
        Me.cbDeinterlace.Text = "Enabled"
        Me.cbDeinterlace.UseVisualStyleBackColor = true
        '
        'tabPage59
        '
        Me.tabPage59.Controls.Add(Me.rbDenoiseCAST)
        Me.tabPage59.Controls.Add(Me.rbDenoiseMosquito)
        Me.tabPage59.Controls.Add(Me.cbDenoise)
        Me.tabPage59.Location = New System.Drawing.Point(4, 22)
        Me.tabPage59.Name = "tabPage59"
        Me.tabPage59.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage59.Size = New System.Drawing.Size(290, 459)
        Me.tabPage59.TabIndex = 4
        Me.tabPage59.Text = "Denoise"
        Me.tabPage59.UseVisualStyleBackColor = true
        '
        'rbDenoiseCAST
        '
        Me.rbDenoiseCAST.AutoSize = true
        Me.rbDenoiseCAST.Location = New System.Drawing.Point(18, 79)
        Me.rbDenoiseCAST.Name = "rbDenoiseCAST"
        Me.rbDenoiseCAST.Size = New System.Drawing.Size(224, 17)
        Me.rbDenoiseCAST.TabIndex = 10
        Me.rbDenoiseCAST.Text = "Content Adaptive Spatio-Temporal (CAST)"
        Me.rbDenoiseCAST.UseVisualStyleBackColor = true
        '
        'rbDenoiseMosquito
        '
        Me.rbDenoiseMosquito.AutoSize = true
        Me.rbDenoiseMosquito.Checked = true
        Me.rbDenoiseMosquito.Location = New System.Drawing.Point(18, 52)
        Me.rbDenoiseMosquito.Name = "rbDenoiseMosquito"
        Me.rbDenoiseMosquito.Size = New System.Drawing.Size(68, 17)
        Me.rbDenoiseMosquito.TabIndex = 9
        Me.rbDenoiseMosquito.TabStop = true
        Me.rbDenoiseMosquito.Text = "Mosquito"
        Me.rbDenoiseMosquito.UseVisualStyleBackColor = true
        '
        'cbDenoise
        '
        Me.cbDenoise.AutoSize = true
        Me.cbDenoise.Location = New System.Drawing.Point(18, 16)
        Me.cbDenoise.Name = "cbDenoise"
        Me.cbDenoise.Size = New System.Drawing.Size(65, 17)
        Me.cbDenoise.TabIndex = 8
        Me.cbDenoise.Text = "Enabled"
        Me.cbDenoise.UseVisualStyleBackColor = true
        '
        'TabPage82
        '
        Me.TabPage82.Controls.Add(Me.cbGPUOldMovie)
        Me.TabPage82.Controls.Add(Me.cbGPUBlur)
        Me.TabPage82.Controls.Add(Me.cbGPUDeinterlace)
        Me.TabPage82.Controls.Add(Me.cbGPUDenoise)
        Me.TabPage82.Controls.Add(Me.cbGPUPixelate)
        Me.TabPage82.Controls.Add(Me.cbGPUNightVision)
        Me.TabPage82.Controls.Add(Me.label383)
        Me.TabPage82.Controls.Add(Me.label384)
        Me.TabPage82.Controls.Add(Me.label385)
        Me.TabPage82.Controls.Add(Me.label386)
        Me.TabPage82.Controls.Add(Me.tbGPUContrast)
        Me.TabPage82.Controls.Add(Me.tbGPUDarkness)
        Me.TabPage82.Controls.Add(Me.tbGPULightness)
        Me.TabPage82.Controls.Add(Me.tbGPUSaturation)
        Me.TabPage82.Controls.Add(Me.cbGPUInvert)
        Me.TabPage82.Controls.Add(Me.cbGPUGreyscale)
        Me.TabPage82.Location = New System.Drawing.Point(4, 22)
        Me.TabPage82.Name = "TabPage82"
        Me.TabPage82.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage82.Size = New System.Drawing.Size(290, 459)
        Me.TabPage82.TabIndex = 8
        Me.TabPage82.Text = "GPU effects"
        Me.TabPage82.UseVisualStyleBackColor = true
        '
        'cbGPUOldMovie
        '
        Me.cbGPUOldMovie.AutoSize = true
        Me.cbGPUOldMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUOldMovie.Location = New System.Drawing.Point(142, 204)
        Me.cbGPUOldMovie.Name = "cbGPUOldMovie"
        Me.cbGPUOldMovie.Size = New System.Drawing.Size(73, 17)
        Me.cbGPUOldMovie.TabIndex = 96
        Me.cbGPUOldMovie.Text = "Old movie"
        Me.cbGPUOldMovie.UseVisualStyleBackColor = true
        '
        'cbGPUBlur
        '
        Me.cbGPUBlur.AutoSize = true
        Me.cbGPUBlur.Location = New System.Drawing.Point(14, 204)
        Me.cbGPUBlur.Name = "cbGPUBlur"
        Me.cbGPUBlur.Size = New System.Drawing.Size(44, 17)
        Me.cbGPUBlur.TabIndex = 95
        Me.cbGPUBlur.Text = "Blur"
        Me.cbGPUBlur.UseVisualStyleBackColor = true
        '
        'cbGPUDeinterlace
        '
        Me.cbGPUDeinterlace.AutoSize = true
        Me.cbGPUDeinterlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUDeinterlace.Location = New System.Drawing.Point(142, 180)
        Me.cbGPUDeinterlace.Name = "cbGPUDeinterlace"
        Me.cbGPUDeinterlace.Size = New System.Drawing.Size(80, 17)
        Me.cbGPUDeinterlace.TabIndex = 94
        Me.cbGPUDeinterlace.Text = "Deinterlace"
        Me.cbGPUDeinterlace.UseVisualStyleBackColor = true
        '
        'cbGPUDenoise
        '
        Me.cbGPUDenoise.AutoSize = true
        Me.cbGPUDenoise.Location = New System.Drawing.Point(14, 180)
        Me.cbGPUDenoise.Name = "cbGPUDenoise"
        Me.cbGPUDenoise.Size = New System.Drawing.Size(65, 17)
        Me.cbGPUDenoise.TabIndex = 93
        Me.cbGPUDenoise.Text = "Denoise"
        Me.cbGPUDenoise.UseVisualStyleBackColor = true
        '
        'cbGPUPixelate
        '
        Me.cbGPUPixelate.AutoSize = true
        Me.cbGPUPixelate.Location = New System.Drawing.Point(142, 157)
        Me.cbGPUPixelate.Name = "cbGPUPixelate"
        Me.cbGPUPixelate.Size = New System.Drawing.Size(63, 17)
        Me.cbGPUPixelate.TabIndex = 92
        Me.cbGPUPixelate.Text = "Pixelate"
        Me.cbGPUPixelate.UseVisualStyleBackColor = true
        '
        'cbGPUNightVision
        '
        Me.cbGPUNightVision.AutoSize = true
        Me.cbGPUNightVision.Location = New System.Drawing.Point(14, 157)
        Me.cbGPUNightVision.Name = "cbGPUNightVision"
        Me.cbGPUNightVision.Size = New System.Drawing.Size(81, 17)
        Me.cbGPUNightVision.TabIndex = 91
        Me.cbGPUNightVision.Text = "Night vision"
        Me.cbGPUNightVision.UseVisualStyleBackColor = true
        '
        'label383
        '
        Me.label383.AutoSize = true
        Me.label383.Location = New System.Drawing.Point(147, 64)
        Me.label383.Name = "label383"
        Me.label383.Size = New System.Drawing.Size(52, 13)
        Me.label383.TabIndex = 90
        Me.label383.Text = "Darkness"
        '
        'label384
        '
        Me.label384.AutoSize = true
        Me.label384.Location = New System.Drawing.Point(11, 64)
        Me.label384.Name = "label384"
        Me.label384.Size = New System.Drawing.Size(46, 13)
        Me.label384.TabIndex = 89
        Me.label384.Text = "Contrast"
        '
        'label385
        '
        Me.label385.AutoSize = true
        Me.label385.Location = New System.Drawing.Point(147, 12)
        Me.label385.Name = "label385"
        Me.label385.Size = New System.Drawing.Size(55, 13)
        Me.label385.TabIndex = 88
        Me.label385.Text = "Saturation"
        '
        'label386
        '
        Me.label386.AutoSize = true
        Me.label386.Location = New System.Drawing.Point(11, 12)
        Me.label386.Name = "label386"
        Me.label386.Size = New System.Drawing.Size(52, 13)
        Me.label386.TabIndex = 87
        Me.label386.Text = "Lightness"
        '
        'tbGPUContrast
        '
        Me.tbGPUContrast.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUContrast.Location = New System.Drawing.Point(8, 83)
        Me.tbGPUContrast.Maximum = 255
        Me.tbGPUContrast.Name = "tbGPUContrast"
        Me.tbGPUContrast.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUContrast.TabIndex = 86
        Me.tbGPUContrast.Value = 255
        '
        'tbGPUDarkness
        '
        Me.tbGPUDarkness.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUDarkness.Location = New System.Drawing.Point(147, 83)
        Me.tbGPUDarkness.Maximum = 255
        Me.tbGPUDarkness.Name = "tbGPUDarkness"
        Me.tbGPUDarkness.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUDarkness.TabIndex = 85
        '
        'tbGPULightness
        '
        Me.tbGPULightness.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPULightness.Location = New System.Drawing.Point(8, 27)
        Me.tbGPULightness.Maximum = 255
        Me.tbGPULightness.Name = "tbGPULightness"
        Me.tbGPULightness.Size = New System.Drawing.Size(130, 45)
        Me.tbGPULightness.TabIndex = 84
        '
        'tbGPUSaturation
        '
        Me.tbGPUSaturation.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUSaturation.Location = New System.Drawing.Point(147, 27)
        Me.tbGPUSaturation.Maximum = 255
        Me.tbGPUSaturation.Name = "tbGPUSaturation"
        Me.tbGPUSaturation.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUSaturation.TabIndex = 83
        Me.tbGPUSaturation.Value = 255
        '
        'cbGPUInvert
        '
        Me.cbGPUInvert.AutoSize = true
        Me.cbGPUInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUInvert.Location = New System.Drawing.Point(142, 134)
        Me.cbGPUInvert.Name = "cbGPUInvert"
        Me.cbGPUInvert.Size = New System.Drawing.Size(53, 17)
        Me.cbGPUInvert.TabIndex = 82
        Me.cbGPUInvert.Text = "Invert"
        Me.cbGPUInvert.UseVisualStyleBackColor = true
        '
        'cbGPUGreyscale
        '
        Me.cbGPUGreyscale.AutoSize = true
        Me.cbGPUGreyscale.Location = New System.Drawing.Point(14, 134)
        Me.cbGPUGreyscale.Name = "cbGPUGreyscale"
        Me.cbGPUGreyscale.Size = New System.Drawing.Size(73, 17)
        Me.cbGPUGreyscale.TabIndex = 81
        Me.cbGPUGreyscale.Text = "Greyscale"
        Me.cbGPUGreyscale.UseVisualStyleBackColor = true
        '
        'TabPage20
        '
        Me.TabPage20.Controls.Add(Me.tabControl15)
        Me.TabPage20.Controls.Add(Me.label16)
        Me.TabPage20.Location = New System.Drawing.Point(4, 22)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage20.Size = New System.Drawing.Size(290, 459)
        Me.TabPage20.TabIndex = 5
        Me.TabPage20.Text = "Object detection"
        Me.TabPage20.UseVisualStyleBackColor = true
        '
        'tabControl15
        '
        Me.tabControl15.Controls.Add(Me.TabPage26)
        Me.tabControl15.Controls.Add(Me.TabPage27)
        Me.tabControl15.Location = New System.Drawing.Point(5, 36)
        Me.tabControl15.Name = "tabControl15"
        Me.tabControl15.SelectedIndex = 0
        Me.tabControl15.Size = New System.Drawing.Size(278, 386)
        Me.tabControl15.TabIndex = 5
        '
        'TabPage26
        '
        Me.TabPage26.Controls.Add(Me.label64)
        Me.TabPage26.Controls.Add(Me.label65)
        Me.TabPage26.Controls.Add(Me.pbAFMotionLevel)
        Me.TabPage26.Controls.Add(Me.cbAFMotionHighlight)
        Me.TabPage26.Controls.Add(Me.cbAFMotionDetection)
        Me.TabPage26.Location = New System.Drawing.Point(4, 22)
        Me.TabPage26.Name = "TabPage26"
        Me.TabPage26.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage26.Size = New System.Drawing.Size(270, 360)
        Me.TabPage26.TabIndex = 0
        Me.TabPage26.Text = "Motion detection"
        Me.TabPage26.UseVisualStyleBackColor = true
        '
        'label64
        '
        Me.label64.AutoSize = true
        Me.label64.Location = New System.Drawing.Point(6, 91)
        Me.label64.Name = "label64"
        Me.label64.Size = New System.Drawing.Size(254, 13)
        Me.label64.TabIndex = 4
        Me.label64.Text = "Much more motion detection options available in API"
        '
        'label65
        '
        Me.label65.AutoSize = true
        Me.label65.Location = New System.Drawing.Point(6, 315)
        Me.label65.Name = "label65"
        Me.label65.Size = New System.Drawing.Size(64, 13)
        Me.label65.TabIndex = 3
        Me.label65.Text = "Motion level"
        '
        'pbAFMotionLevel
        '
        Me.pbAFMotionLevel.Location = New System.Drawing.Point(6, 331)
        Me.pbAFMotionLevel.Name = "pbAFMotionLevel"
        Me.pbAFMotionLevel.Size = New System.Drawing.Size(258, 23)
        Me.pbAFMotionLevel.TabIndex = 2
        '
        'cbAFMotionHighlight
        '
        Me.cbAFMotionHighlight.AutoSize = true
        Me.cbAFMotionHighlight.Location = New System.Drawing.Point(15, 45)
        Me.cbAFMotionHighlight.Name = "cbAFMotionHighlight"
        Me.cbAFMotionHighlight.Size = New System.Drawing.Size(67, 17)
        Me.cbAFMotionHighlight.TabIndex = 1
        Me.cbAFMotionHighlight.Text = "Highlight"
        Me.cbAFMotionHighlight.UseVisualStyleBackColor = true
        '
        'cbAFMotionDetection
        '
        Me.cbAFMotionDetection.AutoSize = true
        Me.cbAFMotionDetection.Location = New System.Drawing.Point(15, 19)
        Me.cbAFMotionDetection.Name = "cbAFMotionDetection"
        Me.cbAFMotionDetection.Size = New System.Drawing.Size(138, 17)
        Me.cbAFMotionDetection.TabIndex = 0
        Me.cbAFMotionDetection.Text = "Enabled, detect objects"
        Me.cbAFMotionDetection.UseVisualStyleBackColor = true
        '
        'TabPage27
        '
        Me.TabPage27.Controls.Add(Me.label171)
        Me.TabPage27.Controls.Add(Me.label66)
        Me.TabPage27.Location = New System.Drawing.Point(4, 22)
        Me.TabPage27.Name = "TabPage27"
        Me.TabPage27.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage27.Size = New System.Drawing.Size(270, 360)
        Me.TabPage27.TabIndex = 1
        Me.TabPage27.Text = "Effects"
        Me.TabPage27.UseVisualStyleBackColor = true
        '
        'label171
        '
        Me.label171.AutoSize = true
        Me.label171.Location = New System.Drawing.Point(10, 40)
        Me.label171.Name = "label171"
        Me.label171.Size = New System.Drawing.Size(141, 13)
        Me.label171.TabIndex = 1
        Me.label171.Text = "OnVideoFrameBuffer event. "
        '
        'label66
        '
        Me.label66.AutoSize = true
        Me.label66.Location = New System.Drawing.Point(10, 18)
        Me.label66.Name = "label66"
        Me.label66.Size = New System.Drawing.Size(171, 13)
        Me.label66.TabIndex = 0
        Me.label66.Text = "You can add various effects using "
        '
        'label16
        '
        Me.label16.Location = New System.Drawing.Point(0, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(100, 23)
        Me.label16.TabIndex = 6
        '
        'TabPage21
        '
        Me.TabPage21.Controls.Add(Me.btChromaKeySelectBGImage)
        Me.TabPage21.Controls.Add(Me.edChromaKeyImage)
        Me.TabPage21.Controls.Add(Me.label216)
        Me.TabPage21.Controls.Add(Me.rbChromaKeyRed)
        Me.TabPage21.Controls.Add(Me.rbChromaKeyBlue)
        Me.TabPage21.Controls.Add(Me.rbChromaKeyGreen)
        Me.TabPage21.Controls.Add(Me.label215)
        Me.TabPage21.Controls.Add(Me.tbChromaKeyContrastHigh)
        Me.TabPage21.Controls.Add(Me.label214)
        Me.TabPage21.Controls.Add(Me.tbChromaKeyContrastLow)
        Me.TabPage21.Controls.Add(Me.label213)
        Me.TabPage21.Controls.Add(Me.cbChromaKeyEnabled)
        Me.TabPage21.Location = New System.Drawing.Point(4, 22)
        Me.TabPage21.Name = "TabPage21"
        Me.TabPage21.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage21.Size = New System.Drawing.Size(290, 459)
        Me.TabPage21.TabIndex = 6
        Me.TabPage21.Text = "Chroma key"
        Me.TabPage21.UseVisualStyleBackColor = true
        '
        'btChromaKeySelectBGImage
        '
        Me.btChromaKeySelectBGImage.Location = New System.Drawing.Point(256, 271)
        Me.btChromaKeySelectBGImage.Name = "btChromaKeySelectBGImage"
        Me.btChromaKeySelectBGImage.Size = New System.Drawing.Size(24, 23)
        Me.btChromaKeySelectBGImage.TabIndex = 44
        Me.btChromaKeySelectBGImage.Text = "..."
        Me.btChromaKeySelectBGImage.UseVisualStyleBackColor = true
        '
        'edChromaKeyImage
        '
        Me.edChromaKeyImage.Location = New System.Drawing.Point(14, 273)
        Me.edChromaKeyImage.Name = "edChromaKeyImage"
        Me.edChromaKeyImage.Size = New System.Drawing.Size(235, 20)
        Me.edChromaKeyImage.TabIndex = 43
        Me.edChromaKeyImage.Text = "c:\chroma_bg.bmp"
        '
        'label216
        '
        Me.label216.AutoSize = true
        Me.label216.Location = New System.Drawing.Point(11, 257)
        Me.label216.Name = "label216"
        Me.label216.Size = New System.Drawing.Size(96, 13)
        Me.label216.TabIndex = 42
        Me.label216.Text = "Background image"
        '
        'rbChromaKeyRed
        '
        Me.rbChromaKeyRed.AutoSize = true
        Me.rbChromaKeyRed.Location = New System.Drawing.Point(148, 222)
        Me.rbChromaKeyRed.Name = "rbChromaKeyRed"
        Me.rbChromaKeyRed.Size = New System.Drawing.Size(45, 17)
        Me.rbChromaKeyRed.TabIndex = 41
        Me.rbChromaKeyRed.Text = "Red"
        Me.rbChromaKeyRed.UseVisualStyleBackColor = true
        '
        'rbChromaKeyBlue
        '
        Me.rbChromaKeyBlue.AutoSize = true
        Me.rbChromaKeyBlue.Location = New System.Drawing.Point(83, 222)
        Me.rbChromaKeyBlue.Name = "rbChromaKeyBlue"
        Me.rbChromaKeyBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbChromaKeyBlue.TabIndex = 40
        Me.rbChromaKeyBlue.Text = "Blue"
        Me.rbChromaKeyBlue.UseVisualStyleBackColor = true
        '
        'rbChromaKeyGreen
        '
        Me.rbChromaKeyGreen.AutoSize = true
        Me.rbChromaKeyGreen.Checked = true
        Me.rbChromaKeyGreen.Location = New System.Drawing.Point(14, 222)
        Me.rbChromaKeyGreen.Name = "rbChromaKeyGreen"
        Me.rbChromaKeyGreen.Size = New System.Drawing.Size(54, 17)
        Me.rbChromaKeyGreen.TabIndex = 39
        Me.rbChromaKeyGreen.TabStop = true
        Me.rbChromaKeyGreen.Text = "Green"
        Me.rbChromaKeyGreen.UseVisualStyleBackColor = true
        '
        'label215
        '
        Me.label215.AutoSize = true
        Me.label215.Location = New System.Drawing.Point(11, 208)
        Me.label215.Name = "label215"
        Me.label215.Size = New System.Drawing.Size(31, 13)
        Me.label215.TabIndex = 38
        Me.label215.Text = "Color"
        '
        'tbChromaKeyContrastHigh
        '
        Me.tbChromaKeyContrastHigh.BackColor = System.Drawing.SystemColors.Window
        Me.tbChromaKeyContrastHigh.Location = New System.Drawing.Point(14, 149)
        Me.tbChromaKeyContrastHigh.Maximum = 255
        Me.tbChromaKeyContrastHigh.Name = "tbChromaKeyContrastHigh"
        Me.tbChromaKeyContrastHigh.Size = New System.Drawing.Size(154, 45)
        Me.tbChromaKeyContrastHigh.TabIndex = 37
        Me.tbChromaKeyContrastHigh.Value = 150
        '
        'label214
        '
        Me.label214.AutoSize = true
        Me.label214.Location = New System.Drawing.Point(11, 131)
        Me.label214.Name = "label214"
        Me.label214.Size = New System.Drawing.Size(71, 13)
        Me.label214.TabIndex = 36
        Me.label214.Text = "Contrast-High"
        '
        'tbChromaKeyContrastLow
        '
        Me.tbChromaKeyContrastLow.BackColor = System.Drawing.SystemColors.Window
        Me.tbChromaKeyContrastLow.Location = New System.Drawing.Point(14, 76)
        Me.tbChromaKeyContrastLow.Maximum = 255
        Me.tbChromaKeyContrastLow.Name = "tbChromaKeyContrastLow"
        Me.tbChromaKeyContrastLow.Size = New System.Drawing.Size(154, 45)
        Me.tbChromaKeyContrastLow.TabIndex = 35
        Me.tbChromaKeyContrastLow.Value = 10
        '
        'label213
        '
        Me.label213.AutoSize = true
        Me.label213.Location = New System.Drawing.Point(11, 58)
        Me.label213.Name = "label213"
        Me.label213.Size = New System.Drawing.Size(69, 13)
        Me.label213.TabIndex = 34
        Me.label213.Text = "Contrast-Low"
        '
        'cbChromaKeyEnabled
        '
        Me.cbChromaKeyEnabled.AutoSize = true
        Me.cbChromaKeyEnabled.Location = New System.Drawing.Point(14, 19)
        Me.cbChromaKeyEnabled.Name = "cbChromaKeyEnabled"
        Me.cbChromaKeyEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbChromaKeyEnabled.TabIndex = 33
        Me.cbChromaKeyEnabled.Text = "Enabled"
        Me.cbChromaKeyEnabled.UseVisualStyleBackColor = true
        '
        'tabPage70
        '
        Me.tabPage70.Controls.Add(Me.btFilterDeleteAll)
        Me.tabPage70.Controls.Add(Me.btFilterSettings2)
        Me.tabPage70.Controls.Add(Me.lbFilters)
        Me.tabPage70.Controls.Add(Me.label106)
        Me.tabPage70.Controls.Add(Me.btFilterSettings)
        Me.tabPage70.Controls.Add(Me.btFilterAdd)
        Me.tabPage70.Controls.Add(Me.cbFilters)
        Me.tabPage70.Controls.Add(Me.label105)
        Me.tabPage70.Location = New System.Drawing.Point(4, 22)
        Me.tabPage70.Name = "tabPage70"
        Me.tabPage70.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage70.Size = New System.Drawing.Size(290, 459)
        Me.tabPage70.TabIndex = 3
        Me.tabPage70.Text = "3rd-party filters"
        Me.tabPage70.UseVisualStyleBackColor = true
        '
        'btFilterDeleteAll
        '
        Me.btFilterDeleteAll.Location = New System.Drawing.Point(210, 287)
        Me.btFilterDeleteAll.Name = "btFilterDeleteAll"
        Me.btFilterDeleteAll.Size = New System.Drawing.Size(68, 23)
        Me.btFilterDeleteAll.TabIndex = 16
        Me.btFilterDeleteAll.Text = "Delete all"
        Me.btFilterDeleteAll.UseVisualStyleBackColor = true
        '
        'btFilterSettings2
        '
        Me.btFilterSettings2.Location = New System.Drawing.Point(18, 287)
        Me.btFilterSettings2.Name = "btFilterSettings2"
        Me.btFilterSettings2.Size = New System.Drawing.Size(65, 23)
        Me.btFilterSettings2.TabIndex = 15
        Me.btFilterSettings2.Text = "Settings"
        Me.btFilterSettings2.UseVisualStyleBackColor = true
        '
        'lbFilters
        '
        Me.lbFilters.FormattingEnabled = true
        Me.lbFilters.Location = New System.Drawing.Point(18, 121)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(260, 160)
        Me.lbFilters.TabIndex = 14
        '
        'label106
        '
        Me.label106.AutoSize = true
        Me.label106.Location = New System.Drawing.Point(15, 105)
        Me.label106.Name = "label106"
        Me.label106.Size = New System.Drawing.Size(68, 13)
        Me.label106.TabIndex = 13
        Me.label106.Text = "Current filters"
        '
        'btFilterSettings
        '
        Me.btFilterSettings.Location = New System.Drawing.Point(210, 57)
        Me.btFilterSettings.Name = "btFilterSettings"
        Me.btFilterSettings.Size = New System.Drawing.Size(68, 23)
        Me.btFilterSettings.TabIndex = 12
        Me.btFilterSettings.Text = "Settings"
        Me.btFilterSettings.UseVisualStyleBackColor = true
        '
        'btFilterAdd
        '
        Me.btFilterAdd.Location = New System.Drawing.Point(18, 57)
        Me.btFilterAdd.Name = "btFilterAdd"
        Me.btFilterAdd.Size = New System.Drawing.Size(39, 23)
        Me.btFilterAdd.TabIndex = 11
        Me.btFilterAdd.Text = "Add"
        Me.btFilterAdd.UseVisualStyleBackColor = true
        '
        'cbFilters
        '
        Me.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilters.FormattingEnabled = true
        Me.cbFilters.Location = New System.Drawing.Point(18, 30)
        Me.cbFilters.Name = "cbFilters"
        Me.cbFilters.Size = New System.Drawing.Size(260, 21)
        Me.cbFilters.TabIndex = 10
        '
        'label105
        '
        Me.label105.AutoSize = true
        Me.label105.Location = New System.Drawing.Point(15, 14)
        Me.label105.Name = "label105"
        Me.label105.Size = New System.Drawing.Size(34, 13)
        Me.label105.TabIndex = 9
        Me.label105.Text = "Filters"
        '
        'TabPage81
        '
        Me.TabPage81.Controls.Add(Me.label177)
        Me.TabPage81.Controls.Add(Me.Label3)
        Me.TabPage81.Controls.Add(Me.btSubtitlesSelectFile)
        Me.TabPage81.Controls.Add(Me.edSubtitlesFilename)
        Me.TabPage81.Controls.Add(Me.Label130)
        Me.TabPage81.Controls.Add(Me.cbSubtitlesEnabled)
        Me.TabPage81.Location = New System.Drawing.Point(4, 22)
        Me.TabPage81.Name = "TabPage81"
        Me.TabPage81.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage81.Size = New System.Drawing.Size(290, 459)
        Me.TabPage81.TabIndex = 7
        Me.TabPage81.Text = "Subtitles"
        Me.TabPage81.UseVisualStyleBackColor = true
        '
        'label177
        '
        Me.label177.AutoSize = true
        Me.label177.Location = New System.Drawing.Point(10, 104)
        Me.label177.Name = "label177"
        Me.label177.Size = New System.Drawing.Size(82, 13)
        Me.label177.TabIndex = 11
        Me.label177.Text = " using interface."
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(10, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Use OnSubtitleSettings event to set other settings"
        '
        'btSubtitlesSelectFile
        '
        Me.btSubtitlesSelectFile.Location = New System.Drawing.Point(250, 55)
        Me.btSubtitlesSelectFile.Name = "btSubtitlesSelectFile"
        Me.btSubtitlesSelectFile.Size = New System.Drawing.Size(23, 23)
        Me.btSubtitlesSelectFile.TabIndex = 9
        Me.btSubtitlesSelectFile.Text = "..."
        Me.btSubtitlesSelectFile.UseVisualStyleBackColor = true
        '
        'edSubtitlesFilename
        '
        Me.edSubtitlesFilename.Location = New System.Drawing.Point(13, 57)
        Me.edSubtitlesFilename.Name = "edSubtitlesFilename"
        Me.edSubtitlesFilename.Size = New System.Drawing.Size(232, 20)
        Me.edSubtitlesFilename.TabIndex = 8
        '
        'Label130
        '
        Me.Label130.AutoSize = true
        Me.Label130.Location = New System.Drawing.Point(10, 41)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(52, 13)
        Me.Label130.TabIndex = 7
        Me.Label130.Text = "File name"
        '
        'cbSubtitlesEnabled
        '
        Me.cbSubtitlesEnabled.AutoSize = true
        Me.cbSubtitlesEnabled.Location = New System.Drawing.Point(13, 16)
        Me.cbSubtitlesEnabled.Name = "cbSubtitlesEnabled"
        Me.cbSubtitlesEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbSubtitlesEnabled.TabIndex = 6
        Me.cbSubtitlesEnabled.Text = "Enabled"
        Me.cbSubtitlesEnabled.UseVisualStyleBackColor = true
        '
        'tabPage9
        '
        Me.tabPage9.Controls.Add(Me.groupBox5)
        Me.tabPage9.Controls.Add(Me.lbTransitions)
        Me.tabPage9.Controls.Add(Me.label43)
        Me.tabPage9.Location = New System.Drawing.Point(4, 22)
        Me.tabPage9.Name = "tabPage9"
        Me.tabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage9.Size = New System.Drawing.Size(302, 494)
        Me.tabPage9.TabIndex = 3
        Me.tabPage9.Text = "Transitions"
        Me.tabPage9.UseVisualStyleBackColor = true
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.label47)
        Me.groupBox5.Controls.Add(Me.edTransStopTime)
        Me.groupBox5.Controls.Add(Me.label48)
        Me.groupBox5.Controls.Add(Me.label46)
        Me.groupBox5.Controls.Add(Me.edTransStartTime)
        Me.groupBox5.Controls.Add(Me.label45)
        Me.groupBox5.Controls.Add(Me.btAddTransition)
        Me.groupBox5.Controls.Add(Me.cbTransitionName)
        Me.groupBox5.Controls.Add(Me.label44)
        Me.groupBox5.Location = New System.Drawing.Point(20, 123)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(251, 144)
        Me.groupBox5.TabIndex = 2
        Me.groupBox5.TabStop = false
        Me.groupBox5.Text = "Add transition"
        '
        'label47
        '
        Me.label47.AutoSize = true
        Me.label47.Location = New System.Drawing.Point(133, 110)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(20, 13)
        Me.label47.TabIndex = 8
        Me.label47.Text = "ms"
        '
        'edTransStopTime
        '
        Me.edTransStopTime.Location = New System.Drawing.Point(84, 107)
        Me.edTransStopTime.Name = "edTransStopTime"
        Me.edTransStopTime.Size = New System.Drawing.Size(43, 20)
        Me.edTransStopTime.TabIndex = 7
        Me.edTransStopTime.Text = "5000"
        '
        'label48
        '
        Me.label48.AutoSize = true
        Me.label48.Location = New System.Drawing.Point(12, 110)
        Me.label48.Name = "label48"
        Me.label48.Size = New System.Drawing.Size(51, 13)
        Me.label48.TabIndex = 6
        Me.label48.Text = "Stop time"
        '
        'label46
        '
        Me.label46.AutoSize = true
        Me.label46.Location = New System.Drawing.Point(133, 84)
        Me.label46.Name = "label46"
        Me.label46.Size = New System.Drawing.Size(20, 13)
        Me.label46.TabIndex = 5
        Me.label46.Text = "ms"
        '
        'edTransStartTime
        '
        Me.edTransStartTime.Location = New System.Drawing.Point(84, 81)
        Me.edTransStartTime.Name = "edTransStartTime"
        Me.edTransStartTime.Size = New System.Drawing.Size(43, 20)
        Me.edTransStartTime.TabIndex = 4
        Me.edTransStartTime.Text = "4000"
        '
        'label45
        '
        Me.label45.AutoSize = true
        Me.label45.Location = New System.Drawing.Point(12, 84)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(51, 13)
        Me.label45.TabIndex = 3
        Me.label45.Text = "Start time"
        '
        'btAddTransition
        '
        Me.btAddTransition.Location = New System.Drawing.Point(203, 42)
        Me.btAddTransition.Name = "btAddTransition"
        Me.btAddTransition.Size = New System.Drawing.Size(42, 23)
        Me.btAddTransition.TabIndex = 2
        Me.btAddTransition.Text = "Add"
        Me.btAddTransition.UseVisualStyleBackColor = true
        '
        'cbTransitionName
        '
        Me.cbTransitionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransitionName.FormattingEnabled = true
        Me.cbTransitionName.Location = New System.Drawing.Point(15, 44)
        Me.cbTransitionName.Name = "cbTransitionName"
        Me.cbTransitionName.Size = New System.Drawing.Size(182, 21)
        Me.cbTransitionName.TabIndex = 1
        '
        'label44
        '
        Me.label44.AutoSize = true
        Me.label44.Location = New System.Drawing.Point(12, 28)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(35, 13)
        Me.label44.TabIndex = 0
        Me.label44.Text = "Name"
        '
        'lbTransitions
        '
        Me.lbTransitions.FormattingEnabled = true
        Me.lbTransitions.Location = New System.Drawing.Point(20, 35)
        Me.lbTransitions.Name = "lbTransitions"
        Me.lbTransitions.Size = New System.Drawing.Size(251, 82)
        Me.lbTransitions.TabIndex = 1
        '
        'label43
        '
        Me.label43.AutoSize = true
        Me.label43.Location = New System.Drawing.Point(17, 19)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(49, 13)
        Me.label43.TabIndex = 0
        Me.label43.Text = "Selected"
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.Label24)
        Me.tabPage3.Controls.Add(Me.tabControl18)
        Me.tabPage3.Controls.Add(Me.cbAudioEffectsEnabled)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(302, 494)
        Me.tabPage3.TabIndex = 5
        Me.tabPage3.Text = "Audio effects"
        Me.tabPage3.UseVisualStyleBackColor = true
        '
        'Label24
        '
        Me.Label24.AutoSize = true
        Me.Label24.Location = New System.Drawing.Point(96, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(188, 13)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Much more effects available using API"
        '
        'tabControl18
        '
        Me.tabControl18.Controls.Add(Me.tabPage71)
        Me.tabControl18.Controls.Add(Me.tabPage72)
        Me.tabControl18.Controls.Add(Me.tabPage73)
        Me.tabControl18.Controls.Add(Me.tabPage75)
        Me.tabControl18.Controls.Add(Me.tabPage76)
        Me.tabControl18.Location = New System.Drawing.Point(10, 38)
        Me.tabControl18.Name = "tabControl18"
        Me.tabControl18.SelectedIndex = 0
        Me.tabControl18.Size = New System.Drawing.Size(283, 442)
        Me.tabControl18.TabIndex = 3
        '
        'tabPage71
        '
        Me.tabPage71.Controls.Add(Me.label231)
        Me.tabPage71.Controls.Add(Me.label230)
        Me.tabPage71.Controls.Add(Me.tbAudAmplifyAmp)
        Me.tabPage71.Controls.Add(Me.label95)
        Me.tabPage71.Controls.Add(Me.cbAudAmplifyEnabled)
        Me.tabPage71.Location = New System.Drawing.Point(4, 22)
        Me.tabPage71.Name = "tabPage71"
        Me.tabPage71.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage71.Size = New System.Drawing.Size(275, 416)
        Me.tabPage71.TabIndex = 0
        Me.tabPage71.Text = "Amplify"
        Me.tabPage71.UseVisualStyleBackColor = true
        '
        'label231
        '
        Me.label231.AutoSize = true
        Me.label231.Location = New System.Drawing.Point(213, 53)
        Me.label231.Name = "label231"
        Me.label231.Size = New System.Drawing.Size(33, 13)
        Me.label231.TabIndex = 5
        Me.label231.Text = "400%"
        '
        'label230
        '
        Me.label230.AutoSize = true
        Me.label230.Location = New System.Drawing.Point(68, 53)
        Me.label230.Name = "label230"
        Me.label230.Size = New System.Drawing.Size(33, 13)
        Me.label230.TabIndex = 4
        Me.label230.Text = "100%"
        '
        'tbAudAmplifyAmp
        '
        Me.tbAudAmplifyAmp.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudAmplifyAmp.Location = New System.Drawing.Point(16, 69)
        Me.tbAudAmplifyAmp.Maximum = 4000
        Me.tbAudAmplifyAmp.Name = "tbAudAmplifyAmp"
        Me.tbAudAmplifyAmp.Size = New System.Drawing.Size(230, 45)
        Me.tbAudAmplifyAmp.TabIndex = 3
        Me.tbAudAmplifyAmp.TickFrequency = 50
        Me.tbAudAmplifyAmp.Value = 1000
        '
        'label95
        '
        Me.label95.AutoSize = true
        Me.label95.Location = New System.Drawing.Point(13, 53)
        Me.label95.Name = "label95"
        Me.label95.Size = New System.Drawing.Size(42, 13)
        Me.label95.TabIndex = 2
        Me.label95.Text = "Volume"
        '
        'cbAudAmplifyEnabled
        '
        Me.cbAudAmplifyEnabled.AutoSize = true
        Me.cbAudAmplifyEnabled.Location = New System.Drawing.Point(16, 16)
        Me.cbAudAmplifyEnabled.Name = "cbAudAmplifyEnabled"
        Me.cbAudAmplifyEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudAmplifyEnabled.TabIndex = 1
        Me.cbAudAmplifyEnabled.Text = "Enabled"
        Me.cbAudAmplifyEnabled.UseVisualStyleBackColor = true
        '
        'tabPage72
        '
        Me.tabPage72.Controls.Add(Me.btAudEqRefresh)
        Me.tabPage72.Controls.Add(Me.cbAudEqualizerPreset)
        Me.tabPage72.Controls.Add(Me.label243)
        Me.tabPage72.Controls.Add(Me.label242)
        Me.tabPage72.Controls.Add(Me.label241)
        Me.tabPage72.Controls.Add(Me.label240)
        Me.tabPage72.Controls.Add(Me.label239)
        Me.tabPage72.Controls.Add(Me.label238)
        Me.tabPage72.Controls.Add(Me.label237)
        Me.tabPage72.Controls.Add(Me.label236)
        Me.tabPage72.Controls.Add(Me.label235)
        Me.tabPage72.Controls.Add(Me.label234)
        Me.tabPage72.Controls.Add(Me.label233)
        Me.tabPage72.Controls.Add(Me.label232)
        Me.tabPage72.Controls.Add(Me.tbAudEq9)
        Me.tabPage72.Controls.Add(Me.tbAudEq8)
        Me.tabPage72.Controls.Add(Me.tbAudEq7)
        Me.tabPage72.Controls.Add(Me.tbAudEq6)
        Me.tabPage72.Controls.Add(Me.tbAudEq5)
        Me.tabPage72.Controls.Add(Me.tbAudEq4)
        Me.tabPage72.Controls.Add(Me.tbAudEq3)
        Me.tabPage72.Controls.Add(Me.tbAudEq2)
        Me.tabPage72.Controls.Add(Me.tbAudEq1)
        Me.tabPage72.Controls.Add(Me.tbAudEq0)
        Me.tabPage72.Controls.Add(Me.cbAudEqualizerEnabled)
        Me.tabPage72.Location = New System.Drawing.Point(4, 22)
        Me.tabPage72.Name = "tabPage72"
        Me.tabPage72.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage72.Size = New System.Drawing.Size(275, 416)
        Me.tabPage72.TabIndex = 1
        Me.tabPage72.Text = "Equlizer"
        Me.tabPage72.UseVisualStyleBackColor = true
        '
        'btAudEqRefresh
        '
        Me.btAudEqRefresh.Location = New System.Drawing.Point(175, 219)
        Me.btAudEqRefresh.Name = "btAudEqRefresh"
        Me.btAudEqRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btAudEqRefresh.TabIndex = 26
        Me.btAudEqRefresh.Text = "Refresh"
        Me.btAudEqRefresh.UseVisualStyleBackColor = true
        '
        'cbAudEqualizerPreset
        '
        Me.cbAudEqualizerPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudEqualizerPreset.FormattingEnabled = true
        Me.cbAudEqualizerPreset.Location = New System.Drawing.Point(61, 180)
        Me.cbAudEqualizerPreset.Name = "cbAudEqualizerPreset"
        Me.cbAudEqualizerPreset.Size = New System.Drawing.Size(189, 21)
        Me.cbAudEqualizerPreset.TabIndex = 25
        '
        'label243
        '
        Me.label243.AutoSize = true
        Me.label243.Location = New System.Drawing.Point(14, 183)
        Me.label243.Name = "label243"
        Me.label243.Size = New System.Drawing.Size(37, 13)
        Me.label243.TabIndex = 24
        Me.label243.Text = "Preset"
        '
        'label242
        '
        Me.label242.AutoSize = true
        Me.label242.Location = New System.Drawing.Point(206, 156)
        Me.label242.Name = "label242"
        Me.label242.Size = New System.Drawing.Size(26, 13)
        Me.label242.TabIndex = 23
        Me.label242.Text = "16K"
        '
        'label241
        '
        Me.label241.AutoSize = true
        Me.label241.Location = New System.Drawing.Point(184, 156)
        Me.label241.Name = "label241"
        Me.label241.Size = New System.Drawing.Size(26, 13)
        Me.label241.TabIndex = 22
        Me.label241.Text = "14K"
        '
        'label240
        '
        Me.label240.AutoSize = true
        Me.label240.Location = New System.Drawing.Point(162, 156)
        Me.label240.Name = "label240"
        Me.label240.Size = New System.Drawing.Size(26, 13)
        Me.label240.TabIndex = 21
        Me.label240.Text = "12K"
        '
        'label239
        '
        Me.label239.AutoSize = true
        Me.label239.Location = New System.Drawing.Point(143, 156)
        Me.label239.Name = "label239"
        Me.label239.Size = New System.Drawing.Size(20, 13)
        Me.label239.TabIndex = 20
        Me.label239.Text = "6K"
        '
        'label238
        '
        Me.label238.AutoSize = true
        Me.label238.Location = New System.Drawing.Point(121, 156)
        Me.label238.Name = "label238"
        Me.label238.Size = New System.Drawing.Size(20, 13)
        Me.label238.TabIndex = 19
        Me.label238.Text = "3K"
        '
        'label237
        '
        Me.label237.AutoSize = true
        Me.label237.Location = New System.Drawing.Point(102, 156)
        Me.label237.Name = "label237"
        Me.label237.Size = New System.Drawing.Size(20, 13)
        Me.label237.TabIndex = 18
        Me.label237.Text = "1K"
        '
        'label236
        '
        Me.label236.AutoSize = true
        Me.label236.Location = New System.Drawing.Point(80, 156)
        Me.label236.Name = "label236"
        Me.label236.Size = New System.Drawing.Size(25, 13)
        Me.label236.TabIndex = 17
        Me.label236.Text = "600"
        '
        'label235
        '
        Me.label235.AutoSize = true
        Me.label235.Location = New System.Drawing.Point(58, 156)
        Me.label235.Name = "label235"
        Me.label235.Size = New System.Drawing.Size(25, 13)
        Me.label235.TabIndex = 16
        Me.label235.Text = "310"
        '
        'label234
        '
        Me.label234.AutoSize = true
        Me.label234.Location = New System.Drawing.Point(36, 156)
        Me.label234.Name = "label234"
        Me.label234.Size = New System.Drawing.Size(25, 13)
        Me.label234.TabIndex = 15
        Me.label234.Text = "170"
        '
        'label233
        '
        Me.label233.AutoSize = true
        Me.label233.Location = New System.Drawing.Point(18, 156)
        Me.label233.Name = "label233"
        Me.label233.Size = New System.Drawing.Size(19, 13)
        Me.label233.TabIndex = 14
        Me.label233.Text = "60"
        '
        'label232
        '
        Me.label232.AutoSize = true
        Me.label232.Location = New System.Drawing.Point(118, 33)
        Me.label232.Name = "label232"
        Me.label232.Size = New System.Drawing.Size(13, 13)
        Me.label232.TabIndex = 13
        Me.label232.Text = "0"
        '
        'tbAudEq9
        '
        Me.tbAudEq9.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq9.Location = New System.Drawing.Point(205, 49)
        Me.tbAudEq9.Maximum = 100
        Me.tbAudEq9.Minimum = -100
        Me.tbAudEq9.Name = "tbAudEq9"
        Me.tbAudEq9.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq9.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq9.TabIndex = 12
        Me.tbAudEq9.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq8
        '
        Me.tbAudEq8.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq8.Location = New System.Drawing.Point(184, 49)
        Me.tbAudEq8.Maximum = 100
        Me.tbAudEq8.Minimum = -100
        Me.tbAudEq8.Name = "tbAudEq8"
        Me.tbAudEq8.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq8.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq8.TabIndex = 11
        Me.tbAudEq8.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq7
        '
        Me.tbAudEq7.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq7.Location = New System.Drawing.Point(162, 49)
        Me.tbAudEq7.Maximum = 100
        Me.tbAudEq7.Minimum = -100
        Me.tbAudEq7.Name = "tbAudEq7"
        Me.tbAudEq7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq7.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq7.TabIndex = 10
        Me.tbAudEq7.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq6
        '
        Me.tbAudEq6.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq6.Location = New System.Drawing.Point(141, 49)
        Me.tbAudEq6.Maximum = 100
        Me.tbAudEq6.Minimum = -100
        Me.tbAudEq6.Name = "tbAudEq6"
        Me.tbAudEq6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq6.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq6.TabIndex = 9
        Me.tbAudEq6.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq5
        '
        Me.tbAudEq5.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq5.Location = New System.Drawing.Point(120, 49)
        Me.tbAudEq5.Maximum = 100
        Me.tbAudEq5.Minimum = -100
        Me.tbAudEq5.Name = "tbAudEq5"
        Me.tbAudEq5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq5.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq5.TabIndex = 8
        Me.tbAudEq5.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq4
        '
        Me.tbAudEq4.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq4.Location = New System.Drawing.Point(100, 49)
        Me.tbAudEq4.Maximum = 100
        Me.tbAudEq4.Minimum = -100
        Me.tbAudEq4.Name = "tbAudEq4"
        Me.tbAudEq4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq4.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq4.TabIndex = 7
        Me.tbAudEq4.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq3
        '
        Me.tbAudEq3.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq3.Location = New System.Drawing.Point(79, 49)
        Me.tbAudEq3.Maximum = 100
        Me.tbAudEq3.Minimum = -100
        Me.tbAudEq3.Name = "tbAudEq3"
        Me.tbAudEq3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq3.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq3.TabIndex = 6
        Me.tbAudEq3.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq2
        '
        Me.tbAudEq2.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq2.Location = New System.Drawing.Point(58, 49)
        Me.tbAudEq2.Maximum = 100
        Me.tbAudEq2.Minimum = -100
        Me.tbAudEq2.Name = "tbAudEq2"
        Me.tbAudEq2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq2.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq2.TabIndex = 5
        Me.tbAudEq2.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq1
        '
        Me.tbAudEq1.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq1.Location = New System.Drawing.Point(37, 49)
        Me.tbAudEq1.Maximum = 100
        Me.tbAudEq1.Minimum = -100
        Me.tbAudEq1.Name = "tbAudEq1"
        Me.tbAudEq1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq1.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq1.TabIndex = 4
        Me.tbAudEq1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbAudEq0
        '
        Me.tbAudEq0.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudEq0.Location = New System.Drawing.Point(17, 49)
        Me.tbAudEq0.Maximum = 100
        Me.tbAudEq0.Minimum = -100
        Me.tbAudEq0.Name = "tbAudEq0"
        Me.tbAudEq0.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudEq0.Size = New System.Drawing.Size(45, 104)
        Me.tbAudEq0.TabIndex = 3
        Me.tbAudEq0.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'cbAudEqualizerEnabled
        '
        Me.cbAudEqualizerEnabled.AutoSize = true
        Me.cbAudEqualizerEnabled.Location = New System.Drawing.Point(16, 16)
        Me.cbAudEqualizerEnabled.Name = "cbAudEqualizerEnabled"
        Me.cbAudEqualizerEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudEqualizerEnabled.TabIndex = 2
        Me.cbAudEqualizerEnabled.Text = "Enabled"
        Me.cbAudEqualizerEnabled.UseVisualStyleBackColor = true
        '
        'tabPage73
        '
        Me.tabPage73.Controls.Add(Me.tbAudRelease)
        Me.tabPage73.Controls.Add(Me.label248)
        Me.tabPage73.Controls.Add(Me.label249)
        Me.tabPage73.Controls.Add(Me.label246)
        Me.tabPage73.Controls.Add(Me.tbAudAttack)
        Me.tabPage73.Controls.Add(Me.label247)
        Me.tabPage73.Controls.Add(Me.label244)
        Me.tabPage73.Controls.Add(Me.tbAudDynAmp)
        Me.tabPage73.Controls.Add(Me.label245)
        Me.tabPage73.Controls.Add(Me.cbAudDynamicAmplifyEnabled)
        Me.tabPage73.Location = New System.Drawing.Point(4, 22)
        Me.tabPage73.Name = "tabPage73"
        Me.tabPage73.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage73.Size = New System.Drawing.Size(275, 416)
        Me.tabPage73.TabIndex = 2
        Me.tabPage73.Text = "Dynamic amplify"
        Me.tabPage73.UseVisualStyleBackColor = true
        '
        'tbAudRelease
        '
        Me.tbAudRelease.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudRelease.Location = New System.Drawing.Point(16, 209)
        Me.tbAudRelease.Maximum = 10000
        Me.tbAudRelease.Minimum = 10
        Me.tbAudRelease.Name = "tbAudRelease"
        Me.tbAudRelease.Size = New System.Drawing.Size(230, 45)
        Me.tbAudRelease.TabIndex = 15
        Me.tbAudRelease.TickFrequency = 250
        Me.tbAudRelease.Value = 10
        '
        'label248
        '
        Me.label248.AutoSize = true
        Me.label248.Location = New System.Drawing.Point(233, 193)
        Me.label248.Name = "label248"
        Me.label248.Size = New System.Drawing.Size(13, 13)
        Me.label248.TabIndex = 14
        Me.label248.Text = "0"
        '
        'label249
        '
        Me.label249.AutoSize = true
        Me.label249.Location = New System.Drawing.Point(13, 193)
        Me.label249.Name = "label249"
        Me.label249.Size = New System.Drawing.Size(68, 13)
        Me.label249.TabIndex = 12
        Me.label249.Text = "Release time"
        '
        'label246
        '
        Me.label246.AutoSize = true
        Me.label246.Location = New System.Drawing.Point(233, 121)
        Me.label246.Name = "label246"
        Me.label246.Size = New System.Drawing.Size(13, 13)
        Me.label246.TabIndex = 11
        Me.label246.Text = "0"
        '
        'tbAudAttack
        '
        Me.tbAudAttack.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudAttack.Location = New System.Drawing.Point(16, 137)
        Me.tbAudAttack.Maximum = 10000
        Me.tbAudAttack.Minimum = 10
        Me.tbAudAttack.Name = "tbAudAttack"
        Me.tbAudAttack.Size = New System.Drawing.Size(230, 45)
        Me.tbAudAttack.TabIndex = 10
        Me.tbAudAttack.TickFrequency = 250
        Me.tbAudAttack.Value = 10
        '
        'label247
        '
        Me.label247.AutoSize = true
        Me.label247.Location = New System.Drawing.Point(13, 121)
        Me.label247.Name = "label247"
        Me.label247.Size = New System.Drawing.Size(38, 13)
        Me.label247.TabIndex = 9
        Me.label247.Text = "Attack"
        '
        'label244
        '
        Me.label244.AutoSize = true
        Me.label244.Location = New System.Drawing.Point(233, 53)
        Me.label244.Name = "label244"
        Me.label244.Size = New System.Drawing.Size(13, 13)
        Me.label244.TabIndex = 8
        Me.label244.Text = "0"
        '
        'tbAudDynAmp
        '
        Me.tbAudDynAmp.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudDynAmp.Location = New System.Drawing.Point(16, 69)
        Me.tbAudDynAmp.Maximum = 2000
        Me.tbAudDynAmp.Minimum = 100
        Me.tbAudDynAmp.Name = "tbAudDynAmp"
        Me.tbAudDynAmp.Size = New System.Drawing.Size(230, 45)
        Me.tbAudDynAmp.TabIndex = 7
        Me.tbAudDynAmp.TickFrequency = 50
        Me.tbAudDynAmp.Value = 1000
        '
        'label245
        '
        Me.label245.AutoSize = true
        Me.label245.Location = New System.Drawing.Point(13, 53)
        Me.label245.Name = "label245"
        Me.label245.Size = New System.Drawing.Size(112, 13)
        Me.label245.TabIndex = 6
        Me.label245.Text = "Maximum amplification"
        '
        'cbAudDynamicAmplifyEnabled
        '
        Me.cbAudDynamicAmplifyEnabled.AutoSize = true
        Me.cbAudDynamicAmplifyEnabled.Location = New System.Drawing.Point(16, 16)
        Me.cbAudDynamicAmplifyEnabled.Name = "cbAudDynamicAmplifyEnabled"
        Me.cbAudDynamicAmplifyEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudDynamicAmplifyEnabled.TabIndex = 2
        Me.cbAudDynamicAmplifyEnabled.Text = "Enabled"
        Me.cbAudDynamicAmplifyEnabled.UseVisualStyleBackColor = true
        '
        'tabPage75
        '
        Me.tabPage75.Controls.Add(Me.tbAud3DSound)
        Me.tabPage75.Controls.Add(Me.label253)
        Me.tabPage75.Controls.Add(Me.cbAudSound3DEnabled)
        Me.tabPage75.Location = New System.Drawing.Point(4, 22)
        Me.tabPage75.Name = "tabPage75"
        Me.tabPage75.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage75.Size = New System.Drawing.Size(275, 416)
        Me.tabPage75.TabIndex = 4
        Me.tabPage75.Text = "Sound 3D"
        Me.tabPage75.UseVisualStyleBackColor = true
        '
        'tbAud3DSound
        '
        Me.tbAud3DSound.BackColor = System.Drawing.SystemColors.Window
        Me.tbAud3DSound.Location = New System.Drawing.Point(16, 69)
        Me.tbAud3DSound.Maximum = 10000
        Me.tbAud3DSound.Name = "tbAud3DSound"
        Me.tbAud3DSound.Size = New System.Drawing.Size(230, 45)
        Me.tbAud3DSound.TabIndex = 19
        Me.tbAud3DSound.TickFrequency = 250
        Me.tbAud3DSound.Value = 500
        '
        'label253
        '
        Me.label253.AutoSize = true
        Me.label253.Location = New System.Drawing.Point(13, 53)
        Me.label253.Name = "label253"
        Me.label253.Size = New System.Drawing.Size(82, 13)
        Me.label253.TabIndex = 18
        Me.label253.Text = "3D amplification"
        '
        'cbAudSound3DEnabled
        '
        Me.cbAudSound3DEnabled.AutoSize = true
        Me.cbAudSound3DEnabled.Location = New System.Drawing.Point(16, 16)
        Me.cbAudSound3DEnabled.Name = "cbAudSound3DEnabled"
        Me.cbAudSound3DEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudSound3DEnabled.TabIndex = 2
        Me.cbAudSound3DEnabled.Text = "Enabled"
        Me.cbAudSound3DEnabled.UseVisualStyleBackColor = true
        '
        'tabPage76
        '
        Me.tabPage76.Controls.Add(Me.tbAudTrueBass)
        Me.tabPage76.Controls.Add(Me.label254)
        Me.tabPage76.Controls.Add(Me.cbAudTrueBassEnabled)
        Me.tabPage76.Location = New System.Drawing.Point(4, 22)
        Me.tabPage76.Name = "tabPage76"
        Me.tabPage76.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage76.Size = New System.Drawing.Size(275, 416)
        Me.tabPage76.TabIndex = 5
        Me.tabPage76.Text = "True Bass"
        Me.tabPage76.UseVisualStyleBackColor = true
        '
        'tbAudTrueBass
        '
        Me.tbAudTrueBass.BackColor = System.Drawing.SystemColors.Window
        Me.tbAudTrueBass.Location = New System.Drawing.Point(16, 69)
        Me.tbAudTrueBass.Maximum = 10000
        Me.tbAudTrueBass.Name = "tbAudTrueBass"
        Me.tbAudTrueBass.Size = New System.Drawing.Size(230, 45)
        Me.tbAudTrueBass.TabIndex = 21
        Me.tbAudTrueBass.TickFrequency = 250
        '
        'label254
        '
        Me.label254.AutoSize = true
        Me.label254.Location = New System.Drawing.Point(13, 53)
        Me.label254.Name = "label254"
        Me.label254.Size = New System.Drawing.Size(42, 13)
        Me.label254.TabIndex = 20
        Me.label254.Text = "Volume"
        '
        'cbAudTrueBassEnabled
        '
        Me.cbAudTrueBassEnabled.AutoSize = true
        Me.cbAudTrueBassEnabled.Location = New System.Drawing.Point(16, 16)
        Me.cbAudTrueBassEnabled.Name = "cbAudTrueBassEnabled"
        Me.cbAudTrueBassEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudTrueBassEnabled.TabIndex = 2
        Me.cbAudTrueBassEnabled.Text = "Enabled"
        Me.cbAudTrueBassEnabled.UseVisualStyleBackColor = true
        '
        'cbAudioEffectsEnabled
        '
        Me.cbAudioEffectsEnabled.AutoSize = true
        Me.cbAudioEffectsEnabled.Location = New System.Drawing.Point(10, 15)
        Me.cbAudioEffectsEnabled.Name = "cbAudioEffectsEnabled"
        Me.cbAudioEffectsEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioEffectsEnabled.TabIndex = 2
        Me.cbAudioEffectsEnabled.Text = "Enabled"
        Me.cbAudioEffectsEnabled.UseVisualStyleBackColor = true
        '
        'TabPage57
        '
        Me.TabPage57.Controls.Add(Me.lbAudioTimeshift)
        Me.TabPage57.Controls.Add(Me.tbAudioTimeshift)
        Me.TabPage57.Controls.Add(Me.label115)
        Me.TabPage57.Controls.Add(Me.groupBox1)
        Me.TabPage57.Controls.Add(Me.groupBox2)
        Me.TabPage57.Controls.Add(Me.cbAudioAutoGain)
        Me.TabPage57.Controls.Add(Me.cbAudioNormalize)
        Me.TabPage57.Controls.Add(Me.cbAudioEnhancementEnabled)
        Me.TabPage57.Location = New System.Drawing.Point(4, 22)
        Me.TabPage57.Name = "TabPage57"
        Me.TabPage57.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage57.Size = New System.Drawing.Size(302, 494)
        Me.TabPage57.TabIndex = 13
        Me.TabPage57.Text = "Audio enhancement"
        Me.TabPage57.UseVisualStyleBackColor = true
        '
        'lbAudioTimeshift
        '
        Me.lbAudioTimeshift.AutoSize = true
        Me.lbAudioTimeshift.Location = New System.Drawing.Point(176, 448)
        Me.lbAudioTimeshift.Name = "lbAudioTimeshift"
        Me.lbAudioTimeshift.Size = New System.Drawing.Size(29, 13)
        Me.lbAudioTimeshift.TabIndex = 20
        Me.lbAudioTimeshift.Text = "0 ms"
        '
        'tbAudioTimeshift
        '
        Me.tbAudioTimeshift.Location = New System.Drawing.Point(66, 437)
        Me.tbAudioTimeshift.Maximum = 1000
        Me.tbAudioTimeshift.Minimum = -1000
        Me.tbAudioTimeshift.Name = "tbAudioTimeshift"
        Me.tbAudioTimeshift.Size = New System.Drawing.Size(104, 45)
        Me.tbAudioTimeshift.SmallChange = 10
        Me.tbAudioTimeshift.TabIndex = 19
        Me.tbAudioTimeshift.TickFrequency = 100
        Me.tbAudioTimeshift.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label115
        '
        Me.label115.AutoSize = true
        Me.label115.Location = New System.Drawing.Point(5, 448)
        Me.label115.Name = "label115"
        Me.label115.Size = New System.Drawing.Size(52, 13)
        Me.label115.TabIndex = 18
        Me.label115.Text = "Time shift"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainLFE)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainLFE)
        Me.groupBox1.Controls.Add(Me.label116)
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainSR)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainSR)
        Me.groupBox1.Controls.Add(Me.label117)
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainSL)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainSL)
        Me.groupBox1.Controls.Add(Me.label118)
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainR)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainR)
        Me.groupBox1.Controls.Add(Me.label119)
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainC)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainC)
        Me.groupBox1.Controls.Add(Me.label121)
        Me.groupBox1.Controls.Add(Me.lbAudioOutputGainL)
        Me.groupBox1.Controls.Add(Me.tbAudioOutputGainL)
        Me.groupBox1.Controls.Add(Me.label122)
        Me.groupBox1.Location = New System.Drawing.Point(8, 257)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(289, 172)
        Me.groupBox1.TabIndex = 17
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "Output gains (dB)"
        '
        'lbAudioOutputGainLFE
        '
        Me.lbAudioOutputGainLFE.AutoSize = true
        Me.lbAudioOutputGainLFE.Location = New System.Drawing.Point(249, 148)
        Me.lbAudioOutputGainLFE.Name = "lbAudioOutputGainLFE"
        Me.lbAudioOutputGainLFE.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainLFE.TabIndex = 17
        Me.lbAudioOutputGainLFE.Text = "0.0"
        '
        'tbAudioOutputGainLFE
        '
        Me.tbAudioOutputGainLFE.Location = New System.Drawing.Point(242, 41)
        Me.tbAudioOutputGainLFE.Maximum = 200
        Me.tbAudioOutputGainLFE.Minimum = -200
        Me.tbAudioOutputGainLFE.Name = "tbAudioOutputGainLFE"
        Me.tbAudioOutputGainLFE.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainLFE.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainLFE.TabIndex = 16
        Me.tbAudioOutputGainLFE.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label116
        '
        Me.label116.AutoSize = true
        Me.label116.Location = New System.Drawing.Point(250, 25)
        Me.label116.Name = "label116"
        Me.label116.Size = New System.Drawing.Size(26, 13)
        Me.label116.TabIndex = 15
        Me.label116.Text = "LFE"
        '
        'lbAudioOutputGainSR
        '
        Me.lbAudioOutputGainSR.AutoSize = true
        Me.lbAudioOutputGainSR.Location = New System.Drawing.Point(201, 148)
        Me.lbAudioOutputGainSR.Name = "lbAudioOutputGainSR"
        Me.lbAudioOutputGainSR.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainSR.TabIndex = 14
        Me.lbAudioOutputGainSR.Text = "0.0"
        '
        'tbAudioOutputGainSR
        '
        Me.tbAudioOutputGainSR.Location = New System.Drawing.Point(194, 41)
        Me.tbAudioOutputGainSR.Maximum = 200
        Me.tbAudioOutputGainSR.Minimum = -200
        Me.tbAudioOutputGainSR.Name = "tbAudioOutputGainSR"
        Me.tbAudioOutputGainSR.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainSR.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainSR.TabIndex = 13
        Me.tbAudioOutputGainSR.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label117
        '
        Me.label117.AutoSize = true
        Me.label117.Location = New System.Drawing.Point(205, 25)
        Me.label117.Name = "label117"
        Me.label117.Size = New System.Drawing.Size(22, 13)
        Me.label117.TabIndex = 12
        Me.label117.Text = "SR"
        '
        'lbAudioOutputGainSL
        '
        Me.lbAudioOutputGainSL.AutoSize = true
        Me.lbAudioOutputGainSL.Location = New System.Drawing.Point(153, 148)
        Me.lbAudioOutputGainSL.Name = "lbAudioOutputGainSL"
        Me.lbAudioOutputGainSL.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainSL.TabIndex = 11
        Me.lbAudioOutputGainSL.Text = "0.0"
        '
        'tbAudioOutputGainSL
        '
        Me.tbAudioOutputGainSL.Location = New System.Drawing.Point(146, 41)
        Me.tbAudioOutputGainSL.Maximum = 200
        Me.tbAudioOutputGainSL.Minimum = -200
        Me.tbAudioOutputGainSL.Name = "tbAudioOutputGainSL"
        Me.tbAudioOutputGainSL.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainSL.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainSL.TabIndex = 10
        Me.tbAudioOutputGainSL.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label118
        '
        Me.label118.AutoSize = true
        Me.label118.Location = New System.Drawing.Point(158, 25)
        Me.label118.Name = "label118"
        Me.label118.Size = New System.Drawing.Size(20, 13)
        Me.label118.TabIndex = 9
        Me.label118.Text = "SL"
        '
        'lbAudioOutputGainR
        '
        Me.lbAudioOutputGainR.AutoSize = true
        Me.lbAudioOutputGainR.Location = New System.Drawing.Point(105, 148)
        Me.lbAudioOutputGainR.Name = "lbAudioOutputGainR"
        Me.lbAudioOutputGainR.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainR.TabIndex = 8
        Me.lbAudioOutputGainR.Text = "0.0"
        '
        'tbAudioOutputGainR
        '
        Me.tbAudioOutputGainR.Location = New System.Drawing.Point(98, 41)
        Me.tbAudioOutputGainR.Maximum = 200
        Me.tbAudioOutputGainR.Minimum = -200
        Me.tbAudioOutputGainR.Name = "tbAudioOutputGainR"
        Me.tbAudioOutputGainR.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainR.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainR.TabIndex = 7
        Me.tbAudioOutputGainR.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label119
        '
        Me.label119.AutoSize = true
        Me.label119.Location = New System.Drawing.Point(114, 25)
        Me.label119.Name = "label119"
        Me.label119.Size = New System.Drawing.Size(15, 13)
        Me.label119.TabIndex = 6
        Me.label119.Text = "R"
        '
        'lbAudioOutputGainC
        '
        Me.lbAudioOutputGainC.AutoSize = true
        Me.lbAudioOutputGainC.Location = New System.Drawing.Point(57, 148)
        Me.lbAudioOutputGainC.Name = "lbAudioOutputGainC"
        Me.lbAudioOutputGainC.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainC.TabIndex = 5
        Me.lbAudioOutputGainC.Text = "0.0"
        '
        'tbAudioOutputGainC
        '
        Me.tbAudioOutputGainC.Location = New System.Drawing.Point(50, 41)
        Me.tbAudioOutputGainC.Maximum = 200
        Me.tbAudioOutputGainC.Minimum = -200
        Me.tbAudioOutputGainC.Name = "tbAudioOutputGainC"
        Me.tbAudioOutputGainC.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainC.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainC.TabIndex = 4
        Me.tbAudioOutputGainC.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label121
        '
        Me.label121.AutoSize = true
        Me.label121.Location = New System.Drawing.Point(66, 25)
        Me.label121.Name = "label121"
        Me.label121.Size = New System.Drawing.Size(14, 13)
        Me.label121.TabIndex = 3
        Me.label121.Text = "C"
        '
        'lbAudioOutputGainL
        '
        Me.lbAudioOutputGainL.AutoSize = true
        Me.lbAudioOutputGainL.Location = New System.Drawing.Point(9, 148)
        Me.lbAudioOutputGainL.Name = "lbAudioOutputGainL"
        Me.lbAudioOutputGainL.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioOutputGainL.TabIndex = 2
        Me.lbAudioOutputGainL.Text = "0.0"
        '
        'tbAudioOutputGainL
        '
        Me.tbAudioOutputGainL.Location = New System.Drawing.Point(2, 41)
        Me.tbAudioOutputGainL.Maximum = 200
        Me.tbAudioOutputGainL.Minimum = -200
        Me.tbAudioOutputGainL.Name = "tbAudioOutputGainL"
        Me.tbAudioOutputGainL.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioOutputGainL.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioOutputGainL.TabIndex = 1
        Me.tbAudioOutputGainL.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label122
        '
        Me.label122.AutoSize = true
        Me.label122.Location = New System.Drawing.Point(18, 25)
        Me.label122.Name = "label122"
        Me.label122.Size = New System.Drawing.Size(13, 13)
        Me.label122.TabIndex = 0
        Me.label122.Text = "L"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainLFE)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainLFE)
        Me.groupBox2.Controls.Add(Me.label123)
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainSR)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainSR)
        Me.groupBox2.Controls.Add(Me.label124)
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainSL)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainSL)
        Me.groupBox2.Controls.Add(Me.label125)
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainR)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainR)
        Me.groupBox2.Controls.Add(Me.label126)
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainC)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainC)
        Me.groupBox2.Controls.Add(Me.label127)
        Me.groupBox2.Controls.Add(Me.lbAudioInputGainL)
        Me.groupBox2.Controls.Add(Me.tbAudioInputGainL)
        Me.groupBox2.Controls.Add(Me.label128)
        Me.groupBox2.Location = New System.Drawing.Point(8, 79)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(289, 172)
        Me.groupBox2.TabIndex = 16
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Input gains (dB)"
        '
        'lbAudioInputGainLFE
        '
        Me.lbAudioInputGainLFE.AutoSize = true
        Me.lbAudioInputGainLFE.Location = New System.Drawing.Point(249, 148)
        Me.lbAudioInputGainLFE.Name = "lbAudioInputGainLFE"
        Me.lbAudioInputGainLFE.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainLFE.TabIndex = 17
        Me.lbAudioInputGainLFE.Text = "0.0"
        '
        'tbAudioInputGainLFE
        '
        Me.tbAudioInputGainLFE.Location = New System.Drawing.Point(242, 41)
        Me.tbAudioInputGainLFE.Maximum = 200
        Me.tbAudioInputGainLFE.Minimum = -200
        Me.tbAudioInputGainLFE.Name = "tbAudioInputGainLFE"
        Me.tbAudioInputGainLFE.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainLFE.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainLFE.TabIndex = 16
        Me.tbAudioInputGainLFE.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label123
        '
        Me.label123.AutoSize = true
        Me.label123.Location = New System.Drawing.Point(250, 25)
        Me.label123.Name = "label123"
        Me.label123.Size = New System.Drawing.Size(26, 13)
        Me.label123.TabIndex = 15
        Me.label123.Text = "LFE"
        '
        'lbAudioInputGainSR
        '
        Me.lbAudioInputGainSR.AutoSize = true
        Me.lbAudioInputGainSR.Location = New System.Drawing.Point(201, 148)
        Me.lbAudioInputGainSR.Name = "lbAudioInputGainSR"
        Me.lbAudioInputGainSR.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainSR.TabIndex = 14
        Me.lbAudioInputGainSR.Text = "0.0"
        '
        'tbAudioInputGainSR
        '
        Me.tbAudioInputGainSR.Location = New System.Drawing.Point(194, 41)
        Me.tbAudioInputGainSR.Maximum = 200
        Me.tbAudioInputGainSR.Minimum = -200
        Me.tbAudioInputGainSR.Name = "tbAudioInputGainSR"
        Me.tbAudioInputGainSR.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainSR.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainSR.TabIndex = 13
        Me.tbAudioInputGainSR.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label124
        '
        Me.label124.AutoSize = true
        Me.label124.Location = New System.Drawing.Point(205, 25)
        Me.label124.Name = "label124"
        Me.label124.Size = New System.Drawing.Size(22, 13)
        Me.label124.TabIndex = 12
        Me.label124.Text = "SR"
        '
        'lbAudioInputGainSL
        '
        Me.lbAudioInputGainSL.AutoSize = true
        Me.lbAudioInputGainSL.Location = New System.Drawing.Point(153, 148)
        Me.lbAudioInputGainSL.Name = "lbAudioInputGainSL"
        Me.lbAudioInputGainSL.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainSL.TabIndex = 11
        Me.lbAudioInputGainSL.Text = "0.0"
        '
        'tbAudioInputGainSL
        '
        Me.tbAudioInputGainSL.Location = New System.Drawing.Point(146, 41)
        Me.tbAudioInputGainSL.Maximum = 200
        Me.tbAudioInputGainSL.Minimum = -200
        Me.tbAudioInputGainSL.Name = "tbAudioInputGainSL"
        Me.tbAudioInputGainSL.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainSL.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainSL.TabIndex = 10
        Me.tbAudioInputGainSL.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label125
        '
        Me.label125.AutoSize = true
        Me.label125.Location = New System.Drawing.Point(158, 25)
        Me.label125.Name = "label125"
        Me.label125.Size = New System.Drawing.Size(20, 13)
        Me.label125.TabIndex = 9
        Me.label125.Text = "SL"
        '
        'lbAudioInputGainR
        '
        Me.lbAudioInputGainR.AutoSize = true
        Me.lbAudioInputGainR.Location = New System.Drawing.Point(105, 148)
        Me.lbAudioInputGainR.Name = "lbAudioInputGainR"
        Me.lbAudioInputGainR.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainR.TabIndex = 8
        Me.lbAudioInputGainR.Text = "0.0"
        '
        'tbAudioInputGainR
        '
        Me.tbAudioInputGainR.Location = New System.Drawing.Point(98, 41)
        Me.tbAudioInputGainR.Maximum = 200
        Me.tbAudioInputGainR.Minimum = -200
        Me.tbAudioInputGainR.Name = "tbAudioInputGainR"
        Me.tbAudioInputGainR.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainR.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainR.TabIndex = 7
        Me.tbAudioInputGainR.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label126
        '
        Me.label126.AutoSize = true
        Me.label126.Location = New System.Drawing.Point(114, 25)
        Me.label126.Name = "label126"
        Me.label126.Size = New System.Drawing.Size(15, 13)
        Me.label126.TabIndex = 6
        Me.label126.Text = "R"
        '
        'lbAudioInputGainC
        '
        Me.lbAudioInputGainC.AutoSize = true
        Me.lbAudioInputGainC.Location = New System.Drawing.Point(57, 148)
        Me.lbAudioInputGainC.Name = "lbAudioInputGainC"
        Me.lbAudioInputGainC.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainC.TabIndex = 5
        Me.lbAudioInputGainC.Text = "0.0"
        '
        'tbAudioInputGainC
        '
        Me.tbAudioInputGainC.Location = New System.Drawing.Point(50, 41)
        Me.tbAudioInputGainC.Maximum = 200
        Me.tbAudioInputGainC.Minimum = -200
        Me.tbAudioInputGainC.Name = "tbAudioInputGainC"
        Me.tbAudioInputGainC.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainC.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainC.TabIndex = 4
        Me.tbAudioInputGainC.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label127
        '
        Me.label127.AutoSize = true
        Me.label127.Location = New System.Drawing.Point(66, 25)
        Me.label127.Name = "label127"
        Me.label127.Size = New System.Drawing.Size(14, 13)
        Me.label127.TabIndex = 3
        Me.label127.Text = "C"
        '
        'lbAudioInputGainL
        '
        Me.lbAudioInputGainL.AutoSize = true
        Me.lbAudioInputGainL.Location = New System.Drawing.Point(9, 148)
        Me.lbAudioInputGainL.Name = "lbAudioInputGainL"
        Me.lbAudioInputGainL.Size = New System.Drawing.Size(22, 13)
        Me.lbAudioInputGainL.TabIndex = 2
        Me.lbAudioInputGainL.Text = "0.0"
        '
        'tbAudioInputGainL
        '
        Me.tbAudioInputGainL.Location = New System.Drawing.Point(2, 41)
        Me.tbAudioInputGainL.Maximum = 200
        Me.tbAudioInputGainL.Minimum = -200
        Me.tbAudioInputGainL.Name = "tbAudioInputGainL"
        Me.tbAudioInputGainL.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbAudioInputGainL.Size = New System.Drawing.Size(45, 104)
        Me.tbAudioInputGainL.TabIndex = 1
        Me.tbAudioInputGainL.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label128
        '
        Me.label128.AutoSize = true
        Me.label128.Location = New System.Drawing.Point(18, 25)
        Me.label128.Name = "label128"
        Me.label128.Size = New System.Drawing.Size(13, 13)
        Me.label128.TabIndex = 0
        Me.label128.Text = "L"
        '
        'cbAudioAutoGain
        '
        Me.cbAudioAutoGain.AutoSize = true
        Me.cbAudioAutoGain.Location = New System.Drawing.Point(135, 45)
        Me.cbAudioAutoGain.Name = "cbAudioAutoGain"
        Me.cbAudioAutoGain.Size = New System.Drawing.Size(71, 17)
        Me.cbAudioAutoGain.TabIndex = 15
        Me.cbAudioAutoGain.Text = "Auto gain"
        Me.cbAudioAutoGain.UseVisualStyleBackColor = true
        '
        'cbAudioNormalize
        '
        Me.cbAudioNormalize.AutoSize = true
        Me.cbAudioNormalize.Location = New System.Drawing.Point(41, 45)
        Me.cbAudioNormalize.Name = "cbAudioNormalize"
        Me.cbAudioNormalize.Size = New System.Drawing.Size(72, 17)
        Me.cbAudioNormalize.TabIndex = 14
        Me.cbAudioNormalize.Text = "Normalize"
        Me.cbAudioNormalize.UseVisualStyleBackColor = true
        '
        'cbAudioEnhancementEnabled
        '
        Me.cbAudioEnhancementEnabled.AutoSize = true
        Me.cbAudioEnhancementEnabled.Location = New System.Drawing.Point(18, 13)
        Me.cbAudioEnhancementEnabled.Name = "cbAudioEnhancementEnabled"
        Me.cbAudioEnhancementEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioEnhancementEnabled.TabIndex = 13
        Me.cbAudioEnhancementEnabled.Text = "Enabled"
        Me.cbAudioEnhancementEnabled.UseVisualStyleBackColor = true
        '
        'TabPage80
        '
        Me.TabPage80.Controls.Add(Me.btAudioChannelMapperClear)
        Me.TabPage80.Controls.Add(Me.groupBox41)
        Me.TabPage80.Controls.Add(Me.label307)
        Me.TabPage80.Controls.Add(Me.edAudioChannelMapperOutputChannels)
        Me.TabPage80.Controls.Add(Me.label306)
        Me.TabPage80.Controls.Add(Me.lbAudioChannelMapperRoutes)
        Me.TabPage80.Controls.Add(Me.cbAudioChannelMapperEnabled)
        Me.TabPage80.Location = New System.Drawing.Point(4, 22)
        Me.TabPage80.Name = "TabPage80"
        Me.TabPage80.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage80.Size = New System.Drawing.Size(302, 494)
        Me.TabPage80.TabIndex = 15
        Me.TabPage80.Text = "Audio channel mapper"
        Me.TabPage80.UseVisualStyleBackColor = true
        '
        'btAudioChannelMapperClear
        '
        Me.btAudioChannelMapperClear.Location = New System.Drawing.Point(202, 219)
        Me.btAudioChannelMapperClear.Name = "btAudioChannelMapperClear"
        Me.btAudioChannelMapperClear.Size = New System.Drawing.Size(75, 23)
        Me.btAudioChannelMapperClear.TabIndex = 28
        Me.btAudioChannelMapperClear.Text = "Clear"
        Me.btAudioChannelMapperClear.UseVisualStyleBackColor = true
        '
        'groupBox41
        '
        Me.groupBox41.Controls.Add(Me.btAudioChannelMapperAddNewRoute)
        Me.groupBox41.Controls.Add(Me.label311)
        Me.groupBox41.Controls.Add(Me.tbAudioChannelMapperVolume)
        Me.groupBox41.Controls.Add(Me.label310)
        Me.groupBox41.Controls.Add(Me.edAudioChannelMapperTargetChannel)
        Me.groupBox41.Controls.Add(Me.label309)
        Me.groupBox41.Controls.Add(Me.edAudioChannelMapperSourceChannel)
        Me.groupBox41.Controls.Add(Me.label308)
        Me.groupBox41.Location = New System.Drawing.Point(4, 248)
        Me.groupBox41.Name = "groupBox41"
        Me.groupBox41.Size = New System.Drawing.Size(292, 171)
        Me.groupBox41.TabIndex = 27
        Me.groupBox41.TabStop = false
        Me.groupBox41.Text = "Add new route"
        '
        'btAudioChannelMapperAddNewRoute
        '
        Me.btAudioChannelMapperAddNewRoute.Location = New System.Drawing.Point(108, 131)
        Me.btAudioChannelMapperAddNewRoute.Name = "btAudioChannelMapperAddNewRoute"
        Me.btAudioChannelMapperAddNewRoute.Size = New System.Drawing.Size(75, 23)
        Me.btAudioChannelMapperAddNewRoute.TabIndex = 20
        Me.btAudioChannelMapperAddNewRoute.Text = "Add"
        Me.btAudioChannelMapperAddNewRoute.UseVisualStyleBackColor = true
        '
        'label311
        '
        Me.label311.AutoSize = true
        Me.label311.Location = New System.Drawing.Point(205, 89)
        Me.label311.Name = "label311"
        Me.label311.Size = New System.Drawing.Size(62, 13)
        Me.label311.TabIndex = 19
        Me.label311.Text = "10% - 200%"
        '
        'tbAudioChannelMapperVolume
        '
        Me.tbAudioChannelMapperVolume.Location = New System.Drawing.Point(208, 41)
        Me.tbAudioChannelMapperVolume.Maximum = 2000
        Me.tbAudioChannelMapperVolume.Minimum = 100
        Me.tbAudioChannelMapperVolume.Name = "tbAudioChannelMapperVolume"
        Me.tbAudioChannelMapperVolume.Size = New System.Drawing.Size(74, 45)
        Me.tbAudioChannelMapperVolume.TabIndex = 18
        Me.tbAudioChannelMapperVolume.Value = 1000
        '
        'label310
        '
        Me.label310.AutoSize = true
        Me.label310.Location = New System.Drawing.Point(205, 25)
        Me.label310.Name = "label310"
        Me.label310.Size = New System.Drawing.Size(42, 13)
        Me.label310.TabIndex = 17
        Me.label310.Text = "Volume"
        '
        'edAudioChannelMapperTargetChannel
        '
        Me.edAudioChannelMapperTargetChannel.Location = New System.Drawing.Point(108, 41)
        Me.edAudioChannelMapperTargetChannel.Name = "edAudioChannelMapperTargetChannel"
        Me.edAudioChannelMapperTargetChannel.Size = New System.Drawing.Size(51, 20)
        Me.edAudioChannelMapperTargetChannel.TabIndex = 16
        Me.edAudioChannelMapperTargetChannel.Text = "0"
        '
        'label309
        '
        Me.label309.AutoSize = true
        Me.label309.Location = New System.Drawing.Point(105, 25)
        Me.label309.Name = "label309"
        Me.label309.Size = New System.Drawing.Size(79, 13)
        Me.label309.TabIndex = 15
        Me.label309.Text = "Target channel"
        '
        'edAudioChannelMapperSourceChannel
        '
        Me.edAudioChannelMapperSourceChannel.Location = New System.Drawing.Point(15, 41)
        Me.edAudioChannelMapperSourceChannel.Name = "edAudioChannelMapperSourceChannel"
        Me.edAudioChannelMapperSourceChannel.Size = New System.Drawing.Size(51, 20)
        Me.edAudioChannelMapperSourceChannel.TabIndex = 14
        Me.edAudioChannelMapperSourceChannel.Text = "0"
        '
        'label308
        '
        Me.label308.AutoSize = true
        Me.label308.Location = New System.Drawing.Point(12, 25)
        Me.label308.Name = "label308"
        Me.label308.Size = New System.Drawing.Size(82, 13)
        Me.label308.TabIndex = 13
        Me.label308.Text = "Source channel"
        '
        'label307
        '
        Me.label307.AutoSize = true
        Me.label307.Location = New System.Drawing.Point(7, 100)
        Me.label307.Name = "label307"
        Me.label307.Size = New System.Drawing.Size(41, 13)
        Me.label307.TabIndex = 26
        Me.label307.Text = "Routes"
        '
        'edAudioChannelMapperOutputChannels
        '
        Me.edAudioChannelMapperOutputChannels.Location = New System.Drawing.Point(10, 61)
        Me.edAudioChannelMapperOutputChannels.Name = "edAudioChannelMapperOutputChannels"
        Me.edAudioChannelMapperOutputChannels.Size = New System.Drawing.Size(42, 20)
        Me.edAudioChannelMapperOutputChannels.TabIndex = 25
        Me.edAudioChannelMapperOutputChannels.Text = "0"
        '
        'label306
        '
        Me.label306.AutoSize = true
        Me.label306.Location = New System.Drawing.Point(7, 45)
        Me.label306.Name = "label306"
        Me.label306.Size = New System.Drawing.Size(274, 13)
        Me.label306.TabIndex = 24
        Me.label306.Text = "Output channels count (0 to use original channels count)"
        '
        'lbAudioChannelMapperRoutes
        '
        Me.lbAudioChannelMapperRoutes.FormattingEnabled = true
        Me.lbAudioChannelMapperRoutes.Location = New System.Drawing.Point(10, 118)
        Me.lbAudioChannelMapperRoutes.Name = "lbAudioChannelMapperRoutes"
        Me.lbAudioChannelMapperRoutes.Size = New System.Drawing.Size(267, 95)
        Me.lbAudioChannelMapperRoutes.TabIndex = 23
        '
        'cbAudioChannelMapperEnabled
        '
        Me.cbAudioChannelMapperEnabled.AutoSize = true
        Me.cbAudioChannelMapperEnabled.Location = New System.Drawing.Point(10, 11)
        Me.cbAudioChannelMapperEnabled.Name = "cbAudioChannelMapperEnabled"
        Me.cbAudioChannelMapperEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioChannelMapperEnabled.TabIndex = 22
        Me.cbAudioChannelMapperEnabled.Text = "Enabled"
        Me.cbAudioChannelMapperEnabled.UseVisualStyleBackColor = true
        '
        'TabPage28
        '
        Me.TabPage28.Controls.Add(Me.tabControl9)
        Me.TabPage28.Controls.Add(Me.cbMotDetEnabled)
        Me.TabPage28.Location = New System.Drawing.Point(4, 22)
        Me.TabPage28.Name = "TabPage28"
        Me.TabPage28.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage28.Size = New System.Drawing.Size(302, 494)
        Me.TabPage28.TabIndex = 7
        Me.TabPage28.Text = "Motion detection"
        Me.TabPage28.UseVisualStyleBackColor = true
        '
        'tabControl9
        '
        Me.tabControl9.Controls.Add(Me.tabPage44)
        Me.tabControl9.Controls.Add(Me.tabPage45)
        Me.tabControl9.Location = New System.Drawing.Point(15, 45)
        Me.tabControl9.Name = "tabControl9"
        Me.tabControl9.SelectedIndex = 0
        Me.tabControl9.Size = New System.Drawing.Size(268, 413)
        Me.tabControl9.TabIndex = 5
        '
        'tabPage44
        '
        Me.tabPage44.Controls.Add(Me.pbMotionLevel)
        Me.tabPage44.Controls.Add(Me.label158)
        Me.tabPage44.Controls.Add(Me.mmMotDetMatrix)
        Me.tabPage44.Location = New System.Drawing.Point(4, 22)
        Me.tabPage44.Name = "tabPage44"
        Me.tabPage44.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage44.Size = New System.Drawing.Size(260, 387)
        Me.tabPage44.TabIndex = 0
        Me.tabPage44.Text = "Output matrix"
        Me.tabPage44.UseVisualStyleBackColor = true
        '
        'pbMotionLevel
        '
        Me.pbMotionLevel.Location = New System.Drawing.Point(47, 207)
        Me.pbMotionLevel.Name = "pbMotionLevel"
        Me.pbMotionLevel.Size = New System.Drawing.Size(197, 19)
        Me.pbMotionLevel.TabIndex = 2
        '
        'label158
        '
        Me.label158.AutoSize = true
        Me.label158.Location = New System.Drawing.Point(16, 187)
        Me.label158.Name = "label158"
        Me.label158.Size = New System.Drawing.Size(64, 13)
        Me.label158.TabIndex = 1
        Me.label158.Text = "Motion level"
        '
        'mmMotDetMatrix
        '
        Me.mmMotDetMatrix.Location = New System.Drawing.Point(17, 19)
        Me.mmMotDetMatrix.Multiline = true
        Me.mmMotDetMatrix.Name = "mmMotDetMatrix"
        Me.mmMotDetMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmMotDetMatrix.Size = New System.Drawing.Size(228, 157)
        Me.mmMotDetMatrix.TabIndex = 0
        '
        'tabPage45
        '
        Me.tabPage45.Controls.Add(Me.groupBox25)
        Me.tabPage45.Controls.Add(Me.btMotDetUpdateSettings)
        Me.tabPage45.Controls.Add(Me.groupBox27)
        Me.tabPage45.Controls.Add(Me.groupBox26)
        Me.tabPage45.Controls.Add(Me.groupBox24)
        Me.tabPage45.Location = New System.Drawing.Point(4, 22)
        Me.tabPage45.Name = "tabPage45"
        Me.tabPage45.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage45.Size = New System.Drawing.Size(260, 387)
        Me.tabPage45.TabIndex = 1
        Me.tabPage45.Text = "Settings"
        Me.tabPage45.UseVisualStyleBackColor = true
        '
        'groupBox25
        '
        Me.groupBox25.Controls.Add(Me.cbMotDetHLColor)
        Me.groupBox25.Controls.Add(Me.label161)
        Me.groupBox25.Controls.Add(Me.label160)
        Me.groupBox25.Controls.Add(Me.cbMotDetHLEnabled)
        Me.groupBox25.Controls.Add(Me.tbMotDetHLThreshold)
        Me.groupBox25.Location = New System.Drawing.Point(12, 103)
        Me.groupBox25.Name = "groupBox25"
        Me.groupBox25.Size = New System.Drawing.Size(233, 86)
        Me.groupBox25.TabIndex = 1
        Me.groupBox25.TabStop = false
        Me.groupBox25.Text = "Color highlight"
        '
        'cbMotDetHLColor
        '
        Me.cbMotDetHLColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMotDetHLColor.FormattingEnabled = true
        Me.cbMotDetHLColor.Items.AddRange(New Object() {"Red", "Green", "Blue"})
        Me.cbMotDetHLColor.Location = New System.Drawing.Point(153, 59)
        Me.cbMotDetHLColor.Name = "cbMotDetHLColor"
        Me.cbMotDetHLColor.Size = New System.Drawing.Size(70, 21)
        Me.cbMotDetHLColor.TabIndex = 5
        '
        'label161
        '
        Me.label161.AutoSize = true
        Me.label161.Location = New System.Drawing.Point(148, 42)
        Me.label161.Name = "label161"
        Me.label161.Size = New System.Drawing.Size(31, 13)
        Me.label161.TabIndex = 4
        Me.label161.Text = "Color"
        '
        'label160
        '
        Me.label160.AutoSize = true
        Me.label160.Location = New System.Drawing.Point(30, 42)
        Me.label160.Name = "label160"
        Me.label160.Size = New System.Drawing.Size(54, 13)
        Me.label160.TabIndex = 2
        Me.label160.Text = "Threshold"
        '
        'cbMotDetHLEnabled
        '
        Me.cbMotDetHLEnabled.AutoSize = true
        Me.cbMotDetHLEnabled.Checked = true
        Me.cbMotDetHLEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMotDetHLEnabled.Location = New System.Drawing.Point(14, 22)
        Me.cbMotDetHLEnabled.Name = "cbMotDetHLEnabled"
        Me.cbMotDetHLEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbMotDetHLEnabled.TabIndex = 1
        Me.cbMotDetHLEnabled.Text = "Enabled"
        Me.cbMotDetHLEnabled.UseVisualStyleBackColor = true
        '
        'tbMotDetHLThreshold
        '
        Me.tbMotDetHLThreshold.BackColor = System.Drawing.SystemColors.Window
        Me.tbMotDetHLThreshold.Location = New System.Drawing.Point(31, 58)
        Me.tbMotDetHLThreshold.Maximum = 255
        Me.tbMotDetHLThreshold.Name = "tbMotDetHLThreshold"
        Me.tbMotDetHLThreshold.Size = New System.Drawing.Size(104, 45)
        Me.tbMotDetHLThreshold.TabIndex = 3
        Me.tbMotDetHLThreshold.TickFrequency = 5
        Me.tbMotDetHLThreshold.Value = 25
        '
        'btMotDetUpdateSettings
        '
        Me.btMotDetUpdateSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btMotDetUpdateSettings.Location = New System.Drawing.Point(138, 358)
        Me.btMotDetUpdateSettings.Name = "btMotDetUpdateSettings"
        Me.btMotDetUpdateSettings.Size = New System.Drawing.Size(107, 23)
        Me.btMotDetUpdateSettings.TabIndex = 4
        Me.btMotDetUpdateSettings.Text = "Update settings"
        Me.btMotDetUpdateSettings.UseVisualStyleBackColor = true
        '
        'groupBox27
        '
        Me.groupBox27.Controls.Add(Me.edMotDetMatrixHeight)
        Me.groupBox27.Controls.Add(Me.label163)
        Me.groupBox27.Controls.Add(Me.edMotDetMatrixWidth)
        Me.groupBox27.Controls.Add(Me.label164)
        Me.groupBox27.Location = New System.Drawing.Point(12, 266)
        Me.groupBox27.Name = "groupBox27"
        Me.groupBox27.Size = New System.Drawing.Size(233, 59)
        Me.groupBox27.TabIndex = 3
        Me.groupBox27.TabStop = false
        Me.groupBox27.Text = "Matrix"
        '
        'edMotDetMatrixHeight
        '
        Me.edMotDetMatrixHeight.Location = New System.Drawing.Point(145, 23)
        Me.edMotDetMatrixHeight.Name = "edMotDetMatrixHeight"
        Me.edMotDetMatrixHeight.Size = New System.Drawing.Size(36, 20)
        Me.edMotDetMatrixHeight.TabIndex = 75
        Me.edMotDetMatrixHeight.Text = "10"
        '
        'label163
        '
        Me.label163.AutoSize = true
        Me.label163.Location = New System.Drawing.Point(98, 26)
        Me.label163.Name = "label163"
        Me.label163.Size = New System.Drawing.Size(38, 13)
        Me.label163.TabIndex = 74
        Me.label163.Text = "Height"
        '
        'edMotDetMatrixWidth
        '
        Me.edMotDetMatrixWidth.Location = New System.Drawing.Point(56, 23)
        Me.edMotDetMatrixWidth.Name = "edMotDetMatrixWidth"
        Me.edMotDetMatrixWidth.Size = New System.Drawing.Size(36, 20)
        Me.edMotDetMatrixWidth.TabIndex = 73
        Me.edMotDetMatrixWidth.Text = "10"
        '
        'label164
        '
        Me.label164.AutoSize = true
        Me.label164.Location = New System.Drawing.Point(14, 26)
        Me.label164.Name = "label164"
        Me.label164.Size = New System.Drawing.Size(35, 13)
        Me.label164.TabIndex = 72
        Me.label164.Text = "Width"
        '
        'groupBox26
        '
        Me.groupBox26.Controls.Add(Me.label162)
        Me.groupBox26.Controls.Add(Me.tbMotDetDropFramesThreshold)
        Me.groupBox26.Controls.Add(Me.cbMotDetDropFramesEnabled)
        Me.groupBox26.Location = New System.Drawing.Point(12, 191)
        Me.groupBox26.Name = "groupBox26"
        Me.groupBox26.Size = New System.Drawing.Size(233, 69)
        Me.groupBox26.TabIndex = 2
        Me.groupBox26.TabStop = false
        Me.groupBox26.Text = "Drop frames"
        '
        'label162
        '
        Me.label162.AutoSize = true
        Me.label162.Location = New System.Drawing.Point(94, 21)
        Me.label162.Name = "label162"
        Me.label162.Size = New System.Drawing.Size(54, 13)
        Me.label162.TabIndex = 4
        Me.label162.Text = "Threshold"
        '
        'tbMotDetDropFramesThreshold
        '
        Me.tbMotDetDropFramesThreshold.BackColor = System.Drawing.SystemColors.Window
        Me.tbMotDetDropFramesThreshold.Location = New System.Drawing.Point(95, 37)
        Me.tbMotDetDropFramesThreshold.Maximum = 255
        Me.tbMotDetDropFramesThreshold.Name = "tbMotDetDropFramesThreshold"
        Me.tbMotDetDropFramesThreshold.Size = New System.Drawing.Size(104, 45)
        Me.tbMotDetDropFramesThreshold.TabIndex = 5
        Me.tbMotDetDropFramesThreshold.TickFrequency = 5
        Me.tbMotDetDropFramesThreshold.Value = 5
        '
        'cbMotDetDropFramesEnabled
        '
        Me.cbMotDetDropFramesEnabled.AutoSize = true
        Me.cbMotDetDropFramesEnabled.Location = New System.Drawing.Point(14, 19)
        Me.cbMotDetDropFramesEnabled.Name = "cbMotDetDropFramesEnabled"
        Me.cbMotDetDropFramesEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbMotDetDropFramesEnabled.TabIndex = 1
        Me.cbMotDetDropFramesEnabled.Text = "Enabled"
        Me.cbMotDetDropFramesEnabled.UseVisualStyleBackColor = true
        '
        'groupBox24
        '
        Me.groupBox24.Controls.Add(Me.edMotDetFrameInterval)
        Me.groupBox24.Controls.Add(Me.label159)
        Me.groupBox24.Controls.Add(Me.cbCompareGreyscale)
        Me.groupBox24.Controls.Add(Me.cbCompareBlue)
        Me.groupBox24.Controls.Add(Me.cbCompareGreen)
        Me.groupBox24.Controls.Add(Me.cbCompareRed)
        Me.groupBox24.Location = New System.Drawing.Point(12, 12)
        Me.groupBox24.Name = "groupBox24"
        Me.groupBox24.Size = New System.Drawing.Size(233, 82)
        Me.groupBox24.TabIndex = 0
        Me.groupBox24.TabStop = false
        Me.groupBox24.Text = "Compare settings"
        '
        'edMotDetFrameInterval
        '
        Me.edMotDetFrameInterval.Location = New System.Drawing.Point(95, 51)
        Me.edMotDetFrameInterval.Name = "edMotDetFrameInterval"
        Me.edMotDetFrameInterval.Size = New System.Drawing.Size(32, 20)
        Me.edMotDetFrameInterval.TabIndex = 5
        Me.edMotDetFrameInterval.Text = "2"
        '
        'label159
        '
        Me.label159.AutoSize = true
        Me.label159.Location = New System.Drawing.Point(11, 54)
        Me.label159.Name = "label159"
        Me.label159.Size = New System.Drawing.Size(73, 13)
        Me.label159.TabIndex = 4
        Me.label159.Text = "Frame interval"
        '
        'cbCompareGreyscale
        '
        Me.cbCompareGreyscale.AutoSize = true
        Me.cbCompareGreyscale.Checked = true
        Me.cbCompareGreyscale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCompareGreyscale.Location = New System.Drawing.Point(163, 21)
        Me.cbCompareGreyscale.Name = "cbCompareGreyscale"
        Me.cbCompareGreyscale.Size = New System.Drawing.Size(73, 17)
        Me.cbCompareGreyscale.TabIndex = 3
        Me.cbCompareGreyscale.Text = "Greyscale"
        Me.cbCompareGreyscale.UseVisualStyleBackColor = true
        '
        'cbCompareBlue
        '
        Me.cbCompareBlue.AutoSize = true
        Me.cbCompareBlue.Location = New System.Drawing.Point(118, 21)
        Me.cbCompareBlue.Name = "cbCompareBlue"
        Me.cbCompareBlue.Size = New System.Drawing.Size(47, 17)
        Me.cbCompareBlue.TabIndex = 2
        Me.cbCompareBlue.Text = "Blue"
        Me.cbCompareBlue.UseVisualStyleBackColor = true
        '
        'cbCompareGreen
        '
        Me.cbCompareGreen.AutoSize = true
        Me.cbCompareGreen.Location = New System.Drawing.Point(60, 21)
        Me.cbCompareGreen.Name = "cbCompareGreen"
        Me.cbCompareGreen.Size = New System.Drawing.Size(55, 17)
        Me.cbCompareGreen.TabIndex = 1
        Me.cbCompareGreen.Text = "Green"
        Me.cbCompareGreen.UseVisualStyleBackColor = true
        '
        'cbCompareRed
        '
        Me.cbCompareRed.AutoSize = true
        Me.cbCompareRed.Location = New System.Drawing.Point(14, 21)
        Me.cbCompareRed.Name = "cbCompareRed"
        Me.cbCompareRed.Size = New System.Drawing.Size(46, 17)
        Me.cbCompareRed.TabIndex = 0
        Me.cbCompareRed.Text = "Red"
        Me.cbCompareRed.UseVisualStyleBackColor = true
        '
        'cbMotDetEnabled
        '
        Me.cbMotDetEnabled.AutoSize = true
        Me.cbMotDetEnabled.Location = New System.Drawing.Point(15, 18)
        Me.cbMotDetEnabled.Name = "cbMotDetEnabled"
        Me.cbMotDetEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbMotDetEnabled.TabIndex = 4
        Me.cbMotDetEnabled.Text = "Enabled"
        Me.cbMotDetEnabled.UseVisualStyleBackColor = true
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.label393)
        Me.tabPage2.Controls.Add(Me.cbDirect2DRotate)
        Me.tabPage2.Controls.Add(Me.pnVideoRendererBGColor)
        Me.tabPage2.Controls.Add(Me.label394)
        Me.tabPage2.Controls.Add(Me.btFullScreen)
        Me.tabPage2.Controls.Add(Me.cbScreenFlipVertical)
        Me.tabPage2.Controls.Add(Me.cbScreenFlipHorizontal)
        Me.tabPage2.Controls.Add(Me.cbStretch)
        Me.tabPage2.Controls.Add(Me.groupBox13)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(302, 494)
        Me.tabPage2.TabIndex = 6
        Me.tabPage2.Text = "Display"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'label393
        '
        Me.label393.AutoSize = true
        Me.label393.Location = New System.Drawing.Point(21, 265)
        Me.label393.Name = "label393"
        Me.label393.Size = New System.Drawing.Size(79, 13)
        Me.label393.TabIndex = 75
        Me.label393.Text = "Direct2D rotate"
        '
        'cbDirect2DRotate
        '
        Me.cbDirect2DRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDirect2DRotate.FormattingEnabled = true
        Me.cbDirect2DRotate.Items.AddRange(New Object() {"0", "90", "180", "270"})
        Me.cbDirect2DRotate.Location = New System.Drawing.Point(24, 281)
        Me.cbDirect2DRotate.Name = "cbDirect2DRotate"
        Me.cbDirect2DRotate.Size = New System.Drawing.Size(122, 21)
        Me.cbDirect2DRotate.TabIndex = 74
        '
        'pnVideoRendererBGColor
        '
        Me.pnVideoRendererBGColor.BackColor = System.Drawing.Color.Black
        Me.pnVideoRendererBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnVideoRendererBGColor.Location = New System.Drawing.Point(128, 179)
        Me.pnVideoRendererBGColor.Name = "pnVideoRendererBGColor"
        Me.pnVideoRendererBGColor.Size = New System.Drawing.Size(24, 24)
        Me.pnVideoRendererBGColor.TabIndex = 73
        '
        'label394
        '
        Me.label394.AutoSize = true
        Me.label394.Location = New System.Drawing.Point(21, 184)
        Me.label394.Name = "label394"
        Me.label394.Size = New System.Drawing.Size(91, 13)
        Me.label394.TabIndex = 72
        Me.label394.Text = "Background color"
        '
        'btFullScreen
        '
        Me.btFullScreen.Location = New System.Drawing.Point(184, 281)
        Me.btFullScreen.Name = "btFullScreen"
        Me.btFullScreen.Size = New System.Drawing.Size(90, 23)
        Me.btFullScreen.TabIndex = 71
        Me.btFullScreen.Text = "Full screen"
        Me.btFullScreen.UseVisualStyleBackColor = true
        '
        'cbScreenFlipVertical
        '
        Me.cbScreenFlipVertical.AutoSize = true
        Me.cbScreenFlipVertical.Location = New System.Drawing.Point(184, 203)
        Me.cbScreenFlipVertical.Name = "cbScreenFlipVertical"
        Me.cbScreenFlipVertical.Size = New System.Drawing.Size(79, 17)
        Me.cbScreenFlipVertical.TabIndex = 70
        Me.cbScreenFlipVertical.Text = "Flip vertical"
        Me.cbScreenFlipVertical.UseVisualStyleBackColor = true
        '
        'cbScreenFlipHorizontal
        '
        Me.cbScreenFlipHorizontal.AutoSize = true
        Me.cbScreenFlipHorizontal.Location = New System.Drawing.Point(184, 180)
        Me.cbScreenFlipHorizontal.Name = "cbScreenFlipHorizontal"
        Me.cbScreenFlipHorizontal.Size = New System.Drawing.Size(90, 17)
        Me.cbScreenFlipHorizontal.TabIndex = 69
        Me.cbScreenFlipHorizontal.Text = "Flip horizontal"
        Me.cbScreenFlipHorizontal.UseVisualStyleBackColor = true
        '
        'cbStretch
        '
        Me.cbStretch.AutoSize = true
        Me.cbStretch.Location = New System.Drawing.Point(184, 228)
        Me.cbStretch.Name = "cbStretch"
        Me.cbStretch.Size = New System.Drawing.Size(89, 17)
        Me.cbStretch.TabIndex = 68
        Me.cbStretch.Text = "Stretch video"
        Me.cbStretch.UseVisualStyleBackColor = true
        '
        'groupBox13
        '
        Me.groupBox13.Controls.Add(Me.rbDirect2D)
        Me.groupBox13.Controls.Add(Me.rbNone)
        Me.groupBox13.Controls.Add(Me.rbEVR)
        Me.groupBox13.Controls.Add(Me.rbVMR9)
        Me.groupBox13.Controls.Add(Me.rbVR)
        Me.groupBox13.Location = New System.Drawing.Point(24, 27)
        Me.groupBox13.Name = "groupBox13"
        Me.groupBox13.Size = New System.Drawing.Size(250, 138)
        Me.groupBox13.TabIndex = 67
        Me.groupBox13.TabStop = false
        Me.groupBox13.Text = "Video Renderer"
        '
        'rbDirect2D
        '
        Me.rbDirect2D.AutoSize = true
        Me.rbDirect2D.Location = New System.Drawing.Point(12, 90)
        Me.rbDirect2D.Name = "rbDirect2D"
        Me.rbDirect2D.Size = New System.Drawing.Size(67, 17)
        Me.rbDirect2D.TabIndex = 4
        Me.rbDirect2D.TabStop = true
        Me.rbDirect2D.Text = "Direct2D"
        Me.rbDirect2D.UseVisualStyleBackColor = true
        '
        'rbNone
        '
        Me.rbNone.AutoSize = true
        Me.rbNone.Location = New System.Drawing.Point(12, 113)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(51, 17)
        Me.rbNone.TabIndex = 3
        Me.rbNone.TabStop = true
        Me.rbNone.Text = "None"
        Me.rbNone.UseVisualStyleBackColor = true
        '
        'rbEVR
        '
        Me.rbEVR.AutoSize = true
        Me.rbEVR.Location = New System.Drawing.Point(12, 67)
        Me.rbEVR.Name = "rbEVR"
        Me.rbEVR.Size = New System.Drawing.Size(227, 17)
        Me.rbEVR.TabIndex = 2
        Me.rbEVR.Text = "Enhanced Video Renderer (Vista and later)"
        Me.rbEVR.UseVisualStyleBackColor = true
        '
        'rbVMR9
        '
        Me.rbVMR9.AutoSize = true
        Me.rbVMR9.Checked = true
        Me.rbVMR9.Location = New System.Drawing.Point(12, 44)
        Me.rbVMR9.Name = "rbVMR9"
        Me.rbVMR9.Size = New System.Drawing.Size(182, 17)
        Me.rbVMR9.TabIndex = 1
        Me.rbVMR9.TabStop = true
        Me.rbVMR9.Text = "Video Mixing Renderer 9 (default)"
        Me.rbVMR9.UseVisualStyleBackColor = true
        '
        'rbVR
        '
        Me.rbVR.AutoSize = true
        Me.rbVR.Location = New System.Drawing.Point(12, 21)
        Me.rbVR.Name = "rbVR"
        Me.rbVR.Size = New System.Drawing.Size(147, 17)
        Me.rbVR.TabIndex = 0
        Me.rbVR.Text = "Video Renderer Filter (old)"
        Me.rbVR.UseVisualStyleBackColor = true
        '
        'TabPage23
        '
        Me.TabPage23.Controls.Add(Me.edBarcodeMetadata)
        Me.TabPage23.Controls.Add(Me.label91)
        Me.TabPage23.Controls.Add(Me.cbBarcodeType)
        Me.TabPage23.Controls.Add(Me.label90)
        Me.TabPage23.Controls.Add(Me.btBarcodeReset)
        Me.TabPage23.Controls.Add(Me.edBarcode)
        Me.TabPage23.Controls.Add(Me.label89)
        Me.TabPage23.Controls.Add(Me.cbBarcodeDetectionEnabled)
        Me.TabPage23.Location = New System.Drawing.Point(4, 22)
        Me.TabPage23.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage23.Name = "TabPage23"
        Me.TabPage23.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage23.Size = New System.Drawing.Size(302, 494)
        Me.TabPage23.TabIndex = 8
        Me.TabPage23.Text = "Barcode reader"
        Me.TabPage23.UseVisualStyleBackColor = true
        '
        'edBarcodeMetadata
        '
        Me.edBarcodeMetadata.Location = New System.Drawing.Point(12, 157)
        Me.edBarcodeMetadata.Margin = New System.Windows.Forms.Padding(2)
        Me.edBarcodeMetadata.Multiline = true
        Me.edBarcodeMetadata.Name = "edBarcodeMetadata"
        Me.edBarcodeMetadata.Size = New System.Drawing.Size(282, 96)
        Me.edBarcodeMetadata.TabIndex = 24
        '
        'label91
        '
        Me.label91.AutoSize = true
        Me.label91.Location = New System.Drawing.Point(10, 138)
        Me.label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label91.Name = "label91"
        Me.label91.Size = New System.Drawing.Size(52, 13)
        Me.label91.TabIndex = 23
        Me.label91.Text = "Metadata"
        '
        'cbBarcodeType
        '
        Me.cbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBarcodeType.FormattingEnabled = true
        Me.cbBarcodeType.Items.AddRange(New Object() {"Autodetect", "UPC-A", "UPC-E", "EAN-8", "EAN-13", "Code 39", "Code 93", "Code 128", "ITF", "CodaBar", "RSS-14", "Data matrix", "Aztec", "QR", "PDF-417"})
        Me.cbBarcodeType.Location = New System.Drawing.Point(12, 61)
        Me.cbBarcodeType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbBarcodeType.Name = "cbBarcodeType"
        Me.cbBarcodeType.Size = New System.Drawing.Size(160, 21)
        Me.cbBarcodeType.TabIndex = 22
        '
        'label90
        '
        Me.label90.AutoSize = true
        Me.label90.Location = New System.Drawing.Point(10, 45)
        Me.label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label90.Name = "label90"
        Me.label90.Size = New System.Drawing.Size(70, 13)
        Me.label90.TabIndex = 21
        Me.label90.Text = "Barcode type"
        '
        'btBarcodeReset
        '
        Me.btBarcodeReset.Location = New System.Drawing.Point(12, 265)
        Me.btBarcodeReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btBarcodeReset.Name = "btBarcodeReset"
        Me.btBarcodeReset.Size = New System.Drawing.Size(62, 23)
        Me.btBarcodeReset.TabIndex = 20
        Me.btBarcodeReset.Text = "Restart"
        Me.btBarcodeReset.UseVisualStyleBackColor = true
        '
        'edBarcode
        '
        Me.edBarcode.Location = New System.Drawing.Point(12, 109)
        Me.edBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.edBarcode.Name = "edBarcode"
        Me.edBarcode.Size = New System.Drawing.Size(282, 20)
        Me.edBarcode.TabIndex = 19
        '
        'label89
        '
        Me.label89.AutoSize = true
        Me.label89.Location = New System.Drawing.Point(10, 93)
        Me.label89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label89.Name = "label89"
        Me.label89.Size = New System.Drawing.Size(93, 13)
        Me.label89.TabIndex = 18
        Me.label89.Text = "Detected barcode"
        '
        'cbBarcodeDetectionEnabled
        '
        Me.cbBarcodeDetectionEnabled.AutoSize = true
        Me.cbBarcodeDetectionEnabled.Location = New System.Drawing.Point(12, 15)
        Me.cbBarcodeDetectionEnabled.Name = "cbBarcodeDetectionEnabled"
        Me.cbBarcodeDetectionEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbBarcodeDetectionEnabled.TabIndex = 17
        Me.cbBarcodeDetectionEnabled.Text = "Enabled"
        Me.cbBarcodeDetectionEnabled.UseVisualStyleBackColor = true
        '
        'TabPage24
        '
        Me.TabPage24.Controls.Add(Me.cbNetworkStreamingMode)
        Me.TabPage24.Controls.Add(Me.tabControl5)
        Me.TabPage24.Controls.Add(Me.cbNetworkStreamingAudioEnabled)
        Me.TabPage24.Controls.Add(Me.cbNetworkStreaming)
        Me.TabPage24.Location = New System.Drawing.Point(4, 22)
        Me.TabPage24.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage24.Name = "TabPage24"
        Me.TabPage24.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage24.Size = New System.Drawing.Size(302, 494)
        Me.TabPage24.TabIndex = 9
        Me.TabPage24.Text = "Network streaming"
        Me.TabPage24.UseVisualStyleBackColor = true
        '
        'cbNetworkStreamingMode
        '
        Me.cbNetworkStreamingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNetworkStreamingMode.FormattingEnabled = true
        Me.cbNetworkStreamingMode.Items.AddRange(New Object() {"Windows Media Video", "RTSP", "RTMP to Adobe Media Server / Wowza", "UDP", "Smooth Streaming to Microsoft IIS", "Output to external virtual devices"})
        Me.cbNetworkStreamingMode.Location = New System.Drawing.Point(14, 37)
        Me.cbNetworkStreamingMode.Name = "cbNetworkStreamingMode"
        Me.cbNetworkStreamingMode.Size = New System.Drawing.Size(276, 21)
        Me.cbNetworkStreamingMode.TabIndex = 33
        '
        'tabControl5
        '
        Me.tabControl5.Controls.Add(Me.TabPage25)
        Me.tabControl5.Controls.Add(Me.TabPage47)
        Me.tabControl5.Controls.Add(Me.TabPage48)
        Me.tabControl5.Controls.Add(Me.TabPage67)
        Me.tabControl5.Controls.Add(Me.TabPage49)
        Me.tabControl5.Controls.Add(Me.TabPage56)
        Me.tabControl5.Location = New System.Drawing.Point(2, 71)
        Me.tabControl5.Name = "tabControl5"
        Me.tabControl5.SelectedIndex = 0
        Me.tabControl5.Size = New System.Drawing.Size(292, 385)
        Me.tabControl5.TabIndex = 32
        '
        'TabPage25
        '
        Me.TabPage25.Controls.Add(Me.Label20)
        Me.TabPage25.Controls.Add(Me.edNetworkURL)
        Me.TabPage25.Controls.Add(Me.edWMVNetworkPort)
        Me.TabPage25.Controls.Add(Me.Label17)
        Me.TabPage25.Controls.Add(Me.btRefreshClients)
        Me.TabPage25.Controls.Add(Me.lbNetworkClients)
        Me.TabPage25.Controls.Add(Me.rbNetworkStreamingUseExternalProfile)
        Me.TabPage25.Controls.Add(Me.rbNetworkStreamingUseMainWMVSettings)
        Me.TabPage25.Controls.Add(Me.label81)
        Me.TabPage25.Controls.Add(Me.label80)
        Me.TabPage25.Controls.Add(Me.edMaximumClients)
        Me.TabPage25.Controls.Add(Me.Label18)
        Me.TabPage25.Controls.Add(Me.btSelectWMVProfileNetwork)
        Me.TabPage25.Controls.Add(Me.edNetworkStreamingWMVProfile)
        Me.TabPage25.Controls.Add(Me.Label19)
        Me.TabPage25.Location = New System.Drawing.Point(4, 22)
        Me.TabPage25.Name = "TabPage25"
        Me.TabPage25.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage25.Size = New System.Drawing.Size(284, 359)
        Me.TabPage25.TabIndex = 0
        Me.TabPage25.Text = "WMV"
        Me.TabPage25.UseVisualStyleBackColor = true
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.Location = New System.Drawing.Point(12, 307)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Connection URL"
        '
        'edNetworkURL
        '
        Me.edNetworkURL.Location = New System.Drawing.Point(15, 322)
        Me.edNetworkURL.Name = "edNetworkURL"
        Me.edNetworkURL.ReadOnly = true
        Me.edNetworkURL.Size = New System.Drawing.Size(255, 20)
        Me.edNetworkURL.TabIndex = 31
        '
        'edWMVNetworkPort
        '
        Me.edWMVNetworkPort.Location = New System.Drawing.Point(236, 120)
        Me.edWMVNetworkPort.Name = "edWMVNetworkPort"
        Me.edWMVNetworkPort.Size = New System.Drawing.Size(34, 20)
        Me.edWMVNetworkPort.TabIndex = 30
        Me.edWMVNetworkPort.Text = "100"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(162, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Network port"
        '
        'btRefreshClients
        '
        Me.btRefreshClients.Location = New System.Drawing.Point(206, 237)
        Me.btRefreshClients.Name = "btRefreshClients"
        Me.btRefreshClients.Size = New System.Drawing.Size(64, 23)
        Me.btRefreshClients.TabIndex = 28
        Me.btRefreshClients.Text = "Refresh"
        Me.btRefreshClients.UseVisualStyleBackColor = true
        '
        'lbNetworkClients
        '
        Me.lbNetworkClients.FormattingEnabled = true
        Me.lbNetworkClients.Location = New System.Drawing.Point(15, 175)
        Me.lbNetworkClients.Name = "lbNetworkClients"
        Me.lbNetworkClients.Size = New System.Drawing.Size(255, 56)
        Me.lbNetworkClients.TabIndex = 27
        '
        'rbNetworkStreamingUseExternalProfile
        '
        Me.rbNetworkStreamingUseExternalProfile.AutoSize = true
        Me.rbNetworkStreamingUseExternalProfile.Location = New System.Drawing.Point(15, 38)
        Me.rbNetworkStreamingUseExternalProfile.Name = "rbNetworkStreamingUseExternalProfile"
        Me.rbNetworkStreamingUseExternalProfile.Size = New System.Drawing.Size(115, 17)
        Me.rbNetworkStreamingUseExternalProfile.TabIndex = 26
        Me.rbNetworkStreamingUseExternalProfile.Text = "Use external profile"
        Me.rbNetworkStreamingUseExternalProfile.UseVisualStyleBackColor = true
        '
        'rbNetworkStreamingUseMainWMVSettings
        '
        Me.rbNetworkStreamingUseMainWMVSettings.AutoSize = true
        Me.rbNetworkStreamingUseMainWMVSettings.Checked = true
        Me.rbNetworkStreamingUseMainWMVSettings.Location = New System.Drawing.Point(15, 15)
        Me.rbNetworkStreamingUseMainWMVSettings.Name = "rbNetworkStreamingUseMainWMVSettings"
        Me.rbNetworkStreamingUseMainWMVSettings.Size = New System.Drawing.Size(193, 17)
        Me.rbNetworkStreamingUseMainWMVSettings.TabIndex = 25
        Me.rbNetworkStreamingUseMainWMVSettings.TabStop = true
        Me.rbNetworkStreamingUseMainWMVSettings.Text = "Use WMV settings from capture tab"
        Me.rbNetworkStreamingUseMainWMVSettings.UseVisualStyleBackColor = true
        '
        'label81
        '
        Me.label81.AutoSize = true
        Me.label81.Location = New System.Drawing.Point(13, 276)
        Me.label81.Name = "label81"
        Me.label81.Size = New System.Drawing.Size(230, 13)
        Me.label81.TabIndex = 24
        Me.label81.Text = "You can use Windows Media Player for testing."
        '
        'label80
        '
        Me.label80.AutoSize = true
        Me.label80.Location = New System.Drawing.Point(13, 159)
        Me.label80.Name = "label80"
        Me.label80.Size = New System.Drawing.Size(38, 13)
        Me.label80.TabIndex = 23
        Me.label80.Text = "Clients"
        '
        'edMaximumClients
        '
        Me.edMaximumClients.Location = New System.Drawing.Point(109, 120)
        Me.edMaximumClients.Name = "edMaximumClients"
        Me.edMaximumClients.Size = New System.Drawing.Size(34, 20)
        Me.edMaximumClients.TabIndex = 22
        Me.edMaximumClients.Text = "10"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(13, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Maximum clients"
        '
        'btSelectWMVProfileNetwork
        '
        Me.btSelectWMVProfileNetwork.Location = New System.Drawing.Point(246, 82)
        Me.btSelectWMVProfileNetwork.Name = "btSelectWMVProfileNetwork"
        Me.btSelectWMVProfileNetwork.Size = New System.Drawing.Size(24, 23)
        Me.btSelectWMVProfileNetwork.TabIndex = 20
        Me.btSelectWMVProfileNetwork.Text = "..."
        Me.btSelectWMVProfileNetwork.UseVisualStyleBackColor = true
        '
        'edNetworkStreamingWMVProfile
        '
        Me.edNetworkStreamingWMVProfile.Location = New System.Drawing.Point(37, 84)
        Me.edNetworkStreamingWMVProfile.Name = "edNetworkStreamingWMVProfile"
        Me.edNetworkStreamingWMVProfile.Size = New System.Drawing.Size(206, 20)
        Me.edNetworkStreamingWMVProfile.TabIndex = 19
        Me.edNetworkStreamingWMVProfile.Text = "c:\WM.prx"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(34, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "File name"
        '
        'TabPage47
        '
        Me.TabPage47.Controls.Add(Me.edNetworkRTSPURL)
        Me.TabPage47.Controls.Add(Me.label367)
        Me.TabPage47.Controls.Add(Me.label366)
        Me.TabPage47.Location = New System.Drawing.Point(4, 22)
        Me.TabPage47.Name = "TabPage47"
        Me.TabPage47.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage47.Size = New System.Drawing.Size(284, 359)
        Me.TabPage47.TabIndex = 2
        Me.TabPage47.Text = "RTSP"
        Me.TabPage47.UseVisualStyleBackColor = true
        '
        'edNetworkRTSPURL
        '
        Me.edNetworkRTSPURL.Location = New System.Drawing.Point(20, 37)
        Me.edNetworkRTSPURL.Name = "edNetworkRTSPURL"
        Me.edNetworkRTSPURL.Size = New System.Drawing.Size(247, 20)
        Me.edNetworkRTSPURL.TabIndex = 14
        Me.edNetworkRTSPURL.Text = "rtsp://localhost:5554/vfstream"
        '
        'label367
        '
        Me.label367.AutoSize = true
        Me.label367.Location = New System.Drawing.Point(17, 21)
        Me.label367.Name = "label367"
        Me.label367.Size = New System.Drawing.Size(29, 13)
        Me.label367.TabIndex = 13
        Me.label367.Text = "URL"
        '
        'label366
        '
        Me.label366.AutoSize = true
        Me.label366.Location = New System.Drawing.Point(17, 327)
        Me.label366.Name = "label366"
        Me.label366.Size = New System.Drawing.Size(159, 13)
        Me.label366.TabIndex = 12
        Me.label366.Text = "MP4 output settings will be used"
        '
        'TabPage48
        '
        Me.TabPage48.Controls.Add(Me.linkLabel11)
        Me.TabPage48.Controls.Add(Me.linkLabel3)
        Me.TabPage48.Controls.Add(Me.rbNetworkRTMPFFMPEGCustom)
        Me.TabPage48.Controls.Add(Me.rbNetworkRTMPFFMPEG)
        Me.TabPage48.Controls.Add(Me.edNetworkRTMPURL)
        Me.TabPage48.Controls.Add(Me.label368)
        Me.TabPage48.Controls.Add(Me.label369)
        Me.TabPage48.Location = New System.Drawing.Point(4, 22)
        Me.TabPage48.Name = "TabPage48"
        Me.TabPage48.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage48.Size = New System.Drawing.Size(284, 359)
        Me.TabPage48.TabIndex = 3
        Me.TabPage48.Text = "RTMP"
        Me.TabPage48.UseVisualStyleBackColor = true
        '
        'linkLabel11
        '
        Me.linkLabel11.AutoSize = true
        Me.linkLabel11.Location = New System.Drawing.Point(17, 111)
        Me.linkLabel11.Name = "linkLabel11"
        Me.linkLabel11.Size = New System.Drawing.Size(154, 13)
        Me.linkLabel11.TabIndex = 23
        Me.linkLabel11.TabStop = true
        Me.linkLabel11.Text = "Network streaming to YouTube"
        '
        'linkLabel3
        '
        Me.linkLabel3.AutoSize = true
        Me.linkLabel3.Location = New System.Drawing.Point(17, 89)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(207, 13)
        Me.linkLabel3.TabIndex = 22
        Me.linkLabel3.TabStop = true
        Me.linkLabel3.Text = "FFMPEG.exe redist required to be installed"
        '
        'rbNetworkRTMPFFMPEGCustom
        '
        Me.rbNetworkRTMPFFMPEGCustom.AutoSize = true
        Me.rbNetworkRTMPFFMPEGCustom.Location = New System.Drawing.Point(20, 42)
        Me.rbNetworkRTMPFFMPEGCustom.Name = "rbNetworkRTMPFFMPEGCustom"
        Me.rbNetworkRTMPFFMPEGCustom.Size = New System.Drawing.Size(197, 17)
        Me.rbNetworkRTMPFFMPEGCustom.TabIndex = 21
        Me.rbNetworkRTMPFFMPEGCustom.Text = "Custom settings using FFMPEG EXE"
        Me.rbNetworkRTMPFFMPEGCustom.UseVisualStyleBackColor = true
        '
        'rbNetworkRTMPFFMPEG
        '
        Me.rbNetworkRTMPFFMPEG.AutoSize = true
        Me.rbNetworkRTMPFFMPEG.Checked = true
        Me.rbNetworkRTMPFFMPEG.Location = New System.Drawing.Point(20, 19)
        Me.rbNetworkRTMPFFMPEG.Name = "rbNetworkRTMPFFMPEG"
        Me.rbNetworkRTMPFFMPEG.Size = New System.Drawing.Size(181, 17)
        Me.rbNetworkRTMPFFMPEG.TabIndex = 20
        Me.rbNetworkRTMPFFMPEG.TabStop = true
        Me.rbNetworkRTMPFFMPEG.Text = "H264 / AAC using FFMPEG EXE"
        Me.rbNetworkRTMPFFMPEG.UseVisualStyleBackColor = true
        '
        'edNetworkRTMPURL
        '
        Me.edNetworkRTMPURL.Location = New System.Drawing.Point(20, 293)
        Me.edNetworkRTMPURL.Name = "edNetworkRTMPURL"
        Me.edNetworkRTMPURL.Size = New System.Drawing.Size(247, 20)
        Me.edNetworkRTMPURL.TabIndex = 19
        Me.edNetworkRTMPURL.Text = "rtmp://localhost:5554/live/Stream"
        '
        'label368
        '
        Me.label368.AutoSize = true
        Me.label368.Location = New System.Drawing.Point(17, 277)
        Me.label368.Name = "label368"
        Me.label368.Size = New System.Drawing.Size(29, 13)
        Me.label368.TabIndex = 18
        Me.label368.Text = "URL"
        '
        'label369
        '
        Me.label369.AutoSize = true
        Me.label369.Location = New System.Drawing.Point(30, 327)
        Me.label369.Name = "label369"
        Me.label369.Size = New System.Drawing.Size(214, 13)
        Me.label369.TabIndex = 17
        Me.label369.Text = "Format settings located on output format tab"
        '
        'TabPage67
        '
        Me.TabPage67.Controls.Add(Me.LinkLabel2)
        Me.TabPage67.Controls.Add(Me.label484)
        Me.TabPage67.Controls.Add(Me.edNetworkUDPURL)
        Me.TabPage67.Controls.Add(Me.label372)
        Me.TabPage67.Controls.Add(Me.rbNetworkUDPFFMPEGCustom)
        Me.TabPage67.Controls.Add(Me.rbNetworkUDPFFMPEG)
        Me.TabPage67.Location = New System.Drawing.Point(4, 22)
        Me.TabPage67.Name = "TabPage67"
        Me.TabPage67.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage67.Size = New System.Drawing.Size(284, 359)
        Me.TabPage67.TabIndex = 5
        Me.TabPage67.Text = "UDP"
        Me.TabPage67.UseVisualStyleBackColor = true
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.Location = New System.Drawing.Point(17, 79)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(207, 13)
        Me.LinkLabel2.TabIndex = 22
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "FFMPEG.exe redist required to be installed"
        '
        'label484
        '
        Me.label484.AutoSize = true
        Me.label484.Location = New System.Drawing.Point(30, 328)
        Me.label484.Name = "label484"
        Me.label484.Size = New System.Drawing.Size(217, 13)
        Me.label484.TabIndex = 21
        Me.label484.Text = "Specify settings located on output format tab"
        '
        'edNetworkUDPURL
        '
        Me.edNetworkUDPURL.Location = New System.Drawing.Point(20, 295)
        Me.edNetworkUDPURL.Name = "edNetworkUDPURL"
        Me.edNetworkUDPURL.Size = New System.Drawing.Size(247, 20)
        Me.edNetworkUDPURL.TabIndex = 20
        Me.edNetworkUDPURL.Text = "udp://127.0.0.1:10000"
        '
        'label372
        '
        Me.label372.AutoSize = true
        Me.label372.Location = New System.Drawing.Point(17, 279)
        Me.label372.Name = "label372"
        Me.label372.Size = New System.Drawing.Size(29, 13)
        Me.label372.TabIndex = 19
        Me.label372.Text = "URL"
        '
        'rbNetworkUDPFFMPEGCustom
        '
        Me.rbNetworkUDPFFMPEGCustom.AutoSize = true
        Me.rbNetworkUDPFFMPEGCustom.Location = New System.Drawing.Point(20, 40)
        Me.rbNetworkUDPFFMPEGCustom.Name = "rbNetworkUDPFFMPEGCustom"
        Me.rbNetworkUDPFFMPEGCustom.Size = New System.Drawing.Size(197, 17)
        Me.rbNetworkUDPFFMPEGCustom.TabIndex = 18
        Me.rbNetworkUDPFFMPEGCustom.Text = "Custom settings using FFMPEG EXE"
        Me.rbNetworkUDPFFMPEGCustom.UseVisualStyleBackColor = true
        '
        'rbNetworkUDPFFMPEG
        '
        Me.rbNetworkUDPFFMPEG.AutoSize = true
        Me.rbNetworkUDPFFMPEG.Checked = true
        Me.rbNetworkUDPFFMPEG.Location = New System.Drawing.Point(20, 17)
        Me.rbNetworkUDPFFMPEG.Name = "rbNetworkUDPFFMPEG"
        Me.rbNetworkUDPFFMPEG.Size = New System.Drawing.Size(181, 17)
        Me.rbNetworkUDPFFMPEG.TabIndex = 17
        Me.rbNetworkUDPFFMPEG.TabStop = true
        Me.rbNetworkUDPFFMPEG.Text = "H264 / AAC using FFMPEG EXE"
        Me.rbNetworkUDPFFMPEG.UseVisualStyleBackColor = true
        '
        'TabPage49
        '
        Me.TabPage49.Controls.Add(Me.linkLabel10)
        Me.TabPage49.Controls.Add(Me.rbNetworkSSFFMPEGCustom)
        Me.TabPage49.Controls.Add(Me.rbNetworkSSFFMPEGDefault)
        Me.TabPage49.Controls.Add(Me.linkLabel5)
        Me.TabPage49.Controls.Add(Me.edNetworkSSURL)
        Me.TabPage49.Controls.Add(Me.label370)
        Me.TabPage49.Controls.Add(Me.label371)
        Me.TabPage49.Controls.Add(Me.rbNetworkSSSoftware)
        Me.TabPage49.Location = New System.Drawing.Point(4, 22)
        Me.TabPage49.Name = "TabPage49"
        Me.TabPage49.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage49.Size = New System.Drawing.Size(284, 359)
        Me.TabPage49.TabIndex = 4
        Me.TabPage49.Text = "IIS Smooth Streaming"
        Me.TabPage49.UseVisualStyleBackColor = true
        '
        'linkLabel10
        '
        Me.linkLabel10.AutoSize = true
        Me.linkLabel10.Location = New System.Drawing.Point(17, 220)
        Me.linkLabel10.Name = "linkLabel10"
        Me.linkLabel10.Size = New System.Drawing.Size(207, 13)
        Me.linkLabel10.TabIndex = 28
        Me.linkLabel10.TabStop = true
        Me.linkLabel10.Text = "FFMPEG.exe redist required to be installed"
        '
        'rbNetworkSSFFMPEGCustom
        '
        Me.rbNetworkSSFFMPEGCustom.AutoSize = true
        Me.rbNetworkSSFFMPEGCustom.Location = New System.Drawing.Point(20, 64)
        Me.rbNetworkSSFFMPEGCustom.Name = "rbNetworkSSFFMPEGCustom"
        Me.rbNetworkSSFFMPEGCustom.Size = New System.Drawing.Size(197, 17)
        Me.rbNetworkSSFFMPEGCustom.TabIndex = 27
        Me.rbNetworkSSFFMPEGCustom.Text = "Custom settings using FFMPEG EXE"
        Me.rbNetworkSSFFMPEGCustom.UseVisualStyleBackColor = true
        '
        'rbNetworkSSFFMPEGDefault
        '
        Me.rbNetworkSSFFMPEGDefault.AutoSize = true
        Me.rbNetworkSSFFMPEGDefault.Location = New System.Drawing.Point(20, 41)
        Me.rbNetworkSSFFMPEGDefault.Name = "rbNetworkSSFFMPEGDefault"
        Me.rbNetworkSSFFMPEGDefault.Size = New System.Drawing.Size(181, 17)
        Me.rbNetworkSSFFMPEGDefault.TabIndex = 26
        Me.rbNetworkSSFFMPEGDefault.Text = "H264 / AAC using FFMPEG EXE"
        Me.rbNetworkSSFFMPEGDefault.UseVisualStyleBackColor = true
        '
        'linkLabel5
        '
        Me.linkLabel5.AutoSize = true
        Me.linkLabel5.Location = New System.Drawing.Point(17, 198)
        Me.linkLabel5.Name = "linkLabel5"
        Me.linkLabel5.Size = New System.Drawing.Size(178, 13)
        Me.linkLabel5.TabIndex = 25
        Me.linkLabel5.TabStop = true
        Me.linkLabel5.Text = "IIS Smooth Streaming usage manual"
        '
        'edNetworkSSURL
        '
        Me.edNetworkSSURL.Location = New System.Drawing.Point(20, 153)
        Me.edNetworkSSURL.Name = "edNetworkSSURL"
        Me.edNetworkSSURL.Size = New System.Drawing.Size(247, 20)
        Me.edNetworkSSURL.TabIndex = 24
        Me.edNetworkSSURL.Text = "http://localhost/LiveStream.isml"
        '
        'label370
        '
        Me.label370.AutoSize = true
        Me.label370.Location = New System.Drawing.Point(17, 137)
        Me.label370.Name = "label370"
        Me.label370.Size = New System.Drawing.Size(106, 13)
        Me.label370.TabIndex = 23
        Me.label370.Text = "Publishing point URL"
        '
        'label371
        '
        Me.label371.AutoSize = true
        Me.label371.Location = New System.Drawing.Point(17, 327)
        Me.label371.Name = "label371"
        Me.label371.Size = New System.Drawing.Size(214, 13)
        Me.label371.TabIndex = 22
        Me.label371.Text = "Format settings located on output format tab"
        '
        'rbNetworkSSSoftware
        '
        Me.rbNetworkSSSoftware.AutoSize = true
        Me.rbNetworkSSSoftware.Checked = true
        Me.rbNetworkSSSoftware.Location = New System.Drawing.Point(20, 18)
        Me.rbNetworkSSSoftware.Name = "rbNetworkSSSoftware"
        Me.rbNetworkSSSoftware.Size = New System.Drawing.Size(244, 17)
        Me.rbNetworkSSSoftware.TabIndex = 20
        Me.rbNetworkSSSoftware.TabStop = true
        Me.rbNetworkSSSoftware.Text = "H264 / AAC using software encoder / NVENC"
        Me.rbNetworkSSSoftware.UseVisualStyleBackColor = true
        '
        'TabPage56
        '
        Me.TabPage56.Controls.Add(Me.LinkLabel4)
        Me.TabPage56.Location = New System.Drawing.Point(4, 22)
        Me.TabPage56.Name = "TabPage56"
        Me.TabPage56.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage56.Size = New System.Drawing.Size(284, 359)
        Me.TabPage56.TabIndex = 1
        Me.TabPage56.Text = "External"
        Me.TabPage56.UseVisualStyleBackColor = true
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = true
        Me.LinkLabel4.Location = New System.Drawing.Point(27, 25)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(194, 13)
        Me.LinkLabel4.TabIndex = 1
        Me.LinkLabel4.TabStop = true
        Me.LinkLabel4.Text = "Streaming to Adobe Flash Media Server"
        '
        'cbNetworkStreamingAudioEnabled
        '
        Me.cbNetworkStreamingAudioEnabled.AutoSize = true
        Me.cbNetworkStreamingAudioEnabled.Location = New System.Drawing.Point(14, 462)
        Me.cbNetworkStreamingAudioEnabled.Name = "cbNetworkStreamingAudioEnabled"
        Me.cbNetworkStreamingAudioEnabled.Size = New System.Drawing.Size(88, 17)
        Me.cbNetworkStreamingAudioEnabled.TabIndex = 31
        Me.cbNetworkStreamingAudioEnabled.Text = "Stream audio"
        Me.cbNetworkStreamingAudioEnabled.UseVisualStyleBackColor = true
        '
        'cbNetworkStreaming
        '
        Me.cbNetworkStreaming.AutoSize = true
        Me.cbNetworkStreaming.Location = New System.Drawing.Point(14, 14)
        Me.cbNetworkStreaming.Name = "cbNetworkStreaming"
        Me.cbNetworkStreaming.Size = New System.Drawing.Size(155, 17)
        Me.cbNetworkStreaming.TabIndex = 28
        Me.cbNetworkStreaming.Text = "Network streaming enabled"
        Me.cbNetworkStreaming.UseVisualStyleBackColor = true
        '
        'TabPage32
        '
        Me.TabPage32.Controls.Add(Me.label328)
        Me.TabPage32.Controls.Add(Me.label327)
        Me.TabPage32.Controls.Add(Me.label326)
        Me.TabPage32.Controls.Add(Me.label325)
        Me.TabPage32.Controls.Add(Me.cbVirtualCamera)
        Me.TabPage32.Location = New System.Drawing.Point(4, 22)
        Me.TabPage32.Name = "TabPage32"
        Me.TabPage32.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage32.Size = New System.Drawing.Size(302, 494)
        Me.TabPage32.TabIndex = 10
        Me.TabPage32.Text = "Virtual camera"
        Me.TabPage32.UseVisualStyleBackColor = true
        '
        'label328
        '
        Me.label328.AutoSize = true
        Me.label328.Location = New System.Drawing.Point(17, 131)
        Me.label328.Name = "label328"
        Me.label328.Size = New System.Drawing.Size(197, 13)
        Me.label328.TabIndex = 7
        Me.label328.Text = "TRIAL limitation - 5000 frames to stream."
        '
        'label327
        '
        Me.label327.AutoSize = true
        Me.label327.Location = New System.Drawing.Point(17, 109)
        Me.label327.Name = "label327"
        Me.label327.Size = New System.Drawing.Size(180, 13)
        Me.label327.TabIndex = 6
        Me.label327.Text = "Virtual Camera SDK license required."
        '
        'label326
        '
        Me.label326.AutoSize = true
        Me.label326.Location = New System.Drawing.Point(17, 73)
        Me.label326.Name = "label326"
        Me.label326.Size = New System.Drawing.Size(111, 13)
        Me.label326.TabIndex = 5
        Me.label326.Text = "to see streamed video"
        '
        'label325
        '
        Me.label325.AutoSize = true
        Me.label325.Location = New System.Drawing.Point(17, 53)
        Me.label325.Name = "label325"
        Me.label325.Size = New System.Drawing.Size(243, 13)
        Me.label325.TabIndex = 4
        Me.label325.Text = "You are can use VisioForge Virtual Camera device"
        '
        'cbVirtualCamera
        '
        Me.cbVirtualCamera.AutoSize = true
        Me.cbVirtualCamera.Location = New System.Drawing.Point(20, 19)
        Me.cbVirtualCamera.Name = "cbVirtualCamera"
        Me.cbVirtualCamera.Size = New System.Drawing.Size(107, 17)
        Me.cbVirtualCamera.TabIndex = 3
        Me.cbVirtualCamera.Text = "Enable streaming"
        Me.cbVirtualCamera.UseVisualStyleBackColor = true
        '
        'TabPage34
        '
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputDownConversionAnalogOutput)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputDownConversion)
        Me.TabPage34.Controls.Add(Me.label337)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputHDTVPulldown)
        Me.TabPage34.Controls.Add(Me.label336)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputBlackToDeck)
        Me.TabPage34.Controls.Add(Me.label335)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputSingleField)
        Me.TabPage34.Controls.Add(Me.label334)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputComponentLevels)
        Me.TabPage34.Controls.Add(Me.label333)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputNTSC)
        Me.TabPage34.Controls.Add(Me.label332)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputDualLink)
        Me.TabPage34.Controls.Add(Me.label331)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutputAnalog)
        Me.TabPage34.Controls.Add(Me.label87)
        Me.TabPage34.Controls.Add(Me.cbDecklinkDV)
        Me.TabPage34.Controls.Add(Me.cbDecklinkOutput)
        Me.TabPage34.Location = New System.Drawing.Point(4, 22)
        Me.TabPage34.Name = "TabPage34"
        Me.TabPage34.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage34.Size = New System.Drawing.Size(302, 494)
        Me.TabPage34.TabIndex = 11
        Me.TabPage34.Text = "Decklink output"
        Me.TabPage34.UseVisualStyleBackColor = true
        '
        'cbDecklinkOutputDownConversionAnalogOutput
        '
        Me.cbDecklinkOutputDownConversionAnalogOutput.AutoSize = true
        Me.cbDecklinkOutputDownConversionAnalogOutput.Location = New System.Drawing.Point(26, 247)
        Me.cbDecklinkOutputDownConversionAnalogOutput.Name = "cbDecklinkOutputDownConversionAnalogOutput"
        Me.cbDecklinkOutputDownConversionAnalogOutput.Size = New System.Drawing.Size(118, 17)
        Me.cbDecklinkOutputDownConversionAnalogOutput.TabIndex = 52
        Me.cbDecklinkOutputDownConversionAnalogOutput.Text = "Analog output used"
        Me.cbDecklinkOutputDownConversionAnalogOutput.UseVisualStyleBackColor = true
        '
        'cbDecklinkOutputDownConversion
        '
        Me.cbDecklinkOutputDownConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputDownConversion.FormattingEnabled = true
        Me.cbDecklinkOutputDownConversion.Items.AddRange(New Object() {"Default", "Disabled", "Letterbox 16:9", "Anamorphic", "Anamorphic center"})
        Me.cbDecklinkOutputDownConversion.Location = New System.Drawing.Point(26, 223)
        Me.cbDecklinkOutputDownConversion.Name = "cbDecklinkOutputDownConversion"
        Me.cbDecklinkOutputDownConversion.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputDownConversion.TabIndex = 51
        '
        'label337
        '
        Me.label337.AutoSize = true
        Me.label337.Location = New System.Drawing.Point(23, 207)
        Me.label337.Name = "label337"
        Me.label337.Size = New System.Drawing.Size(119, 13)
        Me.label337.TabIndex = 50
        Me.label337.Text = "Down conversion mode"
        '
        'cbDecklinkOutputHDTVPulldown
        '
        Me.cbDecklinkOutputHDTVPulldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputHDTVPulldown.FormattingEnabled = true
        Me.cbDecklinkOutputHDTVPulldown.Items.AddRange(New Object() {"Default", "Enabled", "Disabled"})
        Me.cbDecklinkOutputHDTVPulldown.Location = New System.Drawing.Point(26, 294)
        Me.cbDecklinkOutputHDTVPulldown.Name = "cbDecklinkOutputHDTVPulldown"
        Me.cbDecklinkOutputHDTVPulldown.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputHDTVPulldown.TabIndex = 49
        '
        'label336
        '
        Me.label336.AutoSize = true
        Me.label336.Location = New System.Drawing.Point(23, 278)
        Me.label336.Name = "label336"
        Me.label336.Size = New System.Drawing.Size(82, 13)
        Me.label336.TabIndex = 48
        Me.label336.Text = "HDTV pulldown"
        '
        'cbDecklinkOutputBlackToDeck
        '
        Me.cbDecklinkOutputBlackToDeck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputBlackToDeck.FormattingEnabled = true
        Me.cbDecklinkOutputBlackToDeck.Items.AddRange(New Object() {"Default", "None", "Digital", "Analogue"})
        Me.cbDecklinkOutputBlackToDeck.Location = New System.Drawing.Point(26, 176)
        Me.cbDecklinkOutputBlackToDeck.Name = "cbDecklinkOutputBlackToDeck"
        Me.cbDecklinkOutputBlackToDeck.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputBlackToDeck.TabIndex = 47
        '
        'label335
        '
        Me.label335.AutoSize = true
        Me.label335.Location = New System.Drawing.Point(23, 160)
        Me.label335.Name = "label335"
        Me.label335.Size = New System.Drawing.Size(73, 13)
        Me.label335.TabIndex = 46
        Me.label335.Text = "Black to deck"
        '
        'cbDecklinkOutputSingleField
        '
        Me.cbDecklinkOutputSingleField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputSingleField.FormattingEnabled = true
        Me.cbDecklinkOutputSingleField.Items.AddRange(New Object() {"Default", "Enabled", "Disabled"})
        Me.cbDecklinkOutputSingleField.Location = New System.Drawing.Point(26, 131)
        Me.cbDecklinkOutputSingleField.Name = "cbDecklinkOutputSingleField"
        Me.cbDecklinkOutputSingleField.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputSingleField.TabIndex = 45
        '
        'label334
        '
        Me.label334.AutoSize = true
        Me.label334.Location = New System.Drawing.Point(23, 115)
        Me.label334.Name = "label334"
        Me.label334.Size = New System.Drawing.Size(91, 13)
        Me.label334.TabIndex = 44
        Me.label334.Text = "Single field output"
        '
        'cbDecklinkOutputComponentLevels
        '
        Me.cbDecklinkOutputComponentLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputComponentLevels.FormattingEnabled = true
        Me.cbDecklinkOutputComponentLevels.Items.AddRange(New Object() {"SMPTE", "Betacam"})
        Me.cbDecklinkOutputComponentLevels.Location = New System.Drawing.Point(162, 176)
        Me.cbDecklinkOutputComponentLevels.Name = "cbDecklinkOutputComponentLevels"
        Me.cbDecklinkOutputComponentLevels.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputComponentLevels.TabIndex = 43
        '
        'label333
        '
        Me.label333.AutoSize = true
        Me.label333.Location = New System.Drawing.Point(159, 160)
        Me.label333.Name = "label333"
        Me.label333.Size = New System.Drawing.Size(91, 13)
        Me.label333.TabIndex = 42
        Me.label333.Text = "Component levels"
        '
        'cbDecklinkOutputNTSC
        '
        Me.cbDecklinkOutputNTSC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputNTSC.FormattingEnabled = true
        Me.cbDecklinkOutputNTSC.Items.AddRange(New Object() {"USA", "Japan"})
        Me.cbDecklinkOutputNTSC.Location = New System.Drawing.Point(162, 131)
        Me.cbDecklinkOutputNTSC.Name = "cbDecklinkOutputNTSC"
        Me.cbDecklinkOutputNTSC.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputNTSC.TabIndex = 41
        '
        'label332
        '
        Me.label332.AutoSize = true
        Me.label332.Location = New System.Drawing.Point(159, 115)
        Me.label332.Name = "label332"
        Me.label332.Size = New System.Drawing.Size(80, 13)
        Me.label332.TabIndex = 40
        Me.label332.Text = "NTSC standard"
        '
        'cbDecklinkOutputDualLink
        '
        Me.cbDecklinkOutputDualLink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputDualLink.FormattingEnabled = true
        Me.cbDecklinkOutputDualLink.Items.AddRange(New Object() {"Default", "Enabled", "Disabled"})
        Me.cbDecklinkOutputDualLink.Location = New System.Drawing.Point(26, 86)
        Me.cbDecklinkOutputDualLink.Name = "cbDecklinkOutputDualLink"
        Me.cbDecklinkOutputDualLink.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputDualLink.TabIndex = 39
        '
        'label331
        '
        Me.label331.AutoSize = true
        Me.label331.Location = New System.Drawing.Point(23, 70)
        Me.label331.Name = "label331"
        Me.label331.Size = New System.Drawing.Size(77, 13)
        Me.label331.TabIndex = 38
        Me.label331.Text = "Dual link mode"
        '
        'cbDecklinkOutputAnalog
        '
        Me.cbDecklinkOutputAnalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDecklinkOutputAnalog.FormattingEnabled = true
        Me.cbDecklinkOutputAnalog.Items.AddRange(New Object() {"Auto", "Component", "Composite", "S-Video"})
        Me.cbDecklinkOutputAnalog.Location = New System.Drawing.Point(162, 86)
        Me.cbDecklinkOutputAnalog.Name = "cbDecklinkOutputAnalog"
        Me.cbDecklinkOutputAnalog.Size = New System.Drawing.Size(121, 21)
        Me.cbDecklinkOutputAnalog.TabIndex = 37
        '
        'label87
        '
        Me.label87.AutoSize = true
        Me.label87.Location = New System.Drawing.Point(159, 70)
        Me.label87.Name = "label87"
        Me.label87.Size = New System.Drawing.Size(73, 13)
        Me.label87.TabIndex = 36
        Me.label87.Text = "Analog output"
        '
        'cbDecklinkDV
        '
        Me.cbDecklinkDV.AutoSize = true
        Me.cbDecklinkDV.Location = New System.Drawing.Point(35, 40)
        Me.cbDecklinkDV.Name = "cbDecklinkDV"
        Me.cbDecklinkDV.Size = New System.Drawing.Size(74, 17)
        Me.cbDecklinkDV.TabIndex = 3
        Me.cbDecklinkDV.Text = "DV output"
        Me.cbDecklinkDV.UseVisualStyleBackColor = true
        '
        'cbDecklinkOutput
        '
        Me.cbDecklinkOutput.AutoSize = true
        Me.cbDecklinkOutput.Location = New System.Drawing.Point(17, 17)
        Me.cbDecklinkOutput.Name = "cbDecklinkOutput"
        Me.cbDecklinkOutput.Size = New System.Drawing.Size(173, 17)
        Me.cbDecklinkOutput.TabIndex = 2
        Me.cbDecklinkOutput.Text = "Enable output to Decklink card"
        Me.cbDecklinkOutput.UseVisualStyleBackColor = true
        '
        'TabPage43
        '
        Me.TabPage43.Controls.Add(Me.groupBox48)
        Me.TabPage43.Controls.Add(Me.groupBox47)
        Me.TabPage43.Controls.Add(Me.groupBox43)
        Me.TabPage43.Location = New System.Drawing.Point(4, 22)
        Me.TabPage43.Name = "TabPage43"
        Me.TabPage43.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage43.Size = New System.Drawing.Size(302, 494)
        Me.TabPage43.TabIndex = 12
        Me.TabPage43.Text = "Encryption"
        Me.TabPage43.UseVisualStyleBackColor = true
        '
        'groupBox48
        '
        Me.groupBox48.Controls.Add(Me.label343)
        Me.groupBox48.Controls.Add(Me.edEncryptionKeyHEX)
        Me.groupBox48.Controls.Add(Me.rbEncryptionKeyBinary)
        Me.groupBox48.Controls.Add(Me.btEncryptionOpenFile)
        Me.groupBox48.Controls.Add(Me.edEncryptionKeyFile)
        Me.groupBox48.Controls.Add(Me.rbEncryptionKeyFile)
        Me.groupBox48.Controls.Add(Me.edEncryptionKeyString)
        Me.groupBox48.Controls.Add(Me.rbEncryptionKeyString)
        Me.groupBox48.Location = New System.Drawing.Point(16, 193)
        Me.groupBox48.Name = "groupBox48"
        Me.groupBox48.Size = New System.Drawing.Size(269, 224)
        Me.groupBox48.TabIndex = 14
        Me.groupBox48.TabStop = false
        Me.groupBox48.Text = "Encryption key type"
        '
        'label343
        '
        Me.label343.AutoSize = true
        Me.label343.Location = New System.Drawing.Point(33, 199)
        Me.label343.Name = "label343"
        Me.label343.Size = New System.Drawing.Size(157, 13)
        Me.label343.TabIndex = 10
        Me.label343.Text = "You can assign byte[] using API"
        '
        'edEncryptionKeyHEX
        '
        Me.edEncryptionKeyHEX.Location = New System.Drawing.Point(36, 176)
        Me.edEncryptionKeyHEX.Name = "edEncryptionKeyHEX"
        Me.edEncryptionKeyHEX.Size = New System.Drawing.Size(214, 20)
        Me.edEncryptionKeyHEX.TabIndex = 9
        Me.edEncryptionKeyHEX.Text = "enter hex data"
        '
        'rbEncryptionKeyBinary
        '
        Me.rbEncryptionKeyBinary.AutoSize = true
        Me.rbEncryptionKeyBinary.Location = New System.Drawing.Point(14, 153)
        Me.rbEncryptionKeyBinary.Name = "rbEncryptionKeyBinary"
        Me.rbEncryptionKeyBinary.Size = New System.Drawing.Size(124, 17)
        Me.rbEncryptionKeyBinary.TabIndex = 8
        Me.rbEncryptionKeyBinary.Text = "Binary data (v9 SDK)"
        Me.rbEncryptionKeyBinary.UseVisualStyleBackColor = true
        '
        'btEncryptionOpenFile
        '
        Me.btEncryptionOpenFile.Location = New System.Drawing.Point(227, 114)
        Me.btEncryptionOpenFile.Name = "btEncryptionOpenFile"
        Me.btEncryptionOpenFile.Size = New System.Drawing.Size(23, 23)
        Me.btEncryptionOpenFile.TabIndex = 7
        Me.btEncryptionOpenFile.Text = "..."
        Me.btEncryptionOpenFile.UseVisualStyleBackColor = true
        '
        'edEncryptionKeyFile
        '
        Me.edEncryptionKeyFile.Location = New System.Drawing.Point(36, 116)
        Me.edEncryptionKeyFile.Name = "edEncryptionKeyFile"
        Me.edEncryptionKeyFile.Size = New System.Drawing.Size(185, 20)
        Me.edEncryptionKeyFile.TabIndex = 6
        Me.edEncryptionKeyFile.Text = "c:\keyfile.txt"
        '
        'rbEncryptionKeyFile
        '
        Me.rbEncryptionKeyFile.AutoSize = true
        Me.rbEncryptionKeyFile.Location = New System.Drawing.Point(14, 93)
        Me.rbEncryptionKeyFile.Name = "rbEncryptionKeyFile"
        Me.rbEncryptionKeyFile.Size = New System.Drawing.Size(87, 17)
        Me.rbEncryptionKeyFile.TabIndex = 5
        Me.rbEncryptionKeyFile.Text = "File (v9 SDK)"
        Me.rbEncryptionKeyFile.UseVisualStyleBackColor = true
        '
        'edEncryptionKeyString
        '
        Me.edEncryptionKeyString.Location = New System.Drawing.Point(36, 56)
        Me.edEncryptionKeyString.Name = "edEncryptionKeyString"
        Me.edEncryptionKeyString.Size = New System.Drawing.Size(214, 20)
        Me.edEncryptionKeyString.TabIndex = 4
        Me.edEncryptionKeyString.Text = "100"
        '
        'rbEncryptionKeyString
        '
        Me.rbEncryptionKeyString.AutoSize = true
        Me.rbEncryptionKeyString.Checked = true
        Me.rbEncryptionKeyString.Location = New System.Drawing.Point(14, 28)
        Me.rbEncryptionKeyString.Name = "rbEncryptionKeyString"
        Me.rbEncryptionKeyString.Size = New System.Drawing.Size(52, 17)
        Me.rbEncryptionKeyString.TabIndex = 0
        Me.rbEncryptionKeyString.TabStop = true
        Me.rbEncryptionKeyString.Text = "String"
        Me.rbEncryptionKeyString.UseVisualStyleBackColor = true
        '
        'groupBox47
        '
        Me.groupBox47.Controls.Add(Me.rbEncryptionModeAES256)
        Me.groupBox47.Controls.Add(Me.rbEncryptionModeAES128)
        Me.groupBox47.Location = New System.Drawing.Point(16, 15)
        Me.groupBox47.Name = "groupBox47"
        Me.groupBox47.Size = New System.Drawing.Size(269, 83)
        Me.groupBox47.TabIndex = 13
        Me.groupBox47.TabStop = false
        Me.groupBox47.Text = "Method"
        '
        'rbEncryptionModeAES256
        '
        Me.rbEncryptionModeAES256.AutoSize = true
        Me.rbEncryptionModeAES256.Checked = true
        Me.rbEncryptionModeAES256.Location = New System.Drawing.Point(14, 51)
        Me.rbEncryptionModeAES256.Name = "rbEncryptionModeAES256"
        Me.rbEncryptionModeAES256.Size = New System.Drawing.Size(198, 17)
        Me.rbEncryptionModeAES256.TabIndex = 1
        Me.rbEncryptionModeAES256.TabStop = true
        Me.rbEncryptionModeAES256.Text = "AES-256 (v9 encryption SDK output)"
        Me.rbEncryptionModeAES256.UseVisualStyleBackColor = true
        '
        'rbEncryptionModeAES128
        '
        Me.rbEncryptionModeAES128.AutoSize = true
        Me.rbEncryptionModeAES128.Location = New System.Drawing.Point(14, 28)
        Me.rbEncryptionModeAES128.Name = "rbEncryptionModeAES128"
        Me.rbEncryptionModeAES128.Size = New System.Drawing.Size(198, 17)
        Me.rbEncryptionModeAES128.TabIndex = 0
        Me.rbEncryptionModeAES128.Text = "AES-128 (v8 encryption SDK output)"
        Me.rbEncryptionModeAES128.UseVisualStyleBackColor = true
        '
        'groupBox43
        '
        Me.groupBox43.Controls.Add(Me.rbEncryptedH264CUDA)
        Me.groupBox43.Controls.Add(Me.rbEncryptedH264SW)
        Me.groupBox43.Location = New System.Drawing.Point(16, 104)
        Me.groupBox43.Name = "groupBox43"
        Me.groupBox43.Size = New System.Drawing.Size(269, 83)
        Me.groupBox43.TabIndex = 12
        Me.groupBox43.TabStop = false
        Me.groupBox43.Text = "Video / audio format"
        '
        'rbEncryptedH264CUDA
        '
        Me.rbEncryptedH264CUDA.AutoSize = true
        Me.rbEncryptedH264CUDA.Location = New System.Drawing.Point(14, 51)
        Me.rbEncryptedH264CUDA.Name = "rbEncryptedH264CUDA"
        Me.rbEncryptedH264CUDA.Size = New System.Drawing.Size(228, 17)
        Me.rbEncryptedH264CUDA.TabIndex = 7
        Me.rbEncryptedH264CUDA.Text = "Use MP4 H264 CUDA / AAC output format"
        Me.rbEncryptedH264CUDA.UseVisualStyleBackColor = true
        '
        'rbEncryptedH264SW
        '
        Me.rbEncryptedH264SW.AutoSize = true
        Me.rbEncryptedH264SW.Checked = true
        Me.rbEncryptedH264SW.Location = New System.Drawing.Point(14, 28)
        Me.rbEncryptedH264SW.Name = "rbEncryptedH264SW"
        Me.rbEncryptedH264SW.Size = New System.Drawing.Size(195, 17)
        Me.rbEncryptedH264SW.TabIndex = 6
        Me.rbEncryptedH264SW.TabStop = true
        Me.rbEncryptedH264SW.Text = "Use MP4 H264 / ACC output format"
        Me.rbEncryptedH264SW.UseVisualStyleBackColor = true
        '
        'TabPage78
        '
        Me.TabPage78.Controls.Add(Me.TabControl32)
        Me.TabPage78.Controls.Add(Me.cbTagEnabled)
        Me.TabPage78.Location = New System.Drawing.Point(4, 22)
        Me.TabPage78.Name = "TabPage78"
        Me.TabPage78.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage78.Size = New System.Drawing.Size(302, 494)
        Me.TabPage78.TabIndex = 14
        Me.TabPage78.Text = "Tags"
        Me.TabPage78.UseVisualStyleBackColor = true
        '
        'TabControl32
        '
        Me.TabControl32.Controls.Add(Me.TabPage142)
        Me.TabControl32.Controls.Add(Me.TabPage143)
        Me.TabControl32.Location = New System.Drawing.Point(5, 46)
        Me.TabControl32.Name = "TabControl32"
        Me.TabControl32.SelectedIndex = 0
        Me.TabControl32.Size = New System.Drawing.Size(292, 432)
        Me.TabControl32.TabIndex = 3
        '
        'TabPage142
        '
        Me.TabPage142.Controls.Add(Me.edTagTrackID)
        Me.TabPage142.Controls.Add(Me.Label496)
        Me.TabPage142.Controls.Add(Me.edTagYear)
        Me.TabPage142.Controls.Add(Me.Label495)
        Me.TabPage142.Controls.Add(Me.edTagComment)
        Me.TabPage142.Controls.Add(Me.Label493)
        Me.TabPage142.Controls.Add(Me.edTagAlbum)
        Me.TabPage142.Controls.Add(Me.Label491)
        Me.TabPage142.Controls.Add(Me.edTagArtists)
        Me.TabPage142.Controls.Add(Me.Label490)
        Me.TabPage142.Controls.Add(Me.edTagCopyright)
        Me.TabPage142.Controls.Add(Me.Label22)
        Me.TabPage142.Controls.Add(Me.edTagTitle)
        Me.TabPage142.Controls.Add(Me.Label23)
        Me.TabPage142.Location = New System.Drawing.Point(4, 22)
        Me.TabPage142.Name = "TabPage142"
        Me.TabPage142.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage142.Size = New System.Drawing.Size(284, 406)
        Me.TabPage142.TabIndex = 0
        Me.TabPage142.Text = "Common"
        Me.TabPage142.UseVisualStyleBackColor = true
        '
        'edTagTrackID
        '
        Me.edTagTrackID.Location = New System.Drawing.Point(16, 207)
        Me.edTagTrackID.Name = "edTagTrackID"
        Me.edTagTrackID.Size = New System.Drawing.Size(63, 20)
        Me.edTagTrackID.TabIndex = 13
        Me.edTagTrackID.Text = "1"
        '
        'Label496
        '
        Me.Label496.AutoSize = true
        Me.Label496.Location = New System.Drawing.Point(13, 192)
        Me.Label496.Name = "Label496"
        Me.Label496.Size = New System.Drawing.Size(49, 13)
        Me.Label496.TabIndex = 12
        Me.Label496.Text = "Track ID"
        '
        'edTagYear
        '
        Me.edTagYear.Location = New System.Drawing.Point(16, 301)
        Me.edTagYear.Name = "edTagYear"
        Me.edTagYear.Size = New System.Drawing.Size(63, 20)
        Me.edTagYear.TabIndex = 11
        Me.edTagYear.Text = "2015"
        '
        'Label495
        '
        Me.Label495.AutoSize = true
        Me.Label495.Location = New System.Drawing.Point(13, 286)
        Me.Label495.Name = "Label495"
        Me.Label495.Size = New System.Drawing.Size(29, 13)
        Me.Label495.TabIndex = 10
        Me.Label495.Text = "Year"
        '
        'edTagComment
        '
        Me.edTagComment.Location = New System.Drawing.Point(16, 160)
        Me.edTagComment.Name = "edTagComment"
        Me.edTagComment.Size = New System.Drawing.Size(242, 20)
        Me.edTagComment.TabIndex = 9
        Me.edTagComment.Text = "No comments"
        '
        'Label493
        '
        Me.Label493.AutoSize = true
        Me.Label493.Location = New System.Drawing.Point(13, 145)
        Me.Label493.Name = "Label493"
        Me.Label493.Size = New System.Drawing.Size(51, 13)
        Me.Label493.TabIndex = 8
        Me.Label493.Text = "Comment"
        '
        'edTagAlbum
        '
        Me.edTagAlbum.Location = New System.Drawing.Point(16, 116)
        Me.edTagAlbum.Name = "edTagAlbum"
        Me.edTagAlbum.Size = New System.Drawing.Size(242, 20)
        Me.edTagAlbum.TabIndex = 7
        Me.edTagAlbum.Text = "Sample album"
        '
        'Label491
        '
        Me.Label491.AutoSize = true
        Me.Label491.Location = New System.Drawing.Point(13, 101)
        Me.Label491.Name = "Label491"
        Me.Label491.Size = New System.Drawing.Size(36, 13)
        Me.Label491.TabIndex = 6
        Me.Label491.Text = "Album"
        '
        'edTagArtists
        '
        Me.edTagArtists.Location = New System.Drawing.Point(16, 72)
        Me.edTagArtists.Name = "edTagArtists"
        Me.edTagArtists.Size = New System.Drawing.Size(242, 20)
        Me.edTagArtists.TabIndex = 5
        Me.edTagArtists.Text = "Sample artist"
        '
        'Label490
        '
        Me.Label490.AutoSize = true
        Me.Label490.Location = New System.Drawing.Point(13, 57)
        Me.Label490.Name = "Label490"
        Me.Label490.Size = New System.Drawing.Size(35, 13)
        Me.Label490.TabIndex = 4
        Me.Label490.Text = "Artists"
        '
        'edTagCopyright
        '
        Me.edTagCopyright.Location = New System.Drawing.Point(16, 255)
        Me.edTagCopyright.Name = "edTagCopyright"
        Me.edTagCopyright.Size = New System.Drawing.Size(242, 20)
        Me.edTagCopyright.TabIndex = 3
        Me.edTagCopyright.Text = "VisioForge"
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(13, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Copyright"
        '
        'edTagTitle
        '
        Me.edTagTitle.Location = New System.Drawing.Point(16, 29)
        Me.edTagTitle.Name = "edTagTitle"
        Me.edTagTitle.Size = New System.Drawing.Size(242, 20)
        Me.edTagTitle.TabIndex = 1
        Me.edTagTitle.Text = "Sample output file"
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Location = New System.Drawing.Point(13, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Title"
        '
        'TabPage143
        '
        Me.TabPage143.Controls.Add(Me.imgTagCover)
        Me.TabPage143.Controls.Add(Me.Label499)
        Me.TabPage143.Controls.Add(Me.Label498)
        Me.TabPage143.Controls.Add(Me.edTagLyrics)
        Me.TabPage143.Controls.Add(Me.Label497)
        Me.TabPage143.Controls.Add(Me.cbTagGenre)
        Me.TabPage143.Controls.Add(Me.Label494)
        Me.TabPage143.Controls.Add(Me.edTagComposers)
        Me.TabPage143.Controls.Add(Me.Label492)
        Me.TabPage143.Location = New System.Drawing.Point(4, 22)
        Me.TabPage143.Name = "TabPage143"
        Me.TabPage143.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage143.Size = New System.Drawing.Size(284, 406)
        Me.TabPage143.TabIndex = 1
        Me.TabPage143.Text = "Special"
        Me.TabPage143.UseVisualStyleBackColor = true
        '
        'imgTagCover
        '
        Me.imgTagCover.BackColor = System.Drawing.Color.DimGray
        Me.imgTagCover.Location = New System.Drawing.Point(15, 178)
        Me.imgTagCover.Name = "imgTagCover"
        Me.imgTagCover.Size = New System.Drawing.Size(104, 104)
        Me.imgTagCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTagCover.TabIndex = 16
        Me.imgTagCover.TabStop = false
        '
        'Label499
        '
        Me.Label499.AutoSize = true
        Me.Label499.Location = New System.Drawing.Point(12, 162)
        Me.Label499.Name = "Label499"
        Me.Label499.Size = New System.Drawing.Size(35, 13)
        Me.Label499.TabIndex = 15
        Me.Label499.Text = "Cover"
        '
        'Label498
        '
        Me.Label498.AutoSize = true
        Me.Label498.Location = New System.Drawing.Point(43, 334)
        Me.Label498.Name = "Label498"
        Me.Label498.Size = New System.Drawing.Size(194, 13)
        Me.Label498.TabIndex = 14
        Me.Label498.Text = "Many other tags are available using API"
        '
        'edTagLyrics
        '
        Me.edTagLyrics.Location = New System.Drawing.Point(15, 127)
        Me.edTagLyrics.Name = "edTagLyrics"
        Me.edTagLyrics.Size = New System.Drawing.Size(242, 20)
        Me.edTagLyrics.TabIndex = 13
        Me.edTagLyrics.Text = "Yo-ho-ho and the buttle of rum"
        '
        'Label497
        '
        Me.Label497.AutoSize = true
        Me.Label497.Location = New System.Drawing.Point(12, 112)
        Me.Label497.Name = "Label497"
        Me.Label497.Size = New System.Drawing.Size(34, 13)
        Me.Label497.TabIndex = 12
        Me.Label497.Text = "Lyrics"
        '
        'cbTagGenre
        '
        Me.cbTagGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTagGenre.FormattingEnabled = true
        Me.cbTagGenre.Location = New System.Drawing.Point(15, 76)
        Me.cbTagGenre.Name = "cbTagGenre"
        Me.cbTagGenre.Size = New System.Drawing.Size(242, 21)
        Me.cbTagGenre.TabIndex = 11
        '
        'Label494
        '
        Me.Label494.AutoSize = true
        Me.Label494.Location = New System.Drawing.Point(12, 60)
        Me.Label494.Name = "Label494"
        Me.Label494.Size = New System.Drawing.Size(36, 13)
        Me.Label494.TabIndex = 10
        Me.Label494.Text = "Genre"
        '
        'edTagComposers
        '
        Me.edTagComposers.Location = New System.Drawing.Point(15, 29)
        Me.edTagComposers.Name = "edTagComposers"
        Me.edTagComposers.Size = New System.Drawing.Size(242, 20)
        Me.edTagComposers.TabIndex = 9
        Me.edTagComposers.Text = "Sample composer"
        '
        'Label492
        '
        Me.Label492.AutoSize = true
        Me.Label492.Location = New System.Drawing.Point(12, 14)
        Me.Label492.Name = "Label492"
        Me.Label492.Size = New System.Drawing.Size(59, 13)
        Me.Label492.TabIndex = 8
        Me.Label492.Text = "Composers"
        '
        'cbTagEnabled
        '
        Me.cbTagEnabled.AutoSize = true
        Me.cbTagEnabled.Location = New System.Drawing.Point(14, 16)
        Me.cbTagEnabled.Name = "cbTagEnabled"
        Me.cbTagEnabled.Size = New System.Drawing.Size(135, 17)
        Me.cbTagEnabled.TabIndex = 2
        Me.cbTagEnabled.Text = "Write tags to output file"
        Me.cbTagEnabled.UseVisualStyleBackColor = true
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = true
        Me.linkLabel1.Location = New System.Drawing.Point(243, 573)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(78, 13)
        Me.linkLabel1.TabIndex = 85
        Me.linkLabel1.TabStop = true
        Me.linkLabel1.Text = "Watch tutorials"
        '
        'btStop
        '
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStop.Location = New System.Drawing.Point(698, 624)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(58, 23)
        Me.btStop.TabIndex = 88
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = true
        '
        'btStart
        '
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStart.Location = New System.Drawing.Point(631, 624)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(58, 23)
        Me.btStart.TabIndex = 87
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = true
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(441, 624)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(184, 23)
        Me.ProgressBar1.TabIndex = 86
        '
        'tbSeeking
        '
        Me.tbSeeking.Location = New System.Drawing.Point(327, 624)
        Me.tbSeeking.Name = "tbSeeking"
        Me.tbSeeking.Size = New System.Drawing.Size(108, 45)
        Me.tbSeeking.TabIndex = 89
        '
        'openFileDialog3
        '
        Me.openFileDialog3.FileName = "openFileDialog3"
        Me.openFileDialog3.Filter = "Windows Media profile|*.prx"
        '
        'VideoEdit1
        '
        Me.VideoEdit1.Audio_Channel_Mapper = Nothing
        Me.VideoEdit1.Audio_Effects_Enabled = false
        Me.VideoEdit1.Audio_Effects_UseLegacyEffects = false
        Me.VideoEdit1.Audio_Enhancer_Enabled = false
        Me.VideoEdit1.Audio_Preview_Enabled = false
        Me.VideoEdit1.BackColor = System.Drawing.Color.Black
        Me.VideoEdit1.Barcode_Reader_Enabled = false
        Me.VideoEdit1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.VideoEdit1.ChromaKey = Nothing
        Me.VideoEdit1.Debug_Dir = ""
        Me.VideoEdit1.Debug_Mode = false
        Me.VideoEdit1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.[Auto]
        Me.VideoEdit1.Decklink_Output = Nothing
        Me.VideoEdit1.Dynamic_Reconnection = false
        Me.VideoEdit1.Location = New System.Drawing.Point(331, 322)
        Me.VideoEdit1.Mode = VisioForge.Types.VFVideoEditMode.Convert
        Me.VideoEdit1.Motion_Detection = Nothing
        Me.VideoEdit1.Name = "VideoEdit1"
        Me.VideoEdit1.Network_Streaming_Audio_Enabled = false
        Me.VideoEdit1.Network_Streaming_Enabled = false
        Me.VideoEdit1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV
        Me.VideoEdit1.Network_Streaming_Network_Port = 0
        Me.VideoEdit1.Network_Streaming_Output = Nothing
        Me.VideoEdit1.Network_Streaming_URL = Nothing
        Me.VideoEdit1.Network_Streaming_WMV_Maximum_Clients = 0
        Me.VideoEdit1.Motion_DetectionEx = Nothing
        Me.VideoEdit1.Output_Filename = "c:\output.avi"
        Me.VideoEdit1.Output_Format = Nothing
        Me.VideoEdit1.Size = New System.Drawing.Size(425, 287)
        Me.VideoEdit1.Start_DelayEnabled = false
        Me.VideoEdit1.TabIndex = 90
        Me.VideoEdit1.Tags = Nothing
        Me.VideoEdit1.UseLibMediaInfo = false
        Me.VideoEdit1.Video_Crop = Nothing
        Me.VideoEdit1.Video_Custom_Resizer_CLSID = New System.Guid("00000000-0000-0000-0000-000000000000")
        Me.VideoEdit1.Video_Effects_AllowMultipleStreams = false
        Me.VideoEdit1.Video_Effects_Enabled = false
        Me.VideoEdit1.Video_FrameRate = 25R
        Me.VideoEdit1.Video_Preview_Enabled = true
        VideoRendererSettingsWinForms7.Aspect_Ratio_Override = false
        VideoRendererSettingsWinForms7.Aspect_Ratio_X = 0
        VideoRendererSettingsWinForms7.Aspect_Ratio_Y = 0
        VideoRendererSettingsWinForms7.BackgroundColor = System.Drawing.Color.Empty
'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        VideoRendererSettingsWinForms7.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.[Auto]
        VideoRendererSettingsWinForms7.Deinterlace_VMR9_Mode = Nothing
        VideoRendererSettingsWinForms7.Deinterlace_VMR9_UseDefault = false
        VideoRendererSettingsWinForms7.Flip_Horizontal = false
        VideoRendererSettingsWinForms7.Flip_Vertical = false
        VideoRendererSettingsWinForms7.RotationAngle = 0
        VideoRendererSettingsWinForms7.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox
        VideoRendererSettingsWinForms7.Video_Renderer = VisioForge.Types.VFVideoRenderer.VideoRenderer
        VideoRendererSettingsWinForms7.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.VideoRenderer
        VideoRendererSettingsWinForms7.Zoom_Ratio = 0
        VideoRendererSettingsWinForms7.Zoom_ShiftX = 0
        VideoRendererSettingsWinForms7.Zoom_ShiftY = 0
        Me.VideoEdit1.Video_Renderer = VideoRendererSettingsWinForms7
        Me.VideoEdit1.Video_Resize = false
        Me.VideoEdit1.Video_Resize_Height = 480
        Me.VideoEdit1.Video_Resize_Width = 640
        Me.VideoEdit1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone
        Me.VideoEdit1.Video_Subtitles = Nothing
        Me.VideoEdit1.Virtual_Camera_Output_Enabled = false
        '
        'tabControl3
        '
        Me.tabControl3.Controls.Add(Me.tabPage52)
        Me.tabControl3.Controls.Add(Me.tabPage53)
        Me.tabControl3.Controls.Add(Me.tabPage54)
        Me.tabControl3.Controls.Add(Me.TabPage74)
        Me.tabControl3.Location = New System.Drawing.Point(331, 12)
        Me.tabControl3.Name = "tabControl3"
        Me.tabControl3.SelectedIndex = 0
        Me.tabControl3.Size = New System.Drawing.Size(425, 304)
        Me.tabControl3.TabIndex = 91
        '
        'tabPage52
        '
        Me.tabPage52.Controls.Add(Me.groupBox7)
        Me.tabPage52.Controls.Add(Me.label50)
        Me.tabPage52.Controls.Add(Me.groupBox6)
        Me.tabPage52.Controls.Add(Me.btClearList)
        Me.tabPage52.Controls.Add(Me.btAddInputFile)
        Me.tabPage52.Controls.Add(Me.lbFiles)
        Me.tabPage52.Controls.Add(Me.label10)
        Me.tabPage52.Location = New System.Drawing.Point(4, 22)
        Me.tabPage52.Name = "tabPage52"
        Me.tabPage52.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage52.Size = New System.Drawing.Size(417, 278)
        Me.tabPage52.TabIndex = 0
        Me.tabPage52.Text = "Edit"
        Me.tabPage52.UseVisualStyleBackColor = true
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.label72)
        Me.groupBox7.Controls.Add(Me.edInsertTime)
        Me.groupBox7.Controls.Add(Me.label73)
        Me.groupBox7.Controls.Add(Me.cbInsertAfterPreviousFile)
        Me.groupBox7.Location = New System.Drawing.Point(253, 114)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(147, 103)
        Me.groupBox7.TabIndex = 56
        Me.groupBox7.TabStop = false
        Me.groupBox7.Text = "Timeline"
        '
        'label72
        '
        Me.label72.AutoSize = true
        Me.label72.Location = New System.Drawing.Point(116, 45)
        Me.label72.Name = "label72"
        Me.label72.Size = New System.Drawing.Size(20, 13)
        Me.label72.TabIndex = 42
        Me.label72.Text = "ms"
        '
        'edInsertTime
        '
        Me.edInsertTime.Location = New System.Drawing.Point(76, 42)
        Me.edInsertTime.Name = "edInsertTime"
        Me.edInsertTime.Size = New System.Drawing.Size(34, 20)
        Me.edInsertTime.TabIndex = 41
        Me.edInsertTime.Text = "4000"
        '
        'label73
        '
        Me.label73.AutoSize = true
        Me.label73.Location = New System.Drawing.Point(12, 45)
        Me.label73.Name = "label73"
        Me.label73.Size = New System.Drawing.Size(55, 13)
        Me.label73.TabIndex = 40
        Me.label73.Text = "Insert time"
        '
        'cbInsertAfterPreviousFile
        '
        Me.cbInsertAfterPreviousFile.AutoSize = true
        Me.cbInsertAfterPreviousFile.Checked = true
        Me.cbInsertAfterPreviousFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbInsertAfterPreviousFile.Location = New System.Drawing.Point(12, 19)
        Me.cbInsertAfterPreviousFile.Name = "cbInsertAfterPreviousFile"
        Me.cbInsertAfterPreviousFile.Size = New System.Drawing.Size(135, 17)
        Me.cbInsertAfterPreviousFile.TabIndex = 39
        Me.cbInsertAfterPreviousFile.Text = "Insert after previous file"
        Me.cbInsertAfterPreviousFile.UseVisualStyleBackColor = true
        '
        'label50
        '
        Me.label50.AutoSize = true
        Me.label50.Location = New System.Drawing.Point(6, 92)
        Me.label50.Name = "label50"
        Me.label50.Size = New System.Drawing.Size(250, 13)
        Me.label50.TabIndex = 55
        Me.label50.Text = "You must set this parameters before you add the file"
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.lbSpeed)
        Me.groupBox6.Controls.Add(Me.label42)
        Me.groupBox6.Controls.Add(Me.label37)
        Me.groupBox6.Controls.Add(Me.edStopTime)
        Me.groupBox6.Controls.Add(Me.label38)
        Me.groupBox6.Controls.Add(Me.label36)
        Me.groupBox6.Controls.Add(Me.edStartTime)
        Me.groupBox6.Controls.Add(Me.label35)
        Me.groupBox6.Controls.Add(Me.cbAddFullFile)
        Me.groupBox6.Controls.Add(Me.tbSpeed)
        Me.groupBox6.Location = New System.Drawing.Point(9, 114)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(238, 103)
        Me.groupBox6.TabIndex = 54
        Me.groupBox6.TabStop = false
        Me.groupBox6.Text = "Input file"
        '
        'lbSpeed
        '
        Me.lbSpeed.AutoSize = true
        Me.lbSpeed.Location = New System.Drawing.Point(200, 74)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(33, 13)
        Me.lbSpeed.TabIndex = 44
        Me.lbSpeed.Text = "100%"
        '
        'label42
        '
        Me.label42.AutoSize = true
        Me.label42.Location = New System.Drawing.Point(12, 74)
        Me.label42.Name = "label42"
        Me.label42.Size = New System.Drawing.Size(83, 13)
        Me.label42.TabIndex = 42
        Me.label42.Text = "Playback speed"
        '
        'label37
        '
        Me.label37.AutoSize = true
        Me.label37.Location = New System.Drawing.Point(213, 45)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(20, 13)
        Me.label37.TabIndex = 41
        Me.label37.Text = "ms"
        '
        'edStopTime
        '
        Me.edStopTime.Location = New System.Drawing.Point(178, 42)
        Me.edStopTime.Name = "edStopTime"
        Me.edStopTime.Size = New System.Drawing.Size(32, 20)
        Me.edStopTime.TabIndex = 40
        Me.edStopTime.Text = "5000"
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Location = New System.Drawing.Point(127, 45)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(51, 13)
        Me.label38.TabIndex = 39
        Me.label38.Text = "Stop time"
        '
        'label36
        '
        Me.label36.AutoSize = true
        Me.label36.Location = New System.Drawing.Point(92, 45)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(20, 13)
        Me.label36.TabIndex = 38
        Me.label36.Text = "ms"
        '
        'edStartTime
        '
        Me.edStartTime.Location = New System.Drawing.Point(67, 42)
        Me.edStartTime.Name = "edStartTime"
        Me.edStartTime.Size = New System.Drawing.Size(22, 20)
        Me.edStartTime.TabIndex = 37
        Me.edStartTime.Text = "0"
        '
        'label35
        '
        Me.label35.AutoSize = true
        Me.label35.Location = New System.Drawing.Point(12, 45)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(51, 13)
        Me.label35.TabIndex = 36
        Me.label35.Text = "Start time"
        '
        'cbAddFullFile
        '
        Me.cbAddFullFile.AutoSize = true
        Me.cbAddFullFile.Checked = true
        Me.cbAddFullFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAddFullFile.Location = New System.Drawing.Point(12, 19)
        Me.cbAddFullFile.Name = "cbAddFullFile"
        Me.cbAddFullFile.Size = New System.Drawing.Size(77, 17)
        Me.cbAddFullFile.TabIndex = 35
        Me.cbAddFullFile.Text = "Add full file"
        Me.cbAddFullFile.UseVisualStyleBackColor = true
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(101, 68)
        Me.tbSpeed.Maximum = 400
        Me.tbSpeed.Minimum = 10
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(99, 45)
        Me.tbSpeed.TabIndex = 43
        Me.tbSpeed.Value = 100
        '
        'btClearList
        '
        Me.btClearList.Location = New System.Drawing.Point(336, 56)
        Me.btClearList.Name = "btClearList"
        Me.btClearList.Size = New System.Drawing.Size(64, 23)
        Me.btClearList.TabIndex = 53
        Me.btClearList.Text = "Clear"
        Me.btClearList.UseVisualStyleBackColor = true
        '
        'btAddInputFile
        '
        Me.btAddInputFile.Location = New System.Drawing.Point(336, 27)
        Me.btAddInputFile.Name = "btAddInputFile"
        Me.btAddInputFile.Size = New System.Drawing.Size(64, 23)
        Me.btAddInputFile.TabIndex = 52
        Me.btAddInputFile.Text = "Add"
        Me.btAddInputFile.UseVisualStyleBackColor = true
        '
        'lbFiles
        '
        Me.lbFiles.FormattingEnabled = true
        Me.lbFiles.Location = New System.Drawing.Point(9, 27)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(321, 56)
        Me.lbFiles.TabIndex = 51
        '
        'label10
        '
        Me.label10.AutoSize = true
        Me.label10.Location = New System.Drawing.Point(6, 6)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(52, 13)
        Me.label10.TabIndex = 50
        Me.label10.Text = "Input files"
        '
        'tabPage53
        '
        Me.tabPage53.Controls.Add(Me.label134)
        Me.tabPage53.Controls.Add(Me.btSelectOutputCut)
        Me.tabPage53.Controls.Add(Me.edOutputFileCut)
        Me.tabPage53.Controls.Add(Me.label131)
        Me.tabPage53.Controls.Add(Me.btStopCut)
        Me.tabPage53.Controls.Add(Me.btStartCut)
        Me.tabPage53.Controls.Add(Me.label31)
        Me.tabPage53.Controls.Add(Me.btAddInputFile2)
        Me.tabPage53.Controls.Add(Me.edSourceFileToCut)
        Me.tabPage53.Controls.Add(Me.label30)
        Me.tabPage53.Controls.Add(Me.label26)
        Me.tabPage53.Controls.Add(Me.edStopTimeCut)
        Me.tabPage53.Controls.Add(Me.label27)
        Me.tabPage53.Controls.Add(Me.label28)
        Me.tabPage53.Controls.Add(Me.edStartTimeCut)
        Me.tabPage53.Controls.Add(Me.label29)
        Me.tabPage53.Location = New System.Drawing.Point(4, 22)
        Me.tabPage53.Name = "tabPage53"
        Me.tabPage53.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage53.Size = New System.Drawing.Size(417, 278)
        Me.tabPage53.TabIndex = 1
        Me.tabPage53.Text = "Cut file (w/o reencoding)"
        Me.tabPage53.UseVisualStyleBackColor = true
        '
        'label134
        '
        Me.label134.AutoSize = true
        Me.label134.Location = New System.Drawing.Point(17, 188)
        Me.label134.Name = "label134"
        Me.label134.Size = New System.Drawing.Size(221, 13)
        Me.label134.TabIndex = 72
        Me.label134.Text = "Better to specify start time based on keyframe"
        '
        'btSelectOutputCut
        '
        Me.btSelectOutputCut.Location = New System.Drawing.Point(368, 108)
        Me.btSelectOutputCut.Name = "btSelectOutputCut"
        Me.btSelectOutputCut.Size = New System.Drawing.Size(24, 23)
        Me.btSelectOutputCut.TabIndex = 71
        Me.btSelectOutputCut.Text = "..."
        Me.btSelectOutputCut.UseVisualStyleBackColor = true
        '
        'edOutputFileCut
        '
        Me.edOutputFileCut.Location = New System.Drawing.Point(83, 110)
        Me.edOutputFileCut.Name = "edOutputFileCut"
        Me.edOutputFileCut.Size = New System.Drawing.Size(279, 20)
        Me.edOutputFileCut.TabIndex = 70
        Me.edOutputFileCut.Text = "c:\vf\video_edit_output.avi"
        '
        'label131
        '
        Me.label131.AutoSize = true
        Me.label131.Location = New System.Drawing.Point(17, 113)
        Me.label131.Name = "label131"
        Me.label131.Size = New System.Drawing.Size(55, 13)
        Me.label131.TabIndex = 69
        Me.label131.Text = "Output file"
        '
        'btStopCut
        '
        Me.btStopCut.Location = New System.Drawing.Point(100, 153)
        Me.btStopCut.Name = "btStopCut"
        Me.btStopCut.Size = New System.Drawing.Size(75, 23)
        Me.btStopCut.TabIndex = 68
        Me.btStopCut.Text = "Stop"
        Me.btStopCut.UseVisualStyleBackColor = true
        '
        'btStartCut
        '
        Me.btStartCut.Location = New System.Drawing.Point(19, 153)
        Me.btStartCut.Name = "btStartCut"
        Me.btStartCut.Size = New System.Drawing.Size(75, 23)
        Me.btStartCut.TabIndex = 67
        Me.btStartCut.Text = "Start"
        Me.btStartCut.UseVisualStyleBackColor = true
        '
        'label31
        '
        Me.label31.AutoSize = true
        Me.label31.Location = New System.Drawing.Point(80, 77)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(183, 13)
        Me.label31.TabIndex = 66
        Me.label31.Text = "Specify time before adding source file"
        '
        'btAddInputFile2
        '
        Me.btAddInputFile2.Location = New System.Drawing.Point(368, 12)
        Me.btAddInputFile2.Name = "btAddInputFile2"
        Me.btAddInputFile2.Size = New System.Drawing.Size(24, 23)
        Me.btAddInputFile2.TabIndex = 65
        Me.btAddInputFile2.Text = "..."
        Me.btAddInputFile2.UseVisualStyleBackColor = true
        '
        'edSourceFileToCut
        '
        Me.edSourceFileToCut.Location = New System.Drawing.Point(83, 14)
        Me.edSourceFileToCut.Name = "edSourceFileToCut"
        Me.edSourceFileToCut.Size = New System.Drawing.Size(279, 20)
        Me.edSourceFileToCut.TabIndex = 64
        '
        'label30
        '
        Me.label30.AutoSize = true
        Me.label30.Location = New System.Drawing.Point(15, 17)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(57, 13)
        Me.label30.TabIndex = 63
        Me.label30.Text = "Source file"
        '
        'label26
        '
        Me.label26.AutoSize = true
        Me.label26.Location = New System.Drawing.Point(291, 50)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(20, 13)
        Me.label26.TabIndex = 62
        Me.label26.Text = "ms"
        '
        'edStopTimeCut
        '
        Me.edStopTimeCut.Location = New System.Drawing.Point(239, 48)
        Me.edStopTimeCut.Name = "edStopTimeCut"
        Me.edStopTimeCut.Size = New System.Drawing.Size(46, 20)
        Me.edStopTimeCut.TabIndex = 61
        Me.edStopTimeCut.Text = "5000"
        '
        'label27
        '
        Me.label27.AutoSize = true
        Me.label27.Location = New System.Drawing.Point(182, 51)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(51, 13)
        Me.label27.TabIndex = 60
        Me.label27.Text = "Stop time"
        '
        'label28
        '
        Me.label28.AutoSize = true
        Me.label28.Location = New System.Drawing.Point(135, 51)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(20, 13)
        Me.label28.TabIndex = 59
        Me.label28.Text = "ms"
        '
        'edStartTimeCut
        '
        Me.edStartTimeCut.Location = New System.Drawing.Point(83, 48)
        Me.edStartTimeCut.Name = "edStartTimeCut"
        Me.edStartTimeCut.Size = New System.Drawing.Size(46, 20)
        Me.edStartTimeCut.TabIndex = 58
        Me.edStartTimeCut.Text = "0"
        '
        'label29
        '
        Me.label29.AutoSize = true
        Me.label29.Location = New System.Drawing.Point(17, 51)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(51, 13)
        Me.label29.TabIndex = 57
        Me.label29.Text = "Start time"
        '
        'tabPage54
        '
        Me.tabPage54.Controls.Add(Me.btSelectOutputJoin)
        Me.tabPage54.Controls.Add(Me.edOutputFileJoin)
        Me.tabPage54.Controls.Add(Me.label132)
        Me.tabPage54.Controls.Add(Me.btStopJoin)
        Me.tabPage54.Controls.Add(Me.btStartJoin)
        Me.tabPage54.Controls.Add(Me.btClearList3)
        Me.tabPage54.Controls.Add(Me.btAddInputFile3)
        Me.tabPage54.Controls.Add(Me.lbFiles2)
        Me.tabPage54.Controls.Add(Me.label32)
        Me.tabPage54.Location = New System.Drawing.Point(4, 22)
        Me.tabPage54.Name = "tabPage54"
        Me.tabPage54.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage54.Size = New System.Drawing.Size(417, 278)
        Me.tabPage54.TabIndex = 2
        Me.tabPage54.Text = "Join files (w/o reencoding)"
        Me.tabPage54.UseVisualStyleBackColor = true
        '
        'btSelectOutputJoin
        '
        Me.btSelectOutputJoin.Location = New System.Drawing.Point(365, 106)
        Me.btSelectOutputJoin.Name = "btSelectOutputJoin"
        Me.btSelectOutputJoin.Size = New System.Drawing.Size(24, 23)
        Me.btSelectOutputJoin.TabIndex = 71
        Me.btSelectOutputJoin.Text = "..."
        Me.btSelectOutputJoin.UseVisualStyleBackColor = true
        '
        'edOutputFileJoin
        '
        Me.edOutputFileJoin.Location = New System.Drawing.Point(87, 108)
        Me.edOutputFileJoin.Name = "edOutputFileJoin"
        Me.edOutputFileJoin.Size = New System.Drawing.Size(272, 20)
        Me.edOutputFileJoin.TabIndex = 70
        Me.edOutputFileJoin.Text = "c:\vf\video_edit_output.avi"
        '
        'label132
        '
        Me.label132.AutoSize = true
        Me.label132.Location = New System.Drawing.Point(15, 111)
        Me.label132.Name = "label132"
        Me.label132.Size = New System.Drawing.Size(55, 13)
        Me.label132.TabIndex = 69
        Me.label132.Text = "Output file"
        '
        'btStopJoin
        '
        Me.btStopJoin.Location = New System.Drawing.Point(99, 154)
        Me.btStopJoin.Name = "btStopJoin"
        Me.btStopJoin.Size = New System.Drawing.Size(75, 23)
        Me.btStopJoin.TabIndex = 68
        Me.btStopJoin.Text = "Stop"
        Me.btStopJoin.UseVisualStyleBackColor = true
        '
        'btStartJoin
        '
        Me.btStartJoin.Location = New System.Drawing.Point(18, 154)
        Me.btStartJoin.Name = "btStartJoin"
        Me.btStartJoin.Size = New System.Drawing.Size(75, 23)
        Me.btStartJoin.TabIndex = 67
        Me.btStartJoin.Text = "Start"
        Me.btStartJoin.UseVisualStyleBackColor = true
        '
        'btClearList3
        '
        Me.btClearList3.Location = New System.Drawing.Point(325, 62)
        Me.btClearList3.Name = "btClearList3"
        Me.btClearList3.Size = New System.Drawing.Size(64, 23)
        Me.btClearList3.TabIndex = 66
        Me.btClearList3.Text = "Clear"
        Me.btClearList3.UseVisualStyleBackColor = true
        '
        'btAddInputFile3
        '
        Me.btAddInputFile3.Location = New System.Drawing.Point(325, 33)
        Me.btAddInputFile3.Name = "btAddInputFile3"
        Me.btAddInputFile3.Size = New System.Drawing.Size(64, 23)
        Me.btAddInputFile3.TabIndex = 65
        Me.btAddInputFile3.Text = "Add"
        Me.btAddInputFile3.UseVisualStyleBackColor = true
        '
        'lbFiles2
        '
        Me.lbFiles2.FormattingEnabled = true
        Me.lbFiles2.Location = New System.Drawing.Point(18, 33)
        Me.lbFiles2.Name = "lbFiles2"
        Me.lbFiles2.Size = New System.Drawing.Size(301, 56)
        Me.lbFiles2.TabIndex = 64
        '
        'label32
        '
        Me.label32.AutoSize = true
        Me.label32.Location = New System.Drawing.Point(15, 17)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(52, 13)
        Me.label32.TabIndex = 63
        Me.label32.Text = "Input files"
        '
        'TabPage74
        '
        Me.TabPage74.Controls.Add(Me.label168)
        Me.TabPage74.Controls.Add(Me.cbMuxStreamsShortest)
        Me.TabPage74.Controls.Add(Me.cbMuxStreamsType)
        Me.TabPage74.Controls.Add(Me.btMuxStreamsSelectFile)
        Me.TabPage74.Controls.Add(Me.edMuxStreamsSourceFile)
        Me.TabPage74.Controls.Add(Me.label167)
        Me.TabPage74.Controls.Add(Me.btMuxStreamsSelectOutput)
        Me.TabPage74.Controls.Add(Me.edMuxStreamsOutputFile)
        Me.TabPage74.Controls.Add(Me.label165)
        Me.TabPage74.Controls.Add(Me.btStopMux)
        Me.TabPage74.Controls.Add(Me.btStartMux)
        Me.TabPage74.Controls.Add(Me.btMuxStreamsClear)
        Me.TabPage74.Controls.Add(Me.btMuxStreamsAdd)
        Me.TabPage74.Controls.Add(Me.lbMuxStreamsList)
        Me.TabPage74.Controls.Add(Me.label166)
        Me.TabPage74.Location = New System.Drawing.Point(4, 22)
        Me.TabPage74.Name = "TabPage74"
        Me.TabPage74.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage74.Size = New System.Drawing.Size(417, 278)
        Me.TabPage74.TabIndex = 3
        Me.TabPage74.Text = "Mux streams (w/o reencoding)"
        Me.TabPage74.UseVisualStyleBackColor = true
        '
        'label168
        '
        Me.label168.AutoSize = true
        Me.label168.Location = New System.Drawing.Point(267, 12)
        Me.label168.Name = "label168"
        Me.label168.Size = New System.Drawing.Size(71, 13)
        Me.label168.TabIndex = 91
        Me.label168.Text = "Type or index"
        '
        'cbMuxStreamsShortest
        '
        Me.cbMuxStreamsShortest.AutoSize = true
        Me.cbMuxStreamsShortest.Location = New System.Drawing.Point(14, 140)
        Me.cbMuxStreamsShortest.Name = "cbMuxStreamsShortest"
        Me.cbMuxStreamsShortest.Size = New System.Drawing.Size(185, 17)
        Me.cbMuxStreamsShortest.TabIndex = 90
        Me.cbMuxStreamsShortest.Text = "Set file duration to shortest stream"
        Me.cbMuxStreamsShortest.UseVisualStyleBackColor = true
        '
        'cbMuxStreamsType
        '
        Me.cbMuxStreamsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMuxStreamsType.FormattingEnabled = true
        Me.cbMuxStreamsType.Items.AddRange(New Object() {"Video", "Audio", "0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cbMuxStreamsType.Location = New System.Drawing.Point(270, 27)
        Me.cbMuxStreamsType.Name = "cbMuxStreamsType"
        Me.cbMuxStreamsType.Size = New System.Drawing.Size(76, 21)
        Me.cbMuxStreamsType.TabIndex = 89
        '
        'btMuxStreamsSelectFile
        '
        Me.btMuxStreamsSelectFile.Location = New System.Drawing.Point(241, 26)
        Me.btMuxStreamsSelectFile.Name = "btMuxStreamsSelectFile"
        Me.btMuxStreamsSelectFile.Size = New System.Drawing.Size(23, 23)
        Me.btMuxStreamsSelectFile.TabIndex = 88
        Me.btMuxStreamsSelectFile.Text = "..."
        Me.btMuxStreamsSelectFile.UseVisualStyleBackColor = true
        '
        'edMuxStreamsSourceFile
        '
        Me.edMuxStreamsSourceFile.Location = New System.Drawing.Point(14, 28)
        Me.edMuxStreamsSourceFile.Name = "edMuxStreamsSourceFile"
        Me.edMuxStreamsSourceFile.Size = New System.Drawing.Size(221, 20)
        Me.edMuxStreamsSourceFile.TabIndex = 87
        '
        'label167
        '
        Me.label167.AutoSize = true
        Me.label167.Location = New System.Drawing.Point(11, 12)
        Me.label167.Name = "label167"
        Me.label167.Size = New System.Drawing.Size(57, 13)
        Me.label167.TabIndex = 86
        Me.label167.Text = "Source file"
        '
        'btMuxStreamsSelectOutput
        '
        Me.btMuxStreamsSelectOutput.Location = New System.Drawing.Point(380, 180)
        Me.btMuxStreamsSelectOutput.Name = "btMuxStreamsSelectOutput"
        Me.btMuxStreamsSelectOutput.Size = New System.Drawing.Size(24, 23)
        Me.btMuxStreamsSelectOutput.TabIndex = 85
        Me.btMuxStreamsSelectOutput.Text = "..."
        Me.btMuxStreamsSelectOutput.UseVisualStyleBackColor = true
        '
        'edMuxStreamsOutputFile
        '
        Me.edMuxStreamsOutputFile.Location = New System.Drawing.Point(83, 182)
        Me.edMuxStreamsOutputFile.Name = "edMuxStreamsOutputFile"
        Me.edMuxStreamsOutputFile.Size = New System.Drawing.Size(291, 20)
        Me.edMuxStreamsOutputFile.TabIndex = 84
        Me.edMuxStreamsOutputFile.Text = "c:\vf\video_edit_output.avi"
        '
        'label165
        '
        Me.label165.AutoSize = true
        Me.label165.Location = New System.Drawing.Point(11, 185)
        Me.label165.Name = "label165"
        Me.label165.Size = New System.Drawing.Size(55, 13)
        Me.label165.TabIndex = 83
        Me.label165.Text = "Output file"
        '
        'btStopMux
        '
        Me.btStopMux.Location = New System.Drawing.Point(95, 228)
        Me.btStopMux.Name = "btStopMux"
        Me.btStopMux.Size = New System.Drawing.Size(75, 23)
        Me.btStopMux.TabIndex = 82
        Me.btStopMux.Text = "Stop"
        Me.btStopMux.UseVisualStyleBackColor = true
        '
        'btStartMux
        '
        Me.btStartMux.Location = New System.Drawing.Point(14, 228)
        Me.btStartMux.Name = "btStartMux"
        Me.btStartMux.Size = New System.Drawing.Size(75, 23)
        Me.btStartMux.TabIndex = 81
        Me.btStartMux.Text = "Start"
        Me.btStartMux.UseVisualStyleBackColor = true
        '
        'btMuxStreamsClear
        '
        Me.btMuxStreamsClear.Location = New System.Drawing.Point(340, 140)
        Me.btMuxStreamsClear.Name = "btMuxStreamsClear"
        Me.btMuxStreamsClear.Size = New System.Drawing.Size(64, 23)
        Me.btMuxStreamsClear.TabIndex = 80
        Me.btMuxStreamsClear.Text = "Clear"
        Me.btMuxStreamsClear.UseVisualStyleBackColor = true
        '
        'btMuxStreamsAdd
        '
        Me.btMuxStreamsAdd.Location = New System.Drawing.Point(352, 26)
        Me.btMuxStreamsAdd.Name = "btMuxStreamsAdd"
        Me.btMuxStreamsAdd.Size = New System.Drawing.Size(52, 23)
        Me.btMuxStreamsAdd.TabIndex = 79
        Me.btMuxStreamsAdd.Text = "Add"
        Me.btMuxStreamsAdd.UseVisualStyleBackColor = true
        '
        'lbMuxStreamsList
        '
        Me.lbMuxStreamsList.FormattingEnabled = true
        Me.lbMuxStreamsList.Location = New System.Drawing.Point(14, 76)
        Me.lbMuxStreamsList.Name = "lbMuxStreamsList"
        Me.lbMuxStreamsList.Size = New System.Drawing.Size(390, 56)
        Me.lbMuxStreamsList.TabIndex = 78
        '
        'label166
        '
        Me.label166.AutoSize = true
        Me.label166.Location = New System.Drawing.Point(11, 60)
        Me.label166.Name = "label166"
        Me.label166.Size = New System.Drawing.Size(70, 13)
        Me.label166.TabIndex = 77
        Me.label166.Text = "Input streams"
        '
        'btTest
        '
        Me.btTest.Location = New System.Drawing.Point(242, 541)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(75, 23)
        Me.btTest.TabIndex = 92
        Me.btTest.Text = "Test"
        Me.btTest.UseVisualStyleBackColor = true
        '
        'cbLicensing
        '
        Me.cbLicensing.AutoSize = true
        Me.cbLicensing.Location = New System.Drawing.Point(137, 573)
        Me.cbLicensing.Name = "cbLicensing"
        Me.cbLicensing.Size = New System.Drawing.Size(91, 17)
        Me.cbLicensing.TabIndex = 93
        Me.cbLicensing.Text = "Licensing info"
        Me.cbLicensing.UseVisualStyleBackColor = true
        '
        'openFileDialogSubtitles
        '
        Me.openFileDialogSubtitles.FileName = "openFileDialog4"
        Me.openFileDialogSubtitles.Filter = "Subtitle files|*.srt;*.ssa;*.ass;*.sub|All files|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 659)
        Me.Controls.Add(Me.cbLicensing)
        Me.Controls.Add(Me.btTest)
        Me.Controls.Add(Me.VideoEdit1)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbSeeking)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.mmLog)
        Me.Controls.Add(Me.label120)
        Me.Controls.Add(Me.cbDebugMode)
        Me.Controls.Add(Me.rbPreview)
        Me.Controls.Add(Me.rbConvert)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.tabControl3)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "VisioForge Video Edit SDK .Net - Main Demo"
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabControl2.ResumeLayout(false)
        Me.tabPage30.ResumeLayout(false)
        Me.tabPage30.PerformLayout
        Me.tabPage4.ResumeLayout(false)
        Me.tabPage4.PerformLayout
        Me.tabPage5.ResumeLayout(false)
        Me.tabPage5.PerformLayout
        Me.tabControl11.ResumeLayout(false)
        Me.tabPage13.ResumeLayout(false)
        Me.tabPage13.PerformLayout
        Me.tabPage19.ResumeLayout(false)
        Me.tabPage19.PerformLayout
        Me.tabPage6.ResumeLayout(false)
        Me.groupBox8.ResumeLayout(false)
        Me.groupBox8.PerformLayout
        Me.groupBox9.ResumeLayout(false)
        Me.groupBox9.PerformLayout
        Me.groupBox10.ResumeLayout(false)
        Me.groupBox10.PerformLayout
        Me.tabPage10.ResumeLayout(false)
        Me.tabPage10.PerformLayout
        Me.tabPage11.ResumeLayout(false)
        Me.tabControl4.ResumeLayout(false)
        Me.tabPage17.ResumeLayout(false)
        Me.tabPage17.PerformLayout
        CType(Me.tbLameEncodingQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        Me.groupBox12.ResumeLayout(false)
        Me.groupBox12.PerformLayout
        CType(Me.tbLameVBRQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage18.ResumeLayout(false)
        Me.tabPage18.PerformLayout
        Me.tabPage12.ResumeLayout(false)
        Me.tabPage12.PerformLayout
        Me.tabPage8.ResumeLayout(false)
        Me.tabPage8.PerformLayout
        Me.groupBox4.ResumeLayout(false)
        Me.groupBox4.PerformLayout
        Me.groupBox3.ResumeLayout(false)
        Me.groupBox3.PerformLayout
        Me.TabPage14.ResumeLayout(false)
        Me.tabControl6.ResumeLayout(false)
        Me.tabPage58.ResumeLayout(false)
        Me.tabPage58.PerformLayout
        Me.tabPage60.ResumeLayout(false)
        Me.tabPage60.PerformLayout
        CType(Me.tbWebMAudioQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage61.ResumeLayout(false)
        Me.tabPage61.PerformLayout
        Me.tabPage63.ResumeLayout(false)
        Me.tabPage63.PerformLayout
        Me.TabPage15.ResumeLayout(false)
        Me.TabPage15.PerformLayout
        Me.tabControl16.ResumeLayout(false)
        Me.tabPage62.ResumeLayout(false)
        Me.tabPage62.PerformLayout
        Me.tabPage64.ResumeLayout(false)
        Me.tabPage64.PerformLayout
        Me.tabPage65.ResumeLayout(false)
        Me.tabPage65.PerformLayout
        Me.TabPage66.ResumeLayout(false)
        Me.TabPage66.PerformLayout
        Me.tabControl29.ResumeLayout(false)
        Me.tabPage129.ResumeLayout(false)
        Me.tabPage129.PerformLayout
        Me.tabPage132.ResumeLayout(false)
        Me.tabPage132.PerformLayout
        Me.tabPage130.ResumeLayout(false)
        Me.tabControl30.ResumeLayout(false)
        Me.tabPage134.ResumeLayout(false)
        Me.tabPage134.PerformLayout
        Me.tabPage137.ResumeLayout(false)
        Me.tabPage137.PerformLayout
        CType(Me.tbFFEXEVideoQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage136.ResumeLayout(false)
        Me.tabPage136.PerformLayout
        Me.tabPage135.ResumeLayout(false)
        Me.tabPage135.PerformLayout
        CType(Me.tbFFEXEH264Quantizer,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage131.ResumeLayout(false)
        Me.tabPage131.PerformLayout
        CType(Me.tbFFEXEAudioQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage133.ResumeLayout(false)
        Me.tabPage133.PerformLayout
        Me.TabPage46.ResumeLayout(false)
        Me.tabControl24.ResumeLayout(false)
        Me.TabPage50.ResumeLayout(false)
        Me.TabPage50.PerformLayout
        Me.tabPage89.ResumeLayout(false)
        Me.groupBox18.ResumeLayout(false)
        Me.groupBox18.PerformLayout
        Me.groupBox29.ResumeLayout(false)
        Me.groupBox29.PerformLayout
        Me.groupBox46.ResumeLayout(false)
        Me.groupBox46.PerformLayout
        Me.TabPage22.ResumeLayout(false)
        Me.groupBox14.ResumeLayout(false)
        Me.groupBox14.PerformLayout
        Me.groupBox49.ResumeLayout(false)
        Me.groupBox49.PerformLayout
        Me.groupBox50.ResumeLayout(false)
        Me.groupBox50.PerformLayout
        Me.tabPage90.ResumeLayout(false)
        Me.tabPage90.PerformLayout
        Me.TabPage51.ResumeLayout(false)
        Me.TabPage51.PerformLayout
        CType(Me.tbFLACLPCOrder,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbFLACLevel,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage55.ResumeLayout(false)
        Me.TabPage55.PerformLayout
        CType(Me.tbSpeexComplexity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSpeexMaxBitrate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSpeexBitrate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSpeexQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage77.ResumeLayout(false)
        Me.TabControl31.ResumeLayout(false)
        Me.tabPage140.ResumeLayout(false)
        Me.tabPage140.PerformLayout
        Me.TabPage79.ResumeLayout(false)
        Me.TabPage79.PerformLayout
        Me.tabPage31.ResumeLayout(false)
        Me.tabControl17.ResumeLayout(false)
        Me.tabPage68.ResumeLayout(false)
        Me.tabPage68.PerformLayout
        Me.tabControl7.ResumeLayout(false)
        Me.tabPage29.ResumeLayout(false)
        Me.tabPage29.PerformLayout
        Me.tabControl8.ResumeLayout(false)
        Me.tabPage35.ResumeLayout(false)
        Me.tabPage35.PerformLayout
        CType(Me.tbTextLogoTransp,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage36.ResumeLayout(false)
        Me.tabPage36.PerformLayout
        Me.tabPage37.ResumeLayout(false)
        Me.tabPage37.PerformLayout
        Me.tabPage38.ResumeLayout(false)
        Me.tabPage38.PerformLayout
        Me.tabPage39.ResumeLayout(false)
        Me.tabPage39.PerformLayout
        Me.tabPage40.ResumeLayout(false)
        Me.groupBox16.ResumeLayout(false)
        Me.groupBox16.PerformLayout
        Me.groupBox17.ResumeLayout(false)
        Me.groupBox17.PerformLayout
        Me.tabPage41.ResumeLayout(false)
        Me.tabPage41.PerformLayout
        Me.tabPage42.ResumeLayout(false)
        Me.tabPage42.PerformLayout
        CType(Me.tbImageLogoTransp,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox22.ResumeLayout(false)
        Me.groupBox22.PerformLayout
        Me.groupBox23.ResumeLayout(false)
        Me.groupBox23.PerformLayout
        Me.TabPage7.ResumeLayout(false)
        Me.TabPage7.PerformLayout
        Me.groupBox37.ResumeLayout(false)
        Me.TabPage16.ResumeLayout(false)
        Me.TabPage16.PerformLayout
        Me.groupBox40.ResumeLayout(false)
        Me.groupBox40.PerformLayout
        Me.groupBox39.ResumeLayout(false)
        Me.groupBox39.PerformLayout
        Me.groupBox38.ResumeLayout(false)
        Me.groupBox38.PerformLayout
        Me.TabPage33.ResumeLayout(false)
        Me.TabPage33.PerformLayout
        Me.groupBox45.ResumeLayout(false)
        Me.groupBox45.PerformLayout
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbDarkness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbLightness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage69.ResumeLayout(false)
        Me.tabPage69.PerformLayout
        Me.tabPage59.ResumeLayout(false)
        Me.tabPage59.PerformLayout
        Me.TabPage82.ResumeLayout(false)
        Me.TabPage82.PerformLayout
        CType(Me.tbGPUContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPUDarkness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPULightness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPUSaturation,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage20.ResumeLayout(false)
        Me.tabControl15.ResumeLayout(false)
        Me.TabPage26.ResumeLayout(false)
        Me.TabPage26.PerformLayout
        Me.TabPage27.ResumeLayout(false)
        Me.TabPage27.PerformLayout
        Me.TabPage21.ResumeLayout(false)
        Me.TabPage21.PerformLayout
        CType(Me.tbChromaKeyContrastHigh,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbChromaKeyContrastLow,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage70.ResumeLayout(false)
        Me.tabPage70.PerformLayout
        Me.TabPage81.ResumeLayout(false)
        Me.TabPage81.PerformLayout
        Me.tabPage9.ResumeLayout(false)
        Me.tabPage9.PerformLayout
        Me.groupBox5.ResumeLayout(false)
        Me.groupBox5.PerformLayout
        Me.tabPage3.ResumeLayout(false)
        Me.tabPage3.PerformLayout
        Me.tabControl18.ResumeLayout(false)
        Me.tabPage71.ResumeLayout(false)
        Me.tabPage71.PerformLayout
        CType(Me.tbAudAmplifyAmp,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage72.ResumeLayout(false)
        Me.tabPage72.PerformLayout
        CType(Me.tbAudEq9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudEq0,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage73.ResumeLayout(false)
        Me.tabPage73.PerformLayout
        CType(Me.tbAudRelease,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudAttack,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudDynAmp,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage75.ResumeLayout(false)
        Me.tabPage75.PerformLayout
        CType(Me.tbAud3DSound,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage76.ResumeLayout(false)
        Me.tabPage76.PerformLayout
        CType(Me.tbAudTrueBass,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage57.ResumeLayout(false)
        Me.TabPage57.PerformLayout
        CType(Me.tbAudioTimeshift,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        CType(Me.tbAudioOutputGainLFE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainSR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainSL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainL,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        CType(Me.tbAudioInputGainLFE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainSR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainSL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainL,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage80.ResumeLayout(false)
        Me.TabPage80.PerformLayout
        Me.groupBox41.ResumeLayout(false)
        Me.groupBox41.PerformLayout
        CType(Me.tbAudioChannelMapperVolume,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage28.ResumeLayout(false)
        Me.TabPage28.PerformLayout
        Me.tabControl9.ResumeLayout(false)
        Me.tabPage44.ResumeLayout(false)
        Me.tabPage44.PerformLayout
        Me.tabPage45.ResumeLayout(false)
        Me.groupBox25.ResumeLayout(false)
        Me.groupBox25.PerformLayout
        CType(Me.tbMotDetHLThreshold,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox27.ResumeLayout(false)
        Me.groupBox27.PerformLayout
        Me.groupBox26.ResumeLayout(false)
        Me.groupBox26.PerformLayout
        CType(Me.tbMotDetDropFramesThreshold,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox24.ResumeLayout(false)
        Me.groupBox24.PerformLayout
        Me.tabPage2.ResumeLayout(false)
        Me.tabPage2.PerformLayout
        Me.groupBox13.ResumeLayout(false)
        Me.groupBox13.PerformLayout
        Me.TabPage23.ResumeLayout(false)
        Me.TabPage23.PerformLayout
        Me.TabPage24.ResumeLayout(false)
        Me.TabPage24.PerformLayout
        Me.tabControl5.ResumeLayout(false)
        Me.TabPage25.ResumeLayout(false)
        Me.TabPage25.PerformLayout
        Me.TabPage47.ResumeLayout(false)
        Me.TabPage47.PerformLayout
        Me.TabPage48.ResumeLayout(false)
        Me.TabPage48.PerformLayout
        Me.TabPage67.ResumeLayout(false)
        Me.TabPage67.PerformLayout
        Me.TabPage49.ResumeLayout(false)
        Me.TabPage49.PerformLayout
        Me.TabPage56.ResumeLayout(false)
        Me.TabPage56.PerformLayout
        Me.TabPage32.ResumeLayout(false)
        Me.TabPage32.PerformLayout
        Me.TabPage34.ResumeLayout(false)
        Me.TabPage34.PerformLayout
        Me.TabPage43.ResumeLayout(false)
        Me.groupBox48.ResumeLayout(false)
        Me.groupBox48.PerformLayout
        Me.groupBox47.ResumeLayout(false)
        Me.groupBox47.PerformLayout
        Me.groupBox43.ResumeLayout(false)
        Me.groupBox43.PerformLayout
        Me.TabPage78.ResumeLayout(false)
        Me.TabPage78.PerformLayout
        Me.TabControl32.ResumeLayout(false)
        Me.TabPage142.ResumeLayout(false)
        Me.TabPage142.PerformLayout
        Me.TabPage143.ResumeLayout(false)
        Me.TabPage143.PerformLayout
        CType(Me.imgTagCover,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSeeking,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabControl3.ResumeLayout(false)
        Me.tabPage52.ResumeLayout(false)
        Me.tabPage52.PerformLayout
        Me.groupBox7.ResumeLayout(false)
        Me.groupBox7.PerformLayout
        Me.groupBox6.ResumeLayout(false)
        Me.groupBox6.PerformLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage53.ResumeLayout(false)
        Me.tabPage53.PerformLayout
        Me.tabPage54.ResumeLayout(false)
        Me.tabPage54.PerformLayout
        Me.TabPage74.ResumeLayout(false)
        Me.TabPage74.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Private WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents SaveDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents openFileDialog2 As System.Windows.Forms.OpenFileDialog
    Private WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
    Private WithEvents mmLog As System.Windows.Forms.TextBox
    Private WithEvents label120 As System.Windows.Forms.Label
    Private WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Private WithEvents rbPreview As System.Windows.Forms.RadioButton
    Private WithEvents rbConvert As System.Windows.Forms.RadioButton
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents btSelectOutput As System.Windows.Forms.Button
    Private WithEvents edOutput As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents cbOutputVideoFormat As System.Windows.Forms.ComboBox
    Private WithEvents tabControl2 As System.Windows.Forms.TabControl
    Private WithEvents tabPage30 As System.Windows.Forms.TabPage
    Private WithEvents cbFrameRate As System.Windows.Forms.ComboBox
    Private WithEvents edHeight As System.Windows.Forms.TextBox
    Private WithEvents edWidth As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cbResize As System.Windows.Forms.CheckBox
    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
    Private WithEvents cbUseLameInAVI As System.Windows.Forms.CheckBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents cbBPS As System.Windows.Forms.ComboBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents cbSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents cbChannels As System.Windows.Forms.ComboBox
    Private WithEvents btAudioSettings As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cbAudioCodec As System.Windows.Forms.ComboBox
    Private WithEvents btVideoSettings As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cbVideoCodec As System.Windows.Forms.ComboBox
    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
    Private WithEvents tabControl11 As System.Windows.Forms.TabControl
    Private WithEvents tabPage13 As System.Windows.Forms.TabPage
    Private WithEvents label189 As System.Windows.Forms.Label
    Private WithEvents edWMVKeyFrameInterval As System.Windows.Forms.TextBox
    Private WithEvents label190 As System.Windows.Forms.Label
    Private WithEvents label191 As System.Windows.Forms.Label
    Private WithEvents edWMVFrameRate As System.Windows.Forms.TextBox
    Private WithEvents label192 As System.Windows.Forms.Label
    Private WithEvents edWMVVideoQuality As System.Windows.Forms.TextBox
    Private WithEvents label188 As System.Windows.Forms.Label
    Private WithEvents cbWMVTVFormat As System.Windows.Forms.ComboBox
    Private WithEvents label187 As System.Windows.Forms.Label
    Private WithEvents label183 As System.Windows.Forms.Label
    Private WithEvents edWMVVideoPeakBitrate As System.Windows.Forms.TextBox
    Private WithEvents label184 As System.Windows.Forms.Label
    Private WithEvents label185 As System.Windows.Forms.Label
    Private WithEvents edWMVVideoBitrate As System.Windows.Forms.TextBox
    Private WithEvents label186 As System.Windows.Forms.Label
    Private WithEvents label62 As System.Windows.Forms.Label
    Private WithEvents cbWMVSizeSameAsInput As System.Windows.Forms.CheckBox
    Private WithEvents edWMVHeight As System.Windows.Forms.TextBox
    Private WithEvents edWMVWidth As System.Windows.Forms.TextBox
    Private WithEvents label182 As System.Windows.Forms.Label
    Private WithEvents cbWMVVideoEnabled As System.Windows.Forms.CheckBox
    Private WithEvents cbWMVVideoCodec As System.Windows.Forms.ComboBox
    Private WithEvents label174 As System.Windows.Forms.Label
    Private WithEvents cbWMVVideoMode As System.Windows.Forms.ComboBox
    Private WithEvents label175 As System.Windows.Forms.Label
    Private WithEvents tabPage19 As System.Windows.Forms.TabPage
    Private WithEvents cbWMVAudioEnabled As System.Windows.Forms.CheckBox
    Private WithEvents label193 As System.Windows.Forms.Label
    Private WithEvents edWMVAudioPeakBitrate As System.Windows.Forms.TextBox
    Private WithEvents label194 As System.Windows.Forms.Label
    Private WithEvents cbWMVAudioFormat As System.Windows.Forms.ComboBox
    Private WithEvents label195 As System.Windows.Forms.Label
    Private WithEvents cbWMVAudioCodec As System.Windows.Forms.ComboBox
    Private WithEvents label196 As System.Windows.Forms.Label
    Private WithEvents cbWMVAudioMode As System.Windows.Forms.ComboBox
    Private WithEvents label197 As System.Windows.Forms.Label
    Private WithEvents rbWMVCustom As System.Windows.Forms.RadioButton
    Private WithEvents cbWMVInternalProfile8 As System.Windows.Forms.ComboBox
    Private WithEvents rbWMVInternal8 As System.Windows.Forms.RadioButton
    Private WithEvents cbWMVInternalProfile9 As System.Windows.Forms.ComboBox
    Private WithEvents rbWMVInternal9 As System.Windows.Forms.RadioButton
    Private WithEvents rbWMVExternal As System.Windows.Forms.RadioButton
    Private WithEvents btSelectWM As System.Windows.Forms.Button
    Private WithEvents edWMVProfile As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
    Private WithEvents rbDVType2 As System.Windows.Forms.RadioButton
    Private WithEvents rbDVType1 As System.Windows.Forms.RadioButton
    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
    Private WithEvents rbDVNTSC As System.Windows.Forms.RadioButton
    Private WithEvents rbDVPAL As System.Windows.Forms.RadioButton
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents cbDVChannels As System.Windows.Forms.ComboBox
    Private WithEvents cbDVSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents tabPage10 As System.Windows.Forms.TabPage
    Private WithEvents btAudioSettings2 As System.Windows.Forms.Button
    Private WithEvents label67 As System.Windows.Forms.Label
    Private WithEvents cbAudioCodecs2 As System.Windows.Forms.ComboBox
    Private WithEvents cbSampleRate2 As System.Windows.Forms.ComboBox
    Private WithEvents label68 As System.Windows.Forms.Label
    Private WithEvents cbBPS2 As System.Windows.Forms.ComboBox
    Private WithEvents label69 As System.Windows.Forms.Label
    Private WithEvents cbChannels2 As System.Windows.Forms.ComboBox
    Private WithEvents label70 As System.Windows.Forms.Label
    Private WithEvents tabPage11 As System.Windows.Forms.TabPage
    Private WithEvents tabControl4 As System.Windows.Forms.TabControl
    Private WithEvents tabPage17 As System.Windows.Forms.TabPage
    Private WithEvents label71 As System.Windows.Forms.Label
    Private WithEvents tbLameEncodingQuality As System.Windows.Forms.TrackBar
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents cbLameSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents groupBox11 As System.Windows.Forms.GroupBox
    Private WithEvents rbLameMono As System.Windows.Forms.RadioButton
    Private WithEvents rbLameDualChannels As System.Windows.Forms.RadioButton
    Private WithEvents rbLameJointStereo As System.Windows.Forms.RadioButton
    Private WithEvents rbLameStandardStereo As System.Windows.Forms.RadioButton
    Private WithEvents groupBox12 As System.Windows.Forms.GroupBox
    Private WithEvents label74 As System.Windows.Forms.Label
    Private WithEvents tbLameVBRQuality As System.Windows.Forms.TrackBar
    Private WithEvents cbLameVBRMax As System.Windows.Forms.ComboBox
    Private WithEvents label75 As System.Windows.Forms.Label
    Private WithEvents label76 As System.Windows.Forms.Label
    Private WithEvents cbLameVBRMin As System.Windows.Forms.ComboBox
    Private WithEvents label77 As System.Windows.Forms.Label
    Private WithEvents label78 As System.Windows.Forms.Label
    Private WithEvents cbLameCBRBitrate As System.Windows.Forms.ComboBox
    Private WithEvents rbLameVBR As System.Windows.Forms.RadioButton
    Private WithEvents rbLameCBR As System.Windows.Forms.RadioButton
    Private WithEvents tabPage18 As System.Windows.Forms.TabPage
    Private WithEvents cbLameVoiceEncodingMode As System.Windows.Forms.CheckBox
    Private WithEvents cbLameModeFixed As System.Windows.Forms.CheckBox
    Private WithEvents cbLameEnableXingVBRTag As System.Windows.Forms.CheckBox
    Private WithEvents cbLameDisableShortBlocks As System.Windows.Forms.CheckBox
    Private WithEvents cbLameStrictISOCompilance As System.Windows.Forms.CheckBox
    Private WithEvents cbLameKeepAllFrequences As System.Windows.Forms.CheckBox
    Private WithEvents cbLameStrictlyEnforceVBRMinBitrate As System.Windows.Forms.CheckBox
    Private WithEvents cbLameForceMono As System.Windows.Forms.CheckBox
    Private WithEvents cbLameCRCProtected As System.Windows.Forms.CheckBox
    Private WithEvents cbLameOriginal As System.Windows.Forms.CheckBox
    Private WithEvents cbLameCopyright As System.Windows.Forms.CheckBox
    Private WithEvents tabPage12 As System.Windows.Forms.TabPage
    Private WithEvents label60 As System.Windows.Forms.Label
    Private WithEvents label61 As System.Windows.Forms.Label
    Private WithEvents cbOGGAverage As System.Windows.Forms.ComboBox
    Private WithEvents label58 As System.Windows.Forms.Label
    Private WithEvents label59 As System.Windows.Forms.Label
    Private WithEvents cbOGGMaximum As System.Windows.Forms.ComboBox
    Private WithEvents label57 As System.Windows.Forms.Label
    Private WithEvents label56 As System.Windows.Forms.Label
    Private WithEvents cbOGGMinimum As System.Windows.Forms.ComboBox
    Private WithEvents rbOGGBitrate As System.Windows.Forms.RadioButton
    Private WithEvents edOGGQuality As System.Windows.Forms.TextBox
    Private WithEvents label55 As System.Windows.Forms.Label
    Private WithEvents rbOGGQuality As System.Windows.Forms.RadioButton
    Private WithEvents tabPage8 As System.Windows.Forms.TabPage
    Private WithEvents btCustomFilewriterSettings As System.Windows.Forms.Button
    Private WithEvents cbCustomFilewriter As System.Windows.Forms.ComboBox
    Private WithEvents cbUseSpecialFilewriter As System.Windows.Forms.CheckBox
    Private WithEvents cbCustomMuxFilterIsEncoder As System.Windows.Forms.CheckBox
    Private WithEvents btCustomMuxerSettings As System.Windows.Forms.Button
    Private WithEvents cbCustomMuxer As System.Windows.Forms.ComboBox
    Private WithEvents label34 As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents btCustomDSFiltersASettings As System.Windows.Forms.Button
    Private WithEvents cbCustomDSFilterA As System.Windows.Forms.ComboBox
    Private WithEvents rbCustomUseDSFiltersCat As System.Windows.Forms.RadioButton
    Private WithEvents btCustomAudioCodecSettings As System.Windows.Forms.Button
    Private WithEvents cbCustomAudioCodec As System.Windows.Forms.ComboBox
    Private WithEvents rbCustomUseAudioCodecsCat As System.Windows.Forms.RadioButton
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btCustomDSFiltersVSettings As System.Windows.Forms.Button
    Private WithEvents cbCustomDSFilterV As System.Windows.Forms.ComboBox
    Private WithEvents rbCustomUseDSFiltersCap As System.Windows.Forms.RadioButton
    Private WithEvents btCustomVideoCodecSettings As System.Windows.Forms.Button
    Private WithEvents cbCustomVideoCodec As System.Windows.Forms.ComboBox
    Private WithEvents rbCustomUseVideoCodecsCat As System.Windows.Forms.RadioButton
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents tabPage31 As System.Windows.Forms.TabPage
    Private WithEvents tabControl17 As System.Windows.Forms.TabControl
    Private WithEvents tabPage68 As System.Windows.Forms.TabPage
    Private WithEvents label201 As System.Windows.Forms.Label
    Private WithEvents label200 As System.Windows.Forms.Label
    Private WithEvents label199 As System.Windows.Forms.Label
    Private WithEvents label198 As System.Windows.Forms.Label
    Private WithEvents tabControl7 As System.Windows.Forms.TabControl
    Private WithEvents tabPage29 As System.Windows.Forms.TabPage
    Private WithEvents btTextLogoUpdateParams As System.Windows.Forms.Button
    Private WithEvents tabControl8 As System.Windows.Forms.TabControl
    Private WithEvents tabPage35 As System.Windows.Forms.TabPage
    Private WithEvents label39 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoBGColor As System.Windows.Forms.Panel
    Private WithEvents label40 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoTranspBG As System.Windows.Forms.CheckBox
    Private WithEvents cbTextLogoRightToLeft As System.Windows.Forms.CheckBox
    Private WithEvents cbTextLogoVertical As System.Windows.Forms.CheckBox
    Private WithEvents cbTextLogoAlign As System.Windows.Forms.ComboBox
    Private WithEvents label41 As System.Windows.Forms.Label
    Private WithEvents tbTextLogoTransp As System.Windows.Forms.TrackBar
    Private WithEvents tabPage36 As System.Windows.Forms.TabPage
    Private WithEvents cbTextLogoGradMode As System.Windows.Forms.ComboBox
    Private WithEvents label107 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoGradColor2 As System.Windows.Forms.Panel
    Private WithEvents label135 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoGradColor1 As System.Windows.Forms.Panel
    Private WithEvents label136 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoGradientEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage37 As System.Windows.Forms.TabPage
    Private WithEvents edTextLogoHeight As System.Windows.Forms.TextBox
    Private WithEvents label137 As System.Windows.Forms.Label
    Private WithEvents edTextLogoWidth As System.Windows.Forms.TextBox
    Private WithEvents label138 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoUseRect As System.Windows.Forms.CheckBox
    Private WithEvents edTextLogoTop As System.Windows.Forms.TextBox
    Private WithEvents label139 As System.Windows.Forms.Label
    Private WithEvents edTextLogoLeft As System.Windows.Forms.TextBox
    Private WithEvents label140 As System.Windows.Forms.Label
    Private WithEvents tabPage38 As System.Windows.Forms.TabPage
    Private WithEvents cbTextLogoDrawMode As System.Windows.Forms.ComboBox
    Private WithEvents cbTextLogoAntialiasing As System.Windows.Forms.ComboBox
    Private WithEvents label141 As System.Windows.Forms.Label
    Private WithEvents label142 As System.Windows.Forms.Label
    Private WithEvents tabPage39 As System.Windows.Forms.TabPage
    Private WithEvents edTextLogoOuterSize As System.Windows.Forms.TextBox
    Private WithEvents label143 As System.Windows.Forms.Label
    Private WithEvents edTextLogoInnerSize As System.Windows.Forms.TextBox
    Private WithEvents label144 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoOuterColor As System.Windows.Forms.Panel
    Private WithEvents label145 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoInnerColor As System.Windows.Forms.Panel
    Private WithEvents label146 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoEffectrMode As System.Windows.Forms.ComboBox
    Private WithEvents label147 As System.Windows.Forms.Label
    Private WithEvents tabPage40 As System.Windows.Forms.TabPage
    Private WithEvents groupBox16 As System.Windows.Forms.GroupBox
    Private WithEvents rbTextLogoFlipXY As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoFlipY As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoFlipX As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoFlipNone As System.Windows.Forms.RadioButton
    Private WithEvents groupBox17 As System.Windows.Forms.GroupBox
    Private WithEvents rbTextLogoDegree270 As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoDegree180 As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoDegree90 As System.Windows.Forms.RadioButton
    Private WithEvents rbTextLogoDegree0 As System.Windows.Forms.RadioButton
    Private WithEvents tabPage41 As System.Windows.Forms.TabPage
    Private WithEvents edTextLogoShapeHeight As System.Windows.Forms.TextBox
    Private WithEvents label148 As System.Windows.Forms.Label
    Private WithEvents edTextLogoShapeWidth As System.Windows.Forms.TextBox
    Private WithEvents label149 As System.Windows.Forms.Label
    Private WithEvents edTextLogoShapeTop As System.Windows.Forms.TextBox
    Private WithEvents label150 As System.Windows.Forms.Label
    Private WithEvents edTextLogoShapeLeft As System.Windows.Forms.TextBox
    Private WithEvents label151 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoShapeType As System.Windows.Forms.ComboBox
    Private WithEvents label152 As System.Windows.Forms.Label
    Private WithEvents pnTextLogoShapeColor As System.Windows.Forms.Panel
    Private WithEvents label153 As System.Windows.Forms.Label
    Private WithEvents cbTextLogoShapeEnabled As System.Windows.Forms.CheckBox
    Private WithEvents btFont As System.Windows.Forms.Button
    Private WithEvents edTextLogo As System.Windows.Forms.TextBox
    Private WithEvents cbTextLogo As System.Windows.Forms.CheckBox
    Private WithEvents tabPage42 As System.Windows.Forms.TabPage
    Private WithEvents pnImageLogoColorKey As System.Windows.Forms.Panel
    Private WithEvents cbImageLogoUseColorKey As System.Windows.Forms.CheckBox
    Private WithEvents label154 As System.Windows.Forms.Label
    Private WithEvents tbImageLogoTransp As System.Windows.Forms.TrackBar
    Private WithEvents groupBox22 As System.Windows.Forms.GroupBox
    Private WithEvents cbImageLogoShowAlways As System.Windows.Forms.CheckBox
    Private WithEvents edImageLogoStopTime As System.Windows.Forms.TextBox
    Private WithEvents lbGraphicLogoStopTime As System.Windows.Forms.Label
    Private WithEvents edImageLogoStartTime As System.Windows.Forms.TextBox
    Private WithEvents lbGraphicLogoStartTime As System.Windows.Forms.Label
    Private WithEvents groupBox23 As System.Windows.Forms.GroupBox
    Private WithEvents edImageLogoTop As System.Windows.Forms.TextBox
    Private WithEvents label155 As System.Windows.Forms.Label
    Private WithEvents edImageLogoLeft As System.Windows.Forms.TextBox
    Private WithEvents label156 As System.Windows.Forms.Label
    Private WithEvents btSelectImage As System.Windows.Forms.Button
    Private WithEvents label157 As System.Windows.Forms.Label
    Private WithEvents edImageLogoFilename As System.Windows.Forms.TextBox
    Private WithEvents cbImageLogo As System.Windows.Forms.CheckBox
    Private WithEvents tbContrast As System.Windows.Forms.TrackBar
    Private WithEvents tbDarkness As System.Windows.Forms.TrackBar
    Private WithEvents tbLightness As System.Windows.Forms.TrackBar
    Private WithEvents tbSaturation As System.Windows.Forms.TrackBar
    Private WithEvents cbInvert As System.Windows.Forms.CheckBox
    Private WithEvents cbGreyscale As System.Windows.Forms.CheckBox
    Private WithEvents cbEffects As System.Windows.Forms.CheckBox
    Private WithEvents tabPage69 As System.Windows.Forms.TabPage
    Private WithEvents label211 As System.Windows.Forms.Label
    Private WithEvents edDeintTriangleWeight As System.Windows.Forms.TextBox
    Private WithEvents label212 As System.Windows.Forms.Label
    Private WithEvents label210 As System.Windows.Forms.Label
    Private WithEvents label209 As System.Windows.Forms.Label
    Private WithEvents label206 As System.Windows.Forms.Label
    Private WithEvents edDeintBlendConstants2 As System.Windows.Forms.TextBox
    Private WithEvents label207 As System.Windows.Forms.Label
    Private WithEvents edDeintBlendConstants1 As System.Windows.Forms.TextBox
    Private WithEvents label208 As System.Windows.Forms.Label
    Private WithEvents label204 As System.Windows.Forms.Label
    Private WithEvents edDeintBlendThreshold2 As System.Windows.Forms.TextBox
    Private WithEvents label205 As System.Windows.Forms.Label
    Private WithEvents edDeintBlendThreshold1 As System.Windows.Forms.TextBox
    Private WithEvents label203 As System.Windows.Forms.Label
    Private WithEvents label202 As System.Windows.Forms.Label
    Private WithEvents edDeintCAVTThreshold As System.Windows.Forms.TextBox
    Private WithEvents label104 As System.Windows.Forms.Label
    Private WithEvents rbDeintTriangleEnabled As System.Windows.Forms.RadioButton
    Private WithEvents rbDeintBlendEnabled As System.Windows.Forms.RadioButton
    Private WithEvents rbDeintCAVTEnabled As System.Windows.Forms.RadioButton
    Private WithEvents cbDeinterlace As System.Windows.Forms.CheckBox
    Private WithEvents tabPage59 As System.Windows.Forms.TabPage
    Private WithEvents rbDenoiseCAST As System.Windows.Forms.RadioButton
    Private WithEvents rbDenoiseMosquito As System.Windows.Forms.RadioButton
    Private WithEvents cbDenoise As System.Windows.Forms.CheckBox
    Private WithEvents tabPage70 As System.Windows.Forms.TabPage
    Private WithEvents btFilterDeleteAll As System.Windows.Forms.Button
    Private WithEvents btFilterSettings2 As System.Windows.Forms.Button
    Private WithEvents lbFilters As System.Windows.Forms.ListBox
    Private WithEvents label106 As System.Windows.Forms.Label
    Private WithEvents btFilterSettings As System.Windows.Forms.Button
    Private WithEvents btFilterAdd As System.Windows.Forms.Button
    Private WithEvents cbFilters As System.Windows.Forms.ComboBox
    Private WithEvents label105 As System.Windows.Forms.Label
    Private WithEvents tabPage9 As System.Windows.Forms.TabPage
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents label47 As System.Windows.Forms.Label
    Private WithEvents edTransStopTime As System.Windows.Forms.TextBox
    Private WithEvents label48 As System.Windows.Forms.Label
    Private WithEvents label46 As System.Windows.Forms.Label
    Private WithEvents edTransStartTime As System.Windows.Forms.TextBox
    Private WithEvents label45 As System.Windows.Forms.Label
    Private WithEvents btAddTransition As System.Windows.Forms.Button
    Private WithEvents cbTransitionName As System.Windows.Forms.ComboBox
    Private WithEvents label44 As System.Windows.Forms.Label
    Private WithEvents lbTransitions As System.Windows.Forms.ListBox
    Private WithEvents label43 As System.Windows.Forms.Label
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents tabControl18 As System.Windows.Forms.TabControl
    Private WithEvents tabPage71 As System.Windows.Forms.TabPage
    Private WithEvents label231 As System.Windows.Forms.Label
    Private WithEvents label230 As System.Windows.Forms.Label
    Private WithEvents tbAudAmplifyAmp As System.Windows.Forms.TrackBar
    Private WithEvents label95 As System.Windows.Forms.Label
    Private WithEvents cbAudAmplifyEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage72 As System.Windows.Forms.TabPage
    Private WithEvents btAudEqRefresh As System.Windows.Forms.Button
    Private WithEvents cbAudEqualizerPreset As System.Windows.Forms.ComboBox
    Private WithEvents label243 As System.Windows.Forms.Label
    Private WithEvents label242 As System.Windows.Forms.Label
    Private WithEvents label241 As System.Windows.Forms.Label
    Private WithEvents label240 As System.Windows.Forms.Label
    Private WithEvents label239 As System.Windows.Forms.Label
    Private WithEvents label238 As System.Windows.Forms.Label
    Private WithEvents label237 As System.Windows.Forms.Label
    Private WithEvents label236 As System.Windows.Forms.Label
    Private WithEvents label235 As System.Windows.Forms.Label
    Private WithEvents label234 As System.Windows.Forms.Label
    Private WithEvents label233 As System.Windows.Forms.Label
    Private WithEvents label232 As System.Windows.Forms.Label
    Private WithEvents tbAudEq9 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq8 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq7 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq6 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq5 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq4 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq3 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq2 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq1 As System.Windows.Forms.TrackBar
    Private WithEvents tbAudEq0 As System.Windows.Forms.TrackBar
    Private WithEvents cbAudEqualizerEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage73 As System.Windows.Forms.TabPage
    Private WithEvents tbAudRelease As System.Windows.Forms.TrackBar
    Private WithEvents label248 As System.Windows.Forms.Label
    Private WithEvents label249 As System.Windows.Forms.Label
    Private WithEvents label246 As System.Windows.Forms.Label
    Private WithEvents tbAudAttack As System.Windows.Forms.TrackBar
    Private WithEvents label247 As System.Windows.Forms.Label
    Private WithEvents label244 As System.Windows.Forms.Label
    Private WithEvents tbAudDynAmp As System.Windows.Forms.TrackBar
    Private WithEvents label245 As System.Windows.Forms.Label
    Private WithEvents cbAudDynamicAmplifyEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage75 As System.Windows.Forms.TabPage
    Private WithEvents tbAud3DSound As System.Windows.Forms.TrackBar
    Private WithEvents label253 As System.Windows.Forms.Label
    Private WithEvents cbAudSound3DEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage76 As System.Windows.Forms.TabPage
    Private WithEvents tbAudTrueBass As System.Windows.Forms.TrackBar
    Private WithEvents label254 As System.Windows.Forms.Label
    Private WithEvents cbAudTrueBassEnabled As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioEffectsEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents btStop As System.Windows.Forms.Button
    Private WithEvents btStart As System.Windows.Forms.Button
    Private WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents tbSeeking As System.Windows.Forms.TrackBar
    Private WithEvents openFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VideoEdit1 As VisioForge.Controls.UI.WinForms.VideoEdit
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Private WithEvents tabControl16 As System.Windows.Forms.TabControl
    Private WithEvents tabPage62 As System.Windows.Forms.TabPage
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents tabPage64 As System.Windows.Forms.TabPage
    Private WithEvents cbFFVideoInterlace As System.Windows.Forms.CheckBox
    Private WithEvents edFFVideoBitrateMax As System.Windows.Forms.TextBox
    Private WithEvents label218 As System.Windows.Forms.Label
    Private WithEvents edFFVBVBufferSize As System.Windows.Forms.TextBox
    Private WithEvents label224 As System.Windows.Forms.Label
    Private WithEvents label225 As System.Windows.Forms.Label
    Private WithEvents edFFVideoBitrateMin As System.Windows.Forms.TextBox
    Private WithEvents label226 As System.Windows.Forms.Label
    Private WithEvents label227 As System.Windows.Forms.Label
    Private WithEvents edFFTargetBitrate As System.Windows.Forms.TextBox
    Private WithEvents label228 As System.Windows.Forms.Label
    Private WithEvents cbFFConstaint As System.Windows.Forms.ComboBox
    Private WithEvents label255 As System.Windows.Forms.Label
    Private WithEvents cbFFAspectRatio As System.Windows.Forms.ComboBox
    Private WithEvents label257 As System.Windows.Forms.Label
    Private WithEvents edFFVideoHeight As System.Windows.Forms.TextBox
    Private WithEvents label258 As System.Windows.Forms.Label
    Private WithEvents edFFVideoWidth As System.Windows.Forms.TextBox
    Private WithEvents label259 As System.Windows.Forms.Label
    Private WithEvents tabPage65 As System.Windows.Forms.TabPage
    Private WithEvents label261 As System.Windows.Forms.Label
    Private WithEvents label262 As System.Windows.Forms.Label
    Private WithEvents cbFFAudioBitrate As System.Windows.Forms.ComboBox
    Private WithEvents label263 As System.Windows.Forms.Label
    Private WithEvents cbFFAudioChannels As System.Windows.Forms.ComboBox
    Private WithEvents label264 As System.Windows.Forms.Label
    Private WithEvents cbFFAudioSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents label265 As System.Windows.Forms.Label
    Private WithEvents cbFFOutputFormat As System.Windows.Forms.ComboBox
    Private WithEvents label267 As System.Windows.Forms.Label
    Friend WithEvents TabPage20 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage21 As System.Windows.Forms.TabPage
    Private WithEvents tabControl15 As System.Windows.Forms.TabControl
    Private WithEvents TabPage26 As System.Windows.Forms.TabPage
    Private WithEvents label64 As System.Windows.Forms.Label
    Private WithEvents label65 As System.Windows.Forms.Label
    Private WithEvents pbAFMotionLevel As System.Windows.Forms.ProgressBar
    Private WithEvents cbAFMotionHighlight As System.Windows.Forms.CheckBox
    Private WithEvents cbAFMotionDetection As System.Windows.Forms.CheckBox
    Private WithEvents TabPage27 As System.Windows.Forms.TabPage
    Private WithEvents label171 As System.Windows.Forms.Label
    Private WithEvents label66 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents btChromaKeySelectBGImage As System.Windows.Forms.Button
    Private WithEvents edChromaKeyImage As System.Windows.Forms.TextBox
    Private WithEvents label216 As System.Windows.Forms.Label
    Private WithEvents rbChromaKeyRed As System.Windows.Forms.RadioButton
    Private WithEvents rbChromaKeyBlue As System.Windows.Forms.RadioButton
    Private WithEvents rbChromaKeyGreen As System.Windows.Forms.RadioButton
    Private WithEvents label215 As System.Windows.Forms.Label
    Private WithEvents tbChromaKeyContrastHigh As System.Windows.Forms.TrackBar
    Private WithEvents label214 As System.Windows.Forms.Label
    Private WithEvents tbChromaKeyContrastLow As System.Windows.Forms.TrackBar
    Private WithEvents label213 As System.Windows.Forms.Label
    Private WithEvents cbChromaKeyEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage28 As System.Windows.Forms.TabPage
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents tabControl9 As System.Windows.Forms.TabControl
    Private WithEvents tabPage44 As System.Windows.Forms.TabPage
    Private WithEvents pbMotionLevel As System.Windows.Forms.ProgressBar
    Private WithEvents label158 As System.Windows.Forms.Label
    Private WithEvents mmMotDetMatrix As System.Windows.Forms.TextBox
    Private WithEvents tabPage45 As System.Windows.Forms.TabPage
    Private WithEvents groupBox25 As System.Windows.Forms.GroupBox
    Private WithEvents cbMotDetHLColor As System.Windows.Forms.ComboBox
    Private WithEvents label161 As System.Windows.Forms.Label
    Private WithEvents label160 As System.Windows.Forms.Label
    Private WithEvents cbMotDetHLEnabled As System.Windows.Forms.CheckBox
    Private WithEvents tbMotDetHLThreshold As System.Windows.Forms.TrackBar
    Private WithEvents btMotDetUpdateSettings As System.Windows.Forms.Button
    Private WithEvents groupBox27 As System.Windows.Forms.GroupBox
    Private WithEvents edMotDetMatrixHeight As System.Windows.Forms.TextBox
    Private WithEvents label163 As System.Windows.Forms.Label
    Private WithEvents edMotDetMatrixWidth As System.Windows.Forms.TextBox
    Private WithEvents label164 As System.Windows.Forms.Label
    Private WithEvents groupBox26 As System.Windows.Forms.GroupBox
    Private WithEvents label162 As System.Windows.Forms.Label
    Private WithEvents tbMotDetDropFramesThreshold As System.Windows.Forms.TrackBar
    Private WithEvents cbMotDetDropFramesEnabled As System.Windows.Forms.CheckBox
    Private WithEvents groupBox24 As System.Windows.Forms.GroupBox
    Private WithEvents edMotDetFrameInterval As System.Windows.Forms.TextBox
    Private WithEvents label159 As System.Windows.Forms.Label
    Private WithEvents cbCompareGreyscale As System.Windows.Forms.CheckBox
    Private WithEvents cbCompareBlue As System.Windows.Forms.CheckBox
    Private WithEvents cbCompareGreen As System.Windows.Forms.CheckBox
    Private WithEvents cbCompareRed As System.Windows.Forms.CheckBox
    Private WithEvents cbMotDetEnabled As System.Windows.Forms.CheckBox
    Private WithEvents cbTextLogoDateTime As System.Windows.Forms.CheckBox
    Private WithEvents label92 As System.Windows.Forms.Label
    Private WithEvents cbRotate As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Private WithEvents groupBox37 As System.Windows.Forms.GroupBox
    Private WithEvents btEffZoomRight As System.Windows.Forms.Button
    Private WithEvents btEffZoomLeft As System.Windows.Forms.Button
    Private WithEvents btEffZoomOut As System.Windows.Forms.Button
    Private WithEvents btEffZoomIn As System.Windows.Forms.Button
    Private WithEvents btEffZoomDown As System.Windows.Forms.Button
    Private WithEvents btEffZoomUp As System.Windows.Forms.Button
    Private WithEvents cbZoom As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage16 As System.Windows.Forms.TabPage
    Private WithEvents groupBox40 As System.Windows.Forms.GroupBox
    Private WithEvents edPanDestHeight As System.Windows.Forms.TextBox
    Private WithEvents label302 As System.Windows.Forms.Label
    Private WithEvents edPanDestWidth As System.Windows.Forms.TextBox
    Private WithEvents label303 As System.Windows.Forms.Label
    Private WithEvents edPanDestTop As System.Windows.Forms.TextBox
    Private WithEvents label304 As System.Windows.Forms.Label
    Private WithEvents edPanDestLeft As System.Windows.Forms.TextBox
    Private WithEvents label305 As System.Windows.Forms.Label
    Private WithEvents groupBox39 As System.Windows.Forms.GroupBox
    Private WithEvents edPanSourceHeight As System.Windows.Forms.TextBox
    Private WithEvents label298 As System.Windows.Forms.Label
    Private WithEvents edPanSourceWidth As System.Windows.Forms.TextBox
    Private WithEvents label299 As System.Windows.Forms.Label
    Private WithEvents edPanSourceTop As System.Windows.Forms.TextBox
    Private WithEvents label300 As System.Windows.Forms.Label
    Private WithEvents edPanSourceLeft As System.Windows.Forms.TextBox
    Private WithEvents label301 As System.Windows.Forms.Label
    Private WithEvents groupBox38 As System.Windows.Forms.GroupBox
    Private WithEvents edPanStopTime As System.Windows.Forms.TextBox
    Private WithEvents label296 As System.Windows.Forms.Label
    Private WithEvents edPanStartTime As System.Windows.Forms.TextBox
    Private WithEvents label297 As System.Windows.Forms.Label
    Private WithEvents cbPan As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage23 As System.Windows.Forms.TabPage
    Private WithEvents edBarcodeMetadata As System.Windows.Forms.TextBox
    Private WithEvents label91 As System.Windows.Forms.Label
    Private WithEvents cbBarcodeType As System.Windows.Forms.ComboBox
    Private WithEvents label90 As System.Windows.Forms.Label
    Private WithEvents btBarcodeReset As System.Windows.Forms.Button
    Private WithEvents edBarcode As System.Windows.Forms.TextBox
    Private WithEvents label89 As System.Windows.Forms.Label
    Private WithEvents cbBarcodeDetectionEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage24 As System.Windows.Forms.TabPage
    Private WithEvents tabControl5 As System.Windows.Forms.TabControl
    Private WithEvents TabPage25 As System.Windows.Forms.TabPage
    Private WithEvents edWMVNetworkPort As System.Windows.Forms.TextBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents btRefreshClients As System.Windows.Forms.Button
    Private WithEvents lbNetworkClients As System.Windows.Forms.ListBox
    Private WithEvents rbNetworkStreamingUseExternalProfile As System.Windows.Forms.RadioButton
    Private WithEvents rbNetworkStreamingUseMainWMVSettings As System.Windows.Forms.RadioButton
    Private WithEvents label81 As System.Windows.Forms.Label
    Private WithEvents label80 As System.Windows.Forms.Label
    Private WithEvents edMaximumClients As System.Windows.Forms.TextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents btSelectWMVProfileNetwork As System.Windows.Forms.Button
    Private WithEvents edNetworkStreamingWMVProfile As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents TabPage56 As System.Windows.Forms.TabPage
    Private WithEvents cbNetworkStreamingAudioEnabled As System.Windows.Forms.CheckBox
    Private WithEvents cbNetworkStreaming As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage32 As System.Windows.Forms.TabPage
    Private WithEvents label326 As System.Windows.Forms.Label
    Private WithEvents label325 As System.Windows.Forms.Label
    Private WithEvents cbVirtualCamera As System.Windows.Forms.CheckBox
    Private WithEvents label328 As System.Windows.Forms.Label
    Private WithEvents label327 As System.Windows.Forms.Label
    Friend WithEvents TabPage33 As System.Windows.Forms.TabPage
    Private WithEvents rbFadeOut As System.Windows.Forms.RadioButton
    Private WithEvents rbFadeIn As System.Windows.Forms.RadioButton
    Private WithEvents groupBox45 As System.Windows.Forms.GroupBox
    Private WithEvents edFadeInOutStopTime As System.Windows.Forms.TextBox
    Private WithEvents label329 As System.Windows.Forms.Label
    Private WithEvents edFadeInOutStartTime As System.Windows.Forms.TextBox
    Private WithEvents label330 As System.Windows.Forms.Label
    Private WithEvents cbFadeInOut As System.Windows.Forms.CheckBox
    Private WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage34 As System.Windows.Forms.TabPage
    Private WithEvents cbDecklinkDV As System.Windows.Forms.CheckBox
    Private WithEvents cbDecklinkOutput As System.Windows.Forms.CheckBox
    Private WithEvents cbDecklinkOutputDownConversionAnalogOutput As System.Windows.Forms.CheckBox
    Private WithEvents cbDecklinkOutputDownConversion As System.Windows.Forms.ComboBox
    Private WithEvents label337 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputHDTVPulldown As System.Windows.Forms.ComboBox
    Private WithEvents label336 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputBlackToDeck As System.Windows.Forms.ComboBox
    Private WithEvents label335 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputSingleField As System.Windows.Forms.ComboBox
    Private WithEvents label334 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputComponentLevels As System.Windows.Forms.ComboBox
    Private WithEvents label333 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputNTSC As System.Windows.Forms.ComboBox
    Private WithEvents label332 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputDualLink As System.Windows.Forms.ComboBox
    Private WithEvents label331 As System.Windows.Forms.Label
    Private WithEvents cbDecklinkOutputAnalog As System.Windows.Forms.ComboBox
    Private WithEvents label87 As System.Windows.Forms.Label
    Friend WithEvents TabPage43 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage46 As System.Windows.Forms.TabPage
    Private WithEvents tabControl24 As System.Windows.Forms.TabControl
    Private WithEvents tabPage89 As System.Windows.Forms.TabPage
    Private WithEvents groupBox18 As System.Windows.Forms.GroupBox
    Private WithEvents cbH264PictureType As System.Windows.Forms.ComboBox
    Private WithEvents label360 As System.Windows.Forms.Label
    Private WithEvents label347 As System.Windows.Forms.Label
    Private WithEvents edH264P As System.Windows.Forms.TextBox
    Private WithEvents label348 As System.Windows.Forms.Label
    Private WithEvents edH264IDR As System.Windows.Forms.TextBox
    Private WithEvents label349 As System.Windows.Forms.Label
    Private WithEvents cbH264MBEncoding As System.Windows.Forms.ComboBox
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
    Private WithEvents tabPage90 As System.Windows.Forms.TabPage
    Private WithEvents label354 As System.Windows.Forms.Label
    Private WithEvents cbAACOutput As System.Windows.Forms.ComboBox
    Private WithEvents label355 As System.Windows.Forms.Label
    Private WithEvents cbAACBitrate As System.Windows.Forms.ComboBox
    Private WithEvents label356 As System.Windows.Forms.Label
    Private WithEvents cbAACObjectType As System.Windows.Forms.ComboBox
    Private WithEvents label357 As System.Windows.Forms.Label
    Private WithEvents cbAACVersion As System.Windows.Forms.ComboBox
    Private WithEvents label358 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents edNetworkURL As System.Windows.Forms.TextBox
    Friend WithEvents TabPage47 As System.Windows.Forms.TabPage
    Private WithEvents edNetworkRTSPURL As System.Windows.Forms.TextBox
    Private WithEvents label367 As System.Windows.Forms.Label
    Private WithEvents label366 As System.Windows.Forms.Label
    Private WithEvents cbNetworkStreamingMode As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage48 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage49 As System.Windows.Forms.TabPage
    Private WithEvents edNetworkSSURL As System.Windows.Forms.TextBox
    Private WithEvents label370 As System.Windows.Forms.Label
    Private WithEvents label371 As System.Windows.Forms.Label
    Private WithEvents rbNetworkSSSoftware As System.Windows.Forms.RadioButton
    Private WithEvents linkLabel5 As System.Windows.Forms.LinkLabel
    Private WithEvents tabControl3 As System.Windows.Forms.TabControl
    Private WithEvents tabPage52 As System.Windows.Forms.TabPage
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents label72 As System.Windows.Forms.Label
    Private WithEvents edInsertTime As System.Windows.Forms.TextBox
    Private WithEvents label73 As System.Windows.Forms.Label
    Private WithEvents cbInsertAfterPreviousFile As System.Windows.Forms.CheckBox
    Private WithEvents label50 As System.Windows.Forms.Label
    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Private WithEvents lbSpeed As System.Windows.Forms.Label
    Private WithEvents label42 As System.Windows.Forms.Label
    Private WithEvents label37 As System.Windows.Forms.Label
    Private WithEvents edStopTime As System.Windows.Forms.TextBox
    Private WithEvents label38 As System.Windows.Forms.Label
    Private WithEvents label36 As System.Windows.Forms.Label
    Private WithEvents edStartTime As System.Windows.Forms.TextBox
    Private WithEvents label35 As System.Windows.Forms.Label
    Private WithEvents cbAddFullFile As System.Windows.Forms.CheckBox
    Private WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Private WithEvents btClearList As System.Windows.Forms.Button
    Private WithEvents btAddInputFile As System.Windows.Forms.Button
    Private WithEvents lbFiles As System.Windows.Forms.ListBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents tabPage53 As System.Windows.Forms.TabPage
    Private WithEvents tabPage54 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage50 As System.Windows.Forms.TabPage
    Private WithEvents rbMP4Modern As System.Windows.Forms.RadioButton
    Private WithEvents rbMP4Legacy As System.Windows.Forms.RadioButton
    Private WithEvents label380 As System.Windows.Forms.Label
    Private WithEvents label379 As System.Windows.Forms.Label
    Private WithEvents label378 As System.Windows.Forms.Label
    Private WithEvents label377 As System.Windows.Forms.Label
    Private WithEvents label393 As System.Windows.Forms.Label
    Private WithEvents cbDirect2DRotate As System.Windows.Forms.ComboBox
    Private WithEvents pnVideoRendererBGColor As System.Windows.Forms.Panel
    Private WithEvents label394 As System.Windows.Forms.Label
    Private WithEvents btFullScreen As System.Windows.Forms.Button
    Private WithEvents cbScreenFlipVertical As System.Windows.Forms.CheckBox
    Private WithEvents cbScreenFlipHorizontal As System.Windows.Forms.CheckBox
    Private WithEvents cbStretch As System.Windows.Forms.CheckBox
    Private WithEvents groupBox13 As System.Windows.Forms.GroupBox
    Private WithEvents rbDirect2D As System.Windows.Forms.RadioButton
    Private WithEvents rbNone As System.Windows.Forms.RadioButton
    Private WithEvents rbEVR As System.Windows.Forms.RadioButton
    Private WithEvents rbVMR9 As System.Windows.Forms.RadioButton
    Private WithEvents rbVR As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage51 As System.Windows.Forms.TabPage
    Private WithEvents cbFLACExhaustiveModelSearch As System.Windows.Forms.CheckBox
    Private WithEvents cbFLACAdaptiveMidSideCoding As System.Windows.Forms.CheckBox
    Private WithEvents cbFLACMidSideCoding As System.Windows.Forms.CheckBox
    Private WithEvents edFLACRiceMax As System.Windows.Forms.TextBox
    Private WithEvents label401 As System.Windows.Forms.Label
    Private WithEvents edFLACRiceMin As System.Windows.Forms.TextBox
    Private WithEvents label400 As System.Windows.Forms.Label
    Private WithEvents label399 As System.Windows.Forms.Label
    Private WithEvents tbFLACLPCOrder As System.Windows.Forms.TrackBar
    Private WithEvents cbFLACBlockSize As System.Windows.Forms.ComboBox
    Private WithEvents label398 As System.Windows.Forms.Label
    Private WithEvents label397 As System.Windows.Forms.Label
    Private WithEvents label396 As System.Windows.Forms.Label
    Private WithEvents label395 As System.Windows.Forms.Label
    Private WithEvents tbFLACLevel As System.Windows.Forms.TrackBar
    Friend WithEvents TabPage55 As System.Windows.Forms.TabPage
    Private WithEvents cbSpeexDenoise As System.Windows.Forms.CheckBox
    Private WithEvents cbSpeexAGC As System.Windows.Forms.CheckBox
    Private WithEvents cbSpeexVAD As System.Windows.Forms.CheckBox
    Private WithEvents cbSpeexDTX As System.Windows.Forms.CheckBox
    Private WithEvents tbSpeexComplexity As System.Windows.Forms.TrackBar
    Private WithEvents label54 As System.Windows.Forms.Label
    Private WithEvents tbSpeexMaxBitrate As System.Windows.Forms.TrackBar
    Private WithEvents label53 As System.Windows.Forms.Label
    Private WithEvents tbSpeexBitrate As System.Windows.Forms.TrackBar
    Private WithEvents label52 As System.Windows.Forms.Label
    Private WithEvents tbSpeexQuality As System.Windows.Forms.TrackBar
    Private WithEvents label51 As System.Windows.Forms.Label
    Private WithEvents cbSpeexBitrateControl As System.Windows.Forms.ComboBox
    Private WithEvents label49 As System.Windows.Forms.Label
    Private WithEvents cbSpeexMode As System.Windows.Forms.ComboBox
    Private WithEvents label33 As System.Windows.Forms.Label
    Private WithEvents tabControl6 As System.Windows.Forms.TabControl
    Private WithEvents tabPage58 As System.Windows.Forms.TabPage
    Private WithEvents cbWebMVideoKeyframeMode As System.Windows.Forms.ComboBox
    Private WithEvents label113 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoKeyframeMaxInterval As System.Windows.Forms.TextBox
    Private WithEvents label100 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoKeyframeMinInterval As System.Windows.Forms.TextBox
    Private WithEvents label99 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoMaxQuantizer As System.Windows.Forms.TextBox
    Private WithEvents label88 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoMinQuantizer As System.Windows.Forms.TextBox
    Private WithEvents label86 As System.Windows.Forms.Label
    Private WithEvents label79 As System.Windows.Forms.Label
    Private WithEvents cbWebMVideoEncoder As System.Windows.Forms.ComboBox
    Private WithEvents cbWebMVideoQualityMode As System.Windows.Forms.ComboBox
    Private WithEvents label63 As System.Windows.Forms.Label
    Private WithEvents label179 As System.Windows.Forms.Label
    Private WithEvents cbWebMVideoEndUsageMode As System.Windows.Forms.ComboBox
    Private WithEvents label178 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoThreadCount As System.Windows.Forms.TextBox
    Private WithEvents label173 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoBitrate As System.Windows.Forms.TextBox
    Private WithEvents label172 As System.Windows.Forms.Label
    Private WithEvents tabPage60 As System.Windows.Forms.TabPage
    Private WithEvents tbWebMAudioQuality As System.Windows.Forms.TrackBar
    Private WithEvents label223 As System.Windows.Forms.Label
    Private WithEvents tabPage61 As System.Windows.Forms.TabPage
    Private WithEvents cbWebMVideoAutoAltRef As System.Windows.Forms.CheckBox
    Private WithEvents label98 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoDecoderOptimalBuffer As System.Windows.Forms.TextBox
    Private WithEvents label97 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoDecoderInitialBuffer As System.Windows.Forms.TextBox
    Private WithEvents label96 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoDecoderBufferSize As System.Windows.Forms.TextBox
    Private WithEvents edWebMVideoOvershootPct As System.Windows.Forms.TextBox
    Private WithEvents label94 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoUndershootPct As System.Windows.Forms.TextBox
    Private WithEvents label93 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoLagInFrames As System.Windows.Forms.TextBox
    Private WithEvents label85 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoSpatialDownThreshold As System.Windows.Forms.TextBox
    Private WithEvents label84 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoSpatialUpThreshold As System.Windows.Forms.TextBox
    Private WithEvents label83 As System.Windows.Forms.Label
    Private WithEvents cbWebMVideoSpatialResamplingAllowed As System.Windows.Forms.CheckBox
    Private WithEvents edWebMVideoDropFrameThreshold As System.Windows.Forms.TextBox
    Private WithEvents label82 As System.Windows.Forms.Label
    Private WithEvents cbWebMVideoErrorResilent As System.Windows.Forms.CheckBox
    Private WithEvents tabPage63 As System.Windows.Forms.TabPage
    Private WithEvents label112 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoTokenPartition As System.Windows.Forms.TextBox
    Private WithEvents label111 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoDecimate As System.Windows.Forms.TextBox
    Private WithEvents label110 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoStaticThreshold As System.Windows.Forms.TextBox
    Private WithEvents edWebMVideoCPUUsed As System.Windows.Forms.TextBox
    Private WithEvents label109 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoFixedKeyframeInterval As System.Windows.Forms.TextBox
    Private WithEvents label108 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoARNRType As System.Windows.Forms.TextBox
    Private WithEvents label103 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoARNRStrenght As System.Windows.Forms.TextBox
    Private WithEvents label102 As System.Windows.Forms.Label
    Private WithEvents edWebMVideoARNRMaxFrames As System.Windows.Forms.TextBox
    Private WithEvents label101 As System.Windows.Forms.Label
    Friend WithEvents TabPage57 As System.Windows.Forms.TabPage
    Private WithEvents lbAudioTimeshift As System.Windows.Forms.Label
    Private WithEvents tbAudioTimeshift As System.Windows.Forms.TrackBar
    Private WithEvents label115 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lbAudioOutputGainLFE As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainLFE As System.Windows.Forms.TrackBar
    Private WithEvents label116 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainSR As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainSR As System.Windows.Forms.TrackBar
    Private WithEvents label117 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainSL As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainSL As System.Windows.Forms.TrackBar
    Private WithEvents label118 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainR As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainR As System.Windows.Forms.TrackBar
    Private WithEvents label119 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainC As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainC As System.Windows.Forms.TrackBar
    Private WithEvents label121 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainL As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainL As System.Windows.Forms.TrackBar
    Private WithEvents label122 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents lbAudioInputGainLFE As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainLFE As System.Windows.Forms.TrackBar
    Private WithEvents label123 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainSR As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainSR As System.Windows.Forms.TrackBar
    Private WithEvents label124 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainSL As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainSL As System.Windows.Forms.TrackBar
    Private WithEvents label125 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainR As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainR As System.Windows.Forms.TrackBar
    Private WithEvents label126 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainC As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainC As System.Windows.Forms.TrackBar
    Private WithEvents label127 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainL As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainL As System.Windows.Forms.TrackBar
    Private WithEvents label128 As System.Windows.Forms.Label
    Private WithEvents cbAudioAutoGain As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioNormalize As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioEnhancementEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents btTest As System.Windows.Forms.Button
    Friend WithEvents TabPage66 As System.Windows.Forms.TabPage
    Private WithEvents tabControl29 As System.Windows.Forms.TabControl
    Private WithEvents tabPage129 As System.Windows.Forms.TabPage
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents tabPage132 As System.Windows.Forms.TabPage
    Private WithEvents label468 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEOutputFormat As System.Windows.Forms.ComboBox
    Private WithEvents tabPage130 As System.Windows.Forms.TabPage
    Private WithEvents tabControl30 As System.Windows.Forms.TabControl
    Private WithEvents tabPage134 As System.Windows.Forms.TabPage
    Private WithEvents cbFFEXEVideoConstraint As System.Windows.Forms.ComboBox
    Private WithEvents label482 As System.Windows.Forms.Label
    Private WithEvents lbFFEXEVideoNotes As System.Windows.Forms.Label
    Private WithEvents cbFFEXEVideoResolutionLetterbox As System.Windows.Forms.CheckBox
    Private WithEvents label469 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEVideoCodec As System.Windows.Forms.ComboBox
    Private WithEvents cbFFEXEVideoResolutionOriginal As System.Windows.Forms.CheckBox
    Private WithEvents cbFFEXEAspectRatio As System.Windows.Forms.ComboBox
    Private WithEvents label459 As System.Windows.Forms.Label
    Private WithEvents edFFEXEVideoHeight As System.Windows.Forms.TextBox
    Private WithEvents label460 As System.Windows.Forms.Label
    Private WithEvents edFFEXEVideoWidth As System.Windows.Forms.TextBox
    Private WithEvents label461 As System.Windows.Forms.Label
    Private WithEvents tabPage137 As System.Windows.Forms.TabPage
    Private WithEvents lbFFEXEVideoQuality As System.Windows.Forms.Label
    Private WithEvents tbFFEXEVideoQuality As System.Windows.Forms.TrackBar
    Private WithEvents label481 As System.Windows.Forms.Label
    Private WithEvents rbFFEXEVideoModeQuality As System.Windows.Forms.RadioButton
    Private WithEvents rbFFEXEVideoModeABR As System.Windows.Forms.RadioButton
    Private WithEvents rbFFEXEVideoModeCBR As System.Windows.Forms.RadioButton
    Private WithEvents edFFEXEVideoBitrateMax As System.Windows.Forms.TextBox
    Private WithEvents label452 As System.Windows.Forms.Label
    Private WithEvents label454 As System.Windows.Forms.Label
    Private WithEvents edFFEXEVideoBitrateMin As System.Windows.Forms.TextBox
    Private WithEvents label455 As System.Windows.Forms.Label
    Private WithEvents label456 As System.Windows.Forms.Label
    Private WithEvents edFFEXEVideoTargetBitrate As System.Windows.Forms.TextBox
    Private WithEvents label457 As System.Windows.Forms.Label
    Private WithEvents tabPage136 As System.Windows.Forms.TabPage
    Private WithEvents edFFEXEVideoBFramesCount As System.Windows.Forms.TextBox
    Private WithEvents label479 As System.Windows.Forms.Label
    Private WithEvents edFFEXEVideoGOPSize As System.Windows.Forms.TextBox
    Private WithEvents label478 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEVideoInterlace As System.Windows.Forms.CheckBox
    Private WithEvents edFFEXEVBVBufferSize As System.Windows.Forms.TextBox
    Private WithEvents label453 As System.Windows.Forms.Label
    Private WithEvents tabPage135 As System.Windows.Forms.TabPage
    Private WithEvents label483 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEH264WebFastStart As System.Windows.Forms.CheckBox
    Private WithEvents cbFFEXEH264ZeroTolerance As System.Windows.Forms.CheckBox
    Private WithEvents cbFFEXEH264QuickTimeCompatibility As System.Windows.Forms.CheckBox
    Private WithEvents cbFFEXEH264Level As System.Windows.Forms.ComboBox
    Private WithEvents label475 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEH264Profile As System.Windows.Forms.ComboBox
    Private WithEvents label474 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEH264Preset As System.Windows.Forms.ComboBox
    Private WithEvents label473 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEH264Mode As System.Windows.Forms.ComboBox
    Private WithEvents label472 As System.Windows.Forms.Label
    Private WithEvents lbFFEXEH264Quantizer As System.Windows.Forms.Label
    Private WithEvents tbFFEXEH264Quantizer As System.Windows.Forms.TrackBar
    Private WithEvents label458 As System.Windows.Forms.Label
    Private WithEvents tabPage131 As System.Windows.Forms.TabPage
    Private WithEvents lbFFEXEAudioNotes As System.Windows.Forms.Label
    Private WithEvents rbFFEXEAudioModeLossless As System.Windows.Forms.RadioButton
    Private WithEvents rbFFEXEAudioModeQuality As System.Windows.Forms.RadioButton
    Private WithEvents rbFFEXEAudioModeABR As System.Windows.Forms.RadioButton
    Private WithEvents rbFFEXEAudioModeCBR As System.Windows.Forms.RadioButton
    Private WithEvents lbFFEXEAudioQuality As System.Windows.Forms.Label
    Private WithEvents tbFFEXEAudioQuality As System.Windows.Forms.TrackBar
    Private WithEvents label477 As System.Windows.Forms.Label
    Private WithEvents label470 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEAudioCodec As System.Windows.Forms.ComboBox
    Private WithEvents label462 As System.Windows.Forms.Label
    Private WithEvents label463 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEAudioBitrate As System.Windows.Forms.ComboBox
    Private WithEvents label464 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEAudioChannels As System.Windows.Forms.ComboBox
    Private WithEvents label465 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEAudioSampleRate As System.Windows.Forms.ComboBox
    Private WithEvents label466 As System.Windows.Forms.Label
    Private WithEvents tabPage133 As System.Windows.Forms.TabPage
    Private WithEvents edFFEXECustomParametersCommon As System.Windows.Forms.TextBox
    Private WithEvents label480 As System.Windows.Forms.Label
    Private WithEvents edFFEXECustomParametersAudio As System.Windows.Forms.TextBox
    Private WithEvents label476 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEUseAviSynthProxy As System.Windows.Forms.CheckBox
    Private WithEvents cbFFEXEUseOnlyAdditionalParameters As System.Windows.Forms.CheckBox
    Private WithEvents edFFEXECustomParametersVideo As System.Windows.Forms.TextBox
    Private WithEvents label471 As System.Windows.Forms.Label
    Private WithEvents cbFFEXEProfile As System.Windows.Forms.ComboBox
    Private WithEvents label467 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents rbNetworkRTMPFFMPEGCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbNetworkRTMPFFMPEG As System.Windows.Forms.RadioButton
    Private WithEvents edNetworkRTMPURL As System.Windows.Forms.TextBox
    Private WithEvents label368 As System.Windows.Forms.Label
    Private WithEvents label369 As System.Windows.Forms.Label
    Friend WithEvents TabPage67 As System.Windows.Forms.TabPage
    Private WithEvents label484 As System.Windows.Forms.Label
    Private WithEvents edNetworkUDPURL As System.Windows.Forms.TextBox
    Private WithEvents label372 As System.Windows.Forms.Label
    Private WithEvents rbNetworkUDPFFMPEGCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbNetworkUDPFFMPEG As System.Windows.Forms.RadioButton
    Private WithEvents groupBox48 As System.Windows.Forms.GroupBox
    Private WithEvents label343 As System.Windows.Forms.Label
    Private WithEvents edEncryptionKeyHEX As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyBinary As System.Windows.Forms.RadioButton
    Private WithEvents btEncryptionOpenFile As System.Windows.Forms.Button
    Private WithEvents edEncryptionKeyFile As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyFile As System.Windows.Forms.RadioButton
    Private WithEvents edEncryptionKeyString As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyString As System.Windows.Forms.RadioButton
    Private WithEvents groupBox47 As System.Windows.Forms.GroupBox
    Private WithEvents rbEncryptionModeAES256 As System.Windows.Forms.RadioButton
    Private WithEvents rbEncryptionModeAES128 As System.Windows.Forms.RadioButton
    Private WithEvents groupBox43 As System.Windows.Forms.GroupBox
    Private WithEvents rbEncryptedH264CUDA As System.Windows.Forms.RadioButton
    Private WithEvents rbEncryptedH264SW As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage77 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl31 As System.Windows.Forms.TabControl
    Friend WithEvents tabPage140 As System.Windows.Forms.TabPage
    Private WithEvents label485 As System.Windows.Forms.Label
    Private WithEvents cbM4AOutput As System.Windows.Forms.ComboBox
    Private WithEvents label486 As System.Windows.Forms.Label
    Private WithEvents cbM4ABitrate As System.Windows.Forms.ComboBox
    Private WithEvents label487 As System.Windows.Forms.Label
    Private WithEvents cbM4AObjectType As System.Windows.Forms.ComboBox
    Private WithEvents label488 As System.Windows.Forms.Label
    Private WithEvents cbM4AVersion As System.Windows.Forms.ComboBox
    Private WithEvents label489 As System.Windows.Forms.Label
    Friend WithEvents tabPage141 As System.Windows.Forms.TabPage
    Private WithEvents linkLabel6 As System.Windows.Forms.LinkLabel
    Private WithEvents Label500 As System.Windows.Forms.Label
    Private WithEvents Label501 As System.Windows.Forms.Label
    Private WithEvents btSelectOutputCut As Button
    Private WithEvents edOutputFileCut As TextBox
    Private WithEvents label131 As Label
    Private WithEvents btStopCut As Button
    Private WithEvents btStartCut As Button
    Private WithEvents label31 As Label
    Private WithEvents btAddInputFile2 As Button
    Private WithEvents edSourceFileToCut As TextBox
    Private WithEvents label30 As Label
    Private WithEvents label26 As Label
    Private WithEvents edStopTimeCut As TextBox
    Private WithEvents label27 As Label
    Private WithEvents label28 As Label
    Private WithEvents edStartTimeCut As TextBox
    Private WithEvents label29 As Label
    Private WithEvents btSelectOutputJoin As Button
    Private WithEvents edOutputFileJoin As TextBox
    Private WithEvents label132 As Label
    Private WithEvents btStopJoin As Button
    Private WithEvents btStartJoin As Button
    Private WithEvents btClearList3 As Button
    Private WithEvents btAddInputFile3 As Button
    Private WithEvents lbFiles2 As ListBox
    Private WithEvents label32 As Label
    Private WithEvents cbLicensing As CheckBox
    Friend WithEvents TabPage78 As TabPage
    Friend WithEvents TabControl32 As TabControl
    Friend WithEvents TabPage142 As TabPage
    Friend WithEvents edTagTrackID As TextBox
    Friend WithEvents Label496 As Label
    Friend WithEvents edTagYear As TextBox
    Friend WithEvents Label495 As Label
    Friend WithEvents edTagComment As TextBox
    Friend WithEvents Label493 As Label
    Friend WithEvents edTagAlbum As TextBox
    Friend WithEvents Label491 As Label
    Friend WithEvents edTagArtists As TextBox
    Friend WithEvents Label490 As Label
    Friend WithEvents edTagCopyright As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents edTagTitle As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TabPage143 As TabPage
    Friend WithEvents imgTagCover As PictureBox
    Friend WithEvents Label499 As Label
    Friend WithEvents Label498 As Label
    Friend WithEvents edTagLyrics As TextBox
    Friend WithEvents Label497 As Label
    Friend WithEvents cbTagGenre As ComboBox
    Friend WithEvents Label494 As Label
    Friend WithEvents edTagComposers As TextBox
    Friend WithEvents Label492 As Label
    Friend WithEvents cbTagEnabled As CheckBox
    Friend WithEvents Label24 As Label
    Private WithEvents edCropRight As TextBox
    Private WithEvents label176 As Label
    Private WithEvents edCropBottom As TextBox
    Private WithEvents label252 As Label
    Private WithEvents edCropLeft As TextBox
    Private WithEvents label270 As Label
    Private WithEvents edCropTop As TextBox
    Private WithEvents label272 As Label
    Private WithEvents cbCrop As CheckBox
    Private WithEvents label134 As Label
    Friend WithEvents TabPage74 As TabPage
    Private WithEvents cbMuxStreamsShortest As CheckBox
    Private WithEvents cbMuxStreamsType As ComboBox
    Private WithEvents btMuxStreamsSelectFile As Button
    Private WithEvents edMuxStreamsSourceFile As TextBox
    Private WithEvents label167 As Label
    Private WithEvents btMuxStreamsSelectOutput As Button
    Private WithEvents edMuxStreamsOutputFile As TextBox
    Private WithEvents label165 As Label
    Private WithEvents btStopMux As Button
    Private WithEvents btStartMux As Button
    Private WithEvents btMuxStreamsClear As Button
    Private WithEvents btMuxStreamsAdd As Button
    Private WithEvents lbMuxStreamsList As ListBox
    Private WithEvents label166 As Label
    Private WithEvents label168 As Label
    Friend WithEvents TabPage79 As TabPage
    Private WithEvents label504 As Label
    Private WithEvents edGIFHeight As TextBox
    Private WithEvents edGIFWidth As TextBox
    Private WithEvents Label25 As Label
    Private WithEvents edGIFFrameRate As TextBox
    Private WithEvents label251 As Label
    Private WithEvents linkLabel3 As LinkLabel
    Private WithEvents LinkLabel2 As LinkLabel
    Private WithEvents linkLabel10 As LinkLabel
    Private WithEvents rbNetworkSSFFMPEGCustom As RadioButton
    Private WithEvents rbNetworkSSFFMPEGDefault As RadioButton
    Private WithEvents rbMP4NVENC As RadioButton
    Friend WithEvents TabPage22 As TabPage
    Private WithEvents groupBox14 As GroupBox
    Private WithEvents label506 As Label
    Private WithEvents edNVENCBFrames As TextBox
    Private WithEvents label507 As Label
    Private WithEvents edNVENCGOP As TextBox
    Private WithEvents groupBox49 As GroupBox
    Private WithEvents Label129 As Label
    Private WithEvents edNVENCQP As TextBox
    Private WithEvents label508 As Label
    Private WithEvents edNVENCBitrate As TextBox
    Private WithEvents label509 As Label
    Private WithEvents cbNVENCRateControl As ComboBox
    Private WithEvents groupBox50 As GroupBox
    Private WithEvents label511 As Label
    Private WithEvents label512 As Label
    Private WithEvents cbNVENCLevel As ComboBox
    Private WithEvents cbNVENCProfile As ComboBox
    Friend WithEvents TabPage80 As TabPage
    Private WithEvents btAudioChannelMapperClear As Button
    Private WithEvents groupBox41 As GroupBox
    Private WithEvents btAudioChannelMapperAddNewRoute As Button
    Private WithEvents label311 As Label
    Private WithEvents tbAudioChannelMapperVolume As TrackBar
    Private WithEvents label310 As Label
    Private WithEvents edAudioChannelMapperTargetChannel As TextBox
    Private WithEvents label309 As Label
    Private WithEvents edAudioChannelMapperSourceChannel As TextBox
    Private WithEvents label308 As Label
    Private WithEvents label307 As Label
    Private WithEvents edAudioChannelMapperOutputChannels As TextBox
    Private WithEvents label306 As Label
    Private WithEvents lbAudioChannelMapperRoutes As ListBox
    Private WithEvents cbAudioChannelMapperEnabled As CheckBox
    Private WithEvents Label114 As Label
    Private WithEvents linkLabel11 As LinkLabel
    Friend WithEvents TabPage81 As TabPage
    Private WithEvents label177 As Label
    Private WithEvents Label3 As Label
    Private WithEvents btSubtitlesSelectFile As Button
    Private WithEvents edSubtitlesFilename As TextBox
    Private WithEvents Label130 As Label
    Private WithEvents cbSubtitlesEnabled As CheckBox
    Private WithEvents openFileDialogSubtitles As OpenFileDialog
    Friend WithEvents TabPage82 As TabPage
    Private WithEvents cbGPUOldMovie As CheckBox
    Private WithEvents cbGPUBlur As CheckBox
    Private WithEvents cbGPUDeinterlace As CheckBox
    Private WithEvents cbGPUDenoise As CheckBox
    Private WithEvents cbGPUPixelate As CheckBox
    Private WithEvents cbGPUNightVision As CheckBox
    Private WithEvents label383 As Label
    Private WithEvents label384 As Label
    Private WithEvents label385 As Label
    Private WithEvents label386 As Label
    Private WithEvents tbGPUContrast As TrackBar
    Private WithEvents tbGPUDarkness As TrackBar
    Private WithEvents tbGPULightness As TrackBar
    Private WithEvents tbGPUSaturation As TrackBar
    Private WithEvents cbGPUInvert As CheckBox
    Private WithEvents cbGPUGreyscale As CheckBox
End Class
