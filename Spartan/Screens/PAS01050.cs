using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01050", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DateWarning = new WinFormsField("DATE-WARNING", "DateWarning");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
