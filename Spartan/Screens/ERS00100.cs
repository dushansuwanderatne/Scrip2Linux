using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00100", "FormName");
		//Fields
        public static WinFormsField MenuItemCF = new WinFormsField("MENU-ITEM-CF", "Contribution File Report");
        public static WinFormsField MenuItemEF = new WinFormsField("MENU-ITEM-EF", "Employee Extract Report");
        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "Purchase Reconciliation Report");
        public static WinFormsField MenuItemLR = new WinFormsField("MENU-ITEM-LR", "Loan Report");
        public static WinFormsField MenuItemTM = new WinFormsField("MENU-ITEM-TM", "Transaction Movement Report");
        public static WinFormsField MenuItemLV = new WinFormsField("MENU-ITEM-LV", "Unprocessed Leaver Report");
        public static WinFormsField MenuItemGR = new WinFormsField("MENU-ITEM-GR", "Grant Report");
        public static WinFormsField MenuItemVO = new WinFormsField("MENU-ITEM-VO", "Vesting Report");
        public static WinFormsField MenuItemXR = new WinFormsField("MENU-ITEM-XR", "Exercise Report");
        public static WinFormsField MenuItemCE = new WinFormsField("MENU-ITEM-CE", "Cancellation & Expiry Report");
        public static WinFormsField MenuItemEC = new WinFormsField("MENU-ITEM-EC", "Plan Contributions, Purchases and Allocations Report");
        public static WinFormsField MenuItemEW = new WinFormsField("MENU-ITEM-EW", "Plan Withdrawals Report");
        public static WinFormsField MenuItemED = new WinFormsField("MENU-ITEM-ED", "Dividend Report");
        public static WinFormsField MenuItemEU = new WinFormsField("MENU-ITEM-EU", "Unallocated Reconciliation Report");
        public static WinFormsField MenuItemTR = new WinFormsField("MENU-ITEM-TR", "Trustee Reconciliation Report");
        public static WinFormsField MenuItemTX = new WinFormsField("MENU-ITEM-TX", "ESS Tax Reporting (Menu)");
        public static WinFormsField MenuItemWD = new WinFormsField("MENU-ITEM-WD", "Static Withholding Details Report");
        public static WinFormsField MenuItemWA = new WinFormsField("MENU-ITEM-WA", "Withholding Assessment Report");
        public static WinFormsField MenuItemVN = new WinFormsField("MENU-ITEM-VN", "Event Notification Report");
        public static WinFormsField MenuItemVR = new WinFormsField("MENU-ITEM-VR", "Event Reconciliation Report");
        public static WinFormsField MenuItemEV = new WinFormsField("MENU-ITEM-EV", "VWAP Report");
        public static WinFormsField MenuItemHK = new WinFormsField("MENU-ITEM-HK", "ESS Housekeeping Report");
        public static WinFormsField MenuItemHC = new WinFormsField("MENU-ITEM-HC", "Company Client ESS Housekeeping Report");
        public static WinFormsField MenuItemEL = new WinFormsField("MENU-ITEM-EL", "Employee Loan Plan Statement");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "Employee AESS Plan Statement");
        public static WinFormsField MenuItemEE = new WinFormsField("MENU-ITEM-EE", "Employee Option Plan Statement");
        public static WinFormsField MenuItemOT = new WinFormsField("MENU-ITEM-OT", "Pre 2010 Employee Tax Statements");

    }
}
