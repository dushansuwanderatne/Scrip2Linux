using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG02506

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG02506", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RepliedDate = new WinFormsField("REPLIED-DATE", "RepliedDate");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
