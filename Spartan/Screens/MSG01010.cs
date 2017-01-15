using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OldPassword = new WinFormsField("OLD-PASSWORD", "OldPassword");
        public static WinFormsField NewPassword = new WinFormsField("NEW-PASSWORD", "NewPassword");
        public static WinFormsField NewPasswordCK = new WinFormsField("NEW-PASSWORD-CK", "NewPasswordCK");
    }
}
