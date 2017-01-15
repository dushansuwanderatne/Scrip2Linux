using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ARS02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ARS02001", "FormName");
		//Fields


        public static WinFormsField MenuItemLI = new WinFormsField("MENU-ITEM-LI", "LI.  Link Integrity", "LinkIntegrity");
        public static WinFormsField MenuItemOR = new WinFormsField("MENU-ITEM-OR", "OR.  Orphan Records", "OrphanRecords");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit File Integrity Reporting", "ExitFileIntegrityReporting");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
