using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00402

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00402", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingTypeDesc = new WinFormsField("TRADING-TYPE-DESC", "TradingTypeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField ConfirmStatus = new WinFormsField("CONFIRM-STATUS", "ConfirmStatus");
        public static WinFormsField NewStatusDesc = new WinFormsField("NEW-STATUS-DESC", "NewStatusDesc");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField TradeTimeHH = new WinFormsField("TRADE-TIME-HH", "TradeTimeHH");
        public static WinFormsField TradeTimeMM = new WinFormsField("TRADE-TIME-MM", "TradeTimeMM");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField BackdatingIntended = new WinFormsField("BACKDATING-INTENDED", "BackdatingIntended");
        public static WinFormsField EffectiveRun = new WinFormsField("EFFECTIVE-RUN", "EffectiveRun");
        public static WinFormsField ActualSettlementDate = new WinFormsField("ACTUAL-SETTLEMENT-DATE", "ActualSettlementDate");
        public static WinFormsField ActualSettlementRun = new WinFormsField("ACTUAL-SETTLEMENT-RUN", "ActualSettlementRun");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField PriceATAudit = new WinFormsField("PRICE-AT-AUDIT", "PriceATAudit");
        public static WinFormsField PriceATAuditType = new WinFormsField("PRICE-AT-AUDIT-TYPE", "PriceATAuditType");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField PriceBase = new WinFormsField("PRICE-BASE", "PriceBase");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField LatestSharePrice = new WinFormsField("LATEST-SHARE-PRICE", "LatestSharePrice");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField IsinNumber = new WinFormsField("ISIN-NUMBER", "IsinNumber");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField CutOffDate = new WinFormsField("CUT-OFF-DATE", "CutOffDate");
        public static WinFormsField ExecVenue = new WinFormsField("EXEC-VENUE", "ExecVenue");
        public static WinFormsField CutOffHH = new WinFormsField("CUT-OFF-HH", "CutOffHH");
        public static WinFormsField CutOffMM = new WinFormsField("CUT-OFF-MM", "CutOffMM");
        public static WinFormsField MultiExecVenueInd = new WinFormsField("MULTI-EXEC-VENUE-IND", "MultiExecVenueInd");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField ResendTradefill = new WinFormsField("RESEND-TRADEFILL", "ResendTradefill");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField OrderStatus = new WinFormsField("ORDER-STATUS", "OrderStatus");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField ApplyTax = new WinFormsField("APPLY-TAX", "ApplyTax");
        public static WinFormsField MessageTOOrms = new WinFormsField("MESSAGE-TO-ORMS", "MessageTOOrms");
        public static WinFormsField CancellationOrms = new WinFormsField("CANCELLATION-ORMS", "CancellationOrms");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
