using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10022
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10022", "FormName");
        //Fields
        public static WinFormsField MenuItemAU = new WinFormsField("MENU-ITEM-AU", "AU. Audit file", "Auditfile");
        public static WinFormsField MenuItemLB = new WinFormsField("MENU-ITEM-LB", "LB. Labels", "Labels");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT. Notices", "Notices");
        public static WinFormsField MenuItemRL = new WinFormsField("MENU-ITEM-RL", "RL. Register List Format", "RegisterListFormat");
        public static WinFormsField MenuItemSL = new WinFormsField("MENU-ITEM-SL", "SL. Static List Format", "StaticListFormat");
        public static WinFormsField MenuItemHT = new WinFormsField("MENU-ITEM-HT", "HT. Holder tape", "Holdertape");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP. Special Process", "SpecialProcess");
        public static WinFormsField MenuItemDE = new WinFormsField("MENU-ITEM-DE", "DE. Customised Data Extract", "CustomisedDataExtract");
        public static WinFormsField MenuItemTO = new WinFormsField("MENU-ITEM-TO", "TO. Totals Only", "TotalsOnly");
        public static WinFormsField MenuItemBT = new WinFormsField("MENU-ITEM-BT", "BT. Holder tape - balance by class", "Holdertape-balancebyclass");
        public static WinFormsField MenuItemBE = new WinFormsField("MENU-ITEM-BE", "BE. Balance Export Tape", "BalanceExportTape");
        public static WinFormsField MenuItemHE = new WinFormsField("MENU-ITEM-HE", "HE. Holder Export Tape", "HolderExportTape");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM. Employee Mailing Tape", "EmployeeMailingTape");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}