using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1022", "FormName");
		//Fields
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField SourceDescription = new WinFormsField("SOURCE-DESCRIPTION", "SourceDescription");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField PaymentListingHead = new WinFormsField("PAYMENT-LISTING-HEAD", "PaymentListingHead");
        public static WinFormsField PaymentSequence = new WinFormsField("PAYMENT-SEQUENCE", "PaymentSequence");
        public static WinFormsField ChequeAdviceSeq = new WinFormsField("CHEQUE-ADVICE-SEQ", "ChequeAdviceSeq");
        public static WinFormsField ReturnMailApply = new WinFormsField("RETURN-MAIL-APPLY", "ReturnMailApply");
        public static WinFormsField UnissuedChqApply = new WinFormsField("UNISSUED-CHQ-APPLY", "UnissuedChqApply");
        public static WinFormsField TfnPrintFlag = new WinFormsField("TFN-PRINT-FLAG", "TfnPrintFlag");
        public static WinFormsField DeductionsApply = new WinFormsField("DEDUCTIONS-APPLY", "DeductionsApply");
        public static WinFormsField CalcUnitRateInd = new WinFormsField("CALC-UNIT-RATE-IND", "CalcUnitRateInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
