using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00802", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField SellHolderCat = new WinFormsField("SELL-HOLDER-CAT", "SellHolderCat");
        public static WinFormsField SellClassType = new WinFormsField("SELL-CLASS-TYPE", "SellClassType");
        public static WinFormsField SellHolder = new WinFormsField("SELL-HOLDER", "SellHolder");
        public static WinFormsField SellClass = new WinFormsField("SELL-CLASS", "SellClass");
        public static WinFormsField SellRegister = new WinFormsField("SELL-REGISTER", "SellRegister");
        public static WinFormsField SellReference = new WinFormsField("SELL-REFERENCE", "SellReference");
        public static WinFormsField SellBroker = new WinFormsField("SELL-BROKER", "SellBroker");
        public static WinFormsField FullHldPreloadCert = new WinFormsField("FULL-HLD-PRELOAD-CERT", "FullHldPreloadCert");
        public static WinFormsField SellDateEntry = new WinFormsField("SELL-DATE-ENTRY", "SellDateEntry");
        public static WinFormsField SellCertificate = new WinFormsField("SELL-CERTIFICATE", "SellCertificate");
        public static WinFormsField SellCumUnitsFull = new WinFormsField("SELL-CUM-UNITS-FULL", "SellCumUnitsFull");
        public static WinFormsField PartialSellCerts = new WinFormsField("PARTIAL-SELL-CERTS", "PartialSellCerts");
        public static WinFormsField PartialSellMarkings = new WinFormsField("PARTIAL-SELL-MARKINGS", "PartialSellMarkings");
        public static WinFormsField PartialSellHolding = new WinFormsField("PARTIAL-SELL-HOLDING", "PartialSellHolding");
        public static WinFormsField NOSellCertTypes = new WinFormsField("NO-SELL-CERT-TYPES", "NOSellCertTypes");
        public static WinFormsField PosMessageResponse = new WinFormsField("POS-MESSAGE-RESPONSE", "PosMessageResponse");
        public static WinFormsField SpecialSellScreen = new WinFormsField("SPECIAL-SELL-SCREEN", "SpecialSellScreen");
        public static WinFormsField NegMessageResponse = new WinFormsField("NEG-MESSAGE-RESPONSE", "NegMessageResponse");
    }
}
