using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLCGH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLCGH01", "FormName");
		//Fields


        public static WinFormsField MenuItemCghdc = new WinFormsField("MENU-ITEM-CGHDC", "CGHDC.  Schedule Dividend Calculation", "ScheduleDividendCalculation");
        public static WinFormsField MenuItemCghrc = new WinFormsField("MENU-ITEM-CGHRC", "CGHRC.  Cheque Reconciliation and Build", "ChequeReconciliationandBuild");
        public static WinFormsField MenuItemCghsc = new WinFormsField("MENU-ITEM-CGHSC", "CGHSC.  Shareholder Card Processing", "ShareholderCardProcessing");
        public static WinFormsField MenuItemCghmr = new WinFormsField("MENU-ITEM-CGHMR", "CGHMR.  Marketing report", "Marketingreport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.     EXIT Special Processing", "EXITSpecialProcessing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
