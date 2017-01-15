using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SWWA0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SWWA0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField Selcls = new WinFormsField("SELCLS", "Selcls");
        public static WinFormsField SalaryClass = new WinFormsField("SALARY-CLASS", "SalaryClass");
        public static WinFormsField YearClass = new WinFormsField("YEAR-CLASS", "YearClass");
        public static WinFormsField SeparateSalaried = new WinFormsField("SEPARATE-SALARIED", "SeparateSalaried");
        public static WinFormsField SalariedClass = new WinFormsField("SALARIED-CLASS", "SalariedClass");
        public static WinFormsField BalanceFrom = new WinFormsField("BALANCE-FROM", "BalanceFrom");
        public static WinFormsField BalanceTO = new WinFormsField("BALANCE-TO", "BalanceTO");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField Flag1 = new WinFormsField("FLAG1", "Flag1");
        public static WinFormsField Flag2 = new WinFormsField("FLAG2", "Flag2");
        public static WinFormsField Flag3 = new WinFormsField("FLAG3", "Flag3");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
