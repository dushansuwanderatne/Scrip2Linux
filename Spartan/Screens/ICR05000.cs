using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR05000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR05000", "FormName");
		//Fields


        public static WinFormsField MenuItemIca = new WinFormsField("MENU-ITEM-ICA", "ICA.  Issued Capital Approved Amounts Report", "IssuedCapitalApprovedAmountsReport");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemAts = new WinFormsField("MENU-ITEM-ATS", "ATS.  Issued Capital Active Tolerance Summary", "IssuedCapitalActiveToleranceSummary");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
