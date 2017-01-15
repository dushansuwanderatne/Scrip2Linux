using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDCTL01", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField LastTradingIDNbr = new WinFormsField("LAST-TRADING-ID-NBR", "LastTradingIDNbr");
        public static WinFormsField DispExecutionVenueInd = new WinFormsField("DISP-EXECUTION-VENUE-IND", "DispExecutionVenueInd");
        public static WinFormsField ReconciliationCode = new WinFormsField("RECONCILIATION-CODE", "ReconciliationCode");
        public static WinFormsField CalcRequiredInd = new WinFormsField("CALC-REQUIRED-IND", "CalcRequiredInd");
        public static WinFormsField CalcProgram = new WinFormsField("CALC-PROGRAM", "CalcProgram");
        public static WinFormsField GrossRounding = new WinFormsField("GROSS-ROUNDING", "GrossRounding");
        public static WinFormsField InvestorTradeInd = new WinFormsField("INVESTOR-TRADE-IND", "InvestorTradeInd");
        public static WinFormsField MaxHldDefInd = new WinFormsField("MAX-HLD-DEF-IND", "MaxHldDefInd");
        public static WinFormsField MaxHldValue = new WinFormsField("MAX-HLD-VALUE", "MaxHldValue");
        public static WinFormsField RemBalMktParcelInd = new WinFormsField("REM-BAL-MKT-PARCEL-IND", "RemBalMktParcelInd");
        public static WinFormsField SettlementAction = new WinFormsField("SETTLEMENT-ACTION", "SettlementAction");
        public static WinFormsField SpecialSettlementProgram = new WinFormsField("SPECIAL-SETTLEMENT-PROGRAM", "SpecialSettlementProgram");
        public static WinFormsField SettlementDomicile = new WinFormsField("SETTLEMENT-DOMICILE", "SettlementDomicile");
        public static WinFormsField DeductIncomeTaxInd = new WinFormsField("DEDUCT-INCOME-TAX-IND", "DeductIncomeTaxInd");
        public static WinFormsField IncomeTaxProgramName = new WinFormsField("INCOME-TAX-PROGRAM-NAME", "IncomeTaxProgramName");
        public static WinFormsField IncomeSource = new WinFormsField("INCOME-SOURCE", "IncomeSource");
        public static WinFormsField SettlementPeriod = new WinFormsField("SETTLEMENT-PERIOD", "SettlementPeriod");
        public static WinFormsField SettlementOrigin = new WinFormsField("SETTLEMENT-ORIGIN", "SettlementOrigin");
        public static WinFormsField AuditSettlingTransInd = new WinFormsField("AUDIT-SETTLING-TRANS-IND", "AuditSettlingTransInd");
        public static WinFormsField RealTimeTradingInd = new WinFormsField("REAL-TIME-TRADING-IND", "RealTimeTradingInd");
        public static WinFormsField ONMarketTradeInd = new WinFormsField("ON-MARKET-TRADE-IND", "ONMarketTradeInd");
        public static WinFormsField TradeOrigin = new WinFormsField("TRADE-ORIGIN", "TradeOrigin");
        public static WinFormsField DPOrderType = new WinFormsField("DP-ORDER-TYPE", "DPOrderType");
        public static WinFormsField Multiple = new WinFormsField("MULTIPLE", "Multiple");
        public static WinFormsField ChargeCode = new WinFormsField("CHARGE-CODE", "ChargeCode");
        public static WinFormsField ChargePaidBYInd = new WinFormsField("CHARGE-PAID-BY-IND", "ChargePaidBYInd");
        public static WinFormsField TaxBenefitInd = new WinFormsField("TAX-BENEFIT-IND", "TaxBenefitInd");
        public static WinFormsField PlanTypeInd = new WinFormsField("PLAN-TYPE-IND", "PlanTypeInd");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField DPBrokerCode = new WinFormsField("DP-BROKER-CODE", "DPBrokerCode");
        public static WinFormsField DPTradeAccount = new WinFormsField("DP-TRADE-ACCOUNT", "DPTradeAccount");
        public static WinFormsField DPConnectionTO = new WinFormsField("DP-CONNECTION-TO", "DPConnectionTO");
        public static WinFormsField DailyPriceAvgReqdInd = new WinFormsField("DAILY-PRICE-AVG-REQD-IND", "DailyPriceAvgReqdInd");
        public static WinFormsField CounterpartyReqdInd = new WinFormsField("COUNTERPARTY-REQD-IND", "CounterpartyReqdInd");
        public static WinFormsField CounterTranTypeCode = new WinFormsField("COUNTER-TRAN-TYPE-CODE", "CounterTranTypeCode");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterBrokerCode = new WinFormsField("COUNTER-BROKER-CODE", "CounterBrokerCode");
        public static WinFormsField CounterBrokerAccount = new WinFormsField("COUNTER-BROKER-ACCOUNT", "CounterBrokerAccount");
        public static WinFormsField CosmosConnectionCode = new WinFormsField("COSMOS-CONNECTION-CODE", "CosmosConnectionCode");
        public static WinFormsField DeliveryBrokerCode = new WinFormsField("DELIVERY-BROKER-CODE", "DeliveryBrokerCode");
        public static WinFormsField GenerateTrdtpeInd = new WinFormsField("GENERATE-TRDTPE-IND", "GenerateTrdtpeInd");
        public static WinFormsField CashManagementReqdInd = new WinFormsField("CASH-MANAGEMENT-REQD-IND", "CashManagementReqdInd");
        public static WinFormsField GenerateCertificates = new WinFormsField("GENERATE-CERTIFICATES", "GenerateCertificates");
        public static WinFormsField PayrollDependentInd = new WinFormsField("PAYROLL-DEPENDENT-IND", "PayrollDependentInd");
        public static WinFormsField GenerateAdvices = new WinFormsField("GENERATE-ADVICES", "GenerateAdvices");
        public static WinFormsField SpecialAdviceProgram = new WinFormsField("SPECIAL-ADVICE-PROGRAM", "SpecialAdviceProgram");
        public static WinFormsField RemitTaxPayrollInd = new WinFormsField("REMIT-TAX-PAYROLL-IND", "RemitTaxPayrollInd");
        public static WinFormsField TapeFormat = new WinFormsField("TAPE-FORMAT", "TapeFormat");
        public static WinFormsField GenerateFlatFile = new WinFormsField("GENERATE-FLAT-FILE", "GenerateFlatFile");
        public static WinFormsField RemitEmpPayrollInd = new WinFormsField("REMIT-EMP-PAYROLL-IND", "RemitEmpPayrollInd");
        public static WinFormsField LastUpdatedBY = new WinFormsField("LAST-UPDATED-BY", "LastUpdatedBY");
        public static WinFormsField DateUpdated = new WinFormsField("DATE-UPDATED", "DateUpdated");
        public static WinFormsField TimeUpdated = new WinFormsField("TIME-UPDATED", "TimeUpdated");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Mtc0EventBulkInd = new WinFormsField("MTC0-EVENT-BULK-IND", "Mtc0EventBulkInd");
        public static WinFormsField PendPymtCancDays = new WinFormsField("PEND-PYMT-CANC-DAYS", "PendPymtCancDays");
        public static WinFormsField AutoSettleNOCostInd = new WinFormsField("AUTO-SETTLE-NO-COST-IND", "AutoSettleNOCostInd");
        public static WinFormsField AutoUpdFinalPriceInd = new WinFormsField("AUTO-UPD-FINAL-PRICE-IND", "AutoUpdFinalPriceInd");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
