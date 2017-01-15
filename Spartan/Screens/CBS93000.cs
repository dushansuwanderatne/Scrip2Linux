using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS93000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS93000", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField DefaultHin = new WinFormsField("DEFAULT-HIN", "DefaultHin");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Contact = new WinFormsField("CONTACT", "Contact");
        public static WinFormsField Phone = new WinFormsField("PHONE", "Phone");
        public static WinFormsField Fax = new WinFormsField("FAX", "Fax");
        public static WinFormsField CashFloat = new WinFormsField("CASH-FLOAT", "CashFloat");
        public static WinFormsField CurrentPosition = new WinFormsField("CURRENT-POSITION", "CurrentPosition");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchCode = new WinFormsField("SEARCH-CODE", "SearchCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
