using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRN00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRN00401", "FormName");
		//Fields


        public static WinFormsField MenuItemLab1 = new WinFormsField("MENU-ITEM-LAB1", "LAB1. First Lab", "FirstLab");
        public static WinFormsField MenuItemLab2 = new WinFormsField("MENU-ITEM-LAB2", "LAB2. Second Lab", "SecondLab");
        public static WinFormsField MenuItemPrint = new WinFormsField("MENU-ITEM-PRINT", "PRINT. Print a Report", "PrintaReport");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
