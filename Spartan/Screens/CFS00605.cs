using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00605

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00605", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
