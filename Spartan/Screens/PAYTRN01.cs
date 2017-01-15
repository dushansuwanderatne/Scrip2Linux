using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYTRN01", "FormName");
		//Fields


        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField PayAccountTO = new WinFormsField("PAY-ACCOUNT-TO", "PayAccountTO");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField PayMethodTO = new WinFormsField("PAY-METHOD-TO", "PayMethodTO");
        public static WinFormsField PayReference = new WinFormsField("PAY-REFERENCE", "PayReference");
        public static WinFormsField PayReferenceTO = new WinFormsField("PAY-REFERENCE-TO", "PayReferenceTO");
        public static WinFormsField PayTrnCount = new WinFormsField("PAY-TRN-COUNT", "PayTrnCount");
        public static WinFormsField PayTrnCountTO = new WinFormsField("PAY-TRN-COUNT-TO", "PayTrnCountTO");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField PayTransNumber = new WinFormsField("PAY-TRANS-NUMBER", "PayTransNumber");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField PayTransDate = new WinFormsField("PAY-TRANS-DATE", "PayTransDate");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField ReversalFlag = new WinFormsField("REVERSAL-FLAG", "ReversalFlag");
        public static WinFormsField BankAccountNumber = new WinFormsField("BANK-ACCOUNT-NUMBER", "BankAccountNumber");
        public static WinFormsField PayStatusFrom = new WinFormsField("PAY-STATUS-FROM", "PayStatusFrom");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField PayStatusFromUpdt = new WinFormsField("PAY-STATUS-FROM-UPDT", "PayStatusFromUpdt");
        public static WinFormsField BankAccountType = new WinFormsField("BANK-ACCOUNT-TYPE", "BankAccountType");
        public static WinFormsField PendingReference = new WinFormsField("PENDING-REFERENCE", "PendingReference");
        public static WinFormsField RedefPaydetB4Image = new WinFormsField("REDEF-PAYDET-B4-IMAGE", "RedefPaydetB4Image");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
