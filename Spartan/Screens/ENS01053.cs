using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01053

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01053", "FormName");
		//Fields
        public static WinFormsField ExtraCertDetails = new WinFormsField("EXTRA-CERT-DETAILS", "ExtraCertDetails");
    }
}
