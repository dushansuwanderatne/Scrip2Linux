using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00500", "FormName");
		//Fields


        public static WinFormsField MenuItemHol = new WinFormsField("MENU-ITEM-HOL", "HOL.  Holding Report", "HoldingReport");
        public static WinFormsField MenuItemCtr = new WinFormsField("MENU-ITEM-CTR", "CTR.  Daily Control Report", "DailyControlReport");
        public static WinFormsField MenuItemOut = new WinFormsField("MENU-ITEM-OUT", "OUT.  Outstanding Buy Trades", "OutstandingBuyTrades");
        public static WinFormsField MenuItemMov = new WinFormsField("MENU-ITEM-MOV", "MOV.  Movements Report", "MovementsReport");
        public static WinFormsField MenuItemSet = new WinFormsField("MENU-ITEM-SET", "SET.  Settled Trades Today", "SettledTradesToday");
        public static WinFormsField MenuItemAca = new WinFormsField("MENU-ITEM-ACA", "ACA.  Sell Trades ACA Candidates Report", "SellTradesACACandidatesReport");
        public static WinFormsField MenuItemRtr = new WinFormsField("MENU-ITEM-RTR", "RTR.  Registered Transfers Report", "RegisteredTransfersReport");
        public static WinFormsField MenuItemUtr = new WinFormsField("MENU-ITEM-UTR", "UTR.  Unregistered Transfers Report", "UnregisteredTransfersReport");
        public static WinFormsField MenuItemCmr = new WinFormsField("MENU-ITEM-CMR", "CMR.  Cash Management Report", "CashManagementReport");
        public static WinFormsField MenuItemTra = new WinFormsField("MENU-ITEM-TRA", "TRA.  Cash Transaction Analysis", "CashTransactionAnalysis");
        public static WinFormsField MenuItemCor = new WinFormsField("MENU-ITEM-COR", "COR.  Corporate Actions Report", "CorporateActionsReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
