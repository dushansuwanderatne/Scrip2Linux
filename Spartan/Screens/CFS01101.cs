using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01101", "FormName");
		//Fields


        public static WinFormsField ExemptionCode = new WinFormsField("EXEMPTION-CODE", "ExemptionCode");
        public static WinFormsField ExemptionDesc = new WinFormsField("EXEMPTION-DESC", "ExemptionDesc");
        public static WinFormsField AtoTaxFileNumber = new WinFormsField("ATO-TAX-FILE-NUMBER", "AtoTaxFileNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
