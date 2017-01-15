using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FPS01008

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FPS01008", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PaymentCode = new WinFormsField("PAYMENT-CODE", "PaymentCode");
        public static WinFormsField PaymentDescription = new WinFormsField("PAYMENT-DESCRIPTION", "PaymentDescription");
        public static WinFormsField IssueNumber1 = new WinFormsField("ISSUE-NUMBER-1", "IssueNumber1");
        public static WinFormsField LoanType1 = new WinFormsField("LOAN-TYPE-1", "LoanType1");
        public static WinFormsField LoanNumber1 = new WinFormsField("LOAN-NUMBER-1", "LoanNumber1");
        public static WinFormsField MaturityDate1 = new WinFormsField("MATURITY-DATE-1", "MaturityDate1");
        public static WinFormsField InterestRate1 = new WinFormsField("INTEREST-RATE-1", "InterestRate1");
        public static WinFormsField NumberDays1 = new WinFormsField("NUMBER-DAYS-1", "NumberDays1");
        public static WinFormsField IssueNumber2 = new WinFormsField("ISSUE-NUMBER-2", "IssueNumber2");
        public static WinFormsField LoanType2 = new WinFormsField("LOAN-TYPE-2", "LoanType2");
        public static WinFormsField LoanNumber2 = new WinFormsField("LOAN-NUMBER-2", "LoanNumber2");
        public static WinFormsField MaturityDate2 = new WinFormsField("MATURITY-DATE-2", "MaturityDate2");
        public static WinFormsField InterestRate2 = new WinFormsField("INTEREST-RATE-2", "InterestRate2");
        public static WinFormsField NumberDays2 = new WinFormsField("NUMBER-DAYS-2", "NumberDays2");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
