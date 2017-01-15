using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00403", "FormName");
		//Fields
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterAddressLine = new WinFormsField("COUNTER-ADDRESS-LINE", "CounterAddressLine");
        public static WinFormsField ConfirmSettleDate = new WinFormsField("CONFIRM-SETTLE-DATE", "ConfirmSettleDate");
        public static WinFormsField ConfirmTradeDate = new WinFormsField("CONFIRM-TRADE-DATE", "ConfirmTradeDate");
        public static WinFormsField ConfirmTradePrice = new WinFormsField("CONFIRM-TRADE-PRICE", "ConfirmTradePrice");
        public static WinFormsField ConfirmFinalPrice = new WinFormsField("CONFIRM-FINAL-PRICE", "ConfirmFinalPrice");
        public static WinFormsField GrantFmv = new WinFormsField("GRANT-FMV", "GrantFmv");
        public static WinFormsField GrantDate = new WinFormsField("GRANT-DATE", "GrantDate");
        public static WinFormsField EndOFOffer = new WinFormsField("END-OF-OFFER", "EndOFOffer");
        public static WinFormsField SaleRestrictDate = new WinFormsField("SALE-RESTRICT-DATE", "SaleRestrictDate");
        public static WinFormsField TrfRestrictDate = new WinFormsField("TRF-RESTRICT-DATE", "TrfRestrictDate");
        public static WinFormsField ConfirmEffectTrade = new WinFormsField("CONFIRM-EFFECT-TRADE", "ConfirmEffectTrade");
        public static WinFormsField CalcFinalPrice = new WinFormsField("CALC-FINAL-PRICE", "CalcFinalPrice");
        public static WinFormsField ConfirmCalcPrice = new WinFormsField("CONFIRM-CALC-PRICE", "ConfirmCalcPrice");
        public static WinFormsField CnfrmChngdReuters = new WinFormsField("CNFRM-CHNGD-REUTERS", "CnfrmChngdReuters");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
