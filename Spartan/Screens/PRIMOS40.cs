using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS40

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS40", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TelexFrom = new WinFormsField("TELEX-FROM", "TelexFrom");
        public static WinFormsField TelexTO = new WinFormsField("TELEX-TO", "TelexTO");
        public static WinFormsField TelexUfd = new WinFormsField("TELEX-UFD", "TelexUfd");
        public static WinFormsField TelexCompany = new WinFormsField("TELEX-COMPANY", "TelexCompany");
        public static WinFormsField TelexMess = new WinFormsField("TELEX-MESS", "TelexMess");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
