using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10902

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10902", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ReplacementDate = new WinFormsField("REPLACEMENT-DATE", "ReplacementDate");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PayOrigRef = new WinFormsField("PAY-ORIG-REF", "PayOrigRef");
        public static WinFormsField PaymentAmount = new WinFormsField("PAYMENT-AMOUNT", "PaymentAmount");
        public static WinFormsField ReplacementMethod = new WinFormsField("REPLACEMENT-METHOD", "ReplacementMethod");
        public static WinFormsField PayReplaceRef = new WinFormsField("PAY-REPLACE-REF", "PayReplaceRef");
        public static WinFormsField WarningMessage = new WinFormsField("WARNING-MESSAGE", "WarningMessage");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
