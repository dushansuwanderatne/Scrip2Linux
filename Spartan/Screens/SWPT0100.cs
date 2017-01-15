using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SWPT0100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SWPT0100", "FormName");
		//Fields


        public static WinFormsField MenuItemEyt = new WinFormsField("MENU-ITEM-EYT", "EYT.    End of Year Tax Statements", "EndofYearTaxStatements");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.    EXIT Special Options", "EXITSpecialOptions");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
