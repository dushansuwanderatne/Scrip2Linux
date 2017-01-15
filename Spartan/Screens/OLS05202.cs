using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS05202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS05202", "FormName");
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
        public static WinFormsField SellPlan = new WinFormsField("SELL-PLAN", "SellPlan");
        public static WinFormsField SellPlanDesc = new WinFormsField("SELL-PLAN-DESC", "SellPlanDesc");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellRegDesc = new WinFormsField("SELL-REG-DESC", "SellRegDesc");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellHolderAddress = new WinFormsField("SELL-HOLDER-ADDRESS", "SellHolderAddress");
        public static WinFormsField BuySplitNumber = new WinFormsField("BUY-SPLIT-NUMBER", "BuySplitNumber");
        public static WinFormsField BuySplitUnits = new WinFormsField("BUY-SPLIT-UNITS", "BuySplitUnits");
        public static WinFormsField SellHolderWarnings = new WinFormsField("SELL-HOLDER-WARNINGS", "SellHolderWarnings");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
