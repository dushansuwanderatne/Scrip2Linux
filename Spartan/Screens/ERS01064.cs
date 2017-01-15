using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01064

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01064", "FormName");
		//Fields
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
