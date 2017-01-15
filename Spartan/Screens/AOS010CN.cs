using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS010CN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS010CN", "FormName");
		//Fields


        public static WinFormsField ConfirmDesc = new WinFormsField("CONFIRM-DESC", "ConfirmDesc");
        public static WinFormsField AssociatedNameID = new WinFormsField("ASSOCIATED-NAME-ID", "AssociatedNameID");
        public static WinFormsField AssociatedName = new WinFormsField("ASSOCIATED-NAME", "AssociatedName");
        public static WinFormsField ChangeID = new WinFormsField("CHANGE-ID", "ChangeID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField AddLineType = new WinFormsField("ADD-LINE-TYPE", "AddLineType");
        public static WinFormsField CityName = new WinFormsField("CITY-NAME", "CityName");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PhoneID = new WinFormsField("PHONE-ID", "PhoneID");
        public static WinFormsField PaymentInstID = new WinFormsField("PAYMENT-INST-ID", "PaymentInstID");
        public static WinFormsField LocalNumber = new WinFormsField("LOCAL-NUMBER", "LocalNumber");
        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField InterDialCode = new WinFormsField("INTER-DIAL-CODE", "InterDialCode");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField EmailID = new WinFormsField("EMAIL-ID", "EmailID");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
