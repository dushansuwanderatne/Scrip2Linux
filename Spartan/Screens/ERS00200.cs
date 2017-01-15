using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00200", "FormName");
		//Fields


        public static WinFormsField MenuItemItr = new WinFormsField("MENU-ITEM-ITR", "ITR. Integrity/Totals Termination Report", "Integrity/TotalsTerminationReport");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP. Schedule Termination Processing", "ScheduleTerminationProcessing");
        public static WinFormsField MenuItemEys = new WinFormsField("MENU-ITEM-EYS", "EYS. Employee End Of Year Statement", "EmployeeEndOfYearStatement");
        public static WinFormsField MenuItemEdr = new WinFormsField("MENU-ITEM-EDR", "EDR. Employee Detail Report", "EmployeeDetailReport");
        public static WinFormsField MenuItemEtr = new WinFormsField("MENU-ITEM-ETR", "ETR. Employee Termination Report", "EmployeeTerminationReport");
        public static WinFormsField MenuItemElr = new WinFormsField("MENU-ITEM-ELR", "ELR. Employee Loan Reduction", "EmployeeLoanReduction");
        public static WinFormsField MenuItemQst = new WinFormsField("MENU-ITEM-QST", "QST. Quarterly Statements", "QuarterlyStatements");
        public static WinFormsField MenuItemEoy = new WinFormsField("MENU-ITEM-EOY", "EOY. EOY Member Statements Report", "EOYMemberStatementsReport");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
