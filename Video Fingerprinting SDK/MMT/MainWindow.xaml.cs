// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="VisioForge">
//   VisioForge (c) 2016.
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;

namespace VisioForge_MMT
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Windows;

    using VisioForge.Types;
    using VisioForge.VideoFingerPrinting;

    using Classes;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        private List<VFRect> _ignoredAreas;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btAddBroadcastFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.FolderBrowserDialog
                          {
                              SelectedPath = Settings.LastPath
                          };

            System.Windows.Forms.DialogResult result = dlg.ShowDialog(this.GetIWin32Window());

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                lbBroadcastFolders.Items.Add(dlg.SelectedPath);
                Settings.LastPath = dlg.SelectedPath;
            }
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

        private void btClearBroadcast_Click(object sender, RoutedEventArgs e)
        {
            lbBroadcastFolders.Items.Clear();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            if (cbDebug.IsChecked == true)
            {
                VFPAnalyzer.DebugDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\VisioForge\\MMT\\";
            }

            btStart.IsEnabled = false;

            results.Clear();
            lvResults.Items.Refresh();

            lbStatus.Content = "Step 1: Searching video files";

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
            List<string> broadcastList = new List<string>();

            List<VFPFingerPrint> adVFPList = new List<VFPFingerPrint>();
            List<VFPFingerPrint> broadcastVFPList = new List<VFPFingerPrint>();

            foreach (string item in lbAdFolders.Items)
            {
                bool isDir = (File.GetAttributes(item) & FileAttributes.Directory) == FileAttributes.Directory;
                if (isDir)
                {
                    adList.AddRange(FileScanner.SearchVideoInFolder(item));
                }
                else
                {
                    adList.Add(item);
                }
            }

            foreach (string item in lbBroadcastFolders.Items)
            {
                bool isDir = (File.GetAttributes(item) & FileAttributes.Directory) == FileAttributes.Directory;
                if (isDir)
                {
                    broadcastList.AddRange(FileScanner.SearchVideoInFolder(item));
                }
                else
                {
                    broadcastList.Add(item);
                }
            }
            
            lbStatus.Content = "Step 2: Getting fingerprints for ads files";

            int progress = 0;
            foreach (string filename in adList)
            {
                pbProgress.Value = progress;

                string error;

                var source = new VFPFingerprintSource(filename, engine);
                foreach (var area in _ignoredAreas)
                {
                    source.IgnoredAreas.Add(area);
                }

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

            lbStatus.Content = "Step 3: Getting fingerprints for broadcast files";
            progress = 0;
            foreach (string filename in broadcastList)
            {
                pbProgress.Value = progress;

                string error;

                var source = new VFPFingerprintSource(filename, engine);
                foreach (var area in _ignoredAreas)
                {
                    source.IgnoredAreas.Add(area);
                }

                // source.CustomResolution = new System.Drawing.Size(640, 480);

                //source.StopTime = 150000;
                var fp = VFPAnalyzer.GetSearchFingerprintForVideoFile(source, out error);

                //var fp = VFPAnalyzer.GetSearchFingerprintForVideoFile(filename, engine, 180000, 220000, out error);

                if (fp == null)
                {
                    MessageBox.Show("Unable to get fingerpring for video file: " + filename + ". Error: " + error);
                }
                else
                {
                    broadcastVFPList.Add(fp);
                }

                progress += 100 / broadcastList.Count;
            }

            pbProgress.Value = 100;

            lbStatus.Content = "Step 4: Analyzing data";
            progress = 0;
            int foundCount = 0;
            foreach (var broadcast in broadcastVFPList)
            {
                pbProgress.Value = progress;

                foreach (var ad in adVFPList)
                {
                    List<int> positions;
                    bool found = VFPAnalyzer.Search(ad, broadcast, ad.Duration, (int)slDifference.Value, out positions, true);

                    if (found)
                    {
                        foreach (int pos in positions)
                        {
                            foundCount++;
                            int minutes = pos / 60;
                            int seconds = pos % 60;

                            results.Add(
                                new ResultsViewModel()
                                    {
                                        Sample = ad.OriginalFilename,
                                        DumpFile = broadcast.OriginalFilename,
                                        Position = minutes + ":" + seconds
                                    });
                        }
                    }
                }

                progress += 100 / broadcastList.Count;
            }

            pbProgress.Value = 0;

            lvResults.Items.Refresh();

            lbStatus.Content = "Step 5: Done. " + foundCount + " ads found.";

            btStart.IsEnabled = true;
        }

        #region List view

        private readonly ObservableCollection<ResultsViewModel> results = new ObservableCollection<ResultsViewModel>();

        public ObservableCollection<ResultsViewModel> Results { get { return this.results; } }

        #endregion

        private void btPlay_Click(object sender, RoutedEventArgs e)
        {
            if (lvResults.SelectedItem == null)
            {
                return;
            }

            if ((string)btPlay.Content == "Play")
            {
                MediaPlayer1.FilenamesOrURL.Add(((ResultsViewModel)lvResults.SelectedItem).DumpFile);

                MediaPlayer1.Video_Renderer.Video_Renderer = VFVideoRendererWPF.WPF;
                MediaPlayer1.Source_Mode = VFMediaPlayerSource.File_FFMPEG;
                MediaPlayer1.Play();

                btPlay.Content = "Stop";
            }
            else
            {
                MediaPlayer1.Stop();

                btPlay.Content = "Play";
            }
        }

        private void btSaveResults_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.SaveFileDialog
                          {
                              Filter = @"XML file|*.xml|CSV file|*.csv"
                          };
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
                    if (Path.GetExtension(filename.ToLowerInvariant()) == ".xml")
                    {
                        // XML
                        string xml = XmlUtility.Obj2XmlStr(results);

                        using (StreamWriter sw = File.CreateText(filename))
                        {
                            sw.WriteLine(xml);
                        }
                    }
                    else
                    {
                        // CSV
                        using (var stream = new FileStream(filename, FileMode.Create, FileAccess.Write))
                        {
                            var cs = new CsvSerializer<ResultsViewModel>();
                            cs.Serialize(stream, results);
                        }
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
            _ignoredAreas = new List<VFRect>();

            LoadSettings();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            SaveSettings();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveSettings();
        }

        private void slDifference_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lbDifference != null)
            {
                lbDifference.Text = ((int)e.NewValue).ToString();
            }
        }

        private void btAddBroadcastFile_Click(Object sender, RoutedEventArgs e)
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
                    lbBroadcastFolders.Items.Add(name);
                }
                
                Settings.LastPath = Path.GetFullPath(dlg.FileNames[0]);
            }
        }

        private void btAddAdFile_Click(Object sender, RoutedEventArgs e)
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
    }
}
