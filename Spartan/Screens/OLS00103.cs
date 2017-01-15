using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00103", "FormName");
		//Fields


        public static WinFormsField MenuItemAdjst = new WinFormsField("MENU-ITEM-ADJST", "ADJST. Adjustment", "Adjustment");
        public static WinFormsField MenuItemJrnal = new WinFormsField("MENU-ITEM-JRNAL", "JRNAL. Journal Entry", "JournalEntry");
        public static WinFormsField MenuItemAdjin = new WinFormsField("MENU-ITEM-ADJIN", "ADJIN. Adjustment Capital Increase", "AdjustmentCapitalIncrease");
        public static WinFormsField MenuItemCapin = new WinFormsField("MENU-ITEM-CAPIN", "CAPIN. Capital Increase With Scrip", "CapitalIncreaseWithScrip");
        public static WinFormsField MenuItemCapdn = new WinFormsField("MENU-ITEM-CAPDN", "CAPDN. Capital Decrease", "CapitalDecrease");
        public static WinFormsField MenuItemCtind = new WinFormsField("MENU-ITEM-CTIND", "CTIND. Certificate Indicator Setting", "CertificateIndicatorSetting");
        public static WinFormsField MenuItemStfap = new WinFormsField("MENU-ITEM-STFAP", "STFAP. Staff Application", "StaffApplication");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
