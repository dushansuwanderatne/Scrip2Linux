using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL01010", "FormName");
		//Fields


        public static WinFormsField CalcUnits = new WinFormsField("CALC-UNITS", "CalcUnits");
        public static WinFormsField UnitsONFile = new WinFormsField("UNITS-ON-FILE", "UnitsONFile");
    }
}
