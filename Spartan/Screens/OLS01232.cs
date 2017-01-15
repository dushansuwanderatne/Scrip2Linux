using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01232

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01232", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        public static WinFormsField ConfirmAccountID = new WinFormsField("CONFIRM-ACCOUNT-ID", "ConfirmAccountID");
    }
}
