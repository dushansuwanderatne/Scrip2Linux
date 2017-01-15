using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP6003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP6003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportDesc = new WinFormsField("REPORT-DESC", "ReportDesc");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField NoticeDate = new WinFormsField("NOTICE-DATE", "NoticeDate");
        public static WinFormsField NoticeComment = new WinFormsField("NOTICE-COMMENT", "NoticeComment");
        public static WinFormsField DueDate = new WinFormsField("DUE-DATE", "DueDate");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField RunRangeFrom = new WinFormsField("RUN-RANGE-FROM", "RunRangeFrom");
        public static WinFormsField RunRangeTO = new WinFormsField("RUN-RANGE-TO", "RunRangeTO");
        public static WinFormsField DateRangeFrom = new WinFormsField("DATE-RANGE-FROM", "DateRangeFrom");
        public static WinFormsField DateRangeTO = new WinFormsField("DATE-RANGE-TO", "DateRangeTO");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField ModelPartFlag = new WinFormsField("MODEL-PART-FLAG", "ModelPartFlag");
        public static WinFormsField PerformanceFlag = new WinFormsField("PERFORMANCE-FLAG", "PerformanceFlag");
        public static WinFormsField MinOverdueAmt = new WinFormsField("MIN-OVERDUE-AMT", "MinOverdueAmt");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
