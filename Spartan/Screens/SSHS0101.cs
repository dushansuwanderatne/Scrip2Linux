using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SSHS0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SSHS0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField TransGroupFrom = new WinFormsField("TRANS-GROUP-FROM", "TransGroupFrom");
        public static WinFormsField TransGroupTO = new WinFormsField("TRANS-GROUP-TO", "TransGroupTO");
        public static WinFormsField GroupBrokerCodes = new WinFormsField("GROUP-BROKER-CODES", "GroupBrokerCodes");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
