using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00124

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00124", "FormName");
		//Fields
        public static WinFormsField MenuItemInt = new WinFormsField("MENU-ITEM-INT", "INT. Health & Integrity Check", "Health&IntegrityCheck");
        public static WinFormsField MenuItemUpl = new WinFormsField("MENU-ITEM-UPL", "UPL. Bulk Upload Process", "BulkUploadProcess");
        public static WinFormsField MenuItemAwl = new WinFormsField("MENU-ITEM-AWL", "AWL. Manual Award", "ManualAward");
        public static WinFormsField MenuItemRva = new WinFormsField("MENU-ITEM-RVA", "RVA. Reversal Of Award", "ReversalOfAward");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
