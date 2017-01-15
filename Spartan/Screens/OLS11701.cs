using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS11701", "FormName");
		//Fields


        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField PaymentCurrency = new WinFormsField("PAYMENT-CURRENCY", "PaymentCurrency");
        public static WinFormsField ApprovedCountBank = new WinFormsField("APPROVED-COUNT-BANK", "ApprovedCountBank");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField ApprovedAmountBank = new WinFormsField("APPROVED-AMOUNT-BANK", "ApprovedAmountBank");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField BankAccount = new WinFormsField("BANK-ACCOUNT", "BankAccount");
        public static WinFormsField HeaderRemitterName = new WinFormsField("HEADER-REMITTER-NAME", "HeaderRemitterName");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField TransDateFrom = new WinFormsField("TRANS-DATE-FROM", "TransDateFrom");
        public static WinFormsField TransDateTO = new WinFormsField("TRANS-DATE-TO", "TransDateTO");
        public static WinFormsField PaymentDate = new WinFormsField("PAYMENT-DATE", "PaymentDate");
        public static WinFormsField PaymentDesc = new WinFormsField("PAYMENT-DESC", "PaymentDesc");
        public static WinFormsField TransRemitterName = new WinFormsField("TRANS-REMITTER-NAME", "TransRemitterName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
