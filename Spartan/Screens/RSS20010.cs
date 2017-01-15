using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS20010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS20010", "FormName");
		//Fields


        public static WinFormsField ReportingID = new WinFormsField("REPORTING-ID", "ReportingID");
        public static WinFormsField RequestType = new WinFormsField("REQUEST-TYPE", "RequestType");
        public static WinFormsField ProcessingFrequency = new WinFormsField("PROCESSING-FREQUENCY", "ProcessingFrequency");
        public static WinFormsField ProcessingDay = new WinFormsField("PROCESSING-DAY", "ProcessingDay");
        public static WinFormsField ProcessingDayNbr = new WinFormsField("PROCESSING-DAY-NBR", "ProcessingDayNbr");
        public static WinFormsField ProcessingPeriod = new WinFormsField("PROCESSING-PERIOD", "ProcessingPeriod");
        public static WinFormsField ReportingStartDate = new WinFormsField("REPORTING-START-DATE", "ReportingStartDate");
        public static WinFormsField ReportingEndDate = new WinFormsField("REPORTING-END-DATE", "ReportingEndDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
