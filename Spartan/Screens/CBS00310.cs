using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00310

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00310", "FormName");
		//Fields


        public static WinFormsField MenuItemAca = new WinFormsField("MENU-ITEM-ACA", "ACA.  Set Aus C/P Agreement", "SetAusC/PAgreement");
        public static WinFormsField MenuItemRts = new WinFormsField("MENU-ITEM-RTS", "RTS.  Reset Trade Settled", "ResetTradeSettled");
        public static WinFormsField MenuItemTcd = new WinFormsField("MENU-ITEM-TCD", "TCD.  Set Transfer Cash Done", "SetTransferCashDone");
        public static WinFormsField MenuItemRms = new WinFormsField("MENU-ITEM-RMS", "RMS.  Reset Message Generated", "ResetMessageGenerated");
        public static WinFormsField MenuItemMgd = new WinFormsField("MENU-ITEM-MGD", "MGD.  Set Message Generated", "SetMessageGenerated");
        public static WinFormsField MenuItemRtc = new WinFormsField("MENU-ITEM-RTC", "RTC.  Reset Transfer Cash", "ResetTransferCash");
        public static WinFormsField MenuItemTsd = new WinFormsField("MENU-ITEM-TSD", "TSD.  Set Trade Settled", "SetTradeSettled");
        public static WinFormsField MenuItemRca = new WinFormsField("MENU-ITEM-RCA", "RCA.  Reset Aus C/P Agreement", "ResetAusC/PAgreement");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
