using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01072

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01072", "FormName");
		//Fields
        public static WinFormsField GuaranteedForeign = new WinFormsField("GUARANTEED-FOREIGN", "GuaranteedForeign");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField MsgType = new WinFormsField("MSG-TYPE", "MsgType");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField BalanceInst = new WinFormsField("BALANCE-INST", "BalanceInst");
        public static WinFormsField RemainderUnits = new WinFormsField("REMAINDER-UNITS", "RemainderUnits");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField RejectDesc = new WinFormsField("REJECT-DESC", "RejectDesc");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField RejectMsg = new WinFormsField("REJECT-MSG", "RejectMsg");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellerResidency = new WinFormsField("SELLER-RESIDENCY", "SellerResidency");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField BuyerResidency = new WinFormsField("BUYER-RESIDENCY", "BuyerResidency");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField SellPostcode = new WinFormsField("SELL-POSTCODE", "SellPostcode");
        public static WinFormsField BuyPostcode = new WinFormsField("BUY-POSTCODE", "BuyPostcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RejectedReason = new WinFormsField("REJECTED-REASON", "RejectedReason");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
