using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01040", "FormName");
		//Fields


        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField ExtraPayCode = new WinFormsField("EXTRA-PAY-CODE", "ExtraPayCode");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
    }
}
