using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00210

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00210", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField PeriodFrom = new WinFormsField("PERIOD-FROM", "PeriodFrom");
        public static WinFormsField PeriodTO = new WinFormsField("PERIOD-TO", "PeriodTO");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField StatementSequence = new WinFormsField("STATEMENT-SEQUENCE", "StatementSequence");
        public static WinFormsField WdlReportInd = new WinFormsField("WDL-REPORT-IND", "WdlReportInd");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
