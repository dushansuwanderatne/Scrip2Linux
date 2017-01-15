using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03404

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03404", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField OldHolderID = new WinFormsField("OLD-HOLDER-ID", "OldHolderID");
        public static WinFormsField NewHolderID = new WinFormsField("NEW-HOLDER-ID", "NewHolderID");
        public static WinFormsField OldBrokerCode = new WinFormsField("OLD-BROKER-CODE", "OldBrokerCode");
        public static WinFormsField NewBrokerCode = new WinFormsField("NEW-BROKER-CODE", "NewBrokerCode");
    }
}
