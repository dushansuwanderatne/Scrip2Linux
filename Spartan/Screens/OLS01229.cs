using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01229

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01229", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Ranges1 = new WinFormsField("RANGES1", "Ranges1");
        public static WinFormsField Ranges2 = new WinFormsField("RANGES2", "Ranges2");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
