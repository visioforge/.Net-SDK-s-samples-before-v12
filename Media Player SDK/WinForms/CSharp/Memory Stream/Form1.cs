// ReSharper disable InconsistentNaming

namespace Memory_Stream_Demo
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Tools;
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

        private void btStart_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(edFilename.Text, FileMode.Open);
            ManagedIStream stream = new ManagedIStream(fs);

            // specifing settings
            // MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
            MediaPlayer1.Source_Stream = stream;
            MediaPlayer1.Source_Stream_Size = fs.Length;

            // video and audio present in file. tune this settings to play audio files or video files without audio
            MediaPlayer1.Source_Stream_VideoPresent = true;
            MediaPlayer1.Source_Stream_AudioPresent = true;

            MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_FFMPEG;
            
            MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device";

            if (!MediaPlayer1.Filter_Supported_VMR9())
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
            else
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }

            MediaPlayer1.Debug_Mode = cbDebugMode.Checked;
            MediaPlayer1.Play();

            tbTimeline.Maximum = (int)(MediaPlayer1.Duration_Time() / 1000);
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + MediaPlayer1.SDK_Version + ", " + MediaPlayer1.SDK_State + ")";
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Resume();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Pause();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Stop();
            timer1.Enabled = false;
            tbTimeline.Value = 0;
        }

        private void btNextFrame_Click(object sender, EventArgs e)
        {
            MediaPlayer1.NextFrame();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.SetSpeed(tbSpeed.Value / 10.0);
        }

        private void tbVolume1_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);
        }

        private void tbBalance1_Scroll(object sender, EventArgs e)
        {
            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MediaPlayer1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmError.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }
    }
}

// ReSharper restore InconsistentNaming