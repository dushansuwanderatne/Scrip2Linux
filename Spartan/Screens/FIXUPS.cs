using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPS", "FormName");
		//Fields
        public static WinFormsField MenuItemCalctl = new WinFormsField("MENU-ITEM-CALCTL", "CALCTL. CALL control file", "CALLcontrolfile");
        public static WinFormsField MenuItemHldpid = new WinFormsField("MENU-ITEM-HLDPID", "HLDPID. Payee Instruction", "PayeeInstruction");
        public static WinFormsField MenuItemClscde = new WinFormsField("MENU-ITEM-CLSCDE", "CLSCDE. Class code file", "Classcodefile");
        public static WinFormsField MenuItemHldpln = new WinFormsField("MENU-ITEM-HLDPLN", "HLDPLN. Holder plan details file", "Holderplandetailsfile");
        public static WinFormsField MenuItemClstot = new WinFormsField("MENU-ITEM-CLSTOT", "CLSTOT. Class totals", "Classtotals");
        public static WinFormsField MenuItemHldtrn = new WinFormsField("MENU-ITEM-HLDTRN", "HLDTRN. Static Detail Change", "StaticDetailChange");
        public static WinFormsField MenuItemCntrol = new WinFormsField("MENU-ITEM-CNTROL", "CNTROL. Company control file", "Companycontrolfile");
        public static WinFormsField MenuItemMrking = new WinFormsField("MENU-ITEM-MRKING", "MRKING. Markings", "Markings");
        public static WinFormsField MenuItemCoycde = new WinFormsField("MENU-ITEM-COYCDE", "COYCDE. Company Code File", "CompanyCodeFile");
        public static WinFormsField MenuItemPaydet = new WinFormsField("MENU-ITEM-PAYDET", "PAYDET. Payment details", "Paymentdetails");
        public static WinFormsField MenuItemCrtbal = new WinFormsField("MENU-ITEM-CRTBAL", "CRTBAL. Certificate balance file", "Certificatebalancefile");
        public static WinFormsField MenuItemPaydsc = new WinFormsField("MENU-ITEM-PAYDSC", "PAYDSC. Payment Descriptions", "PaymentDescriptions");
        public static WinFormsField MenuItemCrttrn = new WinFormsField("MENU-ITEM-CRTTRN", "CRTTRN. Certificate transaction file", "Certificatetransactionfile");
        public static WinFormsField MenuItemPaytot = new WinFormsField("MENU-ITEM-PAYTOT", "PAYTOT. Payment Totals File", "PaymentTotalsFile");
        public static WinFormsField MenuItemDcbcdea = new WinFormsField("MENU-ITEM-DCBCDEA", "DCBCDEA. Direct Credit/Bulk Pay (Aus)", "DirectCredit/BulkPay(Aus)");
        public static WinFormsField MenuItemRoldsc = new WinFormsField("MENU-ITEM-ROLDSC", "ROLDSC. Role Description File", "RoleDescriptionFile");
        public static WinFormsField MenuItemDcbcden = new WinFormsField("MENU-ITEM-DCBCDEN", "DCBCDEN. Direct Credit/Bulk Pay (NZ) ", "DirectCredit/BulkPay(NZ)");
        public static WinFormsField MenuItemRolrul = new WinFormsField("MENU-ITEM-ROLRUL", "ROLRUL. Role Rule (Class) file", "RoleRule(Class)file");
        public static WinFormsField MenuItemDcbcde = new WinFormsField("MENU-ITEM-DCBCDE", "DCBCDEU. Direct Credit/Bulk Pay (UK)", "DirectCredit/BulkPay(UK)");
        public static WinFormsField MenuItemRunhis = new WinFormsField("MENU-ITEM-RUNHIS", "RUNHIS. Update reporting run history", "Updatereportingrunhistory");
        public static WinFormsField MenuItemDivamt = new WinFormsField("MENU-ITEM-DIVAMT", "DIVAMT. Dividend History Amount File", "DividendHistoryAmountFile");
        public static WinFormsField MenuItemSestot = new WinFormsField("MENU-ITEM-SESTOT", "SESTOT. Session Totals", "SessionTotals");
        public static WinFormsField MenuItemDivhis0 = new WinFormsField("MENU-ITEM-DIVHIS0", "DIVHIS0. Dividend History Header", "DividendHistoryHeader");
        public static WinFormsField MenuItemSubcoy = new WinFormsField("MENU-ITEM-SUBCOY", "SUBCOY. Sub Company code file", "SubCompanycodefile");
        public static WinFormsField MenuItemDivhis1 = new WinFormsField("MENU-ITEM-DIVHIS1", "DIVHIS1. Dividend History Detail", "DividendHistoryDetail");
        public static WinFormsField MenuItemTfnnot = new WinFormsField("MENU-ITEM-TFNNOT", "TFNNOT. Tax file notices", "Taxfilenotices");
        public static WinFormsField MenuItemFlgcde = new WinFormsField("MENU-ITEM-FLGCDE", "FLGCDE. Flag code validation file", "Flagcodevalidationfile");
        public static WinFormsField MenuItemStmexc = new WinFormsField("MENU-ITEM-STMEXC", "STMEXC. Statement Exclusion File ", "StatementExclusionFile");
        public static WinFormsField MenuItemFstctl = new WinFormsField("MENU-ITEM-FSTCTL", "FSTCTL. Fast control file", "Fastcontrolfile");
        public static WinFormsField MenuItemStmhis = new WinFormsField("MENU-ITEM-STMHIS", "STMHIS. Statement History File", "StatementHistoryFile");
        public static WinFormsField MenuItemFsthis = new WinFormsField("MENU-ITEM-FSTHIS", "FSTHIS. Fast History", "FastHistory");
        public static WinFormsField MenuItemHldadd = new WinFormsField("MENU-ITEM-HLDADD", "HLDADD. Holder address file", "Holderaddressfile");
        public static WinFormsField MenuItemTkoctl = new WinFormsField("MENU-ITEM-TKOCTL", "TKOCTL0. Takeover Control (Header)", "TakeoverControl(Header)");
        public static WinFormsField MenuItemHldbal = new WinFormsField("MENU-ITEM-HLDBAL", "HLDBAL. Holding of Trading Classes", "HoldingofTradingClasses");
        public static WinFormsField MenuItemTkoctl1 = new WinFormsField("MENU-ITEM-TKOCTL1", "TKOCTL1. Takeover Control (Class)", "TakeoverControl(Class)");
        public static WinFormsField MenuItemHlddcd = new WinFormsField("MENU-ITEM-HLDDCD", "HLDDCD. Direct Credit/Bulk Pay", "DirectCredit/BulkPay");
        public static WinFormsField MenuItemTrfanl = new WinFormsField("MENU-ITEM-TRFANL", "TRFANL. NZL Trans Anal File", "NZLTransAnalFile");
        public static WinFormsField MenuItemHldext = new WinFormsField("MENU-ITEM-HLDEXT", "HLDEXT. Holder Extra Information", "HolderExtraInformation");
        public static WinFormsField MenuItemHldnot = new WinFormsField("MENU-ITEM-HLDNOT", "HLDNOT. Holder Notices", "HolderNotices");
        public static WinFormsField MenuItemAccctl = new WinFormsField("MENU-ITEM-ACCCTL", "ACCCTL. Acceptance Status Control File", "AcceptanceStatusControlFile");
        public static WinFormsField MenuItemAcchis = new WinFormsField("MENU-ITEM-ACCHIS", "ACCHIS. Acceptance Status History File", "AcceptanceStatusHistoryFile");
        public static WinFormsField MenuItemAccpnd = new WinFormsField("MENU-ITEM-ACCPND", "ACCPND. Acceptance Status Pending File", "AcceptanceStatusPendingFile");
        public static WinFormsField MenuItemNext = new WinFormsField("MENU-ITEM-NEXT", "NEXT. Next Screen of Files ", "NextScreenofFiles");
        public static WinFormsField MenuItemHelp = new WinFormsField("MENU-ITEM-HELP", "HELP. Read me before you change a primary key ", "Readmebeforeyouchangeaprimarykey");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
        public static WinFormsField MenuItemCondtl = new WinFormsField("MENU-ITEM-CONDTL", "CONDTL. External Contact Details", "ExternalContactDetails");
    }
}
