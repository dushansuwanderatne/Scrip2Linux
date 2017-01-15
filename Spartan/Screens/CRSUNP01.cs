using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSUNP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSUNP01", "FormName");
		//Fields


        public static WinFormsField CrsunpKey0 = new WinFormsField("CRSUNP-KEY0", "CrsunpKey0");
        public static WinFormsField StatusFlag = new WinFormsField("STATUS-FLAG", "StatusFlag");
        public static WinFormsField CrestTransID = new WinFormsField("CREST-TRANS-ID", "CrestTransID");
        public static WinFormsField DropNumber = new WinFormsField("DROP-NUMBER", "DropNumber");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField DematerialiseFlag = new WinFormsField("DEMATERIALISE-FLAG", "DematerialiseFlag");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField SellCert1 = new WinFormsField("SELL-CERT1", "SellCert1");
        public static WinFormsField SellCert2 = new WinFormsField("SELL-CERT2", "SellCert2");
        public static WinFormsField SellCert3 = new WinFormsField("SELL-CERT3", "SellCert3");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField BadDeliveryReason = new WinFormsField("BAD-DELIVERY-REASON", "BadDeliveryReason");
        public static WinFormsField InvestorType = new WinFormsField("INVESTOR-TYPE", "InvestorType");
        public static WinFormsField MarkingDate = new WinFormsField("MARKING-DATE", "MarkingDate");
        public static WinFormsField MarkingNumber = new WinFormsField("MARKING-NUMBER", "MarkingNumber");
        public static WinFormsField CertificateShape = new WinFormsField("CERTIFICATE-SHAPE", "CertificateShape");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
