using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0400", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField IncludeUnmApps = new WinFormsField("INCLUDE-UNM-APPS", "IncludeUnmApps");
        public static WinFormsField BrokerCodes = new WinFormsField("BROKER-CODES", "BrokerCodes");
        public static WinFormsField ClassCodes = new WinFormsField("CLASS-CODES", "ClassCodes");
        public static WinFormsField PrintClasses = new WinFormsField("PRINT-CLASSES", "PrintClasses");
        public static WinFormsField RunNumFrom = new WinFormsField("RUN-NUM-FROM", "RunNumFrom");
        public static WinFormsField RunNumTO = new WinFormsField("RUN-NUM-TO", "RunNumTO");
        public static WinFormsField LabelsRequired = new WinFormsField("LABELS-REQUIRED", "LabelsRequired");
        public static WinFormsField LabelHinPrint = new WinFormsField("LABEL-HIN-PRINT", "LabelHinPrint");
        public static WinFormsField LabelBalPrint = new WinFormsField("LABEL-BAL-PRINT", "LabelBalPrint");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
