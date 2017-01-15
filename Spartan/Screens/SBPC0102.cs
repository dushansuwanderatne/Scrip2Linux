using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBPC0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBPC0102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField EmployeeClass = new WinFormsField("EMPLOYEE-CLASS", "EmployeeClass");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
