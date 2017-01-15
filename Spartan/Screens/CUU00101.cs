using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CUU00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CUU00101", "FormName");
		//Fields


        public static WinFormsField DeptCode = new WinFormsField("DEPT-CODE", "DeptCode");
        public static WinFormsField MenuItemCur = new WinFormsField("MENU-ITEM-CUR", "CUR. Currency Conversion Maintenance", "CurrencyConversionMaintenance");
        public static WinFormsField MenuItemRes = new WinFormsField("MENU-ITEM-RES", "RES. Bulk Reset Conversion Rate Entries", "BulkResetConversionRateEntries");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
