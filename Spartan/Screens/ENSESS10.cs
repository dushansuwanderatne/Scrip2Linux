using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS10", "FormName");
		//Fields


        public static WinFormsField TradeRefLine = new WinFormsField("TRADE-REF-LINE", "TradeRefLine");
    }
}