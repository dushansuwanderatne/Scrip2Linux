using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05701", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField CurrentForwardID = new WinFormsField("CURRENT-FORWARD-ID", "CurrentForwardID");
        public static WinFormsField NewForwardID = new WinFormsField("NEW-FORWARD-ID", "NewForwardID");
    }
}
