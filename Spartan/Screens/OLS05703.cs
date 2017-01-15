using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS05703

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS05703", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyClassDesc = new WinFormsField("BUY-CLASS-DESC", "BuyClassDesc");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyRegDesc = new WinFormsField("BUY-REG-DESC", "BuyRegDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuyBrokerDesc = new WinFormsField("BUY-BROKER-DESC", "BuyBrokerDesc");
        public static WinFormsField BuyTradeReference = new WinFormsField("BUY-TRADE-REFERENCE", "BuyTradeReference");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField BuyHnaLine = new WinFormsField("BUY-HNA-LINE", "BuyHnaLine");
        public static WinFormsField ConfirmUnits = new WinFormsField("CONFIRM-UNITS", "ConfirmUnits");
        public static WinFormsField BuyWarning = new WinFormsField("BUY-WARNING", "BuyWarning");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
