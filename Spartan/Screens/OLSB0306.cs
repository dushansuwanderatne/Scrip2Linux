using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0306

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0306", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ExerciseUnits = new WinFormsField("EXERCISE-UNITS", "ExerciseUnits");
        public static WinFormsField CalcUnits = new WinFormsField("CALC-UNITS", "CalcUnits");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
    }
}
