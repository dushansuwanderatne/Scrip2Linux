using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS11002
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS11002", "FormName");
        //Fields
        public static WinFormsField MenuItemBR = new WinFormsField("MENU-ITEM-BR", "BR.  Brief", "Brief");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU.  Summary", "Summary");
        public static WinFormsField MenuItemFU = new WinFormsField("MENU-ITEM-FU", "FU.  Full", "Full");
        public static WinFormsField MenuItemLB = new WinFormsField("MENU-ITEM-LB", "LB.  Labels", "Labels");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT.  Notices", "Notices");
        public static WinFormsField MenuItemTP = new WinFormsField("MENU-ITEM-TP", "TP.  Tape", "Tape");
        public static WinFormsField MenuItemTL = new WinFormsField("MENU-ITEM-TL", "TL.  Resident Tax Listing", "ResidentTaxListing");
        public static WinFormsField MenuItemTO = new WinFormsField("MENU-ITEM-TO", "TO.  Totals Only", "TotalsOnly");
        public static WinFormsField MenuItemBM = new WinFormsField("MENU-ITEM-BM", "BM.  Brief Unclaimed Monies", "BriefUnclaimedMonies");
        public static WinFormsField MenuItemNM = new WinFormsField("MENU-ITEM-NM", "NM.  NSW Unclaimed Monies", "NSWUnclaimedMonies");
        public static WinFormsField MenuItemQM = new WinFormsField("MENU-ITEM-QM", "QM.  Queensland Unclaimed Monies", "QueenslandUnclaimedMonies");
        public static WinFormsField MenuItemVM = new WinFormsField("MENU-ITEM-VM", "VM.  Victorian Unclaimed Monies", "VictorianUnclaimedMonies");
        public static WinFormsField MenuItemUM = new WinFormsField("MENU-ITEM-UM", "UM.  Unclaimed Monies Tape", "UnclaimedMoniesTape");
        public static WinFormsField MenuItemVT = new WinFormsField("MENU-ITEM-VT", "VT.  Victorian Unclaimed Monies Tape", "VictorianUnclaimedMoniesTape");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
