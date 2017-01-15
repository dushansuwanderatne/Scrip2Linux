using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01103", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField PayeeAddressLine = new WinFormsField("PAYEE-ADDRESS-LINE", "PayeeAddressLine");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField UpdateOption = new WinFormsField("UPDATE-OPTION", "UpdateOption");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
        public static WinFormsField AccountNumberOutput = new WinFormsField("ACCOUNT-NUMBER-OUTPUT", "AccountNumberOutput");
        public static WinFormsField BankAccountType = new WinFormsField("BANK-ACCOUNT-TYPE", "BankAccountType");
        public static WinFormsField BankCodeLit = new WinFormsField("BANK-CODE-LIT", "BankCodeLit");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
