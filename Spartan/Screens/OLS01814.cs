using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01814

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01814", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField WarningMessage = new WinFormsField("WARNING-MESSAGE", "WarningMessage");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
