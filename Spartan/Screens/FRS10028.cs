using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10028

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10028", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField DescendingUnitsType = new WinFormsField("DESCENDING-UNITS-TYPE", "DescendingUnitsType");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField ReturnMailATEnd = new WinFormsField("RETURN-MAIL-AT-END", "ReturnMailATEnd");
        public static WinFormsField FurtherSequencing = new WinFormsField("FURTHER-SEQUENCING", "FurtherSequencing");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
