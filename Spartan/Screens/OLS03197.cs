using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03197

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03197", "FormName");
		//Fields


        public static WinFormsField WarnLine = new WinFormsField("WARN-LINE", "WarnLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
