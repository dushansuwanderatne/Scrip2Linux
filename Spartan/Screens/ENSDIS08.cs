using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS08

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS08", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PaymentAmount1 = new WinFormsField("PAYMENT-AMOUNT-1", "PaymentAmount1");
        public static WinFormsField PaymentMethodDesc = new WinFormsField("PAYMENT-METHOD-DESC", "PaymentMethodDesc");
        public static WinFormsField PaymentAmount2 = new WinFormsField("PAYMENT-AMOUNT-2", "PaymentAmount2");
        public static WinFormsField PaymentStatusDesc = new WinFormsField("PAYMENT-STATUS-DESC", "PaymentStatusDesc");
        public static WinFormsField TaxDednAmount = new WinFormsField("TAX-DEDN-AMOUNT", "TaxDednAmount");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField NettAmount = new WinFormsField("NETT-AMOUNT", "NettAmount");
        public static WinFormsField PresModDate = new WinFormsField("PRES-MOD-DATE", "PresModDate");
        public static WinFormsField PaymentOriginDesc = new WinFormsField("PAYMENT-ORIGIN-DESC", "PaymentOriginDesc");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField TaxTypeDesc = new WinFormsField("TAX-TYPE-DESC", "TaxTypeDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField HolderPI = new WinFormsField("HOLDER-PI", "HolderPI");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HnaLine1 = new WinFormsField("HNA-LINE-1", "HnaLine1");
        public static WinFormsField HnaLine2 = new WinFormsField("HNA-LINE-2", "HnaLine2");
        public static WinFormsField RefundPaidDesc = new WinFormsField("REFUND-PAID-DESC", "RefundPaidDesc");
        public static WinFormsField OrigPayAcc = new WinFormsField("ORIG-PAY-ACC", "OrigPayAcc");
        public static WinFormsField OrigPayRef = new WinFormsField("ORIG-PAY-REF", "OrigPayRef");
        public static WinFormsField OrigPayMethDesc = new WinFormsField("ORIG-PAY-METH-DESC", "OrigPayMethDesc");
        public static WinFormsField OrigHolderID = new WinFormsField("ORIG-HOLDER-ID", "OrigHolderID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
