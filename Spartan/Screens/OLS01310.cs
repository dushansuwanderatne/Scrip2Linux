using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01310

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01310", "FormName");
		//Fields


        public static WinFormsField InstructionType = new WinFormsField("INSTRUCTION-TYPE", "InstructionType");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCodeLit = new WinFormsField("BANK-CODE-LIT", "BankCodeLit");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumberOutput = new WinFormsField("ACCOUNT-NUMBER-OUTPUT", "AccountNumberOutput");
        public static WinFormsField BankAccountType = new WinFormsField("BANK-ACCOUNT-TYPE", "BankAccountType");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
