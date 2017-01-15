using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00803", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField BuyHolderCat = new WinFormsField("BUY-HOLDER-CAT", "BuyHolderCat");
        public static WinFormsField BuyClassType = new WinFormsField("BUY-CLASS-TYPE", "BuyClassType");
        public static WinFormsField BuyCertSplit = new WinFormsField("BUY-CERT-SPLIT", "BuyCertSplit");
        public static WinFormsField BuyCertificate = new WinFormsField("BUY-CERTIFICATE", "BuyCertificate");
        public static WinFormsField BuyClass = new WinFormsField("BUY-CLASS", "BuyClass");
        public static WinFormsField BuyRegister = new WinFormsField("BUY-REGISTER", "BuyRegister");
        public static WinFormsField BuyReference = new WinFormsField("BUY-REFERENCE", "BuyReference");
        public static WinFormsField BuyBroker = new WinFormsField("BUY-BROKER", "BuyBroker");
        public static WinFormsField BuyDateEntry = new WinFormsField("BUY-DATE-ENTRY", "BuyDateEntry");
        public static WinFormsField BuyForwardingIns = new WinFormsField("BUY-FORWARDING-INS", "BuyForwardingIns");
        public static WinFormsField BuyReissueBalance = new WinFormsField("BUY-REISSUE-BALANCE", "BuyReissueBalance");
        public static WinFormsField BuyHoldBalance = new WinFormsField("BUY-HOLD-BALANCE", "BuyHoldBalance");
        public static WinFormsField BuyCertType = new WinFormsField("BUY-CERT-TYPE", "BuyCertType");
        public static WinFormsField SpecialBuyScreen = new WinFormsField("SPECIAL-BUY-SCREEN", "SpecialBuyScreen");
    }
}
