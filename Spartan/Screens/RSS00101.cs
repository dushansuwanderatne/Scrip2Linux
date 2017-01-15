using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS00101", "FormName");
		//Fields
        public static WinFormsField MenuItemFrun = new WinFormsField("MENU-ITEM-FRUN", "FRUN. Schedule Transaction Reporting Run", "ScheduleTransactionReportingRun");
        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER. Extract Reporting", "ExtractReporting");
        public static WinFormsField MenuItemRun = new WinFormsField("MENU-ITEM-RUN", "RUN. Schedule Transaction Reporting Run", "ScheduleTransactionReportingRun");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM. End of Month Statistics", "EndofMonthStatistics");
        public static WinFormsField MenuItemTH = new WinFormsField("MENU-ITEM-TH", "TH. Top Holders List", "TopHoldersList");
        public static WinFormsField MenuItemSD = new WinFormsField("MENU-ITEM-SD", "SD. Stamp Duty Report", "StampDutyReport");
        public static WinFormsField MenuItemLH = new WinFormsField("MENU-ITEM-LH", "LH. Like Holders Summary", "LikeHoldersSummary");
        public static WinFormsField MenuItemCE = new WinFormsField("MENU-ITEM-CE", "CE. Cheque Extract Reporting", "ChequeExtractReporting");
        public static WinFormsField MenuItemSR = new WinFormsField("MENU-ITEM-SR", "SR. Summary Reporting", "SummaryReporting");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Control Reporting (Menu)", "ControlReporting(Menu)");
        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL. Plan Reporting (Menu)", "PlanReporting(Menu)");
        public static WinFormsField MenuItemSM = new WinFormsField("MENU-ITEM-SM", "SM. Shareholder Movement Reporting (Menu)", "ShareholderMovementReporting(Menu)");
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Broker Reporting (Menu)", "BrokerReporting(Menu)");
        public static WinFormsField MenuItemUR = new WinFormsField("MENU-ITEM-UR", "UR. Uncertificated Reporting (Menu)", "UncertificatedReporting(Menu)");
        public static WinFormsField MenuItemMH = new WinFormsField("MENU-ITEM-MH", "MH. Merge Holder Reporting (Menu)", "MergeHolderReporting(Menu)");
        public static WinFormsField MenuItemEC = new WinFormsField("MENU-ITEM-EC", "EC. Employee Scheme Reporting (Menu)", "EmployeeSchemeReporting(Menu)");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU. Sundry Reporting (Menu)", "SundryReporting(Menu)");
        public static WinFormsField MenuItemES = new WinFormsField("MENU-ITEM-ES", "ES. ESS Reporting (Menu)", "ESSReporting(Menu)");
        public static WinFormsField MenuItemUM = new WinFormsField("MENU-ITEM-UM", "UM. Unclaimed Monies", "UnclaimedMonies");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Reporting System", "ExitReportingSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
