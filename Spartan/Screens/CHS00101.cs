using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHS00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHS00101", "FormName");
		//Fields


        public static WinFormsField MenuItem406 = new WinFormsField("MENU-ITEM-406", "406. Certificated to CHESS Transfer Authorisation Request", "CertificatedtoCHESSTransferAuthorisationRequest");
        public static WinFormsField MenuItem408 = new WinFormsField("MENU-ITEM-408", "408. Issuer Sponsored to CHESS Transfer Authorisation Request", "IssuerSponsoredtoCHESSTransferAuthorisationRequest");
        public static WinFormsField MenuItem424 = new WinFormsField("MENU-ITEM-424", "424. FAST to CHESS Transfer Authorisation Request", "FASTtoCHESSTransferAuthorisationRequest");
        public static WinFormsField MenuItem402 = new WinFormsField("MENU-ITEM-402", "402. Certificated to CHESS Conversion Authorisation Request", "CertificatedtoCHESSConversionAuthorisationRequest");
        public static WinFormsField MenuItem410 = new WinFormsField("MENU-ITEM-410", "410. FAST to CHESS Conversion Authorisation Request", "FASTtoCHESSConversionAuthorisationRequest");
        public static WinFormsField MenuItem404 = new WinFormsField("MENU-ITEM-404", "404. Issuer Sponsored to CHESS Conversion Authorisation Request", "IssuerSponsoredtoCHESSConversionAuthorisationRequest");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 1", "1");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
