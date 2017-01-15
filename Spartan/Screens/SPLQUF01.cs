using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLQUF01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLQUF01", "FormName");
		//Fields


        public static WinFormsField MenuItemStp = new WinFormsField("MENU-ITEM-STP", "STP.  Create Supplier Tape", "CreateSupplierTape");
        public static WinFormsField MenuItemEtp = new WinFormsField("MENU-ITEM-ETP", "ETP.  Create Employee Tape", "CreateEmployeeTape");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Special Options", "ExitSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
