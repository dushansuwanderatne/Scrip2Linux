using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00126

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00126", "FormName");
		//Fields
        public static WinFormsField MenuItemEsp = new WinFormsField("MENU-ITEM-ESP", "ESP. Employee Scheme Processing", "EmployeeSchemeProcessing");
        public static WinFormsField MenuItemEhi = new WinFormsField("MENU-ITEM-EHI", "EHI. Employee Static Details Health & Integrity ", "EmployeeStaticDetailsHealth&Integrity");
        public static WinFormsField MenuItemEup = new WinFormsField("MENU-ITEM-EUP", "EUP. Employee Static Details Upload", "EmployeeStaticDetailsUpload");
        public static WinFormsField MenuItemRdm = new WinFormsField("MENU-ITEM-RDM", "RDM. Release Dividend Money", "ReleaseDividendMoney");
        public static WinFormsField MenuItemUna = new WinFormsField("MENU-ITEM-UNA", "UNA. Unallocated Account Maintenance", "UnallocatedAccountMaintenance");
        public static WinFormsField MenuItemTax = new WinFormsField("MENU-ITEM-TAX", "TAX. ESS ATO Annual Tax Administration", "ESSATOAnnualTaxAdministration");
        public static WinFormsField MenuItemErl = new WinFormsField("MENU-ITEM-ERL", "ERL. Employee Scheme Residual Payment Lodgement", "EmployeeSchemeResidualPaymentLodgement");
        public static WinFormsField MenuItemFre = new WinFormsField("MENU-ITEM-FRE", "FRE. ESS Financial Reporting Export Authorisation", "ESSFinancialReportingExportAuthorisation");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Session Totals", "SessionTotals");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Employee Plan Processing", "ExitEmployeePlanProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
