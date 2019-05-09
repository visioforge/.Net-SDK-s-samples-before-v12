using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisioForge.Controls.UI;

namespace SeamlessPlaybackDemo
{
    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;

    public partial class Form1 : Form
    {
        private List<string> sourceFiles;

        private MediaPlayer CurrentPlayer;

        //private MediaPlayer backgroundPlayer;

        public Form1()
        {
            InitializeComponent();

            sourceFiles = new List<string>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Text += " (SDK v" + MediaPlayer1.SDK_Version + ", " + MediaPlayer1.SDK_State + "), C#";
        }

        private void btAddFileToPlaylist_Click(object sender, EventArgs e)
        {
            lbSourceFiles.Items.Add(edFilenameOrURL.Text);
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edFilenameOrURL.Text = openFileDialog1.FileName;
            }
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Resume();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Pause();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            CurrentPlayer.Stop();
            timer1.Enabled = false;
            tbTimeline.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tag = 1;
            tbTimeline.Maximum = (int)(CurrentPlayer.Duration_Time() / 1000.0);

            int value = (int)(CurrentPlayer.Position_Get_Time() / 1000.0);
            if ((value > 0) && (value < tbTimeline.Maximum))
            {
                tbTimeline.Value = value;
            }

            lbTime.Text = MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum);
            
            timer1.Tag = 0;
        }

        private void btNextFrame_Click(object sender, EventArgs e)
        {
            CurrentPlayer.NextFrame();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            CurrentPlayer.SetSpeed(tbSpeed.Value / 10.0);
        }

        private void InitPlayer(MediaPlayer player)
        {
            player.Debug_Mode = cbDebugMode.Checked;
            player.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            player.Source_Mode = VFMediaPlayerSource.LAV;
            player.Audio_OutputDevice = "Default DirectSound Device";
            MediaPlayer1.Info_UseLibMediaInfo = true;

            if (player.Filter_Supported_EVR())
            {
                player.Video_Renderer.Video_Renderer = VFVideoRenderer.EVR;
            }
            else if (player.Filter_Supported_VMR9())
            {
                player.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            }
            else
            {
                player.Video_Renderer.Video_Renderer = VFVideoRenderer.VideoRenderer;
            }
        }

        private void PlayFile(string filename, MediaPlayer player)
        {
            player.FilenamesOrURL.Clear();
            player.FilenamesOrURL.Add(filename);

            player.Play();

            timer1.Enabled = true;
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            if (lbSourceFiles.Items.Count < 2)
            {
                MessageBox.Show("You must add 2 or more files to test seamless playback.");
                return;
            }

            InitPlayer(MediaPlayer1);
            InitPlayer(MediaPlayer2);

            foreach (var item in lbSourceFiles.Items)
            {
                sourceFiles.Add(item.ToString());
            }

            CurrentPlayer = MediaPlayer1;

            MediaPlayer1.Show();
            MediaPlayer2.Hide();
            PlayFile(sourceFiles[0], MediaPlayer1);
            sourceFiles.RemoveAt(0);

            PlayFile(sourceFiles[0], MediaPlayer2);
            sourceFiles.RemoveAt(0);
            MediaPlayer2.Pause();
        }

        private void MediaPlayer1_OnStop(object sender, MediaPlayerStopEventArgs e)
        {
            BeginInvoke(new StopDelegate1(StopDelegateMethod1), null);
        }

        private void MediaPlayer2_OnStop(object sender, MediaPlayerStopEventArgs e)
        {
            BeginInvoke(new StopDelegate2(StopDelegateMethod2), null);
        }

        private delegate void StopDelegate1();

        private delegate void StopDelegate2();

        private void StopDelegateMethod1()
        {
            //timer1.Enabled = false;
            tbTimeline.Value = 0;

            MediaPlayer1.Hide();
            MediaPlayer2.Show();

            CurrentPlayer = MediaPlayer2;
            MediaPlayer2.Resume();
            if (sourceFiles.Count > 0)
            {
                PlayFile(sourceFiles[0], MediaPlayer1);
                sourceFiles.RemoveAt(0);
                MediaPlayer1.Pause();
            }
        }
        private void StopDelegateMethod2()
        {
            //timer1.Enabled = false;
            tbTimeline.Value = 0;

            MediaPlayer1.Show();
            MediaPlayer2.Hide();

            CurrentPlayer = MediaPlayer1;
            MediaPlayer1.Resume();
            if (sourceFiles.Count > 0)
            {
                PlayFile(sourceFiles[0], MediaPlayer2);
                sourceFiles.RemoveAt(0);
                MediaPlayer2.Pause();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MediaPlayer1.Status != VFMediaPlayerStatus.Free)
            {
                MediaPlayer1.Stop();
            }

            if (MediaPlayer2.Status != VFMediaPlayerStatus.Free)
            {
                MediaPlayer2.Stop();
            }
        }

        private void tbTimeline_Scroll(object sender, EventArgs e)
        {
            if (Convert.ToInt32(timer1.Tag) == 0)
            {
                CurrentPlayer.Position_Set_Time(tbTimeline.Value * 1000);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", HelpLinks.VideoTutorials);
            Process.Start(startInfo);
        }
    }
}
