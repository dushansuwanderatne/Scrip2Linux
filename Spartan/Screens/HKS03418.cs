using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03418

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03418", "FormName");
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
        public static WinFormsField WireTraceBsb = new WinFormsField("WIRE-TRACE-BSB", "WireTraceBsb");
        public static WinFormsField WireTraceAccount = new WinFormsField("WIRE-TRACE-ACCOUNT", "WireTraceAccount");
        public static WinFormsField WireRemitterName = new WinFormsField("WIRE-REMITTER-NAME", "WireRemitterName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
