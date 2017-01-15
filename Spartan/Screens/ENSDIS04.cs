using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS04", "FormName");
		//Fields


        public static WinFormsField TaxDetails = new WinFormsField("TAX-DETAILS", "TaxDetails");
    }
}
