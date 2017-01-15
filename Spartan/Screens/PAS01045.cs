using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01045", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField WarningMessage1 = new WinFormsField("WARNING-MESSAGE-1", "WarningMessage1");
        public static WinFormsField WarningMessage3 = new WinFormsField("WARNING-MESSAGE-3", "WarningMessage3");
        public static WinFormsField WarningMessage2 = new WinFormsField("WARNING-MESSAGE-2", "WarningMessage2");
        public static WinFormsField WarningMessage4 = new WinFormsField("WARNING-MESSAGE-4", "WarningMessage4");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
