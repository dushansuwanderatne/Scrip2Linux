using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14095

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14095", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField EssName = new WinFormsField("ESS-NAME", "EssName");
        public static WinFormsField EssAbn = new WinFormsField("ESS-ABN", "EssAbn");
        public static WinFormsField EssAddressLine = new WinFormsField("ESS-ADDRESS-LINE", "EssAddressLine");
        public static WinFormsField EssSuburb = new WinFormsField("ESS-SUBURB", "EssSuburb");
        public static WinFormsField EssState = new WinFormsField("ESS-STATE", "EssState");
        public static WinFormsField EssPostcode = new WinFormsField("ESS-POSTCODE", "EssPostcode");
        public static WinFormsField EssCountry = new WinFormsField("ESS-COUNTRY", "EssCountry");
        public static WinFormsField EssContactName = new WinFormsField("ESS-CONTACT-NAME", "EssContactName");
        public static WinFormsField EssFaxNumber = new WinFormsField("ESS-FAX-NUMBER", "EssFaxNumber");
        public static WinFormsField EssPhoneNumber = new WinFormsField("ESS-PHONE-NUMBER", "EssPhoneNumber");
        public static WinFormsField EssEmailID = new WinFormsField("ESS-EMAIL-ID", "EssEmailID");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
