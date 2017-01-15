using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLAMPF1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLAMPF1", "FormName");
		//Fields


        public static WinFormsField MenuItemPay = new WinFormsField("MENU-ITEM-PAY", "PAY. AMP Employee Payroll Systems Report", "AMPEmployeePayrollSystemsReport");
        public static WinFormsField MenuItemET = new WinFormsField("MENU-ITEM-ET", "ET.  AMP Employee Termination Report", "AMPEmployeeTerminationReport");
        public static WinFormsField MenuItemSP = new WinFormsField("MENU-ITEM-SP", "SP.  Share Sale Processing", "ShareSaleProcessing");
        public static WinFormsField MenuItemCR = new WinFormsField("MENU-ITEM-CR", "CR.  Cheque Reconciliation from Sale Processing", "ChequeReconciliationfromSaleProcessing");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit From Special Options", "ExitFromSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}