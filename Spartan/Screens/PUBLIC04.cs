using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PUBLIC04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PUBLIC04", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OldPassword = new WinFormsField("OLD-PASSWORD", "OldPassword");
        public static WinFormsField NewPassword = new WinFormsField("NEW-PASSWORD", "NewPassword");
        public static WinFormsField NewPassword2 = new WinFormsField("NEW-PASSWORD2", "NewPassword2");
    }
}
