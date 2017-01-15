using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FHK01102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FHK01102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField IssueNumber = new WinFormsField("ISSUE-NUMBER", "IssueNumber");
        public static WinFormsField IssueDescription = new WinFormsField("ISSUE-DESCRIPTION", "IssueDescription");
        public static WinFormsField LoanType = new WinFormsField("LOAN-TYPE", "LoanType");
        public static WinFormsField LoanNumber = new WinFormsField("LOAN-NUMBER", "LoanNumber");
        public static WinFormsField MaturityDate = new WinFormsField("MATURITY-DATE", "MaturityDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField PaymentMethod = new WinFormsField("PAYMENT-METHOD", "PaymentMethod");
        public static WinFormsField PaymentFrequency = new WinFormsField("PAYMENT-FREQUENCY", "PaymentFrequency");
        public static WinFormsField IssueParValue = new WinFormsField("ISSUE-PAR-VALUE", "IssueParValue");
        public static WinFormsField IssueAuthoriseMoney = new WinFormsField("ISSUE-AUTHORISE-MONEY", "IssueAuthoriseMoney");
        public static WinFormsField IssueIssuedMoney = new WinFormsField("ISSUE-ISSUED-MONEY", "IssueIssuedMoney");
        public static WinFormsField PrevBcloseRunNbr = new WinFormsField("PREV-BCLOSE-RUN-NBR", "PrevBcloseRunNbr");
        public static WinFormsField LastPaymentDate = new WinFormsField("LAST-PAYMENT-DATE", "LastPaymentDate");
        public static WinFormsField NextPaymentDate = new WinFormsField("NEXT-PAYMENT-DATE", "NextPaymentDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
