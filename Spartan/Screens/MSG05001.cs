using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField OldPassword = new WinFormsField("OLD-PASSWORD", "OldPassword");
        public static WinFormsField NewPassword1 = new WinFormsField("NEW-PASSWORD-1", "NewPassword1");
        public static WinFormsField NewPassword2 = new WinFormsField("NEW-PASSWORD-2", "NewPassword2");
    }
}
