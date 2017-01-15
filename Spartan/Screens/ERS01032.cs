using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01032

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01032", "FormName");
		//Fields
        public static WinFormsField PlanCode = new WinFormsField("PLAN-CODE", "PlanCode");
        public static WinFormsField PlanDesc = new WinFormsField("PLAN-DESC", "PlanDesc");
        public static WinFormsField PlanTypeInd = new WinFormsField("PLAN-TYPE-IND", "PlanTypeInd");
        public static WinFormsField Div13aInd = new WinFormsField("DIV13A-IND", "Div13aInd");
        public static WinFormsField FinalSecurity = new WinFormsField("FINAL-SECURITY", "FinalSecurity");
        public static WinFormsField CntryOFTax = new WinFormsField("CNTRY-OF-TAX", "CntryOFTax");
        public static WinFormsField NorTrustInd = new WinFormsField("NOR-TRUST-IND", "NorTrustInd");
        public static WinFormsField MarketValueInd = new WinFormsField("MARKET-VALUE-IND", "MarketValueInd");
        public static WinFormsField CntlAcct = new WinFormsField("CNTL-ACCT", "CntlAcct");
        public static WinFormsField UnawAcct = new WinFormsField("UNAW-ACCT", "UnawAcct");
        public static WinFormsField PaymtOptionInd = new WinFormsField("PAYMT-OPTION-IND", "PaymtOptionInd");
        public static WinFormsField PaymtCreatnInd = new WinFormsField("PAYMT-CREATN-IND", "PaymtCreatnInd");
        public static WinFormsField BlkoutPeriodInd = new WinFormsField("BLKOUT-PERIOD-IND", "BlkoutPeriodInd");
        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField LeaverPackInd = new WinFormsField("LEAVER-PACK-IND", "LeaverPackInd");
        public static WinFormsField ThirdPrtyPayee = new WinFormsField("THIRD-PRTY-PAYEE", "ThirdPrtyPayee");
        public static WinFormsField CoyPayee = new WinFormsField("COY-PAYEE", "CoyPayee");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField TaxTypeInd = new WinFormsField("TAX-TYPE-IND", "TaxTypeInd");
        public static WinFormsField UsePoolInd = new WinFormsField("USE-POOL-IND", "UsePoolInd");
        public static WinFormsField ForfType = new WinFormsField("FORF-TYPE", "ForfType");
        public static WinFormsField AutoForfInd = new WinFormsField("AUTO-FORF-IND", "AutoForfInd");
        public static WinFormsField AutoRemvlBulkCode = new WinFormsField("AUTO-REMVL-BULK-CODE", "AutoRemvlBulkCode");
        public static WinFormsField AutoRemvlFromInd = new WinFormsField("AUTO-REMVL-FROM-IND", "AutoRemvlFromInd");
        public static WinFormsField MatchWorkgCls = new WinFormsField("MATCH-WORKG-CLS", "MatchWorkgCls");
        public static WinFormsField PlanMtchgLimit = new WinFormsField("PLAN-MTCHG-LIMIT", "PlanMtchgLimit");
        public static WinFormsField PlanMtchgLimitPerd = new WinFormsField("PLAN-MTCHG-LIMIT-PERD", "PlanMtchgLimitPerd");
        public static WinFormsField AutoPhntmTransfr = new WinFormsField("AUTO-PHNTM-TRANSFR", "AutoPhntmTransfr");
        public static WinFormsField RetirementAge = new WinFormsField("RETIREMENT-AGE", "RetirementAge");
        public static WinFormsField FromOptionClass = new WinFormsField("FROM-OPTION-CLASS", "FromOptionClass");
        public static WinFormsField VsaXfrJurisdictCode = new WinFormsField("VSA-XFR-JURISDICT-CODE", "VsaXfrJurisdictCode");
        public static WinFormsField SingleCertNbr = new WinFormsField("SINGLE-CERT-NBR", "SingleCertNbr");
        public static WinFormsField DivReinvestInd = new WinFormsField("DIV-REINVEST-IND", "DivReinvestInd");
        public static WinFormsField DivPlanCat = new WinFormsField("DIV-PLAN-CAT", "DivPlanCat");
        public static WinFormsField DivPlanConcept = new WinFormsField("DIV-PLAN-CONCEPT", "DivPlanConcept");
        public static WinFormsField LapseDays = new WinFormsField("LAPSE-DAYS", "LapseDays");
        public static WinFormsField NilCostOptionInd = new WinFormsField("NIL-COST-OPTION-IND", "NilCostOptionInd");
        public static WinFormsField PhantomOptionInd = new WinFormsField("PHANTOM-OPTION-IND", "PhantomOptionInd");
        public static WinFormsField ExpiryNoticeINUrr = new WinFormsField("EXPIRY-NOTICE-IN-URR", "ExpiryNoticeINUrr");
        public static WinFormsField NbrDaysBefExpiry = new WinFormsField("NBR-DAYS-BEF-EXPIRY", "NbrDaysBefExpiry");
        public static WinFormsField VestingNoticeINUrr = new WinFormsField("VESTING-NOTICE-IN-URR", "VestingNoticeINUrr");
        public static WinFormsField NbrDaysBeforeVest = new WinFormsField("NBR-DAYS-BEFORE-VEST", "NbrDaysBeforeVest");
        public static WinFormsField ONMktPurchaseInd = new WinFormsField("ON-MKT-PURCHASE-IND", "ONMktPurchaseInd");
        public static WinFormsField VsaXfrAllowed = new WinFormsField("VSA-XFR-ALLOWED", "VsaXfrAllowed");
        public static WinFormsField VsaJurisdictionCodes = new WinFormsField("VSA-JURISDICTION-CODES", "VsaJurisdictionCodes");
        public static WinFormsField VsaClassCodes = new WinFormsField("VSA-CLASS-CODES", "VsaClassCodes");
        public static WinFormsField LoanLapseExcepts = new WinFormsField("LOAN-LAPSE-EXCEPTS", "LoanLapseExcepts");
        public static WinFormsField LoanLimitMax = new WinFormsField("LOAN-LIMIT-MAX", "LoanLimitMax");
        public static WinFormsField LoanLimitTypeInd = new WinFormsField("LOAN-LIMIT-TYPE-IND", "LoanLimitTypeInd");
        public static WinFormsField LoanPaymntTypes = new WinFormsField("LOAN-PAYMNT-TYPES", "LoanPaymntTypes");
        public static WinFormsField LoanDivOption = new WinFormsField("LOAN-DIV-OPTION", "LoanDivOption");
        public static WinFormsField AllowWebTrfInd = new WinFormsField("ALLOW-WEB-TRF-IND", "AllowWebTrfInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
