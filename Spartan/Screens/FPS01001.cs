using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField More = new WinFormsField("MORE", "More");
        public static WinFormsField Preload = new WinFormsField("PRELOAD", "Preload");
        public static WinFormsField InputPaymentCode = new WinFormsField("INPUT-PAYMENT-CODE", "InputPaymentCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
