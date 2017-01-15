using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01003", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ApprovalFlag = new WinFormsField("APPROVAL-FLAG", "ApprovalFlag");
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField MarketValueInd = new WinFormsField("MARKET-VALUE-IND", "MarketValueInd");
        public static WinFormsField CountryOFTaxation = new WinFormsField("COUNTRY-OF-TAXATION", "CountryOFTaxation");
        public static WinFormsField TaxTypeInd = new WinFormsField("TAX-TYPE-IND", "TaxTypeInd");
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField SingleCert = new WinFormsField("SINGLE-CERT", "SingleCert");
        public static WinFormsField TrusteeAccountID = new WinFormsField("TRUSTEE-ACCOUNT-ID", "TrusteeAccountID");
        public static WinFormsField UsingPooledInd = new WinFormsField("USING-POOLED-IND", "UsingPooledInd");
        public static WinFormsField UnapAccountID = new WinFormsField("UNAP-ACCOUNT-ID", "UnapAccountID");
        public static WinFormsField PoolRegister = new WinFormsField("POOL-REGISTER", "PoolRegister");
        public static WinFormsField VsaXferJuriCode = new WinFormsField("VSA-XFER-JURI-CODE", "VsaXferJuriCode");
        public static WinFormsField PaymentOption = new WinFormsField("PAYMENT-OPTION", "PaymentOption");
        public static WinFormsField ForfeitureType = new WinFormsField("FORFEITURE-TYPE", "ForfeitureType");
        public static WinFormsField PaymentCreationInd = new WinFormsField("PAYMENT-CREATION-IND", "PaymentCreationInd");
        public static WinFormsField AutoForfeit = new WinFormsField("AUTO-FORFEIT", "AutoForfeit");
        public static WinFormsField LapseDays = new WinFormsField("LAPSE-DAYS", "LapseDays");
        public static WinFormsField AutoRemBulkCode = new WinFormsField("AUTO-REM-BULK-CODE", "AutoRemBulkCode");
        public static WinFormsField BlkoutPeriodInd = new WinFormsField("BLKOUT-PERIOD-IND", "BlkoutPeriodInd");
        public static WinFormsField AutoRemovalFromInd = new WinFormsField("AUTO-REMOVAL-FROM-IND", "AutoRemovalFromInd");
        public static WinFormsField UseBlkoutCodeInd = new WinFormsField("USE-BLKOUT-CODE-IND", "UseBlkoutCodeInd");
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField AutoPhantomTrfInd = new WinFormsField("AUTO-PHANTOM-TRF-IND", "AutoPhantomTrfInd");
        public static WinFormsField MatchWorkingClass = new WinFormsField("MATCH-WORKING-CLASS", "MatchWorkingClass");
        public static WinFormsField MatchingLimitMoney = new WinFormsField("MATCHING-LIMIT-MONEY", "MatchingLimitMoney");
        public static WinFormsField MatchingLimitUnits = new WinFormsField("MATCHING-LIMIT-UNITS", "MatchingLimitUnits");
        public static WinFormsField AllowWebTrfInd = new WinFormsField("ALLOW-WEB-TRF-IND", "AllowWebTrfInd");
        public static WinFormsField MatchLimitPerFrom = new WinFormsField("MATCH-LIMIT-PER-FROM", "MatchLimitPerFrom");
        public static WinFormsField MatchLimitPerTO = new WinFormsField("MATCH-LIMIT-PER-TO", "MatchLimitPerTO");
        public static WinFormsField FromOptionClass = new WinFormsField("FROM-OPTION-CLASS", "FromOptionClass");
        public static WinFormsField DivReinvestment = new WinFormsField("DIV-REINVESTMENT", "DivReinvestment");
        public static WinFormsField ThirdPartyPayeeName = new WinFormsField("THIRD-PARTY-PAYEE-NAME", "ThirdPartyPayeeName");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField CompanyPayeeName = new WinFormsField("COMPANY-PAYEE-NAME", "CompanyPayeeName");
        public static WinFormsField FreeFormatLine = new WinFormsField("FREE-FORMAT-LINE", "FreeFormatLine");
        public static WinFormsField LeaverPackInd = new WinFormsField("LEAVER-PACK-IND", "LeaverPackInd");
        public static WinFormsField RetirementAge = new WinFormsField("RETIREMENT-AGE", "RetirementAge");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
