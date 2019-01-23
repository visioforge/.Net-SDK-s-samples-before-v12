using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using VisioForge.Controls.VideoCapture;
using VisioForge.Types;
using VisioForge.Types.OutputFormat;
// ReSharper disable InconsistentNaming

namespace VisioForge.Controls.UI.Dialogs.OutputFormats
{
    public partial class MP4v10SettingsDialog : Form
    {
        public MP4v10SettingsDialog()
        {
            InitializeComponent();

            LoadDefaults();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDefaults()
        {
            cbH264Profile.SelectedIndex = 2;
            cbH264Level.SelectedIndex = 0;
            cbH264RateControl.SelectedIndex = 1;
            cbH264MBEncoding.SelectedIndex = 0;

            cbH264PictureType.SelectedIndex = 0;
            cbH264TargetUsage.SelectedIndex = 3;

            cbNVENCProfile.SelectedIndex = 2;
            cbNVENCLevel.SelectedIndex = 0;
            cbNVENCRateControl.SelectedIndex = 1;

            cbMP4Mode.SelectedIndex = 1;

            cbAACOutput.SelectedIndex = 0;
            cbAACVersion.SelectedIndex = 0;
            cbAACObjectType.SelectedIndex = 1;
            cbAACBitrate.SelectedIndex = 16;
        }

        public void FillSettings(ref VFMP4v8v10Output mp4Output)
        {
            int tmp;

            switch (cbMP4Mode.SelectedIndex)
            {
                case 0:
                    // v8 Legacy(XP compatible, CPU or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v8;
                    break;
                case 1:
                    // v10(CPU or Intel QuickSync GPU)
                    mp4Output.MP4Mode = VFMP4Mode.v10;
                    break;
                case 2:
                    // v10 nVidia NVENC
                    mp4Output.MP4Mode = VFMP4Mode.v10_NVENC;
                    break;
            }

            if (mp4Output.MP4Mode == VFMP4Mode.v8 || mp4Output.MP4Mode == VFMP4Mode.v10)
            {
                // Legacy / Modern settings

                // Video H264 settings
                switch (cbH264Profile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video.Profile = VFH264Profile.ProfileAuto;
                        break;
                    case 1:
                        mp4Output.Video.Profile = VFH264Profile.ProfileBaseline;
                        break;
                    case 2:
                        mp4Output.Video.Profile = VFH264Profile.ProfileMain;
                        break;
                    case 3:
                        mp4Output.Video.Profile = VFH264Profile.ProfileHigh;
                        break;
                    case 4:
                        mp4Output.Video.Profile = VFH264Profile.ProfileHigh10;
                        break;
                    case 5:
                        mp4Output.Video.Profile = VFH264Profile.ProfileHigh422;
                        break;
                }

                switch (cbH264Level.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video.Level = VFH264Level.LevelAuto;
                        break;
                    case 1:
                        mp4Output.Video.Level = VFH264Level.Level1;
                        break;
                    case 2:
                        mp4Output.Video.Level = VFH264Level.Level11;
                        break;
                    case 3:
                        mp4Output.Video.Level = VFH264Level.Level12;
                        break;
                    case 4:
                        mp4Output.Video.Level = VFH264Level.Level13;
                        break;
                    case 5:
                        mp4Output.Video.Level = VFH264Level.Level2;
                        break;
                    case 6:
                        mp4Output.Video.Level = VFH264Level.Level21;
                        break;
                    case 7:
                        mp4Output.Video.Level = VFH264Level.Level22;
                        break;
                    case 8:
                        mp4Output.Video.Level = VFH264Level.Level3;
                        break;
                    case 9:
                        mp4Output.Video.Level = VFH264Level.Level31;
                        break;
                    case 10:
                        mp4Output.Video.Level = VFH264Level.Level32;
                        break;
                    case 11:
                        mp4Output.Video.Level = VFH264Level.Level4;
                        break;
                    case 12:
                        mp4Output.Video.Level = VFH264Level.Level41;
                        break;
                    case 13:
                        mp4Output.Video.Level = VFH264Level.Level42;
                        break;
                    case 14:
                        mp4Output.Video.Level = VFH264Level.Level5;
                        break;
                    case 15:
                        mp4Output.Video.Level = VFH264Level.Level51;
                        break;
                }

                switch (cbH264TargetUsage.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video.TargetUsage = VFH264TargetUsage.Auto;
                        break;
                    case 1:
                        mp4Output.Video.TargetUsage = VFH264TargetUsage.BestQuality;
                        break;
                    case 2:
                        mp4Output.Video.TargetUsage = VFH264TargetUsage.Balanced;
                        break;
                    case 3:
                        mp4Output.Video.TargetUsage = VFH264TargetUsage.BestSpeed;
                        break;
                }

                switch (cbH264PictureType.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video.PictureType = VFH264PictureType.Auto;
                        break;
                    case 1:
                        mp4Output.Video.PictureType = VFH264PictureType.Frame;
                        break;
                    case 2:
                        mp4Output.Video.PictureType = VFH264PictureType.TFF;
                        break;
                    case 3:
                        mp4Output.Video.PictureType = VFH264PictureType.BFF;
                        break;
                }

                mp4Output.Video.RateControl = (VFH264RateControl)cbH264RateControl.SelectedIndex;
                mp4Output.Video.MBEncoding = (VFH264MBEncoding)cbH264MBEncoding.SelectedIndex;
                mp4Output.Video.GOP = cbH264GOP.Checked;
                mp4Output.Video.BitrateAuto = cbH264AutoBitrate.Checked;

                int.TryParse(edH264IDR.Text, out tmp);
                mp4Output.Video.IDR_Period = tmp;

                int.TryParse(edH264P.Text, out tmp);
                mp4Output.Video.P_Period = tmp;

                int.TryParse(edH264Bitrate.Text, out tmp);
                mp4Output.Video.Bitrate = tmp;
            }
            else if (mp4Output.MP4Mode == VFMP4Mode.v10_NVENC)
            {
                // NVENC settings
                switch (cbNVENCProfile.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.Auto;
                        break;
                    case 1:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Baseline;
                        break;
                    case 2:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_Main;
                        break;
                    case 3:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High;
                        break;
                    case 4:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_High444;
                        break;
                    case 5:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ProgressiveHigh;
                        break;
                    case 6:
                        mp4Output.Video_NVENC.Profile = VFNVENCVideoEncoderProfile.H264_ConstrainedHigh;
                        break;
                }

                switch (cbNVENCLevel.SelectedIndex)
                {
                    case 0:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.Auto;
                        break;
                    case 1:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_1;
                        break;
                    case 2:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_11;
                        break;
                    case 3:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_12;
                        break;
                    case 4:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_13;
                        break;
                    case 5:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_2;
                        break;
                    case 6:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_21;
                        break;
                    case 7:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_22;
                        break;
                    case 8:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_3;
                        break;
                    case 9:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_31;
                        break;
                    case 10:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_32;
                        break;
                    case 11:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_4;
                        break;
                    case 12:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_41;
                        break;
                    case 13:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_42;
                        break;
                    case 14:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_5;
                        break;
                    case 15:
                        mp4Output.Video_NVENC.Level = VFNVENCEncoderLevel.H264_51;
                        break;
                }

                mp4Output.Video_NVENC.Bitrate = Convert.ToInt32(edNVENCBitrate.Text);
                mp4Output.Video_NVENC.QP = Convert.ToInt32(edNVENCQP.Text);
                mp4Output.Video_NVENC.RateControl = (VFNVENCRateControlMode) cbNVENCRateControl.SelectedIndex;
                mp4Output.Video_NVENC.GOP = Convert.ToInt32(edNVENCGOP.Text);
                mp4Output.Video_NVENC.BFrames = Convert.ToInt32(edNVENCBFrames.Text);
            }

            // Audio AAC settings
            int.TryParse(cbAACBitrate.Text, out tmp);
            mp4Output.Audio_AAC.Bitrate = tmp;
            mp4Output.Audio_AAC.Version = (VFAACVersion)cbAACVersion.SelectedIndex;
            mp4Output.Audio_AAC.Output = (VFAACOutput)cbAACOutput.SelectedIndex;
            mp4Output.Audio_AAC.Object = (VFAACObject)(cbAACObjectType.SelectedIndex + 1);

            mp4Output.UseSpecialSyncMode = cbMP4UseSpecialSyncMode.Checked;

            if (cbMP4CustomAVSettings.Checked)
            {
                mp4Output.MP4V10Flags = 0;
                if (cbMP4TimeAdjust.Checked)
                {
                    mp4Output.MP4V10Flags |= (int)MP4V10Flags.TimeAdjust;
                }

                if (cbMP4TimeOverride.Checked)
                {
                    mp4Output.MP4V10Flags |= (int)MP4V10Flags.TimeOverride;
                }
            }

            mp4Output.Encryption_Format = VFEncryptionFormat.MP4_H264_SW_AAC;

            if (rbEncryptionKeyString.Checked)
            {
                mp4Output.Encryption_KeyType = VFEncryptionKeyType.String;
                mp4Output.Encryption_Key = edEncryptionKeyString.Text;
            }
            else if (rbEncryptionKeyFile.Checked)
            {
                mp4Output.Encryption_KeyType = VFEncryptionKeyType.File;
                mp4Output.Encryption_Key = edEncryptionKeyFile.Text;
            }
            else
            {
                mp4Output.Encryption_KeyType = VFEncryptionKeyType.Binary;
                mp4Output.Encryption_Key = ConvertHexStringToByteArray(edEncryptionKeyHEX.Text);
            }

            if (rbEncryptionModeAES128.Checked)
            {
                mp4Output.Encryption_Mode = VFEncryptionMode.v8_AES128;
            }
            else
            {
                mp4Output.Encryption_Mode = VFEncryptionMode.v9_AES256;
            }
        }

        /// <summary>
        /// Converts HEX string to byte array.
        /// </summary>
        /// <param name="hexString">
        /// HEX string.
        /// </param>
        /// <returns>
        /// Byte array.
        /// </returns>
        private static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] HexAsBytes = new byte[hexString.Length / 2];
            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                HexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return HexAsBytes;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", @"http://support.visioforge.com/934037-MP4-H264--AAC-output-for-2K--4K-resolution-memory-problem");
            Process.Start(startInfo);
        }

        private void tpNVEnc_Enter(object sender, EventArgs e)
        {
            if (lbNVENCStatus.Tag.ToString() == "0")
            {
                lbNVENCStatus.Tag = 1;

                bool res = VideoCaptureCore.Filter_Supported_NVENC(out var errorCode);

                if (res)
                {
                    lbNVENCStatus.Text = "Available";
                    lbNVENCStatus.ForeColor = Color.Green;
                }
                else
                {
                    lbNVENCStatus.Text = $"Not available or error (code: {errorCode})";
                    lbNVENCStatus.ForeColor = Color.Red;
                }
            }
        }

        private void MP4v10SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void btEncryptionOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                edEncryptionKeyFile.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "https://github.com/visioforge/.Net-SDK-s-samples/tree/master/Dialogs%20Source%20Code/OutputFormats";
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }
    }
}
