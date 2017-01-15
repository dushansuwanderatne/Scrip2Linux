using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class IATACH03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("IATACH03", "FormName");
		//Fields


        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField UpdateAllowedInd = new WinFormsField("UPDATE-ALLOWED-IND", "UpdateAllowedInd");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField StreetAddr = new WinFormsField("STREET-ADDR", "StreetAddr");
        public static WinFormsField City = new WinFormsField("CITY", "City");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField BankName = new WinFormsField("BANK-NAME", "BankName");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField IsoCountryCode = new WinFormsField("ISO-COUNTRY-CODE", "IsoCountryCode");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
