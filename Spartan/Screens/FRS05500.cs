using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS05500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS05500", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumberFrom = new WinFormsField("LOAN-NUMBER-FROM", "LoanNumberFrom");
        public static WinFormsField LoanNumberTO = new WinFormsField("LOAN-NUMBER-TO", "LoanNumberTO");
        public static WinFormsField MaturityDateFrom = new WinFormsField("MATURITY-DATE-FROM", "MaturityDateFrom");
        public static WinFormsField MaturityDateTO = new WinFormsField("MATURITY-DATE-TO", "MaturityDateTO");
        public static WinFormsField InterestRateFrom = new WinFormsField("INTEREST-RATE-FROM", "InterestRateFrom");
        public static WinFormsField InterestRateTO = new WinFormsField("INTEREST-RATE-TO", "InterestRateTO");
        public static WinFormsField Match = new WinFormsField("MATCH", "Match");
        public static WinFormsField HT = new WinFormsField("HT", "HT");
        public static WinFormsField Companies = new WinFormsField("COMPANIES", "Companies");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}