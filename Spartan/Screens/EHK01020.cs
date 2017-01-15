using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01020", "FormName");
		//Fields
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField VwapDate = new WinFormsField("VWAP-DATE", "VwapDate");
        public static WinFormsField ExchangeCode = new WinFormsField("EXCHANGE-CODE", "ExchangeCode");
        public static WinFormsField OnedayVwap = new WinFormsField("1DAY-VWAP", "1dayVwap");
        public static WinFormsField OnedayTradeVolume = new WinFormsField("1DAY-TRADE-VOLUME", "1dayTradeVolume");
        public static WinFormsField MultiDayVwap = new WinFormsField("MULTI-DAY-VWAP", "MultiDayVwap");
        public static WinFormsField MultiDayVwapDesc = new WinFormsField("MULTI-DAY-VWAP-DESC", "MultiDayVwapDesc");
        public static WinFormsField ClosingPrice = new WinFormsField("CLOSING-PRICE", "ClosingPrice");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField ConversionRate = new WinFormsField("CONVERSION-RATE", "ConversionRate");
        public static WinFormsField TradingDayInd = new WinFormsField("TRADING-DAY-IND", "TradingDayInd");
        public static WinFormsField LastUpdatedBY = new WinFormsField("LAST-UPDATED-BY", "LastUpdatedBY");
        public static WinFormsField LastUpdatedBYDate = new WinFormsField("LAST-UPDATED-BY-DATE", "LastUpdatedBYDate");
        public static WinFormsField LastUpdatedBYTime = new WinFormsField("LAST-UPDATED-BY-TIME", "LastUpdatedBYTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField Ehk01020LocateClass = new WinFormsField("EHK01020-LOCATE-CLASS", "Ehk01020LocateClass");
        public static WinFormsField Ehk01020LocateVwapDate = new WinFormsField("EHK01020-LOCATE-VWAP-DATE", "Ehk01020LocateVwapDate");
        public static WinFormsField Ehk01020LocateExcCode = new WinFormsField("EHK01020-LOCATE-EXC-CODE", "Ehk01020LocateExcCode");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
