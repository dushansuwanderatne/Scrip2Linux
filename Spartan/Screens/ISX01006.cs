using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01006", "FormName");
		//Fields


        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
