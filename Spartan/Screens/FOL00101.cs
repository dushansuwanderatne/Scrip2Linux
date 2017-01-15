using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL00101", "FormName");
		//Fields


        public static WinFormsField MenuItemSdm = new WinFormsField("MENU-ITEM-SDM", "SDM. Static Detail Maintenance", "StaticDetailMaintenance");
        public static WinFormsField MenuItemUdt = new WinFormsField("MENU-ITEM-UDT", "UDT.   User Defined Transactions", "UserDefinedTransactions");
        public static WinFormsField MenuItemStd = new WinFormsField("MENU-ITEM-STD", "STD. Standard Transactions", "StandardTransactions");
        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY.   Payment/Cheque Transactions", "Payment/ChequeTransactions");
        public static WinFormsField MenuItemSpt = new WinFormsField("MENU-ITEM-SPT", "SPT. Special Transactions", "SpecialTransactions");
        public static WinFormsField MenuItemMerge = new WinFormsField("MENU-ITEM-MERGE", "MERGE. Merge Holders", "MergeHolders");
        public static WinFormsField MenuItemHgc = new WinFormsField("MENU-ITEM-HGC", "HGC. Holder Group Codes", "HolderGroupCodes");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit ONLINE System", "ExitONLINESystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
