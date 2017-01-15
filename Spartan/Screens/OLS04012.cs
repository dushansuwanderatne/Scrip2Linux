using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS04012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS04012", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Reg = new WinFormsField("REG", "Reg");
        public static WinFormsField RegDesc = new WinFormsField("REG-DESC", "RegDesc");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
