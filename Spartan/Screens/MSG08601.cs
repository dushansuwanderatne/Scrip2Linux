using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG08601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG08601", "FormName");
		//Fields


        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerNameKey = new WinFormsField("BROKER-NAME-KEY", "BrokerNameKey");
        public static WinFormsField NALine = new WinFormsField("NA-LINE", "NALine");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField TelephoneNumber = new WinFormsField("TELEPHONE-NUMBER", "TelephoneNumber");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCode = new WinFormsField("SEARCH-CODE", "SearchCode");
        public static WinFormsField SearchName = new WinFormsField("SEARCH-NAME", "SearchName");
    }
}
