﻿Imports VisioForge.Types

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId:="memoryFileStream")>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim VideoRendererSettingsWinForms1 As VisioForge.Types.VideoRendererSettingsWinForms = New VisioForge.Types.VideoRendererSettingsWinForms()
        Me.tabControl3 = New System.Windows.Forms.TabControl()
        Me.tabPage10 = New System.Windows.Forms.TabPage()
        Me.cbTelemetry = New System.Windows.Forms.CheckBox()
        Me.cbLicensing = New System.Windows.Forms.CheckBox()
        Me.mmLog = New System.Windows.Forms.TextBox()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.tabPage9 = New System.Windows.Forms.TabPage()
        Me.tabControl13 = New System.Windows.Forms.TabControl()
        Me.tabPage54 = New System.Windows.Forms.TabPage()
        Me.cbImageType = New System.Windows.Forms.ComboBox()
        Me.lbJPEGQuality = New System.Windows.Forms.Label()
        Me.label38 = New System.Windows.Forms.Label()
        Me.btSaveScreenshot = New System.Windows.Forms.Button()
        Me.btSelectScreenshotsFolder = New System.Windows.Forms.Button()
        Me.label63 = New System.Windows.Forms.Label()
        Me.edScreenshotsFolder = New System.Windows.Forms.TextBox()
        Me.tbJPEGQuality = New System.Windows.Forms.TrackBar()
        Me.tabPage55 = New System.Windows.Forms.TabPage()
        Me.edScreenshotHeight = New System.Windows.Forms.TextBox()
        Me.label176 = New System.Windows.Forms.Label()
        Me.edScreenshotWidth = New System.Windows.Forms.TextBox()
        Me.label177 = New System.Windows.Forms.Label()
        Me.cbScreenshotResize = New System.Windows.Forms.CheckBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btDVDControlRootMenu = New System.Windows.Forms.Button()
        Me.btDVDControlTitleMenu = New System.Windows.Forms.Button()
        Me.cbDVDControlSubtitles = New System.Windows.Forms.ComboBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.cbDVDControlAudio = New System.Windows.Forms.ComboBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.cbDVDControlChapter = New System.Windows.Forms.ComboBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.cbDVDControlTitle = New System.Windows.Forms.ComboBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btPreviousFrame = New System.Windows.Forms.Button()
        Me.cbLoop = New System.Windows.Forms.CheckBox()
        Me.btNextFrame = New System.Windows.Forms.Button()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btPause = New System.Windows.Forms.Button()
        Me.btResume = New System.Windows.Forms.Button()
        Me.btStart = New System.Windows.Forms.Button()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.label16 = New System.Windows.Forms.Label()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.tbTimeline = New System.Windows.Forms.TrackBar()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage20 = New System.Windows.Forms.TabPage()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbGPUDirect3D = New System.Windows.Forms.RadioButton()
        Me.rbGPUDXVANative = New System.Windows.Forms.RadioButton()
        Me.rbGPUDXVACopyBack = New System.Windows.Forms.RadioButton()
        Me.rbGPUIntel = New System.Windows.Forms.RadioButton()
        Me.rbGPUNVidia = New System.Windows.Forms.RadioButton()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.cbUseLibMediaInfo = New System.Windows.Forms.CheckBox()
        Me.btReadInfo = New System.Windows.Forms.Button()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPage6 = New System.Windows.Forms.TabPage()
        Me.mmInfo = New System.Windows.Forms.TextBox()
        Me.tabPage7 = New System.Windows.Forms.TabPage()
        Me.lbDVDTitles = New System.Windows.Forms.ListBox()
        Me.cbDVDSubtitles = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbDVDAudio = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.edDVDVideo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TabPage47 = New System.Windows.Forms.TabPage()
        Me.imgTags = New System.Windows.Forms.PictureBox()
        Me.edTags = New System.Windows.Forms.TextBox()
        Me.btReadTags = New System.Windows.Forms.Button()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tbBalance4 = New System.Windows.Forms.TrackBar()
        Me.label11 = New System.Windows.Forms.Label()
        Me.tbVolume4 = New System.Windows.Forms.TrackBar()
        Me.cbAudioStream4 = New System.Windows.Forms.CheckBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.tbBalance3 = New System.Windows.Forms.TrackBar()
        Me.label13 = New System.Windows.Forms.Label()
        Me.tbVolume3 = New System.Windows.Forms.TrackBar()
        Me.cbAudioStream3 = New System.Windows.Forms.CheckBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tbBalance2 = New System.Windows.Forms.TrackBar()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tbVolume2 = New System.Windows.Forms.TrackBar()
        Me.cbAudioStream2 = New System.Windows.Forms.CheckBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbBalance1 = New System.Windows.Forms.TrackBar()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tbVolume1 = New System.Windows.Forms.TrackBar()
        Me.cbAudioStream1 = New System.Windows.Forms.CheckBox()
        Me.cbPlayAudio = New System.Windows.Forms.CheckBox()
        Me.cbAudioOutputDevice = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.tabControl4 = New System.Windows.Forms.TabControl()
        Me.tabPage16 = New System.Windows.Forms.TabPage()
        Me.label393 = New System.Windows.Forms.Label()
        Me.cbDirect2DRotate = New System.Windows.Forms.ComboBox()
        Me.pnVideoRendererBGColor = New System.Windows.Forms.Panel()
        Me.label394 = New System.Windows.Forms.Label()
        Me.btFullScreen = New System.Windows.Forms.Button()
        Me.groupBox28 = New System.Windows.Forms.GroupBox()
        Me.btZoomReset = New System.Windows.Forms.Button()
        Me.btZoomShiftRight = New System.Windows.Forms.Button()
        Me.btZoomShiftLeft = New System.Windows.Forms.Button()
        Me.btZoomOut = New System.Windows.Forms.Button()
        Me.btZoomIn = New System.Windows.Forms.Button()
        Me.btZoomShiftDown = New System.Windows.Forms.Button()
        Me.btZoomShiftUp = New System.Windows.Forms.Button()
        Me.cbScreenFlipVertical = New System.Windows.Forms.CheckBox()
        Me.cbScreenFlipHorizontal = New System.Windows.Forms.CheckBox()
        Me.cbStretch = New System.Windows.Forms.CheckBox()
        Me.groupBox13 = New System.Windows.Forms.GroupBox()
        Me.rbVirtualCameraOutput = New System.Windows.Forms.RadioButton()
        Me.rbDirect2D = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.rbEVR = New System.Windows.Forms.RadioButton()
        Me.rbVMR9 = New System.Windows.Forms.RadioButton()
        Me.rbVR = New System.Windows.Forms.RadioButton()
        Me.label15 = New System.Windows.Forms.Label()
        Me.edAspectRatioY = New System.Windows.Forms.TextBox()
        Me.edAspectRatioX = New System.Windows.Forms.TextBox()
        Me.cbAspectRatioUseCustom = New System.Windows.Forms.CheckBox()
        Me.tabPage17 = New System.Windows.Forms.TabPage()
        Me.cbMultiscreenDrawOnExternalDisplays = New System.Windows.Forms.CheckBox()
        Me.cbMultiscreenDrawOnPanels = New System.Windows.Forms.CheckBox()
        Me.cbFlipHorizontal2 = New System.Windows.Forms.CheckBox()
        Me.cbFlipVertical2 = New System.Windows.Forms.CheckBox()
        Me.cbStretch2 = New System.Windows.Forms.CheckBox()
        Me.cbFlipHorizontal1 = New System.Windows.Forms.CheckBox()
        Me.cbFlipVertical1 = New System.Windows.Forms.CheckBox()
        Me.cbStretch1 = New System.Windows.Forms.CheckBox()
        Me.pnScreen2 = New System.Windows.Forms.Panel()
        Me.pnScreen1 = New System.Windows.Forms.Panel()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.tabControl17 = New System.Windows.Forms.TabControl()
        Me.tabPage68 = New System.Windows.Forms.TabPage()
        Me.cbFlipY = New System.Windows.Forms.CheckBox()
        Me.cbFlipX = New System.Windows.Forms.CheckBox()
        Me.label201 = New System.Windows.Forms.Label()
        Me.label200 = New System.Windows.Forms.Label()
        Me.label199 = New System.Windows.Forms.Label()
        Me.label198 = New System.Windows.Forms.Label()
        Me.tabControl7 = New System.Windows.Forms.TabControl()
        Me.tabPage29 = New System.Windows.Forms.TabPage()
        Me.btTextLogoRemove = New System.Windows.Forms.Button()
        Me.btTextLogoEdit = New System.Windows.Forms.Button()
        Me.lbTextLogos = New System.Windows.Forms.ListBox()
        Me.btTextLogoAdd = New System.Windows.Forms.Button()
        Me.tabPage42 = New System.Windows.Forms.TabPage()
        Me.btImageLogoRemove = New System.Windows.Forms.Button()
        Me.btImageLogoEdit = New System.Windows.Forms.Button()
        Me.lbImageLogos = New System.Windows.Forms.ListBox()
        Me.btImageLogoAdd = New System.Windows.Forms.Button()
        Me.TabPage18 = New System.Windows.Forms.TabPage()
        Me.groupBox37 = New System.Windows.Forms.GroupBox()
        Me.btEffZoomRight = New System.Windows.Forms.Button()
        Me.btEffZoomLeft = New System.Windows.Forms.Button()
        Me.btEffZoomOut = New System.Windows.Forms.Button()
        Me.btEffZoomIn = New System.Windows.Forms.Button()
        Me.btEffZoomDown = New System.Windows.Forms.Button()
        Me.btEffZoomUp = New System.Windows.Forms.Button()
        Me.cbZoom = New System.Windows.Forms.CheckBox()
        Me.TabPage19 = New System.Windows.Forms.TabPage()
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
        Me.TabPage22 = New System.Windows.Forms.TabPage()
        Me.rbFadeOut = New System.Windows.Forms.RadioButton()
        Me.rbFadeIn = New System.Windows.Forms.RadioButton()
        Me.groupBox45 = New System.Windows.Forms.GroupBox()
        Me.edFadeInOutStopTime = New System.Windows.Forms.TextBox()
        Me.label329 = New System.Windows.Forms.Label()
        Me.edFadeInOutStartTime = New System.Windows.Forms.TextBox()
        Me.label330 = New System.Windows.Forms.Label()
        Me.cbFadeInOut = New System.Windows.Forms.CheckBox()
        Me.TabPage27 = New System.Windows.Forms.TabPage()
        Me.cbLiveRotationStretch = New System.Windows.Forms.CheckBox()
        Me.label392 = New System.Windows.Forms.Label()
        Me.label391 = New System.Windows.Forms.Label()
        Me.tbLiveRotationAngle = New System.Windows.Forms.TrackBar()
        Me.label390 = New System.Windows.Forms.Label()
        Me.cbLiveRotation = New System.Windows.Forms.CheckBox()
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
        Me.TabPage50 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbGPUBlur = New System.Windows.Forms.TrackBar()
        Me.cbVideoEffectsGPUEnabled = New System.Windows.Forms.CheckBox()
        Me.cbGPUOldMovie = New System.Windows.Forms.CheckBox()
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
        Me.tabPage8 = New System.Windows.Forms.TabPage()
        Me.lbAdjSaturationCurrent = New System.Windows.Forms.Label()
        Me.lbAdjSaturationMax = New System.Windows.Forms.Label()
        Me.lbAdjSaturationMin = New System.Windows.Forms.Label()
        Me.tbAdjSaturation = New System.Windows.Forms.TrackBar()
        Me.label45 = New System.Windows.Forms.Label()
        Me.lbAdjHueCurrent = New System.Windows.Forms.Label()
        Me.lbAdjHueMax = New System.Windows.Forms.Label()
        Me.lbAdjHueMin = New System.Windows.Forms.Label()
        Me.tbAdjHue = New System.Windows.Forms.TrackBar()
        Me.label41 = New System.Windows.Forms.Label()
        Me.lbAdjContrastCurrent = New System.Windows.Forms.Label()
        Me.lbAdjContrastMax = New System.Windows.Forms.Label()
        Me.lbAdjContrastMin = New System.Windows.Forms.Label()
        Me.tbAdjContrast = New System.Windows.Forms.TrackBar()
        Me.label23 = New System.Windows.Forms.Label()
        Me.lbAdjBrightnessCurrent = New System.Windows.Forms.Label()
        Me.lbAdjBrightnessMax = New System.Windows.Forms.Label()
        Me.lbAdjBrightnessMin = New System.Windows.Forms.Label()
        Me.tbAdjBrightness = New System.Windows.Forms.TrackBar()
        Me.label24 = New System.Windows.Forms.Label()
        Me.tabPage15 = New System.Windows.Forms.TabPage()
        Me.pnChromaKeyColor = New System.Windows.Forms.Panel()
        Me.btChromaKeySelectBGImage = New System.Windows.Forms.Button()
        Me.edChromaKeyImage = New System.Windows.Forms.TextBox()
        Me.label216 = New System.Windows.Forms.Label()
        Me.label215 = New System.Windows.Forms.Label()
        Me.tbChromaKeySmoothing = New System.Windows.Forms.TrackBar()
        Me.label214 = New System.Windows.Forms.Label()
        Me.tbChromaKeyThresholdSensitivity = New System.Windows.Forms.TrackBar()
        Me.label213 = New System.Windows.Forms.Label()
        Me.cbChromaKeyEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage28 = New System.Windows.Forms.TabPage()
        Me.btFilterDelete = New System.Windows.Forms.Button()
        Me.btFilterDeleteAll = New System.Windows.Forms.Button()
        Me.btFilterSettings2 = New System.Windows.Forms.Button()
        Me.lbFilters = New System.Windows.Forms.ListBox()
        Me.label106 = New System.Windows.Forms.Label()
        Me.btFilterSettings = New System.Windows.Forms.Button()
        Me.btFilterAdd = New System.Windows.Forms.Button()
        Me.cbFilters = New System.Windows.Forms.ComboBox()
        Me.label105 = New System.Windows.Forms.Label()
        Me.tabPage11 = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
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
        Me.TabPage46 = New System.Windows.Forms.TabPage()
        Me.lbAudioTimeshift = New System.Windows.Forms.Label()
        Me.tbAudioTimeshift = New System.Windows.Forms.TrackBar()
        Me.label70 = New System.Windows.Forms.Label()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbAudioOutputGainLFE = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainLFE = New System.Windows.Forms.TrackBar()
        Me.label55 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainSR = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainSR = New System.Windows.Forms.TrackBar()
        Me.label57 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainSL = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainSL = New System.Windows.Forms.TrackBar()
        Me.label59 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainR = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainR = New System.Windows.Forms.TrackBar()
        Me.label61 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainC = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainC = New System.Windows.Forms.TrackBar()
        Me.label67 = New System.Windows.Forms.Label()
        Me.lbAudioOutputGainL = New System.Windows.Forms.Label()
        Me.tbAudioOutputGainL = New System.Windows.Forms.TrackBar()
        Me.label69 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAudioInputGainLFE = New System.Windows.Forms.Label()
        Me.tbAudioInputGainLFE = New System.Windows.Forms.TrackBar()
        Me.label53 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainSR = New System.Windows.Forms.Label()
        Me.tbAudioInputGainSR = New System.Windows.Forms.TrackBar()
        Me.label51 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainSL = New System.Windows.Forms.Label()
        Me.tbAudioInputGainSL = New System.Windows.Forms.TrackBar()
        Me.label49 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainR = New System.Windows.Forms.Label()
        Me.tbAudioInputGainR = New System.Windows.Forms.TrackBar()
        Me.label47 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainC = New System.Windows.Forms.Label()
        Me.tbAudioInputGainC = New System.Windows.Forms.TrackBar()
        Me.label44 = New System.Windows.Forms.Label()
        Me.lbAudioInputGainL = New System.Windows.Forms.Label()
        Me.tbAudioInputGainL = New System.Windows.Forms.TrackBar()
        Me.label40 = New System.Windows.Forms.Label()
        Me.cbAudioAutoGain = New System.Windows.Forms.CheckBox()
        Me.cbAudioNormalize = New System.Windows.Forms.CheckBox()
        Me.cbAudioEnhancementEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage49 = New System.Windows.Forms.TabPage()
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
        Me.TabPage25 = New System.Windows.Forms.TabPage()
        Me.tbVUMeterBoost = New System.Windows.Forms.TrackBar()
        Me.label382 = New System.Windows.Forms.Label()
        Me.label381 = New System.Windows.Forms.Label()
        Me.tbVUMeterAmplification = New System.Windows.Forms.TrackBar()
        Me.cbVUMeterPro = New System.Windows.Forms.CheckBox()
        Me.waveformPainter2 = New VisioForge.Controls.UI.WinForms.VolumeMeterPro.WaveformPainter()
        Me.waveformPainter1 = New VisioForge.Controls.UI.WinForms.VolumeMeterPro.WaveformPainter()
        Me.volumeMeter2 = New VisioForge.Controls.UI.WinForms.VolumeMeterPro.VolumeMeter()
        Me.volumeMeter1 = New VisioForge.Controls.UI.WinForms.VolumeMeterPro.VolumeMeter()
        Me.tabPage5 = New System.Windows.Forms.TabPage()
        Me.btOSDRenderLayers = New System.Windows.Forms.Button()
        Me.lbOSDLayers = New System.Windows.Forms.CheckedListBox()
        Me.cbOSDEnabled = New System.Windows.Forms.CheckBox()
        Me.groupBox19 = New System.Windows.Forms.GroupBox()
        Me.btOSDClearLayer = New System.Windows.Forms.Button()
        Me.tabControl6 = New System.Windows.Forms.TabControl()
        Me.tabPage30 = New System.Windows.Forms.TabPage()
        Me.btOSDImageDraw = New System.Windows.Forms.Button()
        Me.pnOSDColorKey = New System.Windows.Forms.Panel()
        Me.cbOSDImageTranspColor = New System.Windows.Forms.CheckBox()
        Me.edOSDImageTop = New System.Windows.Forms.TextBox()
        Me.label115 = New System.Windows.Forms.Label()
        Me.edOSDImageLeft = New System.Windows.Forms.TextBox()
        Me.label114 = New System.Windows.Forms.Label()
        Me.btOSDSelectImage = New System.Windows.Forms.Button()
        Me.edOSDImageFilename = New System.Windows.Forms.TextBox()
        Me.label113 = New System.Windows.Forms.Label()
        Me.tabPage31 = New System.Windows.Forms.TabPage()
        Me.edOSDTextTop = New System.Windows.Forms.TextBox()
        Me.label117 = New System.Windows.Forms.Label()
        Me.edOSDTextLeft = New System.Windows.Forms.TextBox()
        Me.label118 = New System.Windows.Forms.Label()
        Me.label116 = New System.Windows.Forms.Label()
        Me.btOSDSelectFont = New System.Windows.Forms.Button()
        Me.edOSDText = New System.Windows.Forms.TextBox()
        Me.btOSDTextDraw = New System.Windows.Forms.Button()
        Me.tabPage32 = New System.Windows.Forms.TabPage()
        Me.tbOSDTranspLevel = New System.Windows.Forms.TrackBar()
        Me.btOSDSetTransp = New System.Windows.Forms.Button()
        Me.label119 = New System.Windows.Forms.Label()
        Me.btOSDClearLayers = New System.Windows.Forms.Button()
        Me.groupBox15 = New System.Windows.Forms.GroupBox()
        Me.btOSDLayerAdd = New System.Windows.Forms.Button()
        Me.edOSDLayerHeight = New System.Windows.Forms.TextBox()
        Me.label111 = New System.Windows.Forms.Label()
        Me.edOSDLayerWidth = New System.Windows.Forms.TextBox()
        Me.label112 = New System.Windows.Forms.Label()
        Me.edOSDLayerTop = New System.Windows.Forms.TextBox()
        Me.label110 = New System.Windows.Forms.Label()
        Me.edOSDLayerLeft = New System.Windows.Forms.TextBox()
        Me.label109 = New System.Windows.Forms.Label()
        Me.label108 = New System.Windows.Forms.Label()
        Me.tabPage12 = New System.Windows.Forms.TabPage()
        Me.tabControl5 = New System.Windows.Forms.TabControl()
        Me.tabPage33 = New System.Windows.Forms.TabPage()
        Me.cbCustomSplitter = New System.Windows.Forms.ComboBox()
        Me.rbSplitterCustom = New System.Windows.Forms.RadioButton()
        Me.rbSplitterDefault = New System.Windows.Forms.RadioButton()
        Me.tabPage34 = New System.Windows.Forms.TabPage()
        Me.rbVideoDecoderVFH264 = New System.Windows.Forms.RadioButton()
        Me.cbCustomVideoDecoder = New System.Windows.Forms.ComboBox()
        Me.label28 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.rbVideoDecoderCustom = New System.Windows.Forms.RadioButton()
        Me.rbVideoDecoderFFDShow = New System.Windows.Forms.RadioButton()
        Me.rbVideoDecoderMS = New System.Windows.Forms.RadioButton()
        Me.rbVideoDecoderDefault = New System.Windows.Forms.RadioButton()
        Me.TabPage43 = New System.Windows.Forms.TabPage()
        Me.cbCustomAudioDecoder = New System.Windows.Forms.ComboBox()
        Me.rbAudioDecoderCustom = New System.Windows.Forms.RadioButton()
        Me.rbAudioDecoderDefault = New System.Windows.Forms.RadioButton()
        Me.tabPage13 = New System.Windows.Forms.TabPage()
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
        Me.TabPage21 = New System.Windows.Forms.TabPage()
        Me.edBarcodeMetadata = New System.Windows.Forms.TextBox()
        Me.label91 = New System.Windows.Forms.Label()
        Me.cbBarcodeType = New System.Windows.Forms.ComboBox()
        Me.label90 = New System.Windows.Forms.Label()
        Me.btBarcodeReset = New System.Windows.Forms.Button()
        Me.edBarcode = New System.Windows.Forms.TextBox()
        Me.label89 = New System.Windows.Forms.Label()
        Me.cbBarcodeDetectionEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage23 = New System.Windows.Forms.TabPage()
        Me.groupBox48 = New System.Windows.Forms.GroupBox()
        Me.label343 = New System.Windows.Forms.Label()
        Me.edEncryptionKeyHEX = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyBinary = New System.Windows.Forms.RadioButton()
        Me.btEncryptionOpenFile = New System.Windows.Forms.Button()
        Me.edEncryptionKeyFile = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyFile = New System.Windows.Forms.RadioButton()
        Me.edEncryptionKeyString = New System.Windows.Forms.TextBox()
        Me.rbEncryptionKeyString = New System.Windows.Forms.RadioButton()
        Me.TabPage24 = New System.Windows.Forms.TabPage()
        Me.btReversePlaybackNextFrame = New System.Windows.Forms.Button()
        Me.btReversePlaybackPrevFrame = New System.Windows.Forms.Button()
        Me.label34 = New System.Windows.Forms.Label()
        Me.label33 = New System.Windows.Forms.Label()
        Me.btReversePlayback = New System.Windows.Forms.Button()
        Me.edReversePlaybackCacheSize = New System.Windows.Forms.TextBox()
        Me.label32 = New System.Windows.Forms.Label()
        Me.tbReversePlaybackTrackbar = New System.Windows.Forms.TrackBar()
        Me.TabPage14 = New System.Windows.Forms.TabPage()
        Me.label505 = New System.Windows.Forms.Label()
        Me.rbMotionDetectionExProcessor = New System.Windows.Forms.ComboBox()
        Me.label389 = New System.Windows.Forms.Label()
        Me.rbMotionDetectionExDetector = New System.Windows.Forms.ComboBox()
        Me.label64 = New System.Windows.Forms.Label()
        Me.label65 = New System.Windows.Forms.Label()
        Me.pbAFMotionLevel = New System.Windows.Forms.ProgressBar()
        Me.cbMotionDetectionEx = New System.Windows.Forms.CheckBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.openFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btAddFileToPlaylist = New System.Windows.Forms.Button()
        Me.label30 = New System.Windows.Forms.Label()
        Me.lbSourceFiles = New System.Windows.Forms.ListBox()
        Me.mnPlaylist = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnPlaylistRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPlaylistRemoveAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbSourceMode = New System.Windows.Forms.ComboBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.btSelectFile = New System.Windows.Forms.Button()
        Me.edFilenameOrURL = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MediaPlayer1 = New VisioForge.Controls.UI.WinForms.MediaPlayer()
        Me.tabControl3.SuspendLayout
        Me.tabPage10.SuspendLayout
        Me.tabPage9.SuspendLayout
        Me.tabControl13.SuspendLayout
        Me.tabPage54.SuspendLayout
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage55.SuspendLayout
        Me.groupBox3.SuspendLayout
        Me.groupBox2.SuspendLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbTimeline,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabControl1.SuspendLayout
        Me.TabPage20.SuspendLayout
        Me.groupBox6.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPage6.SuspendLayout
        Me.tabPage7.SuspendLayout
        Me.TabPage47.SuspendLayout
        CType(Me.imgTags,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage2.SuspendLayout
        CType(Me.tbBalance4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVolume4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBalance3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVolume3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBalance2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVolume2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBalance1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVolume1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage3.SuspendLayout
        Me.tabControl4.SuspendLayout
        Me.tabPage16.SuspendLayout
        Me.groupBox28.SuspendLayout
        Me.groupBox13.SuspendLayout
        Me.tabPage17.SuspendLayout
        Me.tabPage4.SuspendLayout
        Me.tabControl17.SuspendLayout
        Me.tabPage68.SuspendLayout
        Me.tabControl7.SuspendLayout
        Me.tabPage29.SuspendLayout
        Me.tabPage42.SuspendLayout
        Me.TabPage18.SuspendLayout
        Me.groupBox37.SuspendLayout
        Me.TabPage19.SuspendLayout
        Me.groupBox40.SuspendLayout
        Me.groupBox39.SuspendLayout
        Me.groupBox38.SuspendLayout
        Me.TabPage22.SuspendLayout
        Me.groupBox45.SuspendLayout
        Me.TabPage27.SuspendLayout
        CType(Me.tbLiveRotationAngle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbDarkness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbLightness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage69.SuspendLayout
        Me.tabPage59.SuspendLayout
        Me.TabPage50.SuspendLayout
        CType(Me.tbGPUBlur,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPUContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPUDarkness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPULightness,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbGPUSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage8.SuspendLayout
        CType(Me.tbAdjSaturation,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAdjHue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAdjContrast,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAdjBrightness,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage15.SuspendLayout
        CType(Me.tbChromaKeySmoothing,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbChromaKeyThresholdSensitivity,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage28.SuspendLayout
        Me.tabPage11.SuspendLayout
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
        Me.TabPage46.SuspendLayout
        CType(Me.tbAudioTimeshift,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox4.SuspendLayout
        CType(Me.tbAudioOutputGainLFE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainSR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainSL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioOutputGainL,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox1.SuspendLayout
        CType(Me.tbAudioInputGainLFE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainSR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainSL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainR,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbAudioInputGainL,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage49.SuspendLayout
        Me.groupBox41.SuspendLayout
        CType(Me.tbAudioChannelMapperVolume,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage25.SuspendLayout
        CType(Me.tbVUMeterBoost,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbVUMeterAmplification,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage5.SuspendLayout
        Me.groupBox19.SuspendLayout
        Me.tabControl6.SuspendLayout
        Me.tabPage30.SuspendLayout
        Me.tabPage31.SuspendLayout
        Me.tabPage32.SuspendLayout
        CType(Me.tbOSDTranspLevel,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox15.SuspendLayout
        Me.tabPage12.SuspendLayout
        Me.tabControl5.SuspendLayout
        Me.tabPage33.SuspendLayout
        Me.tabPage34.SuspendLayout
        Me.TabPage43.SuspendLayout
        Me.tabPage13.SuspendLayout
        Me.tabControl9.SuspendLayout
        Me.tabPage44.SuspendLayout
        Me.tabPage45.SuspendLayout
        Me.groupBox25.SuspendLayout
        CType(Me.tbMotDetHLThreshold,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox27.SuspendLayout
        Me.groupBox26.SuspendLayout
        CType(Me.tbMotDetDropFramesThreshold,System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupBox24.SuspendLayout
        Me.TabPage21.SuspendLayout
        Me.TabPage23.SuspendLayout
        Me.groupBox48.SuspendLayout
        Me.TabPage24.SuspendLayout
        CType(Me.tbReversePlaybackTrackbar,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage14.SuspendLayout
        Me.mnPlaylist.SuspendLayout
        Me.SuspendLayout
        '
        'tabControl3
        '
        Me.tabControl3.Controls.Add(Me.tabPage10)
        Me.tabControl3.Controls.Add(Me.tabPage9)
        Me.tabControl3.Location = New System.Drawing.Point(12, 532)
        Me.tabControl3.Name = "tabControl3"
        Me.tabControl3.SelectedIndex = 0
        Me.tabControl3.Size = New System.Drawing.Size(309, 146)
        Me.tabControl3.TabIndex = 22
        '
        'tabPage10
        '
        Me.tabPage10.Controls.Add(Me.cbTelemetry)
        Me.tabPage10.Controls.Add(Me.cbLicensing)
        Me.tabPage10.Controls.Add(Me.mmLog)
        Me.tabPage10.Controls.Add(Me.cbDebugMode)
        Me.tabPage10.Location = New System.Drawing.Point(4, 22)
        Me.tabPage10.Name = "tabPage10"
        Me.tabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage10.Size = New System.Drawing.Size(301, 120)
        Me.tabPage10.TabIndex = 2
        Me.tabPage10.Text = "Debug"
        Me.tabPage10.UseVisualStyleBackColor = true
        '
        'cbTelemetry
        '
        Me.cbTelemetry.AutoSize = true
        Me.cbTelemetry.Checked = true
        Me.cbTelemetry.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTelemetry.Location = New System.Drawing.Point(206, 13)
        Me.cbTelemetry.Name = "cbTelemetry"
        Me.cbTelemetry.Size = New System.Drawing.Size(72, 17)
        Me.cbTelemetry.TabIndex = 5
        Me.cbTelemetry.Text = "Telemetry"
        Me.cbTelemetry.UseVisualStyleBackColor = true
        '
        'cbLicensing
        '
        Me.cbLicensing.AutoSize = true
        Me.cbLicensing.Location = New System.Drawing.Point(109, 13)
        Me.cbLicensing.Name = "cbLicensing"
        Me.cbLicensing.Size = New System.Drawing.Size(91, 17)
        Me.cbLicensing.TabIndex = 4
        Me.cbLicensing.Text = "Licensing info"
        Me.cbLicensing.UseVisualStyleBackColor = true
        '
        'mmLog
        '
        Me.mmLog.Location = New System.Drawing.Point(16, 36)
        Me.mmLog.Multiline = true
        Me.mmLog.Name = "mmLog"
        Me.mmLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmLog.Size = New System.Drawing.Size(264, 78)
        Me.mmLog.TabIndex = 1
        '
        'cbDebugMode
        '
        Me.cbDebugMode.AutoSize = true
        Me.cbDebugMode.Location = New System.Drawing.Point(16, 13)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(87, 17)
        Me.cbDebugMode.TabIndex = 0
        Me.cbDebugMode.Text = "Debug mode"
        Me.cbDebugMode.UseVisualStyleBackColor = true
        '
        'tabPage9
        '
        Me.tabPage9.Controls.Add(Me.tabControl13)
        Me.tabPage9.Location = New System.Drawing.Point(4, 22)
        Me.tabPage9.Name = "tabPage9"
        Me.tabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage9.Size = New System.Drawing.Size(301, 120)
        Me.tabPage9.TabIndex = 1
        Me.tabPage9.Text = "Screenshot"
        Me.tabPage9.UseVisualStyleBackColor = true
        '
        'tabControl13
        '
        Me.tabControl13.Controls.Add(Me.tabPage54)
        Me.tabControl13.Controls.Add(Me.tabPage55)
        Me.tabControl13.Location = New System.Drawing.Point(2, 2)
        Me.tabControl13.Name = "tabControl13"
        Me.tabControl13.SelectedIndex = 0
        Me.tabControl13.Size = New System.Drawing.Size(293, 111)
        Me.tabControl13.TabIndex = 27
        '
        'tabPage54
        '
        Me.tabPage54.Controls.Add(Me.cbImageType)
        Me.tabPage54.Controls.Add(Me.lbJPEGQuality)
        Me.tabPage54.Controls.Add(Me.label38)
        Me.tabPage54.Controls.Add(Me.btSaveScreenshot)
        Me.tabPage54.Controls.Add(Me.btSelectScreenshotsFolder)
        Me.tabPage54.Controls.Add(Me.label63)
        Me.tabPage54.Controls.Add(Me.edScreenshotsFolder)
        Me.tabPage54.Controls.Add(Me.tbJPEGQuality)
        Me.tabPage54.Location = New System.Drawing.Point(4, 22)
        Me.tabPage54.Name = "tabPage54"
        Me.tabPage54.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage54.Size = New System.Drawing.Size(285, 85)
        Me.tabPage54.TabIndex = 0
        Me.tabPage54.Text = "Main"
        Me.tabPage54.UseVisualStyleBackColor = true
        '
        'cbImageType
        '
        Me.cbImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImageType.FormattingEnabled = true
        Me.cbImageType.Items.AddRange(New Object() {"BMP", "JPEG", "GIF", "PNG", "TIFF"})
        Me.cbImageType.Location = New System.Drawing.Point(11, 59)
        Me.cbImageType.Name = "cbImageType"
        Me.cbImageType.Size = New System.Drawing.Size(73, 21)
        Me.cbImageType.TabIndex = 33
        '
        'lbJPEGQuality
        '
        Me.lbJPEGQuality.AutoSize = true
        Me.lbJPEGQuality.Location = New System.Drawing.Point(261, 62)
        Me.lbJPEGQuality.Name = "lbJPEGQuality"
        Me.lbJPEGQuality.Size = New System.Drawing.Size(19, 13)
        Me.lbJPEGQuality.TabIndex = 32
        Me.lbJPEGQuality.Text = "85"
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Location = New System.Drawing.Point(119, 62)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(67, 13)
        Me.label38.TabIndex = 31
        Me.label38.Text = "JPEG quality"
        '
        'btSaveScreenshot
        '
        Me.btSaveScreenshot.Location = New System.Drawing.Point(227, 14)
        Me.btSaveScreenshot.Name = "btSaveScreenshot"
        Me.btSaveScreenshot.Size = New System.Drawing.Size(56, 23)
        Me.btSaveScreenshot.TabIndex = 29
        Me.btSaveScreenshot.Text = "Save"
        Me.btSaveScreenshot.UseVisualStyleBackColor = true
        '
        'btSelectScreenshotsFolder
        '
        Me.btSelectScreenshotsFolder.Location = New System.Drawing.Point(198, 14)
        Me.btSelectScreenshotsFolder.Name = "btSelectScreenshotsFolder"
        Me.btSelectScreenshotsFolder.Size = New System.Drawing.Size(23, 23)
        Me.btSelectScreenshotsFolder.TabIndex = 28
        Me.btSelectScreenshotsFolder.Text = "..."
        Me.btSelectScreenshotsFolder.UseVisualStyleBackColor = true
        '
        'label63
        '
        Me.label63.AutoSize = true
        Me.label63.Location = New System.Drawing.Point(8, 19)
        Me.label63.Name = "label63"
        Me.label63.Size = New System.Drawing.Size(36, 13)
        Me.label63.TabIndex = 27
        Me.label63.Text = "Folder"
        '
        'edScreenshotsFolder
        '
        Me.edScreenshotsFolder.Location = New System.Drawing.Point(53, 16)
        Me.edScreenshotsFolder.Name = "edScreenshotsFolder"
        Me.edScreenshotsFolder.Size = New System.Drawing.Size(139, 20)
        Me.edScreenshotsFolder.TabIndex = 26
        Me.edScreenshotsFolder.Text = "c:\"
        '
        'tbJPEGQuality
        '
        Me.tbJPEGQuality.BackColor = System.Drawing.SystemColors.Window
        Me.tbJPEGQuality.Location = New System.Drawing.Point(192, 48)
        Me.tbJPEGQuality.Maximum = 100
        Me.tbJPEGQuality.Name = "tbJPEGQuality"
        Me.tbJPEGQuality.Size = New System.Drawing.Size(64, 45)
        Me.tbJPEGQuality.TabIndex = 30
        Me.tbJPEGQuality.TickFrequency = 5
        Me.tbJPEGQuality.Value = 85
        '
        'tabPage55
        '
        Me.tabPage55.Controls.Add(Me.edScreenshotHeight)
        Me.tabPage55.Controls.Add(Me.label176)
        Me.tabPage55.Controls.Add(Me.edScreenshotWidth)
        Me.tabPage55.Controls.Add(Me.label177)
        Me.tabPage55.Controls.Add(Me.cbScreenshotResize)
        Me.tabPage55.Location = New System.Drawing.Point(4, 22)
        Me.tabPage55.Name = "tabPage55"
        Me.tabPage55.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage55.Size = New System.Drawing.Size(285, 85)
        Me.tabPage55.TabIndex = 1
        Me.tabPage55.Text = "Resize"
        Me.tabPage55.UseVisualStyleBackColor = true
        '
        'edScreenshotHeight
        '
        Me.edScreenshotHeight.Location = New System.Drawing.Point(163, 44)
        Me.edScreenshotHeight.Name = "edScreenshotHeight"
        Me.edScreenshotHeight.Size = New System.Drawing.Size(36, 20)
        Me.edScreenshotHeight.TabIndex = 128
        Me.edScreenshotHeight.Text = "576"
        '
        'label176
        '
        Me.label176.AutoSize = true
        Me.label176.Location = New System.Drawing.Point(116, 47)
        Me.label176.Name = "label176"
        Me.label176.Size = New System.Drawing.Size(38, 13)
        Me.label176.TabIndex = 127
        Me.label176.Text = "Height"
        '
        'edScreenshotWidth
        '
        Me.edScreenshotWidth.Location = New System.Drawing.Point(74, 44)
        Me.edScreenshotWidth.Name = "edScreenshotWidth"
        Me.edScreenshotWidth.Size = New System.Drawing.Size(36, 20)
        Me.edScreenshotWidth.TabIndex = 126
        Me.edScreenshotWidth.Text = "768"
        '
        'label177
        '
        Me.label177.AutoSize = true
        Me.label177.Location = New System.Drawing.Point(32, 47)
        Me.label177.Name = "label177"
        Me.label177.Size = New System.Drawing.Size(35, 13)
        Me.label177.TabIndex = 125
        Me.label177.Text = "Width"
        '
        'cbScreenshotResize
        '
        Me.cbScreenshotResize.AutoSize = true
        Me.cbScreenshotResize.Location = New System.Drawing.Point(16, 18)
        Me.cbScreenshotResize.Name = "cbScreenshotResize"
        Me.cbScreenshotResize.Size = New System.Drawing.Size(65, 17)
        Me.cbScreenshotResize.TabIndex = 0
        Me.cbScreenshotResize.Text = "Enabled"
        Me.cbScreenshotResize.UseVisualStyleBackColor = true
        '
        'groupBox3
        '
        Me.groupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.groupBox3.Controls.Add(Me.btDVDControlRootMenu)
        Me.groupBox3.Controls.Add(Me.btDVDControlTitleMenu)
        Me.groupBox3.Controls.Add(Me.cbDVDControlSubtitles)
        Me.groupBox3.Controls.Add(Me.label19)
        Me.groupBox3.Controls.Add(Me.cbDVDControlAudio)
        Me.groupBox3.Controls.Add(Me.label21)
        Me.groupBox3.Controls.Add(Me.cbDVDControlChapter)
        Me.groupBox3.Controls.Add(Me.label18)
        Me.groupBox3.Controls.Add(Me.cbDVDControlTitle)
        Me.groupBox3.Controls.Add(Me.label17)
        Me.groupBox3.Location = New System.Drawing.Point(329, 567)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(416, 78)
        Me.groupBox3.TabIndex = 21
        Me.groupBox3.TabStop = false
        Me.groupBox3.Text = "DVD"
        '
        'btDVDControlRootMenu
        '
        Me.btDVDControlRootMenu.Location = New System.Drawing.Point(335, 48)
        Me.btDVDControlRootMenu.Name = "btDVDControlRootMenu"
        Me.btDVDControlRootMenu.Size = New System.Drawing.Size(75, 23)
        Me.btDVDControlRootMenu.TabIndex = 9
        Me.btDVDControlRootMenu.Text = "Root menu"
        Me.btDVDControlRootMenu.UseVisualStyleBackColor = true
        '
        'btDVDControlTitleMenu
        '
        Me.btDVDControlTitleMenu.Location = New System.Drawing.Point(335, 21)
        Me.btDVDControlTitleMenu.Name = "btDVDControlTitleMenu"
        Me.btDVDControlTitleMenu.Size = New System.Drawing.Size(75, 23)
        Me.btDVDControlTitleMenu.TabIndex = 8
        Me.btDVDControlTitleMenu.Text = "Title menu"
        Me.btDVDControlTitleMenu.UseVisualStyleBackColor = true
        '
        'cbDVDControlSubtitles
        '
        Me.cbDVDControlSubtitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDControlSubtitles.FormattingEnabled = true
        Me.cbDVDControlSubtitles.Location = New System.Drawing.Point(217, 50)
        Me.cbDVDControlSubtitles.Name = "cbDVDControlSubtitles"
        Me.cbDVDControlSubtitles.Size = New System.Drawing.Size(112, 21)
        Me.cbDVDControlSubtitles.TabIndex = 7
        '
        'label19
        '
        Me.label19.AutoSize = true
        Me.label19.Location = New System.Drawing.Point(168, 53)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(47, 13)
        Me.label19.TabIndex = 6
        Me.label19.Text = "Subtitles"
        '
        'cbDVDControlAudio
        '
        Me.cbDVDControlAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDControlAudio.FormattingEnabled = true
        Me.cbDVDControlAudio.Location = New System.Drawing.Point(217, 23)
        Me.cbDVDControlAudio.Name = "cbDVDControlAudio"
        Me.cbDVDControlAudio.Size = New System.Drawing.Size(112, 21)
        Me.cbDVDControlAudio.TabIndex = 5
        '
        'label21
        '
        Me.label21.AutoSize = true
        Me.label21.Location = New System.Drawing.Point(168, 26)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(34, 13)
        Me.label21.TabIndex = 4
        Me.label21.Text = "Audio"
        '
        'cbDVDControlChapter
        '
        Me.cbDVDControlChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDControlChapter.FormattingEnabled = true
        Me.cbDVDControlChapter.Location = New System.Drawing.Point(55, 50)
        Me.cbDVDControlChapter.Name = "cbDVDControlChapter"
        Me.cbDVDControlChapter.Size = New System.Drawing.Size(98, 21)
        Me.cbDVDControlChapter.TabIndex = 3
        '
        'label18
        '
        Me.label18.AutoSize = true
        Me.label18.Location = New System.Drawing.Point(6, 53)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(44, 13)
        Me.label18.TabIndex = 2
        Me.label18.Text = "Chapter"
        '
        'cbDVDControlTitle
        '
        Me.cbDVDControlTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDControlTitle.FormattingEnabled = true
        Me.cbDVDControlTitle.Location = New System.Drawing.Point(55, 23)
        Me.cbDVDControlTitle.Name = "cbDVDControlTitle"
        Me.cbDVDControlTitle.Size = New System.Drawing.Size(98, 21)
        Me.cbDVDControlTitle.TabIndex = 1
        '
        'label17
        '
        Me.label17.AutoSize = true
        Me.label17.Location = New System.Drawing.Point(6, 26)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(27, 13)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Title"
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.btPreviousFrame)
        Me.groupBox2.Controls.Add(Me.cbLoop)
        Me.groupBox2.Controls.Add(Me.btNextFrame)
        Me.groupBox2.Controls.Add(Me.btStop)
        Me.groupBox2.Controls.Add(Me.btPause)
        Me.groupBox2.Controls.Add(Me.btResume)
        Me.groupBox2.Controls.Add(Me.btStart)
        Me.groupBox2.Controls.Add(Me.tbSpeed)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.lbTime)
        Me.groupBox2.Controls.Add(Me.tbTimeline)
        Me.groupBox2.Location = New System.Drawing.Point(329, 470)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(416, 90)
        Me.groupBox2.TabIndex = 20
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Controls"
        '
        'btPreviousFrame
        '
        Me.btPreviousFrame.Location = New System.Drawing.Point(259, 58)
        Me.btPreviousFrame.Name = "btPreviousFrame"
        Me.btPreviousFrame.Size = New System.Drawing.Size(70, 23)
        Me.btPreviousFrame.TabIndex = 10
        Me.btPreviousFrame.Text = "Prev frame"
        Me.btPreviousFrame.UseVisualStyleBackColor = true
        '
        'cbLoop
        '
        Me.cbLoop.AutoSize = true
        Me.cbLoop.Location = New System.Drawing.Point(217, 11)
        Me.cbLoop.Name = "cbLoop"
        Me.cbLoop.Size = New System.Drawing.Size(50, 17)
        Me.cbLoop.TabIndex = 9
        Me.cbLoop.Text = "Loop"
        Me.cbLoop.UseVisualStyleBackColor = true
        '
        'btNextFrame
        '
        Me.btNextFrame.Location = New System.Drawing.Point(335, 58)
        Me.btNextFrame.Name = "btNextFrame"
        Me.btNextFrame.Size = New System.Drawing.Size(75, 23)
        Me.btNextFrame.TabIndex = 8
        Me.btNextFrame.Text = "Next frame"
        Me.btNextFrame.UseVisualStyleBackColor = true
        '
        'btStop
        '
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStop.Location = New System.Drawing.Point(180, 58)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(46, 23)
        Me.btStop.TabIndex = 7
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = true
        '
        'btPause
        '
        Me.btPause.Location = New System.Drawing.Point(122, 58)
        Me.btPause.Name = "btPause"
        Me.btPause.Size = New System.Drawing.Size(52, 23)
        Me.btPause.TabIndex = 6
        Me.btPause.Text = "Pause"
        Me.btPause.UseVisualStyleBackColor = true
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(55, 58)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(61, 23)
        Me.btResume.TabIndex = 5
        Me.btResume.Text = "Resume"
        Me.btResume.UseVisualStyleBackColor = true
        '
        'btStart
        '
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btStart.Location = New System.Drawing.Point(6, 58)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(43, 23)
        Me.btStart.TabIndex = 4
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = true
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(321, 27)
        Me.tbSpeed.Maximum = 25
        Me.tbSpeed.Minimum = 5
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(89, 45)
        Me.tbSpeed.TabIndex = 3
        Me.tbSpeed.Value = 10
        '
        'label16
        '
        Me.label16.AutoSize = true
        Me.label16.Location = New System.Drawing.Point(322, 11)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(38, 13)
        Me.label16.TabIndex = 2
        Me.label16.Text = "Speed"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = true
        Me.lbTime.Location = New System.Drawing.Point(214, 37)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(96, 13)
        Me.lbTime.TabIndex = 1
        Me.lbTime.Text = "00:00:00/00:00:00"
        '
        'tbTimeline
        '
        Me.tbTimeline.Location = New System.Drawing.Point(6, 19)
        Me.tbTimeline.Maximum = 100
        Me.tbTimeline.Name = "tbTimeline"
        Me.tbTimeline.Size = New System.Drawing.Size(207, 45)
        Me.tbTimeline.TabIndex = 0
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.TabPage20)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Controls.Add(Me.tabPage11)
        Me.tabControl1.Controls.Add(Me.TabPage46)
        Me.tabControl1.Controls.Add(Me.TabPage49)
        Me.tabControl1.Controls.Add(Me.TabPage25)
        Me.tabControl1.Controls.Add(Me.tabPage5)
        Me.tabControl1.Controls.Add(Me.tabPage12)
        Me.tabControl1.Controls.Add(Me.tabPage13)
        Me.tabControl1.Controls.Add(Me.TabPage21)
        Me.tabControl1.Controls.Add(Me.TabPage23)
        Me.tabControl1.Controls.Add(Me.TabPage24)
        Me.tabControl1.Controls.Add(Me.TabPage14)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(309, 518)
        Me.tabControl1.TabIndex = 14
        '
        'TabPage20
        '
        Me.TabPage20.Controls.Add(Me.groupBox6)
        Me.TabPage20.Location = New System.Drawing.Point(4, 22)
        Me.TabPage20.Name = "TabPage20"
        Me.TabPage20.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage20.Size = New System.Drawing.Size(301, 492)
        Me.TabPage20.TabIndex = 15
        Me.TabPage20.Text = "Source mode"
        Me.TabPage20.UseVisualStyleBackColor = true
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.rbGPUDirect3D)
        Me.groupBox6.Controls.Add(Me.rbGPUDXVANative)
        Me.groupBox6.Controls.Add(Me.rbGPUDXVACopyBack)
        Me.groupBox6.Controls.Add(Me.rbGPUIntel)
        Me.groupBox6.Controls.Add(Me.rbGPUNVidia)
        Me.groupBox6.Location = New System.Drawing.Point(6, 12)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(280, 108)
        Me.groupBox6.TabIndex = 3
        Me.groupBox6.TabStop = false
        Me.groupBox6.Text = "GPU"
        '
        'rbGPUDirect3D
        '
        Me.rbGPUDirect3D.AutoSize = true
        Me.rbGPUDirect3D.Location = New System.Drawing.Point(13, 73)
        Me.rbGPUDirect3D.Name = "rbGPUDirect3D"
        Me.rbGPUDirect3D.Size = New System.Drawing.Size(82, 17)
        Me.rbGPUDirect3D.TabIndex = 4
        Me.rbGPUDirect3D.Text = "Direct3D 11"
        Me.rbGPUDirect3D.UseVisualStyleBackColor = true
        '
        'rbGPUDXVANative
        '
        Me.rbGPUDXVANative.AutoSize = true
        Me.rbGPUDXVANative.Location = New System.Drawing.Point(131, 50)
        Me.rbGPUDXVANative.Name = "rbGPUDXVANative"
        Me.rbGPUDXVANative.Size = New System.Drawing.Size(98, 17)
        Me.rbGPUDXVANative.TabIndex = 3
        Me.rbGPUDXVANative.Text = "DXVA2 (native)"
        Me.rbGPUDXVANative.UseVisualStyleBackColor = true
        '
        'rbGPUDXVACopyBack
        '
        Me.rbGPUDXVACopyBack.AutoSize = true
        Me.rbGPUDXVACopyBack.Checked = true
        Me.rbGPUDXVACopyBack.Location = New System.Drawing.Point(13, 50)
        Me.rbGPUDXVACopyBack.Name = "rbGPUDXVACopyBack"
        Me.rbGPUDXVACopyBack.Size = New System.Drawing.Size(119, 17)
        Me.rbGPUDXVACopyBack.TabIndex = 2
        Me.rbGPUDXVACopyBack.TabStop = true
        Me.rbGPUDXVACopyBack.Text = "DXVA2 (copy-back)"
        Me.rbGPUDXVACopyBack.UseVisualStyleBackColor = true
        '
        'rbGPUIntel
        '
        Me.rbGPUIntel.AutoSize = true
        Me.rbGPUIntel.Location = New System.Drawing.Point(131, 27)
        Me.rbGPUIntel.Name = "rbGPUIntel"
        Me.rbGPUIntel.Size = New System.Drawing.Size(100, 17)
        Me.rbGPUIntel.TabIndex = 1
        Me.rbGPUIntel.Text = "Intel QuickSync"
        Me.rbGPUIntel.UseVisualStyleBackColor = true
        '
        'rbGPUNVidia
        '
        Me.rbGPUNVidia.AutoSize = true
        Me.rbGPUNVidia.Location = New System.Drawing.Point(13, 27)
        Me.rbGPUNVidia.Name = "rbGPUNVidia"
        Me.rbGPUNVidia.Size = New System.Drawing.Size(90, 17)
        Me.rbGPUNVidia.TabIndex = 0
        Me.rbGPUNVidia.Text = "nVidia CUVID"
        Me.rbGPUNVidia.UseVisualStyleBackColor = true
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.cbUseLibMediaInfo)
        Me.tabPage1.Controls.Add(Me.btReadInfo)
        Me.tabPage1.Controls.Add(Me.tabControl2)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(301, 492)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Info"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'cbUseLibMediaInfo
        '
        Me.cbUseLibMediaInfo.AutoSize = true
        Me.cbUseLibMediaInfo.Checked = true
        Me.cbUseLibMediaInfo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUseLibMediaInfo.Location = New System.Drawing.Point(16, 375)
        Me.cbUseLibMediaInfo.Name = "cbUseLibMediaInfo"
        Me.cbUseLibMediaInfo.Size = New System.Drawing.Size(105, 17)
        Me.cbUseLibMediaInfo.TabIndex = 3
        Me.cbUseLibMediaInfo.Text = "Use libMediaInfo"
        Me.cbUseLibMediaInfo.UseVisualStyleBackColor = true
        '
        'btReadInfo
        '
        Me.btReadInfo.Location = New System.Drawing.Point(15, 438)
        Me.btReadInfo.Name = "btReadInfo"
        Me.btReadInfo.Size = New System.Drawing.Size(75, 23)
        Me.btReadInfo.TabIndex = 1
        Me.btReadInfo.Text = "Read info"
        Me.btReadInfo.UseVisualStyleBackColor = true
        '
        'tabControl2
        '
        Me.tabControl2.Controls.Add(Me.tabPage6)
        Me.tabControl2.Controls.Add(Me.tabPage7)
        Me.tabControl2.Controls.Add(Me.TabPage47)
        Me.tabControl2.Location = New System.Drawing.Point(16, 16)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New System.Drawing.Size(272, 342)
        Me.tabControl2.TabIndex = 0
        '
        'tabPage6
        '
        Me.tabPage6.Controls.Add(Me.mmInfo)
        Me.tabPage6.Location = New System.Drawing.Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage6.Size = New System.Drawing.Size(264, 316)
        Me.tabPage6.TabIndex = 0
        Me.tabPage6.Text = "File"
        Me.tabPage6.UseVisualStyleBackColor = true
        '
        'mmInfo
        '
        Me.mmInfo.Location = New System.Drawing.Point(16, 20)
        Me.mmInfo.Multiline = true
        Me.mmInfo.Name = "mmInfo"
        Me.mmInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmInfo.Size = New System.Drawing.Size(232, 234)
        Me.mmInfo.TabIndex = 0
        '
        'tabPage7
        '
        Me.tabPage7.Controls.Add(Me.lbDVDTitles)
        Me.tabPage7.Controls.Add(Me.cbDVDSubtitles)
        Me.tabPage7.Controls.Add(Me.label4)
        Me.tabPage7.Controls.Add(Me.cbDVDAudio)
        Me.tabPage7.Controls.Add(Me.label3)
        Me.tabPage7.Controls.Add(Me.edDVDVideo)
        Me.tabPage7.Controls.Add(Me.label2)
        Me.tabPage7.Controls.Add(Me.label1)
        Me.tabPage7.Location = New System.Drawing.Point(4, 22)
        Me.tabPage7.Name = "tabPage7"
        Me.tabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage7.Size = New System.Drawing.Size(264, 316)
        Me.tabPage7.TabIndex = 1
        Me.tabPage7.Text = "DVD"
        Me.tabPage7.UseVisualStyleBackColor = true
        '
        'lbDVDTitles
        '
        Me.lbDVDTitles.FormattingEnabled = true
        Me.lbDVDTitles.Location = New System.Drawing.Point(18, 35)
        Me.lbDVDTitles.Name = "lbDVDTitles"
        Me.lbDVDTitles.Size = New System.Drawing.Size(229, 121)
        Me.lbDVDTitles.TabIndex = 8
        '
        'cbDVDSubtitles
        '
        Me.cbDVDSubtitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDSubtitles.FormattingEnabled = true
        Me.cbDVDSubtitles.Location = New System.Drawing.Point(18, 275)
        Me.cbDVDSubtitles.Name = "cbDVDSubtitles"
        Me.cbDVDSubtitles.Size = New System.Drawing.Size(229, 21)
        Me.cbDVDSubtitles.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(15, 259)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Subtitles"
        '
        'cbDVDAudio
        '
        Me.cbDVDAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDVDAudio.FormattingEnabled = true
        Me.cbDVDAudio.Location = New System.Drawing.Point(18, 224)
        Me.cbDVDAudio.Name = "cbDVDAudio"
        Me.cbDVDAudio.Size = New System.Drawing.Size(229, 21)
        Me.cbDVDAudio.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(15, 208)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Audio streams"
        '
        'edDVDVideo
        '
        Me.edDVDVideo.Location = New System.Drawing.Point(18, 176)
        Me.edDVDVideo.Name = "edDVDVideo"
        Me.edDVDVideo.Size = New System.Drawing.Size(229, 20)
        Me.edDVDVideo.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(15, 160)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(34, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Video"
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(15, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Titles"
        '
        'TabPage47
        '
        Me.TabPage47.Controls.Add(Me.imgTags)
        Me.TabPage47.Controls.Add(Me.edTags)
        Me.TabPage47.Controls.Add(Me.btReadTags)
        Me.TabPage47.Location = New System.Drawing.Point(4, 22)
        Me.TabPage47.Name = "TabPage47"
        Me.TabPage47.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage47.Size = New System.Drawing.Size(264, 316)
        Me.TabPage47.TabIndex = 2
        Me.TabPage47.Text = "Tags"
        Me.TabPage47.UseVisualStyleBackColor = true
        '
        'imgTags
        '
        Me.imgTags.Location = New System.Drawing.Point(158, 210)
        Me.imgTags.Name = "imgTags"
        Me.imgTags.Size = New System.Drawing.Size(90, 90)
        Me.imgTags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTags.TabIndex = 5
        Me.imgTags.TabStop = false
        '
        'edTags
        '
        Me.edTags.Location = New System.Drawing.Point(16, 16)
        Me.edTags.Multiline = true
        Me.edTags.Name = "edTags"
        Me.edTags.Size = New System.Drawing.Size(232, 188)
        Me.edTags.TabIndex = 4
        '
        'btReadTags
        '
        Me.btReadTags.Location = New System.Drawing.Point(16, 277)
        Me.btReadTags.Name = "btReadTags"
        Me.btReadTags.Size = New System.Drawing.Size(75, 23)
        Me.btReadTags.TabIndex = 3
        Me.btReadTags.Text = "Read tags"
        Me.btReadTags.UseVisualStyleBackColor = true
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.label10)
        Me.tabPage2.Controls.Add(Me.tbBalance4)
        Me.tabPage2.Controls.Add(Me.label11)
        Me.tabPage2.Controls.Add(Me.tbVolume4)
        Me.tabPage2.Controls.Add(Me.cbAudioStream4)
        Me.tabPage2.Controls.Add(Me.label12)
        Me.tabPage2.Controls.Add(Me.tbBalance3)
        Me.tabPage2.Controls.Add(Me.label13)
        Me.tabPage2.Controls.Add(Me.tbVolume3)
        Me.tabPage2.Controls.Add(Me.cbAudioStream3)
        Me.tabPage2.Controls.Add(Me.label8)
        Me.tabPage2.Controls.Add(Me.tbBalance2)
        Me.tabPage2.Controls.Add(Me.label9)
        Me.tabPage2.Controls.Add(Me.tbVolume2)
        Me.tabPage2.Controls.Add(Me.cbAudioStream2)
        Me.tabPage2.Controls.Add(Me.label7)
        Me.tabPage2.Controls.Add(Me.tbBalance1)
        Me.tabPage2.Controls.Add(Me.label6)
        Me.tabPage2.Controls.Add(Me.tbVolume1)
        Me.tabPage2.Controls.Add(Me.cbAudioStream1)
        Me.tabPage2.Controls.Add(Me.cbPlayAudio)
        Me.tabPage2.Controls.Add(Me.cbAudioOutputDevice)
        Me.tabPage2.Controls.Add(Me.label5)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(301, 492)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Audio output"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'label10
        '
        Me.label10.AutoSize = true
        Me.label10.Location = New System.Drawing.Point(193, 321)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(46, 13)
        Me.label10.TabIndex = 22
        Me.label10.Text = "Balance"
        '
        'tbBalance4
        '
        Me.tbBalance4.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance4.Location = New System.Drawing.Point(196, 337)
        Me.tbBalance4.Maximum = 100
        Me.tbBalance4.Minimum = -100
        Me.tbBalance4.Name = "tbBalance4"
        Me.tbBalance4.Size = New System.Drawing.Size(85, 45)
        Me.tbBalance4.TabIndex = 21
        '
        'label11
        '
        Me.label11.AutoSize = true
        Me.label11.Location = New System.Drawing.Point(100, 321)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(42, 13)
        Me.label11.TabIndex = 20
        Me.label11.Text = "Volume"
        '
        'tbVolume4
        '
        Me.tbVolume4.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume4.Location = New System.Drawing.Point(103, 337)
        Me.tbVolume4.Maximum = 100
        Me.tbVolume4.Name = "tbVolume4"
        Me.tbVolume4.Size = New System.Drawing.Size(85, 45)
        Me.tbVolume4.TabIndex = 19
        Me.tbVolume4.Value = 85
        '
        'cbAudioStream4
        '
        Me.cbAudioStream4.AutoSize = true
        Me.cbAudioStream4.Location = New System.Drawing.Point(19, 306)
        Me.cbAudioStream4.Name = "cbAudioStream4"
        Me.cbAudioStream4.Size = New System.Drawing.Size(68, 17)
        Me.cbAudioStream4.TabIndex = 18
        Me.cbAudioStream4.Text = "Stream 4"
        Me.cbAudioStream4.UseVisualStyleBackColor = true
        '
        'label12
        '
        Me.label12.AutoSize = true
        Me.label12.Location = New System.Drawing.Point(193, 254)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(46, 13)
        Me.label12.TabIndex = 17
        Me.label12.Text = "Balance"
        '
        'tbBalance3
        '
        Me.tbBalance3.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance3.Location = New System.Drawing.Point(196, 270)
        Me.tbBalance3.Maximum = 100
        Me.tbBalance3.Minimum = -100
        Me.tbBalance3.Name = "tbBalance3"
        Me.tbBalance3.Size = New System.Drawing.Size(85, 45)
        Me.tbBalance3.TabIndex = 16
        '
        'label13
        '
        Me.label13.AutoSize = true
        Me.label13.Location = New System.Drawing.Point(100, 254)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(42, 13)
        Me.label13.TabIndex = 15
        Me.label13.Text = "Volume"
        '
        'tbVolume3
        '
        Me.tbVolume3.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume3.Location = New System.Drawing.Point(103, 270)
        Me.tbVolume3.Maximum = 100
        Me.tbVolume3.Name = "tbVolume3"
        Me.tbVolume3.Size = New System.Drawing.Size(85, 45)
        Me.tbVolume3.TabIndex = 14
        Me.tbVolume3.Value = 80
        '
        'cbAudioStream3
        '
        Me.cbAudioStream3.AutoSize = true
        Me.cbAudioStream3.Location = New System.Drawing.Point(19, 239)
        Me.cbAudioStream3.Name = "cbAudioStream3"
        Me.cbAudioStream3.Size = New System.Drawing.Size(68, 17)
        Me.cbAudioStream3.TabIndex = 13
        Me.cbAudioStream3.Text = "Stream 3"
        Me.cbAudioStream3.UseVisualStyleBackColor = true
        '
        'label8
        '
        Me.label8.AutoSize = true
        Me.label8.Location = New System.Drawing.Point(193, 186)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(46, 13)
        Me.label8.TabIndex = 12
        Me.label8.Text = "Balance"
        '
        'tbBalance2
        '
        Me.tbBalance2.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance2.Location = New System.Drawing.Point(196, 202)
        Me.tbBalance2.Maximum = 100
        Me.tbBalance2.Minimum = -100
        Me.tbBalance2.Name = "tbBalance2"
        Me.tbBalance2.Size = New System.Drawing.Size(85, 45)
        Me.tbBalance2.TabIndex = 11
        '
        'label9
        '
        Me.label9.AutoSize = true
        Me.label9.Location = New System.Drawing.Point(100, 186)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(42, 13)
        Me.label9.TabIndex = 10
        Me.label9.Text = "Volume"
        '
        'tbVolume2
        '
        Me.tbVolume2.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume2.Location = New System.Drawing.Point(103, 202)
        Me.tbVolume2.Maximum = 100
        Me.tbVolume2.Name = "tbVolume2"
        Me.tbVolume2.Size = New System.Drawing.Size(85, 45)
        Me.tbVolume2.TabIndex = 9
        Me.tbVolume2.Value = 80
        '
        'cbAudioStream2
        '
        Me.cbAudioStream2.AutoSize = true
        Me.cbAudioStream2.Location = New System.Drawing.Point(19, 171)
        Me.cbAudioStream2.Name = "cbAudioStream2"
        Me.cbAudioStream2.Size = New System.Drawing.Size(68, 17)
        Me.cbAudioStream2.TabIndex = 8
        Me.cbAudioStream2.Text = "Stream 2"
        Me.cbAudioStream2.UseVisualStyleBackColor = true
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Location = New System.Drawing.Point(193, 122)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(46, 13)
        Me.label7.TabIndex = 7
        Me.label7.Text = "Balance"
        '
        'tbBalance1
        '
        Me.tbBalance1.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance1.Location = New System.Drawing.Point(196, 138)
        Me.tbBalance1.Maximum = 100
        Me.tbBalance1.Minimum = -100
        Me.tbBalance1.Name = "tbBalance1"
        Me.tbBalance1.Size = New System.Drawing.Size(85, 45)
        Me.tbBalance1.TabIndex = 6
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(100, 122)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Volume"
        '
        'tbVolume1
        '
        Me.tbVolume1.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume1.Location = New System.Drawing.Point(103, 138)
        Me.tbVolume1.Maximum = 100
        Me.tbVolume1.Name = "tbVolume1"
        Me.tbVolume1.Size = New System.Drawing.Size(85, 45)
        Me.tbVolume1.TabIndex = 4
        Me.tbVolume1.Value = 80
        '
        'cbAudioStream1
        '
        Me.cbAudioStream1.AutoSize = true
        Me.cbAudioStream1.Location = New System.Drawing.Point(19, 107)
        Me.cbAudioStream1.Name = "cbAudioStream1"
        Me.cbAudioStream1.Size = New System.Drawing.Size(68, 17)
        Me.cbAudioStream1.TabIndex = 3
        Me.cbAudioStream1.Text = "Stream 1"
        Me.cbAudioStream1.UseVisualStyleBackColor = true
        '
        'cbPlayAudio
        '
        Me.cbPlayAudio.AutoSize = true
        Me.cbPlayAudio.Checked = true
        Me.cbPlayAudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPlayAudio.Location = New System.Drawing.Point(19, 62)
        Me.cbPlayAudio.Name = "cbPlayAudio"
        Me.cbPlayAudio.Size = New System.Drawing.Size(75, 17)
        Me.cbPlayAudio.TabIndex = 2
        Me.cbPlayAudio.Text = "Play audio"
        Me.cbPlayAudio.UseVisualStyleBackColor = true
        '
        'cbAudioOutputDevice
        '
        Me.cbAudioOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAudioOutputDevice.FormattingEnabled = true
        Me.cbAudioOutputDevice.Location = New System.Drawing.Point(19, 35)
        Me.cbAudioOutputDevice.Name = "cbAudioOutputDevice"
        Me.cbAudioOutputDevice.Size = New System.Drawing.Size(262, 21)
        Me.cbAudioOutputDevice.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(16, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Audio output"
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.tabControl4)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(301, 492)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Display"
        Me.tabPage3.UseVisualStyleBackColor = true
        '
        'tabControl4
        '
        Me.tabControl4.Controls.Add(Me.tabPage16)
        Me.tabControl4.Controls.Add(Me.tabPage17)
        Me.tabControl4.Location = New System.Drawing.Point(4, 6)
        Me.tabControl4.Name = "tabControl4"
        Me.tabControl4.SelectedIndex = 0
        Me.tabControl4.Size = New System.Drawing.Size(292, 480)
        Me.tabControl4.TabIndex = 18
        '
        'tabPage16
        '
        Me.tabPage16.Controls.Add(Me.label393)
        Me.tabPage16.Controls.Add(Me.cbDirect2DRotate)
        Me.tabPage16.Controls.Add(Me.pnVideoRendererBGColor)
        Me.tabPage16.Controls.Add(Me.label394)
        Me.tabPage16.Controls.Add(Me.btFullScreen)
        Me.tabPage16.Controls.Add(Me.groupBox28)
        Me.tabPage16.Controls.Add(Me.cbScreenFlipVertical)
        Me.tabPage16.Controls.Add(Me.cbScreenFlipHorizontal)
        Me.tabPage16.Controls.Add(Me.cbStretch)
        Me.tabPage16.Controls.Add(Me.groupBox13)
        Me.tabPage16.Controls.Add(Me.label15)
        Me.tabPage16.Controls.Add(Me.edAspectRatioY)
        Me.tabPage16.Controls.Add(Me.edAspectRatioX)
        Me.tabPage16.Controls.Add(Me.cbAspectRatioUseCustom)
        Me.tabPage16.Location = New System.Drawing.Point(4, 22)
        Me.tabPage16.Name = "tabPage16"
        Me.tabPage16.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage16.Size = New System.Drawing.Size(284, 454)
        Me.tabPage16.TabIndex = 0
        Me.tabPage16.Text = "Main"
        Me.tabPage16.UseVisualStyleBackColor = true
        '
        'label393
        '
        Me.label393.AutoSize = true
        Me.label393.Location = New System.Drawing.Point(144, 312)
        Me.label393.Name = "label393"
        Me.label393.Size = New System.Drawing.Size(79, 13)
        Me.label393.TabIndex = 50
        Me.label393.Text = "Direct2D rotate"
        '
        'cbDirect2DRotate
        '
        Me.cbDirect2DRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDirect2DRotate.FormattingEnabled = true
        Me.cbDirect2DRotate.Items.AddRange(New Object() {"0", "90", "180", "270"})
        Me.cbDirect2DRotate.Location = New System.Drawing.Point(147, 328)
        Me.cbDirect2DRotate.Name = "cbDirect2DRotate"
        Me.cbDirect2DRotate.Size = New System.Drawing.Size(122, 21)
        Me.cbDirect2DRotate.TabIndex = 49
        '
        'pnVideoRendererBGColor
        '
        Me.pnVideoRendererBGColor.BackColor = System.Drawing.Color.Black
        Me.pnVideoRendererBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnVideoRendererBGColor.Location = New System.Drawing.Point(123, 213)
        Me.pnVideoRendererBGColor.Name = "pnVideoRendererBGColor"
        Me.pnVideoRendererBGColor.Size = New System.Drawing.Size(24, 24)
        Me.pnVideoRendererBGColor.TabIndex = 48
        '
        'label394
        '
        Me.label394.AutoSize = true
        Me.label394.Location = New System.Drawing.Point(16, 218)
        Me.label394.Name = "label394"
        Me.label394.Size = New System.Drawing.Size(91, 13)
        Me.label394.TabIndex = 47
        Me.label394.Text = "Background color"
        '
        'btFullScreen
        '
        Me.btFullScreen.Location = New System.Drawing.Point(147, 355)
        Me.btFullScreen.Name = "btFullScreen"
        Me.btFullScreen.Size = New System.Drawing.Size(122, 23)
        Me.btFullScreen.TabIndex = 46
        Me.btFullScreen.Text = "Full screen"
        Me.btFullScreen.UseVisualStyleBackColor = true
        '
        'groupBox28
        '
        Me.groupBox28.Controls.Add(Me.btZoomReset)
        Me.groupBox28.Controls.Add(Me.btZoomShiftRight)
        Me.groupBox28.Controls.Add(Me.btZoomShiftLeft)
        Me.groupBox28.Controls.Add(Me.btZoomOut)
        Me.groupBox28.Controls.Add(Me.btZoomIn)
        Me.groupBox28.Controls.Add(Me.btZoomShiftDown)
        Me.groupBox28.Controls.Add(Me.btZoomShiftUp)
        Me.groupBox28.Location = New System.Drawing.Point(19, 312)
        Me.groupBox28.Name = "groupBox28"
        Me.groupBox28.Size = New System.Drawing.Size(119, 129)
        Me.groupBox28.TabIndex = 45
        Me.groupBox28.TabStop = false
        Me.groupBox28.Text = "Zoom"
        '
        'btZoomReset
        '
        Me.btZoomReset.Location = New System.Drawing.Point(34, 99)
        Me.btZoomReset.Name = "btZoomReset"
        Me.btZoomReset.Size = New System.Drawing.Size(51, 23)
        Me.btZoomReset.TabIndex = 6
        Me.btZoomReset.Text = "Reset"
        Me.btZoomReset.UseVisualStyleBackColor = true
        '
        'btZoomShiftRight
        '
        Me.btZoomShiftRight.Location = New System.Drawing.Point(85, 33)
        Me.btZoomShiftRight.Name = "btZoomShiftRight"
        Me.btZoomShiftRight.Size = New System.Drawing.Size(21, 48)
        Me.btZoomShiftRight.TabIndex = 5
        Me.btZoomShiftRight.Text = "R"
        Me.btZoomShiftRight.UseVisualStyleBackColor = true
        '
        'btZoomShiftLeft
        '
        Me.btZoomShiftLeft.Location = New System.Drawing.Point(13, 32)
        Me.btZoomShiftLeft.Name = "btZoomShiftLeft"
        Me.btZoomShiftLeft.Size = New System.Drawing.Size(21, 48)
        Me.btZoomShiftLeft.TabIndex = 4
        Me.btZoomShiftLeft.Text = "L"
        Me.btZoomShiftLeft.UseVisualStyleBackColor = true
        '
        'btZoomOut
        '
        Me.btZoomOut.Location = New System.Drawing.Point(61, 45)
        Me.btZoomOut.Name = "btZoomOut"
        Me.btZoomOut.Size = New System.Drawing.Size(23, 23)
        Me.btZoomOut.TabIndex = 3
        Me.btZoomOut.Text = "-"
        Me.btZoomOut.UseVisualStyleBackColor = true
        '
        'btZoomIn
        '
        Me.btZoomIn.Location = New System.Drawing.Point(35, 45)
        Me.btZoomIn.Name = "btZoomIn"
        Me.btZoomIn.Size = New System.Drawing.Size(22, 23)
        Me.btZoomIn.TabIndex = 2
        Me.btZoomIn.Text = "+"
        Me.btZoomIn.UseVisualStyleBackColor = true
        '
        'btZoomShiftDown
        '
        Me.btZoomShiftDown.Location = New System.Drawing.Point(34, 70)
        Me.btZoomShiftDown.Name = "btZoomShiftDown"
        Me.btZoomShiftDown.Size = New System.Drawing.Size(51, 23)
        Me.btZoomShiftDown.TabIndex = 1
        Me.btZoomShiftDown.Text = "Down"
        Me.btZoomShiftDown.UseVisualStyleBackColor = true
        '
        'btZoomShiftUp
        '
        Me.btZoomShiftUp.Location = New System.Drawing.Point(34, 20)
        Me.btZoomShiftUp.Name = "btZoomShiftUp"
        Me.btZoomShiftUp.Size = New System.Drawing.Size(51, 23)
        Me.btZoomShiftUp.TabIndex = 0
        Me.btZoomShiftUp.Text = "Up"
        Me.btZoomShiftUp.UseVisualStyleBackColor = true
        '
        'cbScreenFlipVertical
        '
        Me.cbScreenFlipVertical.AutoSize = true
        Me.cbScreenFlipVertical.Location = New System.Drawing.Point(179, 237)
        Me.cbScreenFlipVertical.Name = "cbScreenFlipVertical"
        Me.cbScreenFlipVertical.Size = New System.Drawing.Size(79, 17)
        Me.cbScreenFlipVertical.TabIndex = 44
        Me.cbScreenFlipVertical.Text = "Flip vertical"
        Me.cbScreenFlipVertical.UseVisualStyleBackColor = true
        '
        'cbScreenFlipHorizontal
        '
        Me.cbScreenFlipHorizontal.AutoSize = true
        Me.cbScreenFlipHorizontal.Location = New System.Drawing.Point(179, 214)
        Me.cbScreenFlipHorizontal.Name = "cbScreenFlipHorizontal"
        Me.cbScreenFlipHorizontal.Size = New System.Drawing.Size(90, 17)
        Me.cbScreenFlipHorizontal.TabIndex = 43
        Me.cbScreenFlipHorizontal.Text = "Flip horizontal"
        Me.cbScreenFlipHorizontal.UseVisualStyleBackColor = true
        '
        'cbStretch
        '
        Me.cbStretch.AutoSize = true
        Me.cbStretch.Location = New System.Drawing.Point(179, 262)
        Me.cbStretch.Name = "cbStretch"
        Me.cbStretch.Size = New System.Drawing.Size(89, 17)
        Me.cbStretch.TabIndex = 42
        Me.cbStretch.Text = "Stretch video"
        Me.cbStretch.UseVisualStyleBackColor = true
        '
        'groupBox13
        '
        Me.groupBox13.Controls.Add(Me.rbVirtualCameraOutput)
        Me.groupBox13.Controls.Add(Me.rbDirect2D)
        Me.groupBox13.Controls.Add(Me.rbNone)
        Me.groupBox13.Controls.Add(Me.rbEVR)
        Me.groupBox13.Controls.Add(Me.rbVMR9)
        Me.groupBox13.Controls.Add(Me.rbVR)
        Me.groupBox13.Location = New System.Drawing.Point(19, 11)
        Me.groupBox13.Name = "groupBox13"
        Me.groupBox13.Size = New System.Drawing.Size(250, 172)
        Me.groupBox13.TabIndex = 41
        Me.groupBox13.TabStop = false
        Me.groupBox13.Text = "Video Renderer"
        '
        'rbVirtualCameraOutput
        '
        Me.rbVirtualCameraOutput.AutoSize = true
        Me.rbVirtualCameraOutput.Location = New System.Drawing.Point(12, 136)
        Me.rbVirtualCameraOutput.Name = "rbVirtualCameraOutput"
        Me.rbVirtualCameraOutput.Size = New System.Drawing.Size(165, 17)
        Me.rbVirtualCameraOutput.TabIndex = 7
        Me.rbVirtualCameraOutput.TabStop = true
        Me.rbVirtualCameraOutput.Text = "Output to Virtual Camera SDK"
        Me.rbVirtualCameraOutput.UseVisualStyleBackColor = true
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
        'label15
        '
        Me.label15.AutoSize = true
        Me.label15.Location = New System.Drawing.Point(71, 288)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(12, 13)
        Me.label15.TabIndex = 40
        Me.label15.Text = "x"
        '
        'edAspectRatioY
        '
        Me.edAspectRatioY.Location = New System.Drawing.Point(85, 285)
        Me.edAspectRatioY.Name = "edAspectRatioY"
        Me.edAspectRatioY.Size = New System.Drawing.Size(30, 20)
        Me.edAspectRatioY.TabIndex = 39
        Me.edAspectRatioY.Text = "9"
        '
        'edAspectRatioX
        '
        Me.edAspectRatioX.Location = New System.Drawing.Point(36, 285)
        Me.edAspectRatioX.Name = "edAspectRatioX"
        Me.edAspectRatioX.Size = New System.Drawing.Size(30, 20)
        Me.edAspectRatioX.TabIndex = 38
        Me.edAspectRatioX.Text = "16"
        '
        'cbAspectRatioUseCustom
        '
        Me.cbAspectRatioUseCustom.AutoSize = true
        Me.cbAspectRatioUseCustom.Location = New System.Drawing.Point(19, 262)
        Me.cbAspectRatioUseCustom.Name = "cbAspectRatioUseCustom"
        Me.cbAspectRatioUseCustom.Size = New System.Drawing.Size(140, 17)
        Me.cbAspectRatioUseCustom.TabIndex = 37
        Me.cbAspectRatioUseCustom.Text = "Use custom aspect ratio"
        Me.cbAspectRatioUseCustom.UseVisualStyleBackColor = true
        '
        'tabPage17
        '
        Me.tabPage17.Controls.Add(Me.cbMultiscreenDrawOnExternalDisplays)
        Me.tabPage17.Controls.Add(Me.cbMultiscreenDrawOnPanels)
        Me.tabPage17.Controls.Add(Me.cbFlipHorizontal2)
        Me.tabPage17.Controls.Add(Me.cbFlipVertical2)
        Me.tabPage17.Controls.Add(Me.cbStretch2)
        Me.tabPage17.Controls.Add(Me.cbFlipHorizontal1)
        Me.tabPage17.Controls.Add(Me.cbFlipVertical1)
        Me.tabPage17.Controls.Add(Me.cbStretch1)
        Me.tabPage17.Controls.Add(Me.pnScreen2)
        Me.tabPage17.Controls.Add(Me.pnScreen1)
        Me.tabPage17.Location = New System.Drawing.Point(4, 22)
        Me.tabPage17.Name = "tabPage17"
        Me.tabPage17.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage17.Size = New System.Drawing.Size(284, 454)
        Me.tabPage17.TabIndex = 1
        Me.tabPage17.Text = "Multiscreen"
        Me.tabPage17.UseVisualStyleBackColor = true
        '
        'cbMultiscreenDrawOnExternalDisplays
        '
        Me.cbMultiscreenDrawOnExternalDisplays.AutoSize = true
        Me.cbMultiscreenDrawOnExternalDisplays.Location = New System.Drawing.Point(10, 33)
        Me.cbMultiscreenDrawOnExternalDisplays.Name = "cbMultiscreenDrawOnExternalDisplays"
        Me.cbMultiscreenDrawOnExternalDisplays.Size = New System.Drawing.Size(175, 17)
        Me.cbMultiscreenDrawOnExternalDisplays.TabIndex = 23
        Me.cbMultiscreenDrawOnExternalDisplays.Text = "Draw video on external displays"
        Me.cbMultiscreenDrawOnExternalDisplays.UseVisualStyleBackColor = true
        '
        'cbMultiscreenDrawOnPanels
        '
        Me.cbMultiscreenDrawOnPanels.AutoSize = true
        Me.cbMultiscreenDrawOnPanels.Location = New System.Drawing.Point(10, 10)
        Me.cbMultiscreenDrawOnPanels.Name = "cbMultiscreenDrawOnPanels"
        Me.cbMultiscreenDrawOnPanels.Size = New System.Drawing.Size(129, 17)
        Me.cbMultiscreenDrawOnPanels.TabIndex = 22
        Me.cbMultiscreenDrawOnPanels.Text = "Draw video on panels"
        Me.cbMultiscreenDrawOnPanels.UseVisualStyleBackColor = true
        '
        'cbFlipHorizontal2
        '
        Me.cbFlipHorizontal2.AutoSize = true
        Me.cbFlipHorizontal2.Location = New System.Drawing.Point(162, 431)
        Me.cbFlipHorizontal2.Name = "cbFlipHorizontal2"
        Me.cbFlipHorizontal2.Size = New System.Drawing.Size(90, 17)
        Me.cbFlipHorizontal2.TabIndex = 21
        Me.cbFlipHorizontal2.Text = "Flip horizontal"
        Me.cbFlipHorizontal2.UseVisualStyleBackColor = true
        '
        'cbFlipVertical2
        '
        Me.cbFlipVertical2.AutoSize = true
        Me.cbFlipVertical2.Location = New System.Drawing.Point(76, 431)
        Me.cbFlipVertical2.Name = "cbFlipVertical2"
        Me.cbFlipVertical2.Size = New System.Drawing.Size(79, 17)
        Me.cbFlipVertical2.TabIndex = 20
        Me.cbFlipVertical2.Text = "Flip vertical"
        Me.cbFlipVertical2.UseVisualStyleBackColor = true
        '
        'cbStretch2
        '
        Me.cbStretch2.AutoSize = true
        Me.cbStretch2.Location = New System.Drawing.Point(10, 431)
        Me.cbStretch2.Name = "cbStretch2"
        Me.cbStretch2.Size = New System.Drawing.Size(60, 17)
        Me.cbStretch2.TabIndex = 19
        Me.cbStretch2.Text = "Stretch"
        Me.cbStretch2.UseVisualStyleBackColor = true
        '
        'cbFlipHorizontal1
        '
        Me.cbFlipHorizontal1.AutoSize = true
        Me.cbFlipHorizontal1.Location = New System.Drawing.Point(162, 195)
        Me.cbFlipHorizontal1.Name = "cbFlipHorizontal1"
        Me.cbFlipHorizontal1.Size = New System.Drawing.Size(90, 17)
        Me.cbFlipHorizontal1.TabIndex = 18
        Me.cbFlipHorizontal1.Text = "Flip horizontal"
        Me.cbFlipHorizontal1.UseVisualStyleBackColor = true
        '
        'cbFlipVertical1
        '
        Me.cbFlipVertical1.AutoSize = true
        Me.cbFlipVertical1.Location = New System.Drawing.Point(76, 195)
        Me.cbFlipVertical1.Name = "cbFlipVertical1"
        Me.cbFlipVertical1.Size = New System.Drawing.Size(79, 17)
        Me.cbFlipVertical1.TabIndex = 17
        Me.cbFlipVertical1.Text = "Flip vertical"
        Me.cbFlipVertical1.UseVisualStyleBackColor = true
        '
        'cbStretch1
        '
        Me.cbStretch1.AutoSize = true
        Me.cbStretch1.Location = New System.Drawing.Point(10, 195)
        Me.cbStretch1.Name = "cbStretch1"
        Me.cbStretch1.Size = New System.Drawing.Size(60, 17)
        Me.cbStretch1.TabIndex = 16
        Me.cbStretch1.Text = "Stretch"
        Me.cbStretch1.UseVisualStyleBackColor = true
        '
        'pnScreen2
        '
        Me.pnScreen2.BackColor = System.Drawing.Color.Black
        Me.pnScreen2.Location = New System.Drawing.Point(10, 218)
        Me.pnScreen2.Name = "pnScreen2"
        Me.pnScreen2.Size = New System.Drawing.Size(245, 204)
        Me.pnScreen2.TabIndex = 15
        '
        'pnScreen1
        '
        Me.pnScreen1.BackColor = System.Drawing.Color.Black
        Me.pnScreen1.Location = New System.Drawing.Point(39, 56)
        Me.pnScreen1.Name = "pnScreen1"
        Me.pnScreen1.Size = New System.Drawing.Size(181, 133)
        Me.pnScreen1.TabIndex = 13
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.tabControl17)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(301, 492)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Video processing"
        Me.tabPage4.UseVisualStyleBackColor = true
        '
        'tabControl17
        '
        Me.tabControl17.Controls.Add(Me.tabPage68)
        Me.tabControl17.Controls.Add(Me.tabPage69)
        Me.tabControl17.Controls.Add(Me.tabPage59)
        Me.tabControl17.Controls.Add(Me.TabPage50)
        Me.tabControl17.Controls.Add(Me.tabPage8)
        Me.tabControl17.Controls.Add(Me.tabPage15)
        Me.tabControl17.Controls.Add(Me.TabPage28)
        Me.tabControl17.Location = New System.Drawing.Point(0, 6)
        Me.tabControl17.Name = "tabControl17"
        Me.tabControl17.SelectedIndex = 0
        Me.tabControl17.Size = New System.Drawing.Size(298, 485)
        Me.tabControl17.TabIndex = 37
        '
        'tabPage68
        '
        Me.tabPage68.Controls.Add(Me.cbFlipY)
        Me.tabPage68.Controls.Add(Me.cbFlipX)
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
        'cbFlipY
        '
        Me.cbFlipY.AutoSize = true
        Me.cbFlipY.Location = New System.Drawing.Point(210, 158)
        Me.cbFlipY.Name = "cbFlipY"
        Me.cbFlipY.Size = New System.Drawing.Size(52, 17)
        Me.cbFlipY.TabIndex = 71
        Me.cbFlipY.Text = "Flip Y"
        Me.cbFlipY.UseVisualStyleBackColor = true
        '
        'cbFlipX
        '
        Me.cbFlipX.AutoSize = true
        Me.cbFlipX.Location = New System.Drawing.Point(148, 158)
        Me.cbFlipX.Name = "cbFlipX"
        Me.cbFlipX.Size = New System.Drawing.Size(52, 17)
        Me.cbFlipX.TabIndex = 70
        Me.cbFlipX.Text = "Flip X"
        Me.cbFlipX.UseVisualStyleBackColor = true
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
        Me.tabControl7.Controls.Add(Me.TabPage18)
        Me.tabControl7.Controls.Add(Me.TabPage19)
        Me.tabControl7.Controls.Add(Me.TabPage22)
        Me.tabControl7.Controls.Add(Me.TabPage27)
        Me.tabControl7.Location = New System.Drawing.Point(3, 185)
        Me.tabControl7.Name = "tabControl7"
        Me.tabControl7.SelectedIndex = 0
        Me.tabControl7.Size = New System.Drawing.Size(283, 274)
        Me.tabControl7.TabIndex = 59
        '
        'tabPage29
        '
        Me.tabPage29.Controls.Add(Me.btTextLogoRemove)
        Me.tabPage29.Controls.Add(Me.btTextLogoEdit)
        Me.tabPage29.Controls.Add(Me.lbTextLogos)
        Me.tabPage29.Controls.Add(Me.btTextLogoAdd)
        Me.tabPage29.Location = New System.Drawing.Point(4, 22)
        Me.tabPage29.Name = "tabPage29"
        Me.tabPage29.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage29.Size = New System.Drawing.Size(275, 248)
        Me.tabPage29.TabIndex = 0
        Me.tabPage29.Text = "Text logo"
        Me.tabPage29.UseVisualStyleBackColor = true
        '
        'btTextLogoRemove
        '
        Me.btTextLogoRemove.Location = New System.Drawing.Point(208, 215)
        Me.btTextLogoRemove.Name = "btTextLogoRemove"
        Me.btTextLogoRemove.Size = New System.Drawing.Size(59, 23)
        Me.btTextLogoRemove.TabIndex = 11
        Me.btTextLogoRemove.Text = "Remove"
        Me.btTextLogoRemove.UseVisualStyleBackColor = true
        '
        'btTextLogoEdit
        '
        Me.btTextLogoEdit.Location = New System.Drawing.Point(74, 215)
        Me.btTextLogoEdit.Name = "btTextLogoEdit"
        Me.btTextLogoEdit.Size = New System.Drawing.Size(59, 23)
        Me.btTextLogoEdit.TabIndex = 10
        Me.btTextLogoEdit.Text = "Edit"
        Me.btTextLogoEdit.UseVisualStyleBackColor = true
        '
        'lbTextLogos
        '
        Me.lbTextLogos.FormattingEnabled = true
        Me.lbTextLogos.Location = New System.Drawing.Point(10, 12)
        Me.lbTextLogos.Name = "lbTextLogos"
        Me.lbTextLogos.Size = New System.Drawing.Size(257, 199)
        Me.lbTextLogos.TabIndex = 9
        '
        'btTextLogoAdd
        '
        Me.btTextLogoAdd.Location = New System.Drawing.Point(8, 215)
        Me.btTextLogoAdd.Name = "btTextLogoAdd"
        Me.btTextLogoAdd.Size = New System.Drawing.Size(59, 23)
        Me.btTextLogoAdd.TabIndex = 8
        Me.btTextLogoAdd.Text = "Add"
        Me.btTextLogoAdd.UseVisualStyleBackColor = true
        '
        'tabPage42
        '
        Me.tabPage42.Controls.Add(Me.btImageLogoRemove)
        Me.tabPage42.Controls.Add(Me.btImageLogoEdit)
        Me.tabPage42.Controls.Add(Me.lbImageLogos)
        Me.tabPage42.Controls.Add(Me.btImageLogoAdd)
        Me.tabPage42.Location = New System.Drawing.Point(4, 22)
        Me.tabPage42.Name = "tabPage42"
        Me.tabPage42.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage42.Size = New System.Drawing.Size(275, 248)
        Me.tabPage42.TabIndex = 1
        Me.tabPage42.Text = "Image logo"
        Me.tabPage42.UseVisualStyleBackColor = true
        '
        'btImageLogoRemove
        '
        Me.btImageLogoRemove.Location = New System.Drawing.Point(208, 215)
        Me.btImageLogoRemove.Name = "btImageLogoRemove"
        Me.btImageLogoRemove.Size = New System.Drawing.Size(59, 23)
        Me.btImageLogoRemove.TabIndex = 15
        Me.btImageLogoRemove.Text = "Remove"
        Me.btImageLogoRemove.UseVisualStyleBackColor = true
        '
        'btImageLogoEdit
        '
        Me.btImageLogoEdit.Location = New System.Drawing.Point(74, 215)
        Me.btImageLogoEdit.Name = "btImageLogoEdit"
        Me.btImageLogoEdit.Size = New System.Drawing.Size(59, 23)
        Me.btImageLogoEdit.TabIndex = 14
        Me.btImageLogoEdit.Text = "Edit"
        Me.btImageLogoEdit.UseVisualStyleBackColor = true
        '
        'lbImageLogos
        '
        Me.lbImageLogos.FormattingEnabled = true
        Me.lbImageLogos.Location = New System.Drawing.Point(10, 12)
        Me.lbImageLogos.Name = "lbImageLogos"
        Me.lbImageLogos.Size = New System.Drawing.Size(257, 199)
        Me.lbImageLogos.TabIndex = 13
        '
        'btImageLogoAdd
        '
        Me.btImageLogoAdd.Location = New System.Drawing.Point(8, 215)
        Me.btImageLogoAdd.Name = "btImageLogoAdd"
        Me.btImageLogoAdd.Size = New System.Drawing.Size(59, 23)
        Me.btImageLogoAdd.TabIndex = 12
        Me.btImageLogoAdd.Text = "Add"
        Me.btImageLogoAdd.UseVisualStyleBackColor = true
        '
        'TabPage18
        '
        Me.TabPage18.Controls.Add(Me.groupBox37)
        Me.TabPage18.Controls.Add(Me.cbZoom)
        Me.TabPage18.Location = New System.Drawing.Point(4, 22)
        Me.TabPage18.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage18.Size = New System.Drawing.Size(275, 248)
        Me.TabPage18.TabIndex = 2
        Me.TabPage18.Text = "Zoom"
        Me.TabPage18.UseVisualStyleBackColor = true
        '
        'groupBox37
        '
        Me.groupBox37.Controls.Add(Me.btEffZoomRight)
        Me.groupBox37.Controls.Add(Me.btEffZoomLeft)
        Me.groupBox37.Controls.Add(Me.btEffZoomOut)
        Me.groupBox37.Controls.Add(Me.btEffZoomIn)
        Me.groupBox37.Controls.Add(Me.btEffZoomDown)
        Me.groupBox37.Controls.Add(Me.btEffZoomUp)
        Me.groupBox37.Location = New System.Drawing.Point(82, 53)
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
        Me.cbZoom.Location = New System.Drawing.Point(12, 17)
        Me.cbZoom.Name = "cbZoom"
        Me.cbZoom.Size = New System.Drawing.Size(65, 17)
        Me.cbZoom.TabIndex = 19
        Me.cbZoom.Text = "Enabled"
        Me.cbZoom.UseVisualStyleBackColor = true
        '
        'TabPage19
        '
        Me.TabPage19.Controls.Add(Me.groupBox40)
        Me.TabPage19.Controls.Add(Me.groupBox39)
        Me.TabPage19.Controls.Add(Me.groupBox38)
        Me.TabPage19.Controls.Add(Me.cbPan)
        Me.TabPage19.Location = New System.Drawing.Point(4, 22)
        Me.TabPage19.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage19.Name = "TabPage19"
        Me.TabPage19.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage19.Size = New System.Drawing.Size(275, 248)
        Me.TabPage19.TabIndex = 3
        Me.TabPage19.Text = "Pan"
        Me.TabPage19.UseVisualStyleBackColor = true
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
        'TabPage22
        '
        Me.TabPage22.Controls.Add(Me.rbFadeOut)
        Me.TabPage22.Controls.Add(Me.rbFadeIn)
        Me.TabPage22.Controls.Add(Me.groupBox45)
        Me.TabPage22.Controls.Add(Me.cbFadeInOut)
        Me.TabPage22.Location = New System.Drawing.Point(4, 22)
        Me.TabPage22.Name = "TabPage22"
        Me.TabPage22.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage22.Size = New System.Drawing.Size(275, 248)
        Me.TabPage22.TabIndex = 4
        Me.TabPage22.Text = "Fade-in/out"
        Me.TabPage22.UseVisualStyleBackColor = true
        '
        'rbFadeOut
        '
        Me.rbFadeOut.AutoSize = true
        Me.rbFadeOut.Location = New System.Drawing.Point(101, 93)
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
        Me.rbFadeIn.Location = New System.Drawing.Point(10, 93)
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
        Me.groupBox45.Location = New System.Drawing.Point(10, 41)
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
        Me.cbFadeInOut.Location = New System.Drawing.Point(10, 18)
        Me.cbFadeInOut.Name = "cbFadeInOut"
        Me.cbFadeInOut.Size = New System.Drawing.Size(65, 17)
        Me.cbFadeInOut.TabIndex = 61
        Me.cbFadeInOut.Text = "Enabled"
        Me.cbFadeInOut.UseVisualStyleBackColor = true
        '
        'TabPage27
        '
        Me.TabPage27.Controls.Add(Me.cbLiveRotationStretch)
        Me.TabPage27.Controls.Add(Me.label392)
        Me.TabPage27.Controls.Add(Me.label391)
        Me.TabPage27.Controls.Add(Me.tbLiveRotationAngle)
        Me.TabPage27.Controls.Add(Me.label390)
        Me.TabPage27.Controls.Add(Me.cbLiveRotation)
        Me.TabPage27.Location = New System.Drawing.Point(4, 22)
        Me.TabPage27.Name = "TabPage27"
        Me.TabPage27.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage27.Size = New System.Drawing.Size(275, 248)
        Me.TabPage27.TabIndex = 5
        Me.TabPage27.Text = "Live rotation"
        Me.TabPage27.UseVisualStyleBackColor = true
        '
        'cbLiveRotationStretch
        '
        Me.cbLiveRotationStretch.AutoSize = true
        Me.cbLiveRotationStretch.Location = New System.Drawing.Point(12, 141)
        Me.cbLiveRotationStretch.Name = "cbLiveRotationStretch"
        Me.cbLiveRotationStretch.Size = New System.Drawing.Size(158, 17)
        Me.cbLiveRotationStretch.TabIndex = 65
        Me.cbLiveRotationStretch.Text = "Stretch  if angle is 90 or 270"
        Me.cbLiveRotationStretch.UseVisualStyleBackColor = true
        '
        'label392
        '
        Me.label392.AutoSize = true
        Me.label392.Location = New System.Drawing.Point(130, 115)
        Me.label392.Name = "label392"
        Me.label392.Size = New System.Drawing.Size(25, 13)
        Me.label392.TabIndex = 64
        Me.label392.Text = "360"
        '
        'label391
        '
        Me.label391.AutoSize = true
        Me.label391.Location = New System.Drawing.Point(9, 115)
        Me.label391.Name = "label391"
        Me.label391.Size = New System.Drawing.Size(13, 13)
        Me.label391.TabIndex = 63
        Me.label391.Text = "0"
        '
        'tbLiveRotationAngle
        '
        Me.tbLiveRotationAngle.Location = New System.Drawing.Point(12, 67)
        Me.tbLiveRotationAngle.Maximum = 360
        Me.tbLiveRotationAngle.Name = "tbLiveRotationAngle"
        Me.tbLiveRotationAngle.Size = New System.Drawing.Size(143, 45)
        Me.tbLiveRotationAngle.TabIndex = 62
        Me.tbLiveRotationAngle.TickFrequency = 5
        Me.tbLiveRotationAngle.Value = 90
        '
        'label390
        '
        Me.label390.AutoSize = true
        Me.label390.Location = New System.Drawing.Point(9, 48)
        Me.label390.Name = "label390"
        Me.label390.Size = New System.Drawing.Size(34, 13)
        Me.label390.TabIndex = 61
        Me.label390.Text = "Angle"
        '
        'cbLiveRotation
        '
        Me.cbLiveRotation.AutoSize = true
        Me.cbLiveRotation.Location = New System.Drawing.Point(12, 16)
        Me.cbLiveRotation.Name = "cbLiveRotation"
        Me.cbLiveRotation.Size = New System.Drawing.Size(65, 17)
        Me.cbLiveRotation.TabIndex = 60
        Me.cbLiveRotation.Text = "Enabled"
        Me.cbLiveRotation.UseVisualStyleBackColor = true
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
        Me.cbInvert.Location = New System.Drawing.Point(91, 158)
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
        'TabPage50
        '
        Me.TabPage50.Controls.Add(Me.Label22)
        Me.TabPage50.Controls.Add(Me.tbGPUBlur)
        Me.TabPage50.Controls.Add(Me.cbVideoEffectsGPUEnabled)
        Me.TabPage50.Controls.Add(Me.cbGPUOldMovie)
        Me.TabPage50.Controls.Add(Me.cbGPUDeinterlace)
        Me.TabPage50.Controls.Add(Me.cbGPUDenoise)
        Me.TabPage50.Controls.Add(Me.cbGPUPixelate)
        Me.TabPage50.Controls.Add(Me.cbGPUNightVision)
        Me.TabPage50.Controls.Add(Me.label383)
        Me.TabPage50.Controls.Add(Me.label384)
        Me.TabPage50.Controls.Add(Me.label385)
        Me.TabPage50.Controls.Add(Me.label386)
        Me.TabPage50.Controls.Add(Me.tbGPUContrast)
        Me.TabPage50.Controls.Add(Me.tbGPUDarkness)
        Me.TabPage50.Controls.Add(Me.tbGPULightness)
        Me.TabPage50.Controls.Add(Me.tbGPUSaturation)
        Me.TabPage50.Controls.Add(Me.cbGPUInvert)
        Me.TabPage50.Controls.Add(Me.cbGPUGreyscale)
        Me.TabPage50.Location = New System.Drawing.Point(4, 22)
        Me.TabPage50.Name = "TabPage50"
        Me.TabPage50.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage50.Size = New System.Drawing.Size(290, 459)
        Me.TabPage50.TabIndex = 9
        Me.TabPage50.Text = "Effects (GPU)"
        Me.TabPage50.UseVisualStyleBackColor = true
        '
        'Label22
        '
        Me.Label22.AutoSize = true
        Me.Label22.Location = New System.Drawing.Point(10, 266)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 116
        Me.Label22.Text = "Blur"
        '
        'tbGPUBlur
        '
        Me.tbGPUBlur.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUBlur.Location = New System.Drawing.Point(7, 282)
        Me.tbGPUBlur.Maximum = 30
        Me.tbGPUBlur.Name = "tbGPUBlur"
        Me.tbGPUBlur.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUBlur.TabIndex = 115
        '
        'cbVideoEffectsGPUEnabled
        '
        Me.cbVideoEffectsGPUEnabled.AutoSize = true
        Me.cbVideoEffectsGPUEnabled.Location = New System.Drawing.Point(14, 16)
        Me.cbVideoEffectsGPUEnabled.Name = "cbVideoEffectsGPUEnabled"
        Me.cbVideoEffectsGPUEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbVideoEffectsGPUEnabled.TabIndex = 113
        Me.cbVideoEffectsGPUEnabled.Text = "Enabled"
        Me.cbVideoEffectsGPUEnabled.UseVisualStyleBackColor = true
        '
        'cbGPUOldMovie
        '
        Me.cbGPUOldMovie.AutoSize = true
        Me.cbGPUOldMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUOldMovie.Location = New System.Drawing.Point(141, 237)
        Me.cbGPUOldMovie.Name = "cbGPUOldMovie"
        Me.cbGPUOldMovie.Size = New System.Drawing.Size(73, 17)
        Me.cbGPUOldMovie.TabIndex = 112
        Me.cbGPUOldMovie.Text = "Old movie"
        Me.cbGPUOldMovie.UseVisualStyleBackColor = true
        '
        'cbGPUDeinterlace
        '
        Me.cbGPUDeinterlace.AutoSize = true
        Me.cbGPUDeinterlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUDeinterlace.Location = New System.Drawing.Point(141, 213)
        Me.cbGPUDeinterlace.Name = "cbGPUDeinterlace"
        Me.cbGPUDeinterlace.Size = New System.Drawing.Size(80, 17)
        Me.cbGPUDeinterlace.TabIndex = 110
        Me.cbGPUDeinterlace.Text = "Deinterlace"
        Me.cbGPUDeinterlace.UseVisualStyleBackColor = true
        '
        'cbGPUDenoise
        '
        Me.cbGPUDenoise.AutoSize = true
        Me.cbGPUDenoise.Location = New System.Drawing.Point(13, 213)
        Me.cbGPUDenoise.Name = "cbGPUDenoise"
        Me.cbGPUDenoise.Size = New System.Drawing.Size(65, 17)
        Me.cbGPUDenoise.TabIndex = 109
        Me.cbGPUDenoise.Text = "Denoise"
        Me.cbGPUDenoise.UseVisualStyleBackColor = true
        '
        'cbGPUPixelate
        '
        Me.cbGPUPixelate.AutoSize = true
        Me.cbGPUPixelate.Location = New System.Drawing.Point(141, 190)
        Me.cbGPUPixelate.Name = "cbGPUPixelate"
        Me.cbGPUPixelate.Size = New System.Drawing.Size(63, 17)
        Me.cbGPUPixelate.TabIndex = 108
        Me.cbGPUPixelate.Text = "Pixelate"
        Me.cbGPUPixelate.UseVisualStyleBackColor = true
        '
        'cbGPUNightVision
        '
        Me.cbGPUNightVision.AutoSize = true
        Me.cbGPUNightVision.Location = New System.Drawing.Point(13, 190)
        Me.cbGPUNightVision.Name = "cbGPUNightVision"
        Me.cbGPUNightVision.Size = New System.Drawing.Size(81, 17)
        Me.cbGPUNightVision.TabIndex = 107
        Me.cbGPUNightVision.Text = "Night vision"
        Me.cbGPUNightVision.UseVisualStyleBackColor = true
        '
        'label383
        '
        Me.label383.AutoSize = true
        Me.label383.Location = New System.Drawing.Point(146, 97)
        Me.label383.Name = "label383"
        Me.label383.Size = New System.Drawing.Size(52, 13)
        Me.label383.TabIndex = 106
        Me.label383.Text = "Darkness"
        '
        'label384
        '
        Me.label384.AutoSize = true
        Me.label384.Location = New System.Drawing.Point(10, 97)
        Me.label384.Name = "label384"
        Me.label384.Size = New System.Drawing.Size(46, 13)
        Me.label384.TabIndex = 105
        Me.label384.Text = "Contrast"
        '
        'label385
        '
        Me.label385.AutoSize = true
        Me.label385.Location = New System.Drawing.Point(146, 45)
        Me.label385.Name = "label385"
        Me.label385.Size = New System.Drawing.Size(55, 13)
        Me.label385.TabIndex = 104
        Me.label385.Text = "Saturation"
        '
        'label386
        '
        Me.label386.AutoSize = true
        Me.label386.Location = New System.Drawing.Point(10, 45)
        Me.label386.Name = "label386"
        Me.label386.Size = New System.Drawing.Size(52, 13)
        Me.label386.TabIndex = 103
        Me.label386.Text = "Lightness"
        '
        'tbGPUContrast
        '
        Me.tbGPUContrast.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUContrast.Location = New System.Drawing.Point(7, 116)
        Me.tbGPUContrast.Maximum = 255
        Me.tbGPUContrast.Name = "tbGPUContrast"
        Me.tbGPUContrast.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUContrast.TabIndex = 102
        Me.tbGPUContrast.Value = 255
        '
        'tbGPUDarkness
        '
        Me.tbGPUDarkness.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUDarkness.Location = New System.Drawing.Point(146, 116)
        Me.tbGPUDarkness.Maximum = 255
        Me.tbGPUDarkness.Name = "tbGPUDarkness"
        Me.tbGPUDarkness.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUDarkness.TabIndex = 101
        '
        'tbGPULightness
        '
        Me.tbGPULightness.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPULightness.Location = New System.Drawing.Point(7, 60)
        Me.tbGPULightness.Maximum = 255
        Me.tbGPULightness.Name = "tbGPULightness"
        Me.tbGPULightness.Size = New System.Drawing.Size(130, 45)
        Me.tbGPULightness.TabIndex = 100
        '
        'tbGPUSaturation
        '
        Me.tbGPUSaturation.BackColor = System.Drawing.SystemColors.Window
        Me.tbGPUSaturation.Location = New System.Drawing.Point(146, 60)
        Me.tbGPUSaturation.Maximum = 255
        Me.tbGPUSaturation.Name = "tbGPUSaturation"
        Me.tbGPUSaturation.Size = New System.Drawing.Size(130, 45)
        Me.tbGPUSaturation.TabIndex = 99
        Me.tbGPUSaturation.Value = 255
        '
        'cbGPUInvert
        '
        Me.cbGPUInvert.AutoSize = true
        Me.cbGPUInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cbGPUInvert.Location = New System.Drawing.Point(141, 167)
        Me.cbGPUInvert.Name = "cbGPUInvert"
        Me.cbGPUInvert.Size = New System.Drawing.Size(53, 17)
        Me.cbGPUInvert.TabIndex = 98
        Me.cbGPUInvert.Text = "Invert"
        Me.cbGPUInvert.UseVisualStyleBackColor = true
        '
        'cbGPUGreyscale
        '
        Me.cbGPUGreyscale.AutoSize = true
        Me.cbGPUGreyscale.Location = New System.Drawing.Point(13, 167)
        Me.cbGPUGreyscale.Name = "cbGPUGreyscale"
        Me.cbGPUGreyscale.Size = New System.Drawing.Size(73, 17)
        Me.cbGPUGreyscale.TabIndex = 97
        Me.cbGPUGreyscale.Text = "Greyscale"
        Me.cbGPUGreyscale.UseVisualStyleBackColor = true
        '
        'tabPage8
        '
        Me.tabPage8.Controls.Add(Me.lbAdjSaturationCurrent)
        Me.tabPage8.Controls.Add(Me.lbAdjSaturationMax)
        Me.tabPage8.Controls.Add(Me.lbAdjSaturationMin)
        Me.tabPage8.Controls.Add(Me.tbAdjSaturation)
        Me.tabPage8.Controls.Add(Me.label45)
        Me.tabPage8.Controls.Add(Me.lbAdjHueCurrent)
        Me.tabPage8.Controls.Add(Me.lbAdjHueMax)
        Me.tabPage8.Controls.Add(Me.lbAdjHueMin)
        Me.tabPage8.Controls.Add(Me.tbAdjHue)
        Me.tabPage8.Controls.Add(Me.label41)
        Me.tabPage8.Controls.Add(Me.lbAdjContrastCurrent)
        Me.tabPage8.Controls.Add(Me.lbAdjContrastMax)
        Me.tabPage8.Controls.Add(Me.lbAdjContrastMin)
        Me.tabPage8.Controls.Add(Me.tbAdjContrast)
        Me.tabPage8.Controls.Add(Me.label23)
        Me.tabPage8.Controls.Add(Me.lbAdjBrightnessCurrent)
        Me.tabPage8.Controls.Add(Me.lbAdjBrightnessMax)
        Me.tabPage8.Controls.Add(Me.lbAdjBrightnessMin)
        Me.tabPage8.Controls.Add(Me.tbAdjBrightness)
        Me.tabPage8.Controls.Add(Me.label24)
        Me.tabPage8.Location = New System.Drawing.Point(4, 22)
        Me.tabPage8.Name = "tabPage8"
        Me.tabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage8.Size = New System.Drawing.Size(290, 459)
        Me.tabPage8.TabIndex = 5
        Me.tabPage8.Text = "Effects (Video renderer)"
        Me.tabPage8.UseVisualStyleBackColor = true
        '
        'lbAdjSaturationCurrent
        '
        Me.lbAdjSaturationCurrent.AutoSize = true
        Me.lbAdjSaturationCurrent.Location = New System.Drawing.Point(130, 266)
        Me.lbAdjSaturationCurrent.Name = "lbAdjSaturationCurrent"
        Me.lbAdjSaturationCurrent.Size = New System.Drawing.Size(65, 13)
        Me.lbAdjSaturationCurrent.TabIndex = 48
        Me.lbAdjSaturationCurrent.Text = "Current = 40"
        '
        'lbAdjSaturationMax
        '
        Me.lbAdjSaturationMax.AutoSize = true
        Me.lbAdjSaturationMax.Location = New System.Drawing.Point(67, 266)
        Me.lbAdjSaturationMax.Name = "lbAdjSaturationMax"
        Me.lbAdjSaturationMax.Size = New System.Drawing.Size(57, 13)
        Me.lbAdjSaturationMax.TabIndex = 47
        Me.lbAdjSaturationMax.Text = "Max = 100"
        '
        'lbAdjSaturationMin
        '
        Me.lbAdjSaturationMin.AutoSize = true
        Me.lbAdjSaturationMin.Location = New System.Drawing.Point(19, 266)
        Me.lbAdjSaturationMin.Name = "lbAdjSaturationMin"
        Me.lbAdjSaturationMin.Size = New System.Drawing.Size(42, 13)
        Me.lbAdjSaturationMin.TabIndex = 45
        Me.lbAdjSaturationMin.Text = "Min = 1"
        '
        'tbAdjSaturation
        '
        Me.tbAdjSaturation.BackColor = System.Drawing.SystemColors.Window
        Me.tbAdjSaturation.Location = New System.Drawing.Point(13, 237)
        Me.tbAdjSaturation.Maximum = 100
        Me.tbAdjSaturation.Name = "tbAdjSaturation"
        Me.tbAdjSaturation.Size = New System.Drawing.Size(191, 45)
        Me.tbAdjSaturation.TabIndex = 44
        Me.tbAdjSaturation.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbAdjSaturation.Value = 50
        '
        'label45
        '
        Me.label45.AutoSize = true
        Me.label45.Location = New System.Drawing.Point(10, 221)
        Me.label45.Name = "label45"
        Me.label45.Size = New System.Drawing.Size(55, 13)
        Me.label45.TabIndex = 43
        Me.label45.Text = "Saturation"
        '
        'lbAdjHueCurrent
        '
        Me.lbAdjHueCurrent.AutoSize = true
        Me.lbAdjHueCurrent.Location = New System.Drawing.Point(130, 198)
        Me.lbAdjHueCurrent.Name = "lbAdjHueCurrent"
        Me.lbAdjHueCurrent.Size = New System.Drawing.Size(65, 13)
        Me.lbAdjHueCurrent.TabIndex = 42
        Me.lbAdjHueCurrent.Text = "Current = 40"
        '
        'lbAdjHueMax
        '
        Me.lbAdjHueMax.AutoSize = true
        Me.lbAdjHueMax.Location = New System.Drawing.Point(67, 198)
        Me.lbAdjHueMax.Name = "lbAdjHueMax"
        Me.lbAdjHueMax.Size = New System.Drawing.Size(57, 13)
        Me.lbAdjHueMax.TabIndex = 41
        Me.lbAdjHueMax.Text = "Max = 100"
        '
        'lbAdjHueMin
        '
        Me.lbAdjHueMin.AutoSize = true
        Me.lbAdjHueMin.Location = New System.Drawing.Point(19, 198)
        Me.lbAdjHueMin.Name = "lbAdjHueMin"
        Me.lbAdjHueMin.Size = New System.Drawing.Size(42, 13)
        Me.lbAdjHueMin.TabIndex = 39
        Me.lbAdjHueMin.Text = "Min = 1"
        '
        'tbAdjHue
        '
        Me.tbAdjHue.BackColor = System.Drawing.SystemColors.Window
        Me.tbAdjHue.Location = New System.Drawing.Point(13, 169)
        Me.tbAdjHue.Maximum = 100
        Me.tbAdjHue.Name = "tbAdjHue"
        Me.tbAdjHue.Size = New System.Drawing.Size(191, 45)
        Me.tbAdjHue.TabIndex = 38
        Me.tbAdjHue.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbAdjHue.Value = 50
        '
        'label41
        '
        Me.label41.AutoSize = true
        Me.label41.Location = New System.Drawing.Point(10, 153)
        Me.label41.Name = "label41"
        Me.label41.Size = New System.Drawing.Size(27, 13)
        Me.label41.TabIndex = 37
        Me.label41.Text = "Hue"
        '
        'lbAdjContrastCurrent
        '
        Me.lbAdjContrastCurrent.AutoSize = true
        Me.lbAdjContrastCurrent.Location = New System.Drawing.Point(130, 128)
        Me.lbAdjContrastCurrent.Name = "lbAdjContrastCurrent"
        Me.lbAdjContrastCurrent.Size = New System.Drawing.Size(65, 13)
        Me.lbAdjContrastCurrent.TabIndex = 36
        Me.lbAdjContrastCurrent.Text = "Current = 40"
        '
        'lbAdjContrastMax
        '
        Me.lbAdjContrastMax.AutoSize = true
        Me.lbAdjContrastMax.Location = New System.Drawing.Point(67, 128)
        Me.lbAdjContrastMax.Name = "lbAdjContrastMax"
        Me.lbAdjContrastMax.Size = New System.Drawing.Size(57, 13)
        Me.lbAdjContrastMax.TabIndex = 35
        Me.lbAdjContrastMax.Text = "Max = 100"
        '
        'lbAdjContrastMin
        '
        Me.lbAdjContrastMin.AutoSize = true
        Me.lbAdjContrastMin.Location = New System.Drawing.Point(19, 128)
        Me.lbAdjContrastMin.Name = "lbAdjContrastMin"
        Me.lbAdjContrastMin.Size = New System.Drawing.Size(42, 13)
        Me.lbAdjContrastMin.TabIndex = 33
        Me.lbAdjContrastMin.Text = "Min = 1"
        '
        'tbAdjContrast
        '
        Me.tbAdjContrast.BackColor = System.Drawing.SystemColors.Window
        Me.tbAdjContrast.Location = New System.Drawing.Point(13, 99)
        Me.tbAdjContrast.Maximum = 100
        Me.tbAdjContrast.Name = "tbAdjContrast"
        Me.tbAdjContrast.Size = New System.Drawing.Size(191, 45)
        Me.tbAdjContrast.TabIndex = 32
        Me.tbAdjContrast.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbAdjContrast.Value = 50
        '
        'label23
        '
        Me.label23.AutoSize = true
        Me.label23.Location = New System.Drawing.Point(10, 83)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(46, 13)
        Me.label23.TabIndex = 31
        Me.label23.Text = "Contrast"
        '
        'lbAdjBrightnessCurrent
        '
        Me.lbAdjBrightnessCurrent.AutoSize = true
        Me.lbAdjBrightnessCurrent.Location = New System.Drawing.Point(130, 60)
        Me.lbAdjBrightnessCurrent.Name = "lbAdjBrightnessCurrent"
        Me.lbAdjBrightnessCurrent.Size = New System.Drawing.Size(65, 13)
        Me.lbAdjBrightnessCurrent.TabIndex = 30
        Me.lbAdjBrightnessCurrent.Text = "Current = 40"
        '
        'lbAdjBrightnessMax
        '
        Me.lbAdjBrightnessMax.AutoSize = true
        Me.lbAdjBrightnessMax.Location = New System.Drawing.Point(67, 60)
        Me.lbAdjBrightnessMax.Name = "lbAdjBrightnessMax"
        Me.lbAdjBrightnessMax.Size = New System.Drawing.Size(57, 13)
        Me.lbAdjBrightnessMax.TabIndex = 29
        Me.lbAdjBrightnessMax.Text = "Max = 100"
        '
        'lbAdjBrightnessMin
        '
        Me.lbAdjBrightnessMin.AutoSize = true
        Me.lbAdjBrightnessMin.Location = New System.Drawing.Point(19, 60)
        Me.lbAdjBrightnessMin.Name = "lbAdjBrightnessMin"
        Me.lbAdjBrightnessMin.Size = New System.Drawing.Size(42, 13)
        Me.lbAdjBrightnessMin.TabIndex = 27
        Me.lbAdjBrightnessMin.Text = "Min = 1"
        '
        'tbAdjBrightness
        '
        Me.tbAdjBrightness.BackColor = System.Drawing.SystemColors.Window
        Me.tbAdjBrightness.Location = New System.Drawing.Point(13, 31)
        Me.tbAdjBrightness.Maximum = 100
        Me.tbAdjBrightness.Name = "tbAdjBrightness"
        Me.tbAdjBrightness.Size = New System.Drawing.Size(191, 45)
        Me.tbAdjBrightness.TabIndex = 26
        Me.tbAdjBrightness.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbAdjBrightness.Value = 50
        '
        'label24
        '
        Me.label24.AutoSize = true
        Me.label24.Location = New System.Drawing.Point(10, 15)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(56, 13)
        Me.label24.TabIndex = 25
        Me.label24.Text = "Brightness"
        '
        'tabPage15
        '
        Me.tabPage15.Controls.Add(Me.pnChromaKeyColor)
        Me.tabPage15.Controls.Add(Me.btChromaKeySelectBGImage)
        Me.tabPage15.Controls.Add(Me.edChromaKeyImage)
        Me.tabPage15.Controls.Add(Me.label216)
        Me.tabPage15.Controls.Add(Me.label215)
        Me.tabPage15.Controls.Add(Me.tbChromaKeySmoothing)
        Me.tabPage15.Controls.Add(Me.label214)
        Me.tabPage15.Controls.Add(Me.tbChromaKeyThresholdSensitivity)
        Me.tabPage15.Controls.Add(Me.label213)
        Me.tabPage15.Controls.Add(Me.cbChromaKeyEnabled)
        Me.tabPage15.Location = New System.Drawing.Point(4, 22)
        Me.tabPage15.Name = "tabPage15"
        Me.tabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage15.Size = New System.Drawing.Size(290, 459)
        Me.tabPage15.TabIndex = 7
        Me.tabPage15.Text = "Chroma key"
        Me.tabPage15.UseVisualStyleBackColor = true
        '
        'pnChromaKeyColor
        '
        Me.pnChromaKeyColor.BackColor = System.Drawing.Color.Lime
        Me.pnChromaKeyColor.ForeColor = System.Drawing.SystemColors.Control
        Me.pnChromaKeyColor.Location = New System.Drawing.Point(54, 200)
        Me.pnChromaKeyColor.Name = "pnChromaKeyColor"
        Me.pnChromaKeyColor.Size = New System.Drawing.Size(26, 24)
        Me.pnChromaKeyColor.TabIndex = 43
        '
        'btChromaKeySelectBGImage
        '
        Me.btChromaKeySelectBGImage.Location = New System.Drawing.Point(254, 262)
        Me.btChromaKeySelectBGImage.Name = "btChromaKeySelectBGImage"
        Me.btChromaKeySelectBGImage.Size = New System.Drawing.Size(24, 23)
        Me.btChromaKeySelectBGImage.TabIndex = 42
        Me.btChromaKeySelectBGImage.Text = "..."
        Me.btChromaKeySelectBGImage.UseVisualStyleBackColor = true
        '
        'edChromaKeyImage
        '
        Me.edChromaKeyImage.Location = New System.Drawing.Point(12, 264)
        Me.edChromaKeyImage.Name = "edChromaKeyImage"
        Me.edChromaKeyImage.Size = New System.Drawing.Size(235, 20)
        Me.edChromaKeyImage.TabIndex = 41
        Me.edChromaKeyImage.Text = "c:\Samples\pics\1.jpg"
        '
        'label216
        '
        Me.label216.AutoSize = true
        Me.label216.Location = New System.Drawing.Point(9, 248)
        Me.label216.Name = "label216"
        Me.label216.Size = New System.Drawing.Size(112, 13)
        Me.label216.TabIndex = 40
        Me.label216.Text = "Image background file"
        '
        'label215
        '
        Me.label215.AutoSize = true
        Me.label215.Location = New System.Drawing.Point(9, 204)
        Me.label215.Name = "label215"
        Me.label215.Size = New System.Drawing.Size(31, 13)
        Me.label215.TabIndex = 39
        Me.label215.Text = "Color"
        '
        'tbChromaKeySmoothing
        '
        Me.tbChromaKeySmoothing.BackColor = System.Drawing.SystemColors.Window
        Me.tbChromaKeySmoothing.Location = New System.Drawing.Point(12, 145)
        Me.tbChromaKeySmoothing.Maximum = 1000
        Me.tbChromaKeySmoothing.Name = "tbChromaKeySmoothing"
        Me.tbChromaKeySmoothing.Size = New System.Drawing.Size(154, 45)
        Me.tbChromaKeySmoothing.TabIndex = 38
        Me.tbChromaKeySmoothing.Value = 80
        '
        'label214
        '
        Me.label214.AutoSize = true
        Me.label214.Location = New System.Drawing.Point(9, 127)
        Me.label214.Name = "label214"
        Me.label214.Size = New System.Drawing.Size(57, 13)
        Me.label214.TabIndex = 37
        Me.label214.Text = "Smoothing"
        '
        'tbChromaKeyThresholdSensitivity
        '
        Me.tbChromaKeyThresholdSensitivity.BackColor = System.Drawing.SystemColors.Window
        Me.tbChromaKeyThresholdSensitivity.Location = New System.Drawing.Point(12, 72)
        Me.tbChromaKeyThresholdSensitivity.Maximum = 200
        Me.tbChromaKeyThresholdSensitivity.Name = "tbChromaKeyThresholdSensitivity"
        Me.tbChromaKeyThresholdSensitivity.Size = New System.Drawing.Size(154, 45)
        Me.tbChromaKeyThresholdSensitivity.TabIndex = 36
        Me.tbChromaKeyThresholdSensitivity.Value = 180
        '
        'label213
        '
        Me.label213.AutoSize = true
        Me.label213.Location = New System.Drawing.Point(9, 54)
        Me.label213.Name = "label213"
        Me.label213.Size = New System.Drawing.Size(102, 13)
        Me.label213.TabIndex = 35
        Me.label213.Text = "Threshold sensitivity"
        '
        'cbChromaKeyEnabled
        '
        Me.cbChromaKeyEnabled.AutoSize = true
        Me.cbChromaKeyEnabled.Location = New System.Drawing.Point(12, 16)
        Me.cbChromaKeyEnabled.Name = "cbChromaKeyEnabled"
        Me.cbChromaKeyEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbChromaKeyEnabled.TabIndex = 34
        Me.cbChromaKeyEnabled.Text = "Enabled"
        Me.cbChromaKeyEnabled.UseVisualStyleBackColor = true
        '
        'TabPage28
        '
        Me.TabPage28.Controls.Add(Me.btFilterDelete)
        Me.TabPage28.Controls.Add(Me.btFilterDeleteAll)
        Me.TabPage28.Controls.Add(Me.btFilterSettings2)
        Me.TabPage28.Controls.Add(Me.lbFilters)
        Me.TabPage28.Controls.Add(Me.label106)
        Me.TabPage28.Controls.Add(Me.btFilterSettings)
        Me.TabPage28.Controls.Add(Me.btFilterAdd)
        Me.TabPage28.Controls.Add(Me.cbFilters)
        Me.TabPage28.Controls.Add(Me.label105)
        Me.TabPage28.Location = New System.Drawing.Point(4, 22)
        Me.TabPage28.Name = "TabPage28"
        Me.TabPage28.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage28.Size = New System.Drawing.Size(290, 459)
        Me.TabPage28.TabIndex = 8
        Me.TabPage28.Text = "3rd-party filters"
        Me.TabPage28.UseVisualStyleBackColor = true
        '
        'btFilterDelete
        '
        Me.btFilterDelete.Location = New System.Drawing.Point(154, 288)
        Me.btFilterDelete.Name = "btFilterDelete"
        Me.btFilterDelete.Size = New System.Drawing.Size(48, 23)
        Me.btFilterDelete.TabIndex = 35
        Me.btFilterDelete.Text = "Delete"
        Me.btFilterDelete.UseVisualStyleBackColor = true
        '
        'btFilterDeleteAll
        '
        Me.btFilterDeleteAll.Location = New System.Drawing.Point(208, 288)
        Me.btFilterDeleteAll.Name = "btFilterDeleteAll"
        Me.btFilterDeleteAll.Size = New System.Drawing.Size(68, 23)
        Me.btFilterDeleteAll.TabIndex = 34
        Me.btFilterDeleteAll.Text = "Delete all"
        Me.btFilterDeleteAll.UseVisualStyleBackColor = true
        '
        'btFilterSettings2
        '
        Me.btFilterSettings2.Location = New System.Drawing.Point(16, 288)
        Me.btFilterSettings2.Name = "btFilterSettings2"
        Me.btFilterSettings2.Size = New System.Drawing.Size(65, 23)
        Me.btFilterSettings2.TabIndex = 33
        Me.btFilterSettings2.Text = "Settings"
        Me.btFilterSettings2.UseVisualStyleBackColor = true
        '
        'lbFilters
        '
        Me.lbFilters.FormattingEnabled = true
        Me.lbFilters.Location = New System.Drawing.Point(16, 122)
        Me.lbFilters.Name = "lbFilters"
        Me.lbFilters.Size = New System.Drawing.Size(260, 160)
        Me.lbFilters.TabIndex = 32
        '
        'label106
        '
        Me.label106.AutoSize = true
        Me.label106.Location = New System.Drawing.Point(13, 106)
        Me.label106.Name = "label106"
        Me.label106.Size = New System.Drawing.Size(68, 13)
        Me.label106.TabIndex = 31
        Me.label106.Text = "Current filters"
        '
        'btFilterSettings
        '
        Me.btFilterSettings.Location = New System.Drawing.Point(208, 58)
        Me.btFilterSettings.Name = "btFilterSettings"
        Me.btFilterSettings.Size = New System.Drawing.Size(68, 23)
        Me.btFilterSettings.TabIndex = 30
        Me.btFilterSettings.Text = "Settings"
        Me.btFilterSettings.UseVisualStyleBackColor = true
        '
        'btFilterAdd
        '
        Me.btFilterAdd.Location = New System.Drawing.Point(16, 58)
        Me.btFilterAdd.Name = "btFilterAdd"
        Me.btFilterAdd.Size = New System.Drawing.Size(39, 23)
        Me.btFilterAdd.TabIndex = 29
        Me.btFilterAdd.Text = "Add"
        Me.btFilterAdd.UseVisualStyleBackColor = true
        '
        'cbFilters
        '
        Me.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilters.FormattingEnabled = true
        Me.cbFilters.Location = New System.Drawing.Point(16, 31)
        Me.cbFilters.Name = "cbFilters"
        Me.cbFilters.Size = New System.Drawing.Size(260, 21)
        Me.cbFilters.TabIndex = 28
        '
        'label105
        '
        Me.label105.AutoSize = true
        Me.label105.Location = New System.Drawing.Point(13, 15)
        Me.label105.Name = "label105"
        Me.label105.Size = New System.Drawing.Size(34, 13)
        Me.label105.TabIndex = 27
        Me.label105.Text = "Filters"
        '
        'tabPage11
        '
        Me.tabPage11.Controls.Add(Me.Label31)
        Me.tabPage11.Controls.Add(Me.tabControl18)
        Me.tabPage11.Controls.Add(Me.cbAudioEffectsEnabled)
        Me.tabPage11.Location = New System.Drawing.Point(4, 22)
        Me.tabPage11.Name = "tabPage11"
        Me.tabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage11.Size = New System.Drawing.Size(301, 492)
        Me.tabPage11.TabIndex = 5
        Me.tabPage11.Text = "Audio effects"
        Me.tabPage11.UseVisualStyleBackColor = true
        '
        'Label31
        '
        Me.Label31.AutoSize = true
        Me.Label31.Location = New System.Drawing.Point(90, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(188, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Much more effects available using API"
        '
        'tabControl18
        '
        Me.tabControl18.Controls.Add(Me.tabPage71)
        Me.tabControl18.Controls.Add(Me.tabPage72)
        Me.tabControl18.Controls.Add(Me.tabPage73)
        Me.tabControl18.Controls.Add(Me.tabPage75)
        Me.tabControl18.Controls.Add(Me.tabPage76)
        Me.tabControl18.Location = New System.Drawing.Point(8, 31)
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
        Me.cbAudioEffectsEnabled.Location = New System.Drawing.Point(8, 8)
        Me.cbAudioEffectsEnabled.Name = "cbAudioEffectsEnabled"
        Me.cbAudioEffectsEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioEffectsEnabled.TabIndex = 2
        Me.cbAudioEffectsEnabled.Text = "Enabled"
        Me.cbAudioEffectsEnabled.UseVisualStyleBackColor = true
        '
        'TabPage46
        '
        Me.TabPage46.Controls.Add(Me.lbAudioTimeshift)
        Me.TabPage46.Controls.Add(Me.tbAudioTimeshift)
        Me.TabPage46.Controls.Add(Me.label70)
        Me.TabPage46.Controls.Add(Me.groupBox4)
        Me.TabPage46.Controls.Add(Me.groupBox1)
        Me.TabPage46.Controls.Add(Me.cbAudioAutoGain)
        Me.TabPage46.Controls.Add(Me.cbAudioNormalize)
        Me.TabPage46.Controls.Add(Me.cbAudioEnhancementEnabled)
        Me.TabPage46.Location = New System.Drawing.Point(4, 22)
        Me.TabPage46.Name = "TabPage46"
        Me.TabPage46.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage46.Size = New System.Drawing.Size(301, 492)
        Me.TabPage46.TabIndex = 12
        Me.TabPage46.Text = "Audio enhancement"
        Me.TabPage46.UseVisualStyleBackColor = true
        '
        'lbAudioTimeshift
        '
        Me.lbAudioTimeshift.AutoSize = true
        Me.lbAudioTimeshift.Location = New System.Drawing.Point(175, 446)
        Me.lbAudioTimeshift.Name = "lbAudioTimeshift"
        Me.lbAudioTimeshift.Size = New System.Drawing.Size(29, 13)
        Me.lbAudioTimeshift.TabIndex = 15
        Me.lbAudioTimeshift.Text = "0 ms"
        '
        'tbAudioTimeshift
        '
        Me.tbAudioTimeshift.Location = New System.Drawing.Point(65, 435)
        Me.tbAudioTimeshift.Maximum = 3000
        Me.tbAudioTimeshift.Name = "tbAudioTimeshift"
        Me.tbAudioTimeshift.Size = New System.Drawing.Size(104, 45)
        Me.tbAudioTimeshift.SmallChange = 10
        Me.tbAudioTimeshift.TabIndex = 14
        Me.tbAudioTimeshift.TickFrequency = 100
        Me.tbAudioTimeshift.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label70
        '
        Me.label70.AutoSize = true
        Me.label70.Location = New System.Drawing.Point(4, 446)
        Me.label70.Name = "label70"
        Me.label70.Size = New System.Drawing.Size(52, 13)
        Me.label70.TabIndex = 13
        Me.label70.Text = "Time shift"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainLFE)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainLFE)
        Me.groupBox4.Controls.Add(Me.label55)
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainSR)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainSR)
        Me.groupBox4.Controls.Add(Me.label57)
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainSL)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainSL)
        Me.groupBox4.Controls.Add(Me.label59)
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainR)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainR)
        Me.groupBox4.Controls.Add(Me.label61)
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainC)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainC)
        Me.groupBox4.Controls.Add(Me.label67)
        Me.groupBox4.Controls.Add(Me.lbAudioOutputGainL)
        Me.groupBox4.Controls.Add(Me.tbAudioOutputGainL)
        Me.groupBox4.Controls.Add(Me.label69)
        Me.groupBox4.Location = New System.Drawing.Point(7, 255)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(289, 172)
        Me.groupBox4.TabIndex = 12
        Me.groupBox4.TabStop = false
        Me.groupBox4.Text = "Output gains (dB)"
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
        'label55
        '
        Me.label55.AutoSize = true
        Me.label55.Location = New System.Drawing.Point(250, 25)
        Me.label55.Name = "label55"
        Me.label55.Size = New System.Drawing.Size(26, 13)
        Me.label55.TabIndex = 15
        Me.label55.Text = "LFE"
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
        'label57
        '
        Me.label57.AutoSize = true
        Me.label57.Location = New System.Drawing.Point(205, 25)
        Me.label57.Name = "label57"
        Me.label57.Size = New System.Drawing.Size(22, 13)
        Me.label57.TabIndex = 12
        Me.label57.Text = "SR"
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
        'label59
        '
        Me.label59.AutoSize = true
        Me.label59.Location = New System.Drawing.Point(158, 25)
        Me.label59.Name = "label59"
        Me.label59.Size = New System.Drawing.Size(20, 13)
        Me.label59.TabIndex = 9
        Me.label59.Text = "SL"
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
        'label61
        '
        Me.label61.AutoSize = true
        Me.label61.Location = New System.Drawing.Point(114, 25)
        Me.label61.Name = "label61"
        Me.label61.Size = New System.Drawing.Size(15, 13)
        Me.label61.TabIndex = 6
        Me.label61.Text = "R"
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
        'label67
        '
        Me.label67.AutoSize = true
        Me.label67.Location = New System.Drawing.Point(66, 25)
        Me.label67.Name = "label67"
        Me.label67.Size = New System.Drawing.Size(14, 13)
        Me.label67.TabIndex = 3
        Me.label67.Text = "C"
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
        'label69
        '
        Me.label69.AutoSize = true
        Me.label69.Location = New System.Drawing.Point(18, 25)
        Me.label69.Name = "label69"
        Me.label69.Size = New System.Drawing.Size(13, 13)
        Me.label69.TabIndex = 0
        Me.label69.Text = "L"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainLFE)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainLFE)
        Me.groupBox1.Controls.Add(Me.label53)
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainSR)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainSR)
        Me.groupBox1.Controls.Add(Me.label51)
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainSL)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainSL)
        Me.groupBox1.Controls.Add(Me.label49)
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainR)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainR)
        Me.groupBox1.Controls.Add(Me.label47)
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainC)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainC)
        Me.groupBox1.Controls.Add(Me.label44)
        Me.groupBox1.Controls.Add(Me.lbAudioInputGainL)
        Me.groupBox1.Controls.Add(Me.tbAudioInputGainL)
        Me.groupBox1.Controls.Add(Me.label40)
        Me.groupBox1.Location = New System.Drawing.Point(7, 77)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(289, 172)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "Input gains (dB)"
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
        'label53
        '
        Me.label53.AutoSize = true
        Me.label53.Location = New System.Drawing.Point(250, 25)
        Me.label53.Name = "label53"
        Me.label53.Size = New System.Drawing.Size(26, 13)
        Me.label53.TabIndex = 15
        Me.label53.Text = "LFE"
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
        'label51
        '
        Me.label51.AutoSize = true
        Me.label51.Location = New System.Drawing.Point(205, 25)
        Me.label51.Name = "label51"
        Me.label51.Size = New System.Drawing.Size(22, 13)
        Me.label51.TabIndex = 12
        Me.label51.Text = "SR"
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
        'label49
        '
        Me.label49.AutoSize = true
        Me.label49.Location = New System.Drawing.Point(158, 25)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(20, 13)
        Me.label49.TabIndex = 9
        Me.label49.Text = "SL"
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
        'label47
        '
        Me.label47.AutoSize = true
        Me.label47.Location = New System.Drawing.Point(114, 25)
        Me.label47.Name = "label47"
        Me.label47.Size = New System.Drawing.Size(15, 13)
        Me.label47.TabIndex = 6
        Me.label47.Text = "R"
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
        'label44
        '
        Me.label44.AutoSize = true
        Me.label44.Location = New System.Drawing.Point(66, 25)
        Me.label44.Name = "label44"
        Me.label44.Size = New System.Drawing.Size(14, 13)
        Me.label44.TabIndex = 3
        Me.label44.Text = "C"
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
        'label40
        '
        Me.label40.AutoSize = true
        Me.label40.Location = New System.Drawing.Point(18, 25)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(13, 13)
        Me.label40.TabIndex = 0
        Me.label40.Text = "L"
        '
        'cbAudioAutoGain
        '
        Me.cbAudioAutoGain.AutoSize = true
        Me.cbAudioAutoGain.Location = New System.Drawing.Point(134, 45)
        Me.cbAudioAutoGain.Name = "cbAudioAutoGain"
        Me.cbAudioAutoGain.Size = New System.Drawing.Size(71, 17)
        Me.cbAudioAutoGain.TabIndex = 10
        Me.cbAudioAutoGain.Text = "Auto gain"
        Me.cbAudioAutoGain.UseVisualStyleBackColor = true
        '
        'cbAudioNormalize
        '
        Me.cbAudioNormalize.AutoSize = true
        Me.cbAudioNormalize.Location = New System.Drawing.Point(40, 45)
        Me.cbAudioNormalize.Name = "cbAudioNormalize"
        Me.cbAudioNormalize.Size = New System.Drawing.Size(72, 17)
        Me.cbAudioNormalize.TabIndex = 9
        Me.cbAudioNormalize.Text = "Normalize"
        Me.cbAudioNormalize.UseVisualStyleBackColor = true
        '
        'cbAudioEnhancementEnabled
        '
        Me.cbAudioEnhancementEnabled.AutoSize = true
        Me.cbAudioEnhancementEnabled.Location = New System.Drawing.Point(17, 13)
        Me.cbAudioEnhancementEnabled.Name = "cbAudioEnhancementEnabled"
        Me.cbAudioEnhancementEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioEnhancementEnabled.TabIndex = 8
        Me.cbAudioEnhancementEnabled.Text = "Enabled"
        Me.cbAudioEnhancementEnabled.UseVisualStyleBackColor = true
        '
        'TabPage49
        '
        Me.TabPage49.Controls.Add(Me.btAudioChannelMapperClear)
        Me.TabPage49.Controls.Add(Me.groupBox41)
        Me.TabPage49.Controls.Add(Me.label307)
        Me.TabPage49.Controls.Add(Me.edAudioChannelMapperOutputChannels)
        Me.TabPage49.Controls.Add(Me.label306)
        Me.TabPage49.Controls.Add(Me.lbAudioChannelMapperRoutes)
        Me.TabPage49.Controls.Add(Me.cbAudioChannelMapperEnabled)
        Me.TabPage49.Location = New System.Drawing.Point(4, 22)
        Me.TabPage49.Name = "TabPage49"
        Me.TabPage49.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage49.Size = New System.Drawing.Size(301, 492)
        Me.TabPage49.TabIndex = 13
        Me.TabPage49.Text = "Audio channel mapper"
        Me.TabPage49.UseVisualStyleBackColor = true
        '
        'btAudioChannelMapperClear
        '
        Me.btAudioChannelMapperClear.Location = New System.Drawing.Point(200, 217)
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
        Me.groupBox41.Location = New System.Drawing.Point(6, 246)
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
        Me.label307.Location = New System.Drawing.Point(5, 98)
        Me.label307.Name = "label307"
        Me.label307.Size = New System.Drawing.Size(41, 13)
        Me.label307.TabIndex = 26
        Me.label307.Text = "Routes"
        '
        'edAudioChannelMapperOutputChannels
        '
        Me.edAudioChannelMapperOutputChannels.Location = New System.Drawing.Point(8, 59)
        Me.edAudioChannelMapperOutputChannels.Name = "edAudioChannelMapperOutputChannels"
        Me.edAudioChannelMapperOutputChannels.Size = New System.Drawing.Size(42, 20)
        Me.edAudioChannelMapperOutputChannels.TabIndex = 25
        Me.edAudioChannelMapperOutputChannels.Text = "0"
        '
        'label306
        '
        Me.label306.AutoSize = true
        Me.label306.Location = New System.Drawing.Point(5, 43)
        Me.label306.Name = "label306"
        Me.label306.Size = New System.Drawing.Size(274, 13)
        Me.label306.TabIndex = 24
        Me.label306.Text = "Output channels count (0 to use original channels count)"
        '
        'lbAudioChannelMapperRoutes
        '
        Me.lbAudioChannelMapperRoutes.FormattingEnabled = true
        Me.lbAudioChannelMapperRoutes.Location = New System.Drawing.Point(8, 116)
        Me.lbAudioChannelMapperRoutes.Name = "lbAudioChannelMapperRoutes"
        Me.lbAudioChannelMapperRoutes.Size = New System.Drawing.Size(267, 95)
        Me.lbAudioChannelMapperRoutes.TabIndex = 23
        '
        'cbAudioChannelMapperEnabled
        '
        Me.cbAudioChannelMapperEnabled.AutoSize = true
        Me.cbAudioChannelMapperEnabled.Location = New System.Drawing.Point(8, 9)
        Me.cbAudioChannelMapperEnabled.Name = "cbAudioChannelMapperEnabled"
        Me.cbAudioChannelMapperEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbAudioChannelMapperEnabled.TabIndex = 22
        Me.cbAudioChannelMapperEnabled.Text = "Enabled"
        Me.cbAudioChannelMapperEnabled.UseVisualStyleBackColor = true
        '
        'TabPage25
        '
        Me.TabPage25.Controls.Add(Me.tbVUMeterBoost)
        Me.TabPage25.Controls.Add(Me.label382)
        Me.TabPage25.Controls.Add(Me.label381)
        Me.TabPage25.Controls.Add(Me.tbVUMeterAmplification)
        Me.TabPage25.Controls.Add(Me.cbVUMeterPro)
        Me.TabPage25.Controls.Add(Me.waveformPainter2)
        Me.TabPage25.Controls.Add(Me.waveformPainter1)
        Me.TabPage25.Controls.Add(Me.volumeMeter2)
        Me.TabPage25.Controls.Add(Me.volumeMeter1)
        Me.TabPage25.Location = New System.Drawing.Point(4, 22)
        Me.TabPage25.Name = "TabPage25"
        Me.TabPage25.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage25.Size = New System.Drawing.Size(301, 492)
        Me.TabPage25.TabIndex = 11
        Me.TabPage25.Text = "VU meter"
        Me.TabPage25.UseVisualStyleBackColor = true
        '
        'tbVUMeterBoost
        '
        Me.tbVUMeterBoost.Location = New System.Drawing.Point(118, 127)
        Me.tbVUMeterBoost.Maximum = 30
        Me.tbVUMeterBoost.Minimum = 1
        Me.tbVUMeterBoost.Name = "tbVUMeterBoost"
        Me.tbVUMeterBoost.Size = New System.Drawing.Size(104, 45)
        Me.tbVUMeterBoost.TabIndex = 131
        Me.tbVUMeterBoost.Value = 10
        '
        'label382
        '
        Me.label382.AutoSize = true
        Me.label382.Location = New System.Drawing.Point(115, 111)
        Me.label382.Name = "label382"
        Me.label382.Size = New System.Drawing.Size(68, 13)
        Me.label382.TabIndex = 130
        Me.label382.Text = "Meters boost"
        '
        'label381
        '
        Me.label381.AutoSize = true
        Me.label381.Location = New System.Drawing.Point(115, 46)
        Me.label381.Name = "label381"
        Me.label381.Size = New System.Drawing.Size(120, 13)
        Me.label381.TabIndex = 129
        Me.label381.Text = "Volume amplification (%)"
        '
        'tbVUMeterAmplification
        '
        Me.tbVUMeterAmplification.Location = New System.Drawing.Point(118, 62)
        Me.tbVUMeterAmplification.Maximum = 100
        Me.tbVUMeterAmplification.Name = "tbVUMeterAmplification"
        Me.tbVUMeterAmplification.Size = New System.Drawing.Size(105, 45)
        Me.tbVUMeterAmplification.TabIndex = 128
        Me.tbVUMeterAmplification.Value = 100
        '
        'cbVUMeterPro
        '
        Me.cbVUMeterPro.AutoSize = true
        Me.cbVUMeterPro.Location = New System.Drawing.Point(16, 12)
        Me.cbVUMeterPro.Name = "cbVUMeterPro"
        Me.cbVUMeterPro.Size = New System.Drawing.Size(125, 17)
        Me.cbVUMeterPro.TabIndex = 124
        Me.cbVUMeterPro.Text = "Enable VU meter Pro"
        Me.cbVUMeterPro.UseVisualStyleBackColor = true
        '
        'waveformPainter2
        '
        Me.waveformPainter2.Boost = 1!
        Me.waveformPainter2.Location = New System.Drawing.Point(16, 244)
        Me.waveformPainter2.Name = "waveformPainter2"
        Me.waveformPainter2.Size = New System.Drawing.Size(270, 60)
        Me.waveformPainter2.TabIndex = 127
        Me.waveformPainter2.Text = "waveformPainter2"
        '
        'waveformPainter1
        '
        Me.waveformPainter1.Boost = 1!
        Me.waveformPainter1.Location = New System.Drawing.Point(16, 178)
        Me.waveformPainter1.Name = "waveformPainter1"
        Me.waveformPainter1.Size = New System.Drawing.Size(270, 60)
        Me.waveformPainter1.TabIndex = 126
        Me.waveformPainter1.Text = "waveformPainter1"
        '
        'volumeMeter2
        '
        Me.volumeMeter2.Amplitude = 0!
        Me.volumeMeter2.BackColor = System.Drawing.Color.LightGray
        Me.volumeMeter2.Boost = 1!
        Me.volumeMeter2.Location = New System.Drawing.Point(54, 46)
        Me.volumeMeter2.MaxDb = 18!
        Me.volumeMeter2.MinDb = -60!
        Me.volumeMeter2.Name = "volumeMeter2"
        Me.volumeMeter2.Size = New System.Drawing.Size(22, 126)
        Me.volumeMeter2.TabIndex = 125
        '
        'volumeMeter1
        '
        Me.volumeMeter1.Amplitude = 0!
        Me.volumeMeter1.BackColor = System.Drawing.Color.LightGray
        Me.volumeMeter1.Boost = 1!
        Me.volumeMeter1.Location = New System.Drawing.Point(26, 46)
        Me.volumeMeter1.MaxDb = 18!
        Me.volumeMeter1.MinDb = -60!
        Me.volumeMeter1.Name = "volumeMeter1"
        Me.volumeMeter1.Size = New System.Drawing.Size(22, 126)
        Me.volumeMeter1.TabIndex = 123
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.btOSDRenderLayers)
        Me.tabPage5.Controls.Add(Me.lbOSDLayers)
        Me.tabPage5.Controls.Add(Me.cbOSDEnabled)
        Me.tabPage5.Controls.Add(Me.groupBox19)
        Me.tabPage5.Controls.Add(Me.btOSDClearLayers)
        Me.tabPage5.Controls.Add(Me.groupBox15)
        Me.tabPage5.Controls.Add(Me.label108)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage5.Size = New System.Drawing.Size(301, 492)
        Me.tabPage5.TabIndex = 4
        Me.tabPage5.Text = "OSD"
        Me.tabPage5.UseVisualStyleBackColor = true
        '
        'btOSDRenderLayers
        '
        Me.btOSDRenderLayers.Location = New System.Drawing.Point(161, 207)
        Me.btOSDRenderLayers.Name = "btOSDRenderLayers"
        Me.btOSDRenderLayers.Size = New System.Drawing.Size(125, 23)
        Me.btOSDRenderLayers.TabIndex = 17
        Me.btOSDRenderLayers.Text = "Render layers"
        Me.btOSDRenderLayers.UseVisualStyleBackColor = true
        '
        'lbOSDLayers
        '
        Me.lbOSDLayers.CheckOnClick = true
        Me.lbOSDLayers.FormattingEnabled = true
        Me.lbOSDLayers.Location = New System.Drawing.Point(15, 67)
        Me.lbOSDLayers.Name = "lbOSDLayers"
        Me.lbOSDLayers.Size = New System.Drawing.Size(139, 124)
        Me.lbOSDLayers.TabIndex = 16
        '
        'cbOSDEnabled
        '
        Me.cbOSDEnabled.AutoSize = true
        Me.cbOSDEnabled.Location = New System.Drawing.Point(15, 12)
        Me.cbOSDEnabled.Name = "cbOSDEnabled"
        Me.cbOSDEnabled.Size = New System.Drawing.Size(251, 17)
        Me.cbOSDEnabled.TabIndex = 15
        Me.cbOSDEnabled.Text = "Enabled (should be set before playback started)"
        Me.cbOSDEnabled.UseVisualStyleBackColor = true
        '
        'groupBox19
        '
        Me.groupBox19.Controls.Add(Me.btOSDClearLayer)
        Me.groupBox19.Controls.Add(Me.tabControl6)
        Me.groupBox19.Location = New System.Drawing.Point(15, 236)
        Me.groupBox19.Name = "groupBox19"
        Me.groupBox19.Size = New System.Drawing.Size(270, 250)
        Me.groupBox19.TabIndex = 13
        Me.groupBox19.TabStop = false
        Me.groupBox19.Text = "Selected layer"
        '
        'btOSDClearLayer
        '
        Me.btOSDClearLayer.Location = New System.Drawing.Point(11, 221)
        Me.btOSDClearLayer.Name = "btOSDClearLayer"
        Me.btOSDClearLayer.Size = New System.Drawing.Size(75, 23)
        Me.btOSDClearLayer.TabIndex = 3
        Me.btOSDClearLayer.Text = "Clear"
        Me.btOSDClearLayer.UseVisualStyleBackColor = true
        '
        'tabControl6
        '
        Me.tabControl6.Controls.Add(Me.tabPage30)
        Me.tabControl6.Controls.Add(Me.tabPage31)
        Me.tabControl6.Controls.Add(Me.tabPage32)
        Me.tabControl6.Location = New System.Drawing.Point(11, 19)
        Me.tabControl6.Name = "tabControl6"
        Me.tabControl6.SelectedIndex = 0
        Me.tabControl6.Size = New System.Drawing.Size(250, 196)
        Me.tabControl6.TabIndex = 0
        '
        'tabPage30
        '
        Me.tabPage30.Controls.Add(Me.btOSDImageDraw)
        Me.tabPage30.Controls.Add(Me.pnOSDColorKey)
        Me.tabPage30.Controls.Add(Me.cbOSDImageTranspColor)
        Me.tabPage30.Controls.Add(Me.edOSDImageTop)
        Me.tabPage30.Controls.Add(Me.label115)
        Me.tabPage30.Controls.Add(Me.edOSDImageLeft)
        Me.tabPage30.Controls.Add(Me.label114)
        Me.tabPage30.Controls.Add(Me.btOSDSelectImage)
        Me.tabPage30.Controls.Add(Me.edOSDImageFilename)
        Me.tabPage30.Controls.Add(Me.label113)
        Me.tabPage30.Location = New System.Drawing.Point(4, 22)
        Me.tabPage30.Name = "tabPage30"
        Me.tabPage30.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage30.Size = New System.Drawing.Size(242, 170)
        Me.tabPage30.TabIndex = 1
        Me.tabPage30.Text = "Image"
        Me.tabPage30.UseVisualStyleBackColor = true
        '
        'btOSDImageDraw
        '
        Me.btOSDImageDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btOSDImageDraw.Location = New System.Drawing.Point(178, 141)
        Me.btOSDImageDraw.Name = "btOSDImageDraw"
        Me.btOSDImageDraw.Size = New System.Drawing.Size(57, 23)
        Me.btOSDImageDraw.TabIndex = 47
        Me.btOSDImageDraw.Text = "Draw"
        Me.btOSDImageDraw.UseVisualStyleBackColor = true
        '
        'pnOSDColorKey
        '
        Me.pnOSDColorKey.BackColor = System.Drawing.Color.Fuchsia
        Me.pnOSDColorKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnOSDColorKey.Location = New System.Drawing.Point(161, 102)
        Me.pnOSDColorKey.Name = "pnOSDColorKey"
        Me.pnOSDColorKey.Size = New System.Drawing.Size(24, 24)
        Me.pnOSDColorKey.TabIndex = 45
        '
        'cbOSDImageTranspColor
        '
        Me.cbOSDImageTranspColor.AutoSize = true
        Me.cbOSDImageTranspColor.Location = New System.Drawing.Point(15, 102)
        Me.cbOSDImageTranspColor.Name = "cbOSDImageTranspColor"
        Me.cbOSDImageTranspColor.Size = New System.Drawing.Size(135, 17)
        Me.cbOSDImageTranspColor.TabIndex = 7
        Me.cbOSDImageTranspColor.Text = "Use transparency color"
        Me.cbOSDImageTranspColor.UseVisualStyleBackColor = true
        '
        'edOSDImageTop
        '
        Me.edOSDImageTop.Location = New System.Drawing.Point(132, 67)
        Me.edOSDImageTop.Name = "edOSDImageTop"
        Me.edOSDImageTop.Size = New System.Drawing.Size(38, 20)
        Me.edOSDImageTop.TabIndex = 6
        Me.edOSDImageTop.Text = "0"
        '
        'label115
        '
        Me.label115.AutoSize = true
        Me.label115.Location = New System.Drawing.Point(101, 70)
        Me.label115.Name = "label115"
        Me.label115.Size = New System.Drawing.Size(26, 13)
        Me.label115.TabIndex = 5
        Me.label115.Text = "Top"
        '
        'edOSDImageLeft
        '
        Me.edOSDImageLeft.Location = New System.Drawing.Point(49, 67)
        Me.edOSDImageLeft.Name = "edOSDImageLeft"
        Me.edOSDImageLeft.Size = New System.Drawing.Size(38, 20)
        Me.edOSDImageLeft.TabIndex = 4
        Me.edOSDImageLeft.Text = "0"
        '
        'label114
        '
        Me.label114.AutoSize = true
        Me.label114.Location = New System.Drawing.Point(12, 70)
        Me.label114.Name = "label114"
        Me.label114.Size = New System.Drawing.Size(25, 13)
        Me.label114.TabIndex = 3
        Me.label114.Text = "Left"
        '
        'btOSDSelectImage
        '
        Me.btOSDSelectImage.Location = New System.Drawing.Point(213, 30)
        Me.btOSDSelectImage.Name = "btOSDSelectImage"
        Me.btOSDSelectImage.Size = New System.Drawing.Size(22, 23)
        Me.btOSDSelectImage.TabIndex = 2
        Me.btOSDSelectImage.Text = "..."
        Me.btOSDSelectImage.UseVisualStyleBackColor = true
        '
        'edOSDImageFilename
        '
        Me.edOSDImageFilename.Location = New System.Drawing.Point(15, 32)
        Me.edOSDImageFilename.Name = "edOSDImageFilename"
        Me.edOSDImageFilename.Size = New System.Drawing.Size(192, 20)
        Me.edOSDImageFilename.TabIndex = 1
        Me.edOSDImageFilename.Text = "c:\logo.png"
        '
        'label113
        '
        Me.label113.AutoSize = true
        Me.label113.Location = New System.Drawing.Point(12, 16)
        Me.label113.Name = "label113"
        Me.label113.Size = New System.Drawing.Size(52, 13)
        Me.label113.TabIndex = 0
        Me.label113.Text = "File name"
        '
        'tabPage31
        '
        Me.tabPage31.Controls.Add(Me.edOSDTextTop)
        Me.tabPage31.Controls.Add(Me.label117)
        Me.tabPage31.Controls.Add(Me.edOSDTextLeft)
        Me.tabPage31.Controls.Add(Me.label118)
        Me.tabPage31.Controls.Add(Me.label116)
        Me.tabPage31.Controls.Add(Me.btOSDSelectFont)
        Me.tabPage31.Controls.Add(Me.edOSDText)
        Me.tabPage31.Controls.Add(Me.btOSDTextDraw)
        Me.tabPage31.Location = New System.Drawing.Point(4, 22)
        Me.tabPage31.Name = "tabPage31"
        Me.tabPage31.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage31.Size = New System.Drawing.Size(242, 170)
        Me.tabPage31.TabIndex = 2
        Me.tabPage31.Text = "Text"
        Me.tabPage31.UseVisualStyleBackColor = true
        '
        'edOSDTextTop
        '
        Me.edOSDTextTop.Location = New System.Drawing.Point(132, 67)
        Me.edOSDTextTop.Name = "edOSDTextTop"
        Me.edOSDTextTop.Size = New System.Drawing.Size(38, 20)
        Me.edOSDTextTop.TabIndex = 55
        Me.edOSDTextTop.Text = "0"
        '
        'label117
        '
        Me.label117.AutoSize = true
        Me.label117.Location = New System.Drawing.Point(101, 70)
        Me.label117.Name = "label117"
        Me.label117.Size = New System.Drawing.Size(26, 13)
        Me.label117.TabIndex = 54
        Me.label117.Text = "Top"
        '
        'edOSDTextLeft
        '
        Me.edOSDTextLeft.Location = New System.Drawing.Point(49, 67)
        Me.edOSDTextLeft.Name = "edOSDTextLeft"
        Me.edOSDTextLeft.Size = New System.Drawing.Size(38, 20)
        Me.edOSDTextLeft.TabIndex = 53
        Me.edOSDTextLeft.Text = "0"
        '
        'label118
        '
        Me.label118.AutoSize = true
        Me.label118.Location = New System.Drawing.Point(12, 70)
        Me.label118.Name = "label118"
        Me.label118.Size = New System.Drawing.Size(25, 13)
        Me.label118.TabIndex = 52
        Me.label118.Text = "Left"
        '
        'label116
        '
        Me.label116.AutoSize = true
        Me.label116.Location = New System.Drawing.Point(12, 16)
        Me.label116.Name = "label116"
        Me.label116.Size = New System.Drawing.Size(28, 13)
        Me.label116.TabIndex = 51
        Me.label116.Text = "Text"
        '
        'btOSDSelectFont
        '
        Me.btOSDSelectFont.Location = New System.Drawing.Point(198, 30)
        Me.btOSDSelectFont.Name = "btOSDSelectFont"
        Me.btOSDSelectFont.Size = New System.Drawing.Size(37, 23)
        Me.btOSDSelectFont.TabIndex = 50
        Me.btOSDSelectFont.Text = "Font"
        Me.btOSDSelectFont.UseVisualStyleBackColor = true
        '
        'edOSDText
        '
        Me.edOSDText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edOSDText.Location = New System.Drawing.Point(15, 32)
        Me.edOSDText.Name = "edOSDText"
        Me.edOSDText.Size = New System.Drawing.Size(180, 20)
        Me.edOSDText.TabIndex = 49
        Me.edOSDText.Text = "Hello!!!"
        '
        'btOSDTextDraw
        '
        Me.btOSDTextDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btOSDTextDraw.Location = New System.Drawing.Point(178, 141)
        Me.btOSDTextDraw.Name = "btOSDTextDraw"
        Me.btOSDTextDraw.Size = New System.Drawing.Size(57, 23)
        Me.btOSDTextDraw.TabIndex = 48
        Me.btOSDTextDraw.Text = "Draw"
        Me.btOSDTextDraw.UseVisualStyleBackColor = true
        '
        'tabPage32
        '
        Me.tabPage32.Controls.Add(Me.tbOSDTranspLevel)
        Me.tabPage32.Controls.Add(Me.btOSDSetTransp)
        Me.tabPage32.Controls.Add(Me.label119)
        Me.tabPage32.Location = New System.Drawing.Point(4, 22)
        Me.tabPage32.Name = "tabPage32"
        Me.tabPage32.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage32.Size = New System.Drawing.Size(242, 170)
        Me.tabPage32.TabIndex = 3
        Me.tabPage32.Text = "Other"
        Me.tabPage32.UseVisualStyleBackColor = true
        '
        'tbOSDTranspLevel
        '
        Me.tbOSDTranspLevel.BackColor = System.Drawing.SystemColors.Window
        Me.tbOSDTranspLevel.Location = New System.Drawing.Point(15, 32)
        Me.tbOSDTranspLevel.Maximum = 255
        Me.tbOSDTranspLevel.Name = "tbOSDTranspLevel"
        Me.tbOSDTranspLevel.Size = New System.Drawing.Size(143, 45)
        Me.tbOSDTranspLevel.TabIndex = 3
        Me.tbOSDTranspLevel.TickFrequency = 10
        '
        'btOSDSetTransp
        '
        Me.btOSDSetTransp.Location = New System.Drawing.Point(178, 41)
        Me.btOSDSetTransp.Name = "btOSDSetTransp"
        Me.btOSDSetTransp.Size = New System.Drawing.Size(48, 23)
        Me.btOSDSetTransp.TabIndex = 2
        Me.btOSDSetTransp.Text = "Set"
        Me.btOSDSetTransp.UseVisualStyleBackColor = true
        '
        'label119
        '
        Me.label119.AutoSize = true
        Me.label119.Location = New System.Drawing.Point(12, 16)
        Me.label119.Name = "label119"
        Me.label119.Size = New System.Drawing.Size(97, 13)
        Me.label119.TabIndex = 0
        Me.label119.Text = "Transparency level"
        '
        'btOSDClearLayers
        '
        Me.btOSDClearLayers.Location = New System.Drawing.Point(15, 207)
        Me.btOSDClearLayers.Name = "btOSDClearLayers"
        Me.btOSDClearLayers.Size = New System.Drawing.Size(140, 23)
        Me.btOSDClearLayers.TabIndex = 12
        Me.btOSDClearLayers.Text = "Remove all layers"
        Me.btOSDClearLayers.UseVisualStyleBackColor = true
        '
        'groupBox15
        '
        Me.groupBox15.Controls.Add(Me.btOSDLayerAdd)
        Me.groupBox15.Controls.Add(Me.edOSDLayerHeight)
        Me.groupBox15.Controls.Add(Me.label111)
        Me.groupBox15.Controls.Add(Me.edOSDLayerWidth)
        Me.groupBox15.Controls.Add(Me.label112)
        Me.groupBox15.Controls.Add(Me.edOSDLayerTop)
        Me.groupBox15.Controls.Add(Me.label110)
        Me.groupBox15.Controls.Add(Me.edOSDLayerLeft)
        Me.groupBox15.Controls.Add(Me.label109)
        Me.groupBox15.Location = New System.Drawing.Point(161, 61)
        Me.groupBox15.Name = "groupBox15"
        Me.groupBox15.Size = New System.Drawing.Size(125, 134)
        Me.groupBox15.TabIndex = 11
        Me.groupBox15.TabStop = false
        Me.groupBox15.Text = "New layer"
        '
        'btOSDLayerAdd
        '
        Me.btOSDLayerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.btOSDLayerAdd.Location = New System.Drawing.Point(31, 107)
        Me.btOSDLayerAdd.Name = "btOSDLayerAdd"
        Me.btOSDLayerAdd.Size = New System.Drawing.Size(56, 23)
        Me.btOSDLayerAdd.TabIndex = 8
        Me.btOSDLayerAdd.Text = "Create"
        Me.btOSDLayerAdd.UseVisualStyleBackColor = true
        '
        'edOSDLayerHeight
        '
        Me.edOSDLayerHeight.Location = New System.Drawing.Point(73, 81)
        Me.edOSDLayerHeight.Name = "edOSDLayerHeight"
        Me.edOSDLayerHeight.Size = New System.Drawing.Size(38, 20)
        Me.edOSDLayerHeight.TabIndex = 7
        Me.edOSDLayerHeight.Text = "200"
        '
        'label111
        '
        Me.label111.AutoSize = true
        Me.label111.Location = New System.Drawing.Point(70, 65)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(38, 13)
        Me.label111.TabIndex = 6
        Me.label111.Text = "Height"
        '
        'edOSDLayerWidth
        '
        Me.edOSDLayerWidth.Location = New System.Drawing.Point(13, 81)
        Me.edOSDLayerWidth.Name = "edOSDLayerWidth"
        Me.edOSDLayerWidth.Size = New System.Drawing.Size(38, 20)
        Me.edOSDLayerWidth.TabIndex = 5
        Me.edOSDLayerWidth.Text = "200"
        '
        'label112
        '
        Me.label112.AutoSize = true
        Me.label112.Location = New System.Drawing.Point(10, 65)
        Me.label112.Name = "label112"
        Me.label112.Size = New System.Drawing.Size(35, 13)
        Me.label112.TabIndex = 4
        Me.label112.Text = "Width"
        '
        'edOSDLayerTop
        '
        Me.edOSDLayerTop.Location = New System.Drawing.Point(73, 42)
        Me.edOSDLayerTop.Name = "edOSDLayerTop"
        Me.edOSDLayerTop.Size = New System.Drawing.Size(38, 20)
        Me.edOSDLayerTop.TabIndex = 3
        Me.edOSDLayerTop.Text = "0"
        '
        'label110
        '
        Me.label110.AutoSize = true
        Me.label110.Location = New System.Drawing.Point(70, 26)
        Me.label110.Name = "label110"
        Me.label110.Size = New System.Drawing.Size(26, 13)
        Me.label110.TabIndex = 2
        Me.label110.Text = "Top"
        '
        'edOSDLayerLeft
        '
        Me.edOSDLayerLeft.Location = New System.Drawing.Point(13, 42)
        Me.edOSDLayerLeft.Name = "edOSDLayerLeft"
        Me.edOSDLayerLeft.Size = New System.Drawing.Size(38, 20)
        Me.edOSDLayerLeft.TabIndex = 1
        Me.edOSDLayerLeft.Text = "0"
        '
        'label109
        '
        Me.label109.AutoSize = true
        Me.label109.Location = New System.Drawing.Point(10, 26)
        Me.label109.Name = "label109"
        Me.label109.Size = New System.Drawing.Size(25, 13)
        Me.label109.TabIndex = 0
        Me.label109.Text = "Left"
        '
        'label108
        '
        Me.label108.AutoSize = true
        Me.label108.Location = New System.Drawing.Point(13, 51)
        Me.label108.Name = "label108"
        Me.label108.Size = New System.Drawing.Size(38, 13)
        Me.label108.TabIndex = 9
        Me.label108.Text = "Layers"
        '
        'tabPage12
        '
        Me.tabPage12.Controls.Add(Me.tabControl5)
        Me.tabPage12.Location = New System.Drawing.Point(4, 22)
        Me.tabPage12.Name = "tabPage12"
        Me.tabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage12.Size = New System.Drawing.Size(301, 492)
        Me.tabPage12.TabIndex = 6
        Me.tabPage12.Text = "Decoders / Splitter"
        Me.tabPage12.UseVisualStyleBackColor = true
        '
        'tabControl5
        '
        Me.tabControl5.Controls.Add(Me.tabPage33)
        Me.tabControl5.Controls.Add(Me.tabPage34)
        Me.tabControl5.Controls.Add(Me.TabPage43)
        Me.tabControl5.Location = New System.Drawing.Point(4, 6)
        Me.tabControl5.Name = "tabControl5"
        Me.tabControl5.SelectedIndex = 0
        Me.tabControl5.Size = New System.Drawing.Size(292, 480)
        Me.tabControl5.TabIndex = 1
        '
        'tabPage33
        '
        Me.tabPage33.Controls.Add(Me.cbCustomSplitter)
        Me.tabPage33.Controls.Add(Me.rbSplitterCustom)
        Me.tabPage33.Controls.Add(Me.rbSplitterDefault)
        Me.tabPage33.Location = New System.Drawing.Point(4, 22)
        Me.tabPage33.Name = "tabPage33"
        Me.tabPage33.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage33.Size = New System.Drawing.Size(284, 454)
        Me.tabPage33.TabIndex = 0
        Me.tabPage33.Text = "Splitter"
        Me.tabPage33.UseVisualStyleBackColor = true
        '
        'cbCustomSplitter
        '
        Me.cbCustomSplitter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomSplitter.FormattingEnabled = true
        Me.cbCustomSplitter.Location = New System.Drawing.Point(38, 62)
        Me.cbCustomSplitter.Name = "cbCustomSplitter"
        Me.cbCustomSplitter.Size = New System.Drawing.Size(234, 21)
        Me.cbCustomSplitter.Sorted = true
        Me.cbCustomSplitter.TabIndex = 31
        '
        'rbSplitterCustom
        '
        Me.rbSplitterCustom.AutoSize = true
        Me.rbSplitterCustom.Location = New System.Drawing.Point(17, 42)
        Me.rbSplitterCustom.Name = "rbSplitterCustom"
        Me.rbSplitterCustom.Size = New System.Drawing.Size(60, 17)
        Me.rbSplitterCustom.TabIndex = 30
        Me.rbSplitterCustom.Text = "Custom"
        Me.rbSplitterCustom.UseVisualStyleBackColor = true
        '
        'rbSplitterDefault
        '
        Me.rbSplitterDefault.AutoSize = true
        Me.rbSplitterDefault.Checked = true
        Me.rbSplitterDefault.Location = New System.Drawing.Point(17, 19)
        Me.rbSplitterDefault.Name = "rbSplitterDefault"
        Me.rbSplitterDefault.Size = New System.Drawing.Size(59, 17)
        Me.rbSplitterDefault.TabIndex = 29
        Me.rbSplitterDefault.TabStop = true
        Me.rbSplitterDefault.Text = "Default"
        Me.rbSplitterDefault.UseVisualStyleBackColor = true
        '
        'tabPage34
        '
        Me.tabPage34.Controls.Add(Me.rbVideoDecoderVFH264)
        Me.tabPage34.Controls.Add(Me.cbCustomVideoDecoder)
        Me.tabPage34.Controls.Add(Me.label28)
        Me.tabPage34.Controls.Add(Me.label27)
        Me.tabPage34.Controls.Add(Me.label26)
        Me.tabPage34.Controls.Add(Me.rbVideoDecoderCustom)
        Me.tabPage34.Controls.Add(Me.rbVideoDecoderFFDShow)
        Me.tabPage34.Controls.Add(Me.rbVideoDecoderMS)
        Me.tabPage34.Controls.Add(Me.rbVideoDecoderDefault)
        Me.tabPage34.Location = New System.Drawing.Point(4, 22)
        Me.tabPage34.Name = "tabPage34"
        Me.tabPage34.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage34.Size = New System.Drawing.Size(284, 454)
        Me.tabPage34.TabIndex = 1
        Me.tabPage34.Text = "Video decoder"
        Me.tabPage34.UseVisualStyleBackColor = true
        '
        'rbVideoDecoderVFH264
        '
        Me.rbVideoDecoderVFH264.AutoSize = true
        Me.rbVideoDecoderVFH264.Location = New System.Drawing.Point(17, 205)
        Me.rbVideoDecoderVFH264.Name = "rbVideoDecoderVFH264"
        Me.rbVideoDecoderVFH264.Size = New System.Drawing.Size(147, 17)
        Me.rbVideoDecoderVFH264.TabIndex = 36
        Me.rbVideoDecoderVFH264.TabStop = true
        Me.rbVideoDecoderVFH264.Text = "VisioForge H264 Decoder"
        Me.rbVideoDecoderVFH264.UseVisualStyleBackColor = true
        '
        'cbCustomVideoDecoder
        '
        Me.cbCustomVideoDecoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomVideoDecoder.FormattingEnabled = true
        Me.cbCustomVideoDecoder.Location = New System.Drawing.Point(38, 261)
        Me.cbCustomVideoDecoder.Name = "cbCustomVideoDecoder"
        Me.cbCustomVideoDecoder.Size = New System.Drawing.Size(233, 21)
        Me.cbCustomVideoDecoder.Sorted = true
        Me.cbCustomVideoDecoder.TabIndex = 35
        '
        'label28
        '
        Me.label28.AutoSize = true
        Me.label28.Location = New System.Drawing.Point(35, 174)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(97, 13)
        Me.label28.TabIndex = 34
        Me.label28.Text = "and DVD playback"
        '
        'label27
        '
        Me.label27.AutoSize = true
        Me.label27.Location = New System.Drawing.Point(35, 151)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(244, 13)
        Me.label27.TabIndex = 33
        Me.label27.Text = "To play DVD you must activate MPEG-2 decoding"
        '
        'label26
        '
        Me.label26.AutoSize = true
        Me.label26.Location = New System.Drawing.Point(35, 85)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(195, 13)
        Me.label26.TabIndex = 32
        Me.label26.Text = "Available on Vista / 7 Premium and later"
        '
        'rbVideoDecoderCustom
        '
        Me.rbVideoDecoderCustom.AutoSize = true
        Me.rbVideoDecoderCustom.Location = New System.Drawing.Point(17, 238)
        Me.rbVideoDecoderCustom.Name = "rbVideoDecoderCustom"
        Me.rbVideoDecoderCustom.Size = New System.Drawing.Size(60, 17)
        Me.rbVideoDecoderCustom.TabIndex = 31
        Me.rbVideoDecoderCustom.Text = "Custom"
        Me.rbVideoDecoderCustom.UseVisualStyleBackColor = true
        '
        'rbVideoDecoderFFDShow
        '
        Me.rbVideoDecoderFFDShow.AutoSize = true
        Me.rbVideoDecoderFFDShow.Location = New System.Drawing.Point(17, 121)
        Me.rbVideoDecoderFFDShow.Name = "rbVideoDecoderFFDShow"
        Me.rbVideoDecoderFFDShow.Size = New System.Drawing.Size(72, 17)
        Me.rbVideoDecoderFFDShow.TabIndex = 30
        Me.rbVideoDecoderFFDShow.Text = "FFDShow"
        Me.rbVideoDecoderFFDShow.UseVisualStyleBackColor = true
        '
        'rbVideoDecoderMS
        '
        Me.rbVideoDecoderMS.AutoSize = true
        Me.rbVideoDecoderMS.Location = New System.Drawing.Point(17, 56)
        Me.rbVideoDecoderMS.Name = "rbVideoDecoderMS"
        Me.rbVideoDecoderMS.Size = New System.Drawing.Size(195, 17)
        Me.rbVideoDecoderMS.TabIndex = 29
        Me.rbVideoDecoderMS.Text = "Microsoft DTV/DVD Video Decoder"
        Me.rbVideoDecoderMS.UseVisualStyleBackColor = true
        '
        'rbVideoDecoderDefault
        '
        Me.rbVideoDecoderDefault.AutoSize = true
        Me.rbVideoDecoderDefault.Checked = true
        Me.rbVideoDecoderDefault.Location = New System.Drawing.Point(17, 19)
        Me.rbVideoDecoderDefault.Name = "rbVideoDecoderDefault"
        Me.rbVideoDecoderDefault.Size = New System.Drawing.Size(59, 17)
        Me.rbVideoDecoderDefault.TabIndex = 28
        Me.rbVideoDecoderDefault.TabStop = true
        Me.rbVideoDecoderDefault.Text = "Default"
        Me.rbVideoDecoderDefault.UseVisualStyleBackColor = true
        '
        'TabPage43
        '
        Me.TabPage43.Controls.Add(Me.cbCustomAudioDecoder)
        Me.TabPage43.Controls.Add(Me.rbAudioDecoderCustom)
        Me.TabPage43.Controls.Add(Me.rbAudioDecoderDefault)
        Me.TabPage43.Location = New System.Drawing.Point(4, 22)
        Me.TabPage43.Name = "TabPage43"
        Me.TabPage43.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage43.Size = New System.Drawing.Size(284, 454)
        Me.TabPage43.TabIndex = 2
        Me.TabPage43.Text = "Audio decoder"
        Me.TabPage43.UseVisualStyleBackColor = true
        '
        'cbCustomAudioDecoder
        '
        Me.cbCustomAudioDecoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCustomAudioDecoder.FormattingEnabled = true
        Me.cbCustomAudioDecoder.Location = New System.Drawing.Point(39, 62)
        Me.cbCustomAudioDecoder.Name = "cbCustomAudioDecoder"
        Me.cbCustomAudioDecoder.Size = New System.Drawing.Size(233, 21)
        Me.cbCustomAudioDecoder.Sorted = true
        Me.cbCustomAudioDecoder.TabIndex = 34
        '
        'rbAudioDecoderCustom
        '
        Me.rbAudioDecoderCustom.AutoSize = true
        Me.rbAudioDecoderCustom.Location = New System.Drawing.Point(17, 42)
        Me.rbAudioDecoderCustom.Name = "rbAudioDecoderCustom"
        Me.rbAudioDecoderCustom.Size = New System.Drawing.Size(60, 17)
        Me.rbAudioDecoderCustom.TabIndex = 33
        Me.rbAudioDecoderCustom.Text = "Custom"
        Me.rbAudioDecoderCustom.UseVisualStyleBackColor = true
        '
        'rbAudioDecoderDefault
        '
        Me.rbAudioDecoderDefault.AutoSize = true
        Me.rbAudioDecoderDefault.Checked = true
        Me.rbAudioDecoderDefault.Location = New System.Drawing.Point(17, 19)
        Me.rbAudioDecoderDefault.Name = "rbAudioDecoderDefault"
        Me.rbAudioDecoderDefault.Size = New System.Drawing.Size(59, 17)
        Me.rbAudioDecoderDefault.TabIndex = 32
        Me.rbAudioDecoderDefault.TabStop = true
        Me.rbAudioDecoderDefault.Text = "Default"
        Me.rbAudioDecoderDefault.UseVisualStyleBackColor = true
        '
        'tabPage13
        '
        Me.tabPage13.Controls.Add(Me.tabControl9)
        Me.tabPage13.Controls.Add(Me.cbMotDetEnabled)
        Me.tabPage13.Location = New System.Drawing.Point(4, 22)
        Me.tabPage13.Name = "tabPage13"
        Me.tabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage13.Size = New System.Drawing.Size(301, 492)
        Me.tabPage13.TabIndex = 7
        Me.tabPage13.Text = "Motion detection"
        Me.tabPage13.UseVisualStyleBackColor = true
        '
        'tabControl9
        '
        Me.tabControl9.Controls.Add(Me.tabPage44)
        Me.tabControl9.Controls.Add(Me.tabPage45)
        Me.tabControl9.Location = New System.Drawing.Point(15, 43)
        Me.tabControl9.Name = "tabControl9"
        Me.tabControl9.SelectedIndex = 0
        Me.tabControl9.Size = New System.Drawing.Size(268, 413)
        Me.tabControl9.TabIndex = 3
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
        Me.pbMotionLevel.Location = New System.Drawing.Point(17, 346)
        Me.pbMotionLevel.Name = "pbMotionLevel"
        Me.pbMotionLevel.Size = New System.Drawing.Size(227, 19)
        Me.pbMotionLevel.TabIndex = 2
        '
        'label158
        '
        Me.label158.AutoSize = true
        Me.label158.Location = New System.Drawing.Point(16, 326)
        Me.label158.Name = "label158"
        Me.label158.Size = New System.Drawing.Size(64, 13)
        Me.label158.TabIndex = 1
        Me.label158.Text = "Motion level"
        '
        'mmMotDetMatrix
        '
        Me.mmMotDetMatrix.Location = New System.Drawing.Point(6, 6)
        Me.mmMotDetMatrix.Multiline = true
        Me.mmMotDetMatrix.Name = "mmMotDetMatrix"
        Me.mmMotDetMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmMotDetMatrix.Size = New System.Drawing.Size(248, 246)
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
        Me.cbMotDetEnabled.Location = New System.Drawing.Point(15, 16)
        Me.cbMotDetEnabled.Name = "cbMotDetEnabled"
        Me.cbMotDetEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbMotDetEnabled.TabIndex = 2
        Me.cbMotDetEnabled.Text = "Enabled"
        Me.cbMotDetEnabled.UseVisualStyleBackColor = true
        '
        'TabPage21
        '
        Me.TabPage21.Controls.Add(Me.edBarcodeMetadata)
        Me.TabPage21.Controls.Add(Me.label91)
        Me.TabPage21.Controls.Add(Me.cbBarcodeType)
        Me.TabPage21.Controls.Add(Me.label90)
        Me.TabPage21.Controls.Add(Me.btBarcodeReset)
        Me.TabPage21.Controls.Add(Me.edBarcode)
        Me.TabPage21.Controls.Add(Me.label89)
        Me.TabPage21.Controls.Add(Me.cbBarcodeDetectionEnabled)
        Me.TabPage21.Location = New System.Drawing.Point(4, 22)
        Me.TabPage21.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage21.Name = "TabPage21"
        Me.TabPage21.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage21.Size = New System.Drawing.Size(301, 492)
        Me.TabPage21.TabIndex = 8
        Me.TabPage21.Text = "Barcode reader"
        Me.TabPage21.UseVisualStyleBackColor = true
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
        Me.cbBarcodeDetectionEnabled.Location = New System.Drawing.Point(12, 13)
        Me.cbBarcodeDetectionEnabled.Name = "cbBarcodeDetectionEnabled"
        Me.cbBarcodeDetectionEnabled.Size = New System.Drawing.Size(65, 17)
        Me.cbBarcodeDetectionEnabled.TabIndex = 17
        Me.cbBarcodeDetectionEnabled.Text = "Enabled"
        Me.cbBarcodeDetectionEnabled.UseVisualStyleBackColor = true
        '
        'TabPage23
        '
        Me.TabPage23.Controls.Add(Me.groupBox48)
        Me.TabPage23.Location = New System.Drawing.Point(4, 22)
        Me.TabPage23.Name = "TabPage23"
        Me.TabPage23.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage23.Size = New System.Drawing.Size(301, 492)
        Me.TabPage23.TabIndex = 9
        Me.TabPage23.Text = "Encryption"
        Me.TabPage23.UseVisualStyleBackColor = true
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
        Me.groupBox48.Location = New System.Drawing.Point(16, 12)
        Me.groupBox48.Name = "groupBox48"
        Me.groupBox48.Size = New System.Drawing.Size(269, 224)
        Me.groupBox48.TabIndex = 10
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
        'TabPage24
        '
        Me.TabPage24.Controls.Add(Me.btReversePlaybackNextFrame)
        Me.TabPage24.Controls.Add(Me.btReversePlaybackPrevFrame)
        Me.TabPage24.Controls.Add(Me.label34)
        Me.TabPage24.Controls.Add(Me.label33)
        Me.TabPage24.Controls.Add(Me.btReversePlayback)
        Me.TabPage24.Controls.Add(Me.edReversePlaybackCacheSize)
        Me.TabPage24.Controls.Add(Me.label32)
        Me.TabPage24.Controls.Add(Me.tbReversePlaybackTrackbar)
        Me.TabPage24.Location = New System.Drawing.Point(4, 22)
        Me.TabPage24.Name = "TabPage24"
        Me.TabPage24.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage24.Size = New System.Drawing.Size(301, 492)
        Me.TabPage24.TabIndex = 10
        Me.TabPage24.Text = "Reverse playback"
        Me.TabPage24.UseVisualStyleBackColor = true
        '
        'btReversePlaybackNextFrame
        '
        Me.btReversePlaybackNextFrame.Location = New System.Drawing.Point(129, 209)
        Me.btReversePlaybackNextFrame.Name = "btReversePlaybackNextFrame"
        Me.btReversePlaybackNextFrame.Size = New System.Drawing.Size(105, 23)
        Me.btReversePlaybackNextFrame.TabIndex = 18
        Me.btReversePlaybackNextFrame.Text = "Next frame"
        Me.btReversePlaybackNextFrame.UseVisualStyleBackColor = true
        '
        'btReversePlaybackPrevFrame
        '
        Me.btReversePlaybackPrevFrame.Location = New System.Drawing.Point(18, 209)
        Me.btReversePlaybackPrevFrame.Name = "btReversePlaybackPrevFrame"
        Me.btReversePlaybackPrevFrame.Size = New System.Drawing.Size(105, 23)
        Me.btReversePlaybackPrevFrame.TabIndex = 17
        Me.btReversePlaybackPrevFrame.Text = "Previous frame"
        Me.btReversePlaybackPrevFrame.UseVisualStyleBackColor = true
        '
        'label34
        '
        Me.label34.AutoSize = true
        Me.label34.Location = New System.Drawing.Point(15, 116)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(108, 13)
        Me.label34.TabIndex = 16
        Me.label34.Text = "count before tracking"
        '
        'label33
        '
        Me.label33.AutoSize = true
        Me.label33.Location = New System.Drawing.Point(15, 99)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(229, 13)
        Me.label33.TabIndex = 15
        Me.label33.Text = "Wait several seconds to cache required frames"
        '
        'btReversePlayback
        '
        Me.btReversePlayback.Location = New System.Drawing.Point(18, 64)
        Me.btReversePlayback.Name = "btReversePlayback"
        Me.btReversePlayback.Size = New System.Drawing.Size(190, 23)
        Me.btReversePlayback.TabIndex = 14
        Me.btReversePlayback.Text = "Go to reverse playback mode"
        Me.btReversePlayback.UseVisualStyleBackColor = true
        '
        'edReversePlaybackCacheSize
        '
        Me.edReversePlaybackCacheSize.Location = New System.Drawing.Point(141, 15)
        Me.edReversePlaybackCacheSize.Name = "edReversePlaybackCacheSize"
        Me.edReversePlaybackCacheSize.Size = New System.Drawing.Size(67, 20)
        Me.edReversePlaybackCacheSize.TabIndex = 13
        Me.edReversePlaybackCacheSize.Text = "100"
        '
        'label32
        '
        Me.label32.AutoSize = true
        Me.label32.Location = New System.Drawing.Point(15, 18)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(90, 13)
        Me.label32.TabIndex = 12
        Me.label32.Text = "Frame cache size"
        '
        'tbReversePlaybackTrackbar
        '
        Me.tbReversePlaybackTrackbar.Location = New System.Drawing.Point(18, 142)
        Me.tbReversePlaybackTrackbar.Maximum = 100
        Me.tbReversePlaybackTrackbar.Name = "tbReversePlaybackTrackbar"
        Me.tbReversePlaybackTrackbar.Size = New System.Drawing.Size(190, 45)
        Me.tbReversePlaybackTrackbar.TabIndex = 11
        Me.tbReversePlaybackTrackbar.Value = 100
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.label505)
        Me.TabPage14.Controls.Add(Me.rbMotionDetectionExProcessor)
        Me.TabPage14.Controls.Add(Me.label389)
        Me.TabPage14.Controls.Add(Me.rbMotionDetectionExDetector)
        Me.TabPage14.Controls.Add(Me.label64)
        Me.TabPage14.Controls.Add(Me.label65)
        Me.TabPage14.Controls.Add(Me.pbAFMotionLevel)
        Me.TabPage14.Controls.Add(Me.cbMotionDetectionEx)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(301, 492)
        Me.TabPage14.TabIndex = 14
        Me.TabPage14.Text = "Motion detection (Extended)"
        Me.TabPage14.UseVisualStyleBackColor = true
        '
        'label505
        '
        Me.label505.AutoSize = true
        Me.label505.Location = New System.Drawing.Point(16, 100)
        Me.label505.Name = "label505"
        Me.label505.Size = New System.Drawing.Size(54, 13)
        Me.label505.TabIndex = 31
        Me.label505.Text = "Processor"
        '
        'rbMotionDetectionExProcessor
        '
        Me.rbMotionDetectionExProcessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rbMotionDetectionExProcessor.FormattingEnabled = true
        Me.rbMotionDetectionExProcessor.Items.AddRange(New Object() {"None", "Blob counting objects", "GridMotionAreaProcessing", "Motion area highlighting", "Motion border highlighting"})
        Me.rbMotionDetectionExProcessor.Location = New System.Drawing.Point(16, 116)
        Me.rbMotionDetectionExProcessor.Name = "rbMotionDetectionExProcessor"
        Me.rbMotionDetectionExProcessor.Size = New System.Drawing.Size(258, 21)
        Me.rbMotionDetectionExProcessor.TabIndex = 30
        '
        'label389
        '
        Me.label389.AutoSize = true
        Me.label389.Location = New System.Drawing.Point(16, 50)
        Me.label389.Name = "label389"
        Me.label389.Size = New System.Drawing.Size(48, 13)
        Me.label389.TabIndex = 29
        Me.label389.Text = "Detector"
        '
        'rbMotionDetectionExDetector
        '
        Me.rbMotionDetectionExDetector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rbMotionDetectionExDetector.FormattingEnabled = true
        Me.rbMotionDetectionExDetector.Items.AddRange(New Object() {"Custom frame difference", "Simple background modeling", "Two frames difference"})
        Me.rbMotionDetectionExDetector.Location = New System.Drawing.Point(16, 66)
        Me.rbMotionDetectionExDetector.Name = "rbMotionDetectionExDetector"
        Me.rbMotionDetectionExDetector.Size = New System.Drawing.Size(258, 21)
        Me.rbMotionDetectionExDetector.TabIndex = 28
        '
        'label64
        '
        Me.label64.AutoSize = true
        Me.label64.Location = New System.Drawing.Point(53, 438)
        Me.label64.Name = "label64"
        Me.label64.Size = New System.Drawing.Size(173, 13)
        Me.label64.TabIndex = 27
        Me.label64.Text = "Much more options available in API"
        '
        'label65
        '
        Me.label65.AutoSize = true
        Me.label65.Location = New System.Drawing.Point(16, 158)
        Me.label65.Name = "label65"
        Me.label65.Size = New System.Drawing.Size(64, 13)
        Me.label65.TabIndex = 26
        Me.label65.Text = "Motion level"
        '
        'pbAFMotionLevel
        '
        Me.pbAFMotionLevel.Location = New System.Drawing.Point(16, 174)
        Me.pbAFMotionLevel.Name = "pbAFMotionLevel"
        Me.pbAFMotionLevel.Size = New System.Drawing.Size(258, 23)
        Me.pbAFMotionLevel.TabIndex = 25
        '
        'cbMotionDetectionEx
        '
        Me.cbMotionDetectionEx.AutoSize = true
        Me.cbMotionDetectionEx.Location = New System.Drawing.Point(16, 12)
        Me.cbMotionDetectionEx.Name = "cbMotionDetectionEx"
        Me.cbMotionDetectionEx.Size = New System.Drawing.Size(65, 17)
        Me.cbMotionDetectionEx.TabIndex = 24
        Me.cbMotionDetectionEx.Text = "Enabled"
        Me.cbMotionDetectionEx.UseVisualStyleBackColor = true
        '
        'fontDialog1
        '
        Me.fontDialog1.Color = System.Drawing.Color.White
        Me.fontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.fontDialog1.FontMustExist = true
        Me.fontDialog1.ShowColor = true
        '
        'openFileDialog2
        '
        Me.openFileDialog2.Filter = "Pictures|*.bmp; *.jpg; *.jpeg; *.jpe; *.png; *.gif; *.tiff;|All files|*.*"
        '
        'timer1
        '
        '
        'btAddFileToPlaylist
        '
        Me.btAddFileToPlaylist.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btAddFileToPlaylist.Location = New System.Drawing.Point(682, 24)
        Me.btAddFileToPlaylist.Margin = New System.Windows.Forms.Padding(2)
        Me.btAddFileToPlaylist.Name = "btAddFileToPlaylist"
        Me.btAddFileToPlaylist.Size = New System.Drawing.Size(38, 22)
        Me.btAddFileToPlaylist.TabIndex = 33
        Me.btAddFileToPlaylist.Text = "Add"
        Me.btAddFileToPlaylist.UseVisualStyleBackColor = true
        '
        'label30
        '
        Me.label30.AutoSize = true
        Me.label30.Location = New System.Drawing.Point(327, 46)
        Me.label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(39, 13)
        Me.label30.TabIndex = 32
        Me.label30.Text = "Playlist"
        '
        'lbSourceFiles
        '
        Me.lbSourceFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbSourceFiles.ContextMenuStrip = Me.mnPlaylist
        Me.lbSourceFiles.FormattingEnabled = true
        Me.lbSourceFiles.Location = New System.Drawing.Point(329, 62)
        Me.lbSourceFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.lbSourceFiles.Name = "lbSourceFiles"
        Me.lbSourceFiles.Size = New System.Drawing.Size(415, 56)
        Me.lbSourceFiles.TabIndex = 31
        '
        'mnPlaylist
        '
        Me.mnPlaylist.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPlaylistRemove, Me.mnPlaylistRemoveAll})
        Me.mnPlaylist.Name = "mnPlaylist"
        Me.mnPlaylist.Size = New System.Drawing.Size(133, 48)
        '
        'mnPlaylistRemove
        '
        Me.mnPlaylistRemove.Name = "mnPlaylistRemove"
        Me.mnPlaylistRemove.Size = New System.Drawing.Size(132, 22)
        Me.mnPlaylistRemove.Text = "Remove"
        '
        'mnPlaylistRemoveAll
        '
        Me.mnPlaylistRemoveAll.Name = "mnPlaylistRemoveAll"
        Me.mnPlaylistRemoveAll.Size = New System.Drawing.Size(132, 22)
        Me.mnPlaylistRemoveAll.Text = "Remove all"
        '
        'cbSourceMode
        '
        Me.cbSourceMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbSourceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSourceMode.FormattingEnabled = true
        Me.cbSourceMode.Items.AddRange(New Object() {"File / Network stream (decode using LAV)", "File / Network stream (decode using GPU)", "File (decode using FFMPEG)", "File (decode using DirectShow)", "File (decode using VLC)", "DVD", "Blu-Ray", "File from memory (decode using DirectShow)", "File from memory (decode using FFMPEG)", "MMS / WMV (network stream)", "HTTP / RTSP / RTMP (decoding using FFMPEG)", "HTTP / RTSP / RTMP (decoding using VLC)", "Encrypted file (decode using DirectShow)", "MIDI / KAR"})
        Me.cbSourceMode.Location = New System.Drawing.Point(394, 122)
        Me.cbSourceMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSourceMode.Name = "cbSourceMode"
        Me.cbSourceMode.Size = New System.Drawing.Size(350, 21)
        Me.cbSourceMode.TabIndex = 30
        '
        'label29
        '
        Me.label29.AutoSize = true
        Me.label29.Location = New System.Drawing.Point(326, 125)
        Me.label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(64, 13)
        Me.label29.TabIndex = 29
        Me.label29.Text = "Source type"
        '
        'btSelectFile
        '
        Me.btSelectFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btSelectFile.Location = New System.Drawing.Point(722, 23)
        Me.btSelectFile.Name = "btSelectFile"
        Me.btSelectFile.Size = New System.Drawing.Size(23, 23)
        Me.btSelectFile.TabIndex = 28
        Me.btSelectFile.Text = "..."
        Me.btSelectFile.UseVisualStyleBackColor = true
        '
        'edFilenameOrURL
        '
        Me.edFilenameOrURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.edFilenameOrURL.Location = New System.Drawing.Point(329, 24)
        Me.edFilenameOrURL.Name = "edFilenameOrURL"
        Me.edFilenameOrURL.Size = New System.Drawing.Size(348, 20)
        Me.edFilenameOrURL.TabIndex = 27
        Me.edFilenameOrURL.Text = "c:\Samples\!video.mp4"
        '
        'label14
        '
        Me.label14.AutoSize = true
        Me.label14.Location = New System.Drawing.Point(326, 9)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(89, 13)
        Me.label14.TabIndex = 26
        Me.label14.Text = "File name or URL"
        '
        'linkLabel1
        '
        Me.linkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.linkLabel1.AutoSize = true
        Me.linkLabel1.Location = New System.Drawing.Point(635, 7)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(110, 13)
        Me.linkLabel1.TabIndex = 34
        Me.linkLabel1.TabStop = true
        Me.linkLabel1.Text = "Watch video tutorials!"
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Audio_Channel_Mapper = Nothing
        Me.MediaPlayer1.Audio_Effects_Enabled = false
        Me.MediaPlayer1.Audio_Effects_UseLegacyEffects = false
        Me.MediaPlayer1.Audio_Enhancer_Enabled = false
        Me.MediaPlayer1.Audio_OutputDevice = ""
        Me.MediaPlayer1.Audio_PlayAudio = true
        Me.MediaPlayer1.Audio_Sample_Grabber_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Pro_Enabled = false
        Me.MediaPlayer1.Audio_VUMeter_Pro_Volume = 0
        Me.MediaPlayer1.BackColor = System.Drawing.Color.Black
        Me.MediaPlayer1.Barcode_Reader_Enabled = false
        Me.MediaPlayer1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.MediaPlayer1.ChromaKey = Nothing
        Me.MediaPlayer1.Custom_Audio_Decoder = Nothing
        Me.MediaPlayer1.Custom_Splitter = Nothing
        Me.MediaPlayer1.Custom_Video_Decoder = Nothing
        Me.MediaPlayer1.CustomParameters = CType(resources.GetObject("MediaPlayer1.CustomParameters"),System.Collections.Generic.Dictionary(Of String, String))
        Me.MediaPlayer1.CustomRedist_Auto = true
        Me.MediaPlayer1.CustomRedist_Enabled = false
        Me.MediaPlayer1.CustomRedist_Path = Nothing
        Me.MediaPlayer1.Debug_DeepCleanUp = false
        Me.MediaPlayer1.Debug_Dir = Nothing
        Me.MediaPlayer1.Debug_Mode = false
        Me.MediaPlayer1.Debug_Telemetry = false
        Me.MediaPlayer1.Encryption_Key = ""
        Me.MediaPlayer1.Encryption_KeyType = VisioForge.Types.VFEncryptionKeyType.[String]
        Me.MediaPlayer1.Face_Tracking = Nothing
        Me.MediaPlayer1.FilenamesOrURL = CType(resources.GetObject("MediaPlayer1.FilenamesOrURL"),System.Collections.Generic.List(Of String))
        Me.MediaPlayer1.Info_UseLibMediaInfo = false
        Me.MediaPlayer1.Location = New System.Drawing.Point(329, 150)
        Me.MediaPlayer1.Loop = false
        Me.MediaPlayer1.Loop_DoNotSeekToBeginning = false
        Me.MediaPlayer1.MaximalSpeedPlayback = false
        Me.MediaPlayer1.MIDI_Renderer = Nothing
        Me.MediaPlayer1.Motion_Detection = Nothing
        Me.MediaPlayer1.Motion_DetectionEx = Nothing
        Me.MediaPlayer1.MultiScreen_Enabled = false
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OSD_Enabled = false
        Me.MediaPlayer1.Play_DelayEnabled = false
        Me.MediaPlayer1.Play_PauseAtFirstFrame = false
        Me.MediaPlayer1.ReversePlayback_CacheSize = 0
        Me.MediaPlayer1.ReversePlayback_Enabled = false
        Me.MediaPlayer1.Selection_Active = false
        Me.MediaPlayer1.Selection_Start = 0
        Me.MediaPlayer1.Selection_Stop = 0
        Me.MediaPlayer1.Size = New System.Drawing.Size(415, 314)
        Me.MediaPlayer1.Source_Custom_CLSID = Nothing
        Me.MediaPlayer1.Source_GPU_Mode = VisioForge.Types.VFMediaPlayerSourceGPUDecoder.nVidiaCUVID
        Me.MediaPlayer1.Source_Mode = VisioForge.Types.VFMediaPlayerSource.File_DS
        Me.MediaPlayer1.Source_Stream = Nothing
        Me.MediaPlayer1.Source_Stream_AudioPresent = true
        Me.MediaPlayer1.Source_Stream_Size = CType(0,Long)
        Me.MediaPlayer1.Source_Stream_VideoPresent = true
        Me.MediaPlayer1.TabIndex = 25
        Me.MediaPlayer1.Video_Effects_Enabled = false
        Me.MediaPlayer1.Video_Effects_GPU_Enabled = false
        VideoRendererSettingsWinForms1.Aspect_Ratio_Override = false
        VideoRendererSettingsWinForms1.Aspect_Ratio_X = 0
        VideoRendererSettingsWinForms1.Aspect_Ratio_Y = 0
        VideoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Empty
        VideoRendererSettingsWinForms1.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.[Auto]
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_Mode = Nothing
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_UseDefault = false
        VideoRendererSettingsWinForms1.Flip_Horizontal = false
        VideoRendererSettingsWinForms1.Flip_Vertical = false
        VideoRendererSettingsWinForms1.RotationAngle = 0
        VideoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox
        VideoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.VideoRenderer
        VideoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.VideoRenderer
        VideoRendererSettingsWinForms1.Zoom_Ratio = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftX = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftY = 0
        Me.MediaPlayer1.Video_Renderer = VideoRendererSettingsWinForms1
        Me.MediaPlayer1.Video_Sample_Grabber_UseForVideoEffects = false
        Me.MediaPlayer1.Video_Stream_Index = 0
        Me.MediaPlayer1.Virtual_Camera_Output_Enabled = false
        Me.MediaPlayer1.Virtual_Camera_Output_LicenseKey = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 686)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.btAddFileToPlaylist)
        Me.Controls.Add(Me.label30)
        Me.Controls.Add(Me.lbSourceFiles)
        Me.Controls.Add(Me.cbSourceMode)
        Me.Controls.Add(Me.label29)
        Me.Controls.Add(Me.btSelectFile)
        Me.Controls.Add(Me.edFilenameOrURL)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.tabControl3)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.tabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Media Player SDK .Net - Main Demo"
        Me.tabControl3.ResumeLayout(false)
        Me.tabPage10.ResumeLayout(false)
        Me.tabPage10.PerformLayout
        Me.tabPage9.ResumeLayout(false)
        Me.tabControl13.ResumeLayout(false)
        Me.tabPage54.ResumeLayout(false)
        Me.tabPage54.PerformLayout
        CType(Me.tbJPEGQuality,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage55.ResumeLayout(false)
        Me.tabPage55.PerformLayout
        Me.groupBox3.ResumeLayout(false)
        Me.groupBox3.PerformLayout
        Me.groupBox2.ResumeLayout(false)
        Me.groupBox2.PerformLayout
        CType(Me.tbSpeed,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbTimeline,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabControl1.ResumeLayout(false)
        Me.TabPage20.ResumeLayout(false)
        Me.groupBox6.ResumeLayout(false)
        Me.groupBox6.PerformLayout
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabControl2.ResumeLayout(false)
        Me.tabPage6.ResumeLayout(false)
        Me.tabPage6.PerformLayout
        Me.tabPage7.ResumeLayout(false)
        Me.tabPage7.PerformLayout
        Me.TabPage47.ResumeLayout(false)
        Me.TabPage47.PerformLayout
        CType(Me.imgTags,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage2.ResumeLayout(false)
        Me.tabPage2.PerformLayout
        CType(Me.tbBalance4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVolume4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBalance3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVolume3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBalance2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVolume2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBalance1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVolume1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage3.ResumeLayout(false)
        Me.tabControl4.ResumeLayout(false)
        Me.tabPage16.ResumeLayout(false)
        Me.tabPage16.PerformLayout
        Me.groupBox28.ResumeLayout(false)
        Me.groupBox13.ResumeLayout(false)
        Me.groupBox13.PerformLayout
        Me.tabPage17.ResumeLayout(false)
        Me.tabPage17.PerformLayout
        Me.tabPage4.ResumeLayout(false)
        Me.tabControl17.ResumeLayout(false)
        Me.tabPage68.ResumeLayout(false)
        Me.tabPage68.PerformLayout
        Me.tabControl7.ResumeLayout(false)
        Me.tabPage29.ResumeLayout(false)
        Me.tabPage42.ResumeLayout(false)
        Me.TabPage18.ResumeLayout(false)
        Me.TabPage18.PerformLayout
        Me.groupBox37.ResumeLayout(false)
        Me.TabPage19.ResumeLayout(false)
        Me.TabPage19.PerformLayout
        Me.groupBox40.ResumeLayout(false)
        Me.groupBox40.PerformLayout
        Me.groupBox39.ResumeLayout(false)
        Me.groupBox39.PerformLayout
        Me.groupBox38.ResumeLayout(false)
        Me.groupBox38.PerformLayout
        Me.TabPage22.ResumeLayout(false)
        Me.TabPage22.PerformLayout
        Me.groupBox45.ResumeLayout(false)
        Me.groupBox45.PerformLayout
        Me.TabPage27.ResumeLayout(false)
        Me.TabPage27.PerformLayout
        CType(Me.tbLiveRotationAngle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbDarkness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbLightness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbSaturation,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage69.ResumeLayout(false)
        Me.tabPage69.PerformLayout
        Me.tabPage59.ResumeLayout(false)
        Me.tabPage59.PerformLayout
        Me.TabPage50.ResumeLayout(false)
        Me.TabPage50.PerformLayout
        CType(Me.tbGPUBlur,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPUContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPUDarkness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPULightness,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbGPUSaturation,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage8.ResumeLayout(false)
        Me.tabPage8.PerformLayout
        CType(Me.tbAdjSaturation,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAdjHue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAdjContrast,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAdjBrightness,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage15.ResumeLayout(false)
        Me.tabPage15.PerformLayout
        CType(Me.tbChromaKeySmoothing,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbChromaKeyThresholdSensitivity,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage28.ResumeLayout(false)
        Me.TabPage28.PerformLayout
        Me.tabPage11.ResumeLayout(false)
        Me.tabPage11.PerformLayout
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
        Me.TabPage46.ResumeLayout(false)
        Me.TabPage46.PerformLayout
        CType(Me.tbAudioTimeshift,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox4.ResumeLayout(false)
        Me.groupBox4.PerformLayout
        CType(Me.tbAudioOutputGainLFE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainSR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainSL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioOutputGainL,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox1.ResumeLayout(false)
        Me.groupBox1.PerformLayout
        CType(Me.tbAudioInputGainLFE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainSR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainSL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainR,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbAudioInputGainL,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage49.ResumeLayout(false)
        Me.TabPage49.PerformLayout
        Me.groupBox41.ResumeLayout(false)
        Me.groupBox41.PerformLayout
        CType(Me.tbAudioChannelMapperVolume,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage25.ResumeLayout(false)
        Me.TabPage25.PerformLayout
        CType(Me.tbVUMeterBoost,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbVUMeterAmplification,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage5.ResumeLayout(false)
        Me.tabPage5.PerformLayout
        Me.groupBox19.ResumeLayout(false)
        Me.tabControl6.ResumeLayout(false)
        Me.tabPage30.ResumeLayout(false)
        Me.tabPage30.PerformLayout
        Me.tabPage31.ResumeLayout(false)
        Me.tabPage31.PerformLayout
        Me.tabPage32.ResumeLayout(false)
        Me.tabPage32.PerformLayout
        CType(Me.tbOSDTranspLevel,System.ComponentModel.ISupportInitialize).EndInit
        Me.groupBox15.ResumeLayout(false)
        Me.groupBox15.PerformLayout
        Me.tabPage12.ResumeLayout(false)
        Me.tabControl5.ResumeLayout(false)
        Me.tabPage33.ResumeLayout(false)
        Me.tabPage33.PerformLayout
        Me.tabPage34.ResumeLayout(false)
        Me.tabPage34.PerformLayout
        Me.TabPage43.ResumeLayout(false)
        Me.TabPage43.PerformLayout
        Me.tabPage13.ResumeLayout(false)
        Me.tabPage13.PerformLayout
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
        Me.TabPage21.ResumeLayout(false)
        Me.TabPage21.PerformLayout
        Me.TabPage23.ResumeLayout(false)
        Me.groupBox48.ResumeLayout(false)
        Me.groupBox48.PerformLayout
        Me.TabPage24.ResumeLayout(false)
        Me.TabPage24.PerformLayout
        CType(Me.tbReversePlaybackTrackbar,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage14.ResumeLayout(false)
        Me.TabPage14.PerformLayout
        Me.mnPlaylist.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents tabControl3 As System.Windows.Forms.TabControl
    Private WithEvents tabPage9 As System.Windows.Forms.TabPage
    Private WithEvents tabControl13 As System.Windows.Forms.TabControl
    Private WithEvents tabPage54 As System.Windows.Forms.TabPage
    Private WithEvents cbImageType As System.Windows.Forms.ComboBox
    Private WithEvents lbJPEGQuality As System.Windows.Forms.Label
    Private WithEvents label38 As System.Windows.Forms.Label
    Private WithEvents btSaveScreenshot As System.Windows.Forms.Button
    Private WithEvents btSelectScreenshotsFolder As System.Windows.Forms.Button
    Private WithEvents label63 As System.Windows.Forms.Label
    Private WithEvents edScreenshotsFolder As System.Windows.Forms.TextBox
    Private WithEvents tbJPEGQuality As System.Windows.Forms.TrackBar
    Private WithEvents tabPage55 As System.Windows.Forms.TabPage
    Private WithEvents edScreenshotHeight As System.Windows.Forms.TextBox
    Private WithEvents label176 As System.Windows.Forms.Label
    Private WithEvents edScreenshotWidth As System.Windows.Forms.TextBox
    Private WithEvents label177 As System.Windows.Forms.Label
    Private WithEvents cbScreenshotResize As System.Windows.Forms.CheckBox
    Private WithEvents tabPage10 As System.Windows.Forms.TabPage
    Private WithEvents mmLog As System.Windows.Forms.TextBox
    Private WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents btDVDControlRootMenu As System.Windows.Forms.Button
    Private WithEvents btDVDControlTitleMenu As System.Windows.Forms.Button
    Private WithEvents cbDVDControlSubtitles As System.Windows.Forms.ComboBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents cbDVDControlAudio As System.Windows.Forms.ComboBox
    Private WithEvents label21 As System.Windows.Forms.Label
    Private WithEvents cbDVDControlChapter As System.Windows.Forms.ComboBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents cbDVDControlTitle As System.Windows.Forms.ComboBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cbLoop As System.Windows.Forms.CheckBox
    Private WithEvents btNextFrame As System.Windows.Forms.Button
    Private WithEvents btStop As System.Windows.Forms.Button
    Private WithEvents btPause As System.Windows.Forms.Button
    Private WithEvents btResume As System.Windows.Forms.Button
    Private WithEvents btStart As System.Windows.Forms.Button
    Private WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents lbTime As System.Windows.Forms.Label
    Private WithEvents tbTimeline As System.Windows.Forms.TrackBar
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents btReadInfo As System.Windows.Forms.Button
    Private WithEvents tabControl2 As System.Windows.Forms.TabControl
    Private WithEvents tabPage6 As System.Windows.Forms.TabPage
    Private WithEvents mmInfo As System.Windows.Forms.TextBox
    Private WithEvents tabPage7 As System.Windows.Forms.TabPage
    Private WithEvents lbDVDTitles As System.Windows.Forms.ListBox
    Private WithEvents cbDVDSubtitles As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cbDVDAudio As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents edDVDVideo As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents tbBalance4 As System.Windows.Forms.TrackBar
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents tbVolume4 As System.Windows.Forms.TrackBar
    Private WithEvents cbAudioStream4 As System.Windows.Forms.CheckBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents tbBalance3 As System.Windows.Forms.TrackBar
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents tbVolume3 As System.Windows.Forms.TrackBar
    Private WithEvents cbAudioStream3 As System.Windows.Forms.CheckBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents tbBalance2 As System.Windows.Forms.TrackBar
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents tbVolume2 As System.Windows.Forms.TrackBar
    Private WithEvents cbAudioStream2 As System.Windows.Forms.CheckBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents tbBalance1 As System.Windows.Forms.TrackBar
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents tbVolume1 As System.Windows.Forms.TrackBar
    Private WithEvents cbAudioStream1 As System.Windows.Forms.CheckBox
    Private WithEvents cbPlayAudio As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioOutputDevice As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents tabPage4 As System.Windows.Forms.TabPage
    Private WithEvents tabControl17 As System.Windows.Forms.TabControl
    Private WithEvents tabPage8 As System.Windows.Forms.TabPage
    Private WithEvents lbAdjSaturationCurrent As System.Windows.Forms.Label
    Private WithEvents lbAdjSaturationMax As System.Windows.Forms.Label
    Private WithEvents lbAdjSaturationMin As System.Windows.Forms.Label
    Private WithEvents tbAdjSaturation As System.Windows.Forms.TrackBar
    Private WithEvents label45 As System.Windows.Forms.Label
    Private WithEvents lbAdjHueCurrent As System.Windows.Forms.Label
    Private WithEvents lbAdjHueMax As System.Windows.Forms.Label
    Private WithEvents lbAdjHueMin As System.Windows.Forms.Label
    Private WithEvents tbAdjHue As System.Windows.Forms.TrackBar
    Private WithEvents label41 As System.Windows.Forms.Label
    Private WithEvents lbAdjContrastCurrent As System.Windows.Forms.Label
    Private WithEvents lbAdjContrastMax As System.Windows.Forms.Label
    Private WithEvents lbAdjContrastMin As System.Windows.Forms.Label
    Private WithEvents tbAdjContrast As System.Windows.Forms.TrackBar
    Private WithEvents label23 As System.Windows.Forms.Label
    Private WithEvents lbAdjBrightnessCurrent As System.Windows.Forms.Label
    Private WithEvents lbAdjBrightnessMax As System.Windows.Forms.Label
    Private WithEvents lbAdjBrightnessMin As System.Windows.Forms.Label
    Private WithEvents tbAdjBrightness As System.Windows.Forms.TrackBar
    Private WithEvents label24 As System.Windows.Forms.Label
    Private WithEvents tabPage68 As System.Windows.Forms.TabPage
    Private WithEvents label201 As System.Windows.Forms.Label
    Private WithEvents label200 As System.Windows.Forms.Label
    Private WithEvents label199 As System.Windows.Forms.Label
    Private WithEvents label198 As System.Windows.Forms.Label
    Private WithEvents tabControl7 As System.Windows.Forms.TabControl
    Private WithEvents tabPage29 As System.Windows.Forms.TabPage
    Private WithEvents tabPage42 As System.Windows.Forms.TabPage
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
    Private WithEvents tabPage15 As System.Windows.Forms.TabPage
    Private WithEvents tabPage11 As System.Windows.Forms.TabPage
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
    Private WithEvents tabPage5 As System.Windows.Forms.TabPage
    Private WithEvents groupBox19 As System.Windows.Forms.GroupBox
    Private WithEvents tabControl6 As System.Windows.Forms.TabControl
    Private WithEvents tabPage30 As System.Windows.Forms.TabPage
    Private WithEvents btOSDImageDraw As System.Windows.Forms.Button
    Private WithEvents pnOSDColorKey As System.Windows.Forms.Panel
    Private WithEvents cbOSDImageTranspColor As System.Windows.Forms.CheckBox
    Private WithEvents edOSDImageTop As System.Windows.Forms.TextBox
    Private WithEvents label115 As System.Windows.Forms.Label
    Private WithEvents edOSDImageLeft As System.Windows.Forms.TextBox
    Private WithEvents label114 As System.Windows.Forms.Label
    Private WithEvents btOSDSelectImage As System.Windows.Forms.Button
    Private WithEvents edOSDImageFilename As System.Windows.Forms.TextBox
    Private WithEvents label113 As System.Windows.Forms.Label
    Private WithEvents tabPage31 As System.Windows.Forms.TabPage
    Private WithEvents edOSDTextTop As System.Windows.Forms.TextBox
    Private WithEvents label117 As System.Windows.Forms.Label
    Private WithEvents edOSDTextLeft As System.Windows.Forms.TextBox
    Private WithEvents label118 As System.Windows.Forms.Label
    Private WithEvents label116 As System.Windows.Forms.Label
    Private WithEvents btOSDSelectFont As System.Windows.Forms.Button
    Private WithEvents edOSDText As System.Windows.Forms.TextBox
    Private WithEvents btOSDTextDraw As System.Windows.Forms.Button
    Private WithEvents tabPage32 As System.Windows.Forms.TabPage
    Private WithEvents tbOSDTranspLevel As System.Windows.Forms.TrackBar
    Private WithEvents btOSDSetTransp As System.Windows.Forms.Button
    Private WithEvents label119 As System.Windows.Forms.Label
    Private WithEvents btOSDClearLayers As System.Windows.Forms.Button
    Private WithEvents groupBox15 As System.Windows.Forms.GroupBox
    Private WithEvents btOSDLayerAdd As System.Windows.Forms.Button
    Private WithEvents edOSDLayerHeight As System.Windows.Forms.TextBox
    Private WithEvents label111 As System.Windows.Forms.Label
    Private WithEvents edOSDLayerWidth As System.Windows.Forms.TextBox
    Private WithEvents label112 As System.Windows.Forms.Label
    Private WithEvents edOSDLayerTop As System.Windows.Forms.TextBox
    Private WithEvents label110 As System.Windows.Forms.Label
    Private WithEvents edOSDLayerLeft As System.Windows.Forms.TextBox
    Private WithEvents label109 As System.Windows.Forms.Label
    Private WithEvents label108 As System.Windows.Forms.Label
    Private WithEvents tabPage12 As System.Windows.Forms.TabPage
    Private WithEvents tabPage13 As System.Windows.Forms.TabPage
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
    Friend WithEvents MediaPlayer1 As VisioForge.Controls.UI.WinForms.MediaPlayer
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents fontDialog1 As System.Windows.Forms.FontDialog
    Private WithEvents openFileDialog2 As System.Windows.Forms.OpenFileDialog
    Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents colorDialog1 As System.Windows.Forms.ColorDialog
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents tabControl4 As System.Windows.Forms.TabControl
    Private WithEvents tabPage16 As System.Windows.Forms.TabPage
    Private WithEvents tabPage17 As System.Windows.Forms.TabPage
    Private WithEvents cbFlipHorizontal2 As System.Windows.Forms.CheckBox
    Private WithEvents cbFlipVertical2 As System.Windows.Forms.CheckBox
    Private WithEvents cbStretch2 As System.Windows.Forms.CheckBox
    Private WithEvents cbFlipHorizontal1 As System.Windows.Forms.CheckBox
    Private WithEvents cbFlipVertical1 As System.Windows.Forms.CheckBox
    Private WithEvents cbStretch1 As System.Windows.Forms.CheckBox
    Private WithEvents pnScreen2 As System.Windows.Forms.Panel
    Private WithEvents pnScreen1 As System.Windows.Forms.Panel
    Friend WithEvents TabPage18 As System.Windows.Forms.TabPage
    Private WithEvents groupBox37 As System.Windows.Forms.GroupBox
    Private WithEvents btEffZoomRight As System.Windows.Forms.Button
    Private WithEvents btEffZoomLeft As System.Windows.Forms.Button
    Private WithEvents btEffZoomOut As System.Windows.Forms.Button
    Private WithEvents btEffZoomIn As System.Windows.Forms.Button
    Private WithEvents btEffZoomDown As System.Windows.Forms.Button
    Private WithEvents btEffZoomUp As System.Windows.Forms.Button
    Private WithEvents cbZoom As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage19 As System.Windows.Forms.TabPage
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
    Friend WithEvents TabPage21 As System.Windows.Forms.TabPage
    Private WithEvents edBarcodeMetadata As System.Windows.Forms.TextBox
    Private WithEvents label91 As System.Windows.Forms.Label
    Private WithEvents cbBarcodeType As System.Windows.Forms.ComboBox
    Private WithEvents label90 As System.Windows.Forms.Label
    Private WithEvents btBarcodeReset As System.Windows.Forms.Button
    Private WithEvents edBarcode As System.Windows.Forms.TextBox
    Private WithEvents label89 As System.Windows.Forms.Label
    Private WithEvents cbBarcodeDetectionEnabled As System.Windows.Forms.CheckBox
    Private WithEvents btAddFileToPlaylist As System.Windows.Forms.Button
    Private WithEvents label30 As System.Windows.Forms.Label
    Private WithEvents lbSourceFiles As System.Windows.Forms.ListBox
    Private WithEvents cbSourceMode As System.Windows.Forms.ComboBox
    Private WithEvents label29 As System.Windows.Forms.Label
    Private WithEvents btSelectFile As System.Windows.Forms.Button
    Private WithEvents edFilenameOrURL As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents TabPage22 As System.Windows.Forms.TabPage
    Private WithEvents rbFadeOut As System.Windows.Forms.RadioButton
    Private WithEvents rbFadeIn As System.Windows.Forms.RadioButton
    Private WithEvents groupBox45 As System.Windows.Forms.GroupBox
    Private WithEvents edFadeInOutStopTime As System.Windows.Forms.TextBox
    Private WithEvents label329 As System.Windows.Forms.Label
    Private WithEvents edFadeInOutStartTime As System.Windows.Forms.TextBox
    Private WithEvents label330 As System.Windows.Forms.Label
    Private WithEvents cbFadeInOut As System.Windows.Forms.CheckBox
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage23 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage24 As System.Windows.Forms.TabPage
    Private WithEvents label34 As System.Windows.Forms.Label
    Private WithEvents label33 As System.Windows.Forms.Label
    Private WithEvents btReversePlayback As System.Windows.Forms.Button
    Private WithEvents edReversePlaybackCacheSize As System.Windows.Forms.TextBox
    Private WithEvents label32 As System.Windows.Forms.Label
    Private WithEvents tbReversePlaybackTrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents TabPage25 As System.Windows.Forms.TabPage
    Private WithEvents tbVUMeterBoost As System.Windows.Forms.TrackBar
    Private WithEvents label382 As System.Windows.Forms.Label
    Private WithEvents label381 As System.Windows.Forms.Label
    Private WithEvents tbVUMeterAmplification As System.Windows.Forms.TrackBar
    Private WithEvents cbVUMeterPro As System.Windows.Forms.CheckBox
    Private WithEvents waveformPainter2 As VisioForge.Controls.UI.WinForms.VolumeMeterPro.WaveformPainter
    Private WithEvents waveformPainter1 As VisioForge.Controls.UI.WinForms.VolumeMeterPro.WaveformPainter
    Private WithEvents volumeMeter2 As VisioForge.Controls.UI.WinForms.VolumeMeterPro.VolumeMeter
    Private WithEvents volumeMeter1 As VisioForge.Controls.UI.WinForms.VolumeMeterPro.VolumeMeter
    Private WithEvents tabControl5 As System.Windows.Forms.TabControl
    Private WithEvents tabPage33 As System.Windows.Forms.TabPage
    Private WithEvents tabPage34 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage27 As System.Windows.Forms.TabPage
    Private WithEvents cbLiveRotationStretch As System.Windows.Forms.CheckBox
    Private WithEvents label392 As System.Windows.Forms.Label
    Private WithEvents label391 As System.Windows.Forms.Label
    Private WithEvents tbLiveRotationAngle As System.Windows.Forms.TrackBar
    Private WithEvents label390 As System.Windows.Forms.Label
    Private WithEvents cbLiveRotation As System.Windows.Forms.CheckBox
    Private WithEvents label393 As System.Windows.Forms.Label
    Private WithEvents cbDirect2DRotate As System.Windows.Forms.ComboBox
    Private WithEvents pnVideoRendererBGColor As System.Windows.Forms.Panel
    Private WithEvents label394 As System.Windows.Forms.Label
    Private WithEvents btFullScreen As System.Windows.Forms.Button
    Private WithEvents groupBox28 As System.Windows.Forms.GroupBox
    Private WithEvents btZoomShiftRight As System.Windows.Forms.Button
    Private WithEvents btZoomShiftLeft As System.Windows.Forms.Button
    Private WithEvents btZoomOut As System.Windows.Forms.Button
    Private WithEvents btZoomIn As System.Windows.Forms.Button
    Private WithEvents btZoomShiftDown As System.Windows.Forms.Button
    Private WithEvents btZoomShiftUp As System.Windows.Forms.Button
    Private WithEvents cbScreenFlipVertical As System.Windows.Forms.CheckBox
    Private WithEvents cbScreenFlipHorizontal As System.Windows.Forms.CheckBox
    Private WithEvents cbStretch As System.Windows.Forms.CheckBox
    Private WithEvents groupBox13 As System.Windows.Forms.GroupBox
    Private WithEvents rbDirect2D As System.Windows.Forms.RadioButton
    Private WithEvents rbNone As System.Windows.Forms.RadioButton
    Private WithEvents rbEVR As System.Windows.Forms.RadioButton
    Private WithEvents rbVMR9 As System.Windows.Forms.RadioButton
    Private WithEvents rbVR As System.Windows.Forms.RadioButton
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents edAspectRatioY As System.Windows.Forms.TextBox
    Private WithEvents edAspectRatioX As System.Windows.Forms.TextBox
    Private WithEvents cbAspectRatioUseCustom As System.Windows.Forms.CheckBox
    Private WithEvents cbUseLibMediaInfo As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage28 As System.Windows.Forms.TabPage
    Private WithEvents btFilterDelete As System.Windows.Forms.Button
    Private WithEvents btFilterDeleteAll As System.Windows.Forms.Button
    Private WithEvents btFilterSettings2 As System.Windows.Forms.Button
    Private WithEvents lbFilters As System.Windows.Forms.ListBox
    Private WithEvents label106 As System.Windows.Forms.Label
    Private WithEvents btFilterSettings As System.Windows.Forms.Button
    Private WithEvents btFilterAdd As System.Windows.Forms.Button
    Private WithEvents cbFilters As System.Windows.Forms.ComboBox
    Private WithEvents label105 As System.Windows.Forms.Label
    Private WithEvents cbCustomSplitter As System.Windows.Forms.ComboBox
    Private WithEvents rbSplitterCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbSplitterDefault As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoDecoderVFH264 As System.Windows.Forms.RadioButton
    Private WithEvents cbCustomVideoDecoder As System.Windows.Forms.ComboBox
    Private WithEvents label28 As System.Windows.Forms.Label
    Private WithEvents label27 As System.Windows.Forms.Label
    Private WithEvents label26 As System.Windows.Forms.Label
    Private WithEvents rbVideoDecoderCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoDecoderFFDShow As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoDecoderMS As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoDecoderDefault As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage43 As System.Windows.Forms.TabPage
    Private WithEvents cbCustomAudioDecoder As System.Windows.Forms.ComboBox
    Private WithEvents rbAudioDecoderCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbAudioDecoderDefault As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage46 As System.Windows.Forms.TabPage
    Private WithEvents lbAudioTimeshift As System.Windows.Forms.Label
    Private WithEvents tbAudioTimeshift As System.Windows.Forms.TrackBar
    Private WithEvents label70 As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents lbAudioOutputGainLFE As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainLFE As System.Windows.Forms.TrackBar
    Private WithEvents label55 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainSR As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainSR As System.Windows.Forms.TrackBar
    Private WithEvents label57 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainSL As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainSL As System.Windows.Forms.TrackBar
    Private WithEvents label59 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainR As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainR As System.Windows.Forms.TrackBar
    Private WithEvents label61 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainC As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainC As System.Windows.Forms.TrackBar
    Private WithEvents label67 As System.Windows.Forms.Label
    Private WithEvents lbAudioOutputGainL As System.Windows.Forms.Label
    Private WithEvents tbAudioOutputGainL As System.Windows.Forms.TrackBar
    Private WithEvents label69 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lbAudioInputGainLFE As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainLFE As System.Windows.Forms.TrackBar
    Private WithEvents label53 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainSR As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainSR As System.Windows.Forms.TrackBar
    Private WithEvents label51 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainSL As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainSL As System.Windows.Forms.TrackBar
    Private WithEvents label49 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainR As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainR As System.Windows.Forms.TrackBar
    Private WithEvents label47 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainC As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainC As System.Windows.Forms.TrackBar
    Private WithEvents label44 As System.Windows.Forms.Label
    Private WithEvents lbAudioInputGainL As System.Windows.Forms.Label
    Private WithEvents tbAudioInputGainL As System.Windows.Forms.TrackBar
    Private WithEvents label40 As System.Windows.Forms.Label
    Private WithEvents cbAudioAutoGain As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioNormalize As System.Windows.Forms.CheckBox
    Private WithEvents cbAudioEnhancementEnabled As System.Windows.Forms.CheckBox
    Private WithEvents groupBox48 As System.Windows.Forms.GroupBox
    Private WithEvents label343 As System.Windows.Forms.Label
    Private WithEvents edEncryptionKeyHEX As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyBinary As System.Windows.Forms.RadioButton
    Private WithEvents btEncryptionOpenFile As System.Windows.Forms.Button
    Private WithEvents edEncryptionKeyFile As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyFile As System.Windows.Forms.RadioButton
    Private WithEvents edEncryptionKeyString As System.Windows.Forms.TextBox
    Private WithEvents rbEncryptionKeyString As System.Windows.Forms.RadioButton
    Private WithEvents cbLicensing As CheckBox
    Friend WithEvents TabPage47 As TabPage
    Private WithEvents imgTags As PictureBox
    Private WithEvents edTags As TextBox
    Private WithEvents btReadTags As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents TabPage49 As TabPage
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
    Friend WithEvents TabPage50 As TabPage
    Private WithEvents cbGPUOldMovie As CheckBox
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
    Friend WithEvents TabPage14 As TabPage
    Private WithEvents label505 As Label
    Private WithEvents rbMotionDetectionExProcessor As ComboBox
    Private WithEvents label389 As Label
    Private WithEvents rbMotionDetectionExDetector As ComboBox
    Private WithEvents label64 As Label
    Private WithEvents label65 As Label
    Private WithEvents pbAFMotionLevel As ProgressBar
    Private WithEvents cbMotionDetectionEx As CheckBox
    Private WithEvents btReversePlaybackNextFrame As Button
    Private WithEvents btReversePlaybackPrevFrame As Button
    Friend WithEvents btPreviousFrame As Button
    Private WithEvents cbMultiscreenDrawOnExternalDisplays As CheckBox
    Private WithEvents cbMultiscreenDrawOnPanels As CheckBox
    Private WithEvents btTextLogoRemove As Button
    Private WithEvents btTextLogoEdit As Button
    Private WithEvents lbTextLogos As ListBox
    Private WithEvents btTextLogoAdd As Button
    Private WithEvents btImageLogoRemove As Button
    Private WithEvents btImageLogoEdit As Button
    Private WithEvents lbImageLogos As ListBox
    Private WithEvents btImageLogoAdd As Button
    Private WithEvents cbFlipY As CheckBox
    Private WithEvents cbFlipX As CheckBox
    Private WithEvents cbTelemetry As CheckBox
    Friend WithEvents TabPage20 As TabPage
    Private WithEvents groupBox6 As GroupBox
    Private WithEvents rbGPUDirect3D As RadioButton
    Private WithEvents rbGPUDXVANative As RadioButton
    Private WithEvents rbGPUDXVACopyBack As RadioButton
    Private WithEvents rbGPUIntel As RadioButton
    Private WithEvents rbGPUNVidia As RadioButton
    Private WithEvents cbOSDEnabled As CheckBox
    Private WithEvents btOSDClearLayer As Button
    Private WithEvents cbVideoEffectsGPUEnabled As CheckBox
    Private WithEvents lbOSDLayers As CheckedListBox
    Private WithEvents btOSDRenderLayers As Button
    Friend WithEvents btZoomReset As Button
    Private WithEvents mnPlaylist As ContextMenuStrip
    Private WithEvents mnPlaylistRemove As ToolStripMenuItem
    Private WithEvents mnPlaylistRemoveAll As ToolStripMenuItem
    Private WithEvents Label22 As Label
    Private WithEvents tbGPUBlur As TrackBar
    Private WithEvents rbVirtualCameraOutput As RadioButton
    Private WithEvents pnChromaKeyColor As Panel
    Private WithEvents btChromaKeySelectBGImage As Button
    Private WithEvents edChromaKeyImage As TextBox
    Private WithEvents label216 As Label
    Private WithEvents label215 As Label
    Private WithEvents tbChromaKeySmoothing As TrackBar
    Private WithEvents label214 As Label
    Private WithEvents tbChromaKeyThresholdSensitivity As TrackBar
    Private WithEvents label213 As Label
    Private WithEvents cbChromaKeyEnabled As CheckBox
End Class
