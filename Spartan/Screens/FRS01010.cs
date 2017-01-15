using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS01010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS01010", "FormName");
		//Fields


        public static WinFormsField MenuItemID = new WinFormsField("MENU-ITEM-ID", "ID. Investor Type / Domicile Summary", "InvestorType/DomicileSummary");
        public static WinFormsField MenuItemGL = new WinFormsField("MENU-ITEM-GL", "GL. General Ledger Extract File", "GeneralLedgerExtractFile");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM-PR", "PR. Performance Reporting", "PerformanceReporting");
        public static WinFormsField MenuItemIR = new WinFormsField("MENU-ITEM-IR", "IR. Issue Ranges Summary", "IssueRangesSummary");
        public static WinFormsField MenuItemCP = new WinFormsField("MENU-ITEM-CP", "CP. CommInvest Position Extract File", "CommInvestPositionExtractFile");
        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT. CommInvest Historical Extract File", "CommInvestHistoricalExtractFile");
        public static WinFormsField MenuItemAP = new WinFormsField("MENU-ITEM-AP", "AP. Almis Position Extract File", "AlmisPositionExtractFile");
        public static WinFormsField MenuItemAT = new WinFormsField("MENU-ITEM-AT", "AT. Almis Historical Extract File", "AlmisHistoricalExtractFile");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Format = new WinFormsField("FORMAT", "Format");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
