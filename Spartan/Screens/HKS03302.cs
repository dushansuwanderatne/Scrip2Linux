using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03302", "FormName");
		//Fields


        public static WinFormsField ScreenHeader = new WinFormsField("SCREEN-HEADER", "ScreenHeader");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankDesc = new WinFormsField("BANK-DESC", "BankDesc");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField BANzl1to7 = new WinFormsField("BA-NZL-1TO7", "BANzl1to7");
        public static WinFormsField BANzl8to10 = new WinFormsField("BA-NZL-8TO10", "BANzl8to10");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField BankAccountStatus = new WinFormsField("BANK-ACCOUNT-STATUS", "BankAccountStatus");
        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField ReconciledBYFlg = new WinFormsField("RECONCILED-BY-FLG", "ReconciledBYFlg");
        public static WinFormsField AccurateReconInd = new WinFormsField("ACCURATE-RECON-IND", "AccurateReconInd");
        public static WinFormsField DCInd = new WinFormsField("DC-IND", "DCInd");
        public static WinFormsField CemtexID = new WinFormsField("CEMTEX-ID", "CemtexID");
        public static WinFormsField NzlEftUserID = new WinFormsField("NZL-EFT-USER-ID", "NzlEftUserID");
        public static WinFormsField DcbUserNum = new WinFormsField("DCB-USER-NUM", "DcbUserNum");
        public static WinFormsField DBInd = new WinFormsField("DB-IND", "DBInd");
        public static WinFormsField DebitCemtexID = new WinFormsField("DEBIT-CEMTEX-ID", "DebitCemtexID");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField CitibankGcnCode = new WinFormsField("CITIBANK-GCN-CODE", "CitibankGcnCode");
        public static WinFormsField ChqStockAvailInd = new WinFormsField("CHQ-STOCK-AVAIL-IND", "ChqStockAvailInd");
        public static WinFormsField SettlementAccInd = new WinFormsField("SETTLEMENT-ACC-IND", "SettlementAccInd");
        public static WinFormsField AuditUserName = new WinFormsField("AUDIT-USER-NAME", "AuditUserName");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionOS = new WinFormsField("ACTION-OS", "ActionOS");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
