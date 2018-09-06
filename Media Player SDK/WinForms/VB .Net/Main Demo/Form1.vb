Imports System.Globalization
Imports VisioForge.Types.GPUVideoEffects
Imports VisioForge.Types.VideoEffects ' ReSharper disable InconsistentNaming

Imports System.IO
Imports VisioForge.Tools.MediaInfo
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms

Public Class Form1
    Dim audioChannelMapperItems As List(Of AudioChannelMapperItem) = new List(Of AudioChannelMapperItem)

    ' Zoom
    Dim zoom As Double = 1.0

    Dim zoomShiftX As Integer = 0

    Dim zoomShiftY As Integer = 0

    Private ReadOnly MediaInfo As MediaInfoReader = New MediaInfoReader

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + MediaPlayer1.SDK_Version.ToString() + ", " + MediaPlayer1.SDK_State + "), VB.Net"

        ' set combobox indexes
        cbSourceMode.SelectedIndex = 0
        cbImageType.SelectedIndex = 1
        cbTextLogoAlign.SelectedIndex = 0
        cbTextLogoAntialiasing.SelectedIndex = 0
        cbTextLogoDrawMode.SelectedIndex = 0
        cbTextLogoEffectrMode.SelectedIndex = 0
        cbTextLogoGradMode.SelectedIndex = 0
        cbTextLogoShapeType.SelectedIndex = 0
        cbMotDetHLColor.SelectedIndex = 1
        cbBarcodeType.SelectedIndex = 0
        cbDirect2DRotate.SelectedIndex = 0

        rbMotionDetectionExProcessor.SelectedIndex = 1
        rbMotionDetectionExDetector.SelectedIndex = 1

        For Each device As String In MediaPlayer1.Audio_OutputDevices

            cbAudioOutputDevice.Items.Add(device)

        Next

        If (cbAudioOutputDevice.Items.Count > 0) Then

            cbAudioOutputDevice.SelectedIndex = 0

        End If

        MediaInfo.ReadFilters()

        For Each filter As String In MediaInfo.List_DirectShowFilters()

            cbCustomVideoDecoder.Items.Add(filter)
            cbCustomAudioDecoder.Items.Add(filter)
            cbCustomSplitter.Items.Add(filter)
            cbFilters.Items.Add(filter)

        Next

        If (cbFilters.Items.Count > 0) Then

            cbFilters.SelectedIndex = 0
            cbFilters_SelectedIndexChanged(Nothing, Nothing)

        End If

        rbEVR.Enabled = MediaPlayer1.Filter_Supported_EVR()
        rbVMR9.Enabled = MediaPlayer1.Filter_Supported_VMR9()

        If (rbEVR.Enabled) Then

            rbEVR.Checked = True

        ElseIf (Not rbVMR9.Enabled) Then

            rbVR.Checked = True

        End If

        rbVR_CheckedChanged(sender, e)

        ' ReSharper disable once CoVariantArrayConversion
        cbAudEqualizerPreset.Items.AddRange(MediaPlayer1.Audio_Effects_Equalizer_Presets().ToArray())
        cbAudEqualizerPreset.SelectedIndex = 0

        edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\"
        MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\"

    End Sub

    Private Sub tbLightness_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbLightness.Scroll

        Dim lightness As IVFVideoEffectLightness
        Dim effect = MediaPlayer1.Video_Effects_Get("Lightness")
        If (IsNothing(effect)) Then
            lightness = New VFVideoEffectLightness(True, tbLightness.Value)
            MediaPlayer1.Video_Effects_Add(lightness)
        Else
            lightness = effect
            If (lightness IsNot Nothing) Then
                lightness.Value = tbLightness.Value
            End If
        End If

    End Sub

    Private Sub tbSaturation_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSaturation.Scroll

        Dim saturation As IVFVideoEffectSaturation
        Dim effect = MediaPlayer1.Video_Effects_Get("Saturation")
        If (IsNothing(effect)) Then
            saturation = New VFVideoEffectSaturation(tbSaturation.Value)
            MediaPlayer1.Video_Effects_Add(saturation)
        Else

            saturation = effect
            If (saturation IsNot Nothing) Then
                saturation.Value = tbSaturation.Value
            End If
        End If

    End Sub

    Private Sub tbDarkness_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbDarkness.Scroll

        Dim darkness As IVFVideoEffectDarkness
        Dim effect = MediaPlayer1.Video_Effects_Get("Darkness")
        If (IsNothing(effect)) Then
            darkness = New VFVideoEffectDarkness(True, tbDarkness.Value)
            MediaPlayer1.Video_Effects_Add(darkness)
        Else
            darkness = effect
            If (darkness IsNot Nothing) Then
                darkness.Value = tbDarkness.Value
            End If
        End If

    End Sub

    Private Sub cbTextLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbTextLogo.CheckedChanged

        btTextLogoUpdateParams_Click(sender, e)

    End Sub

    Private Sub cbGreyscale_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbGreyscale.CheckedChanged

        Dim grayscale As IVFVideoEffectGrayscale
        Dim effect = MediaPlayer1.Video_Effects_Get("Grayscale")
        If (IsNothing(effect)) Then
            grayscale = New VFVideoEffectGrayscale(cbGreyscale.Checked)
            MediaPlayer1.Video_Effects_Add(grayscale)
        Else
            grayscale = effect
            If (grayscale IsNot Nothing) Then
                grayscale.Enabled = cbGreyscale.Checked
            End If
        End If

    End Sub

    Private Sub cbInvert_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbInvert.CheckedChanged

         Dim invert As IVFVideoEffectInvert
        Dim effect = MediaPlayer1.Video_Effects_Get("Invert")
        If (IsNothing(effect)) Then
            invert = New VFVideoEffectInvert(cbInvert.Checked)
            MediaPlayer1.Video_Effects_Add(invert)
        Else
            invert = effect
            If (invert IsNot Nothing) Then
                invert.Enabled = cbInvert.Checked
            End If
        End If

    End Sub

    Private Sub btFont_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btFont.Click

        If (fontDialog1.ShowDialog() = DialogResult.OK) Then

            btTextLogoUpdateParams_Click(sender, e)

        End If
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
        Dim effect = MediaPlayer1.Video_Effects_Get("TextLogo")
            If (IsNothing(effect)) Then
            textLogo = New VFVideoEffectTextLogo(cbTextLogo.Checked)
            MediaPlayer1.Video_Effects_Add(textLogo)
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
        textLogo.Font = fontDialog1.Font
        textLogo.FontColor = fontDialog1.Color

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

        If (Not cbTextLogoDateTime.Checked) Then
            textLogo.Mode = TextLogoMode.Text
        Else
            textLogo.Mode = TextLogoMode.DateTime
            textLogo.DateTimeMask = "yyyy-MM-dd. hh:mm:ss"
        End If

        textLogo.Update()

    End Sub

    Private Sub cbGraphicLogoShowAlways_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogoShowAlways.CheckedChanged

        edImageLogoStartTime.Enabled = Not cbImageLogoShowAlways.Checked
        edImageLogoStopTime.Enabled = Not cbImageLogoShowAlways.Checked
        lbGraphicLogoStartTime.Enabled = Not cbImageLogoShowAlways.Checked
        lbGraphicLogoStopTime.Enabled = Not cbImageLogoShowAlways.Checked

        cbImageLogo_CheckedChanged(sender, e)

    End Sub

    Private Sub btSelectImage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectImage.Click

        If (openFileDialog2.ShowDialog() = DialogResult.OK) Then

            edImageLogoFilename.Text = openFileDialog2.FileName

        End If

    End Sub

    Private Sub tbGraphicLogoTransp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbImageLogoTransp.Scroll

        cbImageLogo_CheckedChanged(sender, e)

    End Sub

    Private Sub cbGraphicLogoUseColorKey_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogoUseColorKey.CheckedChanged

        cbImageLogo_CheckedChanged(sender, e)

    End Sub

    Private Sub pnGraphicLogoColorKey_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnImageLogoColorKey.Click

        colorDialog1.Color = pnImageLogoColorKey.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then

            pnImageLogoColorKey.BackColor = colorDialog1.Color

        End If

    End Sub

    Private Sub cbImageLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbImageLogo.CheckedChanged

        If string.IsNullOrEmpty(edImageLogoLeft.Text)
            Return
        End If

        Dim imageLogo As IVFVideoEffectImageLogo
        Dim effect = MediaPlayer1.Video_Effects_Get("ImageLogo")
        If (IsNothing(effect)) Then
            imageLogo = New VFVideoEffectImageLogo(cbImageLogo.Checked)
            MediaPlayer1.Video_Effects_Add(imageLogo)
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

    Private Sub btOSDInit_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDInit.Click

        MediaPlayer1.OSD_Init()

    End Sub

    Private Sub btOSDDeinit_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDDeinit.Click

        MediaPlayer1.OSD_Destroy()

    End Sub

    Private Sub btOSDClearLayers_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDClearLayers.Click

        MediaPlayer1.OSD_Layers_Clear()
        lbOSDLayers.Items.Clear()

    End Sub

    Private Sub btOSDLayerAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDLayerAdd.Click

        MediaPlayer1.OSD_Layers_Create(Convert.ToInt32(edOSDLayerLeft.Text), Convert.ToInt32(edOSDLayerTop.Text), Convert.ToInt32(edOSDLayerWidth.Text), Convert.ToInt32(edOSDLayerHeight.Text))
        lbOSDLayers.Items.Add("layer " + Convert.ToString(lbOSDLayers.Items.Count + 1))

    End Sub

    Private Sub btOSDApplyLayer_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDApplyLayer.Click

        If (lbOSDLayers.SelectedIndex <> -1) Then

            MediaPlayer1.OSD_Layers_Apply(lbOSDLayers.SelectedIndex)

        End If

    End Sub

    Private Sub btOSDSelectImage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDSelectImage.Click

        If (openFileDialog2.ShowDialog() = DialogResult.OK) Then

            edOSDImageFilename.Text = openFileDialog2.FileName

        End If
    End Sub

    Private Sub pnOSDColorKey_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnOSDColorKey.Click

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then

            pnOSDColorKey.BackColor = colorDialog1.Color

        End If

    End Sub

    Private Sub btOSDImageDraw_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDImageDraw.Click

        If (lbOSDLayers.SelectedIndex <> -1) Then

            If (cbOSDImageTranspColor.Checked) Then

                MediaPlayer1.OSD_Layers_Draw_ImageFromFile(lbOSDLayers.SelectedIndex, edOSDImageFilename.Text, Convert.ToInt32(edOSDImageLeft.Text), Convert.ToInt32(edOSDImageTop.Text), True, pnOSDColorKey.BackColor)

            Else

                MediaPlayer1.OSD_Layers_Draw_ImageFromFile(lbOSDLayers.SelectedIndex, edOSDImageFilename.Text, Convert.ToInt32(edOSDImageLeft.Text), Convert.ToInt32(edOSDImageTop.Text), False, Color.Empty)

            End If
        End If

    End Sub

    Private Sub btOSDSelectFont_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDSelectFont.Click

        If (fontDialog1.ShowDialog() = DialogResult.OK) Then

            edOSDText.Font = fontDialog1.Font
            edOSDText.ForeColor = fontDialog1.Color

        End If

    End Sub

    Private Sub btOSDTextDraw_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDTextDraw.Click

        If (lbOSDLayers.SelectedIndex <> -1) Then

            Dim fnt As Font = edOSDText.Font
            Dim color As Color = edOSDText.ForeColor

            MediaPlayer1.OSD_Layers_Draw_Text(lbOSDLayers.SelectedIndex, Convert.ToInt32(edOSDTextLeft.Text), Convert.ToInt32(edOSDTextTop.Text), edOSDText.Text, fnt, color)

        End If

    End Sub

    Private Sub btOSDSetTransp_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btOSDSetTransp.Click

        If (lbOSDLayers.SelectedIndex <> -1) Then

            MediaPlayer1.OSD_Layers_SetTransparency(lbOSDLayers.SelectedIndex, tbOSDTranspLevel.Value)
            MediaPlayer1.OSD_Layers_Apply(lbOSDLayers.SelectedIndex)

        End If

    End Sub

    Private Sub rbVR_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbVR.CheckedChanged, rbVMR9.CheckedChanged, rbNone.CheckedChanged, rbEVR.CheckedChanged, rbDirect2D.CheckedChanged

        cbScreenFlipVertical.Enabled = rbVMR9.Checked Or rbDirect2D.Checked
        cbScreenFlipHorizontal.Enabled = rbVMR9.Checked Or rbDirect2D.Checked

        If (rbVMR9.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9

        ElseIf (rbEVR.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR

        ElseIf (rbVR.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer

        ElseIf (rbDirect2D.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D

        Else

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.None

        End If

    End Sub

    Private Sub btSelectScreenshotsFolder_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectScreenshotsFolder.Click

        If (folderBrowserDialog1.ShowDialog() = DialogResult.OK) Then

            edScreenshotsFolder.Text = folderBrowserDialog1.SelectedPath

        End If

    End Sub

    Private Sub btSaveScreenshot_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSaveScreenshot.Click

        Dim dt As DateTime = DateTime.Now

        Dim s As String = dt.Hour.ToString() + "_" + dt.Minute.ToString() + "_" + dt.Second.ToString() + "_" + dt.Millisecond.ToString()

        Dim customWidth = 0
        Dim customHeight = 0

        If (cbScreenshotResize.Checked) Then
            customWidth = Convert.ToInt32(edScreenshotWidth.Text)
            customHeight = Convert.ToInt32(edScreenshotHeight.Text)
        End If

        Select Case (cbImageType.SelectedIndex)

            Case 0
                MediaPlayer1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0, customWidth, customHeight)

            Case 1
                MediaPlayer1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, tbJPEGQuality.Value, customWidth, customHeight)

            Case 2
                MediaPlayer1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0, customWidth, customHeight)

            Case 3
                MediaPlayer1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0, customWidth, customHeight)

            Case 4
                MediaPlayer1.Frame_Save(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0, customWidth, customHeight)

        End Select

    End Sub

    Private Sub cbDVDControlTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbDVDControlTitle.SelectedIndexChanged

        If (cbDVDControlTitle.SelectedIndex <> -1) Then

            'fill info
            cbDVDControlAudio.Items.Clear()
            cbDVDControlSubtitles.Items.Clear()
            cbDVDControlChapter.Items.Clear()

            MediaInfo.DVD_Fill_Title_Info(cbDVDControlTitle.SelectedIndex)

            For i As Integer = 0 To MediaInfo.DVD_Title_NumberOfChapters - 1

                cbDVDControlChapter.Items.Add("Chapter " + Convert.ToString(i + 1))

            Next

            If (cbDVDControlChapter.Items.Count > 0) Then

                cbDVDControlChapter.SelectedIndex = 0

            End If

            For i As Integer = 0 To MediaInfo.DVD_Title_MainAttributes_NumberOfAudioStreams - 1

                MediaInfo.DVD_Fill_Title_Audio_Info(cbDVDControlTitle.SelectedIndex, i)
                Dim s As String = MediaInfo.DVD_Title_MainAttributes_AudioAttributes_AudioFormat

                s = s + " - "
                s = s + MediaInfo.DVD_Title_MainAttributes_AudioAttributes_NumberOfChannels.ToString + "ch" + " - "
                s = s + MediaInfo.DVD_Title_MainAttributes_AudioAttributes_LanguageS

                cbDVDControlAudio.Items.Add(s)

            Next

            If (cbDVDControlAudio.Items.Count > 0) Then

                cbDVDControlAudio.SelectedIndex = 0

            End If

            cbDVDControlSubtitles.Items.Add("Disabled")
            For i As Integer = 0 To MediaInfo.DVD_Title_MainAttributes_NumberOfSubpictureStreams - 1

                MediaInfo.DVD_Fill_Title_Subpicture_Info(cbDVDControlTitle.SelectedIndex, i)
                cbDVDControlSubtitles.Items.Add(MediaInfo.DVD_Title_MainAttributes_SubpictureAttributes_LanguageS)

            Next

            cbDVDControlSubtitles.SelectedIndex = 0

            'if null we just enumerate titles and chapters
            If (IsDBNull(sender)) Then

                'play title
                MediaPlayer1.DVD_Title_Play(cbDVDControlTitle.SelectedIndex)
                tbTimeline.Maximum = MediaPlayer1.DVD_Title_GetDurationS()

            End If
        End If

    End Sub

    Private Sub lbDVDTitles_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lbDVDTitles.Click

        If (lbDVDTitles.SelectedIndex <> -1) Then

            cbDVDAudio.Items.Clear()
            cbDVDSubtitles.Items.Clear()

            MediaInfo.DVD_Fill_Title_Info(lbDVDTitles.SelectedIndex)

            Dim s As String = MediaInfo.DVD_Title_MainAttributes_VideoAttributes_Compression + " "
            s = s + MediaInfo.DVD_Title_MainAttributes_VideoAttributes_SourceResolutionX + "x" + MediaInfo.DVD_Title_MainAttributes_VideoAttributes_SourceResolutionY + " "
            s = s + MediaInfo.DVD_Title_MainAttributes_VideoAttributes_AspectX + ":" + MediaInfo.DVD_Title_MainAttributes_VideoAttributes_AspectY + " "

            edDVDVideo.Text = s

            For i As Integer = 0 To MediaInfo.DVD_Title_MainAttributes_NumberOfAudioStreams - 1

                MediaInfo.DVD_Fill_Title_Audio_Info(lbDVDTitles.SelectedIndex, i)
                s = MediaInfo.DVD_Title_MainAttributes_AudioAttributes_AudioFormat

                s = s + " - "
                s = s + MediaInfo.DVD_Title_MainAttributes_AudioAttributes_NumberOfChannels + "ch" + " - "
                s = s + MediaInfo.DVD_Title_MainAttributes_AudioAttributes_LanguageS

                cbDVDAudio.Items.Add(s)

            Next

            If (cbDVDAudio.Items.Count > 0) Then

                cbDVDAudio.SelectedIndex = 0

            End If

            For i As Integer = 0 To MediaInfo.DVD_Title_MainAttributes_NumberOfSubpictureStreams - 1

                MediaInfo.DVD_Fill_Title_Subpicture_Info(lbDVDTitles.SelectedIndex, i)
                cbDVDSubtitles.Items.Add(MediaInfo.DVD_Title_MainAttributes_SubpictureAttributes_LanguageS)

            Next

            If (cbDVDSubtitles.Items.Count > 0) Then

                cbDVDSubtitles.SelectedIndex = 0

            End If

        End If

    End Sub

    Private Sub tbBalance1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbBalance1.Scroll

        If (cbAudioStream1.Checked Or MediaPlayer1.Audio_Streams_AllInOne()) Then

            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value)

        End If

    End Sub

    Private Sub tbBalance2_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbBalance2.Scroll

        If (cbAudioStream2.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Balance_Set(1, tbBalance2.Value)

        End If

    End Sub

    Private Sub tbBalance3_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbBalance3.Scroll

        If (cbAudioStream3.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Balance_Set(2, tbBalance3.Value)

        End If

    End Sub

    Private Sub tbBalance4_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbBalance4.Scroll

        If (cbAudioStream4.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Balance_Set(3, tbBalance4.Value)

        End If

    End Sub

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSpeed.Scroll

        If (MediaPlayer1.Source_Mode <> VFMediaPlayerSource.DVD_DS) Then

            MediaPlayer1.SetSpeed(tbSpeed.Value / 10.0)

        Else

            MediaPlayer1.DVD_SetSpeed(tbSpeed.Value / 10.0, False)

        End If

    End Sub

    Private Sub tbVolume1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbVolume1.Scroll

        If (cbAudioStream1.Checked or MediaPlayer1.Audio_Streams_AllInOne()) Then

            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value)

        End If

    End Sub

    Private Sub tbTimeline_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbTimeline.Scroll

        If (Convert.ToInt32(timer1.Tag) = 0) Then

            MediaPlayer1.Position_Set_Time(tbTimeline.Value * 1000)

        End If

    End Sub

    Private Sub tbVolume2_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbVolume2.Scroll

        If (cbAudioStream2.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Volume_Set(1, tbVolume2.Value)

        End If

    End Sub

    Private Sub tbVolume3_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbVolume3.Scroll

        If (cbAudioStream3.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Volume_Set(2, tbVolume3.Value)

        End If

    End Sub

    Private Sub tbVolume4_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbVolume4.Scroll

        If (cbAudioStream4.Checked) Then

            MediaPlayer1.Audio_OutputDevice_Volume_Set(3, tbVolume4.Value)

        End If

    End Sub

    Dim memoryFileStream As FileStream = Nothing

    Private Sub LoadToMemory()

        If Not IsNothing(memoryFileStream) Then

            memoryFileStream.Dispose()
            memoryFileStream = Nothing

        End If

        memoryFileStream = New FileStream(edFilenameOrURL.Text, FileMode.Open)
        Dim stream As ManagedIStream = New ManagedIStream(memoryFileStream)

        ' specifing settings
        ' MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
        MediaPlayer1.Source_Stream = stream
        MediaPlayer1.Source_Stream_Size = memoryFileStream.Length

        ' video and audio present in file. tune this settings to play audio files or video files without audio
        MediaPlayer1.Source_Stream_VideoPresent = True
        MediaPlayer1.Source_Stream_AudioPresent = True

    End Sub

    Private Sub btReadInfo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btReadInfo.Click

        mmInfo.Clear()

        'clear audio controls
        cbAudioStream1.Enabled = False
        cbAudioStream2.Enabled = False
        cbAudioStream3.Enabled = False
        cbAudioStream4.Enabled = False
        tbVolume1.Enabled = False
        tbVolume2.Enabled = False
        tbVolume3.Enabled = False
        tbVolume4.Enabled = False
        tbBalance1.Enabled = False
        tbBalance2.Enabled = False
        tbBalance3.Enabled = False
        tbBalance4.Enabled = False

        MediaInfo.Filename = edFilenameOrURL.Text

        Select Case (cbSourceMode.SelectedIndex)
            Case 0
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV
            Case 1
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG
            Case 2
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS
            Case 3
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_VLC
            Case 4
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS
            Case 5
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.BluRay
            Case 6
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS
            Case 7
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_FFMPEG
            Case 8
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.MMS_WMV_DS
            Case 9
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_FFMPEG
            Case 10
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_VLC
            Case 11
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Encrypted_File_DS
        End Select

        If ((MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS) Or
            (MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG) Or
            (MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV) Or
            (MediaPlayer1.Source_Mode = VFMediaPlayerSource.Encrypted_File_DS)) Then

            ' "Read info" button
            If IsDBNull(sender) Then

                Dim errorCode As VFFilePlaybackError
                Dim errorText As String = ""

                If (MediaInfoReader.IsFilePlayable(edFilenameOrURL.Text, errorCode, errorText)) Then

                    mmInfo.Text += "This file is playable" + Environment.NewLine

                Else

                    mmInfo.Text += "This file is not playable" + Environment.NewLine

                End If
            End If

            Dim keyType As VFEncryptionKeyType
            Dim key As Object
            If (rbEncryptionKeyString.Checked) Then

                keyType = VFEncryptionKeyType.String
                key = edEncryptionKeyString.Text

            ElseIf (rbEncryptionKeyFile.Checked) Then

                keyType = VFEncryptionKeyType.File
                key = edEncryptionKeyFile.Text

            Else

                keyType = VFEncryptionKeyType.Binary
                key = MediaPlayer.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text)

            End If

            MediaInfo.ReadFileInfo(MediaPlayer1.Source_Mode = VFMediaPlayerSource.Encrypted_File_DS, key, keyType, cbUseLibMediaInfo.Checked)

            For i As Integer = 0 To MediaInfo.Video_Streams_Count() - 1

                mmInfo.Text += String.Empty + Environment.NewLine
                mmInfo.Text += "Video #" + Convert.ToString(i + 1) + Environment.NewLine
                mmInfo.Text += "Codec: " + MediaInfo.Video_Codec(i) + Environment.NewLine
                mmInfo.Text += "Duration: " + MediaInfo.Video_Duration(i).ToString() + Environment.NewLine
                mmInfo.Text += "Width: " + MediaInfo.Video_Width(i).ToString() + Environment.NewLine
                mmInfo.Text += "Height: " + MediaInfo.Video_Height(i).ToString() + Environment.NewLine
                mmInfo.Text += "FOURCC: " + MediaInfo.Video_FourCC(i) + Environment.NewLine
                mmInfo.Text += "Aspect Ratio: " + MediaInfo.Video_AspectRatioStr(i) + Environment.NewLine
                mmInfo.Text += "Frame rate: " + MediaInfo.Video_FrameRate(i).ToString() + Environment.NewLine
                mmInfo.Text += "Bitrate: " + MediaInfo.Video_Bitrate(i).ToString() + Environment.NewLine
                mmInfo.Text += "Frames count: " + MediaInfo.Video_FramesCount(i).ToString() + Environment.NewLine

            Next

            For i As Integer = 0 To MediaInfo.Audio_Streams_Count() - 1

                mmInfo.Text += String.Empty + Environment.NewLine
                mmInfo.Text += "Audio #" + Convert.ToString(i + 1) + Environment.NewLine
                mmInfo.Text += "Codec: " + MediaInfo.Audio_Codec(i) + Environment.NewLine
                mmInfo.Text += "Codec info: " + MediaInfo.Audio_CodecInfo(i) + Environment.NewLine
                mmInfo.Text += "Duration: " + MediaInfo.Audio_Duration(i) + Environment.NewLine
                mmInfo.Text += "Bitrate: " + MediaInfo.Audio_Bitrate(i).ToString() + Environment.NewLine
                mmInfo.Text += "Channels: " + MediaInfo.Audio_Channels(i).ToString() + Environment.NewLine
                mmInfo.Text += "Sample rate: " + MediaInfo.Audio_SampleRate(i).ToString() + Environment.NewLine
                mmInfo.Text += "BPS: " + MediaInfo.Audio_BPS(i).ToString() + Environment.NewLine

            Next

            For i As Integer = 0 To MediaInfo.Text_Streams_Count() - 1

                mmInfo.Text += String.Empty + Environment.NewLine
                mmInfo.Text += "Text #" + Convert.ToString(i + 1) + Environment.NewLine
                mmInfo.Text += "Codec: " + MediaInfo.Text_Codec(i) + Environment.NewLine
                mmInfo.Text += "Name: " + MediaInfo.Text_Name(i) + Environment.NewLine
                mmInfo.Text += "Language: " + MediaInfo.Text_Language(i) + Environment.NewLine

            Next

            ' timeline
            If (MediaInfo.Video_Streams_Count() > 0) Then

                tbTimeline.Maximum = (MediaInfo.Video_DurationMSec(0) / 1000)

            ElseIf (MediaInfo.Audio_Streams_Count() > 0) Then

                tbTimeline.Maximum = (MediaInfo.Audio_DurationMSec(0) / 1000)

            End If

            ' set audio streams tab
            Dim count As Integer = MediaInfo.Audio_Streams_Count()
            Dim oneOutput As Boolean = MediaInfo.Audio_Streams_AllInOne

            If (count = 0) Then

                Return

            End If

            cbAudioStream1.Enabled = True
            cbAudioStream1.Checked = True
            tbVolume1.Enabled = True
            tbBalance1.Enabled = True

            If (count > 1) Then

                cbAudioStream2.Enabled = True
                cbAudioStream2.Checked = False
                tbVolume2.Enabled = Not oneOutput
                tbBalance2.Enabled = Not oneOutput

            End If

            If (count > 2) Then

                cbAudioStream3.Enabled = True
                cbAudioStream3.Checked = False
                tbVolume3.Enabled = Not oneOutput
                tbBalance3.Enabled = Not oneOutput

            End If

            If (count > 3) Then

                cbAudioStream4.Enabled = True
                cbAudioStream4.Checked = False
                tbVolume4.Enabled = Not oneOutput
                tbBalance4.Enabled = Not oneOutput

            End If

            ' additional audio streams added from Other audio files
            Dim count2 As Integer = MediaPlayer1.Audio_AdditionalStreams_GetCount()

            If (count2 = 0) Then

                Return

            End If

            Dim count3 As Integer = count2

            If ((count2 + count >= 4) And (count3 > 0)) Then

                cbAudioStream4.Enabled = True
                cbAudioStream4.Checked = True
                tbVolume4.Enabled = True
                tbBalance4.Enabled = True
                count3 = count3 - 1

            End If

            If ((count2 + count >= 3) And (count3 > 0)) Then

                cbAudioStream3.Enabled = True
                cbAudioStream3.Checked = True
                tbVolume3.Enabled = True
                tbBalance3.Enabled = True
                count3 = count3 - 1

            End If

            If ((count2 + count >= 2) And (count3 > 0)) Then

                cbAudioStream2.Enabled = True
                cbAudioStream2.Checked = True
                tbVolume2.Enabled = True
                tbBalance2.Enabled = True
                count3 = count3 - 1

            End If

            If ((count2 + count >= 1) And (count3 > 0)) Then

                cbAudioStream1.Enabled = True
                cbAudioStream1.Checked = True
                tbVolume1.Enabled = True
                tbBalance1.Enabled = True

            End If

        ElseIf (MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS) Then

            cbAudioStream1.Enabled = True
            cbAudioStream1.Checked = True
            tbVolume1.Enabled = True
            tbBalance1.Enabled = True

            edDVDVideo.Text = String.Empty
            lbDVDTitles.Items.Clear()
            cbDVDAudio.Items.Clear()
            cbDVDSubtitles.Items.Clear()

            cbDVDControlTitle.Items.Clear()
            cbDVDControlChapter.Items.Clear()
            cbDVDControlAudio.Items.Clear()
            cbDVDControlSubtitles.Items.Clear()

            MediaInfo.ReadDVDInfo()

            For i As Integer = 0 To MediaInfo.DVD_Disc_NumOfTitles - 1

                lbDVDTitles.Items.Add("Title " + Convert.ToString(i + 1))
                cbDVDControlTitle.Items.Add("Title " + Convert.ToString(i + 1))

            Next

        Else

            cbAudioStream1.Enabled = True
            cbAudioStream1.Checked = True
            tbVolume1.Enabled = True
            tbBalance1.Enabled = True

        End If

    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles timer1.Tick

        timer1.Tag = 1
        tbTimeline.Maximum = (MediaPlayer1.Duration_Time() / 1000.0)

        Dim value As Integer = (MediaPlayer1.Position_Get_Time() / 1000.0)
        If ((value > 0) And (value < tbTimeline.Maximum)) Then

            tbTimeline.Value = value

        End If

        lbTime.Text = MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum)

        If (MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS) Then

            If (MediaPlayer1.DVD_Chapter_GetCurrent() <> cbDVDControlChapter.SelectedIndex And cbDVDControlChapter.SelectedIndex <> -1) Then

                cbDVDControlChapter.SelectedIndex = MediaPlayer1.DVD_Chapter_GetCurrent()

            End If

        End If

        timer1.Tag = 0

    End Sub

    Private Sub FillAdjustRanges()

        'updating adjust settings
        Dim max As Single
        Dim defaultValue As Single
        Dim min As Single
        Dim step1 As Single = 0

        If MediaPlayer1.Video_Renderer_VideoAdjust_GetRanges(VFVideoRendererAdjustment.Brightness, min, max, defaultValue, step1) Then

            tbAdjBrightness.Minimum = min * 10
            tbAdjBrightness.Maximum = max * 10
            tbAdjBrightness.SmallChange = step1 * 10

            Dim def As Integer = defaultValue * 10

            If (def > max * 10) Then

                def = max * 10

            End If

            If (def < min * 10) Then

                def = min * 10

            End If

            tbAdjBrightness.Value = def
            lbAdjBrightnessMin.Text = "Min: " + Convert.ToString(min)
            lbAdjBrightnessMax.Text = "Max: " + Convert.ToString(max)
            lbAdjBrightnessCurrent.Text = "Current: " + Convert.ToString(defaultValue)

        End If

        If (MediaPlayer1.Video_Renderer_VideoAdjust_GetRanges(VFVideoRendererAdjustment.Hue, min, max, step1, defaultValue)) Then

            tbAdjHue.Minimum = min * 10
            tbAdjHue.Maximum = max * 10
            tbAdjHue.SmallChange = step1 * 10

            Dim def As Integer = defaultValue * 10

            If (def > max * 10) Then

                def = max * 10

            End If

            If (def < min * 10) Then

                def = min * 10

            End If

            tbAdjHue.Value = def
            lbAdjHueMin.Text = "Min: " + Convert.ToString(min)
            lbAdjHueMax.Text = "Max: " + Convert.ToString(max)
            lbAdjHueCurrent.Text = "Current: " + Convert.ToString(defaultValue)

        End If

        If (MediaPlayer1.Video_Renderer_VideoAdjust_GetRanges(VFVideoRendererAdjustment.Saturation, min, max, step1, defaultValue)) Then

            tbAdjSaturation.Minimum = min * 10
            tbAdjSaturation.Maximum = max * 10
            tbAdjSaturation.SmallChange = step1 * 10

            Dim def As Integer = defaultValue * 10

            If (def > max * 10) Then

                def = max * 10
            End If

            If (def < min * 10) Then

                def = min * 10
            End If

            tbAdjSaturation.Value = def
            lbAdjSaturationMin.Text = "Min: " + Convert.ToString(min)
            lbAdjSaturationMax.Text = "Max: " + Convert.ToString(max)
            lbAdjSaturationCurrent.Text = "Current: " + Convert.ToString(defaultValue)

        End If

        If (MediaPlayer1.Video_Renderer_VideoAdjust_GetRanges(VFVideoRendererAdjustment.Contrast, min, max, step1, defaultValue)) Then

            tbAdjContrast.Minimum = min * 10
            tbAdjContrast.Maximum = max * 10
            tbAdjContrast.SmallChange = step1 * 10

            Dim def As Integer = defaultValue * 10

            If (def > max * 10) Then

                def = max * 10

            End If

            If (def < min * 10) Then

                def = min * 10

            End If

            tbAdjContrast.Value = def
            lbAdjContrastMin.Text = "Min: " + Convert.ToString(min)
            lbAdjContrastMax.Text = "Max: " + Convert.ToString(max)
            lbAdjContrastCurrent.Text = "Current: " + Convert.ToString(defaultValue)

        End If

    End Sub

    Private Sub ConfigureObjectTracking()
        If (cbMotionDetectionEx.Checked) Then
            MediaPlayer1.Motion_DetectionEx = New MotionDetectionExSettings()
            MediaPlayer1.Motion_DetectionEx.ProcessorType = rbMotionDetectionExProcessor.SelectedIndex
            MediaPlayer1.Motion_DetectionEx.DetectorType = rbMotionDetectionExDetector.SelectedIndex
        Else
            MediaPlayer1.Motion_DetectionEx = Nothing
        End If
    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStart.Click

        zoom = 1.0
        zoomShiftX = 0
        zoomShiftY = 0

        mmLog.Clear()

        MediaPlayer1.Info_UseLibMediaInfo = cbUseLibMediaInfo.Checked

        If (rbVideoDecoderDefault.Checked) Then

            MediaPlayer1.Custom_Video_Decoder = String.Empty

        ElseIf (rbVideoDecoderFFDShow.Checked) Then

            MediaPlayer1.Custom_Video_Decoder = "ffdshow Video Decoder"

        ElseIf (rbVideoDecoderMS.Checked) Then

            MediaPlayer1.Custom_Video_Decoder = "Microsoft DTV-DVD Video Decoder"

        ElseIf (rbVideoDecoderVFH264.Checked) Then

            MediaPlayer1.Custom_Video_Decoder = "VisioForge H264 Decoder"

        ElseIf (rbVideoDecoderCustom.Checked) Then

            MediaPlayer1.Custom_Video_Decoder = cbCustomVideoDecoder.Text

        End If
        
        If (rbSplitterCustom.Checked) Then

            MediaPlayer1.Custom_Splitter = cbCustomSplitter.Text

        Else

            MediaPlayer1.Custom_Splitter = String.Empty

        End If

        If (rbAudioDecoderDefault.Checked) Then

            MediaPlayer1.Custom_Audio_Decoder = String.Empty

        ElseIf (rbAudioDecoderCustom.Checked) Then

            MediaPlayer1.Custom_Audio_Decoder = cbCustomAudioDecoder.Text

        End If

        If (lbSourceFiles.Items.Count = 0) Then

            MessageBox.Show("Playlist is empty!")

        End If

        For Each item As Object In lbSourceFiles.Items

            MediaPlayer1.FilenamesOrURL.Add(item.ToString())

        Next

        MediaPlayer1.Loop = cbLoop.Checked
        MediaPlayer1.Audio_PlayAudio = cbPlayAudio.Checked

        MediaPlayer1.Video_Renderer.Aspect_Ratio_X = Convert.ToInt32(edAspectRatioX.Text)
        MediaPlayer1.Video_Renderer.Aspect_Ratio_Y = Convert.ToInt32(edAspectRatioY.Text)
        MediaPlayer1.Video_Renderer.Aspect_Ratio_Override = cbAspectRatioUseCustom.Checked

        Select Case (cbSourceMode.SelectedIndex)
            Case 0
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV
            Case 1
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG
            Case 2
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS
            Case 3
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_VLC
            Case 4
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS
            Case 5
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.BluRay
            Case 6
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS
                LoadToMemory()
            Case 7
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_FFMPEG
                LoadToMemory()
            Case 8
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.MMS_WMV_DS
            Case 9
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_FFMPEG
            Case 10
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_VLC
            Case 11
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.Encrypted_File_DS
        End Select

        btReadInfo_Click(sender, e)

        MediaPlayer1.Audio_OutputDevice = cbAudioOutputDevice.Text

        If (rbVR.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer

        ElseIf (rbVMR9.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9

        ElseIf (rbEVR.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR

        ElseIf (rbDirect2D.Checked) Then

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.Direct2D

        Else

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.None

        End If

        MediaPlayer1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text)
        MediaPlayer1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked
        MediaPlayer1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked

        MediaPlayer1.Debug_Mode = cbDebugMode.Checked

        ' Audio enhancement
        MediaPlayer1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.Checked
        If (MediaPlayer1.Audio_Enhancer_Enabled) Then

            MediaPlayer1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked)
            MediaPlayer1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked)

            ApplyAudioInputGains()
            ApplyAudioOutputGains()

            MediaPlayer1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value)

        End If

        ' Audio channels mapping
        If (cbAudioChannelMapperEnabled.Checked) Then
            MediaPlayer1.Audio_Channel_Mapper = New AudioChannelMapperSettings()
            MediaPlayer1.Audio_Channel_Mapper.Routes = audioChannelMapperItems.ToArray()
            MediaPlayer1.Audio_Channel_Mapper.OutputChannelsCount = Convert.ToInt32(edAudioChannelMapperOutputChannels.Text)
        Else
            MediaPlayer1.Audio_Channel_Mapper = Nothing
        End if

        ' Audio processing
        MediaPlayer1.Audio_Effects_Clear(-1)
        MediaPlayer1.Audio_Effects_Enabled = cbAudioEffectsEnabled.Checked

        If (MediaPlayer1.Audio_Effects_Enabled) Then

            MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1)
            MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1)
            MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.Checked, -1, -1)
            MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1)
            MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1)

        End If

        ' Multiscreen
        MediaPlayer1.MultiScreen_Clear()
        MediaPlayer1.MultiScreen_Enabled = cbUseAdditionalScreens.Checked

        If (MediaPlayer1.MultiScreen_Enabled) Then

            MediaPlayer1.MultiScreen_AddScreen(pnScreen1.Handle, pnScreen1.Width, pnScreen1.Height)
            MediaPlayer1.MultiScreen_AddScreen(pnScreen2.Handle, pnScreen2.Width, pnScreen2.Height)

        End If

        ' VU meters
        MediaPlayer1.Audio_VUMeter_Pro_Enabled = cbVUMeterPro.Checked

        If (MediaPlayer1.Audio_VUMeter_Pro_Enabled) Then

            MediaPlayer1.Audio_VUMeter_Pro_Volume = tbVUMeterAmplification.Value

            volumeMeter1.Boost = tbVUMeterBoost.Value / 10.0F
            volumeMeter2.Boost = tbVUMeterBoost.Value / 10.0F

            waveformPainter1.Boost = tbVUMeterBoost.Value / 10.0F
            waveformPainter2.Boost = tbVUMeterBoost.Value / 10.0F

        End If

        ' Video effects
        MediaPlayer1.Video_Effects_Enabled = cbEffects.Checked
        MediaPlayer1.Video_Effects_Clear()

        ' Deinterlace
        If cbDeinterlace.Checked Then

            If rbDeintBlendEnabled.Checked Then
                Dim blend As IVFVideoEffectDeinterlaceBlend
                Dim effect = MediaPlayer1.Video_Effects_Get("DeinterlaceBlend")
                If (IsNothing(effect)) Then
                    blend = New VFVideoEffectDeinterlaceBlend(True)
                    MediaPlayer1.Video_Effects_Add(blend)
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
                Dim effect = MediaPlayer1.Video_Effects_Get("DeinterlaceCAVT")
                If (IsNothing(effect)) Then
                    cavt = New VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.Checked, Convert.ToInt32(edDeintCAVTThreshold.Text))
                    MediaPlayer1.Video_Effects_Add(cavt)
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
                Dim effect = MediaPlayer1.Video_Effects_Get("DeinterlaceTriangle")
                If (effect Is Nothing) Then
                    triangle = New VFVideoEffectDeinterlaceTriangle(True, Convert.ToByte(edDeintTriangleWeight.Text))
                    MediaPlayer1.Video_Effects_Add(triangle)
                Else
                    triangle = effect
                End If

                If (triangle Is Nothing) Then
                    MessageBox.Show("Unable to configure deinterlace triangle effect.")
                    Return
                End If

                triangle.Weight = Convert.ToByte(edDeintTriangleWeight.Text)
            End If

        End If

        'Denoise
        If cbDenoise.Checked Then

            If (rbDenoiseCAST.Checked) Then
                Dim cast As IVFVideoEffectDenoiseCAST
                Dim effect = MediaPlayer1.Video_Effects_Get("DenoiseCAST")
                If (effect is Nothing) Then
                    cast = New VFVideoEffectDenoiseCAST(True)
                    MediaPlayer1.Video_Effects_Add(cast)
                Else
                    cast = effect
                End If

                If (cast Is Nothing) Then
                    MessageBox.Show("Unable to configure denoise CAST effect.")
                    Return
                End If
            Else
                Dim mosquito As IVFVideoEffectDenoiseMosquito
                Dim effect = MediaPlayer1.Video_Effects_Get("DenoiseMosquito")
                If (effect is Nothing) Then
                    mosquito = New VFVideoEffectDenoiseMosquito(True)
                    MediaPlayer1.Video_Effects_Add(mosquito)
                Else
                    mosquito = effect
                End If

                If (mosquito Is Nothing) Then
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

        ' Barcode detection
        MediaPlayer1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.Checked
        MediaPlayer1.Barcode_Reader_Type = cbBarcodeType.SelectedIndex

        ' Motion detection
        If (cbMotDetEnabled.Checked) Then
            btMotDetUpdateSettings_Click(Nothing, Nothing)
        End If

        ' Object detection
        ConfigureObjectTracking()

        ' Encryption
        If (rbEncryptionKeyString.Checked) Then

            MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.String
            MediaPlayer1.Encryption_Key = edEncryptionKeyString.Text

        ElseIf (rbEncryptionKeyFile.Checked) Then

            MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.File
            MediaPlayer1.Encryption_Key = edEncryptionKeyFile.Text

        Else

            MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.Binary
            MediaPlayer1.Encryption_Key = VideoCapture.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text)

        End If

        MediaPlayer1.Play()

        FillAdjustRanges()

        ' DVD
        If (MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS) Then

            ' select and play first title
            If (cbDVDControlTitle.Items.Count > 0) Then

                cbDVDControlTitle.SelectedIndex = 0
                cbDVDControlTitle_SelectedIndexChanged(sender, e)

            End If

            ' show title menu
            MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Title)

        End If

        ' set audio volume for each stream
        If (MediaPlayer1.Source_Mode <> VFMediaPlayerSource.DVD_DS And MediaPlayer1.Source_Mode <> VFMediaPlayerSource.MMS_WMV_DS) Then

            Dim count As Integer = MediaPlayer1.Audio_Streams_Count()

            If (count > 0) Then

                MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value)
                MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value)

            End If

            ' independent audio output for each audio stream
            If (Not MediaPlayer1.Audio_Streams_AllInOne()) Then

                If (count > 1) Then

                    MediaPlayer1.Audio_OutputDevice_Balance_Set(1, tbBalance2.Value)
                    MediaPlayer1.Audio_OutputDevice_Volume_Set(1, tbVolume2.Value)
                    MediaPlayer1.Audio_Streams_Set(1, False) 'disable stream

                End If

                If (count > 2) Then

                    MediaPlayer1.Audio_OutputDevice_Balance_Set(2, tbBalance3.Value)
                    MediaPlayer1.Audio_OutputDevice_Volume_Set(2, tbVolume3.Value)
                    MediaPlayer1.Audio_Streams_Set(2, False) 'disable stream

                End If

                If (count > 3) Then

                    MediaPlayer1.Audio_OutputDevice_Balance_Set(3, tbBalance4.Value)
                    MediaPlayer1.Audio_OutputDevice_Volume_Set(3, tbVolume4.Value)
                    MediaPlayer1.Audio_Streams_Set(3, False) 'disable stream

                End If
            Else

                tbBalance2.Enabled = False
                tbVolume2.Enabled = False

                tbBalance3.Enabled = False
                tbVolume3.Enabled = False

                tbBalance4.Enabled = False
                tbVolume4.Enabled = False

            End If

        Else

            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value)
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value)

        End If

        timer1.Enabled = True

    End Sub

    Private Sub btSelectFile_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btSelectFile.Click

        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then

            edFilenameOrURL.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub btDVDControlRootMenu_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btDVDControlRootMenu.Click

        MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Root)

    End Sub

    Private Sub btDVDControlTitleMenu_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btDVDControlTitleMenu.Click

        MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Title)

    End Sub

    Private Sub btZoomIn_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomIn.Click

        MediaPlayer1.Video_Renderer.Zoom_Ratio = MediaPlayer1.Video_Renderer.Zoom_Ratio + 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btZoomOut_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomOut.Click

        MediaPlayer1.Video_Renderer.Zoom_Ratio = MediaPlayer1.Video_Renderer.Zoom_Ratio - 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btZoomShiftDown_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomShiftDown.Click

        MediaPlayer1.Video_Renderer.Zoom_ShiftY = MediaPlayer1.Video_Renderer.Zoom_ShiftY - 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btZoomShiftLeft_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomShiftLeft.Click

        MediaPlayer1.Video_Renderer.Zoom_ShiftX = MediaPlayer1.Video_Renderer.Zoom_ShiftX - 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btZoomShiftRight_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomShiftRight.Click

        MediaPlayer1.Video_Renderer.Zoom_ShiftX = MediaPlayer1.Video_Renderer.Zoom_ShiftX + 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btZoomShiftUp_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btZoomShiftUp.Click

        MediaPlayer1.Video_Renderer.Zoom_ShiftY = MediaPlayer1.Video_Renderer.Zoom_ShiftY + 10
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub cbAudioStream1_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioStream1.CheckedChanged

        MediaPlayer1.Audio_Streams_Set(0, cbAudioStream1.Checked)
        If (cbAudioStream1.Checked) Then

            tbVolume1_Scroll(sender, e)

            If (MediaPlayer1.Audio_Streams_AllInOne()) Then
                cbAudioStream2.Checked = False
                cbAudioStream3.Checked = False
                cbAudioStream4.Checked = False
            End If

        End If

    End Sub

    Private Sub cbAudioStream2_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioStream2.CheckedChanged

        MediaPlayer1.Audio_Streams_Set(1, cbAudioStream2.Checked)

        If (cbAudioStream2.Checked) Then

            tbVolume2_Scroll(sender, e)

            If (MediaPlayer1.Audio_Streams_AllInOne()) Then
                cbAudioStream1.Checked = False
                cbAudioStream3.Checked = False
                cbAudioStream4.Checked = False
            End If

        End If

    End Sub

    Private Sub cbAudioStream3_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioStream3.CheckedChanged

        MediaPlayer1.Audio_Streams_Set(2, cbAudioStream3.Checked)

        If (cbAudioStream3.Checked) Then

            tbVolume3_Scroll(sender, e)

            If (MediaPlayer1.Audio_Streams_AllInOne()) Then
                cbAudioStream1.Checked = False
                cbAudioStream2.Checked = False
                cbAudioStream4.Checked = False
            End If

        End If

    End Sub

    Private Sub cbAudioStream4_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudioStream4.CheckedChanged

        MediaPlayer1.Audio_Streams_Set(3, cbAudioStream4.Checked)

        If (cbAudioStream4.Checked) Then

            tbVolume4_Scroll(sender, e)

            If (MediaPlayer1.Audio_Streams_AllInOne()) Then
                cbAudioStream1.Checked = False
                cbAudioStream2.Checked = False
                cbAudioStream3.Checked = False
            End If

        End If

    End Sub

    Private Sub cbDVDControlAudio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbDVDControlAudio.SelectedIndexChanged

        If (cbDVDControlAudio.SelectedIndex > 0) Then

            MediaPlayer1.DVD_Select_AudioStream(cbDVDControlAudio.SelectedIndex)

        End If

    End Sub

    Private Sub cbDVDControlChapter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbDVDControlChapter.SelectedIndexChanged

        If (cbDVDControlChapter.SelectedIndex > 0) Then

            MediaPlayer1.DVD_Chapter_Select(cbDVDControlChapter.SelectedIndex)

        End If

    End Sub

    Private Sub cbDVDControlSubtitles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbDVDControlSubtitles.SelectedIndexChanged

        If (cbDVDControlSubtitles.SelectedIndex > 0) Then

            MediaPlayer1.DVD_Select_SubpictureStream(cbDVDControlSubtitles.SelectedIndex - 1)

        End If

        ' 0 - x - subtitles
        ' -1 - disable subtitles

    End Sub

    Private Sub cbScreenFlipHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbScreenFlipHorizontal.CheckedChanged

        MediaPlayer1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.Checked
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub cbScreenFlipVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbScreenFlipVertical.CheckedChanged

        MediaPlayer1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.Checked
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub cbStretch_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbStretch.CheckedChanged

        If (cbStretch.Checked) Then

            MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch

        Else

            MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox

        End If

        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStop.Click

        MediaPlayer1.Stop()
        timer1.Enabled = False
        tbTimeline.Value = 0

        waveformPainter1.Clear()
        waveformPainter2.Clear()

        volumeMeter1.Clear()
        volumeMeter2.Clear()

    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btResume.Click

        MediaPlayer1.Resume()

    End Sub

    Private Sub btPause_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btPause.Click

        MediaPlayer1.Pause()

    End Sub

    Private Sub btNextFrame_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btNextFrame.Click

        MediaPlayer1.NextFrame()

    End Sub

    Private Sub tbContrast_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbContrast.Scroll
        
        Dim contrast As IVFVideoEffectContrast
        Dim effect = MediaPlayer1.Video_Effects_Get("Contrast")
        If (effect is Nothing) Then
            contrast = New VFVideoEffectContrast(True, tbContrast.Value)
            MediaPlayer1.Video_Effects_Add(contrast)
        Else
            contrast = effect
            If (contrast IsNot Nothing) Then
                contrast.Value = tbContrast.Value
            End If
        End If

    End Sub

    Private Sub cbAspectRatioUseCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAspectRatioUseCustom.CheckedChanged

        MediaPlayer1.Video_Renderer.Aspect_Ratio_Override = cbAspectRatioUseCustom.Checked
        MediaPlayer1.Video_Renderer.Aspect_Ratio_X = Convert.ToInt32(edAspectRatioX.Text)
        MediaPlayer1.Video_Renderer.Aspect_Ratio_Y = Convert.ToInt32(edAspectRatioY.Text)
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub btAudEqRefresh_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btAudEqRefresh.Click

        tbAudEq0.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0)
        tbAudEq1.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1)
        tbAudEq2.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2)
        tbAudEq3.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3)
        tbAudEq4.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4)
        tbAudEq5.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5)
        tbAudEq6.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6)
        tbAudEq7.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7)
        tbAudEq8.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8)
        tbAudEq9.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9)

    End Sub

    Private Sub cbAudAmplifyEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudAmplifyEnabled.CheckedChanged

        MediaPlayer1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked)

    End Sub

    Private Sub cbAudDynamicAmplifyEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudDynamicAmplifyEnabled.CheckedChanged

        MediaPlayer1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.Checked)

    End Sub

    Private Sub cbAudEqualizerEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudEqualizerEnabled.CheckedChanged

        MediaPlayer1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked)

    End Sub

    Private Sub cbAudEqualizerPreset_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudEqualizerPreset.SelectedIndexChanged

        MediaPlayer1.Audio_Effects_Equalizer_Preset_Set(-1, 1, cbAudEqualizerPreset.SelectedIndex)
        btAudEqRefresh_Click(sender, e)

    End Sub

    Private Sub cbAudSound3DEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudSound3DEnabled.CheckedChanged

        MediaPlayer1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked)

    End Sub

    Private Sub cbAudTrueBassEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbAudTrueBassEnabled.CheckedChanged

        MediaPlayer1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.Checked)

    End Sub

    Private Sub pnTextLogoBGColor_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles pnTextLogoBGColor.Click

        colorDialog1.Color = pnTextLogoGradColor1.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then

            pnTextLogoGradColor1.BackColor = colorDialog1.Color

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

    Private Sub tbAud3DSound_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAud3DSound.Scroll

        MediaPlayer1.Audio_Effects_Sound3D(-1, 3, tbAud3DSound.Value)

    End Sub

    Private Sub tbAudAmplifyAmp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudAmplifyAmp.Scroll

        MediaPlayer1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, False)

    End Sub

    Private Sub tbAudAttack_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudAttack.Scroll

        MediaPlayer1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub tbAudDynAmp_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudDynAmp.Scroll

        MediaPlayer1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub tbAudRelease_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudRelease.Scroll

        MediaPlayer1.Audio_Effects_DynamicAmplify(-1, 2, tbAudAttack.Value, tbAudDynAmp.Value, tbAudRelease.Value)

    End Sub

    Private Sub tbAudEq0_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq0.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, tbAudEq0.Value)

    End Sub

    Private Sub tbAudEq1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq1.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, tbAudEq1.Value)

    End Sub

    Private Sub tbAudEq2_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq2.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, tbAudEq2.Value)

    End Sub

    Private Sub tbAudEq3_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq3.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, tbAudEq3.Value)

    End Sub

    Private Sub tbAudEq4_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq4.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, tbAudEq4.Value)

    End Sub

    Private Sub tbAudEq5_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq5.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, tbAudEq5.Value)

    End Sub

    Private Sub tbAudEq6_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq6.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, tbAudEq6.Value)

    End Sub

    Private Sub tbAudEq7_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq7.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, tbAudEq7.Value)

    End Sub

    Private Sub tbAudEq8_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq8.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, tbAudEq8.Value)

    End Sub

    Private Sub tbAudEq9_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudEq9.Scroll

        MediaPlayer1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, tbAudEq9.Value)

    End Sub

    Private Sub tbAudTrueBass_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAudTrueBass.Scroll

        MediaPlayer1.Audio_Effects_TrueBass(-1, 4, 200, False, tbAudTrueBass.Value)

    End Sub

    Private Sub tbJPEGQuality_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbJPEGQuality.Scroll

        lbJPEGQuality.Text = tbJPEGQuality.Value.ToString()

    End Sub

    Private Sub MediaPlayer1_OnError(ByVal sender As System.Object, ByVal e As ErrorsEventArgs) Handles MediaPlayer1.OnError

        mmLog.Text = mmLog.Text + e.Message + Environment.NewLine

    End Sub

    Public Delegate Sub AFStopDelegate()

    Public Sub AFStopDelegateMethod()

        tbTimeline.Value = 0

        'playlist used, we still need to call from GUI thread, using delegate
        If (MediaPlayer1.FilenamesOrURL.Count > 0) Then

            MediaPlayer1.Play()

        End If

    End Sub

    Private Sub MediaPlayer1_OnStop(ByVal sender As System.Object, ByVal e As EventArgs) Handles MediaPlayer1.OnStop

        Dim motdel As AFStopDelegate = New AFStopDelegate(AddressOf AFStopDelegateMethod)
        BeginInvoke(motdel, Nothing)

    End Sub

    Private Sub tbAdjBrightness_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAdjBrightness.Scroll

        MediaPlayer1.Video_Renderer_VideoAdjust_SetValue(VFVideoRendererAdjustment.Brightness, (tbAdjBrightness.Value / 10.0))
        lbAdjBrightnessCurrent.Text = "Current: " + Convert.ToString(tbAdjBrightness.Value / 10.0)

    End Sub

    Private Sub tbAdjContrast_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAdjContrast.Scroll

        MediaPlayer1.Video_Renderer_VideoAdjust_SetValue(VFVideoRendererAdjustment.Contrast, (tbAdjContrast.Value / 10.0))
        lbAdjContrastCurrent.Text = "Current: " + Convert.ToString(tbAdjContrast.Value / 10.0)

    End Sub

    Private Sub tbAdjHue_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAdjHue.Scroll

        MediaPlayer1.Video_Renderer_VideoAdjust_SetValue(VFVideoRendererAdjustment.Hue, (tbAdjHue.Value / 10.0))
        lbAdjHueCurrent.Text = "Current: " + Convert.ToString(tbAdjHue.Value / 10.0)

    End Sub

    Private Sub tbAdjSaturation_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbAdjSaturation.Scroll

        MediaPlayer1.Video_Renderer_VideoAdjust_SetValue(VFVideoRendererAdjustment.Saturation, (tbAdjSaturation.Value / 10.0))
        lbAdjSaturationCurrent.Text = "Current: " + Convert.ToString(tbAdjSaturation.Value / 10.0)

    End Sub

    Private Sub btMotDetUpdateSettings_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btMotDetUpdateSettings.Click

        If (cbMotDetEnabled.Checked) Then
            MediaPlayer1.Motion_Detection = New MotionDetectionSettings()
            MediaPlayer1.Motion_Detection.Enabled = cbMotDetEnabled.Checked
            MediaPlayer1.Motion_Detection.Compare_Red = cbCompareRed.Checked
            MediaPlayer1.Motion_Detection.Compare_Green = cbCompareGreen.Checked
            MediaPlayer1.Motion_Detection.Compare_Blue = cbCompareBlue.Checked
            MediaPlayer1.Motion_Detection.Compare_Greyscale = cbCompareGreyscale.Checked
            MediaPlayer1.Motion_Detection.Highlight_Color = cbMotDetHLColor.SelectedIndex
            MediaPlayer1.Motion_Detection.Highlight_Enabled = cbMotDetHLEnabled.Checked
            MediaPlayer1.Motion_Detection.Highlight_Threshold = tbMotDetHLThreshold.Value
            MediaPlayer1.Motion_Detection.FrameInterval = Convert.ToInt32(edMotDetFrameInterval.Text)
            MediaPlayer1.Motion_Detection.Matrix_Height = Convert.ToInt32(edMotDetMatrixHeight.Text)
            MediaPlayer1.Motion_Detection.Matrix_Width = Convert.ToInt32(edMotDetMatrixWidth.Text)
            MediaPlayer1.Motion_Detection.DropFrames_Enabled = cbMotDetDropFramesEnabled.Checked
            MediaPlayer1.Motion_Detection.DropFrames_Threshold = tbMotDetDropFramesThreshold.Value
            MediaPlayer1.MotionDetection_Update()
        Else
            MediaPlayer1.Motion_Detection = Nothing
        End If

    End Sub

    Private Sub btChromaKeySelectBGImage_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btChromaKeySelectBGImage.Click

        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then

            edChromaKeyImage.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub cbAFMotionDetection_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbMotionDetectionEx.CheckedChanged 

        ConfigureObjectTracking()

    End Sub

    Public Delegate Sub AFMotionDelegate(ByVal level As System.Single)

    Public Sub AFMotionDelegateMethod(ByVal level As System.Single)

        pbAFMotionLevel.Value = level * 100

    End Sub

    Private Sub MediaPlayer1_OnObjectDetection(ByVal sender As System.Object, ByVal e As MotionDetectionExEventArgs) Handles MediaPlayer1.OnMotionDetectionEx

        Dim motdel As AFMotionDelegate = New AFMotionDelegate(AddressOf AFMotionDelegateMethod)
        BeginInvoke(motdel, e.Level)

    End Sub

    Private Sub ConfigureChromaKey()

        If cbChromaKeyEnabled.Checked Then
            MediaPlayer1.ChromaKey = New ChromaKeySettings()
            MediaPlayer1.ChromaKey.ContrastHigh = tbChromaKeyContrastHigh.Value
            MediaPlayer1.ChromaKey.ContrastLow = tbChromaKeyContrastLow.Value
            MediaPlayer1.ChromaKey.ImageFilename = edChromaKeyImage.Text

            If (rbChromaKeyGreen.Checked) Then
                MediaPlayer1.ChromaKey.Color = VFChromaColor.Green
            ElseIf (rbChromaKeyBlue.Checked) Then
                MediaPlayer1.ChromaKey.Color = VFChromaColor.Blue
            Else
                MediaPlayer1.ChromaKey.Color = VFChromaColor.Red
            End If
        Else
            MediaPlayer1.ChromaKey = Nothing
        End If
    End Sub

    Private Sub tbChromaKeyContrastLow_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbChromaKeyContrastLow.Scroll

        ConfigureChromaKey()

    End Sub

    Private Sub tbChromaKeyContrastHigh_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbChromaKeyContrastHigh.Scroll

        ConfigureChromaKey()

    End Sub

    Public Delegate Sub MotionDelegate(ByVal e As MotionDetectionEventArgs)

    Public Sub MotionDelegateMethod(ByVal e As MotionDetectionEventArgs)

        Dim s As String = String.Empty

        Dim k As Integer
        For Each b As Byte In e.Matrix
            s += b.ToString("D3") + " "

            If (k = MediaPlayer1.Motion_Detection.Matrix_Width - 1) Then
                k = 0
                s += Environment.NewLine
            Else
                k += 1
            End If
        Next

        mmMotDetMatrix.Text = s.Trim()
        pbMotionLevel.Value = e.Level

    End Sub

    Private Sub MediaPlayer1_OnMotion(ByVal sender As System.Object, ByVal e As MotionDetectionEventArgs) Handles MediaPlayer1.OnMotion

        Dim motdel As MotionDelegate = New MotionDelegate(AddressOf MotionDelegateMethod)
        BeginInvoke(motdel, e)

    End Sub

    Private Sub cbStretch1_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbStretch1.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(0, cbStretch1.Checked, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked)

    End Sub

    Private Sub cbFlipVertical1_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbFlipVertical1.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(0, cbStretch1.Checked, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked)

    End Sub

    Private Sub cbFlipHorizontal1_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbFlipHorizontal1.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(0, cbStretch1.Checked, cbFlipHorizontal1.Checked, cbFlipVertical1.Checked)

    End Sub

    Private Sub cbStretch2_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbStretch2.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(1, cbStretch2.Checked, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked)

    End Sub

    Private Sub cbFlipVertical2_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbFlipVertical2.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(1, cbStretch2.Checked, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked)

    End Sub

    Private Sub cbFlipHorizontal2_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbFlipHorizontal2.CheckedChanged

        MediaPlayer1.MultiScreen_SetParameters(1, cbStretch2.Checked, cbFlipHorizontal2.Checked, cbFlipVertical2.Checked)

    End Sub

    Private Sub cbZoom_CheckedChanged(sender As System.Object, e As EventArgs) Handles cbZoom.CheckedChanged

        Dim zoomEffect As IVFVideoEffectZoom
        Dim effect = MediaPlayer1.Video_Effects_Get("Zoom")
        If (effect is Nothing) Then
            zoomEffect = New VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoom.Checked)
            MediaPlayer1.Video_Effects_Add(zoomEffect)
        Else
            zoomEffect = effect
        End If

        If (zoomEffect Is Nothing) Then
            MessageBox.Show("Unable to configure zoom effect.")
            Return
        End If

        zoomEffect.ZoomX = zoom
        zoomEffect.ZoomY = zoom
        zoomEffect.ShiftX = zoomShiftX
        zoomEffect.ShiftY = zoomShiftY
        zoomEffect.Enabled = cbZoom.Checked

    End Sub

    Private Sub btEffZoomIn_Click(sender As System.Object, e As EventArgs) Handles btEffZoomIn.Click

        zoom += 0.1
        zoom = Math.Min(zoom, 5)

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomOut_Click(sender As System.Object, e As EventArgs) Handles btEffZoomOut.Click

        zoom -= 0.1
        zoom = Math.Max(zoom, 1)

       cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomUp_Click(sender As System.Object, e As EventArgs) Handles btEffZoomUp.Click

        zoomShiftY += 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomDown_Click(sender As System.Object, e As EventArgs) Handles btEffZoomDown.Click

        zoomShiftY -= 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomRight_Click(sender As System.Object, e As EventArgs) Handles btEffZoomRight.Click

        zoomShiftX += 20

        cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub btEffZoomLeft_Click(sender As System.Object, e As EventArgs) Handles btEffZoomLeft.Click

        zoomShiftX -= 20

       cbZoom_CheckedChanged(Nothing, Nothing)

    End Sub

    Private Sub cbPan_CheckedChanged(sender As Object, e As EventArgs) Handles cbPan.CheckedChanged
        
        Dim pan As IVFVideoEffectPan
        Dim effect = MediaPlayer1.Video_Effects_Get("Pan")
        If (effect is Nothing) Then
            pan = New VFVideoEffectPan(True)
            MediaPlayer1.Video_Effects_Add(pan)
        Else
            pan = effect
        End If

        If (pan Is Nothing) Then
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
        MediaPlayer1.Barcode_Reader_Enabled = True

    End Sub

    Private Sub MediaPlayer1_OnBarcodeDetected(sender As Object, e As BarcodeEventArgs) Handles MediaPlayer1.OnBarcodeDetected

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

    Private Sub btAddFileToPlaylist_Click(sender As Object, e As EventArgs) Handles btAddFileToPlaylist.Click

        lbSourceFiles.Items.Add(edFilenameOrURL.Text)

    End Sub

    Private Sub cbFadeInOut_CheckedChanged(sender As Object, e As EventArgs) Handles cbFadeInOut.CheckedChanged
        
        If (rbFadeIn.Checked) Then
            Dim fadeIn As IVFVideoEffectFadeIn
            Dim effect = MediaPlayer1.Video_Effects_Get("FadeIn")
            If (effect is Nothing) Then
                fadeIn = New VFVideoEffectFadeIn(cbFadeInOut.Checked)
                MediaPlayer1.Video_Effects_Add(fadeIn)
            Else
                fadeIn = effect
            End If

            If (fadeIn Is Nothing) Then
                MessageBox.Show("Unable to configure fade-in effect.")
                Return
            End If

            fadeIn.Enabled = cbFadeInOut.Checked
            fadeIn.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text)
            fadeIn.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text)
        Else
            Dim fadeOut As IVFVideoEffectFadeOut
            Dim effect = MediaPlayer1.Video_Effects_Get("FadeOut")
            If (effect is Nothing) Then
                fadeOut = New VFVideoEffectFadeOut(cbFadeInOut.Checked)
                MediaPlayer1.Video_Effects_Add(fadeOut)
            Else
                fadeOut = effect
            End If

            If (fadeOut Is Nothing) Then
                MessageBox.Show("Unable to configure fade-out effect.")
                Return
            End If

            fadeOut.Enabled = cbFadeInOut.Checked
            fadeOut.StartTime = Convert.ToInt64(edFadeInOutStartTime.Text)
            fadeOut.StopTime = Convert.ToInt64(edFadeInOutStopTime.Text)
        End If

    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/video_tutorials")
        Process.Start(startInfo)

    End Sub

    Private Sub MediaPlayer1_OnVideoEncrypted(sender As Object, e As EventArgs) Handles MediaPlayer1.OnVideoEncrypted

        MessageBox.Show("Video is encrypted. Please be sure that you're entered correct pin code.")

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

            controlLeft = MediaPlayer1.Left
            controlTop = MediaPlayer1.Top
            controlWidth = MediaPlayer1.Width
            controlHeight = MediaPlayer1.Height

            ' resizing window
            Left = 0
            Top = 0
            Width = Screen.AllScreens(0).WorkingArea.Width
            Height = Screen.AllScreens(0).WorkingArea.Height

            TopMost = True
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized

            ' resizing control
            MediaPlayer1.Left = 0
            MediaPlayer1.Top = 0
            MediaPlayer1.Width = Width
            MediaPlayer1.Height = Height

            MediaPlayer1.Video_Renderer_Update()

        Else
            ' going normal screen
            fullScreen = False

            ' restoring control
            MediaPlayer1.Left = controlLeft
            MediaPlayer1.Top = controlTop
            MediaPlayer1.Width = controlWidth
            MediaPlayer1.Height = controlHeight

            ' restoring window
            Left = windowLeft
            Top = windowTop
            Width = windowWidth
            Height = windowHeight

            TopMost = False
            FormBorderStyle = FormBorderStyle.Sizable
            WindowState = FormWindowState.Normal

            MediaPlayer1.Video_Renderer_Update()

        End If

    End Sub

    Private Sub MediaPlayer1_MouseDown(sender As Object, e As MouseEventArgs) Handles MediaPlayer1.MouseDown

        If (fullScreen) Then

            btFullScreen_Click(sender, e)

        End If

    End Sub

