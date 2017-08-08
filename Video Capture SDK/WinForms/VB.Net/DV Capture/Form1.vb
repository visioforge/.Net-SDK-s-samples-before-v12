' ReSharper disable InconsistentNaming

Imports System.Linq
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Types.OutputFormat
Imports VisioForge.Types.VideoEffects

Public Class Form1

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

        For i = 0 To VideoCapture1.Audio_OutputDevices.Count - 1
            cbAudioOutputDevice.Items.Add(VideoCapture1.Audio_OutputDevices.Item(i))
        Next

        cbAudioOutputDevice.SelectedIndex = 0

        cbChannels.SelectedIndex = 1
        cbBPS.SelectedIndex = 1
        cbSampleRate.SelectedIndex = 0
        cbDVChannels.SelectedIndex = 1
        cbDVSampleRate.SelectedIndex = 0
        cbImageType.SelectedIndex = 1

        edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"
        edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\" + "output.avi"

        If VideoCapture.Filter_Supported_EVR() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf VideoCapture.Filter_Supported_VMR9() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

    End Sub
    Private Sub cbVideoCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVideoCodecs.SelectedIndexChanged
        Dim sName As String = cbVideoCodecs.Text
        btVideoSettings.Enabled = VideoCapture.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)
    End Sub
    Private Sub cbAudioCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioCodecs.SelectedIndexChanged
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
    Private Sub btFont_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btFont.Click
        If fontDialog1.ShowDialog() = DialogResult.OK Then
            cbTextLogo_CheckedChanged(Nothing, Nothing)
        End If
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
    Private Sub tbJPEGQuality_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbJPEGQuality.Scroll
        lbJPEGQuality.Text = tbJPEGQuality.Value.ToString()
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
    Private Sub tbGraphicLogoTransp_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbImageLogoTransp.Scroll
        cbImageLogo_CheckedChanged(Nothing, Nothing)
    End Sub
    Private Sub tbTextLogoTransp_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbTextLogoTransp.Scroll
        cbTextLogo_CheckedChanged(Nothing, Nothing)
    End Sub
    Private Sub cbVideoInputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVideoInputDevice.SelectedIndexChanged
        If cbVideoInputDevice.SelectedIndex <> -1 Then
            VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text

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
    Private Sub btSelectOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectOutput.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            edOutput.Text = saveFileDialog1.FileName
        End If
    End Sub
    Private Sub btDVFF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVFF.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.FastestFwd)
    End Sub
    Private Sub btDVPause_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVPause.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.Pause)
    End Sub
    Private Sub btDVRewind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVRewind.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.Rew)
    End Sub
    Private Sub btDVPlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVPlay.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.Play)
    End Sub
    Private Sub btDVStepFWD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVStepFWD.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.StepFw)
    End Sub
    Private Sub btDVStepRev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVStepRev.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.StepRev)
    End Sub
    Private Sub btDVStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDVStop.Click
        VideoCapture1.DV_SendCommand(VFDVCommand.Stop)
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
            VideoCapture1.Audio_PlayAudio = False
        Else
            VideoCapture1.Audio_RecordAudio = False
            VideoCapture1.Audio_PlayAudio = False
        End If

        'apply capture parameters
        VideoCapture1.Video_CaptureDevice = cbVideoInputDevice.Text
        VideoCapture1.Video_CaptureDevice_IsAudioSource = True
        VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text
        VideoCapture1.Audio_CaptureDevice_Format_UseBest = True
        VideoCapture1.Video_CaptureDevice_Format = cbVideoInputFormat.Text
        VideoCapture1.Video_CaptureDevice_Format_UseBest = cbUseBestVideoInputFormat.Checked

        If cbFramerate.SelectedIndex <> -1 Then
            VideoCapture1.Video_CaptureDevice_FrameRate = CSng(Convert.ToDouble(cbFramerate.Text))
        End If

        If rbPreview.Checked Then
            VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview
        Else
            VideoCapture1.Mode = VFVideoCaptureMode.VideoCapture
            VideoCapture1.Output_Filename = edOutput.Text

            If rbAVI.Checked Then
                Dim aviOutput As VFAVIOutput = New VFAVIOutput()

                aviOutput.ACM.Name = cbAudioCodecs.Text
                aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text)
                aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text)
                aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text)

                aviOutput.Video_Codec = cbVideoCodecs.Text

                VideoCapture1.Output_Format = aviOutput
            ElseIf rbWMV.Checked Then
                Dim wmvOutput As VFWMVOutput = New VFWMVOutput

                wmvOutput.Mode = VFWMVMode.InternalProfile

                If (cbWMVInternalProfile9.SelectedIndex <> -1) Then
                    wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text
                End If

                VideoCapture1.Output_Format = wmvOutput
            ElseIf rbDVDirectstream.Checked Then
                Dim dvDirectcaptureOutput As VFDirectCaptureDVOutput = New VFDirectCaptureDVOutput()
                VideoCapture1.Output_Format = dvDirectcaptureOutput
            Else
                Dim dvOutput As VFDVOutput = New VFDVOutput()

                dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text)
                dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text)

                If rbDVPAL.Checked Then
                    dvOutput.Video_Format = VFDVVideoFormat.PAL
                Else
                    dvOutput.Video_Format = VFDVVideoFormat.NTSC
                End If

                dvOutput.Type2 = rbDVType2.Checked

                VideoCapture1.Output_Format = dvOutput

            End If
        End If

        VideoCapture1.Video_Effects_Enabled = True
        VideoCapture1.Video_Effects_Clear()

        ' add deinterlace
        Dim cavt As IVFVideoEffectDeinterlaceCAVT
        Dim effect = VideoCapture1.Video_Effects_Get("DeinterlaceCAVT")
        If (effect Is Nothing) Then
            cavt = New VFVideoEffectDeinterlaceCAVT(True, 20)
            VideoCapture1.Video_Effects_Add(cavt)
        Else
            cavt = effect
        End If

        If (cavt Is Nothing) Then
            MessageBox.Show("Unable to configure deinterlace CAVT effect.")
            Return
        End If

        cavt.Threshold = 20

        VideoCapture1.Start()
    End Sub
    Private Sub btStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStop.Click

        VideoCapture1.[Stop]()

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