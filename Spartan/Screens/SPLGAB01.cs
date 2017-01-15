using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLGAB01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLGAB01", "FormName");
		//Fields


        public static WinFormsField MenuItemEyt = new WinFormsField("MENU-ITEM-EYT", "EYT.  End of Year Tax Statements", "EndofYearTaxStatements");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
    }
}
