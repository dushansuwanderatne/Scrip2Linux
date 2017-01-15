using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00110", "FormName");
		//Fields


        public static WinFormsField MenuItemUnload = new WinFormsField("MENU-ITEM-UNLOAD", "UNLOAD. Unload attendees to flat file", "Unloadattendeestoflatfile");
        public static WinFormsField MenuItemLoad = new WinFormsField("MENU-ITEM-  LOAD", "  LOAD. Load attendees from flat file", "Loadattendeesfromflatfile");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Proxy Housekeeping", "ExitProxyHousekeeping");
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
