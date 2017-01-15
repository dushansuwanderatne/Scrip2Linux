using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS10101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS10101", "FormName");
		//Fields


        public static WinFormsField MenuItemPet = new WinFormsField("MENU-ITEM-PET", "PET. Proxy Entry", "ProxyEntry");
        public static WinFormsField MenuItemCdp = new WinFormsField("MENU-ITEM-CDP", "CDP. Change/Delete Proxy", "Change/DeleteProxy");
        public static WinFormsField MenuItemPal = new WinFormsField("MENU-ITEM-PAL", "PAL. Proxy Audit Listing", "ProxyAuditListing");
        public static WinFormsField MenuItemSav = new WinFormsField("MENU-ITEM-SAV", "SAV. Schedule Allocate Votes", "ScheduleAllocateVotes");
        public static WinFormsField MenuItemMnp = new WinFormsField("MENU-ITEM-MNP", "MNP. Maintain Nominated Persons", "MaintainNominatedPersons");
        public static WinFormsField MenuItemPrs = new WinFormsField("MENU-ITEM-PRS", "PRS. Proxy Reporting System", "ProxyReportingSystem");
        public static WinFormsField MenuItemAet = new WinFormsField("MENU-ITEM-AET", "AET. Attendee Entry System", "AttendeeEntrySystem");
        public static WinFormsField MenuItemPup = new WinFormsField("MENU-ITEM-PUP", "PUP. Poll Updating", "PollUpdating");
        public static WinFormsField MenuItemPcu = new WinFormsField("MENU-ITEM-PCU", "PCU. Proxy Control Update", "ProxyControlUpdate");
        public static WinFormsField MenuItemPae = new WinFormsField("MENU-ITEM-PAE", "PAE. Post Attendee Entry", "PostAttendeeEntry");
        public static WinFormsField MenuItemPhv = new WinFormsField("MENU-ITEM-PHV", "PHV. Proxy Holder Vote Enquiry", "ProxyHolderVoteEnquiry");
        public static WinFormsField MenuItemPat = new WinFormsField("MENU-ITEM-PAT", "PAT. Proxy Attendee Enquiry", "ProxyAttendeeEnquiry");
        public static WinFormsField MenuItemPin = new WinFormsField("MENU-ITEM-PIN", "PIN. Proxy Initialization", "ProxyInitialization");
        public static WinFormsField MenuItemPhk = new WinFormsField("MENU-ITEM-PHK", "PHK. Proxy Housekeeping", "ProxyHousekeeping");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Proxy System", "ExitProxySystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
