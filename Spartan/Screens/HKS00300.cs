using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00300

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00300", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PeriodMM = new WinFormsField("PERIOD-MM", "PeriodMM");
        public static WinFormsField PeriodYY = new WinFormsField("PERIOD-YY", "PeriodYY");
        public static WinFormsField ChargeableInd = new WinFormsField("CHARGEABLE-IND", "ChargeableInd");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
