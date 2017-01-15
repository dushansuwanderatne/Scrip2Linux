using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISS01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISS01002", "FormName");
		//Fields


        public static WinFormsField MenuItemIps = new WinFormsField("MENU-ITEM-IPS", "IPS.  Issue Parameter Setup", "IssueParameterSetup");
        public static WinFormsField MenuItemCer = new WinFormsField("MENU-ITEM-CER", "CER.  Cumulative Exception Report", "CumulativeExceptionReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuItemAdr = new WinFormsField("MENU-ITEM-ADR", "ADR.  Issue Acceptance Discrepancy Report", "IssueAcceptanceDiscrepancyReport");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
