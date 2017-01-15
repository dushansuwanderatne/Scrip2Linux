using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00001", "FormName");
		//Fields


        public static WinFormsField MenuItemET = new WinFormsField("MENU-ITEM-ET", "ET.  Enter Tips", "EnterTips");
        public static WinFormsField MenuItemFM = new WinFormsField("MENU-ITEM-FM", "FM.  Fixture Maintenance", "FixtureMaintenance");
        public static WinFormsField MenuItemPW = new WinFormsField("MENU-ITEM-PW", "PW.  Change User Password", "ChangeUserPassword");
        public static WinFormsField MenuItemUM = new WinFormsField("MENU-ITEM-UM", "UM.  User Maintenance", "UserMaintenance");
        public static WinFormsField MenuItemPL = new WinFormsField("MENU-ITEM-PL", "PL.  Progressive Ladder report", "ProgressiveLadderreport");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU.  Select User", "SelectUser");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from the system", "Exitfromthesystem");
        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField MenuSelection = new WinFormsField("MENU-SELECTION", "MenuSelection");
    }
}
