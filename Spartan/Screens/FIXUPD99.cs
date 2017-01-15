using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPD99

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPD99", "FormName");
		//Fields


        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
