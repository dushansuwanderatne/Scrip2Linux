using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDSCH02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDSCH02", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField BulkType = new WinFormsField("BULK-TYPE", "BulkType");
        public static WinFormsField BulkTypeDesc = new WinFormsField("BULK-TYPE-DESC", "BulkTypeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField OrderTransUnits = new WinFormsField("ORDER-TRANS-UNITS", "OrderTransUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField TradeTime = new WinFormsField("TRADE-TIME", "TradeTime");
        public static WinFormsField DateDeleted = new WinFormsField("DATE-DELETED", "DateDeleted");
        public static WinFormsField UserMsgid = new WinFormsField("USER-MSGID", "UserMsgid");
        public static WinFormsField BackdatingIntended = new WinFormsField("BACKDATING-INTENDED", "BackdatingIntended");
        public static WinFormsField EffectiveRun = new WinFormsField("EFFECTIVE-RUN", "EffectiveRun");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField ReqdSettlementDate = new WinFormsField("REQD-SETTLEMENT-DATE", "ReqdSettlementDate");
        public static WinFormsField CounterAddressLine = new WinFormsField("COUNTER-ADDRESS-LINE", "CounterAddressLine");
        public static WinFormsField ActualSettlementDate = new WinFormsField("ACTUAL-SETTLEMENT-DATE", "ActualSettlementDate");
        public static WinFormsField ActualSettlementRun = new WinFormsField("ACTUAL-SETTLEMENT-RUN", "ActualSettlementRun");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField ExecVenue = new WinFormsField("EXEC-VENUE", "ExecVenue");
        public static WinFormsField MultiExecVenueInd = new WinFormsField("MULTI-EXEC-VENUE-IND", "MultiExecVenueInd");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ReconciliationCode = new WinFormsField("RECONCILIATION-CODE", "ReconciliationCode");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField CshtrnReference = new WinFormsField("CSHTRN-REFERENCE", "CshtrnReference");
        public static WinFormsField SettledRunNumber = new WinFormsField("SETTLED-RUN-NUMBER", "SettledRunNumber");
        public static WinFormsField CounterTransNumber = new WinFormsField("COUNTER-TRANS-NUMBER", "CounterTransNumber");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField CutOffDate = new WinFormsField("CUT-OFF-DATE", "CutOffDate");
        public static WinFormsField CutOffTime = new WinFormsField("CUT-OFF-TIME", "CutOffTime");
        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField UnitsMoneyLabel = new WinFormsField("UNITS-MONEY-LABEL", "UnitsMoneyLabel");
        public static WinFormsField UnitsMoneyValue = new WinFormsField("UNITS-MONEY-VALUE", "UnitsMoneyValue");
        public static WinFormsField CosmosReturnStatus = new WinFormsField("COSMOS-RETURN-STATUS", "CosmosReturnStatus");
        public static WinFormsField DateSent = new WinFormsField("DATE-SENT", "DateSent");
        public static WinFormsField TimeSentHH = new WinFormsField("TIME-SENT-HH", "TimeSentHH");
        public static WinFormsField TimeSentMM = new WinFormsField("TIME-SENT-MM", "TimeSentMM");
        public static WinFormsField TimeSentSS = new WinFormsField("TIME-SENT-SS", "TimeSentSS");
        public static WinFormsField Trdsch02EventType = new WinFormsField("TRDSCH02-EVENT-TYPE", "Trdsch02EventType");
        public static WinFormsField Trdsch02EventCode = new WinFormsField("TRDSCH02-EVENT-CODE", "Trdsch02EventCode");
        public static WinFormsField DurationType = new WinFormsField("DURATION-TYPE", "DurationType");
        public static WinFormsField Duration = new WinFormsField("DURATION", "Duration");
        public static WinFormsField Trdsch02EventDate = new WinFormsField("TRDSCH02-EVENT-DATE", "Trdsch02EventDate");
        public static WinFormsField FinalFlag = new WinFormsField("FINAL-FLAG", "FinalFlag");
        public static WinFormsField OrderStatus = new WinFormsField("ORDER-STATUS", "OrderStatus");
        public static WinFormsField ApplyTaxInd = new WinFormsField("APPLY-TAX-IND", "ApplyTaxInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionU = new WinFormsField("ACTION-U", "ActionU");
        public static WinFormsField ActionMU = new WinFormsField("ACTION-MU", "ActionMU");
        public static WinFormsField ActionM = new WinFormsField("ACTION-M", "ActionM");
        public static WinFormsField SearchID = new WinFormsField("SEARCH-ID", "SearchID");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
