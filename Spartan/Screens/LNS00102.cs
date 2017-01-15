using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemIL = new WinFormsField("MENU-ITEM-IL", "IL.  Maintain Investor Linking", "MaintainInvestorLinking");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit ONLINE System", "ExitONLINESystem");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
