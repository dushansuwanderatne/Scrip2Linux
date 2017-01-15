using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10703

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10703", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField NewAmount1 = new WinFormsField("NEW-AMOUNT-1", "NewAmount1");
        public static WinFormsField Amount1 = new WinFormsField("AMOUNT-1", "Amount1");
        public static WinFormsField NewAmount2 = new WinFormsField("NEW-AMOUNT-2", "NewAmount2");
        public static WinFormsField Amount2 = new WinFormsField("AMOUNT-2", "Amount2");
        public static WinFormsField NewWitholdTax = new WinFormsField("NEW-WITHOLD-TAX", "NewWitholdTax");
        public static WinFormsField WitholdTax = new WinFormsField("WITHOLD-TAX", "WitholdTax");
        public static WinFormsField NewWHTaxInd = new WinFormsField("NEW-WH-TAX-IND", "NewWHTaxInd");
        public static WinFormsField WHTaxInd = new WinFormsField("WH-TAX-IND", "WHTaxInd");
    }
}
