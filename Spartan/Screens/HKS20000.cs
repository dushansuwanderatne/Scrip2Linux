using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS20000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS20000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField FromRun = new WinFormsField("FROM-RUN", "FromRun");
        public static WinFormsField TORun = new WinFormsField("TO-RUN", "TORun");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField PrintOption = new WinFormsField("PRINT-OPTION", "PrintOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
