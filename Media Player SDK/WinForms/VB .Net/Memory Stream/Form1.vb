' ReSharper disable InconsistentNaming

Imports System.IO
Imports VisioForge.Controls.UI
Imports VisioForge.Tools
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms

Public Class Form1

    Private _stream As ManagedIStream

    Private _fileStream As FileStream

    Private _memoryStream As MemoryStream

    Private _memorySource() As Byte

    Private Sub tbTimeline_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbTimeline.Scroll

        If (Convert.ToInt32(timer1.Tag) = 0) Then
            MediaPlayer1.Position_Set_Time(TimeSpan.FromSeconds(tbTimeline.Value))
        End If

    End Sub

    Private Async Sub btStart_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStart.Click

        mmError.Text = String.Empty

        If (rbSTreamTypeFile.Checked) Then
            _fileStream = New FileStream(edFilename.Text, FileMode.Open)
            _stream = New ManagedIStream(_fileStream)

            ' specifying settings
            ' MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
            MediaPlayer1.Source_Stream = _stream
            MediaPlayer1.Source_Stream_Size = _fileStream.Length
        Else
            _memorySource = File.ReadAllBytes(edFilename.Text)
            _memoryStream = New MemoryStream(_memorySource)
            _stream = New ManagedIStream(_memoryStream)

            MediaPlayer1.Source_Stream = _stream
            MediaPlayer1.Source_Stream_Size = _memoryStream.Length
        End If

        ' video and audio present in file. tune this settings to play audio files or video files without audio
        If (rbVideoWithAudio.Checked) Then
            MediaPlayer1.Source_Stream_VideoPresent = True
            MediaPlayer1.Source_Stream_AudioPresent = True
        ElseIf (rbVideoWithoutAudio.Checked) Then
            MediaPlayer1.Source_Stream_VideoPresent = True
            MediaPlayer1.Source_Stream_AudioPresent = False
        Else
            MediaPlayer1.Source_Stream_VideoPresent = False
            MediaPlayer1.Source_Stream_AudioPresent = True
        End If

        MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS

        MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device"

        If (MediaPlayer1.Filter_Supported_EVR()) Then
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf (MediaPlayer1.Filter_Supported_VMR9()) Then
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

        MediaPlayer1.Debug_Mode = cbDebugMode.Checked
        Await MediaPlayer1.PlayAsync()

        tbTimeline.Maximum = MediaPlayer1.Duration_Time().TotalSeconds
        timer1.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + MediaPlayer1.SDK_Version.ToString() + ", " + MediaPlayer1.SDK_State + ")"
        MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\"

    End Sub

    Private Async Sub btResume_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btResume.Click

        Await MediaPlayer1.ResumeAsync()

    End Sub

    Private Async Sub btPause_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btPause.Click

        Await MediaPlayer1.PauseAsync()

    End Sub

    Private Async Sub btStop_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStop.Click

        Await MediaPlayer1.StopAsync()

        timer1.Enabled = False
        tbTimeline.Value = 0

        _fileStream?.Dispose()
        _fileStream = Nothing

        _memoryStream?.Dispose()
        _memoryStream = Nothing

        _memorySource = Nothing
        _stream = Nothing

    End Sub

    Private Sub btNextFrame_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btNextFrame.Click

        MediaPlayer1.NextFrame()

    End Sub

    Private Sub tbSpeed_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbSpeed.Scroll

        MediaPlayer1.SetSpeed(tbSpeed.Value / 10.0)

    End Sub

    Private Sub tbVolume1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbVolume1.Scroll

        MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value)

    End Sub

    Private Sub tbBalance1_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbBalance1.Scroll

        MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value)

    End Sub

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles timer1.Tick

        timer1.Tag = 1
        tbTimeline.Maximum = MediaPlayer1.Duration_Time().TotalSeconds

        Dim value As Integer = MediaPlayer1.Position_Get_Time().TotalSeconds
        If ((value > 0) And (value < tbTimeline.Maximum)) Then
            tbTimeline.Value = value
        End If

        lbTime.Text = MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum)

        timer1.Tag = 0

    End Sub

    Private Sub MediaPlayer1_OnError(sender As System.Object, e As ErrorsEventArgs) Handles MediaPlayer1.OnError

        Invoke(Sub()
                   mmError.Text = mmError.Text + e.Message + Environment.NewLine
               End Sub)

    End Sub

    Private Sub linkLabel1_LinkClicked(sender As System.Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", HelpLinks.VideoTutorials)
        Process.Start(startInfo)

    End Sub

    Private Sub MediaPlayer1_OnLicenseRequired(sender As Object, e As LicenseEventArgs) Handles MediaPlayer1.OnLicenseRequired

        Invoke(Sub()
                   If cbLicensing.Checked Then
                       mmError.Text = mmError.Text + "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine
                   End If
               End Sub)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        btStop_Click(Nothing, Nothing)
    End Sub

    Private Sub btSelectFile_Click(sender As Object, e As EventArgs) Handles btSelectFile.Click
        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then
            edFilename.Text = openFileDialog1.FileName
        End If
    End Sub
End Class

' ReSharper restore InconsistentNaming