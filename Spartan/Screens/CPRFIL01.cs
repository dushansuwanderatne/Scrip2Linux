using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CPRFIL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CPRFIL01", "FormName");
		//Fields


        public static WinFormsField CprfilKey0 = new WinFormsField("CPRFIL-KEY0", "CprfilKey0");
        public static WinFormsField PrintBatchID = new WinFormsField("PRINT-BATCH-ID", "PrintBatchID");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField PrintingBYFlg = new WinFormsField("PRINTING-BY-FLG", "PrintingBYFlg");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField FirstChequeNumber = new WinFormsField("FIRST-CHEQUE-NUMBER", "FirstChequeNumber");
        public static WinFormsField LastChequeNumber = new WinFormsField("LAST-CHEQUE-NUMBER", "LastChequeNumber");
        public static WinFormsField NbrPayments = new WinFormsField("NBR-PAYMENTS", "NbrPayments");
        public static WinFormsField TotalChqAmt = new WinFormsField("TOTAL-CHQ-AMT", "TotalChqAmt");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
