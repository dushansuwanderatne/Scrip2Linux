using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS10022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS10022", "FormName");
		//Fields


        public static WinFormsField MenuItemRL = new WinFormsField("MENU-ITEM-RL", "RL. Register List", "RegisterList");
        public static WinFormsField MenuItemSL = new WinFormsField("MENU-ITEM-SL", "SL. Static List", "StaticList");
        public static WinFormsField MenuItemLB = new WinFormsField("MENU-ITEM-LB", "LB. Labels", "Labels");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT. Notices", "Notices");
        public static WinFormsField MenuItemHT = new WinFormsField("MENU-ITEM-HT", "HT. Holder Tape", "HolderTape");
        public static WinFormsField MenuItemIT = new WinFormsField("MENU-ITEM-IT", "IT. Holder Tape - Balance By Issue", "HolderTape-BalanceByIssue");
        public static WinFormsField MenuItemAU = new WinFormsField("MENU-ITEM-AU", "AU. Audit file", "Auditfile");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP. Special Process", "SpecialProcess");
        public static WinFormsField MenuItemTO = new WinFormsField("MENU-ITEM-TO", "TO. Totals Only", "TotalsOnly");
        public static WinFormsField MenuItemDE = new WinFormsField("MENU-ITEM-DE", "DE. Customised Data Extract", "CustomisedDataExtract");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
