using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FOL03003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FOL03003", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CapitalLossProfit = new WinFormsField("CAPITAL-LOSS-PROFIT", "CapitalLossProfit");
        public static WinFormsField ProfitLossInd = new WinFormsField("PROFIT-LOSS-IND", "ProfitLossInd");
        public static WinFormsField NetInterest = new WinFormsField("NET-INTEREST", "NetInterest");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
