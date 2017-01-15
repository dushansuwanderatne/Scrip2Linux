using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01005", "FormName");
		//Fields
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField ApprovalFlag = new WinFormsField("APPROVAL-FLAG", "ApprovalFlag");
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField MarketValueInd = new WinFormsField("MARKET-VALUE-IND", "MarketValueInd");
        public static WinFormsField CountryOFTaxation = new WinFormsField("COUNTRY-OF-TAXATION", "CountryOFTaxation");
        public static WinFormsField NilCostOptionInd = new WinFormsField("NIL-COST-OPTION-IND", "NilCostOptionInd");
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField PhantomOptionInd = new WinFormsField("PHANTOM-OPTION-IND", "PhantomOptionInd");
        public static WinFormsField ONMktPurchInd = new WinFormsField("ON-MKT-PURCH-IND", "ONMktPurchInd");
        public static WinFormsField TrusteeAccountID = new WinFormsField("TRUSTEE-ACCOUNT-ID", "TrusteeAccountID");
        public static WinFormsField UnapAccountID = new WinFormsField("UNAP-ACCOUNT-ID", "UnapAccountID");
        public static WinFormsField PaymentOption = new WinFormsField("PAYMENT-OPTION", "PaymentOption");
        public static WinFormsField VsaXferAllowedInd = new WinFormsField("VSA-XFER-ALLOWED-IND", "VsaXferAllowedInd");
        public static WinFormsField PaymentCreationInd = new WinFormsField("PAYMENT-CREATION-IND", "PaymentCreationInd");
        public static WinFormsField BlkoutPeriodInd = new WinFormsField("BLKOUT-PERIOD-IND", "BlkoutPeriodInd");
        public static WinFormsField UseBlkoutCodeInd = new WinFormsField("USE-BLKOUT-CODE-IND", "UseBlkoutCodeInd");
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField AllowWebTrfInd = new WinFormsField("ALLOW-WEB-TRF-IND", "AllowWebTrfInd");
        public static WinFormsField ThirdPartyPayeeName = new WinFormsField("THIRD-PARTY-PAYEE-NAME", "ThirdPartyPayeeName");
        public static WinFormsField LeaverPackInd = new WinFormsField("LEAVER-PACK-IND", "LeaverPackInd");
        public static WinFormsField CompanyPayeeName = new WinFormsField("COMPANY-PAYEE-NAME", "CompanyPayeeName");
        public static WinFormsField ExpiryNoticeINUrr = new WinFormsField("EXPIRY-NOTICE-IN-URR", "ExpiryNoticeINUrr");
        public static WinFormsField FreeFormatLine = new WinFormsField("FREE-FORMAT-LINE", "FreeFormatLine");
        public static WinFormsField NbrDaysBefExpiry = new WinFormsField("NBR-DAYS-BEF-EXPIRY", "NbrDaysBefExpiry");
        public static WinFormsField VestingNoticeINUrr = new WinFormsField("VESTING-NOTICE-IN-URR", "VestingNoticeINUrr");
        public static WinFormsField NbrDaysBeforeVest = new WinFormsField("NBR-DAYS-BEFORE-VEST", "NbrDaysBeforeVest");
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
