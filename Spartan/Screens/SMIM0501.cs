using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SMIM0501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SMIM0501", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymasterCode = new WinFormsField("PAYMASTER-CODE", "PaymasterCode");
        public static WinFormsField Header = new WinFormsField("HEADER", "Header");
        public static WinFormsField MimcoyCode = new WinFormsField("MIMCOY-CODE", "MimcoyCode");
        public static WinFormsField MimcoyName = new WinFormsField("MIMCOY-NAME", "MimcoyName");
        public static WinFormsField OutputTapeGroup = new WinFormsField("OUTPUT-TAPE-GROUP", "OutputTapeGroup");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Paymaster = new WinFormsField("PAYMASTER", "Paymaster");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
