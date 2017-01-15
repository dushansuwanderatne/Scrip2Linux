using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS00103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS00103", "FormName");
		//Fields
        public static WinFormsField MenuItemTfnup = new WinFormsField("MENU-ITEM-TFNUP", "TFNUP.  Tax File Number Updating", "TaxFileNumberUpdating");
        public static WinFormsField MenuItemTfnrq = new WinFormsField("MENU-ITEM-TFNRQ", "TFNRQ.  Tax File Number Notice Request", "TaxFileNumberNoticeRequest");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TrncdeSelection = new WinFormsField("TRNCDE-SELECTION", "TrncdeSelection");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
