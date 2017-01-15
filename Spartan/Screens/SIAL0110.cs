using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SIAL0110

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SIAL0110", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField BrokerReportSeq = new WinFormsField("BROKER-REPORT-SEQ", "BrokerReportSeq");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField BkrsCol1 = new WinFormsField("BKRS-COL1", "BkrsCol1");
        public static WinFormsField BkrsCol2 = new WinFormsField("BKRS-COL2", "BkrsCol2");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField BrokerCutoff = new WinFormsField("BROKER-CUTOFF", "BrokerCutoff");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
