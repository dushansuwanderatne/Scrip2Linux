using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDDCD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDDCD01", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField PayeeAccountNumX = new WinFormsField("PAYEE-ACCOUNT-NUM-X", "PayeeAccountNumX");
        public static WinFormsField PayeeAccountType = new WinFormsField("PAYEE-ACCOUNT-TYPE", "PayeeAccountType");
        public static WinFormsField PayeeAccountName = new WinFormsField("PAYEE-ACCOUNT-NAME", "PayeeAccountName");
        public static WinFormsField RequiredCurrency = new WinFormsField("REQUIRED-CURRENCY", "RequiredCurrency");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
