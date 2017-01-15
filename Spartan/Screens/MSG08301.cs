using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08301", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField LseHeader = new WinFormsField("LSE-HEADER", "LseHeader");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField BidPrice = new WinFormsField("BID-PRICE", "BidPrice");
        public static WinFormsField BidPlusORMinus = new WinFormsField("BID-PLUS-OR-MINUS", "BidPlusORMinus");
        public static WinFormsField OfferPrice = new WinFormsField("OFFER-PRICE", "OfferPrice");
        public static WinFormsField OfferPlusORMinus = new WinFormsField("OFFER-PLUS-OR-MINUS", "OfferPlusORMinus");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
