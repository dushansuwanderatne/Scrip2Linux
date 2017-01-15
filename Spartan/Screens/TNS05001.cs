using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS05001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS05001", "FormName");
		//Fields
        public static WinFormsField MenuItemGii = new WinFormsField("MENU-ITEM-GII", "GII. GIIN Validation Reporting", "GIINValidationReporting");
        public static WinFormsField MenuItemCic = new WinFormsField("MENU-ITEM-CIC", "CIC. Change in Circumstance Reporting", "ChangeinCircumstanceReporting");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.   Exit IRS Processing", "ExitIRSProcessing");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
