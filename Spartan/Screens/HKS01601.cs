using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01601", "FormName");
		//Fields


        public static WinFormsField MenuItemNct = new WinFormsField("MENU-ITEM-NCT", "NCT.  Nominate Company Transactions from system defaults", "NominateCompanyTransactionsfromsystemdefaults");
        public static WinFormsField MenuItemNst = new WinFormsField("MENU-ITEM-NST", "NST.  Nominate System Transactions from system defaults", "NominateSystemTransactionsfromsystemdefaults");
        public static WinFormsField MenuItemUnt = new WinFormsField("MENU-ITEM-UNT", "UNT.  Nominated Transactions", "NominatedTransactions");
        public static WinFormsField MenuItemCct = new WinFormsField("MENU-ITEM-CCT", "CCT.  Clone Company Transactions from system defaults", "CloneCompanyTransactionsfromsystemdefaults");
        public static WinFormsField MenuItemUct = new WinFormsField("MENU-ITEM-UCT", "UCT.  Cloned Company Transactions", "ClonedCompanyTransactions");
        public static WinFormsField MenuItemCst = new WinFormsField("MENU-ITEM-CST", "CST.  Clone System generated transactions from system defaults", "CloneSystemgeneratedtransactionsfromsystemdefaults");
        public static WinFormsField MenuItemUst = new WinFormsField("MENU-ITEM-UST", "UST.  Cloned System Transactions", "ClonedSystemTransactions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MenuOption = new WinFormsField("MENU-OPTION", "MenuOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
