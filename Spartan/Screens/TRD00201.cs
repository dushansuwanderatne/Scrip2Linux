using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00201", "FormName");
		//Fields
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField TradeTypeDesc = new WinFormsField("TRADE-TYPE-DESC", "TradeTypeDesc");
        public static WinFormsField DispClassCode = new WinFormsField("DISP-CLASS-CODE", "DispClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField DealLimitsMinimum = new WinFormsField("DEAL-LIMITS-MINIMUM", "DealLimitsMinimum");
        public static WinFormsField DealLimitsMaximum = new WinFormsField("DEAL-LIMITS-MAXIMUM", "DealLimitsMaximum");
        public static WinFormsField CutOffDate = new WinFormsField("CUT-OFF-DATE", "CutOffDate");
        public static WinFormsField CutOffHH = new WinFormsField("CUT-OFF-HH", "CutOffHH");
        public static WinFormsField CutOffMM = new WinFormsField("CUT-OFF-MM", "CutOffMM");
        public static WinFormsField ApplyTax = new WinFormsField("APPLY-TAX", "ApplyTax");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField CounterBrokerCode = new WinFormsField("COUNTER-BROKER-CODE", "CounterBrokerCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
