using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TELEX01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TELEX01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TelexFrom = new WinFormsField("TELEX-FROM", "TelexFrom");
        public static WinFormsField TelexTO = new WinFormsField("TELEX-TO", "TelexTO");
        public static WinFormsField Subject = new WinFormsField("SUBJECT", "Subject");
        public static WinFormsField TelexState = new WinFormsField("TELEX-STATE", "TelexState");
    }
}
