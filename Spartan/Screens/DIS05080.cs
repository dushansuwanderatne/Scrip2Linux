using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIS05080

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIS05080", "FormName");
		//Fields


        public static WinFormsField AuthorisationRef = new WinFormsField("AUTHORISATION-REF", "AuthorisationRef");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
