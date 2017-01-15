using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00401", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField MenuItemPE = new WinFormsField("MENU-ITEM-PE", "PE. Proxy Extract Listing", "ProxyExtractListing");
        public static WinFormsField MenuItemNP = new WinFormsField("MENU-ITEM-NP", "NP. Selected Nominated Persons Listing", "SelectedNominatedPersonsListing");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM-PR", "PR. Proxy Listing by Resolution", "ProxyListingbyResolution");
        public static WinFormsField MenuItemIS = new WinFormsField("MENU-ITEM-IS", "IS. Indicative Voting Summary", "IndicativeVotingSummary");
        public static WinFormsField MenuItemNC = new WinFormsField("MENU-ITEM-NC", "NC. Nominated Person Code Listing", "NominatedPersonCodeListing");
        public static WinFormsField MenuItemBP = new WinFormsField("MENU-ITEM-BP", "BP. Brief Proxy Listing", "BriefProxyListing");
        public static WinFormsField MenuItemVS = new WinFormsField("MENU-ITEM-VS", "VS. Voting Selection Report", "VotingSelectionReport");
        public static WinFormsField MenuItemVF = new WinFormsField("MENU-ITEM-VF", "VF. Produce Voting Forms", "ProduceVotingForms");
        public static WinFormsField MenuItemAT = new WinFormsField("MENU-ITEM-AT", "AT. Attendee Listing", "AttendeeListing");
        public static WinFormsField MenuItemNV = new WinFormsField("MENU-ITEM-NV", "NV. Non-voting attendees listing", "Non-votingattendeeslisting");
        public static WinFormsField MenuItemAE = new WinFormsField("MENU-ITEM-AE", "AE. Attendee Enquiry Display", "AttendeeEnquiryDisplay");
        public static WinFormsField MenuItemAM = new WinFormsField("MENU-ITEM-AM", "AM. Amendment Listing", "AmendmentListing");
        public static WinFormsField MenuItemPC = new WinFormsField("MENU-ITEM-PC", "PC. Proxy Control Listing", "ProxyControlListing");
        public static WinFormsField MenuItemMR = new WinFormsField("MENU-ITEM-MR", "MR. Membership Report", "MembershipReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Proxy Reporting System", "ExitProxyReportingSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
