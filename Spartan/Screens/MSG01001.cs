using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01001", "FormName");
		//Fields


        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R.   Read messages", "Readmessages");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S.   Send messages", "Sendmessages");
        public static WinFormsField MenuItemT = new WinFormsField("MENU-ITEM-T", "T.   Send a telephone message", "Sendatelephonemessage");
        public static WinFormsField MenuItemM = new WinFormsField("MENU-ITEM-M", "M.   Maintain sent messages", "Maintainsentmessages");
        public static WinFormsField MenuItemU = new WinFormsField("MENU-ITEM-U", "U.   User list", "Userlist");
        public static WinFormsField MenuItemG = new WinFormsField("MENU-ITEM-G", "G.   Group list", "Grouplist");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
