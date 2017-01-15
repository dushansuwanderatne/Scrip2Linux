using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD00203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD00203", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField CounterRegisterCode = new WinFormsField("COUNTER-REGISTER-CODE", "CounterRegisterCode");
        public static WinFormsField CounterBrokerCode = new WinFormsField("COUNTER-BROKER-CODE", "CounterBrokerCode");
        public static WinFormsField CounterBrokerAccount = new WinFormsField("COUNTER-BROKER-ACCOUNT", "CounterBrokerAccount");
        public static WinFormsField ConfirmAccount = new WinFormsField("CONFIRM-ACCOUNT", "ConfirmAccount");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
