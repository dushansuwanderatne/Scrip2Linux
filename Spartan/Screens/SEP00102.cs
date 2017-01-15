using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00102", "FormName");
		//Fields


        public static WinFormsField MenuItemPru = new WinFormsField("MENU-ITEM-PRU", "PRU. Poll Resolutions Update", "PollResolutionsUpdate");
        public static WinFormsField MenuItemPve = new WinFormsField("MENU-ITEM-PVE", "PVE. Poll Voting Entry", "PollVotingEntry");
        public static WinFormsField MenuItemDpe = new WinFormsField("MENU-ITEM-DPE", "DPE. Delete Poll Entry", "DeletePollEntry");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
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
