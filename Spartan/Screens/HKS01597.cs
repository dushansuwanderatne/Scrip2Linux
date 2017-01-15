using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01597

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01597", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField WarnLine = new WinFormsField("WARN-LINE", "WarnLine");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
