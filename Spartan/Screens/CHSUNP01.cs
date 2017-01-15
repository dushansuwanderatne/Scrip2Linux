using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHSUNP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHSUNP01", "FormName");
		//Fields


        public static WinFormsField ChsunpKey0 = new WinFormsField("CHSUNP-KEY0", "ChsunpKey0");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField ChessTransID = new WinFormsField("CHESS-TRANS-ID", "ChessTransID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField BuyRegister = new WinFormsField("BUY-REGISTER", "BuyRegister");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField BalanceInstruction = new WinFormsField("BALANCE-INSTRUCTION", "BalanceInstruction");
        public static WinFormsField ChsinpSequenceNumber = new WinFormsField("CHSINP-SEQUENCE-NUMBER", "ChsinpSequenceNumber");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellRegister = new WinFormsField("SELL-REGISTER", "SellRegister");
        public static WinFormsField TakeoverCode = new WinFormsField("TAKEOVER-CODE", "TakeoverCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField ProcessedFlag = new WinFormsField("PROCESSED-FLAG", "ProcessedFlag");
        public static WinFormsField BuyTfn = new WinFormsField("BUY-TFN", "BuyTfn");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField SellPin = new WinFormsField("SELL-PIN", "SellPin");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
