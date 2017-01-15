using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS03025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS03025", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MparcelClass = new WinFormsField("MPARCEL-CLASS", "MparcelClass");
        public static WinFormsField MparcelClassGroup = new WinFormsField("MPARCEL-CLASS-GROUP", "MparcelClassGroup");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
