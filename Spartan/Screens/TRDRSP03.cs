using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP03", "FormName");
		//Fields


        public static WinFormsField FormHeading = new WinFormsField("FORM-HEADING", "FormHeading");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField LimitPriceFrom = new WinFormsField("LIMIT-PRICE-FROM", "LimitPriceFrom");
        public static WinFormsField LimitPriceTO = new WinFormsField("LIMIT-PRICE-TO", "LimitPriceTO");
        public static WinFormsField OrdDurationType = new WinFormsField("ORD-DURATION-TYPE", "OrdDurationType");
        public static WinFormsField OrmsOrderStatus = new WinFormsField("ORMS-ORDER-STATUS", "OrmsOrderStatus");
        public static WinFormsField DateOrderSentFrom = new WinFormsField("DATE-ORDER-SENT-FROM", "DateOrderSentFrom");
        public static WinFormsField DateOrderSentTO = new WinFormsField("DATE-ORDER-SENT-TO", "DateOrderSentTO");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerAccount = new WinFormsField("BROKER-ACCOUNT", "BrokerAccount");
        public static WinFormsField RecnCode = new WinFormsField("RECN-CODE", "RecnCode");
        public static WinFormsField PayAccount = new WinFormsField("PAY-ACCOUNT", "PayAccount");
        public static WinFormsField ChgPaidBY = new WinFormsField("CHG-PAID-BY", "ChgPaidBY");
        public static WinFormsField ChgType = new WinFormsField("CHG-TYPE", "ChgType");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PymtCurrCode = new WinFormsField("PYMT-CURR-CODE", "PymtCurrCode");
        public static WinFormsField ReportFormat = new WinFormsField("REPORT-FORMAT", "ReportFormat");
        public static WinFormsField CertDtlsInd = new WinFormsField("CERT-DTLS-IND", "CertDtlsInd");
        public static WinFormsField ReversedTradeInd = new WinFormsField("REVERSED-TRADE-IND", "ReversedTradeInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
