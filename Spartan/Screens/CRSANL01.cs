using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSANL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSANL01", "FormName");
		//Fields


        public static WinFormsField CrsanlKey0 = new WinFormsField("CRSANL-KEY0", "CrsanlKey0");
        public static WinFormsField CrestTransID = new WinFormsField("CREST-TRANS-ID", "CrestTransID");
        public static WinFormsField DropNumber = new WinFormsField("DROP-NUMBER", "DropNumber");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField CirclesTimestamp = new WinFormsField("CIRCLES-TIMESTAMP", "CirclesTimestamp");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField RurAvailableDate = new WinFormsField("RUR-AVAILABLE-DATE", "RurAvailableDate");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField TransactionReference = new WinFormsField("TRANSACTION-REFERENCE", "TransactionReference");
        public static WinFormsField RurAvailableTime = new WinFormsField("RUR-AVAILABLE-TIME", "RurAvailableTime");
        public static WinFormsField InverseDropNumber = new WinFormsField("INVERSE-DROP-NUMBER", "InverseDropNumber");
        public static WinFormsField RegisteredDate = new WinFormsField("REGISTERED-DATE", "RegisteredDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField RegisteredTime = new WinFormsField("REGISTERED-TIME", "RegisteredTime");
        public static WinFormsField CrestFileSequence = new WinFormsField("CREST-FILE-SEQUENCE", "CrestFileSequence");
        public static WinFormsField CrestFileSplit = new WinFormsField("CREST-FILE-SPLIT", "CrestFileSplit");
        public static WinFormsField CrestItemSequence = new WinFormsField("CREST-ITEM-SEQUENCE", "CrestItemSequence");
        public static WinFormsField ErrorWarningFlag = new WinFormsField("ERROR-WARNING-FLAG", "ErrorWarningFlag");
        public static WinFormsField SellParticipantID = new WinFormsField("SELL-PARTICIPANT-ID", "SellParticipantID");
        public static WinFormsField CounterLocation = new WinFormsField("COUNTER-LOCATION", "CounterLocation");
        public static WinFormsField SellAccountID = new WinFormsField("SELL-ACCOUNT-ID", "SellAccountID");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellNationality = new WinFormsField("SELL-NATIONALITY", "SellNationality");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField BrokerID = new WinFormsField("BROKER-ID", "BrokerID");
        public static WinFormsField BuyParticipantID = new WinFormsField("BUY-PARTICIPANT-ID", "BuyParticipantID");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField BuyAccountID = new WinFormsField("BUY-ACCOUNT-ID", "BuyAccountID");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField BuyNationality = new WinFormsField("BUY-NATIONALITY", "BuyNationality");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
