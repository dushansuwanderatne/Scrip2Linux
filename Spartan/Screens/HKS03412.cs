using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03412

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03412", "FormName");
		//Fields


        public static WinFormsField BulkPayCode = new WinFormsField("BULK-PAY-CODE", "BulkPayCode");
        public static WinFormsField BulkPayDesc = new WinFormsField("BULK-PAY-DESC", "BulkPayDesc");
        public static WinFormsField BulkPayHolder = new WinFormsField("BULK-PAY-HOLDER", "BulkPayHolder");
        public static WinFormsField CurrencyFlag = new WinFormsField("CURRENCY-FLAG", "CurrencyFlag");
        public static WinFormsField BulkPayType = new WinFormsField("BULK-PAY-TYPE", "BulkPayType");
        public static WinFormsField ListRequired = new WinFormsField("LIST-REQUIRED", "ListRequired");
        public static WinFormsField ConvertCurrency = new WinFormsField("CONVERT-CURRENCY", "ConvertCurrency");
        public static WinFormsField FchqBankSystem = new WinFormsField("FCHQ-BANK-SYSTEM", "FchqBankSystem");
        public static WinFormsField FchqTraceBankType = new WinFormsField("FCHQ-TRACE-BANK-TYPE", "FchqTraceBankType");
        public static WinFormsField FchqTraceBankCode = new WinFormsField("FCHQ-TRACE-BANK-CODE", "FchqTraceBankCode");
        public static WinFormsField FchqGcnCode = new WinFormsField("FCHQ-GCN-CODE", "FchqGcnCode");
        public static WinFormsField FchqTraceAccount = new WinFormsField("FCHQ-TRACE-ACCOUNT", "FchqTraceAccount");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}