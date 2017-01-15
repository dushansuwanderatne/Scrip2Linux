using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01226

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01226", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Premise = new WinFormsField("PREMISE", "Premise");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
