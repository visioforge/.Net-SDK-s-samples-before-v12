using System.Collections.Concurrent;
using System.Threading;
using VisioForge.Types.Sources;

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

    using VisioForge.MediaFramework.MFP;
    using VisioForge.Types;
    using VisioForge.VideoFingerPrinting;

    using VisioForge_MMT.Classes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IDisposable
    {
        private FingerprintLiveData _searchLiveData;

        private FingerprintLiveData _searchLiveOverlapData;

        private ConcurrentQueue<FingerprintLiveData> _fingerprintQueue;

        private IntPtr _tempBuffer;

        private List<VFPFingerPrint> _adVFPList;

        private List<DetectedAd> _results;

        private List<VFRect> _ignoredAreas;

        private long _fragmentDuration;

        private int _fragmentCount;

        private int _overlapFragmentCount;

        private object _processingLock;

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

                Thread.Sleep(500);

                ProcessVideoDelegateMethod();

                btStart.Content = "Start";

                lbStatus.Content = string.Empty;

                if (_tempBuffer != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(_tempBuffer);
                    _tempBuffer = IntPtr.Zero;
                }
            }
            else
            {
                btStart.IsEnabled = false;
                
                lbStatus.Content = "Step 1: Searching video files";
                
                _fragmentCount = 0;
                _overlapFragmentCount = 0;

                var engine = VFMediaPlayerSource.File_VLC;

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

                var adList = new List<string>();

                _adVFPList = new List<VFPFingerPrint>();

                foreach (string item in lbAdFolders.Items)
                {
                    adList.AddRange(FileScanner.SearchVideoInFolder(item));
                }

                lbStatus.Content = "Step 2: Getting fingerprints for ads files";

                if (adList.Count == 0)
                {
                    btStart.Content = "Start";
                    lbStatus.Content = string.Empty;

                    MessageBox.Show("Ads list is empty!");
                    
                    return;
                }

                int progress = 0;
                foreach (string filename in adList)
                {
                    pbProgress.Value = progress;
                    string error = "";
                    VFPFingerPrint fp;

                    if (File.Exists(filename + ".vfsigx"))
                    {
                        fp = VFPFingerPrint.Load(filename + ".vfsigx");
                    }
                    else
                    {
                        var source = new VFPFingerprintSource(filename, engine);
                        foreach (var area in _ignoredAreas)
                        {
                            source.IgnoredAreas.Add(area);
                        }

                        fp = VFPAnalyzer.GetSearchFingerprintForVideoFile(source, out error);
                    }
                    
                    if (fp == null)
                    {
                        MessageBox.Show("Unable to get fingerpring for video file: " + filename + ". Error: " + error);
                    }
                    else
                    {
                        fp.Save(filename + ".vfsigx", false);
                        _adVFPList.Add(fp);
                    }

                    progress += 100 / adList.Count;
                }

                int fragmentDurationProperty = Convert.ToInt32(edFragmentDuration.Text);
                if (fragmentDurationProperty != 0)
                {
                    _fragmentDuration = fragmentDurationProperty * 1000;
                }
                else
                {
                    var maxDuration = _adVFPList.Max((print => print.Duration));
                    long minfragmentDuration = (((maxDuration + 1000) / 1000) + 1) * 1000;
                    _fragmentDuration = minfragmentDuration * 2;
                }

                pbProgress.Value = 100;
                
                if (_tempBuffer != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(_tempBuffer);
                    _tempBuffer = IntPtr.Zero;
                }

                lbStatus.Content = "Step 3: Starting video preview";

                if (cbSource.SelectedIndex == 0)
                {
                    VideoCapture1.Video_CaptureDevice = cbVideoSource.Text;
                    VideoCapture1.Video_CaptureFormat = cbVideoFormat.Text;
                    VideoCapture1.Video_CaptureFormat_UseBest = false;
                    VideoCapture1.Video_FrameRate = Convert.ToDouble(cbVideoFrameRate.Text);

                    VideoCapture1.Mode = VFVideoCaptureMode.VideoPreview;
                }
                else
                {
                    var ip = new IPCameraSourceSettings
                    {
                        URL = edNetworkSourceURL.Text,
                        Login = edNetworkSourceLogin.Text,
                        Password = edNetworkSourcePassword.Text
                    };

                    switch (cbNetworkSourceEngine.SelectedIndex)
                    {
                        case 0:
                            ip.Type = VFIPSource.Auto_LAV;
                            break;
                        case 1:
                            ip.Type = VFIPSource.Auto_VLC;
                            break;
                        case 2:
                            ip.Type = VFIPSource.Auto_FFMPEG;
                            break;
                    }

                    VideoCapture1.IP_Camera_Source = ip;

                    VideoCapture1.Mode = VFVideoCaptureMode.IPPreview;
                }

                VideoCapture1.Audio_PlayAudio = false;
                VideoCapture1.Audio_RecordAudio = false;
               
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

        private ObservableCollection<ResultsViewModel> resultsView = new ObservableCollection<ResultsViewModel>();

        public ObservableCollection<ResultsViewModel> ResultsView
        {
            get
            {
                return resultsView;
            }
        }

        #endregion

        private void btSaveResults_Click(object sender, RoutedEventArgs e)
        {
            string xml = XmlUtility.Obj2XmlStr(resultsView);

            var dlg = new System.Windows.Forms.SaveFileDialog
            {
                Filter = @"XML file|*.xml"
            };

            var result = dlg.ShowDialog(this.GetIWin32Window());

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

            _fingerprintQueue = new ConcurrentQueue<FingerprintLiveData>();

            _processingLock = new object();
            _results = new List<DetectedAd>();
            _ignoredAreas = new List<VFRect>();
        }

        private void VideoCapture1_OnError(object sender, ErrorsEventArgs e)
        {
            edLog.Text += e.Message + Environment.NewLine;
        }

        [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
        private static extern void CopyMemory(IntPtr dest, IntPtr src, int length);

        private delegate void ProcessVideoDelegate();

        private void ProcessVideoDelegateMethod()
        {
            lock (_processingLock)
            {
                //if (VideoCapture1.Status == VFVideoCaptureStatus.Free)
                //{
                //    return;
                //}

                //// done. searching for fingerprints.
                //VideoCapture1.Stop();

                long n;
                FingerprintLiveData fingerprint = null;

                if (_fingerprintQueue.TryDequeue(out fingerprint))
                {
                    IntPtr p = VFPSearch.Build(out n, ref fingerprint.Data);

                    VFPFingerPrint fvp = new VFPFingerPrint()
                    {
                        Data = new byte[n],
                        OriginalFilename = string.Empty
                    };

                    Marshal.Copy(p, fvp.Data, 0, (int) n);

                    foreach (var ad in _adVFPList)
                    {
                        List<int> positions;
                        bool found = VFPAnalyzer.Search(ad, fvp, ad.Duration, (int)slDifference.Value, out positions, true);

                        if (found)
                        {
                            foreach (var pos in positions)
                            {
                                DateTime tm = fingerprint.StartTime.AddMilliseconds(pos * 1000);

                                bool duplicate = false;
                                foreach (var detectedAd in _results)
                                {
                                    long time = 0;

                                    if (detectedAd.Timestamp > tm)
                                    {
                                        time = (long)(detectedAd.Timestamp - tm).TotalMilliseconds;
                                    }
                                    else
                                    {
                                        time = (long)(tm - detectedAd.Timestamp).TotalMilliseconds;
                                    }

                                    if (time < 1000)
                                    {
                                        // duplicate
                                        duplicate = true;
                                        break;
                                    }
                                }

                                if (duplicate)
                                {
                                    break;
                                }

                                _results.Add(new DetectedAd(tm));
                                resultsView.Add(
                                    new ResultsViewModel()
                                    {
                                        Sample = ad.OriginalFilename,
                                        TimeStamp = tm.ToString("HH:mm:ss.fff"),
                                        TimeStampMS = tm - new DateTime(1970, 1, 1)
                                    });
                            }
                        }
                    }

                    fingerprint.Data.Free();
                    fingerprint.Dispose();
                }
            }
        }

        private void VideoCapture1_OnVideoFrameBuffer(object sender, VideoFrameBufferEventArgs e)
        {
            try
            {
                if (_tempBuffer == IntPtr.Zero)
                {
                    _tempBuffer = Marshal.AllocCoTaskMem(e.Frame.Stride * e.Frame.Height);
                }

                // live
                if (_searchLiveData == null)
                {
                    _searchLiveData = new FingerprintLiveData((int)(_fragmentDuration / 1000), DateTime.Now);
                    _fragmentCount++;
                }

                if (e.StartTime < _fragmentDuration * _fragmentCount)
                {
                    ImageHelper.CopyMemory(_tempBuffer, e.Frame.Data, e.Frame.DataSize);

                    // process frame to remove ignored areas
                    if (_ignoredAreas.Count > 0)
                    {
                        foreach (var area in _ignoredAreas)
                        {
                            if (area.Right > e.Frame.Width || area.Bottom > e.Frame.Height)
                            {
                                continue;
                            }

                            MFP.FillColor(_tempBuffer, e.Frame.Width, e.Frame.Height, area, 0);
                        }
                    }

                    VFPSearch.Process(_tempBuffer, e.Frame.Width, e.Frame.Height, e.Frame.Stride, e.StartTime, ref _searchLiveData.Data);
                }
                else
                {
                    _fingerprintQueue.Enqueue(_searchLiveData);

                    _searchLiveData = null;

                    Dispatcher.BeginInvoke(new ProcessVideoDelegate(ProcessVideoDelegateMethod));
                }

                // overlap
                if (e.StartTime < _fragmentDuration / 2)
                {
                    return;
                }

                if (_searchLiveOverlapData == null)
                {
                    _searchLiveOverlapData = new FingerprintLiveData((int)(_fragmentDuration / 1000), DateTime.Now);
                    _overlapFragmentCount++;
                }

                if (e.StartTime < _fragmentDuration * _overlapFragmentCount + _fragmentDuration / 2)
                {
                    ImageHelper.CopyMemory(_tempBuffer, e.Frame.Data, e.Frame.DataSize);
                    VFPSearch.Process(_tempBuffer, e.Frame.Width, e.Frame.Height, e.Frame.Stride, e.StartTime, ref _searchLiveOverlapData.Data);
                }
                else
                {
                    _fingerprintQueue.Enqueue(_searchLiveOverlapData);

                    _searchLiveOverlapData = null;

                    Dispatcher.BeginInvoke(new ProcessVideoDelegate(ProcessVideoDelegateMethod));
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

        #region Dispose

        /// <summary>
        /// Dispose flag.
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Finalizes an instance of the <see cref="MainWindow"/> class. 
        /// </summary>
        ~MainWindow()
        {
            Dispose(false);
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <param name="disposing">
        /// Disposing parameter.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Free other state (managed objects).
                }

                // Free your own state (unmanaged objects).
                // Set large fields to null.

                if (_searchLiveData != null)
                {
                    _searchLiveData.Dispose();
                    _searchLiveData = null;
                }

                disposed = true;
            }
        }

        #endregion

        private void btIgnoredAreaAdd_Click(object sender, RoutedEventArgs e)
        {
            var rect = new VFRect()
            {
                Left = Convert.ToInt32(edIgnoredAreaLeft.Text),
                Top = Convert.ToInt32(edIgnoredAreaTop.Text),
                Right = Convert.ToInt32(edIgnoredAreaRight.Text),
                Bottom = Convert.ToInt32(edIgnoredAreaBottom.Text)
            };

            _ignoredAreas.Add(rect);
            lbIgnoredAreas.Items.Add($"Left: {rect.Left}, Top: {rect.Top}, Right: {rect.Right}, Bottom: {rect.Bottom}");
        }

        private void btIgnoredAreasRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            int index = lbIgnoredAreas.SelectedIndex;
            if (index >= 0)
            {
                lbIgnoredAreas.Items.RemoveAt(index);
                _ignoredAreas.RemoveAt(index);
            }
        }

        private void btIgnoredAreasRemoveAll_Click(object sender, RoutedEventArgs e)
        {
            lbIgnoredAreas.Items.Clear();
            _ignoredAreas.Clear();
        }

        private void btSortResults_Click(object sender, RoutedEventArgs e)
        {
            resultsView = new ObservableCollection<ResultsViewModel>(resultsView.OrderBy(i => i.TimeStampMS.TotalMilliseconds));
            lvResults.ItemsSource = resultsView;
        }

        private void BtAddAdFile_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = Settings.LastPath,
                Multiselect = true
            };

            System.Windows.Forms.DialogResult result = dlg.ShowDialog(this.GetIWin32Window());

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var name in dlg.FileNames)
                {
                    lbAdFolders.Items.Add(name);
                }

                Settings.LastPath = Path.GetFullPath(dlg.FileNames[0]);
            }
        }
    }
}
