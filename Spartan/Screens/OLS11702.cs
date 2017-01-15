using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11702

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11702", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField HomeBankDesc = new WinFormsField("HOME-BANK-DESC", "HomeBankDesc");
        public static WinFormsField TraceBsb = new WinFormsField("TRACE-BSB", "TraceBsb");
        public static WinFormsField TraceAccount = new WinFormsField("TRACE-ACCOUNT", "TraceAccount");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField CemtexUserNum = new WinFormsField("CEMTEX-USER-NUM", "CemtexUserNum");
        public static WinFormsField ApprovedCountBank = new WinFormsField("APPROVED-COUNT-BANK", "ApprovedCountBank");
        public static WinFormsField ApprovedAmountBank = new WinFormsField("APPROVED-AMOUNT-BANK", "ApprovedAmountBank");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
