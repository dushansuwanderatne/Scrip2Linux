using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS0104I

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS0104I", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField CustodianReference = new WinFormsField("CUSTODIAN-REFERENCE", "CustodianReference");
        public static WinFormsField ScripRegAddrLine = new WinFormsField("SCRIP-REG-ADDR-LINE", "ScripRegAddrLine");
        public static WinFormsField ScripRegAddrPCDom = new WinFormsField("SCRIP-REG-ADDR-PC-DOM", "ScripRegAddrPCDom");
        public static WinFormsField TaxReference = new WinFormsField("TAX-REFERENCE", "TaxReference");
        public static WinFormsField EntityType = new WinFormsField("ENTITY-TYPE", "EntityType");
        public static WinFormsField DateBirth = new WinFormsField("DATE-BIRTH", "DateBirth");
        public static WinFormsField BenAddrLine = new WinFormsField("BEN-ADDR-LINE", "BenAddrLine");
        public static WinFormsField TaxCode = new WinFormsField("TAX-CODE", "TaxCode");
        public static WinFormsField SigName = new WinFormsField("SIG-NAME", "SigName");
        public static WinFormsField SigCapacity = new WinFormsField("SIG-CAPACITY", "SigCapacity");
        public static WinFormsField SigPhone = new WinFormsField("SIG-PHONE", "SigPhone");
        public static WinFormsField DwtExpiryDT = new WinFormsField("DWT-EXPIRY-DT", "DwtExpiryDT");
        public static WinFormsField SigDate = new WinFormsField("SIG-DATE", "SigDate");
        public static WinFormsField TotHolderNum = new WinFormsField("TOT-HOLDER-NUM", "TotHolderNum");
        public static WinFormsField CurrHolderNum = new WinFormsField("CURR-HOLDER-NUM", "CurrHolderNum");
        public static WinFormsField IntermediaryInd = new WinFormsField("INTERMEDIARY-IND", "IntermediaryInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField OtherStatus = new WinFormsField("OTHER-STATUS", "OtherStatus");
        public static WinFormsField OtherStatusDesc = new WinFormsField("OTHER-STATUS-DESC", "OtherStatusDesc");
        public static WinFormsField BenAddrPCDom = new WinFormsField("BEN-ADDR-PC-DOM", "BenAddrPCDom");
        public static WinFormsField PrevName = new WinFormsField("PREV-NAME", "PrevName");
        public static WinFormsField CertFileRef = new WinFormsField("CERT-FILE-REF", "CertFileRef");
        public static WinFormsField CertHldrRef = new WinFormsField("CERT-HLDR-REF", "CertHldrRef");
        public static WinFormsField CertStatus = new WinFormsField("CERT-STATUS", "CertStatus");
        public static WinFormsField CertStatusDesc = new WinFormsField("CERT-STATUS-DESC", "CertStatusDesc");
        public static WinFormsField SigCapType = new WinFormsField("SIG-CAP-TYPE", "SigCapType");
        public static WinFormsField TaxRefType = new WinFormsField("TAX-REF-TYPE", "TaxRefType");
        public static WinFormsField TaxAddrLine = new WinFormsField("TAX-ADDR-LINE", "TaxAddrLine");
        public static WinFormsField TaxAddrPCDom = new WinFormsField("TAX-ADDR-PC-DOM", "TaxAddrPCDom");
        public static WinFormsField MailAddrLine = new WinFormsField("MAIL-ADDR-LINE", "MailAddrLine");
        public static WinFormsField MailAddrPCDom = new WinFormsField("MAIL-ADDR-PC-DOM", "MailAddrPCDom");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
