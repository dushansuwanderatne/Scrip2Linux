using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS01011", "FormName");
		//Fields


        public static WinFormsField ConfirmWarning = new WinFormsField("CONFIRM-WARNING", "ConfirmWarning");
    }
}
