using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL10001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL10001", "FormName");
		//Fields


        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA.  Name & Address", "Name&Address");
        public static WinFormsField MenuItemGC = new WinFormsField("MENU-ITEM-GC", "GC.  Group Codes", "GroupCodes");
        public static WinFormsField MenuItemCC = new WinFormsField("MENU-ITEM-CC", "CC.  Company Codes", "CompanyCodes");
        public static WinFormsField MenuItemXT = new WinFormsField("MENU-ITEM-XT", "XT.  Extract File Details", "ExtractFileDetails");
        public static WinFormsField MenuItemSJ = new WinFormsField("MENU-ITEM-SJ", "SJ.  Schedule Job", "ScheduleJob");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
