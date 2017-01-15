using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13006", "FormName");
		//Fields


        public static WinFormsField MenuItemTtr = new WinFormsField("MENU-ITEM-TTR", "TTR.  Trade Order Transaction Report", "TradeOrderTransactionReport");
        public static WinFormsField MenuItemCor = new WinFormsField("MENU-ITEM-COR", "COR.  Company Trade Order Report", "CompanyTradeOrderReport");
        public static WinFormsField MenuItemTch = new WinFormsField("MENU-ITEM-TCH", "TCH.  Trade Control Housekeeping Report", "TradeControlHousekeepingReport");
        public static WinFormsField MenuItemTcc = new WinFormsField("MENU-ITEM-TCC", "TCC.  Company Trade Control Housekeeping Report", "CompanyTradeControlHousekeepingReport");
        public static WinFormsField MenuItemCch = new WinFormsField("MENU-ITEM-CCH", "CCH.  Commission Code Housekeeping Report", "CommissionCodeHousekeepingReport");
        public static WinFormsField MenuItemCcc = new WinFormsField("MENU-ITEM-CCC", "CCC.  Company Commission Code Housekeeping Report", "CompanyCommissionCodeHousekeepingReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
