using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00202", "FormName");
		//Fields
        public static WinFormsField SettleDateDisplay = new WinFormsField("SETTLE-DATE-DISPLAY", "SettleDateDisplay");
        public static WinFormsField SettleDateConfirm = new WinFormsField("SETTLE-DATE-CONFIRM", "SettleDateConfirm");
        public static WinFormsField SettleConfirm = new WinFormsField("SETTLE-CONFIRM", "SettleConfirm");
        public static WinFormsField TradeDateDisplay = new WinFormsField("TRADE-DATE-DISPLAY", "TradeDateDisplay");
        public static WinFormsField TradeDateConfirm = new WinFormsField("TRADE-DATE-CONFIRM", "TradeDateConfirm");
        public static WinFormsField TradeConfirm = new WinFormsField("TRADE-CONFIRM", "TradeConfirm");
    }
}
