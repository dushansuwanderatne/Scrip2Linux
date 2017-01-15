using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKDET02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKDET02", "FormName");
		//Fields


        public static WinFormsField BlkdetKey0 = new WinFormsField("BLKDET-KEY0", "BlkdetKey0");
        public static WinFormsField TaxONCharges = new WinFormsField("TAX-ON-CHARGES", "TaxONCharges");
        public static WinFormsField SplitCertFrom = new WinFormsField("SPLIT-CERT-FROM", "SplitCertFrom");
        public static WinFormsField BuySplitNumber = new WinFormsField("BUY-SPLIT-NUMBER", "BuySplitNumber");
        public static WinFormsField BuySplitUnits = new WinFormsField("BUY-SPLIT-UNITS", "BuySplitUnits");
        public static WinFormsField DeductionOther = new WinFormsField("DEDUCTION-OTHER", "DeductionOther");
        public static WinFormsField SplitCertTO = new WinFormsField("SPLIT-CERT-TO", "SplitCertTO");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField AwardDate = new WinFormsField("AWARD-DATE", "AwardDate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField AccumPeriodFrom = new WinFormsField("ACCUM-PERIOD-FROM", "AccumPeriodFrom");
        public static WinFormsField AccumPeriodTO = new WinFormsField("ACCUM-PERIOD-TO", "AccumPeriodTO");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterTransNumber = new WinFormsField("COUNTER-TRANS-NUMBER", "CounterTransNumber");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField CounterContactDetails = new WinFormsField("COUNTER-CONTACT-DETAILS", "CounterContactDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
