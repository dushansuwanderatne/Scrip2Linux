using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01055

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01055", "FormName");
		//Fields
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField ReportDateFrom = new WinFormsField("REPORT-DATE-FROM", "ReportDateFrom");
        public static WinFormsField ReportDateTO = new WinFormsField("REPORT-DATE-TO", "ReportDateTO");
        public static WinFormsField ModelPrice = new WinFormsField("MODEL-PRICE", "ModelPrice");
        public static WinFormsField TotalsOnly = new WinFormsField("TOTALS-ONLY", "TotalsOnly");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
