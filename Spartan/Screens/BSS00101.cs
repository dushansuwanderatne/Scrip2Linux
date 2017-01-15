using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BSS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BSS00101", "FormName");
		//Fields


        public static WinFormsField MenuItemIE = new WinFormsField("MENU-ITEM-IE", "IE. Invoice Editing Menu", "InvoiceEditingMenu");
        public static WinFormsField MenuItemMH = new WinFormsField("MENU-ITEM-MH", "MH. Master Header Information", "MasterHeaderInformation");
        public static WinFormsField MenuItemAL = new WinFormsField("MENU-ITEM-AL", "AL. Allowances Maintenance", "AllowancesMaintenance");
        public static WinFormsField MenuItemCT = new WinFormsField("MENU-ITEM-CT", "CT. Client Group Totals Update", "ClientGroupTotalsUpdate");
        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
    }
}
