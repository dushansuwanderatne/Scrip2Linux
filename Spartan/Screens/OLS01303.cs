using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01303

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01303", "FormName");
		//Fields
        public static WinFormsField BankCodeAus1to3 = new WinFormsField("BANK-CODE-AUS-1TO3", "BankCodeAus1to3");
        public static WinFormsField BankCodeAus4to6 = new WinFormsField("BANK-CODE-AUS-4TO6", "BankCodeAus4to6");
        public static WinFormsField BankAccountAusNum = new WinFormsField("BANK-ACCOUNT-AUS-NUM", "BankAccountAusNum");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
