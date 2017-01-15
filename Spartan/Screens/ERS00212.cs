using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00212

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00212", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDesc = new WinFormsField("INV-DESC", "InvDesc");
        public static WinFormsField LastStatRun = new WinFormsField("LAST-STAT-RUN", "LastStatRun");
        public static WinFormsField StatementDate = new WinFormsField("STATEMENT-DATE", "StatementDate");
        public static WinFormsField MatchingDate = new WinFormsField("MATCHING-DATE", "MatchingDate");
        public static WinFormsField PeriodTO = new WinFormsField("PERIOD-TO", "PeriodTO");
        public static WinFormsField StatementPeriodFrom = new WinFormsField("STATEMENT-PERIOD-FROM", "StatementPeriodFrom");
        public static WinFormsField StatementPeriodTO = new WinFormsField("STATEMENT-PERIOD-TO", "StatementPeriodTO");
        public static WinFormsField StatementDateFrom = new WinFormsField("STATEMENT-DATE-FROM", "StatementDateFrom");
        public static WinFormsField StatementDateTO = new WinFormsField("STATEMENT-DATE-TO", "StatementDateTO");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
