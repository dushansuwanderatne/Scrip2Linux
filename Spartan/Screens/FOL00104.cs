using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL00104", "FormName");
		//Fields


        public static WinFormsField MenuItemFiacn = new WinFormsField("MENU-ITEM-FIACN", "FIACN.  Application Cancellation", "ApplicationCancellation");
        public static WinFormsField MenuItemFiaaj = new WinFormsField("MENU-ITEM-FIAAJ", "FIAAJ.  Application Adjustment", "ApplicationAdjustment");
        public static WinFormsField MenuItemFiadj = new WinFormsField("MENU-ITEM-FIADJ", "FIADJ.  Adjustment", "Adjustment");
        public static WinFormsField MenuItemFiadd = new WinFormsField("MENU-ITEM-FIADD", "FIADD.  Adjustment of Date", "AdjustmentofDate");
        public static WinFormsField MenuItemFirev = new WinFormsField("MENU-ITEM-FIREV", "FIREV.  Reversal of Transaction", "ReversalofTransaction");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
