using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03703

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03703", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderNumber = new WinFormsField("HOLDER-NUMBER", "HolderNumber");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField BuyORSell = new WinFormsField("BUY-OR-SELL", "BuyORSell");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField NewTradeReference = new WinFormsField("NEW-TRADE-REFERENCE", "NewTradeReference");
    }
}
