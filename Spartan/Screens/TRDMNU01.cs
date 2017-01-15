using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDMNU01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDMNU01", "FormName");
		//Fields
        public static WinFormsField MenuItemSal = new WinFormsField("MENU-ITEM-SAL", "SAL.  Sales", "Sales");
        public static WinFormsField MenuItemPur = new WinFormsField("MENU-ITEM-PUR", "PUR.  Purchases", "Purchases");
        public static WinFormsField MenuItemTrf = new WinFormsField("MENU-ITEM-TRF", "TRF.  Transfers", "Transfers");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Trading System", "ExitTradingSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
