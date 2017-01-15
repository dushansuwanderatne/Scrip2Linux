using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLTAAP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLTAAP01", "FormName");
		//Fields


        public static WinFormsField FltaapKey0 = new WinFormsField("FLTAAP-KEY0", "FltaapKey0");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField AgentCode = new WinFormsField("AGENT-CODE", "AgentCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField BrokerCode2 = new WinFormsField("BROKER-CODE-2", "BrokerCode2");
        public static WinFormsField AgentCode2 = new WinFormsField("AGENT-CODE-2", "AgentCode2");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField ApplicationCategory = new WinFormsField("APPLICATION-CATEGORY", "ApplicationCategory");
        public static WinFormsField HinNumber = new WinFormsField("HIN-NUMBER", "HinNumber");
        public static WinFormsField IpnSpnNumber = new WinFormsField("IPN-SPN-NUMBER", "IpnSpnNumber");
        public static WinFormsField RunIN = new WinFormsField("RUN-IN", "RunIN");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
