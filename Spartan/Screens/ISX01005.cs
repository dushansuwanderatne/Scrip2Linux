using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01005", "FormName");
		//Fields


        public static WinFormsField Proceed = new WinFormsField("PROCEED", "Proceed");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
