using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05302", "FormName");
		//Fields


        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField AdminName = new WinFormsField("ADMIN-NAME", "AdminName");
        public static WinFormsField AdminPassword = new WinFormsField("ADMIN-PASSWORD", "AdminPassword");
    }
}
