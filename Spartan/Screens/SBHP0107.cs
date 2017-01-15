using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP0107

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP0107", "FormName");
		//Fields


        public static WinFormsField MenuItemIac = new WinFormsField("MENU-ITEM-IAC", "IAC.  Employee Issue Application Control", "EmployeeIssueApplicationControl");
        public static WinFormsField MenuItemScc = new WinFormsField("MENU-ITEM-SCC", "SCC.  Schedule Global Centre Code Changes", "ScheduleGlobalCentreCodeChanges");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit BHP Housekeeping System", "ExitBHPHousekeepingSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
