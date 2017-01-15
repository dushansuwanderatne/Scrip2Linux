using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SGEM0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SGEM0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField PeriodDate = new WinFormsField("PERIOD-DATE", "PeriodDate");
        public static WinFormsField DistributionPeriod = new WinFormsField("DISTRIBUTION-PERIOD", "DistributionPeriod");
        public static WinFormsField BrokerRate = new WinFormsField("BROKER-RATE", "BrokerRate");
        public static WinFormsField OrdUnitPrice = new WinFormsField("ORD-UNIT-PRICE", "OrdUnitPrice");
        public static WinFormsField IncUnitPrice = new WinFormsField("INC-UNIT-PRICE", "IncUnitPrice");
        public static WinFormsField GroUnitPrice = new WinFormsField("GRO-UNIT-PRICE", "GroUnitPrice");
        public static WinFormsField CutoffRun = new WinFormsField("CUTOFF-RUN", "CutoffRun");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
