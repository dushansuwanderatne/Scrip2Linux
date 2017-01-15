using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSSCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSSCH01", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField PlanType = new WinFormsField("PLAN-TYPE", "PlanType");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField TaxTypeInd = new WinFormsField("TAX-TYPE-IND", "TaxTypeInd");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField MarketValueInd = new WinFormsField("MARKET-VALUE-IND", "MarketValueInd");
        public static WinFormsField RetirementAge = new WinFormsField("RETIREMENT-AGE", "RetirementAge");
        public static WinFormsField ApprovalFlag = new WinFormsField("APPROVAL-FLAG", "ApprovalFlag");
        public static WinFormsField PhantomOptionInd = new WinFormsField("PHANTOM-OPTION-IND", "PhantomOptionInd");
        public static WinFormsField SingleCertNumber = new WinFormsField("SINGLE-CERT-NUMBER", "SingleCertNumber");
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField AutoPhantomTfrInd = new WinFormsField("AUTO-PHANTOM-TFR-IND", "AutoPhantomTfrInd");
        public static WinFormsField UnapAccountID = new WinFormsField("UNAP-ACCOUNT-ID", "UnapAccountID");
        public static WinFormsField TrusteeAccountID = new WinFormsField("TRUSTEE-ACCOUNT-ID", "TrusteeAccountID");
        public static WinFormsField NilCostOptionInd = new WinFormsField("NIL-COST-OPTION-IND", "NilCostOptionInd");
        public static WinFormsField PoolRegisterCode = new WinFormsField("POOL-REGISTER-CODE", "PoolRegisterCode");
        public static WinFormsField UsingPooledInd = new WinFormsField("USING-POOLED-IND", "UsingPooledInd");
        public static WinFormsField BlkoutPeriodInd = new WinFormsField("BLKOUT-PERIOD-IND", "BlkoutPeriodInd");
        public static WinFormsField CharityInd = new WinFormsField("CHARITY-IND", "CharityInd");
        public static WinFormsField CountryOFTaxation = new WinFormsField("COUNTRY-OF-TAXATION", "CountryOFTaxation");
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField CharityAmount = new WinFormsField("CHARITY-AMOUNT", "CharityAmount");
        public static WinFormsField ForfeitureType = new WinFormsField("FORFEITURE-TYPE", "ForfeitureType");
        public static WinFormsField ONMarketPurchaseInd = new WinFormsField("ON-MARKET-PURCHASE-IND", "ONMarketPurchaseInd");
        public static WinFormsField CharityHolderID = new WinFormsField("CHARITY-HOLDER-ID", "CharityHolderID");
        public static WinFormsField AutoForfeitureInd = new WinFormsField("AUTO-FORFEITURE-IND", "AutoForfeitureInd");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField PendExerLapseDays = new WinFormsField("PEND-EXER-LAPSE-DAYS", "PendExerLapseDays");
        public static WinFormsField EmpTaxResponsibleInd = new WinFormsField("EMP-TAX-RESPONSIBLE-IND", "EmpTaxResponsibleInd");
        public static WinFormsField LimitType = new WinFormsField("LIMIT-TYPE", "LimitType");
        public static WinFormsField ChequeOption = new WinFormsField("CHEQUE-OPTION", "ChequeOption");
        public static WinFormsField EmpTaxRate = new WinFormsField("EMP-TAX-RATE", "EmpTaxRate");
        public static WinFormsField MaxLimitAmount = new WinFormsField("MAX-LIMIT-AMOUNT", "MaxLimitAmount");
        public static WinFormsField AutoRemovalBulkCode = new WinFormsField("AUTO-REMOVAL-BULK-CODE", "AutoRemovalBulkCode");
        public static WinFormsField EmpUseHolderTaxInd = new WinFormsField("EMP-USE-HOLDER-TAX-IND", "EmpUseHolderTaxInd");
        public static WinFormsField MatchingLimitMoney = new WinFormsField("MATCHING-LIMIT-MONEY", "MatchingLimitMoney");
        public static WinFormsField AutoRemovalFromInd = new WinFormsField("AUTO-REMOVAL-FROM-IND", "AutoRemovalFromInd");
        public static WinFormsField MatchingLimitUnits = new WinFormsField("MATCHING-LIMIT-UNITS", "MatchingLimitUnits");
        public static WinFormsField ChequesLastRun = new WinFormsField("CHEQUES-LAST-RUN", "ChequesLastRun");
        public static WinFormsField LvrTaxResponsibleInd = new WinFormsField("LVR-TAX-RESPONSIBLE-IND", "LvrTaxResponsibleInd");
        public static WinFormsField MatchWorkingClass = new WinFormsField("MATCH-WORKING-CLASS", "MatchWorkingClass");
        public static WinFormsField CoyChequeCreationInd = new WinFormsField("COY-CHEQUE-CREATION-IND", "CoyChequeCreationInd");
        public static WinFormsField LvrTaxRate = new WinFormsField("LVR-TAX-RATE", "LvrTaxRate");
        public static WinFormsField MatchingLimitPerFrom = new WinFormsField("MATCHING-LIMIT-PER-FROM", "MatchingLimitPerFrom");
        public static WinFormsField LoanDividendOption = new WinFormsField("LOAN-DIVIDEND-OPTION", "LoanDividendOption");
        public static WinFormsField LvrUseHolderTaxInd = new WinFormsField("LVR-USE-HOLDER-TAX-IND", "LvrUseHolderTaxInd");
        public static WinFormsField MatchingLimitPerTO = new WinFormsField("MATCHING-LIMIT-PER-TO", "MatchingLimitPerTO");
        public static WinFormsField LeavingType = new WinFormsField("LEAVING-TYPE", "LeavingType");
        public static WinFormsField AllowWebTransfersInd = new WinFormsField("ALLOW-WEB-TRANSFERS-IND", "AllowWebTransfersInd");
        public static WinFormsField LapseDays = new WinFormsField("LAPSE-DAYS", "LapseDays");
        public static WinFormsField NewPaymentType = new WinFormsField("NEW-PAYMENT-TYPE", "NewPaymentType");
        public static WinFormsField CompanyPayeeName = new WinFormsField("COMPANY-PAYEE-NAME", "CompanyPayeeName");
        public static WinFormsField ExpiryNoticeINUrrInd = new WinFormsField("EXPIRY-NOTICE-IN-URR-IND", "ExpiryNoticeINUrrInd");
        public static WinFormsField NbrDaysBeforeExpiry = new WinFormsField("NBR-DAYS-BEFORE-EXPIRY", "NbrDaysBeforeExpiry");
        public static WinFormsField ThirdPartyPayeeName = new WinFormsField("THIRD-PARTY-PAYEE-NAME", "ThirdPartyPayeeName");
        public static WinFormsField VestingNoticeINUrrInd = new WinFormsField("VESTING-NOTICE-IN-URR-IND", "VestingNoticeINUrrInd");
        public static WinFormsField NbrDaysBeforeVesting = new WinFormsField("NBR-DAYS-BEFORE-VESTING", "NbrDaysBeforeVesting");
        public static WinFormsField ValidTerms = new WinFormsField("VALID-TERMS", "ValidTerms");
        public static WinFormsField DivTypeRestrictInd = new WinFormsField("DIV-TYPE-RESTRICT-IND", "DivTypeRestrictInd");
        public static WinFormsField FreeFormatLine = new WinFormsField("FREE-FORMAT-LINE", "FreeFormatLine");
        public static WinFormsField DivReinvestmentInd = new WinFormsField("DIV-REINVESTMENT-IND", "DivReinvestmentInd");
        public static WinFormsField LeaverPackInd = new WinFormsField("LEAVER-PACK-IND", "LeaverPackInd");
        public static WinFormsField PlanConcept = new WinFormsField("PLAN-CONCEPT", "PlanConcept");
        public static WinFormsField PlanCategory = new WinFormsField("PLAN-CATEGORY", "PlanCategory");
        public static WinFormsField FromOptionClass = new WinFormsField("FROM-OPTION-CLASS", "FromOptionClass");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
