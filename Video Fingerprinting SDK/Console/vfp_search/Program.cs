using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vfp_search
{
    using System.IO;

    using VisioForge.Types;
    using VisioForge.VideoFingerPrinting;

    class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineOptions();
            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // Display the default usage information
                //Console.WriteLine(options.GetUsage());
                return;
            }

            if (!File.Exists(options.FragmentFile))
            {
                Console.WriteLine("Fragment file not found: " + options.FragmentFile + ".");
                return;
            }

            if (!File.Exists(options.MainFile))
            {
                Console.WriteLine("Main file not found: " + options.MainFile + ".");
                return;
            }

            VFPAnalyzer.SetLicenseKey(options.LicenseKey);

            Console.WriteLine("Starting analyze.");

            var time = DateTime.Now;

            var fragment = VFPFingerPrint.Load(options.FragmentFile);
            var main = VFPFingerPrint.Load(options.MainFile);

            double difference;
            var res = VFPSearch.Search(fragment, 0, main, 0, out difference, options.MaxDifference);

            var elapsed = DateTime.Now - time;
            Console.WriteLine("Analyze finished. Elapsed time: " + elapsed.ToString("g"));

            if (res > 0)
            {
                TimeSpan ts = new TimeSpan(res * TimeSpan.TicksPerSecond);
                Console.WriteLine($"Detected fragment file at {ts:g}, difference level is {difference}");
            }
            else
            {
                Console.WriteLine("Fragment file not found.");
            }
        }
    }
}
