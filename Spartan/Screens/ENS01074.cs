using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01074

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01074", "FormName");
		//Fields


        public static WinFormsField ChessID = new WinFormsField("CHESS-ID", "ChessID");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField CertID = new WinFormsField("CERT-ID", "CertID");
        public static WinFormsField MoveReason = new WinFormsField("MOVE-REASON", "MoveReason");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField SellBrokerDesc = new WinFormsField("SELL-BROKER-DESC", "SellBrokerDesc");
        public static WinFormsField TradeRef = new WinFormsField("TRADE-REF", "TradeRef");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField GuaranteedForeign = new WinFormsField("GUARANTEED-FOREIGN", "GuaranteedForeign");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField Remainder = new WinFormsField("REMAINDER", "Remainder");
        public static WinFormsField SellRegister = new WinFormsField("SELL-REGISTER", "SellRegister");
        public static WinFormsField SellRegisterDesc = new WinFormsField("SELL-REGISTER-DESC", "SellRegisterDesc");
        public static WinFormsField BuyRegister = new WinFormsField("BUY-REGISTER", "BuyRegister");
        public static WinFormsField BuyRegisterDesc = new WinFormsField("BUY-REGISTER-DESC", "BuyRegisterDesc");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellerResidency = new WinFormsField("SELLER-RESIDENCY", "SellerResidency");
        public static WinFormsField BuyHolderRef = new WinFormsField("BUY-HOLDER-REF", "BuyHolderRef");
        public static WinFormsField BuyerResidency = new WinFormsField("BUYER-RESIDENCY", "BuyerResidency");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
    }
}
