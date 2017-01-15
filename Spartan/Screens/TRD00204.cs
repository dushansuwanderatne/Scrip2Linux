using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00204

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00204", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
    }
}
