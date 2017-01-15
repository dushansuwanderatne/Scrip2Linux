using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField PaymentListingHead = new WinFormsField("PAYMENT-LISTING-HEAD", "PaymentListingHead");
        public static WinFormsField OverseasListingHead = new WinFormsField("OVERSEAS-LISTING-HEAD", "OverseasListingHead");
        public static WinFormsField PaymentSequence = new WinFormsField("PAYMENT-SEQUENCE", "PaymentSequence");
        public static WinFormsField OverseasSequence = new WinFormsField("OVERSEAS-SEQUENCE", "OverseasSequence");
        public static WinFormsField ChequeAdviceSeq = new WinFormsField("CHEQUE-ADVICE-SEQ", "ChequeAdviceSeq");
        public static WinFormsField ReturnMailApply = new WinFormsField("RETURN-MAIL-APPLY", "ReturnMailApply");
        public static WinFormsField TfnPrintFlag = new WinFormsField("TFN-PRINT-FLAG", "TfnPrintFlag");
        public static WinFormsField TfnPosition = new WinFormsField("TFN-POSITION", "TfnPosition");
        public static WinFormsField CalcProgram = new WinFormsField("CALC-PROGRAM", "CalcProgram");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
