using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS04210

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS04210", "FormName");
		//Fields


        public static WinFormsField BulkPaySystem = new WinFormsField("BULK-PAY-SYSTEM", "BulkPaySystem");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField CountryDescription = new WinFormsField("COUNTRY-DESCRIPTION", "CountryDescription");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField CurrencyCode = new WinFormsField("CURRENCY-CODE", "CurrencyCode");
        public static WinFormsField CurrencyDescription = new WinFormsField("CURRENCY-DESCRIPTION", "CurrencyDescription");
        public static WinFormsField BankAddressLine = new WinFormsField("BANK-ADDRESS-LINE", "BankAddressLine");
        public static WinFormsField ContactNumber = new WinFormsField("CONTACT-NUMBER", "ContactNumber");
        public static WinFormsField MiscDescription1 = new WinFormsField("MISC-DESCRIPTION-1", "MiscDescription1");
        public static WinFormsField Miscellaneous1 = new WinFormsField("MISCELLANEOUS-1", "Miscellaneous1");
        public static WinFormsField MiscDescription2 = new WinFormsField("MISC-DESCRIPTION-2", "MiscDescription2");
        public static WinFormsField Miscellaneous2 = new WinFormsField("MISCELLANEOUS-2", "Miscellaneous2");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
