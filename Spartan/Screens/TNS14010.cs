using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientName = new WinFormsField("CLIENT-NAME", "ClientName");
        public static WinFormsField ClientAddressLine = new WinFormsField("CLIENT-ADDRESS-LINE", "ClientAddressLine");
        public static WinFormsField ClientSuburb = new WinFormsField("CLIENT-SUBURB", "ClientSuburb");
        public static WinFormsField ClientState = new WinFormsField("CLIENT-STATE", "ClientState");
        public static WinFormsField ClientPostcode = new WinFormsField("CLIENT-POSTCODE", "ClientPostcode");
        public static WinFormsField AtoContactName = new WinFormsField("ATO-CONTACT-NAME", "AtoContactName");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField PhoneNumber = new WinFormsField("PHONE-NUMBER", "PhoneNumber");
    }
}
