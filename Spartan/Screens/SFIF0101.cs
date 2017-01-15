using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFIF0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFIF0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField JanA1 = new WinFormsField("JAN-A1", "JanA1");
        public static WinFormsField JanC1 = new WinFormsField("JAN-C1", "JanC1");
        public static WinFormsField JanA2 = new WinFormsField("JAN-A2", "JanA2");
        public static WinFormsField JanC2 = new WinFormsField("JAN-C2", "JanC2");
        public static WinFormsField JunA1 = new WinFormsField("JUN-A1", "JunA1");
        public static WinFormsField JunC1 = new WinFormsField("JUN-C1", "JunC1");
        public static WinFormsField JunA2 = new WinFormsField("JUN-A2", "JunA2");
        public static WinFormsField JunC2 = new WinFormsField("JUN-C2", "JunC2");
        public static WinFormsField NoticeSequence = new WinFormsField("NOTICE-SEQUENCE", "NoticeSequence");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
