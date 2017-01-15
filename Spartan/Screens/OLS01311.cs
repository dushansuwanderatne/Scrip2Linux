using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01311

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01311", "FormName");
		//Fields


        public static WinFormsField PayeeAddressLine = new WinFormsField("PAYEE-ADDRESS-LINE", "PayeeAddressLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
