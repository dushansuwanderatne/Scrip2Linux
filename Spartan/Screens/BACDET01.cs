using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BACDET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BACDET01", "FormName");
		//Fields


        public static WinFormsField BacdetKey0 = new WinFormsField("BACDET-KEY0", "BacdetKey0");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField SharedAccountInd = new WinFormsField("SHARED-ACCOUNT-IND", "SharedAccountInd");
        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField ReconciledBYFlg = new WinFormsField("RECONCILED-BY-FLG", "ReconciledBYFlg");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField AccurateReconciledInd = new WinFormsField("ACCURATE-RECONCILED-IND", "AccurateReconciledInd");
        public static WinFormsField NzlAnzBatchNumber = new WinFormsField("NZL-ANZ-BATCH-NUMBER", "NzlAnzBatchNumber");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField DCAllowedInd = new WinFormsField("DC-ALLOWED-IND", "DCAllowedInd");
        public static WinFormsField CitibankGcnCode = new WinFormsField("CITIBANK-GCN-CODE", "CitibankGcnCode");
        public static WinFormsField BankAccountStatus = new WinFormsField("BANK-ACCOUNT-STATUS", "BankAccountStatus");
        public static WinFormsField ChqAllowedInd = new WinFormsField("CHQ-ALLOWED-IND", "ChqAllowedInd");
        public static WinFormsField ChqStockAvailableInd = new WinFormsField("CHQ-STOCK-AVAILABLE-IND", "ChqStockAvailableInd");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField SettlementAccountInd = new WinFormsField("SETTLEMENT-ACCOUNT-IND", "SettlementAccountInd");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField DebitUserID = new WinFormsField("DEBIT-USER-ID", "DebitUserID");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField DBAllowedInd = new WinFormsField("DB-ALLOWED-IND", "DBAllowedInd");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
