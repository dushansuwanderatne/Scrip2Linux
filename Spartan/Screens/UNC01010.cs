using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UNC01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UNC01010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField IssuerSponsoredNbr = new WinFormsField("ISSUER-SPONSORED-NBR", "IssuerSponsoredNbr");
        public static WinFormsField HinAlternateID = new WinFormsField("HIN-ALTERNATE-ID", "HinAlternateID");
        public static WinFormsField NewRegister = new WinFormsField("NEW-REGISTER", "NewRegister");
        public static WinFormsField ExemptRegister = new WinFormsField("EXEMPT-REGISTER", "ExemptRegister");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField PrintCertDetails = new WinFormsField("PRINT-CERT-DETAILS", "PrintCertDetails");
        public static WinFormsField TranTypeIndicator = new WinFormsField("TRAN-TYPE-INDICATOR", "TranTypeIndicator");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField Layout = new WinFormsField("LAYOUT", "Layout");
        public static WinFormsField LayoutSeq = new WinFormsField("LAYOUT-SEQ", "LayoutSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
