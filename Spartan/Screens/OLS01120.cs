using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01120

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01120", "FormName");
		//Fields
        public static WinFormsField MenuItemAH = new WinFormsField("MENU-ITEM-AH", "AH. Add Holder(s)", "AddHolder(s)");
        public static WinFormsField MenuItemPI = new WinFormsField("MENU-ITEM-PI", "PI. Payee Instructions", "PayeeInstructions");
        public static WinFormsField MenuItemWR = new WinFormsField("MENU-ITEM-WR", "WR. Overseas Wire Instructions", "OverseasWireInstructions");
        public static WinFormsField MenuItemNA = new WinFormsField("MENU-ITEM-NA", "NA. Name and Address changes", "NameandAddresschanges");
        public static WinFormsField MenuItemCY = new WinFormsField("MENU-ITEM-CY", "CY. Charity Election", "CharityElection");
        public static WinFormsField MenuItemHE = new WinFormsField("MENU-ITEM-HE", "HE. Holder Extra Details", "HolderExtraDetails");
        public static WinFormsField MenuItemED = new WinFormsField("MENU-ITEM-ED", "ED. Employee Details", "EmployeeDetails");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC. Shareholder Communication Methods", "ShareholderCommunicationMethods");
        public static WinFormsField MenuItemN1 = new WinFormsField("MENU-ITEM-N1", "N1. Free format noting (1)", "Freeformatnoting(1)");
        public static WinFormsField MenuItemUD = new WinFormsField("MENU-ITEM-UD", "UD. Unconfirmed Deceased", "UnconfirmedDeceased");
        public static WinFormsField MenuItemN2 = new WinFormsField("MENU-ITEM-N2", "N2. Free format noting (2)", "Freeformatnoting(2)");
        public static WinFormsField MenuItemCD = new WinFormsField("MENU-ITEM-CD", "CD. Confirmed Deceased", "ConfirmedDeceased");
        public static WinFormsField MenuItemN3 = new WinFormsField("MENU-ITEM-N3", "N3. Free format noting (3)", "Freeformatnoting(3)");
        public static WinFormsField MenuItemN4 = new WinFormsField("MENU-ITEM-N4", "N4. Free format noting (4)", "Freeformatnoting(4)");
        public static WinFormsField MenuItemD1 = new WinFormsField("MENU-ITEM-D1", "D1. Deceased Estate notings (1)", "DeceasedEstatenotings(1)");
        public static WinFormsField MenuItemN5 = new WinFormsField("MENU-ITEM-N5", "N5. Free format noting (5)", "Freeformatnoting(5)");
        public static WinFormsField MenuItemD2 = new WinFormsField("MENU-ITEM-D2", "D2. Deceased Estate notings (2)", "DeceasedEstatenotings(2)");
        public static WinFormsField MenuItemD3 = new WinFormsField("MENU-ITEM-D3", "D3. Deceased Estate notings (3)", "DeceasedEstatenotings(3)");
        public static WinFormsField MenuItemFL = new WinFormsField("MENU-ITEM-FL", "FL. Load CSN FIN", "LoadCSNFIN");
        public static WinFormsField MenuItemD4 = new WinFormsField("MENU-ITEM-D4", "D4. Deceased Estate notings (4)", "DeceasedEstatenotings(4)");
        public static WinFormsField MenuItemFC = new WinFormsField("MENU-ITEM-FC", "FC. Change FIN", "ChangeFIN");
        public static WinFormsField MenuItemD5 = new WinFormsField("MENU-ITEM-D5", "D5. Deceased Estate notings (5)", "DeceasedEstatenotings(5)");
        public static WinFormsField MenuItemFG = new WinFormsField("MENU-ITEM-FG", "FG. Generate New FIN", "GenerateNewFIN");
        public static WinFormsField MenuItemP1 = new WinFormsField("MENU-ITEM-P1", "P1. Power of Attorney (1)", "PowerofAttorney(1)");
        public static WinFormsField MenuItemVP = new WinFormsField("MENU-ITEM-VP", "VP. Vesting Performance Schedule Change", "VestingPerformanceScheduleChange");
        public static WinFormsField MenuItemP2 = new WinFormsField("MENU-ITEM-P2", "P2. Power of Attorney (2)", "PowerofAttorney(2)");
        public static WinFormsField MenuItemP3 = new WinFormsField("MENU-ITEM-P3", "P3. Power of Attorney (3)", "PowerofAttorney(3)");
        public static WinFormsField MenuItemUX = new WinFormsField("MENU-ITEM-UX", "UX. US Taxpayer Details - Investors", "USTaxpayerDetails-Investors");
        public static WinFormsField MenuItemIR = new WinFormsField("MENU-ITEM-IR", "IR. IRL Taxpayer Details", "IRLTaxpayerDetails");
        public static WinFormsField MenuItemZA = new WinFormsField("MENU-ITEM-ZA", "ZA. ZAF Taxpayer Details", "ZAFTaxpayerDetails");
        public static WinFormsField UpdateOption = new WinFormsField("UPDATE-OPTION", "UpdateOption");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
