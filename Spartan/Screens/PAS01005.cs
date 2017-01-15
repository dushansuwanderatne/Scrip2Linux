using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PAS01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PAS01005", "FormName");
		//Fields


        public static WinFormsField PayAccountNumber = new WinFormsField("PAY-ACCOUNT-NUMBER", "PayAccountNumber");
        public static WinFormsField UnclaimedMoneyReport = new WinFormsField("UNCLAIMED MONEY REPORT", "UnclaimedMoneyReport");
        public static WinFormsField UnclaimedMoniesFileRecipientType = new WinFormsField("UNCLAIMED MONIES FILE RECIPIENT TYPE", "UnclaimedMoniesFileRecipientType");
        public static WinFormsField PaymentAccountBalanced = new WinFormsField("PAYMENT ACCOUNT BALANCED", "PaymentAccountBalanced");
        public static WinFormsField UMINProgressInd = new WinFormsField("UM-IN-PROGRESS-IND", "UMINProgressInd");
        public static WinFormsField ReportGroup = new WinFormsField("REPORT-GROUP", "ReportGroup");
        public static WinFormsField GazReportYear = new WinFormsField("GAZ-REPORT-YEAR", "GazReportYear");
        public static WinFormsField GazEndYear = new WinFormsField("GAZ-END-YEAR", "GazEndYear");
        public static WinFormsField UncReportYear = new WinFormsField("UNC-REPORT-YEAR", "UncReportYear");
        public static WinFormsField UncEndYear = new WinFormsField("UNC-END-YEAR", "UncEndYear");
        public static WinFormsField DepartmentCode = new WinFormsField("DEPARTMENT CODE", "DepartmentCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
