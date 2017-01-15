using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS08001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS08001", "FormName");
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
        public static WinFormsField PostcodeFrom = new WinFormsField("POSTCODE-FROM", "PostcodeFrom");
        public static WinFormsField PostcodeTO = new WinFormsField("POSTCODE-TO", "PostcodeTO");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField RunNumberFrom = new WinFormsField("RUN-NUMBER-FROM", "RunNumberFrom");
        public static WinFormsField RunNumberTO = new WinFormsField("RUN-NUMBER-TO", "RunNumberTO");
        public static WinFormsField LodgementDateFrom = new WinFormsField("LODGEMENT-DATE-FROM", "LodgementDateFrom");
        public static WinFormsField LodgementDateTO = new WinFormsField("LODGEMENT-DATE-TO", "LodgementDateTO");
        public static WinFormsField ReferenceNbrFrom = new WinFormsField("REFERENCE-NBR-FROM", "ReferenceNbrFrom");
        public static WinFormsField ReferenceNbrTO = new WinFormsField("REFERENCE-NBR-TO", "ReferenceNbrTO");
        public static WinFormsField SofValue = new WinFormsField("SOF-VALUE", "SofValue");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
