using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01089

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01089", "FormName");
		//Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField MarkingNumber = new WinFormsField("MARKING-NUMBER", "MarkingNumber");
    }
}
