using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC04", "FormName");
		//Fields


        public static WinFormsField MenuItemOD = new WinFormsField("MENU-ITEM-OD", "OD. Organisation Details", "OrganisationDetails");
        public static WinFormsField MenuItemRA = new WinFormsField("MENU-ITEM-RA", "RA. Registered Address", "RegisteredAddress");
        public static WinFormsField MenuItemRO = new WinFormsField("MENU-ITEM-RO", "RO. Roles in Organisation", "RolesinOrganisation");
        public static WinFormsField MenuItemSS = new WinFormsField("MENU-ITEM-SS", "SS. Share Structure", "ShareStructure");
        public static WinFormsField MenuItemSH = new WinFormsField("MENU-ITEM-SH", "SH. Shareholders", "Shareholders");
        public static WinFormsField MenuItemCH = new WinFormsField("MENU-ITEM-CH", "CH. Charges", "Charges");
        public static WinFormsField MenuItemDO = new WinFormsField("MENU-ITEM-DO", "DO. Documents", "Documents");
        public static WinFormsField MenuItemAR = new WinFormsField("MENU-ITEM-AR", "AR. Annual Returns", "AnnualReturns");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Number = new WinFormsField("NUMBER", "Number");
        public static WinFormsField Sel = new WinFormsField("SEL", "Sel");
        public static WinFormsField CurrentYN = new WinFormsField("CURRENT-YN", "CurrentYN");
    }
}
