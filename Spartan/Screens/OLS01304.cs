using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01304", "FormName");
		//Fields
        public static WinFormsField BankCodeNzl1to2 = new WinFormsField("BANK-CODE-NZL-1TO2", "BankCodeNzl1to2");
        public static WinFormsField BankCodeNzl3to6 = new WinFormsField("BANK-CODE-NZL-3TO6", "BankCodeNzl3to6");
        public static WinFormsField BankAccountNzl1to7 = new WinFormsField("BANK-ACCOUNT-NZL-1TO7", "BankAccountNzl1to7");
        public static WinFormsField BankAccountNzl8to10 = new WinFormsField("BANK-ACCOUNT-NZL-8TO10", "BankAccountNzl8to10");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
