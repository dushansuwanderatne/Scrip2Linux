using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT.  Tax File Number Notices Reporting", "TaxFileNumberNoticesReporting");
        public static WinFormsField MenuItemXR = new WinFormsField("MENU-ITEM-XR", "XR.  Tax File Number Exemption Reporting", "TaxFileNumberExemptionReporting");
        public static WinFormsField MenuItemAto = new WinFormsField("MENU-ITEM-ATO", "ATO. ATO Reporting", "ATOReporting");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
