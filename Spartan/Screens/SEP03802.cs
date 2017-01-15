using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP03802

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP03802", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField AttendeeNumber = new WinFormsField("ATTENDEE-NUMBER", "AttendeeNumber");
        public static WinFormsField Resolution = new WinFormsField("RESOLUTION", "Resolution");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField UnitsFor = new WinFormsField("UNITS-FOR", "UnitsFor");
        public static WinFormsField UnitsAgainst = new WinFormsField("UNITS-AGAINST", "UnitsAgainst");
        public static WinFormsField UnitsOpen = new WinFormsField("UNITS-OPEN", "UnitsOpen");
        public static WinFormsField UnitsAbstain = new WinFormsField("UNITS-ABSTAIN", "UnitsAbstain");
        public static WinFormsField MoreCodes = new WinFormsField("MORE-CODES", "MoreCodes");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
