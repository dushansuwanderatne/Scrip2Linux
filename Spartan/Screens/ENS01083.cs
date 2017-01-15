using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01083

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01083", "FormName");
		//Fields


        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField FromTOFlag = new WinFormsField("FROM-TO-FLAG", "FromTOFlag");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TransactionDesc = new WinFormsField("TRANSACTION-DESC", "TransactionDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField PendingCode = new WinFormsField("PENDING-CODE", "PendingCode");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TransferQuantity = new WinFormsField("TRANSFER-QUANTITY", "TransferQuantity");
        public static WinFormsField ProcessedDate = new WinFormsField("PROCESSED-DATE", "ProcessedDate");
        public static WinFormsField ReissueBalance = new WinFormsField("REISSUE-BALANCE", "ReissueBalance");
        public static WinFormsField SightedDate = new WinFormsField("SIGHTED-DATE", "SightedDate");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField TransHour = new WinFormsField("TRANS-HOUR", "TransHour");
        public static WinFormsField TransMinute = new WinFormsField("TRANS-MINUTE", "TransMinute");
        public static WinFormsField TransSecond = new WinFormsField("TRANS-SECOND", "TransSecond");
        public static WinFormsField TransferType = new WinFormsField("TRANSFER-TYPE", "TransferType");
        public static WinFormsField UnnotifiedFlag = new WinFormsField("UNNOTIFIED-FLAG", "UnnotifiedFlag");
        public static WinFormsField ReissueInstruction = new WinFormsField("REISSUE-INSTRUCTION", "ReissueInstruction");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField TradingHolderID = new WinFormsField("TRADING-HOLDER-ID", "TradingHolderID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField BuyerAddressLine = new WinFormsField("BUYER-ADDRESS-LINE", "BuyerAddressLine");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField TradingBroker = new WinFormsField("TRADING-BROKER", "TradingBroker");
        public static WinFormsField BuyerAddressType = new WinFormsField("BUYER-ADDRESS-TYPE", "BuyerAddressType");
        public static WinFormsField BuyerDomicileCode = new WinFormsField("BUYER-DOMICILE-CODE", "BuyerDomicileCode");
    }
}
