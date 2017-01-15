using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class THC01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("THC01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransferClsType = new WinFormsField("TRANSFER-CLS-TYPE", "TransferClsType");
        public static WinFormsField ScreenClass1 = new WinFormsField("SCREEN-CLASS-1", "ScreenClass1");
        public static WinFormsField ScreenClass2 = new WinFormsField("SCREEN-CLASS-2", "ScreenClass2");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
