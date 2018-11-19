' ReSharper disable InconsistentNaming

Imports System.Globalization
Imports System.IO
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms
Imports VisioForge.Types.GPUVideoEffects
Imports VisioForge.Types.OutputFormat
Imports VisioForge.Types.VideoEffects

Public Class Form1

    Dim audioChannelMapperItems As List(Of AudioChannelMapperItem) = new List(Of AudioChannelMapperItem)

    ' Zoom
    Dim zoom As Double = 1.0

    Dim zoomShiftX As Integer = 0

    Dim zoomShiftY As Integer = 0

    Public Function GetFileExt(ByVal fileName As String) As String

        Dim k As Integer
        k = fileName.LastIndexOf(".", StringComparison.Ordinal)
        GetFileExt = fileName.Substring(k, fileName.Length - k)

    End Function

    Public Function ChangeFileExt(ByVal FileName As String, ByVal Ext As String) As String

        ChangeFileExt = FileName.Replace(GetFileExt(FileName), Ext)

    End Function

    Private Function IsWindows8OrNewer() As Boolean

        Dim os = Environment.OSVersion
        Return os.Platform = PlatformID.Win32NT And (os.Version.Major > 6 Or (os.Version.Major = 6 And os.Version.Minor >= 2))

    End Function

    Private Function IsWindows7OrNewer() As Boolean

        Dim Version = Environment.OSVersion.Version
        If (Version.Major > 6) Then
            Return True
        End If

        If (Version.Major = 6 And Version.Minor >= 1) Then
            Return True
        End If

        Return False

    End Function

    Private Sub btAudioSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAudioSettings.Click

        Dim sName As String

        sName = cbAudioCodec.Text

        If (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btClearList_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btClearList.Click

        lbFiles.Items.Clear()
        VideoEdit1.Input_Clear_List()

    End Sub

    Private Sub FillWMVSettings(ByRef wmvOutput As VFWMVOutput)

        Dim s As String

        If (rbWMVInternal9.Checked) Then

            wmvOutput.Mode = VFWMVMode.InternalProfile

            If (cbWMVInternalProfile9.SelectedIndex <> -1) Then
                wmvOutput.Internal_Profile_Name = cbWMVInternalProfile9.Text
            End If

        ElseIf (rbWMVInternal8.Checked) Then

            wmvOutput.Mode = VFWMVMode.V8SystemProfile

            If (cbWMVInternalProfile8.SelectedIndex <> -1) Then
                wmvOutput.V8ProfileName = cbWMVInternalProfile8.Text
            End If

        ElseIf (rbWMVExternal.Checked) Then

            wmvOutput.Mode = VFWMVMode.ExternalProfile
            wmvOutput.External_Profile_FileName = edWMVProfile.Text

        Else

            wmvOutput.Mode = VFWMVMode.CustomSettings

            wmvOutput.Custom_Audio_Codec = cbWMVAudioCodec.Text
            wmvOutput.Custom_Audio_Format = cbWMVAudioFormat.Text
            wmvOutput.Custom_Audio_PeakBitrate = Convert.ToInt32(edWMVAudioPeakBitrate.Text)

            s = cbWMVAudioMode.Text
            If (s = "CBR") Then
                wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.CBR
            ElseIf (s = "VBR") Then
                wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRBitrate
            ElseIf (s = "VBR (Peak)") Then
                wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRPeakBitrate
            Else
                wmvOutput.Custom_Audio_Mode = VFWMVStreamMode.VBRQuality
            End If

            wmvOutput.Custom_Audio_StreamPresent = cbWMVAudioEnabled.Checked

            wmvOutput.Custom_Video_Codec = cbWMVVideoCodec.Text
            wmvOutput.Custom_Video_Width = Convert.ToInt32(edWMVWidth.Text)
            wmvOutput.Custom_Video_Height = Convert.ToInt32(edWMVHeight.Text)
            wmvOutput.Custom_Video_SizeSameAsInput = cbWMVSizeSameAsInput.Checked
            wmvOutput.Custom_Video_FrameRate = Convert.ToDouble(edWMVFrameRate.Text)
            wmvOutput.Custom_Video_KeyFrameInterval = Convert.ToByte(edWMVKeyFrameInterval.Text)
            wmvOutput.Custom_Video_Bitrate = Convert.ToInt32(edWMVVideoBitrate.Text)
            wmvOutput.Custom_Video_Quality = Convert.ToByte(edWMVVideoQuality.Text)

            s = cbWMVVideoMode.Text
            If (s = "CBR") Then
                wmvOutput.Custom_Video_Mode = VFWMVStreamMode.CBR
            ElseIf (s = "VBR") Then
                wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRBitrate
            ElseIf (s = "VBR (Peak)") Then
                wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRPeakBitrate
            Else
                wmvOutput.Custom_Video_Mode = VFWMVStreamMode.VBRQuality
            End If

            If (cbWMVTVFormat.Text = "PAL") Then
                wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.PAL
            ElseIf (cbWMVTVFormat.Text = "NTSC") Then
                wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.NTSC
            Else
                wmvOutput.Custom_Video_TVSystem = VFWMVTVSystem.Other
            End If

            wmvOutput.Custom_Video_StreamPresent = cbWMVVideoEnabled.Checked

            wmvOutput.Custom_Profile_Name = "MyProfile1"
        End If
    End Sub

    Private Sub btAddInputFile_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAddInputFile.Click

        Dim s As String

        If (OpenDialog1.ShowDialog() = DialogResult.OK) Then

            VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text, CultureInfo.InvariantCulture)

            ' resize if required
            Dim customWidth = 0
            Dim customHeight = 0

            If (cbResize.Checked) Then
                customWidth = Convert.ToInt32(edWidth.Text)
                customHeight = Convert.ToInt32(edHeight.Text)
            End If

            s = OpenDialog1.FileName

            lbFiles.Items.Add(s)

            If ((String.Compare(GetFileExt(s), ".BMP", True) = 0) Or (String.Compare(GetFileExt(s), ".JPG", True) = 0) Or (String.Compare(GetFileExt(s), ".JPEG", True) = 0) Or (String.Compare(GetFileExt(s), ".GIF", True) = 0) Or (String.Compare(GetFileExt(s), ".PNG", True) = 0)) Then

                If (cbAddFullFile.Checked) Then

                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddImageFile(s, 2000, -1, VFVideoEditStretchMode.Letterbox)
                    Else
                        VideoEdit1.Input_AddImageFile(s, 2000, Convert.ToInt32(edInsertTime.Text), VFVideoEditStretchMode.Letterbox)
                    End If

                Else
                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddImageFile(s, Convert.ToInt32(edStopTime.Text) - Convert.ToInt32(edStartTime.Text), -1, VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight)
                    Else
                        VideoEdit1.Input_AddImageFile(s, Convert.ToInt32(edStopTime.Text) - Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edInsertTime.Text), VFVideoEditStretchMode.Letterbox, 0, customWidth, customHeight)
                    End If
                End If

            ElseIf ((String.Compare(GetFileExt(s), ".WAV", True) = 0) Or (String.Compare(GetFileExt(s), ".MP3", True) = 0) Or (String.Compare(GetFileExt(s), ".OGG", True) = 0) Or (String.Compare(GetFileExt(s), ".WMA", True) = 0)) Then

                If (cbAddFullFile.Checked) Then
                    Dim audioFile = New VFVEAudioSource(s, -1, -1, String.Empty, 0, tbSpeed.Value / 100.0)
                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddAudioFile(audioFile, -1, 0)
                    Else
                        VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0)
                    End If
                Else
                    Dim audioFile = New VFVEAudioSource(s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), String.Empty, 0, tbSpeed.Value / 100.0)
                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddAudioFile(audioFile, -1, 0)
                    Else
                        VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0)
                    End If
                End If
            Else
                If (cbAddFullFile.Checked) Then
                    Dim videoFile = New VFVEVideoSource(
                                s, -1, -1, VFVideoEditStretchMode.Letterbox, 0, tbSpeed.Value / 100.0)
                    Dim audioFile = New VFVEAudioSource(s, -1, -1, String.Empty, 0, tbSpeed.Value / 100.0)

                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddVideoFile(videoFile, -1, 0, customWidth, customHeight)
                        VideoEdit1.Input_AddAudioFile(audioFile, -1, 0)
                    Else
                        VideoEdit1.Input_AddVideoFile(videoFile, Convert.ToInt32(edInsertTime.Text), 0, customWidth, customHeight)
                        VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0)
                    End If
                Else
                    Dim videoFile = New VFVEVideoSource(
                                s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), VFVideoEditStretchMode.Letterbox, 0, tbSpeed.Value / 100.0)
                    Dim audioFile = New VFVEAudioSource(s, Convert.ToInt32(edStartTime.Text), Convert.ToInt32(edStopTime.Text), String.Empty, 0, tbSpeed.Value / 100.0)

                    If (cbInsertAfterPreviousFile.Checked) Then
                        VideoEdit1.Input_AddVideoFile(videoFile, -1, 0, customWidth, customHeight)
                        VideoEdit1.Input_AddAudioFile(audioFile, -1, 0)
                    Else
                        VideoEdit1.Input_AddVideoFile(videoFile, Convert.ToInt32(edInsertTime.Text), 0, customWidth, customHeight)
                        VideoEdit1.Input_AddAudioFile(audioFile, Convert.ToInt32(edInsertTime.Text), 0)
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub btSelectOutput_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectOutput.Click

        If SaveDialog1.ShowDialog() = DialogResult.OK Then

            edOutput.Text = SaveDialog1.FileName

        End If

    End Sub

    Private Sub btVideoSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btVideoSettings.Click

        Dim sName As String

        sName = cbVideoCodec.Text

        If (VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)

        ElseIf (VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + VideoEdit1.SDK_Version.ToString() + ", " + VideoEdit1.SDK_State + ")"

        edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\" + "output.avi"
        edOutputFileCut.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi"
        edOutputFileJoin.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi"
        VideoEdit1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\VisioForge\"

        Tag = 1

        cbFrameRate.SelectedIndex = 0
        cbOutputVideoFormat.SelectedIndex = 14
        cbWMVAudioMode.SelectedIndex = 0
        cbWMVVideoMode.SelectedIndex = 0
        cbWMVTVFormat.SelectedIndex = 0
        cbOGGAverage.SelectedIndex = 6
        cbOGGMaximum.SelectedIndex = 8
        cbOGGMinimum.SelectedIndex = 5
        cbLameCBRBitrate.SelectedIndex = 10
        cbLameVBRMin.SelectedIndex = 8
        cbLameVBRMax.SelectedIndex = 10
        cbLameSampleRate.SelectedIndex = 0
        cbTextLogoAlign.SelectedIndex = 0
        cbTextLogoAntialiasing.SelectedIndex = 0
        cbTextLogoDrawMode.SelectedIndex = 0
        cbTextLogoEffectrMode.SelectedIndex = 0
        cbTextLogoGradMode.SelectedIndex = 0
        cbTextLogoShapeType.SelectedIndex = 0
        cbDVChannels.SelectedIndex = 1
        cbDVSampleRate.SelectedIndex = 1
        cbRotate.SelectedIndex = 0
        cbBarcodeType.SelectedIndex = 0
        cbNetworkStreamingMode.SelectedIndex = 0
        cbDirect2DRotate.SelectedIndex = 0
        cbSpeexBitrateControl.SelectedIndex = 2
        cbSpeexMode.SelectedIndex = 0
        cbMuxStreamsType.SelectedIndex = 0

        cbDVChannels.SelectedIndex = 1
        cbDVSampleRate.SelectedIndex = 0
        cbBPS.SelectedIndex = 0
        cbChannels.SelectedIndex = 0
        cbSampleRate.SelectedIndex = 0
        cbBPS2.SelectedIndex = 0
        cbChannels2.SelectedIndex = 0
        cbSampleRate2.SelectedIndex = 0
        cbLameCBRBitrate.SelectedIndex = 8
        cbLameVBRMin.SelectedIndex = 8
        cbLameVBRMax.SelectedIndex = 10
        cbLameSampleRate.SelectedIndex = 0

        cbMFProfile.SelectedIndex = 1
        cbMFLevel.SelectedIndex = 12
        cbMFRateControl.SelectedIndex = 3
        cbMotDetHLColor.SelectedIndex = 0

        Dim FiltersAvailableInfo = VideoEdit.GetFiltersAvailable()
        If (FiltersAvailableInfo.V11_NVENC_H264) Then
            lbMFHWAvailableEncoders.Text += "NVENC "
        End If

        If (FiltersAvailableInfo.V11_AMD_H264) Then
            lbMFHWAvailableEncoders.Text = lbMFHWAvailableEncoders.Text + "AMD "
        End If

        If (FiltersAvailableInfo.V11_QSV_H264) Then
            lbMFHWAvailableEncoders.Text += "INTEL QSV"
        End If

        If (IsWindows8OrNewer()) Then
            cbMP4Mode.SelectedIndex = 3
        ElseIf (IsWindows7OrNewer()) Then
            cbMP4Mode.SelectedIndex = 1
        Else
            cbMP4Mode.SelectedIndex = 0
        End If

        cbFLACBlockSize.SelectedIndex = 4

        cbFFAspectRatio.SelectedIndex = 0
        cbFFAudioBitrate.SelectedIndex = 8
        cbFFAudioChannels.SelectedIndex = 0
        cbFFAudioSampleRate.SelectedIndex = 1
        cbFFConstaint.SelectedIndex = 0
        cbFFOutputFormat.SelectedIndex = 0

        cbFFEXEAspectRatio.SelectedIndex = 0
        cbFFEXEAudioBitrate.SelectedIndex = 8
        cbFFEXEAudioChannels.SelectedIndex = 0
        cbFFEXEAudioSampleRate.SelectedIndex = 0
        cbFFEXEProfile.SelectedIndex = 0
        cbFFEXEH264Mode.SelectedIndex = 0
        cbFFEXEH264Level.SelectedIndex = 0
        cbFFEXEH264Preset.SelectedIndex = 0
        cbFFEXEH264Profile.SelectedIndex = 0
        cbFFEXEVideoConstraint.SelectedIndex = 0

        cbNVENCProfile.SelectedIndex = 2
        cbNVENCLevel.SelectedIndex = 0
        cbNVENCRateControl.SelectedIndex = 1

        cbH264Profile.SelectedIndex = 2
        cbH264Level.SelectedIndex = 0
        cbH264RateControl.SelectedIndex = 0
        cbH264MBEncoding.SelectedIndex = 0
        cbAACOutput.SelectedIndex = 0
        cbAACVersion.SelectedIndex = 0
        cbAACObjectType.SelectedIndex = 1
        cbAACBitrate.SelectedIndex = 12
        cbH264PictureType.SelectedIndex = 0
        cbH264TargetUsage.SelectedIndex = 0

        cbM4AOutput.SelectedIndex = 0
        cbM4AVersion.SelectedIndex = 0
        cbM4AObjectType.SelectedIndex = 1
        cbM4ABitrate.SelectedIndex = 12

        cbDecklinkOutputAnalog.SelectedIndex = 0
        cbDecklinkOutputBlackToDeck.SelectedIndex = 0
        cbDecklinkOutputComponentLevels.SelectedIndex = 0
        cbDecklinkOutputDownConversion.SelectedIndex = 0
        cbDecklinkOutputDualLink.SelectedIndex = 0
        cbDecklinkOutputHDTVPulldown.SelectedIndex = 0
        cbDecklinkOutputNTSC.SelectedIndex = 0
        cbDecklinkOutputSingleField.SelectedIndex = 0

        cbWebMVideoEndUsageMode.SelectedIndex = 0
        edWebMVideoThreadCount.Text = Environment.ProcessorCount.ToString(CultureInfo.InvariantCulture)
        cbWebMVideoEncoder.SelectedIndex = 0
        cbWebMVideoEndUsageMode.SelectedIndex = 0
        cbWebMVideoKeyframeMode.SelectedIndex = 0
        cbWebMVideoQualityMode.SelectedIndex = 0

        For Each item As String In VideoEdit1.Video_Codecs()
            cbVideoCodec.Items.Add(item)
            cbCustomVideoCodec.Items.Add(item)
        Next

        For Each item As String In VideoEdit1.Audio_Codecs()
            cbAudioCodec.Items.Add(item)
            cbAudioCodecs2.Items.Add(item)
            cbCustomAudioCodec.Items.Add(item)
        Next

        For Each item As String In VideoEdit1.DirectShow_Filters()
            cbCustomDSFilterV.Items.Add(item)
            cbCustomDSFilterA.Items.Add(item)
            cbCustomMuxer.Items.Add(item)
            cbCustomFilewriter.Items.Add(item)
            cbFilters.Items.Add(item)
        Next

        cbVideoCodec.SelectedIndex = 0
        cbCustomVideoCodec.SelectedIndex = 0
        cbCustomAudioCodec.SelectedIndex = 0
        cbCustomDSFilterV.SelectedIndex = 0
        cbCustomDSFilterA.SelectedIndex = 0
        cbCustomMuxer.SelectedIndex = 0
        cbCustomFilewriter.SelectedIndex = 0
        cbFilters.SelectedIndex = 0

        If (cbWMVAudioFormat.Items.Count > 0) Then
            cbWMVAudioFormat.SelectedIndex = 0
        End If

        For i As Integer = 0 To VideoEdit1.WMV_Internal_Profiles().Count - 1
            cbWMVInternalProfile9.Items.Add(VideoEdit1.WMV_Internal_Profiles().Item(i))
        Next
        cbWMVInternalProfile9.SelectedIndex = 0

        Dim names As List(Of String) = New List(Of String)

        Dim descs As List(Of String) = New List(Of String)

        VideoEdit1.WMV_V8_Profiles(names, descs)

        For i As Integer = 0 To names.Count - 1
            cbWMVInternalProfile8.Items.Add(names.Item(i))
        Next i

        cbWMVInternalProfile8.SelectedIndex = 0

        cbCustomVideoCodec_SelectedIndexChanged(sender, e)
        cbCustomAudioCodec_SelectedIndexChanged(sender, e)
        cbCustomMuxer_SelectedIndexChanged(sender, e)
        cbCustomDSFilterA_SelectedIndexChanged(sender, e)
        cbCustomDSFilterV_SelectedIndexChanged(sender, e)
        cbCustomFilewriter_SelectedIndexChanged(sender, e)

        cbVideoCodec_SelectedIndexChanged(sender, e)
        cbAudioCodec_SelectedIndexChanged(sender, e)
        cbAudioCodecs2_SelectedIndexChanged(sender, e)

        cbWMVAudioMode_SelectedIndexChanged(sender, e)
        cbWMVVideoMode_SelectedIndexChanged(sender, e)
        If cbWMVAudioCodec.Items.Count > 0 Then
            cbWMVAudioCodec.SelectedIndex = 0
        End If
        If cbWMVVideoCodec.Items.Count > 0 Then
            cbWMVVideoCodec.SelectedIndex = 0
        End If

        cbWMVAudioCodec_SelectedIndexChanged(sender, e)

        For i As Integer = 0 To VideoEdit1.Video_Transition_Names().Count - 1
            cbTransitionName.Items.Add(VideoEdit1.Video_Transition_Names().Item(i))
        Next
        cbTransitionName.SelectedIndex = 0

        For i As Integer = 0 To VideoEdit1.Audio_Effects_Equalizer_Presets().Count - 1
            cbAudEqualizerPreset.Items.Add(VideoEdit1.Audio_Effects_Equalizer_Presets().Item(i))
        Next

        If (cbAudioCodec.Items.IndexOf("PCM") <> -1) Then
            cbAudioCodec.SelectedIndex = cbAudioCodec.Items.IndexOf("PCM")
        End If

        If (cbAudioCodecs2.Items.IndexOf("PCM") <> -1) Then
            cbAudioCodecs2.SelectedIndex = cbAudioCodecs2.Items.IndexOf("PCM")
        End If

        If (cbVideoCodec.Items.IndexOf("MJPEG Compressor") <> -1) Then
            cbVideoCodec.SelectedIndex = cbVideoCodec.Items.IndexOf("MJPEG Compressor")
        End If

        Dim genres As List(Of String) = New List(Of String)
        For Each s As String In VideoCapture.Tags_GetDefaultAudioGenres
            genres.Add(s)
        Next

        For Each s As String In VideoCapture.Tags_GetDefaultVideoGenres
            genres.Add(s)
        Next

        genres.Sort()

        For Each genre As String In genres
            cbTagGenre.Items.Add(genre)
        Next

        cbTagGenre.Text = "Rock"

        ' ReSharper disable once CoVariantArrayConversion
        cbAudEqualizerPreset.Items.AddRange(VideoEdit1.Audio_Effects_Equalizer_Presets().ToArray())
        cbAudEqualizerPreset.SelectedIndex = 0

    End Sub

    Private Sub VideoEdit1_OnStop(ByVal sender As System.Object, ByVal e As VideoEditStopEventArgs) Handles VideoEdit1.OnStop

        ProgressBar1.Value = 0
        If (e.Successful) Then
            MessageBox.Show("Completed successfully", String.Empty, MessageBoxButtons.OK)
        Else
            MessageBox.Show("Stopped with error", String.Empty, MessageBoxButtons.OK)
        End If

        VideoEdit1.Input_Clear_List()
        lbFiles.Items.Clear()

        VideoEdit1.Video_Transition_Clear()
        lbTransitions.Items.Clear()

    End Sub

    Private Sub ConfigureDecklink()

        If cbDecklinkOutput.Checked Then
            VideoEdit1.Decklink_Output = New DecklinkOutputSettings()
            VideoEdit1.Decklink_Output.DVEncoding = cbDecklinkDV.Checked
            VideoEdit1.Decklink_Output.AnalogOutputIREUSA = cbDecklinkOutputNTSC.SelectedIndex = 0
            VideoEdit1.Decklink_Output.AnalogOutputSMPTE = cbDecklinkOutputComponentLevels.SelectedIndex = 0
            VideoEdit1.Decklink_Output.BlackToDeckInCapture = cbDecklinkOutputBlackToDeck.SelectedIndex
            VideoEdit1.Decklink_Output.DualLinkOutputMode = cbDecklinkOutputDualLink.SelectedIndex
            VideoEdit1.Decklink_Output.HDTVPulldownOnOutput = cbDecklinkOutputHDTVPulldown.SelectedIndex
            VideoEdit1.Decklink_Output.SingleFieldOutputForSynchronousFrames = cbDecklinkOutputSingleField.SelectedIndex
            VideoEdit1.Decklink_Output.VideoOutputDownConversionMode = cbDecklinkOutputDownConversion.SelectedIndex
            VideoEdit1.Decklink_Output.VideoOutputDownConversionModeAnalogUsed = cbDecklinkOutputDownConversionAnalogOutput.Checked
            VideoEdit1.Decklink_Output.AnalogOutput = cbDecklinkOutputAnalog.SelectedIndex
        Else
            VideoEdit1.Decklink_Output = Nothing
        End If

    End Sub

    Private Sub ConfigureObjectTracking()

        If (cbAFMotionDetection.Checked) Then
            VideoEdit1.Motion_DetectionEx = New MotionDetectionExSettings()
            If (cbAFMotionHighlight.Checked) Then
                VideoEdit1.Motion_DetectionEx.ProcessorType = MotionProcessorType.MotionAreaHighlighting
            Else
                VideoEdit1.Motion_DetectionEx.ProcessorType = MotionProcessorType.None
            End If
        Else
            VideoEdit1.Motion_DetectionEx = Nothing
        End If
    End Sub

    Private Sub FillLAMESettings(ByRef lameOutput As VFMP3Output)

        lameOutput.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text)
        lameOutput.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text)
        lameOutput.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text)
        lameOutput.SampleRate = Convert.ToInt32(cbLameSampleRate.Text)
        lameOutput.VBR_Quality = tbLameVBRQuality.Value
        lameOutput.EncodingQuality = tbLameEncodingQuality.Value

        If (rbLameStandardStereo.Checked) Then
            lameOutput.ChannelsMode = VFLameChannelsMode.StandardStereo
        ElseIf (rbLameJointStereo.Checked) Then
            lameOutput.ChannelsMode = VFLameChannelsMode.JointStereo
        ElseIf (rbLameDualChannels.Checked) Then
            lameOutput.ChannelsMode = VFLameChannelsMode.DualStereo
        Else
            lameOutput.ChannelsMode = VFLameChannelsMode.Mono
        End If

        lameOutput.VBR_Mode = rbLameVBR.Checked

        'Other
        lameOutput.Copyright = cbLameCopyright.Checked
        lameOutput.Original = cbLameOriginal.Checked
        lameOutput.CRCProtected = cbLameCRCProtected.Checked
        lameOutput.ForceMono = cbLameForceMono.Checked
        lameOutput.StrictlyEnforceVBRMinBitrate = cbLameStrictlyEnforceVBRMinBitrate.Checked
        lameOutput.VoiceEncodingMode = cbLameVoiceEncodingMode.Checked
        lameOutput.KeepAllFrequencies = cbLameKeepAllFrequences.Checked
        lameOutput.StrictISOCompliance = cbLameStrictISOCompilance.Checked
        lameOutput.DisableShortBlocks = cbLameDisableShortBlocks.Checked
        lameOutput.EnableXingVBRTag = cbLameEnableXingVBRTag.Checked
        lameOutput.ModeFixed = cbLameModeFixed.Checked

    End Sub

    Private Sub ConfigureVideoRenderer()

        If rbVMR9.Checked Then
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        ElseIf rbEVR.Checked Then
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf rbVR.Checked Then
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        ElseIf (rbDirect2D.Checked) Then
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D
        Else
            VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.None
        End If

        If (cbStretch.Checked) Then
            VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch
        Else
            VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox
        End If

        VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text)

        VideoEdit1.Video_Renderer.BackgroundColor = pnVideoRendererBGColor.BackColor
        VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked
        VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked

    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStart.Click

        zoom = 1.0
        zoomShiftX = 0
        zoomShiftY = 0

        mmLog.Clear()

        VideoEdit1.Debug_Mode = cbDebugMode.Checked

        VideoEdit1.Video_Effects_Clear()

        If (rbConvert.Checked) Then
            VideoEdit1.Mode = VFVideoEditMode.Convert
        Else
            VideoEdit1.Mode = VFVideoEditMode.Preview
        End If

        VideoEdit1.Video_Resize = cbResize.Checked

        If (VideoEdit1.Video_Resize) Then

            VideoEdit1.Video_Resize_Width = Convert.ToInt32(edWidth.Text)
            VideoEdit1.Video_Resize_Height = Convert.ToInt32(edHeight.Text)

        End If

        If (cbCrop.Checked) Then
            VideoEdit1.Video_Crop = New VideoCropSettings(
                    Convert.ToInt32(edCropLeft.Text),
                    Convert.ToInt32(edCropTop.Text),
                    Convert.ToInt32(edCropRight.Text),
                    Convert.ToInt32(edCropBottom.Text))
        Else
            VideoEdit1.Video_Crop = Nothing
        End If

        If (cbSubtitlesEnabled.Checked) Then
            VideoEdit1.Video_Subtitles = New SubtitlesSettings(edSubtitlesFilename.Text)
        Else
            VideoEdit1.Video_Subtitles = Nothing
        End If

        VideoEdit1.Video_FrameRate = Convert.ToDouble(cbFrameRate.Text)

        ConfigureVideoRenderer()

        ' Network streaming
        VideoEdit1.Network_Streaming_Enabled = cbNetworkStreaming.Checked

        If VideoEdit1.Network_Streaming_Enabled Then

            Select Case (cbNetworkStreamingMode.SelectedIndex)

                Case 0
                    VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.WMV

                    If (rbNetworkStreamingUseMainWMVSettings.Checked) Then

                        Dim wmvOutput As VFWMVOutput = New VFWMVOutput()
                        FillWMVSettings(wmvOutput)
                        VideoEdit1.Network_Streaming_Output = wmvOutput

                    Else

                        Dim wmvOutput As VFWMVOutput = New VFWMVOutput()
                        wmvOutput.Mode = VFWMVMode.ExternalProfile
                        wmvOutput.External_Profile_FileName = edNetworkStreamingWMVProfile.Text
                        VideoEdit1.Network_Streaming_Output = wmvOutput

                    End If

                    VideoEdit1.Network_Streaming_WMV_Maximum_Clients = Convert.ToInt32(edMaximumClients.Text)
                    VideoEdit1.Network_Streaming_Network_Port = Convert.ToInt32(edWMVNetworkPort.Text)

                Case 1

                    VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.RTSP_H264_AAC_SW
                    VideoEdit1.Network_Streaming_URL = edNetworkRTSPURL.Text

                Case 2

                    VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.RTMP_FFMPEG_EXE

                    Dim ffmpegOutput As VFFFMPEGEXEOutput = New VFFFMPEGEXEOutput()

                    If (rbNetworkUDPFFMPEG.Checked) Then

                        ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, True)

                    Else

                        FillFFMPEGEXESettings(ffmpegOutput)

                    End If

                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLV

                    VideoEdit1.Network_Streaming_Output = ffmpegOutput
                    VideoEdit1.Network_Streaming_URL = edNetworkRTMPURL.Text

                Case 3

                    VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.UDP_FFMPEG_EXE

                    Dim ffmpegOutput As VFFFMPEGEXEOutput = New VFFFMPEGEXEOutput()

                    If (rbNetworkUDPFFMPEG.Checked) Then

                        ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, True)

                    Else

                        FillFFMPEGEXESettings(ffmpegOutput)

                    End If

                    ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS
                    VideoEdit1.Network_Streaming_Output = ffmpegOutput

                    VideoEdit1.Network_Streaming_URL = edNetworkUDPURL.Text

                Case 4

                    If (rbNetworkSSSoftware.Checked) Then

                        VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_H264_AAC_SW

                    Else

                        VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.SSF_FFMPEG_EXE

                        Dim ffmpegOutput As VFFFMPEGEXEOutput = New VFFFMPEGEXEOutput()

                        If (rbNetworkSSFFMPEGDefault.Checked) Then

                            ffmpegOutput.FillDefaults(VFFFMPEGEXEDefaultsProfile.MP4_H264_AAC, True)

                        Else

                            FillFFMPEGEXESettings(ffmpegOutput)

                        End If

                        ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ISMV
                        VideoEdit1.Network_Streaming_Output = ffmpegOutput

                    End If

                    VideoEdit1.Network_Streaming_URL = edNetworkSSURL.Text

                Case 5

                    VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.External

            End Select

            VideoEdit1.Network_Streaming_Audio_Enabled = cbNetworkStreamingAudioEnabled.Checked

        End If

        VideoEdit1.Output_Filename = edOutput.Text

        Dim outputFormat = VFVideoEditOutputFormat.AVI
        Select Case cbOutputVideoFormat.SelectedIndex
            Case 0
                outputFormat = VFVideoEditOutputFormat.AVI
            Case 1
                outputFormat = VFVideoEditOutputFormat.MKV
            Case 2
                outputFormat = VFVideoEditOutputFormat.WMV

                Dim wmvOutput As VFWMVOutput = New VFWMVOutput()
                FillWMVSettings(wmvOutput)
                VideoEdit1.Output_Format = wmvOutput
            Case 3
                outputFormat = VFVideoEditOutputFormat.DV
            Case 4
                outputFormat = VFVideoEditOutputFormat.PCM_ACM
            Case 5
                outputFormat = VFVideoEditOutputFormat.LAME
            Case 6
                outputFormat = VFVideoEditOutputFormat.M4A
            Case 7
                outputFormat = VFVideoEditOutputFormat.WMA

                Dim wmvOutput As VFWMVOutput = New VFWMVOutput()
                FillWMVSettings(wmvOutput)
                VideoEdit1.Output_Format = wmvOutput
            Case 8
                outputFormat = VFVideoEditOutputFormat.OggVorbis
            Case 9
                outputFormat = VFVideoEditOutputFormat.FLAC
            Case 10
                outputFormat = VFVideoEditOutputFormat.Speex
            Case 11
                outputFormat = VFVideoEditOutputFormat.Custom
            Case 12
                outputFormat = VFVideoEditOutputFormat.WebM
            Case 13
                outputFormat = VFVideoEditOutputFormat.FFMPEG_DLL
            Case 14
                outputFormat = VFVideoEditOutputFormat.MP4
            Case 15
                outputFormat = VFVideoEditOutputFormat.AnimatedGIF
            Case 16
                outputFormat = VFVideoEditOutputFormat.Encrypted
        End Select

        If (outputFormat = VFVideoEditOutputFormat.AVI) Then

            Dim aviOutput As VFAVIOutput = New VFAVIOutput()
            aviOutput.ACM.Name = cbAudioCodec.Text
            aviOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text)
            aviOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text)
            aviOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text)
            aviOutput.Video_Codec = cbVideoCodec.Text

            If (cbUseLameInAVI.Checked) Then

                aviOutput.Audio_UseMP3Encoder = True

                Dim lameOutput as VFMP3Output = New VFMP3Output()
                FillLAMESettings(lameOutput)
                aviOutput.MP3 = lameOutput

            End If

            VideoEdit1.Output_Format = aviOutput

        elseIf (outputFormat = VFVideoEditOutputFormat.MKV) Then

            Dim mkvOutput As VFMKVOutput = New VFMKVOutput()
            mkvOutput.ACM.Name = cbAudioCodec.Text
            mkvOutput.ACM.Channels = Convert.ToInt32(cbChannels.Text)
            mkvOutput.ACM.BPS = Convert.ToInt32(cbBPS.Text)
            mkvOutput.ACM.SampleRate = Convert.ToInt32(cbSampleRate.Text)
            mkvOutput.Video_Codec = cbVideoCodec.Text

            If (cbUseLameInAVI.Checked) Then

                mkvOutput.Audio_UseMP3Encoder = True

                Dim lameOutput As VFMP3Output = New VFMP3Output()
                FillLAMESettings(lameOutput)
                mkvOutput.MP3 = lameOutput

            End If

            VideoEdit1.Output_Format = mkvOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.WMA) Then
            'WMA

            Dim wmvOutput As VFWMVOutput = VideoEdit1.Output_Format
            wmvOutput.External_Profile_FileName = edWMVProfile.Text
            VideoEdit1.Output_Format = wmvOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.DV) Then
            'DV

            Dim dvOutput As VFDVOutput = New VFDVOutput()

            dvOutput.Audio_Channels = Convert.ToInt32(cbDVChannels.Text)
            dvOutput.Audio_SampleRate = Convert.ToInt32(cbDVSampleRate.Text)

            If (rbDVPAL.Checked) Then
                dvOutput.Video_Format = VFDVVideoFormat.PAL
            Else
                dvOutput.Video_Format = VFDVVideoFormat.NTSC
            End If

            dvOutput.Type2 = rbDVType2.Checked

            VideoEdit1.Output_Format = dvOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.Custom) Then

            Dim customOutput As VFCustomOutput = New VFCustomOutput()

            If (rbCustomUseVideoCodecsCat.Checked) Then

                customOutput.Video_Codec = cbCustomVideoCodec.Text
                customOutput.Video_Codec_UseFiltersCategory = False
            Else
                customOutput.Video_Codec = cbCustomDSFilterV.Text
                customOutput.Video_Codec_UseFiltersCategory = True
            End If

            If (rbCustomUseAudioCodecsCat.Checked) Then
                customOutput.Audio_Codec = cbCustomAudioCodec.Text
                customOutput.Audio_Codec_UseFiltersCategory = False
            Else
                customOutput.Audio_Codec = cbCustomDSFilterA.Text
                customOutput.Audio_Codec_UseFiltersCategory = True
            End If

            customOutput.MuxFilter_Name = cbCustomMuxer.Text
            customOutput.SpecialFileWriter_Needed = cbUseSpecialFilewriter.Checked
            customOutput.SpecialFileWriter_FilterName = cbCustomFilewriter.Text
            customOutput.MuxFilter_IsEncoder = cbCustomMuxFilterIsEncoder.Checked

            VideoEdit1.Output_Format = customOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.PCM_ACM) Then

            Dim acmOutput As VFACMOutput = New VFACMOutput()

            acmOutput.Channels = Convert.ToInt32(cbChannels2.Text)
            acmOutput.BPS = Convert.ToInt32(cbBPS2.Text)
            acmOutput.SampleRate = Convert.ToInt32(cbSampleRate2.Text)
            acmOutput.Name = cbAudioCodecs2.Text

            VideoEdit1.Output_Format = acmOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.OggVorbis) Then

            Dim oggVorbisOutput As VFOGGVorbisOutput = New VFOGGVorbisOutput()

            oggVorbisOutput.Quality = Convert.ToInt32(edOGGQuality.Text)
            oggVorbisOutput.MinBitRate = Convert.ToInt32(cbOGGMinimum.Text)
            oggVorbisOutput.MaxBitRate = Convert.ToInt32(cbOGGMaximum.Text)
            oggVorbisOutput.AvgBitRate = Convert.ToInt32(cbOGGAverage.Text)

            If (rbOGGQuality.Checked) Then
                oggVorbisOutput.Mode = VFVorbisMode.Quality
            Else
                oggVorbisOutput.Mode = VFVorbisMode.Bitrate
            End If

            VideoEdit1.Output_Format = oggVorbisOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.M4A) Then

            Dim m4aOutput As VFM4AOutput = New VFM4AOutput()

            Dim tmp As Int32
            Int32.TryParse(cbM4ABitrate.Text, tmp)
            m4aOutput.Bitrate = tmp
            m4aOutput.Version = cbM4AVersion.SelectedIndex
            m4aOutput.Output = cbM4AOutput.SelectedIndex
            m4aOutput.Object = cbM4AObjectType.SelectedIndex + 1

            VideoEdit1.Output_Format = m4aOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.Speex) Then

            Dim speexOutput As VFSpeexOutput = New VFSpeexOutput()

            speexOutput.BitRate = tbSpeexBitrate.Value
            speexOutput.BitrateControl = cbSpeexBitrateControl.SelectedIndex
            speexOutput.Mode = cbSpeexMode.SelectedIndex
            speexOutput.MaxBitRate = tbSpeexMaxBitrate.Value
            speexOutput.Complexity = tbSpeexComplexity.Value
            speexOutput.Quality = tbSpeexQuality.Value
            speexOutput.UseAGC = cbSpeexAGC.Checked
            speexOutput.UseDTX = cbSpeexDTX.Checked
            speexOutput.UseDenoise = cbSpeexDenoise.Checked
            speexOutput.UseVAD = cbSpeexVAD.Checked

            VideoEdit1.Output_Format = speexOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.AnimatedGIF) Then

            Dim gifOutput As VFAnimatedGIFOutput = New VFAnimatedGIFOutput()

            gifOutput.FrameRate = Convert.ToDouble(edGIFFrameRate.Text)
            gifOutput.ForcedVideoWidth = Convert.ToInt32(edGIFWidth.Text)
            gifOutput.ForcedVideoHeight = Convert.ToInt32(edGIFHeight.Text)

            VideoEdit1.Output_Format = gifOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.FLAC) Then

            Dim flacOutput As VFFLACOutput = New VFFLACOutput()

            flacOutput.Level = tbFLACLevel.Value
            flacOutput.BlockSize = Convert.ToInt32(cbFLACBlockSize.Text)
            flacOutput.AdaptiveMidSideCoding = cbFLACAdaptiveMidSideCoding.Checked
            flacOutput.ExhaustiveModelSearch = cbFLACExhaustiveModelSearch.Checked
            flacOutput.LPCOrder = tbFLACLPCOrder.Value
            flacOutput.MidSideCoding = cbFLACMidSideCoding.Checked
            flacOutput.RiceMin = Convert.ToInt32(edFLACRiceMin.Text)
            flacOutput.RiceMax = Convert.ToInt32(edFLACRiceMax.Text)

            VideoEdit1.Output_Format = flacOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.LAME) Then

            Dim lameOutput As VFMP3Output = New VFMP3Output()
            FillLAMESettings(lameOutput)
            VideoEdit1.Output_Format = lameOutput

        ElseIf outputFormat = VFVideoEditOutputFormat.WebM Then

            Dim webmOutput As VFWebMOutput = New VFWebMOutput()

            webmOutput.Audio_Quality = tbWebMAudioQuality.Value

            webmOutput.Video_Bitrate = Convert.ToInt32(edWebMVideoBitrate.Text)
            webmOutput.Video_ARNR_MaxFrames = Convert.ToInt32(edWebMVideoARNRMaxFrames.Text)
            webmOutput.Video_ARNR_Strength = Convert.ToInt32(edWebMVideoARNRStrenght.Text)
            webmOutput.Video_ARNR_Type = Convert.ToInt32(edWebMVideoARNRType.Text)
            webmOutput.Video_CPUUsed = Convert.ToInt32(edWebMVideoCPUUsed.Text)
            webmOutput.Video_Decimate = Convert.ToInt32(edWebMVideoDecimate.Text)
            webmOutput.Video_Decoder_Buffer_Size = Convert.ToInt32(edWebMVideoDecoderBufferSize.Text)
            webmOutput.Video_Decoder_Buffer_InitialSize = Convert.ToInt32(edWebMVideoDecoderInitialBuffer.Text)
            webmOutput.Video_Decoder_Buffer_OptimalSize = Convert.ToInt32(edWebMVideoDecoderOptimalBuffer.Text)
            webmOutput.Video_FixedKeyframeInterval = Convert.ToInt32(edWebMVideoFixedKeyframeInterval.Text)
            webmOutput.Video_Keyframe_MaxInterval = Convert.ToInt32(edWebMVideoKeyframeMaxInterval.Text)
            webmOutput.Video_Keyframe_MinInterval = Convert.ToInt32(edWebMVideoKeyframeMinInterval.Text)
            webmOutput.Video_LagInFrames = Convert.ToInt32(edWebMVideoLagInFrames.Text)
            webmOutput.Video_MaxQuantizer = Convert.ToInt32(edWebMVideoMaxQuantizer.Text)
            webmOutput.Video_MinQuantizer = Convert.ToInt32(edWebMVideoMinQuantizer.Text)
            webmOutput.Video_OvershootPct = Convert.ToInt32(edWebMVideoOvershootPct.Text)
            webmOutput.Video_SpatialResampling_DownThreshold = Convert.ToInt32(edWebMVideoSpatialDownThreshold.Text)
            webmOutput.Video_SpatialResampling_UpThreshold = Convert.ToInt32(edWebMVideoSpatialUpThreshold.Text)
            webmOutput.Video_StaticThreshold = Convert.ToInt32(edWebMVideoStaticThreshold.Text)
            webmOutput.Video_ThreadCount = Convert.ToInt32(edWebMVideoThreadCount.Text)
            webmOutput.Video_TokenPartition = Convert.ToInt32(edWebMVideoTokenPartition.Text)
            webmOutput.Video_UndershootPct = Convert.ToInt32(edWebMVideoUndershootPct.Text)
            webmOutput.Video_AutoAltRef = cbWebMVideoAutoAltRef.Checked
            webmOutput.Video_ErrorResilient = cbWebMVideoErrorResilent.Checked
            webmOutput.Video_SpatialResampling_Allowed = cbWebMVideoSpatialResamplingAllowed.Checked
            webmOutput.Video_Encoder = cbWebMVideoEncoder.SelectedIndex

            Select Case cbWebMVideoEndUsageMode.SelectedIndex
                Case 0
                    webmOutput.Video_EndUsage = VP8EndUsageMode.Default
                Case 1
                    webmOutput.Video_EndUsage = VP8EndUsageMode.CBR
                Case 2
                    webmOutput.Video_EndUsage = VP8EndUsageMode.VBR
            End Select

            Select Case cbWebMVideoQualityMode.SelectedIndex
                Case 0
                    webmOutput.Video_Mode = VP8QualityMode.Realtime
                Case 1
                    webmOutput.Video_Mode = VP8QualityMode.GoodQuality
                Case 2
                    webmOutput.Video_Mode = VP8QualityMode.BestQualityBetaDoNotUse
            End Select

            Select Case cbWebMVideoKeyframeMode.SelectedIndex
                Case 0
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Auto
                Case 1
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Default
                Case 2
                    webmOutput.Video_Keyframe_Mode = VP8KeyframeMode.Disabled
            End Select

            VideoEdit1.Output_Format = webmOutput

        ElseIf (outputFormat = VFVideoEditOutputFormat.FFMPEG_DLL) Then

            Dim ffmpegDLLOutput As VFFFMPEGDLLOutput = New VFFFMPEGDLLOutput()

            Select Case (cbFFOutputFormat.SelectedIndex)

                Case 0
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG1

                Case 1
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG1VCD

                Case 2
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2

                Case 3
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2SVCD

                Case 4
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2DVD

                Case 5
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.MPEG2TS

                Case 6
                    ffmpegDLLOutput.OutputFormat = VFFFMPEGDLLOutputFormat.FLV

            End Select

            Select Case (cbFFAspectRatio.SelectedIndex)

                Case 0
                    ffmpegDLLOutput.Video_AspectRatio_W = 0
                    ffmpegDLLOutput.Video_AspectRatio_H = 1

                Case 1
                    ffmpegDLLOutput.Video_AspectRatio_W = 1
                    ffmpegDLLOutput.Video_AspectRatio_H = 1

                Case 2
                    ffmpegDLLOutput.Video_AspectRatio_W = 4
                    ffmpegDLLOutput.Video_AspectRatio_H = 3

                Case 3
                    ffmpegDLLOutput.Video_AspectRatio_W = 16
                    ffmpegDLLOutput.Video_AspectRatio_H = 9

            End Select

            Select Case (cbFFConstaint.SelectedIndex)

                Case 0
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.None

                Case 1
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.PAL

                Case 2
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.NTSC

                Case 3
                    ffmpegDLLOutput.Video_TVSystem = VFFFMPEGDLLTVSystem.Film

            End Select

            ffmpegDLLOutput.Video_Width = Convert.ToInt32(edFFVideoWidth.Text)
            ffmpegDLLOutput.Video_Height = Convert.ToInt32(edFFVideoHeight.Text)
            ffmpegDLLOutput.Video_Bitrate = Convert.ToInt32(edFFTargetBitrate.Text) * 1000
            ffmpegDLLOutput.Video_MaxBitrate = Convert.ToInt32(edFFVideoBitrateMax.Text) * 1000
            ffmpegDLLOutput.Video_MinBitrate = Convert.ToInt32(edFFVideoBitrateMin.Text) * 1000
            ffmpegDLLOutput.Video_BufferSize = Convert.ToInt32(edFFVBVBufferSize.Text)
            ffmpegDLLOutput.Audio_Channels = Convert.ToInt32(cbFFAudioChannels.Text)
            ffmpegDLLOutput.Audio_SampleRate = Convert.ToInt32(cbFFAudioSampleRate.Text)
            ffmpegDLLOutput.Audio_Bitrate = Convert.ToInt32(cbFFAudioBitrate.Text) * 1000
            ffmpegDLLOutput.Video_Interlace = cbFFVideoInterlace.Checked

            VideoEdit1.Output_Format = ffmpegDLLOutput

        ElseIf ((outputFormat = VFVideoEditOutputFormat.MP4) Or
            ((outputFormat = VFVideoEditOutputFormat.Encrypted) And (rbEncryptedH264SW.Checked)) Or
                    (VideoEdit1.Network_Streaming_Enabled And (VideoEdit1.Network_Streaming_Format = VFNetworkStreamingFormat.RTSP_H264_AAC_SW))) Then

            Dim tmp = 0

            Dim mp4Output As VFMP4Output = New VFMP4Output()

            ' Main settings
            Select Case (cbMP4Mode.SelectedIndex)
                Case 0
                    ' v8 Legacy(XP compatible, CPU Or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v8
                Case 1
                    ' v10(CPU Or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v10
                Case 2
                    ' v10 nVidia NVENC
                    mp4Output.MP4Mode = VFMP4Mode.v10_NVENC
                Case Else
                    mp4Output.MP4Mode = VFMP4Mode.v11
            End Select

            If (mp4Output.MP4Mode = VFMP4Mode.v8 Or mp4Output.MP4Mode = VFMP4Mode.v10) Then
                ' Video H264 settings
                Select Case (cbH264Profile.SelectedIndex)

                    Case 0
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileAuto

                    Case 1
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileBaseline

                    Case 2
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileMain

                    Case 3
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh

                    Case 4
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh10

                    Case 5
                        mp4Output.Video_v10.Profile = VFH264Profile.ProfileHigh422


                End Select

                Select Case (cbH264Level.SelectedIndex)

                    Case 0
                        mp4Output.Video_v10.Level = VFH264Level.LevelAuto

                    Case 1
                        mp4Output.Video_v10.Level = VFH264Level.Level1

                    Case 2
                        mp4Output.Video_v10.Level = VFH264Level.Level11

                    Case 3
                        mp4Output.Video_v10.Level = VFH264Level.Level12

                    Case 4
                        mp4Output.Video_v10.Level = VFH264Level.Level13

                    Case 5
                        mp4Output.Video_v10.Level = VFH264Level.Level2

                    Case 6
                        mp4Output.Video_v10.Level = VFH264Level.Level21

                    Case 7
                        mp4Output.Video_v10.Level = VFH264Level.Level22

                    Case 8
                        mp4Output.Video_v10.Level = VFH264Level.Level3

                    Case 9
                        mp4Output.Video_v10.Level = VFH264Level.Level31

                    Case 10
                        mp4Output.Video_v10.Level = VFH264Level.Level32

                    Case 11
                        mp4Output.Video_v10.Level = VFH264Level.Level4

                    Case 12
                        mp4Output.Video_v10.Level = VFH264Level.Level41

                    Case 13
                        mp4Output.Video_v10.Level = VFH264Level.Level42

                    Case 14
                        mp4Output.Video_v10.Level = VFH264Level.Level5

                    Case 15
                        mp4Output.Video_v10.Level = VFH264Level.Level51

                End Select

                Select Case (cbH264TargetUsage.SelectedIndex)

                    Case 0
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.Auto

                    Case 1
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.BestQuality

                    Case 2
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.Balanced

                    Case 3
                        mp4Output.Video_v10.TargetUsage = VFH264TargetUsage.BestSpeed

                End Select

                Select Case (cbH264PictureType.SelectedIndex)

                    Case 0
                        mp4Output.Video_v10.PictureType = VFH264PictureType.Auto

                    Case 1
                        mp4Output.Video_v10.PictureType = VFH264PictureType.Frame

                    Case 2
                        mp4Output.Video_v10.PictureType = VFH264PictureType.TFF

                    Case 3
                        mp4Output.Video_v10.PictureType = VFH264PictureType.BFF

                End Select

                mp4Output.Video_v10.RateControl = cbH264RateControl.SelectedIndex
                mp4Output.Video_v10.MBEncoding = cbH264MBEncoding.SelectedIndex
                mp4Output.Video_v10.GOP = cbH264GOP.Checked
                mp4Output.Video_v10.BitrateAuto = cbH264AutoBitrate.Checked

                Int32.TryParse(edH264IDR.Text, tmp)
                mp4Output.Video_v10.IDR_Period = tmp

                Int32.TryParse(edH264P.Text, tmp)
                mp4Output.Video_v10.P_Period = tmp

                Int32.TryParse(edH264Bitrate.Text, tmp)
                mp4Output.Video_v10.Bitrate = tmp

            ElseIf (mp4Output.MP4Mode = VFMP4Mode.v10_NVENC) Then

                ' NVENC settings
                Select Case (cbNVENCProfile.SelectedIndex)
                    Case 0
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.Auto
                    Case 1
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Baseline
                    Case 2
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Main
                    Case 3
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High
                    Case 4
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High444
                    Case 5
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ProgressiveHigh
                    Case 6
                        mp4Output.Video_v10_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ConstrainedHigh
                End Select

                Select Case (cbNVENCLevel.SelectedIndex)
                    Case 0
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.Auto
                    Case 1
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_1
                    Case 2
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_11
                    Case 3
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_12
                    Case 4
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_13
                    Case 5
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_2
                    Case 6
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_21
                    Case 7
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_22
                    Case 8
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_3
                    Case 9
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_31
                    Case 10
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_32
                    Case 11
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_4
                    Case 12
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_41
                    Case 13
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_42
                    Case 14
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_5
                    Case 15
                        mp4Output.Video_v10_NVENC.Level = VFNVENCEncoderLevel.H264_51
                End Select

                mp4Output.Video_v10_NVENC.Bitrate = Convert.ToInt32(edNVENCBitrate.Text)
                mp4Output.Video_v10_NVENC.QP = Convert.ToInt32(edNVENCQP.Text)
                mp4Output.Video_v10_NVENC.RateControl = cbNVENCRateControl.SelectedIndex
                mp4Output.Video_v10_NVENC.GOP = Convert.ToInt32(edNVENCGOP.Text)
                mp4Output.Video_v10_NVENC.BFrames = Convert.ToInt32(edNVENCBFrames.Text)
            Else
                Select Case (cbMP4Mode.SelectedIndex)
                    Case 3
                        '  v11 (CPU) H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.MS_H264
                    Case 4
                        '  v11 nVidia NVENC H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.NVENC_H264
                    Case 5
                        '  v11 Intel QuickSync H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.QSV_H264
                    Case 6
                        '  v11 AMD Radeon H264
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.AMD_H264
                    Case 7
                        '  v11 nVidia NVENC H265
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.NVENC_H265
                    Case 8
                        '  v11 AMD Radeon H265
                        mp4Output.Video_v11.Codec = VFMFVideoEncoder.AMD_H265
                End Select

                ' Video H264 settings
                Select Case (cbMFProfile.SelectedIndex)
                    Case 0
                        mp4Output.Video_v11.Profile = VFMFH264Profile.Base
                    Case 1
                        mp4Output.Video_v11.Profile = VFMFH264Profile.Main
                    Case 2
                        mp4Output.Video_v11.Profile = VFMFH264Profile.High
                End Select

                Select Case (cbMFLevel.SelectedIndex)
                    Case 0
                        mp4Output.Video_v11.Level = VFMFH264Level.Level1
                    Case 1
                        mp4Output.Video_v11.Level = VFMFH264Level.Level11
                    Case 2
                        mp4Output.Video_v11.Level = VFMFH264Level.Level12
                    Case 3
                        mp4Output.Video_v11.Level = VFMFH264Level.Level13
                    Case 4
                        mp4Output.Video_v11.Level = VFMFH264Level.Level2
                    Case 5
                        mp4Output.Video_v11.Level = VFMFH264Level.Level21
                    Case 6
                        mp4Output.Video_v11.Level = VFMFH264Level.Level22
                    Case 7
                        mp4Output.Video_v11.Level = VFMFH264Level.Level3
                    Case 8
                        mp4Output.Video_v11.Level = VFMFH264Level.Level31
                    Case 9
                        mp4Output.Video_v11.Level = VFMFH264Level.Level32
                    Case 10
                        mp4Output.Video_v11.Level = VFMFH264Level.Level4
                    Case 11
                        mp4Output.Video_v11.Level = VFMFH264Level.Level41
                    Case 12
                        mp4Output.Video_v11.Level = VFMFH264Level.Level42
                    Case 13
                        mp4Output.Video_v11.Level = VFMFH264Level.Level5
                    Case 14
                        mp4Output.Video_v11.Level = VFMFH264Level.Level51
                    Case 15
                        mp4Output.Video_v11.Level = VFMFH264Level.Level51
                End Select

                mp4Output.Video_v11.RateControl = cbMFRateControl.SelectedIndex

                mp4Output.Video_v11.CABAC = cbMFCABAC.Checked
                mp4Output.Video_v11.LowLatencyMode = cbMFLowLatency.Checked

                Int32.TryParse(edMFBFramesCount.Text, tmp)
                mp4Output.Video_v11.DefaultBPictureCount = tmp

                Int32.TryParse(edMFKeyFrameSpacing.Text, tmp)
                mp4Output.Video_v11.MaxKeyFrameSpacing = tmp

                Int32.TryParse(edMFBitrate.Text, tmp)
                mp4Output.Video_v11.AvgBitrate = tmp

                Int32.TryParse(edMFMaxBitrate.Text, tmp)
                mp4Output.Video_v11.MaxBitrate = tmp

                Int32.TryParse(edMFQuality.Text, tmp)
                mp4Output.Video_v11.Quality = tmp
            End If

            ' Audio AAC settings
            Int32.TryParse(cbAACBitrate.Text, tmp)
            mp4Output.Audio_AAC.Bitrate = tmp

            mp4Output.Audio_AAC.Version = cbAACVersion.SelectedIndex
            mp4Output.Audio_AAC.Output = cbAACOutput.SelectedIndex
            mp4Output.Audio_AAC.Object = (cbAACObjectType.SelectedIndex + 1)

            ' encryption
            If (outputFormat = VFVideoEditOutputFormat.Encrypted) Then

                mp4Output.Encryption = True
                mp4Output.Encryption_Format = VFEncryptionFormat.MP4_H264_SW_AAC

                If (rbEncryptionKeyString.Checked) Then

                    mp4Output.Encryption_KeyType = VFEncryptionKeyType.String
                    mp4Output.Encryption_Key = edEncryptionKeyString.Text

                ElseIf (rbEncryptionKeyFile.Checked) Then

                    mp4Output.Encryption_KeyType = VFEncryptionKeyType.File
                    mp4Output.Encryption_Key = edEncryptionKeyFile.Text

                Else

                    mp4Output.Encryption_KeyType = VFEncryptionKeyType.Binary
                    mp4Output.Encryption_Key = VideoCapture.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text)

                End If

                If (rbEncryptionModeAES128.Checked) Then
                    mp4Output.Encryption_Mode = VFEncryptionMode.v8_AES128
                Else
                    mp4Output.Encryption_Mode = VFEncryptionMode.v9_AES256
                End If
            End If

            VideoEdit1.Output_Format = mp4Output

        End If

        VideoEdit1.Audio_Preview_Enabled = True

        ' Audio enhancement
        VideoEdit1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.Checked
        If (VideoEdit1.Audio_Enhancer_Enabled) Then

            VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked)
            VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked)

            ApplyAudioInputGains()
            ApplyAudioOutputGains()

            VideoEdit1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value)

        End If

        ' Audio channels mapping
        If (cbAudioChannelMapperEnabled.Checked) Then
            VideoEdit1.Audio_Channel_Mapper = New AudioChannelMapperSettings()
            VideoEdit1.Audio_Channel_Mapper.Routes = audioChannelMapperItems.ToArray()
            VideoEdit1.Audio_Channel_Mapper.OutputChannelsCount = Convert.ToInt32(edAudioChannelMapperOutputChannels.Text)
        Else
            VideoEdit1.Audio_Channel_Mapper = Nothing
        End If

        'Audio processing
        VideoEdit1.Audio_Effects_Clear(-1)
        VideoEdit1.Audio_Effects_Enabled = cbAudioEffectsEnabled.Checked
        If (VideoEdit1.Audio_Effects_Enabled) Then

            VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1)
            VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1)
            VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.Checked, -1, -1)
            VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1)
            VideoEdit1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1)

            tbAudAmplifyAmp_Scroll(sender, e)
            tbAudDynAmp_Scroll(sender, e)
            tbAudAttack_Scroll(sender, e)
            tbAudRelease_Scroll(sender, e)
            tbAud3DSound_Scroll(sender, e)
            tbAudTrueBass_Scroll(sender, e)

            tbAudEq0_Scroll(sender, e)
            tbAudEq1_Scroll(sender, e)
            tbAudEq2_Scroll(sender, e)
            tbAudEq3_Scroll(sender, e)
            tbAudEq4_Scroll(sender, e)
            tbAudEq5_Scroll(sender, e)
            tbAudEq6_Scroll(sender, e)
            tbAudEq7_Scroll(sender, e)
            tbAudEq8_Scroll(sender, e)
            tbAudEq9_Scroll(sender, e)

        End If

        ' Virtual camera output
        VideoEdit1.Virtual_Camera_Output_Enabled = cbVirtualCamera.Checked

        VideoEdit1.Video_Effects_Enabled = cbEffects.Checked
        VideoEdit1.Video_Effects_Clear()

        'Deinterlace
        If cbDeinterlace.Checked Then

            If rbDeintBlendEnabled.Checked Then
                Dim blend As IVFVideoEffectDeinterlaceBlend
                Dim effect = VideoEdit1.Video_Effects_Get("DeinterlaceBlend")
                If (IsNothing(effect)) Then
                    blend = New VFVideoEffectDeinterlaceBlend(True)
                    VideoEdit1.Video_Effects_Add(blend)
                Else
                    blend = effect
                End If

                If (IsNothing(blend)) Then

                    MessageBox.Show("Unable to configure deinterlace blend effect.")
                    Return
                End If

                blend.Threshold1 = Convert.ToInt32(edDeintBlendThreshold1.Text)
                blend.Threshold2 = Convert.ToInt32(edDeintBlendThreshold2.Text)
                blend.Constants1 = Convert.ToInt32(edDeintBlendConstants1.Text) / 10.0
                blend.Constants2 = Convert.ToInt32(edDeintBlendConstants2.Text) / 10.0
            ElseIf (rbDeintCAVTEnabled.Checked) Then
                Dim cavt As IVFVideoEffectDeinterlaceCAVT
                Dim effect = VideoEdit1.Video_Effects_Get("DeinterlaceCAVT")
                If (IsNothing(effect)) Then
                    cavt = New VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.Checked, Convert.ToInt32(edDeintCAVTThreshold.Text))
                    VideoEdit1.Video_Effects_Add(cavt)
                Else
                    cavt = effect
                End If

                If (IsNothing(cavt)) Then
                    MessageBox.Show("Unable to configure deinterlace CAVT effect.")
                    Return
                End If

                cavt.Threshold = Convert.ToInt32(edDeintCAVTThreshold.Text)
            Else
                Dim triangle As IVFVideoEffectDeinterlaceTriangle
                Dim effect = VideoEdit1.Video_Effects_Get("DeinterlaceTriangle")
                If (IsNothing(effect)) Then
                    triangle = New VFVideoEffectDeinterlaceTriangle(True, Convert.ToByte(edDeintTriangleWeight.Text))
                    VideoEdit1.Video_Effects_Add(triangle)
                Else
                    triangle = effect
                End If

                If (IsNothing(triangle)) Then
                    MessageBox.Show("Unable to configure deinterlace triangle effect.")
                    Return
                End If

                triangle.Weight = Convert.ToByte(edDeintTriangleWeight.Text)
            End If

        End If

        'Denoise
        If cbDenoise.Checked And VideoEdit1.Mode Then

            If (rbDenoiseCAST.Checked) Then
                Dim cast As IVFVideoEffectDenoiseCAST
                Dim effect = VideoEdit1.Video_Effects_Get("DenoiseCAST")
                If (IsNothing(effect)) Then
                    cast = New VFVideoEffectDenoiseCAST(True)
                    VideoEdit1.Video_Effects_Add(cast)
                Else
                    cast = effect
                End If

                If (IsNothing(cast)) Then
                    MessageBox.Show("Unable to configure denoise CAST effect.")
                    Return
                End If
            Else
                Dim mosquito As IVFVideoEffectDenoiseMosquito
                Dim effect = VideoEdit1.Video_Effects_Get("DenoiseMosquito")
                If (IsNothing(effect)) Then
                    mosquito = New VFVideoEffectDenoiseMosquito(True)
                    VideoEdit1.Video_Effects_Add(mosquito)
                Else
                    mosquito = effect
                End If

                If (IsNothing(mosquito)) Then
                    MessageBox.Show("Unable to configure denoise mosquito effect.")
                    Return
                End If
            End If

        End If

        'Other effects
        If tbLightness.Value > 0 Then
            tbLightness_Scroll(Nothing, Nothing)
        End If

        If tbSaturation.Value < 255 Then
            tbSaturation_Scroll(Nothing, Nothing)
        End If

        If tbContrast.Value > 0 Then
            tbContrast_Scroll(Nothing, Nothing)
        End If

        If tbDarkness.Value > 0 Then
            tbDarkness_Scroll(Nothing, Nothing)
        End If

        If cbGreyscale.Checked Then
            cbGreyscale_CheckedChanged(Nothing, Nothing)
        End If

        If cbInvert.Checked Then
            cbInvert_CheckedChanged(Nothing, Nothing)
        End If

        If (cbZoom.Checked) Then
            cbZoom_CheckedChanged(Nothing, Nothing)
        End If

        If (cbPan.Checked) Then
            cbPan_CheckedChanged(Nothing, Nothing)
        End If

        If cbImageLogo.Checked Then
            cbImageLogo_CheckedChanged(Nothing, Nothing)
        End If

        If cbTextLogo.Checked Then
            btTextLogoUpdateParams_Click(Nothing, Nothing)
        End If

        If cbFadeInOut.Checked Then
            cbFadeInOut_CheckedChanged(Nothing, Nothing)
        End If

        'motion detection
        If (cbMotDetEnabled.Checked) Then
            btMotDetUpdateSettings_Click(sender, e) 'apply settings
        End If

        ' Barcode detection
        VideoEdit1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.Checked
        VideoEdit1.Barcode_Reader_Type = cbBarcodeType.SelectedIndex

        ' Decklink output
        ConfigureDecklink()

        ' Object tracking 
        ConfigureObjectTracking()

        ' video rotation
        Select Case cbRotate.SelectedIndex
            Case 0
                VideoEdit1.Video_Rotation = VFRotateMode.RotateNone
            Case 1
                VideoEdit1.Video_Rotation = VFRotateMode.Rotate90
            Case 2
                VideoEdit1.Video_Rotation = VFRotateMode.Rotate180
            Case 3
                VideoEdit1.Video_Rotation = VFRotateMode.Rotate270
        End Select

        ' tags
        If cbTagEnabled.Checked Then

            Dim tags As VFFileTags = New VFFileTags

            tags.Title = edTagTitle.Text
            tags.Performers = New String() {edTagArtists.Text}
            tags.Album = edTagAlbum.Text
            tags.Comment = edTagComment.Text
            tags.Track = Convert.ToUInt32(edTagTrackID.Text)
            tags.Copyright = edTagCopyright.Text
            tags.Year = Convert.ToUInt32(edTagYear.Text)
            tags.Composers = New String() {edTagComposers.Text}
            tags.Genres = New String() {cbTagGenre.Text}
            tags.Lyrics = edTagLyrics.Text

            If Not IsNothing(imgTagCover.Image) Then
                tags.Pictures = New Bitmap() {imgTagCover.Image}
            End If

            VideoEdit1.Tags = tags

        End If

        VideoEdit1.Start()

        lbTransitions.Items.Clear()

        edNetworkURL.Text = VideoEdit1.Network_Streaming_URL

    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStop.Click

        VideoEdit1.Stop()

        lbFiles.Items.Clear()
        VideoEdit1.Input_Clear_List()

        ProgressBar1.Value = 0

    End Sub

    Private Sub btAddTransition_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAddTransition.Click

        Dim id As Integer

        'get id
        id = VideoEdit.Video_Transition_GetIDFromName(cbTransitionName.Text)

        'add transition
        VideoEdit1.Video_Transition_Add(Convert.ToInt64(edTransStartTime.Text), Convert.ToInt64(edTransStopTime.Text), id)

        'add to list
        lbTransitions.Items.Add(cbTransitionName.Text + "(Start: " + edTransStartTime.Text + ", stop: " + edTransStopTime.Text + ")")

    End Sub

    Private Sub btCustomAudioCodecSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomAudioCodecSettings.Click

        Dim sName As String

        sName = cbCustomAudioCodec.Text

        If (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btCustomDSFiltersASettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomDSFiltersASettings.Click

        Dim sName As String

        sName = cbCustomDSFilterA.Text

        If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btCustomDSFiltersVSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomDSFiltersVSettings.Click

        Dim sName As String

        sName = cbCustomDSFilterV.Text

        If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btCustomMuxerSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomMuxerSettings.Click

        Dim sName As String

        sName = cbCustomMuxer.Text

        If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btCustomVideoCodecSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomVideoCodecSettings.Click

        Dim sName As String

        sName = cbCustomVideoCodec.Text

        If (VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.Video_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btFont_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFont.Click

        If FontDialog1.ShowDialog() = DialogResult.OK Then

            btTextLogoUpdateParams_Click(0, e)

        End If

    End Sub

    Private Sub cbAudioCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioCodec.SelectedIndexChanged

        Dim sName As String

        sName = cbAudioCodec.Text
        btAudioSettings.Enabled = VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub cbCustomAudioCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomAudioCodec.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomAudioCodec.Text
        btCustomAudioCodecSettings.Enabled = VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub cbCustomDSFilterA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomDSFilterA.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomDSFilterA.Text
        btCustomDSFiltersASettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub cbCustomVideoCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomVideoCodec.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomVideoCodec.Text
        btCustomVideoCodecSettings.Enabled = VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub cbCustomMuxer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomMuxer.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomMuxer.Text
        btCustomMuxerSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)


    End Sub

    Private Sub cbCustomDSFilterV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomDSFilterV.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomDSFilterV.Text
        btCustomDSFiltersVSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub cbGreyscale_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbGreyscale.CheckedChanged

        Dim intf As IVFVideoEffectGrayscale
        Dim effect = VideoEdit1.Video_Effects_Get("Grayscale")
        If (IsNothing(effect)) Then
            intf = New VFVideoEffectGrayscale(cbGreyscale.Checked)
            VideoEdit1.Video_Effects_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGreyscale.Checked
            End If
        End If

    End Sub

    Private Sub cbInvert_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbInvert.CheckedChanged

        Dim invert As IVFVideoEffectInvert
        Dim effect = VideoEdit1.Video_Effects_Get("Invert")
        If (IsNothing(effect)) Then
            invert = New VFVideoEffectInvert(cbInvert.Checked)
            VideoEdit1.Video_Effects_Add(invert)
        Else
            invert = effect
            If (invert IsNot Nothing) Then
                invert.Enabled = cbInvert.Checked
            End If
        End If

    End Sub

    Private Sub cbTextLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbTextLogo.CheckedChanged

        btTextLogoUpdateParams_Click(sender, e)

    End Sub

    Private Sub cbWMVAudioCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbWMVAudioCodec.SelectedIndexChanged

        Dim mode = VFWMVStreamMode.CBR
        If cbWMVAudioMode.SelectedIndex = 0 Then
            mode = VFWMVStreamMode.CBR
        ElseIf cbWMVAudioMode.SelectedIndex = 1 Then
            mode = VFWMVStreamMode.VBRBitrate
        ElseIf cbWMVAudioMode.SelectedIndex = 2 Then
            mode = VFWMVStreamMode.VBRPeakBitrate
        ElseIf cbWMVAudioMode.SelectedIndex = 3 Then
            mode = VFWMVStreamMode.VBRQuality
        End If

        cbWMVAudioFormat.Items.Clear()

        If cbWMVAudioCodec.SelectedIndex <> -1 Then

            Dim list As List(Of String)
            list = VideoEdit1.WMV_Custom_Audio_Formats(cbWMVAudioCodec.Text, mode)

            For i As Integer = 0 To list.Count - 1
                cbWMVAudioFormat.Items.Add(list.Item(i))
            Next i

        End If

    End Sub

    Private Sub cbWMVAudioMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbWMVAudioMode.SelectedIndexChanged

        Dim mode = VFWMVStreamMode.CBR
        If cbWMVAudioMode.SelectedIndex = 0 Then
            mode = VFWMVStreamMode.CBR
        ElseIf cbWMVAudioMode.SelectedIndex = 1 Then
            mode = VFWMVStreamMode.VBRBitrate
        ElseIf cbWMVAudioMode.SelectedIndex = 2 Then
            mode = VFWMVStreamMode.VBRPeakBitrate
        ElseIf cbWMVAudioMode.SelectedIndex = 3 Then
            mode = VFWMVStreamMode.VBRQuality
        End If

        cbWMVAudioCodec.Items.Clear()

        For i As Integer = 0 To VideoEdit1.WMV_Custom_Audio_Codecs(mode).Count - 1
            cbWMVAudioCodec.Items.Add(VideoEdit1.WMV_Custom_Audio_Codecs(mode).Item(i))
        Next i

        Dim arg As EventArgs
        arg = Nothing
        cbWMVAudioCodec_SelectedIndexChanged(0, arg)

    End Sub

    Private Sub cbWMVVideoMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbWMVVideoMode.SelectedIndexChanged

        Dim mode = VFWMVStreamMode.CBR
        If cbWMVVideoMode.SelectedIndex = 0 Then

            mode = VFWMVStreamMode.CBR
            edWMVVideoBitrate.Enabled = True
            edWMVVideoPeakBitrate.Enabled = False
            edWMVVideoQuality.Enabled = False

        ElseIf cbWMVVideoMode.SelectedIndex = 1 Then

            mode = VFWMVStreamMode.VBRBitrate
            edWMVVideoBitrate.Enabled = True
            edWMVVideoPeakBitrate.Enabled = False
            edWMVVideoQuality.Enabled = False

        ElseIf cbWMVVideoMode.SelectedIndex = 2 Then

            mode = VFWMVStreamMode.VBRPeakBitrate
            edWMVVideoBitrate.Enabled = True
            edWMVVideoPeakBitrate.Enabled = True
            edWMVVideoQuality.Enabled = False

        ElseIf cbWMVVideoMode.SelectedIndex = 3 Then

            mode = VFWMVStreamMode.VBRQuality
            edWMVVideoBitrate.Enabled = False
            edWMVVideoPeakBitrate.Enabled = False
            edWMVVideoQuality.Enabled = True

        End If

        cbWMVVideoCodec.Items.Clear()

        For i As Integer = 0 To VideoEdit1.WMV_Custom_Video_Codecs(mode).Count - 1
            cbWMVVideoCodec.Items.Add(VideoEdit1.WMV_Custom_Video_Codecs(mode).Item(i))
        Next i

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        VideoEdit1.Stop()

    End Sub

    Private Sub tbDarkness_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbDarkness.Scroll

        Dim darkness As IVFVideoEffectDarkness
        Dim effect = VideoEdit1.Video_Effects_Get("Darkness")
        If (IsNothing(effect)) Then
            darkness = New VFVideoEffectDarkness(True, tbDarkness.Value)
            VideoEdit1.Video_Effects_Add(darkness)
        Else
            darkness = effect
            If (darkness IsNot Nothing) Then
                darkness.Value = tbDarkness.Value
            End If
        End If

    End Sub

    Private Sub tbLightness_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbLightness.Scroll

        Dim lightness As IVFVideoEffectLightness
        Dim effect = VideoEdit1.Video_Effects_Get("Lightness")
        If (IsNothing(effect)) Then
            lightness = New VFVideoEffectLightness(True, tbLightness.Value)
            VideoEdit1.Video_Effects_Add(lightness)
        Else
            lightness = effect
            If (lightness IsNot Nothing) Then
                lightness.Value = tbLightness.Value
            End If
        End If

    End Sub

    Private Sub tbSaturation_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSaturation.Scroll

        Dim saturation As IVFVideoEffectSaturation
        Dim effect = VideoEdit1.Video_Effects_Get("Saturation")
        If (IsNothing(effect)) Then
            saturation = New VFVideoEffectSaturation(tbSaturation.Value)
            VideoEdit1.Video_Effects_Add(saturation)
        Else

            saturation = effect
            If (saturation IsNot Nothing) Then
                saturation.Value = tbSaturation.Value
            End If
        End If

    End Sub

    Private Sub cbVideoCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbVideoCodec.SelectedIndexChanged

        Dim sName As String

        sName = cbVideoCodec.Text

        btVideoSettings.Enabled = VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.Default) OrElse VideoEdit.Video_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub btTextLogoUpdateParams_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btTextLogoUpdateParams.Click

        Dim rotate As VFTextRotationMode
        Dim flip As VFTextFlipMode

        Dim stringFormat = New StringFormat()

        If (cbTextLogoVertical.Checked) Then
            stringFormat.FormatFlags = stringFormat.FormatFlags Xor StringFormatFlags.DirectionVertical
        End If

        If (cbTextLogoRightToLeft.Checked) Then
            stringFormat.FormatFlags = stringFormat.FormatFlags Xor StringFormatFlags.DirectionRightToLeft
        End If

        stringFormat.Alignment = cbTextLogoAlign.SelectedIndex

        Dim textLogo As IVFVideoEffectTextLogo
        Dim effect = VideoEdit1.Video_Effects_Get("TextLogo")
        If (IsNothing(effect)) Then
            textLogo = New VFVideoEffectTextLogo(cbTextLogo.Checked)
            VideoEdit1.Video_Effects_Add(textLogo)
        Else
            textLogo = effect
        End If

        If (IsNothing(textLogo)) Then
            MessageBox.Show("Unable to configure text logo effect.")
            Return
        End If

        textLogo.Enabled = cbTextLogo.Checked
        textLogo.Text = edTextLogo.Text
        textLogo.Left = Convert.ToInt32(edTextLogoLeft.Text)
        textLogo.Top = Convert.ToInt32(edTextLogoTop.Text)
        textLogo.Font = FontDialog1.Font
        textLogo.FontColor = FontDialog1.Color

        textLogo.BackgroundTransparent = cbTextLogoTranspBG.Checked
        textLogo.BackgroundColor = pnTextLogoBGColor.BackColor
        textLogo.StringFormat = stringFormat
        textLogo.Antialiasing = cbTextLogoAntialiasing.SelectedIndex
        textLogo.DrawQuality = cbTextLogoDrawMode.SelectedIndex

        If (cbTextLogoUseRect.Checked) Then
            textLogo.RectWidth = Convert.ToInt32(edTextLogoWidth.Text)
            textLogo.RectHeight = Convert.ToInt32(edTextLogoHeight.Text)
        Else
            textLogo.RectWidth = 0
            textLogo.RectHeight = 0
        End If

        If (rbTextLogoDegree0.Checked) Then
            rotate = VFTextRotationMode.RmNone
        ElseIf (rbTextLogoDegree90.Checked) Then
            rotate = VFTextRotationMode.Rm90
        ElseIf (rbTextLogoDegree180.Checked) Then
            rotate = VFTextRotationMode.Rm180
        Else
            rotate = VFTextRotationMode.Rm270
        End If

        If (rbTextLogoFlipNone.Checked) Then
            flip = VFTextFlipMode.None
        ElseIf (rbTextLogoFlipX.Checked) Then
            flip = VFTextFlipMode.X
        ElseIf (rbTextLogoFlipY.Checked) Then
            flip = VFTextFlipMode.Y
        Else
            flip = VFTextFlipMode.XAndY
        End If

        textLogo.RotationMode = rotate
        textLogo.FlipMode = flip

        textLogo.GradientEnabled = cbTextLogoGradientEnabled.Checked
        textLogo.GradientMode = cbTextLogoGradMode.SelectedIndex
        textLogo.GradientColor1 = pnTextLogoGradColor1.BackColor
        textLogo.GradientColor2 = pnTextLogoGradColor2.BackColor

        textLogo.BorderMode = cbTextLogoEffectrMode.SelectedIndex
        textLogo.BorderInnerColor = pnTextLogoInnerColor.BackColor
        textLogo.BorderOuterColor = pnTextLogoOuterColor.BackColor
        textLogo.BorderInnerSize = Convert.ToInt32(edTextLogoInnerSize.Text)
        textLogo.BorderOuterSize = Convert.ToInt32(edTextLogoOuterSize.Text)

        textLogo.Shape = cbTextLogoShapeEnabled.Checked
        textLogo.ShapeLeft = Convert.ToInt32(edTextLogoShapeLeft.Text)
        textLogo.ShapeTop = Convert.ToInt32(edTextLogoShapeTop.Text)
        textLogo.ShapeType = cbTextLogoShapeType.SelectedIndex
        textLogo.ShapeWidth = Convert.ToInt32(edTextLogoShapeWidth.Text)
        textLogo.ShapeHeight = Convert.ToInt32(edTextLogoShapeHeight.Text)
        textLogo.ShapeColor = pnTextLogoShapeColor.BackColor

        textLogo.TransparencyLevel = tbTextLogoTransp.Value

        If (cbTextLogoDateTime.Checked) Then
            textLogo.Mode = TextLogoMode.DateTime
            textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss"
        Else
            textLogo.Mode = TextLogoMode.Text
        End If

        textLogo.Update()

    End Sub

    Private Sub cbImageLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogo.CheckedChanged

        If String.IsNullOrEmpty(edImageLogoLeft.Text) Then
            Return
        End If

        If (Not File.Exists(edImageLogoFilename.Text)) Then
            If (cbImageLogo.Checked) Then
                MessageBox.Show("Unable to find " + edImageLogoFilename.Text)
                cbImageLogo.Checked = False
            End If
            Return
        End If

        Dim imageLogo As IVFVideoEffectImageLogo
        Dim effect = VideoEdit1.Video_Effects_Get("ImageLogo")
        If (IsNothing(effect)) Then
            imageLogo = New VFVideoEffectImageLogo(cbImageLogo.Checked)
            VideoEdit1.Video_Effects_Add(imageLogo)
        Else
            imageLogo = effect
        End If

        If (IsNothing(imageLogo)) Then
            MessageBox.Show("Unable to configure image logo effect.")
            Return
        End If

        imageLogo.Enabled = cbImageLogo.Checked
        imageLogo.Filename = edImageLogoFilename.Text
        imageLogo.Left = Convert.ToUInt32(edImageLogoLeft.Text)
        imageLogo.Top = Convert.ToUInt32(edImageLogoTop.Text)
        imageLogo.TransparencyLevel = tbImageLogoTransp.Value
        imageLogo.ColorKey = pnImageLogoColorKey.ForeColor
        imageLogo.UseColorKey = cbImageLogoUseColorKey.Checked
        imageLogo.AnimationEnabled = True

        If (cbImageLogoShowAlways.Checked) Then
            imageLogo.StartTime = 0
            imageLogo.StopTime = 0
        Else
            imageLogo.StartTime = Convert.ToInt32(edImageLogoStartTime.Text)
            imageLogo.StopTime = Convert.ToInt32(edImageLogoStopTime.Text)
        End If

    End Sub

    Private Sub btSelectImage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectImage.Click

        If (openFileDialog2.ShowDialog() = DialogResult.OK) Then
            edImageLogoFilename.Text = openFileDialog2.FileName
        End If

    End Sub

    Private Sub cbGraphicLogoShowAlways_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogoShowAlways.CheckedChanged

        If Tag = 1 Then

            edImageLogoStartTime.Enabled = Not cbImageLogoShowAlways.Checked
            edImageLogoStopTime.Enabled = Not cbImageLogoShowAlways.Checked
            lbGraphicLogoStartTime.Enabled = Not cbImageLogoShowAlways.Checked
            lbGraphicLogoStopTime.Enabled = Not cbImageLogoShowAlways.Checked

            cbImageLogo_CheckedChanged(sender, e)

        End If

    End Sub

    Private Sub tbGraphicLogoTransp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbImageLogoTransp.Scroll

        cbImageLogo_CheckedChanged(sender, e)

    End Sub

    Private Sub cbGraphicLogoUseColorKey_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogoUseColorKey.CheckedChanged

        cbImageLogo_CheckedChanged(sender, e)

    End Sub

    Private Sub pnTextLogoBGColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoBGColor.Click

        colorDialog1.Color = pnTextLogoBGColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoBGColor.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnTextLogoGradColor1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoGradColor1.Click


        colorDialog1.Color = pnTextLogoGradColor1.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoGradColor1.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnTextLogoGradColor2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoGradColor2.Click

        colorDialog1.Color = pnTextLogoGradColor2.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoGradColor2.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnTextLogoInnerColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoInnerColor.Click

        colorDialog1.Color = pnTextLogoInnerColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoInnerColor.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnTextLogoOuterColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoOuterColor.Click

        colorDialog1.Color = pnTextLogoOuterColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoOuterColor.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnTextLogoShapeColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoShapeColor.Click

        colorDialog1.Color = pnTextLogoShapeColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnTextLogoShapeColor.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub pnGraphicLogoColorKey_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnImageLogoColorKey.Click

        colorDialog1.Color = pnImageLogoColorKey.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then
            pnImageLogoColorKey.BackColor = colorDialog1.Color
        End If

    End Sub

    Private Sub cbUseSpecialFilewriter_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbUseSpecialFilewriter.CheckedChanged

        cbCustomFilewriter.Enabled = cbUseSpecialFilewriter.Checked
        btCustomFilewriterSettings.Enabled = cbUseSpecialFilewriter.Checked

    End Sub

    Private Sub cbCustomFilewriter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbCustomFilewriter.SelectedIndexChanged

        Dim sName As String

        sName = cbCustomFilewriter.Text
        btCustomFilewriterSettings.Enabled = VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default) Or VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)

    End Sub

    Private Sub btCustomFilewriterSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btCustomFilewriterSettings.Click

        Dim sName As String

        sName = cbCustomFilewriter.Text

        If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btSelectWM_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectWM.Click

        If (openFileDialog3.ShowDialog() = DialogResult.OK) Then

            edWMVProfile.Text = openFileDialog3.FileName

        End If

    End Sub

    Private Sub cbAudioCodecs2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioCodecs2.SelectedIndexChanged

        Dim sName As String

        sName = cbAudioCodecs2.Text
        btAudioSettings2.Enabled = (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default) Or VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig))

    End Sub

    Private Sub tbContrast_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbContrast.Scroll

        Dim contrast As IVFVideoEffectContrast
        Dim effect = VideoEdit1.Video_Effects_Get("Contrast")
        If (IsNothing(effect)) Then
            contrast = New VFVideoEffectContrast(True, tbContrast.Value)
            VideoEdit1.Video_Effects_Add(contrast)
        Else
            contrast = effect
            If (contrast IsNot Nothing) Then
                contrast.Value = tbContrast.Value
            End If
        End If

    End Sub

    Private Sub cbFilters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbFilters.SelectedIndexChanged

        If (cbFilters.SelectedIndex <> -1) Then

            Dim sName As String = cbFilters.Text
            btFilterSettings.Enabled = (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Or (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig))

        End If

    End Sub

    Private Sub btFilterAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFilterAdd.Click

        If (cbFilters.SelectedIndex <> -1) Then

            VideoEdit1.Video_Filters_Add(New VFCustomProcessingFilter(cbFilters.Text))
            lbFilters.Items.Add(cbFilters.Text)

        End If

    End Sub

    Private Sub btFilterSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFilterSettings.Click

        Dim sName As String = cbFilters.Text

        If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub lbFilters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lbFilters.SelectedIndexChanged

        If (lbFilters.SelectedIndex <> -1) Then

            Dim sName As String = lbFilters.Text
            btFilterSettings2.Enabled = (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Or (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig))

        End If

    End Sub

    Private Sub btFilterSettings2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFilterSettings2.Click

        If (lbFilters.SelectedIndex <> -1) Then

            Dim sName As String = lbFilters.Text

            If (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
            ElseIf (VideoEdit.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
                VideoEdit.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
            End If

        End If

    End Sub

    Private Sub btFilterDeleteAll_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFilterDeleteAll.Click

        lbFilters.Items.Clear()
        VideoEdit1.Video_Filters_Clear()

    End Sub


    Private Sub cbAudAmplifyEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudAmplifyEnabled.CheckedChanged

        VideoEdit1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked)

    End Sub

    Private Sub tbAudAmplifyAmp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudAmplifyAmp.Scroll

        VideoEdit1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, False)

    End Sub

    Private Sub cbAudEqualizerEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudEqualizerEnabled.CheckedChanged

        VideoEdit1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked)

    End Sub

    Private Sub tbAudEq0_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq0.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, tbAudEq0.Value)

    End Sub

    Private Sub tbAudEq1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq1.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, tbAudEq1.Value)

    End Sub

    Private Sub tbAudEq2_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq2.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, tbAudEq2.Value)

    End Sub

    Private Sub tbAudEq3_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq3.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, tbAudEq3.Value)

    End Sub

    Private Sub tbAudEq4_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq4.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, tbAudEq4.Value)

    End Sub

    Private Sub tbAudEq5_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq5.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, tbAudEq5.Value)

    End Sub

    Private Sub tbAudEq6_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq6.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, tbAudEq6.Value)

    End Sub

    Private Sub tbAudEq7_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq7.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, tbAudEq7.Value)

    End Sub

    Private Sub tbAudEq8_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq8.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, tbAudEq8.Value)

    End Sub

    Private Sub tbAudEq9_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq9.Scroll

        VideoEdit1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, tbAudEq9.Value)

    End Sub

    Private Sub cbAudEqualizerPreset_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudEqualizerPreset.SelectedIndexChanged

        VideoEdit1.Audio_Effects_Equalizer_Preset_Set(-1, 1, cbAudEqualizerPreset.SelectedIndex)
        btAudEqRefresh_Click(sender, e)

    End Sub

    Private Sub btAudEqRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAudEqRefresh.Click

        tbAudEq0.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0)
        tbAudEq1.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1)
        tbAudEq2.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2)
        tbAudEq3.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3)
        tbAudEq4.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4)
        tbAudEq5.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5)
        tbAudEq6.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6)
        tbAudEq7.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7)
        tbAudEq8.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8)
        tbAudEq9.Value = VideoEdit1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9)

    End Sub

    Private Sub cbAudDynamicAmplifyEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudDynamicAmplifyEnabled.CheckedChanged

        VideoEdit1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.Checked)

    End Sub

    Private Sub tbAudDynAmp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudDynAmp.Scroll

        VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub tbAudAttack_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudAttack.Scroll

        VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub tbAudRelease_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudRelease.Scroll

        VideoEdit1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub cbAudSound3DEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudSound3DEnabled.CheckedChanged

        VideoEdit1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked)

    End Sub

    Private Sub tbAud3DSound_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAud3DSound.Scroll

        VideoEdit1.Audio_Effects_Sound3D(-1, 3, tbAud3DSound.Value)

    End Sub

    Private Sub cbAudTrueBassEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudTrueBassEnabled.CheckedChanged

        VideoEdit1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.Checked)

    End Sub

    Private Sub tbAudTrueBass_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudTrueBass.Scroll

        VideoEdit1.Audio_Effects_TrueBass(-1, 4, 200, False, tbAudTrueBass.Value)

    End Sub

    Private Sub rbVR_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbVR.CheckedChanged, rbVMR9.CheckedChanged, rbNone.CheckedChanged, rbEVR.CheckedChanged, rbDirect2D.CheckedChanged

        cbScreenFlipVertical.Enabled = rbVMR9.Checked Or rbDirect2D.Checked
        cbScreenFlipHorizontal.Enabled = rbVMR9.Checked Or rbDirect2D.Checked

        If Tag = 1 Then

            If (rbVMR9.Checked) Then
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
            ElseIf (rbEVR.Checked) Then
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
            ElseIf (rbVR.Checked) Then
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
            ElseIf (rbDirect2D.Checked) Then
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D
            Else
                VideoEdit1.Video_Renderer.Video_Renderer = VFVideoRenderer.None
            End If

        End If

    End Sub

    Private Sub cbStretch_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbStretch.CheckedChanged

        If (cbStretch.Checked) Then
            VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch
        Else
            VideoEdit1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox
        End If

        VideoEdit1.Video_Renderer_Update()

    End Sub

    Private Sub cbScreenFlipVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbScreenFlipVertical.CheckedChanged

        VideoEdit1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked
        VideoEdit1.Video_Renderer_Update()

    End Sub

    Private Sub cbScreenFlipHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbScreenFlipHorizontal.CheckedChanged

        VideoEdit1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked
        VideoEdit1.Video_Renderer_Update()

    End Sub

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/video_tutorials")
        Process.Start(startInfo)

    End Sub

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSpeed.Scroll

        lbSpeed.Text = Convert.ToInt32(tbSpeed.Value) + "%"

    End Sub

    Private Sub tbSeeking_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSeeking.Scroll

        VideoEdit1.Position_Set(tbSeeking.Value)

    End Sub

    Private Sub VideoEdit1_OnStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles VideoEdit1.OnStart

        tbSeeking.Maximum = VideoEdit1.Duration()

    End Sub

    Private Sub VideoEdit1_OnProgress(ByVal sender As System.Object, ByVal e As VisioForge.Types.ProgressEventArgs) Handles VideoEdit1.OnProgress

        ProgressBar1.Value = e.Progress

    End Sub

    Private Sub VideoEdit1_OnError(ByVal sender As System.Object, ByVal e As VisioForge.Types.ErrorsEventArgs) Handles VideoEdit1.OnError

        mmLog.Text = mmLog.Text + e.Message + Environment.NewLine

    End Sub

    Private Sub btAudioSettings2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAudioSettings2.Click

        Dim sName As String

        sName = cbAudioCodecs2.Text

        If (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.Default)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (VideoEdit.Audio_Codec_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            VideoEdit.Audio_Codec_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)
        End If

    End Sub

    Private Sub btMotDetUpdateSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btMotDetUpdateSettings.Click

        If (cbMotDetEnabled.Checked) Then
            VideoEdit1.Motion_Detection = New MotionDetectionSettings()
            VideoEdit1.Motion_Detection.Enabled = cbMotDetEnabled.Checked
            VideoEdit1.Motion_Detection.Compare_Red = cbCompareRed.Checked
            VideoEdit1.Motion_Detection.Compare_Green = cbCompareGreen.Checked
            VideoEdit1.Motion_Detection.Compare_Blue = cbCompareBlue.Checked
            VideoEdit1.Motion_Detection.Compare_Greyscale = cbCompareGreyscale.Checked
            VideoEdit1.Motion_Detection.Highlight_Color = cbMotDetHLColor.SelectedIndex
            VideoEdit1.Motion_Detection.Highlight_Enabled = cbMotDetHLEnabled.Checked
            VideoEdit1.Motion_Detection.Highlight_Threshold = tbMotDetHLThreshold.Value
            VideoEdit1.Motion_Detection.FrameInterval = Convert.ToInt32(edMotDetFrameInterval.Text)
            VideoEdit1.Motion_Detection.Matrix_Height = Convert.ToInt32(edMotDetMatrixHeight.Text)
            VideoEdit1.Motion_Detection.Matrix_Width = Convert.ToInt32(edMotDetMatrixWidth.Text)
            VideoEdit1.Motion_Detection.DropFrames_Enabled = cbMotDetDropFramesEnabled.Checked
            VideoEdit1.Motion_Detection.DropFrames_Threshold = tbMotDetDropFramesThreshold.Value
            VideoEdit1.MotionDetection_Update()
        Else
            VideoEdit1.Motion_Detection = Nothing
        End If

    End Sub

    Public Delegate Sub MotionDelegate(ByVal e As MotionDetectionEventArgs)

    Public Sub MotionDelegateMethod(ByVal e As MotionDetectionEventArgs)

        Dim s As String = String.Empty

        Dim k As Integer
        For Each b As Byte In e.Matrix
            s += b.ToString("D3") + " "

            If (k = VideoEdit1.Motion_Detection.Matrix_Width - 1) Then
                k = 0
                s += Environment.NewLine
            Else
                k += 1
            End If
        Next

        mmMotDetMatrix.Text = s.Trim()
        pbMotionLevel.Value = e.Level

    End Sub

    Private Sub MediaPlayer1_OnMotion(ByVal sender As System.Object, ByVal e As MotionDetectionEventArgs) Handles VideoEdit1.OnMotionDetection

        Dim motdel As MotionDelegate = New MotionDelegate(AddressOf MotionDelegateMethod)
        BeginInvoke(motdel, e)

    End Sub

    Private Sub cbAFMotionDetection_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAFMotionDetection.CheckedChanged

        ConfigureObjectTracking()

    End Sub

    Private Sub cbAFMotionHighlight_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAFMotionHighlight.CheckedChanged

        ConfigureObjectTracking()

    End Sub

    Private Sub VideoEdit1_OnObjectDetection(ByVal sender As System.Object, ByVal e As VisioForge.Types.MotionDetectionExEventArgs) Handles VideoEdit1.OnMotionDetectionEx

        Dim motdel As AFMotionDelegate = New AFMotionDelegate(AddressOf AFMotionDelegateMethod)
        BeginInvoke(motdel, e.Level)

    End Sub

    Public Delegate Sub AFMotionDelegate(ByVal level As System.Single)

    Public Sub AFMotionDelegateMethod(ByVal level As System.Single)

        pbAFMotionLevel.Value = level * 100

    End Sub

    Private Sub cbZoom_CheckedChanged(sender As Object, e As EventArgs) Handles cbZoom.CheckedChanged

        Dim zoomEffect As IVFVideoEffectZoom
        Dim effect = VideoEdit1.Video_Effects_Get("Zoom")
        If (IsNothing(effect)) Then
            zoomEffect = New VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoom.Checked)
            VideoEdit1.Video_Effects_Add(zoomEffect)
        Else
            zoomEffect = effect
        End If

        If (IsNothing(zoomEffect)) Then
            MessageBox.Show("Unable to configure zoom effect.")
            Return
        End If

        zoomEffect.ZoomX = zoom
        zoomEffect.ZoomY = zoom
        zoomEffect.ShiftX = zoomShiftX
        zoomEffect.ShiftY = zoomShiftY
        zoomEffect.Enabled = cbZoom.Checked

    End Sub

    Private Sub btEffZoomIn_Click(sender As Object, e As EventArgs) Handles btEffZoomIn.Click

        zoom += 0.1
        zoom = Math.Min(zoom, 5)

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomOut_Click(sender As Object, e As EventArgs) Handles btEffZoomOut.Click

        zoom -= 0.1
        zoom = Math.Max(zoom, 1)

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomDown_Click(sender As Object, e As EventArgs) Handles btEffZoomDown.Click

        zoomShiftY += 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomRight_Click(sender As Object, e As EventArgs) Handles btEffZoomRight.Click

        zoomShiftX += 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomLeft_Click(sender As Object, e As EventArgs) Handles btEffZoomLeft.Click

        zoomShiftX -= 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomUp_Click(sender As Object, e As EventArgs) Handles btEffZoomUp.Click

        zoomShiftY += 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub cbPan_CheckedChanged(sender As Object, e As EventArgs) Handles cbPan.CheckedChanged

        Dim pan As IVFVideoEffectPan
        Dim effect = VideoEdit1.Video_Effects_Get("Pan")
        If (IsNothing(effect)) Then
            pan = New VFVideoEffectPan(True)
            VideoEdit1.Video_Effects_Add(pan)
        Else
            pan = effect
        End If

        If (IsNothing(pan)) Then
            MessageBox.Show("Unable to configure pan effect.")
            Return
        End If

        pan.Enabled = cbPan.Checked
        pan.StartTime = Convert.ToInt32(edPanStartTime.Text)
        pan.StopTime = Convert.ToInt32(edPanStopTime.Text)
        pan.StartX = Convert.ToInt32(edPanSourceLeft.Text)
        pan.StartY = Convert.ToInt32(edPanSourceTop.Text)
        pan.StartWidth = Convert.ToInt32(edPanSourceWidth.Text)
        pan.StartHeight = Convert.ToInt32(edPanSourceHeight.Text)
        pan.StopX = Convert.ToInt32(edPanDestLeft.Text)
        pan.StopY = Convert.ToInt32(edPanDestTop.Text)
        pan.StopWidth = Convert.ToInt32(edPanDestWidth.Text)
        pan.StopHeight = Convert.ToInt32(edPanDestHeight.Text)

    End Sub

    Private Sub btBarcodeReset_Click(sender As Object, e As EventArgs) Handles btBarcodeReset.Click

        edBarcode.Text = String.Empty
        edBarcodeMetadata.Text = String.Empty
        VideoEdit1.Barcode_Reader_Enabled = True

    End Sub

    Private Sub VideoEdit1_OnBarcodeDetected(sender As Object, e As BarcodeEventArgs) Handles VideoEdit1.OnBarcodeDetected

        e.DetectorEnabled = False

        BeginInvoke(New BarcodeDelegate(AddressOf BarcodeDelegateMethod), e)

    End Sub

    Private Delegate Sub BarcodeDelegate(ByVal value As BarcodeEventArgs)

    Private Sub BarcodeDelegateMethod(ByVal value As BarcodeEventArgs)

        edBarcode.Text = value.Value
        edBarcodeMetadata.Text = String.Empty

        For Each o As KeyValuePair(Of VFBarcodeResultMetadataType, Object) In value.Metadata

            edBarcodeMetadata.Text += o.Key.ToString() + ": " + o.Value.ToString() + Environment.NewLine

        Next

    End Sub

    Private Sub btRefreshClients_Click(sender As Object, e As EventArgs) Handles btRefreshClients.Click

        Dim dns1 As String = "", address As String = ""

        Dim port As Integer = 0

        lbNetworkClients.Items.Clear()

        For i As Integer = 0 To VideoEdit1.Network_Streaming_WMV_Clients_GetCount - 1

            VideoEdit1.Network_Streaming_WMV_Clients_GetInfo(i, port, address, dns1)

            Dim client As String = "ID: " + i + ", Port: " + port + ", Address: " + address + ", DNS: " + dns1
            lbNetworkClients.Items.Add(client)

        Next i

    End Sub

    Private Sub btSelectWMVProfileNetwork_Click(sender As Object, e As EventArgs) Handles btSelectWMVProfileNetwork.Click

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            edNetworkStreamingWMVProfile.Text = openFileDialog1.FileName
        End If

    End Sub

    Private Sub cbFadeInOut_CheckedChanged(sender As Object, e As EventArgs) Handles cbFadeInOut.CheckedChanged

        If (rbFadeIn.Checked) Then
            Dim fadeIn As IVFVideoEffectFadeIn
            Dim effect = VideoEdit1.Video_Effects_Get("FadeIn")
            If (IsNothing(effect)) Then
                fadeIn = New VFVideoEffectFadeIn(cbFadeInOut.Checked)
                VideoEdit1.Video_Effects_Add(fadeIn)
            Else
                fadeIn = effect
            End If

            If (IsNothing(fadeIn)) Then
                MessageBox.Show("Unable to configure fade-in effect.")
                Return
            End If

            fadeIn.Enabled = cbFadeInOut.Checked
            fadeIn.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text)
            fadeIn.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text)
        Else
            Dim fadeOut As IVFVideoEffectFadeOut
            Dim effect = VideoEdit1.Video_Effects_Get("FadeOut")
            If (IsNothing(effect)) Then
                fadeOut = New VFVideoEffectFadeOut(cbFadeInOut.Checked)
                VideoEdit1.Video_Effects_Add(fadeOut)
            Else
                fadeOut = effect
            End If

            If (IsNothing(fadeOut)) Then
                MessageBox.Show("Unable to configure fade-out effect.")
                Return
            End If

            fadeOut.Enabled = cbFadeInOut.Checked
            fadeOut.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text)
            fadeOut.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text)
        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/support/878966-Streaming-to-Adobe-Flash-Media-Server")
        Process.Start(startInfo)

    End Sub

