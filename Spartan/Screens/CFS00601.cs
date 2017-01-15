using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00601", "FormName");
		//Fields


        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerType = new WinFormsField("BROKER-TYPE", "BrokerType");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField NA = new WinFormsField("NA", "NA");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TelephoneNumber = new WinFormsField("TELEPHONE-NUMBER", "TelephoneNumber");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField EntrepotAccount1 = new WinFormsField("ENTREPOT-ACCOUNT-1", "EntrepotAccount1");
        public static WinFormsField EntrepotAccount2to7 = new WinFormsField("ENTREPOT-ACCOUNT-2TO7", "EntrepotAccount2to7");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCode = new WinFormsField("SEARCH-CODE", "SearchCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField ActionEnquire = new WinFormsField("ACTION-ENQUIRE", "ActionEnquire");
    }
}
