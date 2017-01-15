using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01002", "FormName");
		//Fields


        public static WinFormsField MenuItemCmp = new WinFormsField("MENU-ITEM-CMP", "CMP.  Change Password", "ChangePassword");
        public static WinFormsField MenuItemFwd = new WinFormsField("MENU-ITEM-FWD", "FWD.  Forward message system messages", "Forwardmessagesystemmessages");
        public static WinFormsField MenuItemGrp = new WinFormsField("MENU-ITEM-GRP", "GRP.  Setup Groups", "SetupGroups");
        public static WinFormsField MenuItemEud = new WinFormsField("MENU-ITEM-EUD", "EUD.  Edit User Details", "EditUserDetails");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuItemRur = new WinFormsField("MENU-ITEM-RUR", "RUR.  Role and User Reporting ", "RoleandUserReporting");
        public static WinFormsField MenuItemIbr = new WinFormsField("MENU-ITEM-IBR", "IBR.  Impersonate Business Role", "ImpersonateBusinessRole");
    }
}
