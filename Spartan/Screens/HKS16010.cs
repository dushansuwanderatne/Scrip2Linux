using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS16010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS16010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField DivSourceFrom = new WinFormsField("DIV-SOURCE-FROM", "DivSourceFrom");
        public static WinFormsField DivSourceTO = new WinFormsField("DIV-SOURCE-TO", "DivSourceTO");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
