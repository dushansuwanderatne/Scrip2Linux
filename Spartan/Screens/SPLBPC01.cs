using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLBPC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLBPC01", "FormName");
		//Fields


        public static WinFormsField MenuItemSia = new WinFormsField("MENU-ITEM-SIA", "SIA.  Shareholder Dividend Info. Advices", "ShareholderDividendInfo.Advices");
        public static WinFormsField MenuItemErr = new WinFormsField("MENU-ITEM-ERR", "ERR.  Employee Repayment Report", "EmployeeRepaymentReport");
        public static WinFormsField MenuItemEil = new WinFormsField("MENU-ITEM-EIL", "EIL.  Employee Issue Repaid Loans", "EmployeeIssueRepaidLoans");
        public static WinFormsField MenuItemEas = new WinFormsField("MENU-ITEM-EAS", "EAS.  Employee Annual Statement", "EmployeeAnnualStatement");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit Special Company Options", "ExitSpecialCompanyOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
