using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP15

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP15", "FormName");
		//Fields


        public static WinFormsField TransUic = new WinFormsField("TRANS-UIC", "TransUic");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField TransReference = new WinFormsField("TRANS-REFERENCE", "TransReference");
        public static WinFormsField SellCertID = new WinFormsField("SELL-CERT-ID", "SellCertID");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BusinessDate = new WinFormsField("BUSINESS-DATE", "BusinessDate");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField BalanceInstruction = new WinFormsField("BALANCE-INSTRUCTION", "BalanceInstruction");
        public static WinFormsField RemainingUnits = new WinFormsField("REMAINING-UNITS", "RemainingUnits");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField SellRegister = new WinFormsField("SELL-REGISTER", "SellRegister");
        public static WinFormsField RejectReason = new WinFormsField("REJECT-REASON", "RejectReason");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField RejectMsg = new WinFormsField("REJECT-MSG", "RejectMsg");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
