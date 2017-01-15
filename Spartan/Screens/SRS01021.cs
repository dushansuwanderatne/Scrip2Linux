using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField Hin = new WinFormsField("HIN", "Hin");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
    }
}