#End Region

    Private Delegate Sub StopDelegate()

    Private Sub StopDelegateMethod()

        tbTimeline.Value = 0

        waveformPainter1.Clear()
        waveformPainter2.Clear()

        volumeMeter1.Clear()
        volumeMeter2.Clear()

        If Not IsNothing(memoryFileStream) Then

            memoryFileStream.Dispose()
            memoryFileStream = Nothing

        End If

    End Sub


    Private Sub MediaPlayer1_OnStop(sender As Object, e As StopEventArgs) Handles MediaPlayer1.OnStop

        BeginInvoke(New StopDelegate(AddressOf StopDelegateMethod))

    End Sub

    Private Sub btReversePlayback_Click(sender As Object, e As EventArgs) Handles btReversePlayback.Click

        MediaPlayer1.ReversePlayback_CacheSize = Int32.Parse(edReversePlaybackCacheSize.Text)

        If (MediaPlayer1.ReversePlayback_Enabled) Then

            btReversePlayback.Text = "Go to reverse playback mode"
            MediaPlayer1.ReversePlayback_Enabled = False

        Else

            btReversePlayback.Text = "Go to normal playback mode"
            MediaPlayer1.ReversePlayback_Enabled = True

        End If

    End Sub

    Private Sub tbReversePlaybackTrackbar_Scroll(sender As Object, e As EventArgs) Handles tbReversePlaybackTrackbar.Scroll

        MediaPlayer1.ReversePlayback_GoToFrame(tbReversePlaybackTrackbar.Value)

    End Sub

    Private Sub tbVUMeterAmplification_Scroll(sender As Object, e As EventArgs) Handles tbVUMeterAmplification.Scroll

        MediaPlayer1.Audio_VUMeter_Pro_Volume = tbVUMeterAmplification.Value

    End Sub

    Private Sub tbVUMeterBoost_Scroll(sender As Object, e As EventArgs) Handles tbVUMeterBoost.Scroll

        volumeMeter1.Boost = tbVUMeterBoost.Value / 10.0F
        volumeMeter2.Boost = tbVUMeterBoost.Value / 10.0F

        waveformPainter1.Boost = tbVUMeterBoost.Value / 10.0F
        waveformPainter2.Boost = tbVUMeterBoost.Value / 10.0F

    End Sub

    Private Sub MediaPlayer1_OnAudioVUMeterProVolume(sender As Object, e As AudioLevelEventArgs) Handles MediaPlayer1.OnAudioVUMeterProVolume

        volumeMeter1.Amplitude = e.ChannelLevelsDb(0)
        waveformPainter1.AddMax(e.ChannelLevelsDb(0))

        If (e.ChannelLevelsDb.Length > 1) Then

            volumeMeter2.Amplitude = e.ChannelLevelsDb(1)
            waveformPainter2.AddMax(e.ChannelLevelsDb(1))

        End If

    End Sub

    Private Sub cbLiveRotation_CheckedChanged(sender As Object, e As EventArgs) Handles cbLiveRotation.CheckedChanged

        Dim rotate As IVFVideoEffectRotate
        Dim effect = MediaPlayer1.Video_Effects_Get("Rotate")
        If (effect is Nothing) Then
            rotate = New VFVideoEffectRotate(
                    cbLiveRotation.Checked,
                    tbLiveRotationAngle.Value,
                    cbLiveRotationStretch.Checked)
            MediaPlayer1.Video_Effects_Add(rotate)
        Else
            rotate = effect
        End If

        If (rotate Is Nothing) Then
            MessageBox.Show("Unable to configure rotate effect.")
            Return
        End If

        rotate.Enabled = cbLiveRotation.Checked
        rotate.Angle = tbLiveRotationAngle.Value
        rotate.Stretch = cbLiveRotationStretch.Checked

    End Sub

    Private Sub tbLiveRotationAngle_Scroll(sender As Object, e As EventArgs) Handles tbLiveRotationAngle.Scroll

        cbLiveRotation_CheckedChanged(sender, e)

    End Sub

    Private Sub cbLiveRotationStretch_CheckedChanged(sender As Object, e As EventArgs) Handles cbLiveRotationStretch.CheckedChanged

        cbLiveRotation_CheckedChanged(sender, e)

    End Sub

    Private Sub pnVideoRendererBGColor_Click(sender As Object, e As EventArgs) Handles pnVideoRendererBGColor.Click

        colorDialog1.Color = pnVideoRendererBGColor.BackColor

        If (colorDialog1.ShowDialog() = DialogResult.OK) Then

            pnVideoRendererBGColor.BackColor = colorDialog1.Color

        End If

    End Sub

    Private Sub cbDirect2DRotate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDirect2DRotate.SelectedIndexChanged

        MediaPlayer1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text)
        MediaPlayer1.Video_Renderer_Update()

    End Sub

    Private Sub cbFilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilters.SelectedIndexChanged

        If cbFilters.SelectedIndex <> -1 Then

            Dim sName As String = cbFilters.Text
            btFilterSettings.Enabled = (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Or (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig))

        End If

    End Sub

    Private Sub btFilterAdd_Click(sender As Object, e As EventArgs) Handles btFilterAdd.Click

        If cbFilters.SelectedIndex <> -1 Then

            MediaPlayer1.Video_Filters_Add(cbFilters.Text)
            lbFilters.Items.Add(cbFilters.Text)

        End If

    End Sub

    Private Sub btFilterSettings_Click(sender As Object, e As EventArgs) Handles btFilterSettings.Click

        Dim sName As String = cbFilters.Text

        If (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
            MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
        ElseIf (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
            MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)

        End If

    End Sub

    Private Sub lbFilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFilters.SelectedIndexChanged

        If lbFilters.SelectedIndex <> -1 Then

            Dim sName As String = lbFilters.Text
            btFilterSettings2.Enabled = (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Or (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig))

        End If

    End Sub

    Private Sub btFilterSettings2_Click(sender As Object, e As EventArgs) Handles btFilterSettings2.Click

        If lbFilters.SelectedIndex <> -1 Then

            Dim sName As String = lbFilters.Text

            If (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.Default)) Then
                MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.Default)
            ElseIf (MediaPlayer.DirectShow_Filter_Has_Dialog(sName, VFPropertyPage.VFWCompConfig)) Then
                MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, sName, VFPropertyPage.VFWCompConfig)

            End If

        End If

    End Sub

    Private Sub btFilterDelete_Click(sender As Object, e As EventArgs) Handles btFilterDelete.Click

        If lbFilters.SelectedIndex <> -1 Then

            MediaPlayer1.Video_Filters_Delete(lbFilters.Text)
            lbFilters.Items.Remove(lbFilters.Text)

        End If

    End Sub

    Private Sub btFilterDeleteAll_Click(sender As Object, e As EventArgs) Handles btFilterDeleteAll.Click

        lbFilters.Items.Clear()
        MediaPlayer1.Video_Filters_Clear()

    End Sub

    Private Sub cbAudioNormalize_CheckedChanged(sender As Object, e As EventArgs) Handles cbAudioNormalize.CheckedChanged

        MediaPlayer1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.Checked)

    End Sub

    Private Sub cbAudioAutoGain_CheckedChanged(sender As Object, e As EventArgs) Handles cbAudioAutoGain.CheckedChanged

        MediaPlayer1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.Checked)

    End Sub

    Private Sub ApplyAudioInputGains()

        Dim gains As VFAudioEnhancerGains = New VFAudioEnhancerGains()

        gains.L = tbAudioInputGainL.Value / 10.0F
        gains.C = tbAudioInputGainC.Value / 10.0F
        gains.R = tbAudioInputGainR.Value / 10.0F
        gains.SL = tbAudioInputGainSL.Value / 10.0F
        gains.SR = tbAudioInputGainSR.Value / 10.0F
        gains.LFE = tbAudioInputGainLFE.Value / 10.0F

        MediaPlayer1.Audio_Enhancer_InputGains(-1, gains)

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

    Private Sub ApplyAudioOutputGains()

        Dim gains As VFAudioEnhancerGains = New VFAudioEnhancerGains

        gains.L = tbAudioOutputGainL.Value / 10.0F
        gains.C = tbAudioOutputGainC.Value / 10.0F
        gains.R = tbAudioOutputGainR.Value / 10.0F
        gains.SL = tbAudioOutputGainSL.Value / 10.0F
        gains.SR = tbAudioOutputGainSR.Value / 10.0F
        gains.LFE = tbAudioOutputGainLFE.Value / 10.0F

        MediaPlayer1.Audio_Enhancer_OutputGains(-1, gains)

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

        MediaPlayer1.Audio_Enhancer_Timeshift(-1, tbAudioTimeshift.Value)

    End Sub

    Private Sub MediaPlayer1_OnLicenseRequired(sender As Object, e As LicenseEventArgs) Handles MediaPlayer1.OnLicenseRequired

        If cbLicensing.Checked Then
            mmLog.Text = mmLog.Text + "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Not IsNothing(memoryFileStream) Then

            memoryFileStream.Dispose()
            memoryFileStream = Nothing

        End If

    End Sub

    Private Sub btReadTags_Click(sender As Object, e As EventArgs) Handles btReadTags.Click

        Dim tags = MediaPlayer1.Tags_Read(edFilenameOrURL.Text)

        If (Not IsNothing(tags)) Then

            If (Not IsNothing(tags.Pictures) And tags.Pictures.Length > 0) Then

                imgTags.Image = tags.Pictures(0)

            End If

            edTags.Text = tags.ToString()

        End If

    End Sub

    Private Sub linkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "https://visioforge-files.s3.amazonaws.com/redists_net/redist_dotnet_vlc_x86.exe")
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

    Private Sub tbGPULightness_Scroll(sender As Object, e As EventArgs) Handles tbGPULightness.Scroll

         Dim intf As IVFGPUVideoEffectBrightness
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Brightness")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectBrightness(True, tbGPULightness.Value)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Saturation")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectSaturation(True, tbGPUSaturation.Value)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Contrast")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectContrast(True, tbGPUContrast.Value)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Darkness")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDarkness(True, tbGPUDarkness.Value)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Grayscale")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectGrayscale(cbGPUGreyscale.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Invert")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectInvert(cbGPUInvert.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("NightVision")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectNightVision(cbGPUNightVision.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Pixelate")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectPixelate(cbGPUPixelate.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Denoise")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDenoise(cbGPUDenoise.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("DeinterlaceBlend")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("Blur")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectBlur(cbGPUBlur.Checked, 50)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
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
        Dim effect = MediaPlayer1.Video_Effects_GPU_Get("OldMovie")
        If (IsNothing(effect)) Then
            intf = New VFGPUVideoEffectOldMovie(cbGPUOldMovie.Checked)
            MediaPlayer1.Video_Effects_GPU_Add(intf)
        Else
            intf = effect
            If (not IsNothing(intf)) Then
                intf.Enabled = cbGPUOldMovie.Checked
                intf.Update()
            End If
        End If

    End Sub

    Private Sub btReversePlaybackPrevFrame_Click(sender As Object, e As EventArgs) Handles btReversePlaybackPrevFrame.Click

        MediaPlayer1.ReversePlayback_PreviousFrame()

    End Sub

    Private Sub btReversePlaybackNextFrame_Click(sender As Object, e As EventArgs) Handles btReversePlaybackNextFrame.Click

        MediaPlayer1.ReversePlayback_NextFrame()

    End Sub

    Private Sub btPreviousFrame_Click(sender As Object, e As EventArgs) Handles btPreviousFrame.Click

        MediaPlayer1.PreviousFrame()

    End Sub
End Class

' ReSharper restore InconsistentNaming