using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05020", "FormName");
		//Fields


        public static WinFormsField PaymentStatusDetail = new WinFormsField("PAYMENT-STATUS-DETAIL", "PaymentStatusDetail");
    }
}
