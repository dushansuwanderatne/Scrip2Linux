using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CPRDET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CPRDET01", "FormName");
		//Fields


        public static WinFormsField CprdetKey0 = new WinFormsField("CPRDET-KEY0", "CprdetKey0");
        public static WinFormsField PrintBatchID = new WinFormsField("PRINT-BATCH-ID", "PrintBatchID");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField PendingReference = new WinFormsField("PENDING-REFERENCE", "PendingReference");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField PrintBatchID2 = new WinFormsField("PRINT-BATCH-ID-2", "PrintBatchID2");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField OrigPaymentDate = new WinFormsField("ORIG-PAYMENT-DATE", "OrigPaymentDate");
        public static WinFormsField OrigPayReference = new WinFormsField("ORIG-PAY-REFERENCE", "OrigPayReference");
        public static WinFormsField OrigPayMethod = new WinFormsField("ORIG-PAY-METHOD", "OrigPayMethod");
        public static WinFormsField WorkflowID = new WinFormsField("WORKFLOW-ID", "WorkflowID");
        public static WinFormsField ChqNOAllocated = new WinFormsField("CHQ-NO-ALLOCATED", "ChqNOAllocated");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PaidAmount = new WinFormsField("PAID-AMOUNT", "PaidAmount");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField NotPrntdReasonCode = new WinFormsField("NOT-PRNTD-REASON-CODE", "NotPrntdReasonCode");
        public static WinFormsField AuditExceptionCode = new WinFormsField("AUDIT-EXCEPTION-CODE", "AuditExceptionCode");
        public static WinFormsField SourceIDX = new WinFormsField("SOURCE-ID-X", "SourceIDX");
        public static WinFormsField ChqRejectedInd = new WinFormsField("CHQ-REJECTED-IND", "ChqRejectedInd");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField RejectedSource = new WinFormsField("REJECTED-SOURCE", "RejectedSource");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
