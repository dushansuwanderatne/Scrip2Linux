using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDORD02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDORD02", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradingNumber = new WinFormsField("TRADING-NUMBER", "TradingNumber");
        public static WinFormsField TradingStatus = new WinFormsField("TRADING-STATUS", "TradingStatus");
        public static WinFormsField TradingType = new WinFormsField("TRADING-TYPE", "TradingType");
        public static WinFormsField TradingCodeKey1 = new WinFormsField("TRADING-CODE-KEY1", "TradingCodeKey1");
        public static WinFormsField TradingLevy = new WinFormsField("TRADING-LEVY", "TradingLevy");
        public static WinFormsField ActualUnitsTraded = new WinFormsField("ACTUAL-UNITS-TRADED", "ActualUnitsTraded");
        public static WinFormsField FractionAmount = new WinFormsField("FRACTION-AMOUNT", "FractionAmount");
        public static WinFormsField ChargePaidBYInd = new WinFormsField("CHARGE-PAID-BY-IND", "ChargePaidBYInd");
        public static WinFormsField Charge = new WinFormsField("CHARGE", "Charge");
        public static WinFormsField TaxONCharge = new WinFormsField("TAX-ON-CHARGE", "TaxONCharge");
        public static WinFormsField ActualMoneyTraded = new WinFormsField("ACTUAL-MONEY-TRADED", "ActualMoneyTraded");
        public static WinFormsField CalculatedUnits = new WinFormsField("CALCULATED-UNITS", "CalculatedUnits");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField TradeTime = new WinFormsField("TRADE-TIME", "TradeTime");
        public static WinFormsField TradePrice = new WinFormsField("TRADE-PRICE", "TradePrice");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField FinalPrice = new WinFormsField("FINAL-PRICE", "FinalPrice");
        public static WinFormsField IndicativePrice = new WinFormsField("INDICATIVE-PRICE", "IndicativePrice");
        public static WinFormsField TradeAccount = new WinFormsField("TRADE-ACCOUNT", "TradeAccount");
        public static WinFormsField GrantDate = new WinFormsField("GRANT-DATE", "GrantDate");
        public static WinFormsField GrantFmv = new WinFormsField("GRANT-FMV", "GrantFmv");
        public static WinFormsField EndOFOffer = new WinFormsField("END-OF-OFFER", "EndOFOffer");
        public static WinFormsField PriceBase = new WinFormsField("PRICE-BASE", "PriceBase");
        public static WinFormsField EndSaleRestrictDate = new WinFormsField("END-SALE-RESTRICT-DATE", "EndSaleRestrictDate");
        public static WinFormsField EndTrfRestrictDate = new WinFormsField("END-TRF-RESTRICT-DATE", "EndTrfRestrictDate");
        public static WinFormsField PlanCertID = new WinFormsField("PLAN-CERT-ID", "PlanCertID");
        public static WinFormsField MatchCertID = new WinFormsField("MATCH-CERT-ID", "MatchCertID");
        public static WinFormsField DivRecordDate = new WinFormsField("DIV-RECORD-DATE", "DivRecordDate");
        public static WinFormsField DivPaymentDate = new WinFormsField("DIV-PAYMENT-DATE", "DivPaymentDate");
        public static WinFormsField LimitAdjustment = new WinFormsField("LIMIT-ADJUSTMENT", "LimitAdjustment");
        public static WinFormsField PaymentAccount = new WinFormsField("PAYMENT-ACCOUNT", "PaymentAccount");
        public static WinFormsField DirectBankCount = new WinFormsField("DIRECT-BANK-COUNT", "DirectBankCount");
        public static WinFormsField DirectBankNettAmount = new WinFormsField("DIRECT-BANK-NETT-AMOUNT", "DirectBankNettAmount");
        public static WinFormsField UnitBreakageAdjustment = new WinFormsField("UNIT-BREAKAGE-ADJUSTMENT", "UnitBreakageAdjustment");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField LocalChqCount = new WinFormsField("LOCAL-CHQ-COUNT", "LocalChqCount");
        public static WinFormsField LocalChqNettAmount = new WinFormsField("LOCAL-CHQ-NETT-AMOUNT", "LocalChqNettAmount");
        public static WinFormsField CashBreakageAdjustment = new WinFormsField("CASH-BREAKAGE-ADJUSTMENT", "CashBreakageAdjustment");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField ForeignChqCount = new WinFormsField("FOREIGN-CHQ-COUNT", "ForeignChqCount");
        public static WinFormsField ForeignChqNettAmount = new WinFormsField("FOREIGN-CHQ-NETT-AMOUNT", "ForeignChqNettAmount");
        public static WinFormsField EstimatedChargeAdj = new WinFormsField("ESTIMATED-CHARGE-ADJ", "EstimatedChargeAdj");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField WireCount = new WinFormsField("WIRE-COUNT", "WireCount");
        public static WinFormsField WireNettAmount = new WinFormsField("WIRE-NETT-AMOUNT", "WireNettAmount");
        public static WinFormsField LatestSharePrice = new WinFormsField("LATEST-SHARE-PRICE", "LatestSharePrice");
        public static WinFormsField EmployerCount = new WinFormsField("EMPLOYER-COUNT", "EmployerCount");
        public static WinFormsField EmployerNettAmount = new WinFormsField("EMPLOYER-NETT-AMOUNT", "EmployerNettAmount");
        public static WinFormsField CashTopUP = new WinFormsField("CASH-TOP-UP", "CashTopUP");
        public static WinFormsField PaymentTotalsSpare1 = new WinFormsField("PAYMENT-TOTALS-SPARE1", "PaymentTotalsSpare1");
        public static WinFormsField PaymentTotalsSpare2 = new WinFormsField("PAYMENT-TOTALS-SPARE2", "PaymentTotalsSpare2");
        public static WinFormsField ChqNbrFrom = new WinFormsField("CHQ-NBR-FROM", "ChqNbrFrom");
        public static WinFormsField ChqNbrTO = new WinFormsField("CHQ-NBR-TO", "ChqNbrTO");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
