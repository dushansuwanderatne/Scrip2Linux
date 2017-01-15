using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL10203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL10203", "FormName");
		//Fields


        public static WinFormsField Desc4 = new WinFormsField("DESC-4", "Desc4");
        public static WinFormsField CalcNett = new WinFormsField("CALC-NETT", "CalcNett");
        public static WinFormsField CalcDual = new WinFormsField("CALC-DUAL", "CalcDual");
        public static WinFormsField Desc5 = new WinFormsField("DESC-5", "Desc5");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
    }
}
