using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK01", "FormName");
		//Fields
        public static WinFormsField MenuItemBro = new WinFormsField("MENU-ITEM-BRO", "BRO. Bulk Reporting Options", "BulkReportingOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField BulkType = new WinFormsField("BULK-TYPE", "BulkType");
        public static WinFormsField EssType = new WinFormsField("ESS-TYPE", "EssType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
