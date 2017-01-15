using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CPY01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CPY01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Account = new WinFormsField("ACCOUNT", "Account");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Build = new WinFormsField("BUILD", "Build");
        public static WinFormsField Deprec = new WinFormsField("DEPREC", "Deprec");
        public static WinFormsField Rate = new WinFormsField("RATE", "Rate");
        public static WinFormsField ReportHead = new WinFormsField("REPORT-HEAD", "ReportHead");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
