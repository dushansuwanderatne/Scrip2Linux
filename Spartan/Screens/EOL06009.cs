using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL06009

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL06009", "FormName");
		//Fields


        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField ConfirmInd = new WinFormsField("CONFIRM-IND", "ConfirmInd");
        public static WinFormsField CertIdentifier = new WinFormsField("CERT-IDENTIFIER", "CertIdentifier");
        public static WinFormsField OrigBal = new WinFormsField("ORIG-BAL", "OrigBal");
        public static WinFormsField CurrBal = new WinFormsField("CURR-BAL", "CurrBal");
    }
}
