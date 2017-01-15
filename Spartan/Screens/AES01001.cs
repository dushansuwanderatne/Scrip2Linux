using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AES01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AES01001", "FormName");
		//Fields


        public static WinFormsField NAIdentifier = new WinFormsField("NA-IDENTIFIER", "NAIdentifier");
        public static WinFormsField NameLine1 = new WinFormsField("NAME-LINE-1", "NameLine1");
        public static WinFormsField NameLine2 = new WinFormsField("NAME-LINE-2", "NameLine2");
        public static WinFormsField ADIdentifier = new WinFormsField("AD-IDENTIFIER", "ADIdentifier");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField AddLineTypes = new WinFormsField("ADD-LINE-TYPES", "AddLineTypes");
        public static WinFormsField CityName = new WinFormsField("CITY-NAME", "CityName");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField LastChgDate = new WinFormsField("LAST-CHG-DATE", "LastChgDate");
        public static WinFormsField LastChgMsgid = new WinFormsField("LAST-CHG-MSGID", "LastChgMsgid");
        public static WinFormsField LastChgName = new WinFormsField("LAST-CHG-NAME", "LastChgName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField NotingAction = new WinFormsField("NOTING-ACTION", "NotingAction");
        public static WinFormsField Locate = new WinFormsField("LOCATE", "Locate");
        public static WinFormsField AssocAction = new WinFormsField("ASSOC-ACTION", "AssocAction");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
