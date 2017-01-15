using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10203", "FormName");
		//Fields


        public static WinFormsField Calc1 = new WinFormsField("CALC-1", "Calc1");
        public static WinFormsField Desc1 = new WinFormsField("DESC-1", "Desc1");
        public static WinFormsField Calc2 = new WinFormsField("CALC-2", "Calc2");
        public static WinFormsField Desc2 = new WinFormsField("DESC-2", "Desc2");
        public static WinFormsField Calc3 = new WinFormsField("CALC-3", "Calc3");
        public static WinFormsField Desc3 = new WinFormsField("DESC-3", "Desc3");
        public static WinFormsField CalcNett = new WinFormsField("CALC-NETT", "CalcNett");
        public static WinFormsField Desc4 = new WinFormsField("DESC-4", "Desc4");
        public static WinFormsField CalcDual = new WinFormsField("CALC-DUAL", "CalcDual");
        public static WinFormsField Desc5 = new WinFormsField("DESC-5", "Desc5");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
    }
}
