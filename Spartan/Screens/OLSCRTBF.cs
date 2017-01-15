using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTBF

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTBF", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyClassDesc = new WinFormsField("BUY-CLASS-DESC", "BuyClassDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyRegDesc = new WinFormsField("BUY-REG-DESC", "BuyRegDesc");
        public static WinFormsField BuyReference = new WinFormsField("BUY-REFERENCE", "BuyReference");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuyBrokerDesc = new WinFormsField("BUY-BROKER-DESC", "BuyBrokerDesc");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField BuyAddressLine = new WinFormsField("BUY-ADDRESS-LINE", "BuyAddressLine");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField MarkingNumber = new WinFormsField("MARKING-NUMBER", "MarkingNumber");
        public static WinFormsField ReissueBal = new WinFormsField("REISSUE-BAL", "ReissueBal");
        public static WinFormsField ReissTOSellBroker = new WinFormsField("REISS-TO-SELL-BROKER", "ReissTOSellBroker");
        public static WinFormsField BuyCertID = new WinFormsField("BUY-CERT-ID", "BuyCertID");
        public static WinFormsField BuyTransDate = new WinFormsField("BUY-TRANS-DATE", "BuyTransDate");
        public static WinFormsField UncertBuyReg = new WinFormsField("UNCERT-BUY-REG", "UncertBuyReg");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField BuySplitNbr1to5 = new WinFormsField("BUY-SPLIT-NBR-1TO5", "BuySplitNbr1to5");
        public static WinFormsField BuySplitUnits1to5 = new WinFormsField("BUY-SPLIT-UNITS-1TO5", "BuySplitUnits1to5");
        public static WinFormsField BuyWarning1to3 = new WinFormsField("BUY-WARNING-1TO3", "BuyWarning1to3");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
