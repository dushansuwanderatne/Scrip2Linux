using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UCM00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UCM00104", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 2", "2");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField AttendeeDay1 = new WinFormsField("ATTENDEE-DAY-1", "AttendeeDay1");
        public static WinFormsField AttendeeDay2 = new WinFormsField("ATTENDEE-DAY-2", "AttendeeDay2");
        public static WinFormsField AttendeeDay3 = new WinFormsField("ATTENDEE-DAY-3", "AttendeeDay3");
        public static WinFormsField AttendeeDay4 = new WinFormsField("ATTENDEE-DAY-4", "AttendeeDay4");
        public static WinFormsField AttendeeDay5 = new WinFormsField("ATTENDEE-DAY-5", "AttendeeDay5");
        public static WinFormsField AttendeeDay6 = new WinFormsField("ATTENDEE-DAY-6", "AttendeeDay6");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField AttendeeSpouseName = new WinFormsField("ATTENDEE-SPOUSE-NAME", "AttendeeSpouseName");
        public static WinFormsField SeminFee = new WinFormsField("SEMIN-FEE", "SeminFee");
        public static WinFormsField AccommReq1 = new WinFormsField("ACCOMM-REQ-1", "AccommReq1");
        public static WinFormsField AccommReq2 = new WinFormsField("ACCOMM-REQ-2", "AccommReq2");
        public static WinFormsField AccommReq3 = new WinFormsField("ACCOMM-REQ-3", "AccommReq3");
        public static WinFormsField AccommReq4 = new WinFormsField("ACCOMM-REQ-4", "AccommReq4");
        public static WinFormsField AccommReq5 = new WinFormsField("ACCOMM-REQ-5", "AccommReq5");
        public static WinFormsField AccommReq6 = new WinFormsField("ACCOMM-REQ-6", "AccommReq6");
        public static WinFormsField DinnerFri = new WinFormsField("DINNER-FRI", "DinnerFri");
        public static WinFormsField DinnerSat = new WinFormsField("DINNER-SAT", "DinnerSat");
    }
}
