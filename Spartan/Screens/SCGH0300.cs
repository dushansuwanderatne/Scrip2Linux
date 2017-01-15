using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCGH0300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCGH0300", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField IssueType = new WinFormsField("ISSUE-TYPE", "IssueType");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField RunNumFrom = new WinFormsField("RUN-NUM-FROM", "RunNumFrom");
        public static WinFormsField RunNumTO = new WinFormsField("RUN-NUM-TO", "RunNumTO");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField MinLevel = new WinFormsField("MIN-LEVEL", "MinLevel");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField XtractFileInd = new WinFormsField("XTRACT-FILE-IND", "XtractFileInd");
        public static WinFormsField XtractFilename = new WinFormsField("XTRACT-FILENAME", "XtractFilename");
        public static WinFormsField ExcludeReturnMail = new WinFormsField("EXCLUDE-RETURN-MAIL", "ExcludeReturnMail");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}