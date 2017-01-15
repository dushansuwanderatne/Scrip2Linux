using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM09

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM09", "FormName");
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
        public static WinFormsField OCustodianRef = new WinFormsField("O-CUSTODIAN-REF", "OCustodianRef");
        public static WinFormsField NCustodianRef = new WinFormsField("N-CUSTODIAN-REF", "NCustodianRef");
        public static WinFormsField OTradingName1 = new WinFormsField("O-TRADING-NAME1", "OTradingName1");
        public static WinFormsField NTradingName1 = new WinFormsField("N-TRADING-NAME1", "NTradingName1");
        public static WinFormsField OOtherStatus = new WinFormsField("O-OTHER-STATUS", "OOtherStatus");
        public static WinFormsField NOtherStatus = new WinFormsField("N-OTHER-STATUS", "NOtherStatus");
        public static WinFormsField OTradingName2 = new WinFormsField("O-TRADING-NAME2", "OTradingName2");
        public static WinFormsField NTradingName2 = new WinFormsField("N-TRADING-NAME2", "NTradingName2");
        public static WinFormsField OTaxCode = new WinFormsField("O-TAX-CODE", "OTaxCode");
        public static WinFormsField NTaxCode = new WinFormsField("N-TAX-CODE", "NTaxCode");
        public static WinFormsField OEmail = new WinFormsField("O-EMAIL", "OEmail");
        public static WinFormsField OIntermediaryInd = new WinFormsField("O-INTERMEDIARY-IND", "OIntermediaryInd");
        public static WinFormsField NIntermediaryInd = new WinFormsField("N-INTERMEDIARY-IND", "NIntermediaryInd");
        public static WinFormsField NEmail = new WinFormsField("N-EMAIL", "NEmail");
        public static WinFormsField OEntityType = new WinFormsField("O-ENTITY-TYPE", "OEntityType");
        public static WinFormsField NEntityType = new WinFormsField("N-ENTITY-TYPE", "NEntityType");
        public static WinFormsField OBenAddrLine = new WinFormsField("O-BEN-ADDR-LINE", "OBenAddrLine");
        public static WinFormsField NBenAddrLine = new WinFormsField("N-BEN-ADDR-LINE", "NBenAddrLine");
        public static WinFormsField OPostAddrLine = new WinFormsField("O-POST-ADDR-LINE", "OPostAddrLine");
        public static WinFormsField NPostAddrLine = new WinFormsField("N-POST-ADDR-LINE", "NPostAddrLine");
        public static WinFormsField OBenAddrPC = new WinFormsField("O-BEN-ADDR-PC", "OBenAddrPC");
        public static WinFormsField NBenAddrPC = new WinFormsField("N-BEN-ADDR-PC", "NBenAddrPC");
        public static WinFormsField OPostAddrPC = new WinFormsField("O-POST-ADDR-PC", "OPostAddrPC");
        public static WinFormsField NPostAddrPC = new WinFormsField("N-POST-ADDR-PC", "NPostAddrPC");
        public static WinFormsField ODateBirth = new WinFormsField("O-DATE-BIRTH", "ODateBirth");
        public static WinFormsField NDateBirth = new WinFormsField("N-DATE-BIRTH", "NDateBirth");
        public static WinFormsField OTaxReference = new WinFormsField("O-TAX-REFERENCE", "OTaxReference");
        public static WinFormsField NTaxReference = new WinFormsField("N-TAX-REFERENCE", "NTaxReference");
        public static WinFormsField OTaxRefType = new WinFormsField("O-TAX-REF-TYPE", "OTaxRefType");
        public static WinFormsField NTaxRefType = new WinFormsField("N-TAX-REF-TYPE", "NTaxRefType");
        public static WinFormsField OExemptionCode = new WinFormsField("O-EXEMPTION-CODE", "OExemptionCode");
        public static WinFormsField NExemptionCode = new WinFormsField("N-EXEMPTION-CODE", "NExemptionCode");
        public static WinFormsField OIDReference = new WinFormsField("O-ID-REFERENCE", "OIDReference");
        public static WinFormsField NIDReference = new WinFormsField("N-ID-REFERENCE", "NIDReference");
        public static WinFormsField OIDRefType = new WinFormsField("O-ID-REF-TYPE", "OIDRefType");
        public static WinFormsField NIDRefType = new WinFormsField("N-ID-REF-TYPE", "NIDRefType");
        public static WinFormsField OCertStatus = new WinFormsField("O-CERT-STATUS", "OCertStatus");
        public static WinFormsField NCertStatus = new WinFormsField("N-CERT-STATUS", "NCertStatus");
        public static WinFormsField OPhone = new WinFormsField("O-PHONE", "OPhone");
        public static WinFormsField NPhone = new WinFormsField("N-PHONE", "NPhone");
        public static WinFormsField OPassportCtry = new WinFormsField("O-PASSPORT-CTRY", "OPassportCtry");
        public static WinFormsField NPassportCtry = new WinFormsField("N-PASSPORT-CTRY", "NPassportCtry");
        public static WinFormsField OSigDate = new WinFormsField("O-SIG-DATE", "OSigDate");
        public static WinFormsField NSigDate = new WinFormsField("N-SIG-DATE", "NSigDate");
        public static WinFormsField ODecName = new WinFormsField("O-DEC-NAME", "ODecName");
        public static WinFormsField NDecName = new WinFormsField("N-DEC-NAME", "NDecName");
        public static WinFormsField OUndName = new WinFormsField("O-UND-NAME", "OUndName");
        public static WinFormsField NUndName = new WinFormsField("N-UND-NAME", "NUndName");
        public static WinFormsField ODecCapacity = new WinFormsField("O-DEC-CAPACITY", "ODecCapacity");
        public static WinFormsField NDecCapacity = new WinFormsField("N-DEC-CAPACITY", "NDecCapacity");
        public static WinFormsField OUndCapacity = new WinFormsField("O-UND-CAPACITY", "OUndCapacity");
        public static WinFormsField NUndCapacity = new WinFormsField("N-UND-CAPACITY", "NUndCapacity");
        public static WinFormsField ODecDate = new WinFormsField("O-DEC-DATE", "ODecDate");
        public static WinFormsField NDecDate = new WinFormsField("N-DEC-DATE", "NDecDate");
        public static WinFormsField OUndDate = new WinFormsField("O-UND-DATE", "OUndDate");
        public static WinFormsField NUndDate = new WinFormsField("N-UND-DATE", "NUndDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
