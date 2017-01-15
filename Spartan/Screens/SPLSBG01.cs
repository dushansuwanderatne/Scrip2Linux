using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLSBG01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLSBG01", "FormName");
		//Fields


        public static WinFormsField MenuItemHtt = new WinFormsField("MENU-ITEM-HTT", "HTT. Holder Type/Groups Listing", "HolderType/GroupsListing");
        public static WinFormsField MenuItemEcp = new WinFormsField("MENU-ITEM-ECP", "ECP. Employee Scheme Clean/Purge", "EmployeeSchemeClean/Purge");
        public static WinFormsField MenuItemEaf = new WinFormsField("MENU-ITEM-EAF", "EAF. Employee Application Forms", "EmployeeApplicationForms");
        public static WinFormsField MenuItemEat = new WinFormsField("MENU-ITEM-EAT", "EAT. Employee Acceptance Transaction", "EmployeeAcceptanceTransaction");
        public static WinFormsField MenuItemEis = new WinFormsField("MENU-ITEM-EIS", "EIS. Employee Issue Statements", "EmployeeIssueStatements");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Specials Menu", "ExitSpecialsMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
