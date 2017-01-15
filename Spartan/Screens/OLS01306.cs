using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01306

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01306", "FormName");
		//Fields
        public static WinFormsField BankCodeGbr1to2 = new WinFormsField("BANK-CODE-GBR-1TO2", "BankCodeGbr1to2");
        public static WinFormsField BankCodeGbr3to4 = new WinFormsField("BANK-CODE-GBR-3TO4", "BankCodeGbr3to4");
        public static WinFormsField BankCodeGbr5to6 = new WinFormsField("BANK-CODE-GBR-5TO6", "BankCodeGbr5to6");
        public static WinFormsField BankAccountGbrNum = new WinFormsField("BANK-ACCOUNT-GBR-NUM", "BankAccountGbrNum");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
