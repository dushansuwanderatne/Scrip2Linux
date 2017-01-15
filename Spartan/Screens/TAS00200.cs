using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00200", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ReportSuffix = new WinFormsField("REPORT-SUFFIX", "ReportSuffix");
        public static WinFormsField FProject = new WinFormsField("F-PROJECT", "FProject");
        public static WinFormsField TProject = new WinFormsField("T-PROJECT", "TProject");
        public static WinFormsField FDate = new WinFormsField("F-DATE", "FDate");
        public static WinFormsField TDate = new WinFormsField("T-DATE", "TDate");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField TaskFlag = new WinFormsField("TASK-FLAG", "TaskFlag");
        public static WinFormsField Task = new WinFormsField("TASK", "Task");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField DailyBreakup = new WinFormsField("DAILY-BREAKUP", "DailyBreakup");
        public static WinFormsField CostFlag = new WinFormsField("COST-FLAG", "CostFlag");
        public static WinFormsField TotalsAT = new WinFormsField("TOTALS-AT", "TotalsAT");
    }
}
