using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11706

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11706", "FormName");
		//Fields


        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField CurrencyDescription = new WinFormsField("CURRENCY-DESCRIPTION", "CurrencyDescription");
        public static WinFormsField UsaRoutingNumber = new WinFormsField("USA-ROUTING-NUMBER", "UsaRoutingNumber");
        public static WinFormsField UsaAccountNumber = new WinFormsField("USA-ACCOUNT-NUMBER", "UsaAccountNumber");
        public static WinFormsField UsaRemitterName = new WinFormsField("USA-REMITTER-NAME", "UsaRemitterName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
