using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS03001", "FormName");
		//Fields


        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField Class01 = new WinFormsField("CLASS-01", "Class01");
        public static WinFormsField Value01 = new WinFormsField("VALUE-01", "Value01");
        public static WinFormsField Class02 = new WinFormsField("CLASS-02", "Class02");
        public static WinFormsField Value02 = new WinFormsField("VALUE-02", "Value02");
        public static WinFormsField Class03 = new WinFormsField("CLASS-03", "Class03");
        public static WinFormsField Value03 = new WinFormsField("VALUE-03", "Value03");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
