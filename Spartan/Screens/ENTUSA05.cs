using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENTUSA05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENTUSA05", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField WorstCaseInvNbr = new WinFormsField("WORST-CASE-INV-NBR", "WorstCaseInvNbr");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField WcaseAccountType = new WinFormsField("WCASE-ACCOUNT-TYPE", "WcaseAccountType");
        public static WinFormsField OrideAccountType = new WinFormsField("ORIDE-ACCOUNT-TYPE", "OrideAccountType");
        public static WinFormsField WcasePreExisting = new WinFormsField("WCASE-PRE-EXISTING", "WcasePreExisting");
        public static WinFormsField OridePreExisting = new WinFormsField("ORIDE-PRE-EXISTING", "OridePreExisting");
        public static WinFormsField WcaseTinStatus = new WinFormsField("WCASE-TIN-STATUS", "WcaseTinStatus");
        public static WinFormsField OrideTinStatus = new WinFormsField("ORIDE-TIN-STATUS", "OrideTinStatus");
        public static WinFormsField WcaseUSIndicia = new WinFormsField("WCASE-US-INDICIA", "WcaseUSIndicia");
        public static WinFormsField WcaseUSTaxCode = new WinFormsField("WCASE-US-TAX-CODE", "WcaseUSTaxCode");
        public static WinFormsField OrideUSTaxCode = new WinFormsField("ORIDE-US-TAX-CODE", "OrideUSTaxCode");
        public static WinFormsField WcaseChapter3Status = new WinFormsField("WCASE-CHAPTER3-STATUS", "WcaseChapter3Status");
        public static WinFormsField WcaseChapter4Status = new WinFormsField("WCASE-CHAPTER4-STATUS", "WcaseChapter4Status");
        public static WinFormsField CuringStatus = new WinFormsField("CURING-STATUS", "CuringStatus");
        public static WinFormsField WcaseTaxChapter = new WinFormsField("WCASE-TAX-CHAPTER", "WcaseTaxChapter");
        public static WinFormsField OrideTaxType = new WinFormsField("ORIDE-TAX-TYPE", "OrideTaxType");
        public static WinFormsField IntermediaryID = new WinFormsField("INTERMEDIARY-ID", "IntermediaryID");
        public static WinFormsField Inv15Chosen = new WinFormsField("INV-1-5-CHOSEN", "Inv15Chosen");
        public static WinFormsField Inv15Max = new WinFormsField("INV-1-5-MAX", "Inv15Max");
        public static WinFormsField InvName = new WinFormsField("INV-NAME", "InvName");
        public static WinFormsField WorstCaseInvInd = new WinFormsField("WORST-CASE-INV-IND", "WorstCaseInvInd");
        public static WinFormsField InvType = new WinFormsField("INV-TYPE", "InvType");
        public static WinFormsField InvTinStatus = new WinFormsField("INV-TIN-STATUS", "InvTinStatus");
        public static WinFormsField InvChpt3 = new WinFormsField("INV-CHPT-3", "InvChpt3");
        public static WinFormsField InvChpt4 = new WinFormsField("INV-CHPT-4", "InvChpt4");
        public static WinFormsField InvW8Exp = new WinFormsField("INV-W8-EXP", "InvW8Exp");
        public static WinFormsField InvNumCntrols = new WinFormsField("INV-NUM-CNTROLS", "InvNumCntrols");
        public static WinFormsField CntType = new WinFormsField("CNT-TYPE", "CntType");
        public static WinFormsField Cnt110Chosen = new WinFormsField("CNT-1-10-CHOSEN", "Cnt110Chosen");
        public static WinFormsField Cnt110Max = new WinFormsField("CNT-1-10-MAX", "Cnt110Max");
        public static WinFormsField CntName = new WinFormsField("CNT-NAME", "CntName");
        public static WinFormsField CntAddressLine = new WinFormsField("CNT-ADDRESS-LINE", "CntAddressLine");
        public static WinFormsField CntPostcode = new WinFormsField("CNT-POSTCODE", "CntPostcode");
        public static WinFormsField CntCountry = new WinFormsField("CNT-COUNTRY", "CntCountry");
        public static WinFormsField CntCitizenship = new WinFormsField("CNT-CITIZENSHIP", "CntCitizenship");
        public static WinFormsField CntDobIncorp = new WinFormsField("CNT-DOB-INCORP", "CntDobIncorp");
        public static WinFormsField CntTaxIdentifier = new WinFormsField("CNT-TAX-IDENTIFIER", "CntTaxIdentifier");
        public static WinFormsField CntTin = new WinFormsField("CNT-TIN", "CntTin");
        public static WinFormsField CntTinStatus = new WinFormsField("CNT-TIN-STATUS", "CntTinStatus");
        public static WinFormsField CntChpt3 = new WinFormsField("CNT-CHPT-3", "CntChpt3");
        public static WinFormsField CntChpt4 = new WinFormsField("CNT-CHPT-4", "CntChpt4");
        public static WinFormsField CntUSTaxCode = new WinFormsField("CNT-US-TAX-CODE", "CntUSTaxCode");
        public static WinFormsField CntW8ExpDate = new WinFormsField("CNT-W8-EXP-DATE", "CntW8ExpDate");
        public static WinFormsField CntGiinP1 = new WinFormsField("CNT-GIIN-P1", "CntGiinP1");
        public static WinFormsField CntGiinP2 = new WinFormsField("CNT-GIIN-P2", "CntGiinP2");
        public static WinFormsField CntGiinP3 = new WinFormsField("CNT-GIIN-P3", "CntGiinP3");
        public static WinFormsField CntGiinP4 = new WinFormsField("CNT-GIIN-P4", "CntGiinP4");
        public static WinFormsField CntGiinException = new WinFormsField("CNT-GIIN-EXCEPTION", "CntGiinException");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SysValueStatus = new WinFormsField("SYS-VALUE-STATUS", "SysValueStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
