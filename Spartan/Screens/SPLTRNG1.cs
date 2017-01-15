using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLTRNG1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLTRNG1", "FormName");
		//Fields


        public static WinFormsField MenuItemTrndc = new WinFormsField("MENU-ITEM-TRNDC", "TRNDC.  Schedule Dividend Calculation", "ScheduleDividendCalculation");
        public static WinFormsField MenuItemTrnrc = new WinFormsField("MENU-ITEM-TRNRC", "TRNRC.  Cheque Reconciliation and Build", "ChequeReconciliationandBuild");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.     EXIT Special Processing", "EXITSpecialProcessing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
