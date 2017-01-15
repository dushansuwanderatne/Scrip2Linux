using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00602

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00602", "FormName");
		//Fields


        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField MatchNameKey = new WinFormsField("MATCH-NAME-KEY", "MatchNameKey");
        public static WinFormsField ActionCode = new WinFormsField("ACTION-CODE", "ActionCode");
    }
}
