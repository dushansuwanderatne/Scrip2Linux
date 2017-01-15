using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP02002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP02002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MonthlyAbtMax = new WinFormsField("MONTHLY-ABT-MAX", "MonthlyAbtMax");
        public static WinFormsField CashDepMin = new WinFormsField("CASH-DEP-MIN", "CashDepMin");
        public static WinFormsField AnnualCashLimit = new WinFormsField("ANNUAL-CASH-LIMIT", "AnnualCashLimit");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
