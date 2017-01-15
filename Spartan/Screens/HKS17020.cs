using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS17020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS17020", "FormName");
		//Fields


        public static WinFormsField RangeDetails = new WinFormsField("RANGE-DETAILS", "RangeDetails");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
