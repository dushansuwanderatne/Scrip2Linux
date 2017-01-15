using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SAMC0102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SAMC0102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField ReportOnly = new WinFormsField("REPORT-ONLY", "ReportOnly");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Month = new WinFormsField("MONTH", "Month");
        public static WinFormsField Year = new WinFormsField("YEAR", "Year");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
    }
}
