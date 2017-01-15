using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSFSPP1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSFSPP1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField BidCurr = new WinFormsField("BID-CURR", "BidCurr");
        public static WinFormsField BidNum = new WinFormsField("BID-NUM", "BidNum");
        public static WinFormsField OfferCurr = new WinFormsField("OFFER-CURR", "OfferCurr");
        public static WinFormsField OfferNum = new WinFormsField("OFFER-NUM", "OfferNum");
        public static WinFormsField BidPriceTstamp = new WinFormsField("BID-PRICE-TSTAMP", "BidPriceTstamp");
        public static WinFormsField OfferPriceTstamp = new WinFormsField("OFFER-PRICE-TSTAMP", "OfferPriceTstamp");
    }
}
