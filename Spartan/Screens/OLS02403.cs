using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02403", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField MarkingNbr = new WinFormsField("MARKING-NBR", "MarkingNbr");
        public static WinFormsField MarkingDate = new WinFormsField("MARKING-DATE", "MarkingDate");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField SecLineNbr = new WinFormsField("SEC-LINE-NBR", "SecLineNbr");
        public static WinFormsField SecQuantity = new WinFormsField("SEC-QUANTITY", "SecQuantity");
        public static WinFormsField SecDenom = new WinFormsField("SEC-DENOM", "SecDenom");
        public static WinFormsField BrkLineNbr = new WinFormsField("BRK-LINE-NBR", "BrkLineNbr");
        public static WinFormsField BrkQuantity = new WinFormsField("BRK-QUANTITY", "BrkQuantity");
        public static WinFormsField BrkDenom = new WinFormsField("BRK-DENOM", "BrkDenom");
        public static WinFormsField RemainingBalance = new WinFormsField("REMAINING-BALANCE", "RemainingBalance");
        public static WinFormsField HolderTransferBal = new WinFormsField("HOLDER-TRANSFER-BAL", "HolderTransferBal");
        public static WinFormsField HolderScripBalance = new WinFormsField("HOLDER-SCRIP-BALANCE", "HolderScripBalance");
        public static WinFormsField ReissueBal = new WinFormsField("REISSUE-BAL", "ReissueBal");
        public static WinFormsField SellerBroker = new WinFormsField("SELLER-BROKER", "SellerBroker");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
