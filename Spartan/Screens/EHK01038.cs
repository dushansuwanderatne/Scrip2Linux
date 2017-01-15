using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01038

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01038", "FormName");
		//Fields
        public static WinFormsField Abn = new WinFormsField("ABN", "Abn");
        public static WinFormsField BranchNumber = new WinFormsField("BRANCH-NUMBER", "BranchNumber");
        public static WinFormsField ProviderNameLine = new WinFormsField("PROVIDER-NAME-LINE", "ProviderNameLine");
        public static WinFormsField TradingNameLine = new WinFormsField("TRADING-NAME-LINE", "TradingNameLine");
        public static WinFormsField PostalAddressLine = new WinFormsField("POSTAL-ADDRESS-LINE", "PostalAddressLine");
        public static WinFormsField PostalSuburb = new WinFormsField("POSTAL-SUBURB", "PostalSuburb");
        public static WinFormsField PostalState = new WinFormsField("POSTAL-STATE", "PostalState");
        public static WinFormsField PostalPostcode = new WinFormsField("POSTAL-POSTCODE", "PostalPostcode");
        public static WinFormsField PostalCountry = new WinFormsField("POSTAL-COUNTRY", "PostalCountry");
        public static WinFormsField AddressForNotices = new WinFormsField("ADDRESS-FOR-NOTICES", "AddressForNotices");
        public static WinFormsField CommunicationMethod = new WinFormsField("COMMUNICATION-METHOD", "CommunicationMethod");
        public static WinFormsField ProviderContactName = new WinFormsField("PROVIDER-CONTACT-NAME", "ProviderContactName");
        public static WinFormsField ProviderPhoneNumber = new WinFormsField("PROVIDER-PHONE-NUMBER", "ProviderPhoneNumber");
        public static WinFormsField ProviderEmailID = new WinFormsField("PROVIDER-EMAIL-ID", "ProviderEmailID");
        public static WinFormsField AuthorisedSignatory = new WinFormsField("AUTHORISED-SIGNATORY", "AuthorisedSignatory");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
