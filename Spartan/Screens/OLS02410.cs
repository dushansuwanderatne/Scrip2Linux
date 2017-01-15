using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02410

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02410", "FormName");
		//Fields


        public static WinFormsField LastCert = new WinFormsField("LAST-CERT", "LastCert");
        public static WinFormsField SubTotal = new WinFormsField("SUB-TOTAL", "SubTotal");
        public static WinFormsField Cert = new WinFormsField("CERT", "Cert");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
    }
}
