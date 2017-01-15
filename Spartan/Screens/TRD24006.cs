using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD24006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD24006", "FormName");
		//Fields
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CounterpartyReqd = new WinFormsField("COUNTERPARTY-REQD", "CounterpartyReqd");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField CounterpartyRegister = new WinFormsField("COUNTERPARTY-REGISTER", "CounterpartyRegister");
        public static WinFormsField CounterTrantypeCode = new WinFormsField("COUNTER-TRANTYPE-CODE", "CounterTrantypeCode");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField ONMarketTradeInd = new WinFormsField("ON-MARKET-TRADE-IND", "ONMarketTradeInd");
        public static WinFormsField DPBrokerCode = new WinFormsField("DP-BROKER-CODE", "DPBrokerCode");
        public static WinFormsField DPTradeAccount = new WinFormsField("DP-TRADE-ACCOUNT", "DPTradeAccount");
        public static WinFormsField DPConnectionTO = new WinFormsField("DP-CONNECTION-TO", "DPConnectionTO");
        public static WinFormsField RealTimeTrading = new WinFormsField("REAL-TIME-TRADING", "RealTimeTrading");
        public static WinFormsField DPOrderType = new WinFormsField("DP-ORDER-TYPE", "DPOrderType");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
