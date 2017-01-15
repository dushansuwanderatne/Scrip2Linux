using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK02001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumber = new WinFormsField("LOAN-NUMBER", "LoanNumber");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField AustraclearCode = new WinFormsField("AUSTRACLEAR-CODE", "AustraclearCode");
        public static WinFormsField SubholderName = new WinFormsField("SUBHOLDER-NAME", "SubholderName");
        public static WinFormsField SubholderBalance = new WinFormsField("SUBHOLDER-BALANCE", "SubholderBalance");
        public static WinFormsField Submission = new WinFormsField("SUBMISSION", "Submission");
        public static WinFormsField Detail = new WinFormsField("DETAIL", "Detail");
        public static WinFormsField Action1 = new WinFormsField("ACTION1", "Action1");
        public static WinFormsField Action2 = new WinFormsField("ACTION2", "Action2");
        public static WinFormsField SearchLoanType = new WinFormsField("SEARCH-LOAN-TYPE", "SearchLoanType");
        public static WinFormsField SearchLoanNumber = new WinFormsField("SEARCH-LOAN-NUMBER", "SearchLoanNumber");
        public static WinFormsField SearchMaturityDate = new WinFormsField("SEARCH-MATURITY-DATE", "SearchMaturityDate");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchInterestRate = new WinFormsField("SEARCH-INTEREST-RATE", "SearchInterestRate");
        public static WinFormsField SearchAustCode = new WinFormsField("SEARCH-AUST-CODE", "SearchAustCode");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
