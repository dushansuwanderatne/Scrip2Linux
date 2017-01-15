using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05098

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS05098", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField XtrName = new WinFormsField("XTR-NAME", "XtrName");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
