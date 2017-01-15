using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01605

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01605", "FormName");
		//Fields


        public static WinFormsField CertPrefixAction = new WinFormsField("CERT-PREFIX-ACTION", "CertPrefixAction");
        public static WinFormsField CertPrefixBroker = new WinFormsField("CERT-PREFIX-BROKER", "CertPrefixBroker");
        public static WinFormsField CertPrefixSystem = new WinFormsField("CERT-PREFIX-SYSTEM", "CertPrefixSystem");
        public static WinFormsField CertSuffixAction = new WinFormsField("CERT-SUFFIX-ACTION", "CertSuffixAction");
        public static WinFormsField CertSuffixBroker = new WinFormsField("CERT-SUFFIX-BROKER", "CertSuffixBroker");
        public static WinFormsField CertSuffixSystem = new WinFormsField("CERT-SUFFIX-SYSTEM", "CertSuffixSystem");
        public static WinFormsField TestOptions = new WinFormsField("TEST-OPTIONS", "TestOptions");
        public static WinFormsField CertNumber = new WinFormsField("CERT-NUMBER", "CertNumber");
    }
}
