using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS01109

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS01109", "FormName");
		//Fields


        public static WinFormsField TfnExemptionCode = new WinFormsField("TFN-EXEMPTION-CODE", "TfnExemptionCode");
        public static WinFormsField TfnExemptionDesc = new WinFormsField("TFN-EXEMPTION-DESC", "TfnExemptionDesc");
        public static WinFormsField AtoTaxFileNumber = new WinFormsField("ATO-TAX-FILE-NUMBER", "AtoTaxFileNumber");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
