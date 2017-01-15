using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS02002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS02002", "FormName");
		//Fields


        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField BrokerDesc = new WinFormsField("BROKER-DESC", "BrokerDesc");
        public static WinFormsField ContactName = new WinFormsField("CONTACT-NAME", "ContactName");
        public static WinFormsField ContactTitle = new WinFormsField("CONTACT-TITLE", "ContactTitle");
        public static WinFormsField ContactNO = new WinFormsField("CONTACT-NO", "ContactNO");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
        public static WinFormsField Ipn = new WinFormsField("IPN", "Ipn");
    }
}
