using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STATS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STATS", "FormName");
		//Fields


        public static WinFormsField MenuItemSct = new WinFormsField("MENU-ITEM-SCT", "SCT.  Client Totals Update", "ClientTotalsUpdate");
        public static WinFormsField MenuItemCgr = new WinFormsField("MENU-ITEM-CGR", "CGR.  Client Group Report", "ClientGroupReport");
    }
}
