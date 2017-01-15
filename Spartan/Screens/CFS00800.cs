using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00800

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00800", "FormName");
		//Fields


        public static WinFormsField TransactionCode = new WinFormsField("TRANSACTION-CODE", "TransactionCode");
        public static WinFormsField TransDesc = new WinFormsField("TRANS-DESC", "TransDesc");
        public static WinFormsField ForwardDatedInd = new WinFormsField("FORWARD-DATED-IND", "ForwardDatedInd");
        public static WinFormsField TransClass = new WinFormsField("TRANS-CLASS", "TransClass");
        public static WinFormsField TransFromTOFlag = new WinFormsField("TRANS-FROM-TO-FLAG", "TransFromTOFlag");
        public static WinFormsField TransAnalysisCode = new WinFormsField("TRANS-ANALYSIS-CODE", "TransAnalysisCode");
        public static WinFormsField TransListNumber = new WinFormsField("TRANS-LIST-NUMBER", "TransListNumber");
        public static WinFormsField TranBillingGroup = new WinFormsField("TRAN-BILLING-GROUP", "TranBillingGroup");
        public static WinFormsField TransScripOption = new WinFormsField("TRANS-SCRIP-OPTION", "TransScripOption");
        public static WinFormsField TransGrouping = new WinFormsField("TRANS-GROUPING", "TransGrouping");
        public static WinFormsField TransProcessNumber = new WinFormsField("TRANS-PROCESS-NUMBER", "TransProcessNumber");
        public static WinFormsField TranTypeAlt = new WinFormsField("TRAN-TYPE-ALT", "TranTypeAlt");
        public static WinFormsField TranCompanyType = new WinFormsField("TRAN-COMPANY-TYPE", "TranCompanyType");
        public static WinFormsField OnlineProgram = new WinFormsField("ONLINE-PROGRAM", "OnlineProgram");
        public static WinFormsField TranTypeOrigin = new WinFormsField("TRAN-TYPE-ORIGIN", "TranTypeOrigin");
        public static WinFormsField InclTransListInd = new WinFormsField("INCL-TRANS-LIST-IND", "InclTransListInd");
        public static WinFormsField AfoTranType = new WinFormsField("AFO-TRAN-TYPE", "AfoTranType");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TradeHolder = new WinFormsField("TRADE-HOLDER", "TradeHolder");
        public static WinFormsField TradeClass = new WinFormsField("TRADE-CLASS", "TradeClass");
        public static WinFormsField CheckNumber = new WinFormsField("CHECK-NUMBER", "CheckNumber");
        public static WinFormsField TradeReg = new WinFormsField("TRADE-REG", "TradeReg");
        public static WinFormsField AffectCumBalance = new WinFormsField("AFFECT-CUM-BALANCE", "AffectCumBalance");
        public static WinFormsField TradeBroker = new WinFormsField("TRADE-BROKER", "TradeBroker");
        public static WinFormsField NotifyChessInd = new WinFormsField("NOTIFY-CHESS-IND", "NotifyChessInd");
        public static WinFormsField TradeCert = new WinFormsField("TRADE-CERT", "TradeCert");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField TradeDate = new WinFormsField("TRADE-DATE", "TradeDate");
        public static WinFormsField SpecialTradeScreen = new WinFormsField("SPECIAL-TRADE-SCREEN", "SpecialTradeScreen");
        public static WinFormsField SpecialTradeDetails = new WinFormsField("SPECIAL-TRADE-DETAILS", "SpecialTradeDetails");
        public static WinFormsField BuySellCategories = new WinFormsField("BUY-SELL-CATEGORIES", "BuySellCategories");
        public static WinFormsField AuditINWorkflowInd = new WinFormsField("AUDIT-IN-WORKFLOW-IND", "AuditINWorkflowInd");
        public static WinFormsField WorkflowTranType = new WinFormsField("WORKFLOW-TRAN-TYPE", "WorkflowTranType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
