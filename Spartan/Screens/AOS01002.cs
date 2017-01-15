using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01002", "FormName");
		//Fields


        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST.  Street Address", "StreetAddress");
        public static WinFormsField MenuItemHR = new WinFormsField("MENU-ITEM-HR", "HR.  Highrise", "Highrise");
        public static WinFormsField MenuItemPB = new WinFormsField("MENU-ITEM-PB", "PB.  PO Box", "POBox");
        public static WinFormsField MenuItemRR = new WinFormsField("MENU-ITEM-RR", "RR.  Rural Route", "RuralRoute");
        public static WinFormsField MenuItemUS = new WinFormsField("MENU-ITEM-US", "US.  Unstructured", "Unstructured");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
