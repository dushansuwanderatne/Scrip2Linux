using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRS00508

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRS00508", "FormName");
		//Fields
        public static WinFormsField TradingID = new WinFormsField("TRADING-ID", "TradingID");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
    }
}
