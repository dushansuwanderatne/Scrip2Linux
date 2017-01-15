using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS07601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS07601", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TkoctlNum = new WinFormsField("TKOCTL-NUM", "TkoctlNum");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellHolder = new WinFormsField("SELL-HOLDER", "SellHolder");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
