' ReSharper disable InconsistentNaming

Imports System.Linq
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Types.OutputFormat

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + VideoCapture1.SDK_Version.ToString() + ", " + VideoCapture1.SDK_State + ")"

        Dim i As Integer

        For i = 0 To VideoCapture1.Audio_Codecs.Count - 1
            cbAudioCodecs.Items.Add(VideoCapture1.Audio_Codecs.Item(i))
        Next

        cbAudioCodecs.SelectedIndex = 0
        cbAudioCodecs_SelectedIndexChanged(Nothing, Nothing)

        For i = 0 To VideoCapture1.Audio_CaptureDevicesInfo.Count - 1
            cbAudioInputDevice.Items.Add(VideoCapture1.Audio_CaptureDevicesInfo.Item(i).Name)
        Next

        If cbAudioInputDevice.Items.Count > 0 Then
            cbAudioInputDevice.SelectedIndex = 0
            cbAudioInputDevice_SelectedIndexChanged(Nothing, Nothing)
        End If
        
        cbAudioInputLine.Items.Clear()

        Dim deviceItem as List(Of AudioCaptureDeviceInfo) = (From info In VideoCapture1.Audio_CaptureDevicesInfo Where info.Name = cbAudioInputDevice.Text).ToList()
        If Not IsNothing(deviceItem) And deviceItem.Any() Then
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

        If cbAudioCodecs.Items.IndexOf("PCM") <> -1 Then
            cbAudioCodecs.SelectedIndex = cbAudioCodecs.Items.IndexOf("PCM")
        End If

        cbAudioCodecs_SelectedIndexChanged(Nothing, Nothing)

        For i = 0 To VideoCapture1.Audio_Effects_Equalizer_Presets.Count - 1
            cbAudEqualizerPreset.Items.Add(VideoCapture1.Audio_Effects_Equalizer_Presets.Item(i))
        Next

        cbOutputFormat.SelectedIndex = 0
        cbChannels.SelectedIndex = 0
        cbSampleRate.SelectedIndex = 0
        cbBPS.SelectedIndex = 0
        cbLameCBRBitrate.SelectedIndex = 8
        cbLameVBRMax.SelectedIndex = 8
        cbLameVBRMin.SelectedIndex = 8
        cbLameSampleRate.SelectedIndex = 0
        cbAudEqualizerPreset.SelectedIndex = 0
        cbAudEqualizerPreset_SelectedIndexChanged(Nothing, Nothing)

        edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\" + "output.wav"

    End Sub
    Private Sub cbAudioCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioCodecs.SelectedIndexChanged

        Dim sName As String = cbAudioCodecs.Text
        btAudioSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoCapture.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

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
    Private Sub cbAudioInputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioInputDevice.SelectedIndexChanged

        If cbAudioInputDevice.SelectedIndex <> -1 Then
            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text
            cbAudioInputFormat.Items.Clear()

            Dim deviceItem = (From info In VideoCapture1.Audio_CaptureDevicesInfo Where info.Name = cbAudioInputDevice.Text)?.First()
            if IsNothing(deviceItem) Then
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
    Private Sub cbAudioOutputDevice_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudioOutputDevice.SelectedIndexChanged

        VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text

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
    Private Sub cbAudSound3DEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAudSound3DEnabled.CheckedChanged

        VideoCapture1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked)

    End Sub
    Private Sub tbAud3DSound_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbAud3DSound.Scroll

        VideoCapture1.Audio_Effects_Sound3D(-1, 3, tbAud3DSound.Value)

    End Sub
    Private Sub btSelectOutput_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSelectOutput.Click

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            edOutput.Text = saveFileDialog1.FileName
        End If

    End Sub
    Private Sub btStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btStart.Click

        mmLog.Clear()

        VideoCapture1.Video_Renderer.Zoom_Ratio = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftX = 0
        VideoCapture1.Video_Renderer.Zoom_ShiftY = 0

        VideoCapture1.Debug_Mode = cbDebugMode.Checked
        VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"

        VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text
        VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text
        VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text
        VideoCapture1.Audio_CaptureDevice_Format_UseBest = False
        VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text
        VideoCapture1.Audio_PlayAudio = cbPlayAudio.Checked
        VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.None

        If rbPreview.Checked Then
            VideoCapture1.Mode = VFVideoCaptureMode.AudioPreview
            VideoCapture1.Audio_RecordAudio = True
        Else
            VideoCapture1.Mode = VFVideoCaptureMode.AudioCapture
            VideoCapture1.Audio_RecordAudio = True
            VideoCapture1.Output_Filename = edOutput.Text

            If cbOutputFormat.SelectedIndex = 0 Then
                Dim acmOutput As VFACMOutput = New VFACMOutput

                acmOutput.Name = cbAudioCodecs.Text
                acmOutput.Channels = Convert.ToInt32(cbChannels.Text)
                acmOutput.BPS = Convert.ToInt32(cbBPS.Text)
                acmOutput.SampleRate = Convert.ToInt32(cbSampleRate.Text)

                VideoCapture1.Output_Format = acmOutput
            Else
                Dim mp3Output As VFMP3Output = New VFMP3Output()

                'main
                mp3Output.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text)
                mp3Output.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text)
                mp3Output.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text)
                mp3Output.SampleRate = Convert.ToInt32(cbLameSampleRate.Text)
                mp3Output.VBR_Quality = tbLameVBRQuality.Value
                mp3Output.EncodingQuality = tbLameEncodingQuality.Value

                If rbLameStandardStereo.Checked Then
                    mp3Output.ChannelsMode = VFLameChannelsMode.StandardStereo
                ElseIf rbLameJointStereo.Checked Then
                    mp3Output.ChannelsMode = VFLameChannelsMode.JointStereo
                ElseIf rbLameDualChannels.Checked Then
                    mp3Output.ChannelsMode = VFLameChannelsMode.DualStereo
                Else
                    mp3Output.ChannelsMode = VFLameChannelsMode.Mono
                End If

                mp3Output.VBR_Mode = rbLameVBR.Checked

                'Other
                mp3Output.Copyright = cbLameCopyright.Checked
                mp3Output.Original = cbLameOriginal.Checked
                mp3Output.CRCProtected = cbLameCRCProtected.Checked
                mp3Output.ForceMono = cbLameForceMono.Checked
                mp3Output.StrictlyEnforceVBRMinBitrate = cbLameStrictlyEnforceVBRMinBitrate.Checked
                mp3Output.VoiceEncodingMode = cbLameVoiceEncodingMode.Checked
                mp3Output.KeepAllFrequencies = cbLameKeepAllFrequencies.Checked
                mp3Output.StrictISOCompliance = cbLameStrictISOCompilance.Checked
                mp3Output.DisableShortBlocks = cbLameDisableShortBlocks.Checked
                mp3Output.EnableXingVBRTag = cbLameEnableXingVBRTag.Checked
                mp3Output.ModeFixed = cbLameModeFixed.Checked

                VideoCapture1.Output_Format = mp3Output
            End If
        End If

        'Audio processing
        VideoCapture1.Audio_Effects_Clear(-1)
        VideoCapture1.Audio_Effects_Enabled = True

        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1)
        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1)
        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1)
        VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1)

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