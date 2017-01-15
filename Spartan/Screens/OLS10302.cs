using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS10302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS10302", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PayRefNumber = new WinFormsField("PAY-REF-NUMBER", "PayRefNumber");
        public static WinFormsField PaymentAmount = new WinFormsField("PAYMENT-AMOUNT", "PaymentAmount");
        public static WinFormsField PayOrigHolderIdent = new WinFormsField("PAY-ORIG-HOLDER-IDENT", "PayOrigHolderIdent");
        public static WinFormsField NewHolderIdentifier = new WinFormsField("NEW-HOLDER-IDENTIFIER", "NewHolderIdentifier");
        public static WinFormsField NewHnaLine = new WinFormsField("NEW-HNA-LINE", "NewHnaLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
