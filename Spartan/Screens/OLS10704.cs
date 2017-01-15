using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10704", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField NewGrossAmount = new WinFormsField("NEW-GROSS-AMOUNT", "NewGrossAmount");
        public static WinFormsField GrossAmount = new WinFormsField("GROSS-AMOUNT", "GrossAmount");
        public static WinFormsField NewWitholdTax = new WinFormsField("NEW-WITHOLD-TAX", "NewWitholdTax");
        public static WinFormsField WitholdTax = new WinFormsField("WITHOLD-TAX", "WitholdTax");
        public static WinFormsField NewWHTaxInd = new WinFormsField("NEW-WH-TAX-IND", "NewWHTaxInd");
        public static WinFormsField WHTaxInd = new WinFormsField("WH-TAX-IND", "WHTaxInd");
    }
}
