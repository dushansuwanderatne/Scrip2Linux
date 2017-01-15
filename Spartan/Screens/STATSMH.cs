using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STATSMH

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STATSMH", "FormName");
		//Fields


        public static WinFormsField MenuItemSct = new WinFormsField("MENU-ITEM-SCT", "SCT.  Client Totals Update", "ClientTotalsUpdate");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  EXIT", "EXIT");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
    }
}
