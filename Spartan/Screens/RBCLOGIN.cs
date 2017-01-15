using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RBCLOGIN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RBCLOGIN", "FormName");
		//Fields


        public static WinFormsField User = new WinFormsField("USER", "User");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
