using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01040", "FormName");
		//Fields


        public static WinFormsField RecalcDate = new WinFormsField("RECALC-DATE", "RecalcDate");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ListingSeq = new WinFormsField("LISTING-SEQ", "ListingSeq");
        public static WinFormsField HolderIDPrint = new WinFormsField("HOLDER-ID-PRINT", "HolderIDPrint");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
