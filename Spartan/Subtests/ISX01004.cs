using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01004", "FormName");
		//Fields


        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField SubsystemDesc = new WinFormsField("SUBSYSTEM-DESC", "SubsystemDesc");
        public static WinFormsField MenuItemIct = new WinFormsField("MENU-ITEM-ICT", "ICT.  Issue Calculation Totals & Reports", "IssueCalculationTotals&Reports");
        public static WinFormsField MenuItemIcn = new WinFormsField("MENU-ITEM-ICN", "ICN.  Issue Calculation Notices & Output Files", "IssueCalculationNotices&OutputFiles");
        public static WinFormsField MenuItemIcb = new WinFormsField("MENU-ITEM-ICB", "ICB.  Issue Build Authorisation", "IssueBuildAuthorisation");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
