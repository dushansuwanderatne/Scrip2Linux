using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP02", "FormName");
		//Fields


        public static WinFormsField OldPassword = new WinFormsField("OLD-PASSWORD", "OldPassword");
        public static WinFormsField NewPassword = new WinFormsField("NEW-PASSWORD", "NewPassword");
        public static WinFormsField ConfirmPassword = new WinFormsField("CONFIRM-PASSWORD", "ConfirmPassword");
    }
}
