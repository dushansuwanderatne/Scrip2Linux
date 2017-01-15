using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSMNYRE

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSMNYRE", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField HoldBalanceMoney = new WinFormsField("HOLD-BALANCE-MONEY", "HoldBalanceMoney");
        public static WinFormsField ReissueBalMoney = new WinFormsField("REISSUE-BAL-MONEY", "ReissueBalMoney");
        public static WinFormsField TransferMoney = new WinFormsField("TRANSFER-MONEY", "TransferMoney");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField BuySplitNbr1to5 = new WinFormsField("BUY-SPLIT-NBR-1TO5", "BuySplitNbr1to5");
        public static WinFormsField BuySplitMoney1to5 = new WinFormsField("BUY-SPLIT-MONEY-1TO5", "BuySplitMoney1to5");
        public static WinFormsField SellWarning1to3 = new WinFormsField("SELL-WARNING-1TO3", "SellWarning1to3");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
