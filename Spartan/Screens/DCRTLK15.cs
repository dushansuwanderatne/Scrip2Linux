using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCRTLK15

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCRTLK15", "FormName");
		//Fields


        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellRegister = new WinFormsField("SELL-REGISTER", "SellRegister");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyRegister = new WinFormsField("BUY-REGISTER", "BuyRegister");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField SellTradeReference = new WinFormsField("SELL-TRADE-REFERENCE", "SellTradeReference");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField BuyTradeReference = new WinFormsField("BUY-TRADE-REFERENCE", "BuyTradeReference");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuyCertID = new WinFormsField("BUY-CERT-ID", "BuyCertID");
        public static WinFormsField BuyTransDate = new WinFormsField("BUY-TRANS-DATE", "BuyTransDate");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField SellCert = new WinFormsField("SELL-CERT", "SellCert");
        public static WinFormsField SellUnits = new WinFormsField("SELL-UNITS", "SellUnits");
        public static WinFormsField SellTransDate = new WinFormsField("SELL-TRANS-DATE", "SellTransDate");
        public static WinFormsField SellCertIndicator = new WinFormsField("SELL-CERT-INDICATOR", "SellCertIndicator");
        public static WinFormsField SellCreatedThisRun = new WinFormsField("SELL-CREATED-THIS-RUN", "SellCreatedThisRun");
        public static WinFormsField BuyInstructions = new WinFormsField("BUY-INSTRUCTIONS", "BuyInstructions");
        public static WinFormsField RevRunNumber = new WinFormsField("REV-RUN-NUMBER", "RevRunNumber");
        public static WinFormsField RevTransNumber = new WinFormsField("REV-TRANS-NUMBER", "RevTransNumber");
        public static WinFormsField PaymentAmount = new WinFormsField("PAYMENT-AMOUNT", "PaymentAmount");
        public static WinFormsField Tolerance = new WinFormsField("TOLERANCE", "Tolerance");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
