using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01015

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01015", "FormName");
		//Fields


        public static WinFormsField PaymentAccount5 = new WinFormsField("PAYMENT-ACCOUNT-5", "PaymentAccount5");
        public static WinFormsField PaymentAccount10 = new WinFormsField("PAYMENT-ACCOUNT-10", "PaymentAccount10");
        public static WinFormsField PaymentAccount15 = new WinFormsField("PAYMENT-ACCOUNT-15", "PaymentAccount15");
        public static WinFormsField PaymentAccount20 = new WinFormsField("PAYMENT-ACCOUNT-20", "PaymentAccount20");
        public static WinFormsField PaymentAccount25 = new WinFormsField("PAYMENT-ACCOUNT-25", "PaymentAccount25");
        public static WinFormsField PaymentAccount30 = new WinFormsField("PAYMENT-ACCOUNT-30", "PaymentAccount30");
    }
}
