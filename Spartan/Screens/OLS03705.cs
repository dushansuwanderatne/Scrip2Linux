using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03705

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03705", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransferNumber = new WinFormsField("TRANSFER-NUMBER", "TransferNumber");
        public static WinFormsField BuyORSell = new WinFormsField("BUY-OR-SELL", "BuyORSell");
        public static WinFormsField OldBrokerCode = new WinFormsField("OLD-BROKER-CODE", "OldBrokerCode");
        public static WinFormsField NewBrokerCode = new WinFormsField("NEW-BROKER-CODE", "NewBrokerCode");
    }
}
