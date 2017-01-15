using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS08002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS08002", "FormName");
		//Fields


        public static WinFormsField MenuItemIA = new WinFormsField("MENU-ITEM-IA", "IA. Issue Application Analysis", "IssueApplicationAnalysis");
        public static WinFormsField MenuItemIR = new WinFormsField("MENU-ITEM-IR", "IR. Issue Application Range Analysis", "IssueApplicationRangeAnalysis");
        public static WinFormsField MenuItemTO = new WinFormsField("MENU-ITEM-TO", "TO. Totals Only", "TotalsOnly");
        public static WinFormsField MenuItemPA = new WinFormsField("MENU-ITEM-PA", "PA. Postcode Analysis", "PostcodeAnalysis");
        public static WinFormsField MenuItemRA = new WinFormsField("MENU-ITEM-RA", "RA. Regions Analysis", "RegionsAnalysis");
        public static WinFormsField MenuItemSA = new WinFormsField("MENU-ITEM-SA", "SA. State Analysis", "StateAnalysis");
        public static WinFormsField MenuItemCB = new WinFormsField("MENU-ITEM-CB", "CB. Cash Banked List", "CashBankedList");
        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT. Compound Tax List", "CompoundTaxList");
        public static WinFormsField MenuItemSF = new WinFormsField("MENU-ITEM-SF", "SF. Source of Funds List", "SourceofFundsList");
        public static WinFormsField MenuItemLR = new WinFormsField("MENU-ITEM-LR", "LR. Loan Reconciliation List", "LoanReconciliationList");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
