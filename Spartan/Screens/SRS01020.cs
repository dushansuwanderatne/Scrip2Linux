using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
    }
}
