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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim VideoRendererSettingsWinForms1 As VisioForge.Types.VideoRendererSettingsWinForms = New VisioForge.Types.VideoRendererSettingsWinForms()
        Me.rbAudioFile = New System.Windows.Forms.RadioButton()
        Me.rbVideoWithoutAudio = New System.Windows.Forms.RadioButton()
        Me.rbVideoWithAudio = New System.Windows.Forms.RadioButton()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbBalance1 = New System.Windows.Forms.TrackBar()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tbVolume1 = New System.Windows.Forms.TrackBar()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbLicensing = New System.Windows.Forms.CheckBox()
        Me.mmError = New System.Windows.Forms.TextBox()
        Me.cbDebugMode = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btSelectFile = New System.Windows.Forms.Button()
        Me.edFilename = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MediaPlayer1 = New VisioForge.Controls.UI.WinForms.MediaPlayer()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbStreamTypeMemory = New System.Windows.Forms.RadioButton()
        Me.rbSTreamTypeFile = New System.Windows.Forms.RadioButton()
        Me.groupBox4.SuspendLayout()
        CType(Me.tbBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVolume1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTimeline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbAudioFile
        '
        Me.rbAudioFile.AutoSize = True
        Me.rbAudioFile.Location = New System.Drawing.Point(572, 112)
        Me.rbAudioFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rbAudioFile.Name = "rbAudioFile"
        Me.rbAudioFile.Size = New System.Drawing.Size(132, 29)
        Me.rbAudioFile.TabIndex = 57
        Me.rbAudioFile.Text = "Audio file"
        Me.rbAudioFile.UseVisualStyleBackColor = True
        '
        'rbVideoWithoutAudio
        '
        Me.rbVideoWithoutAudio.AutoSize = True
        Me.rbVideoWithoutAudio.Location = New System.Drawing.Point(280, 112)
        Me.rbVideoWithoutAudio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rbVideoWithoutAudio.Name = "rbVideoWithoutAudio"
        Me.rbVideoWithoutAudio.Size = New System.Drawing.Size(279, 29)
        Me.rbVideoWithoutAudio.TabIndex = 56
        Me.rbVideoWithoutAudio.Text = "Video file (without audio)"
        Me.rbVideoWithoutAudio.UseVisualStyleBackColor = True
        '
        'rbVideoWithAudio
        '
        Me.rbVideoWithAudio.AutoSize = True
        Me.rbVideoWithAudio.Checked = True
        Me.rbVideoWithAudio.Location = New System.Drawing.Point(24, 112)
        Me.rbVideoWithAudio.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.rbVideoWithAudio.Name = "rbVideoWithAudio"
        Me.rbVideoWithAudio.Size = New System.Drawing.Size(249, 29)
        Me.rbVideoWithAudio.TabIndex = 55
        Me.rbVideoWithAudio.TabStop = True
        Me.rbVideoWithAudio.Text = "Video file (with audio)"
        Me.rbVideoWithAudio.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.label7)
        Me.groupBox4.Controls.Add(Me.tbBalance1)
        Me.groupBox4.Controls.Add(Me.label6)
        Me.groupBox4.Controls.Add(Me.tbVolume1)
        Me.groupBox4.Location = New System.Drawing.Point(868, 285)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox4.Size = New System.Drawing.Size(442, 206)
        Me.groupBox4.TabIndex = 53
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Audio output"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(218, 54)
        Me.label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(90, 25)
        Me.label7.TabIndex = 11
        Me.label7.Text = "Balance"
        '
        'tbBalance1
        '
        Me.tbBalance1.BackColor = System.Drawing.SystemColors.Window
        Me.tbBalance1.Location = New System.Drawing.Point(224, 85)
        Me.tbBalance1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbBalance1.Maximum = 100
        Me.tbBalance1.Minimum = -100
        Me.tbBalance1.Name = "tbBalance1"
        Me.tbBalance1.Size = New System.Drawing.Size(170, 90)
        Me.tbBalance1.TabIndex = 10
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(32, 54)
        Me.label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(84, 25)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Volume"
        '
        'tbVolume1
        '
        Me.tbVolume1.BackColor = System.Drawing.SystemColors.Window
        Me.tbVolume1.Location = New System.Drawing.Point(38, 85)
        Me.tbVolume1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbVolume1.Maximum = 100
        Me.tbVolume1.Minimum = 20
        Me.tbVolume1.Name = "tbVolume1"
        Me.tbVolume1.Size = New System.Drawing.Size(170, 90)
        Me.tbVolume1.TabIndex = 8
        Me.tbVolume1.Value = 80
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.cbLicensing)
        Me.groupBox1.Controls.Add(Me.mmError)
        Me.groupBox1.Controls.Add(Me.cbDebugMode)
        Me.groupBox1.Location = New System.Drawing.Point(868, 31)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox1.Size = New System.Drawing.Size(442, 242)
        Me.groupBox1.TabIndex = 52
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Errors and warnings"
        '
        'cbLicensing
        '
        Me.cbLicensing.AutoSize = True
        Me.cbLicensing.Location = New System.Drawing.Point(212, 37)
        Me.cbLicensing.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbLicensing.Name = "cbLicensing"
        Me.cbLicensing.Size = New System.Drawing.Size(177, 29)
        Me.cbLicensing.TabIndex = 4
        Me.cbLicensing.Text = "Licensing info"
        Me.cbLicensing.UseVisualStyleBackColor = True
        '
        'mmError
        '
        Me.mmError.Location = New System.Drawing.Point(12, 81)
        Me.mmError.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.mmError.Multiline = True
        Me.mmError.Name = "mmError"
        Me.mmError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmError.Size = New System.Drawing.Size(414, 146)
        Me.mmError.TabIndex = 3
        '
        'cbDebugMode
        '
        Me.cbDebugMode.AutoSize = True
        Me.cbDebugMode.Location = New System.Drawing.Point(12, 37)
        Me.cbDebugMode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbDebugMode.Name = "cbDebugMode"
        Me.cbDebugMode.Size = New System.Drawing.Size(166, 29)
        Me.cbDebugMode.TabIndex = 2
        Me.cbDebugMode.Text = "Debug mode"
        Me.cbDebugMode.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(166, 990)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(459, 26)
        Me.label1.TabIndex = 51
        Me.label1.Text = "Much more features shown in Main Demo!"
        '
        'groupBox2
        '
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
        Me.groupBox2.Location = New System.Drawing.Point(24, 785)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.groupBox2.Size = New System.Drawing.Size(832, 173)
        Me.groupBox2.TabIndex = 50
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Controls"
        '
        'cbLoop
        '
        Me.cbLoop.AutoSize = True
        Me.cbLoop.Location = New System.Drawing.Point(674, 119)
        Me.cbLoop.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cbLoop.Name = "cbLoop"
        Me.cbLoop.Size = New System.Drawing.Size(92, 29)
        Me.cbLoop.TabIndex = 10
        Me.cbLoop.Text = "Loop"
        Me.cbLoop.UseVisualStyleBackColor = True
        '
        'btNextFrame
        '
        Me.btNextFrame.Location = New System.Drawing.Point(498, 112)
        Me.btNextFrame.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btNextFrame.Name = "btNextFrame"
        Me.btNextFrame.Size = New System.Drawing.Size(150, 44)
        Me.btNextFrame.TabIndex = 8
        Me.btNextFrame.Text = "Next frame"
        Me.btNextFrame.UseVisualStyleBackColor = True
        '
        'btStop
        '
        Me.btStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btStop.Location = New System.Drawing.Point(360, 112)
        Me.btStop.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(92, 44)
        Me.btStop.TabIndex = 7
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'btPause
        '
        Me.btPause.Location = New System.Drawing.Point(244, 112)
        Me.btPause.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btPause.Name = "btPause"
        Me.btPause.Size = New System.Drawing.Size(104, 44)
        Me.btPause.TabIndex = 6
        Me.btPause.Text = "Pause"
        Me.btPause.UseVisualStyleBackColor = True
        '
        'btResume
        '
        Me.btResume.Location = New System.Drawing.Point(110, 112)
        Me.btResume.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btResume.Name = "btResume"
        Me.btResume.Size = New System.Drawing.Size(122, 44)
        Me.btResume.TabIndex = 5
        Me.btResume.Text = "Resume"
        Me.btResume.UseVisualStyleBackColor = True
        '
        'btStart
        '
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btStart.Location = New System.Drawing.Point(12, 112)
        Me.btStart.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(86, 44)
        Me.btStart.TabIndex = 4
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(642, 52)
        Me.tbSpeed.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbSpeed.Maximum = 25
        Me.tbSpeed.Minimum = 5
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(178, 90)
        Me.tbSpeed.TabIndex = 3
        Me.tbSpeed.Value = 10
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(644, 21)
        Me.label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(74, 25)
        Me.label16.TabIndex = 2
        Me.label16.Text = "Speed"
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Location = New System.Drawing.Point(438, 52)
        Me.lbTime.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(186, 25)
        Me.lbTime.TabIndex = 1
        Me.lbTime.Text = "00:00:00/00:00:00"
        '
        'tbTimeline
        '
        Me.tbTimeline.Location = New System.Drawing.Point(12, 37)
        Me.tbTimeline.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbTimeline.Maximum = 100
        Me.tbTimeline.Name = "tbTimeline"
        Me.tbTimeline.Size = New System.Drawing.Size(414, 90)
        Me.tbTimeline.TabIndex = 0
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(636, 19)
        Me.linkLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(219, 25)
        Me.linkLabel1.TabIndex = 49
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Watch video tutorials!"
        '
        'btSelectFile
        '
        Me.btSelectFile.Location = New System.Drawing.Point(810, 52)
        Me.btSelectFile.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btSelectFile.Name = "btSelectFile"
        Me.btSelectFile.Size = New System.Drawing.Size(46, 44)
        Me.btSelectFile.TabIndex = 48
        Me.btSelectFile.Text = "..."
        Me.btSelectFile.UseVisualStyleBackColor = True
        '
        'edFilename
        '
        Me.edFilename.Location = New System.Drawing.Point(24, 56)
        Me.edFilename.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.edFilename.Name = "edFilename"
        Me.edFilename.Size = New System.Drawing.Size(770, 31)
        Me.edFilename.TabIndex = 47
        Me.edFilename.Text = "C:\video.avi"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(18, 25)
        Me.label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(106, 25)
        Me.label14.TabIndex = 46
        Me.label14.Text = "File name"
        '
        'timer1
        '
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Audio_Channel_Mapper = Nothing
        Me.MediaPlayer1.Audio_Effects_Enabled = False
        Me.MediaPlayer1.Audio_Effects_UseLegacyEffects = False
        Me.MediaPlayer1.Audio_Enhancer_Enabled = False
        Me.MediaPlayer1.Audio_OutputDevice = ""
        Me.MediaPlayer1.Audio_PlayAudio = True
        Me.MediaPlayer1.Audio_Sample_Grabber_Enabled = False
        Me.MediaPlayer1.Audio_VUMeter_Enabled = False
        Me.MediaPlayer1.Audio_VUMeter_Pro_Enabled = False
        Me.MediaPlayer1.Audio_VUMeter_Pro_Volume = 0
        Me.MediaPlayer1.BackColor = System.Drawing.Color.Black
        Me.MediaPlayer1.Barcode_Reader_Enabled = False
        Me.MediaPlayer1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.[Auto]
        Me.MediaPlayer1.ChromaKey = Nothing
        Me.MediaPlayer1.Custom_Audio_Decoder = Nothing
        Me.MediaPlayer1.Custom_Splitter = Nothing
        Me.MediaPlayer1.Custom_Video_Decoder = Nothing
        Me.MediaPlayer1.Debug_DeepCleanUp = False
        Me.MediaPlayer1.Debug_Dir = Nothing
        Me.MediaPlayer1.Debug_Mode = False
        Me.MediaPlayer1.Encryption_Key = ""
        Me.MediaPlayer1.Encryption_KeyType = VisioForge.Types.VFEncryptionKeyType.[String]
        Me.MediaPlayer1.Face_Tracking = Nothing
        Me.MediaPlayer1.FilenamesOrURL = CType(resources.GetObject("MediaPlayer1.FilenamesOrURL"), System.Collections.Generic.List(Of String))
        Me.MediaPlayer1.Info_UseLibMediaInfo = False
        Me.MediaPlayer1.Location = New System.Drawing.Point(24, 156)
        Me.MediaPlayer1.Loop = False
        Me.MediaPlayer1.Loop_DoNotSeekToBeginning = False
        Me.MediaPlayer1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MediaPlayer1.MaximalSpeedPlayback = False
        Me.MediaPlayer1.Motion_Detection = Nothing
        Me.MediaPlayer1.Motion_DetectionEx = Nothing
        Me.MediaPlayer1.MultiScreen_Enabled = False
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.ReversePlayback_CacheSize = 0
        Me.MediaPlayer1.ReversePlayback_Enabled = False
        Me.MediaPlayer1.Selection_Active = False
        Me.MediaPlayer1.Selection_Start = 0
        Me.MediaPlayer1.Selection_Stop = 0
        Me.MediaPlayer1.Size = New System.Drawing.Size(830, 610)
        Me.MediaPlayer1.Source_Custom_CLSID = Nothing
        Me.MediaPlayer1.Source_Mode = VisioForge.Types.VFMediaPlayerSource.File_DS
        Me.MediaPlayer1.Source_Stream = Nothing
        Me.MediaPlayer1.Source_Stream_AudioPresent = True
        Me.MediaPlayer1.Source_Stream_Size = CType(0, Long)
        Me.MediaPlayer1.Source_Stream_VideoPresent = True
        Me.MediaPlayer1.Start_DelayEnabled = False
        Me.MediaPlayer1.TabIndex = 58
        Me.MediaPlayer1.Video_Effects_Enabled = False
        VideoRendererSettingsWinForms1.Aspect_Ratio_Override = False
        VideoRendererSettingsWinForms1.Aspect_Ratio_X = 0
        VideoRendererSettingsWinForms1.Aspect_Ratio_Y = 0
        VideoRendererSettingsWinForms1.BackgroundColor = System.Drawing.Color.Black
        'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        VideoRendererSettingsWinForms1.Deinterlace_EVR_Mode = VisioForge.Types.EVRDeinterlaceMode.[Auto]
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_Mode = Nothing
        VideoRendererSettingsWinForms1.Deinterlace_VMR9_UseDefault = True
        VideoRendererSettingsWinForms1.Flip_Horizontal = False
        VideoRendererSettingsWinForms1.Flip_Vertical = False
        VideoRendererSettingsWinForms1.RotationAngle = 0
        VideoRendererSettingsWinForms1.StretchMode = VisioForge.Types.VFVideoRendererStretchMode.Letterbox
        VideoRendererSettingsWinForms1.Video_Renderer = VisioForge.Types.VFVideoRenderer.EVR
        VideoRendererSettingsWinForms1.VideoRendererInternal = VisioForge.Types.VFVideoRendererInternal.EVR
        VideoRendererSettingsWinForms1.Zoom_Ratio = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftX = 0
        VideoRendererSettingsWinForms1.Zoom_ShiftY = 0
        Me.MediaPlayer1.Video_Renderer = VideoRendererSettingsWinForms1
        Me.MediaPlayer1.Video_Sample_Grabber_UseForVideoEffects = True
        Me.MediaPlayer1.Video_Stream_Index = 0
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.rbStreamTypeMemory)
        Me.groupBox3.Controls.Add(Me.rbSTreamTypeFile)
        Me.groupBox3.Location = New System.Drawing.Point(880, 500)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(414, 156)
        Me.groupBox3.TabIndex = 59
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Stream type"
        '
        'rbStreamTypeMemory
        '
        Me.rbStreamTypeMemory.AutoSize = True
        Me.rbStreamTypeMemory.Location = New System.Drawing.Point(25, 95)
        Me.rbStreamTypeMemory.Name = "rbStreamTypeMemory"
        Me.rbStreamTypeMemory.Size = New System.Drawing.Size(308, 29)
        Me.rbStreamTypeMemory.TabIndex = 1
        Me.rbStreamTypeMemory.Text = "Load entire file into memory"
        Me.rbStreamTypeMemory.UseVisualStyleBackColor = True
        '
        'rbSTreamTypeFile
        '
        Me.rbSTreamTypeFile.AutoSize = True
        Me.rbSTreamTypeFile.Checked = True
        Me.rbSTreamTypeFile.Location = New System.Drawing.Point(25, 41)
        Me.rbSTreamTypeFile.Name = "rbSTreamTypeFile"
        Me.rbSTreamTypeFile.Size = New System.Drawing.Size(186, 29)
        Me.rbSTreamTypeFile.TabIndex = 0
        Me.rbSTreamTypeFile.TabStop = True
        Me.rbSTreamTypeFile.Text = "Use file stream"
        Me.rbSTreamTypeFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 1029)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.Controls.Add(Me.rbAudioFile)
        Me.Controls.Add(Me.rbVideoWithoutAudio)
        Me.Controls.Add(Me.rbVideoWithAudio)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.btSelectFile)
        Me.Controls.Add(Me.edFilename)
        Me.Controls.Add(Me.label14)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Media Player SDK .Net - Memory Playback Demo"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.tbBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVolume1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTimeline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Private WithEvents rbAudioFile As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoWithoutAudio As System.Windows.Forms.RadioButton
    Private WithEvents rbVideoWithAudio As System.Windows.Forms.RadioButton
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents tbBalance1 As System.Windows.Forms.TrackBar
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents tbVolume1 As System.Windows.Forms.TrackBar
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents mmError As System.Windows.Forms.TextBox
    Private WithEvents cbDebugMode As System.Windows.Forms.CheckBox
    Private WithEvents label1 As System.Windows.Forms.Label
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
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents btSelectFile As System.Windows.Forms.Button
    Private WithEvents edFilename As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents MediaPlayer1 As VisioForge.Controls.UI.WinForms.MediaPlayer
    Private WithEvents cbLicensing As CheckBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents rbStreamTypeMemory As RadioButton
    Private WithEvents rbSTreamTypeFile As RadioButton
End Class
