using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLWFT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLWFT01", "FormName");
		//Fields


        public static WinFormsField MenuItemET = new WinFormsField("MENU-ITEM-ET", "ET. End of Year Tax Statements", "EndofYearTaxStatements");
        public static WinFormsField MenuItemBT = new WinFormsField("MENU-ITEM-BT", "BT. Cumulative Broker Trading Report", "CumulativeBrokerTradingReport");
        public static WinFormsField MenuItemTT = new WinFormsField("MENU-ITEM-TT", "TT. Top Holders Trading Report", "TopHoldersTradingReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  EXIT Special Options", "EXITSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
