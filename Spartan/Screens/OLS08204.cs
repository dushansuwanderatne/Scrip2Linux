using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08204

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08204", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CallClass = new WinFormsField("CALL-CLASS", "CallClass");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}