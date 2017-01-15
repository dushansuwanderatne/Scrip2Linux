using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS00236

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS00236", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField RangeFrom = new WinFormsField("RANGE-FROM", "RangeFrom");
        public static WinFormsField RangeTO = new WinFormsField("RANGE-TO", "RangeTO");
        public static WinFormsField CommPercentage = new WinFormsField("COMM-PERCENTAGE", "CommPercentage");
        public static WinFormsField MinimumRate = new WinFormsField("MINIMUM-RATE", "MinimumRate");
        public static WinFormsField MaximumRate = new WinFormsField("MAXIMUM-RATE", "MaximumRate");
        public static WinFormsField StampDutyValue = new WinFormsField("STAMP-DUTY-VALUE", "StampDutyValue");
    }
}
