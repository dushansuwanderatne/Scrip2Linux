using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS00201", "FormName");
		//Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField ATMeetingFlag = new WinFormsField("AT-MEETING-FLAG", "ATMeetingFlag");
        public static WinFormsField AllocateRun = new WinFormsField("ALLOCATE-RUN", "AllocateRun");
        public static WinFormsField Chairman = new WinFormsField("CHAIRMAN", "Chairman");
        public static WinFormsField NbrRes = new WinFormsField("NBR-RES", "NbrRes");
        public static WinFormsField DisplayProxyWatch = new WinFormsField("DISPLAY-PROXY-WATCH", "DisplayProxyWatch");
        public static WinFormsField PWFinalProxyFigInd = new WinFormsField("PW-FINAL-PROXY-FIG-IND", "PWFinalProxyFigInd");
        public static WinFormsField SchemeMeetingInd = new WinFormsField("SCHEME-MEETING-IND", "SchemeMeetingInd");
        public static WinFormsField InternetMeeting = new WinFormsField("INTERNET-MEETING", "InternetMeeting");
        public static WinFormsField AlgorithmNumber = new WinFormsField("ALGORITHM-NUMBER", "AlgorithmNumber");
        public static WinFormsField RemResOpenVotes = new WinFormsField("REM-RES-OPEN-VOTES", "RemResOpenVotes");
        public static WinFormsField ClassVotesInd = new WinFormsField("CLASS-VOTES-IND", "ClassVotesInd");
        public static WinFormsField SameClasses = new WinFormsField("SAME-CLASSES", "SameClasses");
        public static WinFormsField DirectVotingInd = new WinFormsField("DIRECT-VOTING-IND", "DirectVotingInd");
        public static WinFormsField ProcessingCutoff = new WinFormsField("PROCESSING-CUTOFF", "ProcessingCutoff");
        public static WinFormsField ManualProcessCutOff = new WinFormsField("MANUAL PROCESS CUT-OFF", "ManualProcessCutOff");
        public static WinFormsField ColourCodingYN = new WinFormsField("COLOUR-CODING-YN", "ColourCodingYN");
        public static WinFormsField AutoAttendeeNum = new WinFormsField("AUTO-ATTENDEE-NUM", "AutoAttendeeNum");
        public static WinFormsField AttendeeConfirm = new WinFormsField("ATTENDEE-CONFIRM", "AttendeeConfirm");
        public static WinFormsField CompanyWarningYN = new WinFormsField("COMPANY-WARNING-YN", "CompanyWarningYN");
        public static WinFormsField NomNotPresent = new WinFormsField("NOM-NOT-PRESENT", "NomNotPresent");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
