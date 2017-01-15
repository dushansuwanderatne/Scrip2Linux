using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01010", "FormName");
		//Fields


        public static WinFormsField DeletePreOption = new WinFormsField("DELETE-PRE-OPTION", "DeletePreOption");
        public static WinFormsField DelPreAccount = new WinFormsField("DEL-PRE-ACCOUNT", "DelPreAccount");
        public static WinFormsField DelPreRetainDelete = new WinFormsField("DEL-PRE-RETAIN-DELETE", "DelPreRetainDelete");
        public static WinFormsField PreChqAccount = new WinFormsField("PRE-CHQ-ACCOUNT", "PreChqAccount");
        public static WinFormsField PresentedDate = new WinFormsField("PRESENTED-DATE", "PresentedDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