#Region "Full screen"

    Dim fullScreen As Boolean

    Dim windowLeft As Integer

    Dim windowTop As Integer

    Dim windowWidth As Integer

    Dim windowHeight As Integer

    Dim controlLeft As Integer

    Dim controlTop As Integer

    Dim controlWidth As Integer

    Dim controlHeight As Integer

    Private Sub btFullScreen_Click(sender As Object, e As EventArgs) Handles btFullScreen.Click

        If (Not fullScreen) Then

            ' going fullscreen
            fullScreen = True

            ' saving coordinates
            windowLeft = Left
            windowTop = Top
            windowWidth = Width
            windowHeight = Height

            controlLeft = VideoEdit1.Left
            controlTop = VideoEdit1.Top
            controlWidth = VideoEdit1.Width
            controlHeight = VideoEdit1.Height

            ' resizing window
            Left = 0
            Top = 0
            Width = Screen.AllScreens(0).WorkingArea.Width
            Height = Screen.AllScreens(0).WorkingArea.Height

            TopMost = True
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized

            ' resizing control
            VideoEdit1.Left = 0
            VideoEdit1.Top = 0
            VideoEdit1.Width = Width
            VideoEdit1.Height = Height

            VideoEdit1.Video_Renderer_Update()

        Else
            ' going normal screen
            fullScreen = False

            ' restoring control
            VideoEdit1.Left = controlLeft
            VideoEdit1.Top = controlTop
            VideoEdit1.Width = controlWidth
            VideoEdit1.Height = controlHeight

            ' restoring window
            Left = windowLeft
            Top = windowTop
            Width = windowWidth
            Height = windowHeight

            TopMost = False
            FormBorderStyle = FormBorderStyle.Sizable
            WindowState = FormWindowState.Normal

            VideoEdit1.Video_Renderer_Update()

        End If

    End Sub

    Private Sub VideoEdit1_MouseDown(sender As Object, e As MouseEventArgs) Handles VideoEdit1.MouseDown

        If (fullScreen) Then

            btFullScreen_Click(sender, e)

        End If

    End Sub

