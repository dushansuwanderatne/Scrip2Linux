using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRFANL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRFANL01", "FormName");
		//Fields


        public static WinFormsField TransferType = new WinFormsField("TRANSFER-TYPE", "TransferType");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TradingBroker = new WinFormsField("TRADING-BROKER", "TradingBroker");
        public static WinFormsField SightedDate = new WinFormsField("SIGHTED-DATE", "SightedDate");
        public static WinFormsField TradingHolderID = new WinFormsField("TRADING-HOLDER-ID", "TradingHolderID");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField ReissueBalance = new WinFormsField("REISSUE-BALANCE", "ReissueBalance");
        public static WinFormsField Fin = new WinFormsField("FIN", "Fin");
        public static WinFormsField ProcessedDate = new WinFormsField("PROCESSED-DATE", "ProcessedDate");
        public static WinFormsField ReissueInstruction = new WinFormsField("REISSUE-INSTRUCTION", "ReissueInstruction");
        public static WinFormsField TransferQuantity = new WinFormsField("TRANSFER-QUANTITY", "TransferQuantity");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField PendingCode = new WinFormsField("PENDING-CODE", "PendingCode");
        public static WinFormsField UnnotifiedFlag = new WinFormsField("UNNOTIFIED-FLAG", "UnnotifiedFlag");
        public static WinFormsField TransHour = new WinFormsField("TRANS-HOUR", "TransHour");
        public static WinFormsField TransMinute = new WinFormsField("TRANS-MINUTE", "TransMinute");
        public static WinFormsField TransSecond = new WinFormsField("TRANS-SECOND", "TransSecond");
        public static WinFormsField TransHundred = new WinFormsField("TRANS-HUNDRED", "TransHundred");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField ResPrefix = new WinFormsField("RES-PREFIX", "ResPrefix");
        public static WinFormsField ResNumber = new WinFormsField("RES-NUMBER", "ResNumber");
        public static WinFormsField ResReason = new WinFormsField("RES-REASON", "ResReason");
        public static WinFormsField ResExpiryDate = new WinFormsField("RES-EXPIRY-DATE", "ResExpiryDate");
        public static WinFormsField ResDeal = new WinFormsField("RES-DEAL", "ResDeal");
        public static WinFormsField ResNomPartic = new WinFormsField("RES-NOM-PARTIC", "ResNomPartic");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
