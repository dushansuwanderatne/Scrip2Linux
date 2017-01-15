using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS09011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS09011", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BrokerReportSeq = new WinFormsField("BROKER-REPORT-SEQ", "BrokerReportSeq");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField PrintUnknown = new WinFormsField("PRINT-UNKNOWN", "PrintUnknown");
        public static WinFormsField BrokerCommission = new WinFormsField("BROKER-COMMISSION", "BrokerCommission");
        public static WinFormsField StandardCommPercent = new WinFormsField("STANDARD-COMM-PERCENT", "StandardCommPercent");
        public static WinFormsField SpecialFidComm = new WinFormsField("SPECIAL-FID-COMM", "SpecialFidComm");
        public static WinFormsField ChequesRequired = new WinFormsField("CHEQUES-REQUIRED", "ChequesRequired");
        public static WinFormsField ChequeFormat = new WinFormsField("CHEQUE-FORMAT", "ChequeFormat");
        public static WinFormsField ChequeDate = new WinFormsField("CHEQUE-DATE", "ChequeDate");
        public static WinFormsField UpperComment = new WinFormsField("UPPER-COMMENT", "UpperComment");
        public static WinFormsField LowerComment = new WinFormsField("LOWER-COMMENT", "LowerComment");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
