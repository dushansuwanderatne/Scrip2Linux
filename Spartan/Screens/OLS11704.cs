using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11704

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11704", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField CurrencyDescription = new WinFormsField("CURRENCY-DESCRIPTION", "CurrencyDescription");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField BsbNum1 = new WinFormsField("BSB-NUM1", "BsbNum1");
        public static WinFormsField BsbNum2 = new WinFormsField("BSB-NUM2", "BsbNum2");
        public static WinFormsField Account1 = new WinFormsField("ACCOUNT1", "Account1");
        public static WinFormsField Account2 = new WinFormsField("ACCOUNT2", "Account2");
        public static WinFormsField BatchNumber = new WinFormsField("BATCH-NUMBER", "BatchNumber");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
