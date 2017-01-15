using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS03003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS03003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SortPC = new WinFormsField("SORT-PC", "SortPC");
        public static WinFormsField ReportAddress = new WinFormsField("REPORT-ADDRESS", "ReportAddress");
        public static WinFormsField NonCurrent = new WinFormsField("NON-CURRENT", "NonCurrent");
        public static WinFormsField PrintNumber = new WinFormsField("PRINT-NUMBER", "PrintNumber");
        public static WinFormsField CommaDelimit = new WinFormsField("COMMA-DELIMIT", "CommaDelimit");
    }
}
