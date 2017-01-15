using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB80

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB80", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PasswordOutput = new WinFormsField("PASSWORD-OUTPUT", "PasswordOutput");
        public static WinFormsField PasswordInput = new WinFormsField("PASSWORD-INPUT", "PasswordInput");
    }
}
