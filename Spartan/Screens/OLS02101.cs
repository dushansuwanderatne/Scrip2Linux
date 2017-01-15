using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS02101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS02101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrkAdvFlag = new WinFormsField("BRK-ADV-FLAG", "BrkAdvFlag");
        public static WinFormsField CurrentInd = new WinFormsField("CURRENT-IND", "CurrentInd");
        public static WinFormsField NA = new WinFormsField("NA", "NA");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TelephoneNumber = new WinFormsField("TELEPHONE-NUMBER", "TelephoneNumber");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField AdvisorCode = new WinFormsField("ADVISOR-CODE", "AdvisorCode");
        public static WinFormsField AssociatedBroker = new WinFormsField("ASSOCIATED-BROKER", "AssociatedBroker");
        public static WinFormsField AssociatedHid = new WinFormsField("ASSOCIATED-HID", "AssociatedHid");
        public static WinFormsField AwexXmit1st5 = new WinFormsField("AWEX-XMIT-1ST5", "AwexXmit1st5");
        public static WinFormsField AwexXmit2nd5 = new WinFormsField("AWEX-XMIT-2ND5", "AwexXmit2nd5");
        public static WinFormsField Action1 = new WinFormsField("ACTION1", "Action1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
