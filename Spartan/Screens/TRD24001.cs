using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD24001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD24001", "FormName");
		//Fields


        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField InvTradeInd = new WinFormsField("INV-TRADE-IND", "InvTradeInd");
        public static WinFormsField LoanClassInd = new WinFormsField("LOAN-CLASS-IND", "LoanClassInd");
        public static WinFormsField Trd24001EventBulkInd = new WinFormsField("TRD24001-EVENT-BULK-IND", "Trd24001EventBulkInd");
        public static WinFormsField SettlementAction = new WinFormsField("SETTLEMENT-ACTION", "SettlementAction");
        public static WinFormsField SettlementPeriod = new WinFormsField("SETTLEMENT-PERIOD", "SettlementPeriod");
        public static WinFormsField SettlementRegime = new WinFormsField("SETTLEMENT-REGIME", "SettlementRegime");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField ReportableValue = new WinFormsField("REPORTABLE-VALUE", "ReportableValue");
        public static WinFormsField MultipleOF1 = new WinFormsField("MULTIPLE-OF-1", "MultipleOF1");
        public static WinFormsField RecordMoneyORUnits = new WinFormsField("RECORD-MONEY-OR-UNITS", "RecordMoneyORUnits");
        public static WinFormsField MaxHldDefInd = new WinFormsField("MAX-HLD-DEF-IND", "MaxHldDefInd");
        public static WinFormsField MaxHldValue = new WinFormsField("MAX-HLD-VALUE", "MaxHldValue");
        public static WinFormsField RemBalMktParcel = new WinFormsField("REM-BAL-MKT-PARCEL", "RemBalMktParcel");
        public static WinFormsField CutOffHH = new WinFormsField("CUT-OFF-HH", "CutOffHH");
        public static WinFormsField CutOffMM = new WinFormsField("CUT-OFF-MM", "CutOffMM");
        public static WinFormsField CalcReqInd = new WinFormsField("CALC-REQ-IND", "CalcReqInd");
        public static WinFormsField ContactDetails = new WinFormsField("CONTACT-DETAILS", "ContactDetails");
        public static WinFormsField LastTradingIDNbr = new WinFormsField("LAST-TRADING-ID-NBR", "LastTradingIDNbr");
        public static WinFormsField LastUpdatedBY = new WinFormsField("LAST-UPDATED-BY", "LastUpdatedBY");
        public static WinFormsField LastDateUpdated = new WinFormsField("LAST-DATE-UPDATED", "LastDateUpdated");
        public static WinFormsField LastTimeUpdated = new WinFormsField("LAST-TIME-UPDATED", "LastTimeUpdated");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SearchTradingCode = new WinFormsField("SEARCH-TRADING-CODE", "SearchTradingCode");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
