using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10702", "FormName");
		//Fields


        public static WinFormsField NewFranked = new WinFormsField("NEW-FRANKED", "NewFranked");
        public static WinFormsField Franked = new WinFormsField("FRANKED", "Franked");
        public static WinFormsField NewUnfranked = new WinFormsField("NEW-UNFRANKED", "NewUnfranked");
        public static WinFormsField Unfranked = new WinFormsField("UNFRANKED", "Unfranked");
        public static WinFormsField NewWitholdTax = new WinFormsField("NEW-WITHOLD-TAX", "NewWitholdTax");
        public static WinFormsField WitholdTax = new WinFormsField("WITHOLD-TAX", "WitholdTax");
        public static WinFormsField NewWHTaxInd = new WinFormsField("NEW-WH-TAX-IND", "NewWHTaxInd");
        public static WinFormsField WHTaxInd = new WinFormsField("WH-TAX-IND", "WHTaxInd");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
