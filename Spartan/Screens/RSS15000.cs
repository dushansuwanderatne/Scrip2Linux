using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS15000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS15000", "FormName");
		//Fields
        public static WinFormsField MenuItemMC = new WinFormsField("MENU-ITEM-MC", "MC. Merge Holder File Create", "MergeHolderFileCreate");
        public static WinFormsField MenuItemMR = new WinFormsField("MENU-ITEM-MR", "MR. Merge Holder Report", "MergeHolderReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Merge Holders", "ExitMergeHolders");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
