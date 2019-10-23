using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Controls.MediaPlayer;
using VisioForge.Controls.UI;
using VisioForge.MediaFramework.CDG;
using VisioForge.Types;

namespace Karaoke_Demo
{
    public partial class Form1 : Form
    {
        private MediaPlayerCore MediaPlayer1;

        private CDGFile cdg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayer1 = new MediaPlayerCore();
            MediaPlayer1.OnError += MediaPlayer1_OnError;
            MediaPlayer1.OnLicenseRequired += MediaPlayer1_OnLicenseRequired;
            MediaPlayer1.OnStop += MediaPlayer1_OnStop;

            Text += " (SDK v" + MediaPlayerCore.SDK_Version + ", " + MediaPlayerCore.SDK_State + ")";
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edFilename.Text = openFileDialog1.FileName;

                if (cdg != null)
                {
                    cdg.Dispose();
                    cdg = null;
                }
                
                var cdgFile = Path.Combine(Path.GetDirectoryName(edFilename.Text), Path.GetFileNameWithoutExtension(edFilename.Text)) + ".cdg";
                if (File.Exists(cdgFile))
                {
                    cdg = new CDGFile(cdgFile);
                }
            }
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
            mmError.Clear();

            MediaPlayer1.FilenamesOrURL.Add(edFilename.Text);
            MediaPlayer1.Audio_PlayAudio = true;

            MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS;
            MediaPlayer1.Audio_OutputDevice = "Default DirectSound Device";

            MediaPlayer1.Video_Renderer.VideoRendererInternal = VFVideoRendererInternal.None;

            MediaPlayer1.Debug_Mode = cbDebugMode.Checked;
            MediaPlayer1.Info_UseLibMediaInfo = true;

            MediaPlayer1.Play();

            MediaPlayer1.Audio_OutputDevice_Balance_Set(0, tbBalance1.Value);
            MediaPlayer1.Audio_OutputDevice_Volume_Set(0, tbVolume1.Value);

            timer1.Enabled = true;
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

            imgScreen.Image = null;
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

            var positionMS = MediaPlayer1.Position_Get_Time();

            int value = (int)(positionMS / 1000);
            if ((value > 0) && (value < tbTimeline.Maximum))
            {
                tbTimeline.Value = value;
            }

            lbTime.Text = MediaPlayerCore.Helpful_SecondsToTimeFormatted(tbTimeline.Value) + "/" + MediaPlayerCore.Helpful_SecondsToTimeFormatted(tbTimeline.Maximum);
            
            if (cdg != null)
            {
                if (cdg.renderAtPosition(positionMS))
                {
                    imgScreen.Image = cdg.RGBImage();
                }
            }

            timer1.Tag = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", HelpLinks.VideoTutorials);
            Process.Start(startInfo);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btStop_Click(null, null);
        }
    }
}
