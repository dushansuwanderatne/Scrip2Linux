using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYHIS01", "FormName");
		//Fields


        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDateFrom = new WinFormsField("PAYMENT-DATE-FROM", "PaymentDateFrom");
        public static WinFormsField PaymentDateTO = new WinFormsField("PAYMENT-DATE-TO", "PaymentDateTO");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField BCRunNumber = new WinFormsField("BC-RUN-NUMBER", "BCRunNumber");
        public static WinFormsField NARunNumber = new WinFormsField("NA-RUN-NUMBER", "NARunNumber");
        public static WinFormsField PayAccountNbr = new WinFormsField("PAY-ACCOUNT-NBR", "PayAccountNbr");
        public static WinFormsField MCAllConvRate = new WinFormsField("MC-ALL-CONV-RATE", "MCAllConvRate");
        public static WinFormsField MCDomicileCodes = new WinFormsField("MC-DOMICILE-CODES", "MCDomicileCodes");
        public static WinFormsField MCConversionRate = new WinFormsField("MC-CONVERSION-RATE", "MCConversionRate");
        public static WinFormsField MCPayAccountNumber = new WinFormsField("MC-PAY-ACCOUNT-NUMBER", "MCPayAccountNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
