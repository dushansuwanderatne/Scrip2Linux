using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP00102", "FormName");
		//Fields


        public static WinFormsField MenuItemStp = new WinFormsField("MENU-ITEM-STP", "STP.  Change SPP Parameters", "ChangeSPPParameters");
        public static WinFormsField MenuItemDmp = new WinFormsField("MENU-ITEM-DMP", "DMP.  Setup an EOY SPP dump", "SetupanEOYSPPdump");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
