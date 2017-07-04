using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vfp_compare
{
    using CommandLine;
    using CommandLine.Text;

    public class CommandLineOptions
    {
        [Option('f', "f1", Required = true, HelpText = "First fingerprint file.")]
        public string Input1 { get; set; }

        [Option('s', "f2", Required = true, HelpText = "Second fingerprint file.")]
        public string Input2 { get; set; }

        [Option('d', "md", Required = false, HelpText = "Maximal difference between fingerprints.", DefaultValue = 500)]
        public int MaxDifference { get; set; }

        [Option('l', "license", Required = false, HelpText = "License key.", DefaultValue = "TRIAL")]
        public string LicenseKey { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText
            {
                Heading = new HeadingInfo("VisioForge Video Fingerprinting SDK signature compare tool (can compare one fingerprint with another).", "10.0"),
                Copyright = new CopyrightInfo("VisioForge", 2017),
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };

            help.AddPreOptionsLine("Usage: app -f1 \"first input file\" -f2 \"second input file\" options");
            help.AddOptions(this);

            return help;
        }
    }
}
