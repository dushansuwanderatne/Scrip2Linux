using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS00101", "FormName");
		//Fields
        public static WinFormsField MenuItemTol = new WinFormsField("MENU-ITEM-TOL", "TOL.  Tax File Number Online Data Entry", "TaxFileNumberOnlineDataEntry");
        public static WinFormsField MenuItemTrs = new WinFormsField("MENU-ITEM-TRS", "TRS.  Tax File Number Reporting System", "TaxFileNumberReportingSystem");
        public static WinFormsField MenuItemIrl = new WinFormsField("MENU-ITEM-IRL", "IRL.  IRL Tax Processing System", "IRLTaxProcessingSystem");
        public static WinFormsField MenuItemZaf = new WinFormsField("MENU-ITEM-ZAF", "ZAF.  ZAF Tax Processing System", "ZAFTaxProcessingSystem");
        public static WinFormsField MenuItemIrs = new WinFormsField("MENU-ITEM-IRS", "IRS.  IRS Reporting System", "IRSReportingSystem");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit Tax Processing", "ExitTaxProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
