using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05010", "FormName");
		//Fields


        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField InputDividendCode = new WinFormsField("INPUT-DIVIDEND-CODE", "InputDividendCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PaymentPhaseStatus = new WinFormsField("PAYMENT-PHASE-STATUS", "PaymentPhaseStatus");
        public static WinFormsField LitFwd = new WinFormsField("LIT-FWD", "LitFwd");
        public static WinFormsField LitBwd = new WinFormsField("LIT-BWD", "LitBwd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
