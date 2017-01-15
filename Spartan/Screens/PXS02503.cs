using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02503", "FormName");
		//Fields


        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField PersonA = new WinFormsField("PERSON-A", "PersonA");
        public static WinFormsField TypeA = new WinFormsField("TYPE-A", "TypeA");
        public static WinFormsField FailingA = new WinFormsField("FAILING-A", "FailingA");
        public static WinFormsField FailDesc = new WinFormsField("FAIL-DESC", "FailDesc");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField RefNum = new WinFormsField("REF-NUM", "RefNum");
        public static WinFormsField LodgDate = new WinFormsField("LODG-DATE", "LodgDate");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Nomb = new WinFormsField("NOMB", "Nomb");
        public static WinFormsField PersonB = new WinFormsField("PERSON-B", "PersonB");
        public static WinFormsField TotalShares = new WinFormsField("TOTAL-SHARES", "TotalShares");
    }
}
