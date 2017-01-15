using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13000
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS13000", "FormName");
        //Fields
        public static WinFormsField MenuItemMC = new WinFormsField("MENU-ITEM-MC", "MC. Print Master Codes", "PrintMasterCodes");
        public static WinFormsField MenuItemBC = new WinFormsField("MENU-ITEM-BC", "BC. Bank Code Exception Report", "BankCodeExceptionReport");
        public static WinFormsField MenuItemCC = new WinFormsField("MENU-ITEM-CC", "CC. Print Control Codes", "PrintControlCodes");
        public static WinFormsField MenuItemDP = new WinFormsField("MENU-ITEM-DP", "DP. Domicile/Postcode Exception Report", "Domicile/PostcodeExceptionReport");
        public static WinFormsField MenuItemBL = new WinFormsField("MENU-ITEM-BL", "BL. Broker Code Labels", "BrokerCodeLabels");
        public static WinFormsField MenuItemBE = new WinFormsField("MENU-ITEM-BE", "BE. Broker Codes Exception Report", "BrokerCodesExceptionReport");
        public static WinFormsField MenuItemNZ = new WinFormsField("MENU-ITEM-NZ", "NZ. New Zealand Annual Return", "NewZealandAnnualReturn");
        public static WinFormsField MenuItemTS = new WinFormsField("MENU-ITEM-TS", "TS. Transaction Summary Reporting", "TransactionSummaryReporting");
        public static WinFormsField MenuItemPC = new WinFormsField("MENU-ITEM-PC", "PC. Pending Holder Communications", "PendingHolderCommunications");
        public static WinFormsField MenuItemSF = new WinFormsField("MENU-ITEM-SF", "SF. Scrip Formats", "ScripFormats");
        public static WinFormsField MenuItemDF = new WinFormsField("MENU-ITEM-DF", "DF. Dividend Formats", "DividendFormats");
        public static WinFormsField MenuItemDC = new WinFormsField("MENU-ITEM-DC", "DC. Direct Credit Test Tape (CEMTEX)", "DirectCreditTestTape(CEMTEX)");
        public static WinFormsField MenuItemUC = new WinFormsField("MENU-ITEM-UC", "UC. Print Update Reporting", "PrintUpdateReporting");
        public static WinFormsField MenuItemRL = new WinFormsField("MENU-ITEM-RL", "RL. Reference Code Labels", "ReferenceCodeLabels");
        public static WinFormsField MenuItemNI = new WinFormsField("MENU-ITEM-NI", "NI. New Zealand IRD Tape", "NewZealandIRDTape");
        public static WinFormsField MenuItemTA = new WinFormsField("MENU-ITEM-TA", "TA. Transaction Activity Reporting", "TransactionActivityReporting");
        public static WinFormsField MenuItemTR = new WinFormsField("MENU-ITEM-TR", "TR. Trading System Reporting", "TradingSystemReporting");
        public static WinFormsField MenuItemBG = new WinFormsField("MENU-ITEM-BG", "BG. Copy Billing Groups", "CopyBillingGroups");
        public static WinFormsField MenuItemAM = new WinFormsField("MENU-ITEM-AM", "AM. Audit Method Report", "AuditMethodReport");
        public static WinFormsField MenuItemRS = new WinFormsField("MENU-ITEM-RS", "RS. Report Statistics", "ReportStatistics");
        public static WinFormsField MenuItemPR = new WinFormsField("MENU-ITEM-PR", "PR. Payment Instruction Reporting", "PaymentInstructionReporting");
        public static WinFormsField MenuItemCD = new WinFormsField("MENU-ITEM-CD", "CD. Custodian Holder Detail Extract", "CustodianHolderDetailExtract");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
