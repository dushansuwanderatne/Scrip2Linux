using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK03003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK03003", "FormName");
		//Fields


        public static WinFormsField PayrollID = new WinFormsField("PAYROLL-ID", "PayrollID");
        public static WinFormsField PayrollDesc = new WinFormsField("PAYROLL-DESC", "PayrollDesc");
        public static WinFormsField PayeeNameLine = new WinFormsField("PAYEE-NAME-LINE", "PayeeNameLine");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField AusPostcode = new WinFormsField("AUS-POSTCODE", "AusPostcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
