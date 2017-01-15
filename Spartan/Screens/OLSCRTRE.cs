using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTRE

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTRE", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField HoldBalance = new WinFormsField("HOLD-BALANCE", "HoldBalance");
        public static WinFormsField ReissueBal = new WinFormsField("REISSUE-BAL", "ReissueBal");
        public static WinFormsField TransferUnits = new WinFormsField("TRANSFER-UNITS", "TransferUnits");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField BuySplitNbr1to5 = new WinFormsField("BUY-SPLIT-NBR-1TO5", "BuySplitNbr1to5");
        public static WinFormsField BuySplitUnits1to5 = new WinFormsField("BUY-SPLIT-UNITS-1TO5", "BuySplitUnits1to5");
        public static WinFormsField SellWarning1to3 = new WinFormsField("SELL-WARNING-1TO3", "SellWarning1to3");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
