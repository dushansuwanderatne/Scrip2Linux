using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0105", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkCurrency = new WinFormsField("BULK-CURRENCY", "BulkCurrency");
        public static WinFormsField SettlementFrom = new WinFormsField("SETTLEMENT-FROM", "SettlementFrom");
        public static WinFormsField SettlementTO = new WinFormsField("SETTLEMENT-TO", "SettlementTO");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
