using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEYT0104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEYT0104", "FormName");
		//Fields


        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
    }
}
