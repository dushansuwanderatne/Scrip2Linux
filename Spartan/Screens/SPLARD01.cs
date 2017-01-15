using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPLARD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPLARD01", "FormName");
		//Fields


        public static WinFormsField MenuItemSphsr = new WinFormsField("MENU-ITEM-SPHSR", "SPHSR.  Holder Type Summary by Register", "HolderTypeSummarybyRegister");
        public static WinFormsField MenuItemSpipr = new WinFormsField("MENU-ITEM-SPIPR", "SPIPR.  Special Interest/Principal Report", "SpecialInterest/PrincipalReport");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit ARD Special Processing", "ExitARDSpecialProcessing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
