using System.IO;
using System.Text.RegularExpressions;

namespace SCRIPAU.Automation.ReportParser
{
    internal class MaskRule
    {
        public Regex Pattern;
        public string ReplaceText;

        public MaskRule(string pattern, string replaceText)
        {
            Pattern = new Regex(pattern);
            ReplaceText = replaceText;
        }
    }

    internal class ReportOutputParseUtility
    {
        private static void ParseFile(string inFilename, bool fortran = false)
        {
            string outFilename = inFilename + ".mask";

            MaskRule[] rules;

            if (Path.GetExtension(inFilename).ToLower() == ".xml")
            {
                // Rules for XML files
                rules = new MaskRule[]
                {
                    new MaskRule(@"(?<=\<r:SystemType\>)(?:Development|Production)", "{systemtype}"),
                    //new MaskRule(@"(?<=\(.{6}:)\d\d\.\d\d:\d{6}\)", "_{timestamp})"),
                };
            }
            else
            {
                // Rules for non XML files
                rules = new MaskRule[]
                {
                    new MaskRule(@"\b[A-Za-z_]+\.(sh|COM)\b", "{scriptname}"),
                    new MaskRule(@"(?<=Report name.*)_\d{8} ", "_{datestamp}"),
                    new MaskRule(@"(?<=\(.{6}:)\d\d\.\d\d:\d{6}\)", "_{timestamp})"),
                };
            }

            string lineFeed = "";
            using (StreamReader inStm = File.OpenText(inFilename))
            using (StreamWriter outStm = File.CreateText(outFilename))
            {
                string line;
                while ((line = inStm.ReadLine()) != null)
                {
                    if (fortran && line.Length > 0)
                    {
                        char controlChar = line[0];
                        line = line.Substring(1);
                        switch (controlChar)
                        {
                            case '0':
                                lineFeed = "\n\n";
                                break;

                            case '1':
                                lineFeed = "\x0c";
                                break;
                        }
                    }

                    foreach (MaskRule rule in rules)
                    {
                        line = rule.Pattern.Replace(line, rule.ReplaceText);
                    }

                    outStm.Write(lineFeed + line);
                    lineFeed = "\n";
                }
                outStm.Write(lineFeed);
            }
        }
    }
}