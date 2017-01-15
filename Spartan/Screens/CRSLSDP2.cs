using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLSDP2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLSDP2", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Form = new WinFormsField("FORM", "Form");
        public static WinFormsField CertificateNbrCount = new WinFormsField("CERTIFICATE-NBR-COUNT", "CertificateNbrCount");
        public static WinFormsField CertificateNbr = new WinFormsField("CERTIFICATE-NBR", "CertificateNbr");
        public static WinFormsField RegistrarsAccountFolioNbr = new WinFormsField("REGISTRARS-ACCOUNT-FOLIO-NBR", "RegistrarsAccountFolioNbr");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
