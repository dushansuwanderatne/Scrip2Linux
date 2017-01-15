using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00101", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField MenuItemPet = new WinFormsField("MENU-ITEM-PET", "PET. Proxy Entry", "ProxyEntry");
        public static WinFormsField MenuItemCdp = new WinFormsField("MENU-ITEM-CDP", "CDP. Change/Delete Proxy", "Change/DeleteProxy");
        public static WinFormsField MenuItemPal = new WinFormsField("MENU-ITEM-PAL", "PAL. Proxy Audit Listing", "ProxyAuditListing");
        public static WinFormsField MenuItemSav = new WinFormsField("MENU-ITEM-SAV", "SAV. Schedule Allocate Votes", "ScheduleAllocateVotes");
        public static WinFormsField MenuItemMnp = new WinFormsField("MENU-ITEM-MNP", "MNP. Maintain Nominated Persons", "MaintainNominatedPersons");
        public static WinFormsField MenuItemPrs = new WinFormsField("MENU-ITEM-PRS", "PRS. Proxy Reporting System", "ProxyReportingSystem");
        public static WinFormsField MenuItemPre = new WinFormsField("MENU-ITEM-PRE", "PRE. Pre Close Registration Report", "PreCloseRegistrationReport");
        public static WinFormsField MenuItemAet = new WinFormsField("MENU-ITEM-AET", "AET. Attendee Entry System", "AttendeeEntrySystem");
        public static WinFormsField MenuItemScr = new WinFormsField("MENU-ITEM-SCR", "SCR. Schedule Close Regn/Process OR Failing", "ScheduleCloseRegn/ProcessORFailing");
        public static WinFormsField MenuItemPst = new WinFormsField("MENU-ITEM-PST", "PST. Post Close Registration Report", "PostCloseRegistrationReport");
        public static WinFormsField MenuItemPcu = new WinFormsField("MENU-ITEM-PCU", "PCU. Proxy Control Update", "ProxyControlUpdate");
        public static WinFormsField MenuItemPup = new WinFormsField("MENU-ITEM-PUP", "PUP. Poll Updating", "PollUpdating");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM- PR", " PR. Poll Results Report", "PollResultsReport");
        public static WinFormsField MenuItemPhv = new WinFormsField("MENU-ITEM-PHV", "PHV. Proxy Holder Vote Enquiry", "ProxyHolderVoteEnquiry");
        public static WinFormsField MenuItemPat = new WinFormsField("MENU-ITEM-PAT", "PAT. Proxy Attendee Enquiry", "ProxyAttendeeEnquiry");
        public static WinFormsField MenuItemCpb = new WinFormsField("MENU-ITEM-CPB", "CPB. Current Proxy Balance", "CurrentProxyBalance");
        public static WinFormsField MenuItemCmf = new WinFormsField("MENU-ITEM-CMF", "CMF. Create Membership File", "CreateMembershipFile");
        public static WinFormsField MenuItemNve = new WinFormsField("MENU-ITEM-NVE", "NVE. Nom Person Vote Enquiry", "NomPersonVoteEnquiry");
        public static WinFormsField MenuItemIml = new WinFormsField("MENU-ITEM-IML", "IML. IML System Reporting (menu)", "IMLSystemReporting(menu)");
        public static WinFormsField MenuItemDcv = new WinFormsField("MENU-ITEM-DCV", "DCV. Display Class Value", "DisplayClassValue");
        public static WinFormsField MenuItemCrt = new WinFormsField("MENU-ITEM-CRT", "CRT. Create / Refresh Top Holders", "Create/RefreshTopHolders");
        public static WinFormsField MenuItemThe = new WinFormsField("MENU-ITEM-THE", "THE. Top Holders Enquiry", "TopHoldersEnquiry");
        public static WinFormsField MenuItemImo = new WinFormsField("MENU-ITEM-IMO", "IMO. Intermediary Online Voting Intention Extract", "IntermediaryOnlineVotingIntentionExtract");
        public static WinFormsField MenuItemPin = new WinFormsField("MENU-ITEM-PIN", "PIN. Proxy Initialization", "ProxyInitialization");
        public static WinFormsField MenuItemPhk = new WinFormsField("MENU-ITEM-PHK", "PHK. Proxy Housekeeping", "ProxyHousekeeping");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Proxy System", "ExitProxySystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
