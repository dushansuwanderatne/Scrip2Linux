using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02001", "FormName");
		//Fields


        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C. Company Identifying Words", "CompanyIdentifyingWords");
        public static WinFormsField MenuItemL = new WinFormsField("MENU-ITEM-L", "L. Surname Link Words", "SurnameLinkWords");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Surname Exception Words", "SurnameExceptionWords");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T. General Title Words", "GeneralTitleWords");
        public static WinFormsField MenuItemX = new WinFormsField("MENU-ITEM-X", "X. Designator Exception Words", "DesignatorExceptionWords");
        public static WinFormsField MenuItemF = new WinFormsField("MENU-ITEM-F", "F. FATCA Identifying Words", "FATCAIdentifyingWords");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
