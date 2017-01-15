using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM08

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM08", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderJntID = new WinFormsField("HOLDER-JNT-ID", "HolderJntID");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField OMailAddrLine = new WinFormsField("O-MAIL-ADDR-LINE", "OMailAddrLine");
        public static WinFormsField NMailAddrLine = new WinFormsField("N-MAIL-ADDR-LINE", "NMailAddrLine");
        public static WinFormsField OCustodianRef = new WinFormsField("O-CUSTODIAN-REF", "OCustodianRef");
        public static WinFormsField NCustodianRef = new WinFormsField("N-CUSTODIAN-REF", "NCustodianRef");
        public static WinFormsField OOtherStatus = new WinFormsField("O-OTHER-STATUS", "OOtherStatus");
        public static WinFormsField NOtherStatus = new WinFormsField("N-OTHER-STATUS", "NOtherStatus");
        public static WinFormsField OTaxCode = new WinFormsField("O-TAX-CODE", "OTaxCode");
        public static WinFormsField NTaxCode = new WinFormsField("N-TAX-CODE", "NTaxCode");
        public static WinFormsField OIntermediaryInd = new WinFormsField("O-INTERMEDIARY-IND", "OIntermediaryInd");
        public static WinFormsField NIntermediaryInd = new WinFormsField("N-INTERMEDIARY-IND", "NIntermediaryInd");
        public static WinFormsField OEntityType = new WinFormsField("O-ENTITY-TYPE", "OEntityType");
        public static WinFormsField NEntityType = new WinFormsField("N-ENTITY-TYPE", "NEntityType");
        public static WinFormsField OMailAddrPC = new WinFormsField("O-MAIL-ADDR-PC", "OMailAddrPC");
        public static WinFormsField NMailAddrPC = new WinFormsField("N-MAIL-ADDR-PC", "NMailAddrPC");
        public static WinFormsField OBenAddrLine = new WinFormsField("O-BEN-ADDR-LINE", "OBenAddrLine");
        public static WinFormsField NBenAddrLine = new WinFormsField("N-BEN-ADDR-LINE", "NBenAddrLine");
        public static WinFormsField OTaxAddrLine = new WinFormsField("O-TAX-ADDR-LINE", "OTaxAddrLine");
        public static WinFormsField NTaxAddrLine = new WinFormsField("N-TAX-ADDR-LINE", "NTaxAddrLine");
        public static WinFormsField OBenAddrPC = new WinFormsField("O-BEN-ADDR-PC", "OBenAddrPC");
        public static WinFormsField NBenAddrPC = new WinFormsField("N-BEN-ADDR-PC", "NBenAddrPC");
        public static WinFormsField OTaxAddrPC = new WinFormsField("O-TAX-ADDR-PC", "OTaxAddrPC");
        public static WinFormsField NTaxAddrPC = new WinFormsField("N-TAX-ADDR-PC", "NTaxAddrPC");
        public static WinFormsField ODateBirth = new WinFormsField("O-DATE-BIRTH", "ODateBirth");
        public static WinFormsField NDateBirth = new WinFormsField("N-DATE-BIRTH", "NDateBirth");
        public static WinFormsField OTaxReference = new WinFormsField("O-TAX-REFERENCE", "OTaxReference");
        public static WinFormsField NTaxReference = new WinFormsField("N-TAX-REFERENCE", "NTaxReference");
        public static WinFormsField OTaxRefType = new WinFormsField("O-TAX-REF-TYPE", "OTaxRefType");
        public static WinFormsField NTaxRefType = new WinFormsField("N-TAX-REF-TYPE", "NTaxRefType");
        public static WinFormsField OPrevName = new WinFormsField("O-PREV-NAME", "OPrevName");
        public static WinFormsField NPrevName = new WinFormsField("N-PREV-NAME", "NPrevName");
        public static WinFormsField ODwtExpiryDT = new WinFormsField("O-DWT-EXPIRY-DT", "ODwtExpiryDT");
        public static WinFormsField NDwtExpiryDT = new WinFormsField("N-DWT-EXPIRY-DT", "NDwtExpiryDT");
        public static WinFormsField OSigName = new WinFormsField("O-SIG-NAME", "OSigName");
        public static WinFormsField NSigName = new WinFormsField("N-SIG-NAME", "NSigName");
        public static WinFormsField OCertStatus = new WinFormsField("O-CERT-STATUS", "OCertStatus");
        public static WinFormsField NCertStatus = new WinFormsField("N-CERT-STATUS", "NCertStatus");
        public static WinFormsField OSigPhone = new WinFormsField("O-SIG-PHONE", "OSigPhone");
        public static WinFormsField NSigPhone = new WinFormsField("N-SIG-PHONE", "NSigPhone");
        public static WinFormsField OCertFileRef = new WinFormsField("O-CERT-FILE-REF", "OCertFileRef");
        public static WinFormsField NCertFileRef = new WinFormsField("N-CERT-FILE-REF", "NCertFileRef");
        public static WinFormsField OSigCapType = new WinFormsField("O-SIG-CAP-TYPE", "OSigCapType");
        public static WinFormsField NSigCapType = new WinFormsField("N-SIG-CAP-TYPE", "NSigCapType");
        public static WinFormsField OSigDate = new WinFormsField("O-SIG-DATE", "OSigDate");
        public static WinFormsField NSigDate = new WinFormsField("N-SIG-DATE", "NSigDate");
        public static WinFormsField OCertDwtRef = new WinFormsField("O-CERT-DWT-REF", "OCertDwtRef");
        public static WinFormsField NCertDwtRef = new WinFormsField("N-CERT-DWT-REF", "NCertDwtRef");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
