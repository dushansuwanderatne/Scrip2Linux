using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTTA

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTTA", "FormName");
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
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellClassDesc = new WinFormsField("SELL-CLASS-DESC", "SellClassDesc");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField SellReg = new WinFormsField("SELL-REG", "SellReg");
        public static WinFormsField SellRegDesc = new WinFormsField("SELL-REG-DESC", "SellRegDesc");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField SellBrokerDesc = new WinFormsField("SELL-BROKER-DESC", "SellBrokerDesc");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField SellDate = new WinFormsField("SELL-DATE", "SellDate");
        public static WinFormsField SellAddressLine = new WinFormsField("SELL-ADDRESS-LINE", "SellAddressLine");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField SellWarning1to3 = new WinFormsField("SELL-WARNING-1TO3", "SellWarning1to3");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuySbn = new WinFormsField("BUY-SBN", "BuySbn");
        public static WinFormsField BuyReg = new WinFormsField("BUY-REG", "BuyReg");
        public static WinFormsField BuyReference = new WinFormsField("BUY-REFERENCE", "BuyReference");
        public static WinFormsField BuySearchName = new WinFormsField("BUY-SEARCH-NAME", "BuySearchName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
