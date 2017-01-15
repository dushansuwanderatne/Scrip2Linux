using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS14

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS14", "FormName");
		//Fields
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField Usan = new WinFormsField("USAN", "Usan");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField RegType = new WinFormsField("REG-TYPE", "RegType");
        public static WinFormsField TradeRef = new WinFormsField("TRADE-REF", "TradeRef");
        public static WinFormsField Run = new WinFormsField("RUN", "Run");
        public static WinFormsField Trans = new WinFormsField("TRANS", "Trans");
        public static WinFormsField NicAmount = new WinFormsField("NIC-AMOUNT", "NicAmount");
        public static WinFormsField SeqNbr = new WinFormsField("SEQ-NBR", "SeqNbr");
        public static WinFormsField PayAmt = new WinFormsField("PAY-AMT", "PayAmt");
        public static WinFormsField Ensess14EmpBaseCurr = new WinFormsField("ENSESS14-EMP-BASE-CURR", "Ensess14EmpBaseCurr");
        public static WinFormsField EmployerPayAmt = new WinFormsField("EMPLOYER-PAY-AMT", "EmployerPayAmt");
        public static WinFormsField Ensess14CoyBaseCurr = new WinFormsField("ENSESS14-COY-BASE-CURR", "Ensess14CoyBaseCurr");
        public static WinFormsField AccumPeriod = new WinFormsField("ACCUM-PERIOD", "AccumPeriod");
        public static WinFormsField Residue = new WinFormsField("RESIDUE", "Residue");
        public static WinFormsField PaymentNbr = new WinFormsField("PAYMENT-NBR", "PaymentNbr");
        public static WinFormsField TaxAmount = new WinFormsField("TAX-AMOUNT", "TaxAmount");
        public static WinFormsField MarketValue = new WinFormsField("MARKET-VALUE", "MarketValue");
        public static WinFormsField Shares = new WinFormsField("SHARES", "Shares");
        public static WinFormsField Unmatched = new WinFormsField("UNMATCHED", "Unmatched");
        public static WinFormsField Ensess14ExchangeRate = new WinFormsField("ENSESS14-EXCHANGE-RATE", "Ensess14ExchangeRate");
        public static WinFormsField Ensess14EmpReceiptAmt = new WinFormsField("ENSESS14-EMP-RECEIPT-AMT", "Ensess14EmpReceiptAmt");
        public static WinFormsField Ensess14EmpReceiptCurr = new WinFormsField("ENSESS14-EMP-RECEIPT-CURR", "Ensess14EmpReceiptCurr");
        public static WinFormsField Ensess14CoyReceiptAmt = new WinFormsField("ENSESS14-COY-RECEIPT-AMT", "Ensess14CoyReceiptAmt");
        public static WinFormsField Ensess14CoyReceiptCurr = new WinFormsField("ENSESS14-COY-RECEIPT-CURR", "Ensess14CoyReceiptCurr");
    }
}
