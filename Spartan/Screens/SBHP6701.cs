using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP6701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP6701", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LastRunDate = new WinFormsField("LAST-RUN-DATE", "LastRunDate");
        public static WinFormsField LapsePriorDate = new WinFormsField("LAPSE-PRIOR-DATE", "LapsePriorDate");
        public static WinFormsField ReportDesc = new WinFormsField("REPORT-DESC", "ReportDesc");
        public static WinFormsField LapseNoticeDate = new WinFormsField("LAPSE-NOTICE-DATE", "LapseNoticeDate");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Grp = new WinFormsField("GRP", "Grp");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
