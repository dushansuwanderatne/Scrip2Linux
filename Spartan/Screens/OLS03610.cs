using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03610

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03610", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField WarningLine = new WinFormsField("WARNING-LINE", "WarningLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
