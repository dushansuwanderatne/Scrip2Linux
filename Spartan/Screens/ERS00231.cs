using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00231

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00231", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField Classes = new WinFormsField("CLASSES", "Classes");
        public static WinFormsField Ctind = new WinFormsField("CTIND", "Ctind");
        public static WinFormsField Elcdn = new WinFormsField("ELCDN", "Elcdn");
        public static WinFormsField Capdn = new WinFormsField("CAPDN", "Capdn");
        public static WinFormsField ContributionTran = new WinFormsField("CONTRIBUTION-TRAN", "ContributionTran");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
