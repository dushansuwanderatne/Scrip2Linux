using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01046

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01046", "FormName");
		//Fields


        public static WinFormsField ErrorMessage = new WinFormsField("ERROR-MESSAGE", "ErrorMessage");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
