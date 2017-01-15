using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAYIAT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAYIAT01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField PayiatKey0 = new WinFormsField("PAYIAT-KEY0", "PayiatKey0");
        public static WinFormsField IatCode = new WinFormsField("IAT-CODE", "IatCode");
        public static WinFormsField OriginatorName = new WinFormsField("ORIGINATOR-NAME", "OriginatorName");
        public static WinFormsField OriginatorStreetAddr = new WinFormsField("ORIGINATOR-STREET-ADDR", "OriginatorStreetAddr");
        public static WinFormsField OriginatorCity = new WinFormsField("ORIGINATOR-CITY", "OriginatorCity");
        public static WinFormsField OriginatorState = new WinFormsField("ORIGINATOR-STATE", "OriginatorState");
        public static WinFormsField OriginatorPostcode = new WinFormsField("ORIGINATOR-POSTCODE", "OriginatorPostcode");
        public static WinFormsField OriginatorDomicile = new WinFormsField("ORIGINATOR-DOMICILE", "OriginatorDomicile");
        public static WinFormsField BankName = new WinFormsField("BANK-NAME", "BankName");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField IsoCountryCode = new WinFormsField("ISO-COUNTRY-CODE", "IsoCountryCode");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField UpdateAllowedInd = new WinFormsField("UPDATE-ALLOWED-IND", "UpdateAllowedInd");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
    }
}
