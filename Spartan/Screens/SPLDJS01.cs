using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLDJS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLDJS01", "FormName");
		//Fields


        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Shareholder Card Processing", "ShareholderCardProcessing");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. EXIT from Special Options", "EXITfromSpecialOptions");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
