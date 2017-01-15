using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP02000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP02000", "FormName");
		//Fields


        public static WinFormsField MenuItemAbtt = new WinFormsField("MENU-ITEM-ABTT", "ABTT.  SPP ABT Trace Details", "SPPABTTraceDetails");
        public static WinFormsField MenuItemSppp = new WinFormsField("MENU-ITEM-SPPP", "SPPP.  SPP Parameters", "SPPParameters");
        public static WinFormsField MenuItemPchg = new WinFormsField("MENU-ITEM-PCHG", "PCHG.  Plan Parameters", "PlanParameters");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SetupOption = new WinFormsField("SETUP-OPTION", "SetupOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
