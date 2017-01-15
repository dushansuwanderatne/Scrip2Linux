using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01500", "FormName");
		//Fields


        public static WinFormsField MenuItemDrr = new WinFormsField("MENU-ITEM-DRR", "DRR.  Dormant Role Report", "DormantRoleReport");
        public static WinFormsField MenuItemUlr = new WinFormsField("MENU-ITEM-ULR", "ULR.  User Login Report", "UserLoginReport");
        public static WinFormsField MenuItemRar = new WinFormsField("MENU-ITEM-RAR", "RAR.  Role Audit Report", "RoleAuditReport");
        public static WinFormsField MenuItemUar = new WinFormsField("MENU-ITEM-UAR", "UAR.  User Audit Report ", "UserAuditReport");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField MenuItemRde = new WinFormsField("MENU-ITEM-RDE", "RDE.  Role Data Export", "RoleDataExport");
    }
}
