using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC01", "FormName");
		//Fields


        public static WinFormsField MenuItemOS = new WinFormsField("MENU-ITEM-OS", "OS. Organisation Search", "OrganisationSearch");
        public static WinFormsField MenuItemSU = new WinFormsField("MENU-ITEM-SU", "SU. Sundry Registers", "SundryRegisters");
        public static WinFormsField MenuItemPS = new WinFormsField("MENU-ITEM-PS", "PS. Personal Searches", "PersonalSearches");
        public static WinFormsField MenuItemCcs = new WinFormsField("MENU-ITEM-CCS", "CCS. Company Charges Search", "CompanyChargesSearch");
        public static WinFormsField MenuItemRos = new WinFormsField("MENU-ITEM-ROS", "ROS. Relational Organisation Search", "RelationalOrganisationSearch");
        public static WinFormsField MenuItemWsr = new WinFormsField("MENU-ITEM-WSR", "WSR. Weekly Summary Reports", "WeeklySummaryReports");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Sel = new WinFormsField("SEL", "Sel");
    }
}
