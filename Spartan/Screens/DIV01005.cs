using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01005", "FormName");
		//Fields


        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField DividendType = new WinFormsField("DIVIDEND-TYPE", "DividendType");
        public static WinFormsField SecondDividendCode = new WinFormsField("SECOND-DIVIDEND-CODE", "SecondDividendCode");
        public static WinFormsField EmployeeDividend = new WinFormsField("EMPLOYEE-DIVIDEND", "EmployeeDividend");
        public static WinFormsField EssLoanDividend = new WinFormsField("ESS-LOAN-DIVIDEND", "EssLoanDividend");
        public static WinFormsField ElectronicStatements = new WinFormsField("ELECTRONIC-STATEMENTS", "ElectronicStatements");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
