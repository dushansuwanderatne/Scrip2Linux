using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00102", "FormName");
		//Fields


        public static WinFormsField MenuItemApr = new WinFormsField("MENU-ITEM-APR", "APR. Appropriation", "Appropriation");
        public static WinFormsField MenuItemDis = new WinFormsField("MENU-ITEM-DIS", "DIS. Disposal", "Disposal");
        public static WinFormsField MenuItemRel = new WinFormsField("MENU-ITEM-REL", "REL. Release", "Release");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
