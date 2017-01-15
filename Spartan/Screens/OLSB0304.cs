using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0304", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField CertUnits = new WinFormsField("CERT-UNITS", "CertUnits");
        public static WinFormsField BuyHolder = new WinFormsField("BUY-HOLDER", "BuyHolder");
    }
}
