using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00115

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00115", "FormName");
		//Fields
        public static WinFormsField MenuItemEC = new WinFormsField("MENU-ITEM-EC", "EC.", "");
        public static WinFormsField MenuItemEF = new WinFormsField("MENU-ITEM-EF", "EF.", "");
        public static WinFormsField MenuItemEM = new WinFormsField("MENU-ITEM-EM", "EM.", "");
        public static WinFormsField MenuItemEP = new WinFormsField("MENU-ITEM-EP", "EP.", "");
        public static WinFormsField MenuItemEB = new WinFormsField("MENU-ITEM-EB", "EB.", "");
        public static WinFormsField MenuItemEN = new WinFormsField("MENU-ITEM-EN", "EN.", "");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemEA = new WinFormsField("MENU-ITEM-EA", "EA.", "");
        public static WinFormsField MenuItemED = new WinFormsField("MENU-ITEM-ED", "ED.", "");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
