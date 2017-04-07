// ReSharper disable InconsistentNaming
// ReSharper disable StyleCop.SA1600
// ReSharper disable UseObjectOrCollectionInitializer
// ReSharper disable StyleCop.SA1601
namespace VisioForge_SDK_4_Audio_Capture_CSharp
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;

    using VisioForge.Controls.UI.WinForms;
    using VisioForge.Types;
    using VisioForge.Types.OutputFormat;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " (SDK v" + VideoCapture1.SDK_Version + ", " + VideoCapture1.SDK_State + ")";

            foreach (string codec in VideoCapture1.Audio_Codecs)
            {
                cbAudioCodecs.Items.Add(codec);
            }

            if (cbAudioCodecs.Items.Count > 0)
            {
                cbAudioCodecs.SelectedIndex = 0;
                cbAudioCodecs_SelectedIndexChanged(null, null);
            }

            foreach (var device in VideoCapture1.Audio_CaptureDevicesInfo)
            {
                cbAudioInputDevice.Items.Add(device.Name);
            }

            if (cbAudioInputDevice.Items.Count > 0)
            {
                cbAudioInputDevice.SelectedIndex = 0;
                cbAudioInputDevice_SelectedIndexChanged(null, null);
            }

            cbAudioInputLine.Items.Clear();

            if (!string.IsNullOrEmpty(cbAudioInputDevice.Text))
            {
                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem != null)
                {
                    foreach (string line in deviceItem.Lines)
                    {
                        cbAudioInputLine.Items.Add(line);
                    }
                }
            }

            if (cbAudioInputLine.Items.Count > 0)
            {
                cbAudioInputLine.SelectedIndex = 0;
                cbAudioInputLine_SelectedIndexChanged(null, null);
                cbAudioInputFormat_SelectedIndexChanged(null, null);
            }
            
            foreach (string audioOutputDevice in VideoCapture1.Audio_OutputDevices)
            {
                cbAudioOutputDevice.Items.Add(audioOutputDevice);
            }

            if (cbAudioOutputDevice.Items.Count > 0)
            {
                cbAudioOutputDevice.SelectedIndex = 0;
            }

            if (cbAudioCodecs.Items.IndexOf("PCM") != -1)
            {
                cbAudioCodecs.SelectedIndex = cbAudioCodecs.Items.IndexOf("PCM");
            }

            cbAudioCodecs_SelectedIndexChanged(null, null);

            foreach (string preset in VideoCapture1.Audio_Effects_Equalizer_Presets())
            {
                cbAudEqualizerPreset.Items.Add(preset);
            }

            cbOutputFormat.SelectedIndex = 0;
            cbChannels.SelectedIndex = 0;
            cbSampleRate.SelectedIndex = 0;
            cbBPS.SelectedIndex = 0;
            cbLameCBRBitrate.SelectedIndex = 0;
            cbLameVBRMax.SelectedIndex = 0;
            cbLameVBRMin.SelectedIndex = 0;
            cbLameSampleRate.SelectedIndex = 0;
            cbAudEqualizerPreset.SelectedIndex = 0;
            cbAudEqualizerPreset_SelectedIndexChanged(null, null);

            edOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\" + "output.avi";
        }

        private void cbAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbAudioCodecs.Text;
            btAudioSettings.Enabled = VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default) ||
                VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
        }

        private void btAudioSettings_Click(object sender, EventArgs e)
        {
            string name = cbAudioCodecs.Text;

            if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.Default))
            {
                VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else
            {
                if (VideoCapture.Audio_Codec_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    VideoCapture.Audio_Codec_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void cbAudioInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAudioInputDevice.SelectedIndex != -1)
            {
                VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
                cbAudioInputFormat.Items.Clear();

                var deviceItem = VideoCapture1.Audio_CaptureDevicesInfo.First(device => device.Name == cbAudioInputDevice.Text);
                if (deviceItem == null)
                {
                    return;
                }

                foreach (string format in deviceItem.Formats)
                {
                    cbAudioInputFormat.Items.Add(format);
                }

                if (cbAudioInputFormat.Items.Count > 0)
                {
                    cbAudioInputFormat.SelectedIndex = 0;
                }

                cbAudioInputFormat_SelectedIndexChanged(null, null);

                cbAudioInputLine.Items.Clear();

                foreach (string line in deviceItem.Lines)
                {
                    cbAudioInputLine.Items.Add(line);
                }

                if (cbAudioInputLine.Items.Count > 0)
                {
                    cbAudioInputLine.SelectedIndex = 0;
                }

                cbAudioInputLine_SelectedIndexChanged(null, null);

                btAudioInputDeviceSettings.Enabled = deviceItem.DialogDefault;
            }
        }

        private void btAudioInputDeviceSettings_Click(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_SettingsDialog_Show(IntPtr.Zero, cbAudioInputDevice.Text);
        }

        private void cbAudioInputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
        }

        private void cbAudioInputLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
        }

        private void cbUseBestAudioInputFormat_CheckedChanged(object sender, EventArgs e)
        {
            cbAudioInputFormat.Enabled = !cbUseBestAudioInputFormat.Checked;
        }

        private void cbAudioOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
        }

        private void tbAudioVolume_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice_Volume_Set(tbAudioVolume.Value);
        }

        private void tbAudioBalance_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_OutputDevice_Balance_Set(tbAudioBalance.Value);
            VideoCapture1.Audio_OutputDevice_Balance_Get();
        }

        private void cbAudAmplifyEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.Checked);
        }

        private void tbAudAmplifyAmp_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Amplify(-1, 0, tbAudAmplifyAmp.Value * 10, false);
        }

        private void cbAudEqualizerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.Checked);
        }

        private void tbAudEq0_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, (sbyte)tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, (sbyte)tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, (sbyte)tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, (sbyte)tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, (sbyte)tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, (sbyte)tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, (sbyte)tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, (sbyte)tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, (sbyte)tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, (sbyte)tbAudEq9.Value);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(sender, e);
        }

        private void btAudEqRefresh_Click(object sender, EventArgs e)
        {
            tbAudEq0.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0);
            tbAudEq1.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1);
            tbAudEq2.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2);
            tbAudEq3.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3);
            tbAudEq4.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4);
            tbAudEq5.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5);
            tbAudEq6.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6);
            tbAudEq7.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7);
            tbAudEq8.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8);
            tbAudEq9.Value = VideoCapture1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9);
        }

        private void cbAudTrueBassEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 5, cbAudTrueBassEnabled.Checked);
        }

        private void tbAudTrueBass_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_TrueBass(-1, 5, 200, false, (ushort)tbAudTrueBass.Value);
        }

        private void cbAudSound3DEnabled_CheckedChanged(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.Checked);
        }

        private void tbAud3DSound_Scroll(object sender, EventArgs e)
        {
            VideoCapture1.Audio_Effects_Sound3D(-1, 3, (ushort)tbAud3DSound.Value);
        }

        private void btSelectOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            mmLog.Clear();

            VideoCapture1.Video_Renderer.Zoom_Ratio = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftX = 0;
            VideoCapture1.Video_Renderer.Zoom_ShiftY = 0;

            VideoCapture1.Debug_Mode = cbDebugMode.Checked;
            VideoCapture1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
       
            VideoCapture1.Audio_CaptureDevice = cbAudioInputDevice.Text;
            VideoCapture1.Audio_OutputDevice = cbAudioOutputDevice.Text;
            VideoCapture1.Audio_CaptureDevice_Format = cbAudioInputFormat.Text;
            VideoCapture1.Audio_CaptureDevice_Format_UseBest = false;
            VideoCapture1.Audio_CaptureDevice_Line = cbAudioInputLine.Text;
            VideoCapture1.Audio_PlayAudio = cbPlayAudio.Checked;
            VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRenderer.None;
           
            if (rbPreview.Checked)
            {
                VideoCapture1.Mode = VFVideoCaptureMode.AudioPreview;
                VideoCapture1.Audio_RecordAudio = true;
            }
            else
            {
                VideoCapture1.Mode = VFVideoCaptureMode.AudioCapture;
                VideoCapture1.Audio_RecordAudio = true;
                VideoCapture1.Output_Filename = edOutput.Text;

                if (cbOutputFormat.SelectedIndex == 0)
                {
                    var acmOutput = new VFACMOutput();

                    acmOutput.Name = cbAudioCodecs.Text;
                    acmOutput.Channels = Convert.ToInt32(cbChannels.Text);
                    acmOutput.BPS = Convert.ToInt32(cbBPS.Text);
                    acmOutput.SampleRate = Convert.ToInt32(cbSampleRate.Text);

                    VideoCapture1.Output_Format = acmOutput;
                }
                else
                {
                    var mp3Output = new VFMP3Output();

                    // main
                    mp3Output.CBR_Bitrate = Convert.ToInt32(cbLameCBRBitrate.Text);
                    mp3Output.VBR_MinBitrate = Convert.ToInt32(cbLameVBRMin.Text);
                    mp3Output.VBR_MaxBitrate = Convert.ToInt32(cbLameVBRMax.Text);
                    mp3Output.SampleRate = Convert.ToInt32(cbLameSampleRate.Text);
                    mp3Output.VBR_Quality = tbLameVBRQuality.Value;
                    mp3Output.EncodingQuality = tbLameEncodingQuality.Value;

                    if (rbLameStandardStereo.Checked)
                    {
                        mp3Output.ChannelsMode = VFLameChannelsMode.StandardStereo;
                    }
                    else if (rbLameJointStereo.Checked)
                    {
                        mp3Output.ChannelsMode = VFLameChannelsMode.JointStereo;
                    }
                    else if (rbLameDualChannels.Checked)
                    {
                        mp3Output.ChannelsMode = VFLameChannelsMode.DualStereo;
                    }
                    else
                    {
                        mp3Output.ChannelsMode = VFLameChannelsMode.Mono;
                    }

                    mp3Output.VBR_Mode = rbLameVBR.Checked;

                    // other
                    mp3Output.Copyright = cbLameCopyright.Checked;
                    mp3Output.Original = cbLameOriginal.Checked;
                    mp3Output.CRCProtected = cbLameCRCProtected.Checked;
                    mp3Output.ForceMono = cbLameForceMono.Checked;
                    mp3Output.StrictlyEnforceVBRMinBitrate = cbLameStrictlyEnforceVBRMinBitrate.Checked;
                    mp3Output.VoiceEncodingMode = cbLameVoiceEncodingMode.Checked;
                    mp3Output.KeepAllFrequencies = cbLameKeepAllFrequencies.Checked;
                    mp3Output.StrictISOCompliance = cbLameStrictISOCompilance.Checked;
                    mp3Output.DisableShortBlocks = cbLameDisableShortBlocks.Checked;
                    mp3Output.EnableXingVBRTag = cbLameEnableXingVBRTag.Checked;
                    mp3Output.ModeFixed = cbLameModeFixed.Checked;

                    VideoCapture1.Output_Format = mp3Output;
                }
            }

            // Audio processing
            VideoCapture1.Audio_Effects_Clear(-1);
            VideoCapture1.Audio_Effects_Enabled = true;

            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.Checked, -1, -1);
            VideoCapture1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.Checked, -1, -1);
  
            VideoCapture1.Start();
        }
        
        private void btStop_Click(object sender, EventArgs e)
        {
            VideoCapture1.Stop();
        }

        private void llVideoTutorials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://www.visioforge.com/video_tutorials");
            Process.Start(startInfo);
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
        }

        private void VideoCapture1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            if (cbLicensing.Checked)
            {
                mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
            }
        }
    }
}

// ReSharper restore InconsistentNaming