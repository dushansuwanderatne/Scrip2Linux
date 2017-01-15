using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP07", "FormName");
		//Fields


        public static WinFormsField MenuItemNsw = new WinFormsField("MENU-ITEM-NSW", "NSW. New South Wales", "NewSouthWales");
        public static WinFormsField MenuItemVic = new WinFormsField("MENU-ITEM-VIC", "VIC. Victoria", "Victoria");
        public static WinFormsField MenuItemTas = new WinFormsField("MENU-ITEM-TAS", "TAS. Tasmania", "Tasmania");
        public static WinFormsField MenuItemNT = new WinFormsField("MENU-ITEM-NT", "NT.  Northern Territory", "NorthernTerritory");
        public static WinFormsField MenuItemAct = new WinFormsField("MENU-ITEM-ACT", "ACT. Australian Capital Territory", "AustralianCapitalTerritory");
        public static WinFormsField MenuItemQld = new WinFormsField("MENU-ITEM-QLD", "QLD. Queensland", "Queensland");
        public static WinFormsField MenuItemSA = new WinFormsField("MENU-ITEM-SA", "SA.  South Australia", "SouthAustralia");
        public static WinFormsField MenuItemWA = new WinFormsField("MENU-ITEM-WA", "WA.  Western Australia", "WesternAustralia");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
