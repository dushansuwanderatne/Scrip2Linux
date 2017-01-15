using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NAB00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NAB00401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField ApplicationClass = new WinFormsField("APPLICATION-CLASS", "ApplicationClass");
        public static WinFormsField LoanClass = new WinFormsField("LOAN-CLASS", "LoanClass");
        public static WinFormsField IssuePrice = new WinFormsField("ISSUE-PRICE", "IssuePrice");
        public static WinFormsField InitialPayment = new WinFormsField("INITIAL-PAYMENT", "InitialPayment");
        public static WinFormsField FirstDeduction = new WinFormsField("FIRST-DEDUCTION", "FirstDeduction");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
