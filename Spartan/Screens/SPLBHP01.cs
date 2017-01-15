using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLBHP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLBHP01", "FormName");
		//Fields


        public static WinFormsField MenuItemBol = new WinFormsField("MENU-ITEM-BOL", "BOL.  Online Data Entry System", "OnlineDataEntrySystem");
        public static WinFormsField MenuItemBrs = new WinFormsField("MENU-ITEM-BRS", "BRS.  Reporting System", "ReportingSystem");
        public static WinFormsField MenuItemBhk = new WinFormsField("MENU-ITEM-BHK", "BHK.  Housekeeping System", "HousekeepingSystem");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit from System", "ExitfromSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
