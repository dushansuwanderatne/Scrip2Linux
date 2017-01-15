using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSMNYUU

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSMNYUU", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField LodgeDate = new WinFormsField("LODGE-DATE", "LodgeDate");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellSbn = new WinFormsField("SELL-SBN", "SellSbn");
        public static WinFormsField SellSearchName = new WinFormsField("SELL-SEARCH-NAME", "SellSearchName");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField CheckNumberX = new WinFormsField("CHECK-NUMBER-X", "CheckNumberX");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuySbn = new WinFormsField("BUY-SBN", "BuySbn");
        public static WinFormsField BuySearchName = new WinFormsField("BUY-SEARCH-NAME", "BuySearchName");
        public static WinFormsField BuyReference = new WinFormsField("BUY-REFERENCE", "BuyReference");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuyTransDate = new WinFormsField("BUY-TRANS-DATE", "BuyTransDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
