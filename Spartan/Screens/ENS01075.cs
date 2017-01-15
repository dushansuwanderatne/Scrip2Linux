using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01075

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01075", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField WRCountryCode = new WinFormsField("WR-COUNTRY-CODE", "WRCountryCode");
        public static WinFormsField WRCountryName = new WinFormsField("WR-COUNTRY-NAME", "WRCountryName");
        public static WinFormsField WRBulkPaySystem = new WinFormsField("WR-BULK-PAY-SYSTEM", "WRBulkPaySystem");
        public static WinFormsField WRBankCode = new WinFormsField("WR-BANK-CODE", "WRBankCode");
        public static WinFormsField WRSwiftCode = new WinFormsField("WR-SWIFT-CODE", "WRSwiftCode");
        public static WinFormsField WRAccountNumber = new WinFormsField("WR-ACCOUNT-NUMBER", "WRAccountNumber");
        public static WinFormsField WRAccountName = new WinFormsField("WR-ACCOUNT-NAME", "WRAccountName");
        public static WinFormsField WRCurrencyCode = new WinFormsField("WR-CURRENCY-CODE", "WRCurrencyCode");
        public static WinFormsField WRCurrencyDesc = new WinFormsField("WR-CURRENCY-DESC", "WRCurrencyDesc");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
