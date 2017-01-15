using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HCC00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HCC00101", "FormName");
		//Fields
        public static WinFormsField MenuItemCtl = new WinFormsField("MENU-ITEM-CTL", "CTL. Control Code/Options", "ControlCode/Options");
        public static WinFormsField MenuItemDC = new WinFormsField("MENU-ITEM-DC", "DC. Dividend Intention Control", "DividendIntentionControl");
        public static WinFormsField MenuItemUlt = new WinFormsField("MENU-ITEM-ULT", "ULT. Unlisted Trust Maintenance", "UnlistedTrustMaintenance");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
