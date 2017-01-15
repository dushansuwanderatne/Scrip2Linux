using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03403

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03403", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField FromHolderID = new WinFormsField("FROM-HOLDER-ID", "FromHolderID");
        public static WinFormsField TOHolderID = new WinFormsField("TO-HOLDER-ID", "TOHolderID");
        public static WinFormsField FromBrokerCode = new WinFormsField("FROM-BROKER-CODE", "FromBrokerCode");
        public static WinFormsField FromHnaLine = new WinFormsField("FROM-HNA-LINE", "FromHnaLine");
        public static WinFormsField FromBrokerName = new WinFormsField("FROM-BROKER-NAME", "FromBrokerName");
        public static WinFormsField FromWarning = new WinFormsField("FROM-WARNING", "FromWarning");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
