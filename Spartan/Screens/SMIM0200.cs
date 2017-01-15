using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SMIM0200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SMIM0200", "FormName");
		//Fields


        public static WinFormsField MenuItemUpdnc = new WinFormsField("MENU-ITEM-UPDNC", "UPDNC. Update Paymaster Codes", "UpdatePaymasterCodes");
        public static WinFormsField MenuItemUpdpc = new WinFormsField("MENU-ITEM-UPDPC", "UPDPC. Update Payroll Codes", "UpdatePayrollCodes");
        public static WinFormsField MenuItemUpddc = new WinFormsField("MENU-ITEM-UPDDC", "UPDDC. Update Deduction Code Conversion", "UpdateDeductionCodeConversion");
        public static WinFormsField MenuItemPrint = new WinFormsField("MENU-ITEM-PRINT", "PRINT. Print Control Codes", "PrintControlCodes");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
