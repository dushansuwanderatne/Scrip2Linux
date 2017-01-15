using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSKT102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSKT102", "FormName");
		//Fields


        public static WinFormsField MenuItemTrnfr = new WinFormsField("MENU-ITEM-TRNFR", "TRNFR. Transfer", "Transfer");
        public static WinFormsField MenuItemMrkng = new WinFormsField("MENU-ITEM-MRKNG", "MRKNG. Scrip in office marking", "Scripinofficemarking");
        public static WinFormsField MenuItemNctfr = new WinFormsField("MENU-ITEM-NCTFR", "NCTFR. Non Certificated Transfer", "NonCertificatedTransfer");
        public static WinFormsField MenuItemRibal = new WinFormsField("MENU-ITEM-RIBAL", "RIBAL. Re-issue Balance", "Re-issueBalance");
        public static WinFormsField MenuItemRmval = new WinFormsField("MENU-ITEM-RMVAL", "RMVAL. Register Removal", "RegisterRemoval");
        public static WinFormsField MenuItemTrnsm = new WinFormsField("MENU-ITEM-TRNSM", "TRNSM. Transmission", "Transmission");
        public static WinFormsField MenuItemNmchg = new WinFormsField("MENU-ITEM-NMCHG", "NMCHG. Name Change", "NameChange");
        public static WinFormsField MenuItemLstsc = new WinFormsField("MENU-ITEM-LSTSC", "LSTSC. Lost Scrip Replacement", "LostScripReplacement");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Display/Increment Session Totals", "Display/IncrementSessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
