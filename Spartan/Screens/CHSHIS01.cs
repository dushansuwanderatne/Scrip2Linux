using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHSHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHSHIS01", "FormName");
		//Fields


        public static WinFormsField ChshisKey0 = new WinFormsField("CHSHIS-KEY0", "ChshisKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField ChessGroupNum = new WinFormsField("CHESS-GROUP-NUM", "ChessGroupNum");
        public static WinFormsField TransCount = new WinFormsField("TRANS-COUNT", "TransCount");
        public static WinFormsField ChsinpSequenceNumber = new WinFormsField("CHSINP-SEQUENCE-NUMBER", "ChsinpSequenceNumber");
        public static WinFormsField ChessRegTransSeq = new WinFormsField("CHESS-REG-TRANS-SEQ", "ChessRegTransSeq");
        public static WinFormsField ChshisKey3 = new WinFormsField("CHSHIS-KEY3", "ChshisKey3");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField ChessTransID = new WinFormsField("CHESS-TRANS-ID", "ChessTransID");
        public static WinFormsField UnitsTraded = new WinFormsField("UNITS-TRADED", "UnitsTraded");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField BrokerCommissionCode = new WinFormsField("BROKER-COMMISSION-CODE", "BrokerCommissionCode");
        public static WinFormsField Mch0TradeReference = new WinFormsField("MCH0-TRADE-REFERENCE", "Mch0TradeReference");
        public static WinFormsField AcknowledgedFlag = new WinFormsField("ACKNOWLEDGED-FLAG", "AcknowledgedFlag");
        public static WinFormsField AckBusinessDate = new WinFormsField("ACK-BUSINESS-DATE", "AckBusinessDate");
        public static WinFormsField DistinctPortionInd = new WinFormsField("DISTINCT-PORTION-IND", "DistinctPortionInd");
        public static WinFormsField AckChsinpSequence = new WinFormsField("ACK-CHSINP-SEQUENCE", "AckChsinpSequence");
        public static WinFormsField GuaranteedForeignInd = new WinFormsField("GUARANTEED-FOREIGN-IND", "GuaranteedForeignInd");
        public static WinFormsField BusinessDateChanged = new WinFormsField("BUSINESS-DATE-CHANGED", "BusinessDateChanged");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField CetChessErrorType = new WinFormsField("CET-CHESS-ERROR-TYPE", "CetChessErrorType");
        public static WinFormsField ProcessTimeChanged = new WinFormsField("PROCESS-TIME-CHANGED", "ProcessTimeChanged");
        public static WinFormsField AckProcessTime = new WinFormsField("ACK-PROCESS-TIME", "AckProcessTime");
        public static WinFormsField CetChessErrorDesc = new WinFormsField("CET-CHESS-ERROR-DESC", "CetChessErrorDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
