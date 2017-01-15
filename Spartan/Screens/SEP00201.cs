using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP00201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField ATMeetingFlag = new WinFormsField("AT-MEETING-FLAG", "ATMeetingFlag");
        public static WinFormsField Chairman = new WinFormsField("CHAIRMAN", "Chairman");
        public static WinFormsField AllocateRun = new WinFormsField("ALLOCATE-RUN", "AllocateRun");
        public static WinFormsField NbrRes = new WinFormsField("NBR-RES", "NbrRes");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField OtherReqdInd = new WinFormsField("OTHER-REQD-IND", "OtherReqdInd");
        public static WinFormsField Class2nd = new WinFormsField("CLASS-2ND", "Class2nd");
        public static WinFormsField Rounding = new WinFormsField("ROUNDING", "Rounding");
        public static WinFormsField AttendeeConfirm = new WinFormsField("ATTENDEE-CONFIRM", "AttendeeConfirm");
        public static WinFormsField CompanyWarningYN = new WinFormsField("COMPANY-WARNING-YN", "CompanyWarningYN");
        public static WinFormsField AutoAttendeeNum = new WinFormsField("AUTO-ATTENDEE-NUM", "AutoAttendeeNum");
        public static WinFormsField NomNotPresent = new WinFormsField("NOM-NOT-PRESENT", "NomNotPresent");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
