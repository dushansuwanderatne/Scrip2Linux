using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03101", "FormName");
		//Fields


        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT. Code Tables", "CodeTables");
        public static WinFormsField MenuItemTC = new WinFormsField("MENU-ITEM-TC", "TC. Code Table Codes", "CodeTableCodes");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
