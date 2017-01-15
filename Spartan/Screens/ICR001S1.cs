using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR001S1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR001S1", "FormName");
		//Fields


        public static WinFormsField MenuOptionName = new WinFormsField("MENU-OPTION-NAME", "MenuOptionName");
        public static WinFormsField MenuItemEnterCompanyCode = new WinFormsField("MENU-ITEM-ENTER COMPANY CODE", "Enter Company Code..........:", ".........:");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField MenuItemClassCode = new WinFormsField("MENU-ITEM-CLASS CODE", "Class Code............:", "...........:");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField MenuItemGroupNumber = new WinFormsField("MENU-ITEM-GROUP NUMBER", "Group Number..........:", ".........:");
        public static WinFormsField GroupNumber = new WinFormsField("GROUP-NUMBER", "GroupNumber");
        public static WinFormsField ClassAsxCode = new WinFormsField("CLASS-ASX-CODE", "ClassAsxCode");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField TODate = new WinFormsField("TO-DATE", "TODate");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
