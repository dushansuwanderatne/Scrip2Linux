using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13500", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ReturnPeriod = new WinFormsField("RETURN-PERIOD", "ReturnPeriod");
        public static WinFormsField InpAcc1 = new WinFormsField("INP-ACC1", "InpAcc1");
        public static WinFormsField InpAcc2 = new WinFormsField("INP-ACC2", "InpAcc2");
        public static WinFormsField TaxResidencyInd = new WinFormsField("TAX-RESIDENCY-IND", "TaxResidencyInd");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
