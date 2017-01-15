using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS01102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS01102", "FormName");
		//Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField OtherTaxCode = new WinFormsField("OTHER-TAX-CODE", "OtherTaxCode");
        public static WinFormsField DeleteInd = new WinFormsField("DELETE-IND", "DeleteInd");
        public static WinFormsField TfnDesc = new WinFormsField("TFN-DESC", "TfnDesc");
        public static WinFormsField HolderExemptInd1 = new WinFormsField("HOLDER-EXEMPT-IND-1", "HolderExemptInd1");
        public static WinFormsField HolderName1 = new WinFormsField("HOLDER-NAME-1", "HolderName1");
        public static WinFormsField AbnDesc = new WinFormsField("ABN-DESC", "AbnDesc");
        public static WinFormsField ExemptionCode1 = new WinFormsField("EXEMPTION-CODE-1", "ExemptionCode1");
        public static WinFormsField DateOFBirth1 = new WinFormsField("DATE-OF-BIRTH-1", "DateOFBirth1");
        public static WinFormsField Tfn1 = new WinFormsField("TFN-1", "Tfn1");
        public static WinFormsField TfnSuffix1 = new WinFormsField("TFN-SUFFIX-1", "TfnSuffix1");
        public static WinFormsField Description1 = new WinFormsField("DESCRIPTION-1", "Description1");
        public static WinFormsField Abn1 = new WinFormsField("ABN-1", "Abn1");
        public static WinFormsField AbnSuffix1 = new WinFormsField("ABN-SUFFIX-1", "AbnSuffix1");
        public static WinFormsField HolderExemptInd2 = new WinFormsField("HOLDER-EXEMPT-IND-2", "HolderExemptInd2");
        public static WinFormsField HolderName2 = new WinFormsField("HOLDER-NAME-2", "HolderName2");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField ExemptionCode2 = new WinFormsField("EXEMPTION-CODE-2", "ExemptionCode2");
        public static WinFormsField DateOFBirth2 = new WinFormsField("DATE-OF-BIRTH-2", "DateOFBirth2");
        public static WinFormsField Tfn2 = new WinFormsField("TFN-2", "Tfn2");
        public static WinFormsField TfnSuffix2 = new WinFormsField("TFN-SUFFIX-2", "TfnSuffix2");
        public static WinFormsField Description2 = new WinFormsField("DESCRIPTION-2", "Description2");
        public static WinFormsField Abn2 = new WinFormsField("ABN-2", "Abn2");
        public static WinFormsField AbnSuffix2 = new WinFormsField("ABN-SUFFIX-2", "AbnSuffix2");
        public static WinFormsField HolderExemptInd3 = new WinFormsField("HOLDER-EXEMPT-IND-3", "HolderExemptInd3");
        public static WinFormsField HolderName3 = new WinFormsField("HOLDER-NAME-3", "HolderName3");
        public static WinFormsField ExemptionCode3 = new WinFormsField("EXEMPTION-CODE-3", "ExemptionCode3");
        public static WinFormsField DateOFBirth3 = new WinFormsField("DATE-OF-BIRTH-3", "DateOFBirth3");
        public static WinFormsField Tfn3 = new WinFormsField("TFN-3", "Tfn3");
        public static WinFormsField TfnSuffix3 = new WinFormsField("TFN-SUFFIX-3", "TfnSuffix3");
        public static WinFormsField Description3 = new WinFormsField("DESCRIPTION-3", "Description3");
        public static WinFormsField Abn3 = new WinFormsField("ABN-3", "Abn3");
        public static WinFormsField AbnSuffix3 = new WinFormsField("ABN-SUFFIX-3", "AbnSuffix3");
        public static WinFormsField HolderExemptInd4 = new WinFormsField("HOLDER-EXEMPT-IND-4", "HolderExemptInd4");
        public static WinFormsField HolderName4 = new WinFormsField("HOLDER-NAME-4", "HolderName4");
        public static WinFormsField ExemptionCode4 = new WinFormsField("EXEMPTION-CODE-4", "ExemptionCode4");
        public static WinFormsField DateOFBirth4 = new WinFormsField("DATE-OF-BIRTH-4", "DateOFBirth4");
        public static WinFormsField Tfn4 = new WinFormsField("TFN-4", "Tfn4");
        public static WinFormsField TfnSuffix4 = new WinFormsField("TFN-SUFFIX-4", "TfnSuffix4");
        public static WinFormsField Description4 = new WinFormsField("DESCRIPTION-4", "Description4");
        public static WinFormsField Abn4 = new WinFormsField("ABN-4", "Abn4");
        public static WinFormsField AbnSuffix4 = new WinFormsField("ABN-SUFFIX-4", "AbnSuffix4");
        public static WinFormsField Warnings = new WinFormsField("WARNINGS", "Warnings");
        public static WinFormsField HolderExemptInd5 = new WinFormsField("HOLDER-EXEMPT-IND-5", "HolderExemptInd5");
        public static WinFormsField HolderName5 = new WinFormsField("HOLDER-NAME-5", "HolderName5");
        public static WinFormsField ExemptionCode5 = new WinFormsField("EXEMPTION-CODE-5", "ExemptionCode5");
        public static WinFormsField DateOFBirth5 = new WinFormsField("DATE-OF-BIRTH-5", "DateOFBirth5");
        public static WinFormsField Tfn5 = new WinFormsField("TFN-5", "Tfn5");
        public static WinFormsField TfnSuffix5 = new WinFormsField("TFN-SUFFIX-5", "TfnSuffix5");
        public static WinFormsField Description5 = new WinFormsField("DESCRIPTION-5", "Description5");
        public static WinFormsField Abn5 = new WinFormsField("ABN-5", "Abn5");
        public static WinFormsField AbnSuffix5 = new WinFormsField("ABN-SUFFIX-5", "AbnSuffix5");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
