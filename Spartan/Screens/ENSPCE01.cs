using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSPCE01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSPCE01", "FormName");
		//Fields
        public static WinFormsField MenuItemDlas = new WinFormsField("MENU-ITEM-DLAS", "DLAS.   Display Towns/Locations Matching Alpha String", "DisplayTowns/LocationsMatchingAlphaString");
        public static WinFormsField MenuItemDlpc = new WinFormsField("MENU-ITEM-DLPC", "DLPC.   Display Towns/Locations Matching Full/Part Post Code", "DisplayTowns/LocationsMatchingFull/PartPostCode");
        public static WinFormsField MenuItemDlps = new WinFormsField("MENU-ITEM-DLPS", "DLPS.   Display Towns/Locations Matching Full/Part Pre Sort Code", "DisplayTowns/LocationsMatchingFull/PartPreSortCode");
        public static WinFormsField MenuItemDlbp = new WinFormsField("MENU-ITEM-DLBP", "DLBP.   Display Towns/Locations Matching Full/Part Barcode", "DisplayTowns/LocationsMatchingFull/PartBarcode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Country = new WinFormsField("COUNTRY", "Country");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
