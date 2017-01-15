using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02901

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02901", "FormName");
		//Fields


        public static WinFormsField MenuItemSdc = new WinFormsField("MENU-ITEM-SDC", "SDC. Payment Components", "PaymentComponents");
        public static WinFormsField MenuItemSst = new WinFormsField("MENU-ITEM-SST", "SST. Income Source Tax Rates", "IncomeSourceTaxRates");
        public static WinFormsField MenuItemSct = new WinFormsField("MENU-ITEM-SCT", "SCT. Component Category/Types", "ComponentCategory/Types");
        public static WinFormsField MenuItemStr = new WinFormsField("MENU-ITEM-STR", "STR. Tax Codes", "TaxCodes");
        public static WinFormsField MenuItemSar = new WinFormsField("MENU-ITEM-SAR", "SAR. AIIR References", "AIIRReferences");
        public static WinFormsField MenuItemSac = new WinFormsField("MENU-ITEM-SAC", "SAC. AIIR/Payment Component Type", "AIIR/PaymentComponentType");
        public static WinFormsField MenuItemSca = new WinFormsField("MENU-ITEM-SCA", "SCA. Payment Component Type/AIIR", "PaymentComponentType/AIIR");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField MenuItemArf = new WinFormsField("MENU-ITEM-ARF", "ARF. SCRIP/Accurate Reference ", "SCRIP/AccurateReference");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
