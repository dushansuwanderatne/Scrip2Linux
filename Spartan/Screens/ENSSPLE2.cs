using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSPLE2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSPLE2", "FormName");
		//Fields


        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Proceeds = new WinFormsField("PROCEEDS", "Proceeds");
        public static WinFormsField Liv = new WinFormsField("LIV", "Liv");
        public static WinFormsField Taxable = new WinFormsField("TAXABLE", "Taxable");
        public static WinFormsField TaxON = new WinFormsField("TAX-ON", "TaxON");
        public static WinFormsField TaxDeducted = new WinFormsField("TAX-DEDUCTED", "TaxDeducted");
    }
}
