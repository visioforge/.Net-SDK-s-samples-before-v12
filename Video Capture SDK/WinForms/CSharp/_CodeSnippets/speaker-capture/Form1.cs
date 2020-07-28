﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable StyleCop.SA1600
// ReSharper disable InconsistentNaming

namespace speaker_capture
{
    using VisioForge.Controls.VideoCapture;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;

    public partial class Form1 : Form
    {
        private VideoCaptureCore VideoCapture1;

        private TimeSpan _currentTimestamp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string txt)
        {
            if (IsHandleCreated)
            {
                Invoke((Action)(() => { mmLog.Text = mmLog.Text + txt + Environment.NewLine; }));
            }
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            Log(e.Message);
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            Log(e.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCaptureCore.SDK_Version + ", " + VideoCaptureCore.SDK_State + ")";

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.mp3";

            VideoCapture1 = new VideoCaptureCore();
            VideoCapture1.OnError += VideoCapture1_OnError;
            VideoCapture1.OnLicenseRequired += VideoCapture1_OnLicenseRequired;
            VideoCapture1.OnAudioFrameBuffer += VideoCapture1_OnAudioFrameBuffer;
        }

        private void VideoCapture1_OnAudioFrameBuffer(object sender, AudioFrameBufferEventArgs e)
        {
            _currentTimestamp = e.Timestamp;
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice = "VisioForge What You Hear Source";
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = true;

            VideoCapture1.Audio_RecordAudio = true;
            VideoCapture1.Audio_PlayAudio = true;

            VideoCapture1.Mode = VFVideoCaptureMode.AudioCapture;

            VideoCapture1.Output_Format = new VFMP3Output();
            VideoCapture1.Output_Filename = edOutput.Text;

            VideoCapture1.Audio_Sample_Grabber_Enabled = true;

            _currentTimestamp = TimeSpan.Zero;

            await VideoCapture1.StartAsync();

            timer1.Start();
        }

        private async void btStop_Click(object sender, EventArgs e)
        {
            await VideoCapture1.StopAsync();

            timer1.Stop();
        }

        private async void btPause_Click(object sender, EventArgs e)
        {
            await VideoCapture1.PauseAsync();
        }

        private async void btResume_Click(object sender, EventArgs e)
        {
            await VideoCapture1.ResumeAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimestamp.Text = _currentTimestamp.ToString(@"hh\:mm\:ss");
        }
    }
}
