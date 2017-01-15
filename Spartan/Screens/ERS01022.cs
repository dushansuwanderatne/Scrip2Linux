using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01022", "FormName");
		//Fields
        public static WinFormsField Class1 = new WinFormsField("CLASS-1", "Class1");
        public static WinFormsField PayAcct = new WinFormsField("PAY-ACCT", "PayAcct");
        public static WinFormsField ClassPerCatInd = new WinFormsField("1-CLASS-PER-CAT-IND", "1ClassPerCatInd");
        public static WinFormsField UseHistClassesInd = new WinFormsField("USE-HIST-CLASSES-IND", "UseHistClassesInd");
        public static WinFormsField HistClass = new WinFormsField("HIST-CLASS", "HistClass");
        public static WinFormsField ReportCgtInd = new WinFormsField("REPORT-CGT-IND", "ReportCgtInd");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField LoanDiscountPrice = new WinFormsField("LOAN-DISCOUNT-PRICE", "LoanDiscountPrice");
        public static WinFormsField AmendmentInd = new WinFormsField("AMENDMENT-IND", "AmendmentInd");
        public static WinFormsField Ers01022AmendTfnReqInd = new WinFormsField("ERS01022-AMEND-TFN-REQ-IND", "Ers01022AmendTfnReqInd");
        public static WinFormsField IgnoreReconTxnsInd = new WinFormsField("IGNORE-RECON-TXNS-IND", "IgnoreReconTxnsInd");
        public static WinFormsField CapRetPaymentDate = new WinFormsField("CAP-RET-PAYMENT-DATE", "CapRetPaymentDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
