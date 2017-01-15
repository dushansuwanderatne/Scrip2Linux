using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS04510

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS04510", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RequestNumber = new WinFormsField("REQUEST-NUMBER", "RequestNumber");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
