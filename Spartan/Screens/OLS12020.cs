using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS12020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS12020", "FormName");
		//Fields


        public static WinFormsField RangeDetails = new WinFormsField("RANGE-DETAILS", "RangeDetails");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
