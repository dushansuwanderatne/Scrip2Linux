using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESVWAP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESVWAP01", "FormName");
		//Fields


        public static WinFormsField EsvwapKey0 = new WinFormsField("ESVWAP-KEY0", "EsvwapKey0");
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField VwapDate = new WinFormsField("VWAP-DATE", "VwapDate");
        public static WinFormsField TradingDayInd = new WinFormsField("TRADING-DAY-IND", "TradingDayInd");
        //public static WinFormsField 1dayVwap = new WinFormsField("1DAY-VWAP", "1dayVwap");
        //public static WinFormsField 1dayTradeVolume = new WinFormsField("1DAY-TRADE-VOLUME", "1dayTradeVolume");
        public static WinFormsField MultiDayVwap = new WinFormsField("MULTI-DAY-VWAP", "MultiDayVwap");
        public static WinFormsField MarketValue = new WinFormsField("MARKET-VALUE", "MarketValue");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField Source = new WinFormsField("SOURCE", "Source");
        public static WinFormsField DateUpdated = new WinFormsField("DATE-UPDATED", "DateUpdated");
        public static WinFormsField TimeUpdated = new WinFormsField("TIME-UPDATED", "TimeUpdated");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
