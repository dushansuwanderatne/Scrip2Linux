using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CBS00900

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CBS00900", "FormName");
		//Fields


        public static WinFormsField MenuItemSal = new WinFormsField("MENU-ITEM-SAL", "SAL.  Set ALIAS", "SetALIAS");
        public static WinFormsField MenuItemXch = new WinFormsField("MENU-ITEM-XCH", "XCH.  Create a CHAMP export file", "CreateaCHAMPexportfile");
        public static WinFormsField MenuItemMus = new WinFormsField("MENU-ITEM-MUS", "MUS.  Maintain Users/Logins", "MaintainUsers/Logins");
        public static WinFormsField MenuItemIch = new WinFormsField("MENU-ITEM-ICH", "ICH.  Import messages from CHAMP", "ImportmessagesfromCHAMP");
        public static WinFormsField MenuItemMpa = new WinFormsField("MENU-ITEM-MPA", "MPA.  Maintain Participants", "MaintainParticipants");
        public static WinFormsField MenuItemRch = new WinFormsField("MENU-ITEM-RCH", "RCH.  Reconcile with CHAMP", "ReconcilewithCHAMP");
        public static WinFormsField MenuItemMho = new WinFormsField("MENU-ITEM-MHO", "MHO.  Maintain Holdings", "MaintainHoldings");
        public static WinFormsField MenuItemEca = new WinFormsField("MENU-ITEM-ECA", "ECA.  Enter Corporate Actions", "EnterCorporateActions");
        public static WinFormsField MenuItemEcm = new WinFormsField("MENU-ITEM-ECM", "ECM.  Enter Cash Movements", "EnterCashMovements");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit this menu", "Exitthismenu");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree3 = new WinFormsField("SYSTEM-INFO-FREE-3", "17", "17");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
    }
}
