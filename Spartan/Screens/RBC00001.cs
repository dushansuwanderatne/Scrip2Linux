using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RBC00001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RBC00001", "FormName");
		//Fields


        public static WinFormsField MenuItemET = new WinFormsField("MENU-ITEM-ET", "ET.  Enter Tips", "EnterTips");
        public static WinFormsField MenuItemFM = new WinFormsField("MENU-ITEM-FM", "FM.  Fixture Maintenance", "FixtureMaintenance");
        public static WinFormsField MenuItemPW = new WinFormsField("MENU-ITEM-PW", "PW.  Change User Password", "ChangeUserPassword");
        public static WinFormsField MenuItemUM = new WinFormsField("MENU-ITEM-UM", "UM.  User Maintenance", "UserMaintenance");
        public static WinFormsField MenuItemSS = new WinFormsField("MENU-ITEM-SS", "SS.  Scoring System", "ScoringSystem");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU.  Select User", "SelectUser");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from the system", "Exitfromthesystem");
        public static WinFormsField MenuSelection = new WinFormsField("MENU-SELECTION", "MenuSelection");
    }
}
