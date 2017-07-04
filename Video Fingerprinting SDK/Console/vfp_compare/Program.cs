using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vfp_compare
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

            if (!File.Exists(options.Input1))
            {
                Console.WriteLine("Input file 1 not found: " + options.Input1 + ".");
                return;
            }

            if (!File.Exists(options.Input2))
            {
                Console.WriteLine("Input file 2 not found: " + options.Input2 + ".");
                return;
            }

            VFPAnalyzer.SetLicenseKey(options.LicenseKey);

            Console.WriteLine("Starting analyze.");

            var time = DateTime.Now;

            var fragment = VFPFingerPrint.Load(options.Input1);
            var main = VFPFingerPrint.Load(options.Input2);

            double difference;
            var res = VFPCompare.Compare(fragment, main, options.MaxDifference);

            var elapsed = DateTime.Now - time;
            Console.WriteLine("Analyze finished. Elapsed time: " + elapsed.ToString("g"));

            if (res < 300)
            {
                Console.WriteLine("Input files are similar.");
            }
            else
            {
                Console.WriteLine("Input files are different.");
            }
        }
    }
}
