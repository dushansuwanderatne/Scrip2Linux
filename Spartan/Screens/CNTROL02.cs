using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNTROL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNTROL02", "FormName");
		//Fields


        public static WinFormsField CntrolKey0 = new WinFormsField("CNTROL-KEY0", "CntrolKey0");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField StationeryScrnotOpt = new WinFormsField("STATIONERY-SCRNOT-OPT", "StationeryScrnotOpt");
        public static WinFormsField StationeryEnquiryOpt = new WinFormsField("STATIONERY-ENQUIRY-OPT", "StationeryEnquiryOpt");
        public static WinFormsField ProcessingStatus = new WinFormsField("PROCESSING-STATUS", "ProcessingStatus");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField ChessUic = new WinFormsField("CHESS-UIC", "ChessUic");
        public static WinFormsField StationeryFastOpt = new WinFormsField("STATIONERY-FAST-OPT", "StationeryFastOpt");
        public static WinFormsField StationeryTfnOpt = new WinFormsField("STATIONERY-TFN-OPT", "StationeryTfnOpt");
        public static WinFormsField BuyerUnmatchedCnt = new WinFormsField("BUYER-UNMATCHED-CNT", "BuyerUnmatchedCnt");
        public static WinFormsField RequiresReconciliation = new WinFormsField("REQUIRES-RECONCILIATION", "RequiresReconciliation");
        public static WinFormsField StationeryPlanOpt = new WinFormsField("STATIONERY-PLAN-OPT", "StationeryPlanOpt");
        public static WinFormsField StationeryMrgnotOpt = new WinFormsField("STATIONERY-MRGNOT-OPT", "StationeryMrgnotOpt");
        public static WinFormsField BuySellUnmatchedCnt = new WinFormsField("BUY-SELL-UNMATCHED-CNT", "BuySellUnmatchedCnt");
        public static WinFormsField LastReconciled = new WinFormsField("LAST-RECONCILED", "LastReconciled");
        public static WinFormsField StationeryPaymentOpt = new WinFormsField("STATIONERY-PAYMENT-OPT", "StationeryPaymentOpt");
        public static WinFormsField StationeryLstsrnNotOpt = new WinFormsField("STATIONERY-LSTSRN-NOT-OPT", "StationeryLstsrnNotOpt");
        public static WinFormsField FasterUnmatchedCnt = new WinFormsField("FASTER-UNMATCHED-CNT", "FasterUnmatchedCnt");
        public static WinFormsField StationeryAddressOpt = new WinFormsField("STATIONERY-ADDRESS-OPT", "StationeryAddressOpt");
        public static WinFormsField ChessLiveDate = new WinFormsField("CHESS-LIVE-DATE", "ChessLiveDate");
        public static WinFormsField UnacknowledgedCount = new WinFormsField("UNACKNOWLEDGED-COUNT", "UnacknowledgedCount");
        public static WinFormsField StationeryOption = new WinFormsField("STATIONERY-OPTION", "StationeryOption");
        public static WinFormsField ChessRegTransSeq = new WinFormsField("CHESS-REG-TRANS-SEQ", "ChessRegTransSeq");
        public static WinFormsField StartChessRegTransSeq = new WinFormsField("START-CHESS-REG-TRANS-SEQ", "StartChessRegTransSeq");
        public static WinFormsField UpdateMonday = new WinFormsField("UPDATE-MONDAY", "UpdateMonday");
        public static WinFormsField UpdateTuesday = new WinFormsField("UPDATE-TUESDAY", "UpdateTuesday");
        public static WinFormsField UpdateWednesday = new WinFormsField("UPDATE-WEDNESDAY", "UpdateWednesday");
        public static WinFormsField UpdateThursday = new WinFormsField("UPDATE-THURSDAY", "UpdateThursday");
        public static WinFormsField UpdateFriday = new WinFormsField("UPDATE-FRIDAY", "UpdateFriday");
        public static WinFormsField StartChsinpSequenceNbr = new WinFormsField("START-CHSINP-SEQUENCE-NBR", "StartChsinpSequenceNbr");
        public static WinFormsField RunUpdateEvery2days = new WinFormsField("RUN-UPDATE-EVERY-2DAYS", "RunUpdateEvery2days");
        public static WinFormsField NextUrrDate = new WinFormsField("NEXT-URR-DATE", "NextUrrDate");
        public static WinFormsField ChessGroupNum = new WinFormsField("CHESS-GROUP-NUM", "ChessGroupNum");
        public static WinFormsField LastEomstsRun = new WinFormsField("LAST-EOMSTS-RUN", "LastEomstsRun");
        public static WinFormsField ValidateBrokerInd = new WinFormsField("VALIDATE-BROKER-IND", "ValidateBrokerInd");
        public static WinFormsField LcrtdmpRun = new WinFormsField("LCRTDMP-RUN", "LcrtdmpRun");
        public static WinFormsField DeceasedBuyFlag = new WinFormsField("DECEASED-BUY-FLAG", "DeceasedBuyFlag");
        public static WinFormsField ExtraTransHistory = new WinFormsField("EXTRA-TRANS-HISTORY", "ExtraTransHistory");
        public static WinFormsField LfilchkRun = new WinFormsField("LFILCHK-RUN", "LfilchkRun");
        public static WinFormsField LcrtdmpDate = new WinFormsField("LCRTDMP-DATE", "LcrtdmpDate");
        public static WinFormsField DeceasedSellFlag = new WinFormsField("DECEASED-SELL-FLAG", "DeceasedSellFlag");
        public static WinFormsField LfsthisdmpRun = new WinFormsField("LFSTHISDMP-RUN", "LfsthisdmpRun");
        public static WinFormsField LfilchkDate = new WinFormsField("LFILCHK-DATE", "LfilchkDate");
        public static WinFormsField LcrtdmpUptoRun = new WinFormsField("LCRTDMP-UPTO-RUN", "LcrtdmpUptoRun");
        public static WinFormsField BillingCode = new WinFormsField("BILLING-CODE", "BillingCode");
        public static WinFormsField LfstcrtdmpRun = new WinFormsField("LFSTCRTDMP-RUN", "LfstcrtdmpRun");
        public static WinFormsField LfilchkCurrHolders = new WinFormsField("LFILCHK-CURR-HOLDERS", "LfilchkCurrHolders");
        public static WinFormsField LpaydmpRun = new WinFormsField("LPAYDMP-RUN", "LpaydmpRun");
        public static WinFormsField ProcessGroupCode = new WinFormsField("PROCESS-GROUP-CODE", "ProcessGroupCode");
        public static WinFormsField LastPayTransNbr = new WinFormsField("LAST-PAY-TRANS-NBR", "LastPayTransNbr");
        public static WinFormsField LplnwdRun = new WinFormsField("LPLNWD-RUN", "LplnwdRun");
        public static WinFormsField LpaydmpDate = new WinFormsField("LPAYDMP-DATE", "LpaydmpDate");
        public static WinFormsField FastStatProg = new WinFormsField("FAST-STAT-PROG", "FastStatProg");
        public static WinFormsField LastCrtTransNbr = new WinFormsField("LAST-CRT-TRANS-NBR", "LastCrtTransNbr");
        public static WinFormsField LbrdrptRun = new WinFormsField("LBRDRPT-RUN", "LbrdrptRun");
        public static WinFormsField LhlddmpRun = new WinFormsField("LHLDDMP-RUN", "LhlddmpRun");
        public static WinFormsField AllowTwinDividendInd = new WinFormsField("ALLOW-TWIN-DIVIDEND-IND", "AllowTwinDividendInd");
        public static WinFormsField LastHldTransNbr = new WinFormsField("LAST-HLD-TRANS-NBR", "LastHldTransNbr");
        public static WinFormsField LstmentRun = new WinFormsField("LSTMENT-RUN", "LstmentRun");
        public static WinFormsField LhlddmpDate = new WinFormsField("LHLDDMP-DATE", "LhlddmpDate");
        public static WinFormsField IncorporatedComment = new WinFormsField("INCORPORATED-COMMENT", "IncorporatedComment");
        public static WinFormsField PafVersionNumber = new WinFormsField("PAF-VERSION-NUMBER", "PafVersionNumber");
        public static WinFormsField PafDataVersion = new WinFormsField("PAF-DATA-VERSION", "PafDataVersion");
        public static WinFormsField EomstmAutomatedInd = new WinFormsField("EOMSTM-AUTOMATED-IND", "EomstmAutomatedInd");
        public static WinFormsField EomstmUpperLimit = new WinFormsField("EOMSTM-UPPER-LIMIT", "EomstmUpperLimit");
        public static WinFormsField EomstmLowerLimit = new WinFormsField("EOMSTM-LOWER-LIMIT", "EomstmLowerLimit");
        public static WinFormsField UfdDeleteFlag = new WinFormsField("UFD-DELETE-FLAG", "UfdDeleteFlag");
    }
}
