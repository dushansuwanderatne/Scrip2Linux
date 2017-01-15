using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05101", "FormName");
		//Fields


        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField UserIdentifier = new WinFormsField("USER-IDENTIFIER", "UserIdentifier");
        public static WinFormsField HostUserName = new WinFormsField("HOST-USER-NAME", "HostUserName");
        public static WinFormsField IgnoreStaffInd = new WinFormsField("IGNORE-STAFF-IND", "IgnoreStaffInd");
        public static WinFormsField UsualLogin = new WinFormsField("USUAL-LOGIN", "UsualLogin");
        public static WinFormsField NewUsualLogin = new WinFormsField("NEW-USUAL-LOGIN", "NewUsualLogin");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
