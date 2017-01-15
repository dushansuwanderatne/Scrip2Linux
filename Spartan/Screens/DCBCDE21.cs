using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCBCDE21

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCBCDE21", "FormName");
		//Fields


        public static WinFormsField DcbcdeKey0 = new WinFormsField("DCBCDE-KEY0", "DcbcdeKey0");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField BulkPayHolder = new WinFormsField("BULK-PAY-HOLDER", "BulkPayHolder");
        public static WinFormsField BulkPayType = new WinFormsField("BULK-PAY-TYPE", "BulkPayType");
        public static WinFormsField NzlRemitterName = new WinFormsField("NZL-REMITTER-NAME", "NzlRemitterName");
        public static WinFormsField NzlBankAccount = new WinFormsField("NZL-BANK-ACCOUNT", "NzlBankAccount");
        public static WinFormsField NzlPayDesc = new WinFormsField("NZL-PAY-DESC", "NzlPayDesc");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField ListRequired = new WinFormsField("LIST-REQUIRED", "ListRequired");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField ConvertCurrency = new WinFormsField("CONVERT-CURRENCY", "ConvertCurrency");
        public static WinFormsField PseudoCode = new WinFormsField("PSEUDO-CODE", "PseudoCode");
        public static WinFormsField BankDetKnownInd = new WinFormsField("BANK-DET-KNOWN-IND", "BankDetKnownInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
