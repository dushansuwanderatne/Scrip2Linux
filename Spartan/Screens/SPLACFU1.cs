using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLACFU1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLACFU1", "FormName");
		//Fields


        public static WinFormsField MenuItemSR = new WinFormsField("MENU-ITEM-SR", "SR.  Shareholder Statement Request", "ShareholderStatementRequest");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit Special Processing Menu", "ExitSpecialProcessingMenu");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
    }
}
