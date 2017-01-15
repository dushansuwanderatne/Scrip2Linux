using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD24008

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD24008", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField TradingCode = new WinFormsField("TRADING-CODE", "TradingCode");
        public static WinFormsField TradeDescription = new WinFormsField("TRADE-DESCRIPTION", "TradeDescription");
        public static WinFormsField TradeType = new WinFormsField("TRADE-TYPE", "TradeType");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField UnitAllocationInd = new WinFormsField("UNIT-ALLOCATION-IND", "UnitAllocationInd");
        public static WinFormsField ResidueProcessing = new WinFormsField("RESIDUE-PROCESSING", "ResidueProcessing");
        public static WinFormsField ResidueLevPaidout = new WinFormsField("RESIDUE-LEV-PAIDOUT", "ResidueLevPaidout");
        public static WinFormsField PriceBase = new WinFormsField("PRICE-BASE", "PriceBase");
        public static WinFormsField DiscountPercentage = new WinFormsField("DISCOUNT-PERCENTAGE", "DiscountPercentage");
        public static WinFormsField AllowDirectDebitInd = new WinFormsField("ALLOW-DIRECT-DEBIT-IND", "AllowDirectDebitInd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
