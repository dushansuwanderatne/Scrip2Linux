using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPD98

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPD98", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
