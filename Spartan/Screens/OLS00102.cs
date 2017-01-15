using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS00102", "FormName");
		//Fields


        public static WinFormsField MenuItemTrnfr = new WinFormsField("MENU-ITEM-TRNFR", "TRNFR. Transfer", "Transfer");
        public static WinFormsField MenuItemMrkng = new WinFormsField("MENU-ITEM-MRKNG", "MRKNG. Marking", "Marking");
        public static WinFormsField MenuItemRmval = new WinFormsField("MENU-ITEM-RMVAL", "RMVAL. Register Removal", "RegisterRemoval");
        public static WinFormsField MenuItemRibal = new WinFormsField("MENU-ITEM-RIBAL", "RIBAL. Re-issue Balance", "Re-issueBalance");
        public static WinFormsField MenuItemNmchg = new WinFormsField("MENU-ITEM-NMCHG", "NMCHG. Name Change", "NameChange");
        public static WinFormsField MenuItemNacnv = new WinFormsField("MENU-ITEM-NACNV", "NACNV. Name Change Conversion", "NameChangeConversion");
        public static WinFormsField MenuItemSplit = new WinFormsField("MENU-ITEM-SPLIT", "SPLIT. Split Certificate", "SplitCertificate");
        public static WinFormsField MenuItemTrnsm = new WinFormsField("MENU-ITEM-TRNSM", "TRNSM. Transmission", "Transmission");
        public static WinFormsField MenuItemLstsc = new WinFormsField("MENU-ITEM-LSTSC", "LSTSC. Lost Scrip Replacement", "LostScripReplacement");
        public static WinFormsField MenuItemConsc = new WinFormsField("MENU-ITEM-CONSC", "CONSC. Consolidate Certificates", "ConsolidateCertificates");
        public static WinFormsField MenuItemUncm = new WinFormsField("MENU-ITEM-UNCM", "UNCM.  Uncertificated Trans Menu", "UncertificatedTransMenu");
        public static WinFormsField MenuItemSeccv = new WinFormsField("MENU-ITEM-SECCV", "SECCV. Securities Conversion", "SecuritiesConversion");
        public static WinFormsField MenuItemST = new WinFormsField("MENU-ITEM-ST", "ST. Session Totals", "SessionTotals");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
