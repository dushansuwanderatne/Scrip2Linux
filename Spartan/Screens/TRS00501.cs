using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00501", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
        public static WinFormsField SessionTotal = new WinFormsField("SESSION-TOTAL", "SessionTotal");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
