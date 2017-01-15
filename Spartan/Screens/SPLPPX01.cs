using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLPPX01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLPPX01", "FormName");
		//Fields


        public static WinFormsField MenuItemPpxlh = new WinFormsField("MENU-ITEM-PPXLH", "PPXLH.  Large Holder Report", "LargeHolderReport");
        public static WinFormsField MenuItemPpxdc = new WinFormsField("MENU-ITEM-PPXDC", "PPXDC.  Schedule Dividend Calculation", "ScheduleDividendCalculation");
        public static WinFormsField MenuItemPpxrc = new WinFormsField("MENU-ITEM-PPXRC", "PPXRC.  Cheque Reconciliation and Build", "ChequeReconciliationandBuild");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.     EXIT Special Processing", "EXITSpecialProcessing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
