using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STATSND

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STATSND", "FormName");
		//Fields


        public static WinFormsField MenuItemSct = new WinFormsField("MENU-ITEM-SCT", "SCT.   Client Totals Update", "ClientTotalsUpdate");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.    Exit", "Exit");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
