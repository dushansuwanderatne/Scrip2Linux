using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDSCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDSCH01", "FormName");
		//Fields
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Price = new WinFormsField("PRICE", "Price");
        public static WinFormsField LimitPriceInd = new WinFormsField("LIMIT-PRICE-IND", "LimitPriceInd");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField TransCount = new WinFormsField("TRANS-COUNT", "TransCount");
        public static WinFormsField TransTotal = new WinFormsField("TRANS-TOTAL", "TransTotal");
        public static WinFormsField MoneyTotal = new WinFormsField("MONEY-TOTAL", "MoneyTotal");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField ApplyTaxInd = new WinFormsField("APPLY-TAX-IND", "ApplyTaxInd");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
