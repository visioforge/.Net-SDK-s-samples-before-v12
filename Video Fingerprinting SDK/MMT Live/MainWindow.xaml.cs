namespace VisioForge_MMT
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows;

    using VisioForge.Types;
    using VisioForge.VideoFingerPrinting;

    using VisioForge_MMT.Classes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        private VFPSearchData searchLiveData;

        private IntPtr tempBuffer;

        private List<VFPFingerPrint> adVFPList;

        private int fragmentDuration;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btAddAdFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.FolderBrowserDialog
            {
                SelectedPath = Settings.LastPath
            };

            System.Windows.Forms.DialogResult result = dlg.ShowDialog(this.GetIWin32Window());

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                lbAdFolders.Items.Add(dlg.SelectedPath);
                Settings.LastPath = dlg.SelectedPath;
            }
        }

        private void btClearAds_Click(object sender, RoutedEventArgs e)
        {
            lbAdFolders.Items.Clear();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btStart.Content == "Stop")
            {
                VideoCapture1.Stop();

                btStart.Content = "Start";

                lbStatus.Content = string.Empty;
            }
            else
            {
                btStart.IsEnabled = false;

                lbStatus.Content = "Step 1: Searching video files";

                fragmentDuration = Convert.ToInt32(edFragmentDuration.Text) * 60 * 1000;

                VFMediaPlayerSource engine = VFMediaPlayerSource.File_VLC;

                switch (cbEngine.SelectedIndex)
                {
                    case 0:
                        engine = VFMediaPlayerSource.File_DS;
                        break;
                    case 1:
                        engine = VFMediaPlayerSource.File_FFMPEG;
                        break;
                    case 2:
                        engine = VFMediaPlayerSource.File_VLC;
                        break;
                    case 3:
                        engine = VFMediaPlayerSource.LAV;
                        break;
                }

                List<string> adList = new List<string>();

                adVFPList = new List<VFPFingerPrint>();

                foreach (string item in lbAdFolders.Items)
                {
                    adList.AddRange(FileScanner.SearchVideoInFolder(item));
                }

                lbStatus.Content = "Step 2: Getting fingerprints for ads files";

                int progress = 0;
                foreach (string filename in adList)
                {
                    pbProgress.Value = progress;
                    string error;

                    var source = new VFPFingerprintSource(filename, engine);
                    var fp = VFPAnalyzer.GetSearchFingerprintForVideoFile(source, out error);

                    if (fp == null)
                    {
                        MessageBox.Show("Unable to get fingerpring for video file: " + filename + ". Error: " + error);
                    }
                    else
                    {
                        adVFPList.Add(fp);
                    }

                    progress += 100 / adList.Count;
                }

                pbProgress.Value = 100;

                searchLiveData = new VFPSearchData(Convert.ToInt32(edFragmentDuration.Text) * 60);
                if (tempBuffer != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(tempBuffer);
                    tempBuffer = IntPtr.Zero;
                }

                lbStatus.Content = "Step 3: Starting video preview";

                VideoCapture1.Video_CaptureDevice = cbVideoSource.Text;
                VideoCapture1.Video_CaptureFormat = cbVideoFormat.Text;
                VideoCapture1.Video_CaptureFormat_UseBest = false;
                VideoCapture1.Video_FrameRate = Convert.ToDouble(cbVideoFrameRate.Text);
                VideoCapture1.Audio_PlayAudio = false;
                VideoCapture1.Audio_RecordAudio = false;
                VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
                VideoCapture1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;

                VideoCapture1.Start();

                lbStatus.Content = "Step 4: Getting data";

                pbProgress.Value = 0;

                lvResults.Items.Refresh();

                btStart.IsEnabled = true;
                btStart.Content = "Stop";
            }
        }

        #region List view

        private readonly ObservableCollection<ResultsViewModel> results = new ObservableCollection<ResultsViewModel>();

        public ObservableCollection<ResultsViewModel> Results
        {
            get
            {
                return results;
            }
        }

        #endregion

        private void btSaveResults_Click(object sender, RoutedEventArgs e)
        {
            string xml = XmlUtility.Obj2XmlStr(results);

            var dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.Filter = @"XML file|*.xml";
            System.Windows.Forms.DialogResult result = dlg.ShowDialog(this.GetIWin32Window());

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string filename = dlg.FileName;

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }

                if (!File.Exists(filename))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        sw.WriteLine(xml);
                    }
                }
            }
        }

        private void SaveSettings()
        {
            string filename = Settings.SettingsFolder + "settings.xml";

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            if (!Directory.Exists(Settings.SettingsFolder))
            {
                Directory.CreateDirectory(Settings.SettingsFolder);
            }

            Settings.Save(typeof(Settings), filename);
        }

        private void LoadSettings()
        {
            string filename = Settings.SettingsFolder + "settings.xml";

            if (File.Exists(filename))
            {
                Settings.Load(typeof(Settings), filename);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSettings();

            foreach (var item in VideoCapture1.Video_CaptureDevicesInfo)
            {
                cbVideoSource.Items.Add(item.Name);
            }

            if (cbVideoSource.Items.Count > 0)
            {
                cbVideoSource.SelectedIndex = 0;
                cbVideoSource_SelectionChanged(null, null);
            }

            VideoCapture1.OnVideoFrameBuffer += VideoCapture1_OnVideoFrameBuffer;
            VideoCapture1.OnError += VideoCapture1_OnError;
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            edLog.Text += e.Message + Environment.NewLine;
        }

        [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern void CopyMemory(IntPtr dest, IntPtr src, int length);

        private delegate void StopVideoDelegate();

        private void StopVideoDelegateMethod()
        {
            // done. searching for fingerprints.
            VideoCapture1.Stop();

            long n;
            IntPtr p = VFPSearch.Build(out n, ref searchLiveData);

            VFPFingerPrint fvp = new VFPFingerPrint()
            {
                Data = new byte[n],
                OriginalFilename = string.Empty
            };

            Marshal.Copy(p, fvp.Data, 0, (int)n);

            searchLiveData.Free();


            foreach (var ad in adVFPList)
            {
                List<int> positions;
                bool found = VFPAnalyzer.Search(ad, fvp, ad.Duration, (int)slDifference.Value, out positions, true);

                if (found)
                {
                    foreach (var pos in positions)
                    {
                        results.Add(
                            new ResultsViewModel()
                                {
                                    Sample = ad.OriginalFilename,
                                    TimeStamp = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                                    // minutes + ":" + seconds
                                });
                    }
                }
            }

            MessageBox.Show("Analyze completed!");
        }

        private void VideoCapture1_OnVideoFrameBuffer(object sender, VideoFrameBufferEventArgs e)
        {
            try
            {
                if (tempBuffer == IntPtr.Zero)
                {
                    tempBuffer = Marshal.AllocCoTaskMem(e.Width * e.Height * 3);
                }

                if (e.StartTime < fragmentDuration)
                {
                    Marshal.Copy(e.Buffer, 0, tempBuffer, e.Buffer.Length);
                    VFPSearch.Process(tempBuffer, e.Width, e.Height, e.Width * 3, e.StartTime, ref searchLiveData);
                }
                else
                {
                    Dispatcher.BeginInvoke(new StopVideoDelegate(StopVideoDelegateMethod));
                }
            }
            catch
            {
            }
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            SaveSettings();
        }

        private void cbVideoSource_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(cbVideoSource.Text))
            {
                return;
            }

            VideoCapture1.Video_CaptureDevice = cbVideoSource.Text;

            // enumerate video formats
            cbVideoFormat.Items.Clear();

            var videoCaptureDevice = VideoCapture1.Video_CaptureDevicesInfo.First(device => device.Name == cbVideoSource.Text);
            foreach (var format in videoCaptureDevice.VideoFormats)
            {
                cbVideoFormat.Items.Add(format);
            }

            if (cbVideoFormat.Items.Count > 0)
            {
                cbVideoFormat.SelectedIndex = 0;
            }

            // enumerate video frame rates
            cbVideoFrameRate.Items.Clear();

            foreach (var frameRate in videoCaptureDevice.VideoFrameRates)
            {
                cbVideoFrameRate.Items.Add(frameRate);
            }

            if (cbVideoFrameRate.Items.Count > 0)
            {
                cbVideoFrameRate.SelectedIndex = 0;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveSettings();
        }
    }
}
