using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00409

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00409", "FormName");
		//Fields


        public static WinFormsField UnitsTOTrade = new WinFormsField("UNITS-TO-TRADE", "UnitsTOTrade");
        public static WinFormsField UnitBreakageAdj = new WinFormsField("UNIT-BREAKAGE-ADJ", "UnitBreakageAdj");
        public static WinFormsField CashLimitOverage = new WinFormsField("CASH-LIMIT-OVERAGE", "CashLimitOverage");
        public static WinFormsField ShareLimitOverage = new WinFormsField("SHARE-LIMIT-OVERAGE", "ShareLimitOverage");
        public static WinFormsField TaxSellTOCover = new WinFormsField("TAX-SELL-TO-COVER", "TaxSellTOCover");
        public static WinFormsField LimitAdjustment = new WinFormsField("LIMIT-ADJUSTMENT", "LimitAdjustment");
        public static WinFormsField EstChargeAdj = new WinFormsField("EST-CHARGE-ADJ", "EstChargeAdj");
        public static WinFormsField ChargePerUnit = new WinFormsField("CHARGE-PER-UNIT", "ChargePerUnit");
        public static WinFormsField CashTOTrade = new WinFormsField("CASH-TO-TRADE", "CashTOTrade");
        public static WinFormsField CashTopUP = new WinFormsField("CASH-TOP-UP", "CashTopUP");
        public static WinFormsField CashTopUPDesc = new WinFormsField("CASH-TOP-UP-DESC", "CashTopUPDesc");
        public static WinFormsField LatestSharePrice = new WinFormsField("LATEST-SHARE-PRICE", "LatestSharePrice");
        public static WinFormsField BreakagePreTrade = new WinFormsField("BREAKAGE-PRE-TRADE", "BreakagePreTrade");
        public static WinFormsField BreakagePostTrade = new WinFormsField("BREAKAGE-POST-TRADE", "BreakagePostTrade");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
