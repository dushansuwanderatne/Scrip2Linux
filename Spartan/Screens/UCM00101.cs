using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UCM00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UCM00101", "FormName");
		//Fields


        public static WinFormsField MenuItemCU = new WinFormsField("MENU-ITEM-CU", "CU.  Conference Control Update", "ConferenceControlUpdate");
        public static WinFormsField MenuItemCA = new WinFormsField("MENU-ITEM-CA", "CA.  Conference Attendee Updating", "ConferenceAttendeeUpdating");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR.  Conference Reporting Menu", "ConferenceReportingMenu");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Conference Maintenance", "ExitConferenceMaintenance");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
