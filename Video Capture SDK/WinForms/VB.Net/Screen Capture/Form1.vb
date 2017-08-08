' ReSharper disable InconsistentNaming

Imports System.Linq
Imports System.Runtime.InteropServices
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Types.OutputFormat
Imports VisioForge.Types.Sources
Imports VisioForge.Types.VideoEffects

Public Class Form1

    <DllImport("user32.dll", EntryPoint:="FindWindow", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Private Shared Function FindWindowByClass( _
     ByVal lpClassName As String, _
     ByVal zero As IntPtr) As IntPtr
    End Function

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

        For i = 0 To VideoCapture1.Audio_CaptureDevicesInfo.Count - 1
            cbAudioInputDevice.Items.Add(VideoCapture1.Audio_CaptureDevicesInfo.Item(i).Name)
        Next

        If (cbAudioInputDevice.Items.Count > 0) Then
            cbAudioInputDevice.SelectedIndex = 0
            cbAudioInputDevice_SelectedIndexChanged(Nothing, Nothing)
        End If

        For i = 0 To VideoCapture1.WMV_Internal_Profiles.Count - 1
            cbWMVInternalProfile9.Items.Add(VideoCapture1.WMV_Internal_Profiles.Item(i))
        Next
        cbWMVInternalProfile9.SelectedIndex = 0

        cbChannels.SelectedIndex = 1
        cbBPS.SelectedIndex = 1
        cbSampleRate.SelectedIndex = 0
        cbImageType.SelectedIndex = 1

        For Each screen As Screen In Windows.Forms.Screen.AllScreens
            cbScreenCaptureDisplayIndex.Items.Add(screen.DeviceName.Replace("\\.\DISPLAY", String.Empty))
        Next

        cbScreenCaptureDisplayIndex.SelectedIndex = 0
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

    Private Sub btScreenCaptureUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btScreenCaptureUpdate.Click

        VideoCapture1.Screen_Capture_UpdateParameters(Convert.ToInt32(edScreenLeft.Text), Convert.ToInt32(edScreenTop.Text), cbScreenCapture_GrabMouseCursor.Checked)

    End Sub

    Private Sub cbImageLogo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbImageLogo.CheckStateChanged

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

    Private Sub cbTextLogo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextLogo.CheckStateChanged

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

    Private Sub cbUseBestAudioInputFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUseBestAudioInputFormat.CheckedChanged

        cbAudioInputFormat.Enabled = Not cbUseBestAudioInputFormat.Checked

    End Sub

    Private Sub btSelectOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectOutput.Click

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            edOutput.Text = saveFileDialog1.FileName
        End If

    End Sub

    Private Sub btStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStart.Click

        VideoCapture1.Video_Sample_Grabber_Enabled = true

        mmLog.Clear()

        VideoCapture1.Debug_Mode = cbDebugMode.Checked
        VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"

        'from screen
        VideoCapture1.Screen_Capture_Source = New ScreenCaptureSourceSettings()

        If (rbScreenCaptureWindow.Checked) Then

            VideoCapture1.Screen_Capture_Source.Mode = VFScreenCaptureMode.Window

            VideoCapture1.Screen_Capture_Source.WindowHandle = IntPtr.Zero

            Try

                VideoCapture1.Screen_Capture_Source.WindowHandle = FindWindowByClass(edScreenCaptureWindowName.Text, IntPtr.Zero)

            Catch

            End Try

            If (VideoCapture1.Screen_Capture_Source.WindowHandle = IntPtr.Zero) Then

                MessageBox.Show("Incorrect window title for screen capture.")
                Return

            End If


        Else

            VideoCapture1.Screen_Capture_Source.Mode = VFScreenCaptureMode.Screen

        End If
        VideoCapture1.Screen_Capture_Source.FrameRate = CSng(Convert.ToDouble(edScreenFrameRate.Text))
        VideoCapture1.Screen_Capture_Source.FullScreen = rbScreenFullScreen.Checked
        VideoCapture1.Screen_Capture_Source.Top = Convert.ToInt32(edScreenTop.Text)
        VideoCapture1.Screen_Capture_Source.Bottom = Convert.ToInt32(edScreenBottom.Text)
        VideoCapture1.Screen_Capture_Source.Left = Convert.ToInt32(edScreenLeft.Text)
        VideoCapture1.Screen_Capture_Source.Right = Convert.ToInt32(edScreenRight.Text)
        VideoCapture1.Screen_Capture_Source.GrabMouseCursor = cbScreenCapture_GrabMouseCursor.Checked
        VideoCapture1.Screen_Capture_Source.DisplayIndex = Convert.ToInt32(cbScreenCaptureDisplayIndex.Text)
        VideoCapture1.Screen_Capture_Source.AllowDesktopDuplicationEngine = cbScreenCapture_DesktopDuplication.Checked

        If cbRecordAudio.Checked Then
            VideoCapture1.Audio_RecordAudio = True
            VideoCapture1.Audio_PlayAudio = False

            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text
        Else
            VideoCapture1.Audio_RecordAudio = False
            VideoCapture1.Audio_PlayAudio = False
        End If

        'apply capture parameters
        If VideoCapture.Filter_Supported_EVR() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf VideoCapture.Filter_Supported_VMR9() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

        VideoCapture1.Video_Effects_Enabled = True
        VideoCapture1.Video_Effects_Clear()

        If (cbMode.SelectedIndex = 0) Then
            VideoCapture1.Mode = VFVideoCaptureMode.ScreenPreview
        Else
            VideoCapture1.Mode = VFVideoCaptureMode.ScreenCapture
            VideoCapture1.Output_Filename = edOutput.Text

            If (cbMode.SelectedIndex = 1) Then

                    Dim aviOutput As VFAVIOutput = new VFAVIOutput()

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
                
                Dim mp4Output As VFMP4Output = new VFMP4Output()

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

        VideoCapture1.Start()

    End Sub

    Private Sub btStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStop.Click

        VideoCapture1.Stop()

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