using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL30000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL30000", "FormName");
		//Fields


        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER. Extract Reporting", "ExtractReporting");
        public static WinFormsField MenuItemCF = new WinFormsField("MENU-ITEM-CF", "CF. Control File Listings", "ControlFileListings");
        public static WinFormsField MenuItemRR = new WinFormsField("MENU-ITEM-RR", "RR. Reporting Run", "ReportingRun");
        public static WinFormsField MenuItemLK = new WinFormsField("MENU-ITEM-LK", "LK. Like Keys", "LikeKeys");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from System", "ExitfromSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
