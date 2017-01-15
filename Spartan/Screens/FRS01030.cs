using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField ExtractFilename = new WinFormsField("EXTRACT-FILENAME", "ExtractFilename");
        public static WinFormsField RangeUnitsTO1 = new WinFormsField("RANGE-UNITS-TO-1", "RangeUnitsTO1");
        public static WinFormsField RangeUnitsTO2 = new WinFormsField("RANGE-UNITS-TO-2", "RangeUnitsTO2");
        public static WinFormsField RangeUnitsTO3 = new WinFormsField("RANGE-UNITS-TO-3", "RangeUnitsTO3");
        public static WinFormsField RangeUnitsTO4 = new WinFormsField("RANGE-UNITS-TO-4", "RangeUnitsTO4");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
