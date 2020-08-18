﻿// ReSharper disable InconsistentNaming

// ReSharper disable StyleCop.SA1600
// ReSharper disable NotAccessedVariable

namespace Main_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Threading;

    using VisioForge.Controls.UI;
    using VisioForge.Controls.UI.Dialogs;
    using VisioForge.Controls.UI.Dialogs.VideoEffects;
    using VisioForge.Tools;
    using VisioForge.Tools.MediaInfo;
    using VisioForge.Types;
    using VisioForge.Types.GPUVideoEffects;
    using VisioForge.Types.VideoEffects;

    using Color = System.Windows.Media.Color;
    using MediaPlayer = VisioForge.Controls.UI.WPF.MediaPlayer;
    using MessageBox = System.Windows.MessageBox;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public partial class MainWindow
    {
        private readonly List<AudioChannelMapperItem> audioChannelMapperItems = new List<AudioChannelMapperItem>();

        // Zoom
        private double zoom = 1.0;
        private int zoomShiftX;
        private int zoomShiftY;

        // ReSharper disable InconsistentNaming

        private readonly MediaInfoReader MediaInfo = new MediaInfoReader();

        private readonly DVDInfoReader DVDInfo = new DVDInfoReader();

        //Dialogs
        private readonly FontDialog fontDialog = new FontDialog();

        private readonly Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
        private readonly ColorDialog colorDialog1 = new ColorDialog();
        private readonly FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        //timer
        private readonly DispatcherTimer timer = new DispatcherTimer();

        private void timer1_Tick()
        {
            timer.Tag = 1;
            tbTimeline.Maximum = (int)MediaPlayer1.Duration_Time().TotalSeconds;

            int value = (int)MediaPlayer1.Position_Get_Time().TotalSeconds;
            if ((value > 0) && (value < tbTimeline.Maximum))
            {
                tbTimeline.Value = value;
            }

            lbTime.Content = MediaPlayer.Helpful_SecondsToTimeFormatted((int)tbTimeline.Value) + "/" + MediaPlayer.Helpful_SecondsToTimeFormatted((int)tbTimeline.Maximum);

            if (MediaPlayer1.Source_Mode == VFMediaPlayerSource.DVD_DS)
            {
                if (MediaPlayer1.DVD_Chapter_GetCurrent() != cbDVDControlChapter.SelectedIndex && cbDVDControlChapter.SelectedIndex != -1)
                {
                    cbDVDControlChapter.SelectedIndex = MediaPlayer1.DVD_Chapter_GetCurrent();
                }
            }

            timer.Tag = 0;
        }

        private void InitTimer()
        {
            // ReSharper disable ConvertToLambdaExpression
            // ReSharper disable UnusedAnonymousMethodSignature

            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick +=
                delegate(object s, EventArgs a)
                {
                    timer1_Tick();
                };

            // ReSharper restore ConvertToLambdaExpression
            // ReSharper restore UnusedAnonymousMethodSignature
        }

        private static System.Drawing.Color ColorConv(Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        private static Color ColorConv(System.Drawing.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Forms.Application.EnableVisualStyles();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title += " (SDK v" + MediaPlayer1.SDK_Version + ", " + MediaPlayer1.SDK_State + "), C# WPF";

            // font for text logo
            fontDialog.Color = System.Drawing.Color.White;
            fontDialog.Font = new Font(System.Drawing.FontFamily.GenericSansSerif, 32);

            // set combobox indexes
            cbSourceMode.SelectedIndex = 0;
            cbImageType.SelectedIndex = 1;
            cbMotDetHLColor.SelectedIndex = 1;
            cbBarcodeType.SelectedIndex = 0;
            cbDirect2DRotate.SelectedIndex = 0;

            rbMotionDetectionExProcessor.SelectedIndex = 1;
            rbMotionDetectionExDetector.SelectedIndex = 1;

            pnChromaKeyColor.Fill = new SolidColorBrush(Color.FromArgb(255, 128, 218, 128));

            string defaultAudioRenderer = string.Empty;
            foreach (string audioOutputDevice in MediaPlayer1.Audio_OutputDevices)
            {
                cbAudioOutputDevice.Items.Add(audioOutputDevice);

                if (audioOutputDevice.Contains("Default DirectSound Device"))
                {
                    defaultAudioRenderer = audioOutputDevice;
                }
            }

            if (cbAudioOutputDevice.Items.Count > 0)
            {
                if (string.IsNullOrEmpty(defaultAudioRenderer))
                {
                    cbAudioOutputDevice.SelectedIndex = 0;
                }
                else
                {
                    cbAudioOutputDevice.Text = defaultAudioRenderer;
                }
            }

            foreach (string directShowFilter in MediaPlayer1.DirectShow_Filters)
            {
                cbFilters.Items.Add(directShowFilter);
            }

            if (cbFilters.Items.Count > 0)
            {
                cbFilters.SelectedIndex = 0;
            }

            MediaInfo.ReadFilters();

            foreach (string filter in MediaInfo.List_DirectShowFilters())
            {
                cbCustomAudioDecoder.Items.Add(filter);
                cbCustomVideoDecoder.Items.Add(filter);
                cbCustomSplitter.Items.Add(filter);
            }

            // ReSharper disable once CoVariantArrayConversion
            foreach (var item in MediaPlayer1.Audio_Effects_Equalizer_Presets())
            {
                cbAudEqualizerPreset.Items.Add(item);
            }

            cbAudEqualizerPreset.SelectedIndex = 0;

            edScreenshotsFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";
            MediaPlayer1.Debug_Dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\";

            InitTimer();
        }

        private void tbLightness_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectLightness lightness;
            var effect = MediaPlayer1.Video_Effects_Get("Lightness");
            if (effect == null)
            {
                lightness = new VFVideoEffectLightness(true, (int)tbLightness.Value);
                MediaPlayer1.Video_Effects_Add(lightness);
            }
            else
            {
                lightness = effect as IVFVideoEffectLightness;
                if (lightness != null)
                {
                    lightness.Value = (int)tbLightness.Value;
                }
            }
        }

        private void tbSaturation_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 != null)
            {
                IVFVideoEffectSaturation saturation;
                var effect = MediaPlayer1.Video_Effects_Get("Saturation");
                if (effect == null)
                {
                    saturation = new VFVideoEffectSaturation((int)tbSaturation.Value);
                    MediaPlayer1.Video_Effects_Add(saturation);
                }
                else
                {
                    saturation = effect as IVFVideoEffectSaturation;
                    if (saturation != null)
                    {
                        saturation.Value = (int)tbSaturation.Value;
                    }
                }
            }
        }

        private void tbDarkness_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectDarkness darkness;
            var effect = MediaPlayer1.Video_Effects_Get("Darkness");
            if (effect == null)
            {
                darkness = new VFVideoEffectDarkness(true, (int)tbDarkness.Value);
                MediaPlayer1.Video_Effects_Add(darkness);
            }
            else
            {
                darkness = effect as IVFVideoEffectDarkness;
                if (darkness != null)
                {
                    darkness.Value = (int)tbDarkness.Value;
                }
            }
        }

        private void cbGreyscale_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectGrayscale grayscale;
            var effect = MediaPlayer1.Video_Effects_Get("Grayscale");
            if (effect == null)
            {
                grayscale = new VFVideoEffectGrayscale(cbGreyscale.IsChecked == true);
                MediaPlayer1.Video_Effects_Add(grayscale);
            }
            else
            {
                grayscale = effect as IVFVideoEffectGrayscale;
                if (grayscale != null)
                {
                    grayscale.Enabled = cbGreyscale.IsChecked == true;
                }
            }
        }

        private void cbInvert_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectInvert invert;
            var effect = MediaPlayer1.Video_Effects_Get("Invert");
            if (effect == null)
            {
                invert = new VFVideoEffectInvert(cbInvert.IsChecked == true);
                MediaPlayer1.Video_Effects_Add(invert);
            }
            else
            {
                invert = effect as IVFVideoEffectInvert;
                if (invert != null)
                {
                    invert.Enabled = cbInvert.IsChecked == true;
                }
            }
        }
        
        private void btSelectScreenshotsFolder_Click(object sender, RoutedEventArgs e)
        {
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                edScreenshotsFolder.Text = folderDialog.SelectedPath;
            }
        }

        private async void btSaveScreenshot_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;

            string s = dt.Hour + "_" + dt.Minute + "_" + dt.Second + "_" + dt.Millisecond;

            int customWidth = 0;
            int customHeight = 0;

            if (cbScreenshotResize.IsChecked == true)
            {
                customWidth = Convert.ToInt32(edScreenshotWidth.Text);
                customHeight = Convert.ToInt32(edScreenshotHeight.Text);
            }

            switch (cbImageType.SelectedIndex)
            {
                case 0:
                    await MediaPlayer1.Frame_SaveAsync(edScreenshotsFolder.Text + "\\" + s + ".bmp", VFImageFormat.BMP, 0, customWidth, customHeight);
                    break;
                case 1:
                    await MediaPlayer1.Frame_SaveAsync(edScreenshotsFolder.Text + "\\" + s + ".jpg", VFImageFormat.JPEG, (int)tbJPEGQuality.Value, customWidth, customHeight);
                    break;
                case 2:
                    await MediaPlayer1.Frame_SaveAsync(edScreenshotsFolder.Text + "\\" + s + ".gif", VFImageFormat.GIF, 0, customWidth, customHeight);
                    break;
                case 3:
                    await MediaPlayer1.Frame_SaveAsync(edScreenshotsFolder.Text + "\\" + s + ".png", VFImageFormat.PNG, 0, customWidth, customHeight);
                    break;
                case 4:
                    await MediaPlayer1.Frame_SaveAsync(edScreenshotsFolder.Text + "\\" + s + ".tiff", VFImageFormat.TIFF, 0, customWidth, customHeight);
                    break;
            }
        }

        private void lbDVDTitles_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lbDVDTitles.SelectedIndex != -1)
            {
                cbDVDAudio.Items.Clear();
                cbDVDSubtitles.Items.Clear();

                DVDInfo.DVD_Fill_Title_Info(lbDVDTitles.SelectedIndex);

                string s = DVDInfo.DVD_Title_MainAttributes_VideoAttributes_Compression + " ";
                s = s + DVDInfo.DVD_Title_MainAttributes_VideoAttributes_SourceResolutionX + "x" + DVDInfo.DVD_Title_MainAttributes_VideoAttributes_SourceResolutionY + " ";
                s = s + DVDInfo.DVD_Title_MainAttributes_VideoAttributes_AspectX + ":" + DVDInfo.DVD_Title_MainAttributes_VideoAttributes_AspectY + " ";

                edDVDVideo.Text = s;

                for (int i = 0; i < DVDInfo.DVD_Title_MainAttributes_NumberOfAudioStreams; i++)
                {
                    DVDInfo.DVD_Fill_Title_Audio_Info(lbDVDTitles.SelectedIndex, i);
                    s = DVDInfo.DVD_Title_MainAttributes_AudioAttributes_AudioFormat;

                    s = s + " - ";
                    s = s + DVDInfo.DVD_Title_MainAttributes_AudioAttributes_NumberOfChannels + "ch" + " - ";
                    s = s + DVDInfo.DVD_Title_MainAttributes_AudioAttributes_LanguageS;

                    cbDVDAudio.Items.Add(s);
                }

                if (cbDVDAudio.Items.Count > 0)
                {
                    cbDVDAudio.SelectedIndex = 0;
                }

                for (int i = 0; i < DVDInfo.DVD_Title_MainAttributes_NumberOfSubpictureStreams; i++)
                {
                    DVDInfo.DVD_Fill_Title_Subpicture_Info(lbDVDTitles.SelectedIndex, i);
                    cbDVDSubtitles.Items.Add(DVDInfo.DVD_Title_MainAttributes_SubpictureAttributes_LanguageS);
                }

                if (cbDVDSubtitles.Items.Count > 0)
                {
                    cbDVDSubtitles.SelectedIndex = 0;
                }
            }
        }

        private void tbBalance1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream1.IsChecked == true || MediaPlayer1.Audio_Streams_AllInOne())
            {
                MediaPlayer1.Audio_OutputDevice_Balance_Set(0, (int)tbBalance1.Value);
            }
        }

        private void tbBalance2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream2.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Balance_Set(1, (int)tbBalance2.Value);
            }
        }

        private void tbBalance3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream3.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Balance_Set(2, (int)tbBalance3.Value);
            }
        }

        private void tbBalance4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream4.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Balance_Set(3, (int)tbBalance4.Value);
            }
        }

        private void tbSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            if (MediaPlayer1.Source_Mode != VFMediaPlayerSource.DVD_DS)
            {
                MediaPlayer1.SetSpeed(tbSpeed.Value / 10.0);
            }
            else
            {
                MediaPlayer1.DVD_SetSpeed(tbSpeed.Value / 10.0, false);
            }
        }

        private void tbVolume1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            if (cbAudioStream1.IsChecked == true || MediaPlayer1.Audio_Streams_AllInOne())
            {
                MediaPlayer1.Audio_OutputDevice_Volume_Set(0, (int)tbVolume1.Value);
            }
        }

        private void tbVolume2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream2.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Volume_Set(1, (int)tbVolume2.Value);
            }
        }

        private void tbTimeline_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Convert.ToInt32(timer.Tag) == 0)
            {
                MediaPlayer1.Position_Set_Time(TimeSpan.FromSeconds(tbTimeline.Value));
            }
        }

        private void tbVolume3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream3.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Volume_Set(2, (int)tbVolume3.Value);
            }
        }

        private void tbVolume4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cbAudioStream4.IsChecked == true)
            {
                MediaPlayer1.Audio_OutputDevice_Volume_Set(3, (int)tbVolume4.Value);
            }
        }

        private void btReadInfo_Click(object sender, RoutedEventArgs e)
        {
            mmInfo.Clear();

            // clear audio controls
            cbAudioStream1.IsEnabled = false;
            cbAudioStream2.IsEnabled = false;
            cbAudioStream3.IsEnabled = false;
            cbAudioStream4.IsEnabled = false;
            tbVolume1.IsEnabled = false;
            tbVolume2.IsEnabled = false;
            tbVolume3.IsEnabled = false;
            tbVolume4.IsEnabled = false;
            tbBalance1.IsEnabled = false;
            tbBalance2.IsEnabled = false;
            tbBalance3.IsEnabled = false;
            tbBalance4.IsEnabled = false;

            MediaInfo.Filename = edFilenameOrURL.Text;

            SetSourceMode();

            if ((MediaPlayer1.Source_Mode == VFMediaPlayerSource.File_DS) ||
                (MediaPlayer1.Source_Mode == VFMediaPlayerSource.File_FFMPEG) ||
                (MediaPlayer1.Source_Mode == VFMediaPlayerSource.LAV) ||
                (MediaPlayer1.Source_Mode == VFMediaPlayerSource.Encrypted_File_DS))
            {
                // "Read info" button
                if (sender != null)
                {
                    VFFilePlaybackError ErrorCode;
                    string ErrorText;
                    // ReSharper disable once AccessToStaticMemberViaDerivedType
                    if (MediaInfoReader.IsFilePlayable(edFilenameOrURL.Text, out ErrorCode, out ErrorText))
                    {
                        mmInfo.Text += "This file is playable" + Environment.NewLine;
                    }
                    else
                    {
                        mmInfo.Text += "This file is not playable" + Environment.NewLine;
                    }
                }

                VFEncryptionKeyType keyType;
                object key;
                if (rbEncryptionKeyString.IsChecked == true)
                {
                    keyType = VFEncryptionKeyType.String;
                    key = edEncryptionKeyString.Text;
                }
                else if (rbEncryptionKeyFile.IsChecked == true)
                {
                    keyType = VFEncryptionKeyType.File;
                    key = edEncryptionKeyFile.Text;
                }
                else
                {
                    keyType = VFEncryptionKeyType.Binary;
                    key = MediaPlayer.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text);
                }

                MediaInfo.ReadFileInfo(MediaPlayer1.Source_Mode == VFMediaPlayerSource.Encrypted_File_DS, key, keyType, cbUseLibMediaInfo.IsChecked == true);

                for (int i = 0; i < MediaInfo.Video_Streams_Count(); i++)
                {
                    mmInfo.Text += string.Empty + Environment.NewLine;
                    mmInfo.Text += "Video #" + Convert.ToString(i + 1) + Environment.NewLine;
                    mmInfo.Text += "Codec: " + MediaInfo.Video_Codec(i) + Environment.NewLine;
                    mmInfo.Text += "Duration: " + MediaInfo.Video_Duration(i) + Environment.NewLine;
                    mmInfo.Text += "Width: " + MediaInfo.Video_Width(i) + Environment.NewLine;
                    mmInfo.Text += "Height: " + MediaInfo.Video_Height(i) + Environment.NewLine;
                    mmInfo.Text += "FOURCC: " + MediaInfo.Video_FourCC(i) + Environment.NewLine;
                    mmInfo.Text += "Aspect Ratio: " + MediaInfo.Video_AspectRatioStr(i) + Environment.NewLine;
                    mmInfo.Text += "Frame rate: " + MediaInfo.Video_FrameRate(i) + Environment.NewLine;
                    mmInfo.Text += "Bitrate: " + MediaInfo.Video_Bitrate(i) + Environment.NewLine;
                    mmInfo.Text += "Frames count: " + MediaInfo.Video_FramesCount(i) + Environment.NewLine;
                }

                for (int i = 0; i < MediaInfo.Audio_Streams_Count(); i++)
                {
                    mmInfo.Text += string.Empty + Environment.NewLine;
                    mmInfo.Text += "Audio #" + Convert.ToString(i + 1) + Environment.NewLine;
                    mmInfo.Text += "Codec: " + MediaInfo.Audio_Codec(i) + Environment.NewLine;
                    mmInfo.Text += "Codec info: " + MediaInfo.Audio_CodecInfo(i) + Environment.NewLine;
                    mmInfo.Text += "Duration: " + MediaInfo.Audio_Duration(i) + Environment.NewLine;
                    mmInfo.Text += "Bitrate: " + MediaInfo.Audio_Bitrate(i) + Environment.NewLine;
                    mmInfo.Text += "Channels: " + MediaInfo.Audio_Channels(i) + Environment.NewLine;
                    mmInfo.Text += "Sample rate: " + MediaInfo.Audio_SampleRate(i) + Environment.NewLine;
                    mmInfo.Text += "BPS: " + MediaInfo.Audio_BPS(i) + Environment.NewLine;
                }

                for (int i = 0; i < MediaInfo.Text_Streams_Count(); i++)
                {
                    mmInfo.Text += string.Empty + Environment.NewLine;
                    mmInfo.Text += "Text #" + Convert.ToString(i + 1) + Environment.NewLine;
                    mmInfo.Text += "Codec: " + MediaInfo.Text_Codec(i) + Environment.NewLine;
                    mmInfo.Text += "Name: " + MediaInfo.Text_Name(i) + Environment.NewLine;
                    mmInfo.Text += "Language: " + MediaInfo.Text_Language(i) + Environment.NewLine;
                }

                // timeline
                if (MediaInfo.Video_Streams_Count() > 0)
                {
                    tbTimeline.Maximum = (int)(MediaInfo.Video_DurationMSec(0) / 1000);
                }
                else if (MediaInfo.Audio_Streams_Count() > 0)
                {
                    tbTimeline.Maximum = (int)(MediaInfo.Audio_DurationMSec(0) / 1000);
                }

                // set audio streams tab
                int count = MediaInfo.Audio_Streams_Count();
                bool one_output = MediaInfo.Audio_Streams_AllInOne;

                cbAudioStream1.IsEnabled = true;
                cbAudioStream1.IsChecked = true;
                tbVolume1.IsEnabled = true;
                tbBalance1.IsEnabled = true;

                if (count == 0)
                {
                    return;
                }
                
                if (count > 1)
                {
                    cbAudioStream2.IsEnabled = true;
                    cbAudioStream2.IsChecked = false;
                    tbVolume2.IsEnabled = !one_output;
                    tbBalance2.IsEnabled = !one_output;
                }

                if (count > 2)
                {
                    cbAudioStream3.IsEnabled = true;
                    cbAudioStream3.IsChecked = false;
                    tbVolume3.IsEnabled = !one_output;
                    tbBalance3.IsEnabled = !one_output;
                }

                if (count > 3)
                {
                    cbAudioStream4.IsEnabled = true;
                    cbAudioStream4.IsChecked = false;
                    tbVolume4.IsEnabled = !one_output;
                    tbBalance4.IsEnabled = !one_output;
                }

                // additional audio streams added from other audio files
                int count2 = MediaPlayer1.Audio_AdditionalStreams_GetCount();

                if (count2 == 0)
                {
                    return;
                }

                int count3 = count2;

                if ((count2 + count >= 4) && (count3 > 0))
                {
                    cbAudioStream4.IsEnabled = true;
                    cbAudioStream4.IsChecked = true;
                    tbVolume4.IsEnabled = true;
                    tbBalance4.IsEnabled = true;
                    count3 = count3 - 1;
                }

                if ((count2 + count >= 3) && (count3 > 0))
                {
                    cbAudioStream3.IsEnabled = true;
                    cbAudioStream3.IsChecked = true;
                    tbVolume3.IsEnabled = true;
                    tbBalance3.IsEnabled = true;
                    count3 = count3 - 1;
                }

                if ((count2 + count >= 2) && (count3 > 0))
                {
                    cbAudioStream2.IsEnabled = true;
                    cbAudioStream2.IsChecked = true;
                    tbVolume2.IsEnabled = true;
                    tbBalance2.IsEnabled = true;
                    count3 = count3 - 1;
                }

                if ((count2 + count >= 1) && (count3 > 0))
                {
                    cbAudioStream1.IsEnabled = true;
                    cbAudioStream1.IsChecked = true;
                    tbVolume1.IsEnabled = true;
                    tbBalance1.IsEnabled = true;
                }
            }
            else if (MediaPlayer1.Source_Mode == VFMediaPlayerSource.DVD_DS)
            {
                cbAudioStream1.IsEnabled = true;
                cbAudioStream1.IsChecked = true;
                tbVolume1.IsEnabled = true;
                tbBalance1.IsEnabled = true;

                edDVDVideo.Text = string.Empty;
                lbDVDTitles.Items.Clear();
                cbDVDAudio.Items.Clear();
                cbDVDSubtitles.Items.Clear();

                cbDVDControlTitle.Items.Clear();
                cbDVDControlChapter.Items.Clear();
                cbDVDControlAudio.Items.Clear();
                cbDVDControlSubtitles.Items.Clear();

                DVDInfo.ReadDVDInfo();

                for (int i = 0; i < DVDInfo.DVD_Disc_NumOfTitles; i++)
                {
                    lbDVDTitles.Items.Add("Title " + Convert.ToString(i + 1));
                    cbDVDControlTitle.Items.Add("Title " + Convert.ToString(i + 1));
                }
            }
            else
            {
                cbAudioStream1.IsEnabled = true;
                cbAudioStream1.IsChecked = true;
                tbVolume1.IsEnabled = true;
                tbBalance1.IsEnabled = true;
            }
        }

        private FileStream memoryFileStream;

        private void LoadToMemory()
        {
            if (memoryFileStream != null)
            {
                memoryFileStream.Dispose();
                memoryFileStream = null;
            }

            memoryFileStream = new FileStream(edFilenameOrURL.Text, FileMode.Open);
            ManagedIStream stream = new ManagedIStream(memoryFileStream);

            // specifying settings
            //MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
            MediaPlayer1.Source_Stream = stream;
            MediaPlayer1.Source_Stream_Size = memoryFileStream.Length;

            // video and audio present in file. tune this settings to play audio files or video files without audio
            MediaPlayer1.Source_Stream_VideoPresent = true;
            MediaPlayer1.Source_Stream_AudioPresent = true;
        }

        private void SetSourceMode()
        {
            switch (cbSourceMode.SelectedIndex)
            {
                case 0:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.LAV;
                    break;
                case 1:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.GPU;

                    if (rbGPUIntel.IsChecked == true)
                    {
                        MediaPlayer1.Source_GPU_Mode = VFMediaPlayerSourceGPUDecoder.IntelQuickSync;
                    }
                    else if (rbGPUNVidia.IsChecked == true)
                    {
                        MediaPlayer1.Source_GPU_Mode = VFMediaPlayerSourceGPUDecoder.nVidiaCUVID;
                    }
                    else if (rbGPUDXVANative.IsChecked == true)
                    {
                        MediaPlayer1.Source_GPU_Mode = VFMediaPlayerSourceGPUDecoder.DXVA2Native;
                    }
                    else if (rbGPUDXVACopyBack.IsChecked == true)
                    {
                        MediaPlayer1.Source_GPU_Mode = VFMediaPlayerSourceGPUDecoder.DXVA2CopyBack;
                    }
                    else if (rbGPUDirect3D.IsChecked == true)
                    {
                        MediaPlayer1.Source_GPU_Mode = VFMediaPlayerSourceGPUDecoder.Direct3D11;
                    }

                    break;
                case 2:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG;
                    break;
                case 3:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_DS;
                    break;
                case 4:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_VLC;
                    break;
                case 5:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.DVD_DS;
                    break;
                case 6:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.BluRay;
                    break;
                case 7:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_DS;
                    LoadToMemory();
                    break;
                case 8:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.Memory_FFMPEG;
                    LoadToMemory();
                    break;
                case 9:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.MMS_WMV_DS;
                    break;
                case 10:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_FFMPEG;
                    break;
                case 11:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.HTTP_RTSP_VLC;
                    break;
                case 12:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.Encrypted_File_DS;
                    break;
                case 13:
                    MediaPlayer1.Source_Mode = VFMediaPlayerSource.MIDI;
                    break;
            }
        }

        private async void btStart_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Debug_Telemetry = cbTelemetry.IsChecked == true;
            MediaPlayer1.Debug_Mode = cbDebugMode.IsChecked == true;

            zoom = 1.0;
            zoomShiftX = 0;
            zoomShiftY = 0;

            mmLog.Clear();

            MediaPlayer1.Info_UseLibMediaInfo = cbUseLibMediaInfo.IsChecked == true;

            if (rbVideoDecoderDefault.IsChecked == true)
            {
                MediaPlayer1.Custom_Video_Decoder = string.Empty;
            }
            else if (rbVideoDecoderFFDShow.IsChecked == true)
            {
                MediaPlayer1.Custom_Video_Decoder = "ffdshow Video Decoder";
            }
            else if (rbVideoDecoderMS.IsChecked == true)
            {
                MediaPlayer1.Custom_Video_Decoder = "Microsoft DTV-DVD Video Decoder";
            }
            else if (rbVideoDecoderVFH264.IsChecked == true)
            {
                MediaPlayer1.Custom_Video_Decoder = "VisioForge H264 Decoder";
            }
            else if (rbVideoDecoderCustom.IsChecked == true)
            {
                MediaPlayer1.Custom_Video_Decoder = cbCustomVideoDecoder.Text;
            }

            if (rbSplitterCustom.IsChecked == true)
            {
                MediaPlayer1.Custom_Splitter = cbCustomSplitter.Text;
            }
            else
            {
                MediaPlayer1.Custom_Splitter = string.Empty;
            }

            if (rbAudioDecoderDefault.IsChecked == true)
            {
                MediaPlayer1.Custom_Audio_Decoder = string.Empty;
            }
            else if (rbAudioDecoderCustom.IsChecked == true)
            {
                MediaPlayer1.Custom_Audio_Decoder = cbCustomAudioDecoder.Text;
            }

            if (lbSourceFiles.Items.Count == 0)
            {
                MessageBox.Show(this, "Playlist is empty!");
            }

            foreach (var item in lbSourceFiles.Items)
            {
                MediaPlayer1.FilenamesOrURL.Add(item.ToString());
            }

            MediaPlayer1.Loop = cbLoop.IsChecked == true;
            MediaPlayer1.Audio_Play = cbPlayAudio.IsChecked == true;

            SetSourceMode();

            btReadInfo_Click(null, null);

            MediaPlayer1.Audio_OutputDevice = cbAudioOutputDevice.Text;

            if (rbWPF.IsChecked == true)
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;
            }
            else if (rbDirect2D.IsChecked == true)
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.Direct2D;
            }
            else if (rbEVR.IsChecked == true)
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.EVR;
            }
            else
            {
                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.None;
            }

            MediaPlayer1.Virtual_Camera_Output_Enabled = rbVirtualCameraOutput.IsChecked == true;

            if (cbStretch.IsChecked == true)
            {
                MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            MediaPlayer1.Video_Renderer.RotationAngle = Convert.ToInt32(cbDirect2DRotate.Text);

            MediaPlayer1.Video_Renderer.BackgroundColor = MediaPlayer.ColorConv(((SolidColorBrush)pnVideoRendererBGColor.Fill).Color);
            MediaPlayer1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            MediaPlayer1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;
            MediaPlayer1.Background = pnVideoRendererBGColor.Fill;

            MediaPlayer1.Video_Sample_Grabber_UseForVideoEffects = true;

            // Audio enhancement
            MediaPlayer1.Audio_Enhancer_Enabled = cbAudioEnhancementEnabled.IsChecked == true;
            if (MediaPlayer1.Audio_Enhancer_Enabled)
            {
                MediaPlayer1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.IsChecked == true);
                MediaPlayer1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.IsChecked == true);

                ApplyAudioInputGains();
                ApplyAudioOutputGains();

                MediaPlayer1.Audio_Enhancer_Timeshift(-1, (int)tbAudioTimeshift.Value);
            }

            // Audio channels mapping
            if (cbAudioChannelMapperEnabled.IsChecked == true)
            {
                MediaPlayer1.Audio_Channel_Mapper = new AudioChannelMapperSettings
                {
                    Routes = audioChannelMapperItems.ToArray(),
                    OutputChannelsCount =
                                                                Convert.ToInt32(
                                                                    edAudioChannelMapperOutputChannels.Text)
                };
            }
            else
            {
                MediaPlayer1.Audio_Channel_Mapper = null;
            }

            // Audio processing
            MediaPlayer1.Audio_Effects_Clear(-1);
            MediaPlayer1.Audio_Effects_Enabled = cbAudioEffectsEnabled.IsChecked == true;
            if (MediaPlayer1.Audio_Effects_Enabled)
            {
                MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Amplify, cbAudAmplifyEnabled.IsChecked == true, TimeSpan.Zero, TimeSpan.Zero);
                MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Equalizer, cbAudEqualizerEnabled.IsChecked == true, TimeSpan.Zero, TimeSpan.Zero);
                MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.DynamicAmplify, cbAudDynamicAmplifyEnabled.IsChecked == true, TimeSpan.Zero, TimeSpan.Zero);
                MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.Sound3D, cbAudSound3DEnabled.IsChecked == true, TimeSpan.Zero, TimeSpan.Zero);
                MediaPlayer1.Audio_Effects_Add(-1, VFAudioEffectType.TrueBass, cbAudTrueBassEnabled.IsChecked == true, TimeSpan.Zero, TimeSpan.Zero);
            }

            // VU meter Pro
            if (cbVUMeterProEnabled.IsChecked == true)
            {
                MediaPlayer1.Audio_VUMeter_Pro_Enabled = true;

                MediaPlayer1.Audio_VUMeter_Pro_Volume = (int)tbVUMeterAmplification.Value;

                volumeMeter1.Boost = (float)tbVUMeterBoost.Value / 10.0F;
                volumeMeter2.Boost = (float)tbVUMeterBoost.Value / 10.0F;

                waveformPainter.Start();
                spectrumAnalyzer.Start();
                volumeMeter1.Start();
                volumeMeter2.Start();
            }
            else
            {
                MediaPlayer1.Audio_VUMeter_Pro_Enabled = false;
            }
            
            // Video effects CPU
            AddVideoEffects();

            // Configure chroma-key
            ConfigureChromaKey();

            // Video effects GPU
            MediaPlayer1.Video_Effects_GPU_Enabled = cbVideoEffectsGPUEnabled.IsChecked == true;

            // Motion detection
            ConfigureMotionDetection();

            // Barcode detection
            MediaPlayer1.Barcode_Reader_Enabled = cbBarcodeDetectionEnabled.IsChecked == true;
            MediaPlayer1.Barcode_Reader_Type = (VFBarcodeType)cbBarcodeType.SelectedIndex;

            // Encryption
            if (rbEncryptionKeyString.IsChecked == true)
            {
                MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.String;
                MediaPlayer1.Encryption_Key = edEncryptionKeyString.Text;
            }
            else if (rbEncryptionKeyFile.IsChecked == true)
            {
                MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.File;
                MediaPlayer1.Encryption_Key = edEncryptionKeyFile.Text;
            }
            else
            {
                MediaPlayer1.Encryption_KeyType = VFEncryptionKeyType.Binary;
                MediaPlayer1.Encryption_Key = MediaPlayer.ConvertHexStringToByteArray(edEncryptionKeyHEX.Text);
            }

            MediaPlayer1.Video_Sample_Grabber_UseForVideoEffects = MediaPlayer1.Video_Effects_Enabled;

            //MediaPlayer1.Play(cbRunAsync.IsChecked == true);

            await MediaPlayer1.PlayAsync().ConfigureAwait(true);

            // DVD
            if (MediaPlayer1.Source_Mode == VFMediaPlayerSource.DVD_DS)
            {
                // select and play first title
                if (cbDVDControlTitle.Items.Count > 0)
                {
                    cbDVDControlTitle.SelectedIndex = 0;
                    cbDVDControlTitle_SelectionChanged(null, null);
                }

                // show title menu
                MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Title);
            }

            // set audio volume for each stream
            if (MediaPlayer1.Source_Mode != VFMediaPlayerSource.DVD_DS && MediaPlayer1.Source_Mode != VFMediaPlayerSource.MMS_WMV_DS)
            {
                int count = MediaPlayer1.Audio_Streams_Count();

                if (count > 0)
                {
                    MediaPlayer1.Audio_OutputDevice_Balance_Set(0, (int)tbBalance1.Value);
                    MediaPlayer1.Audio_OutputDevice_Volume_Set(0, (int)tbVolume1.Value);
                }

                // independent audio output for each audio stream
                if (!MediaPlayer1.Audio_Streams_AllInOne())
                {
                    if (count > 1)
                    {
                        MediaPlayer1.Audio_OutputDevice_Balance_Set(1, (int)tbBalance2.Value);
                        MediaPlayer1.Audio_OutputDevice_Volume_Set(1, (int)tbVolume2.Value);
                        MediaPlayer1.Audio_Streams_Set(1, false); // disable stream
                    }

                    if (count > 2)
                    {
                        MediaPlayer1.Audio_OutputDevice_Balance_Set(2, (int)tbBalance3.Value);
                        MediaPlayer1.Audio_OutputDevice_Volume_Set(2, (int)tbVolume3.Value);
                        MediaPlayer1.Audio_Streams_Set(2, false); // disable stream
                    }

                    if (count > 3)
                    {
                        MediaPlayer1.Audio_OutputDevice_Balance_Set(3, (int)tbBalance4.Value);
                        MediaPlayer1.Audio_OutputDevice_Volume_Set(3, (int)tbVolume4.Value);
                        MediaPlayer1.Audio_Streams_Set(3, false); // disable stream
                    }
                }
                else
                {
                    tbBalance2.IsEnabled = false;
                    tbVolume2.IsEnabled = false;

                    tbBalance3.IsEnabled = false;
                    tbVolume3.IsEnabled = false;

                    tbBalance4.IsEnabled = false;
                    tbVolume4.IsEnabled = false;
                }
            }
            else
            {
                MediaPlayer1.Audio_OutputDevice_Balance_Set(0, (int)tbBalance1.Value);
                MediaPlayer1.Audio_OutputDevice_Volume_Set(0, (int)tbVolume1.Value);
            }

            timer.Start();
        }

        private void AddVideoEffects()
        {
            MediaPlayer1.Video_Effects_Enabled = cbEffects.IsChecked == true;
            MediaPlayer1.Video_Effects_Clear();
            lbTextLogos.Items.Clear();
            lbImageLogos.Items.Clear();

            // Deinterlace
            if (cbDeinterlace.IsChecked == true)
            {
                MediaPlayer1.Video_Effects_Enabled = true;
                if (rbDeintBlendEnabled.IsChecked == true)
                {
                    IVFVideoEffectDeinterlaceBlend blend;
                    var effect = MediaPlayer1.Video_Effects_Get("DeinterlaceBlend");
                    if (effect == null)
                    {
                        blend = new VFVideoEffectDeinterlaceBlend(true);
                        MediaPlayer1.Video_Effects_Add(blend);
                    }
                    else
                    {
                        blend = effect as IVFVideoEffectDeinterlaceBlend;
                    }

                    if (blend == null)
                    {
                        MessageBox.Show("Unable to configure deinterlace blend effect.");
                        return;
                    }

                    blend.Threshold1 = Convert.ToInt32(edDeintBlendThreshold1.Text);
                    blend.Threshold2 = Convert.ToInt32(edDeintBlendThreshold2.Text);
                    blend.Constants1 = Convert.ToInt32(edDeintBlendConstants1.Text) / 10.0;
                    blend.Constants2 = Convert.ToInt32(edDeintBlendConstants2.Text) / 10.0;
                }
                else if (rbDeintCAVTEnabled.IsChecked == true)
                {
                    IVFVideoEffectDeinterlaceCAVT cavt;
                    var effect = MediaPlayer1.Video_Effects_Get("DeinterlaceCAVT");
                    if (effect == null)
                    {
                        cavt = new VFVideoEffectDeinterlaceCAVT(rbDeintCAVTEnabled.IsChecked == true, Convert.ToInt32(edDeintCAVTThreshold.Text));
                        MediaPlayer1.Video_Effects_Add(cavt);
                    }
                    else
                    {
                        cavt = effect as IVFVideoEffectDeinterlaceCAVT;
                    }

                    if (cavt == null)
                    {
                        System.Windows.Forms.MessageBox.Show(@"Unable to configure deinterlace CAVT effect.");
                        return;
                    }

                    cavt.Threshold = Convert.ToInt32(edDeintCAVTThreshold.Text);
                }
                else
                {
                    IVFVideoEffectDeinterlaceTriangle triangle;
                    var effect = MediaPlayer1.Video_Effects_Get("DeinterlaceTriangle");
                    if (effect == null)
                    {
                        triangle = new VFVideoEffectDeinterlaceTriangle(true, Convert.ToByte(edDeintTriangleWeight.Text));
                        MediaPlayer1.Video_Effects_Add(triangle);
                    }
                    else
                    {
                        triangle = effect as IVFVideoEffectDeinterlaceTriangle;
                    }

                    if (triangle == null)
                    {
                        MessageBox.Show("Unable to configure deinterlace triangle effect.");
                        return;
                    }

                    triangle.Weight = Convert.ToByte(edDeintTriangleWeight.Text);
                }
            }

            // Denoise
            if (cbDenoise.IsChecked == true)
            {
                MediaPlayer1.Video_Effects_Enabled = true;
                if (rbDenoiseCAST.IsChecked == true)
                {
                    IVFVideoEffectDenoiseCAST cast;
                    var effect = MediaPlayer1.Video_Effects_Get("DenoiseCAST");
                    if (effect == null)
                    {
                        cast = new VFVideoEffectDenoiseCAST(true);
                        MediaPlayer1.Video_Effects_Add(cast);
                    }
                    else
                    {
                        cast = effect as IVFVideoEffectDenoiseCAST;
                    }

                    if (cast == null)
                    {
                        MessageBox.Show("Unable to configure denoise CAST effect.");
                        return;
                    }
                }
                else
                {
                    IVFVideoEffectDenoiseMosquito mosquito;
                    var effect = MediaPlayer1.Video_Effects_Get("DenoiseMosquito");
                    if (effect == null)
                    {
                        mosquito = new VFVideoEffectDenoiseMosquito(true);
                        MediaPlayer1.Video_Effects_Add(mosquito);
                    }
                    else
                    {
                        mosquito = effect as IVFVideoEffectDenoiseMosquito;
                    }

                    if (mosquito == null)
                    {
                        MessageBox.Show("Unable to configure denoise mosquito effect.");
                        return;
                    }
                }
            }

            // Other effects
            if (tbLightness.Value > 0)
            {
                tbLightness_Scroll(null, null);
            }

            if (tbSaturation.Value < 255)
            {
                tbSaturation_Scroll(null, null);
            }

            if (tbContrast.Value > 0)
            {
                tbContrast_Scroll(null, null);
            }

            if (tbDarkness.Value > 0)
            {
                tbDarkness_Scroll(null, null);
            }

            if (cbGreyscale.IsChecked == true)
            {
                cbGreyscale_Checked(null, null);
            }

            if (cbInvert.IsChecked == true)
            {
                cbInvert_Checked(null, null);
            }

            if (cbZoomEnabled.IsChecked == true)
            {
                cbZoomEnabled_Checked(null, null);
            }

            if (cbPan.IsChecked == true)
            {
                cbPan_Checked(null, null);
            }

            if (cbFadeInOut.IsChecked == true)
            {
                cbFadeInOut_Checked(null, null);
            }

            if (cbFlipX.IsChecked == true)
            {
                CbFlipX_Checked(null, null);
            }

            if (cbFlipY.IsChecked == true)
            {
                CbFlipY_Checked(null, null);
            }

            if (cbLiveRotation.IsChecked == true)
            {
                cbLiveRotation_Checked(null, null);
            }
        }

        private void btSelectFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edFilenameOrURL.Text = openFileDialog1.FileName;
            }
        }

        private void btDVDControlRootMenu_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Root);
        }

        private void btDVDControlTitleMenu_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.DVD_Menu_Show(VFDVDMenu.Title);
        }

        private void cbAudioStream1_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Streams_Set(0, cbAudioStream1.IsChecked == true);
            if (cbAudioStream1.IsChecked == true)
            {
                tbVolume1_ValueChanged(null, null);

                if (MediaPlayer1.Audio_Streams_AllInOne())
                {
                    cbAudioStream2.IsChecked = false;
                    cbAudioStream3.IsChecked = false;
                    cbAudioStream4.IsChecked = false;
                }
            }
        }

        private void cbAudioStream2_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Streams_Set(1, cbAudioStream2.IsChecked == true);
            if (cbAudioStream2.IsChecked == true)
            {
                tbVolume2_ValueChanged(null, null);

                if (MediaPlayer1.Audio_Streams_AllInOne())
                {
                    cbAudioStream1.IsChecked = false;
                    cbAudioStream3.IsChecked = false;
                    cbAudioStream4.IsChecked = false;
                }
            }
        }

        private void cbAudioStream3_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Streams_Set(2, cbAudioStream3.IsChecked == true);
            if (cbAudioStream3.IsChecked == true)
            {
                tbVolume3_ValueChanged(null, null);

                if (MediaPlayer1.Audio_Streams_AllInOne())
                {
                    cbAudioStream1.IsChecked = false;
                    cbAudioStream2.IsChecked = false;
                    cbAudioStream4.IsChecked = false;
                }
            }
        }

        private void cbAudioStream4_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Streams_Set(3, cbAudioStream4.IsChecked == true);
            if (cbAudioStream4.IsChecked == true)
            {
                tbVolume4_ValueChanged(null, null);

                if (MediaPlayer1.Audio_Streams_AllInOne())
                {
                    cbAudioStream1.IsChecked = false;
                    cbAudioStream2.IsChecked = false;
                    cbAudioStream3.IsChecked = false;
                }
            }
        }

        private void cbDVDControlAudio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDVDControlAudio.SelectedIndex > 0)
            {
                MediaPlayer1.DVD_Select_AudioStream(cbDVDControlAudio.SelectedIndex);
            }
        }

        private void cbDVDControlChapter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDVDControlChapter.SelectedIndex > 0)
            {
                MediaPlayer1.DVD_Chapter_Select(cbDVDControlChapter.SelectedIndex);
            }
        }

        private void cbDVDControlSubtitles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDVDControlSubtitles.SelectedIndex > 0)
            {
                MediaPlayer1.DVD_Select_SubpictureStream(cbDVDControlSubtitles.SelectedIndex - 1);
            }

            // 0 - x - subtitles
            // -1 - disable subtitles
        }

        private void cbDVDControlTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbDVDControlTitle.SelectedIndex != -1)
            {
                //fill info
                cbDVDControlAudio.Items.Clear();
                cbDVDControlSubtitles.Items.Clear();
                cbDVDControlChapter.Items.Clear();

                DVDInfo.DVD_Fill_Title_Info(cbDVDControlTitle.SelectedIndex);

                for (int i = 0; i < DVDInfo.DVD_Title_NumberOfChapters; i++)
                {
                    cbDVDControlChapter.Items.Add("Chapter " + Convert.ToString(i + 1));
                }

                if (cbDVDControlChapter.Items.Count > 0)
                {
                    cbDVDControlChapter.SelectedIndex = 0;
                }

                for (int i = 0; i < DVDInfo.DVD_Title_MainAttributes_NumberOfAudioStreams; i++)
                {
                    DVDInfo.DVD_Fill_Title_Audio_Info(cbDVDControlTitle.SelectedIndex, i);
                    string s = DVDInfo.DVD_Title_MainAttributes_AudioAttributes_AudioFormat;

                    s = s + " - ";
                    s = s + DVDInfo.DVD_Title_MainAttributes_AudioAttributes_NumberOfChannels + "ch" + " - ";
                    s = s + DVDInfo.DVD_Title_MainAttributes_AudioAttributes_LanguageS;

                    cbDVDControlAudio.Items.Add(s);
                }

                if (cbDVDControlAudio.Items.Count > 0)
                {
                    cbDVDControlAudio.SelectedIndex = 0;
                }

                cbDVDControlSubtitles.Items.Add("Disabled");
                for (int i = 0; i < DVDInfo.DVD_Title_MainAttributes_NumberOfSubpictureStreams; i++)
                {
                    DVDInfo.DVD_Fill_Title_Subpicture_Info(cbDVDControlTitle.SelectedIndex, i);
                    cbDVDControlSubtitles.Items.Add(DVDInfo.DVD_Title_MainAttributes_SubpictureAttributes_LanguageS);
                }

                cbDVDControlSubtitles.SelectedIndex = 0;

                //if null we just enumerate titles and chapters
                if (sender != null)
                {
                    //play title
                    MediaPlayer1.DVD_Title_Play(cbDVDControlTitle.SelectedIndex);
                    tbTimeline.Maximum = MediaPlayer1.DVD_Title_GetDuration().TotalSeconds;
                }
            }
        }

        private void ClearUI()
        {
            tbTimeline.Value = 0;

            waveformPainter.Stop();
            waveformPainter.Clear();

            spectrumAnalyzer.Stop();
            spectrumAnalyzer.Clear();

            volumeMeter1.Stop();
            volumeMeter1.Clear();

            volumeMeter2.Stop();
            volumeMeter2.Clear();
        }

        private async Task StopAll()
        {
            await MediaPlayer1.StopAsync().ConfigureAwait(false);

            timer.Stop();

            if (Dispatcher.CheckAccess())
            {
                ClearUI();
            }
            else
            {
                Dispatcher.Invoke(ClearUI);
            }
        }

        private async void btStop_Click(object sender, RoutedEventArgs e)
        {
            await StopAll();
        }

        private async void btResume_Click(object sender, RoutedEventArgs e)
        {
            await MediaPlayer1.ResumeAsync().ConfigureAwait(false);
        }

        private async void btPause_Click(object sender, RoutedEventArgs e)
        {
            await MediaPlayer1.PauseAsync().ConfigureAwait(false);
        }

        private void btNextFrame_Click(object sender, RoutedEventArgs e)
        {
            if (MediaPlayer1.Video_Renderer.Video_Renderer != VFVideoRendererWPF.EVR)
            {
                MessageBox.Show(this, "Please set video renderer to EVR to support frame step.");
                return;
            }

            MediaPlayer1.NextFrame();
        }

        private void tbContrast_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFVideoEffectContrast contrast;
            var effect = MediaPlayer1.Video_Effects_Get("Contrast");
            if (effect == null)
            {
                contrast = new VFVideoEffectContrast(true, (int)tbContrast.Value);
                MediaPlayer1.Video_Effects_Add(contrast);
            }
            else
            {
                contrast = effect as IVFVideoEffectContrast;
                if (contrast != null)
                {
                    contrast.Value = (int)tbContrast.Value;
                }
            }
        }

        private void btAudEqRefresh_Click(object sender, RoutedEventArgs e)
        {
            tbAudEq0.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 0);
            tbAudEq1.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 1);
            tbAudEq2.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 2);
            tbAudEq3.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 3);
            tbAudEq4.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 4);
            tbAudEq5.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 5);
            tbAudEq6.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 6);
            tbAudEq7.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 7);
            tbAudEq8.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 8);
            tbAudEq9.Value = MediaPlayer1.Audio_Effects_Equalizer_Band_Get(-1, 1, 9);
        }

        private void cbAudAmplifyEnabled_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Enable(-1, 0, cbAudAmplifyEnabled.IsChecked == true);
        }

        private void cbAudDynamicAmplifyEnabled_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Enable(-1, 2, cbAudDynamicAmplifyEnabled.IsChecked == true);
        }

        private void cbAudEqualizerEnabled_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Enable(-1, 1, cbAudEqualizerEnabled.IsChecked == true);
        }

        private void cbAudEqualizerPreset_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Equalizer_Preset_Set(-1, 1, (EqualizerPreset)cbAudEqualizerPreset.SelectedIndex);
            btAudEqRefresh_Click(null, null);
        }

        private void cbAudSound3DEnabled_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Enable(-1, 3, cbAudSound3DEnabled.IsChecked == true);
        }

        private void cbAudTrueBassEnabled_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Effects_Enable(-1, 4, cbAudTrueBassEnabled.IsChecked == true);
        }
        
        private void tbAud3DSound_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Sound3D(-1, 3, (int)tbAud3DSound.Value);
        }

        private void tbAudAmplifyAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Amplify(-1, 0, (int)tbAudAmplifyAmp.Value * 10, false);
        }

        private void tbAudAttack_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_DynamicAmplify(-1, 2, (int)tbAudAttack.Value, (int)tbAudDynAmp.Value, (int)tbAudRelease.Value);
        }

        private void tbAudDynAmp_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_DynamicAmplify(-1, 2, (int)tbAudAttack.Value, (int)tbAudDynAmp.Value, (int)tbAudRelease.Value);
        }

        private void tbAudEq0_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 0, (int)tbAudEq0.Value);
        }

        private void tbAudEq1_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 1, (int)tbAudEq1.Value);
        }

        private void tbAudEq2_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 2, (int)tbAudEq2.Value);
        }

        private void tbAudEq3_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 3, (int)tbAudEq3.Value);
        }

        private void tbAudEq4_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 4, (int)tbAudEq4.Value);
        }

        private void tbAudEq5_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 5, (int)tbAudEq5.Value);
        }

        private void tbAudEq6_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 6, (int)tbAudEq6.Value);
        }

        private void tbAudEq7_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 7, (int)tbAudEq7.Value);
        }

        private void tbAudEq8_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 8, (int)tbAudEq8.Value);
        }

        private void tbAudEq9_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_Equalizer_Band_Set(-1, 1, 9, (int)tbAudEq9.Value);
        }

        private void tbAudRelease_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_DynamicAmplify(-1, 2, (int)tbAudAttack.Value, (int)tbAudDynAmp.Value, (int)tbAudRelease.Value);
        }

        private void tbAudTrueBass_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaPlayer1?.Audio_Effects_TrueBass(-1, 4, 200, false, (int)tbAudTrueBass.Value);
        }

        private void tbJPEGQuality_Scroll(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbJPEGQuality != null)
            {
                lbJPEGQuality.Content = tbJPEGQuality.Value.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void MediaPlayer1_OnError(object sender, ErrorsEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
            {
                mmLog.Text = mmLog.Text + e.Message + Environment.NewLine;
            }));
        }

        private void ConfigureMotionDetection()
        {
            if (cbMotDetEnabled.IsChecked == true)
            {
                MediaPlayer1.Motion_Detection = new MotionDetectionSettings
                                                    {
                                                        Enabled = cbMotDetEnabled.IsChecked == true,
                                                        Compare_Red = cbCompareRed.IsChecked == true,
                                                        Compare_Green = cbCompareGreen.IsChecked == true,
                                                        Compare_Blue = cbCompareBlue.IsChecked == true,
                                                        Compare_Greyscale = cbCompareGreyscale.IsChecked == true,
                                                        Highlight_Color =
                                                            (VFMotionCHLColor)cbMotDetHLColor.SelectedIndex,
                                                        Highlight_Enabled = cbMotDetHLEnabled.IsChecked == true,
                                                        Highlight_Threshold = (int)tbMotDetHLThreshold.Value,
                                                        FrameInterval = Convert.ToInt32(edMotDetFrameInterval.Text),
                                                        Matrix_Height = Convert.ToInt32(edMotDetMatrixHeight.Text),
                                                        Matrix_Width = Convert.ToInt32(edMotDetMatrixWidth.Text),
                                                        DropFrames_Enabled =
                                                            cbMotDetDropFramesEnabled.IsChecked == true,
                                                        DropFrames_Threshold = (int)tbMotDetDropFramesThreshold.Value
                                                    };
                MediaPlayer1.MotionDetection_Update();
            }
            else
            {
                MediaPlayer1.Motion_Detection = null;
            }
        }

        private void btMotDetUpdateSettings_Click(object sender, RoutedEventArgs e)
        {
            ConfigureMotionDetection();
        }

        private void btChromaKeySelectBGImage_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edChromaKeyImage.Text = openFileDialog1.FileName;
                ConfigureChromaKey();
            }
        }

        private void ConfigureMotionDetectionEx()
        {
            if (cbMotionDetectionEx.IsChecked == true)
            {
                MediaPlayer1.Motion_DetectionEx = new MotionDetectionExSettings
                {
                    ProcessorType = (MotionProcessorType)rbMotionDetectionExProcessor.SelectedIndex,
                    DetectorType = (MotionDetectorType)rbMotionDetectionExDetector.SelectedIndex
                };
            }
            else
            {
                MediaPlayer1.Motion_DetectionEx = null;
            }
        }

        private void cbAFMotionDetection_Checked(object sender, RoutedEventArgs e)
        {
            ConfigureMotionDetectionEx();
        }

        private delegate void AFMotionDelegate(float level);

        private void AFMotionDelegateMethod(float level)
        {
            pbAFMotionLevel.Value = (int)(level * 100);
        }

        private void MediaPlayer1_OnObjectDetection(object sender, MotionDetectionExEventArgs e)
        {
            Dispatcher?.BeginInvoke(new AFMotionDelegate(AFMotionDelegateMethod), e.Level);
        }

        private void ConfigureChromaKey()
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            if (MediaPlayer1.ChromaKey != null)
            {
                MediaPlayer1.ChromaKey.Dispose();
                MediaPlayer1.ChromaKey = null;
            }

            if (cbChromaKeyEnabled.IsChecked == true)
            {
                if (!File.Exists(edChromaKeyImage.Text))
                {
                    MessageBox.Show("Chroma-key background file doesn't exists.");
                    return;
                }

                MediaPlayer1.ChromaKey = new ChromaKeySettings(new Bitmap(edChromaKeyImage.Text))
                {
                    Smoothing = (float)(tbChromaKeySmoothing.Value / 1000f),
                    ThresholdSensitivity = (float)(tbChromaKeyThresholdSensitivity.Value / 1000f),
                    Color = ColorConv(((SolidColorBrush)pnChromaKeyColor.Fill).Color)
                };
            }
            else
            {
                MediaPlayer1.ChromaKey = null;
            }
        }

        private delegate void MotionDelegate(MotionDetectionEventArgs e);

        private void MotionDelegateMethod(MotionDetectionEventArgs e)
        {
            string s = string.Empty;
            int k = 0;
            foreach (byte b in e.Matrix)
            {
                s += b.ToString("D3") + " ";

                if (k == MediaPlayer1.Motion_Detection.Matrix_Width - 1)
                {
                    k = 0;
                    s += Environment.NewLine;
                }
                else
                {
                    k++;
                }
            }

            mmMotDetMatrix.Text = s.Trim();
            pbMotionLevel.Value = e.Level;
        }

        private void MediaPlayer1_OnMotion(object sender, MotionDetectionEventArgs e)
        {
            Dispatcher?.BeginInvoke(new MotionDelegate(MotionDelegateMethod), e);
        }

        private void MediaPlayer1_OnStop(object sender, MediaPlayerStopEventArgs e)
        {
            Dispatcher?.BeginInvoke(new StopDelegate(StopDelegateMethod), null);
        }

        private delegate void StopDelegate();

        private void StopDelegateMethod()
        {
            tbTimeline.Value = 0;

            waveformPainter.Stop();
            waveformPainter.Clear();

            spectrumAnalyzer.Stop();
            spectrumAnalyzer.Clear();

            volumeMeter1.Stop();
            volumeMeter1.Clear();

            volumeMeter2.Stop();
            volumeMeter2.Clear();

            if (memoryFileStream != null)
            {
                memoryFileStream.Dispose();
                memoryFileStream = null;
            }
        }

        private void cbZoomEnabled_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectZoom zoomEffect;
            var effect = MediaPlayer1.Video_Effects_Get("Zoom");
            if (effect == null)
            {
                zoomEffect = new VFVideoEffectZoom(zoom, zoom, zoomShiftX, zoomShiftY, cbZoomEnabled.IsChecked == true);
                MediaPlayer1.Video_Effects_Add(zoomEffect);
            }
            else
            {
                zoomEffect = effect as IVFVideoEffectZoom;
            }

            if (zoomEffect == null)
            {
                MessageBox.Show("Unable to configure zoom effect.");
                return;
            }

            zoomEffect.ZoomX = zoom;
            zoomEffect.ZoomY = zoom;
            zoomEffect.ShiftX = zoomShiftX;
            zoomEffect.ShiftY = zoomShiftY;
            zoomEffect.Enabled = cbZoomEnabled.IsChecked == true;
        }

        private void btEffZoomIn_Click(object sender, RoutedEventArgs e)
        {
            zoom += 0.1;
            zoom = Math.Min(zoom, 5);

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomOut_Click(object sender, RoutedEventArgs e)
        {
            zoom -= 0.1;
            zoom = Math.Max(zoom, 1);

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftUp_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftY += 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftDown_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftY -= 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftRight_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftX += 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void btEffZoomShiftLeft_Click(object sender, RoutedEventArgs e)
        {
            zoomShiftX -= 20;

            cbZoomEnabled_Checked(null, null);
        }

        private void cbPan_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectPan pan;
            var effect = MediaPlayer1.Video_Effects_Get("Pan");
            if (effect == null)
            {
                pan = new VFVideoEffectPan(true);
                MediaPlayer1.Video_Effects_Add(pan);
            }
            else
            {
                pan = effect as IVFVideoEffectPan;
            }

            if (pan == null)
            {
                MessageBox.Show("Unable to configure pan effect.");
                return;
            }

            pan.Enabled = cbPan.IsChecked == true;
            pan.StartTime = TimeSpan.FromMilliseconds(Convert.ToInt32(edPanStartTime.Text));
            pan.StopTime = TimeSpan.FromMilliseconds(Convert.ToInt32(edPanStopTime.Text));
            pan.StartX = Convert.ToInt32(edPanSourceLeft.Text);
            pan.StartY = Convert.ToInt32(edPanSourceTop.Text);
            pan.StartWidth = Convert.ToInt32(edPanSourceWidth.Text);
            pan.StartHeight = Convert.ToInt32(edPanSourceHeight.Text);
            pan.StopX = Convert.ToInt32(edPanDestLeft.Text);
            pan.StopY = Convert.ToInt32(edPanDestTop.Text);
            pan.StopWidth = Convert.ToInt32(edPanDestWidth.Text);
            pan.StopHeight = Convert.ToInt32(edPanDestHeight.Text);
        }

        private void btBarcodeReset_Click(object sender, RoutedEventArgs e)
        {
            edBarcode.Text = string.Empty;
            edBarcodeMetadata.Text = string.Empty;
            MediaPlayer1.Barcode_Reader_Enabled = true;
        }

        #region Barcode detector

        private delegate void BarcodeDelegate(BarcodeEventArgs value);

        private void BarcodeDelegateMethod(BarcodeEventArgs value)
        {
            edBarcode.Text = value.Value;
            edBarcodeMetadata.Text = string.Empty;
            foreach (var o in value.Metadata)
            {
                edBarcodeMetadata.Text += o.Key + ": " + o.Value + Environment.NewLine;
            }
        }

        private void MediaPlayer1_OnBarcodeDetected(object sender, BarcodeEventArgs e)
        {
            e.DetectorEnabled = false;

            Dispatcher?.BeginInvoke(new BarcodeDelegate(BarcodeDelegateMethod), e);
        }

        #endregion

        private void btAddFileToPlaylist_Click(object sender, RoutedEventArgs e)
        {
            lbSourceFiles.Items.Add(edFilenameOrURL.Text);
        }

        private void cbFadeInOut_Checked(object sender, RoutedEventArgs e)
        {
            if (rbFadeIn.IsChecked == true)
            {
                IVFVideoEffectFadeIn fadeIn;
                var effect = MediaPlayer1.Video_Effects_Get("FadeIn");
                if (effect == null)
                {
                    fadeIn = new VFVideoEffectFadeIn(cbFadeInOut.IsChecked == true);
                    MediaPlayer1.Video_Effects_Add(fadeIn);
                }
                else
                {
                    fadeIn = effect as IVFVideoEffectFadeIn;
                }

                if (fadeIn == null)
                {
                    MessageBox.Show("Unable to configure fade-in effect.");
                    return;
                }

                fadeIn.Enabled = cbFadeInOut.IsChecked == true;
                fadeIn.StartTime = TimeSpan.FromMilliseconds(Convert.ToInt64(edFadeInOutStartTime.Text));
                fadeIn.StopTime = TimeSpan.FromMilliseconds(Convert.ToInt64(edFadeInOutStopTime.Text));
            }
            else
            {
                IVFVideoEffectFadeOut fadeOut;
                var effect = MediaPlayer1.Video_Effects_Get("FadeOut");
                if (effect == null)
                {
                    fadeOut = new VFVideoEffectFadeOut(cbFadeInOut.IsChecked == true);
                    MediaPlayer1.Video_Effects_Add(fadeOut);
                }
                else
                {
                    fadeOut = effect as IVFVideoEffectFadeOut;
                }

                if (fadeOut == null)
                {
                    MessageBox.Show("Unable to configure fade-out effect.");
                    return;
                }

                fadeOut.Enabled = cbFadeInOut.IsChecked == true;
                fadeOut.StartTime = TimeSpan.FromMilliseconds(Convert.ToInt64(edFadeInOutStartTime.Text));
                fadeOut.StopTime = TimeSpan.FromMilliseconds(Convert.ToInt64(edFadeInOutStopTime.Text));
            }
        }

        private void label129_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", HelpLinks.VideoTutorials);
            Process.Start(startInfo);
        }

        private void MediaPlayer1_OnVideoEncrypted(object sender, EventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
            {
                MessageBox.Show(this, "Video is encrypted. Please be sure that you're entered correct pin code.");
            }));
        }

        #region Full screen

        private bool fullScreen;

        private double windowLeft;

        private double windowTop;

        private double windowWidth;

        private double windowHeight;

        private Thickness controlMargin;

        private double controlWidth;

        private double controlHeight;

        private async void btFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (!fullScreen)
            {
                // going fullscreen
                fullScreen = true;

                // saving coordinates
                windowLeft = Left;
                windowTop = Top;
                windowWidth = Width;
                windowHeight = Height;

                controlMargin = MediaPlayer1.Margin;
                controlWidth = MediaPlayer1.Width;
                controlHeight = MediaPlayer1.Height;

                // resizing window
                ResizeMode = ResizeMode.NoResize;
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
                Topmost = true;

                Left = 0;
                Top = 0;
                Width = Screen.AllScreens[0].Bounds.Width;
                Height = Screen.AllScreens[0].Bounds.Height;
                Margin = new Thickness(0);

                // resizing control
                MediaPlayer1.Margin = new Thickness(0, 0, 0, 0);
                MediaPlayer1.Width = Screen.AllScreens[0].Bounds.Width;
                MediaPlayer1.Height = Screen.AllScreens[0].Bounds.Height;

                await MediaPlayer1.Video_Renderer_UpdateAsync();
            }
            else
            {
                // going normal screen
                fullScreen = false;

                // restoring control
                MediaPlayer1.Margin = controlMargin;
                MediaPlayer1.Width = controlWidth;
                MediaPlayer1.Height = controlHeight;

                MediaPlayer1.Width = controlWidth;
                MediaPlayer1.Height = controlHeight;

                // restoring window
                Left = windowLeft;
                Top = windowTop;
                Width = windowWidth;
                Height = windowHeight;

                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
                Topmost = false;
                ResizeMode = ResizeMode.CanResize;

                await MediaPlayer1.Video_Renderer_UpdateAsync();
            }
        }

        private void MediaPlayer1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fullScreen)
            {
                btFullScreen_Click(null, null);
            }
        }

        #endregion

        private void btReversePlayback_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.ReversePlayback_CacheSize = int.Parse(edReversePlaybackCacheSize.Text);

            if (MediaPlayer1.ReversePlayback_Enabled)
            {
                btReversePlayback.Content = "Go to reverse playback mode";
                MediaPlayer1.ReversePlayback_Enabled = false;
            }
            else
            {
                btReversePlayback.Content = "Go to normal playback mode";
                MediaPlayer1.ReversePlayback_Enabled = true;
            }
        }

        private void tbReversePlaybackTrackbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (tbReversePlaybackTrackbar != null)
            {
                MediaPlayer1?.ReversePlayback_GoToFrame((int)tbReversePlaybackTrackbar.Value);
            }
        }

        #region VU meter Pro

        private void MediaPlayer1_OnAudioVUMeterProMaximumCalculated(object sender, VUMeterMaxSampleEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
                                                    {
                                                        waveformPainter.AddValue(e.MaxSample, e.MinSample);
                                                    }));
        }

        private void MediaPlayer1_OnAudioVUMeterProFFTCalculated(object sender, VUMeterFFTEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
                {
                    spectrumAnalyzer.Update(e.Result);
                }));
        }

        private void MediaPlayer1_OnAudioVUMeterProVolume(object sender, AudioLevelEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
                                                    {
                                                        volumeMeter1.Amplitude = e.ChannelLevelsDb[0];
                                                        volumeMeter1.Update();

                                                        if (e.ChannelLevelsDb.Length > 1)
                                                        {
                                                            volumeMeter2.Amplitude = e.ChannelLevelsDb[1];
                                                            volumeMeter2.Update();
                                                        }
                                                    }));
        }

        private void tbVUMeterAmplification_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 != null)
            {
                MediaPlayer1.Audio_VUMeter_Pro_Volume = (int)tbVUMeterAmplification.Value;
            }
        }

        private void tbVUMeterBoost_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            volumeMeter1.Boost = (float)tbVUMeterBoost.Value / 10.0F;
            volumeMeter2.Boost = (float)tbVUMeterBoost.Value / 10.0F;
        }

        #endregion

        private void cbLiveRotation_Checked(object sender, RoutedEventArgs e)
        {
            if (MediaPlayer1 != null)
            {
                IVFVideoEffectRotate rotate;
                var effect = MediaPlayer1.Video_Effects_Get("Rotate");
                if (effect == null)
                {
                    rotate = new VFVideoEffectRotate(
                        cbLiveRotation.IsChecked == true,
                        tbLiveRotationAngle.Value,
                        cbLiveRotationStretch.IsChecked == true);
                    MediaPlayer1.Video_Effects_Add(rotate);
                }
                else
                {
                    rotate = effect as IVFVideoEffectRotate;
                }

                if (rotate == null)
                {
                    MessageBox.Show("Unable to configure rotate effect.");
                    return;
                }

                rotate.Enabled = cbLiveRotation.IsChecked == true;
                rotate.Angle = tbLiveRotationAngle.Value;
                rotate.Stretch = cbLiveRotationStretch.IsChecked == true;
            }
        }

        private void tbLiveRotationAngle_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cbLiveRotation_Checked(sender, e);
        }

        private void cbLiveRotationStretch_Checked(object sender, RoutedEventArgs e)
        {
            cbLiveRotation_Checked(sender, e);
        }

        private async void cbScreenFlipVertical_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Flip_Vertical = cbScreenFlipVertical.IsChecked == true;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void cbScreenFlipHorizontal_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Flip_Horizontal = cbScreenFlipHorizontal.IsChecked == true;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void cbDirect2DRotate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = ((ComboBoxItem)e.AddedItems[0]).Content.ToString();
            if (!string.IsNullOrEmpty(name))
            {
                MediaPlayer1.Video_Renderer.RotationAngle = Convert.ToInt32(name);
                await MediaPlayer1.Video_Renderer_UpdateAsync();
            }
        }

        private async void btZoomShiftUp_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_ShiftY = MediaPlayer1.Video_Renderer.Zoom_ShiftY + 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void btZoomShiftRight_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_ShiftX = MediaPlayer1.Video_Renderer.Zoom_ShiftX + 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void btZoomShiftLeft_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_ShiftX = MediaPlayer1.Video_Renderer.Zoom_ShiftX - 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void btZoomShiftDown_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_ShiftY = MediaPlayer1.Video_Renderer.Zoom_ShiftY - 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void btZoomOut_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_Ratio = MediaPlayer1.Video_Renderer.Zoom_Ratio - 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void btZoomIn_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Video_Renderer.Zoom_Ratio = MediaPlayer1.Video_Renderer.Zoom_Ratio + 10;
            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private async void pnVideoRendererBGColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnVideoRendererBGColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnVideoRendererBGColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
                MediaPlayer1.Background = pnVideoRendererBGColor.Fill;

                MediaPlayer1.Video_Renderer.BackgroundColor = colorDialog1.Color;
                await MediaPlayer1.Video_Renderer_UpdateAsync();
            }
        }

        private async void cbStretch_Checked(object sender, RoutedEventArgs e)
        {
            if (cbStretch.IsChecked == true)
            {
                MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Stretch;
            }
            else
            {
                MediaPlayer1.Video_Renderer.StretchMode = VFVideoRendererStretchMode.Letterbox;
            }

            await MediaPlayer1.Video_Renderer_UpdateAsync();
        }

        private void rbVR_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDirect2D != null)
            {
                bool direct2d = rbDirect2D.IsChecked == true;
                cbScreenFlipVertical.IsEnabled = direct2d;
                cbScreenFlipHorizontal.IsEnabled = direct2d;
                cbDirect2DRotate.IsEnabled = direct2d;
                pnZoom.IsEnabled = direct2d;
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1 && e != null && e.AddedItems.Count > 0)
            {
                string name = e.AddedItems[0].ToString();
                btFilterSettings.IsEnabled = MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                    MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbFilters.SelectedIndex != -1)
            {
                MediaPlayer1.Video_Filters_Add(cbFilters.Text);
                lbFilters.Items.Add(cbFilters.Text);
            }
        }

        private void btFilterSettings_Click(object sender, RoutedEventArgs e)
        {
            string name = cbFilters.Text;

            if (MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
            {
                MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
            }
            else if (MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
            {
                MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void btFilterSettings2_Click(object sender, RoutedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.SelectedValue.ToString();

                if (MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default))
                {
                    MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.Default);
                }
                else if (MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig))
                {
                    MediaPlayer.DirectShow_Filter_Show_Dialog(IntPtr.Zero, name, VFPropertyPage.VFWCompConfig);
                }
            }
        }

        private void btFilterDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                MediaPlayer1.Video_Filters_Delete((string)lbFilters.SelectedValue);
                lbFilters.Items.Remove(lbFilters.SelectedValue);
            }
        }

        private void btFilterDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            lbFilters.Items.Clear();
            MediaPlayer1.Video_Filters_Clear();
        }

        private void lbFilters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbFilters.SelectedIndex != -1)
            {
                string name = lbFilters.SelectedValue.ToString();
                btFilterSettings2.IsEnabled = MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.Default) ||
                                            MediaPlayer.DirectShow_Filter_Has_Dialog(name, VFPropertyPage.VFWCompConfig);
            }
        }

        private void cbAudioNormalize_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Enhancer_Normalize(-1, cbAudioNormalize.IsChecked == true);
        }

        private void cbAudioAutoGain_Checked(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.Audio_Enhancer_AutoGain(-1, cbAudioAutoGain.IsChecked == true);
        }

        private void ApplyAudioInputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = (float)tbAudioInputGainL.Value / 10.0f,
                C = (float)tbAudioInputGainC.Value / 10.0f,
                R = (float)tbAudioInputGainR.Value / 10.0f,
                SL = (float)tbAudioInputGainSL.Value / 10.0f,
                SR = (float)tbAudioInputGainSR.Value / 10.0f,
                LFE = (float)tbAudioInputGainLFE.Value / 10.0f
            };

            MediaPlayer1.Audio_Enhancer_InputGains(-1, gains);
        }

        private void tbAudioInputGainL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainL.Content = (tbAudioInputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainC_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainC.Content = (tbAudioInputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainR.Content = (tbAudioInputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainSL.Content = (tbAudioInputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainSR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainSR.Content = (tbAudioInputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void tbAudioInputGainLFE_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioInputGainLFE.Content = (tbAudioInputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioInputGains();
        }

        private void ApplyAudioOutputGains()
        {
            VFAudioEnhancerGains gains = new VFAudioEnhancerGains
            {
                L = (float)tbAudioOutputGainL.Value / 10.0f,
                C = (float)tbAudioOutputGainC.Value / 10.0f,
                R = (float)tbAudioOutputGainR.Value / 10.0f,
                SL = (float)tbAudioOutputGainSL.Value / 10.0f,
                SR = (float)tbAudioOutputGainSR.Value / 10.0f,
                LFE = (float)tbAudioOutputGainLFE.Value / 10.0f
            };

            MediaPlayer1.Audio_Enhancer_OutputGains(-1, gains);
        }

        private void tbAudioOutputGainL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainL.Content = (tbAudioOutputGainL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainC_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainC.Content = (tbAudioOutputGainC.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainR.Content = (tbAudioOutputGainR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSL_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainSL.Content = (tbAudioOutputGainSL.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainSR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainSR.Content = (tbAudioOutputGainSR.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioOutputGainLFE_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioOutputGainLFE.Content = (tbAudioOutputGainLFE.Value / 10.0f).ToString("F1");

            ApplyAudioOutputGains();
        }

        private void tbAudioTimeshift_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbAudioTimeshift.Content = tbAudioTimeshift.Value.ToString(CultureInfo.InvariantCulture) + " ms";

            MediaPlayer1.Audio_Enhancer_Timeshift(-1, (int)tbAudioTimeshift.Value);
        }

        private void MediaPlayer1_OnLicenseRequired(object sender, LicenseEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
            {
                if (cbLicensing.IsChecked == true)
                {
                    mmLog.Text += "LICENSING:" + Environment.NewLine + e.Message + Environment.NewLine;
                }
            }));
        }

        private void btEncryptionOpenFile_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                edEncryptionKeyFile.Text = openFileDialog1.FileName;
            }
        }

        private void btReadTags_Click(object sender, RoutedEventArgs e)
        {
            var tags = MediaPlayer1.Tags_Read(edFilenameOrURL.Text);

            if (tags != null)
            {
                if (tags.Pictures?.Length > 0)
                {
                    imgTags.Source = MediaPlayer.BitmapConv(tags.Pictures[0]);
                }

                edTags.Text = tags.ToString();
            }
        }

        private void btAudioChannelMapperClear_Click(object sender, RoutedEventArgs e)
        {
            audioChannelMapperItems.Clear();
            lbAudioChannelMapperRoutes.Items.Clear();
        }

        private void btAudioChannelMapperAddNewRoute_Click(object sender, RoutedEventArgs e)
        {
            var item = new AudioChannelMapperItem
            {
                SourceChannel = Convert.ToInt32(edAudioChannelMapperSourceChannel.Text),
                TargetChannel = Convert.ToInt32(edAudioChannelMapperTargetChannel.Text),
                TargetChannelVolume = (float)tbAudioChannelMapperVolume.Value / 1000.0f
            };

            audioChannelMapperItems.Add(item);

            lbAudioChannelMapperRoutes.Items.Add(
                "Source: " + edAudioChannelMapperSourceChannel.Text + ", target: "
                + edAudioChannelMapperTargetChannel.Text + ", volume: "
                + (tbAudioChannelMapperVolume.Value / 1000.0f).ToString("F2"));
        }

        private void tbGPULightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            IVFGPUVideoEffectBrightness intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Brightness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBrightness(true, (int)tbGPULightness.Value);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBrightness;
                if (intf != null)
                {
                    intf.Value = (int)tbGPULightness.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUSaturation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            IVFGPUVideoEffectSaturation intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Saturation");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectSaturation(true, (int)tbGPUSaturation.Value);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectSaturation;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUSaturation.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUContrast_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            IVFGPUVideoEffectContrast intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Contrast");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectContrast(true, (int)tbGPUContrast.Value);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as VFGPUVideoEffectContrast;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUContrast.Value;
                    intf.Update();
                }
            }
        }

        private void tbGPUDarkness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (MediaPlayer1 == null)
            {
                return;
            }

            IVFGPUVideoEffectDarkness intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Darkness");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDarkness(true, (int)tbGPUDarkness.Value);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDarkness;
                if (intf != null)
                {
                    intf.Value = (int)tbGPUDarkness.Value;
                    intf.Update();
                }
            }
        }

        private void cbGPUGreyscale_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectGrayscale intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Grayscale");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectGrayscale(cbGPUGreyscale.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectGrayscale;
                if (intf != null)
                {
                    intf.Enabled = cbGPUGreyscale.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUInvert_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectInvert intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Invert");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectInvert(cbGPUInvert.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectInvert;
                if (intf != null)
                {
                    intf.Enabled = cbGPUInvert.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUNightVision_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectNightVision intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("NightVision");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectNightVision(cbGPUNightVision.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectNightVision;
                if (intf != null)
                {
                    intf.Enabled = cbGPUNightVision.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUPixelate_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectPixelate intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Pixelate");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectPixelate(cbGPUPixelate.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectPixelate;
                if (intf != null)
                {
                    intf.Enabled = cbGPUPixelate.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUDenoise_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectDenoise intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Denoise");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDenoise(cbGPUDenoise.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDenoise;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDenoise.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUDeinterlace_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectDeinterlaceBlend intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("DeinterlaceBlend");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectDeinterlaceBlend(cbGPUDeinterlace.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectDeinterlaceBlend;
                if (intf != null)
                {
                    intf.Enabled = cbGPUDeinterlace.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void cbGPUOldMovie_Click(object sender, RoutedEventArgs e)
        {
            IVFGPUVideoEffectOldMovie intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("OldMovie");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectOldMovie(cbGPUOldMovie.IsChecked == true);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectOldMovie;
                if (intf != null)
                {
                    intf.Enabled = cbGPUOldMovie.IsChecked == true;
                    intf.Update();
                }
            }
        }

        private void btReversePlaybackPrevFrame_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.ReversePlayback_PreviousFrame();
        }

        private void btReversePlaybackNextFrame_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.ReversePlayback_NextFrame();
        }

        private void btPrevFrame_Click(object sender, RoutedEventArgs e)
        {
            if (MediaPlayer1.Video_Renderer.Video_Renderer != VFVideoRendererWPF.EVR)
            {
                MessageBox.Show(this, "Please set video renderer to EVR to support frame step.");
                return;
            }

            MediaPlayer1.PreviousFrame();
        }

        private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            await StopAll();
        }

        private void BtTextLogoAdd_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new TextLogoSettingsDialog();

            var name = dlg.GenerateNewEffectName(MediaPlayer1);
            var effect = new VFVideoEffectTextLogo(true, name);

            MediaPlayer1.Video_Effects_Add(effect);
            lbTextLogos.Items.Add(effect.Name);
            dlg.Fill(effect);

            dlg.ShowDialog(this);
            dlg.Dispose();
        }

        private void BtTextLogoEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lbTextLogos.SelectedItem != null)
            {
                var dlg = new TextLogoSettingsDialog();
                var effect = MediaPlayer1.Video_Effects_Get((string)lbTextLogos.SelectedItem);
                dlg.Attach(effect);

                dlg.ShowDialog(this);
                dlg.Dispose();
            }
        }

        private void BtTextLogoRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbTextLogos.SelectedItem != null)
            {
                MediaPlayer1.Video_Effects_Remove((string)lbTextLogos.SelectedItem);
                lbTextLogos.Items.Remove(lbTextLogos.SelectedItem);
            }
        }

        private void BtImageLogoAdd_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ImageLogoSettingsDialog();

            var name = dlg.GenerateNewEffectName(MediaPlayer1);
            var effect = new VFVideoEffectImageLogo(true, name);

            MediaPlayer1.Video_Effects_Add(effect);
            lbImageLogos.Items.Add(effect.Name);

            dlg.Fill(effect);
            dlg.ShowDialog(this);
            dlg.Dispose();
        }

        private void BtImageLogoEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lbImageLogos.SelectedItem != null)
            {
                var dlg = new ImageLogoSettingsDialog();
                var effect = MediaPlayer1.Video_Effects_Get((string)lbImageLogos.SelectedItem);

                dlg.Attach(effect);
                dlg.ShowDialog(this);
                dlg.Dispose();
            }
        }

        private void BtImageLogoRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbImageLogos.SelectedItem != null)
            {
                MediaPlayer1.Video_Effects_Remove((string)lbImageLogos.SelectedItem);
                lbImageLogos.Items.Remove(lbImageLogos.SelectedItem);
            }
        }

        private void CbFlipX_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectFlipDown flip;
            var effect = MediaPlayer1.Video_Effects_Get("FlipDown");
            if (effect == null)
            {
                flip = new VFVideoEffectFlipHorizontal(cbFlipX.IsChecked == true);
                MediaPlayer1.Video_Effects_Add(flip);
            }
            else
            {
                flip = effect as IVFVideoEffectFlipDown;
                if (flip != null)
                {
                    flip.Enabled = cbFlipX.IsChecked == true;
                }
            }
        }

        private void CbFlipY_Checked(object sender, RoutedEventArgs e)
        {
            IVFVideoEffectFlipRight flip;
            var effect = MediaPlayer1.Video_Effects_Get("FlipRight");
            if (effect == null)
            {
                flip = new VFVideoEffectFlipVertical(cbFlipY.IsChecked == true);
                MediaPlayer1.Video_Effects_Add(flip);
            }
            else
            {
                flip = effect as IVFVideoEffectFlipRight;
                if (flip != null)
                {
                    flip.Enabled = cbFlipY.IsChecked == true;
                }
            }
        }

        private void MediaPlayer1_OnMIDIFileInfo(object sender, MIDIInfoEventArgs e)
        {
            Dispatcher?.BeginInvoke((Action)(() =>
            {
                edTags.Text += "MIDI Info from OnMIDIFileInfo event:" + Environment.NewLine;
                edTags.Text += e.Info.ToString();
            }));
        }

        private void mnPlaylistRemoveAll_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer1.FilenamesOrURL.Clear();
            lbSourceFiles.Items.Clear();
        }

        private void mnPlaylistRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbSourceFiles.SelectedItem != null)
            {
                var filename = lbSourceFiles.SelectedItem.ToString();
                MediaPlayer1.FilenamesOrURL.Remove(filename);

                lbSourceFiles.Items.Remove(lbSourceFiles.SelectedItem);
            }
        }

        private void tbGPUBlur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            IVFGPUVideoEffectBlur intf;
            var effect = MediaPlayer1.Video_Effects_GPU_Get("Blur");
            if (effect == null)
            {
                intf = new VFGPUVideoEffectBlur(tbGPUBlur.Value > 0, (int)tbGPUBlur.Value);
                MediaPlayer1.Video_Effects_GPU_Add(intf);
            }
            else
            {
                intf = effect as IVFGPUVideoEffectBlur;
                if (intf != null)
                {
                    intf.Enabled = tbGPUBlur.Value > 0;
                    intf.Value = (int)tbGPUBlur.Value;
                    intf.Update();
                }
            }
        }

        private void pnChromaKeyColor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorDialog1.Color = ColorConv(((SolidColorBrush)pnChromaKeyColor.Fill).Color);

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pnChromaKeyColor.Fill = new SolidColorBrush(ColorConv(colorDialog1.Color));
                ConfigureChromaKey();
            }
        }

        private void tbChromaKeyThresholdSensitivity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ConfigureChromaKey();
        }

        private void tbChromaKeySmoothing_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ConfigureChromaKey();
        }
    }
}

// ReSharper restore InconsistentNaming