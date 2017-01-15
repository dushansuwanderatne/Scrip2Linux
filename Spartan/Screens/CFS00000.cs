using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00000", "FormName");
		//Fields


        public static WinFormsField MenuItemMcc = new WinFormsField("MENU-ITEM-MCC", "MCC. Master Control Codes", "MasterControlCodes");
        public static WinFormsField MenuItemCcu = new WinFormsField("MENU-ITEM-CCU", "CCU. Client/Company/User Setup", "Client/Company/UserSetup");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit From System", "ExitFromSystem");
    }
}
