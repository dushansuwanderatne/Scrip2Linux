using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01026

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01026", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField YearTaxLodgement = new WinFormsField("YEAR-TAX-LODGEMENT", "YearTaxLodgement");
        public static WinFormsField TypePayment = new WinFormsField("TYPE-PAYMENT", "TypePayment");
        public static WinFormsField TypeAccount = new WinFormsField("TYPE-ACCOUNT", "TypeAccount");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
