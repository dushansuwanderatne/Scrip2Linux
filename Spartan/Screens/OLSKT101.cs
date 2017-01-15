using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSKT101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSKT101", "FormName");
		//Fields


        public static WinFormsField MenuItemSdm = new WinFormsField("MENU-ITEM-SDM", "SDM. Static Detail Maintenance", "StaticDetailMaintenance");
        public static WinFormsField MenuItemUdt = new WinFormsField("MENU-ITEM-UDT", "UDT. User Defined Transactions", "UserDefinedTransactions");
        public static WinFormsField MenuItemStd = new WinFormsField("MENU-ITEM-STD", "STD. Standard transactions", "Standardtransactions");
        public static WinFormsField MenuItemIct = new WinFormsField("MENU-ITEM-ICT", "ICT. Issue/Call /Takeover Transactions", "Issue/Call/TakeoverTransactions");
        public static WinFormsField MenuItemSpt = new WinFormsField("MENU-ITEM-SPT", "SPT. Special Transactions", "SpecialTransactions");
        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. Payment/Cheque Transactions", "Payment/ChequeTransactions");
        public static WinFormsField MenuItemDrp = new WinFormsField("MENU-ITEM-DRP", "DRP. DRP Transactions", "DRPTransactions");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Display/Increment Session Totals", "Display/IncrementSessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit ONLINE system", "ExitONLINEsystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
