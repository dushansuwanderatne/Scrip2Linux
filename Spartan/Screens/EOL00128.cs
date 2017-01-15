using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00128

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00128", "FormName");
		//Fields


        public static WinFormsField MenuItemRvw = new WinFormsField("MENU-ITEM-RVW", "ESRVW. Reconstruction Down Reversal", "ReconstructionDownReversal");
        public static WinFormsField MenuItemRvx = new WinFormsField("MENU-ITEM-RVX", "ESRVX. Reconstruction Up Reversal", "ReconstructionUpReversal");
        public static WinFormsField MenuItemRvy = new WinFormsField("MENU-ITEM-RVY", "ESRVY. Allotment Down Reversal", "AllotmentDownReversal");
        public static WinFormsField MenuItemRvz = new WinFormsField("MENU-ITEM-RVZ", "ESRVZ. Allotment Up Reversal", "AllotmentUpReversal");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDescription = new WinFormsField("REGISTER-DESCRIPTION", "RegisterDescription");
        public static WinFormsField RegisterType = new WinFormsField("REGISTER-TYPE", "RegisterType");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
