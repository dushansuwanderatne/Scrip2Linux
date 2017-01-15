using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS42

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS42", "FormName");
		//Fields
        public static WinFormsField EventAccNumber = new WinFormsField("EVENT-ACC-NUMBER", "EventAccNumber");
        public static WinFormsField EventAccName = new WinFormsField("EVENT-ACC-NAME", "EventAccName");
        public static WinFormsField EventBankDetails = new WinFormsField("EVENT-BANK-DETAILS", "EventBankDetails");
    }
}
