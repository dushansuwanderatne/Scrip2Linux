using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UCM00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UCM00103", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField AttendeeType = new WinFormsField("ATTENDEE-TYPE", "AttendeeType");
        public static WinFormsField ComputershareGuest = new WinFormsField("COMPUTERSHARE-GUEST", "ComputershareGuest");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchDetails = new WinFormsField("SEARCH-DETAILS", "SearchDetails");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
