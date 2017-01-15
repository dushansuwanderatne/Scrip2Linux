using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK04

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK04", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField AdvicesCount = new WinFormsField("ADVICES-COUNT", "AdvicesCount");
        public static WinFormsField AdvicesUnits = new WinFormsField("ADVICES-UNITS", "AdvicesUnits");
        public static WinFormsField AdviceConfirm = new WinFormsField("ADVICE-CONFIRM", "AdviceConfirm");
        public static WinFormsField UnauditedCount = new WinFormsField("UNAUDITED-COUNT", "UnauditedCount");
        public static WinFormsField UnauditedUnits = new WinFormsField("UNAUDITED-UNITS", "UnauditedUnits");
        public static WinFormsField NewCertCount = new WinFormsField("NEW-CERT-COUNT", "NewCertCount");
        public static WinFormsField NewCertUnits = new WinFormsField("NEW-CERT-UNITS", "NewCertUnits");
        public static WinFormsField StartCertNbr = new WinFormsField("START-CERT-NBR", "StartCertNbr");
        public static WinFormsField SettlementDate = new WinFormsField("SETTLEMENT-DATE", "SettlementDate");
        public static WinFormsField CertCount = new WinFormsField("CERT-COUNT", "CertCount");
        public static WinFormsField CertUnits = new WinFormsField("CERT-UNITS", "CertUnits");
        public static WinFormsField CertsFrom = new WinFormsField("CERTS-FROM", "CertsFrom");
        public static WinFormsField CertsTO = new WinFormsField("CERTS-TO", "CertsTO");
        public static WinFormsField TransFrom = new WinFormsField("TRANS-FROM", "TransFrom");
        public static WinFormsField TransTO = new WinFormsField("TRANS-TO", "TransTO");
        public static WinFormsField CertConfirm = new WinFormsField("CERT-CONFIRM", "CertConfirm");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
