using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKOCTL11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKOCTL11", "FormName");
		//Fields


        public static WinFormsField TkoctlKey0 = new WinFormsField("TKOCTL-KEY0", "TkoctlKey0");
        public static WinFormsField OfferClass = new WinFormsField("OFFER-CLASS", "OfferClass");
        public static WinFormsField OfferClassDesc = new WinFormsField("OFFER-CLASS-DESC", "OfferClassDesc");
        public static WinFormsField TypeOFOffer = new WinFormsField("TYPE-OF-OFFER", "TypeOFOffer");
        public static WinFormsField OfferX = new WinFormsField("OFFER-X", "OfferX");
        public static WinFormsField OfferY = new WinFormsField("OFFER-Y", "OfferY");
        public static WinFormsField OfferParcelAmount = new WinFormsField("OFFER-PARCEL-AMOUNT", "OfferParcelAmount");
        public static WinFormsField OfferFractionAmount = new WinFormsField("OFFER-FRACTION-AMOUNT", "OfferFractionAmount");
        public static WinFormsField CashPerShare = new WinFormsField("CASH-PER-SHARE", "CashPerShare");
        public static WinFormsField CashCashClass = new WinFormsField("CASH-CASH-CLASS", "CashCashClass");
        public static WinFormsField ShareAcceptanceClass = new WinFormsField("SHARE-ACCEPTANCE-CLASS", "ShareAcceptanceClass");
        public static WinFormsField ShareHistoryClass = new WinFormsField("SHARE-HISTORY-CLASS", "ShareHistoryClass");
        public static WinFormsField ShareParcelClass = new WinFormsField("SHARE-PARCEL-CLASS", "ShareParcelClass");
        public static WinFormsField ShareFractionsClass = new WinFormsField("SHARE-FRACTIONS-CLASS", "ShareFractionsClass");
        public static WinFormsField ShareTakeovererClass = new WinFormsField("SHARE-TAKEOVERER-CLASS", "ShareTakeovererClass");
        public static WinFormsField CashAcceptanceClass = new WinFormsField("CASH-ACCEPTANCE-CLASS", "CashAcceptanceClass");
        public static WinFormsField CashHistoryClass = new WinFormsField("CASH-HISTORY-CLASS", "CashHistoryClass");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField AsxTakeoverCode = new WinFormsField("ASX-TAKEOVER-CODE", "AsxTakeoverCode");
        public static WinFormsField AsxTakeoverDesc = new WinFormsField("ASX-TAKEOVER-DESC", "AsxTakeoverDesc");
    }
}
