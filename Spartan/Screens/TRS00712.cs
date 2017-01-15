using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00712

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00712", "FormName");
		//Fields


        public static WinFormsField OverrideMobileInd = new WinFormsField("OVERRIDE-MOBILE-IND", "OverrideMobileInd");
        public static WinFormsField MobilePhone = new WinFormsField("MOBILE-PHONE", "MobilePhone");
        public static WinFormsField OverrideEmailInd = new WinFormsField("OVERRIDE-EMAIL-IND", "OverrideEmailInd");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
