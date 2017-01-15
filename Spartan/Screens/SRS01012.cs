using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01012", "FormName");
		//Fields


        public static WinFormsField OldBrokerCode = new WinFormsField("OLD-BROKER-CODE", "OldBrokerCode");
        public static WinFormsField NewBrokerCode = new WinFormsField("NEW-BROKER-CODE", "NewBrokerCode");
    }
}