#End Region

    Private Sub linkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel5.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/support/240078-How-to-configure-IIS-Smooth-Streaming-in-SDK-demo-application")
        Process.Start(startInfo)

    End Sub

    Private Sub pnVideoRendererBGColor_Click(sender As Object, e As EventArgs) Handles pnVideoRendererBGColor.Click

        colorDialog1.Color = pnVideoRendererBGColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then

            pnVideoRendererBGColor.BackColor = colorDialog1.Color

        End If

    End Sub

    Private Sub cbDirect2DRotate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDirect2DRotate.SelectedIndexChanged

        VideoEdit1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text)
        VideoEdit1.Video_Renderer_Update()

    End Sub

    Private Sub cbAudioNormalize_CheckedChanged(sender As Object, e As EventArgs) Handles cbAudioNormalize.CheckedChanged

        VideoEdit1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked)

    End Sub

    Private Sub cbAudioAutoGain_CheckedChanged(sender As Object, e As EventArgs) Handles cbAudioAutoGain.CheckedChanged

        VideoEdit1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked)

    End Sub

    Private Sub ApplyAudioInputGains()

        Dim gains As VFAudioEnhancerGains = New VFAudioEnhancerGains()

        gains.L = tbAudioInputGainL.Value / 10.0F
        gains.C = tbAudioInputGainC.Value / 10.0F
        gains.R = tbAudioInputGainR.Value / 10.0F
        gains.SL = tbAudioInputGainSL.Value / 10.0F
        gains.SR = tbAudioInputGainSR.Value / 10.0F
        gains.LFE = tbAudioInputGainLFE.Value / 10.0F

        VideoEdit1.Audio_Enhancer_InputGains(-1, gains)

    End Sub

    Private Sub ApplyAudioOutputGains()

        Dim gains As VFAudioEnhancerGains = New VFAudioEnhancerGains

        gains.L = tbAudioOutputGainL.Value / 10.0F
        gains.C = tbAudioOutputGainC.Value / 10.0F
        gains.R = tbAudioOutputGainR.Value / 10.0F
        gains.SL = tbAudioOutputGainSL.Value / 10.0F
        gains.SR = tbAudioOutputGainSR.Value / 10.0F
        gains.LFE = tbAudioOutputGainLFE.Value / 10.0F

        VideoEdit1.Audio_Enhancer_OutputGains(-1, gains)

    End Sub

    Private Sub tbAudioInputGainL_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainL.Scroll

        lbAudioInputGainL.Text = (tbAudioInputGainL.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioInputGainC_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainC.Scroll

        lbAudioInputGainC.Text = (tbAudioInputGainC.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioInputGainR_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainR.Scroll

        lbAudioInputGainR.Text = (tbAudioInputGainR.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioInputGainSL_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainSL.Scroll

        lbAudioInputGainSL.Text = (tbAudioInputGainSL.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioInputGainSR_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainSR.Scroll

        lbAudioInputGainSR.Text = (tbAudioInputGainSR.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioInputGainLFE_Scroll(sender As Object, e As EventArgs) Handles tbAudioInputGainLFE.Scroll

        lbAudioInputGainLFE.Text = (tbAudioInputGainLFE.Value / 10.0F).ToString("F1")

        ApplyAudioInputGains()

    End Sub

    Private Sub tbAudioOutputGainL_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainL.Scroll

        lbAudioOutputGainL.Text = (tbAudioOutputGainL.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioOutputGainC_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainC.Scroll

        lbAudioOutputGainC.Text = (tbAudioOutputGainC.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioOutputGainR_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainR.Scroll

        lbAudioOutputGainR.Text = (tbAudioOutputGainR.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioOutputGainSL_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainSL.Scroll

        lbAudioOutputGainSL.Text = (tbAudioOutputGainSL.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioOutputGainSR_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainSR.Scroll

        lbAudioOutputGainSR.Text = (tbAudioOutputGainSR.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioOutputGainLFE_Scroll(sender As Object, e As EventArgs) Handles tbAudioOutputGainLFE.Scroll

        lbAudioOutputGainLFE.Text = (tbAudioOutputGainLFE.Value / 10.0F).ToString("F1")

        ApplyAudioOutputGains()

    End Sub

    Private Sub tbAudioTimeshift_Scroll(sender As Object, e As EventArgs) Handles tbAudioTimeshift.Scroll

        lbAudioTimeshift.Text = tbAudioTimeshift.Value.ToString(CultureInfo.InvariantCulture) + " ms"

        VideoEdit1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value)

    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click

        'Dim sourceFile As String = "x:\VideoSource\axe_matamor.avi" '"x:\VideoSource\ScreenCapture.wmv"

        'Dim sourceFile2 As String = "x:\VideoSource\Intro.wmv"

        'Dim overlayFile As String = "x:\VideoSource\pip-sub.wmv"

        'Dim position1 As Integer = 200

        'Dim position2 As Integer = 4600

        'Dim sourceLength As Integer = 5982

        'Dim duration1 As Integer = 2715 - position1

        'Dim duration2 As Integer = sourceLength - position2

        'With VideoEdit1

        '    .Input_Clear_List()

        '    .Input_AddVideoFile(sourceFile, 0, 10000, 0, VFVideoEditStretchMode.Letterbox, 1.0)

        '    .Input_AddVideoFile(sourceFile2, 0, 5000, 0, VFVideoEditStretchMode.Letterbox, 1.0)

        '    .Video_Transition_Add_PIP(0, 5000, 0, 0, 320, 240)


        '    '.Input_AddVideoFile(sourceFile, 0, 5000, 5000, VFVideoEditStretchMode.Letterbox, 1.0)

        '    .Input_AddVideoFile(overlayFile, 0, 5000, 5000, VFVideoEditStretchMode.Letterbox, 1.0)

        '    .Video_Transition_Add_PIP(5000, 10000, 0, 0, 320, 240)

        '    '.Input_AddVideoFile(sourceFile, position1, 2715, -1, VFVideoEditStretchMode.Letterbox, 1.0)

        '    '.Input_AddAudioFile(sourceFile, position1, 2715, -1, sourceFile, 0, 0, 1.0)

        '    '.Input_AddVideoFile(sourceFile, position2, sourceLength, -1, VFVideoEditStretchMode.Letterbox, 1.0)

        '    '.Input_AddAudioFile(sourceFile, position2, sourceLength, -1,sourceFile, 0, 0, 1.0)

        '    '.Input_AddVideoFile(overlayFile, 0, duration1, 0, VFVideoEditStretchMode.Letterbox, 1.0)

        '    '.Video_Transition_Add_PIP(0, duration1, 0, 0, 320, 240)

        '    '.Input_AddVideoFile(overlayFile, duration1 + 1, duration1 + duration2, duration1 + 1, VFVideoEditStretchMode.Letterbox, 1.0)

        '    '.Video_Transition_Add_PIP(duration1 + 1, duration2, 0, 0, 320, 240)

        '    '.Output_Format = VFVideoEditOutputFormat.MP4

        '    '.Output_Filename = "x:\output.mp4"

        '    .Mode = VFVideoEditMode.Preview

        '    '.Video_Renderer = VFVideoRenderer.EVR

        '    '.Video_FrameRate = 0

        '    '.Video_Resize = False

        '    '.MP4_LegacyCodecs = True

        '    '.MP4_Video_H264_Profile = VFH264Profile.ProfileAuto

        '    '.MP4_Video_H264_Level = VFH264Level.LevelAuto

        '    '.MP4_Video_H264_Target_Usage = VFH264TargetUsage.Auto

        '    '.MP4_Video_H264_PictureType = VFH264PictureType.Auto

        '    '.MP4_Video_H264_RateControl = VFH264RateControl.CBR

        '    '.MP4_Video_H264_BitrateAuto = True

        '    '.MP4_Audio_AAC_Bitrate = 128 'kbps

        '    '.MP4_Audio_AAC_Version = VFAACVersion.MPEG4

        '    '.MP4_Audio_AAC_Output = VFAACOutput.RAW

        '    ' .MP4_Audio_AAC_Object = VFAACObject.Low

        '    .Audio_Preview_Enabled = False

        '    .Start()

        'End With

    End Sub

    Private Sub VideoEdit1_OnLicenseRequired(sender As Object, e As LicenseEventArgs) Handles VideoEdit1.OnLicenseRequired

        If cbLicensing.Checked Then
            mmLog.Text = mmLog.Text + "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine
        End If

    End Sub

    Private Sub cbFFEXEProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFFEXEProfile.SelectedIndexChanged

        Select Case (cbFFEXEProfile.SelectedIndex)
            ' MPEG-1
            Case 0
                cbFFEXEOutputFormat.SelectedIndex = 23

                cbFFEXEVideoCodec.SelectedIndex = 12
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MPEG-1 VCD
            Case 1
                cbFFEXEOutputFormat.SelectedIndex = 34

                cbFFEXEVideoCodec.SelectedIndex = 12
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MPEG-2
            Case 2
                cbFFEXEOutputFormat.SelectedIndex = 23

                cbFFEXEVideoCodec.SelectedIndex = 13
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MPEG-2 SVCD
            Case 3
                cbFFEXEOutputFormat.SelectedIndex = 30

                cbFFEXEVideoCodec.SelectedIndex = 13
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MPEG-2 DVD
            Case 4
                cbFFEXEOutputFormat.SelectedIndex = 7

                cbFFEXEVideoCodec.SelectedIndex = 13
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MPEG-2 TS
            Case 5
                cbFFEXEOutputFormat.SelectedIndex = 24

                cbFFEXEVideoCodec.SelectedIndex = 13
                cbFFEXEAudioCodec.SelectedIndex = 12

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' Flash Video (FLV)
            Case 6
                cbFFEXEOutputFormat.SelectedIndex = 11

                cbFFEXEVideoCodec.SelectedIndex = 5
                cbFFEXEAudioCodec.SelectedIndex = 1

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MP4 H264 / AAC
            Case 7
                cbFFEXEOutputFormat.SelectedIndex = 22

                cbFFEXEVideoCodec.SelectedIndex = 5
                cbFFEXEAudioCodec.SelectedIndex = 1

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MP4 HEVC / AAC
            Case 8
                cbFFEXEOutputFormat.SelectedIndex = 22

                cbFFEXEVideoCodec.SelectedIndex = 6
                cbFFEXEAudioCodec.SelectedIndex = 1

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' WebM
            Case 9
                cbFFEXEOutputFormat.SelectedIndex = 36

                cbFFEXEVideoCodec.SelectedIndex = 17
                cbFFEXEAudioCodec.SelectedIndex = 41

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' AVI
            Case 10
                cbFFEXEOutputFormat.SelectedIndex = 4

                cbFFEXEVideoCodec.SelectedIndex = 14
                cbFFEXEAudioCodec.SelectedIndex = 13

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' OGG Vorbis
            Case 11
                cbFFEXEOutputFormat.SelectedIndex = 26

                cbFFEXEVideoCodec.SelectedIndex = 0
                cbFFEXEAudioCodec.SelectedIndex = 41

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' Opus
            Case 12
                cbFFEXEOutputFormat.SelectedIndex = 27

                cbFFEXEVideoCodec.SelectedIndex = 0
                cbFFEXEAudioCodec.SelectedIndex = 14

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' Speex
            Case 13
                cbFFEXEOutputFormat.SelectedIndex = 26

                cbFFEXEVideoCodec.SelectedIndex = 0
                cbFFEXEAudioCodec.SelectedIndex = 40

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' FLAC
            Case 14
                cbFFEXEOutputFormat.SelectedIndex = 10

                cbFFEXEVideoCodec.SelectedIndex = 0
                cbFFEXEAudioCodec.SelectedIndex = 10

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' MP3
            Case 15
                cbFFEXEOutputFormat.SelectedIndex = 21

                cbFFEXEVideoCodec.SelectedIndex = 0
                cbFFEXEAudioCodec.SelectedIndex = 13

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

            ' DV
            Case 16
                cbFFEXEOutputFormat.SelectedIndex = 4

                cbFFEXEVideoCodec.SelectedIndex = 1
                cbFFEXEAudioCodec.SelectedIndex = 23

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

                cbFFEXEAudioChannels.SelectedIndex = 1
                cbFFEXEAudioSampleRate.SelectedIndex = 1

            ' Custom
            Case 17
                cbFFEXEOutputFormat.SelectedIndex = 4

                cbFFEXEVideoCodec.SelectedIndex = 14
                cbFFEXEAudioCodec.SelectedIndex = 13

                cbFFEXEVideoCodec_SelectedIndexChanged(Nothing, Nothing)
                cbFFEXEAudioCodec_SelectedIndexChanged(Nothing, Nothing)

        End Select

    End Sub

    Private Sub FFEXEDisableVideoMode()

        rbFFEXEVideoModeABR.Enabled = False
        rbFFEXEVideoModeABR.Checked = False
        rbFFEXEVideoModeCBR.Enabled = False
        rbFFEXEVideoModeCBR.Checked = False
        rbFFEXEVideoModeQuality.Enabled = False
        rbFFEXEVideoModeQuality.Checked = False

        tbFFEXEVideoQuality.Enabled = False
        edFFEXEVideoTargetBitrate.Enabled = False
        edFFEXEVideoBitrateMax.Enabled = False
        edFFEXEVideoBitrateMin.Enabled = False

    End Sub

    Private Sub FFEXEEnableVideoCBR()

        rbFFEXEVideoModeCBR.Enabled = True
        rbFFEXEVideoModeCBR.Checked = True

        edFFEXEVideoTargetBitrate.Enabled = True

    End Sub

    Private Sub FFEXEEnableVideoABR()

        rbFFEXEVideoModeABR.Enabled = True
        rbFFEXEVideoModeABR.Checked = True

        edFFEXEVideoTargetBitrate.Enabled = True
        edFFEXEVideoBitrateMax.Enabled = True
        edFFEXEVideoBitrateMin.Enabled = True

    End Sub

    Private Sub FFEXEEnableVideoQuality()

        rbFFEXEVideoModeQuality.Enabled = True
        rbFFEXEVideoModeQuality.Checked = True

        tbFFEXEVideoQuality.Enabled = True

    End Sub

    Private Sub cbFFEXEVideoCodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFFEXEVideoCodec.SelectedIndexChanged

        edFFEXEVBVBufferSize.Text = "0"
        edFFEXEVideoGOPSize.Text = "0"
        edFFEXEVideoBFramesCount.Text = "0"
        tbFFEXEVideoQuality.Minimum = 1
        tbFFEXEVideoQuality.Maximum = 31

        lbFFEXEVideoNotes.Text = "Notes: None."

        FFEXEDisableVideoMode()

        Select Case (cbFFEXEVideoCodec.SelectedIndex)

            ' Auto / None
            Case 0
                FFEXEEnableVideoABR()
                FFEXEEnableVideoQuality()

            ' DV
            Case 1

                lbFFEXEVideoNotes.Text = "Notes: Specify constraint settings for PAL or NTSC DV output."
                cbFFEXEVideoConstraint.SelectedIndex = 1

            ' FLV1
            Case 2
                FFEXEEnableVideoCBR()
                FFEXEEnableVideoQuality()

            ' GIF
            Case 3

                ' H263
            Case 4

                ' H264
            Case 5
                cbFFEXEH264Mode.SelectedIndex = 0
                cbFFEXEH264Level.SelectedIndex = 0
                cbFFEXEH264Preset.SelectedIndex = 0
                cbFFEXEH264Profile.SelectedIndex = 0
                tbFFEXEH264Quantizer.Value = 23
                cbFFEXEH264QuickTimeCompatibility.Checked = True
                cbFFEXEH264ZeroTolerance.Checked = False
                cbFFEXEH264WebFastStart.Checked = False

            ' HEVC
            Case 6
                cbFFEXEH264Mode.SelectedIndex = 0
                cbFFEXEH264Level.SelectedIndex = 0
                cbFFEXEH264Preset.SelectedIndex = 0
                cbFFEXEH264Profile.SelectedIndex = 0
                tbFFEXEH264Quantizer.Value = 23
                cbFFEXEH264QuickTimeCompatibility.Checked = True
                cbFFEXEH264ZeroTolerance.Checked = False
                cbFFEXEH264WebFastStart.Checked = False


            ' HuffYUV
            Case 7


                ' JPEG 2000
            Case 8


                ' JPEG-LS
            Case 9


                ' LJPEG
            Case 10


                ' MJPEG
            Case 11
                FFEXEEnableVideoQuality()

                tbFFEXEVideoQuality.Value = 4
                tbFFEXEVideoQuality_Scroll(Nothing, Nothing)

            ' MPEG-1
            Case 12
                FFEXEEnableVideoCBR()

                edFFEXEVideoBitrateMin.Text = "1000"
                edFFEXEVideoBitrateMax.Text = "2000"
                edFFEXEVideoTargetBitrate.Text = "1800"

            ' MPEG-2
            Case 13
                FFEXEEnableVideoCBR()

                edFFEXEVideoBitrateMin.Text = "2000"
                edFFEXEVideoBitrateMax.Text = "5000"
                edFFEXEVideoTargetBitrate.Text = "4000"

                edFFEXEVideoGOPSize.Text = "45"
                edFFEXEVideoBFramesCount.Text = "2"

            ' MPEG-4
            Case 14
                FFEXEEnableVideoCBR()

                edFFEXEVideoBitrateMin.Text = "2000"
                edFFEXEVideoBitrateMax.Text = "5000"
                edFFEXEVideoTargetBitrate.Text = "4000"

            ' PNG
            Case 15

                ' Theora
            Case 16
                FFEXEEnableVideoQuality()

                tbFFEXEVideoQuality.Minimum = 0
                tbFFEXEVideoQuality.Maximum = 10
                tbFFEXEVideoQuality.Value = 7
                tbFFEXEVideoQuality_Scroll(Nothing, Nothing)

                edFFEXEVideoTargetBitrate.Text = "2000"

            ' VP8
            Case 17
                FFEXEEnableVideoQuality()
                FFEXEEnableVideoCBR()

                tbFFEXEVideoQuality.Minimum = 4
                tbFFEXEVideoQuality.Maximum = 63
                tbFFEXEVideoQuality.Value = 10
                tbFFEXEVideoQuality_Scroll(Nothing, Nothing)

                edFFEXEVideoTargetBitrate.Text = "2000"

            ' VP9   
            Case 18

                FFEXEEnableVideoQuality()
                FFEXEEnableVideoCBR()

                tbFFEXEVideoQuality.Minimum = 4
                tbFFEXEVideoQuality.Maximum = 63
                tbFFEXEVideoQuality.Value = 10
                tbFFEXEVideoQuality_Scroll(Nothing, Nothing)

                edFFEXEVideoTargetBitrate.Text = "2000"

        End Select

    End Sub

    Private Sub FFEXEDisableAudioMode()

        rbFFEXEAudioModeABR.Enabled = False
        rbFFEXEAudioModeABR.Checked = False
        rbFFEXEAudioModeCBR.Enabled = False
        rbFFEXEAudioModeCBR.Checked = False
        rbFFEXEAudioModeQuality.Enabled = False
        rbFFEXEAudioModeQuality.Checked = False
        rbFFEXEAudioModeLossless.Enabled = False
        rbFFEXEAudioModeLossless.Checked = False

        tbFFEXEAudioQuality.Enabled = False
        cbFFEXEAudioBitrate.Enabled = False

    End Sub

    Private Sub FFEXEEnableAudioCBR()

        rbFFEXEAudioModeCBR.Enabled = True
        rbFFEXEAudioModeCBR.Checked = True

        cbFFEXEAudioBitrate.Enabled = True

    End Sub

    Private Sub FFEXEEnableAudioABR()

        rbFFEXEAudioModeABR.Enabled = True
        rbFFEXEAudioModeABR.Checked = True

        ' edFFEXEAudioTargetBitrate.Enabled = true
        ' edFFEXEAudioBitrateMax.Enabled = true
        ' edFFEXEAudioBitrateMin.Enabled = true

    End Sub

    Private Sub FFEXEEnableAudioQuality()

        rbFFEXEAudioModeQuality.Enabled = True
        rbFFEXEAudioModeQuality.Checked = True

        tbFFEXEAudioQuality.Enabled = True

    End Sub

    Private Sub FFEXEEnableAudioLossless()

        rbFFEXEAudioModeLossless.Enabled = True
        rbFFEXEAudioModeLossless.Checked = True

        ' tbFFEXEAudioQuality.Enabled = true

    End Sub

    Private Sub cbFFEXEAudioCodec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFFEXEAudioCodec.SelectedIndexChanged

        FFEXEDisableAudioMode()
        lbFFEXEAudioNotes.Text = "Notes: None."

        Select Case (cbFFEXEAudioCodec.SelectedIndex)
            ' Auto / None
            Case 0


                ' AAC
            Case 1
                FFEXEEnableAudioCBR()

            ' AC3
            Case 2
                FFEXEEnableAudioCBR()

            ' G722
            Case 3

                ' G726
            Case 4

                ' ADPCM
            Case 5

                ' ALAC
            Case 6
                FFEXEEnableAudioCBR()
                FFEXEEnableAudioLossless()

            ' AMR-NB
            Case 7

                ' AMR-WB
            Case 8

                ' E-AC3
            Case 9
                FFEXEEnableAudioCBR()

            ' FLAC
            Case 10

                lbFFEXEAudioNotes.Text = "Notes: Use Quality mode, trackbar set compression level (0-12, ."

                FFEXEEnableAudioQuality()

                tbFFEXEAudioQuality.Minimum = 0
                tbFFEXEAudioQuality.Maximum = 12
                tbFFEXEAudioQuality.Value = 5
                lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString()

            ' G723
            Case 11

                ' MP2
            Case 12
                FFEXEEnableAudioQuality()
                FFEXEEnableAudioCBR()

                tbFFEXEAudioQuality.Minimum = 0
                tbFFEXEAudioQuality.Maximum = 9
                tbFFEXEAudioQuality.Value = 0
                lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString()

            ' MP3
            Case 13
                FFEXEEnableAudioQuality()
                FFEXEEnableAudioCBR()

                tbFFEXEAudioQuality.Minimum = 0
                tbFFEXEAudioQuality.Maximum = 9
                tbFFEXEAudioQuality.Value = 4
                lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString()

            ' OPUS
            Case 14
                FFEXEEnableAudioCBR()

            ' PCM ALAW
            Case 15

                ' PCM F32BE
            Case 16

                ' PCM F32LE
            Case 17

                ' PCM F64BE
            Case 18

                ' PCM F64LE
            Case 19

                ' PCM MULAW
            Case 20

                ' PCM S16BE
            Case 21

                ' PCM S16BE Planar
            Case 22

                ' PCM S16LE
            Case 23

                ' PCM S16LE Planar
            Case 24

                ' PCM S24BE
            Case 25

                ' PCM S24LE
            Case 26

                ' PCM S24LE Planar
            Case 27

                ' PCM S32BE
            Case 28

                ' PCM S32LE
            Case 29

                ' PCM S32LE Planar
            Case 30

                ' PCM S8
            Case 31

                ' PCM S8 Planar
            Case 32

                ' PCM U16BE
            Case 33

                ' PCM U16LE
            Case 34

                ' PCM U24BE
            Case 35

                ' PCM U24LE
            Case 36

                ' PCM U32BE     
            Case 37

                ' PCM U32LE
            Case 38

                ' PCM U8
            Case 39

                ' Speex
            Case 40
                FFEXEEnableAudioQuality()
                FFEXEEnableAudioCBR()

                tbFFEXEAudioQuality.Minimum = 0
                tbFFEXEAudioQuality.Maximum = 10
                tbFFEXEAudioQuality.Value = 5
                tbFFEXEAudioQuality_Scroll(Nothing, Nothing)

            ' Vorbis
            Case 41
                FFEXEEnableAudioQuality()
                FFEXEEnableAudioCBR()

                tbFFEXEAudioQuality.Minimum = -1
                tbFFEXEAudioQuality.Maximum = 10
                tbFFEXEAudioQuality.Value = 5
                tbFFEXEAudioQuality_Scroll(Nothing, Nothing)

            ' WavPack
            Case 42
        End Select

    End Sub

    Private Sub tbFFEXEVideoQuality_Scroll(sender As Object, e As EventArgs) Handles tbFFEXEVideoQuality.Scroll

        lbFFEXEVideoQuality.Text = tbFFEXEVideoQuality.Value.ToString()

    End Sub

    Private Sub tbFFEXEH264Quantizer_Scroll(sender As Object, e As EventArgs) Handles tbFFEXEH264Quantizer.Scroll

        lbFFEXEH264Quantizer.Text = tbFFEXEH264Quantizer.Value.ToString()

    End Sub

    Private Sub tbFFEXEAudioQuality_Scroll(sender As Object, e As EventArgs) Handles tbFFEXEAudioQuality.Scroll

        lbFFEXEAudioQuality.Text = tbFFEXEAudioQuality.Value.ToString()

    End Sub

    Private Sub FillFFMPEGEXESettings(ByRef ffmpegOutput As VFFFMPEGEXEOutput)

        ffmpegOutput.Custom_AdditionalAudioArgs = edFFEXECustomParametersAudio.Text
        ffmpegOutput.Custom_AdditionalVideoArgs = edFFEXECustomParametersVideo.Text

        If (cbFFEXEUseOnlyAdditionalParameters.Checked) Then

            ffmpegOutput.Custom_AllFFMPEGArgs = edFFEXECustomParametersCommon.Text

        Else

            ffmpegOutput.Custom_AdditionalCommonArgs = edFFEXECustomParametersCommon.Text

        End If

        Select Case (cbFFEXEOutputFormat.SelectedIndex)
            Case 0
                ' 3G2
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Mobile3G2

            Case 1
                ' 3GP
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Mobile3GP

            Case 2
                ' AC3
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.AC3

            Case 3
                ' ADTS
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.ADTS

            Case 4
                ' AVI
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.AVI

            Case 5
                ' DTS
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.DTS

            Case 6
                ' DTS-HD
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.DTSHD

            Case 7
                ' DVD (VOB)
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VOB

            Case 8
                ' E-AC3
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.EAC3

            Case 9
                ' F4V
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.F4V

            Case 10
                ' FLAC
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLAC

            Case 11
                ' FLV
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.FLV

            Case 12
                ' GIF
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.GIF

            Case 13
                ' H263
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.H263

            Case 14
                ' H264
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.H264

            Case 15
                ' HEVC
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.HEVC

            Case 16
                ' Matroska
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.Matroska

            Case 17
                ' M4V
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.M4V

            Case 18
                ' MJPEG
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MJPEG

            Case 19
                ' MOV
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MOV

            Case 20
                ' MP2
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP2

            Case 21
                ' MP3
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP3

            Case 22
                ' MP4
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MP4

            Case 23
                ' MPEG
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEG

            Case 24
                ' MPEGTS
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MPEGTS

            Case 25
                ' MXF
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.MXF

            Case 26
                ' OGG
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.OGG

            Case 27
                ' OPUS
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.OPUS

            Case 28
                ' PSP MP4
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.PSP

            Case 29
                ' RAWVideo
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.RAWVideo

            Case 30
                ' SVCD
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.SVCD

            Case 31
                ' SWF
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.SWF

            Case 32
                ' TrueHD
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.TrueHD

            Case 33
                ' VC1
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VC1

            Case 34
                ' VCD
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.VCD

            Case 35
                ' WAV
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WAV

            Case 36
                ' WebM
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WebM

            Case 37
                ' WTV
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WTV

            Case 38
                ' WV (WavPack)
                ffmpegOutput.OutputMuxer = VFFFMPEGEXEOutputMuxer.WV

        End Select

        Select Case (cbFFEXEVideoCodec.SelectedIndex)

            Case 0
                ' Auto
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.Auto

            Case 1
                ' DV
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.DVVideo

            Case 2
                ' FLV1
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.FLV1

            Case 3
                ' GIF
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.GIF

            Case 4
                ' H263
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.H263

            Case 5
                ' H264
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.H264

            Case 6
                ' HEVC
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HEVC

            Case 7
                ' HuffYUV
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.HuffYUV

            Case 8
                ' JPEG 2000
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEG2000

            Case 9
                ' JPEG-LS
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.JPEGLS

            Case 10
                ' LJPEG
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.LJPEG

            Case 11
                ' MJPEG
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MJPEG

            Case 12
                ' MPEG-1
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG1Video

            Case 13
                ' MPEG-2
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG2Video

            Case 14
                ' MPEG-4
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.MPEG4

            Case 15
                ' PNG
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.PNG

            Case 16
                ' Theora
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.Theora

            Case 17
                ' VP8
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.VP8

            Case 18
                ' VP9
                ffmpegOutput.Video_Encoder = VFFFMPEGEXEVideoEncoder.VP9

        End Select

        Select Case (cbFFEXEAspectRatio.SelectedIndex)

            Case 0
                ffmpegOutput.Video_AspectRatioW = 0
                ffmpegOutput.Video_AspectRatioH = 1

            Case 1
                ffmpegOutput.Video_AspectRatioW = 1
                ffmpegOutput.Video_AspectRatioH = 1

            Case 2
                ffmpegOutput.Video_AspectRatioW = 4
                ffmpegOutput.Video_AspectRatioH = 3

            Case 3
                ffmpegOutput.Video_AspectRatioW = 16
                ffmpegOutput.Video_AspectRatioH = 9

        End Select

        If (cbFFEXEVideoResolutionOriginal.Checked) Then

            ffmpegOutput.Video_Width = 0
            ffmpegOutput.Video_Height = 0

        Else

            ffmpegOutput.Video_Width = Convert.ToInt32(edFFEXEVideoWidth.Text)
            ffmpegOutput.Video_Height = Convert.ToInt32(edFFEXEVideoHeight.Text)

        End If

        If (rbFFEXEVideoModeCBR.Checked) Then

            ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.CBR

        ElseIf (rbFFEXEVideoModeQuality.Checked) Then

            ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.Quality

        ElseIf (rbFFEXEVideoModeABR.Checked) Then

            ffmpegOutput.Video_Mode = VFFFMPEGEXEVideoMode.ABR

        End If

        ffmpegOutput.Video_Bitrate = Convert.ToInt32(edFFEXEVideoTargetBitrate.Text) * 1000
        ffmpegOutput.Video_MaxBitrate = Convert.ToInt32(edFFEXEVideoBitrateMax.Text) * 1000
        ffmpegOutput.Video_MinBitrate = Convert.ToInt32(edFFEXEVideoBitrateMin.Text) * 1000
        ffmpegOutput.Video_BufferSize = Convert.ToInt32(edFFEXEVBVBufferSize.Text)
        ffmpegOutput.Video_GOPSize = Convert.ToInt32(edFFEXEVideoGOPSize.Text)
        ffmpegOutput.Video_BFrames = Convert.ToInt32(edFFEXEVideoBFramesCount.Text)
        ffmpegOutput.Video_Interlace = cbFFEXEVideoInterlace.Checked
        ffmpegOutput.Video_Letterbox = cbFFEXEVideoResolutionLetterbox.Checked
        ffmpegOutput.Video_Quality = tbFFEXEVideoQuality.Value

        ffmpegOutput.Video_H264_Quantizer = tbFFEXEH264Quantizer.Value
        ffmpegOutput.Video_H264_Mode = cbFFEXEH264Mode.SelectedIndex
        ffmpegOutput.Video_H264_Preset = cbFFEXEH264Preset.SelectedIndex
        ffmpegOutput.Video_H264_Profile = cbFFEXEH264Profile.SelectedIndex
        ffmpegOutput.Video_H264_QuickTime_Compatibility = cbFFEXEH264QuickTimeCompatibility.Checked
        ffmpegOutput.Video_H264_ZeroTolerance = cbFFEXEH264ZeroTolerance.Checked
        ffmpegOutput.Video_H264_WebFastStart = cbFFEXEH264WebFastStart.Checked
        ffmpegOutput.Video_TVSystem = cbFFEXEVideoConstraint.SelectedIndex

        Select Case (cbFFEXEH264Level.SelectedIndex)

            Case 0
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.None

            Case 1
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level1

            Case 2
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level11

            Case 3
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level12

            Case 4
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level13

            Case 5
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level2

            Case 6
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level21

            Case 7
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level22

            Case 8
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level3

            Case 9
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level31

            Case 10
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level32

            Case 11
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level4

            Case 12
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level41

            Case 13
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level42

            Case 14
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level5

            Case 15
                ffmpegOutput.Video_H264_Level = VFFFMPEGEXEH264Level.Level51

        End Select

        Select Case (cbFFEXEAudioCodec.SelectedIndex)

            Case 0
                ' Auto
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Auto

            Case 1
                ' AAC
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AAC

            Case 2
                ' AC3
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AC3

            Case 3
                ' G722
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_g722

            Case 4
                ' G726
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_g726

            Case 5
                ' ADPCM
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.adpcm_ms

            Case 6
                ' ALAC
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.ALAC

            Case 7
                ' AMR-NB
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AMR_NB

            Case 8
                ' AMR-WB
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.AMR_WB

            Case 9
                ' E-AC3
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.EAC3

            Case 10
                ' FLAC
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.FLAC

            Case 11
                ' G723
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.G723_1

            Case 12
                ' MP2
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.MP2

            Case 13
                ' MP3
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.MP3

            Case 14
                ' OPUS
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.OPUS

            Case 15
                ' PCM ALAW
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_ALAW

            Case 16
                ' PCM F32BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F32BE

            Case 17
                ' PCM F32LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F32LE

            Case 18
                ' PCM F64BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F64BE

            Case 19
                ' PCM F64LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_F64LE

            Case 20
                ' PCM MULAW
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_MULAW

            Case 21
                ' PCM S16BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16BE

            Case 22
                ' PCM S16BE Planar
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16BE_Planar

            Case 23
                ' PCM S16LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16LE

            Case 24
                ' PCM S16LE Planar
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S16LE_Planar

            Case 25
                ' PCM S24BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24BE

            Case 26
                ' PCM S24LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24LE

            Case 27
                ' PCM S24LE Planar
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S24LE_Planar

            Case 28
                ' PCM S32BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32BE

            Case 29
                ' PCM S32LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32LE

            Case 30
                ' PCM S32LE Planar
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S32LE_Planar

            Case 31
                ' PCM S8
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S8

            Case 32
                ' PCM S8 Planar
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_S8_Planar

            Case 33
                ' PCM U16BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U16BE

            Case 34
                ' PCM U16LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U16LE

            Case 35
                ' PCM U24BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U24BE

            Case 36
                ' PCM U24LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U24LE

            Case 37
                ' PCM U32BE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U32BE

            Case 38
                ' PCM U32LE
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U32LE

            Case 39
                ' PCM U8
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.PCM_U8

            Case 40
                ' Speex
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Speex

            Case 41
                ' Vorbis
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.Vorbis

            Case 42
                ' WavPack
                ffmpegOutput.Audio_Encoder = VFFFMPEGEXEAudioEncoder.WavPack

        End Select

        If (cbFFEXEAudioChannels.SelectedIndex = 0) Then

            ffmpegOutput.Audio_Channels = 0

        Else

            ffmpegOutput.Audio_Channels = Convert.ToInt32(cbFFEXEAudioChannels.Text)

        End If

        If (cbFFEXEAudioSampleRate.SelectedIndex = 0) Then

            ffmpegOutput.Audio_SampleRate = 0

        Else

            ffmpegOutput.Audio_SampleRate = Convert.ToInt32(cbFFEXEAudioSampleRate.Text)

        End If


        If (cbFFEXEAudioBitrate.SelectedIndex = 0) Then

            ffmpegOutput.Audio_Bitrate = 0

        Else

            ffmpegOutput.Audio_Bitrate = Convert.ToInt32(cbFFEXEAudioBitrate.Text) * 1000

        End If

        ffmpegOutput.Audio_Quality = tbFFEXEAudioQuality.Value

        If (rbFFEXEAudioModeCBR.Checked) Then

            ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.CBR

        ElseIf (rbFFEXEAudioModeQuality.Checked) Then

            ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Quality

        ElseIf (rbFFEXEAudioModeABR.Checked) Then

            ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.ABR

        ElseIf (rbFFEXEAudioModeLossless.Checked) Then

            ffmpegOutput.Audio_Mode = VFFFMPEGEXEAudioMode.Lossless

        End If
    End Sub

    Public Delegate Sub FFMPEGInfoDelegate(ByVal message As String)

    Public Sub FFMPEGInfoDelegateMethod(ByVal message As String)

        mmLog.Text += "(NOT ERROR) FFMPEG " + message + Environment.NewLine

    End Sub

    Private Sub VideoEdit1_OnFFMPEGInfo(sender As Object, e As FFMPEGInfoEventArgs) Handles VideoEdit1.OnFFMPEGInfo

        Dim del As FFMPEGInfoDelegate = New FFMPEGInfoDelegate(AddressOf FFMPEGInfoDelegateMethod)
        BeginInvoke(del, e)

    End Sub

    Private Sub btEncryptionOpenFile_Click(sender As Object, e As EventArgs) Handles btEncryptionOpenFile.Click

        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then

            edEncryptionKeyFile.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub cbFFEXEH264Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFFEXEH264Mode.SelectedIndexChanged

        FFEXEDisableVideoMode()

        Select Case (cbFFEXEH264Mode.SelectedIndex)
            Case 0
                'CRF
            Case 1
                'CRF (limited bitrate)
                FFEXEEnableVideoCBR()
            Case 2
                'CBR
                FFEXEEnableVideoCBR()
            Case 3
                'ABR
                FFEXEEnableVideoABR()
            Case 4
                'Lossless
        End Select

    End Sub

    Private Sub linkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/support/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem")
        Process.Start(startInfo)

    End Sub

    Private Sub btAddInputFile2_Click(sender As Object, e As EventArgs) Handles btAddInputFile2.Click

        If (OpenDialog1.ShowDialog() = DialogResult.OK) Then

            Dim s = OpenDialog1.FileName

            edSourceFileToCut.Text = s

            Dim extNew = Path.GetExtension(s).ToLowerInvariant()
            Dim extOld = Path.GetExtension(edOutputFileCut.Text).ToLowerInvariant()
            edOutputFileCut.Text = edOutputFileCut.Text.Replace(extOld, extNew)

        End If

    End Sub

    Private Sub btSelectOutputCut_Click(sender As Object, e As EventArgs) Handles btSelectOutputCut.Click

        If (SaveDialog1.ShowDialog() = DialogResult.OK) Then

            edOutputFileCut.Text = SaveDialog1.FileName

        End If

    End Sub

    Private Sub btSelectOutputJoin_Click(sender As Object, e As EventArgs) Handles btSelectOutputJoin.Click

        If (SaveDialog1.ShowDialog() = DialogResult.OK) Then

            edOutputFileJoin.Text = SaveDialog1.FileName

        End If

    End Sub

    Private Sub btStartCut_Click(sender As Object, e As EventArgs) Handles btStartCut.Click

        VideoEdit1.FastEdit_CutFile(
                edSourceFileToCut.Text,
                Convert.ToInt32(edStartTimeCut.Text),
                Convert.ToInt32(edStopTimeCut.Text),
                edOutputFileCut.Text)

    End Sub

    Private Sub btStartJoin_Click(sender As Object, e As EventArgs) Handles btStartJoin.Click

        Dim files = New List(Of String)

        For Each item As Object In files
            files.Add(item.ToString())
        Next

        VideoEdit1.FastEdit_JoinFiles(
                files.ToArray(),
                edOutputFileCut.Text)

    End Sub

    Private Sub btStopJoin_Click(sender As Object, e As EventArgs) Handles btStopJoin.Click

        VideoEdit1.FastEdit_Stop()

    End Sub

    Private Sub btStopCut_Click(sender As Object, e As EventArgs) Handles btStopCut.Click

        VideoEdit1.FastEdit_Stop()

    End Sub

    Private Sub btClearList3_Click(sender As Object, e As EventArgs) Handles btClearList3.Click

        lbFiles2.Items.Clear()

    End Sub

    Private Sub imgTagCover_Click(sender As Object, e As EventArgs) Handles imgTagCover.Click

        If (openFileDialog2.ShowDialog() = DialogResult.OK) Then

            imgTagCover.LoadAsync(openFileDialog2.FileName)
            imgTagCover.Tag = openFileDialog2.FileName

        End If

    End Sub

    Private Sub btMuxStreamsSelectFile_Click(sender As Object, e As EventArgs) Handles btMuxStreamsSelectFile.Click

        If (OpenDialog1.ShowDialog() = DialogResult.OK) Then

            edMuxStreamsSourceFile.Text = OpenDialog1.FileName

        End If

    End Sub

    Private Sub btMuxStreamsAdd_Click(sender As Object, e As EventArgs) Handles btMuxStreamsAdd.Click

        Dim prefix
        If (cbMuxStreamsType.SelectedIndex = 0) Then

            prefix = "v"

        ElseIf (cbMuxStreamsType.SelectedIndex = 1) Then

            prefix = "a"

        Else

            prefix = cbMuxStreamsType.Text

        End If

        lbMuxStreamsList.Items.Add(prefix + ": " + edMuxStreamsSourceFile.Text)

    End Sub

    Private Sub btStartMux_Click(sender As Object, e As EventArgs) Handles btStartMux.Click

        Dim streams As List(Of VFVEFFMPEGStream) = New List(Of VFVEFFMPEGStream)

        For Each item As String In lbMuxStreamsList.Items

            Dim prefix = item.Substring(0, 1)
            Dim filename = item.Substring(3)

            Dim stream = New VFVEFFMPEGStream()
            stream.Filename = filename
            stream.ID = prefix

            streams.Add(stream)

        Next

        VideoEdit1.FastEdit_MuxStreams(streams, cbMuxStreamsShortest.Checked, edMuxStreamsOutputFile.Text)

    End Sub

    Private Sub btMuxStreamsClear_Click(sender As Object, e As EventArgs) Handles btMuxStreamsClear.Click

        lbMuxStreamsList.Items.Clear()

    End Sub

    Private Sub btMuxStreamsSelectOutput_Click(sender As Object, e As EventArgs) Handles btMuxStreamsSelectOutput.Click

        If (SaveDialog1.ShowDialog() = DialogResult.OK) Then

            edMuxStreamsOutputFile.Text = SaveDialog1.FileName

        End If

    End Sub

    Private Sub btStopMux_Click(sender As Object, e As EventArgs) Handles btStopMux.Click

        VideoEdit1.FastEdit_Stop()

    End Sub

    Private Sub cbDebugMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbDebugMode.CheckedChanged

        VideoEdit1.Debug_Mode = cbDebugMode.Checked

    End Sub

    Private Sub FFMPEGDownloadLinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel3.LinkClicked, LinkLabel2.LinkClicked, linkLabel10.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_ffmpeg_exe_x86_x64.exe")
        Process.Start(startInfo)

    End Sub

    Private Sub btAudioChannelMapperClear_Click(sender As Object, e As EventArgs) Handles btAudioChannelMapperClear.Click
        
        audioChannelMapperItems.Clear()
        lbAudioChannelMapperRoutes.Items.Clear()

    End Sub

    Private Sub btAudioChannelMapperAddNewRoute_Click(sender As Object, e As EventArgs) Handles btAudioChannelMapperAddNewRoute.Click

        Dim item = New AudioChannelMapperItem()
        item.SourceChannel = Convert.ToInt32(edAudioChannelMapperSourceChannel.Text)
        item.TargetChannel = Convert.ToInt32(edAudioChannelMapperTargetChannel.Text)
        item.TargetChannelVolume = tbAudioChannelMapperVolume.Value / 1000.0F

        audioChannelMapperItems.Add(item)

        lbAudioChannelMapperRoutes.Items.Add(
                "Source: " + edAudioChannelMapperSourceChannel.Text + ", target: " + edAudioChannelMapperTargetChannel.Text + ", volume: " + (tbAudioChannelMapperVolume.Value / 1000.0F).ToString("F2"))

    End Sub

    Private Sub linkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel11.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "https://visioforge.com/support/577349-Network-streaming-to-YouTube")
        Process.Start(startInfo)

    End Sub

    Private Sub btSubtitlesSelectFile_Click(sender As Object, e As EventArgs) Handles btSubtitlesSelectFile.Click

        If (openFileDialogSubtitles.ShowDialog() = DialogResult.OK) Then
            edSubtitlesFilename.Text = openFileDialogSubtitles.FileName
        End If

    End Sub

    Private Sub tbGPULightness_Scroll(sender As Object, e As EventArgs) Handles tbGPULightness.Scroll
        
        Dim intf As IVFGPUVideoEffectBrightness
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Brightness")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectBrightness(True, tbGPULightness.Value)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (Not IsNothing(intf)) Then
                intf.Value = tbGPULightness.Value
                intf.Update()
            End If
        End If

    End Sub

    Private Sub tbGPUSaturation_Scroll(sender As Object, e As EventArgs) Handles tbGPUSaturation.Scroll

        Dim intf As IVFGPUVideoEffectSaturation
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Saturation")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectSaturation(True, tbGPUSaturation.Value)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (Not IsNothing(intf)) Then
                intf.Value = tbGPUSaturation.Value
                intf.Update()
            End If
        End If

    End Sub

    Private Sub tbGPUContrast_Scroll(sender As Object, e As EventArgs) Handles tbGPUContrast.Scroll

        Dim intf As IVFGPUVideoEffectContrast
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Contrast")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectContrast(True, tbGPUContrast.Value)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (Not IsNothing(intf)) Then
                intf.Value = tbGPUContrast.Value
                intf.Update()
            End If
        End If

    End Sub

    Private Sub tbGPUDarkness_Scroll(sender As Object, e As EventArgs) Handles tbGPUDarkness.Scroll

        Dim intf As IVFGPUVideoEffectDarkness
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Darkness")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDarkness(True, tbGPUDarkness.Value)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (Not IsNothing(intf)) Then
                intf.Value = tbGPUDarkness.Value
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUGreyscale_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUGreyscale.CheckedChanged

        Dim intf As IVFGPUVideoEffectGrayscale
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Grayscale")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectGrayscale(cbGPUGreyscale.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUGreyscale.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUInvert_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUInvert.CheckedChanged

        Dim intf As IVFGPUVideoEffectInvert
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Invert")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectInvert(cbGPUInvert.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUInvert.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUNightVision_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUNightVision.CheckedChanged

        Dim intf As IVFGPUVideoEffectNightVision
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("NightVision")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectNightVision(cbGPUNightVision.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUNightVision.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUPixelate_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUPixelate.CheckedChanged

         Dim intf As IVFGPUVideoEffectPixelate
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Pixelate")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectPixelate(cbGPUPixelate.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUPixelate.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUDenoise_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUDenoise.CheckedChanged

        Dim intf As IVFGPUVideoEffectDenoise
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Denoise")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDenoise(cbGPUDenoise.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUDenoise.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUDeinterlace_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUDeinterlace.CheckedChanged

        Dim intf As IVFGPUVideoEffectDeinterlaceBlend
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("DeinterlaceBlend")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUDeinterlace.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUBlur_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUBlur.CheckedChanged

         Dim intf As IVFGPUVideoEffectBlur
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("Blur")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectBlur(cbGPUBlur.Checked, 50)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUBlur.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub cbGPUOldMovie_CheckedChanged(sender As Object, e As EventArgs) Handles cbGPUOldMovie.CheckedChanged

        Dim intf As IVFGPUVideoEffectOldMovie
        Dim effect = VideoEdit1.Video_Effects_GPU_Get("OldMovie")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectOldMovie(cbGPUOldMovie.Checked)
            VideoEdit1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUOldMovie.Checked
                intf.Update()
            End If
        End If

    End Sub
End Class

' ReSharper restore InconsistentNaming