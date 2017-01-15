using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01094

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01094", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine1 = new WinFormsField("ADDRESS-LINE-1", "AddressLine1");
        public static WinFormsField AddressLine2 = new WinFormsField("ADDRESS-LINE-2", "AddressLine2");
        public static WinFormsField AddressLine3 = new WinFormsField("ADDRESS-LINE-3", "AddressLine3");
        public static WinFormsField AddressLine4 = new WinFormsField("ADDRESS-LINE-4", "AddressLine4");
        public static WinFormsField AddressLine5 = new WinFormsField("ADDRESS-LINE-5", "AddressLine5");
        public static WinFormsField WarningLine = new WinFormsField("WARNING-LINE", "WarningLine");
        public static WinFormsField AddressLine6 = new WinFormsField("ADDRESS-LINE-6", "AddressLine6");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
