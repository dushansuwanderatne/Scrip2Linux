using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemRun = new WinFormsField("MENU-ITEM-RUN", "RUN. Schedule Transaction Reporting Run", "ScheduleTransactionReportingRun");
        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER. Extract Reporting", "ExtractReporting");
        public static WinFormsField MenuItemTR = new WinFormsField("MENU-ITEM-TR", "TR. Transaction Reporting", "TransactionReporting");
        public static WinFormsField MenuItemSR = new WinFormsField("MENU-ITEM-SR", "SR. Summary Reporting", "SummaryReporting");
        public static WinFormsField MenuItemCE = new WinFormsField("MENU-ITEM-CE", "CE. Cheque Extract Reporting", "ChequeExtractReporting");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM. End Of Month Statistics", "EndOfMonthStatistics");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR. Control Reporting (Menu)", "ControlReporting(Menu)");
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR. Broker Reporting (Menu)", "BrokerReporting(Menu)");
        public static WinFormsField MenuItemDG = new WinFormsField("MENU-ITEM-DG", "DG. Dealer Group Reporting", "DealerGroupReporting");
        public static WinFormsField MenuItemLH = new WinFormsField("MENU-ITEM-LH", "LH. Like Holders Summary", "LikeHoldersSummary");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Reporting System", "ExitReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
