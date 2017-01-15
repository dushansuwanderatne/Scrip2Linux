using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AESIND03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AESIND03", "FormName");
		//Fields


        public static WinFormsField CountryCode = new WinFormsField("COUNTRY-CODE", "CountryCode");
        public static WinFormsField Identifier = new WinFormsField("IDENTIFIER", "Identifier");
        public static WinFormsField DomicileDesc = new WinFormsField("DOMICILE-DESC", "DomicileDesc");
        public static WinFormsField BankCode = new WinFormsField("BANK-CODE", "BankCode");
        public static WinFormsField SwiftCode = new WinFormsField("SWIFT-CODE", "SwiftCode");
        public static WinFormsField AccountNumber = new WinFormsField("ACCOUNT-NUMBER", "AccountNumber");
        public static WinFormsField LastChgDate = new WinFormsField("LAST-CHG-DATE", "LastChgDate");
        public static WinFormsField LastChgMsgid = new WinFormsField("LAST-CHG-MSGID", "LastChgMsgid");
        public static WinFormsField LastChgName = new WinFormsField("LAST-CHG-NAME", "LastChgName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField NotingAction = new WinFormsField("NOTING-ACTION", "NotingAction");
        public static WinFormsField Locate = new WinFormsField("LOCATE", "Locate");
        public static WinFormsField SchCountryCode = new WinFormsField("SCH-COUNTRY-CODE", "SchCountryCode");
        public static WinFormsField SchBankCode = new WinFormsField("SCH-BANK-CODE", "SchBankCode");
        public static WinFormsField SchSwiftCode = new WinFormsField("SCH-SWIFT-CODE", "SchSwiftCode");
        public static WinFormsField SchAccountNbr = new WinFormsField("SCH-ACCOUNT-NBR", "SchAccountNbr");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
