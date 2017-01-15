using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01003", "FormName");
		//Fields


        public static WinFormsField ScreenDesc = new WinFormsField("SCREEN-DESC", "ScreenDesc");
        public static WinFormsField ChangeID = new WinFormsField("CHANGE-ID", "ChangeID");
        public static WinFormsField PrimaryAddLine = new WinFormsField("PRIMARY-ADD-LINE", "PrimaryAddLine");
        public static WinFormsField PrimaryExample = new WinFormsField("PRIMARY-EXAMPLE", "PrimaryExample");
        public static WinFormsField SecondaryAddLine = new WinFormsField("SECONDARY-ADD-LINE", "SecondaryAddLine");
        public static WinFormsField SecondaryExample = new WinFormsField("SECONDARY-EXAMPLE", "SecondaryExample");
        public static WinFormsField TertiaryAddLine = new WinFormsField("TERTIARY-ADD-LINE", "TertiaryAddLine");
        public static WinFormsField TertiaryExample = new WinFormsField("TERTIARY-EXAMPLE", "TertiaryExample");
        public static WinFormsField CityName = new WinFormsField("CITY-NAME", "CityName");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
