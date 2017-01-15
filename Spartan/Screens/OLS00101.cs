using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00101", "FormName");
		//Fields
        public static WinFormsField MenuItemSdm = new WinFormsField("MENU-ITEM-SDM", "SDM. Static Detail Maintenance", "StaticDetailMaintenance");
        public static WinFormsField MenuItemStd = new WinFormsField("MENU-ITEM-STD", "STD. Standard Transactions", "StandardTransactions");
        public static WinFormsField MenuItemAct = new WinFormsField("MENU-ITEM-ACT", "ACT. Acceptance Transactions", "AcceptanceTransactions");
        public static WinFormsField MenuItemSpt = new WinFormsField("MENU-ITEM-SPT", "SPT. Special Transactions", "SpecialTransactions");
        public static WinFormsField MenuItemPat = new WinFormsField("MENU-ITEM-PAT", "PAT. Payment Transactions", "PaymentTransactions");
        public static WinFormsField MenuItemDpm = new WinFormsField("MENU-ITEM-DPM", "DPM. Dividend Plan Maintenance", "DividendPlanMaintenance");
        public static WinFormsField MenuItemMer = new WinFormsField("MENU-ITEM-MER", "MER. Merge Holders Transaction", "MergeHoldersTransaction");
        public static WinFormsField MenuItemCfx = new WinFormsField("MENU-ITEM-CFX", "CFX. CHESS Fix Transactions", "CHESSFixTransactions");
        public static WinFormsField MenuItemHkt = new WinFormsField("MENU-ITEM-HKT", "HKT. Housekeeping Transactions", "HousekeepingTransactions");
        public static WinFormsField MenuItemCht = new WinFormsField("MENU-ITEM-CHT", "CHT. CHESS Transactions", "CHESSTransactions");
        public static WinFormsField MenuItemCtk = new WinFormsField("MENU-ITEM-CTK", "CTK. CHESS Takeover Transactions", "CHESSTakeoverTransactions");
        public static WinFormsField MenuItemUnc = new WinFormsField("MENU-ITEM-UNC", "UNC. Uncertificated Transactions", "UncertificatedTransactions");
        public static WinFormsField MenuItemFas = new WinFormsField("MENU-ITEM-FAS", "FAS. FASTER Uncertificated Transactions/Reservations", "FASTERUncertificatedTransactions/Reservations");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit ONLINE System", "ExitONLINESystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
