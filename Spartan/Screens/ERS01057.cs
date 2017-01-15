using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01057

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01057", "FormName");
		//Fields
        public static WinFormsField EventCode = new WinFormsField("EVENT-CODE", "EventCode");
        public static WinFormsField EventType = new WinFormsField("EVENT-TYPE", "EventType");
        public static WinFormsField EventDate = new WinFormsField("EVENT-DATE", "EventDate");
        public static WinFormsField WithholdingTaxRate = new WinFormsField("WITHHOLDING-TAX-RATE", "WithholdingTaxRate");
        public static WinFormsField WithholdingTaxDesc = new WinFormsField("WITHHOLDING-TAX-DESC", "WithholdingTaxDesc");
        public static WinFormsField MarketValueType = new WinFormsField("MARKET-VALUE-TYPE", "MarketValueType");
        public static WinFormsField ComplexHolderCode = new WinFormsField("COMPLEX-HOLDER-CODE", "ComplexHolderCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
