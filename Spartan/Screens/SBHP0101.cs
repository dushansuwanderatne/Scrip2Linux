using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP0101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP0101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MenuItemApp = new WinFormsField("MENU-ITEM-APP", "APP.  ESP/EOP Applications Menu", "ESP/EOPApplicationsMenu");
        public static WinFormsField MenuItemLns = new WinFormsField("MENU-ITEM-LNS", "LNS.  Loan Maintenance Menu", "LoanMaintenanceMenu");
        public static WinFormsField MenuItemOpt = new WinFormsField("MENU-ITEM-OPT", "OPT.  Options Maintenance Menu", "OptionsMaintenanceMenu");
        public static WinFormsField MenuItemEmp = new WinFormsField("MENU-ITEM-EMP", "EMP.  Employee Maintenance Menu", "EmployeeMaintenanceMenu");
        public static WinFormsField MenuItemUdt = new WinFormsField("MENU-ITEM-UDT", "UDT.  User Defined Transactions", "UserDefinedTransactions");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit BHP Online System", "ExitBHPOnlineSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
