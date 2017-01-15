using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CurrentBroker = new WinFormsField("CURRENT-BROKER", "CurrentBroker");
        public static WinFormsField CurrentName = new WinFormsField("CURRENT-NAME", "CurrentName");
        public static WinFormsField Ipn = new WinFormsField("IPN", "Ipn");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Broker = new WinFormsField("BROKER", "Broker");
        public static WinFormsField LoginBroker = new WinFormsField("LOGIN-BROKER", "LoginBroker");
    }
}
