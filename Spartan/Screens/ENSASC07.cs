using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC07", "FormName");
		//Fields


        public static WinFormsField MenuItemFN = new WinFormsField("MENU-ITEM-FN", "FN. Former Names", "FormerNames");
        public static WinFormsField MenuItemRH = new WinFormsField("MENU-ITEM-RH", "RH. Roles Held", "RolesHeld");
        public static WinFormsField MenuItemRG = new WinFormsField("MENU-ITEM-RG", "RG. Registers", "Registers");
        public static WinFormsField MenuItemSH = new WinFormsField("MENU-ITEM-SH", "SH. Shares Held", "SharesHeld");
        public static WinFormsField MenuItemDO = new WinFormsField("MENU-ITEM-DO", "DO. Documents", "Documents");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Place = new WinFormsField("PLACE", "Place");
        public static WinFormsField Sel = new WinFormsField("SEL", "Sel");
    }
}
