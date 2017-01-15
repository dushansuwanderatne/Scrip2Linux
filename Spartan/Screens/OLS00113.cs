using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00113

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00113", "FormName");
		//Fields


        public static WinFormsField MenuItemFre = new WinFormsField("MENU-ITEM-FRE", "FRE. Faster Reservation Entry", "FasterReservationEntry");
        public static WinFormsField MenuItemFru = new WinFormsField("MENU-ITEM-FRU", "FRU. Faster Reservation Update", "FasterReservationUpdate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
