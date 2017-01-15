using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYDET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYDET01", "FormName");
		//Fields


        public static WinFormsField PaydetKey0 = new WinFormsField("PAYDET-KEY0", "PaydetKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PresentedDate = new WinFormsField("PRESENTED-DATE", "PresentedDate");
        public static WinFormsField PaymentAmount1 = new WinFormsField("PAYMENT-AMOUNT-1", "PaymentAmount1");
        public static WinFormsField PaymentAmount2 = new WinFormsField("PAYMENT-AMOUNT-2", "PaymentAmount2");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField PaymentOrigin = new WinFormsField("PAYMENT-ORIGIN", "PaymentOrigin");
        public static WinFormsField PaymentStatus = new WinFormsField("PAYMENT-STATUS", "PaymentStatus");
        public static WinFormsField TaxTypeIndicator = new WinFormsField("TAX-TYPE-INDICATOR", "TaxTypeIndicator");
        public static WinFormsField ChequePaymentDate = new WinFormsField("CHEQUE-PAYMENT-DATE", "ChequePaymentDate");
        public static WinFormsField OrigHolderIdentifier = new WinFormsField("ORIG-HOLDER-IDENTIFIER", "OrigHolderIdentifier");
        public static WinFormsField OrigPayAccountNumber = new WinFormsField("ORIG-PAY-ACCOUNT-NUMBER", "OrigPayAccountNumber");
        public static WinFormsField OrigPayRefNumber = new WinFormsField("ORIG-PAY-REF-NUMBER", "OrigPayRefNumber");
        public static WinFormsField OrigPaymentMethod = new WinFormsField("ORIG-PAYMENT-METHOD", "OrigPaymentMethod");
        public static WinFormsField PayTrnCount = new WinFormsField("PAY-TRN-COUNT", "PayTrnCount");
        public static WinFormsField ChequePaidInd = new WinFormsField("CHEQUE-PAID-IND", "ChequePaidInd");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField ExternalReference = new WinFormsField("EXTERNAL-REFERENCE", "ExternalReference");
        public static WinFormsField FailDCSource = new WinFormsField("FAIL-DC-SOURCE", "FailDCSource");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField RecnPayAccount = new WinFormsField("RECN-PAY-ACCOUNT", "RecnPayAccount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
