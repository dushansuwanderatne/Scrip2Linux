using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP00", "FormName");
		//Fields


        public static WinFormsField MenuItemTtr = new WinFormsField("MENU-ITEM-TTR", "TTR.  Trade Order Transaction Report", "TradeOrderTransactionReport");
        public static WinFormsField MenuItemCor = new WinFormsField("MENU-ITEM-COR", "COR.  Company Trade Order Report", "CompanyTradeOrderReport");
        public static WinFormsField MenuItemTch = new WinFormsField("MENU-ITEM-TCH", "TCH.  Trade Control Housekeeping Report", "TradeControlHousekeepingReport");
        public static WinFormsField MenuItemTcc = new WinFormsField("MENU-ITEM-TCC", "TCC.  Company Trade Control Housekeeping Report", "CompanyTradeControlHousekeepingReport");
        public static WinFormsField MenuItemCch = new WinFormsField("MENU-ITEM-CCH", "CCH.  Commission Code Housekeeping Report", "CommissionCodeHousekeepingReport");
        public static WinFormsField MenuItemCcc = new WinFormsField("MENU-ITEM-CCC", "CCC.  Company Commission Code Housekeeping Report", "CompanyCommissionCodeHousekeepingReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit Trading System Reporting", "ExitTradingSystemReporting");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
