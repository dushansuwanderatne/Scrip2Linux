using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS24000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS24000", "FormName");
		//Fields


        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDescription = new WinFormsField("BULK-DESCRIPTION", "BulkDescription");
        public static WinFormsField BulkProcessType = new WinFormsField("BULK-PROCESS-TYPE", "BulkProcessType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField BulkGroupCode = new WinFormsField("BULK-GROUP-CODE", "BulkGroupCode");
        public static WinFormsField ExerciseBulkInd = new WinFormsField("EXERCISE-BULK-IND", "ExerciseBulkInd");
        public static WinFormsField EssBulkTypeFlag = new WinFormsField("ESS-BULK-TYPE-FLAG", "EssBulkTypeFlag");
        public static WinFormsField EssType = new WinFormsField("ESS-TYPE", "EssType");
        public static WinFormsField EssPoolFlag = new WinFormsField("ESS-POOL-FLAG", "EssPoolFlag");
        public static WinFormsField ProcessAction = new WinFormsField("PROCESS-ACTION", "ProcessAction");
        public static WinFormsField SettlementPeriod = new WinFormsField("SETTLEMENT-PERIOD", "SettlementPeriod");
        public static WinFormsField RecordMoneyORUnits = new WinFormsField("RECORD-MONEY-OR-UNITS", "RecordMoneyORUnits");
        public static WinFormsField BulkCpartyReq = new WinFormsField("BULK-CPARTY-REQ", "BulkCpartyReq");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField CounterTrantypeCode = new WinFormsField("COUNTER-TRANTYPE-CODE", "CounterTrantypeCode");
        public static WinFormsField BulkCalcReqInd = new WinFormsField("BULK-CALC-REQ-IND", "BulkCalcReqInd");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField ExerciseTranType = new WinFormsField("EXERCISE-TRAN-TYPE", "ExerciseTranType");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TradeMinimum = new WinFormsField("TRADE-MINIMUM", "TradeMinimum");
        public static WinFormsField HolderCategory = new WinFormsField("HOLDER-CATEGORY", "HolderCategory");
        public static WinFormsField TradeMaximum = new WinFormsField("TRADE-MAXIMUM", "TradeMaximum");
        public static WinFormsField TradeMultiple = new WinFormsField("TRADE-MULTIPLE", "TradeMultiple");
        public static WinFormsField CounterContactDetail = new WinFormsField("COUNTER-CONTACT-DETAIL", "CounterContactDetail");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SearchBulkCode = new WinFormsField("SEARCH-BULK-CODE", "SearchBulkCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
