using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS01", "FormName");
		//Fields


        public static WinFormsField MenuItemPrt = new WinFormsField("MENU-ITEM-PRT", "PRT. Print Options Menu", "PrintOptionsMenu");
        public static WinFormsField MenuItemCpr = new WinFormsField("MENU-ITEM-CPR", "CPR. Control Your Printer(s) Menu", "ControlYourPrinter(s)Menu");
        public static WinFormsField MenuItemJob = new WinFormsField("MENU-ITEM-JOB", "JOB. Check on JOB Queue(s)", "CheckonJOBQueue(s)");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Select Company", "SelectCompany");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
