using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS00104

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS00104", "FormName");
		//Fields


        public static WinFormsField MenuItemAM = new WinFormsField("MENU-ITEM-AM", "AM.  ADS Class/Payment Maintenance", "ADSClass/PaymentMaintenance");
        public static WinFormsField MenuItemLC = new WinFormsField("MENU-ITEM-LC", "LC.  Link Control", "LinkControl");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit HOUSEKEEPING System", "ExitHOUSEKEEPINGSystem");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
