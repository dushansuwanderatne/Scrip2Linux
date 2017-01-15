using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00410

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00410", "FormName");
		//Fields


        public static WinFormsField MenuItemTau = new WinFormsField("MENU-ITEM-TAU", "TAU.  Set Transfer Authorised", "SetTransferAuthorised");
        public static WinFormsField MenuItemRdr = new WinFormsField("MENU-ITEM-RDR", "RDR.  Reset Registration", "ResetRegistration");
        public static WinFormsField MenuItemTds = new WinFormsField("MENU-ITEM-TDS", "TDS.  Set Transfer Dispatched", "SetTransferDispatched");
        public static WinFormsField MenuItemRtd = new WinFormsField("MENU-ITEM-RTD", "RTD.  Reset Dispatch", "ResetDispatch");
        public static WinFormsField MenuItemDor = new WinFormsField("MENU-ITEM-DOR", "DOR.  Set Date of Registration", "SetDateofRegistration");
        public static WinFormsField MenuItemRca = new WinFormsField("MENU-ITEM-RCA", "RCA.  Reset Authorisation", "ResetAuthorisation");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
