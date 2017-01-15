using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS12

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS12", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField CurrentNode = new WinFormsField("CURRENT-NODE", "CurrentNode");
        public static WinFormsField PrintFN = new WinFormsField("PRINT-FN", "PrintFN");
        public static WinFormsField CurrentPrinter = new WinFormsField("CURRENT-PRINTER", "CurrentPrinter");
        public static WinFormsField TONode = new WinFormsField("TO-NODE", "TONode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
