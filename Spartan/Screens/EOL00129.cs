using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00129

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00129", "FormName");
		//Fields


        public static WinFormsField MenuItemEsuua = new WinFormsField("MENU-ITEM-ESUUA", "ESUUA.  ESS Unalloc Acc Unit Price Add", "ESSUnallocAccUnitPriceAdd");
        public static WinFormsField MenuItemEsucc = new WinFormsField("MENU-ITEM-ESUCC", "ESUCC.  ESS Unalloc Acc Unit Price Chg ", "ESSUnallocAccUnitPriceChg");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
