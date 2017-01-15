using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00000", "FormName");
		//Fields


        public static WinFormsField MenuItemO = new WinFormsField("MENU-ITEM-O", "O. Company Options", "CompanyOptions");
        public static WinFormsField MenuItemV1 = new WinFormsField("MENU-ITEM-V1", "V1. Variable flag 1", "Variableflag1");
        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C. Class", "Class");
        public static WinFormsField MenuItemV2 = new WinFormsField("MENU-ITEM-V2", "V2. Variable flag 2", "Variableflag2");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R. Register", "Register");
        public static WinFormsField MenuItemV3 = new WinFormsField("MENU-ITEM-V3", "V3. Variable flag 3", "Variableflag3");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T. Type (Status code)", "Type(Statuscode)");
        public static WinFormsField MenuItemG = new WinFormsField("MENU-ITEM-G", "G. Group", "Group");
        public static WinFormsField MenuItemD1 = new WinFormsField("MENU-ITEM-D1", "D1. DRP 1 details", "DRP1details");
        public static WinFormsField MenuItemI = new WinFormsField("MENU-ITEM-I", "I. Indicator (certificate)", "Indicator(certificate)");
        public static WinFormsField MenuItemD2 = new WinFormsField("MENU-ITEM-D2", "D2. DRP 2 details", "DRP2details");
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Account", "Account");
        public static WinFormsField MenuItemD3 = new WinFormsField("MENU-ITEM-D3", "D3. DRP 3 details", "DRP3details");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Conversion Code Entry", "ExitConversionCodeEntry");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldUfd = new WinFormsField("OLD-UFD", "OldUfd");
        public static WinFormsField NewUfd = new WinFormsField("NEW-UFD", "NewUfd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuOldCode = new WinFormsField("MENU-OLD-CODE", "MenuOldCode");
    }
}
