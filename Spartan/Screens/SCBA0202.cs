using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SCBA0202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SCBA0202", "FormName");
		//Fields


        public static WinFormsField NumberUnits4 = new WinFormsField("NUMBER-UNITS-4", "NumberUnits4");
        public static WinFormsField NumberUnits5 = new WinFormsField("NUMBER-UNITS-5", "NumberUnits5");
        public static WinFormsField AmountMoney5 = new WinFormsField("AMOUNT-MONEY-5", "AmountMoney5");
        public static WinFormsField AmountMoney6 = new WinFormsField("AMOUNT-MONEY-6", "AmountMoney6");
    }
}
