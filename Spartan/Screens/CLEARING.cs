using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLEARING

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLEARING", "FormName");
		//Fields


        public static WinFormsField MenuItemCsm = new WinFormsField("MENU-ITEM-CSM", "CSM.   Clearing Sale Inventory Enquire/Update", "ClearingSaleInventoryEnquire/Update");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.    Exit From Clearing Sale Inventory Menu", "ExitFromClearingSaleInventoryMenu");
    }
}
