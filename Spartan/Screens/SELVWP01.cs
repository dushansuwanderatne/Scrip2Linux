using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELVWP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELVWP01", "FormName");
		//Fields
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField MultiDayHdg = new WinFormsField("MULTI-DAY-HDG", "MultiDayHdg");
        public static WinFormsField Highlight = new WinFormsField("HIGHLIGHT", "Highlight");
        public static WinFormsField VwapDate = new WinFormsField("VWAP-DATE", "VwapDate");
        public static WinFormsField day1Vwap = new WinFormsField("1DAY-VWAP", "1dayVwap");
        public static WinFormsField MultiDayVwap = new WinFormsField("MULTI-DAY-VWAP", "MultiDayVwap");
        public static WinFormsField day1TradeVolume = new WinFormsField("1DAY-TRADE-VOLUME", "1dayTradeVolume");
        public static WinFormsField ClosingPrice = new WinFormsField("CLOSING-PRICE", "ClosingPrice");
        public static WinFormsField MoreComment = new WinFormsField("MORE-COMMENT", "MoreComment");
        public static WinFormsField InputAction = new WinFormsField("INPUT-ACTION", "InputAction");
    }
}
