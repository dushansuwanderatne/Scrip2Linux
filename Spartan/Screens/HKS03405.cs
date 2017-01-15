using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03405

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03405", "FormName");
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
        public static WinFormsField DcbUserNum = new WinFormsField("DCB-USER-NUM", "DcbUserNum");
        public static WinFormsField GbrTrace1to2 = new WinFormsField("GBR-TRACE-1TO2", "GbrTrace1to2");
        public static WinFormsField GbrTrace3to4 = new WinFormsField("GBR-TRACE-3TO4", "GbrTrace3to4");
        public static WinFormsField GbrTrace5to6 = new WinFormsField("GBR-TRACE-5TO6", "GbrTrace5to6");
        public static WinFormsField GbrTraceAccount = new WinFormsField("GBR-TRACE-ACCOUNT", "GbrTraceAccount");
        public static WinFormsField GbrRemitterName = new WinFormsField("GBR-REMITTER-NAME", "GbrRemitterName");
        public static WinFormsField PseudoCode = new WinFormsField("PSEUDO-CODE", "PseudoCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField AddKey = new WinFormsField("ADD-KEY", "AddKey");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
