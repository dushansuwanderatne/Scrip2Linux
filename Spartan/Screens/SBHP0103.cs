using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP0103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP0103", "FormName");
		//Fields


        public static WinFormsField MenuItemBeldc = new WinFormsField("MENU-ITEM-BELDC", "BELDC.  Employee Loan Decrease", "EmployeeLoanDecrease");
        public static WinFormsField MenuItemBeldr = new WinFormsField("MENU-ITEM-BELDR", "BELDR.  Employee Loan Decrease Reversal", "EmployeeLoanDecreaseReversal");
        public static WinFormsField MenuItemBescr = new WinFormsField("MENU-ITEM-BESCR", "BESCR.  Employee Share Decrease Reversal", "EmployeeShareDecreaseReversal");
        public static WinFormsField MenuItemBelre = new WinFormsField("MENU-ITEM-BELRE", "BELRE.  Loan Repayment Election Change", "LoanRepaymentElectionChange");
        public static WinFormsField MenuItemBeaoa = new WinFormsField("MENU-ITEM-BEAOA", "BEAOA.  Adjust Overdue Amount", "AdjustOverdueAmount");
        public static WinFormsField MenuItemBelrm = new WinFormsField("MENU-ITEM-BELRM", "BELRM.  Employee Loan Removal", "EmployeeLoanRemoval");
        public static WinFormsField MenuItemBelin = new WinFormsField("MENU-ITEM-BELIN", "BELIN.  Employee Loan Increase", "EmployeeLoanIncrease");
        public static WinFormsField MenuItemBelir = new WinFormsField("MENU-ITEM-BELIR", "BELIR.  Employee Loan Increase Reversal", "EmployeeLoanIncreaseReversal");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
