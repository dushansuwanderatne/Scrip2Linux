using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02803", "FormName");
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
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField BuySplitNumber = new WinFormsField("BUY-SPLIT-NUMBER", "BuySplitNumber");
        public static WinFormsField BuySplitUnits = new WinFormsField("BUY-SPLIT-UNITS", "BuySplitUnits");
        public static WinFormsField BuyTradeReference = new WinFormsField("BUY-TRADE-REFERENCE", "BuyTradeReference");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}