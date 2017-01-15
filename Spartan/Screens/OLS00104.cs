using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00104", "FormName");
		//Fields


        public static WinFormsField MenuItemDivit = new WinFormsField("MENU-ITEM-DIVIT", "DIVIT. Dividend Intentions", "DividendIntentions");
        public static WinFormsField MenuItemRibui = new WinFormsField("MENU-ITEM-RIBUI", "RIBUI. Reissue Unissued Certs", "ReissueUnissuedCerts");
        public static WinFormsField MenuItemMnydn = new WinFormsField("MENU-ITEM-MNYDN", "MNYDN. Plan Money Decrease", "PlanMoneyDecrease");
        public static WinFormsField MenuItemMnyin = new WinFormsField("MENU-ITEM-MNYIN", "MNYIN. Plan Money Increase", "PlanMoneyIncrease");
        public static WinFormsField MenuItemUnidn = new WinFormsField("MENU-ITEM-UNIDN", "UNIDN. Unissued Units Decrease", "UnissuedUnitsDecrease");
        public static WinFormsField MenuItemUniin = new WinFormsField("MENU-ITEM-UNIIN", "UNIIN. Unissued Units Increase", "UnissuedUnitsIncrease");
        public static WinFormsField MenuItemElcdn = new WinFormsField("MENU-ITEM-ELCDN", "ELCDN. Employee Loan Class Decrease", "EmployeeLoanClassDecrease");
        public static WinFormsField MenuItemElcin = new WinFormsField("MENU-ITEM-ELCIN", "ELCIN. Employee Loan Class Increase", "EmployeeLoanClassIncrease");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
