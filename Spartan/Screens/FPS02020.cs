using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS02020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS02020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportName = new WinFormsField("REPORT-NAME", "ReportName");
        public static WinFormsField Issue = new WinFormsField("ISSUE", "Issue");
        public static WinFormsField IssueReportDesc = new WinFormsField("ISSUE-REPORT-DESC", "IssueReportDesc");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField LastBookCloseRun = new WinFormsField("LAST-BOOK-CLOSE-RUN", "LastBookCloseRun");
        public static WinFormsField LastPayDate = new WinFormsField("LAST-PAY-DATE", "LastPayDate");
        public static WinFormsField NextPayDate = new WinFormsField("NEXT-PAY-DATE", "NextPayDate");
        public static WinFormsField CalcMethod = new WinFormsField("CALC-METHOD", "CalcMethod");
        public static WinFormsField TotalIssues = new WinFormsField("TOTAL-ISSUES", "TotalIssues");
        public static WinFormsField ScheduleReport = new WinFormsField("SCHEDULE-REPORT", "ScheduleReport");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
