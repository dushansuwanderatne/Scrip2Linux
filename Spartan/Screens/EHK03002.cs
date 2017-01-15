using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK03002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK03002", "FormName");
		//Fields


        public static WinFormsField ErrorMessage = new WinFormsField("ERROR-MESSAGE", "ErrorMessage");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
