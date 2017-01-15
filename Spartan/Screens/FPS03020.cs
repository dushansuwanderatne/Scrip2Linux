using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS03020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS03020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumberFrom = new WinFormsField("LOAN-NUMBER-FROM", "LoanNumberFrom");
        public static WinFormsField LoanNumberTO = new WinFormsField("LOAN-NUMBER-TO", "LoanNumberTO");
        public static WinFormsField MaturityDateFrom = new WinFormsField("MATURITY-DATE-FROM", "MaturityDateFrom");
        public static WinFormsField MaturityDateTO = new WinFormsField("MATURITY-DATE-TO", "MaturityDateTO");
        public static WinFormsField InterestRateFrom = new WinFormsField("INTEREST-RATE-FROM", "InterestRateFrom");
        public static WinFormsField InterestRateTO = new WinFormsField("INTEREST-RATE-TO", "InterestRateTO");
        public static WinFormsField InterestType = new WinFormsField("INTEREST-TYPE", "InterestType");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
