using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB1020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB1020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RegisterCode1 = new WinFormsField("REGISTER-CODE-1", "RegisterCode1");
        public static WinFormsField CertIdentifier1 = new WinFormsField("CERT-IDENTIFIER-1", "CertIdentifier1");
        public static WinFormsField Units1 = new WinFormsField("UNITS-1", "Units1");
        public static WinFormsField RegisterCode2 = new WinFormsField("REGISTER-CODE-2", "RegisterCode2");
        public static WinFormsField CertIdentifier2 = new WinFormsField("CERT-IDENTIFIER-2", "CertIdentifier2");
        public static WinFormsField Units2 = new WinFormsField("UNITS-2", "Units2");
        public static WinFormsField RegisterCode3 = new WinFormsField("REGISTER-CODE-3", "RegisterCode3");
        public static WinFormsField CertIdentifier3 = new WinFormsField("CERT-IDENTIFIER-3", "CertIdentifier3");
        public static WinFormsField Units3 = new WinFormsField("UNITS-3", "Units3");
        public static WinFormsField BuyerRegCode = new WinFormsField("BUYER-REG-CODE", "BuyerRegCode");
        public static WinFormsField BuyerCertID = new WinFormsField("BUYER-CERT-ID", "BuyerCertID");
        public static WinFormsField BuyerUnits = new WinFormsField("BUYER-UNITS", "BuyerUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
