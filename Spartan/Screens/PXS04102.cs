using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04102", "FormName");
		//Fields


        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderName = new WinFormsField("HOLDER-NAME", "HolderName");
        public static WinFormsField CurrentHolding = new WinFormsField("CURRENT-HOLDING", "CurrentHolding");
        public static WinFormsField CurrentVotes = new WinFormsField("CURRENT-VOTES", "CurrentVotes");
        public static WinFormsField Exclusion = new WinFormsField("EXCLUSION", "Exclusion");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalVotes = new WinFormsField("TOTAL-VOTES", "TotalVotes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
