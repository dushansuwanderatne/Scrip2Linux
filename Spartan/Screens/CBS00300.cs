using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00300", "FormName");
		//Fields


        public static WinFormsField MenuItemMbt = new WinFormsField("MENU-ITEM-MBT", "MBT.  Maintain BUY Trades", "MaintainBUYTrades");
        public static WinFormsField MenuItemMst = new WinFormsField("MENU-ITEM-MST", "MST.  Maintain SELL Trades", "MaintainSELLTrades");
        public static WinFormsField MenuItemTrp = new WinFormsField("MENU-ITEM-TRP", "TRP.  Trade Phase Setting", "TradePhaseSetting");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
