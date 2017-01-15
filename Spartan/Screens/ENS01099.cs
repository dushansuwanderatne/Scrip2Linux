using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01099", "FormName");
		//Fields


        public static WinFormsField MenuItemEnq = new WinFormsField("MENU-ITEM-ENQ", "ENQ.  HLDADD Enquiry", "HLDADDEnquiry");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit", "Exit");
    }
}
