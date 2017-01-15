using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1097

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1097", "FormName");
		//Fields


        public static WinFormsField TaxYear = new WinFormsField("TAX-YEAR", "TaxYear");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
