using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00903

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00903", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField WarningMessage = new WinFormsField("WARNING-MESSAGE", "WarningMessage");
    }
}
