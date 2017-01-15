using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField ValidationDate = new WinFormsField("VALIDATION-DATE", "ValidationDate");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField MoneyCalc = new WinFormsField("MONEY-CALC", "MoneyCalc");
        public static WinFormsField CalctlNum = new WinFormsField("CALCTL-NUM", "CalctlNum");
        public static WinFormsField CallDescription = new WinFormsField("CALL-DESCRIPTION", "CallDescription");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField BuyClassDesc = new WinFormsField("BUY-CLASS-DESC", "BuyClassDesc");
        public static WinFormsField SellHin = new WinFormsField("SELL-HIN", "SellHin");
        public static WinFormsField SellHnaLine = new WinFormsField("SELL-HNA-LINE", "SellHnaLine");
        public static WinFormsField ToleranceText = new WinFormsField("TOLERANCE-TEXT", "ToleranceText");
        public static WinFormsField ToleranceAmount = new WinFormsField("TOLERANCE-AMOUNT", "ToleranceAmount");
        public static WinFormsField SellWarning = new WinFormsField("SELL-WARNING", "SellWarning");
        public static WinFormsField UncertBuyReg = new WinFormsField("UNCERT-BUY-REG", "UncertBuyReg");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
