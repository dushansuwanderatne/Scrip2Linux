using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BLK00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BLK00101", "FormName");
		//Fields


        public static WinFormsField MenuItemBlk = new WinFormsField("MENU-ITEM-BLK", "BLK.  Bulk Processing Menu", "BulkProcessingMenu");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Bulk Processing", "ExitBulkProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
