using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS04101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS04101", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField RefNumber = new WinFormsField("REF-NUMBER", "RefNumber");
        public static WinFormsField LodgmentDate = new WinFormsField("LODGMENT-DATE", "LodgmentDate");
        public static WinFormsField ProxyRunNumber = new WinFormsField("PROXY-RUN-NUMBER", "ProxyRunNumber");
        public static WinFormsField VotingMethod = new WinFormsField("VOTING-METHOD", "VotingMethod");
        public static WinFormsField TotalUnits = new WinFormsField("TOTAL-UNITS", "TotalUnits");
        public static WinFormsField TotalVotes = new WinFormsField("TOTAL-VOTES", "TotalVotes");
        public static WinFormsField CurrentHolding = new WinFormsField("CURRENT-HOLDING", "CurrentHolding");
        public static WinFormsField CurrentVotes = new WinFormsField("CURRENT-VOTES", "CurrentVotes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField HolderSearchKey = new WinFormsField("HOLDER-SEARCH-KEY", "HolderSearchKey");
        public static WinFormsField PinX = new WinFormsField("PIN-X", "PinX");
        public static WinFormsField GpatControlNumberX = new WinFormsField("GPAT-CONTROL-NUMBER-X", "GpatControlNumberX");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
