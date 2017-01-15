using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS11001
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS11001", "FormName");
        //Fields
        public static WinFormsField OutstandingUnpres = new WinFormsField("OUTSTANDING-UNPRES", "OutstandingUnpres");
        public static WinFormsField PayAccountNumber1 = new WinFormsField("PAY-ACCOUNT-NUMBER1", "PayAccountNumber1");
        public static WinFormsField PayAccountNumber2 = new WinFormsField("PAY-ACCOUNT-NUMBER2", "PayAccountNumber2");
        public static WinFormsField PayAccountNumber3 = new WinFormsField("PAY-ACCOUNT-NUMBER3", "PayAccountNumber3");
        public static WinFormsField PayAccountNumber4 = new WinFormsField("PAY-ACCOUNT-NUMBER4", "PayAccountNumber4");
        public static WinFormsField PayAccountNumber5 = new WinFormsField("PAY-ACCOUNT-NUMBER5", "PayAccountNumber5");
        public static WinFormsField PayAccountNumber6 = new WinFormsField("PAY-ACCOUNT-NUMBER6", "PayAccountNumber6");
        public static WinFormsField PayAccountNumber7 = new WinFormsField("PAY-ACCOUNT-NUMBER7", "PayAccountNumber7");
        public static WinFormsField PayAccountNumber8 = new WinFormsField("PAY-ACCOUNT-NUMBER8", "PayAccountNumber8");
        public static WinFormsField PayAccountNumber9 = new WinFormsField("PAY-ACCOUNT-NUMBER9", "PayAccountNumber9");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PaymentCurr = new WinFormsField("PAYMENT-CURR", "PaymentCurr");
        public static WinFormsField PaymentAmountFrom = new WinFormsField("PAYMENT-AMOUNT-FROM", "PaymentAmountFrom");
        public static WinFormsField PaymentAmountTO = new WinFormsField("PAYMENT-AMOUNT-TO", "PaymentAmountTO");
        public static WinFormsField TaxSelectionYN = new WinFormsField("TAX-SELECTION-YN", "TaxSelectionYN");
        public static WinFormsField UseInputFile = new WinFormsField("USE-INPUT-FILE", "UseInputFile");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}