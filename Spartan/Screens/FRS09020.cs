using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FRS09020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FRS09020", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField FlatFeeAmount = new WinFormsField("FLAT-FEE-AMOUNT", "FlatFeeAmount");
        public static WinFormsField FlatFeeLimit = new WinFormsField("FLAT-FEE-LIMIT", "FlatFeeLimit");
        public static WinFormsField SpecialPercent = new WinFormsField("SPECIAL-PERCENT", "SpecialPercent");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
