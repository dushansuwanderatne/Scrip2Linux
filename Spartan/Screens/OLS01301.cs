using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01301", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNbrI = new WinFormsField("TRANS-NBR-I", "TransNbrI");
        public static WinFormsField TransDateI = new WinFormsField("TRANS-DATE-I", "TransDateI");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField InstructionType = new WinFormsField("INSTRUCTION-TYPE", "InstructionType");
        public static WinFormsField InstructionType2 = new WinFormsField("INSTRUCTION-TYPE-2", "InstructionType2");
        public static WinFormsField PayeeAddressLine = new WinFormsField("PAYEE-ADDRESS-LINE", "PayeeAddressLine");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField RequiredCurrency = new WinFormsField("REQUIRED-CURRENCY", "RequiredCurrency");
        public static WinFormsField BankCodeLit = new WinFormsField("BANK-CODE-LIT", "BankCodeLit");
        public static WinFormsField BankCodeOutput = new WinFormsField("BANK-CODE-OUTPUT", "BankCodeOutput");
        public static WinFormsField AccountNumberLit = new WinFormsField("ACCOUNT-NUMBER-LIT", "AccountNumberLit");
        public static WinFormsField AccountNumberOutput = new WinFormsField("ACCOUNT-NUMBER-OUTPUT", "AccountNumberOutput");
        public static WinFormsField BankAccountType = new WinFormsField("BANK-ACCOUNT-TYPE", "BankAccountType");
        public static WinFormsField AccountNameLit = new WinFormsField("ACCOUNT-NAME-LIT", "AccountNameLit");
        public static WinFormsField AccountNameOut = new WinFormsField("ACCOUNT-NAME-OUT", "AccountNameOut");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionDesc = new WinFormsField("ACTION-DESC", "ActionDesc");
        public static WinFormsField Action2 = new WinFormsField("ACTION-2", "Action2");
        public static WinFormsField Action3 = new WinFormsField("ACTION-3", "Action3");
        public static WinFormsField ActionDesc2 = new WinFormsField("ACTION-DESC-2", "ActionDesc2");
        public static WinFormsField Confirm2 = new WinFormsField("CONFIRM-2", "Confirm2");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
