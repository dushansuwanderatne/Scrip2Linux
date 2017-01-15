using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01011", "FormName");
		//Fields


        public static WinFormsField MenuItemCB = new WinFormsField("MENU-ITEM-CB", "CB.  Change Current Broker Code", "ChangeCurrentBrokerCode");
        public static WinFormsField MenuItemDS = new WinFormsField("MENU-ITEM-DS", "DS.  Dump Surtrn File", "DumpSurtrnFile");
        public static WinFormsField MenuItemUL = new WinFormsField("MENU-ITEM-UL", "UL.  User Listing", "UserListing");
        public static WinFormsField MenuItemUA = new WinFormsField("MENU-ITEM-UA", "UA.  User Update", "UserUpdate");
        public static WinFormsField MenuItemPP = new WinFormsField("MENU-ITEM-PP", "PP.  Participating Companies", "ParticipatingCompanies");
        public static WinFormsField MenuItemCU = new WinFormsField("MENU-ITEM-CU", "CU.  Company File Update", "CompanyFileUpdate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
