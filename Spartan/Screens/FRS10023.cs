using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10023

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10023", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PrintHin = new WinFormsField("PRINT-HIN", "PrintHin");
        public static WinFormsField PrintAsx = new WinFormsField("PRINT-ASX", "PrintAsx");
        public static WinFormsField PrintHolding = new WinFormsField("PRINT-HOLDING", "PrintHolding");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
