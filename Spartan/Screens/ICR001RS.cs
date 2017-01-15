using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR001RS

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR001RS", "FormName");
		//Fields


        public static WinFormsField MenuItemIca = new WinFormsField("MENU-ITEM-ICA", "ICA.  Issued Capital Approved Amounts Report", "IssuedCapitalApprovedAmountsReport");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
