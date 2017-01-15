using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1005", "FormName");
		//Fields
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField CorporateAction = new WinFormsField("CORPORATE-ACTION", "CorporateAction");
        public static WinFormsField EmployeeDividend = new WinFormsField("EMPLOYEE-DIVIDEND", "EmployeeDividend");
        public static WinFormsField EssLoanDividend = new WinFormsField("ESS-LOAN-DIVIDEND", "EssLoanDividend");
        public static WinFormsField ElectronicStatements = new WinFormsField("ELECTRONIC-STATEMENTS", "ElectronicStatements");
        public static WinFormsField UseEmpCommMethInd = new WinFormsField("USE-EMP-COMM-METH-IND", "UseEmpCommMethInd");
        public static WinFormsField MultiplePayments = new WinFormsField("MULTIPLE-PAYMENTS", "MultiplePayments");
        public static WinFormsField NumberOFPayments = new WinFormsField("NUMBER-OF-PAYMENTS", "NumberOFPayments");
        public static WinFormsField AutomatedJobRelease = new WinFormsField("AUTOMATED-JOB-RELEASE", "AutomatedJobRelease");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
