using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HCC00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HCC00103", "FormName");
		//Fields


        public static WinFormsField MenuItemCat = new WinFormsField("MENU-ITEM-CAT", "CAT. Category Codes", "CategoryCodes");
        public static WinFormsField MenuItemApp = new WinFormsField("MENU-ITEM-APP", "APP. Apply Pending Plan Intentions", "ApplyPendingPlanIntentions");
        public static WinFormsField MenuItemPln = new WinFormsField("MENU-ITEM-PLN", "PLN. Plan Control Parameters", "PlanControlParameters");
        public static WinFormsField MenuItemPE = new WinFormsField("MENU-ITEM-PE", "PE. Plan Exceptions/Withdrawals", "PlanExceptions/Withdrawals");
        public static WinFormsField MenuItemRpw = new WinFormsField("MENU-ITEM-RPW", "RPW. Reissues from Plan Withdrawals", "ReissuesfromPlanWithdrawals");
        public static WinFormsField MenuItemDiv = new WinFormsField("MENU-ITEM-DIV", "DIV. Dividend Source Codes", "DividendSourceCodes");
        public static WinFormsField MenuItemWcr = new WinFormsField("MENU-ITEM-WCR", "WCR. Cheque Reconciliation for RPW", "ChequeReconciliationforRPW");
        public static WinFormsField MenuItemCB = new WinFormsField("MENU-ITEM-CB", "CB. Reduce Plan Cash Residual Balance", "ReducePlanCashResidualBalance");
        public static WinFormsField MenuItemDcb = new WinFormsField("MENU-ITEM-DCB", "DCB. Direct Credit/Bulk Pay Codes", "DirectCredit/BulkPayCodes");
        public static WinFormsField MenuItemPpd = new WinFormsField("MENU-ITEM-PPD", "PPD. Print Plan Details", "PrintPlanDetails");
        public static WinFormsField MenuItemMis = new WinFormsField("MENU-ITEM-MIS", "MIS. Managed Investment Scheme (Menu)", "ManagedInvestmentScheme(Menu)");
        public static WinFormsField MenuItemPir = new WinFormsField("MENU-ITEM-PIR", "PIR. Payee Instruction Removal", "PayeeInstructionRemoval");
        public static WinFormsField MenuItemAds = new WinFormsField("MENU-ITEM-ADS", "ADS. Alter Dividend Source", "AlterDividendSource");
        public static WinFormsField MenuItemNir = new WinFormsField("MENU-ITEM-NIR", "NIR. Noting Instruction Removal", "NotingInstructionRemoval");
        public static WinFormsField MenuItemChe = new WinFormsField("MENU-ITEM-CHE", "CHE. Charity Class Parameters", "CharityClassParameters");
        public static WinFormsField MenuItemApc = new WinFormsField("MENU-ITEM-APC", "APC. Apply Pending Charity elections", "ApplyPendingCharityelections");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
