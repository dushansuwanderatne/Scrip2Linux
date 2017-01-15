using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemAP = new WinFormsField("MENU-ITEM-AP", "AP.  Appropriation Report", "AppropriationReport");
        public static WinFormsField MenuItemEF = new WinFormsField("MENU-ITEM-EF", "EF.  Produce Employee Export File", "ProduceEmployeeExportFile");
        public static WinFormsField MenuItemTS = new WinFormsField("MENU-ITEM-TS", "TS.  Taxation Report for Sales", "TaxationReportforSales");
        public static WinFormsField MenuItemTT = new WinFormsField("MENU-ITEM-TT", "TT.  Taxation Report for Transfers", "TaxationReportforTransfers");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportSelection = new WinFormsField("REPORT-SELECTION", "ReportSelection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
