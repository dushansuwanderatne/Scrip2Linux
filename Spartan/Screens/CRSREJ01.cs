using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSREJ01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSREJ01", "FormName");
		//Fields


        public static WinFormsField CrsrejKey0 = new WinFormsField("CRSREJ-KEY0", "CrsrejKey0");
        public static WinFormsField CrestTransID = new WinFormsField("CREST-TRANS-ID", "CrestTransID");
        public static WinFormsField DropNumber = new WinFormsField("DROP-NUMBER", "DropNumber");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField SellHolderID = new WinFormsField("SELL-HOLDER-ID", "SellHolderID");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField AddressType = new WinFormsField("ADDRESS-TYPE", "AddressType");
        public static WinFormsField SellCertC1 = new WinFormsField("SELL-CERT-C1", "SellCertC1");
        public static WinFormsField SellCertC2 = new WinFormsField("SELL-CERT-C2", "SellCertC2");
        public static WinFormsField SellCertC3 = new WinFormsField("SELL-CERT-C3", "SellCertC3");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField BadDeliveryReason = new WinFormsField("BAD-DELIVERY-REASON", "BadDeliveryReason");
        public static WinFormsField DematerialiseFlag = new WinFormsField("DEMATERIALISE-FLAG", "DematerialiseFlag");
        public static WinFormsField MarkingDate = new WinFormsField("MARKING-DATE", "MarkingDate");
        public static WinFormsField InvestorType = new WinFormsField("INVESTOR-TYPE", "InvestorType");
        public static WinFormsField MarkingNumber = new WinFormsField("MARKING-NUMBER", "MarkingNumber");
        public static WinFormsField CertificateShape = new WinFormsField("CERTIFICATE-SHAPE", "CertificateShape");
        public static WinFormsField RejectedMessage = new WinFormsField("REJECTED-MESSAGE", "RejectedMessage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
