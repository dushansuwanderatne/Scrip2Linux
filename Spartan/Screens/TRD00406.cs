using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00406

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00406", "FormName");
		//Fields


        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingTypeDesc = new WinFormsField("TRADING-TYPE-DESC", "TradingTypeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField Money = new WinFormsField("MONEY", "Money");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField OrderTypeDesc = new WinFormsField("ORDER-TYPE-DESC", "OrderTypeDesc");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField DurationType = new WinFormsField("DURATION-TYPE", "DurationType");
        public static WinFormsField Duration = new WinFormsField("DURATION", "Duration");
        public static WinFormsField FinalFlag = new WinFormsField("FINAL-FLAG", "FinalFlag");
        public static WinFormsField OrderStatus = new WinFormsField("ORDER-STATUS", "OrderStatus");
        public static WinFormsField DateSent = new WinFormsField("DATE-SENT", "DateSent");
        public static WinFormsField TimeSentHH = new WinFormsField("TIME-SENT-HH", "TimeSentHH");
        public static WinFormsField TimeSentMM = new WinFormsField("TIME-SENT-MM", "TimeSentMM");
        public static WinFormsField TimeSentSS = new WinFormsField("TIME-SENT-SS", "TimeSentSS");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField TradeAccount = new WinFormsField("TRADE-ACCOUNT", "TradeAccount");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SuppressOrmsMessage = new WinFormsField("SUPPRESS-ORMS-MESSAGE", "SuppressOrmsMessage");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
