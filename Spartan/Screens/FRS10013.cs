using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10013

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10013", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Loan = new WinFormsField("LOAN", "Loan");
        public static WinFormsField LoanFrom = new WinFormsField("LOAN-FROM", "LoanFrom");
        public static WinFormsField LoanTO = new WinFormsField("LOAN-TO", "LoanTO");
        public static WinFormsField MaturityFrom = new WinFormsField("MATURITY-FROM", "MaturityFrom");
        public static WinFormsField MaturityTO = new WinFormsField("MATURITY-TO", "MaturityTO");
        public static WinFormsField InterestFrom = new WinFormsField("INTEREST-FROM", "InterestFrom");
        public static WinFormsField InterestTO = new WinFormsField("INTEREST-TO", "InterestTO");
        public static WinFormsField IntType = new WinFormsField("INT-TYPE", "IntType");
        public static WinFormsField BalanceRangeType = new WinFormsField("BALANCE-RANGE-TYPE", "BalanceRangeType");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField AccruedFrom = new WinFormsField("ACCRUED-FROM", "AccruedFrom");
        public static WinFormsField AccruedTO = new WinFormsField("ACCRUED-TO", "AccruedTO");
        public static WinFormsField CompoundFrom = new WinFormsField("COMPOUND-FROM", "CompoundFrom");
        public static WinFormsField CompoundTO = new WinFormsField("COMPOUND-TO", "CompoundTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
