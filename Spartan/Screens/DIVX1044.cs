using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1044

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1044", "FormName");
		//Fields


        public static WinFormsField StateOFTaxLodge = new WinFormsField("STATE-OF-TAX-LODGE", "StateOFTaxLodge");
        public static WinFormsField YearTaxLodgement = new WinFormsField("YEAR-TAX-LODGEMENT", "YearTaxLodgement");
        public static WinFormsField InvestmentCode = new WinFormsField("INVESTMENT-CODE", "InvestmentCode");
        public static WinFormsField InvestmentDesc = new WinFormsField("INVESTMENT-DESC", "InvestmentDesc");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField RecnPayAcc = new WinFormsField("RECN-PAY-ACC", "RecnPayAcc");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
