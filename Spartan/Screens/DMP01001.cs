using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01001", "FormName");
		//Fields


        public static WinFormsField DumpDescription = new WinFormsField("DUMP-DESCRIPTION", "DumpDescription");
        public static WinFormsField UpdateReportRun = new WinFormsField("UPDATE-REPORT-RUN", "UpdateReportRun");
        public static WinFormsField DumpPayments = new WinFormsField("DUMP-PAYMENTS", "DumpPayments");
        public static WinFormsField InpPaymentFileInd = new WinFormsField("INP-PAYMENT-FILE-IND", "InpPaymentFileInd");
        public static WinFormsField InpPaymentFileName = new WinFormsField("INP-PAYMENT-FILE-NAME", "InpPaymentFileName");
        public static WinFormsField DumpCertificates = new WinFormsField("DUMP-CERTIFICATES", "DumpCertificates");
        public static WinFormsField DumpPlanDetails = new WinFormsField("DUMP-PLAN-DETAILS", "DumpPlanDetails");
        public static WinFormsField DumpWithdrawnPlan = new WinFormsField("DUMP-WITHDRAWN-PLAN", "DumpWithdrawnPlan");
        public static WinFormsField DumpDivhis = new WinFormsField("DUMP-DIVHIS", "DumpDivhis");
        public static WinFormsField DumpPostChessConv = new WinFormsField("DUMP-POST-CHESS-CONV", "DumpPostChessConv");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
