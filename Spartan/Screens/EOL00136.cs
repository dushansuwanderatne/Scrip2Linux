using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00136

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00136", "FormName");
		//Fields


        public static WinFormsField MenuItemED = new WinFormsField("MENU-ITEM-ED", "ED.  ESS ATO Reporting Employer Declaration", "ESSATOReportingEmployerDeclaration");
        public static WinFormsField MenuItemMA = new WinFormsField("MENU-ITEM-MA", "MA.  Manual Tax Reporting Approval/Unapproval", "ManualTaxReportingApproval/Unapproval");
        public static WinFormsField MenuItemDA = new WinFormsField("MENU-ITEM-DA", "DA.  Dispatch ESSATO Reporting Files", "DispatchESSATOReportingFiles");
        public static WinFormsField MenuItemMC = new WinFormsField("MENU-ITEM-MC", "MC.  Manual Tax Reporting Cancellation", "ManualTaxReportingCancellation");
        public static WinFormsField MenuItemTB = new WinFormsField("MENU-ITEM-TB", "TB.  Manual Tax History Build", "ManualTaxHistoryBuild");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit ATO Annual Tax Administration", "ExitATOAnnualTaxAdministration");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
