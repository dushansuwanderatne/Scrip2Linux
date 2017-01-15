using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01002", "FormName");
		//Fields


        public static WinFormsField SubsystemID = new WinFormsField("SUBSYSTEM-ID", "SubsystemID");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField MenuItemIsr = new WinFormsField("MENU-ITEM-ISR", "ISR.  Intraday Summary Reporting", "IntradaySummaryReporting");
        public static WinFormsField MenuItemAse = new WinFormsField("MENU-ITEM-ASE", "ASE.  Acceptance Status Exception Reporting", "AcceptanceStatusExceptionReporting");
        public static WinFormsField MenuItemAhr = new WinFormsField("MENU-ITEM-AHR", "AHR.  Acceptance Status History Report", "AcceptanceStatusHistoryReport");
        public static WinFormsField MenuItemRec = new WinFormsField("MENU-ITEM-REC", "REC.  Re-Calculation Parameters", "Re-CalculationParameters");
        public static WinFormsField MenuItemRca = new WinFormsField("MENU-ITEM-RCA", "RCA.  Re-Calculation Totals Report & Listing", "Re-CalculationTotalsReport&Listing");
        public static WinFormsField MenuItemRba = new WinFormsField("MENU-ITEM-RBA", "RBA.  Re-Calculation Build Authorisation", "Re-CalculationBuildAuthorisation");
        public static WinFormsField MenuItemRpm = new WinFormsField("MENU-ITEM-RPM", "RPM.  Pending Money Enquiry / Sub System Refunds", "PendingMoneyEnquiry/SubSystemRefunds");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
