using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS09002
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS09002", "FormName");
        //Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField RepDate = new WinFormsField("REP-DATE", "RepDate");
        public static WinFormsField ExtractFileName = new WinFormsField("EXTRACT-FILE-NAME", "ExtractFileName");
        public static WinFormsField BkrsCol1 = new WinFormsField("BKRS-COL1", "BkrsCol1");
        public static WinFormsField BkrsCol2 = new WinFormsField("BKRS-COL2", "BkrsCol2");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ClgCon = new WinFormsField("CLG-CON", "ClgCon");
        public static WinFormsField RunFrom = new WinFormsField("RUN-FROM", "RunFrom");
        public static WinFormsField RunTO = new WinFormsField("RUN-TO", "RunTO");
        public static WinFormsField BrokerReportSeq = new WinFormsField("BROKER-REPORT-SEQ", "BrokerReportSeq");
        public static WinFormsField PrintUnknown = new WinFormsField("PRINT-UNKNOWN", "PrintUnknown");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField PrintHin = new WinFormsField("PRINT-HIN", "PrintHin");
        public static WinFormsField BrokerCommission = new WinFormsField("BROKER-COMMISSION", "BrokerCommission");
        public static WinFormsField CommissionFrom = new WinFormsField("COMMISSION-FROM", "CommissionFrom");
        public static WinFormsField CommissionTO = new WinFormsField("COMMISSION-TO", "CommissionTO");
        public static WinFormsField CommPerc = new WinFormsField("COMM-PERC", "CommPerc");
        public static WinFormsField FlatFee = new WinFormsField("FLAT-FEE", "FlatFee");
        public static WinFormsField ChequesRequired = new WinFormsField("CHEQUES-REQUIRED", "ChequesRequired");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
