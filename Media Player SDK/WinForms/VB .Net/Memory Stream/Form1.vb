' ReSharper disable InconsistentNaming

Imports System.IO
Imports VisioForge.Tools
Imports VisioForge.Types
Imports VisioForge.Controls.UI.WinForms

Public Class Form1

    Private Sub tbTimeline_Scroll(ByVal sender As System.Object, ByVal e As EventArgs) Handles tbTimeline.Scroll

        If (Convert.ToInt32(timer1.Tag) = 0) Then
            MediaPlayer1.Position_Set_Time(tbTimeline.Value * 1000)
        End If

    End Sub

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStart.Click

        Dim fs As FileStream = New FileStream(edFilename.Text, FileMode.Open)
        Dim stream As ManagedIStream = New ManagedIStream(fs)

        ' specifing settings
        ' MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
        MediaPlayer1.Source_Stream = stream
        MediaPlayer1.Source_Stream_Size = fs.Length

        ' video and audio present in file. tune this settings to play audio files or video files without audio
        MediaPlayer1.Source_Stream_VideoPresent = True
        MediaPlayer1.Source_Stream_AudioPresent = True

        MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_FFMPEG

        MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device"

        If (MediaPlayer1.Filter_Supported_EVR()) Then
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR
        ElseIf (MediaPlayer1.Filter_Supported_VMR9()) Then
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9
        Else
            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer
        End If

        MediaPlayer1.Debug_Mode = cbDebugMode.Checked
        MediaPlayer1.Play()

        tbTimeline.Maximum = MediaPlayer1.Duration_Time() / 1000
        timer1.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        Text += " (SDK v" + MediaPlayer1.SDK_Version.ToString() + ", " + MediaPlayer1.SDK_State + ")"
        MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\"

    End Sub

    Private Sub btResume_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btResume.Click

        MediaPlayer1.Resume()

    End Sub

    Private Sub btPause_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btPause.Click

        MediaPlayer1.Pause()

    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btStop.Click

        MediaPlayer1.Stop()
        timer1.Enabled = False
        tbTimeline.Value = 0

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
        tbTimeline.Maximum = MediaPlayer1.Duration_Time() / 1000

        Dim value As Integer = MediaPlayer1.Position_Get_Time() / 1000
        If ((value > 0) And (value < tbTimeline.Maximum)) Then
            tbTimeline.Value = value
        End If

        lbTime.Text = MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum)

        timer1.Tag = 0

    End Sub

    Private Sub MediaPlayer1_OnError(sender As System.Object, e As VisioForge.Types.ErrorsEventArgs) Handles MediaPlayer1.OnError

        mmError.Text = mmError.Text + e.Message + Environment.NewLine

    End Sub

    Private Sub linkLabel1_LinkClicked(sender As System.Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

        Dim startInfo = New ProcessStartInfo("explorer.exe", "http://www.visioforge.com/video_tutorials")
        Process.Start(startInfo)

    End Sub

    Private Sub MediaPlayer1_OnLicenseRequired(sender As Object, e As LicenseEventArgs) Handles MediaPlayer1.OnLicenseRequired

        If cbLicensing.Checked Then
            mmError.Text = mmError.Text + "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine
        End If

    End Sub
End Class

' ReSharper restore InconsistentNaming