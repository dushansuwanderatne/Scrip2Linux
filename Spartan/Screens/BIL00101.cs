using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BIL00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BIL00101", "FormName");
		//Fields


        public static WinFormsField MenuItemCG = new WinFormsField("MENU-ITEM-CG", "CG.   Client Group Totals", "ClientGroupTotals");
        public static WinFormsField MenuItemIM = new WinFormsField("MENU-ITEM-IM", "IM.   Invoice Maintenance Menu", "InvoiceMaintenanceMenu");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   EXIT CHARGE", "EXITCHARGE");
    }
}
