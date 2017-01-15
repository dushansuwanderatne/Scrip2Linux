using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00101", "FormName");
		//Fields


        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField DomicileName = new WinFormsField("DOMICILE-NAME", "DomicileName");
        public static WinFormsField ValidCountryInd = new WinFormsField("VALID-COUNTRY-IND", "ValidCountryInd");
        public static WinFormsField DomicileDivRate = new WinFormsField("DOMICILE-DIV-RATE", "DomicileDivRate");
        public static WinFormsField DomicileIntRate = new WinFormsField("DOMICILE-INT-RATE", "DomicileIntRate");
        public static WinFormsField DomicileNZDivRate = new WinFormsField("DOMICILE-NZ-DIV-RATE", "DomicileNZDivRate");
        public static WinFormsField DomicileNZIntRate = new WinFormsField("DOMICILE-NZ-INT-RATE", "DomicileNZIntRate");
        public static WinFormsField DomicileAlpha2 = new WinFormsField("DOMICILE-ALPHA-2", "DomicileAlpha2");
        public static WinFormsField DomicileNum3 = new WinFormsField("DOMICILE-NUM-3", "DomicileNum3");
        public static WinFormsField PostalZone = new WinFormsField("POSTAL-ZONE", "PostalZone");
        public static WinFormsField CurrencyPrefix = new WinFormsField("CURRENCY-PREFIX", "CurrencyPrefix");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField CurrencyDesc = new WinFormsField("CURRENCY-DESC", "CurrencyDesc");
        public static WinFormsField GcmEnabledInd = new WinFormsField("GCM-ENABLED-IND", "GcmEnabledInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField GcmRegion = new WinFormsField("GCM-REGION", "GcmRegion");
    }
}
