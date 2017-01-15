using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01041

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01041", "FormName");
		//Fields


        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField ExtraDivCode = new WinFormsField("EXTRA-DIV-CODE", "ExtraDivCode");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
    }
}
