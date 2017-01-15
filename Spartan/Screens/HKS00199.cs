using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00199

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00199", "FormName");
		//Fields


        public static WinFormsField OldPassword = new WinFormsField("OLD-PASSWORD", "OldPassword");
        public static WinFormsField NewPassword = new WinFormsField("NEW-PASSWORD", "NewPassword");
    }
}
