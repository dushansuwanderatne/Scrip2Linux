using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS96000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS96000", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField UKParticipantID = new WinFormsField("UK-PARTICIPANT-ID", "UKParticipantID");
        public static WinFormsField UKParticipantName = new WinFormsField("UK-PARTICIPANT-NAME", "UKParticipantName");
        public static WinFormsField UKParticipantType = new WinFormsField("UK-PARTICIPANT-TYPE", "UKParticipantType");
        public static WinFormsField AusParticipantID = new WinFormsField("AUS-PARTICIPANT-ID", "AusParticipantID");
        public static WinFormsField AusParticipantName = new WinFormsField("AUS-PARTICIPANT-NAME", "AusParticipantName");
        public static WinFormsField AusParticipantType = new WinFormsField("AUS-PARTICIPANT-TYPE", "AusParticipantType");
        //public static WinFormsField UKParticipantID = new WinFormsField("UK-PARTICIPANT-ID", "UKParticipantID");
        //public static WinFormsField AusParticipantID = new WinFormsField("AUS-PARTICIPANT-ID", "AusParticipantID");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
