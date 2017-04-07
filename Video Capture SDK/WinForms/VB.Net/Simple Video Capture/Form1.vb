' ReSharper disable InconsistentNaming

Imports System.Linq
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Types.OutputFormat
Imports VisioForge.Types.VideoEffects

Public Class Form1

    Private Sub cbVideoCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim sName As String = cbVideoCodecs.Text
        btVideoSettings.Enabled = VideoCapture.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)
    End Sub

    Private Sub cbAudioCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim sName As String = cbAudioCodecs.Text
        btAudioSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)
    End Sub

    Private Sub btVideoSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btVideoSettings.Click
        Dim sName As String = cbVideoCodecs.Text

        If VideoCapture.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default) Then
            VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        Else
            If VideoCapture.Video_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig) Then
                VideoCapture.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
            End If
        End If
    End Sub

    Private Sub btAudioSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAudioSettings.Click
        Dim sName As String = cbAudioCodecs.Text

        If VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) Then
            VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        Else
            If VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig) Then
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
            End If
        End If
    End Sub

    Private Sub cbImageLogo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbImageLogo.CheckedChanged

        Dim imageLogo As IVFVideoEffectImageLogo
        Dim effect = VideoCapture1.Video_Effects_Get("ImageLogo")
        If (effect Is Nothing) Then
            imageLogo = New VFVideoEffectImageLogo(cbImageLogo.Checked)
            VideoCapture1.Video_Effects_Add(imageLogo)
        Else
            imageLogo = effect
        End If

        If (imageLogo Is Nothing) Then
            MessageBox.Show("Unable to configure image logo effect.")
            Return
        End If

        imageLogo.Enabled = cbImageLogo.Checked
        imageLogo.Filename = edImageLogoFilename.Text
        imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text)
        imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text)
        imageLogo.TransparencyLevel = tbImageLogoTransp.Value
        imageLogo.AnimationEnabled = True

    End Sub

    Private Sub btSelectImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectImage.Click
        If openFileDialog2.ShowDialog() = DialogResult.OK Then
            edImageLogoFilename.Text = openFileDialog2.FileName
        End If
    End Sub

    Private Sub tbGraphicLogoTransp_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbImageLogoTransp.Scroll
        cbImageLogo_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub tbTextLogoTransp_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbTextLogoTransp.Scroll
        cbTextLogo_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub btFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btFont.Click
        If fontDialog1.ShowDialog() = DialogResult.OK Then
            cbTextLogo_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub tbJPEGQuality_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbJPEGQuality.Scroll
        lbJPEGQuality.Text = tbJPEGQuality.Value.ToString()
    End Sub

    Private Sub btSaveScreenshot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSaveScreenshot.Click
        Dim s As String

        Dim dt As DateTime = DateTime.Now
        s = (((dt.Hour.ToString() & "_") + dt.Minute.ToString() & "_") + dt.Second.ToString() & "_") + dt.Millisecond.ToString()

        Select Case cbImageType.SelectedIndex
            Case 0
                VideoCapture1.Frame_Save((edScreenshotsFolder.Text & "\") + s & ".bmp", VFImageFormat.BMP, 0)
                Exit Select
            Case 1
                VideoCapture1.Frame_Save((edScreenshotsFolder.Text & "\") + s & ".jpg", VFImageFormat.JPEG, tbJPEGQuality.Value)
                Exit Select
            Case 2
                VideoCapture1.Frame_Save((edScreenshotsFolder.Text & "\") + s & ".gif", VFImageFormat.GIF, 0)
                Exit Select
            Case 3
                VideoCapture1.Frame_Save((edScreenshotsFolder.Text & "\") + s & ".png", VFImageFormat.PNG, 0)
                Exit Select
            Case 4
                VideoCapture1.Frame_Save((edScreenshotsFolder.Text & "\") + s & ".tiff", VFImageFormat.TIFF, 0)
                Exit Select
        End Select
    End Sub

    Private Sub cbTextLogo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextLogo.CheckedChanged

        Dim textLogo As IVFVideoEffectTextLogo
        Dim effect = VideoCapture1.Video_Effects_Get("TextLogo")
        If (effect Is Nothing) Then
            textLogo = New VFVideoEffectTextLogo(cbTextLogo.Checked)
            VideoCapture1.Video_Effects_Add(textLogo)
        Else
            textLogo = effect
        End If

        If (textLogo Is Nothing) Then
            MessageBox.Show("Unable to configure text logo effect.")
            Return
        End If

        textLogo.Enabled = cbTextLogo.Checked
        textLogo.Text = edTextLogo.Text
        textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text)
        textLogo.Top = Convert.ToInt32(edTextLogoTop.Text)
        textLogo.Font = fontDialog1.Font
        textLogo.FontColor = fontDialog1.Color

        textLogo.TransparencyLevel = tbTextLogoTransp.Value

        textLogo.Update()
    End Sub

    Private Sub cbAudioInputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioInputDevice.SelectedIndexChanged
        If cbAudioInputDevice.SelectedIndex <> -1 Then

            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text
            cbAudioInputFormat.Items.Clear()

            Dim deviceItem = (From info In VideoCapture1.Audio_CaptureDevicesInfo Where info.Name = cbAudioInputDevice.Text)?.First()
            If IsNothing(deviceItem) Then
                Exit Sub
            End If

            Dim formats = deviceItem.Formats
            For Each item As String In formats
                cbAudioInputFormat.Items.Add(item)
            Next

            If cbAudioInputFormat.Items.Count > 0 Then
                cbAudioInputFormat.SelectedIndex = 0
            End If

            cbAudioInputFormat_SelectedIndexChanged(Nothing, Nothing)

            cbAudioInputLine.Items.Clear()
            Dim lines = deviceItem.Lines
            For Each item As String In lines
                cbAudioInputLine.Items.Add(item)
            Next

            If cbAudioInputLine.Items.Count > 0 Then
                cbAudioInputLine.SelectedIndex = 0
            End If

            cbAudioInputLine_SelectedIndexChanged(Nothing, Nothing)

            btAudioInputDeviceSettings.Enabled = deviceItem.DialogDefault
        End If
    End Sub

    Private Sub btAudioInputDeviceSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAudioInputDeviceSettings.Click
        VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text)
    End Sub

    Private Sub cbAudioInputFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioInputFormat.SelectedIndexChanged
        VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text
    End Sub

    Private Sub cbAudioInputLine_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioInputLine.SelectedIndexChanged
        VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text
    End Sub

    Private Sub cbAudioOutputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioOutputDevice.SelectedIndexChanged
        VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text
    End Sub

    Private Sub cbUseBestAudioInputFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUseBestAudioInputFormat.CheckedChanged
        cbAudioInputFormat.Enabled = Not cbUseBestAudioInputFormat.Checked
    End Sub

    Private Sub cbUseAudioInputFromVideoCaptureDevice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUseAudioInputFromVideoCaptureDevice.CheckedChanged
        If Not ((cbVideoInputDevice.Text = "") OrElse (cbVideoInputDevice.Text Is Nothing)) Then
            VideoCapture1.Video_CaptureDevice_IsAudioSource = cbUseAudioInputFromVideoCaptureDevice.Checked
            cbAudioInputDevice_SelectedIndexChanged(Nothing, Nothing)

            cbAudioInputDevice.Enabled = Not cbUseAudioInputFromVideoCaptureDevice.Checked
            btAudioInputDeviceSettings.Enabled = Not cbUseAudioInputFromVideoCaptureDevice.Checked
        End If
    End Sub

    Private Sub cbVideoInputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVideoInputDevice.SelectedIndexChanged
        Dim i As Integer

        If cbVideoInputDevice.SelectedIndex <> -1 Then
            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text

            cbVideoInputFormat.Items.Clear()

            Dim deviceItem = (From info In VideoCapture1.Video_CaptureDevicesInfo Where info.Name = cbVideoInputDevice.Text)?.First()
            if IsNothing(deviceItem) Then
                Exit sub
            End If

            Dim formats = deviceItem.VideoFormats
            For Each item As String In formats
                cbVideoInputFormat.Items.Add(item)
            Next

            If cbVideoInputFormat.Items.Count > 0 Then
                cbVideoInputFormat.SelectedIndex = 0
                cbVideoInputFormat_SelectedIndexChanged(Nothing, Nothing)
            End If

            cbFramerate.Items.Clear()
            Dim frameRate = deviceItem.VideoFrameRates
            For Each item As String In frameRate
                cbFramerate.Items.Add(item)
            Next

            If cbFramerate.Items.Count > 0 Then
                cbFramerate.SelectedIndex = 0
            End If

            cbUseAudioInputFromVideoCaptureDevice.Enabled = deviceItem.AudioOutput
            btVideoCaptureDeviceSettings.Enabled = deviceItem.DialogDefault
        End If
    End Sub

    Private Sub cbVideoInputFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVideoInputFormat.SelectedIndexChanged
        If cbVideoInputFormat.SelectedIndex <> -1 Then
            VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text
        Else
            VideoCapture1.Video_CaptureDevice_Format = ""
        End If
    End Sub

    Private Sub cbUseBestVideoInputFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUseBestVideoInputFormat.CheckedChanged
        cbVideoInputFormat.Enabled = Not cbUseBestVideoInputFormat.Checked
    End Sub

    Private Sub btVideoCaptureDeviceSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btVideoCaptureDeviceSettings.Click
        VideoCapture1.Video_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbVideoInputDevice.Text)
    End Sub

    Private Sub tbAudioVolume_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudioVolume.Scroll
        VideoCapture1.Audio_OutputDevice_Volume_Set(tbAudioVolume.Value)
    End Sub

    Private Sub tbAudioBalance_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudioBalance.Scroll
        VideoCapture1.Audio_OutputDevice_Balance_Set(tbAudioBalance.Value)
        VideoCapture1.Audio_OutputDevice_Balance_Get()
    End Sub

    Private Sub cbAudAmplifyEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudAmplifyEnabled.CheckedChanged
        VideoCapture1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked)
    End Sub

    Private Sub tbAudAmplifyAmp_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudAmplifyAmp.Scroll
        VideoCapture1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, False)
    End Sub

    Private Sub cbAudEqualizerEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudEqualizerEnabled.CheckedChanged
        VideoCapture1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked)
    End Sub

    Private Sub tbAudEq0_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq0.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, tbAudEq0.Value)
    End Sub

    Private Sub tbAudEq1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq1.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, tbAudEq1.Value)
    End Sub

    Private Sub tbAudEq2_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq2.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, tbAudEq2.Value)
    End Sub

    Private Sub tbAudEq3_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq3.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, tbAudEq3.Value)
    End Sub

    Private Sub tbAudEq4_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq4.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, tbAudEq4.Value)
    End Sub

    Private Sub tbAudEq5_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq5.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, tbAudEq5.Value)
    End Sub

    Private Sub tbAudEq6_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq6.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, tbAudEq6.Value)
    End Sub

    Private Sub tbAudEq7_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq7.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, tbAudEq7.Value)
    End Sub

    Private Sub tbAudEq8_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq8.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, tbAudEq8.Value)
    End Sub

    Private Sub tbAudEq9_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudEq9.Scroll
        VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, tbAudEq9.Value)
    End Sub

    Private Sub cbAudEqualizerPreset_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudEqualizerPreset.SelectedIndexChanged
        VideoCapture1.Audio_Effects_Equalizer_Preset_Set(-1, 1, cbAudEqualizerPreset.SelectedIndex)
        btAudEqRefresh_Click(sender, e)
    End Sub

    Private Sub btAudEqRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAudEqRefresh.Click
        tbAudEq0.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0)
        tbAudEq1.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1)
        tbAudEq2.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2)
        tbAudEq3.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3)
        tbAudEq4.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4)
        tbAudEq5.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5)
        tbAudEq6.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6)
        tbAudEq7.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7)
        tbAudEq8.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8)
        tbAudEq9.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9)
    End Sub

    Private Sub cbAudTrueBassEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudTrueBassEnabled.CheckedChanged
        VideoCapture1.Audio_Effects_Enable(-1, 5, cbAudTrueBassEnabled.Checked)
    End Sub

    Private Sub tbAudTrueBass_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAudTrueBass.Scroll
        VideoCapture1.Audio_Effects_TrueBass(-1, 5, 200, False, tbAudTrueBass.Value)
    End Sub

    Private Sub btSelectOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectOutput.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            edOutput.Text = saveFileDialog1.FileName
        End If
    End Sub

    Private Sub btStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStart.Click
        mmLog.Clear()

        VideoCapture1.Video_Sample_Grabber_Enabled = true

        VideoCapture1.Video_Renderer.Zoom_Ratio = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftX = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftY = 0

        VideoCapture1.Debug_Mode = cbDebugMode.Checked
        VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"


        If cbRecordAudio.Checked Then
            VideoCapture1.Audio_RecordAudio = True
            VideoCapture1.Audio_PlayAudio = True
        Else
            VideoCapture1.Audio_RecordAudio = False
            VideoCapture1.Audio_PlayAudio = False
        End If

        'apply capture parameters
        If VideoCapture.Filter_Supported_VMR9() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

        VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text
        VideoCapture1.Video_CaptureDevice_IsAudioSource = True
        VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text
        VideoCapture1.Audio_CaptureDevice_Format_UseBest = True
        VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text
        VideoCapture1.Video_CaptureDevice_Format_UseBest = cbUseBestVideoInputFormat.Checked
        VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text
        VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text

        If cbFramerate.SelectedIndex <> -1 Then
            VideoCapture1.Video_CaptureDevice_FrameRate = CSng(Convert.ToDouble(cbFramerate.Text))
        End If

        If (cbMode.SelectedIndex = 0) Then
            VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview
        Else
            VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture
            VideoCapture1.Output_Filename = edOutput.Text

            If (cbMode.SelectedIndex = 1) Then

                Dim aviOutput As VFAVIOutput = New VFAVIOutput()

                aviOutput.ACM.Name = cbAudioCodecs.Text
                aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text)
                aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text)
                aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text)

                aviOutput.Video_Codec = cbVideoCodecs.Text

                VideoCapture1.Output_Format = aviOutput

            ElseIf (cbMode.SelectedIndex = 2) Then

                Dim wmvOutput As VFWMVOutput = New VFWMVOutput

                wmvOutput.Mode = VFWMVMode.InternalProfile

                If (cbWMVInternalProfile9.SelectedIndex <> -1) Then
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text
                End If

                VideoCapture1.Output_Format = wmvOutput

            ElseIf (cbMode.SelectedIndex = 3) Then

                VideoCapture1.Output_Filename = edOutput.Text

                Dim mp4Output As VFMP4Output = New VFMP4Output()

                ' Main settings
                mp4Output.MP4Mode = VFMP4Mode.v10

                ' Video H264 settings
                Select Case (cbH264Profile.SelectedIndex)
                    Case 0
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileAuto
                    Case 1
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileBaseline
                    Case 2
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileMain
                    Case 3
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh
                    Case 4
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh10
                    Case 5
                        mp4Output.Video_H264.Profile = VFH264Profile.ProfileHigh422
                End Select

                Select Case (cbH264Level.SelectedIndex)
                    Case 0
                        mp4Output.Video_H264.Level = VFH264Level.LevelAuto
                    Case 1
                        mp4Output.Video_H264.Level = VFH264Level.Level1
                    Case 2
                        mp4Output.Video_H264.Level = VFH264Level.Level11
                    Case 3
                        mp4Output.Video_H264.Level = VFH264Level.Level12
                    Case 4
                        mp4Output.Video_H264.Level = VFH264Level.Level13
                    Case 5
                        mp4Output.Video_H264.Level = VFH264Level.Level2
                    Case 6
                        mp4Output.Video_H264.Level = VFH264Level.Level21
                    Case 7
                        mp4Output.Video_H264.Level = VFH264Level.Level22
                    Case 8
                        mp4Output.Video_H264.Level = VFH264Level.Level3
                    Case 9
                        mp4Output.Video_H264.Level = VFH264Level.Level31
                    Case 10
                        mp4Output.Video_H264.Level = VFH264Level.Level32
                    Case 11
                        mp4Output.Video_H264.Level = VFH264Level.Level4
                    Case 12
                        mp4Output.Video_H264.Level = VFH264Level.Level41
                    Case 13
                        mp4Output.Video_H264.Level = VFH264Level.Level42
                    Case 14
                        mp4Output.Video_H264.Level = VFH264Level.Level5
                    Case 15
                        mp4Output.Video_H264.Level = VFH264Level.Level51
                End Select

                Select Case (cbH264TargetUsage.SelectedIndex)
                    Case 0
                        mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.Auto
                    Case 1
                        mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.BestQuality
                    Case 2
                        mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.Balanced
                    Case 3
                        mp4Output.Video_H264.TargetUsage = VFH264TargetUsage.BestSpeed
                End Select

                mp4Output.Video_H264.PictureType = VFH264PictureType.Auto

                mp4Output.Video_H264.RateControl = cbH264RateControl.SelectedIndex
                mp4Output.Video_H264.GOP = cbH264GOP.Checked
                mp4Output.Video_H264.BitrateAuto = cbH264AutoBitrate.Checked

                Dim tmp As Integer
                Integer.TryParse(edH264Bitrate.Text, tmp)
                mp4Output.Video_H264.Bitrate = tmp

                ' Audio AAC settings
                Integer.TryParse(cbAACBitrate.Text, tmp)
                mp4Output.Audio_AAC.Bitrate = tmp

                mp4Output.Audio_AAC.Version = cbAACVersion.SelectedIndex
                mp4Output.Audio_AAC.Output = cbAACOutput.SelectedIndex
                mp4Output.Audio_AAC.Object = (cbAACObjectType.SelectedIndex + 1)

                VideoCapture1.Output_Format = mp4Output
            End If
        End If

        VideoCapture1.Video_Effects_Enabled = True
        VideoCapture1.Video_Effects_Clear()

        'VideoCapture1.Video_Effects_Deinterlace_CAVT(0, 0, 0, True, 20)

        'Audio processing
        VideoCapture1.Audio_Effects_Clear(-1)
        VideoCapture1.Audio_Effects_Enabled = True

        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1)
        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1)
        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1)

        VideoCapture1.Start()
    End Sub

    Private Sub btStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStop.Click
        VideoCapture1.[Stop]()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + VideoCapture1.SDK_Version.ToString() + ", " + VideoCapture1.SDK_State + ")"

        Dim i As Integer
        For i = 0 To VideoCapture1.Video_Codecs.Count - 1
            cbVideoCodecs.Items.Add(VideoCapture1.Video_Codecs.Item(i))
        Next

        cbVideoCodecs.SelectedIndex = 0
        cbVideoCodecs_SelectedIndexChanged(Nothing, Nothing)

        For i = 0 To VideoCapture1.Audio_Codecs.Count - 1
            cbAudioCodecs.Items.Add(VideoCapture1.Audio_Codecs.Item(i))
        Next

        cbAudioCodecs.SelectedIndex = 0
        cbAudioCodecs_SelectedIndexChanged(Nothing, Nothing)

        If cbVideoCodecs.Items.IndexOf("MJPEG Compressor") <> -1 Then
            cbVideoCodecs.SelectedIndex = cbVideoCodecs.Items.IndexOf("MJPEG Compressor")
        End If

        If cbAudioCodecs.Items.IndexOf("PCM") <> -1 Then
            cbAudioCodecs.SelectedIndex = cbAudioCodecs.Items.IndexOf("PCM")
        End If

        For i = 0 To VideoCapture1.WMV_Internal_Profiles.Count - 1
            cbWMVInternalProfile9.Items.Add(VideoCapture1.WMV_Internal_Profiles.Item(i))
        Next
        cbWMVInternalProfile9.SelectedIndex = 0

        For i = 0 To VideoCapture1.Video_CaptureDevicesInfo.Count - 1
            cbVideoInputDevice.Items.Add(VideoCapture1.Video_CaptureDevicesInfo.Item(i).Name)
        Next

        If cbVideoInputDevice.Items.Count > 0 Then
            cbVideoInputDevice.SelectedIndex = 0
        End If

        cbVideoInputDevice_SelectedIndexChanged(Nothing, Nothing)

        For i = 0 To VideoCapture1.Audio_CaptureDevicesInfo.Count - 1
            cbAudioInputDevice.Items.Add(VideoCapture1.Audio_CaptureDevicesInfo.Item(i).Name)
        Next

        If (cbAudioInputDevice.Items.Count > 0) Then
            cbAudioInputDevice.SelectedIndex = 0
            cbAudioInputDevice_SelectedIndexChanged(Nothing, Nothing)
        End If

        cbAudioInputLine.Items.Clear()

        Dim deviceItem As List(Of AudioCaptureDeviceInfo) = (From info In VideoCapture1.Audio_CaptureDevicesInfo Where info.Name = cbAudioInputDevice.Text).ToList()
        If Not IsNothing(deviceItem) and deviceItem.Any() Then
            Dim lines = deviceItem.First.Lines
            For Each item As String In lines
                cbAudioInputLine.Items.Add(item)
            Next

            cbAudioInputLine.SelectedIndex = 0
            cbAudioInputLine_SelectedIndexChanged(Nothing, Nothing)
            cbAudioInputFormat_SelectedIndexChanged(Nothing, Nothing)
        End If

        For i = 0 To VideoCapture1.Audio_OutputDevices.Count - 1
            cbAudioOutputDevice.Items.Add(VideoCapture1.Audio_OutputDevices.Item(i))
        Next

        cbAudioOutputDevice.SelectedIndex = 0

        For i = 0 To VideoCapture1.Audio_Effects_Equalizer_Presets.Count - 1
            cbAudEqualizerPreset.Items.Add(VideoCapture1.Audio_Effects_Equalizer_Presets.Item(i))
        Next

        cbChannels.SelectedIndex = 1
        cbBPS.SelectedIndex = 1
        cbSampleRate.SelectedIndex = 0
        cbImageType.SelectedIndex = 1

        cbMode.SelectedIndex = 0

        cbH264Profile.SelectedIndex = 2
        cbH264Level.SelectedIndex = 0
        cbH264RateControl.SelectedIndex = 1
        cbAACOutput.SelectedIndex = 0
        cbAACVersion.SelectedIndex = 0
        cbAACObjectType.SelectedIndex = 1
        cbAACBitrate.SelectedIndex = 12
        cbH264TargetUsage.SelectedIndex = 3

        edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"
        edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\" + "output.avi"

    End Sub

    Private Sub llVideoTutorials_LinkClicked(ByVal sender As System.Object, ByVal e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llVideoTutorials.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/video_tutorials")
        Process.Start(startInfo)

    End Sub

    Private Sub VideoCapture1_OnError(ByVal sender As System.Object, ByVal e As VisioForge.Types.ErrorsEventArgs) Handles VideoCapture1.OnError

        mmLog.Text = mmLog.Text + e.Message + Environment.NewLine

    End Sub


    Private Sub VideoCapture1_OnLicenseRequired(sender As Object, e As LicenseEventArgs) Handles VideoCapture1.OnLicenseRequired

        If cbLicensing.Checked Then
            mmLog.Text = mmLog.Text + "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine
        End If

    End Sub
End Class

' ReSharper restore InconsistentNaming