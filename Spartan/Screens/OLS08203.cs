using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08203", "FormName");
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
        public static WinFormsField Reference = new WinFormsField("REFERENCE", "Reference");
        public static WinFormsField CallNbr = new WinFormsField("CALL-NBR", "CallNbr");
        public static WinFormsField CallDescription = new WinFormsField("CALL-DESCRIPTION", "CallDescription");
        public static WinFormsField MoneyClass = new WinFormsField("MONEY-CLASS", "MoneyClass");
        public static WinFormsField MoneyClassDesc = new WinFormsField("MONEY-CLASS-DESC", "MoneyClassDesc");
        public static WinFormsField SellHin = new WinFormsField("SELL-HIN", "SellHin");
        public static WinFormsField BuyHin = new WinFormsField("BUY-HIN", "BuyHin");
        public static WinFormsField SellNoticeNbr = new WinFormsField("SELL-NOTICE-NBR", "SellNoticeNbr");
        public static WinFormsField BuyNoticeNbr = new WinFormsField("BUY-NOTICE-NBR", "BuyNoticeNbr");
        public static WinFormsField SellHnaLine = new WinFormsField("SELL-HNA-LINE", "SellHnaLine");
        public static WinFormsField BuyHnaLine = new WinFormsField("BUY-HNA-LINE", "BuyHnaLine");
        public static WinFormsField SellWarning = new WinFormsField("SELL-WARNING", "SellWarning");
        public static WinFormsField BuyWarning = new WinFormsField("BUY-WARNING", "BuyWarning");
        public static WinFormsField BuyException = new WinFormsField("BUY-EXCEPTION", "BuyException");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
