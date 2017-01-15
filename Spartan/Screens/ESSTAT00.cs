using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSTAT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSTAT00", "FormName");
		//Fields


        public static WinFormsField TaxTableCode = new WinFormsField("TAX-TABLE-CODE", "TaxTableCode");
        public static WinFormsField TaxTableDesc = new WinFormsField("TAX-TABLE-DESC", "TaxTableDesc");
        public static WinFormsField CalculationPerc = new WinFormsField("CALCULATION-PERC", "CalculationPerc");
        public static WinFormsField BasePerc = new WinFormsField("BASE-PERC", "BasePerc");
        public static WinFormsField AdditionalPerc = new WinFormsField("ADDITIONAL-PERC", "AdditionalPerc");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField SelectPlanType = new WinFormsField("SELECT-PLAN-TYPE", "SelectPlanType");
        public static WinFormsField SelectFinYear = new WinFormsField("SELECT-FIN-YEAR", "SelectFinYear");
        public static WinFormsField SelectMonths = new WinFormsField("SELECT-MONTHS", "SelectMonths");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
