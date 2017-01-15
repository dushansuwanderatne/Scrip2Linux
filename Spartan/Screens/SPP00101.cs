using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP00101", "FormName");
		//Fields


        public static WinFormsField MenuItemSppit = new WinFormsField("MENU-ITEM-SPPIT", "SPPIT.  SPP Dividend Intention", "SPPDividendIntention");
        public static WinFormsField MenuItemSpapr = new WinFormsField("MENU-ITEM-SPAPR", "SPAPR.  Request Application Form", "RequestApplicationForm");
        public static WinFormsField MenuItemSpabt = new WinFormsField("MENU-ITEM-SPABT", "SPABT.  ABT Instructions", "ABTInstructions");
        public static WinFormsField MenuItemSpdep = new WinFormsField("MENU-ITEM-SPDEP", "SPDEP.  Cash Deposits", "CashDeposits");
        public static WinFormsField MenuItemSpwid = new WinFormsField("MENU-ITEM-SPWID", "SPWID.  Cash Withdrawals", "CashWithdrawals");
        public static WinFormsField MenuItemSpadj = new WinFormsField("MENU-ITEM-SPADJ", "SPADJ.  Cash Adjustments", "CashAdjustments");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
