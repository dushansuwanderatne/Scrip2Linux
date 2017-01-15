using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACS01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACS01000", "FormName");
		//Fields


        public static WinFormsField MenuItemGad = new WinFormsField("MENU-ITEM-GAD", "GAD.  Generate Accurate Default Parameter file Report", "GenerateAccurateDefaultParameterfileReport");
        public static WinFormsField MenuItemGil = new WinFormsField("MENU-ITEM-GIL", "GIL.  Generate Initial Load Data", "GenerateInitialLoadData");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
