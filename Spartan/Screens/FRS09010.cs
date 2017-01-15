using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS09010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS09010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumberFrom = new WinFormsField("LOAN-NUMBER-FROM", "LoanNumberFrom");
        public static WinFormsField LoanNumberTO = new WinFormsField("LOAN-NUMBER-TO", "LoanNumberTO");
        public static WinFormsField MaturityDateFrom = new WinFormsField("MATURITY-DATE-FROM", "MaturityDateFrom");
        public static WinFormsField MaturityDateTO = new WinFormsField("MATURITY-DATE-TO", "MaturityDateTO");
        public static WinFormsField InterestRateFrom = new WinFormsField("INTEREST-RATE-FROM", "InterestRateFrom");
        public static WinFormsField InterestRateTO = new WinFormsField("INTEREST-RATE-TO", "InterestRateTO");
        public static WinFormsField BkrsCol1 = new WinFormsField("BKRS-COL1", "BkrsCol1");
        public static WinFormsField BkrsCol2 = new WinFormsField("BKRS-COL2", "BkrsCol2");
        public static WinFormsField BkrsCol3 = new WinFormsField("BKRS-COL3", "BkrsCol3");
        public static WinFormsField TransTypeCol1 = new WinFormsField("TRANS-TYPE-COL1", "TransTypeCol1");
        public static WinFormsField TransTypeCol2 = new WinFormsField("TRANS-TYPE-COL2", "TransTypeCol2");
        public static WinFormsField RunNumberFrom = new WinFormsField("RUN-NUMBER-FROM", "RunNumberFrom");
        public static WinFormsField RunNumberTO = new WinFormsField("RUN-NUMBER-TO", "RunNumberTO");
        public static WinFormsField LodgeDateFrom = new WinFormsField("LODGE-DATE-FROM", "LodgeDateFrom");
        public static WinFormsField LodgeDateTO = new WinFormsField("LODGE-DATE-TO", "LodgeDateTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
