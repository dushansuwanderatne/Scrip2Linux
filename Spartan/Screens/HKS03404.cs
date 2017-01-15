using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03404", "FormName");
		//Fields


        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField BulkPayHolder = new WinFormsField("BULK-PAY-HOLDER", "BulkPayHolder");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField BulkPayType = new WinFormsField("BULK-PAY-TYPE", "BulkPayType");
        public static WinFormsField ListRequired = new WinFormsField("LIST-REQUIRED", "ListRequired");
        public static WinFormsField ConvertCurrency = new WinFormsField("CONVERT-CURRENCY", "ConvertCurrency");
        public static WinFormsField PaidCurrency = new WinFormsField("PAID-CURRENCY", "PaidCurrency");
        public static WinFormsField PaidCurrencyDesc = new WinFormsField("PAID-CURRENCY-DESC", "PaidCurrencyDesc");
        public static WinFormsField BankDetKnownInd = new WinFormsField("BANK-DET-KNOWN-IND", "BankDetKnownInd");
        public static WinFormsField NzlPayDesc = new WinFormsField("NZL-PAY-DESC", "NzlPayDesc");
        public static WinFormsField NzlBank = new WinFormsField("NZL-BANK", "NzlBank");
        public static WinFormsField NzlBranch = new WinFormsField("NZL-BRANCH", "NzlBranch");
        public static WinFormsField NzlAccount = new WinFormsField("NZL-ACCOUNT", "NzlAccount");
        public static WinFormsField NzlSuffix = new WinFormsField("NZL-SUFFIX", "NzlSuffix");
        public static WinFormsField NzlRemitterName = new WinFormsField("NZL-REMITTER-NAME", "NzlRemitterName");
        public static WinFormsField PseudoCode = new WinFormsField("PSEUDO-CODE", "PseudoCode");
        public static WinFormsField NzlEftUserID = new WinFormsField("NZL-EFT-USER-ID", "NzlEftUserID");
        public static WinFormsField NzlDiffTraceAcct = new WinFormsField("NZL-DIFF-TRACE-ACCT", "NzlDiffTraceAcct");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
