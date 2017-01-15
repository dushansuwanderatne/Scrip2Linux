using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14072

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14072", "FormName");
		//Fields


        public static WinFormsField SubCoyCode = new WinFormsField("SUB-COY-CODE", "SubCoyCode");
        public static WinFormsField SubCoyDesc = new WinFormsField("SUB-COY-DESC", "SubCoyDesc");
        public static WinFormsField SubCoyAbn = new WinFormsField("SUB-COY-ABN", "SubCoyAbn");
        public static WinFormsField AtoEftLargePayer = new WinFormsField("ATO-EFT-LARGE-PAYER", "AtoEftLargePayer");
        public static WinFormsField TaxHolderID = new WinFormsField("TAX-HOLDER-ID", "TaxHolderID");
        public static WinFormsField OtherTaxHolderID = new WinFormsField("OTHER-TAX-HOLDER-ID", "OtherTaxHolderID");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
