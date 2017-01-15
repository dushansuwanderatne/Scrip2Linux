using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01054

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01054", "FormName");
		//Fields


        public static WinFormsField TradeReference = new WinFormsField("TRADE-REFERENCE", "TradeReference");
        public static WinFormsField BrokerIpn = new WinFormsField("BROKER-IPN", "BrokerIpn");
    }
}
