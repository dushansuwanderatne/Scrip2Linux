using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLKCTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLKCTL01", "FormName");
		//Fields


        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField BulkProcessType = new WinFormsField("BULK-PROCESS-TYPE", "BulkProcessType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField RecordMoneyORUnits = new WinFormsField("RECORD-MONEY-OR-UNITS", "RecordMoneyORUnits");
        public static WinFormsField ExerciseBulkInd = new WinFormsField("EXERCISE-BULK-IND", "ExerciseBulkInd");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField BulkCalcRequiredInd = new WinFormsField("BULK-CALC-REQUIRED-IND", "BulkCalcRequiredInd");
        public static WinFormsField ExerciseTranType = new WinFormsField("EXERCISE-TRAN-TYPE", "ExerciseTranType");
        public static WinFormsField BulkGroupCode = new WinFormsField("BULK-GROUP-CODE", "BulkGroupCode");
        public static WinFormsField TransactionSource = new WinFormsField("TRANSACTION-SOURCE", "TransactionSource");
        public static WinFormsField TradeMinimum = new WinFormsField("TRADE-MINIMUM", "TradeMinimum");
        public static WinFormsField ProcessAction = new WinFormsField("PROCESS-ACTION", "ProcessAction");
        public static WinFormsField AuditSettlingTransInd = new WinFormsField("AUDIT-SETTLING-TRANS-IND", "AuditSettlingTransInd");
        public static WinFormsField TradeMaximum = new WinFormsField("TRADE-MAXIMUM", "TradeMaximum");
        public static WinFormsField SettlementPeriod = new WinFormsField("SETTLEMENT-PERIOD", "SettlementPeriod");
        public static WinFormsField TradeMultiple = new WinFormsField("TRADE-MULTIPLE", "TradeMultiple");
        public static WinFormsField AuditInd = new WinFormsField("AUDIT-IND", "AuditInd");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField EssBulkTypeFlag = new WinFormsField("ESS-BULK-TYPE-FLAG", "EssBulkTypeFlag");
        public static WinFormsField EssType = new WinFormsField("ESS-TYPE", "EssType");
        public static WinFormsField BulkCounterpartyReqdInd = new WinFormsField("BULK-COUNTERPARTY-REQD-IND", "BulkCounterpartyReqdInd");
        public static WinFormsField EssPoolFlag = new WinFormsField("ESS-POOL-FLAG", "EssPoolFlag");
        public static WinFormsField CounterTranTypeCode = new WinFormsField("COUNTER-TRAN-TYPE-CODE", "CounterTranTypeCode");
        public static WinFormsField SpecialSettlementProgram = new WinFormsField("SPECIAL-SETTLEMENT-PROGRAM", "SpecialSettlementProgram");
        public static WinFormsField AllowCorporateBodiesInd = new WinFormsField("ALLOW-CORPORATE-BODIES-IND", "AllowCorporateBodiesInd");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField GenerateCertificates = new WinFormsField("GENERATE-CERTIFICATES", "GenerateCertificates");
        public static WinFormsField AllowForeignResidInd = new WinFormsField("ALLOW-FOREIGN-RESID-IND", "AllowForeignResidInd");
        public static WinFormsField GenerateAdvices = new WinFormsField("GENERATE-ADVICES", "GenerateAdvices");
        public static WinFormsField AllowReturnMailInd = new WinFormsField("ALLOW-RETURN-MAIL-IND", "AllowReturnMailInd");
        public static WinFormsField SpecialAdviceProgram = new WinFormsField("SPECIAL-ADVICE-PROGRAM", "SpecialAdviceProgram");
        public static WinFormsField AllowDeceasedInd = new WinFormsField("ALLOW-DECEASED-IND", "AllowDeceasedInd");
        public static WinFormsField CounterContactDetails = new WinFormsField("COUNTER-CONTACT-DETAILS", "CounterContactDetails");
        public static WinFormsField AllowPartialSellInd = new WinFormsField("ALLOW-PARTIAL-SELL-IND", "AllowPartialSellInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
