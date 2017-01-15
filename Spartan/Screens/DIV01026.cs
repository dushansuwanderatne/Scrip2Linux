using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01026

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01026", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField StateOFTaxLodge = new WinFormsField("STATE-OF-TAX-LODGE", "StateOFTaxLodge");
        public static WinFormsField YearTaxLodgement = new WinFormsField("YEAR-TAX-LODGEMENT", "YearTaxLodgement");
        public static WinFormsField InvestmentCode = new WinFormsField("INVESTMENT-CODE", "InvestmentCode");
        public static WinFormsField InvestmentDesc = new WinFormsField("INVESTMENT-DESC", "InvestmentDesc");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
