using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00101", "FormName");
		//Fields
        public static WinFormsField MenuItemInt = new WinFormsField("MENU-ITEM-INT", "INT. Initialize Online Data Entry", "InitializeOnlineDataEntry");
        public static WinFormsField MenuItemRsm = new WinFormsField("MENU-ITEM-RSM", "RSM. Re-issue Stale Markings", "Re-issueStaleMarkings");
        public static WinFormsField MenuItemAtr = new WinFormsField("MENU-ITEM-ATR", "ATR. Adhoc Transaction Reporting Run", "AdhocTransactionReportingRun");
        public static WinFormsField MenuItemTJ = new WinFormsField("MENU-ITEM-TJ", "TJ. Transfer Journal Report", "TransferJournalReport");
        public static WinFormsField MenuItemCco = new WinFormsField("MENU-ITEM-CCO", "CCO. Control Code Options", "ControlCodeOptions");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Housekeeping", "ExitHousekeeping");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
