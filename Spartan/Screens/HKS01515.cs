using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01515

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01515", "FormName");
		//Fields


        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
