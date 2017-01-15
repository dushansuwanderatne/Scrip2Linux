using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01307

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01307", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField RequiredCurrency = new WinFormsField("REQUIRED-CURRENCY", "RequiredCurrency");
        public static WinFormsField ReqCurrencyDesc = new WinFormsField("REQ-CURRENCY-DESC", "ReqCurrencyDesc");
    }
}
