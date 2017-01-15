using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PNDPAY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PNDPAY01", "FormName");
		//Fields


        public static WinFormsField PndpayKey0 = new WinFormsField("PNDPAY-KEY0", "PndpayKey0");
        public static WinFormsField PendingReference = new WinFormsField("PENDING-REFERENCE", "PendingReference");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderIdentifierTO = new WinFormsField("HOLDER-IDENTIFIER-TO", "HolderIdentifierTO");
        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField PayAccountTO = new WinFormsField("PAY-ACCOUNT-TO", "PayAccountTO");
        public static WinFormsField PayReference = new WinFormsField("PAY-REFERENCE", "PayReference");
        public static WinFormsField PayReferenceTO = new WinFormsField("PAY-REFERENCE-TO", "PayReferenceTO");
        public static WinFormsField PayMethod = new WinFormsField("PAY-METHOD", "PayMethod");
        public static WinFormsField PayMethodTO = new WinFormsField("PAY-METHOD-TO", "PayMethodTO");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField RequestCreatedDate = new WinFormsField("REQUEST-CREATED-DATE", "RequestCreatedDate");
        public static WinFormsField ReplacementPayDate = new WinFormsField("REPLACEMENT-PAY-DATE", "ReplacementPayDate");
        public static WinFormsField PndpayStepCode = new WinFormsField("PNDPAY-STEP-CODE", "PndpayStepCode");
        public static WinFormsField PndpayStatus = new WinFormsField("PNDPAY-STATUS", "PndpayStatus");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField PaidAmount = new WinFormsField("PAID-AMOUNT", "PaidAmount");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField RequestSource = new WinFormsField("REQUEST-SOURCE", "RequestSource");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField SourceIDX = new WinFormsField("SOURCE-ID-X", "SourceIDX");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField PayStatusFrom = new WinFormsField("PAY-STATUS-FROM", "PayStatusFrom");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
