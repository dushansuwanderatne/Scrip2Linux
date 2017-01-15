using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLCSTU1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLCSTU1", "FormName");
		//Fields


        public static WinFormsField MenuItemEyt = new WinFormsField("MENU-ITEM-EYT", "EYT.  End Of Year Tax Statements", "EndOfYearTaxStatements");
        public static WinFormsField MenuItemTcr = new WinFormsField("MENU-ITEM-TCR", "TCR.  Trailing Commission Report", "TrailingCommissionReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Specials Menu", "ExitSpecialsMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
