using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemRun = new WinFormsField("MENU-ITEM-RUN", "RUN. Schedule Transaction Reporting Run", "ScheduleTransactionReportingRun");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Control Reporting (Menu)", "ControlReporting(Menu)");
        public static WinFormsField MenuItemMR = new WinFormsField("MENU-ITEM-MR", "MR. Maturity Register", "MaturityRegister");
        public static WinFormsField MenuItemMN = new WinFormsField("MENU-ITEM-MN", "MN. Maturity Notices/Listing", "MaturityNotices/Listing");
        public static WinFormsField MenuItemRL = new WinFormsField("MENU-ITEM-RL", "RL. Register List", "RegisterList");
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Broker Reporting (Menu)", "BrokerReporting(Menu)");
        public static WinFormsField MenuItemRR = new WinFormsField("MENU-ITEM-RR", "RR. Investments per Rate per Residual Term", "InvestmentsperRateperResidualTerm");
        public static WinFormsField MenuItemCE = new WinFormsField("MENU-ITEM-CE", "CE. Cheque Extract Reporting", "ChequeExtractReporting");
        public static WinFormsField MenuItemSD = new WinFormsField("MENU-ITEM-SD", "SD. Stamp Duty Report", "StampDutyReport");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Reporting System", "ExitReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
