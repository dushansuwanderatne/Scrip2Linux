using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS00103", "FormName");
		//Fields


        public static WinFormsField MenuItemLC = new WinFormsField("MENU-ITEM-LC", "LC. Link Control Reporting", "LinkControlReporting");
        public static WinFormsField MenuItemER = new WinFormsField("MENU-ITEM-ER", "ER. Extract Reporting", "ExtractReporting");
        public static WinFormsField MenuItemAL = new WinFormsField("MENU-ITEM-AL", "AL. Audit Listing Run", "AuditListingRun");
        public static WinFormsField MenuItemAS = new WinFormsField("MENU-ITEM-AS", "AS. ADS Laser file creation", "ADSLaserfilecreation");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Reporting System", "ExitReportingSystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
