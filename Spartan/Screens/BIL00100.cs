using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BIL00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BIL00100", "FormName");
		//Fields


        public static WinFormsField MenuItemAsx = new WinFormsField("MENU-ITEM-ASX", "ASX.  ASX Charge rates", "ASXChargerates");
        public static WinFormsField MenuItemUsc = new WinFormsField("MENU-ITEM-USC", "USC.  Update SCRIP client Charge rates", "UpdateSCRIPclientChargerates");
        public static WinFormsField MenuItemCS = new WinFormsField("MENU-ITEM-CS", "CS.   Update Company Statistics", "UpdateCompanyStatistics");
        public static WinFormsField MenuItemCG = new WinFormsField("MENU-ITEM-CG", "CG.   Client Group Totals", "ClientGroupTotals");
        public static WinFormsField MenuItemIM = new WinFormsField("MENU-ITEM-IM", "IM.   Invoice Maintenance Menu", "InvoiceMaintenanceMenu");
        public static WinFormsField MenuItemSC = new WinFormsField("MENU-ITEM-SC", "SC.  Select Company", "SelectCompany");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit from System", "ExitfromSystem");
    }
}
