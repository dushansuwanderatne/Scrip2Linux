using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPS00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPS00104", "FormName");
		//Fields


        public static WinFormsField MenuItemTps = new WinFormsField("MENU-ITEM-TPS", "TPS.  Takeover Parameter Setup", "TakeoverParameterSetup");
        public static WinFormsField MenuItemTsr = new WinFormsField("MENU-ITEM-TSR", "TSR.  Offeror Initiated Transaction Status Report", "OfferorInitiatedTransactionStatusReport");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
