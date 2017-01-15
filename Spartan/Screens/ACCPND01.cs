using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACCPND01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACCPND01", "FormName");
		//Fields


        public static WinFormsField AccpndKey0 = new WinFormsField("ACCPND-KEY0", "AccpndKey0");
        public static WinFormsField PaymentSource = new WinFormsField("PAYMENT-SOURCE", "PaymentSource");
        public static WinFormsField MoneyPaid = new WinFormsField("MONEY-PAID", "MoneyPaid");
        public static WinFormsField RemittanceRefNO = new WinFormsField("REMITTANCE-REF-NO", "RemittanceRefNO");
        public static WinFormsField TraceNO9 = new WinFormsField("TRACE-NO-9", "TraceNO9");
        public static WinFormsField SourceEntryMethod = new WinFormsField("SOURCE-ENTRY-METHOD", "SourceEntryMethod");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField TimeHhmmss = new WinFormsField("TIME-HHMMSS", "TimeHhmmss");
        public static WinFormsField BpaySettleDate = new WinFormsField("BPAY-SETTLE-DATE", "BpaySettleDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField ReasonCode = new WinFormsField("REASON-CODE", "ReasonCode");
    }
}
