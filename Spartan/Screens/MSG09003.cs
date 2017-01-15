using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09003", "FormName");
		//Fields


        public static WinFormsField ErrorMessage = new WinFormsField("ERROR-MESSAGE", "ErrorMessage");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField LoginName = new WinFormsField("LOGIN-NAME", "LoginName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
