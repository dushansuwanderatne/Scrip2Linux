using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0403", "FormName");
		//Fields


        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField CounterAddressLine = new WinFormsField("COUNTER-ADDRESS-LINE", "CounterAddressLine");
        public static WinFormsField MultiDayVwap = new WinFormsField("MULTI-DAY-VWAP", "MultiDayVwap");
        public static WinFormsField ConfirmSettlement = new WinFormsField("CONFIRM-SETTLEMENT", "ConfirmSettlement");
        public static WinFormsField ConfirmTradeTime = new WinFormsField("CONFIRM-TRADE-TIME", "ConfirmTradeTime");
        public static WinFormsField ConfirmFinalPrice = new WinFormsField("CONFIRM-FINAL-PRICE", "ConfirmFinalPrice");
        public static WinFormsField ConfirmPriceDiff = new WinFormsField("CONFIRM-PRICE-DIFF", "ConfirmPriceDiff");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
