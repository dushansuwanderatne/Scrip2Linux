using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLMES01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLMES01", "FormName");
		//Fields


        public static WinFormsField MenuItemEsshk = new WinFormsField("MENU-ITEM-ESSHK", "ESSHK. Update Payroll/Deductions code files", "UpdatePayroll/Deductionscodefiles");
        public static WinFormsField MenuItemEsclt = new WinFormsField("MENU-ITEM-ESCLT", "ESCLT. Schedule Consolidated Loan Transactions", "ScheduleConsolidatedLoanTransactions");
        public static WinFormsField MenuItemEssct = new WinFormsField("MENU-ITEM-ESSCT", "ESSCT. Schedule Employee/Loan class Control Report", "ScheduleEmployee/LoanclassControlReport");
        public static WinFormsField MenuItemLtr = new WinFormsField("MENU-ITEM-LTR", "LTR. Large Transaction Report", "LargeTransactionReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  EXIT Special Options", "EXITSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
