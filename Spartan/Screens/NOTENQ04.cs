using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTENQ04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTENQ04", "FormName");
		//Fields


        public static WinFormsField MenuItemP1 = new WinFormsField("MENU-ITEM-P1", "P1. Power of Attorney (1)", "PowerofAttorney(1)");
        public static WinFormsField MenuItemN1 = new WinFormsField("MENU-ITEM-N1", "N1. Free format noting (1)", "Freeformatnoting(1)");
        public static WinFormsField MenuItemP2 = new WinFormsField("MENU-ITEM-P2", "P2. Power of Attorney (2)", "PowerofAttorney(2)");
        public static WinFormsField MenuItemN2 = new WinFormsField("MENU-ITEM-N2", "N2. Free format noting (2)", "Freeformatnoting(2)");
        public static WinFormsField MenuItemP3 = new WinFormsField("MENU-ITEM-P3", "P3. Power of Attorney (3)", "PowerofAttorney(3)");
        public static WinFormsField MenuItemN3 = new WinFormsField("MENU-ITEM-N3", "N3. Free format noting (3)", "Freeformatnoting(3)");
        public static WinFormsField MenuItemD1 = new WinFormsField("MENU-ITEM-D1", "D1. Deceased Estate noting", "DeceasedEstatenoting");
        public static WinFormsField MenuItemN4 = new WinFormsField("MENU-ITEM-N4", "N4. Free format noting (4)", "Freeformatnoting(4)");
        public static WinFormsField MenuItemM1 = new WinFormsField("MENU-ITEM-M1", "M1. Memorandum and Articles", "MemorandumandArticles");
        public static WinFormsField MenuItemN5 = new WinFormsField("MENU-ITEM-N5", "N5. Free format noting (5)", "Freeformatnoting(5)");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField Action2 = new WinFormsField("ACTION-2", "Action2");
        public static WinFormsField UpdateOption = new WinFormsField("UPDATE-OPTION", "UpdateOption");
        public static WinFormsField SearchData = new WinFormsField("SEARCH-DATA", "SearchData");
    }
}
