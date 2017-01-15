using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP00104", "FormName");
		//Fields


        public static WinFormsField MenuItemAD = new WinFormsField("MENU-ITEM-AD", "AD.  Schedule Auto Debit Processing Run", "ScheduleAutoDebitProcessingRun");
        public static WinFormsField MenuItemAP = new WinFormsField("MENU-ITEM-AP", "AP.  Setup Allotment Parameters", "SetupAllotmentParameters");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR.  Schedule Allotment Calculation Report", "ScheduleAllotmentCalculationReport");
        public static WinFormsField MenuItemSA = new WinFormsField("MENU-ITEM-SA", "SA.  Schedule SPP Cash Allotment Run", "ScheduleSPPCashAllotmentRun");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Regular Processing Menu", "ExitRegularProcessingMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
