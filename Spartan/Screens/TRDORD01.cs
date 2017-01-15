using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDORD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDORD01", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradingNumber = new WinFormsField("TRADING-NUMBER", "TradingNumber");
        public static WinFormsField TradingStatus = new WinFormsField("TRADING-STATUS", "TradingStatus");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingCodeKey1 = new WinFormsField("TRADING-CODE-KEY1", "TradingCodeKey1");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterBrokerCode = new WinFormsField("COUNTER-BROKER-CODE", "CounterBrokerCode");
        public static WinFormsField SettledRunNumber = new WinFormsField("SETTLED-RUN-NUMBER", "SettledRunNumber");
        public static WinFormsField CounterBrokerAccount = new WinFormsField("COUNTER-BROKER-ACCOUNT", "CounterBrokerAccount");
        public static WinFormsField LastTransNbrCompleted = new WinFormsField("LAST-TRANS-NBR-COMPLETED", "LastTransNbrCompleted");
        public static WinFormsField CounterTransNumber = new WinFormsField("COUNTER-TRANS-NUMBER", "CounterTransNumber");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField CounterpartyCertID = new WinFormsField("COUNTERPARTY-CERT-ID", "CounterpartyCertID");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField UnitBreakageRunNumber = new WinFormsField("UNIT-BREAKAGE-RUN-NUMBER", "UnitBreakageRunNumber");
        public static WinFormsField UnitBreakageTransNbr = new WinFormsField("UNIT-BREAKAGE-TRANS-NBR", "UnitBreakageTransNbr");
        public static WinFormsField DeletedRunNbr = new WinFormsField("DELETED-RUN-NBR", "DeletedRunNbr");
        public static WinFormsField CosmosReturnStatus = new WinFormsField("COSMOS-RETURN-STATUS", "CosmosReturnStatus");
        public static WinFormsField CashBreakageRunNumber = new WinFormsField("CASH-BREAKAGE-RUN-NUMBER", "CashBreakageRunNumber");
        public static WinFormsField DeletedDate = new WinFormsField("DELETED-DATE", "DeletedDate");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField CashBreakageTransNbr = new WinFormsField("CASH-BREAKAGE-TRANS-NBR", "CashBreakageTransNbr");
        public static WinFormsField DeletedMsgid = new WinFormsField("DELETED-MSGID", "DeletedMsgid");
        public static WinFormsField TotalDirectDebits = new WinFormsField("TOTAL-DIRECT-DEBITS", "TotalDirectDebits");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField CshtrnReference = new WinFormsField("CSHTRN-REFERENCE", "CshtrnReference");
        public static WinFormsField AddDate = new WinFormsField("ADD-DATE", "AddDate");
        public static WinFormsField DirectDebitProducedInd = new WinFormsField("DIRECT-DEBIT-PRODUCED-IND", "DirectDebitProducedInd");
        public static WinFormsField PriceATAudit = new WinFormsField("PRICE-AT-AUDIT", "PriceATAudit");
        public static WinFormsField PriceATAuditInd = new WinFormsField("PRICE-AT-AUDIT-IND", "PriceATAuditInd");
        public static WinFormsField AddMsgid = new WinFormsField("ADD-MSGID", "AddMsgid");
        public static WinFormsField IntendBackDateInd = new WinFormsField("INTEND-BACK-DATE-IND", "IntendBackDateInd");
        public static WinFormsField EffectiveRunNbr = new WinFormsField("EFFECTIVE-RUN-NBR", "EffectiveRunNbr");
        public static WinFormsField CutOffDate = new WinFormsField("CUT-OFF-DATE", "CutOffDate");
        public static WinFormsField CutOffTime = new WinFormsField("CUT-OFF-TIME", "CutOffTime");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField DPSequenceNumber = new WinFormsField("DP-SEQUENCE-NUMBER", "DPSequenceNumber");
        public static WinFormsField TransCount = new WinFormsField("TRANS-COUNT", "TransCount");
        public static WinFormsField PendingTradingStatus = new WinFormsField("PENDING-TRADING-STATUS", "PendingTradingStatus");
        public static WinFormsField DPUnits = new WinFormsField("DP-UNITS", "DPUnits");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField DPMoney = new WinFormsField("DP-MONEY", "DPMoney");
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField DPOrderType = new WinFormsField("DP-ORDER-TYPE", "DPOrderType");
        public static WinFormsField FirstTransNbr = new WinFormsField("FIRST-TRANS-NBR", "FirstTransNbr");
        public static WinFormsField LastTransNbr = new WinFormsField("LAST-TRANS-NBR", "LastTransNbr");
        public static WinFormsField DPLimitPrice = new WinFormsField("DP-LIMIT-PRICE", "DPLimitPrice");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField DPDurationType = new WinFormsField("DP-DURATION-TYPE", "DPDurationType");
        public static WinFormsField DPDuration = new WinFormsField("DP-DURATION", "DPDuration");
        public static WinFormsField BuyCertFrom = new WinFormsField("BUY-CERT-FROM", "BuyCertFrom");
        public static WinFormsField BuyCertTO = new WinFormsField("BUY-CERT-TO", "BuyCertTO");
        public static WinFormsField DPFinalFlag = new WinFormsField("DP-FINAL-FLAG", "DPFinalFlag");
        public static WinFormsField CertsProducedInd = new WinFormsField("CERTS-PRODUCED-IND", "CertsProducedInd");
        public static WinFormsField AdvicesProducedInd = new WinFormsField("ADVICES-PRODUCED-IND", "AdvicesProducedInd");
        public static WinFormsField DPOrderStatus = new WinFormsField("DP-ORDER-STATUS", "DPOrderStatus");
        public static WinFormsField TotalRemainingBal = new WinFormsField("TOTAL-REMAINING-BAL", "TotalRemainingBal");
        public static WinFormsField DPDateSent = new WinFormsField("DP-DATE-SENT", "DPDateSent");
        public static WinFormsField DPTimeSent = new WinFormsField("DP-TIME-SENT", "DPTimeSent");
        public static WinFormsField EstimateUnitsTopup = new WinFormsField("ESTIMATE-UNITS-TOPUP", "EstimateUnitsTopup");
        public static WinFormsField ExecutionVenue = new WinFormsField("EXECUTION-VENUE", "ExecutionVenue");
        public static WinFormsField MultiVenueFulfilmentInd = new WinFormsField("MULTI-VENUE-FULFILMENT-IND", "MultiVenueFulfilmentInd");
        public static WinFormsField DPAllowPartialFillInd = new WinFormsField("DP-ALLOW-PARTIAL-FILL-IND", "DPAllowPartialFillInd");
        public static WinFormsField ExternalInterfaceRef = new WinFormsField("EXTERNAL-INTERFACE-REF", "ExternalInterfaceRef");
        public static WinFormsField CrestTransID = new WinFormsField("CREST-TRANS-ID", "CrestTransID");
        public static WinFormsField CrestAdvnTypeInd = new WinFormsField("CREST-ADVN-TYPE-IND", "CrestAdvnTypeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
