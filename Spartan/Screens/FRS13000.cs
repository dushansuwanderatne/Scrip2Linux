using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS13000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS13000", "FormName");
		//Fields


        public static WinFormsField MenuItemMC = new WinFormsField("MENU-ITEM-MC", "MC. Print Master Codes", "PrintMasterCodes");
        public static WinFormsField MenuItemBC = new WinFormsField("MENU-ITEM-BC", "BC. Bank Code Exception Report", "BankCodeExceptionReport");
        public static WinFormsField MenuItemCC = new WinFormsField("MENU-ITEM-CC", "CC. Print Control Codes", "PrintControlCodes");
        public static WinFormsField MenuItemDP = new WinFormsField("MENU-ITEM-DP", "DP. Domicile/Postcode Exception Report", "Domicile/PostcodeExceptionReport");
        public static WinFormsField MenuItemBL = new WinFormsField("MENU-ITEM-BL", "BL. Broker Code Labels", "BrokerCodeLabels");
        public static WinFormsField MenuItemBE = new WinFormsField("MENU-ITEM-BE", "BE. Broker Codes Exception Report", "BrokerCodesExceptionReport");
        public static WinFormsField MenuItemTS = new WinFormsField("MENU-ITEM-TS", "TS. Transaction Summary Reporting", "TransactionSummaryReporting");
        public static WinFormsField MenuItemDC = new WinFormsField("MENU-ITEM-DC", "DC. Direct Credit Test Tape (CEMTEX)", "DirectCreditTestTape(CEMTEX)");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
