using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENTUSA03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENTUSA03", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField WorstCaseInvNbr = new WinFormsField("WORST-CASE-INV-NBR", "WorstCaseInvNbr");
        public static WinFormsField WcaseAccountType = new WinFormsField("WCASE-ACCOUNT-TYPE", "WcaseAccountType");
        public static WinFormsField OrideAccountType = new WinFormsField("ORIDE-ACCOUNT-TYPE", "OrideAccountType");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
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
        public static WinFormsField OrideTaxChapter = new WinFormsField("ORIDE-TAX-CHAPTER", "OrideTaxChapter");
        public static WinFormsField IntermediaryID = new WinFormsField("INTERMEDIARY-ID", "IntermediaryID");
        public static WinFormsField Inv15Chosen = new WinFormsField("INV-1-5-CHOSEN", "Inv15Chosen");
        public static WinFormsField Inv15Max = new WinFormsField("INV-1-5-MAX", "Inv15Max");
        public static WinFormsField JntAccountType = new WinFormsField("JNT-ACCOUNT-TYPE", "JntAccountType");
        public static WinFormsField InvName = new WinFormsField("INV-NAME", "InvName");
        public static WinFormsField InvTinStatus = new WinFormsField("INV-TIN-STATUS", "InvTinStatus");
        public static WinFormsField InvTin = new WinFormsField("INV-TIN", "InvTin");
        public static WinFormsField InvUSTaxCode = new WinFormsField("INV-US-TAX-CODE", "InvUSTaxCode");
        public static WinFormsField InvTinExpiryDate = new WinFormsField("INV-TIN-EXPIRY-DATE", "InvTinExpiryDate");
        public static WinFormsField InvChpt3 = new WinFormsField("INV-CHPT-3", "InvChpt3");
        public static WinFormsField InvChpt4 = new WinFormsField("INV-CHPT-4", "InvChpt4");
        public static WinFormsField InvBirthDate = new WinFormsField("INV-BIRTH-DATE", "InvBirthDate");
        public static WinFormsField InvCountry = new WinFormsField("INV-COUNTRY", "InvCountry");
        public static WinFormsField InvTaxID = new WinFormsField("INV-TAX-ID", "InvTaxID");
        public static WinFormsField InvAddress1 = new WinFormsField("INV-ADDRESS1", "InvAddress1");
        public static WinFormsField InvAddress2 = new WinFormsField("INV-ADDRESS2", "InvAddress2");
        public static WinFormsField InvGiinP1 = new WinFormsField("INV-GIIN-P1", "InvGiinP1");
        public static WinFormsField InvGiinP2 = new WinFormsField("INV-GIIN-P2", "InvGiinP2");
        public static WinFormsField InvGiinP3 = new WinFormsField("INV-GIIN-P3", "InvGiinP3");
        public static WinFormsField InvGiinP4 = new WinFormsField("INV-GIIN-P4", "InvGiinP4");
        public static WinFormsField InvGiinException = new WinFormsField("INV-GIIN-EXCEPTION", "InvGiinException");
        public static WinFormsField ConBenLit = new WinFormsField("CON-BEN-LIT", "ConBenLit");
        public static WinFormsField ConBenCount = new WinFormsField("CON-BEN-COUNT", "ConBenCount");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SysValueStatus = new WinFormsField("SYS-VALUE-STATUS", "SysValueStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
