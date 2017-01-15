using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS01060", "FormName");
		//Fields


        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField RepASATRun = new WinFormsField("REP-AS-AT-RUN", "RepASATRun");
        public static WinFormsField ReportFormat = new WinFormsField("REPORT-FORMAT", "ReportFormat");
        public static WinFormsField Selcls1 = new WinFormsField("SELCLS-1", "Selcls1");
        public static WinFormsField Selcls2 = new WinFormsField("SELCLS-2", "Selcls2");
        public static WinFormsField UseClassPrice = new WinFormsField("USE-CLASS-PRICE", "UseClassPrice");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
