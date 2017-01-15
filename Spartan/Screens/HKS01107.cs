using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01107

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01107", "FormName");
		//Fields


        public static WinFormsField EssDummyCheck = new WinFormsField("ESS-DUMMY-CHECK", "EssDummyCheck");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
