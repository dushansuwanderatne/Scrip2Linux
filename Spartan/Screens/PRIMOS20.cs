using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS20", "FormName");
		//Fields


        public static WinFormsField MenuItemSelprt = new WinFormsField("MENU-ITEM-SELPRT", "SELPRT. Select CURRENT Printer From Above List", "SelectCURRENTPrinterFromAboveList");
        public static WinFormsField MenuItemSetnpf = new WinFormsField("MENU-ITEM-SETNPF", "SETNPF. Set NOTICE Printer Form Type", "SetNOTICEPrinterFormType");
        public static WinFormsField MenuItemRstrt = new WinFormsField("MENU-ITEM-RSTRT", "RSTRT.  Restart PRINTER At Start Of File Currently Printing", "RestartPRINTERAtStartOfFileCurrentlyPrinting");
        public static WinFormsField MenuItemBack = new WinFormsField("MENU-ITEM-BACK", "BACK.   Restart PRINTER Back A Few Pages On File Currently Printing", "RestartPRINTERBackAFewPagesOnFileCurrentlyPrinting");
        public static WinFormsField MenuItemStatus = new WinFormsField("MENU-ITEM-STATUS", "STATUS. Display Status Of Current Printer", "DisplayStatusOfCurrentPrinter");
        public static WinFormsField MenuItemSetup = new WinFormsField("MENU-ITEM-SETUP", "SETUP.  Set FORM Length On Current Printer", "SetFORMLengthOnCurrentPrinter");
        public static WinFormsField MenuItemForm = new WinFormsField("MENU-ITEM-FORM", "FORM.   Change FORM Type On Current Printer", "ChangeFORMTypeOnCurrentPrinter");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Printer1 = new WinFormsField("PRINTER1", "Printer1");
        public static WinFormsField Printer2 = new WinFormsField("PRINTER2", "Printer2");
        public static WinFormsField Printer3 = new WinFormsField("PRINTER3", "Printer3");
        public static WinFormsField Printer4 = new WinFormsField("PRINTER4", "Printer4");
        public static WinFormsField Printer5 = new WinFormsField("PRINTER5", "Printer5");
        public static WinFormsField Printer6 = new WinFormsField("PRINTER6", "Printer6");
        public static WinFormsField Printer7 = new WinFormsField("PRINTER7", "Printer7");
        public static WinFormsField Printer8 = new WinFormsField("PRINTER8", "Printer8");
        public static WinFormsField Printer9 = new WinFormsField("PRINTER9", "Printer9");
        public static WinFormsField Printer10 = new WinFormsField("PRINTER10", "Printer10");
        public static WinFormsField CurrentPrinter = new WinFormsField("CURRENT-PRINTER", "CurrentPrinter");
        public static WinFormsField CurrentForm = new WinFormsField("CURRENT-FORM", "CurrentForm");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}