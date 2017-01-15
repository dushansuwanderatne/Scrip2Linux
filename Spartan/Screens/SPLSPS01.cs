using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLSPS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLSPS01", "FormName");
		//Fields


        public static WinFormsField MenuItemPsu = new WinFormsField("MENU-ITEM-PSU", "PSU.  Purchases Summary Report", "PurchasesSummaryReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  EXIT Special Options", "EXITSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
