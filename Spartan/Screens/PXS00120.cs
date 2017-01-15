using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00120

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00120", "FormName");
		//Fields


        public static WinFormsField WarningMessageLine = new WinFormsField("WARNING-MESSAGE-LINE", "WarningMessageLine");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
