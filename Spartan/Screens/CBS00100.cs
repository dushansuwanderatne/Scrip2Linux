using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00100", "FormName");
		//Fields


        public static WinFormsField MenuItemHol = new WinFormsField("MENU-ITEM-HOL", "HOL.  Holding Enquiry", "HoldingEnquiry");
        public static WinFormsField MenuItemTra = new WinFormsField("MENU-ITEM-TRA", "TRA.  Trades Enquiry", "TradesEnquiry");
        public static WinFormsField MenuItemTrf = new WinFormsField("MENU-ITEM-TRF", "TRF.  Transfers Enquiry", "TransfersEnquiry");
        public static WinFormsField MenuItemNso = new WinFormsField("MENU-ITEM-NSO", "NSO.  Net Settlement Obligations Enquiry", "NetSettlementObligationsEnquiry");
        public static WinFormsField MenuItemSal = new WinFormsField("MENU-ITEM-SAL", "SAL.  Set Alias", "SetAlias");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
