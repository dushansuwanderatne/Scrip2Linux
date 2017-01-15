using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1016

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1016", "FormName");
		//Fields


        public static WinFormsField LoanClass = new WinFormsField("LOAN-CLASS", "LoanClass");
        public static WinFormsField Percentage = new WinFormsField("PERCENTAGE", "Percentage");
        public static WinFormsField EmployeeLoanOption = new WinFormsField("EMPLOYEE-LOAN-OPTION", "EmployeeLoanOption");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
