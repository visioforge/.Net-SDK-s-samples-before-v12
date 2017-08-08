' ReSharper disable InconsistentNaming

Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Shared.IPCameraDB
Imports VisioForge.Tools
Imports VisioForge.Types.OutputFormat
Imports VisioForge.Types.Sources

Public Class Form1

    Dim onvifControl As ONVIFControl

    Dim onvifPtzRanges As ONVIFPTZRanges

    Dim onvifPtzX As Double

    Dim onvifPtzY As Double

    Dim onvifPtzZoom As Double

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

        cbImageType.SelectedIndex = 1
        cbChannels.SelectedIndex = 1
        cbBPS.SelectedIndex = 1
        cbSampleRate.SelectedIndex = 0
        cbIPCameraType.SelectedIndex = 2

        cbH264Profile.SelectedIndex = 2
        cbH264Level.SelectedIndex = 0
        cbH264RateControl.SelectedIndex = 1
        cbAACOutput.SelectedIndex = 0
        cbAACVersion.SelectedIndex = 0
        cbAACObjectType.SelectedIndex = 1
        cbAACBitrate.SelectedIndex = 12
        cbH264TargetUsage.SelectedIndex = 3

        edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"
        edOutputAVI.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi"
        edOutputMP4.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp4"

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
    Private Sub btSelectOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectOutput.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            edOutputAVI.Text = saveFileDialog1.FileName
        End If
    End Sub
    Private Sub btStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStart.Click

        If (onvifControl IsNot Nothing) Then
            onvifControl.Disconnect()
            onvifControl.Dispose()
            onvifControl = Nothing

            btONVIFConnect.Text = "Connect"
        End If

        mmLog.Clear()

        VideoCapture1.Video_Sample_Grabber_Enabled = True

        VideoCapture1.Video_Renderer.Zoom_Ratio = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftX = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftY = 0

        VideoCapture1.Debug_Mode = cbDebugMode.Checked
        VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"

        VideoCapture1.Audio_RecordAudio = False
        VideoCapture1.Audio_PlayAudio = False

        If VideoCapture.Filter_Supported_EVR() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf VideoCapture.Filter_Supported_VMR9() Then
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

        'source
        VideoCapture1.IP_Camera_Source = New IPCameraSourceSettings()

        Select Case (cbIPCameraType.SelectedIndex)

            Case 0 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_VLC

            Case 1 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_FFMPEG

            Case 2 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.Auto_LAV

            Case 3 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_Live555

            Case 4 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.HTTP_FFMPEG

            Case 5 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.MMS_WMV

            Case 6 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_UDP_FFMPEG

            Case 7 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_TCP_FFMPEG

            Case 8 : VideoCapture1.IP_Camera_Source.Type = VFIPSource.RTSP_HTTP_FFMPEG

        End Select

        VideoCapture1.IP_Camera_Source.URL = edIPUrl.Text
        VideoCapture1.IP_Camera_Source.AudioCapture = cbIPAudioCapture.Checked
        VideoCapture1.IP_Camera_Source.Login = edIPLogin.Text
        VideoCapture1.IP_Camera_Source.Password = edIPPassword.Text
        VideoCapture1.IP_Camera_Source.VLC_ZeroClockJitterEnabled = cbVLCZeroClockJitter.Checked
        VideoCapture1.IP_Camera_Source.VLC_CustomLatency = Convert.ToInt32(edVLCCacheSize.Text)

        If (cbIPCameraONVIF.Checked) Then
            VideoCapture1.IP_Camera_Source.ONVIF_Source = True

            If (cbONVIFProfile.SelectedIndex <> -1) Then
                VideoCapture1.IP_Camera_Source.ONVIF_SourceProfile = cbONVIFProfile.Text
            End If
        End If

        If rbPreview.Checked Then

            VideoCapture1.Mode = VFVideoCaptureMode.IPPreview

        ElseIf (rbCaptureAVI.Checked) Then

            VideoCapture1.Mode = VFVideoCaptureMode.IPCapture

            VideoCapture1.Output_Filename = edOutputAVI.Text
            Dim aviOutput As VFAVIOutput = New VFAVIOutput()

            aviOutput.ACM.Name = cbAudioCodecs.Text
            aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text)
            aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text)
            aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text)

            aviOutput.Video_Codec = cbVideoCodecs.Text

            VideoCapture1.Output_Format = aviOutput

        Else

            VideoCapture1.Mode = VFVideoCaptureMode.IPCapture

            VideoCapture1.Output_Filename = edOutputMP4.Text

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

    Private Sub linkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel7.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe")
        Process.Start(startInfo)

    End Sub

    Private Sub btShowIPCamDatabase_Click(sender As Object, e As EventArgs) Handles btShowIPCamDatabase.Click

        IPCameraDB.ShowWindow()

    End Sub

    Private Sub btONVIFConnect_Click(sender As Object, e As EventArgs) Handles btONVIFConnect.Click

        If (btONVIFConnect.Text = "Connect") Then
            btONVIFConnect.Text = "Disconnect"

            If (onvifControl IsNot Nothing) Then
                onvifControl.Disconnect()
                onvifControl.Dispose()
                onvifControl = Nothing
            End If

            If (String.IsNullOrEmpty(edIPLogin.Text) Or String.IsNullOrEmpty(edIPPassword.Text)) Then
                MessageBox.Show("Please specify IP camera user name and password.")
                Exit Sub
            End If

            onvifControl = New ONVIFControl()
            Dim result = onvifControl.Connect(edIPUrl.Text, edIPLogin.Text, edIPPassword.Text)

            If (Not result) Then
                onvifControl = Nothing
                MessageBox.Show("Unable to connect to ONVIF camera.")
                Exit Sub
            End If

            Dim deviceInfo = onvifControl.GetDeviceInformation()
            lbONVIFCameraInfo.Text = $"Model {deviceInfo.Model}, Firmware {deviceInfo.Firmware}"

            cbONVIFProfile.Items.Clear()

            Dim profiles As VisioForge.MediaFramework.deviceio.Profile() = onvifControl.GetProfiles()
            For Each profile As VisioForge.MediaFramework.deviceio.Profile In profiles
                cbONVIFProfile.Items.Add($"{profile.Name}")
            Next

            If (cbONVIFProfile.Items.Count > 0) Then
                cbONVIFProfile.SelectedIndex = 0
            End If

            edONVIFLiveVideoURL.Text = onvifControl.GetVideoURL()

            onvifPtzRanges = onvifControl.PTZ_GetRanges()
            onvifControl.PTZ_SetAbsolute(0, 0, 0)

            onvifPtzX = 0
            onvifPtzY = 0
            onvifPtzZoom = 0
        Else
            btONVIFConnect.Text = "Connect"

            If (onvifControl IsNot Nothing) Then
                onvifControl.Disconnect()
                onvifControl.Dispose()
                onvifControl = Nothing
            End If
        End If

    End Sub

    Private Sub btONVIFRight_Click(sender As Object, e As EventArgs) Handles btONVIFRight.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30
        onvifPtzX = onvifPtzX - step_

        If (onvifPtzX < onvifPtzRanges.MinX) Then
            onvifPtzX = onvifPtzRanges.MinX
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub

    Private Sub btONVIFPTZSetDefault_Click(sender As Object, e As EventArgs) Handles btONVIFPTZSetDefault.Click

        onvifControl?.PTZ_SetAbsolute(0, 0, 0)

    End Sub

    Private Sub btONVIFLeft_Click(sender As Object, e As EventArgs) Handles btONVIFLeft.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxX - onvifPtzRanges.MinX) / 30
        onvifPtzX = onvifPtzX + step_

        If (onvifPtzX > onvifPtzRanges.MaxX) Then
            onvifPtzX = onvifPtzRanges.MaxX
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub

    Private Sub btONVIFUp_Click(sender As Object, e As EventArgs) Handles btONVIFUp.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30
        onvifPtzY = onvifPtzY - step_

        If (onvifPtzY < onvifPtzRanges.MinY) Then
            onvifPtzY = onvifPtzRanges.MinY
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub

    Private Sub btONVIFDown_Click(sender As Object, e As EventArgs) Handles btONVIFDown.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxY - onvifPtzRanges.MinY) / 30
        onvifPtzY = onvifPtzY + step_

        If (onvifPtzY > onvifPtzRanges.MaxY) Then
            onvifPtzY = onvifPtzRanges.MaxY
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub

    Private Sub btONVIFZoomIn_Click(sender As Object, e As EventArgs) Handles btONVIFZoomIn.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100
        onvifPtzZoom = onvifPtzZoom + step_

        If (onvifPtzZoom > onvifPtzRanges.MaxZoom) Then
            onvifPtzZoom = onvifPtzRanges.MaxZoom
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub

    Private Sub btONVIFZoomOut_Click(sender As Object, e As EventArgs) Handles btONVIFZoomOut.Click

        If (onvifControl Is Nothing Or onvifPtzRanges Is Nothing) Then
            Exit Sub
        End If

        Dim step_ As Double = (onvifPtzRanges.MaxZoom - onvifPtzRanges.MinZoom) / 100
        onvifPtzZoom = onvifPtzZoom - step_

        If (onvifPtzZoom < onvifPtzRanges.MinZoom) Then
            onvifPtzZoom = onvifPtzRanges.MinZoom
        End If

        onvifControl?.PTZ_SetAbsolute(onvifPtzX, onvifPtzY, onvifPtzZoom)

    End Sub
End Class

' ReSharper restore InconsistentNaming