using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PMHCOY00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PMHCOY00", "FormName");
		//Fields


        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C.  Class Details", "ClassDetails");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T.  Types (Status Codes)", "Types(StatusCodes)");
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A.  Account Details", "AccountDetails");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R.  Registers", "Registers");
        public static WinFormsField MenuItemD = new WinFormsField("MENU-ITEM-D", "D.  Reinvestment Details", "ReinvestmentDetails");
        public static WinFormsField MenuItemX = new WinFormsField("MENU-ITEM-X", "X.  Exit Conversion Code Entry", "ExitConversionCodeEntry");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuOldCode = new WinFormsField("MENU-OLD-CODE", "MenuOldCode");
    }
}
