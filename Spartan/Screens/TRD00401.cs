using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00401", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField TotalCount = new WinFormsField("TOTAL-COUNT", "TotalCount");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField CounterAddressLine = new WinFormsField("COUNTER-ADDRESS-LINE", "CounterAddressLine");
        public static WinFormsField MinimumDeal = new WinFormsField("MINIMUM-DEAL", "MinimumDeal");
        public static WinFormsField MaximumDeal = new WinFormsField("MAXIMUM-DEAL", "MaximumDeal");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField CounterpartyClass = new WinFormsField("COUNTERPARTY-CLASS", "CounterpartyClass");
        public static WinFormsField CounterRegCode = new WinFormsField("COUNTER-REG-CODE", "CounterRegCode");
        public static WinFormsField StatusDesc = new WinFormsField("STATUS-DESC", "StatusDesc");
        public static WinFormsField MenuAction = new WinFormsField("MENU-ACTION", "MenuAction");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField MenuDesc = new WinFormsField("MENU-DESC", "MenuDesc");
        public static WinFormsField MenuSelection = new WinFormsField("MENU-SELECTION", "MenuSelection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
