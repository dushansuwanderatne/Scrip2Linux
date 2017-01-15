using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00100", "FormName");
		//Fields


        public static WinFormsField MenuItemSyst = new WinFormsField("MENU-ITEM-SYST", "SYST.   System", "System");
        public static WinFormsField MenuItemProj = new WinFormsField("MENU-ITEM-PROJ", "PROJ.   Projects", "Projects");
        public static WinFormsField MenuItemUser = new WinFormsField("MENU-ITEM-USER", "USER.   Users", "Users");
        public static WinFormsField MenuItemGrps = new WinFormsField("MENU-ITEM-GRPS", "GRPS.   Groups", "Groups");
        public static WinFormsField MenuItemSpec = new WinFormsField("MENU-ITEM-SPEC", "SPEC.   Specials", "Specials");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.     Exit", "Exit");
        public static WinFormsField Response = new WinFormsField("RESPONSE", "Response");
    }
}
