using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using VisioForge.Types;

namespace Video_Mixing_Demo
{
    public partial class Form1 : Form
    {
        private List<PIPInfo> _pipInfos;

        public Form1()
        {
            InitializeComponent();

            _pipInfos = new List<PIPInfo>();
        }

        private void AddFile(string filename)
        {
            var info = new PIPInfo();
            
            // first file should be added as usual, other files using PIP API
            if (MediaPlayer1.FilenamesOrURL.Count == 0)
            {
                MediaPlayer1.FilenamesOrURL.Add(filename);
                lbSourceFiles.Items.Add($@"{filename} (entire screen)");
                info.Rect = new Rectangle(0, 0, 0, 0);
            }
            else
            {
                int left = Convert.ToInt32(edPIPFileLeft.Text);
                int top = Convert.ToInt32(edPIPFileTop.Text);
                int width = Convert.ToInt32(edPIPFileWidth.Text);
                int height = Convert.ToInt32(edPIPFileHeight.Text);

                MediaPlayer1.PIP_Sources_Add(filename, left, top, width, height);
                lbSourceFiles.Items.Add($@"{filename} ({left}.{top}px, width: {width}px, height: {height}px)");
                info.Rect = new Rectangle(left, top, width, height);
            }

            info.Filename = filename;
            info.ZOrder = _pipInfos.Count;

            _pipInfos.Add(info);

            //lbSourceFiles.SelectedIndex = _pipInfos.Count - 1;
        }

        private void btAddFileToPlaylist_Click(object sender, EventArgs e)
        {
            var filename = edFilenameOrURL.Text;
            AddFile(filename);
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edFilenameOrURL.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Debug_Mode = cbDebugMode.Checked;

            mmLog.Clear();

            MediaPlayer1.Video_Renderer.Zoom_Ratio = 0;
            MediaPlayer1.Video_Renderer.Zoom_ShiftX = 0;
            MediaPlayer1.Video_Renderer.Zoom_ShiftY = 0;

            MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRenderer.VMR9;
            MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV;

            MediaPlayer1.Play();
        }

        private void MediaPlayer1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            string filename1 = @"c:\samples\!video.avi";
            string filename2 = @"c:\samples\!Noel.Fieldings.Luxury.Comedy.s02e01.2014.MPEG4.HDTVRip.mp4";
            string filename3 = @"c:\samples\!video4K.mp4";

            AddFile(filename1);
            AddFile(filename2);
            AddFile(filename3);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Stop();

            _pipInfos.Clear();
            MediaPlayer1.PIP_Sources_Clear();
            lbSourceFiles.Items.Clear();
        }

        private void btResume_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Resume();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Pause();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Text += @" (SDK v" + MediaPlayer1.SDK_Version + ", " + MediaPlayer1.SDK_State + "), C#";

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
        }

        private void lbSourceFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSourceFiles.SelectedIndex >= 0)
            {
                var pip = _pipInfos[lbSourceFiles.SelectedIndex];
                edPIPFileLeft.Text = pip.Rect.Left.ToString();
                edPIPFileTop.Text = pip.Rect.Top.ToString();
                edPIPFileWidth.Text = pip.Rect.Width.ToString();
                edPIPFileHeight.Text = pip.Rect.Height.ToString();

                edZOrder.Text = pip.ZOrder.ToString();
            }
        }

        private void btUpdateRect_Click(object sender, EventArgs e)
        {
            int index = lbSourceFiles.SelectedIndex;
            if (index >= 0)
            {
                int left = Convert.ToInt32(edPIPFileLeft.Text);
                int top = Convert.ToInt32(edPIPFileTop.Text);
                int width = Convert.ToInt32(edPIPFileWidth.Text);
                int height = Convert.ToInt32(edPIPFileHeight.Text);
                _pipInfos[index].Rect = new Rectangle(left, top, width, height);

                _pipInfos[index].ZOrder = Convert.ToInt32(edZOrder.Text);

                if (left == 0 && top == 0 && width == 0 && height == 0)
                {
                    lbSourceFiles.Items[index] = $@"{_pipInfos[index].Filename} (entire screen)";
                }
                else
                {
                    lbSourceFiles.Items[index] = $@"{_pipInfos[index].Filename} ({left}.{top}px, width: {width}px, height: {height}px)";
                }

                MediaPlayer1.PIP_Sources_SetSourcePosition(index, _pipInfos[index].Rect);
                MediaPlayer1.PIP_Sources_SetSourceOrder(index, _pipInfos[index].ZOrder);
            }
        }
    }
}
