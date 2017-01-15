using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00101", "FormName");
		//Fields
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField OrderNO = new WinFormsField("ORDER-NO", "OrderNO");
        public static WinFormsField Ident = new WinFormsField("IDENT", "Ident");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField NbrTrades = new WinFormsField("NBR-TRADES", "NbrTrades");
        public static WinFormsField TradeGrossAmount = new WinFormsField("TRADE-GROSS-AMOUNT", "TradeGrossAmount");
        public static WinFormsField TradeFrom = new WinFormsField("TRADE-FROM", "TradeFrom");
        public static WinFormsField TradeTO = new WinFormsField("TRADE-TO", "TradeTO");
        public static WinFormsField SettlementFrom = new WinFormsField("SETTLEMENT-FROM", "SettlementFrom");
        public static WinFormsField SettlementTO = new WinFormsField("SETTLEMENT-TO", "SettlementTO");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
