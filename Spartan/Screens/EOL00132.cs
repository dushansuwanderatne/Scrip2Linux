using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00132

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00132", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField MenuItemLpe = new WinFormsField("MENU-ITEM-LPE", "LPE. Lapse Options - Employee Initiated", "LapseOptions-EmployeeInitiated");
        public static WinFormsField MenuItemLpc = new WinFormsField("MENU-ITEM-LPC", "LPC. Lapse Options - Company  Initiated", "LapseOptions-CompanyInitiated");
        public static WinFormsField MenuItemCle = new WinFormsField("MENU-ITEM-CLE", "CLE. Cancel Options - Employee Initiated", "CancelOptions-EmployeeInitiated");
        public static WinFormsField MenuItemClc = new WinFormsField("MENU-ITEM-CLC", "CLC. Cancel Options - Company  Initiated", "CancelOptions-CompanyInitiated");
        public static WinFormsField MenuItemRvl = new WinFormsField("MENU-ITEM-RVL", "RVL. Lapse/Cancel Options Reversal", "Lapse/CancelOptionsReversal");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
