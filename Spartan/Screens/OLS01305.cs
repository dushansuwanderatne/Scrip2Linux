using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01305

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01305", "FormName");
		//Fields
        public static WinFormsField BankCodeUsa = new WinFormsField("BANK-CODE-USA", "BankCodeUsa");
        public static WinFormsField BankAccountUsa = new WinFormsField("BANK-ACCOUNT-USA", "BankAccountUsa");
        public static WinFormsField BankAccountType = new WinFormsField("BANK-ACCOUNT-TYPE", "BankAccountType");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
