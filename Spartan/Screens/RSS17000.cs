using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17000", "FormName");
		//Fields


        public static WinFormsField MenuItemCX = new WinFormsField("MENU-ITEM-CX", "CX.   Close Chess Sub-Register", "CloseChessSub-Register");
        public static WinFormsField MenuItemCI = new WinFormsField("MENU-ITEM-CI", "CI.   Close Issuer Sub-Register", "CloseIssuerSub-Register");
        public static WinFormsField MenuItemCN = new WinFormsField("MENU-ITEM-CN", "CN.   Close New Zealand Sub-Register", "CloseNewZealandSub-Register");
        public static WinFormsField MenuItemFD = new WinFormsField("MENU-ITEM-FD", "FD.   Forward Dated Transaction List", "ForwardDatedTransactionList");
        public static WinFormsField MenuItemAD = new WinFormsField("MENU-ITEM-AD", "AD.   Allocate DPID", "AllocateDPID");
        public static WinFormsField MenuItemET = new WinFormsField("MENU-ITEM-ET", "ET.   End of Year Tax Statements (Menu)", "EndofYearTaxStatements(Menu)");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField MenuItemMS = new WinFormsField("MENU-ITEM-MS", "MS.   Managed Investment Scheme Periodic Statements", "ManagedInvestmentSchemePeriodicStatements");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
