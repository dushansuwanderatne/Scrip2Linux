using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ALS01025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ALS01025", "FormName");
		//Fields


        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Alpha", "Alpha");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Postcode", "Postcode");
        public static WinFormsField MenuItemX = new WinFormsField("MENU-ITEM-X", "X. Alpha for Australia followed by Alpha within Country", "AlphaforAustraliafollowedbyAlphawithinCountry");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Special pre-sort plan", "Specialpre-sortplan");
        public static WinFormsField MenuItemB = new WinFormsField("MENU-ITEM-B", "B. Barcode pre-sort plan...:", "Barcodepre-sortplan...:");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ScripSeq = new WinFormsField("SCRIP-SEQ", "ScripSeq");
        public static WinFormsField ScripComment60 = new WinFormsField("SCRIP-COMMENT-60", "ScripComment60");
        public static WinFormsField ScripComment40 = new WinFormsField("SCRIP-COMMENT-40", "ScripComment40");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
