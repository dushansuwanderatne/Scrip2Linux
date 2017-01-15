using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UCM00105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UCM00105", "FormName");
		//Fields


        public static WinFormsField MenuItemAL = new WinFormsField("MENU-ITEM-AL", "AL.  Attendee/Accommodation Listing", "Attendee/AccommodationListing");
        public static WinFormsField MenuItemAI = new WinFormsField("MENU-ITEM-AI", "AI.  Attendee Invoices", "AttendeeInvoices");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit From Reporting Menu", "ExitFromReportingMenu");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
