using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS08003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS08003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ExtractFilename = new WinFormsField("EXTRACT-FILENAME", "ExtractFilename");
        public static WinFormsField RangeFrom1to5 = new WinFormsField("RANGE-FROM-1TO5", "RangeFrom1to5");
        public static WinFormsField RangeFrom6to10 = new WinFormsField("RANGE-FROM-6TO10", "RangeFrom6to10");
        public static WinFormsField RangeFrom11to15 = new WinFormsField("RANGE-FROM-11TO15", "RangeFrom11to15");
        public static WinFormsField RangeFrom16to20 = new WinFormsField("RANGE-FROM-16TO20", "RangeFrom16to20");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
