using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLBTR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLBTR01", "FormName");
		//Fields


        public static WinFormsField MenuItemEol = new WinFormsField("MENU-ITEM-EOL", "EOL.  Executive Option Listing", "ExecutiveOptionListing");
        public static WinFormsField MenuItemPao = new WinFormsField("MENU-ITEM-PAO", "PAO.  Post Allotment Option Listing", "PostAllotmentOptionListing");
        public static WinFormsField MenuItemYsi = new WinFormsField("MENU-ITEM-YSI", "YSI.  Years Of Service Increment", "YearsOfServiceIncrement");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Specials Menu", "ExitSpecialsMenu");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
