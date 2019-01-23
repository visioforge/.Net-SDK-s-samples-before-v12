// ReSharper disable InconsistentNaming

namespace Video_Player_Demo
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edFilename.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void tbTimeline_Scroll(object sender, EventArgs e)
        {
            if (Convert.ToInt32(timer1.Tag) == 0)
            {
                MediaPlayer1.Position_Set_Time(tbTimeline.Value * 1000);
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.SetSpeed(tbSpeed.Value / 10.0);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmError.Clear();

            switch (cbSourceMode.SelectedIndex)
            {
                case 0:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV;
                    break;
                case 1:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS;
                    break;
                case 2:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG;
                    break;
                case 3:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_VLC;
                    break;
            }

            MediaPlayer1.FilenamesOrURL.Add(edFilename.Text);
            MediaPlayer1.Loop = cbLoop.Checked;
            MediaPlayer1.Audio_PlayAudio = true;
            MediaPlayer1.Info_UseLibMediaInfo = true;
            MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device";

            if (MediaPlayer1.Filter_Supported_EVR())
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (MediaPlayer1.Filter_Supported_VMR9())
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }

            MediaPlayer1.Debug_Mode = cbDebugMode.Checked;

            MediaPlayer1.Play();

            // set audio volume for each stream
            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value);
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);

            timer1.Enabled = true;
        }

        private void btNextFrame_Click(object sender, EventArgs e)
        {
            MediaPlayer1.NextFrame();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Stop();
            timer1.Enabled = false;
            tbTimeline.Value = 0;
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Pause();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Resume();
        }

        private void tbVolume1_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
        }

        private void tbBalance1_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + MediaPlayer1.SDK_Version + ", " + MediaPlayer1.SDK_State + ")";
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            cbSourceMode.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tag = 1;
            tbTimeline.Maximum = (int)(MediaPlayer1.Duration_Time() / 1000);

            int value = (int)(MediaPlayer1.Position_Get_Time() / 1000);
            if ((value > 0) && (value < tbTimeline.Maximum))
            {
                tbTimeline.Value = value;
            }

            lbTime.Text = MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum);

            timer1.Tag = 0;
        }

        private void MediaPlayer1_OnError(object sender, ErrorsEventArgs e)
        {
            mmError.Text = mmError.Text + e.Message + Environment.NewLine;
        }

        private void MediaPlayer1_OnStop(object sender, MediaPlayerStopEventArgs e)
        {
            tbTimeline.Value = 0;
        }

        private void MediaPlayer1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmError.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }

        private void btPreviousFrame_Click(object sender, EventArgs e)
        {
            MediaPlayer1.PreviousFrame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(null, null);
        }
    }
}

// ReSharper restore InconsistentNaming
