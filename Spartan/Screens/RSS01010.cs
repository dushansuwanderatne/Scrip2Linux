using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS01010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS01010", "FormName");
        //Fields
        public static WinFormsField MenuItemHS = new WinFormsField("MENU-ITEM-HS", "HS. Holder Type Summary", "HolderTypeSummary");
        public static WinFormsField MenuItemDS = new WinFormsField("MENU-ITEM-DS", "DS. Local/Domicile Summary", "Local/DomicileSummary");
        public static WinFormsField MenuItemRU = new WinFormsField("MENU-ITEM-RU", "RU. Range of Units Summary", "RangeofUnitsSummary");
        public static WinFormsField MenuItemSA = new WinFormsField("MENU-ITEM-SA", "SA. Spread Of Holders Address Summary", "SpreadOfHoldersAddressSummary");
        public static WinFormsField Format = new WinFormsField("FORMAT", "Format");
        public static WinFormsField MenuItemSS = new WinFormsField("MENU-ITEM-SS", "SS. Holder Subscriptions Summary", "HolderSubscriptionsSummary");
        public static WinFormsField MenuItemPE = new WinFormsField("MENU-ITEM-PE", "PE. Payment Elections Summary", "PaymentElectionsSummary");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
