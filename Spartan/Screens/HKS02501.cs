using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS02501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS02501", "FormName");
		//Fields


        public static WinFormsField MenuItemNom = new WinFormsField("MENU-ITEM-NOM", "NOM.  Nominate Reservations from system defaults", "NominateReservationsfromsystemdefaults");
        public static WinFormsField MenuItemChg = new WinFormsField("MENU-ITEM-CHG", "CHG.  Change Nominated Reservation Details", "ChangeNominatedReservationDetails");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MenuOption = new WinFormsField("MENU-OPTION", "MenuOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
